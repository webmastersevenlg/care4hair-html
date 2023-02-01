using System.Text.RegularExpressions;

namespace BaseProject_7_0.Tools
{
    public static class StringProcessing
    {
        public static string RemoveAccent(this string txt)
        {
            byte[] bytes = System.Text.Encoding.GetEncoding("Cyrillic").GetBytes(txt);
            return System.Text.Encoding.ASCII.GetString(bytes);
        }

        public static string Slugify(this string phrase)
        {
            string str = phrase.RemoveAccent().ToLower();
            str = System.Text.RegularExpressions.Regex.Replace(str, @"[^a-z0-9\s-]", ""); // Remove all non valid chars          
            str = System.Text.RegularExpressions.Regex.Replace(str, @"\s+", " ").Trim(); // convert multiple spaces into one space  
            str = System.Text.RegularExpressions.Regex.Replace(str, @"\s", "-"); // //Replace spaces by dashes
            return str;
        }

        public static bool ContainsHtml(string input)
        {
            if (input != null)
            {
                Regex containsHtmlRegex = new Regex(@"<\s*([^ >]+)[^>]*>.*?<\s*/\s*\1\s*>");
                bool containsHtml = containsHtmlRegex.IsMatch(input);
                return containsHtml;
            }
            else
            {
                return false;
            }
        }

        public static bool ContainsLink(string input)
        {

            if (input != null)
            {
                Uri uriResult;
                bool result = (Uri.TryCreate(input, UriKind.Absolute, out uriResult)
                    && uriResult.Scheme == Uri.UriSchemeHttp) || input.ToLower().Contains("http");

                return result;
            }
            else
            {
                return false;
            }
        }
    }
}