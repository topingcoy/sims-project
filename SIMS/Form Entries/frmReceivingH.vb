Imports MySql.Data.MySqlClient

Public Class frmReceivingH

    Private Sub frmReceivingH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsRcvGo.Cursor = Cursors.Hand
        tsRcvList.Cursor = Cursors.Hand

    End Sub

    Private Sub tsAddRcv_Click(sender As Object, e As EventArgs) Handles tsAddRcv.Click
        frmReceivingD.ShowDialog()

    End Sub
End Class