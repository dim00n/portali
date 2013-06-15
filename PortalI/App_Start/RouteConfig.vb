Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Public Class RouteConfig
    Public Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

        routes.MapRoute(
            "CountryRoute",
            "Country/{action}/{id}",
            New With {.controller = "AssigningBody", .action = "Index", .id = UrlParameter.Optional})

        routes.MapRoute( _
            name:="Default", _
            url:="{controller}/{action}/{id}", _
            defaults:=New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional} _
        )

        'routes.MapRoute( _
        '    name:="Default1", _
        '    url:="*/{action}/{id}", _
        '    defaults:=New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional} _
        ')

        'catch any request route and handle by the same controller/action
        routes.MapRoute(
            "NonExisting",
            "{path*}",
            New With {.controller = "Home", .action = "Index"}
        )
    End Sub
End Class