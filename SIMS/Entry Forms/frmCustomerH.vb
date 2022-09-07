Imports MySql.Data.MySqlClient

Public Class frmCustomerH

    Private Sub AddCust_Click(sender As Object, e As EventArgs)
        frmCustomerD.ShowDialog()
    End Sub

    Private Sub frmCustomerH_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            btnAdd_Click(sender, e)
        ElseIf e.KeyCode = Keys.F6 Then
            btnRefresh_Click(sender, e)
        ElseIf e.KeyCode = Keys.F7 Then
            btnDelete_Click(sender, e)
        ElseIf e.KeyCode = Keys.Escape Then
            If gbSalesman.Visible = True Then
                gbSalesman.Visible = False
                gbSalesman.SendToBack()
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmCustomerH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomer()
        LoadArea()
        LoadOutletType()
        LoadProvince()
        LoadSalesman()
        '  LoadMainPrincipal()
        '  LoadSalesman()
        ' NewCustomer.PerformClick()
        btnSave.Enabled = False
        txtCustName.Focus()

    End Sub

    Sub LoadCustomer()
        dgvcustomerlist.Rows.Clear()
        Dim i As Integer
        cmd = New MySqlCommand("SELECT * FROM customers WHERE active <> 'N' order by custname asc", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvcustomerlist.Rows.Add(i, rd.Item("custcode").ToString, rd.Item("custname").ToString, rd.Item("address").ToString, rd.Item("shipto").ToString, _
                                  rd.Item("areacode").ToString, rd.Item("areaname").ToString, rd.Item("outletcode").ToString, rd.Item("outlettype").ToString, rd.Item("provcode").ToString, rd.Item("province").ToString, rd.Item("maincode").ToString, rd.Item("mainp").ToString, _
                                  rd.Item("tinno").ToString, rd.Item("mobileno").ToString, rd.Item("telno").ToString, rd.Item("payterms").ToString, _
                                  Format(CDbl(rd.Item("creditlimit").ToString), "#,##0.00"), Format(CDbl(rd.Item("spdiscount").ToString), "#,##0.00"), _
                                  rd.Item("allowpd").ToString, rd.Item("active").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
    End Sub

    Private Sub dgvcustomerlist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcustomerlist.CellClick
        With gbCustomer
            txtCustCode.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(1).Value.ToString
            txtCustName.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(2).Value.ToString
            txtCustAddress.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(3).Value.ToString
            txtShipTo.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(4).Value.ToString
            cboTerritory.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(5).Value.ToString
            txtArea.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(6).Value.ToString
            cboOutletType.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(7).Value.ToString
            txtOutlet.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(8).Value.ToString
            cboProvince.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(9).Value.ToString
            txtProvince.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(10).Value.ToString
            cboMainPrincipal.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(11).Value.ToString
            txtMainPrincipal.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(12).Value.ToString
            txtTin.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(13).Value.ToString
            txtMobile.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(14).Value.ToString
            txtTelno.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(15).Value.ToString
            nuPayTerms.Value = dgvcustomerlist.Rows(e.RowIndex).Cells(16).Value.ToString
            nuCredit.Value = dgvcustomerlist.Rows(e.RowIndex).Cells(17).Value.ToString
            nuSpecial.Value = dgvcustomerlist.Rows(e.RowIndex).Cells(18).Value.ToString
            cboAllow.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(19).Value.ToString
            cboActive.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(20).Value.ToString
            LoadCustSales()

            btnSave.Enabled = False
            btnUpdate.Enabled = True
        End With
    End Sub

    Private Sub dgvcustomerlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcustomerlist.CellContentClick
        'Dim colName As String = dgvcustomerlist.Columns(e.ColumnIndex).Name
        'If colName = "Edit" Then
        '    With frmCustomerD
        '        .tbCustCode.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(1).Value.ToString
        '        .tbCustName.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(2).Value.ToString
        '        .tbCustAddress.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(3).Value.ToString
        '        .tbShipTo.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(4).Value.ToString
        '        .cbxTerritory.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(5).Value.ToString
        '        .lblArea.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(6).Value.ToString
        '        .cbxOutletType.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(7).Value.ToString
        '        .lblOutlet.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(8).Value.ToString
        '        .cbxProvince.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(9).Value.ToString
        '        .lblProvince.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(10).Value.ToString
        '        .cbxMainPrincipal.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(11).Value.ToString
        '        .lblMain.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(12).Value.ToString
        '        .tbTin.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(13).Value.ToString
        '        .tbMobile.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(14).Value.ToString
        '        .tbTelno.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(15).Value.ToString
        '        .nuPayTerms.Value = dgvcustomerlist.Rows(e.RowIndex).Cells(16).Value.ToString
        '        .nuCredit.Value = dgvcustomerlist.Rows(e.RowIndex).Cells(17).Value.ToString
        '        .nuSpecial.Value = dgvcustomerlist.Rows(e.RowIndex).Cells(18).Value.ToString
        '        .cbxAllow.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(19).Value.ToString
        '        .cbxActive.Text = dgvcustomerlist.Rows(e.RowIndex).Cells(20).Value.ToString
        '        .LoadCustSales()
        '        .tbCustCode.Enabled = False
        '        .SaveCust.Enabled = False
        '        .ClearCust.Enabled = False
        '        .NewCust.Enabled = False
        '        .ShowDialog()
        '    End With

        'ElseIf colName = "Delete" Then
        '    If MsgBox("Delete this Customer? Click Yes to Confirm", vbYesNo + vbQuestion) = vbYes Then
        '        cmd = New MySqlCommand("DELETE from customers where custcode like '" & dgvcustomerlist.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cdb)
        '        cmd.ExecuteNonQuery()

        '        cmd = New MySqlCommand("DELETE from custsales where custcode like '" & dgvcustomerlist.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cdb)
        '        cmd.ExecuteNonQuery()
        '        MsgBox("Customer has been Successfully Deleted!", vbInformation)
        '        LoadCustomer()
        '    End If

        'End If
    End Sub

    Private Sub tbSearchCust_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCustomer.TextChanged
        Dim i As Integer
        dgvcustomerlist.Rows.Clear()
        cmd = New MySqlCommand("SELECT * FROM customers where custcode like '%" & txtSearchCustomer.Text & "%' or custname like '%" & txtSearchCustomer.Text & "%' or address like '%" & txtSearchCustomer.Text & "%' or areaname like '%" & txtSearchCustomer.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvcustomerlist.Rows.Add(i, rd.Item("custcode").ToString, rd.Item("custname").ToString, rd.Item("address").ToString, rd.Item("shipto").ToString, _
                                  rd.Item("areacode").ToString, rd.Item("areaname").ToString, rd.Item("outletcode").ToString, rd.Item("outlettype").ToString, rd.Item("provcode").ToString, rd.Item("province").ToString, rd.Item("maincode").ToString, rd.Item("mainp").ToString, _
                                  rd.Item("tinno").ToString, rd.Item("mobileno").ToString, rd.Item("telno").ToString, rd.Item("payterms").ToString, _
                                  Format(CDbl(rd.Item("creditlimit").ToString), "#,##0.00"), Format(CDbl(rd.Item("spdiscount").ToString), "#,##0.00"), _
                                  rd.Item("allowpd").ToString, rd.Item("active").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
    End Sub



    Private Sub sRemovetoListCustomerD()
        For Each row As DataGridViewRow In dgvCustomerSalesman.SelectedRows
            dgvCustomerSalesman.Rows.Remove(row)
        Next
    End Sub

    Sub LoadArea()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand

        cboTerritory.Items.Clear()
        cboTerritory.DisplayMember = "text"
        qry = "Select * from area ORDER BY areaname"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            cboTerritory.Items.Add(New With {.Text = relr("areacode").ToString(), .Value = relr("areaname").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub

    Sub LoadOutletType()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand

        cboOutletType.Items.Clear()
        cboOutletType.DisplayMember = "text"
        qry = "Select * from outlet ORDER BY outletname"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            cboOutletType.Items.Add(New With {.Text = relr("outletcode").ToString(), .Value = relr("outletname").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub

    Sub LoadProvince()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand

        cboProvince.Items.Clear()
        cboProvince.DisplayMember = "text"
        qry = "Select * from province ORDER BY provincename"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            cboProvince.Items.Add(New With {.Text = relr("provcode").ToString(), .Value = relr("provincename").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub

    Private Sub cbxTerritory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTerritory.SelectedIndexChanged
        cmd = New MySqlCommand("SELECT * from area where areacode like '%" & cboTerritory.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            With rd
                txtArea.Text = rd.Item("areaname").ToString
            End With
        End If
        rd.Close()
    End Sub

    Private Sub cbxOutletType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOutletType.SelectedIndexChanged
        cmd = New MySqlCommand("SELECT * from outlet where outletcode like '%" & cboOutletType.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            With rd
                txtOutlet.Text = rd.Item("outletname").ToString
            End With
        End If
        rd.Close()
    End Sub

    Private Sub cbxProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvince.SelectedIndexChanged
        cmd = New MySqlCommand("SELECT * from province where provcode like '%" & cboProvince.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            With rd
                txtProvince.Text = rd.Item("provincename").ToString
            End With
        End If
        rd.Close()
    End Sub

    Function CheckCustName()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT custname FROM customers WHERE custname = @cname", cdb)
        With cmd
            .Parameters.AddWithValue("@cname", txtCustName.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Sub GetCustCode()
        Dim mdr As MySqlDataReader
        Dim ep As MySqlCommand
        Dim rcnt As Integer = 0
        Dim yn As Integer = 0
        Dim empn As String = Nothing
        Dim cnts As String = Nothing
        Dim cqry As String = Nothing

        yn = Year(gettime2(3))
        cqry = "Select custcode as pno FROM customers ORDER BY pkno DESC LIMIT 1"
        ep = New MySqlCommand(cqry, cdb)
        ep.ExecuteNonQuery()
        mdr = ep.ExecuteReader()
        If mdr.HasRows = True Then
            While mdr.Read()
                rcnt += 1
            End While

            empn = mdr("pno") + 1

            If Strings.Left(empn, 4) <> yn Then
                cnts = "0001"
                empn = yn & cnts
            End If
            mdr.Close()
        Else
            mdr.Close()
            mdr.Dispose()
        End If


        If rcnt = 0 Then
            cnts = "0001"
            empn = yn & cnts
        End If
        mdr.Close()
        mdr.Dispose()
        ep.Dispose()

        txtCustCode.Text = empn

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'trap duplicate
        If CheckCustName() = True Then
            MsgBox("Customer Name Already Exist!", vbCritical, "Enter Customer Name")
            Exit Sub
        End If

        If txtCustName.Text = Nothing Then
            MsgBox("Pls Enter Customer Name!", vbCritical)
            Exit Sub
        End If

        If dgvListSalesman.ColumnCount = 0 Then
            MsgBox("Pls Enter Salesman!", vbExclamation)
            Exit Sub
        End If

        Dim pricetype As String = Nothing
        For i As Integer = 0 To dgvCustomerSalesman.RowCount - 1
            With dgvCustomerSalesman
                pricetype = dgvCustomerSalesman.Rows(i).Cells(7).Value
                If pricetype = Nothing Then
                    MsgBox("Select Price Type!", vbCritical)
                    Exit Sub
                End If
            End With
        Next

        If MsgBox("Save this Customer?", vbYesNo + vbQuestion) = vbYes Then
            'save to customers
            GetCustCode()
            SaveCustomer()

            MsgBox("New Customer Has Been Save Sucessfully!", vbInformation)
            AuditTrail("Customer Code:" & txtCustCode.Text & Space(2) & "Customer Name:" & txtCustName.Text, "Customer Entry")
            LoadCustomer()
            btnAdd_Click(sender, e)
        End If

    End Sub

    Sub SaveCustomer()
        'save to customer
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("INSERT INTO customers (custcode,custname,address,shipto,areacode,areaname,outletcode,outlettype,provcode,province,maincode,mainp, " & _
                               "tinno,mobileno,telno,payterms,creditlimit,spdiscount,allowpd,active) " & _
                               " VALUES (@custcode,@custname,@address,@shipto,@acode,@aname,@ocode,@outlet,@pvcode,@prov,@mcode,@mainp,@tinno, " & _
                               "@mobile,@telno,@terms,@climit,@spd,@allow,@active)", cdb)
        With cmd
            cmd.Parameters.AddWithValue("@custcode", txtCustCode.Text)
            cmd.Parameters.AddWithValue("@custname", txtCustName.Text)
            cmd.Parameters.AddWithValue("@address", txtCustAddress.Text)
            cmd.Parameters.AddWithValue("@shipto", txtShipTo.Text)
            cmd.Parameters.AddWithValue("@acode", cboTerritory.Text)
            cmd.Parameters.AddWithValue("@aname", txtArea.Text)
            cmd.Parameters.AddWithValue("@ocode", cboOutletType.Text)
            cmd.Parameters.AddWithValue("@outlet", txtOutlet.Text)
            cmd.Parameters.AddWithValue("@pvcode", cboProvince.Text)
            cmd.Parameters.AddWithValue("@prov", txtProvince.Text)
            cmd.Parameters.AddWithValue("@mcode", cboMainPrincipal.Text)
            cmd.Parameters.AddWithValue("@mainp", txtMainPrincipal.Text)
            cmd.Parameters.AddWithValue("@tinno", txtTin.Text)
            cmd.Parameters.AddWithValue("@mobile", txtMobile.Text)
            cmd.Parameters.AddWithValue("@telno", txtTelno.Text)
            cmd.Parameters.AddWithValue("@terms", nuPayTerms.Text)
            cmd.Parameters.AddWithValue("@climit", CDbl(nuCredit.Text))
            cmd.Parameters.AddWithValue("@spd", CDbl(nuSpecial.Text))
            cmd.Parameters.AddWithValue("@allow", cboAllow.Text)
            cmd.Parameters.AddWithValue("@active", cboActive.Text)
            'cmd.Parameters.AddWithValue("@custno", tbCustNo.Text)
            cmd.ExecuteNonQuery()
        End With
        Dim pricetype As String = Nothing
        'save to custsales
        For i As Integer = 0 To dgvCustomerSalesman.RowCount - 1
            cmd = New MySqlCommand("INSERT INTO custsales (custcode,slmncode,slmnname,whscode,warehouse,opercode,typeofoper,pricetype) VALUES " & _
                                   "(@ccode,@smcode,@sname,@whcode,@whname,@opercode,@typeoper,@pt)", cdb)
            With cmd
                With dgvCustomerSalesman
                    cmd.Parameters.AddWithValue("@ccode", txtCustCode.Text)
                    cmd.Parameters.AddWithValue("@smcode", dgvCustomerSalesman.Rows(i).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@sname", dgvCustomerSalesman.Rows(i).Cells(2).Value)
                    cmd.Parameters.AddWithValue("@whcode", dgvCustomerSalesman.Rows(i).Cells(3).Value)
                    cmd.Parameters.AddWithValue("@whname", dgvCustomerSalesman.Rows(i).Cells(4).Value)
                    cmd.Parameters.AddWithValue("@opercode", dgvCustomerSalesman.Rows(i).Cells(5).Value)
                    cmd.Parameters.AddWithValue("@typeoper", dgvCustomerSalesman.Rows(i).Cells(6).Value)
                    pricetype = dgvCustomerSalesman.Rows(i).Cells(7).Value

                    cmd.Parameters.AddWithValue("@pt", pricetype)
                    cmd.ExecuteNonQuery()
                End With
            End With
        Next
    End Sub


    Sub ClearCustomer()
        txtCustCode.Clear()
        txtCustName.Clear()
        txtCustAddress.Clear()
        txtShipTo.Clear()
        cboTerritory.SelectedIndex = -1
        txtArea.Text = ""
        cboOutletType.SelectedIndex = -1
        txtOutlet.Text = ""
        cboProvince.SelectedIndex = -1
        txtProvince.Text = ""
        cboMainPrincipal.SelectedIndex = -1
        txtMainPrincipal.Text = ""
        txtTin.Clear()
        txtMobile.Clear()
        txtTelno.Clear()
        nuPayTerms.Value = "0"
        nuCredit.Value = "0"
        nuSpecial.Value = "0"
        cboAllow.SelectedIndex = 1
        cboActive.SelectedIndex = 0
        dgvCustomerSalesman.Rows.Clear()
        txtCustName.Focus()
    End Sub

    Sub LoadCustSales()
        dgvCustomerSalesman.Rows.Clear()
        Dim i As Integer
        cmd = New MySqlCommand("select * from custsales where custcode = '" & txtCustCode.Text & "'", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvCustomerSalesman.Rows.Add(i, rd.Item("slmncode").ToString, rd.Item("slmnname").ToString, _
                                         rd.Item("whscode").ToString, rd.Item("warehouse").ToString, _
                                         rd.Item("opercode").ToString, rd.Item("typeofoper").ToString, _
                                         rd.Item("pricetype").ToString, rd.Item("pkno").ToString)
        End While
        rd.Close()
    End Sub

    Private Sub dgvcustomerlist_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvcustomerlist.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.PageDown Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.PageUp Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dgvcustomerlist_CellClick(1, New DataGridViewCellEventArgs(0, dgvcustomerlist.CurrentRow.Index))
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        gbSalesman.Visible = False
        gbSalesman.SendToBack()
    End Sub

    Sub LoadSalesman()
        Dim i As Integer = 0
        dgvListSalesman.Rows.Clear()
        cmd = New MySqlCommand("SELECT * FROM salesman", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvListSalesman.Rows.Add(i, rd.Item("slmncode").ToString, rd.Item("slmnname").ToString, _
                                     rd.Item("whscode").ToString, rd.Item("whsname").ToString, _
                                     rd.Item("opercode").ToString, rd.Item("typeofoper").ToString) ', rd.Item("pkno").ToString, "Edit", "Delete")
            'dgvListSalesman.Rows(i - 1).Cells(0).Value = False
        End While
        rd.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ClearCustomer()
        btnUpdate.Enabled = False
        btnSave.Enabled = True
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadCustomer()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        With dgvcustomerlist
            If .RowCount > 0 Then
                Dim pkno As String = Nothing
                Dim cCode As String = Nothing
                Dim cName As String = Nothing

                pkno = .Item(21, .CurrentRow.Index).Value
                cCode = .Item(1, .CurrentRow.Index).Value
                cName = .Item(2, .CurrentRow.Index).Value


                If checkCustomerIfExistingALL(cCode) Then
                    'MsgBox("naa")
                    MsgBox("This customer has already transaction. Cannot be deleted.", vbInformation)
                Else
                    'MsgBox("wala")
                    If MsgBox("Delete this Customer : " & cName & "?", vbYesNo + vbQuestion, "Continue?") = vbYes Then
                        cmd = New MySqlCommand("DELETE from customers where custcode like '" & cCode & "'", cdb)
                        cmd.ExecuteNonQuery()

                        cmd = New MySqlCommand("DELETE from custsales where custcode like '" & cCode & "'", cdb)
                        cmd.ExecuteNonQuery()
                        MsgBox("Customer has been Successfully Deleted!", vbInformation)
                        LoadCustomer()
                        btnAdd_Click(sender, e)
                    End If
                End If

            End If
        End With

    End Sub

    Private Sub dgvListSalesman_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListSalesman.CellContentClick

        If e.ColumnIndex = 0 Then
            With dgvListSalesman
                If .Rows(.CurrentRow.Index).Cells(0).Value = True Then
                    .Rows(.CurrentRow.Index).Cells(0).Value = False
                    For i = 0 To dgvCustomerSalesman.RowCount - 1
                        If .CurrentRow.Cells(1).Value = dgvCustomerSalesman.Rows(i).Cells(1).Value Then
                            dgvCustomerSalesman.Rows.Remove(dgvCustomerSalesman.Rows(i))
                            For j = 0 To dgvCustomerSalesman.RowCount - 1
                                dgvCustomerSalesman.Rows(j).Cells(0).Value = j + 1
                            Next
                            Exit For
                        End If
                    Next
                Else
                    AddtoList()
                End If
                If e.ColumnIndex = 1 Then
                    sRemovetoList()
                End If
            End With

        End If
    End Sub

    Private Sub AddtoList()

        Dim r As Integer

        'For i As Integer = 0 To dgvListSalesman.RowCount - 1
        '    If frmCustomerD.dgvSalesman.Rows(i).Cells(1).Value = dgvListSalesman.CurrentRow.Cells(1).Value Then
        '        MsgBox("Salesman Already Exist!", vbCritical)
        '        With frmCustomerD
        '            frmCustomerD.dgvSalesman.Rows(i).Cells(1).Value.sRemovetoListCustomerD()
        '        End With
        '    ElseIf frmCustomerD.dgvSalesman.Rows(i).Cells(1).Value <> dgvListSalesman.CurrentRow.Cells(1).Value Then

        dgvListSalesman.Rows(dgvListSalesman.CurrentRow.Index).Cells(0).Value = True
        dgvCustomerSalesman.Rows.Add()
        r = dgvCustomerSalesman.RowCount - 1
        dgvCustomerSalesman.Rows(r).Cells(0).Value = r + 1
        dgvCustomerSalesman.Rows(r).Cells(1).Value = dgvListSalesman.CurrentRow.Cells(1).Value
        dgvCustomerSalesman.Rows(r).Cells(2).Value = dgvListSalesman.CurrentRow.Cells(2).Value
        dgvCustomerSalesman.Rows(r).Cells(3).Value = dgvListSalesman.CurrentRow.Cells(3).Value
        dgvCustomerSalesman.Rows(r).Cells(4).Value = dgvListSalesman.CurrentRow.Cells(4).Value
        dgvCustomerSalesman.Rows(r).Cells(5).Value = dgvListSalesman.CurrentRow.Cells(5).Value
        dgvCustomerSalesman.Rows(r).Cells(6).Value = dgvListSalesman.CurrentRow.Cells(6).Value
        '   End If
        '  Next
    End Sub

    Private Sub sRemovetoList()
        For Each row As DataGridViewRow In dgvListSalesman.SelectedRows
            dgvListSalesman.Rows.Remove(row)
        Next
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtCustCode.Text = Nothing Then
            MsgBox("Select Record to Update!", vbExclamation)
            Exit Sub
        Else
            If MsgBox("Update this Customer?", vbYesNo + vbQuestion) = vbYes Then
                Dim bolDuplicateWasFound As Boolean = False

                'For x As Integer = 0 To dgvSalesman.Rows.Count - 1
                '    For y As Integer = 0 To dgvSalesman.Rows.Count - 1
                '        If y <> x AndAlso dgvSalesman.Rows(x).Cells(0).Value.ToString = dgvSalesman.Rows(y).Cells(0).Value.ToString Then
                '            bolDuplicateWasFound = True
                '            MsgBox("Duplicate Salesman!", vbCritical)
                '            Exit Sub
                '        End If
                '    Next
                'Next

                Dim pricetype As String = Nothing
                For i As Integer = 0 To dgvCustomerSalesman.RowCount - 1
                    With dgvCustomerSalesman
                        pricetype = dgvCustomerSalesman.Rows(i).Cells(7).Value
                        If pricetype = Nothing Then
                            MsgBox("Select Price Type!", vbCritical)
                            Exit Sub
                        End If
                    End With
                Next

                If Not bolDuplicateWasFound Then
                    txtCustName.Focus()
                    UpdateCustomer()
                    MsgBox("Customer Has Been Updated Sucessfully!", vbInformation)
                    LoadCustomer()
                End If
                btnAdd_Click(sender, e)
            End If
        End If

    End Sub

    Sub UpdateCustomer()
        'update to customer

        cmd = New MySqlCommand("UPDATE customers SET  custcode=@custcode, custname=@custname, address=@address, shipto=@shipto, " & _
                               "areacode=@acode, areaname=@aname, outletcode=@ocode, outlettype=@outlet, " & _
                               "provcode=@pcode, province=@prov, maincode=@mcode, mainp=@mainp, tinno=@tinno, mobileno=@mobile, telno=@telno, " & _
                               "payterms=@terms, creditlimit=@climit, spdiscount=@spd, allowpd=@allow, active=@active where custcode=@custcode", cdb)
        With cmd
            cmd.Parameters.AddWithValue("@custcode", txtCustCode.Text)
            cmd.Parameters.AddWithValue("@custname", txtCustName.Text)
            cmd.Parameters.AddWithValue("@address", txtCustAddress.Text)
            cmd.Parameters.AddWithValue("@shipto", txtShipTo.Text)
            cmd.Parameters.AddWithValue("@acode", cboTerritory.Text)
            cmd.Parameters.AddWithValue("@aname", txtArea.Text)
            cmd.Parameters.AddWithValue("@ocode", cboOutletType.Text)
            cmd.Parameters.AddWithValue("@outlet", txtOutlet.Text)
            cmd.Parameters.AddWithValue("@pcode", cboProvince.Text)
            cmd.Parameters.AddWithValue("@prov", txtProvince.Text)
            cmd.Parameters.AddWithValue("@mcode", cboMainPrincipal.Text)
            cmd.Parameters.AddWithValue("@mainp", txtMainPrincipal.Text)
            cmd.Parameters.AddWithValue("@tinno", txtTin.Text)
            cmd.Parameters.AddWithValue("@mobile", txtMobile.Text)
            cmd.Parameters.AddWithValue("@telno", txtTelno.Text)
            cmd.Parameters.AddWithValue("@terms", nuPayTerms.Text)
            cmd.Parameters.AddWithValue("@climit", nuCredit.Text)
            cmd.Parameters.AddWithValue("@spd", nuSpecial.Text)
            cmd.Parameters.AddWithValue("@allow", cboAllow.Text)
            cmd.Parameters.AddWithValue("@active", cboActive.Text)

            cmd.ExecuteNonQuery()
        End With

        'update to custsales
        'For i As Integer = 0 To dgvSalesman.RowCount - 1
        '    cmd = New MySqlCommand("UPDATE custsales SET custcode=@ccode, slmcode=@smcode, salesman=@sname, whscode=@whcode, warehouse=@whname, opercode=@opercode, typeofoper=@typeoper, pricetype=@pt WHERE custcode=@ccode and pkno=@pkno", cdb)
        '    With cmd
        '        With dgvSalesman
        '            cmd.Parameters.AddWithValue("@ccode", tbCustCode.Text)
        '            cmd.Parameters.AddWithValue("@smcode", dgvSalesman.Rows(i).Cells(1).Value)
        '            cmd.Parameters.AddWithValue("@sname", dgvSalesman.Rows(i).Cells(2).Value)
        '            cmd.Parameters.AddWithValue("@whcode", dgvSalesman.Rows(i).Cells(3).Value)
        '            cmd.Parameters.AddWithValue("@whname", dgvSalesman.Rows(i).Cells(4).Value)
        '            cmd.Parameters.AddWithValue("@opercode", dgvSalesman.Rows(i).Cells(5).Value)
        '            cmd.Parameters.AddWithValue("@typeoper", dgvSalesman.Rows(i).Cells(6).Value)
        '            cmd.Parameters.AddWithValue("@pt", dgvSalesman.Rows(i).Cells(7).Value)
        '            cmd.Parameters.AddWithValue("@pkno", dgvSalesman.Rows(i).Cells(8).Value)
        '            cmd.ExecuteNonQuery()
        '        End With
        '    End With
        'Next

        Dim pricetype As String = Nothing
        Dim cmd2 As MySqlCommand
        cmd2 = New MySqlCommand("Delete From custsales where custcode = @c_no", cdb)
        cmd2.Parameters.AddWithValue("@c_no", txtCustCode.Text)
        cmd2.ExecuteNonQuery()

        For i As Integer = 0 To dgvCustomerSalesman.RowCount - 1
            cmd = New MySqlCommand("INSERT INTO custsales (custcode,slmncode,slmnname,whscode,warehouse,opercode,typeofoper,pricetype) VALUES " & _
                                   "(@ccode,@smcode,@sname,@whcode,@whname,@opercode,@typeoper,@pt)", cdb)
            With cmd
                With dgvCustomerSalesman
                    cmd.Parameters.AddWithValue("@ccode", txtCustCode.Text)
                    cmd.Parameters.AddWithValue("@smcode", dgvCustomerSalesman.Rows(i).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@sname", dgvCustomerSalesman.Rows(i).Cells(2).Value)
                    cmd.Parameters.AddWithValue("@whcode", dgvCustomerSalesman.Rows(i).Cells(3).Value)
                    cmd.Parameters.AddWithValue("@whname", dgvCustomerSalesman.Rows(i).Cells(4).Value)
                    cmd.Parameters.AddWithValue("@opercode", dgvCustomerSalesman.Rows(i).Cells(5).Value)
                    cmd.Parameters.AddWithValue("@typeoper", dgvCustomerSalesman.Rows(i).Cells(6).Value)
                    pricetype = dgvCustomerSalesman.Rows(i).Cells(7).Value
                    cmd.Parameters.AddWithValue("@pt", pricetype)
                    cmd.ExecuteNonQuery()
                End With
            End With
        Next
        'Me.Dispose()
    End Sub

    Private Sub btnAddSalesman_Click(sender As Object, e As EventArgs) Handles btnAddSalesman.Click
        If txtCustName.Text = Nothing Then
            MsgBox("Enter Customer Name First!", vbCritical)
        Else
            gbSalesman.Visible = True
            gbSalesman.BringToFront()
        End If
        ' frmSalesmanList.ShowDialog()
    End Sub

    Private Sub btnDeleSalesman_Click(sender As Object, e As EventArgs) Handles btnDeleSalesman.Click

        If dgvCustomerSalesman.Rows.Count = 0 Then
            MsgBox("Select Salesman to Remove!", vbCritical)
        Else
            If MsgBox("Remove this Salesman?", vbYesNo + vbExclamation) = vbYes Then
                Try
                    For Each row As DataGridViewRow In dgvCustomerSalesman.SelectedRows
                        dgvCustomerSalesman.Rows.Remove(row)
                    Next
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub dgvSalesman_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomerSalesman.CellContentClick

    End Sub

    Dim selrow As Integer = 0
    Delegate Sub SetColumnIndex(ByVal i As Integer)
    Private Sub Mymethod(ByVal columnIndex As Integer)
        If Me.dgvCustomerSalesman.CurrentRow.Index >= 0 Then
            If Me.dgvCustomerSalesman.CurrentRow.Index > 0 Then
                Me.dgvCustomerSalesman.CurrentCell = Me.dgvCustomerSalesman.Item(columnIndex, selrow)    '.Cells(columnIndex)
                Me.dgvCustomerSalesman.BeginEdit(True)
            Else
                Me.dgvCustomerSalesman.CurrentCell = Me.dgvCustomerSalesman.Item(columnIndex, 0)   '.Cells(columnIndex)
                Me.dgvCustomerSalesman.BeginEdit(True)
            End If
        End If
    End Sub

    Private Sub dgvSalesman_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomerSalesman.CellEndEdit
        'Dim selrow As Integer
        'Dim mrw As Integer = 0

        'With dgvCustomerSalesman
        '    selrow = mrw
        '    Dim method As New SetColumnIndex(AddressOf Mymethod)
        '    Dim nextindex As Integer = 7
        '    Me.dgvCustomerSalesman.BeginInvoke(method, nextindex)
        '    ' .BeginEdit()
        'End With

        Dim srow As String = e.ColumnIndex

        If e.ColumnIndex = 7 Then


        End If

    End Sub
End Class