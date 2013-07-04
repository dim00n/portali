<div>
    @Html.Bootstrap().ActionLinkButton("Details", "Details").Style(ButtonStyle.Success).Size(ButtonSize.Mini).RouteValues(New With {.id = ViewData("id")}) <span>|</span>
    @Html.Bootstrap().Button().Text("Delete").Style(ButtonStyle.Danger).Size(ButtonSize.Mini).HtmlAttributes(New With {.class = "my-delete-button", .data_toggle = "modal", .data_target = "#modalDialog"})
</div>
