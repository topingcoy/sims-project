Imports MySql.Data.MySqlClient

Public Class frmCategory

    Sub LoadCategory()
        dgvCategory.Rows.Clear()
        Dim i As Integer
        cmd = New MySqlCommand("SELECT * FROM category ORDER BY categoryname asc", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvCategory.Rows.Add(i, rd.Item("catcode").ToString, rd.Item("categoryname").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
    End Sub

    Dim lastitemsel As String = Nothing

    Private Sub frmCategory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            btnAddCat_Click(sender, e)
        ElseIf e.KeyCode = Keys.F6 Then
            btnReresh_Click(sender, e)
        ElseIf e.KeyCode = Keys.F7 Then
            btnDelete_Click(sender, e)
        ElseIf e.KeyCode = Keys.Escape Then
            If txtCode.Text <> Nothing And txtCatname.Text <> Nothing Then
                If MsgBox("Are You Sure You Want to Close?", vbYesNo + vbQuestion, "Manage Category") = vbYes Then
                    Me.Dispose()
                End If
            End If
        End If
    End Sub

    Private Sub frmCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategory()
        btnUpdate.Enabled = False
    End Sub

    Private Sub SaveCat_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'trap duplicate 
        If checkcatcode() = True Then
            MsgBox("Category Code Already Exist!", 48, "Enter Category Code")
            Exit Sub
        End If

        If checkcatname() = True Then
            MsgBox("Category Name Already Exist!", 48, "Enter Category Name")
            Exit Sub
        End If

        If txtCode.Text = Nothing Or txtCatname.Text = Nothing Then
            MsgBox("Enter Missing Field!", 48, "Enter Category")
            Exit Sub
        End If

        'save to category
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("INSERT INTO category (catcode,categoryname) VALUES (@cc,@cn)", cdb)
        cmd.Parameters.AddWithValue("@cc", txtCode.Text)
        cmd.Parameters.AddWithValue("@cn", txtCatname.Text)
        cmd.ExecuteNonQuery()
        AuditTrail("Code.:" & Space(1) & txtCode.Text & Space(2) & "Category name:" & Space(1) & txtCatname.Text, "Add Category")
        MsgBox("Category has been successfully save!", vbInformation)
        txtCode.Clear()
        txtCatname.Clear()
        LoadCategory()
    End Sub

    Function checkcatcode()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT catcode FROM category WHERE catcode = @catcode", cdb)
        With cmd
            .Parameters.AddWithValue("@catcode", txtCode.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Function checkcatname()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT categoryname FROM category WHERE categoryname = @catname", cdb)
        With cmd
            .Parameters.AddWithValue("@catname", txtCatname.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Private Sub dgvCategory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategory.CellClick
        With dgvCategory
            If .RowCount > 0 And e.RowIndex >= 0 Then
                gbxCategory.Text = "EDIT WAREHOUSE"
                txtCode.Text = dgvCategory.Rows(e.RowIndex).Cells(1).Value.ToString
                txtCatname.Text = dgvCategory.Rows(e.RowIndex).Cells(2).Value.ToString
                lblpkno.Text = dgvCategory.Rows(e.RowIndex).Cells(3).Value.ToString
                txtCode.Enabled = False
                btnSave.Enabled = False
                btnUpdate.Enabled = True

                lastitemsel = dgvCategory.Rows(e.RowIndex).Cells(2).Value.ToString

            End If
        End With
    End Sub

    Private Sub dgvCategory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategory.CellContentClick
        'Dim colName As String = dgvCategory.Columns(e.ColumnIndex).Name
        'If colName = "Edit" Then
        '    With gbxCategory
        '        gbxCategory.Text = "EDIT CATEGORY"
        '        tbCatCode.Text = dgvCategory.Rows(e.RowIndex).Cells(1).Value.ToString
        '        tbCatName.Text = dgvCategory.Rows(e.RowIndex).Cells(2).Value.ToString
        '        lblpkno.Text = dgvCategory.Rows(e.RowIndex).Cells(3).Value.ToString
        '        tbCatCode.Enabled = False
        '        gbxCategory.Visible = True
        '        btnSave.Enabled = False
        '        btnUpdate.Enabled = True
        '    End With
        'ElseIf colName = "Delete" Then
        '    If MsgBox("Delete this Category? Click Yes to Confirm", vbYesNo + vbQuestion) = vbYes Then
        '        cmd = New MySqlCommand("DELETE from category where catcode like '" & dgvCategory.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cdb)
        '        cmd.ExecuteNonQuery()
        '        MsgBox("Category has been Successfully Deleted!", vbInformation)
        '        LoadCategory()
        '    End If
        'End If
    End Sub

    Private Sub UpdateCat_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtCode.Text = Nothing Or txtCatname.Text = Nothing Then
            MsgBox("Pls Select Record to Update!", vbExclamation)
            Exit Sub
        ElseIf MsgBox("Update this Category?", vbYesNo + vbQuestion) = vbYes Then
            cmd = New MySqlCommand("UPDATE category set catcode=@cc, categoryname=@cn where pkno=@pk", cdb)
            With cmd
                .Parameters.AddWithValue("@pk", lblpkno.Text.Trim)
                .Parameters.AddWithValue("@cc", txtCode.Text)
                .Parameters.AddWithValue("@cn", txtCatname.Text)
                .ExecuteNonQuery()
            End With
            AuditTrail("Code:" & Space(1) & txtCode.Text & Space(2) & "Category name:" & Space(1) & txtCatname.Text, "Update Category")
            MsgBox("Category has been successfully updated.", vbInformation)
            LoadCategory()
            txtCode.Clear()
            txtCatname.Clear()
            lblpkno.Text = ""
        End If
    End Sub

    Private Sub tbSearchCat_TextChanged(sender As Object, e As EventArgs) Handles tbSearchCat.TextChanged
        Try
            Dim i As Integer
            dgvCategory.Rows.Clear()
            cmd = New MySqlCommand("SELECT * from category where categoryname like '%" & tbSearchCat.Text & "%' or catcode Like '%" & tbSearchCat.Text & "%'", cdb)
            rd = cmd.ExecuteReader
            While rd.Read
                i += 1
                dgvCategory.Rows.Add(i, rd.Item("catcode").ToString, rd.Item("categoryname").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
            End While
            rd.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnAddCat_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        gbxCategory.Text = "ADD CATEGORY"
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        txtCode.Enabled = True
        txtCode.Clear()
        txtCatname.Clear()
        txtCode.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With dgvCategory
            If .RowCount > 0 Then
                Dim myPkno As String = Nothing
                Dim cCode As String = Nothing
                Dim cName As String = Nothing

                myPkno = .Item(3, .CurrentRow.Index).Value
                cCode = .Item(1, .CurrentRow.Index).Value
                cName = .Item(2, .CurrentRow.Index).Value

                If checkContainCatCode(cCode) Then
                    'MsgBox("naa")
                    MsgBox("This category has already transaction. Cannot be deleted.", vbInformation)
                Else 'false
                    'MsgBox("wala")
                    If MsgBox("Delete Category :" & cCode & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then
                        Dim cmd As MySqlCommand
                        cmd = New MySqlCommand("DELETE FROM category where catcode=@cc", cdb)
                        cmd.Parameters.AddWithValue("@cc", cCode)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        AuditTrail("Code.:" & Space(1) & cCode & Space(2) & "Category name:" & Space(1) & cName, "Delete Category")
                        MsgBox("Category has been successfully deleted!", vbInformation)
                        txtCode.Clear()
                        txtCatname.Clear()
                        LoadCategory()
                    End If
                End If
            End If
        End With
    End Sub

    Function checkContainCatCode(ByVal Catcode As String) As Boolean
        Dim retvar As Boolean = False
        cmd = New MySqlCommand("SELECT catcode FROM ivitem WHERE catcode=@cc", cdb)
        cmd.Parameters.AddWithValue("@cc", Catcode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retvar = True
            End If
        End Using
        Return retvar
    End Function

    Private Sub tbCatCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCode.KeyPress
        If e.KeyChar = vbCr Then
            txtCatname.Focus()
        End If
    End Sub

    Private Sub tbCatName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCatname.KeyPress
        If e.KeyChar = vbCr Then
            tsMenu2.Items(1).Select()
            tsMenu2.Focus()
        End If
    End Sub

    Private Sub dgvCategory_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvCategory.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.PageDown Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.PageUp Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dgvCategory_CellClick(1, New DataGridViewCellEventArgs(0, dgvCategory.CurrentRow.Index))
        End If
    End Sub

    Private Sub btnReresh_Click(sender As Object, e As EventArgs) Handles btnReresh.Click
        LoadCategory()
        btnAdd.PerformClick()
    End Sub
End Class
