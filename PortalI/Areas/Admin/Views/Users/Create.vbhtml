@ModelType PortalI.UserProfile

@Code
    ViewData("Title") = "Create New User"
End Code

<h3>@ViewData("Title")</h3>

@Using Html.Bootstrap.Begin(New Form("Create", "Users").FormMethod(FormMethod.Post).Type(FormType.Horizontal))
    @Html.ValidationSummary(True)
    @Html.AntiForgeryToken()

    @<fieldset>
        <legend>User Profile</legend>
        @Html.Bootstrap().ControlGroup().TextBoxFor(Function(model) model.UserName).Placeholder()
        @Html.Bootstrap().ControlGroup().TextBoxFor(Function(model) model.MainRole)

        <div>
            @Html.Partial("Elements/_Create_BackToList")
        </div>
    </fieldset>
End Using

@Section Scripts
End Section
