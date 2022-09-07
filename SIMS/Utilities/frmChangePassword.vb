Public Class frmChangePassword

    Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbOldPassword.PasswordChar = Chr(149)
        tbNewPassword.PasswordChar = Chr(149)
        tbRetypeNewPass.PasswordChar = Chr(149)
    End Sub
End Class