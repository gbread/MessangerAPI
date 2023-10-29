using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerAPITests
{
    // Could be done via .env or appsettings.
    // Rename CredentialsTemplate to Credentials and fill your credentials
    public class CredentialsTemplate
    {
        public static string TwilioAccountSid => "";
        public static string TwilioAuthToken => "";
        public static string TwilioPhoneNumberFrom => "";
        public static string TwilioPhoneNumberTo => "";
    }
}
