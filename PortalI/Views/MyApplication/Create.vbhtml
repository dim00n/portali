@ModelType PortalI.MyApplication

@Code
    ViewData("Title") = "Create New Application"
End Code

<h3>@ViewData("Title")</h3>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)
    @Html.AntiForgeryToken()

    @<fieldset>
        <legend>MyApplication</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Name)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Name)
            @Html.ValidationMessageFor(Function(model) model.Name)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.AppTypeId)
        </div>
        <div class="editor-field">
            @Html.DropDownList("AppTypeId", "-- Select Type --")
            @Html.ValidationMessageFor(Function(model) model.AppTypeId)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Description)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Description)
            @Html.ValidationMessageFor(Function(model) model.Description)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Implemented)
        </div>
        <div class="editor-field">
            @Html.CheckBoxFor(Function(model) model.Implemented)
            @Html.ValidationMessageFor(Function(model) model.Implemented)
        </div>

        <div>
            @Html.Partial("Elements/_Create_BackToList")
        </div>
    </fieldset>
End Using

@Section Scripts
End Section
