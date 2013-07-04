@ModelType PortalI.AssigningBody

@Code
    ViewData("Title") = "Edit Country"
End Code

<h3>@ViewData("Title")</h3>

@Using Html.Bootstrap.Begin(New Form("Edit", "Country").FormMethod(FormMethod.Post).Type(FormType.Horizontal))
    @Html.ValidationSummary(True)
    @Html.AntiForgeryToken()

    @<fieldset>
        <legend>Language</legend>
        @Html.Bootstrap().ControlGroup().TextBoxFor(Function(model) model.AssigningBodyCode)
        @Html.Bootstrap().ControlGroup().TextBoxFor(Function(model) model.AssigningBodyName)
        @Html.Bootstrap().ControlGroup().TextBoxFor(Function(model) model.AssigningBodyAdjective)
        <div>
            @Html.Partial("Elements/_Save_BackToList", ViewData)
        </div>
    </fieldset>
End Using

@Section Scripts
End Section
