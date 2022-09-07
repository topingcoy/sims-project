Public Class frmReport

    Private Sub frmReport_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        With frmExpressCollD
            .iClear()
            '.txtCustCode.Focus()
            .tsUpdate.SendToBack()
            .tsUpdate.Visible = False
            .tsSave.BringToFront()
            .tsSave.Visible = True
        End With
        Me.Dispose()
    End Sub

    Private Sub frmReport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' frmExpressCollD.
    End Sub

    Private Sub frmReport_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            btnClose_Click(sender, e)
        End If
    End Sub

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)

        Me.Dispose()

    End Sub
End Class