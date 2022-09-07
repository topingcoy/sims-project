Imports MySql.Data.MySqlClient

Public Class frmProvince

    Private Sub frmProvince_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frmProvince_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub frmProvince_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProvince()
        btnUpdate.Enabled = False
    End Sub

    Sub LoadProvince()
        dgvProv.Rows.Clear()
        Dim i As Integer
        cmd = New MySqlCommand("SELECT * FROM province", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvProv.Rows.Add(i, rd.Item("provcode").ToString, rd.Item("provincename").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
    End Sub

    Private Sub CloseProv_Click(sender As Object, e As EventArgs)
        gbxProvince.Visible = False
    End Sub

    Private Sub SaveProv_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'trap duplicate
        If checkprovcode() = True Then
            MsgBox("Province Code Already Exist!", 48, "Enter Province Code")
            Exit Sub
        End If

        If checkprovname() = True Then
            MsgBox("Province Name Already Exist!", 48, "Enter Province Name")
            Exit Sub
        End If

        If txtProvCode.Text = Nothing Or txtProvName.Text = Nothing Then
            MsgBox("Enter Missing Field!", 48, "Enter Province")
            Exit Sub
        End If

        'save to province
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("INSERT INTO province (provcode,provincename) VALUES (@pcode,@provname)", cdb)
        cmd.Parameters.AddWithValue("@pcode", txtProvCode.Text)
        cmd.Parameters.AddWithValue("@provname", txtProvName.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Parehouse Has Been Save Successfully!", vbInformation)
        LoadProvince()
        txtProvCode.Clear()
        txtProvName.Clear()
        txtProvCode.Focus()
    End Sub

    Function checkprovcode()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT provcode FROM province WHERE provcode = @pcode", cdb)
        With cmd
            .Parameters.AddWithValue("@pcode", txtProvCode.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Function checkprovname()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT provincename FROM province WHERE provincename = @provname", cdb)
        With cmd
            .Parameters.AddWithValue("@provname", txtProvName.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function


    Private Sub UpdateProv_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If MsgBox("Update this Province?", vbYesNo + vbQuestion) = vbYes Then
            cmd = New MySqlCommand("UPDATE province set provcode=@pcode, provincename=@provname where pkno=@pk", cdb)
            With cmd
                .Parameters.AddWithValue("@pk", lblpkno.Text.Trim)
                .Parameters.AddWithValue("@pcode", txtProvCode.Text)
                .Parameters.AddWithValue("@provname", txtProvName.Text)
                .ExecuteNonQuery()
            End With
            MsgBox("Province Has Been Successfully Updated.", vbInformation)
            LoadProvince()
            txtProvCode.Clear()
            txtProvName.Clear()
            lblpkno.Text = ""
        End If
    End Sub

    Private Sub dgvProv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProv.CellClick
        With dgvProv
            gbxProvince.Text = "EDIT PROVINCE"
            txtProvCode.Text = dgvProv.Rows(e.RowIndex).Cells(1).Value.ToString
            txtProvName.Text = dgvProv.Rows(e.RowIndex).Cells(2).Value.ToString
            lblpkno.Text = dgvProv.Rows(e.RowIndex).Cells(3).Value.ToString
            btnSave.Enabled = False
            btnUpdate.Enabled = True
            txtProvCode.Enabled = False
        End With
    End Sub

    Private Sub dgvProv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProv.CellContentClick
        'Dim colName As String = dgvProv.Columns(e.ColumnIndex).Name
        'If colName = "Edit" Then
        '    With gbxProvince
        '        gbxProvince.Text = "EDIT PROVINCE"
        '        tbProvCode.Text = dgvProv.Rows(e.RowIndex).Cells(1).Value.ToString
        '        tbProvName.Text = dgvProv.Rows(e.RowIndex).Cells(2).Value.ToString
        '        lblpkno.Text = dgvProv.Rows(e.RowIndex).Cells(3).Value.ToString
        '        gbxProvince.Visible = True
        '        btnSave.Enabled = False
        '        btnUpdate.Enabled = True
        '        tbProvCode.Enabled = False
        '    End With
        'ElseIf colName = "Delete" Then
        '    If MsgBox("Delete this Province? Click Yes to Confirm", vbYesNo + vbQuestion) = vbYes Then
        '        cmd = New MySqlCommand("DELETE from province where provcode like '" & dgvProv.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cdb)
        '        cmd.ExecuteNonQuery()
        '        MsgBox("Province Has Been Successfully Deleted!", vbInformation)
        '        LoadProvince()
        '    End If
        'End If
    End Sub

    Private Sub tbSearchProv_KeyDown(sender As Object, e As KeyEventArgs) Handles tbSearch.KeyDown

    End Sub

    Private Sub tbSearchProv_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Dim i As Integer
        dgvProv.Rows.Clear()
        cmd = New MySqlCommand("SELECT * from province where provincename like '%" & tbSearch.Text & "%' or provcode Like '%" & tbSearch.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvProv.Rows.Add(i, rd.Item("provcode").ToString, rd.Item("provincename").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        gbxProvince.Text = "ADD PROVINCE"
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        txtProvCode.Enabled = True
        txtProvCode.Clear()
        txtProvName.Clear()
        txtProvCode.Focus()
    End Sub

    Private Sub dgvProv_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvProv.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.PageDown Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.PageUp Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dgvProv_CellClick(1, New DataGridViewCellEventArgs(0, dgvProv.CurrentRow.Index))
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With dgvProv
            If .RowCount > 0 Then
                Dim pkno As String = Nothing
                Dim pCode As String = Nothing
                pkno = .Item(3, .CurrentRow.Index).Value
                pCode = .Item(1, .CurrentRow.Index).Value

                If checkContainProvCode(pCode) Then
                    'MsgBox("naa")
                    MsgBox("This province has already transaction. Cannot be deleted.", vbInformation)
                Else 'false
                    'MsgBox("wala")
                    If MsgBox("Delete Province :" & pCode & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then
                        Dim cmd As MySqlCommand
                        cmd = New MySqlCommand("DELETE FROM province where provcode=@pc", cdb)
                        cmd.Parameters.AddWithValue("@pc", pCode)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        MsgBox("Province has been successfully deleted!", vbInformation)
                        LoadProvince()
                        txtProvCode.Clear()
                        txtProvName.Clear()
                    End If
                End If
            End If
        End With
    End Sub

    Function checkContainProvCode(ByVal provcode As String) As Boolean
        Dim retvar As Boolean = False
        cmd = New MySqlCommand("SELECT provcode FROM customers WHERE provcode=@pc", cdb)
        cmd.Parameters.AddWithValue("@pc", provcode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retvar = True
            End If
        End Using
        Return retvar
    End Function

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadProvince()
        btnAdd_Click(sender, e)
    End Sub
End Class