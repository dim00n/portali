@Using Html.BeginForm()
    @<button type="submit" value="Create" class="btn btn-small btn-success">Create</button> @<span>|</span>
    @Html.ActionLink("Back to List", "Index", Nothing, New With {.class = "btn btn-small btn-primary"})
End Using