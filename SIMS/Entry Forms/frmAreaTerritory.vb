Imports MySql.Data.MySqlClient

Public Class frmAreaTerritory

    Private Sub frmAreaTerritory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frmAreaTerritory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            btnAdd_Click(sender, e)
        ElseIf e.KeyCode = Keys.F6 Then
            btnRefresh_Click(sender, e)
        ElseIf e.KeyCode = Keys.F7 Then
            btnDelete_Click(sender, e)
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub frmAreaTerritory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadArea()
    End Sub

    Sub LoadArea()
        dgvArea.Rows.Clear()
        Dim i As Integer
        cmd = New MySqlCommand("SELECT * FROM area ORDER BY areaname asc", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvArea.Rows.Add(i, rd.Item("areacode").ToString, rd.Item("areaname").ToString, rd.Item("pkno").ToString) ', "Edit", "Delete")
        End While
        rd.Close()
    End Sub

    Function checkareacode()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT areacode FROM area WHERE areacode = @acode", cdb)
        With cmd
            .Parameters.AddWithValue("@acode", txtAreaCode.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Function checkareaname()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT areaname FROM area WHERE areaname = @aname", cdb)
        With cmd
            .Parameters.AddWithValue("@aname", txtAreaName.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Private Sub SaveArea_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'trap duplicate 
        If checkareacode() = True Then
            MsgBox("Area Code Already Exist!", 48, "Enter Area Code")
            Exit Sub
        End If

        If checkareaname() = True Then
            MsgBox("Area Name Already Exist!", 48, "Enter Area Name")
            Exit Sub
        End If

        If txtAreaCode.Text = Nothing Or txtAreaName.Text = Nothing Then
            MsgBox("Enter Missing Field!", 48, "Enter Area")
            Exit Sub
        End If

        'save to area
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("INSERT INTO area (areacode,areaname) VALUES (@acode,@aname)", cdb)
        cmd.Parameters.AddWithValue("@acode", txtAreaCode.Text)
        cmd.Parameters.AddWithValue("@aname", txtAreaName.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Area Has Been Successfully Save!", vbInformation)
        txtAreaCode.Clear()
        txtAreaName.Clear()
        LoadArea()
    End Sub

    Private Sub UpdateArea_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If MsgBox("Update this Area?", vbYesNo + vbQuestion) = vbYes Then
            cmd = New MySqlCommand("UPDATE area set areacode=@acode, areaname=@aname where pkno=@pk", cdb)
            With cmd
                .Parameters.AddWithValue("@pk", lblpkno.Text.Trim)
                .Parameters.AddWithValue("@acode", txtAreaCode.Text)
                .Parameters.AddWithValue("@aname", txtAreaName.Text)
                .ExecuteNonQuery()
            End With
            MsgBox("Area Has Been Successfully Updated.", vbInformation)
            LoadArea()
            txtAreaCode.Clear()
            txtAreaName.Clear()
            lblpkno.Text = ""
        End If
    End Sub

    Private Sub dgvArea_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArea.CellClick
        With dgvArea
            gbxArea.Text = "EDIT AREA"
            txtAreaCode.Text = dgvArea.Rows(e.RowIndex).Cells(1).Value.ToString
            txtAreaName.Text = dgvArea.Rows(e.RowIndex).Cells(2).Value.ToString
            lblpkno.Text = dgvArea.Rows(e.RowIndex).Cells(3).Value.ToString
            btnSave.Enabled = False
            btnUpdate.Enabled = True
            txtAreaCode.Enabled = False
        End With
    End Sub

    Private Sub dgvArea_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArea.CellContentClick
        'Dim colName As String = dgvArea.Columns(e.ColumnIndex).Name
        'If colName = "Edit" Then
        '    With gbxArea
        '        gbxArea.Text = "EDIT AREA"
        '        tbAreaCode.Text = dgvArea.Rows(e.RowIndex).Cells(1).Value.ToString
        '        tbAreaName.Text = dgvArea.Rows(e.RowIndex).Cells(2).Value.ToString
        '        lblpkno.Text = dgvArea.Rows(e.RowIndex).Cells(3).Value.ToString
        '        gbxArea.Visible = True
        '        SaveArea.Enabled = False
        '        UpdateArea.Enabled = True
        '        tbAreaCode.Enabled = False
        '    End With
        'ElseIf colName = "Delete" Then
        '    If MsgBox("Delete this Area? Click Yes to Confirm", vbYesNo + vbQuestion) = vbYes Then
        '        cmd = New MySqlCommand("DELETE from area where areacode like '" & dgvArea.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cdb)
        '        cmd.ExecuteNonQuery()
        '        MsgBox("Area Has Been Successfully Deleted!", vbInformation)
        '        LoadArea()
        '    End If
        'End If
    End Sub

    Private Sub tbSearchArea_TextChanged(sender As Object, e As EventArgs) Handles txtSearchArea.TextChanged
        Dim i As Integer
        dgvArea.Rows.Clear()
        cmd = New MySqlCommand("SELECT * from area where areaname like '%" & txtSearchArea.Text & "%' or areacode Like '%" & txtSearchArea.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvArea.Rows.Add(i, rd.Item("areacode").ToString, rd.Item("areaname").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
    End Sub

    Private Sub dgvArea_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvArea.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.PageDown Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.PageUp Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dgvArea_CellClick(1, New DataGridViewCellEventArgs(0, dgvArea.CurrentRow.Index))
        End If
    End Sub



    Sub del()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        gbxArea.Text = "ADD AREA"
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        txtAreaCode.Enabled = True
        txtAreaCode.Clear()
        txtAreaName.Clear()
        txtAreaCode.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With dgvArea
            If .RowCount > 0 Then
                Dim pkno As String = Nothing
                Dim acode As String = Nothing
                pkno = .Item(3, .CurrentRow.Index).Value
                acode = .Item(1, .CurrentRow.Index).Value

                If checkContainAreaCode(acode) Then
                    'MsgBox("naa")
                    MsgBox("This area has already transaction. Cannot be deleted.", vbInformation)
                Else 'false
                    'MsgBox("wala")
                    If MsgBox("Delete Area :" & acode & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then
                        Dim cmd As MySqlCommand
                        'cmd = New MySqlCommand("UPDATE supcmdm SET isdeleted=1 WHERE transno=@tr", cdb)
                        cmd = New MySqlCommand("DELETE FROM area where areacode=@ac", cdb)
                        cmd.Parameters.AddWithValue("@ac", acode)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        MsgBox("Area has been successfully deleted!", vbInformation)
                        LoadArea()
                        txtAreaCode.Clear()
                        txtAreaName.Clear()
                    End If
                End If
            End If
        End With
    End Sub

    Function checkContainAreaCode(ByVal acode As String) As Boolean
        Dim retvar As Boolean = False
        cmd = New MySqlCommand("SELECT areacode FROM customers WHERE areacode=@ac", cdb)
        cmd.Parameters.AddWithValue("@ac", acode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retvar = True
            End If
        End Using
        Return retvar
    End Function

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadArea()
        btnAdd_Click(sender, e)
    End Sub
End Class