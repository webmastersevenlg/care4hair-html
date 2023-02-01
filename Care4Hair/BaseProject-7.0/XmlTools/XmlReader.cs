using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace BaseProject_7_0.XmlTools
{
    public partial class XmlReader
    {
        public static IWebHostEnvironment WebHostEnvironment;

        public static T GetElementByFileNameAttributeNameAndAttributeValue<T>(string xmlEntityFile, string attributeName, string attributeValue) where T : class, new()
        {
            string contentRootPath = WebHostEnvironment.ContentRootPath;
            string absolutePath = contentRootPath + xmlEntityFile.Replace("/", "\\").Replace("~", "");
            XDocument doc = XDocument.Load(absolutePath);
            XElement element = doc.Root.Elements(typeof(T).Name).Where(e => e.Attribute(attributeName.ToLower()).Value.ToLower() == attributeValue.ToLower()).FirstOrDefault();
            var Object = new T();
            if (element != null)
            {
                Object = XmlParser.ParseObject<T>(element, Object);
            }
            return Object;
        }

        public static ICollection<T> GetElementsByFileNameAttributeNameAndAttributeValue<T>(string xmlEntityFile, string attributeName, string attributeValue) where T : class, new()
        {
            string contentRootPath = WebHostEnvironment.ContentRootPath;
            string absolutePath = contentRootPath + xmlEntityFile.Replace("/", "\\").Replace("~", "");
            XDocument doc = XDocument.Load(absolutePath);
            ICollection<XElement> elements = doc.Root.Elements(typeof(T).Name).Where(e => e.Attribute(attributeName.ToLower()).Value.ToLower() == attributeValue.ToLower()).ToArray();
            ICollection<T> objects = new List<T>();
            foreach (var element in elements)
            {
                if (element != null)
                {
                    objects.Add(XmlParser.ParseObject<T>(element, new T()));
                }      
            }
            return objects;
        }

        public static ICollection<T> GetElementsByFileNameAndSubElementAttributeValue<T>(string xmlEntityFile, string subElementName, string attributeName, string attributeValue) where T : class, new()
        {
            string contentRootPath = WebHostEnvironment.ContentRootPath;
            string absolutePath = contentRootPath + xmlEntityFile.Replace("/", "\\").Replace("~", "");
            XDocument doc = XDocument.Load(absolutePath);
            ICollection<XElement> elements = doc.Root.Elements(typeof(T).Name).Where(e => e.Elements().Any(sube=>sube.Name==subElementName && sube.Attribute(attributeName).Value.ToLower() == attributeValue.ToLower())).ToArray();
            ICollection<T> objects = new List<T>();
            foreach (var element in elements)
            {
                if (element != null)
                {
                    objects.Add(XmlParser.ParseObject<T>(element, new T()));
                }
            }
            return objects;
        }

        public static ICollection<T> GetAllElementsByFileName<T>(string xmlEntityFile) where T : class, new()
        {
            string contentRootPath = WebHostEnvironment.ContentRootPath;
            string absolutePath = contentRootPath + xmlEntityFile.Replace("/", "\\").Replace("~", "");
            XDocument doc = XDocument.Load(absolutePath);
            ICollection<XElement> elements = doc.Root.Elements(typeof(T).Name).ToArray();
            ICollection<T> objects = new List<T>();
            foreach (var element in elements)
            {
                if (element != null)
                {
                    objects.Add(XmlParser.ParseObject<T>(element, new T()));
                }
            }
            return objects;
        }

        public static ICollection<T> GetElementsByFileName_SubGroupName_SubGroupElementName_Attribute_and_Value<T>(string xmlEntityFile, string subGroupName, string subGroupElementName, string attributeName, string attributeValue) where T : class, new()
        {
            string contentRootPath = WebHostEnvironment.ContentRootPath;
            string absolutePath = contentRootPath + xmlEntityFile.Replace("/", "\\").Replace("~", "");
            XDocument doc = XDocument.Load(absolutePath);
            ICollection<XElement> elements = doc.Root.Elements(typeof(T).Name)
                                            .Where(e => e.Elements().Any(subgroup => subgroup.Name == subGroupName 
                                                        && subgroup.Elements().Any(sge=>sge.Name==subGroupElementName 
                                                                                      && sge.Attribute(attributeName).Value.ToLower() == attributeValue.ToLower()))).ToArray();
            ICollection<T> objects = new List<T>();
            foreach (var element in elements)
            {
                if (element != null)
                {
                    objects.Add(XmlParser.ParseObject<T>(element, new T()));
                }
            }
            return objects;
        }

        public static string[] GetEachAttributeValueByFileNameAndAttributeName(string xmlEntityFile, string attributeName) 
        {
            string contentRootPath = WebHostEnvironment.ContentRootPath;
            string absolutePath = contentRootPath + xmlEntityFile.Replace("/", "\\").Replace("~","");
            XDocument doc = XDocument.Load(absolutePath);
            ICollection<XElement> elements = doc.Root.Elements().ToArray();
            string[] list = doc.Root.Elements().Select(str => str.Attribute(attributeName).Value).ToArray();
            return list.ToArray();
        }
    }
}