<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerARBalance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerARBalance))
        Me.dgvARBalance = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbSelectCustomer = New System.Windows.Forms.TextBox()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.tsARBalance = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.Go = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintARBalance = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.dgvARBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsARBalance.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvARBalance
        '
        Me.dgvARBalance.AllowUserToAddRows = False
        Me.dgvARBalance.AllowUserToResizeRows = False
        Me.dgvARBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvARBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvARBalance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgvARBalance.Location = New System.Drawing.Point(13, 38)
        Me.dgvARBalance.Name = "dgvARBalance"
        Me.dgvARBalance.RowHeadersVisible = False
        Me.dgvARBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvARBalance.Size = New System.Drawing.Size(826, 403)
        Me.dgvARBalance.TabIndex = 32
        '
        'Column1
        '
        Me.Column1.HeaderText = "DATE"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "TYPE"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "DOC NO"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "P.O. NO"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "AMOUNT"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "PAID"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "BALANCE"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "COMMULATIVE"
        Me.Column8.Name = "Column8"
        '
        'tbSelectCustomer
        '
        Me.tbSelectCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSelectCustomer.Location = New System.Drawing.Point(13, 11)
        Me.tbSelectCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbSelectCustomer.MaxLength = 50
        Me.tbSelectCustomer.Name = "tbSelectCustomer"
        Me.tbSelectCustomer.Size = New System.Drawing.Size(143, 22)
        Me.tbSelectCustomer.TabIndex = 33
        '
        'lblCustomer
        '
        Me.lblCustomer.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(162, 11)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(316, 22)
        Me.lblCustomer.TabIndex = 193
        Me.lblCustomer.Text = "CUSTOMER NAME"
        Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCustomer.Visible = False
        '
        'tsARBalance
        '
        Me.tsARBalance.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsARBalance.Dock = System.Windows.Forms.DockStyle.None
        Me.tsARBalance.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsARBalance.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.Go, Me.ToolStripSeparator33, Me.PrintARBalance, Me.ToolStripSeparator34})
        Me.tsARBalance.Location = New System.Drawing.Point(711, 8)
        Me.tsARBalance.Name = "tsARBalance"
        Me.tsARBalance.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsARBalance.Size = New System.Drawing.Size(129, 25)
        Me.tsARBalance.TabIndex = 239
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'Go
        '
        Me.Go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Go.Image = CType(resources.GetObject("Go.Image"), System.Drawing.Image)
        Me.Go.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Go.Name = "Go"
        Me.Go.Size = New System.Drawing.Size(28, 22)
        Me.Go.Text = "&GO"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'PrintARBalance
        '
        Me.PrintARBalance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PrintARBalance.Image = CType(resources.GetObject("PrintARBalance.Image"), System.Drawing.Image)
        Me.PrintARBalance.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintARBalance.Name = "PrintARBalance"
        Me.PrintARBalance.Size = New System.Drawing.Size(80, 22)
        Me.PrintARBalance.Text = "Print Preview"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'frmCustomerARBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 453)
        Me.Controls.Add(Me.tsARBalance)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.tbSelectCustomer)
        Me.Controls.Add(Me.dgvARBalance)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomerARBalance"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUSTOMER A/R BALANCE"
        CType(Me.dgvARBalance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsARBalance.ResumeLayout(False)
        Me.tsARBalance.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvARBalance As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbSelectCustomer As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents tsARBalance As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Go As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintARBalance As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
End Class
