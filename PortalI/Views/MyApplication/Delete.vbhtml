@ModelType PortalI.MyApplication

@Code
    ViewData("Title") = "Delete Application"
    ViewData("id") = Model.MyApplicationID
End Code

<div class="@TempData("Style")">
@If (TempData("Message") Is Nothing) Then
@<h3>@ViewData("Title")</h3>

@<h4>Are you sure you want to delete this?</h4>
@<fieldset>
    <legend>MyApplication</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Name)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Name)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Description)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Description)
    </div>
</fieldset>
Else
    @Html.Partial("Elements/_ErrorMessage", ViewData)
End If

@Html.Partial("Elements/_Delete_BackToList", ViewData)
</div>