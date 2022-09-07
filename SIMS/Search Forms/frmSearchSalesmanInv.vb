Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class frmSearchSalesmanInv
    Public selectedValue As String = String.Empty
    Public selectedName As String = String.Empty
    Private Sub frmSearchSalesmanInv_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            btnSelect.PerformClick()
        End If
    End Sub

    Private Sub frmSearchSalesmanInv_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        shortcutkeys(e)
    End Sub

    Private Sub frmSearchSalesmanInv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSalesman()
    End Sub
    Sub uncheckedAll()
        For x As Integer = 0 To dgvListSalesman.RowCount - 1

            dgvListSalesman.Rows(x).Cells(1).Value = False

        Next
    End Sub
    Sub searchAndChecked(ByVal searchValue As String)
        For x As Integer = 0 To dgvListSalesman.RowCount - 1
            If searchValue = dgvListSalesman.Rows(x).Cells(2).Value() Then
                dgvListSalesman.Rows(x).Cells(1).Value = True
            End If
        Next
    End Sub

    Sub shortcutkeys(e As KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            ' gbxBrand.Visible = False
            Me.Close()
        ElseIf e.KeyCode = Keys.F12 Then

        ElseIf e.KeyCode = Keys.F1 Then

        End If
    End Sub

    Sub LoadSalesman()
        'Dim i As Integer = 0
        'dgvListSalesman.Rows.Clear()
        'cmd = New MySqlCommand("SELECT s.*,c.* FROM custsales s JOIN customers c ON s.custcode=c.custcode WHERE s.custcode like '" & frmSalesInvoiceD.txtCustCode.Text & "'", cdb)
        'rd = cmd.ExecuteReader
        'While rd.Read
        '    i += 1
        '    dgvListSalesman.Rows.Add(i, rd.Item("slmncode").ToString, rd.Item("slmnname").ToString, rd.Item("whscode").ToString, rd.Item("warehouse").ToString, rd.Item("opercode").ToString, rd.Item("typeofoper").ToString, rd.Item("pricetype").ToString) ') ', rd.Item("pkno").ToString, "Edit", "Delete")
        'End While
        'rd.Close()

        Dim i As Integer = 0
        dgvListSalesman.Rows.Clear()
        ' cmd = New MySqlCommand("SELECT s.*,c.* FROM custsales s JOIN customers c ON s.custcode=c.custcode WHERE s.custcode like '" & frmListSalesInvoices.txtSlmncode.Text & "'", cdb)
        cmd = New MySqlCommand("SELECT * FROM salesman", cdb)
        ' cmd = New MySqlCommand("SELECT s.*,c.* FROM salesman s LEFT JOIN custsales c on s.slmncode=c.slmncode", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            Dim prctype As String = Nothing
            '  prctype = rd.Item("pricetype").ToString()
            'MsgBox(rd.Item("slmnname").ToString & " - " & prctype)
            dgvListSalesman.Rows.Add(i, False, rd.Item("slmncode").ToString, rd.Item("slmnname").ToString, rd.Item("whscode").ToString, rd.Item("whsname").ToString, rd.Item("opercode").ToString, rd.Item("typeofoper").ToString) ', rd.Item("pricetype").ToString)
            'dgvListSalesman.Rows.Add(i, False) ', rd.Item("slmncode").ToString, rd.Item("slmnname").ToString, rd.Item("whscode").ToString, rd.Item("whsname").ToString, rd.Item("opercode").ToString, rd.Item("typeofoper").ToString) ', rd.Item("pricetype").ToString)
            '  dgvListSalesman.Rows(i - 1).Cells(0).Value = False
        End While
        rd.Close()
    End Sub


    'Sub LoadSalesman(ByVal custsalesno As Integer)
    '    Dim i As Integer = 0
    '    dgvListSalesman.Rows.Clear()

    '    Dim cmd2 As MySqlCommand
    '    cmd = New MySqlCommand("SELECT * FROM salesman", cdb)
    '    rd = cmd.ExecuteReader

    '    While rd.Read
    '        cmd2 = New MySqlCommand("SELECT * FROM custsales", cdb)
    '        i += 1
    '        dgvListSalesman.Rows.Add(i, rd.Item("slmcode").ToString, rd.Item("slmnname").ToString, rd.Item("whscode").ToString, rd.Item("whsname").ToString, rd.Item("opercode").ToString, rd.Item("typeofoper").ToString) ', rd.Item("pkno").ToString, "Edit", "Delete")

    '        dgvListSalesman.Rows(i - 1).Cells(0).Value = False

    '    End While
    '    rd.Close()

    '    'For i = 0 To frmCustomerD.dgvSalesman.RowCount - 1
    '    '    For j = 0 To dgvListSalesman.RowCount - 1
    '    '        If frmCustomerD.dgvSalesman.Rows(i).Cells(2).Value = dgvListSalesman.Rows(j).Cells(2).Value Then
    '    '            dgvListSalesman.Rows(j).Cells(0).Value = True
    '    '            Exit For
    '    '        End If
    '    '    Next
    '    'Next

    'End Sub

    'Private Sub dgvListSalesman_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListSalesman.CellContentClick
    '    If e.ColumnIndex = 0 Then
    '        With dgvListSalesman
    '            If .Rows(.CurrentRow.Index).Cells(0).Value = True Then
    '                .Rows(.CurrentRow.Index).Cells(0).Value = False
    '                For i = 0 To frmCustomerD.dgvSalesman.RowCount - 1
    '                    If .CurrentRow.Cells(1).Value = frmCustomerD.dgvSalesman.Rows(i).Cells(1).Value Then
    '                        frmCustomerD.dgvSalesman.Rows.Remove(frmCustomerD.dgvSalesman.Rows(i))
    '                        For j = 0 To frmCustomerD.dgvSalesman.RowCount - 1
    '                            frmCustomerD.dgvSalesman.Rows(j).Cells(0).Value = j + 1


    '                        Next
    '                        Exit For
    '                    End If
    '                Next
    '            Else
    '                AddtoList()
    '            End If
    '            If e.ColumnIndex = 1 Then
    '                sRemovetoList()
    '            End If
    '        End With


    'For i = 0 To frmCustomerD.dgvSalesman.RowCount - 1
    '    For j = 0 To dgvListSalesman.RowCount - 1
    '        If frmCustomerD.dgvSalesman.Rows(i).Cells(2).Value = dgvListSalesman.Rows(j).Cells(2).Value Then
    '            dgvListSalesman.Rows(j).Cells(0).Value = True
    '            Exit For
    '        End If
    '    Next
    'Next
    '    End If
    'End Sub

    Private Sub AddtoList()

        'Dim r As Integer

        ''For i As Integer = 0 To dgvListSalesman.RowCount - 1
        ''    If frmCustomerD.dgvSalesman.Rows(i).Cells(1).Value = dgvListSalesman.CurrentRow.Cells(1).Value Then
        ''        MsgBox("Salesman Already Exist!", vbCritical)
        ''        With frmCustomerD
        ''            frmCustomerD.dgvSalesman.Rows(i).Cells(1).Value.sRemovetoListCustomerD()
        ''        End With
        ''    ElseIf frmCustomerD.dgvSalesman.Rows(i).Cells(1).Value <> dgvListSalesman.CurrentRow.Cells(1).Value Then

        'dgvListSalesman.Rows(dgvListSalesman.CurrentRow.Index).Cells(0).Value = True
        'frmCustomerD.dgvSalesman.Rows.Add()
        'r = frmCustomerD.dgvSalesman.RowCount - 1
        'frmCustomerD.dgvSalesman.Rows(r).Cells(0).Value = r + 1
        'frmCustomerD.dgvSalesman.Rows(r).Cells(1).Value = dgvListSalesman.CurrentRow.Cells(1).Value
        'frmCustomerD.dgvSalesman.Rows(r).Cells(2).Value = dgvListSalesman.CurrentRow.Cells(2).Value
        'frmCustomerD.dgvSalesman.Rows(r).Cells(3).Value = dgvListSalesman.CurrentRow.Cells(3).Value
        'frmCustomerD.dgvSalesman.Rows(r).Cells(4).Value = dgvListSalesman.CurrentRow.Cells(4).Value
        'frmCustomerD.dgvSalesman.Rows(r).Cells(5).Value = dgvListSalesman.CurrentRow.Cells(5).Value
        'frmCustomerD.dgvSalesman.Rows(r).Cells(6).Value = dgvListSalesman.CurrentRow.Cells(6).Value
        ''   End If
        ''  Next

    End Sub

    Private Sub sRemovetoList()
        For Each row As DataGridViewRow In dgvListSalesman.SelectedRows
            dgvListSalesman.Rows.Remove(row)
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub dgvListSalesman_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListSalesman.CellClick
        'With frmSalesInvoiceD
        '    .txtSalesmanCode.Text = dgvListSalesman.CurrentRow.Cells(1).Value
        '    .txtSalesmanName.Text = dgvListSalesman.CurrentRow.Cells(2).Value
        '    .txtWarehouseCode.Text = dgvListSalesman.CurrentRow.Cells(3).Value
        '    .txtWarehouseName.Text = dgvListSalesman.CurrentRow.Cells(4).Value
        '    .txtPriceType.Text = dgvListSalesman.CurrentRow.Cells(7).Value
        'End With
    End Sub

    Private Sub dgvListSalesman_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListSalesman.CellDoubleClick
        'btnSelect_Click(sender, e)
        'With frmSalesInvoiceD
        '    .txtSalesmanCode.Text = dgvListSalesman.CurrentRow.Cells(1).Value
        '    .txtSalesmanName.Text = dgvListSalesman.CurrentRow.Cells(2).Value
        '    .txtWarehouseCode.Text = dgvListSalesman.CurrentRow.Cells(3).Value
        '    .txtWarehouseName.Text = dgvListSalesman.CurrentRow.Cells(4).Value
        '    .txtPriceType.Text = dgvListSalesman.CurrentRow.Cells(7).Value
        'End With
        'Me.Dispose()
    End Sub

    'Private Sub dgvListSalesman_KeyUp(sender As Object, e As KeyEventArgs) Handles dgvListSalesman.KeyUp
    '    shortcutkeys(e)
    'End Sub

    'Private Sub tbSearchSlsman_KeyUp(sender As Object, e As KeyEventArgs) Handles tbSearchSlsman.KeyUp
    '    shortcutkeys(e)
    'End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        If Me.Text = "SALESMAN LIST (Detailed Sales Invoice)" Then

            txtSearchSlsman.Focus()

            Dim selcode As String = txtSlmncode.Text
            Dim salesmanname As String = txtSalesmanName.Text
            With frmListofSalesInvoicesDetailed 'Detailed_Sales_Invoice
                .txtSlmncode.Text = selcode.Remove(0, 1)
                .txtSalesmanName.Text = salesmanname.Remove(0, 1)
                .chkSalesman.Checked = False
                .chkSortSalesman.Enabled = True
            End With
            Me.Close()
            'Dim selectedValue As String = String.Empty
            'Dim selectedName As String = String.Empty
            'For Each row As DataGridViewRow In dgvListSalesman.Rows
            '    Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("dgCheckbox").Value)
            '    If isSelected Then

            '        selectedValue &= "'" & row.Cells("dgCode").Value.ToString() & "'"
            '        selectedValue &= ", "


            '        selectedName &= "" & row.Cells("dgSalesmanName").Value.ToString() & ""
            '        selectedName &= ", "
            '    End If


            'Next

            'With frmListofSalesInvoicesDetailed 'Detailed_Sales_Invoice
            '    .txtSlmncode.Text = selectedValue.Substring(0, selectedValue.Length - 2)
            '    .txtSalesmanName.Text = selectedName.Substring(0, selectedName.Length - 2)
            '    .chkSalesman.Checked = False
            '    .chkSortSalesman.Enabled = True
            'End With
            'Me.Close()

        Else ' SALES INVOICE H
            txtSearchSlsman.Focus()

            Dim selcode As String = txtSlmncode.Text
            Dim salesmanname As String = txtSalesmanName.Text
            With frmListSalesInvoices 'Detailed_Sales_Invoice
                .txtSlmncode.Text = selcode.Remove(0, 1)
                .txtSalesmanName.Text = salesmanname.Remove(0, 1)
                .chkSalesman.Checked = False
                .chkSortSalesman.Enabled = True
            End With
            Me.Close()

            'txtSearchSlsman.Focus()
            'Dim selectedValue As String = String.Empty
            'Dim selectedName As String = String.Empty
            'For Each row As DataGridViewRow In dgvListSalesman.Rows
            '    Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("dgCheckbox").Value)
            '    If isSelected Then

            '        selectedValue &= "'" & row.Cells("dgCode").Value.ToString() & "'"
            '        selectedValue &= ", "

            '        selectedName &= "" & row.Cells("dgSalesmanName").Value.ToString() & ""
            '        selectedName &= ", "
            '    End If

            'Next

            'With frmListSalesInvoices
            '    .txtSlmncode.Text = selectedValue.Substring(0, selectedValue.Length - 2)
            '    .txtSalesmanName.Text = selectedName.Substring(0, selectedName.Length - 2)
            '    .chkSalesman.Checked = False
            '    .chkSortSalesman.Enabled = True
            'End With
            'Me.Close()


        End If



        'If Me.Text = "LIST OF SALES INVOICES" Then
        '    frmListSalesInvoices.txtSlmncode.Text = dgvListSalesman.CurrentRow.Cells(1).Value
        '    frmListSalesInvoices.txtSalesmanName.Text = dgvListSalesman.CurrentRow.Cells(2).Value
        '    frmListSalesInvoices.txtSlmncode.Focus()
        '    ' SendKeys.Send("{enter}")
        'End If
        'Me.Close()
        'dgvListSalesman.Rows(0).Selected = True

        'With frmSalesInvoiceD
        '    .txtSalesmanCode.Text = dgvListSalesman.CurrentRow.Cells(1).Value
        '    .txtSalesmanName.Text = dgvListSalesman.CurrentRow.Cells(2).Value
        '    .txtWarehouseCode.Text = dgvListSalesman.CurrentRow.Cells(3).Value
        '    .txtWarehouseName.Text = dgvListSalesman.CurrentRow.Cells(4).Value
        '    .txtPriceType.Text = dgvListSalesman.CurrentRow.Cells(7).Value
        'End With

        'cmd = New MySqlCommand("SELECT * FROM custsales WHERE custcode like '" & frmSalesInvoiceD.txtCustCode.Text & "'", cdb)
        'Using rd As MySqlDataReader = cmd.ExecuteReader
        '    If rd.HasRows Then
        '        rd.Read()
        '        'With frmSalesInvoiceD
        '        frmSalesInvoiceD.txtSalesmanCode.Text = rd("slmcode").ToString
        '        frmSalesInvoiceD.txtSalesmanName.Text = rd("salesman").ToString
        '        frmSalesInvoiceD.txtPriceType.Text = rd("pricetype").ToString
        '        frmSalesInvoiceD.txtWarehouseCode.Text = rd("whscode").ToString
        '        frmSalesInvoiceD.txtWarehouseName.Text = rd("warehouse").ToString
        '        'End With
        '        rd.Close()
        '    End If
        '    Me.Dispose()
        'End Using
    End Sub

    Private Sub dgvListSalesman_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListSalesman.CellEnter
        'btnSelect_Click(sender, e)
        '  btnCloseSalesman_Click(sender, e)
    End Sub

    Private Sub dgvListSalesman_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListSalesman.CellContentClick
        'btnSelect_Click(sender, e)
        ' btnSalesmanClose_Click(sender, e)

        Dim oldtextfromthis As String = txtSlmncode.Text

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 1 Then

            Dim row As DataGridViewRow = dgvListSalesman.Rows(e.RowIndex)


            row.Cells("dgCheckbox").Value = Convert.ToBoolean(row.Cells("dgCheckbox").EditedFormattedValue)

            Dim codeval As String = "'" & dgvListSalesman.Rows(e.RowIndex).Cells(2).Value & "',"
            Dim codevalname As String = "" & dgvListSalesman.Rows(e.RowIndex).Cells(3).Value & ","
            If Convert.ToBoolean(row.Cells("dgCheckbox").Value) Then 'ADD


                selectedValue &= ",'" & dgvListSalesman.Rows(e.RowIndex).Cells(2).Value & "'"

                txtSlmncode.Text = selectedValue '.Substring(0, selectedValue.Length - 1)


                selectedName &= "," & dgvListSalesman.Rows(e.RowIndex).Cells(3).Value & ""

                txtSalesmanName.Text = selectedName 'selectedName.Substring(0, selectedName.Length - 2)
        
            Else 'REMOVE

                Dim inputText As String = txtSlmncode.Text

                Dim custcodename As String = Nothing
                custcodename = Replace(inputText, codeval, "") 'inputText.Replace("", codeval) 'naay comma

                If inputText = custcodename Then    'meaning wala na remove kay naay comma sa last 

                    Dim codevalwithoutcomma As String = "," & codeval.Substring(0, codeval.Length - 1)
                    custcodename = Replace(inputText, codevalwithoutcomma, "")

                    'Else
                    '    custcodename = custcodename & ","
                End If

                txtSlmncode.Text = custcodename
                selectedValue = custcodename


                Dim inputTextname As String = txtSalesmanName.Text
                Dim custcodenameFull As String = Nothing
                custcodenameFull = Replace(inputTextname, codevalname, "")  'inputText.Replace("", codeval)
                If inputTextname = custcodenameFull Then  'meaning wala na remove kay naay comma sa last 
                    Dim codevalwithoutcommaFull As String = "," & codevalname.Substring(0, codevalname.Length - 1)
                    custcodenameFull = Replace(inputTextname, codevalwithoutcommaFull, "")
                Else
                    'custcodenameFull = custcodenameFull & ","
                End If
                txtSalesmanName.Text = custcodenameFull
                selectedName = custcodenameFull

            End If
        End If


    End Sub

    Private Sub tbSearchSlsman_TextChanged(sender As Object, e As EventArgs) Handles txtSearchSlsman.TextChanged



        Dim i As Integer = 0
        dgvListSalesman.Rows.Clear()
        cmd = New MySqlCommand("SELECT * FROM salesman where slmncode like '%" & txtSearchSlsman.Text & "%' or " & _
                               "slmnname like '%" & txtSearchSlsman.Text & "%' or whsname like '%" & txtSearchSlsman.Text & "%' " & _
                                "order by slmnname Asc", cdb)
        ' cmd = New MySqlCommand("SELECT * FROM salesman", cdb)

        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            Dim prctype As String = Nothing
          
            dgvListSalesman.Rows.Add(i, False, rd.Item("slmncode").ToString, rd.Item("slmnname").ToString, rd.Item("whscode").ToString, rd.Item("whsname").ToString, rd.Item("opercode").ToString, rd.Item("typeofoper").ToString) ', rd.Item("pricetype").ToString)
            
        End While
        rd.Close()





        'Dim i As Integer
        'dgvCustomerList.Rows.Clear()
        'cmd = New MySqlCommand("SELECT * FROM customers where custcode like '%" & txtSearchCustomer.Text & "%' or custname like '%" & txtSearchCustomer.Text & "%' or address like '%" & txtSearchCustomer.Text & "%' or " & _
        '                       "areaname like '%" & txtSearchCustomer.Text & "%' order by custname Asc", cdb)
        'rd = cmd.ExecuteReader
        'While rd.Read
        '    i += 1
        '    dgvCustomerList.Rows.Add(i, False, rd.Item("custcode").ToString, rd.Item("custname").ToString, rd.Item("address").ToString, rd.Item("shipto").ToString, _
        '                          rd.Item("areacode").ToString, rd.Item("areaname").ToString, rd.Item("outletcode").ToString, rd.Item("outlettype").ToString, _
        '                          rd.Item("provcode").ToString, rd.Item("province").ToString, rd.Item("maincode").ToString, rd.Item("mainp").ToString, _
        '                          rd.Item("tinno").ToString, rd.Item("mobileno").ToString, rd.Item("telno").ToString, rd.Item("payterms").ToString, _
        '                          Format(CDbl(rd.Item("creditlimit").ToString), "#,##0.00"), Format(CDbl(rd.Item("spdiscount").ToString), "#,##0.00"), _
        '                          rd.Item("allowpd").ToString, rd.Item("active").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        'End While
        'rd.Close()

        If dgvListSalesman.RowCount > 0 Then

            Dim inputText As String = txtSlmncode.Text
            Dim result As String() = Regex.Split(inputText, ",")


            For Each s As String In result
                Dim str = s.Replace("'", "")
                str = str.Replace(" ", "")
                searchAndChecked(str)
            Next

        End If
    End Sub

    Private Sub btnCloseSalesman_Click(sender As Object, e As EventArgs) Handles btnCloseSalesman.Click
        Me.Dispose()
    End Sub

    Private Sub btnCloseSalesman_KeyDown(sender As Object, e As KeyEventArgs) Handles btnCloseSalesman.KeyDown

    End Sub

    Private Sub dgvListSalesman_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvListSalesman.CellFormatting

    End Sub

    Private Sub dgvListSalesman_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvListSalesman.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.PageDown Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.PageUp Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dgvListSalesman_CellClick(1, New DataGridViewCellEventArgs(0, dgvListSalesman.CurrentRow.Index))
        End If
    End Sub
End Class