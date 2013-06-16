@ModelType PortalI.MyApplication

@Code
    ViewData("Title") = "Create New Application"
End Code

<h3>@ViewData("Title")</h3>

@Using Html.BeginForm("Create", "MyApplication", FormMethod.Post, New With {.class = "form-horizontal"})
    @Html.ValidationSummary(True)
    @Html.AntiForgeryToken()

     @<fieldset>
        <legend>MyApplication</legend>
        @Html.Bootstrap().ControlGroup().TextBoxFor(Function(model) model.Name).Placeholder()
        @Html.Bootstrap().ControlGroup().DropDownListFor(Function(model) model.AppTypeId, ViewData("AppTypeId")).OptionLabel("-- Select Type --")
        @Html.Bootstrap().ControlGroup().TextAreaFor(Function(model) model.Description)
        @Html.Bootstrap().ControlGroup().CheckBoxFor(Function(model) model.Implemented)
        <div>
            @Html.Partial("Elements/_Create_BackToList")
        </div>
    </fieldset>
End Using

@Section Scripts
End Section


@*
         <div class="editor-label">
            @Html.LabelFor(Function(model) model.AppTypeId)
        </div>
        <div class="editor-field">
            @Html.DropDownList("AppTypeId", "-- Select Type --")
            @Html.ValidationMessageFor(Function(model) model.AppTypeId)
        </div>
*@