@ModelType IPagedList(Of PortalI.Language)

<div id="targetList">
    <div class="pagedList" data-my-target="#targetList">
        @Html.PagedListPager(Model, Function(x) Url.Action("Index", New With {.page = x}), PagedListRenderOptions.ClassicPlusFirstAndLast)
    </div>

    <table class="table table-striped table-bordered table-condensed">
        <thead>
            <tr>
                <th>@Html.DisplayNameFor(Function(m) Model.FirstOrDefault.LCode)</th>
                <th>@Html.DisplayNameFor(Function(m) Model.FirstOrDefault.LNameEnglish)</th>
                <th>@Html.DisplayNameFor(Function(m) Model.FirstOrDefault.LNameOriginal)</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            @For Each item In Model
                Dim currentItem As PortalI.Language = item
                ViewData("id") = currentItem.LCode
                @<tr data-my-appid = "@ViewData("id")">
                    <td>
                        @Html.ActionLink(currentItem.LCode, "Edit", New With {.id = ViewData("id")})
                    </td>
                    <td data-my-appname="@currentItem.LNameEnglish" data-my-apptype="Language">
                        @Html.DisplayFor(Function(m) currentItem.LNameEnglish)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(m) currentItem.LNameOriginal)
                    </td>
                    <td>
                        @Html.Partial("Elements/_Details_Delete", ViewData)
                   </td>
                </tr>
            Next
        </tbody>
    </table>
</div>
