using BaseProject_7_0.App_Resources;
using Newtonsoft.Json;

namespace BaseProject_7_0.Tools
{
    public class ReCaptchaClass
    {
        public static async Task<ReCaptchaClass> Validate(string EncodedResponse)
        {
            var client = new HttpClient();

            string PrivateKey = Settings.ReCaptchaPrivateKey;

            var GoogleReply = await client.GetStringAsync(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", PrivateKey, EncodedResponse));

            var captchaResponse = JsonConvert.DeserializeObject<ReCaptchaClass>(GoogleReply);

            return captchaResponse;
        }

        [JsonProperty("success")]
        public string Success
        {
            get { return m_Success; }
            set { m_Success = value; }
        }

        public string ChallengeTs
        {
            get { return challenge_ts; }
            set { challenge_ts = value; }
        }

        public string Hostname
        {
            get { return hostname; }
            set { hostname = value; }
        }

        public decimal Score
        {
            get { return score; }
            set { score = value; }
        }

        private string challenge_ts;
        private string m_Success;
        private string hostname;
        private decimal score;

        [JsonProperty("error-codes")]
        public List<string> ErrorCodes
        {
            get { return m_ErrorCodes; }
            set { m_ErrorCodes = value; }
        }


        private List<string> m_ErrorCodes;
    }
}