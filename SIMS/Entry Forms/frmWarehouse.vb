Imports MySql.Data.MySqlClient

Public Class frmWarehouse

    Private Sub frmWarehouse_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Dim lastitemsel As String = Nothing

    Private Sub frmWarehouse_InputLanguageChanged(sender As Object, e As InputLanguageChangedEventArgs) Handles Me.InputLanguageChanged

    End Sub

    Private Sub frmWarehouse_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            btn_AddWarehouse_Click(sender, e)
        ElseIf e.KeyCode = Keys.F6 Then
            btn_RereshWhs_Click(sender, e)
        ElseIf e.KeyCode = Keys.F7 Then
            btn_DeleteWhs_Click(sender, e)
        End If
        If e.KeyCode = Keys.Escape Then
            If txtWhscode.Text <> Nothing And txtWhsname.Text <> Nothing Then
                If MsgBox("Are you sure you want to close?", vbYesNo + vbQuestion, "Mange Warehouse") = vbYes Then
                    Me.Dispose()
                End If
            End If
        End If
    End Sub

    Private Sub frmWarehouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadwarehouse()
        SaveWhs.Enabled = True
        UpdateWhs.Enabled = False

    End Sub


    Private Sub tsaddwhs_Click(sender As Object, e As EventArgs)
        txtWhscode.Focus()
    End Sub

    Private Sub CloseGBwhs_Click(sender As Object, e As EventArgs)
        txtWhsname.Clear()
        txtWhscode.Clear()
        ' gbxWarehouse.Visible = False
    End Sub

    Private Sub SaveWhs_Click(sender As Object, e As EventArgs) Handles SaveWhs.Click
        'trap duplicate
        If checkwhscode() = True Then
            MsgBox("Warehouse code already exist!", 48, "Enter Warehouse Code")
            Exit Sub
        End If

        If checkwhsname() = True Then
            MsgBox("Warehouse name already exist!", 48, "Enter Warehouse Name")
            Exit Sub
        End If

        If txtWhscode.Text = Nothing Or txtWhsname.Text = Nothing Then
            MsgBox("Enter missing field!", 48, "Enter Warehouse")
            Exit Sub
        End If

        'save to warehouse
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("INSERT INTO warehouse (whscode,warehouse) VALUES (@wcode,@whs)", cdb)
        cmd.Parameters.AddWithValue("@wcode", txtWhscode.Text)
        cmd.Parameters.AddWithValue("@whs", txtWhsname.Text)
        cmd.ExecuteNonQuery()
        AuditTrail("Whs code.:" & Space(1) & txtWhscode.Text & Space(2) & "Warehouse name:" & Space(1) & txtWhsname.Text, "Add New Warehouse")
        MsgBox("Warehouse has been save!", vbInformation)
        txtWhscode.Clear()
        txtWhsname.Clear()
        Loadwarehouse()
    End Sub

    Function checkwhscode()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT whscode FROM warehouse WHERE whscode = @whscode", cdb)
        With cmd
            .Parameters.AddWithValue("@whscode", txtWhscode.Text.Trim)
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
            .Parameters.AddWithValue("@whsname", txtWhsname.Text.Trim)
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
        'Dim cmd As MySqlCommand
        'Dim rd As MySqlDataReader
        txtWhscode.Clear()
        txtWhsname.Clear()
        cmd = New MySqlCommand("SELECT * FROM warehouse", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvWhs.Rows.Add(i, rd.Item("whscode").ToString, rd.Item("warehouse").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
        btn_AddWarehouse.PerformClick()
    End Sub

    Private Sub tsEditWhs_Click(sender As Object, e As EventArgs)

        ' With gbxWarehouse
        Dim cmd As MySqlCommand
        Dim rd As MySqlDataReader

        cmd = New MySqlCommand("SELECT * FROM warehouse", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            With gbxWarehouse
                txtWhscode.Text = rd.Item("whscode").ToString
                txtWhscode.Text = rd.Item("warehouse").ToString
                .Show()
                txtWhscode.Enabled = False
            End With
        End If

        ' End With
        'With gbxWarehouse
        '    tbWhsCode.Text = dgvWhs.Rows.Cells(1).Value.ToString
        '    tbWhsName.Text = dgvWhs.Rows(e.RowIndex).Cells(2).Value.ToString
        '    gbxWarehouse.Visible = True
        'End With
    End Sub

    Private Sub dgvWhs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWhs.CellClick

        With dgvWhs
            If .RowCount > 0 And e.RowIndex >= 0 Then
                gbxWarehouse.Text = "EDIT WAREHOUSE"
                txtWhscode.Text = dgvWhs.Rows(e.RowIndex).Cells(1).Value.ToString
                txtWhsname.Text = dgvWhs.Rows(e.RowIndex).Cells(2).Value.ToString
                lblpkno.Text = dgvWhs.Rows(e.RowIndex).Cells(3).Value.ToString
                txtWhscode.Enabled = False
                gbxWarehouse.Visible = True
                SaveWhs.Enabled = False
                UpdateWhs.Enabled = True

                lastitemsel = dgvWhs.Rows(e.RowIndex).Cells(2).Value.ToString

            End If
        End With
    End Sub

    Private Sub dgvWhs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWhs.CellContentClick
        'Dim colName As String = dgvWhs.Columns(e.ColumnIndex).Name
        'If colName = "Edit" Then
        '    With gbxWarehouse
        '        gbxWarehouse.Text = "EDIT WAREHOUSE"
        '        tbWhsCode.Text = dgvWhs.Rows(e.RowIndex).Cells(1).Value.ToString
        '        tbWhsName.Text = dgvWhs.Rows(e.RowIndex).Cells(2).Value.ToString
        '        lblpkno.Text = dgvWhs.Rows(e.RowIndex).Cells(3).Value.ToString
        '        tbWhsCode.Enabled = False
        '        gbxWarehouse.Visible = True
        '        SaveWhs.Enabled = False
        '        UpdateWhs.Enabled = True
        '    End With
        'ElseIf colName = "Delete" Then
        '    If MsgBox("Delete this Warehouse? Click Yes to Confirm", vbYesNo + vbQuestion) = vbYes Then
        '        cmd = New MySqlCommand("DELETE from warehouse where whscode like '" & dgvWhs.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cdb)
        '        cmd.ExecuteNonQuery()
        '        MsgBox("Warehouse has been Successfully Deleted!", vbInformation)
        '        Loadwarehouse()
        '    End If
        'End If
    End Sub

    Private Sub UpdateWhs_Click(sender As Object, e As EventArgs) Handles UpdateWhs.Click
        If txtWhscode.Text = Nothing Or txtWhsname.Text = Nothing Then
            MsgBox("Pls Select Record to Update!", vbExclamation)
            Exit Sub
        ElseIf MsgBox("Update this Warehouse?", vbYesNo + vbQuestion, "Continue") = vbYes Then
            cmd = New MySqlCommand("UPDATE warehouse set whscode=@wc, warehouse=@wh where pkno=@pk", cdb)
            With cmd
                .Parameters.AddWithValue("@pk", lblpkno.Text.Trim)
                .Parameters.AddWithValue("@wc", txtWhscode.Text)
                .Parameters.AddWithValue("@wh", txtWhsname.Text)
                .ExecuteNonQuery()
            End With
            AuditTrail("Whs code.:" & Space(1) & txtWhscode.Text & Space(2) & "Warehouse name:" & Space(1) & txtWhsname.Text, "Update Warehouse")
            MsgBox("Warehouse has been Updated.", vbInformation)
            Loadwarehouse()
            txtWhscode.Clear()
            txtWhsname.Clear()
            lblpkno.Text = ""
        End If
    End Sub

    Private Sub tbSearchWhs_TextChanged(sender As Object, e As EventArgs) Handles tbSearchWhs.TextChanged
        Try
            Dim i As Integer
            dgvWhs.Rows.Clear()
            cmd = New MySqlCommand("SELECT * from Warehouse where warehouse like '%" & tbSearchWhs.Text & "%' or whscode like '%" & tbSearchWhs.Text & "%'", cdb)
            rd = cmd.ExecuteReader
            While rd.Read
                i += 1
                dgvWhs.Rows.Add(i, rd.Item("whscode").ToString, rd.Item("warehouse").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
            End While
            rd.Close()

        Catch ex As Exception

            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        gbxWarehouse.Text = "ADD WAREHOUSE"
        gbxWarehouse.Visible = True
        SaveWhs.Enabled = True
        UpdateWhs.Enabled = False
        txtWhscode.Enabled = True
        txtWhscode.Clear()
        txtWhsname.Clear()
        txtWhscode.Focus()
    End Sub

    Private Sub CloseWh_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub tbWhsCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWhscode.KeyPress
        If e.KeyChar = vbCr Then
            txtWhsname.Focus()
        End If
    End Sub



    Private Sub dgvWhs_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvWhs.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.PageDown Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.PageUp Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dgvWhs_CellClick(1, New DataGridViewCellEventArgs(0, dgvWhs.CurrentRow.Index))
        End If
    End Sub

    Private Sub tsNewSupCM_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        'SaveWhs.Enabled = True
        'UpdateWhs.Enabled = False
        'tbWhsCode.Enabled = True
        'tbWhsName.Enabled = True
        'tbWhsCode.Clear()
        'tbWhsName.Clear()
        'tbWhsCode.Focus()
    End Sub


    Private Sub btn_RereshWhs_Click(sender As Object, e As EventArgs) Handles btn_RereshWhs.Click
        SaveWhs.Enabled = False
        UpdateWhs.Enabled = False
        Loadwarehouse()
    End Sub

    Private Sub btn_DeleteWhs_Click(sender As Object, e As EventArgs) Handles btn_DeleteWhs.Click
        With dgvWhs
            If .RowCount > 0 Then
                Dim myWhs As String = Nothing
                Dim wCode As String = Nothing
                myWhs = .Item(3, .CurrentRow.Index).Value 'pkno
                wCode = .Item(1, .CurrentRow.Index).Value 'whscode

                If checkWhscodeIfExistingALL(wCode) Then
                    'MsgBox("naa")
                    MsgBox("This warehouse has already transaction. Cannot be deleted.", vbInformation)
                Else 'false
                    'MsgBox("wala")
                    If MsgBox("Delete Warehouse :" & wCode & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then
                        If checkExistingQtyGoodWhscodefromIVWH(wCode) = True Then
                            MsgBox("Warehouse has transaction to IVWH. Cannot be deleted", vbInformation)
                            Exit Sub
                        End If

                        Dim cmd As MySqlCommand
                        'cmd = New MySqlCommand("UPDATE supcmdm SET isdeleted=1 WHERE transno=@tr", cdb)
                        cmd = New MySqlCommand("DELETE FROM warehouse where whscode=@whscode", cdb)
                        cmd.Parameters.AddWithValue("@whscode", wCode)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        'ivwh
                        cmd = New MySqlCommand("DELETE FROM ivwh where whscode=@whscode", cdb)
                        cmd.Parameters.AddWithValue("@whscode", wCode)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        AuditTrail("Whs code.:" & Space(1) & txtWhscode.Text & Space(2) & "Warehouse name:" & Space(1) & txtWhsname.Text, "Delete Warehouse")
                        MsgBox("Warehouse has been successfully deleted!", vbInformation)
                        txtWhscode.Clear()
                        txtWhsname.Clear()
                        Loadwarehouse()
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub btn_AddWarehouse_Click(sender As Object, e As EventArgs) Handles btn_AddWarehouse.Click
        gbxWarehouse.Text = "ADD WAREHOUSE"
        SaveWhs.Enabled = True
        UpdateWhs.Enabled = False
        txtWhscode.Enabled = True
        txtWhsname.Enabled = True
        txtWhscode.Clear()
        txtWhsname.Clear()
        txtWhscode.Focus()
    End Sub

    Private Sub tbWhsName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWhsname.KeyPress
        If e.KeyChar = vbCr Then
            tsMenu2.Items(1).Select()
            tsMenu2.Focus()
        End If
    End Sub

    Function checkTablesThatContainsWhscode(ByVal whscode As String, ByVal tablename As String) As Boolean
        Dim retvar As Boolean = False
        cmd = New MySqlCommand("SELECT whscode FROM " & tablename & " WHERE whscode=@wc and isdeleted='0'", cdb)
        cmd.Parameters.AddWithValue("@wc", whscode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retvar = True
            End If
        End Using
        Return retvar
    End Function



    'Function checkWhscodeIsExistingIVD(ByVal whscode As String) As Boolean
    '    Dim retvar As Boolean = False
    '    cmd = New MySqlCommand("SELECT whscode FROM ivd WHERE whscode=@wc", cdb)
    '    cmd.Parameters.AddWithValue("@wc", whscode)
    '    Using rd As MySqlDataReader = cmd.ExecuteReader
    '        If rd.HasRows Then
    '            retvar = True
    '        End If
    '    End Using
    '    Return retvar
    'End Function

    'Function checkWhscodeIsExistingIVH(ByVal whscode As String) As Boolean
    '    Dim retvar As Boolean = False
    '    cmd = New MySqlCommand("SELECT whscode FROM ivh WHERE whscode=@wc", cdb)
    '    cmd.Parameters.AddWithValue("@wc", whscode)
    '    Using rd As MySqlDataReader = cmd.ExecuteReader
    '        If rd.HasRows Then
    '            retvar = True
    '        End If
    '    End Using
    '    Return retvar
    'End Function

    ' Function checkWhscodeIsExistingIVWH(ByVal whscode As String) As Boolean
    '    Dim retvar As Boolean = False
    '    cmd = New MySqlCommand("SELECT whscode FROM ivwh WHERE whscode=@wc", cdb)
    '    cmd.Parameters.AddWithValue("@wc", whscode)
    '    Using rd As MySqlDataReader = cmd.ExecuteReader
    '        If rd.HasRows Then
    '            retvar = True
    '        End If
    '    End Using
    '    Return retvar
    'End Function

    'Public Function checkWhscodeIsExistingPHYIVH(ByVal whscode As String) As Boolean
    '    Dim retvar As Boolean = False
    '    cmd = New MySqlCommand("SELECT whscode FROM phyivh WHERE whscode=@wc", cdb)
    '    cmd.Parameters.AddWithValue("@wc", whscode)
    '    Using rd As MySqlDataReader = cmd.ExecuteReader
    '        If rd.HasRows Then
    '            retvar = True
    '        End If
    '    End Using
    '    Return retvar
    'End Function

    'Public Function checkWhscodeIsExistingPHYIVD(ByVal whscode As String) As Boolean
    '    Dim retvar As Boolean = False
    '    cmd = New MySqlCommand("SELECT whscode FROM phyivd WHERE whscode=@wc", cdb)
    '    cmd.Parameters.AddWithValue("@wc", whscode)
    '    Using rd As MySqlDataReader = cmd.ExecuteReader
    '        If rd.HasRows Then
    '            retvar = True
    '        End If
    '    End Using
    '    Return retvar
    'End Function

    'Public Function checkWhscodeIsExistingPHYIVA(ByVal whscode As String) As Boolean
    '    Dim retvar As Boolean = False
    '    cmd = New MySqlCommand("SELECT whscode FROM phyiva WHERE whscode=@wc", cdb)
    '    cmd.Parameters.AddWithValue("@wc", whscode)
    '    Using rd As MySqlDataReader = cmd.ExecuteReader
    '        If rd.HasRows Then
    '            retvar = True
    '        End If
    '    End Using
    '    Return retvar
    'End Function

    'Public Function checkWhscodeIsExistingRCVINGH(ByVal whscode As String) As Boolean
    '    Dim retvar As Boolean = False
    '    cmd = New MySqlCommand("SELECT whscode FROM rcvingh WHERE whscode=@wc", cdb)
    '    cmd.Parameters.AddWithValue("@wc", whscode)
    '    Using rd As MySqlDataReader = cmd.ExecuteReader
    '        If rd.HasRows Then
    '            retvar = True
    '        End If
    '    End Using
    '    Return retvar
    'End Function

    'Public Function checkWhscodeIsExistingRCVINGD(ByVal whscode As String) As Boolean
    '    Dim retvar As Boolean = False
    '    cmd = New MySqlCommand("SELECT whscode FROM rcvingd WHERE whscode=@wc", cdb)
    '    cmd.Parameters.AddWithValue("@wc", whscode)
    '    Using rd As MySqlDataReader = cmd.ExecuteReader
    '        If rd.HasRows Then
    '            retvar = True
    '        End If
    '    End Using
    '    Return retvar
    'End Function

    'Public Function checkWhscodeIsExistingSALESD(ByVal whscode As String) As Boolean
    '    Dim retvar As Boolean = False
    '    cmd = New MySqlCommand("SELECT whscode FROM salesd WHERE whscode=@wc and isdeleted='1'", cdb)
    '    cmd.Parameters.AddWithValue("@wc", whscode)
    '    Using rd As MySqlDataReader = cmd.ExecuteReader
    '        If rd.HasRows Then
    '            retvar = True
    '        End If
    '    End Using
    '    Return retvar
    'End Function

    'Public Function checkWhscodeIsExistingSALESH(ByVal whscode As String) As Boolean
    '    Dim retvar As Boolean = False
    '    cmd = New MySqlCommand("SELECT whscode FROM salesh WHERE whscode=@wc", cdb)
    '    cmd.Parameters.AddWithValue("@wc", whscode)
    '    Using rd As MySqlDataReader = cmd.ExecuteReader
    '        If rd.HasRows Then
    '            retvar = True
    '        End If
    '    End Using
    '    Return retvar
    'End Function

    'Public Function checkWhscodeIsExistingSALESMAN(ByVal whscode As String) As Boolean
    '    Dim retvar As Boolean = False
    '    cmd = New MySqlCommand("SELECT whscode FROM salesman WHERE whscode=@wc", cdb)
    '    cmd.Parameters.AddWithValue("@wc", whscode)
    '    Using rd As MySqlDataReader = cmd.ExecuteReader
    '        If rd.HasRows Then
    '            retvar = True
    '        End If
    '    End Using
    '    Return retvar
    'End Function

    'Public Function checkWhscodeIsExistingCUSTSALES(ByVal whscode As String) As Boolean
    '    Dim retvar As Boolean = False
    '    cmd = New MySqlCommand("SELECT whscode FROM custsales WHERE whscode=@wc", cdb)
    '    cmd.Parameters.AddWithValue("@wc", whscode)
    '    Using rd As MySqlDataReader = cmd.ExecuteReader
    '        If rd.HasRows Then
    '            retvar = True
    '        End If
    '    End Using
    '    Return retvar
    'End Function

    Function checkTOHWSfromIVD(ByVal whscode As String) As Boolean
        Dim retvar As Boolean = False
        cmd = New MySqlCommand("SELECT towhs FROM ivd WHERE towhs=@wc and isdeleted='0'", cdb)
        cmd.Parameters.AddWithValue("@wc", whscode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retvar = True
            End If
        End Using
        Return retvar
    End Function

    Function checkTOHWSfromIVH(ByVal whscode As String) As Boolean
        Dim retvar As Boolean = False
        cmd = New MySqlCommand("SELECT towhs FROM ivh WHERE towhs=@wc and isdeleted='0'", cdb)
        cmd.Parameters.AddWithValue("@wc", whscode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retvar = True
            End If
        End Using
        Return retvar
    End Function

    Public Function checkWhscodeIfExistingALL(ByVal whscode As String) As Boolean
        Dim retVar As Boolean = False
        If Not checkTablesThatContainsWhscode(whscode, "ivd") _
            Or Not checkTOHWSfromIVD(whscode) _
            Or Not checkTOHWSfromIVH(whscode) _
            Or Not checkTablesThatContainsWhscode(whscode, "ivh") _
            Or Not checkTablesThatContainsWhscode(whscode, "phyivh") _
            Or Not checkTablesThatContainsWhscode(whscode, "phyivd") _
            Or Not checkTablesThatContainsWhscode(whscode, "phyivA") _
            Or Not checkTablesThatContainsWhscode(whscode, "rcvingh") _
            Or Not checkTablesThatContainsWhscode(whscode, "rcvingd") _
            Or Not checkTablesThatContainsWhscode(whscode, "salesd") _
            Or Not checkTablesThatContainsWhscode(whscode, "salesh") _
            Or Not checkTablesThatContainsWhscode(whscode, "salesman") _
            Or Not checkTablesThatContainsWhscode(whscode, "custsales") Then
            'Or checkWhscodeIsExistingIVWH(whscode) _
            retVar = False
        End If
        Return retVar
    End Function

    Function checkExistingQtyGoodWhscodefromIVWH(ByVal whscode As String) As Boolean
        Dim retvar As Boolean = False
        Dim totalqtygood As Decimal = 0
        cmd = New MySqlCommand("SELECT SUM(qty_good) totalqtygood, whscode FROM ivwh WHERE whscode=@wc", cdb)
        cmd.Parameters.AddWithValue("@wc", whscode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                totalqtygood = Val(rd("totalqtygood").ToString)
                If totalqtygood > 0 Then
                    retvar = True 'naa pay sulod -> dili ka delete
                Else
                    retvar = False
                End If
            End If
        End Using
        Return retvar
    End Function

End Class