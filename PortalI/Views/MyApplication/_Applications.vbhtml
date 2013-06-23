@ModelType IPagedList(Of PortalI.MyApplication)

<div id="targetList">
    <div class="pagedList" data-otf-target="#targetList">
        @Html.PagedListPager(Model, Function(x) Url.Action("Index", New With {.page = x}), PagedListRenderOptions.ClassicPlusFirstAndLast)
    </div>
    <table class="table table-striped table-bordered table-condensed">
        <thead>
            <tr>
                <th>
                    @Html.DisplayNameFor(Function(m) Model.FirstOrDefault.Name)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(m) Model.FirstOrDefault.AppTypeId)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(m) Model.FirstOrDefault.Description)
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
                    @Html.DisplayFor(Function(m) currentItem.AppType.AppType)
                </td>
                <td>
                    @Html.DisplayFor(Function(m) currentItem.Description)
                </td>
                <td>
                    @Html.ActionLink("Details", "Details", New With {.id = currentItem.MyApplicationID}, New With {.class = "btn btn-mini btn-success"}) |
                    @Html.Bootstrap().ActionLinkButton("Delete", "Delete").Size(ButtonSize.Mini).Style(ButtonStyle.Danger).HtmlAttributes(New With {.data_toggle = "modal", .data_target = "#modalDelete"}).RouteValues(New With {.id = currentItem.MyApplicationID})
                </td>
            </tr>
        Next
    </table>
</div>

@Using mdl = Html.Bootstrap().Begin(New Modal().Fade.Id("modalDelete"))
    @Using mdl.BeginHeader
        @<button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>    
        @<h3>Delete Application</h3>
    End Using
    @Using mdl.BeginBody
    End Using
    @Using mdl.BeginFooter
        @Html.Bootstrap().Button().Text("Close").Style(ButtonStyle.Success).HtmlAttributes(New With {.data_dismiss = "modal"})
    End Using
End Using

@*
        @Html.Bootstrap().Button().Text("&times;").Style(ButtonStyle.Default).HtmlAttributes(New With {.data_dismiss = "modal", .class = "close", .aria_hidden = "true"})
*@
