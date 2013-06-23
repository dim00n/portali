@ModelType IPagedList(Of PortalI.MyApplication)

@Code
    ViewData("Title") = "Applications"
    If Model.Count = 0 Then ViewData("id") = 0 Else ViewData("id") = Model.First.AppTypeId
End Code

<h2>@ViewData("Title")</h2>

@Html.Partial("Elements/_Search", Model)

@Html.Partial("_Applications", Model)


