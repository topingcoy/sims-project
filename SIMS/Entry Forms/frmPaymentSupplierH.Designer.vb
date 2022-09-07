<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentSupplierH
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentSupplierH))
        Me.dgvPaymentSupplier = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsPaymentSupplier = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddPayment = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditPayment = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeletePayment = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        CType(Me.dgvPaymentSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsPaymentSupplier.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPaymentSupplier
        '
        Me.dgvPaymentSupplier.AllowUserToAddRows = False
        Me.dgvPaymentSupplier.AllowUserToDeleteRows = False
        Me.dgvPaymentSupplier.AllowUserToResizeRows = False
        Me.dgvPaymentSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPaymentSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaymentSupplier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column6, Me.Column9})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPaymentSupplier.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPaymentSupplier.Location = New System.Drawing.Point(12, 33)
        Me.dgvPaymentSupplier.Name = "dgvPaymentSupplier"
        Me.dgvPaymentSupplier.ReadOnly = True
        Me.dgvPaymentSupplier.RowHeadersVisible = False
        Me.dgvPaymentSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPaymentSupplier.Size = New System.Drawing.Size(617, 386)
        Me.dgvPaymentSupplier.TabIndex = 42
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 39
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "TRANS NO."
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 92
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "DATE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 59
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "VOUCHER NO."
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column6.HeaderText = "AMOUNT"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 83
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "ADDED BY"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 87
        '
        'tsPaymentSupplier
        '
        Me.tsPaymentSupplier.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsPaymentSupplier.Dock = System.Windows.Forms.DockStyle.None
        Me.tsPaymentSupplier.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsPaymentSupplier.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.AddPayment, Me.ToolStripSeparator33, Me.EditPayment, Me.ToolStripSeparator3, Me.DeletePayment, Me.ToolStripSeparator4})
        Me.tsPaymentSupplier.Location = New System.Drawing.Point(188, 424)
        Me.tsPaymentSupplier.Name = "tsPaymentSupplier"
        Me.tsPaymentSupplier.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsPaymentSupplier.Size = New System.Drawing.Size(260, 25)
        Me.tsPaymentSupplier.TabIndex = 109
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'AddPayment
        '
        Me.AddPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AddPayment.Image = CType(resources.GetObject("AddPayment.Image"), System.Drawing.Image)
        Me.AddPayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddPayment.Name = "AddPayment"
        Me.AddPayment.Size = New System.Drawing.Size(66, 22)
        Me.AddPayment.Text = "[F5] - ADD"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'EditPayment
        '
        Me.EditPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditPayment.Image = CType(resources.GetObject("EditPayment.Image"), System.Drawing.Image)
        Me.EditPayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditPayment.Name = "EditPayment"
        Me.EditPayment.Size = New System.Drawing.Size(87, 22)
        Me.EditPayment.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'DeletePayment
        '
        Me.DeletePayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DeletePayment.Image = CType(resources.GetObject("DeletePayment.Image"), System.Drawing.Image)
        Me.DeletePayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeletePayment.Name = "DeletePayment"
        Me.DeletePayment.Size = New System.Drawing.Size(80, 22)
        Me.DeletePayment.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tbSearch
        '
        Me.tbSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSearch.Location = New System.Drawing.Point(12, 6)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(192, 23)
        Me.tbSearch.TabIndex = 110
        '
        'frmPaymentSupplierH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 457)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.tsPaymentSupplier)
        Me.Controls.Add(Me.dgvPaymentSupplier)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPaymentSupplierH"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENTER PAYMENT TO SUPPLIER"
        CType(Me.dgvPaymentSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsPaymentSupplier.ResumeLayout(False)
        Me.tsPaymentSupplier.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPaymentSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents tsPaymentSupplier As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddPayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditPayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeletePayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbSearch As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
