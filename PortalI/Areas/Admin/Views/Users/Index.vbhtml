@ModelType IPagedList(Of PortalI.UserProfile)

@Code
    ViewData("Title") = "Users"
End Code

<h2>@ViewData("Title")</h2>

@Html.Partial("Elements/_Search", Model)

@Html.Partial("_Users", Model)
