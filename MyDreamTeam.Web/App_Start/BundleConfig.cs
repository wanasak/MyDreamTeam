using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MyDreamTeam.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bootstrap/js")
                .Include(
                "~/scripts/js/bootstrap.js", 
                "~/scripts/js/site.js")
                );
            bundles.Add(new StyleBundle("~/bootstrap/css")
                .Include(
                "~/content/css/bootstrap.css", 
                //"~/content/css/bootstrap-theme.css",
                "~/content/css/site.css")
                );

            BundleTable.EnableOptimizations = true;
        }
    }
}