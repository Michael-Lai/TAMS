Imports System.Data.Odbc
Imports System.Text
Public Class clsUserGroupRight
    Private Const ModCode As String = "clsDBUserGroup"

    Private strSQL As StringBuilder
    Private cmd As OdbcCommand
    Private da As OdbcDataAdapter

    Public Function AddUserGroup(ByVal USERGROUP As clsUserGroupRight, ByRef Conn As clsConnection) As Boolean
        Dim ret As Integer = 0
        Try
            strSQL = New StringBuilder
            With strSQL
                .Append("INSERT INTO MAS_OUTLETUSERGROUP(GroupID, GroupName, IsActive, IsFullAccess,")
                .Append(" CreatedBy, ModifiedBy, DateCreated)")
                .Append(" VALUES(?,?,?,?,?,?,?)")
            End With
            cmd = New OdbcCommand(strSQL.ToString, Conn.Conn, Conn.Trans)
            With cmd.Parameters
                '.Add(New OdbcParameter("GroupID", CSQLQuote(USERGROUP.GroupID)))
                '.Add(New OdbcParameter("GroupName", CSQLQuote(USERGROUP.GroupName)))
                '.Add(New OdbcParameter("IsActive", CSQLBoolean(USERGROUP.IsActive)))
                '.Add(New OdbcParameter("IsFullAccess", CSQLBoolean(USERGROUP.IsFullAccess)))
                '.Add(New OdbcParameter("CreatedBy", CSQLQuote(USERGROUP.Ref.CreatedBy)))
                '.Add(New OdbcParameter("ModifiedBy", CSQLQuote(USERGROUP.Ref.ModifiedBy)))
                '.Add(New OdbcParameter("DateCreated", CSQLDateTime(USERGROUP.Ref.DateCreated)))
            End With
            ret = cmd.ExecuteNonQuery

        Catch ex As Exception
            MsgBox(ex.ToString)
            ret = 0
        End Try

        Return IIf(ret = 0, False, True)
    End Function
    Public Function AddUserGroupRight(ByVal GROUPRIGHT As clsUserGroupRight, ByRef Conn As clsConnection) As Boolean
        Dim ret As Integer = 0
        Try
            strSQL = New StringBuilder
            With strSQL
                .Append("INSERT INTO TAMS_USERGROUPRIGHT(GroupID, FormName, CanView, CanAdd, CanEdit,")
                .Append(" CanCancel, CanPrint, Custom1, Custom2, CreatedBy, ModifiedBy, DateCreated)")
                .Append(" VALUES(?,?,?,?,?,?,?,?,?,?,?,?)")
            End With
            cmd = New OdbcCommand(strSQL.ToString, Conn.Conn, Conn.Trans)
            With cmd.Parameters
                '.Add(New OdbcParameter("GroupID", CSQLQuote(GROUPRIGHT.GroupID)))
                '.Add(New OdbcParameter("FormName", CSQLQuote(GROUPRIGHT.FromName)))
                '.Add(New OdbcParameter("CanView", CSQLBoolean(GROUPRIGHT.CanView)))
                '.Add(New OdbcParameter("CanAdd", CSQLBoolean(GROUPRIGHT.CanAdd)))
                '.Add(New OdbcParameter("CanEdit", CSQLBoolean(GROUPRIGHT.CanEdit)))
                '.Add(New OdbcParameter("CanCancel", CSQLBoolean(GROUPRIGHT.CanCancel)))
                '.Add(New OdbcParameter("CanPrint", CSQLBoolean(GROUPRIGHT.CanPrint)))
                '.Add(New OdbcParameter("Custom1", CSQLBoolean(GROUPRIGHT.Custom1)))
                '.Add(New OdbcParameter("Custom2", CSQLBoolean(GROUPRIGHT.Custom2)))
                '.Add(New OdbcParameter("CreatedBy", CSQLQuote(GROUPRIGHT.Ref.CreatedBy)))
                '.Add(New OdbcParameter("ModifiedBy", CSQLQuote(GROUPRIGHT.Ref.ModifiedBy)))
                '.Add(New OdbcParameter("DateCreated", CSQLDateTime(GROUPRIGHT.Ref.DateCreated)))
            End With
            ret = cmd.ExecuteNonQuery
        Catch ex As Exception
            MsgBox(ex.ToString)
            ret = 0
        End Try
        Return IIf(ret = 0, False, True)
    End Function
End Class
