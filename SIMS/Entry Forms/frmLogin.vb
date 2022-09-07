Imports MySql.Data.MySqlClient

Public Class frmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        condb()
        tbpwd.PasswordChar = Chr(149)
        tbuser.Focus()
    End Sub

    Private Sub tbuser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbuser.KeyPress
        If e.KeyChar = vbCr Then
            If tbuser.Text = Nothing Then
                MsgBox("Enter Username!", vbCritical)
                Return
            Else
                tbpwd.Focus()
            End If
        End If

    End Sub

    Private Sub tbpwd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbpwd.KeyPress
        If e.KeyChar = vbCr Then
            btnLogin.Focus()
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs)

        If Trim(tbuser.Text) <> Nothing And Trim(tbpwd.Text) <> Nothing Then
            Dim sq As String = Nothing

            sq = "SELECT utype FROM useraccnt where BINARY Username=@unem And BINARY Password=@pword"
            Using cmd = New MySqlCommand
                cmd.Connection = cdb
                cmd.Parameters.AddWithValue("@unem", tbuser.Text.ToString.Trim)
                cmd.Parameters.AddWithValue("@pword", tbpwd.Text.ToString.Trim)
                cmd.CommandText = sq
                cmd.CommandType = CommandType.Text
                Using rdr As MySqlDataReader = cmd.ExecuteReader()
                    If rdr.HasRows = True Then
                        rdr.Read()
                        usertyp = rdr("utype").ToString
                        rdr.Dispose()
                        MsgBox("Access Granted", 64, "Successful : Access Granted")
                        tbuser.Text = Nothing
                        tbpwd.Text = Nothing
                        tbuser.Focus()
                        Me.Hide()
                        MDIParent1.Show()
                    Else
                        MsgBox("Unknown Username and Password!", 48, "Unknown User Information")
                    End If
                End Using
            End Using
        Else
            MsgBox("Please Input Username and Password", 48, "Username and Password Field is Empty")
        End If
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tbpwd.Text = String.Empty Or tbuser.Text = String.Empty Then
            MsgBox("Required missing field!", vbCritical)
            Return
        End If

        Dim found As Boolean = False

        cmd = New MySqlCommand("select * from users where BINARY username = @username", cdb)
        With cmd
            .Parameters.AddWithValue("@username", tbuser.Text)
            '  .Parameters.AddWithValue("@password", tbpwd.Text)
        End With
        rd = cmd.ExecuteReader

        If rd.HasRows Then
            rd.Read()
            _pass = rd.Item("password").ToString
            If DecryptData(_pass) = tbpwd.Text.Trim Then
                found = True
                _user = rd.Item("username").ToString
                _pass = DecryptData(_pass)
                '_pass = _pass
                _name = rd.Item("fullname").ToString
                _usertype = rd.Item("usertype").ToString
            End If
        Else
            found = False
            _user = ""
            _pass = ""
            _name = ""
        End If
        rd.Close()
        '   cn.Close()

        If found = False Then
            MsgBox("Access Denied! Invalid username or password!", vbCritical)
            Exit Sub
        End If

        If found = True Then
            If _usertype <> "Administrator" Then
                With MDIParent1
                    tbuser.Clear()
                    tbpwd.Clear()
                    Me.Hide()
                    .lbluser.Text = _user
                    .tsipadd.Text = mysvrip
                    '.lblip.Text = "Localhost"
                    AuditTrail("Login", "Login")
                    .ShowDialog()
                End With
            Else
                With MDIParent1
                    tbuser.Clear()
                    tbpwd.Clear()
                    Me.Hide()
                    .lbluser.Text = _user
                    .tsipadd.Text = mysvrip
                    '.lblip.Text = "Localhost"
                    AuditTrail("Login", "Login")
                    .ShowDialog()
                End With
                'MsgBox("Access Denied! Invalid username or password .", vbExclamation)
            End If
            'Else
            '    MsgBox("Access Granted! Welcome " & _name & "!", vbInformation)
            '    AuditTrail("Login", "Login Module")
            'End If
        End If

        'Catch ex As Exception
        '    cn.Close()
        '    MsgBox(ex.Message, vbCritical)
        'End Try


        '================================
        'If Trim(tbuser.Text) <> Nothing And Trim(tbpwd.Text) <> Nothing Then
        '    Dim sq As String = Nothing

        '    sq = "SELECT * FROM useraccnt where BINARY Username=@unem And BINARY Password=@pword"
        '    Using cmd = New MySqlCommand
        '        cmd.Connection = cdb
        '        cmd.Parameters.AddWithValue("@unem", tbuser.Text.ToString.Trim)
        '        cmd.Parameters.AddWithValue("@pword", tbpwd.Text.ToString.Trim)
        '        cmd.CommandText = sq
        '        cmd.CommandType = CommandType.Text
        '        Using rdr As MySqlDataReader = cmd.ExecuteReader()
        '            If rdr.HasRows = True Then
        '                rdr.Read()
        '                usertyp = rdr("role").ToString
        '                str_user = rdr("username").ToString
        '                rdr.Dispose()
        '                ' MsgBox("Access Granted", 64, "Successful : Access Granted")
        '                AuditTrail("Login", "Login Module")
        '                tbuser.Text = Nothing
        '                tbpwd.Text = Nothing
        '                tbuser.Focus()
        '                Me.Hide()
        '                MDIParent1.Show()
        '            Else
        '                MsgBox("Unknown Username and Password!", 48, "Unknown User Information")
        '            End If
        '        End Using
        '    End Using
        'Else
        '    MsgBox("Please Input Username and Password", 48, "Username and Password Field is Empty")
        'End If


        '=======================================
        'Dim found As Boolean = False

        'If Trim(tbuser.Text) <> Nothing And Trim(tbpwd.Text) <> Nothing Then
        '    Dim sq As String = Nothing

        '    sq = "SELECT * FROM useraccnt where BINARY Username=@unem And BINARY Password=@pword"
        '    Using cmd = New MySqlCommand
        '        cmd.Connection = cdb
        '        cmd.Parameters.AddWithValue("@unem", tbuser.Text.ToString.Trim)
        '        cmd.Parameters.AddWithValue("@pword", tbpwd.Text.ToString.Trim)
        '        cmd.CommandText = sq
        '        cmd.CommandType = CommandType.Text
        '        Using rdr As MySqlDataReader = cmd.ExecuteReader()
        '            If rdr.HasRows = True Then
        '                rdr.Read()
        '                str_pass = rdr("password").ToString
        '                If DecryptData(str_pass) = tbpwd.Text.Trim Then
        '                    found = True
        '                    str_pass = DecryptData(str_pass)
        '                    str_role = rdr("role").ToString
        '                    str_user = rdr("username").ToString
        '                End If
        '                rdr.Dispose()
        '                MsgBox("Access Granted", 64, "Successful : Access Granted")
        '                AuditTrail("Login", "Login Module")
        '                tbuser.Text = Nothing
        '                tbpwd.Text = Nothing
        '                tbuser.Focus()
        '                Me.Hide()
        '                MDIParent1.Show()
        '            Else
        '                MsgBox("Unknown Username and Password!", 48, "Unknown User Information")
        '            End If
        '        End Using
        '    End Using
        'Else
        '    MsgBox("Please Input Username and Password", 48, "Username and Password Field is Empty")
        'End If
    End Sub

    Private Sub tbuser_TextChanged(sender As Object, e As EventArgs) Handles tbuser.TextChanged

    End Sub
End Class
