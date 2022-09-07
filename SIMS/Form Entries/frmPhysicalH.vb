
Public Class frmPhysicalH

    Private Sub AddTransfer_Click(sender As Object, e As EventArgs) Handles AddTransfer.Click
        frmPhysicalD.ShowDialog()
    End Sub

    Private Sub frmPhysicalH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsTransfer.Cursor = Cursors.Hand
        tsTransGo.Cursor = Cursors.Hand

    End Sub
End Class