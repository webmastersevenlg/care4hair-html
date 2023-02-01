using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using BaseProject_7_0.Models.YoutubeApi;
using Newtonsoft.Json.Linq;

namespace BaseProject_7_0.Models.EntityModels.XmlEntities
{
    public class VideoEntity : BaseXmlEntityModel
    {
        //this fields are for easy navidation to the entityModel that map from this class.
        public VideoPartialViewModel NeverUsedField;
        public VideoIndexablePageViewModel NeverUsedField1;

        public string Title { get; set; }
        public string Language { get; set; }
        public string Src { get; set; }
        public string Thumbnail { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public string Transcription { get; set; }
        public string About { get; set; }
        public string Genre { get; set; }
        public string TargeredKeyword { get; set; }
        public string DateCreated { get; set; }
        public string DatePublished { get; set; }
        public string DateModificate { get; set; }
        public ICollection<ProfessionalEntity> Professionals { get; set; }
        public ICollection<TagEntity> Tags { get; set; }
        public CategoryEntity Category { get; set; }
        public ServiceEntity  Service { get; set; }
        public static string XmlFilePath = "/app_data/videoentities.xml";
        public override string UrlSpanish { get { return Url; } }

        public void GetDataFromYoutube()
        {
            try
            {
                Snippet videoSnippedPart = GetJsonObject<Snippet>("https://www.googleapis.com/youtube/v3/videos?id=" + Src + "&part=snippet&key=AIzaSyCJ1S27OcMvVrvhJJ4BEK2dgkO7TO2SW1w").ToObject<Snippet>();
                ContentDetails videoContentDetailsPart = GetJsonObject<ContentDetails>("https://www.googleapis.com/youtube/v3/videos?id=" + Src + "&part=contentDetails&key=AIzaSyCJ1S27OcMvVrvhJJ4BEK2dgkO7TO2SW1w").ToObject<ContentDetails>();
                Title = videoSnippedPart?.title;
                Thumbnail = videoSnippedPart?.thumbnails.medium.url;
                Duration = videoContentDetailsPart?.duration;
            }
            catch (Exception)
            {
                Title = null;
                Thumbnail = null;
                Duration = null;
            }
        }
        public static JObject GetJsonObject<T>(string url)
        {
            string tymeName = typeof(T).Name;
            string camelCaseTypeName = Char.ToLowerInvariant(tymeName[0]) + tymeName.Substring(1);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    var str = reader.ReadToEnd();
                    JObject rss = JObject.Parse(str);
                    return rss["items"][0][camelCaseTypeName].Value<JObject>();
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    // log errorText
                }
                throw;
            }
        }
    }
}