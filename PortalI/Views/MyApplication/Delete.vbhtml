@ModelType PortalI.MyApplication

@Code
    ViewData("Title") = "Delete Application"
    ViewData("id") = Model.MyApplicationID
End Code

<h3>@ViewData("Title")</h3>

@Using Html.Bootstrap().Begin(New Alert().Style(AlertColor.Error))
    @Html.Partial("Elements/_ErrorMessage", ViewData)
    @Html.Partial("Elements/_Delete_BackToList", ViewData)
End Using
