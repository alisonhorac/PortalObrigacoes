using System.Data.Entity.Migrations;

namespace AHAS.PO.INFRA.DATA.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Context.DataBaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context.DataBaseContext context)
        {
        }
    }
}
