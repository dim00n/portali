@ModelType PortalI.Language

@Code
    ViewData("Title") = "Language Details"
    ViewData("id") = Model.LCode
End Code

<h3>@ViewData("Title")</h3>

<fieldset>
    <legend>Language</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.LCode)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.LCode)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.LNameEnglish)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.LNameEnglish)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.LNameOriginal)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.LNameOriginal)
    </div>
</fieldset>

<div>
    @Html.Partial("Elements/_Edit_BackToList", ViewData)
</div>