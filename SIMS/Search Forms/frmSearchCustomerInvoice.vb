Imports MySql.Data.MySqlClient

Public Class frmSearchCustomerInvoice

    Private Sub frmSearchCustomerInvoice_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub frmSearchCustomerInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomerList()
    End Sub

    Sub LoadCustomerList()
        dgvCustomerList.Rows.Clear()
        Dim i As Integer
        cmd = New MySqlCommand("SELECT * FROM customers WHERE active <> 'N' order by custname asc", cdb)
        'cmd = New MySqlCommand("SELECT c.*,s.* FROM customers c JOIN custsales s ON c.custcode=s.custcode WHERE c.custcode like '" & frmSalesInvoiceD.txtCustCode.Text & "'", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvCustomerList.Rows.Add(i, rd.Item("custcode").ToString, rd.Item("custname").ToString, rd.Item("address").ToString, rd.Item("shipto").ToString, _
                                  rd.Item("areacode").ToString, rd.Item("areaname").ToString, rd.Item("outletcode").ToString, rd.Item("outlettype").ToString, rd.Item("provcode").ToString, rd.Item("province").ToString, rd.Item("maincode").ToString, rd.Item("mainp").ToString, _
                                  rd.Item("tinno").ToString, rd.Item("mobileno").ToString, rd.Item("telno").ToString, rd.Item("payterms").ToString, _
                                  Format(CDbl(rd.Item("creditlimit").ToString), "#,##0.00"), Format(CDbl(rd.Item("spdiscount").ToString), "#,##0.00"), _
                                  rd.Item("allowpd").ToString, rd.Item("active").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
        'dgvCustomerList.CurrentCell = dgvCustomerList.Rows(1).Cells(1)
        'dgvCustomerList.Focus()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If Me.Text = "SALES INVOICE" Then
            frmSalesInvoiceD.txtCustCode.Text = dgvCustomerList.CurrentRow.Cells(1).Value
            frmSalesInvoiceD.txtCustomername.Text = dgvCustomerList.CurrentRow.Cells(2).Value
            frmSalesInvoiceD.txtAddress.Text = dgvCustomerList.CurrentRow.Cells(3).Value
            frmSalesInvoiceD.txtSalesmanCode.Focus()
            SendKeys.Send("{enter}")
        ElseIf Me.Text = "SALES RETURN" Then
            frmSalesReturnD.txtCustCode.Text = dgvCustomerList.CurrentRow.Cells(1).Value
            frmSalesReturnD.txtCustomername.Text = dgvCustomerList.CurrentRow.Cells(2).Value
            frmSalesReturnD.txtAddress.Text = dgvCustomerList.CurrentRow.Cells(3).Value
            frmSalesReturnD.txtSalesmanCode.Focus()
            SendKeys.Send("{enter}")
        ElseIf Me.Text = "BO RETURN" Then
            frmSalesBOReturnD.txtCustCode.Text = dgvCustomerList.CurrentRow.Cells(1).Value
            frmSalesBOReturnD.txtCustomername.Text = dgvCustomerList.CurrentRow.Cells(2).Value
            frmSalesBOReturnD.txtAddress.Text = dgvCustomerList.CurrentRow.Cells(3).Value
            frmSalesBOReturnD.txtSalesmanCode.Focus()
            SendKeys.Send("{enter}")
        ElseIf Me.Text = "CREDIT MEMO" Then
            frmMemoCredit.txtCustCode.Text = dgvCustomerList.CurrentRow.Cells(1).Value
            frmMemoCredit.txtCustomerName.Text = dgvCustomerList.CurrentRow.Cells(2).Value
            frmMemoCredit.txtSalesmanCode.Focus()
            SendKeys.Send("{enter}")
        ElseIf Me.Text = "CUSTOMER A/R BALANCE" Then
            frmCustomerARBalance.txtCustCode.Text = dgvCustomerList.CurrentRow.Cells(1).Value
            frmCustomerARBalance.txtCustomername.Text = dgvCustomerList.CurrentRow.Cells(2).Value
            frmCustomerARBalance.txtCustCode.Focus()
            'SendKeys.Send("{enter}")
        ElseIf Me.Text = "ENTER BOOKING A/R COLLECTION" Then
            frmBookingARCollD.txtCustCode.Text = dgvCustomerList.CurrentRow.Cells(1).Value
            frmBookingARCollD.txtCustomername.Text = dgvCustomerList.CurrentRow.Cells(2).Value
            frmBookingARCollD.txtCustCode.Focus()
            SendKeys.Send("{enter}")
        ElseIf Me.Text = "LIST OF SALES INVOICES" Then
            frmListSalesInvoices.txtCustCode.Text = dgvCustomerList.CurrentRow.Cells(1).Value
            frmListSalesInvoices.txtCustomername.Text = dgvCustomerList.CurrentRow.Cells(2).Value
            frmListSalesInvoices.txtCustCode.Focus()
        ElseIf Me.Text = "LIST OF SALES RETURN" Then
            frmListSalesReturn.txtCustCode.Text = dgvCustomerList.CurrentRow.Cells(1).Value
            frmListSalesReturn.txtCustomername.Text = dgvCustomerList.CurrentRow.Cells(2).Value
            frmListSalesReturn.txtCustCode.Focus()
        ElseIf Me.Text = "CUSTOMER A/R BALANCE" Then
            frmCustomerARBalance.txtCustCode.Text = dgvCustomerList.CurrentRow.Cells(1).Value
            frmCustomerARBalance.txtCustomername.Text = dgvCustomerList.CurrentRow.Cells(2).Value
            frmCustomerARBalance.txtCustCode.Focus()
        ElseIf Me.Text = "CASH RECEIVE FROM COLLECTION" Then
            frmListofCashReceive.txtCustcode.Text = dgvCustomerList.CurrentRow.Cells(1).Value
            frmListofCashReceive.txtCustomername.Text = dgvCustomerList.CurrentRow.Cells(2).Value
            frmListofCashReceive.txtCustcode.Focus()
            SendKeys.Send("{enter}")
        ElseIf Me.Text = "CHECK RECEIVE FROM COLLECTION" Then
            frmlistofCheckReceive.txtCustcode.Text = dgvCustomerList.CurrentRow.Cells(1).Value
            frmlistofCheckReceive.txtCustomername.Text = dgvCustomerList.CurrentRow.Cells(2).Value
            frmlistofCheckReceive.txtCustcode.Focus()
            SendKeys.Send("{enter}")
            'ElseIf Me.Text = "CUSTOMER AR (with Item Detailed)" Then
            '    frmCustomerAR_ItemDetailed.txtCustCode.Text = dgvCustomerList.CurrentRow.Cells(1).Value
            '    frmCustomerAR_ItemDetailed.txtCustomername.Text = dgvCustomerList.CurrentRow.Cells(2).Value
            '    frmCustomerAR_ItemDetailed.txtCustCode.Focus()
            '    SendKeys.Send("{enter}")
        End If
        Me.Close()
    End Sub

    Private Sub dgvCustomerList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomerList.CellContentClick

    End Sub

    Private Sub dgvCustomerList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomerList.CellDoubleClick
        btnSelect_Click(sender, e)
    End Sub

    Private Sub txtSearchCustomer_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCustomer.TextChanged
        Dim i As Integer
        dgvCustomerList.Rows.Clear()
        cmd = New MySqlCommand("SELECT * FROM customers where custcode like '%" & txtSearchCustomer.Text & "%' or custname like '%" & txtSearchCustomer.Text & "%' or address like '%" & txtSearchCustomer.Text & "%' or areaname like '%" & txtSearchCustomer.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvCustomerList.Rows.Add(i, rd.Item("custcode").ToString, rd.Item("custname").ToString, rd.Item("address").ToString, rd.Item("shipto").ToString, _
                                  rd.Item("areacode").ToString, rd.Item("areaname").ToString, rd.Item("outletcode").ToString, rd.Item("outlettype").ToString, _
                                  rd.Item("provcode").ToString, rd.Item("province").ToString, rd.Item("maincode").ToString, rd.Item("mainp").ToString, _
                                  rd.Item("tinno").ToString, rd.Item("mobileno").ToString, rd.Item("telno").ToString, rd.Item("payterms").ToString, _
                                  Format(CDbl(rd.Item("creditlimit").ToString), "#,##0.00"), Format(CDbl(rd.Item("spdiscount").ToString), "#,##0.00"), _
                                  rd.Item("allowpd").ToString, rd.Item("active").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
        'dgvCustomerList.CurrentCell = dgvCustomerList.Rows(1).Cells(1)
        'dgvCustomerList.Focus()
    End Sub

    Private Sub dgvCustomerList_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvCustomerList.KeyDown
        If (e.KeyCode >= Keys.A And e.KeyCode <= Keys.Z) Or e.KeyCode = Keys.Space Or (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) Or (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) Then
            txtSearchCustomer.Text = txtSearchCustomer.Text & Chr(e.KeyCode)
        ElseIf e.KeyCode = Keys.Back Then
            txtSearchCustomer.Text = Strings.Left(txtSearchCustomer.Text, Strings.Len(txtSearchCustomer.Text) - 1)
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnSelect_Click(1, New System.EventArgs())
        End If
    End Sub
End Class