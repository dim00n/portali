@ModelType PortalI.MyApplication

@Code
    ViewData("Title") = "Edit Application"
End Code

<h3>@ViewData("Title")</h3>

@Using Html.Bootstrap.Begin(New Form("Edit", "MyApplication").FormMethod(FormMethod.Post).Type(FormType.Horizontal))
    @Html.ValidationSummary(True)
    @Html.AntiForgeryToken()

     @<fieldset>
        <legend>MyApplication</legend>
        @Html.Bootstrap().ControlGroup().TextBoxFor(Function(model) model.Name)
        @Html.Bootstrap().ControlGroup().DropDownListFor(Function(model) model.AppTypeId, ViewBag.AppTypeIds)
        @Html.Bootstrap().ControlGroup().TextAreaFor(Function(model) model.Description)
        @Html.Bootstrap().ControlGroup().CheckBoxFor(Function(model) model.Implemented)
        @Html.HiddenFor(Function(model) model.MyApplicationID)
        <div>
            @Html.Partial("Elements/_Save_BackToList", ViewData)
        </div>
    </fieldset>
End Using

@Section Scripts
End Section
