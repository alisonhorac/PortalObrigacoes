using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAS.PO.INFRA.CROSS.IDENTITY.External.SendGridEmail
{
    public interface ISendGridEmail
    {
        Task SendGridAsync(IdentityMessage message);
    }
}
