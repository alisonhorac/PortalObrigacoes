﻿using System.Web.Optimization;

namespace AHAS.PO.UI.SITE.App_Start.Bundles
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

        public static void LoadPage(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/content/css/pageload").Include("~/Content/css/shared/load/page.load.css"));
        }

        public static void Theme(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/content/css/theme").Include("~/Content/css/theme/theme.css"));
        }

        public static void TwitterBootstrap(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/cdn/css/twitter-bootstrap", "https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/2.3.2/css/bootstrap.min.css"));
        }

        public static void TwitterBootstrapNew(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/cdn/css/twitter-bootstrap-new", "https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/css/bootstrap.min.css"));
        }

        public static void FontAwersomeOld(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/cdn/css/font-awesome-old", "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/3.0.2/css/font-awesome.min.css"));
        }

        //Utilizado no calendário
        public static void JqueryUI(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/cdn/css/jquery-ui", "https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css"));
        }

        //Utilizado no calendário com range
        public static void DateRangePicker(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/cdn/css/daterangepicker", "https://cdn.jsdelivr.net/npm/daterangepicker/daterangepicker.css"));
        }

        public static void SweetAlert(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/cdn/css/sweetalert", "https://cdnjs.cloudflare.com/ajax/libs/bootstrap-sweetalert/1.0.1/sweetalert.min.css"));
        }
    }
}
