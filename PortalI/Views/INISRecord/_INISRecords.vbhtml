@ModelType IPagedList(Of PortalI.INISRecord)

<div id="targetList">
    <div class="pagedList" data-otf-target="#targetList">
        @Html.PagedListPager(Model, Function(x) Url.Action("Index", New With {.page = x}), PagedListRenderOptions.ClassicPlusFirstAndLast)
    </div>

    @Using table = Html.Bootstrap.Begin(New Table().Striped.Bordered.Condensed)
        @<thead>
        <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Item(0).INISRecId)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Item(0).BatchNo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Item(0).TRN)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Item(0).ReportNo)
        </th>
       <th>
            @Html.DisplayNameFor(Function(model) model.Item(0).SubjectCat)
        </th>
        <th></th>
        </tr>
        </thead>
         @For Each item In Model
            Dim currentItem = item
            @Using table.BeginRow()
                @<td>
                    @Html.DisplayFor(Function(modelItem) currentItem.INISRecId)
                </td>
                @<td>
                    @Html.DisplayFor(Function(modelItem) currentItem.BatchNo)
                </td>
                @<td>
                    @Html.DisplayFor(Function(modelItem) currentItem.TRN)
                </td>
                @<td>
                    @Html.DisplayFor(Function(modelItem) currentItem.ReportNo)
                </td>
                @<td>
                    @Html.DisplayFor(Function(modelItem) currentItem.SubjectCat)
                </td>
                @<td>
                    @Html.ActionLink("Details", "Details", New With {.id = currentItem.INISRecId}, New With {.class = "btn btn-mini btn-success"})
                    |
                    @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.INISRecId}, New With {.class = "btn btn-mini btn-danger"})
                </td>
            End Using
         Next
     End Using

</div>
