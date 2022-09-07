Imports MySql.Data.MySqlClient

Public Class frmStockInH

    Private Sub frmMiscStockInH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsStockIGo.Cursor = Cursors.Hand
        tsStockIn.Cursor = Cursors.Hand

    End Sub

    Private Sub AddStockIn_Click(sender As Object, e As EventArgs) Handles AddStockIn.Click
        frmStockInD.ShowDialog()

    End Sub
End Class