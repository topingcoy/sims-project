Imports MySql.Data.MySqlClient

Public Class frmSalesmanList

    Private Sub frmSalesmanList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSalesman()
    End Sub

    Sub LoadSalesman()
        Dim i As Integer = 0
        dgvListSalesman.Rows.Clear()
        cmd = New MySqlCommand("SELECT * FROM salesman", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvListSalesman.Rows.Add(i, rd.Item("slmncode").ToString, rd.Item("slmnname").ToString, rd.Item("whscode").ToString, rd.Item("whsname").ToString, rd.Item("opercode").ToString, rd.Item("typeofoper").ToString, rd.Item("pricetype").ToString, "Add")
            '  dgvListSalesman.Rows(i - 1).Cells(0).Value = False
        End While
        rd.Close()
    End Sub

    Private Sub dgvListSalesman_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListSalesman.CellContentClick
        Dim colname As String = dgvListSalesman.Columns(e.ColumnIndex).Name
        If colname = "ColAdd" Then
            With dgvListSalesman
                dgvListSalesman.Rows(e.RowIndex).Cells(0).Value = frmCustomerH.dgvCustomerSalesman.Rows(e.RowIndex).Cells(0).Value.ToString
                dgvListSalesman.Rows(e.RowIndex).Cells(1).Value = frmCustomerH.dgvCustomerSalesman.Rows(e.RowIndex).Cells(1).Value.ToString
                dgvListSalesman.Rows(e.RowIndex).Cells(2).Value = frmCustomerH.dgvCustomerSalesman.Rows(e.RowIndex).Cells(2).Value.ToString
                dgvListSalesman.Rows(e.RowIndex).Cells(3).Value = frmCustomerH.dgvCustomerSalesman.Rows(e.RowIndex).Cells(3).Value.ToString
                dgvListSalesman.Rows(e.RowIndex).Cells(4).Value = frmCustomerH.dgvCustomerSalesman.Rows(e.RowIndex).Cells(4).Value.ToString
                dgvListSalesman.Rows(e.RowIndex).Cells(5).Value = frmCustomerH.dgvCustomerSalesman.Rows(e.RowIndex).Cells(5).Value.ToString
            End With
            
        End If
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If Me.Text = "LIST OF SALES INVOICES" Then
            frmListSalesInvoices.txtSlmncode.Text = dgvListSalesman.CurrentRow.Cells(1).Value
            frmListSalesInvoices.txtSalesmanName.Text = dgvListSalesman.CurrentRow.Cells(2).Value
            frmListSalesInvoices.txtSlmncode.Focus()
            SendKeys.Send("{enter}")
        End If
        Me.Close()
    End Sub
End Class