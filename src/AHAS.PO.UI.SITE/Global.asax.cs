﻿using AHAS.PO.SERVICE.APPLICATION.AutoMapper;
using AHAS.PO.UI.SITE.App_Start.Bundles;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AHAS.PO.UI.SITE
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfig.RegisterMappings();
        }
    }
}
