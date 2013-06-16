@ModelType IPagedList(Of PortalI.MyApplication)

@Code
    ViewData("Title") = "Applications"
    ViewData("id") = Model.Item(0).AppTypeId
End Code

<h2>@ViewData("Title")</h2>

@Html.Partial("Elements/_Search", Model)

@Html.Partial("_Applications", Model)

@*<div id="mdl">
<button type="button" data-toggle="modal" data-target="#myModal">Launch modal</button>
@Html.Bootstrap().Button().HtmlAttributes(New With {.data_toggle = "modal", .data_target = "#myModal"})
</div>
@Using mdl = Html.Bootstrap().Begin(New Modal().Fade.Id("modalDelete"))
    Using mdl.BeginHeader
        @<h2>Some header</h2>
    End Using
    Using mdl.BeginBody
        @<p>Some body</p>
    End Using
    Using mdl.BeginFooter
        @<p>Footer here.</p>
        @Html.Bootstrap().Button().Text("Close").Style(ButtonStyle.Success)
    End Using
End Using


<!-- modal div -->
<div class="modal hide fade in" id="myModal" role="dialog" aria-hidden="true">
    <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal">×</button>
        <h3>Modal header</h3>
    </div>
    <div class="modal-body">
         <p>Some body</p>
   </div>
    <div class="modal-footer">
        <a href="#" class="btn" data-dismiss="modal">Close</a>
        <a href="#" class="btn btn-primary">Save changes</a>
    </div>
</div>*@