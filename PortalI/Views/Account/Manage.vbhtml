@ModelType PortalI.LocalPasswordModel
@Code
    Layout = "~/Views/Shared/_LayoutWithoutSidebar.vbhtml"
    ViewData("Title") = "Manage Account"
End Code

<hgroup class="title">
    <h3>@ViewData("Title"): <span style="color:Green">@User.Identity.Name</span></h3>
</hgroup>

<section id="loginForm">
    @If ViewData("HasLocalPassword") Then
        @Html.Partial("_ChangePasswordPartial")
    Else
        @Html.Partial("_SetPasswordPartial")
    End If
    <p class="message-success">@ViewData("StatusMessage")</p>
</section>

<section class="social" id="socialLoginForm">
    @Html.Action("RemoveExternalLogins")

    <h4>Add an external login</h4>
    @Html.Action("ExternalLoginsList", New With {.ReturnUrl = ViewData("ReturnUrl")})
</section>

@Section Scripts
End Section
