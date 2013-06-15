@ModelType IPagedList(Of PortalI.MyApplication)

<div id="targetList">
    <div class="pagedList" data-otf-target="#targetList">
        @Html.PagedListPager(Model, Function(x) Url.Action("Index", New With {.page = x}), PagedListRenderOptions.ClassicPlusFirstAndLast)
    </div>
    <table class="table table-striped table-bordered table-condensed">
        <thead>
            <tr>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Item(0).Name)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Item(0).AppTypeId)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Item(0).Description)
                </th>
                <th>
                </th>
            </tr>
        </thead>
        @For Each item In Model
            Dim currentItem = item
            @<tr>
                <td>
                    @Html.ActionLink(currentItem.Name, "Edit", New With {.id = currentItem.MyApplicationID})
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) currentItem.AppType.AppType)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) currentItem.Description)
                </td>
                <td>
                    @Html.ActionLink("Details", "Details", New With {.id = currentItem.MyApplicationID}, New With {.class = "btn btn-mini btn-success"}) |
                    @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.MyApplicationID}, New With {.class = "btn btn-mini btn-danger"})
                </td>
            </tr>
        Next
    </table>
</div>
