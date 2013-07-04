@ModelType PortalI.Language

@Code
    ViewData("Title") = "Create New Language"
End Code

<h3>@ViewData("Title")</h3>

@Using Html.Bootstrap.Begin(New Form("Create", "Language").FormMethod(FormMethod.Post).Type(FormType.Horizontal))
    @Html.ValidationSummary(True)
    @Html.AntiForgeryToken()

     @<fieldset>
        <legend>Language</legend>
            @Html.Bootstrap().ControlGroup().TextBoxFor(Function(model) model.LCode)
            @Html.Bootstrap().ControlGroup().TextBoxFor(Function(model) model.LNameEnglish)
            @Html.Bootstrap().ControlGroup().TextBoxFor(Function(model) model.LNameOriginal)
        <div>
            @Html.Partial("Elements/_Create_BackToList")
        </div>
    </fieldset>
End Using

@Section Scripts
End Section
