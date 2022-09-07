<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangePassword))
        Me.tbRetypeNewPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNewPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbOldPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsChangePass = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveNewPass = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearPass = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsChangePass.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbRetypeNewPass
        '
        Me.tbRetypeNewPass.Location = New System.Drawing.Point(152, 72)
        Me.tbRetypeNewPass.Name = "tbRetypeNewPass"
        Me.tbRetypeNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.tbRetypeNewPass.Size = New System.Drawing.Size(300, 22)
        Me.tbRetypeNewPass.TabIndex = 34
        Me.tbRetypeNewPass.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Re-Type New Password :"
        '
        'tbNewPassword
        '
        Me.tbNewPassword.Location = New System.Drawing.Point(152, 42)
        Me.tbNewPassword.Name = "tbNewPassword"
        Me.tbNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.tbNewPassword.Size = New System.Drawing.Size(300, 22)
        Me.tbNewPassword.TabIndex = 32
        Me.tbNewPassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "New Password :"
        '
        'tbOldPassword
        '
        Me.tbOldPassword.Location = New System.Drawing.Point(152, 12)
        Me.tbOldPassword.Name = "tbOldPassword"
        Me.tbOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.tbOldPassword.Size = New System.Drawing.Size(300, 22)
        Me.tbOldPassword.TabIndex = 30
        Me.tbOldPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Old Password :"
        '
        'tsChangePass
        '
        Me.tsChangePass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsChangePass.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsChangePass.Dock = System.Windows.Forms.DockStyle.None
        Me.tsChangePass.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsChangePass.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.SaveNewPass, Me.ToolStripSeparator1, Me.ClearPass, Me.ToolStripSeparator9})
        Me.tsChangePass.Location = New System.Drawing.Point(357, 97)
        Me.tsChangePass.Name = "tsChangePass"
        Me.tsChangePass.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsChangePass.Size = New System.Drawing.Size(94, 25)
        Me.tsChangePass.TabIndex = 63
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'SaveNewPass
        '
        Me.SaveNewPass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveNewPass.Image = CType(resources.GetObject("SaveNewPass.Image"), System.Drawing.Image)
        Me.SaveNewPass.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveNewPass.Name = "SaveNewPass"
        Me.SaveNewPass.Size = New System.Drawing.Size(35, 22)
        Me.SaveNewPass.Text = "&Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ClearPass
        '
        Me.ClearPass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ClearPass.Image = CType(resources.GetObject("ClearPass.Image"), System.Drawing.Image)
        Me.ClearPass.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearPass.Name = "ClearPass"
        Me.ClearPass.Size = New System.Drawing.Size(38, 22)
        Me.ClearPass.Text = "&Clear"
        Me.ClearPass.ToolTipText = "S&ave "
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'frmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 127)
        Me.Controls.Add(Me.tsChangePass)
        Me.Controls.Add(Me.tbRetypeNewPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbNewPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbOldPassword)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangePassword"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHANGE PASSWORD"
        Me.tsChangePass.ResumeLayout(False)
        Me.tsChangePass.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbRetypeNewPass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tsChangePass As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveNewPass As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClearPass As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
