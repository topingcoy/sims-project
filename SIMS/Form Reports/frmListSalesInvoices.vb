Public Class frmListSalesInvoices

    Private Sub frmListSalesInvoices_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
      
    End Sub

    Private Sub frmListSalesInvoices_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tbCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles tbSalesman.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmSearchSalesman.ShowDialog()
        End If
    End Sub

    Private Sub tbWhs_KeyDown(sender As Object, e As KeyEventArgs) Handles tbWhs.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmSearchWarehouse.ShowDialog()
        End If
    End Sub

    Private Sub tbCustomer_KeyDown1(sender As Object, e As KeyEventArgs) Handles tbCustomer.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmSearchCustomer.ShowDialog()
        End If
    End Sub

    Private Sub tbCustomer_TextChanged(sender As Object, e As EventArgs) Handles tbCustomer.TextChanged

    End Sub
End Class