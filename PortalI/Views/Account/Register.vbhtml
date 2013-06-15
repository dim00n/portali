@ModelType PortalI.RegisterModel
@Code
    Layout = "~/Views/Shared/_LayoutWithoutSidebar.vbhtml"
    ViewData("Title") = "Register"
End Code

<hgroup class="title">
    <h3>@ViewData("Title").</h3>
    <h4>Create a new account.</h4>
</hgroup>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary()

    @<fieldset>
        <legend>Registration Form</legend>
        <ol>
            <li>
                @Html.LabelFor(Function(m) m.UserName)
                @Html.TextBoxFor(Function(m) m.UserName)
            </li>
            <li>
                @Html.LabelFor(Function(m) m.Password)
                @Html.PasswordFor(Function(m) m.Password)
            </li>
            <li>
                @Html.LabelFor(Function(m) m.ConfirmPassword)
                @Html.PasswordFor(Function(m) m.ConfirmPassword)
            </li>
        </ol>
        <button type="submit" value="Register" class="btn btn-success">Register</button>
    </fieldset>
End Using

@Section Scripts
End Section
