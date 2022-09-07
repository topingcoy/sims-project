Public Class frmGStoBOH

    Private Sub AddStockIn_Click(sender As Object, e As EventArgs) Handles AddStockIn.Click
        frmGStoBOD.ShowDialog()

    End Sub

    Private Sub frmGStoBOH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsGStoBO.Cursor = Cursors.Hand
        tsStockIGo.Cursor = Cursors.Hand
    End Sub
End Class