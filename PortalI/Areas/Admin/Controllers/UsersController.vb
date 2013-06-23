Imports System.Data.Entity
Imports PagedList
Imports System.Data.SqlClient

Namespace PortalI.Areas.Admin.Controllers
    Public Class UsersController
        Inherits System.Web.Mvc.Controller

        Private _db As PortalIDb

        Public Sub New()
            _db = New PortalIDb
        End Sub

        Public Sub New(db As IPortalIDb)
            _db = db
        End Sub

        <AllowAnonymous()>
        Public Function Autocomplete(term As String) As ActionResult

            Dim model = _db.Query(Of UserProfile) _
                            .Where(Function(x) x.UserName.StartsWith(term)) _
                            .Take(10) _
                            .Select(Function(x) New With {
                                        .label = x.UserName
                            }).ToList()

            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function

        '
        ' GET: /Admin/Users/

        Function Index(Optional searchTerm As String = Nothing,
                       Optional page As Integer = 1) As ActionResult
            Dim model = _db.Query(Of UserProfile) _
                    .OrderBy(Function(x) x.UserName) _
                    .Where(Function(x) searchTerm Is Nothing OrElse x.UserName.StartsWith(searchTerm)) _
                    .ToPagedList(page, 10)
            If (Request.IsAjaxRequest) Then
                Return PartialView("_Users", model)
            End If
            Return View(model)
        End Function

        '
        ' GET: /Admin/Users/Details/5

        Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim userprofile As UserProfile = _db.Find(Of UserProfile)(id)
            If IsNothing(userprofile) Then
                Return HttpNotFound()
            End If
            Return View(userprofile)
        End Function

        '
        ' GET: /Admin/Users/Create

        Function Create() As ActionResult
            Return View()
        End Function

        '
        ' POST: /Admin/Users/Create

        <HttpPost()> _
        Function Create(ByVal userprofile As UserProfile) As ActionResult
            If (_db.Query(Of UserProfile).Where(Function(x) x.UserName = userprofile.UserName).Count > 0) Then
                ModelState.AddModelError("UserName", "User Name must be unique!")
            End If
            If ModelState.IsValid Then
                _db.Add(userprofile)
                SaveChanges()
                Return RedirectToAction("Index")
            End If

            Return View(userprofile)
        End Function

        '
        ' GET: /Admin/Users/Edit/5

        Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim userprofile As UserProfile = _db.Find(Of UserProfile)(id)
            If IsNothing(userprofile) Then
                Return HttpNotFound()
            End If
            Return View(userprofile)
        End Function

        '
        ' POST: /Admin/Users/Edit/5

        <HttpPost()> _
        Function Edit(ByVal userprofile As UserProfile) As ActionResult
            If ModelState.IsValid Then
                _db.Update(userprofile)
                SaveChanges()
                Return RedirectToAction("Index")
            End If

            Return View(userprofile)
        End Function

        '
        ' GET: /Admin/Users/Delete/5

        Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim userprofile As UserProfile = _db.Find(Of UserProfile)(id)
            If IsNothing(userprofile) Then
                Return HttpNotFound()
            End If
            TempData("Message") = "Do you really want to delete user: '" & userprofile.UserName & "'?"
            TempData("Style") = "alert alert-error"
            Return View(userprofile)
        End Function

        '
        ' POST: /Admin/Users/Delete/5

        <HttpPost()> _
        <ActionName("Delete")> _
        Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
            Dim userprofile As UserProfile = _db.Find(Of UserProfile)(id)
            _db.Remove(userprofile)
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