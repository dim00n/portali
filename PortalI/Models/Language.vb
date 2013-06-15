Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Web.Mvc

Public Class Language

    Private _LCode As String
    <Key()>
    <Required(ErrorMessage:="Language Code is required.")>
    <StringLength(2, minimumLength:=2, ErrorMessage:="Language Code must be 2 characters.")>
    <DisplayName("Language Code")>
    Public Property LCode() As String
        Get
            Return _LCode
        End Get
        Set(ByVal value As String)
            _LCode = value
        End Set
    End Property

    Private _LNameEnglish As String
    <Required(ErrorMessage:="Language Name is required")>
    <StringLength(60, ErrorMessage:="Language Name must be between 0 and 255 characters.")>
    <DisplayName("Language Name")>
    Public Property LNameEnglish() As String
        Get
            Return _LNameEnglish
        End Get
        Set(ByVal value As String)
            _LNameEnglish = value
        End Set
    End Property

    Private _LNameOriginal As String
    <StringLength(255, ErrorMessage:="Original Name must be between 0 and 255 characters.")>
    <DisplayName("Original Name")>
    Public Property LNameOriginal() As String
        Get
            Return _LNameOriginal
        End Get
        Set(ByVal value As String)
            _LNameOriginal = value
        End Set
    End Property


End Class
