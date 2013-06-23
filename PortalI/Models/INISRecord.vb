Imports System.Web.Mvc

Public Class INISRecord

    Private _INISRecId As Integer
    Public Property INISRecId() As Integer
        Get
            Return _INISRecId
        End Get
        Set(ByVal value As Integer)
            _INISRecId = value
        End Set
    End Property

    Private _TRN As String
    Public Property TRN() As String
        Get
            Return _TRN
        End Get
        Set(ByVal value As String)
            _TRN = value
        End Set
    End Property

    Private _SubjectCat As String
    Public Property SubjectCat() As String
        Get
            Return _SubjectCat
        End Get
        Set(ByVal value As String)
            _SubjectCat = value
        End Set
    End Property

    Private _SecondarySubjectCat As String
    Public Property SecondarySubjectcat() As String
        Get
            Return _SecondarySubjectCat
        End Get
        Set(ByVal value As String)
            _SecondarySubjectCat = value
        End Set
    End Property

    Private _NumberOfAbstracts As Byte
    Public Property NumberOfAbstracts() As String
        Get
            Return _NumberOfAbstracts
        End Get
        Set(ByVal value As String)
            _NumberOfAbstracts = value
        End Set
    End Property

    Private _RecordType As Char
    Public Property RecordType() As Char
        Get
            Return _RecordType
        End Get
        Set(ByVal value As Char)
            _RecordType = value
        End Set
    End Property

    Private _BibLevels As String
    Public Property BibLevels() As String
        Get
            Return _BibLevels
        End Get
        Set(ByVal value As String)
            _BibLevels = value
        End Set
    End Property

    Private _LiteraryIndicator As String
    Public Property LiteraryIndicator() As String
        Get
            Return _LiteraryIndicator
        End Get
        Set(ByVal value As String)
            _LiteraryIndicator = value
        End Set
    End Property

    Private _IRPSJournalId As Integer
    Public Property IRPSJournalId() As Integer
        Get
            Return _IRPSJournalId
        End Get
        Set(ByVal value As Integer)
            _IRPSJournalId = value
        End Set
    End Property

    Private _ReportNo As String
    Public Property ReportNo() As String
        Get
            Return _ReportNo
        End Get
        Set(ByVal value As String)
            _ReportNo = value
        End Set
    End Property

    Private _BatchNo As String
    Public Property BatchNo() As String
        Get
            Return _BatchNo
        End Get
        Set(ByVal value As String)
            _BatchNo = value
        End Set
    End Property



End Class
