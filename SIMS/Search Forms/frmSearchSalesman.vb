Imports MySql.Data.MySqlClient

Public Class frmSearchSalesman

    Private Sub frmSearchSalesman_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        shortcutkeys(e)
    End Sub

    Private Sub frmSearchSalesman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSalesman()
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
        Dim i As Integer = 0
        dgvListSalesman.Rows.Clear()
        cmd = New MySqlCommand("SELECT s.*,c.* FROM custsales s JOIN customers c ON s.custcode=c.custcode WHERE s.custcode like '" & frmSalesInvoiceD.txtCustCode.Text & "'", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvListSalesman.Rows.Add(i, rd.Item("slmcode").ToString, rd.Item("salesman").ToString, rd.Item("whscode").ToString, rd.Item("warehouse").ToString, rd.Item("opercode").ToString, rd.Item("typeofoper").ToString, rd.Item("pricetype").ToString) ') ', rd.Item("pkno").ToString, "Edit", "Delete")
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

    Private Sub dgvListSalesman_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListSalesman.CellDoubleClick
        btnSelect_Click(sender, e)
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
        With frmSalesInvoiceD
            .txtSalesmanCode.Text = dgvListSalesman.CurrentRow.Cells(1).Value
            .txtSalesmanName.Text = dgvListSalesman.CurrentRow.Cells(2).Value
            .txtWarehouseCode.Text = dgvListSalesman.CurrentRow.Cells(3).Value
            .txtWarehouseName.Text = dgvListSalesman.CurrentRow.Cells(4).Value
            .txtPriceType.Text = dgvListSalesman.CurrentRow.Cells(7).Value
        End With

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
        btnSelect_Click(sender, e)
    End Sub

    Private Sub dgvListSalesman_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListSalesman.CellContentClick

    End Sub
End Class