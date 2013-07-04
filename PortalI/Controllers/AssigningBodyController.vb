Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.SqlClient
Imports PagedList

Namespace PortalI
    Public Class AssigningBodyController
        Inherits System.Web.Mvc.Controller

        Private _db As IPortalIDb

        Public Sub New()
            _db = New PortalIDb
        End Sub

        Public Sub New(db As IPortalIDb)
            _db = db
        End Sub


        Public Function Autocomplete(term As String) As ActionResult

            Dim model = _db.Query(Of AssigningBody) _
                            .Where(Function(x) x.AssigningBodyName.StartsWith(term)) _
                            .OrderBy(Function(x) x.AssigningBodyName) _
                            .Take(10) _
                            .Select(Function(x) New With {
                                .label = x.AssigningBodyName
                            }).ToList()

            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function

        '
        ' GET: /AssigningBody/
        <OutputCache(Duration:=3, VaryByHeader:="X-Requested-With", Location:=OutputCacheLocation.Server)>
        Function Index(Optional searchTerm As String = Nothing,
                       Optional page As Integer = 1) As ActionResult

            ViewBag.SearchTerm = searchTerm
            Dim model = _db.Query(Of AssigningBody) _
                    .OrderBy(Function(x) x.AssigningBodyCode) _
                    .Where(Function(x) searchTerm Is Nothing OrElse x.AssigningBodyName.StartsWith(searchTerm)) _
                    .ToPagedList(page, 10)
            If (Request.IsAjaxRequest) Then
                Return PartialView("_AssigningBodies", model)
            End If
            Return View(model)
        End Function

        '
        ' GET: /AssigningBody/Details/5

        Function Details(Optional ByVal id As String = Nothing) As ActionResult
            Dim assigningbody As AssigningBody = _db.Find(Of AssigningBody)(id)
            If IsNothing(assigningbody) Then
                Return HttpNotFound()
            End If
            Return View(assigningbody)
        End Function

        '
        ' GET: /AssigningBody/Create

        Function Create() As ActionResult
            Return View()
        End Function

        '
        ' POST: /AssigningBody/Create

        <HttpPost()>
        <ValidateAntiForgeryToken()>
        <Authorize(Roles:="Admin")>
        Function Create(ByVal assigningbody As AssigningBody) As ActionResult
            If (_db.Query(Of AssigningBody).Where(Function(x) x.AssigningBodyCode = assigningbody.AssigningBodyCode).Count > 0) Then
                ModelState.AddModelError("AssigningBodyCode", "Country code must be unique!")
            End If
            If ModelState.IsValid Then
                _db.Add(assigningbody)
                SaveChanges()
                If ModelState.IsValid Then Return RedirectToAction("Index")
            End If

            Return View(assigningbody)
        End Function

        '
        ' GET: /AssigningBody/Edit/5

        Function Edit(Optional ByVal id As String = Nothing) As ActionResult
            Dim assigningbody As AssigningBody = _db.Find(Of AssigningBody)(id)
            If IsNothing(assigningbody) Then
                Return HttpNotFound()
            End If
            Return View(assigningbody)
        End Function

        '
        ' POST: /AssigningBody/Edit/5

        <HttpPost()>
        <ValidateAntiForgeryToken()>
        <Authorize(Roles:="Admin")>
        Function Edit(ByVal assigningbody As AssigningBody) As ActionResult
            If ModelState.IsValid Then
                _db.Update(assigningbody)
                SaveChanges()
                If ModelState.IsValid Then Return RedirectToAction("Index")
            End If

            Return View(assigningbody)
        End Function

        '
        ' GET: /AssigningBody/Delete/5

        '<Authorize(Roles:="Admin")>
        'Function Delete(Optional ByVal id As String = Nothing) As ActionResult
        '    Dim assigningbody As AssigningBody = _db.Find(Of AssigningBody)(id)
        '    If IsNothing(assigningbody) Then
        '        Return HttpNotFound()
        '    End If
        '    TempData("Message") = "Do you really want to delete country: '" & assigningbody.AssigningBodyName & "'?"
        '    TempData("Style") = "alert alert-error"
        '    Return View(assigningbody)
        'End Function

        '
        ' POST: /AssigningBody/Delete/5

        <HttpPost()> _
        <ActionName("Delete")> _
        <Authorize(Roles:="Admin")>
        Function DeleteConfirmed(ByVal id As String) As RedirectToRouteResult
            Dim assigningbody As AssigningBody = _db.Find(Of AssigningBody)(id)
            _db.Remove(assigningbody)
            SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            _db.Dispose()
            MyBase.Dispose(disposing)
        End Sub

        Private Sub SaveChanges()
            Try
                _db.Save()
            Catch ex As SqlException
                ModelState.AddModelError(String.Empty, ex.Message)
            End Try
        End Sub

    End Class
End Namespace