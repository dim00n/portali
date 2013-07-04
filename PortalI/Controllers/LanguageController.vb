Imports System.Data.Entity
Imports System.Data.SqlClient
Imports PagedList

Namespace PortalI
    Public Class LanguageController
        Inherits System.Web.Mvc.Controller

        Private _db As IPortalIDb

        Public Sub New()
            _db = New PortalIDb
        End Sub

        Public Sub New(db As IPortalIDb)
            _db = db
        End Sub

        Public Function Autocomplete(term As String) As ActionResult

            Dim model = _db.Query(Of Language) _
                            .Where(Function(x) x.LCode.StartsWith(term)) _
                            .OrderBy(Function(x) x.LCode) _
                            .Take(10) _
                            .Select(Function(x) New With {
                                        .label = x.LCode
                            }).ToList()

            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function

        '
        ' GET: /Language/

        <OutputCache(Duration:=3, VaryByHeader:="X-Requested-With", Location:=OutputCacheLocation.Server)>
        Public Function Index(Optional searchTerm As String = Nothing,
                              Optional page As Integer = 1) As ActionResult

            ViewBag.SearchTerm = searchTerm
            Dim model = _db.Query(Of Language) _
                    .OrderBy(Function(x) x.LCode) _
                    .Where(Function(x) searchTerm Is Nothing OrElse x.LCode.StartsWith(searchTerm)) _
                    .ToPagedList(page, 10)
            If (Request.IsAjaxRequest) Then
                Return PartialView("_Languages", model)
            End If
            Return View(model)
        End Function

        '
        ' GET: /Language/Details/5

        Public Function Details(Optional ByVal id As String = Nothing) As ActionResult
            Dim language As Language = _db.Find(Of Language)(id)
            If IsNothing(language) Then
                Return HttpNotFound()
            End If
            Return View(language)
        End Function

        '
        ' GET: /Language/Create
        Public Function Create() As ActionResult
            Return View()
        End Function

        '
        ' POST: /Language/Create

        <HttpPost()>
        <Authorize(Roles:="Admin")>
        <ValidateAntiForgeryToken()>
        Public Function Create(ByVal language As Language) As ActionResult
            If (_db.Query(Of Language).Where(Function(x) x.LCode = language.LCode).Count > 0) Then
                ModelState.AddModelError("LCode", "Language Code must be unique!")
            End If
            If ModelState.IsValid Then
                _db.Add(language)
                SaveChanges()
                If ModelState.IsValid Then Return RedirectToAction("Index")
            End If

            Return View(language)
        End Function

        '
        ' GET: /Language/Edit/5

        Public Function Edit(Optional ByVal id As String = Nothing) As ActionResult
            Dim language As Language = _db.Find(Of Language)(id)
            If IsNothing(language) Then
                Return HttpNotFound()
            End If
            Return View(language)
        End Function

        '
        ' POST: /Language/Edit/5

        <HttpPost()>
        <Authorize(Roles:="Admin")>
        <ValidateAntiForgeryToken()>
        Public Function Edit(ByVal language As Language) As ActionResult
            If ModelState.IsValid Then
                _db.Update(language)
                SaveChanges()
                If ModelState.IsValid Then Return RedirectToAction("Index")
            End If

            Return View(language)
        End Function

        '
        ' GET: /Language/Delete/5

        '<Authorize(Roles:="Admin")>
        'Public Function Delete(Optional ByVal id As String = Nothing) As ActionResult
        '    Dim language As Language = _db.Find(Of Language)(id)
        '    If IsNothing(language) Then
        '        Return HttpNotFound()
        '    End If
        '    TempData("Message") = "Do you really want to delete language: '" & language.LNameEnglish & "'?"
        '    TempData("Style") = "alert alert-error"
        '    Return View(language)
        'End Function

        '
        ' POST: /Language/Delete/5

        <HttpPost()>
        <ActionName("Delete")>
        <Authorize(Roles:="Admin")>
        Public Function DeleteConfirmed(ByVal id As String) As RedirectToRouteResult
            Dim language As Language = _db.Find(Of Language)(id)
            _db.Remove(language)
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