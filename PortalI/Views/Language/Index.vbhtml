@ModelType IPagedList(Of PortalI.Language)

@Code
    ViewData("Title") = "Language Authority"
End Code

<h2>@ViewData("Title")</h2>

@Html.Partial("Elements/_Search", Model)

@Html.Partial("_Languages", Model)


