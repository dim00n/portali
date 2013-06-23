Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Private _db As IPortalIDb

    Public Sub New()
        _db = New PortalIDb
    End Sub

    Public Sub New(db As IPortalIDb)
        _db = db
    End Sub

    Function Index() As ActionResult
        ViewData("Message") = String.Empty
        Return View()
    End Function

    Function About() As ActionResult
        Return View()
    End Function

    Function Contact() As ActionResult
        Return View()
    End Function

    <ChildActionOnly()>
    <OutputCache(Duration:=10)>
    Public Function AppMenu() As ActionResult
        Dim apps = _db.Query(Of MyApplication).Where(Function(x) x.Implemented = True).ToList().OrderBy(Function(x) x.Name)

        Return PartialView(apps)
    End Function

    Protected Overrides Sub Dispose(disposing As Boolean)
        If (Not _db Is Nothing) Then _db.Dispose()
        MyBase.Dispose(disposing)
    End Sub
End Class
