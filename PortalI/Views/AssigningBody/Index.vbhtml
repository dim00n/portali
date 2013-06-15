@ModelType IPagedList(Of PortalI.AssigningBody)

@Code
    ViewData("Title") = "Country Authority"
End Code

<h2>@ViewData("Title")</h2>

@Html.Partial("Elements/_Search", Model)

@Html.Partial("_AssigningBodies", Model)