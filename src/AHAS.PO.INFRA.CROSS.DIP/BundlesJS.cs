using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Optimization;

namespace AHAS.PO.INFRA.CROSS.DIP
{
    public static class BundlesJS
    {
        
        
        public static void JquerySlim(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/cdn/js/jquery-slim", "https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.slim.min.js"));
        }

        public static void Jquery(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/cdn/js/jquery", "https://cdnjs.cloudflare.com/ajax/libs/jquery/1.12.4/jquery.min.js"));
        }

        public static void JqueryDataTable(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/content/js/jquery-dataTables").Include("~/Content/scripts/feriado/jquery.dataTables.js"));
        }

        public static void TwitterBootstrap(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/cdn/js/twitter-bootstrap", "https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/2.3.2/js/bootstrap.min.js"));
        }
    }
}
