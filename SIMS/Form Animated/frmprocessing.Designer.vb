<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmprogress
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmprogress))
        Me.pn_bar = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pgloading = New System.Windows.Forms.PictureBox()
        Me.lblcount = New System.Windows.Forms.Label()
        Me.pn_bar.SuspendLayout()
        CType(Me.pgloading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pn_bar
        '
        Me.pn_bar.Controls.Add(Me.Label6)
        Me.pn_bar.Controls.Add(Me.pgloading)
        Me.pn_bar.Controls.Add(Me.lblcount)
        Me.pn_bar.Location = New System.Drawing.Point(12, 12)
        Me.pn_bar.Name = "pn_bar"
        Me.pn_bar.Size = New System.Drawing.Size(337, 85)
        Me.pn_bar.TabIndex = 145
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(63, 24)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(226, 19)
        Me.Label6.TabIndex = 132
        Me.Label6.Text = "Please Wait. . ."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pgloading
        '
        Me.pgloading.Image = CType(resources.GetObject("pgloading.Image"), System.Drawing.Image)
        Me.pgloading.Location = New System.Drawing.Point(86, 43)
        Me.pgloading.Name = "pgloading"
        Me.pgloading.Size = New System.Drawing.Size(191, 10)
        Me.pgloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pgloading.TabIndex = 489
        Me.pgloading.TabStop = False
        '
        'lblcount
        '
        Me.lblcount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcount.Location = New System.Drawing.Point(179, 24)
        Me.lblcount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(110, 19)
        Me.lblcount.TabIndex = 133
        Me.lblcount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblcount.Visible = False
        '
        'frmprogress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 112)
        Me.ControlBox = False
        Me.Controls.Add(Me.pn_bar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmprogress"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Please wait processing request..."
        Me.pn_bar.ResumeLayout(False)
        CType(Me.pgloading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pn_bar As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pgloading As System.Windows.Forms.PictureBox
    Friend WithEvents lblcount As System.Windows.Forms.Label
End Class
