using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace AHAS.PO.INFRA.CROSS.IDENTITY.Configuration
{
    public class SmsService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            //TO DO:
            return Task.FromResult(0);
        }
    }
}