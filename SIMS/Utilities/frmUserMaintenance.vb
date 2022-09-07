Imports MySql.Data.MySqlClient

Public Class frmUserMaintenance

    Private Sub CloseUser_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Sub Clear()
        tbUsername.Clear()
        tbPassword.Clear()
        tbComfirmPass.Clear()
        cbxRole.Text = Nothing
        tbFullname.Clear()
    End Sub

    Private Sub frmUserMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
        tbPassword.PasswordChar = Chr(149)
        tbComfirmPass.PasswordChar = Chr(149)
        tbUsername.Focus()
    End Sub

    Sub LoadUsers()
        dgvUserList.Rows.Clear()
        Dim i As Integer
        cmd = New MySqlCommand("SELECT * FROM users", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvUserList.Rows.Add(i, rd.Item("Username").ToString, rd.Item("Fullname").ToString, rd.Item("Usertype").ToString, "Delete")
        End While
        rd.Close()

    End Sub

    Private Sub SaveUser_Click(sender As Object, e As EventArgs) Handles SaveUser.Click
        Try
            'If IS_EMPTY(txtUser) = True Then Return
            'If IS_EMPTY(txtPass) = True Then Return
            'If IS_EMPTY(txtConfirm) = True Then Return
            'If IS_EMPTY(cboUserType) = True Then Return
            'If IS_EMPTY(txtName) = True Then Return
            If tbUsername.Text = Nothing Or tbPassword.Text = Nothing Or tbFullname.Text = Nothing Then
                MsgBox("Check missing field!", vbCritical)
                Return
            End If

            If tbPassword.Text <> tbComfirmPass.Text Then
                MsgBox("Confirm password did not match!", vbCritical)
                Return
            ElseIf MsgBox("Are you sure you want to save this New User?", vbYesNo + vbQuestion) = vbYes Then
                ' cn.Open()
                cmd = New MySqlCommand("insert into users (username, password, fullname, usertype) values(@username, @password, @fullname, @utype)", cdb)
                cmd.Parameters.AddWithValue("@username", tbUsername.Text)
                cmd.Parameters.AddWithValue("@password", EncryptData(tbPassword.Text))
                cmd.Parameters.AddWithValue("@fullname", tbFullname.Text)
                cmd.Parameters.AddWithValue("@utype", cbxRole.Text)
                cmd.ExecuteNonQuery()
                ' cn.Close()
                MsgBox("New User has been successfully saved.", vbInformation)
                Clear()
                LoadUsers()
            End If
        Catch ex As Exception
            ' cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class