<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerateInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenerateInventory))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpInventory = New System.Windows.Forms.DateTimePicker()
        Me.cbxWhs = New System.Windows.Forms.ComboBox()
        Me.ckGood = New System.Windows.Forms.CheckBox()
        Me.ckBO = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbBrand = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbPriceType = New System.Windows.Forms.ComboBox()
        Me.dgvInventoryItem = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsGenerateInventory = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.GoGenerate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintPreview = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbGStoBOTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvInventoryItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsGenerateInventory.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Warehouse :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Inventory as of :"
        '
        'dtpInventory
        '
        Me.dtpInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpInventory.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInventory.Location = New System.Drawing.Point(106, 12)
        Me.dtpInventory.Name = "dtpInventory"
        Me.dtpInventory.Size = New System.Drawing.Size(93, 22)
        Me.dtpInventory.TabIndex = 96
        '
        'cbxWhs
        '
        Me.cbxWhs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxWhs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxWhs.FormattingEnabled = True
        Me.cbxWhs.Location = New System.Drawing.Point(106, 40)
        Me.cbxWhs.Name = "cbxWhs"
        Me.cbxWhs.Size = New System.Drawing.Size(305, 21)
        Me.cbxWhs.TabIndex = 95
        '
        'ckGood
        '
        Me.ckGood.AutoSize = True
        Me.ckGood.Location = New System.Drawing.Point(6, 21)
        Me.ckGood.Name = "ckGood"
        Me.ckGood.Size = New System.Drawing.Size(86, 17)
        Me.ckGood.TabIndex = 99
        Me.ckGood.Text = "Good Stock"
        Me.ckGood.UseVisualStyleBackColor = True
        '
        'ckBO
        '
        Me.ckBO.AutoSize = True
        Me.ckBO.Location = New System.Drawing.Point(98, 21)
        Me.ckBO.Name = "ckBO"
        Me.ckBO.Size = New System.Drawing.Size(47, 17)
        Me.ckBO.TabIndex = 100
        Me.ckBO.Text = "B.O."
        Me.ckBO.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckGood)
        Me.GroupBox1.Controls.Add(Me.ckBO)
        Me.GroupBox1.Location = New System.Drawing.Point(256, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 48)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Option"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cbBrand)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cbCategory)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cbSupplier)
        Me.GroupBox2.Location = New System.Drawing.Point(437, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 105)
        Me.GroupBox2.TabIndex = 102
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Brand :"
        '
        'cbBrand
        '
        Me.cbBrand.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBrand.FormattingEnabled = True
        Me.cbBrand.Location = New System.Drawing.Point(75, 74)
        Me.cbBrand.Name = "cbBrand"
        Me.cbBrand.Size = New System.Drawing.Size(305, 21)
        Me.cbBrand.TabIndex = 103
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "Category :"
        '
        'cbCategory
        '
        Me.cbCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Location = New System.Drawing.Point(75, 48)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(305, 21)
        Me.cbCategory.TabIndex = 101
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Supplier :"
        '
        'cbSupplier
        '
        Me.cbSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSupplier.FormattingEnabled = True
        Me.cbSupplier.Location = New System.Drawing.Point(75, 21)
        Me.cbSupplier.Name = "cbSupplier"
        Me.cbSupplier.Size = New System.Drawing.Size(305, 21)
        Me.cbSupplier.TabIndex = 99
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "Price Type :"
        '
        'cbPriceType
        '
        Me.cbPriceType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbPriceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPriceType.FormattingEnabled = True
        Me.cbPriceType.Items.AddRange(New Object() {"1", "A", "B", "C"})
        Me.cbPriceType.Location = New System.Drawing.Point(106, 66)
        Me.cbPriceType.Name = "cbPriceType"
        Me.cbPriceType.Size = New System.Drawing.Size(44, 21)
        Me.cbPriceType.TabIndex = 111
        '
        'dgvInventoryItem
        '
        Me.dgvInventoryItem.AllowUserToAddRows = False
        Me.dgvInventoryItem.AllowUserToResizeRows = False
        Me.dgvInventoryItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvInventoryItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventoryItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgvInventoryItem.Location = New System.Drawing.Point(16, 125)
        Me.dgvInventoryItem.Name = "dgvInventoryItem"
        Me.dgvInventoryItem.RowHeadersVisible = False
        Me.dgvInventoryItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventoryItem.Size = New System.Drawing.Size(970, 454)
        Me.dgvInventoryItem.TabIndex = 114
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 39
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "ITEMCODE"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 87
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "ITEM DESCRIPTION"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "CASES"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 64
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "BAGS"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 59
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "PIECES"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 66
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "PCKG"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 59
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "CATEGORY"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 86
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "AMOUNT"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 80
        '
        'tsGenerateInventory
        '
        Me.tsGenerateInventory.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsGenerateInventory.Dock = System.Windows.Forms.DockStyle.None
        Me.tsGenerateInventory.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsGenerateInventory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.GoGenerate, Me.ToolStripSeparator33, Me.PrintPreview, Me.ToolStripSeparator34})
        Me.tsGenerateInventory.Location = New System.Drawing.Point(859, 16)
        Me.tsGenerateInventory.Name = "tsGenerateInventory"
        Me.tsGenerateInventory.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsGenerateInventory.Size = New System.Drawing.Size(158, 25)
        Me.tsGenerateInventory.TabIndex = 115
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'GoGenerate
        '
        Me.GoGenerate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.GoGenerate.Image = CType(resources.GetObject("GoGenerate.Image"), System.Drawing.Image)
        Me.GoGenerate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GoGenerate.Name = "GoGenerate"
        Me.GoGenerate.Size = New System.Drawing.Size(26, 22)
        Me.GoGenerate.Text = "&Go"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'PrintPreview
        '
        Me.PrintPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PrintPreview.Image = CType(resources.GetObject("PrintPreview.Image"), System.Drawing.Image)
        Me.PrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreview.Name = "PrintPreview"
        Me.PrintPreview.Size = New System.Drawing.Size(80, 22)
        Me.PrintPreview.Text = "&Print Preview"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(738, 590)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "TOTAL AMOUNT:"
        '
        'tbGStoBOTotal
        '
        Me.tbGStoBOTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbGStoBOTotal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGStoBOTotal.Location = New System.Drawing.Point(840, 585)
        Me.tbGStoBOTotal.MaxLength = 50
        Me.tbGStoBOTotal.Name = "tbGStoBOTotal"
        Me.tbGStoBOTotal.ReadOnly = True
        Me.tbGStoBOTotal.Size = New System.Drawing.Size(146, 22)
        Me.tbGStoBOTotal.TabIndex = 121
        '
        'frmGenerateInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 616)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbGStoBOTotal)
        Me.Controls.Add(Me.tsGenerateInventory)
        Me.Controls.Add(Me.dgvInventoryItem)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbPriceType)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpInventory)
        Me.Controls.Add(Me.cbxWhs)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGenerateInventory"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GENERATE WAREHOUSE INVENTORY"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvInventoryItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsGenerateInventory.ResumeLayout(False)
        Me.tsGenerateInventory.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpInventory As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbxWhs As System.Windows.Forms.ComboBox
    Friend WithEvents ckGood As System.Windows.Forms.CheckBox
    Friend WithEvents ckBO As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbBrand As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbPriceType As System.Windows.Forms.ComboBox
    Friend WithEvents dgvInventoryItem As System.Windows.Forms.DataGridView
    Friend WithEvents tsGenerateInventory As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GoGenerate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintPreview As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbGStoBOTotal As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
