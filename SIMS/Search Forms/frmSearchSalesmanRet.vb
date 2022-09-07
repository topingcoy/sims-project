Imports MySql.Data.MySqlClient

Public Class frmSearchSalesmanRet

    Private Sub frmSearchSalesmanRet_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            btnSelect.PerformClick()
        End If
    End Sub

    Private Sub frmSearchSalesmanRet_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        shortcutkeys(e)
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
        cmd = New MySqlCommand("SELECT s.*,c.* FROM custsales s JOIN customers c ON s.custcode=c.custcode WHERE s.custcode like '" & frmSalesReturnD.txtCustCode.Text & "'", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvListSalesman.Rows.Add(i, rd.Item("slmncode").ToString, rd.Item("slmnname").ToString, rd.Item("whscode").ToString, rd.Item("warehouse").ToString, rd.Item("opercode").ToString, rd.Item("typeofoper").ToString, rd.Item("pricetype").ToString) ') ', rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub dgvListSalesman_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListSalesman.CellClick
        With frmSalesReturnD
            .txtSalesmanCode.Text = dgvListSalesman.CurrentRow.Cells(1).Value
            .txtSalesmanName.Text = dgvListSalesman.CurrentRow.Cells(2).Value
            .txtWarehouseCode.Text = dgvListSalesman.CurrentRow.Cells(3).Value
            .txtWarehouseName.Text = dgvListSalesman.CurrentRow.Cells(4).Value
            .txtPriceType.Text = dgvListSalesman.CurrentRow.Cells(7).Value
        End With
    End Sub

    Private Sub dgvListSalesman_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListSalesman.CellDoubleClick
        btnSelect_Click(sender, e)
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        'With frmSalesReturnD
        '    .txtSalesmanCode.Text = dgvListSalesman.CurrentRow.Cells(1).Value
        '    .txtSalesmanName.Text = dgvListSalesman.CurrentRow.Cells(2).Value
        '    .txtWarehouseCode.Text = dgvListSalesman.CurrentRow.Cells(3).Value
        '    .txtWarehouseName.Text = dgvListSalesman.CurrentRow.Cells(4).Value
        '    .txtPriceType.Text = dgvListSalesman.CurrentRow.Cells(7).Value
        'End With
        Me.Dispose()

    End Sub

    Private Sub dgvListSalesman_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListSalesman.CellEnter
        ' .btnSelect_Click(sender, e)
        '  btnCloseSalesman_Click(sender, e)
    End Sub

    Private Sub dgvListSalesman_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListSalesman.CellContentClick
        btnSelect_Click(sender, e)
        ' btnSalesmanClose_Click(sender, e)
    End Sub

    Private Sub btnCloseSalesman_Click(sender As Object, e As EventArgs) Handles btnCloseSalesman.Click
        Me.Dispose()
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

    Private Sub frmSearchSalesmanRet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSalesman()
    End Sub

    Private Sub tbSearchSlsman_TextChanged(sender As Object, e As EventArgs) Handles tbSearchSlsman.TextChanged

    End Sub
End Class