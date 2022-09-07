Imports MySql.Data.MySqlClient

Public Class frmItemH

    Private Sub tsadditem_Click(sender As Object, e As EventArgs) Handles tsadditem.Click
        frmItemD.ShowDialog()

    End Sub

    Private Sub frmItemH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsitem.Cursor = Cursors.Hand
    End Sub
End Class