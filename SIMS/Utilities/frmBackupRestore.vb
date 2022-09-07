Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmBackupRestore
    Dim Sqlconnection As MySqlConnection
    Dim dt As New DataTable
    Dim cmd As String
    Dim dtseCt As Integer
    Dim da As MySqlDataAdapter


    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Try
            Dim constring As String = Nothing
            constring = "server=" & txtServer.Text & ";user id=" & txtUser.Text & ";password=" & txtPass.Text & ";"
            Using con As New MySqlConnection(constring)
                Using cmd As New MySqlCommand("SELECT DISTINCT TABLE_SCHEMA FROM information_schema.TABLES", con)
                    cmd.CommandType = CommandType.Text
                    da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
            'cmd = "SELECT DISTINCT TABLE_SCHEMA FROM information_schema.TABLES"
            'da = New MySqlDataAdapter(cmd, Sqlconnection)
            'da.Fill(dt)
            dtseCt = 0
            cbDatabase.Enabled = True
            cbDatabase.Items.Clear()
            cbDatabase.Items.Add("== Select Database ==")

            While dtseCt <= dt.Rows.Count - 1
                cbDatabase.Items.Add(dt.Rows(dtseCt)(0).ToString())
                dtseCt = dtseCt + 1
            End While

            cbDatabase.SelectedIndex = 0
            btnConnect.Enabled = False
            btnBackup.Enabled = True
            btnRestore.Enabled = True

            'Sqlconnection.Clone()
            dt.Dispose()
            da.Dispose()

        Catch ex As Exception
            MsgBox("Connection Failed!")
        End Try
    End Sub

    Public Sub koneksi()
        Try
            Sqlconnection = New MySqlConnection("server=" & txtServer.Text & ";user id=" & txtUser.Text & ";password=" & txtPass.Text & ";")
            If Sqlconnection.State = ConnectionState.Closed Then
                Sqlconnection.Open()

            End If
        Catch ex As Exception
            MsgBox("Connection Failed!")
        End Try
    End Sub

    Private Sub btnConnect_DoubleClick(sender As Object, e As EventArgs) Handles btnConnect.DoubleClick

    End Sub

    Private Sub btnBackup_Click(sender As Object, ByVal e As EventArgs) Handles btnBackup.Click
        Dim dbFile As String = Nothing

        ' Try
        SaveFileDialog1.Filter = "SQL Dump File (*.sql)|*.sql|All files(*.*)|*.*"
        SaveFileDialog1.FileName = "Database Backup" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            'koneksi()
            dbFile = SaveFileDialog1.FileName
            btnBackup.Text = "Please wait system is creating backup file.."
            btnBackup.Enabled = False
            btnRestore.Enabled = False
            Dim BackupProcess As New Process

            BackupProcess.StartInfo.FileName = "cmd.exe"
            BackupProcess.StartInfo.UseShellExecute = False
            BackupProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            BackupProcess.StartInfo.CreateNoWindow = True
            BackupProcess.StartInfo.WorkingDirectory = "D:\xampp\mysql\bin\"
            BackupProcess.StartInfo.RedirectStandardInput = True
            BackupProcess.StartInfo.RedirectStandardOutput = True

            BackupProcess.Start()
            Timer1.Start()

            Dim BackupStream As StreamWriter = BackupProcess.StandardInput
            Dim myStreamReader As StreamReader = BackupProcess.StandardOutput
            'Dim startInfo As New ProcessStartInfo("mysqldump.exe", "-h " & TextBox1.Text & " -u " & TextBox2.Text & " -p" & TextBox3.Text & " " & ComboBox1.Text & " -r """ & dbFile & """")
            ' startInfo.WindowStyle = ProcessWindowStyle.Hidden

            Application.DoEvents()
            ' Process.Start(startInfo)

            BackupStream.WriteLine("mysqldump -u " & txtUser.Text & " -p" & txtPass.Text & " -h " & txtServer.Text & " " & cbDatabase.Text & " -r """ + dbFile + """")

            BackupStream.Close()

            BackupProcess.WaitForExit()
            BackupProcess.Close()
            ' Sqlconnection.Close()

            MsgBox("Backup your MYSQL database Created Successfully!", MsgBoxStyle.Information, "Backup MySql Database")
            btnBackup.Text = "Backup Database"
            btnBackup.Enabled = True
            btnRestore.Enabled = True
        End If

        ' Catch ex As Exception
        'MsgBox("Nothing to do!")

        ' End Try
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Dim dbFile As String = Nothing

        Try
            OpenFileDialog1.Filter = "SQL Dump File (*.sql)|*.sql|All files(*.*)|*.*"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                'koneksi()

                btnRestore.Text = "Please wait system is restoring database..."
                btnRestore.Enabled = False
                btnBackup.Enabled = False
                dbFile = OpenFileDialog1.FileName
                Dim BackupProcess As New Process
                BackupProcess.StartInfo.FileName = "cmd.exe"
                BackupProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                BackupProcess.StartInfo.CreateNoWindow = True
                BackupProcess.StartInfo.UseShellExecute = False
                BackupProcess.StartInfo.WorkingDirectory = "D:\xampp\mysql\bin\"
                BackupProcess.StartInfo.RedirectStandardInput = True
                BackupProcess.StartInfo.RedirectStandardOutput = True
                BackupProcess.Start()

                Dim BackupStream As StreamWriter = BackupProcess.StandardInput
                Dim myStreamReader As StreamReader = BackupProcess.StandardOutput
                BackupStream.WriteLine("mysql --user=" & txtUser.Text & " --password=" & txtPass.Text & " -h " & txtServer.Text & " " & cbDatabase.Text & " < """ + dbFile + """")


                BackupStream.Close()
                BackupProcess.WaitForExit()
                BackupProcess.Close()
                'Sqlconnection.Close()
                'Dim startInfo As New ProcessStartInfo("mysql.exe", "-h " & TextBox1.Text & " -u " & TextBox2.Text & " -p" & TextBox3.Text & " " & ComboBox1.Text & " < """ & dbFile & """")
                'startInfo.WindowStyle = ProcessWindowStyle.Normal

                Application.DoEvents()

                'Process.Start(startInfo)
                MsgBox("Restore your MYSQL database Successfully!", MsgBoxStyle.Information, "Restore MySql Database")
                btnRestore.Text = "Restore Database"
                btnBackup.Enabled = True
                btnRestore.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Nothing to do!")
        End Try
    End Sub

    Private Sub frmBackupRestore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnConnect.Enabled = True
        btnBackup.Enabled = False
        btnRestore.Enabled = False
        txtPass.PasswordChar = Chr(149)
        txtUser.Focus()
    End Sub

    Private Sub BackupMySql()

        Dim localDir As String = "path to where to save file"
        Dim strDate As String = Date.Now.ToShortDateString   'Prepend file with date for dated backups
        Dim fileName As String = strDate.Replace("/", "-") ' & "_" & ftphost & ".sql"
        Dim saveFile As String = localDir & fileName
        Dim DBServer As String = "mysql host"
        Dim DBServerPort As String = "mysql port"
        Dim Database As String = "database name"
        Dim DBUser As String = "mysql username"
        Dim DBPass As String = "mysql password"
        Dim MyConString As String = "SERVER=" & DBServer & ";DATABASE=" & Database & ";UID=" & DBUser & ";PASSWORD=" & DBPass
        Dim connection As New MySqlConnection(MyConString)
        Dim tablesCommand As MySqlCommand = connection.CreateCommand()
        Dim rowsCommand As MySqlCommand = connection.CreateCommand()
        Dim tablesReader As MySqlDataReader
        Dim rowsReader As MySqlDataReader

        tablesCommand.CommandText = "SHOW TABLES FROM " & Database
        connection.Open()
        tablesReader = tablesCommand.ExecuteReader()

        Dim query As String = ""
        Dim tablesArray As New ArrayList()
        While tablesReader.Read()
            tablesArray.Add(tablesReader.GetValue(0).ToString())
        End While
        tablesReader.Close()
        For i = 0 To tablesArray.Count - 1
            query += "DROP TABLE IF EXISTS `" & tablesArray(i) & "`;" & vbCrLf '& Database & "."
            query += vbCrLf & "CREATE TABLE `" & tablesArray(i) & "` (" & vbCrLf
            rowsCommand.CommandText = "DESCRIBE " & tablesArray(i)
            rowsReader = rowsCommand.ExecuteReader()

            Dim temp As String = ""
            While rowsReader.Read()
                query += "`" & rowsReader.GetString("Field") & "` " & rowsReader.GetString("Type")
                If Not rowsReader.GetString("Null") = "YES" Then
                    query += " NOT NULL"
                End If
                If IsDBNull(rowsReader.Item("Default")) = False Then
                    query += " DEFAULT '" & rowsReader.GetString("Default") & "'"
                End If
                If Not rowsReader.GetString("Extra") = Nothing Then
                    query += " " & rowsReader.GetString("Extra").ToUpper()
                End If
                If rowsReader.GetString("Key") = "PRI" Then
                    temp = "primary key(" & rowsReader.GetString("Field") & ")"
                End If
                query += "," & vbCrLf
            End While

            query += temp & vbCrLf & ");" & vbCrLf & vbCrLf

            rowsReader.Close()
            rowsCommand.CommandText = "SELECT * FROM " & tablesArray(i)

            rowsReader = rowsCommand.ExecuteReader()
            While rowsReader.Read()
                query += "INSERT INTO `" & tablesArray(i) & "` ("
                Dim count As Integer = rowsReader.FieldCount - 1
                Dim keys(count) As String
                Dim values(count) As String

                For n = 0 To count
                    keys(n) = rowsReader.GetName(n)
                    values(n) = rowsReader.Item(n)
                Next
                query += Join(keys, ", ") & ")" & vbCrLf & "VALUES ('" & Join(values, "', '") & "');" & vbCrLf
            End While

            rowsReader.Close()
            query += vbCrLf & vbCrLf

        Next
        connection.Close()
        connection.Dispose()

        If File.Exists(saveFile) Then
            File.Delete(saveFile)
        End If

        Dim objWriter As New System.IO.StreamWriter(saveFile)
        objWriter.Write(query)
        objWriter.Close()

    End Sub

    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As System.Windows.Forms.Keys) As Integer

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("D:\xampp\mysql\bin\mysqldump.exe --user=root --password=; --host=localhost  --databases ANIMALAIDE -r C:\AA.sql")
        Dim myProcess As New Process()
        myProcess.StartInfo.FileName = "cmd.exe"
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.WorkingDirectory = "[MYSQL BIN PATH LOCATION]"
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.Start()
        Dim myStreamerWriter As StreamWriter = myProcess.StandardInput
        Dim myStreamerReader As StreamReader = myProcess.StandardOutput
        'myStreamerWriter.WriteLine("mysql -u [USERNAME] -p [YOUR PASSWORD] [DATABASE NAME] < [BACKUP DATABASE LOCATION]")
        myStreamerWriter.WriteLine("mysql -u [root] -p [] [ANIMALAIDE] < [C:\BACKUP]")
        myStreamerWriter.Close()
        myProcess.WaitForExit()
        myProcess.Close()

    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim myProcess As New Process()
        myProcess.StartInfo.FileName = "cmd.exe"
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.WorkingDirectory = "D:\xampp\mysql\bin"
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.Start()
        Dim myStreamerWriter As StreamWriter = myProcess.StandardInput
        Dim myStreamerReader As StreamReader = myProcess.StandardOutput
        myStreamerWriter.WriteLine("mysql -u root skripsi < D:\Backup\Database.sql")
        myStreamerWriter.Close()
        myProcess.WaitForExit()
        myProcess.Close()
    End Sub

    Private Sub txtServer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtServer.KeyPress
        If e.KeyChar = vbCr Then
            txtUser.Focus()
        End If
    End Sub


    Private Sub txtServer_TextChanged(sender As Object, e As EventArgs) Handles txtServer.TextChanged

    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = vbCr Then
            txtPass.Focus()
        End If
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = vbCr Then
            btnConnect.Focus()
        End If
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub

    Private Sub cbDatabase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDatabase.SelectedIndexChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value >= 100 Then
            ' ProgressBar1.Value = 0
        Else
            ProgressBar1.Value = ProgressBar1.Value + 1
            lblPercent.Text = ProgressBar1.Value & "% Completed...."
        End If
    End Sub
End Class