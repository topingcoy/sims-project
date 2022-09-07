Imports MySql.Data.MySqlClient

Public Class frmStockOutH

    Private Sub frmStockOutH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsStockOGo.Cursor = Cursors.Hand
        tsStockOut.Cursor = Cursors.Hand

    End Sub

    Private Sub AddStockOut_Click(sender As Object, e As EventArgs) Handles AddStockOut.Click
        frmStockOutD.ShowDialog()

    End Sub
End Class