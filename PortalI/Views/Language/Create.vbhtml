@ModelType PortalI.Language

@Code
    ViewData("Title") = "Create New Language"
End Code

<h3>@ViewData("Title")</h3>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)
    @Html.AntiForgeryToken()

    @<fieldset>
        <legend>Language</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.LCode)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.LCode)
            @Html.ValidationMessageFor(Function(model) model.LCode)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.LNameEnglish)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.LNameEnglish)
            @Html.ValidationMessageFor(Function(model) model.LNameEnglish)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.LNameOriginal)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.LNameOriginal)
            @Html.ValidationMessageFor(Function(model) model.LNameOriginal)
        </div>

        <div>
            @Html.Partial("Elements/_Create_BackToList")
        </div>
    </fieldset>
End Using

@Section Scripts
End Section
