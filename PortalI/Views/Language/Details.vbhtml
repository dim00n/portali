@ModelType PortalI.Language

@Code
    ViewData("Title") = "Language Details"
    ViewData("id") = Model.LCode
End Code

<h3>@ViewData("Title")</h3>

@Using Html.Bootstrap.Begin(New Form("Details", "Language").FormMethod(FormMethod.Post).Type(FormType.Horizontal))
    @<fieldset>
        <legend>Language</legend>
            @Html.Bootstrap().ControlGroup().DisplayTextFor(Function(m) Model.LCode)
            @Html.Bootstrap().ControlGroup().DisplayTextFor(Function(m) Model.LNameEnglish)
            @Html.Bootstrap().ControlGroup().DisplayTextFor(Function(m) Model.LNameOriginal)
        <div>
            @Html.Partial("Elements/_Edit_BackToList", ViewData)
        </div>
    </fieldset>
End Using
