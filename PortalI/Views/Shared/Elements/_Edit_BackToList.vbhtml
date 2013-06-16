@Using Html.Bootstrap().Begin(New FormActions())
    @Html.Bootstrap().ActionLinkButton("Edit", "Edit").Style(ButtonStyle.Success).Size(ButtonSize.Small).RouteValues(New With {.id = ViewData("id")}) @<span>|</span>
    @Html.Bootstrap().ActionLinkButton("Back to List", "Index").Style(ButtonStyle.Primary).Size(ButtonSize.Small)
End Using