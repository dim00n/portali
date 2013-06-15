Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Web.Mvc

Public Class ApplicationType

    Public Enum AppTypes As Integer
        Authority = 1
        Application = 2
        Service = 3
    End Enum

    Private _AppTypeId As Integer
    <Key()>
    <Required()>
    <EnumDataType(GetType(AppTypes))>
    Public Property AppTypeId() As Integer
        Get
            Return _AppTypeId
        End Get
        Set(ByVal value As Integer)
            _AppTypeId = value
        End Set
    End Property

    Private _AppType As String
    <Required()>
    Public Property AppType() As String
        Get
            Return _AppType
        End Get
        Set(ByVal value As String)
            _AppType = value
        End Set
    End Property

End Class
