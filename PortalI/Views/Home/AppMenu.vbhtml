@ModelType IEnumerable(Of PortalI.MyApplication)

@Code
    ViewData("Title") = "AppMenu"
    Dim typeAuthId As Integer = PortalI.ApplicationType.AppTypes.Authority
    Dim typeAppId As Integer = PortalI.ApplicationType.AppTypes.Application
End Code
@*                <ul id="menu" class="nav nav-pills pull-right">
                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                </ul>
*@
<ul id="categories" class="nav nav-list">
    <li class="nav-header">@Html.ActionLink("Home", "Index", "Home")</li>
    <li class="nav-header">Authorities
    @If (User.IsInRole("Admin")) Then
        @<span class="pull-right">
            <a class="btn btn-mini btn-link" href="@Url.Action("Index", "MyApplication", New With {.appTypeId = typeAuthId})"><i class="icon-pencil"></i></a>
        </span>
    End If
    </li>
    @For Each App As PortalI.MyApplication In Model.Where(Function(x) x.AppType.AppTypeId = PortalI.ApplicationType.AppTypes.Authority)
        @<li>@Html.ActionLink(App.Name,
                "Index", App.Name,
                New With {Key .Id = App.MyApplicationID}, Nothing)
        </li>
    Next App
    <li class="nav-header">Applications
    @If (User.IsInRole("Admin")) Then
        @<span class="pull-right">
            <a class="btn btn-mini btn-link" href="@Url.Action("Index", "MyApplication", New With {.appTypeId = typeAppId})"><i class="icon-pencil"></i></a>
        </span>
    End If
    </li>
    @For Each App As PortalI.MyApplication In Model.Where(Function(x) x.AppType.AppTypeId = PortalI.ApplicationType.AppTypes.Application)
        @<li>@Html.ActionLink(App.Name,
                "Index", App.Name,
                New With {Key .Id = App.MyApplicationID}, Nothing)
        </li>
    Next App
</ul>

