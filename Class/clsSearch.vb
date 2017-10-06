Imports System.Data.Odbc
Public Class clsSearch

    Private _EID As String
    Property EID() As String
        Get
            Return _EID
        End Get
        Set(ByVal value As String)
            _EID = value
        End Set
    End Property
End Class
