Imports MySql.Data.MySqlClient

Public Class frmSupplier

    Private Sub frmSupplier_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frmSupplier_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            btn_Add_Click(sender, e)
        ElseIf e.KeyCode = Keys.F6 Then
            LoadSupplier()
        ElseIf e.KeyCode = Keys.F7 Then
            btn_Delete_Click(sender, e)
        ElseIf e.KeyCode = Keys.Escape Then
            If txtCode.Text <> Nothing And txtSupname.Text <> Nothing Then
                If MsgBox("Are you sure you want to close?", vbYesNo + vbQuestion, "Supplier Entry") = vbYes Then
                    Me.Dispose()
                End If
            End If
        End If
    End Sub

    Private Sub frmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSupplier()
    End Sub

    Function checksupcode()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT supcode FROM supplier WHERE supcode = @supcode", cdb)
        With cmd
            .Parameters.AddWithValue("@supcode", txtCode.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Function checksupname()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT suppliername FROM supplier WHERE suppliername = @sn", cdb)
        With cmd
            .Parameters.AddWithValue("@sn", txtSupname.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Private Sub SaveSup_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'check for duplicate entry
        If checksupcode() = True Then
            MsgBox("Supplier Code already exist!", 48, "Enter Supplier Code")
            Exit Sub
        End If

        If checksupname() = True Then
            MsgBox("Supplier Name already exist!", 48, "Enter Supplier Name")
            Exit Sub
        End If

        If txtCode.Text = Nothing Or txtSupname.Text = Nothing Then
            MsgBox("Enter missing field!", 48, "Enter Supplier")
            Exit Sub
        End If

        'save to supplier
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("INSERT INTO supplier (supcode,suppliername,address) VALUES (@scode,@sname,@sadd)", cdb)
        cmd.Parameters.AddWithValue("@scode", txtCode.Text)
        cmd.Parameters.AddWithValue("@sname", txtSupname.Text)
        cmd.Parameters.AddWithValue("@sadd", txtAddress.Text)
        cmd.ExecuteNonQuery()
        AuditTrail("Code.:" & Space(1) & txtCode.Text & Space(2) & "Supplier name:" & Space(1) & txtSupname.Text & Space(2) & "Address:" & Space(2) & txtAddress.Text, "Add New Supplier")
        MsgBox("Supplier has been save!", vbInformation)
        txtCode.Clear()
        txtSupname.Clear()
        txtAddress.Clear()
        LoadSupplier()
    End Sub

    Sub LoadSupplier()
        dgvSupplier.Rows.Clear()
        Dim i As Integer
        cmd = New MySqlCommand("SELECT * FROM supplier", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvSupplier.Rows.Add(i, rd.Item("supcode").ToString, rd.Item("suppliername").ToString, rd.Item("address").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
    End Sub

    Private Sub dgvSupplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplier.CellClick
        With gbxSupplier
            gbxSupplier.Text = "EDIT SUPPLIER"
            txtCode.Text = dgvSupplier.Rows(e.RowIndex).Cells(1).Value.ToString
            txtSupname.Text = dgvSupplier.Rows(e.RowIndex).Cells(2).Value.ToString
            txtAddress.Text = dgvSupplier.Rows(e.RowIndex).Cells(3).Value.ToString
            lblpkno.Text = dgvSupplier.Rows(e.RowIndex).Cells(4).Value.ToString
            txtCode.Enabled = False
            btnSave.Enabled = False
            btnUpdate.Enabled = True
        End With
    End Sub

    Private Sub dgvSupplier_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplier.CellContentClick
        'Dim colName As String = dgvSupplier.Columns(e.ColumnIndex).Name
        'If colName = "Edit" Then
        '    With gbxSupplier
        '        gbxSupplier.Text = "EDIT SUPPLIER"
        '        tbSupCode.Text = dgvSupplier.Rows(e.RowIndex).Cells(1).Value.ToString
        '        tbSupName.Text = dgvSupplier.Rows(e.RowIndex).Cells(2).Value.ToString
        '        lblpkno.Text = dgvSupplier.Rows(e.RowIndex).Cells(3).Value.ToString
        '        tbSupCode.Enabled = False
        '        gbxSupplier.Visible = True
        '        btnSave.Enabled = False
        '        btnUpdate.Enabled = True
        '    End With
        'ElseIf colName = "Delete" Then
        '    If MsgBox("Delete this Supplier? Click Yes to Confirm", vbYesNo + vbQuestion) = vbYes Then

        '    cmd = New MySqlCommand("select * from supplier where status <> 0 ", cdb)
        '    cmd.ExecuteNonQuery()
        '    MsgBox("Supplier already used and cannot be deleted!", vbCritical)
        'Else

        'cmd = New MySqlCommand("DELETE from supplier where supcode like '" & dgvSupplier.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cdb)
        'cmd.ExecuteNonQuery()
        ''  cn.Close()
        'MsgBox("Supplier has been Successfully Deleted!", vbInformation)
        'LoadSupplier()
        '    End If
        'End If
    End Sub

    Private Sub UpdateSup_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtCode.Text = Nothing Or txtSupname.Text = Nothing Then
            MsgBox("Pls Select Record to Update!", vbExclamation)
            Exit Sub
        ElseIf MsgBox("Update this Supplier?", vbYesNo + vbQuestion) = vbYes Then
            cmd = New MySqlCommand("UPDATE supplier set supcode=@sc, suppliername=@sn, address=@sa where pkno=@pk", cdb)
            With cmd
                .Parameters.AddWithValue("@pk", lblpkno.Text.Trim)
                .Parameters.AddWithValue("@sc", txtCode.Text)
                .Parameters.AddWithValue("@sn", txtSupname.Text)
                .Parameters.AddWithValue("@sa", txtAddress.Text)
                .ExecuteNonQuery()
            End With
            AuditTrail("Code.:" & Space(1) & txtCode.Text & Space(2) & "Supplier name:" & Space(1) & txtSupname.Text & Space(2) & "Address:" & Space(2) & txtAddress.Text, "Update Supplier")
            MsgBox("Supplier has been updated successfully.", vbInformation)
            LoadSupplier()
            txtCode.Clear()
            txtSupname.Clear()
            txtAddress.Clear()
            lblpkno.Text = ""
        End If
    End Sub

    Private Sub tbSearchSup_TextChanged(sender As Object, e As EventArgs) Handles tbSearchSup.TextChanged
        Try
            Dim i As Integer
            dgvSupplier.Rows.Clear()
            cmd = New MySqlCommand("SELECT * from supplier where suppliername like '%" & tbSearchSup.Text & "%' or supcode Like '%" & tbSearchSup.Text & "%'", cdb)
            rd = cmd.ExecuteReader
            While rd.Read
                i += 1
                dgvSupplier.Rows.Add(i, rd.Item("supcode").ToString, rd.Item("suppliername").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
            End While
            rd.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        gbxSupplier.Text = "ADD SUPPLIER"
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        txtCode.Enabled = True
        txtCode.Clear()
        txtSupname.Clear()
        txtAddress.Clear()
        txtCode.Focus()
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        With dgvSupplier
            If .RowCount > 0 Then
                Dim mySup As String = Nothing
                Dim sCode As String = Nothing
                mySup = .Item(2, .CurrentRow.Index).Value
                sCode = .Item(1, .CurrentRow.Index).Value

                If checkContainSupCode(sCode) Then
                    'MsgBox("naa")
                    MsgBox("This supplier has already transaction. Cannot be deleted.", vbInformation)
                Else 'false
                    'MsgBox("wala")
                    If MsgBox("Delete Supplier :" & mySup & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then
                        Dim cmd As MySqlCommand
                        cmd = New MySqlCommand("DELETE FROM supplier where supcode=@sc", cdb)
                        cmd.Parameters.AddWithValue("@sc", sCode)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        AuditTrail("Code.:" & Space(1) & txtCode.Text & Space(2) & "Supplier name:" & Space(1) & txtSupname.Text & Space(2) & "Address:" & Space(2) & txtAddress.Text, "Delete Supplier")
                        MsgBox("Supplier has been successfully deleted!", vbInformation)
                        txtCode.Clear()
                        txtSupname.Clear()
                        txtAddress.Clear()
                        LoadSupplier()
                    End If
                End If
            End If
        End With
    End Sub

    Function checkContainSupCode(ByVal Supcode As String) As Boolean
        Dim retvar As Boolean = False
        cmd = New MySqlCommand("SELECT supcode FROM ivitem WHERE supcode=@sc", cdb)
        cmd.Parameters.AddWithValue("@sc", Supcode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retvar = True
            End If
        End Using
        Return retvar
    End Function

    Private Sub btn_Reresh_Click(sender As Object, e As EventArgs) Handles btn_Reresh.Click
        LoadSupplier()
        btn_Add.PerformClick()
    End Sub

    Private Sub dgvSupplier_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvSupplier.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.PageDown Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.PageUp Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dgvSupplier_CellClick(1, New DataGridViewCellEventArgs(0, dgvSupplier.CurrentRow.Index))
        End If
    End Sub

    Private Sub txtSupCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCode.KeyPress
        If e.KeyChar = vbCr Then
            txtSupname.Focus()
        End If
    End Sub

    Private Sub txtSupCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged

    End Sub

    Private Sub txtSupname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSupname.KeyPress
        If e.KeyChar = vbCr Then
            txtAddress.Focus()
        End If
    End Sub

    Private Sub txtSupname_TextChanged(sender As Object, e As EventArgs) Handles txtSupname.TextChanged

    End Sub
End Class