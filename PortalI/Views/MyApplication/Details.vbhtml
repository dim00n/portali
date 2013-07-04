@ModelType PortalI.MyApplication

@Code
    ViewData("Title") = "Application Details"
    ViewData("id") = Model.MyApplicationID
End Code

<h3>@ViewData("Title")</h3>

@Using Html.Bootstrap.Begin(New Form("Details", "MyApplication").FormMethod(FormMethod.Post).Type(FormType.Horizontal))
    @<fieldset>
        <legend>MyApplication</legend>
            @Html.Bootstrap().ControlGroup().DisplayTextFor(Function(model) model.Name).HtmlAttributes(New With {.class = "display-field"})
            @Html.Bootstrap().ControlGroup().DisplayTextFor(Function(model) model.AppType.AppType).HtmlAttributes(New With {.class = "display-field"})
            @Html.Bootstrap().ControlGroup().DisplayTextFor(Function(model) model.Description).HtmlAttributes(New With {.class = "display-field"})
            @Html.Bootstrap().ControlGroup().DisplayTextFor(Function(model) model.Implemented).HtmlAttributes(New With {.class = "display-field"})
        <div>
            @Html.Partial("Elements/_Edit_BackToList", ViewData)
        </div>
    </fieldset>
End Using

@*
    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Name)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Name)
    </div>
*@