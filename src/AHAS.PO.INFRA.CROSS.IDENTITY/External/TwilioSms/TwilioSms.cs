using Microsoft.AspNet.Identity;
using System.Configuration;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace AHAS.PO.INFRA.CROSS.IDENTITY.External.TwilioSms
{
    public class TwilioSms : ITwilioSms
    {
        public async Task SendMessageAsync(IdentityMessage message)
        {
            TwilioClient.Init(ConfigurationManager.AppSettings["apisidtwilio"], 
                              ConfigurationManager.AppSettings["apitokentwilio"]);

            await MessageResource.CreateAsync(new PhoneNumber(message.Destination),
                                              from: new PhoneNumber(ConfigurationManager.AppSettings["apiphonetwilio"]),
                                              body: message.Body);
        }
    }
}
