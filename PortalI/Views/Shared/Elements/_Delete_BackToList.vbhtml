@Using Html.BeginForm()
    @<input type="hidden" name="id" value="@ViewData("id")" />
    @<button type="submit" value="Delete" class="btn btn-small btn-danger">Delete</button> @<span>|</span>
    @Html.ActionLink("Back to List", "Index", Nothing, New With {.class = "btn btn-small btn-primary"})
End Using