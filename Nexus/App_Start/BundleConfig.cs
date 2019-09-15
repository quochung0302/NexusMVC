using System.Web;
using System.Web.Optimization;

namespace Nexus
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-3.2.1.min.js",
                        "~/Scripts/popper.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/stellar.js",
                        "~/Scripts/jquery.ajaxchimp.min.js",
                        "~/Scripts/mail-script.js",
                        "~/Scripts/gmaps.min.js",
                        "~/Scripts/theme.js",
                        "~/Content/vendors/lightbox/simpleLightbox.min.js",
                        "~/Content/vendors/nice-select/js/jquery.nice-select.min.js",
                        "~/Content/vendors/isotope/imagesloaded.pkgd.min.js",
                        "~/Content/vendors/isotope/isotope-min.js",
                        "~/Content/vendors/owl-carousel/owl.carousel.min.js",
                        "~/Content/vendors/counter-up/jquery.waypoints.min.js",
                        "~/Content/vendors/jquery-ui/jquery-ui.js",
                        "~/Content/vendors/counter-up/jquery.counterup.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.css",
                      "~/Content/vendors/linericon/style.css",
                      "~/Content/css/font-awesome.min.css",
                      "~/Content/vendors/owl-carousel/owl.carousel.min.css",
                      "~/Content/vendors/lightbox/simpleLightbox.css",
                      "~/Content/vendors/nice-select/css/nice-select.css",
                      "~/Content/vendors/animate-css/animate.css",
                      "~/Content/vendors/flaticon/flaticon.css",
                      "~/Content/css/style.css",
                      "~/Content/css/responsive.css"
                      ));
        }
    }
}
