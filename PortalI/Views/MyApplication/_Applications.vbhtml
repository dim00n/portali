@ModelType IPagedList(Of PortalI.MyApplication)

<div id="targetList">
    <div class="pagedList" data-my-target="#targetList">
        @Html.PagedListPager(Model, Function(x) Url.Action("Index", New With {.page = x}), PagedListRenderOptions.ClassicPlusFirstAndLast)
    </div>

    <table class="table table-striped table-bordered table-condensed">
        <thead>
            <tr>
                <th>@Html.DisplayNameFor(Function(m) Model.FirstOrDefault.Name)</th>
                <th>@Html.DisplayNameFor(Function(m) Model.FirstOrDefault.AppTypeId)</th>
                <th>@Html.DisplayNameFor(Function(m) Model.FirstOrDefault.Description)</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            @For Each item In Model
                Dim currentItem As PortalI.MyApplication = item
                ViewData("id") = currentItem.MyApplicationID
                @<tr data-my-appid = "@ViewData("id")">
                    <td data-my-appname="@currentItem.Name">
                        @Html.ActionLink(currentItem.Name, "Edit", New With {.id = ViewData("id")})
                    </td>
                    <td data-my-apptype="@currentItem.AppType.AppType">
                        @Html.DisplayFor(Function(m) currentItem.AppType.AppType)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(m) currentItem.Description)
                    </td>
                    <td>@Html.Partial("Elements/_Details_Delete", ViewData)</td>
                </tr>
            Next
        </tbody>
    </table>
</div>
