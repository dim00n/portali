@ModelType IPagedList(Of PortalI.Language)

<div id="targetList">
    <div class="pagedList" data-otf-target="#targetList">
        @Html.PagedListPager(Model, Function(x) Url.Action("Index", New With {.page = x}), PagedListRenderOptions.ClassicPlusFirstAndLast)
    </div>
    <table class="table table-striped table-bordered table-condensed">
        <thead>
            <tr>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Item(0).LCode)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Item(0).LNameEnglish)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Item(0).LNameOriginal)
                </th>
                <th>
                </th>
            </tr>
        </thead>
        @For Each item In Model
            Dim currentItem = item
            @<tr>
                <td>
                    @Html.ActionLink(currentItem.LCode, "Edit", New With {.id = currentItem.LCode})
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) currentItem.LNameEnglish)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) currentItem.LNameOriginal)
                </td>
                <td>
                    @Html.ActionLink("Details", "Details", New With {.id = currentItem.LCode}, New With {.class = "btn btn-mini btn-success"})
                    |
                    @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.LCode}, New With {.class = "btn btn-mini btn-danger"})
                </td>
            </tr>
        Next
    </table>
</div>
