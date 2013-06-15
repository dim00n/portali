@ModelType PortalI.AssigningBody

@Code
    ViewData("Title") = "Edit Country"
End Code

<h3>@ViewData("Title")</h3>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)
    @Html.AntiForgeryToken()

    @<fieldset>
        <legend>Country</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.AssigningBodyCode)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.AssigningBodyCode)
            @Html.ValidationMessageFor(Function(model) model.AssigningBodyCode)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.AssigningBodyName)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.AssigningBodyName)
            @Html.ValidationMessageFor(Function(model) model.AssigningBodyName)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.AssigningBodyAdjective)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.AssigningBodyAdjective)
            @Html.ValidationMessageFor(Function(model) model.AssigningBodyAdjective)
        </div>

        <div>
            @Html.Partial("Elements/_Save_BackToList", ViewData)
        </div>
     </fieldset>
End Using


@Section Scripts
End Section
