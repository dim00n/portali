@ModelType PortalI.MyApplication

@Code
    ViewData("Title") = "Edit Application"
End Code

<h3>@ViewData("Title")</h3>

@Using Html.BeginForm("Edit", "MyApplication", FormMethod.Post, New With {.class = "form-horizontal"})
    @Html.ValidationSummary(True)
    @Html.AntiForgeryToken()

     @<fieldset>
        <legend>MyApplication</legend>
        @Html.Bootstrap().ControlGroup().TextBoxFor(Function(model) model.Name)
        @Html.Bootstrap().ControlGroup().DropDownListFor(Function(model) model.AppTypeId, ViewData("AppTypeId"))
        @Html.Bootstrap().ControlGroup().TextAreaFor(Function(model) model.Description)
        @Html.Bootstrap().ControlGroup().CheckBoxFor(Function(model) model.Implemented)
        <div>
            @Html.Partial("Elements/_Save_BackToList", ViewData)
        </div>
    </fieldset>
End Using

@Section Scripts
End Section
