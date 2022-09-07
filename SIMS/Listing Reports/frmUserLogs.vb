Imports MySql.Data.MySqlClient

Public Class frmUserLogs

    Private Sub frmUserLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsersToCombox()
        LoadAllUserTransaction()

    End Sub

    Sub LoadUsersToCombox()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand
        cboUser.Items.Clear()
        cboUser.DisplayMember = "text"
        qry = "Select * from users ORDER BY username"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            cboUser.Items.Add(New With {.Text = relr("username").ToString(), .Value = relr("username").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub

    Private Sub chkAllUsers_CheckedChanged(sender As Object, e As EventArgs)
        'If chkAllUserTransaction.Checked = True Then
        '    cboUser.Text = Nothing
        'End If
        'LoadAllUserTransaction()
    End Sub

    Sub LoadAllUserTransaction()
        With dgvUserLogs
            dgvUserLogs.Rows.Clear()
            Dim i As Integer

            cmd = New MySqlCommand("SELECT * FROM audittrail ORDER BY pkno asc", cdb)
            rd = cmd.ExecuteReader
            While rd.Read
                i += 1
                dgvUserLogs.Rows.Add(i, rd.Item("user").ToString, _
                                        rd.Item("transactions").ToString, _
                                        rd.Item("module").ToString, _
                                        rd.Item("sdate").ToString, _
                                        rd.Item("stime").ToString)
            End While
            rd.Close()
            cmd.Dispose()
        End With
    End Sub

    Private Sub cboUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUser.SelectedIndexChanged
        cmd = New MySqlCommand("SELECT * from users where username like '%" & cboUser.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            With rd
                txtFullname.Text = rd.Item("fullname").ToString
            End With
        End If
        rd.Close()
    End Sub

    Private Sub Go_Click(sender As Object, e As EventArgs) Handles Go.Click
        Dim i As Integer
        Dim qry As String = Nothing
        dgvUserLogs.Rows.Clear()
        If cboUser.Text <> Nothing Then
            cmd = New MySqlCommand("SELECT * FROM audittrail WHERE sDate >= '" & Format(sDate1.Value, "yyyy-MM-dd") & "' and sDate <= '" & Format(sDate2.Value, "yyyy-MM-dd") & "'" & " and user like  '" & cboUser.Text & "' ORDER BY pkno asc", cdb)
            rd = cmd.ExecuteReader
            While rd.Read
                i += 1
                dgvUserLogs.Rows.Add(i, rd.Item("user").ToString, rd.Item("transactions").ToString, _
                                 rd.Item("module").ToString, rd.Item("sdate").ToString, _
                                 rd.Item("stime").ToString)
            End While
            rd.Close()
            cmd.Dispose()
        Else
            cmd = New MySqlCommand("SELECT * FROM audittrail WHERE sDate >= '" & Format(sDate1.Value, "yyyy-MM-dd") & "' and sDate <= '" & Format(sDate2.Value, "yyyy-MM-dd") & "'" & "  ORDER BY sdate, stime asc", cdb)
            rd = cmd.ExecuteReader
            While rd.Read
                i += 1
                dgvUserLogs.Rows.Add(i, rd.Item("user").ToString, rd.Item("transactions").ToString, _
                                 rd.Item("module").ToString, rd.Item("sdate").ToString, _
                                 rd.Item("stime").ToString)
            End While
            rd.Close()
            cmd.Dispose()
        End If

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        cboUser.Text = Nothing
        txtFullname.Clear()
        LoadAllUserTransaction()
    End Sub
End Class