using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Optimization;

namespace AHAS.PO.INFRA.CROSS.DIP
{
    public static class BundlesCSS
    {
        public static void BootStrapResponsive(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/cdn/css/bootstrap-responsive", "https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/2.3.2/css/bootstrap-responsive.min.css"));
        }

        public static void FontAwesomeAll(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/cdn/css/font-awesome-all", "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.8.2/css/all.min.css"));
        }

        public static void FontFamilyOpenSans(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/cdn/css/family-opensans", "http://fonts.googleapis.com/css?family=Open+Sans:400italic,600italic,400,600"));
        }

        public static void Theme(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/content/css/theme").Include("~/Content/css/theme/theme.css"));
        }

        public static void TwitterBootstrap(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/cdn/css/twitter-bootstrap", "https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/2.3.2/css/bootstrap.css"));
        }

        public static void TwitterBootstrapNew(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/cdn/css/twitter-bootstrap-new", "https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/css/bootstrap.min.css"));
        }

        public static void FontAwersomeOld(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/cdn/css/font-awesome-old", "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/3.0.2/css/font-awesome.min.css"));
        }
    }
}
