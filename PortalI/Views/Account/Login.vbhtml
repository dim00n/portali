@ModelType PortalI.LoginModel

@Code
    Layout = "~/Views/Shared/_LayoutWithoutSidebar.vbhtml"
    ViewData("Title") = "Log in"
End Code

<hgroup class="title">
    <h3>@ViewData("Title").</h3>
</hgroup>

<section id="loginForm">
<h4>Use a local account to log in.</h4>
<div>
@Using Html.BeginForm(New With { .ReturnUrl = ViewData("ReturnUrl") })
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(true)

    @<fieldset>
        <legend>Log in Form</legend>
        <ol>
            <li>
                @Html.LabelFor(Function(m) m.UserName)
                @Html.TextBoxFor(Function(m) m.UserName)
                @Html.ValidationMessageFor(Function(m) m.UserName)
            </li>
            <li>
                @Html.LabelFor(Function(m) m.Password)
                @Html.PasswordFor(Function(m) m.Password)
                @Html.ValidationMessageFor(Function(m) m.Password)
            </li>
            <li>
                @Html.CheckBoxFor(Function(m) m.RememberMe)
                @Html.LabelFor(Function(m) m.RememberMe, New With { .Class = "checkbox" })
            </li>
        </ol>
        <button type="submit" value="Log in" class="btn btn-success">Log in</button>
    </fieldset>
End Using
</div>
<div>
    @Html.ActionLink("Register", "Register") if you don't have an account.
</div>
</section>

<section class="social" id="socialLoginForm">
    <h4>Use another service to log in.</h4>
    @Html.Action("ExternalLoginsList", New With {.ReturnUrl = ViewData("ReturnUrl")})
</section>

@Section Scripts
End Section
