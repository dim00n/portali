@ModelType PortalI.AssigningBody

@Code
    ViewData("Title") = "Country Details"
    ViewData("id") = Model.AssigningBodyCode
End Code

<h3>@ViewData("Title")</h3>


@Using Html.Bootstrap.Begin(New Form("Details", "Country").FormMethod(FormMethod.Post).Type(FormType.Horizontal))
    @<fieldset>
        <legend>Language</legend>
        @Html.Bootstrap().ControlGroup().DisplayTextFor(Function(m) Model.AssigningBodyCode)
        @Html.Bootstrap().ControlGroup().DisplayTextFor(Function(m) Model.AssigningBodyName)
        @Html.Bootstrap().ControlGroup().DisplayTextFor(Function(m) Model.AssigningBodyAdjective)
        <div>
            @Html.Partial("Elements/_Edit_BackToList", ViewData)
        </div>
    </fieldset>
End Using

