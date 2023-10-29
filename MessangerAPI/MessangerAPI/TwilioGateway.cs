using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace MessengerAPI
{
    public class TwilioGateway : ISMSPlatform
    {
        public TwilioGateway(string accountSid, string authToken)
        {
            TwilioClient.Init(accountSid, authToken);
        }
        public SMSSendResult Send(SMSSendParams sendParams)
        {
            var messageOptions = new CreateMessageOptions(
                new PhoneNumber(sendParams.PhoneNumberTo));
            messageOptions.From = new PhoneNumber(sendParams.PhoneNumberFrom);
            messageOptions.Body = sendParams.Body;

            var message = MessageResource.Create(messageOptions);

            return new SMSSendResult(message.Sid);
        }
    }
}
