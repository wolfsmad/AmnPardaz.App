using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AmnPardaz.App.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Example for bundling and minifying CSS
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/Site.css"));

            // Example for bundling and minifying JavaScript
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //    "~/Scripts/jquery-{version}.js",
            //    "~/Scripts/jquery.validate*",
            //    "~/Scripts/jquery.unobtrusive*"));

            // Add more bundles as needed
        }
    }
}