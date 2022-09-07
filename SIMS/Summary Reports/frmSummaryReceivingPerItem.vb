Public Class frmSummaryReceivingPerItem

    Private Sub tbItem_KeyDown(sender As Object, e As KeyEventArgs) Handles tbItem.KeyDown
        If Keys.F2 Then
            frmItemH.ShowDialog()

        End If
    End Sub

    Private Sub tbItem_TextChanged(sender As Object, e As EventArgs) Handles tbItem.TextChanged

    End Sub

    Private Sub tbCategory_KeyDown(sender As Object, e As KeyEventArgs) Handles tbCategory.KeyDown
        If Keys.F2 Then
            frmSearchCategory.ShowDialog()

        End If
    End Sub

    Private Sub tbCategory_TextChanged(sender As Object, e As EventArgs) Handles tbCategory.TextChanged

    End Sub

    Private Sub tbWhs_KeyDown(sender As Object, e As KeyEventArgs) Handles tbWhs.KeyDown
        If Keys.F2 Then
            frmSearchWarehouse.ShowDialog()

        End If
    End Sub

    Private Sub tbWhs_TextChanged(sender As Object, e As EventArgs) Handles tbWhs.TextChanged

    End Sub

    Private Sub tbSupplier_KeyDown(sender As Object, e As KeyEventArgs) Handles tbSupplier.KeyDown
        If Keys.F2 Then
            frmSearchSupplier.ShowDialog()

        End If
    End Sub

    Private Sub tbSupplier_TextChanged(sender As Object, e As EventArgs) Handles tbSupplier.TextChanged

    End Sub

    Private Sub tbBrand_KeyDown(sender As Object, e As KeyEventArgs) Handles tbBrand.KeyDown
        If Keys.F2 Then
            frmSearchBrand.ShowDialog()

        End If
    End Sub

    Private Sub tbBrand_TextChanged(sender As Object, e As EventArgs) Handles tbBrand.TextChanged

    End Sub
End Class