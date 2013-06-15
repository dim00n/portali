@ModelType IPagedList(Of PortalI.AssigningBody)

<div id="targetList">
    <div class="pagedList" data-otf-target="#targetList">
        @Html.PagedListPager(Model, Function(x) Url.Action("Index", New With {.page = x}), PagedListRenderOptions.ClassicPlusFirstAndLast)
    </div>
    <table class="table table-striped table-bordered table-condensed">
        <thead>
            <tr>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Item(0).AssigningBodyCode)
                </th>
                <th style="width: 40%">
                    @Html.DisplayNameFor(Function(model) model.Item(0).AssigningBodyName)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Item(0).AssigningBodyAdjective)
                </th>
                <th>
                </th>
            </tr>
        </thead>
        @For Each item In Model
            Dim currentItem = item
            @<tr>
                <td>
                    @Html.ActionLink(currentItem.AssigningBodyCode, "Edit", New With {.id = currentItem.AssigningBodyCode})
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) currentItem.AssigningBodyName)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) currentItem.AssigningBodyAdjective)
                </td>
                <td>
                    @Html.ActionLink("Details", "Details", New With {.id = currentItem.AssigningBodyCode}, New With {.class = "btn btn-mini btn-success"})
                    |
                    @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.AssigningBodyCode}, New With {.class = "btn btn-mini btn-danger"})
                </td>
            </tr>
        Next
    </table>
</div>
