Imports System.Web
Imports System.Web.Mvc

Public Class FakeControllerContext
    Inherits ControllerContext

    Private _context As HttpContextBase = New FakeHttpContext()

    Public Overrides Property HttpContext As HttpContextBase
        Get
            Return _context
        End Get
        Set(value As HttpContextBase)
            _context = value
        End Set
    End Property

End Class

Public Class FakeHttpContext
    Inherits HttpContextBase

    Private _request As HttpRequestBase = New FakeHttpRequest()

    Public Overrides ReadOnly Property Request As HttpRequestBase
        Get
            Return _request
        End Get
    End Property
End Class

Public Class FakeHttpRequest
    Inherits HttpRequestBase

    Default Public Overrides ReadOnly Property Item(key As String) As String
        Get
            'Return MyBase.Item(key)
            Return Nothing
        End Get
    End Property

    Public Overrides ReadOnly Property Headers As System.Collections.Specialized.NameValueCollection
        Get
            Return New System.Collections.Specialized.NameValueCollection
        End Get
    End Property
End Class
