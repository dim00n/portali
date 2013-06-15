<form method="get" action="@Url.Action("Index", New With {.appTypeId = ViewData("id")})" data-otf-ajax="true" data-otf-target="#targetList">
    <input type="search" name="searchTerm" data-otf-autocomplete="@Url.Action("Autocomplete")" />
    <button type="submit" value="Search" class="btn btn-success">Search</button>
    @If (User.IsInRole("Admin") Or Not ViewData("Title").ToString.Contains("Applications")) Then
        @Html.ActionLink("Create New", "Create", Nothing, New With {.class = "btn btn-primary"})
    End If
</form>
