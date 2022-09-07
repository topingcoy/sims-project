<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerARLedger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerARLedger))
        Me.dgvARLedger = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.tbSelectCustomer = New System.Windows.Forms.TextBox()
        Me.tsARLedger = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.Go = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintARLedger = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.dgvARLedger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsARLedger.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvARLedger
        '
        Me.dgvARLedger.AllowUserToAddRows = False
        Me.dgvARLedger.AllowUserToResizeRows = False
        Me.dgvARLedger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvARLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvARLedger.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        Me.dgvARLedger.Location = New System.Drawing.Point(13, 38)
        Me.dgvARLedger.Name = "dgvARLedger"
        Me.dgvARLedger.RowHeadersVisible = False
        Me.dgvARLedger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvARLedger.Size = New System.Drawing.Size(1053, 487)
        Me.dgvARLedger.TabIndex = 33
        '
        'Column1
        '
        Me.Column1.HeaderText = "DATE"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 75
        '
        'Column2
        '
        Me.Column2.HeaderText = "TRANS"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 75
        '
        'Column3
        '
        Me.Column3.HeaderText = "DOC NO"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 80
        '
        'Column4
        '
        Me.Column4.HeaderText = "P.O. NO"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 85
        '
        'Column5
        '
        Me.Column5.HeaderText = "DEBIT"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 85
        '
        'Column6
        '
        Me.Column6.HeaderText = "CREDIT"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 85
        '
        'Column7
        '
        Me.Column7.HeaderText = "A/R BALANCE"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "BANK"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 85
        '
        'Column9
        '
        Me.Column9.HeaderText = "CHECK #"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 85
        '
        'Column10
        '
        Me.Column10.HeaderText = "CHECK DATE"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "CHECK AMT"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "TERMS"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 75
        '
        'lblCustomer
        '
        Me.lblCustomer.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(162, 11)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(316, 22)
        Me.lblCustomer.TabIndex = 195
        Me.lblCustomer.Text = "CUSTOMER NAME"
        Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCustomer.Visible = False
        '
        'tbSelectCustomer
        '
        Me.tbSelectCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSelectCustomer.Location = New System.Drawing.Point(13, 11)
        Me.tbSelectCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbSelectCustomer.MaxLength = 50
        Me.tbSelectCustomer.Name = "tbSelectCustomer"
        Me.tbSelectCustomer.Size = New System.Drawing.Size(143, 22)
        Me.tbSelectCustomer.TabIndex = 194
        '
        'tsARLedger
        '
        Me.tsARLedger.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsARLedger.Dock = System.Windows.Forms.DockStyle.None
        Me.tsARLedger.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsARLedger.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.Go, Me.ToolStripSeparator33, Me.PrintARLedger, Me.ToolStripSeparator34})
        Me.tsARLedger.Location = New System.Drawing.Point(936, 8)
        Me.tsARLedger.Name = "tsARLedger"
        Me.tsARLedger.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsARLedger.Size = New System.Drawing.Size(129, 25)
        Me.tsARLedger.TabIndex = 240
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
        'PrintARLedger
        '
        Me.PrintARLedger.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PrintARLedger.Image = CType(resources.GetObject("PrintARLedger.Image"), System.Drawing.Image)
        Me.PrintARLedger.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintARLedger.Name = "PrintARLedger"
        Me.PrintARLedger.Size = New System.Drawing.Size(80, 22)
        Me.PrintARLedger.Text = "Print Preview"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'frmCustomerARLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 537)
        Me.Controls.Add(Me.tsARLedger)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.tbSelectCustomer)
        Me.Controls.Add(Me.dgvARLedger)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomerARLedger"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUSTOMER A/R LEDGER"
        CType(Me.dgvARLedger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsARLedger.ResumeLayout(False)
        Me.tsARLedger.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvARLedger As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents tbSelectCustomer As System.Windows.Forms.TextBox
    Friend WithEvents tsARLedger As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Go As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintARLedger As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
End Class
