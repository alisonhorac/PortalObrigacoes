﻿using AHAS.PO.INFRA.CROSS.DIP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AHAS.PO.UI.SITE.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            RegisterShared(bundles);
            RegisterFeriado(bundles);
            RegisterError(bundles);
            RegisterAccount(bundles);

            BundleTable.EnableOptimizations = true;
        }

        private static void RegisterError(BundleCollection bundles)
        {
            BundlesCSS.TwitterBootstrapNew(bundles);
        }

        private static void RegisterAccount(BundleCollection bundles)
        {
            BundlesJS.JquerySlim(bundles);
        }

        private static void RegisterShared(BundleCollection bundles)
        {
            BundlesCSS.TwitterBootstrap(bundles);
            BundlesCSS.BootStrapResponsive(bundles);
            BundlesCSS.FontAwesomeAll(bundles);
            BundlesCSS.FontFamilyOpenSans(bundles);
            BundlesCSS.Theme(bundles);
            BundlesJS.Jquery(bundles);
            BundlesJS.TwitterBootstrap(bundles);
        }

        private static void RegisterFeriado(BundleCollection bundles)
        {
            BundlesCSS.FontAwersomeOld(bundles);
            BundlesJS.JqueryDataTable(bundles);
        }
    }
}