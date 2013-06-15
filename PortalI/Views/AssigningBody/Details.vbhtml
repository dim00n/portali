@ModelType PortalI.AssigningBody

@Code
    ViewData("Title") = "Country Details"
    ViewData("id") = Model.AssigningBodyCode
End Code

<h3>@ViewData("Title")</h3>

<fieldset>
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
    <div>
        @Html.Partial("Elements/_Edit_BackToList", ViewData)
    </div>
</fieldset>


 