Imports System.Data.Odbc
Imports System.Text
Public Class clsShiftID
    Private Const ModCode As String = "clsShiftID"
    Private strSQL As New StringBuilder
    Private cmd As New OdbcCommand
    Private da As New OdbcDataAdapter

    Public Function GetShiftGroupListing(ByRef Conn As OdbcConnection) As DataTable
        Dim dt As New DataTable
        Try
            strSQL = New StringBuilder
            With strSQL
                .Append("SELECT shiftid,shiftname,color")
                .Append(" FROM tams_shift")
                .Append(" ORDER BY shiftid")
            End With
            da = New OdbcDataAdapter(strSQL.ToString, Conn)
            da.Fill(dt)
        Catch ex As Exception
            ShowError(ModCode & " - GetUserGroupListing", ex.ToString)
        End Try
        Return dt
    End Function

    Public Function GetShiftCat(ByRef Conn As OdbcConnection) As DataTable
        Dim dt As New DataTable
        Try
            strSQL = New StringBuilder
            With strSQL
                .Append("SELECT Shift_Cat")
                .Append(" FROM tams_shift")
                .Append(" GROUP BY Shift_Cat")
            End With
            da = New OdbcDataAdapter(strSQL.ToString, Conn)
            da.Fill(dt)
        Catch ex As Exception
            ShowError(ModCode & " - GetShiftCat", ex.ToString)
        End Try
        Return dt
    End Function
End Class
