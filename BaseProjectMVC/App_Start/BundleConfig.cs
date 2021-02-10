using System.Web.Optimization;

namespace IdentitySample
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //allow CDN in BundleConfig
            bundles.UseCdn = true;


            //
            //Bundle templates
            //

            //css
            bundles.Add(new StyleBundle("~/Content/css").Include(
                        //"https://fonts.googleapis.com/css?family=Roboto:100,100italic,300,300italic,400,400italic,500,500italic,700,700italic,900,900italic",
                        //"https://fonts.googleapis.com/icon?family=Material+Icons",
                        "~/Assets/plugins/jquery-ui/themes/base/minified/jquery-ui.min.css",
                        "~/Assets/plugins/bootstrap/css/bootstrap.min.css",
                        "~/Assets/plugins/font-awesome/css/font-awesome.min.css",
                        "~/Assets/css/animate.min.css",
                        "~/Assets/css/style.min.css",
                        "~/Assets/css/style-responsive.min.css",
                        "~/Assets/css/theme/default.css"));

            bundles.Add(new StyleBundle("~/Content/css/PageLevelCss").Include(
                        "~/Assets/plugins/jquery-jvectormap/jquery-jvectormap.css",
                        "~/Assets/plugins/bootstrap-datepicker/css/bootstrap-datepicker.min.css",
                        "~/Assets/plugins/gritter/css/jquery.gritter.css"));

            bundles.Add(new StyleBundle("~/Content/js/pace").Include(
                        "~/Assets/plugins/pace/pace.min.js"));



            //js
            bundles.Add(new ScriptBundle("~/Content/js").Include(
                        "~/Assets/plugins/jquery/jquery-1.9.1.min.js",
                        "~/Assets/plugins/jquery/jquery-migrate-1.1.0.min.js",
                        "~/Assets/plugins/jquery-ui/ui/minified/jquery-ui.min.js",
                        "~/Assets/plugins/bootstrap/js/bootstrap.min.js",
                        "~/Assets/plugins/slimscroll/jquery.slimscroll.min.js",
                        "~/Assets/plugins/jquery-cookie/jquery.cookie.js"));

            bundles.Add(new ScriptBundle("~/Content/js/PageLevelJs").Include(
                        "~/Assets/plugins/gritter/js/jquery.gritter.js",
                        "~/Assets/plugins/flot/jquery.flot.min.js",
                        "~/Assets/plugins/flot/jquery.flot.time.min.js",
                        "~/Assets/plugins/flot/jquery.flot.resize.min.js",
                        "~/Assets/plugins/flot/jquery.flot.pie.min.js",
                        "~/Assets/plugins/sparkline/jquery.sparkline.js",
                        "~/Assets/plugins/jquery-jvectormap/jquery-jvectormap.min.js",
                        "~/Assets/plugins/jquery-jvectormap/jquery-jvectormap-world-mill-en.js",
                        "~/Assets/plugins/bootstrap-datepicker/js/bootstrap-datepicker.js",
                        "~/Assets/js/dashboard.js",
                        "~/Assets/js/apps.js"));
        }
    }
}
