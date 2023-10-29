using MessengerAPI;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace MessengerAPITests
{
    public class TwilioTests
    {
        private TwilioGateway gateway;

        [SetUp]
        public void Setup()
        {
            gateway = new TwilioGateway(Credentials.TwilioAccountSid, Credentials.TwilioAuthToken);
        }

        [Test]
        public void TwilioSentSMS()
        {
            SMSSendParams smsParams = new(Credentials.TwilioPhoneNumberFrom, Credentials.TwilioPhoneNumberTo, "Testing message");

            var res = gateway.Send(smsParams);
            MessageResource messageResource;
            do
            {
                Thread.Sleep(5000);
                messageResource = MessageResource.Fetch(res.MessageID);
                Assert.That(messageResource.Status, Is.Not.EqualTo(MessageResource.StatusEnum.Failed));
            } while (messageResource.Status != MessageResource.StatusEnum.Sent && messageResource.Status != MessageResource.StatusEnum.Delivered);
            
            Console.WriteLine(messageResource.Status);
        }
    }
}