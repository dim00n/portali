@ModelType PortalI.UserProfile

@Code
    ViewData("Title") = "Edit User"
End Code

<h3>@ViewData("Title")</h3>

@Using Html.Bootstrap.Begin(New Form("Edit", "Users").FormMethod(FormMethod.Post).Type(FormType.Horizontal))
    @Html.ValidationSummary(True)
    @Html.AntiForgeryToken()

     @<fieldset>
        <legend>User</legend>
            @Html.Bootstrap().ControlGroup().TextBoxFor(Function(model) model.UserName)
            @Html.Bootstrap().ControlGroup().TextBoxFor(Function(model) model.MainRole)
            @Html.HiddenFor(Function(model) model.UserId)
        <div>
            @Html.Partial("Elements/_Save_BackToList", ViewData)
        </div>
    </fieldset>
End Using

@Section Scripts
End Section
