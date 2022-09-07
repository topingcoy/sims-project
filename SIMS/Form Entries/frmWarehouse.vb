Imports MySql.Data.MySqlClient

Public Class frmWarehouse

    Private Sub frmWarehouse_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            tsaddwhs_Click(sender, e)
        ElseIf e.KeyCode = Keys.Enter Then
            'tseditwhs_Click(sender, e)
        End If

    End Sub

    Private Sub frmWarehouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsWhs.Cursor = Cursors.Hand
        tsgbxWhs.Cursor = Cursors.Hand
        Loadwarehouse()

    End Sub


    Private Sub tsaddwhs_Click(sender As Object, e As EventArgs) Handles tsAddWhs.Click
        gBxWarehouse.Visible = True
        tbWhsCode.Focus()

    End Sub

    Private Sub CloseGBwhs_Click(sender As Object, e As EventArgs) Handles CloseWhs.Click
        tbWhsName.Clear()
        tbWhsCode.Clear()
        gBxWarehouse.Visible = False
    End Sub

    Private Sub ClearWhs_Click(sender As Object, e As EventArgs) Handles ClearWhs.Click
        tbWhsCode.Clear()
        tbWhsName.Clear()

    End Sub


    Private Sub SaveWhs_Click(sender As Object, e As EventArgs) Handles SaveWhs.Click
        'save to warehouse

        If checkwhscode() = True Then
            MsgBox("Warehouse code already exist!", 48, "Enter Warehouse Code")
            Exit Sub
        End If

        If checkwhsname() = True Then
            MsgBox("Warehouse name already exist!", 48, "Enter Warehouse Name")
            Exit Sub
        End If

        If tbWhsCode.Text = Nothing Or tbWhsName.Text = Nothing Then
            MsgBox("Enter missing field!", 48, "Enter Warehouse")
            Exit Sub
        End If

        'save to warehouse
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("INSERT INTO warehouse (whscode,warehouse) VALUES (@wcode,@whs)", cdb)
        cmd.Parameters.AddWithValue("@wcode", tbWhsCode.Text)
        cmd.Parameters.AddWithValue("@whs", tbWhsName.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Warehouse has been save!", vbInformation)
        Loadwarehouse()
        gBxWarehouse.Visible = False

    End Sub


    Function checkwhscode()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT whscode FROM warehouse WHERE whscode = @whscode", cdb)
        With cmd
            .Parameters.AddWithValue("@whscode", tbwhscode.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Function checkwhsname()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT warehouse FROM warehouse WHERE warehouse = @whsname", cdb)
        With cmd
            .Parameters.AddWithValue("@whsname", tbWhsName.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Sub Loadwarehouse()
        dgvWhs.Rows.Clear()
        Dim i As Integer
        Dim cmd As MySqlCommand
        Dim rd As MySqlDataReader
        cmd = New MySqlCommand("SELECT * FROM warehouse", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvWhs.Rows.Add(i, rd.Item("whscode").ToString, rd.Item("warehouse").ToString)
        End While
        rd.Close()
    End Sub

End Class