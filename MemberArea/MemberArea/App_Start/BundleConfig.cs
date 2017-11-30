using System.Web;
using System.Web.Optimization;

namespace MemberArea
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/main").Include(
                      "~/ClientApp/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Styles/bootstrap.min.css",
                      "~/Content/Styles/Site.css"));
        }
    }
}
