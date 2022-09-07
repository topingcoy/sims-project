Public Class frmSummaryStockTransfer

    Private Sub tbWarehouseCame_KeyDown(sender As Object, e As KeyEventArgs) Handles tbWarehouseCame.KeyDown
        If Keys.F2 Then
            frmSearchWarehouse.ShowDialog()
        End If
    End Sub


    Private Sub tbWarehouseCame_TextChanged(sender As Object, e As EventArgs) Handles tbWarehouseCame.TextChanged

    End Sub

    Private Sub tbWarehouseTransferredTo_KeyDown(sender As Object, e As KeyEventArgs) Handles tbWarehouseTransferredTo.KeyDown
        If Keys.F2 Then
            frmSearchWarehouse.ShowDialog()
        End If
    End Sub

    Private Sub tbWarehouseTransferredTo_TextChanged(sender As Object, e As EventArgs) Handles tbWarehouseTransferredTo.TextChanged

    End Sub
End Class