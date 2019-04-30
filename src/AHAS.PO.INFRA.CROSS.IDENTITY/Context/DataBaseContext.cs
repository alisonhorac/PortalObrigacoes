using AHAS.PO.INFRA.CROSS.IDENTITY.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace AHAS.PO.INFRA.CROSS.IDENTITY.Context
{
    public class DataBaseContext : IdentityDbContext<ApplicationUser>, IDisposable
    {
        public DataBaseContext() : base("name=DataBaseConnection", throwIfV1Schema: false)
        {
        }

        public static DataBaseContext Create()
        {
            return new DataBaseContext();
        }
    }
}
