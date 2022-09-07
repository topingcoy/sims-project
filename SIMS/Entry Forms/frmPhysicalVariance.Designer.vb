<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhysicalVariance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhysicalVariance))
        Me.dgvTransferList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsPrintVariance = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdateAct = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cbxValueInventory = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbPriceType = New System.Windows.Forms.ComboBox()
        CType(Me.dgvTransferList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsPrintVariance.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTransferList
        '
        Me.dgvTransferList.AllowUserToAddRows = False
        Me.dgvTransferList.AllowUserToDeleteRows = False
        Me.dgvTransferList.AllowUserToResizeRows = False
        Me.dgvTransferList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTransferList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransferList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvTransferList.Location = New System.Drawing.Point(12, 34)
        Me.dgvTransferList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvTransferList.Name = "dgvTransferList"
        Me.dgvTransferList.ReadOnly = True
        Me.dgvTransferList.RowHeadersVisible = False
        Me.dgvTransferList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTransferList.Size = New System.Drawing.Size(588, 389)
        Me.dgvTransferList.TabIndex = 62
        '
        'Column1
        '
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 39
        '
        'Column2
        '
        Me.Column2.HeaderText = "Select"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 43
        '
        'Column3
        '
        Me.Column3.HeaderText = "TRANSNO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 80
        '
        'Column4
        '
        Me.Column4.HeaderText = "WAREHOUSE"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 280
        '
        'Column5
        '
        Me.Column5.HeaderText = "DATE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 58
        '
        'Column6
        '
        Me.Column6.HeaderText = "STATUS"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 65
        '
        'tsPrintVariance
        '
        Me.tsPrintVariance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tsPrintVariance.Dock = System.Windows.Forms.DockStyle.None
        Me.tsPrintVariance.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsPrintVariance.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.UpdateAct, Me.ToolStripSeparator2})
        Me.tsPrintVariance.Location = New System.Drawing.Point(502, 5)
        Me.tsPrintVariance.Name = "tsPrintVariance"
        Me.tsPrintVariance.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsPrintVariance.Size = New System.Drawing.Size(98, 25)
        Me.tsPrintVariance.TabIndex = 63
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'UpdateAct
        '
        Me.UpdateAct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.UpdateAct.Image = CType(resources.GetObject("UpdateAct.Image"), System.Drawing.Image)
        Me.UpdateAct.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UpdateAct.Name = "UpdateAct"
        Me.UpdateAct.Size = New System.Drawing.Size(83, 22)
        Me.UpdateAct.Text = "&Print Variance"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'cbxValueInventory
        '
        Me.cbxValueInventory.AutoSize = True
        Me.cbxValueInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxValueInventory.Location = New System.Drawing.Point(12, 12)
        Me.cbxValueInventory.Name = "cbxValueInventory"
        Me.cbxValueInventory.Size = New System.Drawing.Size(160, 17)
        Me.cbxValueInventory.TabIndex = 64
        Me.cbxValueInventory.Text = "Include Value of Inventory"
        Me.cbxValueInventory.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(178, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Price Type :"
        '
        'cbPriceType
        '
        Me.cbPriceType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbPriceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPriceType.FormattingEnabled = True
        Me.cbPriceType.Items.AddRange(New Object() {"1", "A", "B", "C"})
        Me.cbPriceType.Location = New System.Drawing.Point(245, 9)
        Me.cbPriceType.Name = "cbPriceType"
        Me.cbPriceType.Size = New System.Drawing.Size(44, 21)
        Me.cbPriceType.TabIndex = 93
        '
        'frmPhysicalVariance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 434)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbPriceType)
        Me.Controls.Add(Me.cbxValueInventory)
        Me.Controls.Add(Me.tsPrintVariance)
        Me.Controls.Add(Me.dgvTransferList)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPhysicalVariance"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRINT VARIANCE REPORT"
        CType(Me.dgvTransferList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsPrintVariance.ResumeLayout(False)
        Me.tsPrintVariance.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTransferList As System.Windows.Forms.DataGridView
    Friend WithEvents tsPrintVariance As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UpdateAct As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cbxValueInventory As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbPriceType As System.Windows.Forms.ComboBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
