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

            bundles.Add(new StyleBundle("~/bundles/cdn/font-awesome-old", "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/3.0.2/css/font-awesome.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/cdn/jquery", "https://cdnjs.cloudflare.com/ajax/libs/jquery/1.12.4/jquery.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/cdn/twitter-bootstrap", "https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/2.3.2/js/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/content/jquery-dataTables").Include("~/Content/scripts/feriado/jquery.dataTables.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}