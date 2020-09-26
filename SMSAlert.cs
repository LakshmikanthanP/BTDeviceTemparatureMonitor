using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace BTDeviceTemparatureMonitor
{
    public static class SMSAlert
    {
        public static void SendSMS( string bodytext, string tomobileno)
        {
            // Find your Account Sid and Token at twilio.com/console
            // DANGER! This is insecure. See http://twil.io/secure
            const string accountSid = "AC0f7da365ff637258608785f631935b52";
            const string authToken = "7659ca715d1beab47089e7285b2e4c37";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: bodytext,
                from: new Twilio.Types.PhoneNumber("+12024106788"),
                to: new Twilio.Types.PhoneNumber(tomobileno)
            );

            Console.WriteLine(message.Sid);
        }
    }
}
