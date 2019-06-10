using System.Collections.Generic;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using AHAS.PO.INFRA.CROSS.DIPCFG;
using Microsoft.Owin;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
[assembly: WebActivator.PostApplicationStartMethod(typeof(AHAS.PO.UI.SITE.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace AHAS.PO.UI.SITE.App_Start
{
    public static class SimpleInjectorInitializer
    {
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            
            InitializeContainer(container);

            container.Register(() => container.IsVerifying ? 
                                                            new OwinContext(new Dictionary<string, object>()).Authentication 
                                                            : HttpContext.Current.GetOwinContext().Authentication, Lifestyle.Scoped);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            container.Verify();
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
     
        private static void InitializeContainer(Container container)
        {
            BootStrapper.RegistrarServicos(container);
        }
    }
}