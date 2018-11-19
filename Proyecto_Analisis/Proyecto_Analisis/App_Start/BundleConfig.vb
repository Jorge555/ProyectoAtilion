Imports System.Web.Optimization
Module BundleConfig

    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").
                    Include("~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").
                    Include("~/Scripts/jquery.validate*"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryvalunobtrusive").
                    Include("~/Scripts/jquery.validate.unobtrusive.min.js"))


        'bundles.Add(New StyleBundle("~/Content/css").Include("~/Content/Style.css"))
        bundles.Add(New StyleBundle("~/Content/css").Include("~/Content/bootstrap.min.css"))
        bundles.Add(New StyleBundle("~/Content/css2").Include("~/Content/fontawesome-all.min.css"))
        bundles.Add(New StyleBundle("~/Content/css3").Include("~/Content/2.css"))
        bundles.Add(New StyleBundle("~/Content/css4").Include("~/Content/estilo.css"))

    End Sub


End Module