Imports MySql.Data.MySqlClient

Public Class frmSearchSalesmanInvoice

    Private Sub frmSearchSalesmanInvoice_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.PageDown Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.PageUp Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Space Then
            btnSelect_Click(sender, e)
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dgvListSalesman_CellClick(1, New DataGridViewCellEventArgs(0, dgvListSalesman.CurrentRow.Index))
        End If
    End Sub

    Private Sub frmSearchSalesmanInvoice_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        shortcutkeys(e)
    End Sub

    Private Sub frmSearchSalesmanInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSalesman()
    End Sub

    Sub LoadSalesman()

        Dim i As Integer = 0
        dgvListSalesman.Rows.Clear()
        cmd = New MySqlCommand("SELECT s.*,c.* FROM custsales s JOIN customers c ON s.custcode=c.custcode WHERE s.custcode like '" & frmSalesInvoiceD.txtCustCode.Text & "'", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            Dim prctype As String = Nothing
            dgvListSalesman.Rows.Add(i, rd.Item("slmncode").ToString, rd.Item("slmnname").ToString, rd.Item("whscode").ToString, rd.Item("warehouse").ToString, rd.Item("opercode").ToString, rd.Item("typeofoper").ToString, rd.Item("pricetype").ToString, "Add")
        End While
        rd.Close()
    End Sub

    Private Sub dgvListSalesman_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListSalesman.CellClick
        With frmSalesInvoiceD
            .txtSalesmanCode.Text = dgvListSalesman.CurrentRow.Cells(1).Value
            .txtSalesmanName.Text = dgvListSalesman.CurrentRow.Cells(2).Value
            .txtWarehouseCode.Text = dgvListSalesman.CurrentRow.Cells(3).Value
            .txtWarehouseName.Text = dgvListSalesman.CurrentRow.Cells(4).Value
            .txtPriceType.Text = dgvListSalesman.CurrentRow.Cells(7).Value
        End With
    End Sub

    Sub shortcutkeys(e As KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F12 Then

        ElseIf e.KeyCode = Keys.F1 Then

        End If
    End Sub

    Private Sub dgvListSalesman_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListSalesman.CellContentClick

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Me.Dispose()
    End Sub

    Private Sub dgvListSalesman_DoubleClick(sender As Object, e As EventArgs) Handles dgvListSalesman.DoubleClick
        btnSelect_Click(sender, e)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim i As Integer = 0
        dgvListSalesman.Rows.Clear()
        cmd = New MySqlCommand("SELECT * FROM salesman where slmncode like '%" & txtSearch.Text & "%' or " & _
                               "slmnname like '%" & txtSearch.Text & "%' or whsname like '%" & txtSearch.Text & "%' " & _
                                "order by slmnname Asc", cdb)
        ' cmd = New MySqlCommand("SELECT * FROM salesman", cdb)

        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            Dim prctype As String = Nothing
            'dgvListSalesman.Rows.Add(i, False, rd.Item("slmncode").ToString, rd.Item("slmnname").ToString, rd.Item("whscode").ToString, rd.Item("whsname").ToString, rd.Item("opercode").ToString, rd.Item("typeofoper").ToString) ', rd.Item("pricetype").ToString)
            dgvListSalesman.Rows.Add(i, rd.Item("slmncode").ToString, rd.Item("slmnname").ToString, rd.Item("whscode").ToString, rd.Item("whsname").ToString, rd.Item("opercode").ToString, rd.Item("typeofoper").ToString, rd.Item("pricetype").ToString, "Add")
        End While
        rd.Close()

    End Sub
End Class