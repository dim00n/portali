@Using Html.BeginForm()
    @<button type="submit" value="Save" class="btn btn-small btn-success">Save</button> @<span>|</span>
    @Html.ActionLink("Back to List", "Index", Nothing, New With {.class = "btn btn-small btn-primary"})
End Using