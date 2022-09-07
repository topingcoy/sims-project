Public Class frmprogress

    Private Sub frmprogress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.Tag = 1 Then
            frmStockCard.start_thread(Me.Tag)
        End If
    End Sub
End Class