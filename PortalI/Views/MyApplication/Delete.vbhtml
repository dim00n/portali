@ModelType PortalI.MyApplication

@Code
    Layout = ""
    ViewData("id") = Model.MyApplicationID
End Code

@Html.Partial("Elements/_ErrorMessage", ViewData)
@Html.Partial("Elements/_Delete_BackToList", ViewData)

