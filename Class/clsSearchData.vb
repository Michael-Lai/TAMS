Imports System.Data.Odbc
Imports System.Text

Public Class clsSearchData

    Private strSQL As New StringBuilder
    Private cmd As New OdbcCommand
    Private da As New OdbcDataAdapter

    Public Function FindData(ByVal strData As String, ByRef Conn As clsConnection) As DataTable
        Dim dt As New DataTable
        Try
            strSQL = New StringBuilder
            With strSQL
                .Append("SELECT RowNo,LeaveID,TYPE,Emp_ID,StaffID, ")
                .Append(" NAME,DateFrom,DateTo,TimeFrom,")
                .Append("TimeTo,Remark,CreatedBy,DateCreated ")
                .Append(" FROM tams_holiday WHERE RowNo= '" & strData & "'")
            End With
            If Conn.Trans Is Nothing Then
                cmd = New OdbcCommand(strSQL.ToString, Conn.Conn)
            Else
                cmd = New OdbcCommand(strSQL.ToString, Conn.Conn, Conn.Trans)
            End If
            da = New OdbcDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return dt
    End Function
End Class
