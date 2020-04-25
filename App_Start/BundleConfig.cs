using System.Web;
using System.Web.Optimization;

namespace LibraryWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/assets/css").Include(
                    "~/assets/plugins/bootstrap3/css/bootstrap.min.css",
                    "~/assets/plugins/font-awesome/css/font-awesome.min.css",
                    "~/assets/plugins/animate/animate.min.css",
                    "~/assets/css/style.min.css",
                    "~/assets/css/style-responsive.min.css",
                    "~/assets/css/default.css"));

            bundles.Add(new ScriptBundle("~/assets/pace").Include(
                    "~/assets/plugins/pace/pace.min.js"));

            bundles.Add(new ScriptBundle("~/assets/js").Include(
                    "~/assets/plugins/jquery/jquery-3.2.1.min.js",
                    "~/assets/plugins/bootstrap3/js/bootstrap.min.js",
                    "~/assets/plugins/js-cookie/js.cookie.js",
                    "~/assets/plugins/scrollMonitor/scrollMonitor.js",
                    "~/assets/js/apps.min.js"));
        }
    }
}
