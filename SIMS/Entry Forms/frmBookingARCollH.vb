Imports MySql.Data.MySqlClient

Public Class frmBookingARCollH

    Private Sub frmPaymentModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tsAddPayment_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmBookingARCollD.ShowDialog()

    End Sub
End Class