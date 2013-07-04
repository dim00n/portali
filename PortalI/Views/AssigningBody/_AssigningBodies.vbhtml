@ModelType IPagedList(Of PortalI.AssigningBody)

<div id="targetList">
    <div class="pagedList" data-my-target="#targetList">
        @Html.PagedListPager(Model, Function(x) Url.Action("Index", New With {.page = x, .searchTerm = ViewBag.SearchTerm}), PagedListRenderOptions.ClassicPlusFirstAndLast)
    </div>

    <table class="table table-striped table-bordered table-condensed">
        <thead>
            <tr>
                <th>@Html.DisplayNameFor(Function(m) Model.FirstOrDefault.AssigningBodyCode)</th>
                <th style="width: 40%">@Html.DisplayNameFor(Function(m) Model.FirstOrDefault.AssigningBodyName)</th>
                <th>@Html.DisplayNameFor(Function(m) Model.FirstOrDefault.AssigningBodyAdjective)</th>
                <th></th>
            </tr>
        </thead>
        @For Each item In Model
            Dim currentItem As PortalI.AssigningBody = item
            ViewData("id") = currentItem.AssigningBodyCode
           @<tr data-my-appid = "@ViewData("id")">
                <td>
                    @Html.ActionLink(currentItem.AssigningBodyCode, "Edit", New With {.id = currentItem.AssigningBodyCode})
                </td>
                <td data-my-appname="@currentItem.AssigningBodyName" data-my-apptype="Country">
                    @Html.DisplayFor(Function(modelItem) currentItem.AssigningBodyName)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) currentItem.AssigningBodyAdjective)
                </td>
                <td>
                    @Html.Partial("Elements/_Details_Delete", ViewData)
                </td>
            </tr>
        Next
    </table>
</div>
