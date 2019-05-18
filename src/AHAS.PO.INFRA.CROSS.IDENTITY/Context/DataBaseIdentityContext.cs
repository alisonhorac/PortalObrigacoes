using AHAS.PO.INFRA.CROSS.IDENTITY.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace AHAS.PO.INFRA.CROSS.IDENTITY.Context
{
    public class DataBaseIdentityContext : IdentityDbContext<ApplicationUser>, IDisposable
    {
        public DataBaseIdentityContext() : base("name=DataBaseConnection", throwIfV1Schema: false)
        {
        }

        public static DataBaseIdentityContext Create()
        {
            return new DataBaseIdentityContext();
        }
    }
}
