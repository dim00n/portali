Imports System.Data.Entity
Imports System.Data.SqlClient
Imports PagedList

Namespace PortalI
    <Authorize(Roles:="Admin")>
    Public Class MyApplicationController
        Inherits System.Web.Mvc.Controller

        Private _db As IPortalIDb

        Public Sub New()
            _db = New PortalIDb
        End Sub

        Public Sub New(db As IPortalIDb)
            _db = db
        End Sub

        <AllowAnonymous()>
        Public Function Autocomplete(term As String) As ActionResult

            Dim model = _db.Query(Of MyApplication) _
                            .Where(Function(x) x.Name.StartsWith(term)) _
                            .Take(10) _
                            .Select(Function(x) New With {
                                        .label = x.Name
                            }).ToList()

            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function

        '
        ' GET: /MyApplication/
        <AllowAnonymous()>
        Function Index(Optional searchTerm As String = Nothing,
                       Optional page As Integer = 1,
                       Optional appTypeId As Integer = 0) As ActionResult

            Dim model = _db.Query(Of MyApplication).Include(Function(x) x.AppType) _
                    .OrderBy(Function(x) x.MyApplicationID) _
                    .Where(Function(x) searchTerm Is Nothing OrElse x.Name.StartsWith(searchTerm)) _
                    .Where(Function(x) appTypeId = 0 OrElse x.AppTypeId = appTypeId) _
                    .Where(Function(x) x.Implemented = True) _
                    .ToPagedList(page, 10)
            If (Request.IsAjaxRequest) Then
                Return PartialView("_Applications", model)
            End If
            Return View(model)

        End Function

        '
        ' GET: /MyApplication/Details/5
        <AllowAnonymous()>
        Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim myapplication As MyApplication = _db.Find(Of MyApplication)(id)
            If IsNothing(myapplication) Then
                Return HttpNotFound()
            End If
            Return View(myapplication)

        End Function

        '
        ' GET: /MyApplication/Create

        Function Create() As ActionResult
            ViewBag.AppTypeId = New SelectList(_db.Query(Of ApplicationType), "AppTypeId", "AppType")
            Return View()
        End Function

        '
        ' POST: /MyApplication/Create

        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(ByVal myapplication As MyApplication) As ActionResult
            If (_db.Query(Of MyApplication).Where(Function(x) x.Name = myapplication.Name).Count > 0) Then
                ModelState.AddModelError("Name", "Application Name must be unique!")
            End If
            If ModelState.IsValid Then
                _db.Add(myapplication)
                SaveChanges()
                Return RedirectToAction("Index", New With {.appTypeId = myapplication.AppTypeId})
            End If

            ViewBag.AppTypeId = New SelectList(_db.Query(Of ApplicationType), "AppTypeId", "AppType")
            Return View(myapplication)
        End Function

        '
        ' GET: /MyApplication/Edit/5

        Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim myapplication As MyApplication = _db.Find(Of MyApplication)(id)
            If IsNothing(myapplication) Then
                Return HttpNotFound()
            End If
            ViewBag.AppTypeId = New SelectList(_db.Query(Of ApplicationType), "AppTypeId", "AppType", myapplication.AppType.AppTypeId)
            Return View(myapplication)
        End Function

        '
        ' POST: /MyApplication/Edit/5

        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(ByVal myapplication As MyApplication) As ActionResult
            If ModelState.IsValid Then
                _db.Update(myapplication)
                SaveChanges()
                Return RedirectToAction("Index", New With {.appTypeId = myapplication.AppTypeId})
            End If

            ViewBag.AppTypeId = New SelectList(_db.Query(Of ApplicationType), "AppTypeId", "AppType", myapplication.AppType.AppTypeId)
            Return View(myapplication)
        End Function

        '
        ' GET: /MyApplication/Delete/5

        Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim myapplication As MyApplication = _db.Find(Of MyApplication)(id)
            If IsNothing(myapplication) Then
                Return HttpNotFound()
            End If
            TempData("Message") = "Do you really want to delete application: '" & myapplication.Name & "'?"
            TempData("Style") = "alert alert-error"
            Return View(myapplication)
        End Function

        '
        ' POST: /MyApplication/Delete/5

        <HttpPost()> _
        <ActionName("Delete")> _
        Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
            Dim myapplication As MyApplication = _db.Find(Of MyApplication)(id)
            _db.Remove(myapplication)
            SaveChanges()
            Return RedirectToAction("Index", New With {.appTypeId = myapplication.AppTypeId})
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