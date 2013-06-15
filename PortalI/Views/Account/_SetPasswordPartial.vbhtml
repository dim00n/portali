@ModelType PortalI.LocalPasswordModel

<h4>Set password</h4>
<p>
    You do not have a local password for this site. Add a local
    password so you can log in without an external login.
</p>

@Using Html.BeginForm("Manage", "Account")
    @Html.AntiForgeryToken()
    @Html.ValidationSummary()

    @<fieldset>
        <legend>Set Password Form</legend>
        <ol>
            <li>
                @Html.LabelFor(Function(m) m.NewPassword)
                @Html.PasswordFor(Function(m) m.NewPassword)
            </li>
            <li>
                @Html.LabelFor(Function(m) m.ConfirmPassword)
                @Html.PasswordFor(Function(m) m.ConfirmPassword)
            </li>
        </ol>
        <button type="submit" value="Set password" class="btn btn-success">Set password</button>
    </fieldset>
End Using
