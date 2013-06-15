@Using Html.BeginForm()
    @Html.ActionLink("Edit", "Edit", New With {.id = ViewData("id")}, New With {.class = "btn btn-small btn-success"}) @<span>|</span>
    @Html.ActionLink("Back to List", "Index", Nothing, New With {.class = "btn btn-small btn-primary"})
End Using