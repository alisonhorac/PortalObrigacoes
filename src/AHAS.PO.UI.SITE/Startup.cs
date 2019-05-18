using AHAS.PO.UI.SITE;
using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(Startup))]

namespace AHAS.PO.UI.SITE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
