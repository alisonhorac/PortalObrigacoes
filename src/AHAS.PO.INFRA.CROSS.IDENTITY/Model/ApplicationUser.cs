using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AHAS.PO.INFRA.CROSS.IDENTITY.Model
{
    public class ApplicationUser : IdentityUser
    {
        public virtual bool FlagAtivo { get; set; }

        public virtual string PhoneDDI { get; set; }

        public virtual string PhoneDDD { get; set; }

        public virtual string CellPhone { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }
}