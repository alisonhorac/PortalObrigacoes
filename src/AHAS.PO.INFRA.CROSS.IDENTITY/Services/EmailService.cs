using System.Threading.Tasks;
using AHAS.PO.INFRA.CROSS.IDENTITY.External.SendGridEmail;
using AHAS.PO.INFRA.CROSS.IDENTITY.Intefaces.Service;
using Microsoft.AspNet.Identity;

namespace AHAS.PO.INFRA.CROSS.IDENTITY.Services
{
    public class EmailService : IEmailService
    {
        private readonly ISendGridEmail _sendGridEmail;

        public EmailService(ISendGridEmail sendGridEmail)
        {
            _sendGridEmail = sendGridEmail;
        }

        public Task SendAsync(IdentityMessage message)
        {
            return _sendGridEmail.SendGridAsync(message);
        }
    }
}