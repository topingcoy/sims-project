Imports MySql.Data.MySqlClient

Public Class frmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
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

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        condb()
    End Sub

End Class
