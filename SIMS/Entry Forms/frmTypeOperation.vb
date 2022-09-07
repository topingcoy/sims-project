Imports MySql.Data.MySqlClient

Public Class frmTypeOperation

    Private Sub frmTypeOperation_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            btnAdd_Click(sender, e)
        ElseIf e.KeyCode = Keys.F6 Then
            btnRefresh_Click(sender, e)
        ElseIf e.KeyCode = Keys.F7 Then
            btnDeleteOper_Click(sender, e)
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Dim lastitemsel As String = Nothing
    Private Sub frmTypeOperation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTypeOper()
        btnUpdate.Enabled = False
    End Sub

    Sub LoadTypeOper()
        dgvTypeOper.Rows.Clear()
        Dim i As Integer

        cmd = New MySqlCommand("SELECT * FROM typeoper ORDER BY operationname asc", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvTypeOper.Rows.Add(i, rd.Item("opercode").ToString, rd.Item("operationname").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
        btnAdd.PerformClick()
        'tbCode.Clear()
        'tbTypeOperator.Clear()
    End Sub

    Function checkopercode()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT opercode FROM typeoper WHERE opercode = @opercode", cdb)
        With cmd
            .Parameters.AddWithValue("@opercode", txtCode.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Function checkopername()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT operationname FROM typeoper WHERE operationname = @opername", cdb)
        With cmd
            .Parameters.AddWithValue("@opername", txtTypeOperator.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Private Sub CloseType_Click(sender As Object, e As EventArgs)
        gbxTypeOper.Visible = False
    End Sub

    Private Sub SaveTypeOper_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'trap duplicate
        If checkopercode() = True Then
            MsgBox("Operation Code Already Exist!", 48, "Enter Operation Code")
            Exit Sub
        End If

        If checkopername() = True Then
            MsgBox("Operation Name Already Exist!", 48, "Enter Operation Name")
            Exit Sub
        End If

        If txtCode.Text = Nothing Or txtTypeOperator.Text = Nothing Then
            MsgBox("Enter Missing Field!", 48, "Enter Type of Operation")
            Exit Sub
        End If

        'save to typeoper
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("INSERT INTO typeoper (opercode,operationname) VALUES (@opercode,@opername)", cdb)
        cmd.Parameters.AddWithValue("@opercode", txtCode.Text)
        cmd.Parameters.AddWithValue("@opername", txtTypeOperator.Text)
        cmd.ExecuteNonQuery()
        AuditTrail("Code.:" & Space(1) & txtCode.Text & Space(2) & "Operation name:" & Space(1) & txtTypeOperator.Text, "Add Type of Operation")
        MsgBox("Type of operation has been successfully save!", vbInformation)
        txtCode.Clear()
        txtTypeOperator.Clear()
        LoadTypeOper()
        txtCode.Focus()
    End Sub

    Private Sub dgvTypeOper_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTypeOper.CellClick
        With dgvTypeOper
            If .RowCount > 0 And e.RowIndex >= 0 Then
                gbxTypeOper.Text = "EDIT TYPE OF OPERATION"
                txtCode.Text = dgvTypeOper.Rows(e.RowIndex).Cells(1).Value.ToString
                txtTypeOperator.Text = dgvTypeOper.Rows(e.RowIndex).Cells(2).Value.ToString
                lblpkno.Text = dgvTypeOper.Rows(e.RowIndex).Cells(3).Value.ToString
                txtCode.Enabled = False
                gbxTypeOper.Visible = True
                btnSave.Enabled = False
                btnUpdate.Enabled = True
                txtCode.Enabled = False
                lastitemsel = dgvTypeOper.Rows(e.RowIndex).Cells(2).Value.ToString
            End If

        End With
    End Sub

    Private Sub dgvTypeOper_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTypeOper.CellContentClick
        'Dim colName As String = dgvTypeOper.Columns(e.ColumnIndex).Name
        'If colName = "Edit" Then
        '    With gbxTypeOper
        '        gbxTypeOper.Text = "EDIT TYPE OF OPERATION"
        '        tbCode.Text = dgvTypeOper.Rows(e.RowIndex).Cells(1).Value.ToString
        '        tbTypeOperator.Text = dgvTypeOper.Rows(e.RowIndex).Cells(2).Value.ToString
        '        lblpkno.Text = dgvTypeOper.Rows(e.RowIndex).Cells(3).Value.ToString
        '        tbCode.Enabled = False
        '        gbxTypeOper.Visible = True
        '        btnSave.Enabled = False
        '        btnUpdate.Enabled = True
        '        tbCode.Enabled = False
        '    End With
        'ElseIf colName = "Delete" Then
        '    If MsgBox("Delete this Type of Operation? Click Yes to Confirm", vbYesNo + vbQuestion) = vbYes Then
        '        cmd = New MySqlCommand("DELETE FROM typeoper where opercode like '" & dgvTypeOper.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cdb)
        '        cmd.ExecuteNonQuery()
        '        MsgBox("Type of Operation Has Been Successfully Deleted!", vbInformation)
        '        LoadTypeOper()
        '    End If
        'End If
    End Sub

    Private Sub UpdateTypeOper_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtCode.Text = Nothing Or txtTypeOperator.Text = Nothing Then
            MsgBox("Pls Select Record to Update!", vbExclamation)
            Exit Sub
        ElseIf MsgBox("Update this Type of Operation?", vbYesNo + vbQuestion, "Continue") = vbYes Then
            cmd = New MySqlCommand("UPDATE typeoper set opercode=@ocode, operationname=@oname where pkno=@pkno", cdb)
            With cmd
                .Parameters.AddWithValue("@pkno", lblpkno.Text.Trim)
                .Parameters.AddWithValue("@ocode", txtCode.Text)
                .Parameters.AddWithValue("@oname", txtTypeOperator.Text)
                .ExecuteNonQuery()
            End With
            AuditTrail("Code.:" & Space(1) & txtCode.Text & Space(2) & "Operation name:" & Space(1) & txtTypeOperator.Text, "Update Type of Operation")
            MsgBox("Type of Operation Has Been Successfully Updated.", vbInformation)
            LoadTypeOper()
            txtCode.Clear()
            txtTypeOperator.Clear()
            lblpkno.Text = ""
        End If
    End Sub

    Private Sub tbSearchTypeOper_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim i As Integer
        dgvTypeOper.Rows.Clear()
        cmd = New MySqlCommand("SELECT * from typeoper where operationname like '%" & txtSearch.Text & "%' or opercode Like '%" & txtSearch.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvTypeOper.Rows.Add(i, rd.Item("opercode").ToString, rd.Item("operationname").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
    End Sub

    Private Sub dgvTypeOper_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvTypeOper.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.PageDown Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.PageUp Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dgvTypeOper_CellClick(1, New DataGridViewCellEventArgs(0, dgvTypeOper.CurrentRow.Index))
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadTypeOper()


    End Sub

    Private Sub btnDeleteOper_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With dgvTypeOper
            If .RowCount > 0 Then
                Dim pkno As String = Nothing
                Dim tcode As String = Nothing
                pkno = .Item(3, .CurrentRow.Index).Value
                tcode = .Item(1, .CurrentRow.Index).Value

                If checkContainTypeofOperCode(tcode) Then
                    'MsgBox("naa")
                    MsgBox("This area has already transaction. Cannot be deleted.", vbInformation)
                Else 'false
                    'MsgBox("wala")

                    If MsgBox("Delete Type of Operation :" & tcode & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then
                        Dim cmd As MySqlCommand
                        'cmd = New MySqlCommand("UPDATE supcmdm SET isdeleted=1 WHERE transno=@tr", cdb)
                        cmd = New MySqlCommand("DELETE FROM typeoper where opercode=@oc", cdb)
                        cmd.Parameters.AddWithValue("@oc", tcode)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        AuditTrail("Code.:" & Space(1) & txtCode.Text & Space(2) & "Operation name:" & Space(1) & txtTypeOperator.Text, "Delete Type of Operation")
                        MsgBox("Type of Operation has been successfully eleted!", vbInformation)
                        LoadTypeOper()
                        txtCode.Clear()
                        txtTypeOperator.Clear()
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub tbCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCode.KeyPress
        If e.KeyChar = vbCr Then
            txtTypeOperator.Focus()
        End If
    End Sub

    Private Sub tbTypeOperator_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTypeOperator.KeyPress
        If e.KeyChar = vbCr Then
            tsMenu2.Items(1).Select()
            tsMenu2.Focus()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        gbxTypeOper.Text = "ADD PROVINCE"
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        txtCode.Enabled = True
        txtTypeOperator.Clear()
        txtCode.Clear()
        txtCode.Focus()
    End Sub

    Function checkContainTypeofOperCode(ByVal opercode As String) As Boolean
        Dim retvar As Boolean = False
        cmd = New MySqlCommand("SELECT opercode FROM custsales WHERE opercode=@oc", cdb)
        cmd.Parameters.AddWithValue("@oc", opercode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retvar = True
            End If
        End Using
        Return retvar
    End Function

End Class