@Using Html.Bootstrap.Begin(New Form() _
                           .FormMethod(FormMethod.Get) _
                           .HtmlAttributes(New With {.data_my_ajax = "true", .data_my_target = "#targetList"}))
    @<input type="search" name="searchTerm" data-my-autocomplete="@Url.Action("Autocomplete")" value="@ViewBag.SearchTerm"/>
    
    @Html.Bootstrap().SubmitButton().Value("Search").Text("Search").Style(ButtonStyle.Success) @<span>&nbsp;</span>
    @If (User.IsInRole("Admin") Or Not ViewData("Title").ToString.Contains("Applications")) Then
        @Html.Bootstrap().ActionLinkButton("Create New", "Create").Style(ButtonStyle.Primary)
    End If
    
End Using
@*<form method="get" action="@Url.Action("Index", New With {.appTypeId = ViewData("id")})" data-my-ajax="true" data-my-target="#targetList">
</form>
*@