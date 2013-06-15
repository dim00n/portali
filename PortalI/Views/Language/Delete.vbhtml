@ModelType PortalI.Language

@Code
    ViewData("Title") = "Delete Language"
    ViewData("id") = Model.LCode
End Code

<div class="@TempData("Style")">
@If (TempData("Message") Is Nothing) Then
@<h3>@ViewData("Title")</h3>

@<h4>Are you sure you want to delete this?</h4>
@<fieldset>
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
Else
    @Html.Partial("Elements/_ErrorMessage", ViewData)
End If

@Html.Partial("Elements/_Delete_BackToList", ViewData)
</div>
