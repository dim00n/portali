@ModelType PortalI.AssigningBody

@Code
    ViewData("Title") = "Create New Country"
End Code

<h3>@ViewData("Title")</h3>

@Using Html.Bootstrap.Begin(New Form("Create", "Country").FormMethod(FormMethod.Post).Type(FormType.Horizontal))
    @Html.ValidationSummary(True)
    @Html.AntiForgeryToken()

     @<fieldset>
        <legend>Country</legend>
        @Html.Bootstrap().ControlGroup().TextBoxFor(Function(model) model.AssigningBodyCode)
        @Html.Bootstrap().ControlGroup().TextBoxFor(Function(model) model.AssigningBodyName)
        @Html.Bootstrap().ControlGroup().TextBoxFor(Function(model) model.AssigningBodyAdjective)
        <div>
            @Html.Partial("Elements/_Create_BackToList")
        </div>
    </fieldset>
End Using

@Section Scripts
End Section
