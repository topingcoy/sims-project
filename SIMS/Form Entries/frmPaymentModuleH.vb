Imports MySql.Data.MySqlClient

Public Class frmPaymentModuleH

    Private Sub frmPaymentModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tsAddPayment_Click(sender As Object, e As EventArgs) Handles tsAddPayment.Click
        frmPaymentModuleD.ShowDialog()

    End Sub
End Class