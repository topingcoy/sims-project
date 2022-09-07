Public Class frmBOreturnSupplierH

    Private Sub AddBOreturn_Click(sender As Object, e As EventArgs) Handles AddBOreturn.Click
        frmBOreturnSupplierD.ShowDialog()

    End Sub

    Private Sub frmBOreturnSupplierH_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F5 Then
            AddBOreturn_Click(sender, e)

        End If
    End Sub

    Private Sub frmBOreturnSupplierH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class