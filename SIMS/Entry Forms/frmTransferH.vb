Imports MySql.Data.MySqlClient

Public Class frmTransferH

    Private Sub frmTransferH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsTransfer.Cursor = Cursors.Hand
        tsTransGo.Cursor = Cursors.Hand

    End Sub

    Private Sub AddTransfer_Click(sender As Object, e As EventArgs) Handles AddTransfer.Click
        frmTransferD.ShowDialog()

    End Sub
End Class