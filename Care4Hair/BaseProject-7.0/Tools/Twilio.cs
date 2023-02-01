using System.Net;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using BaseProject_7_0.App_Resources;

namespace BaseProject_7_0.Services.SMSService
{
    public class TwilioService
    {  
        public string SendMessage(string strcell, string strtexto)
        {
            TwilioClient.Init(Settings.GetTwilioAccountSid, Settings.GetTwilioAuthToken);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            strcell = string.IsNullOrEmpty(Settings.GetPhoneErrorNotificationList) ? strcell : Settings.GetPhoneErrorNotificationList;

            var message = MessageResource.Create(
               body: strtexto,
               from: new Twilio.Types.PhoneNumber(Settings.GetTwilioFrom),
               to: new Twilio.Types.PhoneNumber(strcell)
           );

            return message.Status.ToString();
        }   
    } 
}