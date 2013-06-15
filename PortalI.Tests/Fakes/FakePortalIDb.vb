Imports System.Data.Entity

Public Class FakePortalIDb
    Implements IPortalIDb

    Public Sets As New Dictionary(Of Type, Object)()
    Public Added As New List(Of Object)
    Public Removed As New List(Of Object)
    Public Updated As New List(Of Object)
    Public Saved As Boolean = False

    Public Function Query(Of T As Class)() As System.Linq.IQueryable(Of T) Implements IPortalIDb.Query
        Return Sets(GetType(T))
    End Function

    Public Sub AddSet(Of T)(objects As System.Linq.IQueryable(Of T))
        Sets.Add(GetType(T), objects)
    End Sub

    Public Sub Add(Of T As Class)(entity As T) Implements IPortalIDb.Add
        Added.Add(entity)
    End Sub

    Public Sub Remove(Of T As Class)(entity As T) Implements IPortalIDb.Remove
        Removed.Add(entity)
    End Sub

    Public Sub Update(Of T As Class)(entity As T) Implements IPortalIDb.Update
        Updated.Add(entity)
    End Sub

    Public Sub Save() Implements IPortalIDb.Save
        Saved = True
    End Sub

    Public Function Find(Of T As Class)(key As Object) As T Implements IPortalIDb.Find
        Dim objects As List(Of T) = Sets(GetType(T))
        Return objects.Find(Function(x) x.Equals(key))
    End Function


#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' Dispose managed state (managed objects).
            End If

            ' Free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' Set large fields to null.
            Sets = Nothing
            Added = Nothing
            Removed = Nothing
            Updated = Nothing
        End If
        Me.disposedValue = True
    End Sub

    ' Override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    Protected Overrides Sub Finalize()
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(False)
        MyBase.Finalize()
    End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
