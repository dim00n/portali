@ModelType IPagedList(Of PortalI.UserProfile)

<div id="targetList">
    <div class="pagedList" data-otf-target="#targetList">
        @Html.PagedListPager(Model, Function(x) Url.Action("Index", New With {.page = x}), PagedListRenderOptions.ClassicPlusFirstAndLast)
    </div>
    <table class="table table-striped table-bordered table-condensed">
    <thead>
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.FirstOrDefault.UserName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FirstOrDefault.MainRole)
        </th>
        <th></th>
    </tr>
    </thead>
@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.ActionLink(currentItem.UserName, "Edit", New With {.id = currentItem.UserId})
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.MainRole)
        </td>
        <td>
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.UserId}, New With {.class = "btn btn-mini btn-success"}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.UserId}, New With {.class = "btn btn-mini btn-danger"})
        </td>
    </tr>
Next

</table>
</div>

