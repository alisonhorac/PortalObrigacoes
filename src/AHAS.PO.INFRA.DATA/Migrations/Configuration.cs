using System.Data.Entity.Migrations;

namespace AHAS.PO.INFRA.DATA.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Context.BDContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context.BDContext context)
        {
        }
    }
}
