@ModelType PortalI.UserProfile

@Code
    ViewData("Title") = "User Details"
    ViewData("id") = Model.UserId
End Code

<h3>@ViewData("Title")</h3>

@Using Html.Bootstrap.Begin(New Form("Details", "Users").FormMethod(FormMethod.Post).Type(FormType.Horizontal))
     @<fieldset class="form-horizontal">
        <legend>User</legend>
            @Html.Bootstrap().ControlGroup().DisplayTextFor(Function(model) model.UserName).HtmlAttributes(New With {.class = "display-field"})
            @Html.Bootstrap().ControlGroup().DisplayTextFor(Function(model) model.MainRole).HtmlAttributes(New With {.class = "display-field"})
        <div>
            @Html.Partial("Elements/_Edit_BackToList", ViewData)
        </div>
    </fieldset>
End Using
