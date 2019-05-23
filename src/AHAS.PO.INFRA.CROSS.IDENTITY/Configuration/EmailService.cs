using System.Configuration;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace AHAS.PO.INFRA.CROSS.IDENTITY.Configuration
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            return SendGridAsync(message);
        }

        private async Task SendGridAsync(IdentityMessage message)
        {
            var emailMessage = new SendGridMessage();
            emailMessage.AddTo(message.Destination);
            emailMessage.From = new EmailAddress("naoresponda@portalobrigacao.com.br", "Portal de Obrigações");
            emailMessage.Subject = message.Subject;
            emailMessage.HtmlContent = message.Body;
            var transportWeb = new SendGridClient(ConfigurationManager.AppSettings["keyAccount"]);
            var result = await transportWeb.SendEmailAsync(emailMessage);
        }
    }
}