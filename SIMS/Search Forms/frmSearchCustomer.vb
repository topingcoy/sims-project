Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class frmSearchCustomer
    Public selectedValue As String = String.Empty
    Public selectedName As String = String.Empty
    Private Sub frmSearchCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()

        End If
    End Sub

    Private Sub frmSearchCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomerList()
    End Sub
    Sub searchAndChecked(ByVal searchValue As String)
        For x As Integer = 0 To dgvCustomerList.RowCount - 1
            If searchValue = dgvCustomerList.Rows(x).Cells(2).Value() Then
                dgvCustomerList.Rows(x).Cells(1).Value = True
            End If
        Next
    End Sub
    Sub uncheckedAll()
        For x As Integer = 0 To dgvCustomerList.RowCount - 1

            dgvCustomerList.Rows(x).Cells(1).Value = False

        Next
    End Sub
    Sub LoadCustomerList()
        dgvCustomerList.Rows.Clear()
        Dim i As Integer
        cmd = New MySqlCommand("SELECT * FROM customers WHERE active <> 'N' order by custname asc", cdb)
        'cmd = New MySqlCommand("SELECT c.*,s.* FROM customers c JOIN custsales s ON c.custcode=s.custcode WHERE c.custcode like '" & frmSalesInvoiceD.txtCustCode.Text & "'", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvCustomerList.Rows.Add(i, False, rd.Item("custcode").ToString, rd.Item("custname").ToString, rd.Item("address").ToString, rd.Item("shipto").ToString, _
                                  rd.Item("areacode").ToString, rd.Item("areaname").ToString, rd.Item("outletcode").ToString, rd.Item("outlettype").ToString, rd.Item("provcode").ToString, rd.Item("province").ToString, rd.Item("maincode").ToString, rd.Item("mainp").ToString, _
                                  rd.Item("tinno").ToString, rd.Item("mobileno").ToString, rd.Item("telno").ToString, rd.Item("payterms").ToString, _
                                  Format(CDbl(rd.Item("creditlimit").ToString), "#,##0.00"), Format(CDbl(rd.Item("spdiscount").ToString), "#,##0.00"), _
                                  rd.Item("allowpd").ToString, rd.Item("active").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
        'dgvCustomerList.CurrentCell = dgvCustomerList.Rows(1).Cells(1)
        'dgvCustomerList.Focus()
    End Sub

    Private Sub dgvcustomerlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        'With frmSalesInvoiceD
        '    .txtCustCode.Text = dgvCustomerList.Rows(e.RowIndex).Cells(1).Value.ToString
        '    .txtCustomername.Text = dgvCustomerList.Rows(e.RowIndex).Cells(2).Value.ToString
        '    .txtAddress.Text = dgvCustomerList.Rows(e.RowIndex).Cells(3).Value.ToString
        'End With
        'Me.Dispose()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs)

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
        ElseIf Me.Text = "CUSTOMER LIST" Then '"LIST OF SALES INVOICES" Then
            'frmListSalesInvoices.txtCustCode.Text = dgvCustomerList.CurrentRow.Cells(1).Value
            'frmListSalesInvoices.txtCustomername.Text = dgvCustomerList.CurrentRow.Cells(2).Value
            'frmListSalesInvoices.txtCustCode.Focus()

            txtSearchCustomer.Focus()
            Dim selectedValue As String = String.Empty
            Dim selectedName As String = String.Empty
            For Each row As DataGridViewRow In dgvCustomerList.Rows
                Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("dgCheckbox").Value)
                If isSelected Then

                    selectedValue &= "'" & row.Cells("dgCode").Value.ToString() & "'"
                    selectedValue &= ", "

                    selectedName &= "" & row.Cells("dgCustomerName").Value.ToString() & ""
                    selectedName &= ", "
                End If


            Next

            With frmListSalesInvoices
                .txtCustCode.Text = selectedValue.Substring(0, selectedValue.Length - 2)
                .txtCustomername.Text = selectedName.Substring(0, selectedName.Length - 2)
                .chkCustomer.Checked = False
                .chkSortCustomer.Enabled = True
            End With
            Me.Close()
        ElseIf Me.Text = "CUSTOMER LIST (Detailed Sales Invoice)" Then '"LIST OF SALES INVOICES" Then
            'frmListSalesInvoices.txtCustCode.Text = dgvCustomerList.CurrentRow.Cells(1).Value
            'frmListSalesInvoices.txtCustomername.Text = dgvCustomerList.CurrentRow.Cells(2).Value
            'frmListSalesInvoices.txtCustCode.Focus()

            txtSearchCustomer.Focus()
            Dim selectedValue As String = String.Empty
            Dim selectedName As String = String.Empty
            For Each row As DataGridViewRow In dgvCustomerList.Rows
                Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("dgCheckbox").Value)
                If isSelected Then

                    selectedValue &= "'" & row.Cells("dgCode").Value.ToString() & "'"
                    selectedValue &= ", "

                    selectedName &= "" & row.Cells("dgCustomerName").Value.ToString() & ""
                    selectedName &= ", "
                End If


            Next

            With frmListofSalesInvoicesDetailed 'Detailed_Sales_Invoice
                .txtCustCode.Text = selectedValue.Substring(0, selectedValue.Length - 2)
                .txtCustomername.Text = selectedName.Substring(0, selectedName.Length - 2)
                .chkCustomer.Checked = False
                .chkSortCustomer.Enabled = True
            End With
            Me.Close()
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
        End If
        Me.Close()

    End Sub

    Private Sub dgvCustomerList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        btnSelect_Click(sender, e)
    End Sub

    Private Sub dgvCustomerList_CellEnter(sender As Object, e As DataGridViewCellEventArgs)
        'btnSelect_Click(sender, e)
    End Sub

    Private Sub dgvCustomerList_KeyDown(sender As Object, e As KeyEventArgs)
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

    Private Sub txtSearchCustomer_TextChanged(sender As Object, e As EventArgs)
        Dim i As Integer
        dgvCustomerList.Rows.Clear()
        cmd = New MySqlCommand("SELECT * FROM customers where custcode like '%" & txtSearchCustomer.Text & "%' or custname like '%" & txtSearchCustomer.Text & "%' or address like '%" & txtSearchCustomer.Text & "%' or areaname like '%" & txtSearchCustomer.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvCustomerList.Rows.Add(i, False, rd.Item("custcode").ToString, rd.Item("custname").ToString, rd.Item("address").ToString, rd.Item("shipto").ToString, _
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

    Private Sub btnSelect_Click_1(sender As Object, e As EventArgs) Handles btnSelect.Click

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
        ElseIf Me.Text = "CUSTOMER LIST" Then '"LIST OF SALES INVOICES" Then
            'frmListSalesInvoices.txtCustCode.Text = dgvCustomerList.CurrentRow.Cells(1).Value
            'frmListSalesInvoices.txtCustomername.Text = dgvCustomerList.CurrentRow.Cells(2).Value
            'frmListSalesInvoices.txtCustCode.Focus()

            txtSearchCustomer.Focus()
            'Dim selectedValue As String = String.Empty
            'Dim selectedName As String = String.Empty
            'For Each row As DataGridViewRow In dgvCustomerList.Rows
            '    Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("dgCheckbox").Value)
            '    If isSelected Then

            '        selectedValue &= "'" & row.Cells("dgCode").Value.ToString() & "'"
            '        selectedValue &= ", "

            '        selectedName &= "" & row.Cells("dgCustomerName").Value.ToString() & ""
            '        selectedName &= ", "
            '    End If


            'Next

            'With frmListSalesInvoices
            '    .txtCustCode.Text = selectedValue.Substring(0, selectedValue.Length - 2)
            '    .txtCustomername.Text = selectedName.Substring(0, selectedName.Length - 2)
            '    .chkCustomer.Checked = False
            '    .chkSortCustomer.Enabled = True
            'End With
            'Me.Close()


            Dim selcode As String = txtCustCode.Text
            Dim custName As String = txtCustomername.Text
            With frmListSalesInvoices 'Detailed_Sales_Invoice
                .txtCustCode.Text = selcode.Remove(0, 1)
                .txtCustomername.Text = custName.Remove(0, 1)
                .chkCustomer.Checked = False
                .chkSortCustomer.Enabled = True
            End With
            Me.Close()


        ElseIf Me.Text = "CUSTOMER LIST (Detailed Sales Invoice)" Then '"LIST OF SALES INVOICES" Then
            'frmListSalesInvoices.txtCustCode.Text = dgvCustomerList.CurrentRow.Cells(1).Value
            'frmListSalesInvoices.txtCustomername.Text = dgvCustomerList.CurrentRow.Cells(2).Value
            'frmListSalesInvoices.txtCustCode.Focus()

            txtSearchCustomer.Focus()
            'Dim selectedValue As String = String.Empty
            'Dim selectedName As String = String.Empty
            'For Each row As DataGridViewRow In dgvCustomerList.Rows
            '    Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("dgCheckbox").Value)
            '    If isSelected Then

            '        selectedValue &= "'" & row.Cells("dgCode").Value.ToString() & "'"
            '        selectedValue &= ", "

            '        selectedName &= "" & row.Cells("dgCustomerName").Value.ToString() & ""
            '        selectedName &= ", "
            '    End If


            'Next

            'With frmListofSalesInvoicesDetailed 'Detailed_Sales_Invoice
            '    .txtCustCode.Text = selectedValue.Substring(0, selectedValue.Length - 2)
            '    .txtCustomername.Text = selectedName.Substring(0, selectedName.Length - 2)
            '    .chkCustomer.Checked = False
            '    .chkSortCustomer.Enabled = True
            'End With
            Dim selcode As String = txtCustCode.Text
            Dim custName As String = txtCustomername.Text
            With frmListofSalesInvoicesDetailed 'Detailed_Sales_Invoice
                .txtCustCode.Text = selcode.Remove(0, 1)
                .txtCustomername.Text = custName.Remove(0, 1)
            End With
            Me.Close()
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
        End If
        Me.Close()

    End Sub

    Private Sub txtSearchCustomer_TextChanged_1(sender As Object, e As EventArgs) Handles txtSearchCustomer.TextChanged
        Dim i As Integer
        dgvCustomerList.Rows.Clear()
        cmd = New MySqlCommand("SELECT * FROM customers where custcode like '%" & txtSearchCustomer.Text & "%' or custname like '%" & txtSearchCustomer.Text & "%' or address like '%" & txtSearchCustomer.Text & "%' or " & _
                               "areaname like '%" & txtSearchCustomer.Text & "%' order by custname Asc", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvCustomerList.Rows.Add(i, False, rd.Item("custcode").ToString, rd.Item("custname").ToString, rd.Item("address").ToString, rd.Item("shipto").ToString, _
                                  rd.Item("areacode").ToString, rd.Item("areaname").ToString, rd.Item("outletcode").ToString, rd.Item("outlettype").ToString, _
                                  rd.Item("provcode").ToString, rd.Item("province").ToString, rd.Item("maincode").ToString, rd.Item("mainp").ToString, _
                                  rd.Item("tinno").ToString, rd.Item("mobileno").ToString, rd.Item("telno").ToString, rd.Item("payterms").ToString, _
                                  Format(CDbl(rd.Item("creditlimit").ToString), "#,##0.00"), Format(CDbl(rd.Item("spdiscount").ToString), "#,##0.00"), _
                                  rd.Item("allowpd").ToString, rd.Item("active").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()

        If dgvCustomerList.RowCount > 0 Then

            Dim inputText As String = txtCustCode.Text
            Dim result As String() = Regex.Split(inputText, ",")

           
            For Each s As String In result
                Dim str = s.Replace("'", "")
                str = str.Replace(" ", "")
                searchAndChecked(str)
            Next

        End If
        'dgvCustomerList.CurrentCell = dgvCustomerList.Rows(1).Cells(1)
        'dgvCustomerList.Focus()
    End Sub

    Private Sub dgvCustomerList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomerList.CellClick

    End Sub

    Private Sub dgvCustomerList_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomerList.CellContentClick

        Dim oldtextfromthis As String = txtCustCode.Text

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 1 Then

            Dim row As DataGridViewRow = dgvCustomerList.Rows(e.RowIndex)


            row.Cells("dgCheckbox").Value = Convert.ToBoolean(row.Cells("dgCheckbox").EditedFormattedValue)

            Dim codeval As String = "'" & dgvCustomerList.Rows(e.RowIndex).Cells(2).Value & "',"
            Dim codevalname As String = "" & dgvCustomerList.Rows(e.RowIndex).Cells(3).Value & ","
            If Convert.ToBoolean(row.Cells("dgCheckbox").Value) Then 'ADD


                selectedValue &= ",'" & dgvCustomerList.Rows(e.RowIndex).Cells(2).Value & "'"
                ' selectedValue &= ", "
                txtCustCode.Text = selectedValue '.Substring(0, selectedValue.Length - 1)


                selectedName &= "," & dgvCustomerList.Rows(e.RowIndex).Cells(3).Value & ""
                ' selectedName &= ", "


                txtCustomername.Text = selectedName 'selectedName.Substring(0, selectedName.Length - 2)
                'callthisfunction()
                '==============sayup=================
                'MessageBox.Show(("Selected ID: " & row.Cells(1).Value))

                '==============sayup=================
            Else 'REMOVE

                Dim inputText As String = txtCustCode.Text

                Dim custcodename As String = Nothing
                custcodename = Replace(inputText, codeval, "") 'inputText.Replace("", codeval) 'naay comma

                If inputText = custcodename Then    'meaning wala na remove kay naay comma sa last 

                    Dim codevalwithoutcomma As String = "," & codeval.Substring(0, codeval.Length - 1)
                    custcodename = Replace(inputText, codevalwithoutcomma, "")

                    'Else
                    '    custcodename = custcodename & ","
                End If

                txtCustCode.Text = custcodename
                selectedValue = custcodename


                Dim inputTextname As String = txtCustomername.Text
                Dim custcodenameFull As String = Nothing
                custcodenameFull = Replace(inputTextname, codevalname, "")  'inputText.Replace("", codeval)
                If inputTextname = custcodenameFull Then  'meaning wala na remove kay naay comma sa last 
                    Dim codevalwithoutcommaFull As String = "," & codevalname.Substring(0, codevalname.Length - 1)
                    custcodenameFull = Replace(inputTextname, codevalwithoutcommaFull, "")
                Else
                    'custcodenameFull = custcodenameFull & ","
                End If
                txtCustomername.Text = custcodenameFull
                selectedName = custcodenameFull

            End If
        End If







    End Sub

    Sub callthisfunction()
        txtCustCode.Text = Nothing
        Dim selectedValue As String = String.Empty

        For Each row As DataGridViewRow In dgvCustomerList.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("dgCheckbox").Value)
            If isSelected Then

                selectedValue &= "'" & row.Cells("dgCode").Value.ToString() & "'"
                selectedValue &= ", "


            End If


        Next
        txtCustCode.Text = selectedValue.Substring(0, selectedValue.Length - 2)

    End Sub

    'pls dont erase this
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then

    ''Reference the GridView Row.
    'Dim row As DataGridViewRow = dataGridView1.Rows(e.RowIndex)

    ''Set the CheckBox selection.
    '    row.Cells("checkBoxColumn").Value = Convert.ToBoolean(row.Cells("checkBoxColumn").EditedFormattedValue)

    ''If CheckBox is checked, display Message Box.
    '    If Convert.ToBoolean(row.Cells("checkBoxColumn").Value) Then
    '        MessageBox.Show(("Selected ID: " & row.Cells(1).Value))
    '    End If
    'End If
End Class