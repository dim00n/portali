@ModelType PortalI.AssigningBody

@Code
    ViewData("Title") = "Delete Country"
    ViewData("id") = Model.AssigningBodyCode
End Code

<div class="@TempData("Style")">
@If (TempData("Message") Is Nothing) Then
    @<h3>@ViewData("Title")</h3>

    @<h4>Are you sure you want to delete this?</h4>
    @<fieldset>
        <legend>Country</legend>
        <div class="display-label">
            @Html.DisplayNameFor(Function(model) model.AssigningBodyCode)
        </div>
        <div class="display-field">
            @Html.DisplayFor(Function(model) model.AssigningBodyCode)
        </div>
        <div class="display-label">
            @Html.DisplayNameFor(Function(model) model.AssigningBodyName)
        </div>
        <div class="display-field">
            @Html.DisplayFor(Function(model) model.AssigningBodyName)
        </div>
        <div class="display-label">
            @Html.DisplayNameFor(Function(model) model.AssigningBodyAdjective)
        </div>
        <div class="display-field">
            @Html.DisplayFor(Function(model) model.AssigningBodyAdjective)
        </div>
    </fieldset>   
Else
    @Html.Partial("Elements/_ErrorMessage", ViewData)
End If

@Html.Partial("Elements/_Delete_BackToList", ViewData)
</div>

