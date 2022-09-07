Public Class frmCustomerARBalance

    Private Sub tbSelectCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles tbSelectCustomer.KeyDown
        If Keys.F2 Then
            frmSearchCustomer.ShowDialog()

        End If
    End Sub

    Private Sub tbSelectCustomer_TextChanged(sender As Object, e As EventArgs) Handles tbSelectCustomer.TextChanged

    End Sub
End Class