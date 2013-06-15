@ModelType PortalI.LocalPasswordModel

<h4>Change password</h4>

@Using Html.BeginForm("Manage", "Account")
    @Html.AntiForgeryToken()
    @Html.ValidationSummary()

    @<fieldset>
        <legend>Change Password Form</legend>
        <ol>
            <li>
                @Html.LabelFor(Function(m) m.OldPassword)
                @Html.PasswordFor(Function(m) m.OldPassword)
            </li>
            <li>
                @Html.LabelFor(Function(m) m.NewPassword)
                @Html.PasswordFor(Function(m) m.NewPassword)
            </li>
            <li>
                @Html.LabelFor(Function(m) m.ConfirmPassword)
                @Html.PasswordFor(Function(m) m.ConfirmPassword)
            </li>
        </ol>
        <button type="submit" value="Change password" class="btn btn-success">Change password</button>
    </fieldset>
End Using
