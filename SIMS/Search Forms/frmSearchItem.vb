Imports MySql.Data.MySqlClient

Public Class frmSearchItem

    Private Sub frmSearchItem_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSelect.PerformClick()
        End If
    End Sub

    Private Sub frmSearchItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItemList()
        txtSeachItem.Focus()
    End Sub

    Sub LoadItemList()
        dgvItemList.Rows.Clear()
        Dim i As Integer
        cmd = New MySqlCommand("SELECT * FROM ivitem WHERE obsolet <> 'Y' order by description asc", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvItemList.Rows.Add(i, rd.Item("itemcode").ToString, rd.Item("description").ToString, rd.Item("supcode").ToString, rd.Item("supplier").ToString, rd.Item("catcode").ToString, rd.Item("category").ToString, _
                                  rd.Item("brcode").ToString, rd.Item("brand").ToString, rd.Item("unit").ToString, Format(CDbl(rd.Item("pckgc").ToString), "#,##0"), rd.Item("pckgb").ToString, _
                                  rd.Item("freeitem").ToString, Format(CDbl(rd.Item("grscost").ToString), "#,##0.00"), Format(CDbl(rd.Item("netcost").ToString), "#,##0.00"), Format(CDbl(rd.Item("costpc").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("apricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("apriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("apricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("bpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("cpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpricep").ToString), "#,##0.00"), _
                                  rd.Item("obsolet").ToString, Format(CDbl(rd.Item("discpct").ToString), "#,##.0"), rd.Item("pkno").ToString) ' "Edit", "Delete")
        End While
        rd.Close()
    End Sub

    Private Sub tsSelectItem_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        If Me.Tag = "StockCard" Then
            With frmStockCard
                .txtItemCode.Text = dgvItemList.CurrentRow.Cells(1).Value
                .txtDescription.Text = dgvItemList.CurrentRow.Cells(2).Value
            End With
        Else
            With frmItemHistory
                .txtItemCode.Text = dgvItemList.CurrentRow.Cells(1).Value
                .txtDescription.Text = dgvItemList.CurrentRow.Cells(2).Value
            End With

        End If


        Me.Dispose()

        'With frmStockCard
        '    .txtItemCode.Text = dgvItemList.CurrentRow.Cells(1).Value
        '    .txtDescription.Text = dgvItemList.CurrentRow.Cells(2).Value
        'End With
        'Me.Dispose()
        'Dim rr As Integer
        'rr = frmReceivingD.dgvItem.CurrentRow.Index
        'frmReceivingD.dgvItem.Rows(rr).Cells(1).Value = dgvItemList.CurrentRow.Cells(1).Value
        'frmReceivingD.dgvItem.Rows(rr).Cells(2).Value = dgvItemList.CurrentRow.Cells(2).Value
        'frmReceivingD.dgvItem.Rows(rr).Cells(4).Value = dgvItemList.CurrentRow.Cells(9).Value
        'frmReceivingD.dgvItem.Rows(rr).Cells(5).Value = dgvItemList.CurrentRow.Cells(10).Value
        'frmReceivingD.dgvItem.Rows(rr).Cells(6).Value = dgvItemList.CurrentRow.Cells(13).Value
        'frmReceivingD.dgvItem.Rows(rr).Cells(7).Value = dgvItemList.CurrentRow.Cells(14).Value
        'frmReceivingD.dgvItem.Rows(rr).Cells(9).Value = dgvItemList.CurrentRow.Cells(15).Value


        'frmReceivingD.dgvRcvItem.Rows(rr).Cells(8).Value = dgvItemList.CurrentRow.Cells().Value
        'frmReceivingD.dgvRcvItem.Rows(rr).Cells(4).Value = dgvItemList.CurrentRow.Cells(2).Value
        'frmReceivingD.dgvItem.CurrentCell = frmReceivingD.dgvItem.Rows(rr).Cells(3)
        'frmReceivingD.dgvItem.Focus()
        'Me.Hide()
    End Sub

    Private Sub dgvItemList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellContentClick
        'tsSelectItem_Click(1, New System.EventArgs())
    End Sub

    Private Sub tbSeachItem_TextChanged(sender As Object, e As EventArgs) Handles txtSeachItem.TextChanged
        Dim i As Integer
        dgvItemList.Rows.Clear()
        cmd = New MySqlCommand("SELECT * FROM ivitem where description like '%" & txtSeachItem.Text & "%' or itemcode like '%" & txtSeachItem.Text & "%' and isdeleted<>1", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvItemList.Rows.Add(i, rd.Item("itemcode").ToString, rd.Item("description").ToString, rd.Item("supcode").ToString, rd.Item("supplier").ToString, rd.Item("catcode").ToString, rd.Item("category").ToString, _
                                   rd.Item("brcode").ToString, rd.Item("brand").ToString, rd.Item("unit").ToString, Format(CDbl(rd.Item("pckgc").ToString), "#,##0"), rd.Item("pckgb").ToString, _
                                   rd.Item("freeitem").ToString, rd.Item("grscost").ToString, rd.Item("netcost").ToString, rd.Item("costpc").ToString, _
                                   Format(CDbl(rd.Item("apricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("apriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("apricep").ToString), "#,##0.00"), _
                                   Format(CDbl(rd.Item("bpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpricep").ToString), "#,##0.00"), _
                                   Format(CDbl(rd.Item("cpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpricep").ToString), "#,##0.00"), _
                                   rd.Item("obsolet").ToString, Format(CDbl(rd.Item("discpct").ToString), "#,##.0"), rd.Item("pkno").ToString) ' "Edit", "Delete")
        End While
        rd.Close()
    End Sub

    Private Sub dgvItemList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellDoubleClick
        btnSelect.PerformClick()
    End Sub

    Private Sub dgvItemList_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvItemList.KeyDown

    End Sub

    Private Sub dgvItemList_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvItemList.KeyPress
        '  tsSelectItem_Click(sender, e)

    End Sub
End Class