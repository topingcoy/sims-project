Imports MySql.Data.MySqlClient

Public Class frmCollSalesman

    Private Sub frmCollSalesman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSalesman()
    End Sub

    Sub LoadSalesman()
        dgvCollSalesman.Rows.Clear()
        Dim i As Integer
        cmd = New MySqlCommand("SELECT * FROM salesman", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvCollSalesman.Rows.Add(i, rd.Item("slmnname").ToString, rd.Item("slmncode").ToString)
        End While
        rd.Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        With frmExpressCollD
            .txtSalesmanCode.Text = dgvCollSalesman.CurrentRow.Cells(2).Value
            .txtSalesmanName.Text = dgvCollSalesman.CurrentRow.Cells(1).Value
        End With
        Me.Dispose()
        frmCollSearch.ShowDialog()
    End Sub

    Private Sub dgvCollSalesman_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCollSalesman.CellContentClick
        btnSelect_Click(sender, e)
        'tb.Text = dgvSalesman.CurrentRow.Cells(1).Value
        'sWhse = dgvSalesman.CurrentRow.Cells(1).Value
        'lblSalesman.Text = dgvSalesman.CurrentRow.Cells(0).Value
        'dgvSalesman.Visible = False
        'tsItemMenu.Items(0).Select()
        'tsbAddItem_Click(1, e)
    End Sub
End Class