using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Optimization;

namespace AHAS.PO.INFRA.CROSS.DIPCFG
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

        //Utilizado no grid
        public static void JqueryDataTable(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/content/js/jquery-dataTables").Include("~/Content/scripts/feriado/jquery.dataTables.js"));
        }

        public static void LoadPage(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/content/js/pageload").Include("~/Content/scripts/shared/load/page.load.js"));
        }

        public static void TwitterBootstrap(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/cdn/js/twitter-bootstrap", "https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/2.3.2/js/bootstrap.min.js"));
        }

        //Utilizado no calendário
        public static void JqueryUI(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/cdn/js/jquery-ui", "https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"));
        }

        //Utilizado no calendário com range
        public static void JQueryV3(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/cdn/js/jquery-v3", "https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js"));
        }

        //Utilizado no calendário com range
        public static void Moment(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/cdn/js/moment", "https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.24.0/moment.min.js"));
        }

        //Utilizado no calendário com range
        public static void DateRangePicker(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/cdn/js/daterangepicker", "https://cdnjs.cloudflare.com/ajax/libs/bootstrap-daterangepicker/3.0.5/daterangepicker.min.js"));
        }
    }
}
