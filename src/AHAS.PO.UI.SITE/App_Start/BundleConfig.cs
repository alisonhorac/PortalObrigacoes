using System.Web;
using System.Web.Optimization;

namespace AHAS.PO.UI.SITE
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterLayout(bundles);
            RegisterShared(bundles);
            RegisterAccount(bundles);
        }

        private static void RegisterAccount(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Account/Login").Include(
                "~/Scripts/Account/Login.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Account/Register").Include(
                "~/Scripts/Account/Register.js"));
        }

        private static void RegisterShared(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Shared/_Layout").Include(
                "~/Scripts/Shared/_Layout.js"));
        }

        private static void RegisterLayout(BundleCollection bundles)
        {
            // bootstrap
            bundles.Add(new ScriptBundle("~/Content/bootstrap/js").Include(
                "~/Content/bootstrap/js/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap/css").Include(
                "~/Content/bootstrap/css/bootstrap.min.css"));

            // dist
            bundles.Add(new ScriptBundle("~/Content/dist/js").Include(
                "~/Content/dist/js/app.js"));

            bundles.Add(new StyleBundle("~/Content/dist/css").Include(
                "~/Content/dist/css/admin-lte.min.css"));

            bundles.Add(new StyleBundle("~/Content/dist/css/skins").Include(
                "~/Content/dist/css/skins/_all-skins.min.css"));

            // plugins | jquery
            bundles.Add(new ScriptBundle("~/Content/plugins/jquery/js").Include(
                                         "~/Content/plugins/jquery/js/jQuery-2.1.4.min.js"));

            // plugins | font-awesome
            bundles.Add(new StyleBundle("~/Content/plugins/font-awesome/css").Include(
                                        "~/Content/plugins/font-awesome/css/font-awesome.min.css"));

            // plugins | ionicons
            bundles.Add(new StyleBundle("~/Content/plugins/ionicons/css").Include(
                                        "~/Content/plugins/ionicons/css/ionicons.min.css"));

            // plugins | fastclick
            bundles.Add(new ScriptBundle("~/Content/plugins/fastclick/js").Include(
                                         "~/Content/plugins/fastclick/js/fastclick.min.js"));

            // plugins | slimscroll
            bundles.Add(new ScriptBundle("~/Content/plugins/slimscroll/js").Include(
                                         "~/Content/plugins/slimscroll/js/jquery.slimscroll.min.js"));

            // plugins | checkbox
            bundles.Add(new ScriptBundle("~/Content/plugins/icheck/js").Include(
                                         "~/Content/plugins/icheck/js/icheck.min.js"));

            bundles.Add(new StyleBundle("~/Content/plugins/icheck/css").Include(
                                        "~/Content/plugins/icheck/css/all.css"));

            bundles.Add(new StyleBundle("~/Content/plugins/icheck/css/flat").Include(
                                        "~/Content/plugins/icheck/css/flat/flat.css"));

            bundles.Add(new StyleBundle("~/Content/plugins/icheck/css/sqare/blue").Include(
                                        "~/Content/plugins/icheck/css/sqare/blue.css"));
        }
    }
}
