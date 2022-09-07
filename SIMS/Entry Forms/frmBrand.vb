Imports MySql.Data.MySqlClient

Public Class frmBrand

    Private Sub frmBrand_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frmBrand_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            btnAdd_Click(sender, e)
        ElseIf e.KeyCode = Keys.F6 Then
            btnRefresh_Click(sender, e)
        ElseIf e.KeyCode = Keys.F7 Then
            btnDelete_Click(sender, e)
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
            End If
    End Sub
  

    Private Sub frmBrand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBrand()
        btnUpdate.Enabled = False
    End Sub

    Private Sub SaveBrand_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'trap duplicate
        If checkbrandcode() = True Then
            MsgBox("Brand Code Already Exist!", 48, "Enter Brand Code")
            Exit Sub
        End If

        If checkbrandname() = True Then
            MsgBox("Brand Name Already Exist!", 48, "Enter Brand Name")
            Exit Sub
        End If

        If tbBrandCode.Text = Nothing Or tbBrandName.Text = Nothing Then
            MsgBox("Enter Missing Field!", 48, "Enter Brand")
            Exit Sub
        End If

        'save to brand
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("INSERT INTO brand (brcode,brandname) VALUES (@bc,@bn)", cdb)
        cmd.Parameters.AddWithValue("@bc", tbBrandCode.Text)
        cmd.Parameters.AddWithValue("@bn", tbBrandName.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Brand Has Been Successfully Save!", vbInformation)
        tbBrandCode.Clear()
        tbBrandName.Clear()
        LoadBrand()
    End Sub

    Sub LoadBrand()
        dgvBrand.Rows.Clear()
        Dim i As Integer
        cmd = New MySqlCommand("SELECT * FROM brand", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvBrand.Rows.Add(i, rd.Item("brcode").ToString, rd.Item("brandname").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
    End Sub

    Function checkbrandcode()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT brcode FROM brand WHERE brcode = @bc", cdb)
        With cmd
            .Parameters.AddWithValue("@bc", tbBrandCode.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Function checkbrandname()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT brandname FROM brand WHERE brandname = @bn", cdb)
        With cmd
            .Parameters.AddWithValue("@bn", tbBrandName.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Private Sub UpdateBrand_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If MsgBox("Update this Brand?", vbYesNo + vbQuestion) = vbYes Then
            cmd = New MySqlCommand("UPDATE brand set brcode=@bc, brandname=@bn where pkno=@pk", cdb)
            With cmd
                .Parameters.AddWithValue("@pk", lblpkno.Text.Trim)
                .Parameters.AddWithValue("@bc", tbBrandCode.Text)
                .Parameters.AddWithValue("@bn", tbBrandName.Text)
                .ExecuteNonQuery()
            End With
            MsgBox("Brand Has Been Successfully Updated.", vbInformation)
            LoadBrand()
            tbBrandCode.Clear()
            tbBrandName.Clear()
            lblpkno.Text = ""
        End If
    End Sub

    Dim lastitemsel As String = Nothing
    Private Sub dgvBrand_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBrand.CellClick
        With dgvBrand
            If .RowCount > 0 And e.RowIndex >= 0 Then
                gbxBrand.Text = "EDIT BRAND"
                tbBrandCode.Text = dgvBrand.Rows(e.RowIndex).Cells(1).Value.ToString
                tbBrandName.Text = dgvBrand.Rows(e.RowIndex).Cells(2).Value.ToString
                lblpkno.Text = dgvBrand.Rows(e.RowIndex).Cells(3).Value.ToString
                tbBrandCode.Enabled = False
                btnSave.Enabled = False
                btnUpdate.Enabled = True

                lastitemsel = dgvBrand.Rows(e.RowIndex).Cells(2).Value.ToString
            End If
        End With
    End Sub

    Private Sub dgvBrand_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBrand.CellContentClick
        'Dim colName As String = dgvBrand.Columns(e.ColumnIndex).Name
        'If colName = "Edit" Then
        '    With gbxBrand
        '        gbxBrand.Text = "EDIT BRAND"
        '        tbBrandCode.Text = dgvBrand.Rows(e.RowIndex).Cells(1).Value.ToString
        '        tbBrandName.Text = dgvBrand.Rows(e.RowIndex).Cells(2).Value.ToString
        '        lblpkno.Text = dgvBrand.Rows(e.RowIndex).Cells(3).Value.ToString
        '        tbBrandCode.Enabled = False
        '        gbxBrand.Visible = True
        '        btnSave.Enabled = False
        '        btnUpdate.Enabled = True
        '    End With
        'ElseIf colName = "Delete" Then
        '    If MsgBox("Delete this Brand? Click Yes to Confirm", vbYesNo + vbQuestion) = vbYes Then

        '        cmd = New MySqlCommand("DELETE from brand where brandcode like '" & dgvBrand.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cdb)
        '        cmd.ExecuteNonQuery()

        '        MsgBox("Brand has been Successfully Deleted!", vbInformation)
        '        LoadBrand()
        '    End If
        'End If
    End Sub

    Private Sub tbSearchBrand_TextChanged(sender As Object, e As EventArgs) Handles tbSearchBrand.TextChanged
        Try
            Dim i As Integer
            dgvBrand.Rows.Clear()
            cmd = New MySqlCommand("SELECT * from brand where brandname like '%" & tbSearchBrand.Text & "%' or brandcode Like '%" & tbSearchBrand.Text & "%'", cdb)
            rd = cmd.ExecuteReader
            While rd.Read
                i += 1
                dgvBrand.Rows.Add(i, rd.Item("brandcode").ToString, rd.Item("brandname").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
            End While
            rd.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub dgvBrand_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvBrand.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.PageDown Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.PageUp Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dgvBrand_CellClick(1, New DataGridViewCellEventArgs(0, dgvBrand.CurrentRow.Index))
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadBrand()
        btnAdd.PerformClick()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With dgvBrand
            If .RowCount > 0 Then
                Dim myPkno As String = Nothing
                Dim bCode As String = Nothing
                myPkno = .Item(3, .CurrentRow.Index).Value
                bCode = .Item(1, .CurrentRow.Index).Value
                If MsgBox("Delete Brand :" & bCode & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then
                    Dim cmd As MySqlCommand
                    'cmd = New MySqlCommand("UPDATE supcmdm SET isdeleted=1 WHERE transno=@tr", cdb)
                    cmd = New MySqlCommand("DELETE FROM brand where pkno like '" & myPkno & "'", cdb)
                    cmd.Parameters.AddWithValue("@tr", myPkno)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    MsgBox("Brand has been Successfully Deleted!", vbInformation)
                    tbBrandCode.Clear()
                    tbBrandName.Clear()
                    LoadBrand()
                End If
            End If
        End With
    End Sub

    
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        gbxBrand.Text = "ADD BRAND"
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        tbBrandCode.Enabled = True
        tbBrandCode.Clear()
        tbBrandName.Clear()
        tbBrandCode.Focus()
    End Sub
End Class