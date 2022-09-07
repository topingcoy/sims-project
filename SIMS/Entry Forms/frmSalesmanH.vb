Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic

Public Class frmSalesmanH

    Private Sub frmSalesmanH_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub frmSalesmanH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSalesman()
        LoadWarehouse()
        LoadTypeofOper()
    End Sub


    Private Sub tsaddsalesman_Click(sender As Object, e As EventArgs)
        gbxSalesman.Visible = True
    End Sub

    Sub LoadSalesman()
        dgvSalesmanList.Rows.Clear()
        Dim i As Integer
        cmd = New MySqlCommand("SELECT * FROM salesman", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvSalesmanList.Rows.Add(i, rd.Item("slmncode").ToString, rd.Item("slmnname").ToString, rd.Item("bort").ToString, rd.Item("whscode").ToString, rd.Item("whsname").ToString, rd.Item("opercode").ToString, rd.Item("typeofoper").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
        cmd.Dispose()
    End Sub

    Sub LoadWarehouse()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand

        cboWhsCode.Items.Clear()
        cboWhsCode.DisplayMember = "text"

        qry = "Select * FROM warehouse ORDER BY warehouse"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            cboWhsCode.Items.Add(New With {.Text = relr("whscode").ToString(), .Value = relr("warehouse").ToString()})
        End While
        relr.Close()
        rmd.Dispose()

    End Sub

    Sub LoadTypeofOper()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand

        cboTypeOperCode.Items.Clear()
        cboTypeOperCode.DisplayMember = "text"

        qry = "Select * FROM typeoper ORDER BY operationname"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            cboTypeOperCode.Items.Add(New With {.Text = relr("opercode").ToString(), .Value = relr("operationname").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub

    Private Sub cboBT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboBT.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxWarehouse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboWhsCode.KeyPress
        e.Handled = True
        'cbxWarehouse.Text = StrConv(cbxWarehouse.Text, VbStrConv.Uppercase)
        'cmd = New MySqlCommand("select * from salesman where whscode like '" & cbxWarehouse.Text & "'", cdb)
        'rd = cmd.ExecuteReader
        'rd.Read()
        'If rd.HasRows Then
        '    lblWarehouseName.Text = rd.Item("whsname").ToString
        'End If
        'rd.Close()
    End Sub

    Private Sub cbxTypeOper_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTypeOperCode.KeyPress
        e.Handled = True
    End Sub

    Private Sub dgvSalesmanList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesmanList.CellClick
        With dgvSalesmanList
            gbxSalesman.Text = "EDIT SALESMAN"
            txtSlmcode.Text = dgvSalesmanList.Rows(e.RowIndex).Cells(1).Value.ToString
            txtSalesmanName.Text = dgvSalesmanList.Rows(e.RowIndex).Cells(2).Value.ToString
            cboBT.Text = dgvSalesmanList.Rows(e.RowIndex).Cells(3).Value.ToString
            cboWhsCode.Text = dgvSalesmanList.Rows(e.RowIndex).Cells(4).Value.ToString
            txtWarehouse.Text = dgvSalesmanList.Rows(e.RowIndex).Cells(5).Value.ToString
            cboTypeOperCode.Text = dgvSalesmanList.Rows(e.RowIndex).Cells(6).Value.ToString
            txtTypeOper.Text = dgvSalesmanList.Rows(e.RowIndex).Cells(7).Value.ToString
            lblpkno.Text = dgvSalesmanList.Rows(e.RowIndex).Cells(8).Value.ToString
            txtSlmcode.Enabled = False
            btnSave.Enabled = False
            btnUpdate.Enabled = True
        End With
    End Sub

    Private Sub dgvSalesmanList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesmanList.CellContentClick
        'Dim colName As String = dgvSalesmanList.Columns(e.ColumnIndex).Name
        'If colName = "Edit" Then
        '    With gbxSalesman
        '        gbxSalesman.Text = "EDIT SALESMAN"
        '        tbSlmCode.Text = dgvSalesmanList.Rows(e.RowIndex).Cells(1).Value.ToString
        '        tbSalesmanName.Text = dgvSalesmanList.Rows(e.RowIndex).Cells(2).Value.ToString
        '        cbxBT.Text = dgvSalesmanList.Rows(e.RowIndex).Cells(3).Value.ToString
        '        cbxWarehouse.Text = dgvSalesmanList.Rows(e.RowIndex).Cells(4).Value.ToString
        '        lblWarehouseName.Text = dgvSalesmanList.Rows(e.RowIndex).Cells(5).Value.ToString
        '        cbxTypeOper.Text = dgvSalesmanList.Rows(e.RowIndex).Cells(6).Value.ToString
        '        lblTypeOper.Text = dgvSalesmanList.Rows(e.RowIndex).Cells(7).Value.ToString
        '        lblpkno.Text = dgvSalesmanList.Rows(e.RowIndex).Cells(8).Value.ToString
        '        tbSlmCode.Enabled = False
        '        gbxSalesman.Visible = True
        '        SaveSalesman.Enabled = False
        '        UpdateSalesman.Enabled = True
        '        CloseSalesman.Enabled = True
        '    End With
        'ElseIf colName = "Delete" Then
        '    If MsgBox("Delete this Salesman? Click Yes to Confirm", vbYesNo + vbQuestion) = vbYes Then
        '        cmd = New MySqlCommand("DELETE FROM salesman where slmcode like '" & dgvSalesmanList.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cdb)
        '        cmd.ExecuteNonQuery()
        '        MsgBox("Salesman Has Been Successfully Deleted!", vbInformation)
        '        LoadSalesman()
        '    End If
        'End If
    End Sub

    Private Sub SaveSalesman_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'trap duplicate
        If checkslsmancode() = True Then
            MsgBox("Salesman Code Already Exist!", 48, "Enter Salesman Code")
            Exit Sub
        End If

        If checkslsmanname() = True Then
            MsgBox("Salesman Name Already Exist!", 48, "Enter Salesman Name")
            Exit Sub
        End If

        If txtSlmcode.Text = Nothing Or txtSalesmanName.Text = Nothing Or cboBT.Text = Nothing Or cboWhsCode.Text = Nothing Or cboTypeOperCode.Text = Nothing Then
            MsgBox("Enter Missing Field!", 48, "Enter Salesman")
            Exit Sub
        End If

        'save to salesman
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("INSERT INTO salesman (slmncode,slmnname,bort,whscode,whsname,opercode,typeofoper) VALUES (@slmncode,@slmname,@bt,@whscode,@whsname,@opercode,@typeofoper)", cdb)
        cmd.Parameters.AddWithValue("@slmncode", txtSlmcode.Text)
        cmd.Parameters.AddWithValue("@slmname", txtSalesmanName.Text)
        cmd.Parameters.AddWithValue("@bt", cboBT.Text)
        cmd.Parameters.AddWithValue("@whscode", cboWhsCode.Text)
        cmd.Parameters.AddWithValue("@whsname", txtWarehouse.Text)
        cmd.Parameters.AddWithValue("@opercode", cboTypeOperCode.Text)
        cmd.Parameters.AddWithValue("@typeofoper", txtTypeOper.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Salesman Has Been Successfully Save!", vbInformation)
        txtSlmcode.Clear()
        txtSalesmanName.Clear()
        cboBT.Text = Nothing
        cboWhsCode.Text = Nothing
        cboTypeOperCode.Text = Nothing
        LoadSalesman()
        txtWarehouse.Text = Nothing
        txtTypeOper.Text = Nothing
        btnAdd_Click(sender, e)
    End Sub

    Function checkslsmancode()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT slmncode FROM salesman WHERE slmncode = @slmncode", cdb)
        With cmd
            .Parameters.AddWithValue("@slmncode", txtSlmcode.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Function checkslsmanname()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT slmnname FROM salesman WHERE slmnname = @slmnname", cdb)
        With cmd
            .Parameters.AddWithValue("@slmnname", txtSalesmanName.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Private Sub UpdateSalesman_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If MsgBox("Update this Salesman?", vbYesNo + vbQuestion) = vbYes Then
            UpdateSalesmans()
        End If
        MsgBox("Salesman has been successfully updated!", vbInformation)
        txtSlmcode.Clear()
        txtSalesmanName.Clear()
        cboBT.Text = Nothing
        cboWhsCode.Text = Nothing
        cboTypeOperCode.Text = Nothing
        LoadSalesman()
        'tbWarehouse.Text = Nothing
        'tbTypeOp.Text = Nothing
        btnAdd_Click(sender, e)
    End Sub

    Sub UpdateSalesmans()
        'updatesalesman
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("UPDATE salesman SET slmncode=@slmncode, slmnname=@slmname, bort=@bt, whscode=@wcode, whsname=@wname, opercode=@ocode, typeofoper=@oname where pkno=@pkno", cdb)
        cmd.Parameters.AddWithValue("@slmncode", txtSlmcode.Text)
        cmd.Parameters.AddWithValue("@slmname", txtSalesmanName.Text)
        cmd.Parameters.AddWithValue("@bt", cboBT.Text)
        cmd.Parameters.AddWithValue("@wcode", cboWhsCode.Text)
        cmd.Parameters.AddWithValue("@wname", txtWarehouse.Text)
        cmd.Parameters.AddWithValue("@ocode", cboTypeOperCode.Text)
        cmd.Parameters.AddWithValue("@oname", txtTypeOper.Text)
        cmd.Parameters.AddWithValue("@pkno", lblpkno.Text)
        cmd.ExecuteNonQuery()

    End Sub

    Private Sub cbxWarehouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboWhsCode.SelectedIndexChanged
        Dim cmd As MySqlCommand
        Dim rdx As MySqlDataReader
        '        cbxWarehouse.Text = StrConv(cbxWarehouse.Text, VbStrConv.Uppercase)
        cmd = New MySqlCommand("SELECT * from warehouse where whscode like '%" & cboWhsCode.Text & "%'", cdb)
        rdx = cmd.ExecuteReader
        If rdx.HasRows Then
            rdx.Read()
            With rdx
                txtWarehouse.Text = rdx.Item("warehouse").ToString
            End With
        End If
        rdx.Close()

    End Sub

    Private Sub cbxTypeOper_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTypeOperCode.SelectedIndexChanged
        Dim cmd As MySqlCommand
        Dim rxd As MySqlDataReader
        cmd = New MySqlCommand("SELECT * from typeoper where opercode like '%" & cboTypeOperCode.Text & "%'", cdb)
        rxd = cmd.ExecuteReader
        If rxd.HasRows Then
            rxd.Read()
            With rxd
                txtTypeOper.Text = rxd.Item("operationname").ToString
            End With
        End If
        rxd.Close()
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim i As Integer
        Dim cmd As MySqlCommand
        Dim rdd As MySqlDataReader
        dgvSalesmanList.Rows.Clear()
        cmd = New MySqlCommand("SELECT * FROM salesman where slmnname like '%" & txtSearch.Text & "%' or slmcode like '%" & txtSearch.Text & "%'", cdb)
        rdd = cmd.ExecuteReader
        While rdd.Read
            i += 1
            ' dgvSalesmanList.Rows.Add(i, rd.Item("slmcode").ToString, rd.Item("slmnname").ToString, rd.Item("bort").ToString, rd.Item("whscode").ToString, rd.Item("typeofoper").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
            dgvSalesmanList.Rows.Add(i, rdd.Item("slmcode").ToString, rdd.Item("slmnname").ToString, rdd.Item("bort").ToString, rdd.Item("whscode").ToString, rdd.Item("whsname").ToString, rdd.Item("opercode").ToString, rdd.Item("typeofoper").ToString, rdd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rdd.Close()
    End Sub

    Private Sub dgvSalesmanList_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvSalesmanList.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.PageDown Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.PageUp Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dgvSalesmanList_CellClick(1, New DataGridViewCellEventArgs(0, dgvSalesmanList.CurrentRow.Index))
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        gbxSalesman.Text = "ADD SALESMAN"
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        txtSlmcode.Clear()
        txtSalesmanName.Clear()
        cboWhsCode.Text = Nothing
        cboTypeOperCode.Text = Nothing
        cboBT.Text = Nothing
        lblpkno.Text = Nothing
        txtSlmcode.Enabled = True
        txtWarehouse.Text = Nothing
        txtTypeOper.Text = Nothing
        txtSlmcode.Focus()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadSalesman()
        btnAdd_Click(sender, e)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With dgvSalesmanList
            If .RowCount > 0 Then
                Dim pkno As String = Nothing
                Dim sCode As String = Nothing
                pkno = .Item(8, .CurrentRow.Index).Value
                sCode = .Item(1, .CurrentRow.Index).Value

                If checkAllExistingSLMNCODE(sCode) Then
                    'MsgBox("naa")
                    MsgBox("This salesman has already transaction. Cannot be deleted.", vbInformation)
                    Exit Sub
                Else 'false
                    'MsgBox("wala")
                    If MsgBox("Delete Salesman :" & sCode & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then
                        Dim cmd As MySqlCommand
                        cmd = New MySqlCommand("DELETE FROM salesman where slmncode=@scode", cdb)
                        cmd.Parameters.AddWithValue("@scode", sCode)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        MsgBox("Salesman has been successfully deleted!", vbInformation)
                        LoadSalesman()
                        btnAdd_Click(sender, e)
                    End If
                End If
            End If
        End With

        'With dgvSalesmanList
        '    If MsgBox("Delete this Salesman? Click Yes to Confirm", vbYesNo + vbQuestion) = vbYes Then
        '        cmd = New MySqlCommand("DELETE FROM salesman where slmcode like '" & dgvSalesmanList.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cdb)
        '        cmd.ExecuteNonQuery()
        '        MsgBox("Salesman Has Been Successfully Deleted!", vbInformation)
        '        LoadSalesman()
        '    End If
        'End With
    End Sub

    Function checkAllExistingSLMNCODE(ByVal slmncode As String) As Boolean
        Dim retVar As Boolean = False
        If checkSlmncodefromCUSTSALES(slmncode) _
            Or checkSlmncodefromSALESH(slmncode) _
            Or checkSlmncodefromEXPRESH(slmncode) _
            Or checkSlmncodefromEXPRESD(slmncode) _
            Or checkSlmncodefromCOLLH(slmncode) _
            Or checkSlmncodefromPAYH(slmncode) Then
            retVar = True
        Else
            retVar = False
        End If
        Return retVar

    End Function

    'Public Function checkItemIsExisting(ByVal itemcode As String) As Boolean
    '    Dim retVar As Boolean = False

    '    If checkItemIsExistingIVD(itemcode) _
    '        Or checkItemIsExistingRCVINGD(itemcode) _
    '        Or checkItemIsExistingSALESD(itemcode) _
    '        Or checkItemisExistingPHYIVD(itemcode) _
    '        Or checkItemisExistingPHYIVA(itemcode) Then
    '        retVar = True
    '    Else
    '        retVar = False
    '    End If
    '    Return retVar
    'End Function

    Function checkSlmncodefromCUSTSALES(ByVal slmncode As String) As Boolean
        Dim retvar As Boolean = False
        cmd = New MySqlCommand("SELECT slmncode FROM custsales WHERE slmncode=@scode and isdeleted='0'", cdb)
        cmd.Parameters.AddWithValue("@scode", slmncode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retvar = True
            End If
        End Using
        Return retvar

        'Dim retVar As Boolean = False

        'Dim cmd As MySqlCommand
        'cmd = New MySqlCommand("SELECT * " & _
        '        "FROM salesd AS sd " & _
        '         "Where sd.isdeleted = '0' and sd.itemcode = @itemcode", cdb)
        'cmd.Parameters.AddWithValue("@itemcode", itemcode)
        'Using rd As MySqlDataReader = cmd.ExecuteReader
        '    If rd.HasRows Then
        '        retVar = True
        '    End If
        'End Using
        'cmd.Dispose()

        'Return retVar

      

    End Function

    Function checkSlmncodefromSALESH(ByVal slmncode As String) As Boolean
        Dim retvar As Boolean = False
        cmd = New MySqlCommand("SELECT slmncode FROM salesh WHERE slmncode=@scode and isdeleted='0'", cdb)
        cmd.Parameters.AddWithValue("@scode", slmncode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retvar = True
            End If
        End Using
        Return retvar
    End Function

    Function checkSlmncodefromEXPRESH(ByVal slmncode As String) As Boolean
        Dim retvar As Boolean = False
        cmd = New MySqlCommand("SELECT slmncode FROM expresh WHERE slmncode=@scode and isdeleted='0'", cdb)
        cmd.Parameters.AddWithValue("@scode", slmncode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retvar = True
            End If
        End Using
        Return retvar
    End Function

    Function checkSlmncodefromEXPRESD(ByVal slmncode As String) As Boolean
        Dim retvar As Boolean = False
        cmd = New MySqlCommand("SELECT slmncode FROM expresd WHERE slmncode=@scode and isdeleted='0'", cdb)
        cmd.Parameters.AddWithValue("@scode", slmncode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retvar = True
            End If
        End Using
        Return retvar
    End Function

    Function checkSlmncodefromCOLLH(ByVal slmncode As String) As Boolean
        Dim retvar As Boolean = False
        cmd = New MySqlCommand("SELECT slmncode FROM collh WHERE slmncode=@scode and isdeleted='0'", cdb)
        cmd.Parameters.AddWithValue("@scode", slmncode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retvar = True
            End If
        End Using
        Return retvar
    End Function

    Function checkSlmncodefromPAYH(ByVal slmncode As String) As Boolean
        Dim retvar As Boolean = False
        cmd = New MySqlCommand("SELECT slmncode FROM payh WHERE slmncode=@scode and isdeleted='0'", cdb)
        cmd.Parameters.AddWithValue("@scode", slmncode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retvar = True
            End If
        End Using
        Return retvar
    End Function

End Class