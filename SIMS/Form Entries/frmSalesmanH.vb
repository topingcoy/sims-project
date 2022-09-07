Imports MySql.Data.MySqlClient

Public Class frmSalesmanH

    Private Sub frmSalesmanH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsSalesman.Cursor = Cursors.Hand
        gbxAddSalesmn.Cursor = Cursors.Hand


    End Sub

    Private Sub tsaddsalesman_Click(sender As Object, e As EventArgs) Handles tsaddsalesman.Click
        gbxSalesman.Visible = True
    End Sub
End Class