using System.Threading.Tasks;
using AHAS.PO.INFRA.CROSS.IDENTITY.External.TwilioSms;
using AHAS.PO.INFRA.CROSS.IDENTITY.Intefaces.Service;
using Microsoft.AspNet.Identity;

namespace AHAS.PO.INFRA.CROSS.IDENTITY.Services
{
    public class SmsService : ISmsService
    {
        private readonly ITwilioSms _twilioSms;

        public SmsService(ITwilioSms twilioSms)
        {
            _twilioSms = twilioSms;
        }

        public async Task SendAsync(IdentityMessage message)
        {
            await _twilioSms.SendMessageAsync(message);
        }
    }
}