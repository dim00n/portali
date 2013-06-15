
Public Class TestData

    Public Shared ReadOnly Property Languages() As IQueryable(Of Language)
        Get
            Dim _Languages = New List(Of Language)
            For j As Integer = Asc("A"c) To Asc("Z"c)
                For i As Integer = 0 To 9
                    Dim lang = New Language With {.LCode = Chr(j) & i.ToString, .LNameEnglish = Chr(j), .LNameOriginal = Chr(i)}
                    _Languages.Add(lang)
                Next i
            Next j
            Return _Languages.AsQueryable()
        End Get
    End Property

    Public Shared ReadOnly Property AssigningBodies() As IQueryable(Of AssigningBody)
        Get
            Dim _AssigningBodies = New List(Of AssigningBody)
            For j As Integer = Asc("A"c) To Asc("Z"c)
                For i As Integer = 0 To 9
                    Dim ab = New AssigningBody With {.AssigningBodyCode = Chr(j) & i.ToString, .AssigningBodyName = Chr(j), .AssigningBodyAdjective = Chr(i)}
                    _AssigningBodies.Add(ab)
                Next i
            Next j
            Return _AssigningBodies.AsQueryable()
        End Get
    End Property

    Public Shared ReadOnly Property MyApplications() As IQueryable(Of MyApplication)
        Get
            Dim _MyApplications = New List(Of MyApplication)
            _MyApplications.Add(New MyApplication With {.MyApplicationID = 11,
                                                        .Name = "Language",
                                                        .Description = "Language Authority",
                                                        .AppTypeId = 1})
            _MyApplications.Add(New MyApplication With {.MyApplicationID = 12,
                                                        .Name = "Country",
                                                        .Description = "Country Authority",
                                                        .AppTypeId = 1})
            _MyApplications.Add(New MyApplication With {.MyApplicationID = 25,
                                                        .Name = "New A",
                                                        .Description = "A new",
                                                        .AppTypeId = 2})
            Return _MyApplications.AsQueryable()
        End Get
    End Property

    Public Shared ReadOnly Property AppTypes() As IQueryable(Of ApplicationType)
        Get
            Dim _AppTypes = New List(Of ApplicationType)
            _AppTypes.Add(New ApplicationType With {.AppTypeId = ApplicationType.AppTypes.Authority,
                                                    .AppType = [Enum].GetName(GetType(ApplicationType.AppTypes), ApplicationType.AppTypes.Authority)})
            _AppTypes.Add(New ApplicationType With {.AppTypeId = ApplicationType.AppTypes.Application,
                                                    .AppType = [Enum].GetName(GetType(ApplicationType.AppTypes), ApplicationType.AppTypes.Application)})
            _AppTypes.Add(New ApplicationType With {.AppTypeId = ApplicationType.AppTypes.Service,
                                                    .AppType = [Enum].GetName(GetType(ApplicationType.AppTypes), ApplicationType.AppTypes.Service)})
            Return _AppTypes.AsQueryable()
        End Get
    End Property

End Class
