using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerAPI
{
    public struct SMSSendParams
    {
        public string PhoneNumberFrom { get; private set; }
        public string PhoneNumberTo { get; private set; }
        public string Body { get; private set; }

        public SMSSendParams(string phoneNumberFrom, string phoneNumberTo, string body)
        {
            PhoneNumberFrom = phoneNumberFrom;
            PhoneNumberTo = phoneNumberTo;
            Body = body;
        }
    }

    public struct SMSSendResult
    {
        public string MessageID { get; private set; }

        public SMSSendResult(string messageID)
        {
              MessageID = messageID;
        }
    }

    public interface ISMSPlatform: ISendMessagePlatform<SMSSendParams, SMSSendResult>
    {
    }


}
