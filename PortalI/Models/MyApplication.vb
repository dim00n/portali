Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Web.Mvc

'TODO: Rename 'MyApplication' class.

Public Class MyApplication

    Private _MyApplicationID As Integer
    <ScaffoldColumn(False)>
    Public Property MyApplicationID() As Integer
        Get
            Return _MyApplicationID
        End Get
        Set(ByVal value As Integer)
            _MyApplicationID = value
        End Set
    End Property

    <Required()>
    <Display(Name:="Type", Prompt:="Application Type")>
    Public Property AppTypeId As Integer

    Private _Name As String
    <Required(ErrorMessage:="Application Name is required.")>
    <StringLength(60)>
    <Display(Name:="Name", Prompt:="Application Name")>
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    Private _Description As String
    Public Property Description() As String
        Get
            Return _Description
        End Get
        Set(ByVal value As String)
            _Description = value
        End Set
    End Property

    Private _Implemented As Boolean
    <Required()>
    <DefaultValue(False)>
    Public Property Implemented() As Boolean
        Get
            Return _Implemented
        End Get
        Set(ByVal value As Boolean)
            _Implemented = value
        End Set
    End Property


    Public Overridable Property AppType As ApplicationType




End Class
