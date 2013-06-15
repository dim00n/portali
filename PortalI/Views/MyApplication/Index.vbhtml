@ModelType IPagedList(Of PortalI.MyApplication)

@Code
    ViewData("Title") = "Applications"
    ViewData("id") = Model.Item(0).AppTypeId
End Code

<h2>@ViewData("Title")</h2>

@Html.Partial("Elements/_Search", Model)

@Html.Partial("_Applications", Model)