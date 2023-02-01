using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;
using System.Linq.Expressions;

namespace BaseProject_7_0.XmlTools
{
    public static partial class XmlParser
    {
        public static T ParseObject<T>(XElement element, T o) where T : class, new()
        {
            if (element.Name == typeof(T).Name)
            {
                if (element.Attribute("type") != null && element.Attribute("type").Value == "ref")
                    element = element.Document.Root.Element("ProjectXmlEntities").Element(element.Attributes().FirstOrDefault(a => a.Name == "group").Value).Elements().FirstOrDefault(e => e.HasAttributes
                            && e.Attributes().Any(a => a.Name == "id")
                            && e.Attribute("id").Value == element.Attribute("id").Value);

                foreach (var prop in typeof(T).GetProperties().Where(p => p.CanWrite))
                {
                    if (prop.GetValue(o) == null)
                    {
                        //if the property is not a Ienumerable type 
                        if (!(prop.PropertyType.IsGenericType || prop.PropertyType.IsGenericTypeDefinition))
                        {
                            string propName = prop.Name;
                            if (element != null)
                            {
                                string value = null;
                                if (element.Attribute(propName.ToLower()) != null)
                                    value = element.Attribute(propName.ToLower()).Value;
                                else if (element.Element(propName) != null)
                                    value = element.Element(propName).Attribute("id").Value;

                                if (prop.PropertyType == typeof(string))
                                {
                                    prop.SetValue(o, value);
                                }
                                else if (prop.PropertyType == typeof(int))
                                {
                                    int parsedValue;
                                    if (Int32.TryParse(value, out parsedValue))
                                        prop.SetValue(o, parsedValue);
                                }
                                else if (prop.PropertyType == typeof(bool))
                                {
                                    bool parsedValue;
                                    if (Boolean.TryParse(value, out parsedValue))
                                        prop.SetValue(o, parsedValue);
                                }
                                else
                                {
                                    XElement subElement = element.Element(prop.Name);
                                    if (subElement != null && subElement.Attribute("id").Value!=null)
                                    {
                                        var x = prop.PropertyType.GetField("XmlFilePath");
                                        var xmlEntityFile = x.GetValue(null);
                                        object subEntity = prop.PropertyType.GetConstructor(Type.EmptyTypes).Invoke(null);
                                        var mi = typeof(XmlReader).GetMethod("GetElementByFileNameAttributeNameAndAttributeValue");
                                        var PropObject = mi.MakeGenericMethod(subEntity.GetType());
                                        object resultSubEntity = PropObject.Invoke(null, new object[] { xmlEntityFile, "id", subElement.Attribute("id").Value });
                                        prop.SetValue(o, resultSubEntity);
                                    }
                                }
                            }
                        }
                        else
                        //if the property is a ienumerable type
                        //Iterating generic types
                        {
                            ParseIenumerableTypeAsPropertyForOfObject(element.Element(prop.Name), o, prop);
                        }
                    }
                }
            }
            return o;
        }

        public static void ParseIenumerableTypeAsPropertyForOfObject(XElement element, object o, System.Reflection.PropertyInfo propertyInfo)
        {
            if (propertyInfo.PropertyType.GetInterfaces().Contains(typeof(System.Collections.IEnumerable)))
            //If this generic type is a collection osea si es una lista
            {
                string propName = propertyInfo.Name;
                var listType = typeof(List<>);
                //Creating a temp List of the same type
                Type CollectionArgumentsType = propertyInfo.PropertyType.GetGenericArguments().Single();
                var constructedListType = listType.MakeGenericType(CollectionArgumentsType);
                var ListInstance = Activator.CreateInstance(constructedListType);

                //setting the ListInstance to the property
                propertyInfo.SetValue(o, ListInstance);

                //checking if the CollectionArgumentsType is a end node type
                //if is a non end node
                if (CollectionArgumentsType.IsPrimitive
                    || CollectionArgumentsType.GetProperties().Count() <= 0
                    || CollectionArgumentsType == typeof(string))
                {
                    if (element != null)
                    {
                        foreach (var subNode in element.Nodes())
                        //Iterating the sub elements of the xml node with the same name of the property name
                        {
                            var subelement = subNode as XElement;

                            #region getting the value of inside each node <node>value</node>
                            string value = null;
                            if (subelement != null
                                && CollectionArgumentsType.Name == subelement.Name.LocalName
                                && !string.IsNullOrEmpty(subelement.Value))
                            {
                                var name = subelement.Name.LocalName;
                                value = subelement.Value;
                                var converter = TypeDescriptor.GetConverter(CollectionArgumentsType);
                                if (converter != null)
                                {
                                    try
                                    {
                                        //Cast ConvertFromString(string text) : object to (T)
                                        var convertedValue = converter.ConvertFromString(value);
                                        //invoking method add of the property in the for add the value to the ListInstance
                                        propertyInfo.PropertyType.GetMethod("Add").Invoke(ListInstance, new object[] { convertedValue });
                                    }
                                    catch (Exception)
                                    {
                                        throw;
                                    }
                                }
                                else
                                {
                                    object subEntity = CollectionArgumentsType.GetConstructor(null).Invoke(null);
                                    var mi = typeof(XmlParser).GetMethod("ParseObject");
                                    var GenericParseObject = mi.MakeGenericMethod(CollectionArgumentsType);
                                    object resultSubEntity = GenericParseObject.Invoke(null, new object[] { subelement, subEntity });
                                    propertyInfo.PropertyType.GetMethod("Add").Invoke(ListInstance, new object[] { resultSubEntity });
                                }
                            }
                            #endregion
                        }
                    }
                }

                if (element != null)
                {
                    foreach (var subNode in element.Nodes())
                    //Iterating the sub elements of the xml node with the same name of the property name
                    {
                        var subelement = subNode as XElement;
                        if (subelement != null && CollectionArgumentsType != null)
                        {
                            var filePathfield = CollectionArgumentsType.GetField("XmlFilePath");
                            if(filePathfield == null)
                            {
                                throw new System.Exception("No se encontro la propiedad 'XmlFilePath'");
                            }
                            //checo si es un subelemento que no tiene otro file separado
                            if (filePathfield.GetValue(null).ToString() == "false")
                            {
                                //solo parseo el elemento y lo anado a la colleccion
                                var methodForParseElement = typeof(XmlParser).GetMethod("ParseObject");
                                try
                                {
                                    var resultSubEntity = Activator.CreateInstance(CollectionArgumentsType);
                                    var GenericParseObject = methodForParseElement.MakeGenericMethod(CollectionArgumentsType);
                                    resultSubEntity = GenericParseObject.Invoke(null, new object[] { subelement, resultSubEntity });
                                    if (resultSubEntity == null)
                                    {
                                        throw new System.Exception("El SubNodo debe tener el mismo nombre de la clase");
                                    }
                                    propertyInfo.PropertyType.GetMethod("Add").Invoke(ListInstance, new object[] { resultSubEntity });
                                }
                                catch (Exception e)
                                {
                                    throw new Exception(element.ToString() + " subnode=  " + subNode.ToString() + ".   ", e);
                                }                                
                            }
                            else
                            {
                                //busco el elemento en un file separado por el id y lo anado a la coleccion
                                var xmlEntityFile = filePathfield.GetValue(null);
                                var methodForGetAndParseElement = typeof(XmlReader).GetMethod("GetElementByFileNameAttributeNameAndAttributeValue");
                                try
                                {
                                    var GenericParseObject = methodForGetAndParseElement.MakeGenericMethod(CollectionArgumentsType);
                                    object resultSubEntity = GenericParseObject.Invoke(null, new object[] { xmlEntityFile, "id", subelement.Attribute("id").Value });
                                    propertyInfo.PropertyType.GetMethod("Add").Invoke(ListInstance, new object[] { resultSubEntity });
                                }
                                catch (Exception e)
                                {
                                    throw new Exception(element.ToString() + " subnode=  " + subNode.ToString() + ".   ", e);
                                }
                            }                          
                        }
                    }
                }
            }
        }

        public static void ParseIenumerableTypeAsPropertyForOfObjectOutOfNodeByAttributeNameAndAttributeValue(XElement element, string attributeName, string attributeValue, object o, System.Reflection.PropertyInfo propertyInfo)
        {
            if (propertyInfo.PropertyType.GetInterfaces().Contains(typeof(System.Collections.IEnumerable)))
            //If this generic type is a collection osea si es una lista
            {
                string propName = propertyInfo.Name;
                var listType = typeof(List<>);
                //Creating a temp List of the same type
                Type CollectionArgumentsType = propertyInfo.PropertyType.GetGenericArguments().Single();

                var constructedListType = listType.MakeGenericType(CollectionArgumentsType);
                var ListInstance = Activator.CreateInstance(constructedListType);
                //setting the ListInstance to the property
                propertyInfo.SetValue(o, ListInstance);

                //checking if the CollectionArgumentsType is a end node type
                //if is a non end node
                if (CollectionArgumentsType.IsPrimitive
                    || CollectionArgumentsType.GetProperties().Count() <= 0
                    || CollectionArgumentsType == typeof(string))
                {
                    if (element != null)
                    {
                        foreach (var subNode in element.Nodes())
                        //Iterating the sub elements of the xml node with the same name of the property name
                        {
                            var subelement = subNode as XElement;

                            #region getting the value of inside each node <node>value</node>
                            string value = null;
                            if (subelement != null
                                && CollectionArgumentsType.Name == subelement.Name.LocalName
                                && !string.IsNullOrEmpty(subelement.Value))
                            {
                                var name = subelement.Name.LocalName;
                                value = subelement.Value;
                                var converter = TypeDescriptor.GetConverter(CollectionArgumentsType);
                                if (converter != null)
                                {
                                    try
                                    {
                                        //Cast ConvertFromString(string text) : object to (T)
                                        var convertedValue = converter.ConvertFromString(value);
                                        //invoking method add of the property in the for add the value to the ListInstance
                                        propertyInfo.PropertyType.GetMethod("Add").Invoke(ListInstance, new object[] { convertedValue });
                                    }
                                    catch (Exception)
                                    {
                                        throw;
                                    }
                                }
                                else
                                {
                                    object subEntity = CollectionArgumentsType.GetConstructor(null).Invoke(null);
                                    var mi = typeof(XmlParser).GetMethod("ParseObject");
                                    var GenericParseObject = mi.MakeGenericMethod(CollectionArgumentsType);
                                    object resultSubEntity = GenericParseObject.Invoke(null, new object[] { subelement, subEntity });
                                    propertyInfo.PropertyType.GetMethod("Add").Invoke(ListInstance, new object[] { resultSubEntity });
                                }
                            }
                            #endregion
                        }
                    }
                }

                if (element != null)
                {
                    foreach (var subNode in element.Nodes())
                    //Iterating the sub elements of the xml node with the same name of the property name
                    {
                        var subelement = subNode as XElement;

                        if (subelement != null)
                        {
                            object subEntity = CollectionArgumentsType.GetConstructor(new Type[] { }).Invoke(new object[] { });
                            var mi = typeof(XmlParser).GetMethod("ParseObject");
                            var GenericParseObject = mi.MakeGenericMethod(CollectionArgumentsType);
                            object resultSubEntity = GenericParseObject.Invoke(null, new object[] { subelement, subEntity });
                            propertyInfo.PropertyType.GetMethod("Add").Invoke(ListInstance, new object[] { resultSubEntity });
                        }
                    }
                }
            }
        }

    
      /// <summary>
        /// Return A List of objects Objects parsed from a group of xml nodes and Filtered By any valid params combination
        /// </summary>
        /// <returns>
        /// ICollection<T>
        ///<returns>

        public static IEnumerable<T> GenericListBuilder<T>(IEnumerable<T> candidates, Dictionary<string, string> filters) where T : class
        {
            var result = candidates;

            ParameterExpression paramExp = Expression.Parameter(typeof(T), "t");
            Expression exp = null;
            foreach (KeyValuePair<string, string> filter in filters)
            {
                var propName = filter.Key;
                var propValue = filter.Value;
                if (exp == null)
                    exp = GetExpression(paramExp, propName, propValue);
                else
                    exp = Expression.AndAlso(exp, GetExpression(paramExp, propName, propValue));
            }

            var whereExpression = Expression.Lambda<Func<T, bool>>(exp, paramExp).Compile();

            result = result.Where(whereExpression);

            return result;
        }

        public static IEnumerable<T> GenericListBuilder<T>(IEnumerable<T> candidates, Dictionary<string, object> filters) where T : class
        {
            var result = candidates;

            foreach (var filter in filters)
            {
                result = result.Where(c => PropertyValueIsEqualOrHasSameId<T>(c, filter.Key, filter.Value)).ToArray();
            }
            return result;
        }

        private static bool PropertyValueIsEqualOrHasSameId<T>(T candidate, string propertyName, object filterValue) where T : class
        {
            bool result = candidate != null;

            var pi = typeof(T).GetProperty(propertyName);

            if (candidate != null
                && filterValue != null
                && pi != null
                && pi.PropertyType.IsAssignableFrom(filterValue.GetType()))
            {
                if (pi.PropertyType.IsPrimitive)
                {
                    result = pi.GetValue(candidate) == filterValue;
                }
                else
                {
                    var idPi = pi.PropertyType.GetProperty("Id");

                    if (idPi != null)
                        result = pi.GetValue(candidate) != null
                            && idPi.GetValue(pi.GetValue(candidate)).Equals(idPi.GetValue(filterValue));
                }
            }
            return result;
        }

        public static IEnumerable<T> GenericListBuilder<T>(IEnumerable<T> candidates, Dictionary<string, IEnumerable<string>> filters) where T : class
        {
            var result = candidates;
            foreach (var filter in filters)
            {
                result = result.Where(c => PropertyHasAllValues<T>(c, filter.Key, filter.Value)).ToList();
            }

            return result;
        }

        private static bool PropertyHasAllValues<T>(T candidate, string propertyName, IEnumerable<string> filterValues) where T : class
        {
            bool result = candidate != null;

            var pi = typeof(T).GetProperty(propertyName);

            if (candidate != null
                && filterValues != null
                && pi != null
                && pi.PropertyType.GetInterfaces().Contains(typeof(System.Collections.IEnumerable)))
            {
                IEnumerable<object> existingObjects = pi.GetValue(candidate) as IEnumerable<object>;
                List<string> existingValues = new List<string>();
                var idPi = pi.PropertyType.GetGenericArguments().Single().GetProperty("Id");
                foreach (var objeto in existingObjects)
                {
                    existingValues.Add(idPi.GetValue(objeto).ToString());
                }


                if (existingValues == null)
                {
                    result = false;
                }
                else
                {
                    for (int i = 0; result && i < filterValues.Count(); i++)
                    {
                        result = existingValues.Contains(filterValues.ElementAt(i));
                    }
                }
            }
            return result;
        }

        private static Expression GetExpression(ParameterExpression paramExp, string propName, string propValue)
        {
            MemberExpression member = Expression.Property(paramExp, propName);
            ConstantExpression constant = Expression.Constant(propValue);
            return Expression.Equal(member, constant);
        }
      }
}