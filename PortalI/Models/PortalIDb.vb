Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.SqlClient

Public Interface IPortalIDb
    Inherits IDisposable

    Function Query(Of T As Class)() As IQueryable(Of T)
    Sub Add(Of T As Class)(entity As T)
    Sub Update(Of T As Class)(entity As T)
    Sub Remove(Of T As Class)(entity As T)
    Sub Save()
    Function Find(Of T As Class)(key As Object) As T

End Interface

Public Class PortalIDb
    Inherits DbContext
    Implements IPortalIDb


    Private _MyApplications As DbSet(Of MyApplication)
    Public Property MyApplications() As DbSet(Of MyApplication)
        Get
            Return _MyApplications
        End Get
        Set(ByVal value As DbSet(Of MyApplication))
            _MyApplications = value
        End Set
    End Property

    Private _AssigningBodies As DbSet(Of AssigningBody)
    Public Property AssigningBodies() As DbSet(Of AssigningBody)
        Get
            Return _AssigningBodies
        End Get
        Set(ByVal value As DbSet(Of AssigningBody))
            _AssigningBodies = value
        End Set
    End Property

    Private _Languages As DbSet(Of Language)
    Public Property Languages() As DbSet(Of Language)
        Get
            Return _Languages
        End Get
        Set(ByVal value As DbSet(Of Language))
            _Languages = value
        End Set
    End Property

    Private _UserProfiles As DbSet(Of UserProfile)
    Public Property UserProfiles() As DbSet(Of UserProfile)
        Get
            Return _UserProfiles
        End Get
        Set(ByVal value As DbSet(Of UserProfile))
            _UserProfiles = value
        End Set
    End Property

    Private _AppTypes As DbSet(Of ApplicationType)
    Public Property AppTypes() As DbSet(Of ApplicationType)
        Get
            Return _AppTypes
        End Get
        Set(ByVal value As DbSet(Of ApplicationType))
            _AppTypes = value
        End Set
    End Property


    Public Sub New()
        MyBase.New("name=DefaultConnection")
    End Sub

    Public Function Query(Of T As Class)() As System.Linq.IQueryable(Of T) Implements IPortalIDb.Query
        Return [Set](Of T)()
    End Function

    Public Sub Add(Of T As Class)(entity As T) Implements IPortalIDb.Add
        [Set](Of T)().Add(entity)
    End Sub

    Public Sub Remove(Of T As Class)(entity As T) Implements IPortalIDb.Remove
        [Set](Of T)().Remove(entity)
    End Sub

    Public Sub Update(Of T As Class)(entity As T) Implements IPortalIDb.Update
        Entry(entity).State = EntityState.Modified
    End Sub

    Public Function Find(Of T As Class)(key As Object) As T Implements IPortalIDb.Find
        Return [Set](Of T)().Find(key)
    End Function

    Public Sub Save() Implements IPortalIDb.Save
        Try
            SaveChanges()
        Catch dbUpEx As DbUpdateException
            Dim ex As Exception = dbUpEx
            While Not ex.InnerException Is Nothing
                ex = ex.InnerException
            End While
            Dim sqlEx As SqlException = DirectCast(ex, SqlException)
            Throw sqlEx
        End Try
    End Sub

End Class
