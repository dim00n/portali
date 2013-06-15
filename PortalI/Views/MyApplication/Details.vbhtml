@ModelType PortalI.MyApplication

@Code
    ViewData("Title") = "Application Details"
    ViewData("id") = Model.MyApplicationID
End Code

<h3>@ViewData("Title")</h3>

<fieldset>
    <legend>MyApplication</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.AppTypeId)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.AppType.AppType)
    </div>

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

    <div class="display-label">
        @Html.LabelFor(Function(model) model.Implemented)
    </div>
    <div class="display-field">
        @Html.CheckBoxFor(Function(model) model.Implemented)
    </div>

</fieldset>

<div>
    @Html.Partial("Elements/_Edit_BackToList", ViewData)
</div>