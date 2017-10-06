Imports System.Data.Odbc
Public Class clsConnection
    Sub New()

    End Sub

    Private _Name As String
    Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    Private _Conn As New OdbcConnection
    Property Conn() As OdbcConnection
        Get
            Return _Conn
        End Get
        Set(ByVal value As OdbcConnection)
            _Conn = value
        End Set
    End Property

    Private _Trans As OdbcTransaction
    Property Trans() As OdbcTransaction
        Get
            Return _Trans
        End Get
        Set(ByVal value As OdbcTransaction)
            _Trans = value
        End Set
    End Property


End Class
