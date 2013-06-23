Imports PagedList

Namespace PortalI
    Public Class INISRecordController
        Inherits System.Web.Mvc.Controller


        <AllowAnonymous()>
        Public Function Autocomplete(term As String) As ActionResult

            Dim model = INISRecords _
                            .Where(Function(x) x.TRN.StartsWith(term)) _
                            .Take(10) _
                            .Select(Function(x) New With {
                                        .label = x.TRN
                            }).ToList()

            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function

        '
        ' GET: /INISRecord

        Function Index(Optional searchTerm As String = Nothing,
                       Optional page As Integer = 1) As ActionResult
            Dim model = INISRecords _
                    .OrderBy(Function(x) x.INISRecId) _
                    .Where(Function(x) searchTerm Is Nothing OrElse x.TRN.StartsWith(searchTerm)) _
                    .ToPagedList(page, 10)
            If (Request.IsAjaxRequest) Then
                Return PartialView("_INISRecords", model)
            End If
            Return View(model)
        End Function

        '
        ' GET: /INISRecord/Details/5

        Function Details(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        '
        ' GET: /INISRecord/Create

        Function Create() As ActionResult
            Return View()
        End Function

        '
        ' POST: /INISRecord/Create

        <HttpPost()> _
        Function Create(ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add insert logic here
                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        '
        ' GET: /INISRecord/Edit/5

        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        '
        ' POST: /INISRecord/Edit/5

        <HttpPost()> _
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        '
        ' GET: /INISRecord/Delete/5

        Function Delete(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        '
        ' POST: /INISRecord/Delete/5

        <HttpPost()> _
        Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        Public Shared ReadOnly Property INISRecords() As IQueryable(Of INISRecord)
            Get
                Dim _INISRecords = New List(Of INISRecord)
                Dim k As Integer = 1
                For j As Integer = Asc("A"c) To Asc("Z"c)
                    For i As Integer = 0 To 9
                        Dim rec = New INISRecord With {.INISRecId = k,
                                                       .BatchNo = j.ToString,
                                                       .TRN = Chr(j) & i.ToString & "12345",
                                                       .BibLevels = "",
                                                       .IRPSJournalId = 0,
                                                       .LiteraryIndicator = "",
                                                       .NumberOfAbstracts = i / 3,
                                                       .RecordType = "",
                                                       .ReportNo = "",
                                                       .SecondarySubjectcat = "S0" & i.ToString,
                                                       .SubjectCat = "S7" & i.ToString}
                        _INISRecords.Add(rec)
                        k += 1
                    Next i
                Next j
                Return _INISRecords.AsQueryable()
            End Get
        End Property


    End Class
End Namespace