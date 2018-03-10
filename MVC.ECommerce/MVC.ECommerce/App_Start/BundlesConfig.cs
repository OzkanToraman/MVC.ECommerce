using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MVC.ECommerce.App_Start
{
    public class BundlesConfig
    {
        
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region StylesBundle
            
                bundles.Add(new StyleBundle("~/bundlesAdmin/styles")
                        .IncludeDirectory(
                        "~/Content/Admin/css",
                        "*.css",
                        true
                        ));
            

            #endregion
            #region ScriptsBundle

                bundles.Add(new ScriptBundle("~/bundlesAdmin/scripts")
                    .IncludeDirectory(
                    "~/Content/Admin/js",
                    "*.js",
                    true
                    ));
      

            #endregion

            BundleTable.EnableOptimizations = true;
        }
    }
}