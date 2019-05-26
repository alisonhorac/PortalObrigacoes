using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
using Twilio.Rest.Api.V2010.Account;

namespace AHAS.PO.INFRA.CROSS.IDENTITY.External.TwilioSms
{
    public interface ITwilioSms
    {
        Task SendMessageAsync(IdentityMessage message);
    }
}
