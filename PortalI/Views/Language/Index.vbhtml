@ModelType IPagedList(Of PortalI.Language)

@Code
    ViewData("Title") = "Language Authority"
    If Model.Count = 0 Then ViewData("id") = 0 Else ViewData("id") = Model.First.LCode
End Code

<h2>@ViewData("Title")</h2>

@Html.Partial("Elements/_Search", Model)

@Html.Partial("_Languages", Model)

@Code
    ViewData("modalDialogAction") = "Delete"
    ViewData("modalDialogHeader") = "Delete Language"
    ViewData("modalDialogMsgTemplate") = "_DeleteWarningMsg"
End Code
@Html.Partial("Elements/_DeleteWarningModal")


