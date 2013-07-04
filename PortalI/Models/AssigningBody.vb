Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Web.Mvc

Public Class AssigningBody

    Private _AssigningBodyCode As String
    <Key()>
    <Required(ErrorMessage:="Country Code is required.")>
    <StringLength(2, minimumLength:=2, ErrorMessage:="Country Code must be 2 characters.")>
    <DisplayName("Country Code")>
    Public Property AssigningBodyCode() As String
        Get
            Return _AssigningBodyCode
        End Get
        Set(ByVal value As String)
            _AssigningBodyCode = value
        End Set
    End Property

    Private _AssigningBodyName As String
    <Required(ErrorMessage:="Country Name is required.")>
    <StringLength(60, ErrorMessage:="Country Name must be between 0 and 60 characters.")>
    <DisplayName("Country Name")>
    Public Property AssigningBodyName() As String
        Get
            Return _AssigningBodyName
        End Get
        Set(ByVal value As String)
            _AssigningBodyName = value
        End Set
    End Property

    Private _AssigningBodyAdjective As String
    <StringLength(30, ErrorMessage:="Country Adjective must be between 0 and 30 characters.")>
    <DisplayName("Adjective")>
    Public Property AssigningBodyAdjective() As String
        Get
            Return _AssigningBodyAdjective
        End Get
        Set(ByVal value As String)
            _AssigningBodyAdjective = value
        End Set
    End Property


End Class
