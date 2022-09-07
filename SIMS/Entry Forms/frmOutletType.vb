Imports MySql.Data.MySqlClient

Public Class frmOutletType

    Private Sub frmOutletType_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frmOutletType_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            btnAdd_Click(sender, e)
        ElseIf e.KeyCode = Keys.F6 Then
            btnRefresh_Click(sender, e)
        ElseIf e.KeyCode = Keys.F7 Then

        ElseIf e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub frmOutletType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOutlet()
    End Sub

    Sub LoadOutlet()
        dgvOutlet.Rows.Clear()
        Dim i As Integer
        cmd = New MySqlCommand("SELECT * FROM outlet ORDER BY outletname asc", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvOutlet.Rows.Add(i, rd.Item("outletcode").ToString, rd.Item("outletname").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
    End Sub

    Function checkoutletcode()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT outletcode FROM outlet WHERE outletcode = @ocode", cdb)
        With cmd
            .Parameters.AddWithValue("@ocode", txtOutletCode.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Function checkoutletype()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT outletname FROM outlet WHERE outletname = @oname", cdb)
        With cmd
            .Parameters.AddWithValue("@oname", txtOutletName.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'trap duplicate 
        If checkoutletcode() = True Then
            MsgBox("Outlet Code Already Exist!", 48, "Enter Outlet Code")
            Exit Sub
        End If

        If checkoutletype() = True Then
            MsgBox("Outlet Type Already Exist!", 48, "Enter Outlet Type")
            Exit Sub
        End If

        If txtOutletCode.Text = Nothing Or txtOutletName.Text = Nothing Then
            MsgBox("Enter Missing Field!", 48, "Enter Outlet Type")
            Exit Sub
        End If

        'save to outlet
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("INSERT INTO outlet (outletcode,outletname) VALUES (@oc,@on)", cdb)
        cmd.Parameters.AddWithValue("@oc", txtOutletCode.Text)
        cmd.Parameters.AddWithValue("@on", txtOutletName.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Outlet Type Has Been Successfully Save!", vbInformation)
        txtOutletCode.Clear()
        txtOutletName.Clear()
        LoadOutlet()
    End Sub

    Private Sub UpdateOutlet_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If MsgBox("Update this Outlet?", vbYesNo + vbQuestion) = vbYes Then
            cmd = New MySqlCommand("UPDATE outlet set outletcode=@oc, outletname=@on where pkno=@pk", cdb)
            With cmd
                .Parameters.AddWithValue("@pk", lblpkno.Text.Trim)
                .Parameters.AddWithValue("@oc", txtOutletCode.Text)
                .Parameters.AddWithValue("@on", txtOutletName.Text)
                .ExecuteNonQuery()
            End With
            MsgBox("Outlet Type Has Been Successfully Updated.", vbInformation)
            LoadOutlet()
            txtOutletCode.Clear()
            txtOutletName.Clear()
            lblpkno.Text = ""
        End If
    End Sub

    Private Sub dgvOutlet_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOutlet.CellClick
        With gbxOutlet
            gbxOutlet.Text = "EDIT OUTLET TYPE"
            txtOutletCode.Text = dgvOutlet.Rows(e.RowIndex).Cells(1).Value.ToString
            txtOutletName.Text = dgvOutlet.Rows(e.RowIndex).Cells(2).Value.ToString
            lblpkno.Text = dgvOutlet.Rows(e.RowIndex).Cells(3).Value.ToString
            txtOutletCode.Enabled = False
            gbxOutlet.Visible = True
            btnSave.Enabled = False
            btnUpdate.Enabled = True
        End With
    End Sub

    Private Sub dgvOutlet_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOutlet.CellContentClick
        'Dim colName As String = dgvOutlet.Columns(e.ColumnIndex).Name
        'If colName = "Edit" Then
        '    With gbxOutlet
        '        gbxOutlet.Text = "EDIT OUTLET TYPE"
        '        tbOutletCode.Text = dgvOutlet.Rows(e.RowIndex).Cells(1).Value.ToString
        '        tbOutletName.Text = dgvOutlet.Rows(e.RowIndex).Cells(2).Value.ToString
        '        lblpkno.Text = dgvOutlet.Rows(e.RowIndex).Cells(3).Value.ToString
        '        gbxOutlet.Visible = True
        '        btnSave.Enabled = False
        '        btnUpdate.Enabled = True
        '    End With
        'ElseIf colName = "Delete" Then
        '    If MsgBox("Delete this Outlet? Click Yes to Confirm", vbYesNo + vbQuestion) = vbYes Then
        '        cmd = New MySqlCommand("DELETE from outlet where outletcode like '" & dgvOutlet.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cdb)
        '        cmd.ExecuteNonQuery()
        '        MsgBox("Outlet has been Successfully Deleted!", vbInformation)
        '        LoadOutlet()
        '    End If
        'End If
    End Sub

    Private Sub txtSearchOutlet_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim i As Integer
        dgvOutlet.Rows.Clear()
        cmd = New MySqlCommand("SELECT * from outlet where outletname like '%" & txtSearch.Text & "%' or outletcode Like '%" & txtSearch.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvOutlet.Rows.Add(i, rd.Item("outletcode").ToString, rd.Item("outletname").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        gbxOutlet.Text = "ADD OUTLET TYPE"
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        txtOutletCode.Enabled = True
        txtOutletCode.Clear()
        txtOutletName.Clear()
        txtOutletCode.Focus()
    End Sub

    Private Sub dgvOutlet_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvOutlet.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.PageDown Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.PageUp Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dgvOutlet_CellClick(1, New DataGridViewCellEventArgs(0, dgvOutlet.CurrentRow.Index))
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadOutlet()
        btnAdd_Click(sender, e)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With dgvOutlet
            If .RowCount > 0 Then
                Dim pkno As String = Nothing
                Dim ocode As String = Nothing
                pkno = .Item(3, .CurrentRow.Index).Value
                ocode = .Item(1, .CurrentRow.Index).Value

                If checkContainOuletCode(ocode) Then
                    'MsgBox("naa")
                    MsgBox("This area has already transaction. Cannot be deleted.", vbInformation)
                Else 'false
                    'MsgBox("wala")
                    If MsgBox("Delete Type of Outlet :" & ocode & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then
                        Dim cmd As MySqlCommand
                        cmd = New MySqlCommand("DELETE FROM outlet where outletcode=@oc", cdb)
                        cmd.Parameters.AddWithValue("@oc", ocode)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        MsgBox("Outlet has been successfully deleted!", vbInformation)
                        LoadOutlet()
                        txtOutletCode.Clear()
                        txtOutletName.Clear()
                    End If
                End If
            End If
        End With
    End Sub

    Function checkContainOuletCode(ByVal ocode As String) As Boolean
        Dim retvar As Boolean = False
        cmd = New MySqlCommand("SELECT outletcode FROM customers WHERE outletcode=@oc", cdb)
        cmd.Parameters.AddWithValue("@oc", ocode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retvar = True
            End If
        End Using
        Return retvar
    End Function

End Class