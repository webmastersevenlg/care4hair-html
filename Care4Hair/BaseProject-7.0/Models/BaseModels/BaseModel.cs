using System.Threading;

namespace BaseProject_7_0.Models.BaseModels
{

    public class BaseModel
    {
        public virtual string XmlPriority { get; set; }

        public bool IsEnglish
        {
            get
            {
                return IsEnglishThread;
            }
        }

        public static bool IsEnglishAbbreviation(string abbreviatedLanguage)
        {
            return Language.English.AbbreviatedName.ToLower() == abbreviatedLanguage.ToLower();
        }

        //static members
        public static bool IsEnglishThread
        {
            get
            {
                return !string.IsNullOrEmpty(GetabbreviatedLanguage) && GetabbreviatedLanguage == "en";
            }
        }

        public static string GetabbreviatedLanguage { get { return Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.ToString(); } }

    }
}