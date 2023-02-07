using BaseProject_7_0.App_Resources;
using Shyjus.BrowserDetection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Web;

namespace BaseProject_7_0.Models.BaseModels
{
    public class BaseViewModel : BaseModel
    {

        public IBrowserDetector browserDetector;
        public IHttpContextAccessor httpContextAccessor;

        public string ImagesFolderPath;

        public string Id { get; set; }
        public Language CurrentLanguage { get; set; }

        public bool IsMobile { get; set; }
        public string Referrer { get; set; }
        public string VisitSource { get; set; }

        public bool IsLandingPage { get; set; }

        public string Url { get; set; }
        public string UrlSpanish { get; set; }
        public string Name { get; set; }
        public string NameSpanish { get; set; }

        public string ImageName { get; set; }

        public string DbUrl { get; set; }

        public string DbUrlSpanish { get; set; }

        public string GetDbUrl
        {
            get
            {
                return IsEnglish ? DbUrl : DbUrlSpanish;
            }
        }

        public virtual string GetUrl
        {
            get
            {
                return IsEnglish ? Url : UrlSpanish;
            }
        }

        public virtual string GetUrlByLanguage(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? Url : UrlSpanish;
        }

        public virtual string GetName
        {
            get
            {
                return IsEnglish ? Name : NameSpanish;
            }
        }




        public virtual string GetImageById()
        {
            return string.Format("{0}/{1}.jpg", ImagesFolderPath, Id);
        }

        public virtual string GetImage()
        {
            return string.Format("{0}/{1}.jpg", ImagesFolderPath, ImageName);
        }

        public string GetImage(string resolution, string format = null)
        {
            if (string.IsNullOrEmpty(format))
                return string.Format("{0}/{1}/{2}.jpg", ImagesFolderPath, resolution, Id);

            return string.Format("{0}/{1}/{2}.{3}", ImagesFolderPath, resolution, Id, format);
        }

        //this property is virtual because [fullurl] can be different to [url] in some classes, in that case you have to override this method
        public string GetPageUrl()
        {
            return IsEnglish ? GetPageUrl(Language.English.AbbreviatedName) : GetPageUrl(Language.Spanish.AbbreviatedName);
        }

        public string GetPageUrl(bool IsLandingPage)
        {
            if (IsLandingPage)
                return IsEnglish ? GetLandingPageUrl(Language.English.AbbreviatedName) : GetLandingPageUrl(Language.Spanish.AbbreviatedName);
            else
                return IsEnglish ? GetPageUrl(Language.English.AbbreviatedName) : GetPageUrl(Language.Spanish.AbbreviatedName);
        }

        public virtual string GetPageUrl(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "/" + Url : ("/" + Settings.GetSpanishUrl + "/" + UrlSpanish).TrimEnd('/');
        }

        public virtual string GetPageUrl(string abbreviatedLanguage, bool IsLandingPage)
        {
            if (IsLandingPage)
                return GetLandingPageUrl(abbreviatedLanguage);
            else
                return IsEnglishAbbreviation(abbreviatedLanguage) ? "/" + Url : ("/" + Settings.GetSpanishUrl + "/" + UrlSpanish).TrimEnd('/');
        }

        public virtual string GetLandingPageUrl(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "/lp/" + (string.IsNullOrEmpty(Url) ? "specials" : Url) : ("/" + Settings.GetSpanishUrl + "/lp/" + (string.IsNullOrEmpty(UrlSpanish) ? "especiales" : UrlSpanish)).TrimEnd('/');
        }

        public void MapFromDbEntity<DbEntityModel>(DbEntityModel dbEntity) where DbEntityModel : class
        {
            List<PropertyInfo> properties = dbEntity.GetType().GetProperties().Where(p => p.CanRead).ToList();
            foreach (var prop in properties)
            {
                if (prop.GetValue(dbEntity) != null)
                {
                    var thisprop = this.GetType().GetProperties().Where(p => p.CanWrite && p.Name == prop.Name).FirstOrDefault();
                    if (thisprop != null)
                    {
                        //if the property is not a Ienumerable type
                        if (!(prop.PropertyType.IsGenericType || prop.PropertyType.IsGenericTypeDefinition))
                        {
                            if (prop.PropertyType.Name == thisprop.PropertyType.Name)
                            {
                                var value = prop.GetValue(dbEntity);
                                thisprop.SetValue(this, value);
                            }
                        }
                        else
                        {
                            if (prop.PropertyType.GetGenericArguments()[0].Name == thisprop.PropertyType.GetGenericArguments()[0].Name)
                            {
                                var value = prop.GetValue(dbEntity);
                                thisprop.SetValue(this, value);
                            }
                        }
                    }
                }
            }
        }

        public void MapFromXmlEntity<XmlEntity>(XmlEntity xmlEntity) where XmlEntity : class
        {
            List<PropertyInfo> properties = xmlEntity.GetType().GetProperties().Where(p => p.CanWrite).ToList();
            //properties.AddRange(this.GetType().BaseType.GetProperties().Where(p => p.CanWrite).ToList());
            foreach (var prop in properties)
            {
                if (prop.GetValue(xmlEntity) != null)
                {
                    var thisprop = this.GetType().GetProperties().Where(p => p.CanWrite && p.Name == prop.Name).FirstOrDefault();
                    if (thisprop != null)
                    {
                        //if the property is not a Ienumerable type
                        if (!(prop.PropertyType.IsGenericType || prop.PropertyType.IsGenericTypeDefinition))
                        {

                            if (prop.PropertyType.Name == thisprop.PropertyType.Name)
                            {
                                var value = prop.GetValue(xmlEntity);
                                thisprop.SetValue(this, value);
                            }
                            else
                            {
                                if (prop.PropertyType.IsSubclassOf(typeof(BaseXmlEntityModel)) && !thisprop.PropertyType.IsPrimitive)
                                {
                                    {
                                        object newViewModel = thisprop.PropertyType.GetConstructor(Type.EmptyTypes).Invoke(null);
                                        var subentity = prop.PropertyType.GetConstructor(Type.EmptyTypes).Invoke(null);
                                        subentity = prop.GetValue(xmlEntity);
                                        var subViewModelMethod = thisprop.PropertyType.GetMethod("MapFromXmlEntity");
                                        var subViewModelMethodWithArgumentType = subViewModelMethod.MakeGenericMethod(subentity.GetType());
                                        subViewModelMethodWithArgumentType.Invoke(newViewModel, new object[] { subentity });
                                        thisprop.SetValue(this, newViewModel);
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (prop.PropertyType.GetGenericArguments()[0].Name == thisprop.PropertyType.GetGenericArguments()[0].Name)
                            {
                                var value = prop.GetValue(xmlEntity);
                                thisprop.SetValue(this, value);
                            }
                            else
                            {
                                if (prop.PropertyType.GetGenericArguments()[0].IsSubclassOf(typeof(BaseXmlEntityModel)) && !thisprop.PropertyType.GetGenericArguments()[0].IsPrimitive)
                                {
                                    {
                                        var subEntityListType = typeof(List<>);
                                        var subEntityCollectionArgumentType = prop.PropertyType.GetGenericArguments()[0];
                                        var subEntityListTypeWithArgumentType = subEntityListType.MakeGenericType(subEntityCollectionArgumentType);
                                        var subEntityListObject = Activator.CreateInstance(subEntityListTypeWithArgumentType);
                                        subEntityListObject = prop.GetValue(xmlEntity);

                                        var subViewModelListType = typeof(List<>);
                                        var subViewModeCollectionArgumentType = thisprop.PropertyType.GetGenericArguments()[0];
                                        var subViewModelListTypeWithArgumentType = subViewModelListType.MakeGenericType(subViewModeCollectionArgumentType);
                                        var subViewModelListObject = Activator.CreateInstance(subViewModelListTypeWithArgumentType);
                                        thisprop.SetValue(this, subViewModelListObject);

                                        //if error in the next line check that the mapping list is of type list and not of type array
                                        var method = subEntityListTypeWithArgumentType.GetMethod("get_Count");
                                        int count = int.Parse(method.Invoke(subEntityListObject, null).ToString());

                                        for (int i = 0; i < count; i++)
                                        {
                                            var get_Item = subEntityListObject.GetType().GetMethod("get_Item");
                                            var subEntity = get_Item.Invoke(subEntityListObject, new object[] { i });

                                            object newViewModel = subViewModeCollectionArgumentType.GetConstructor(Type.EmptyTypes).Invoke(null);
                                            var subViewModelMethod = subViewModeCollectionArgumentType.GetMethod("MapFromXmlEntity");
                                            var subViewModelMethodWithArgumentType = subViewModelMethod.MakeGenericMethod(subEntity.GetType());
                                            subViewModelMethodWithArgumentType.Invoke(newViewModel, new object[] { subEntity });
                                            subViewModelListTypeWithArgumentType.GetMethod("Add").Invoke(subViewModelListObject, new object[] { newViewModel });
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


        public BaseViewModel()
        {
            CurrentLanguage = IsEnglish ? Language.English : Language.Spanish;
        }

        public BaseViewModel(IHttpContextAccessor _httpContextAccessor, IBrowserDetector _browserDetector)
        {
            httpContextAccessor = _httpContextAccessor;
            browserDetector = _browserDetector;

            CurrentLanguage = IsEnglish ? Language.English : Language.Spanish;
            var path = httpContextAccessor.HttpContext?.Request.Path.ToString();
            IsLandingPage = (path != null && path.Contains("/lp/"));
        }
    }
}