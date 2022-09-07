<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockCard))
        Me.dgvStockCard = New System.Windows.Forms.DataGridView()
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
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbItemCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxWhs = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckGood = New System.Windows.Forms.CheckBox()
        Me.ckBO = New System.Windows.Forms.CheckBox()
        Me.tsStockCard = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.GoStockCard = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintStockCard = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbBalCase = New System.Windows.Forms.TextBox()
        Me.tbBalBags = New System.Windows.Forms.TextBox()
        Me.tbBalPieces = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblItemDescription = New System.Windows.Forms.Label()
        CType(Me.dgvStockCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tsStockCard.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvStockCard
        '
        Me.dgvStockCard.AllowUserToAddRows = False
        Me.dgvStockCard.AllowUserToResizeRows = False
        Me.dgvStockCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvStockCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStockCard.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14})
        Me.dgvStockCard.Location = New System.Drawing.Point(12, 92)
        Me.dgvStockCard.Name = "dgvStockCard"
        Me.dgvStockCard.RowHeadersVisible = False
        Me.dgvStockCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStockCard.Size = New System.Drawing.Size(1179, 503)
        Me.dgvStockCard.TabIndex = 115
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "DATE"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 58
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "TRANS"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 65
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "DOC NO"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 76
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "InCases"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 71
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "InBags"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 67
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "InPieces"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 73
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "OutCases"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 81
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "OutBags"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 77
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "OutPieces"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 83
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "BalCases"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 77
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column11.HeaderText = "BalBags"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 73
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column12.HeaderText = "BalPieces"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 79
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column13.HeaderText = "UNIT PRICE"
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 88
        '
        'Column14
        '
        Me.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column14.HeaderText = "PARTICULARS"
        Me.Column14.Name = "Column14"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Item Code :"
        '
        'tbItemCode
        '
        Me.tbItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbItemCode.Location = New System.Drawing.Point(124, 10)
        Me.tbItemCode.Name = "tbItemCode"
        Me.tbItemCode.Size = New System.Drawing.Size(123, 22)
        Me.tbItemCode.TabIndex = 116
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Warehouse :"
        '
        'cbxWhs
        '
        Me.cbxWhs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxWhs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxWhs.FormattingEnabled = True
        Me.cbxWhs.Location = New System.Drawing.Point(124, 37)
        Me.cbxWhs.Name = "cbxWhs"
        Me.cbxWhs.Size = New System.Drawing.Size(236, 21)
        Me.cbxWhs.TabIndex = 118
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Date to Start From :"
        '
        'dtpStart
        '
        Me.dtpStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStart.Location = New System.Drawing.Point(124, 63)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(93, 22)
        Me.dtpStart.TabIndex = 120
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckGood)
        Me.GroupBox1.Controls.Add(Me.ckBO)
        Me.GroupBox1.Location = New System.Drawing.Point(664, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 48)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Option"
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
        Me.ckBO.Size = New System.Drawing.Size(48, 17)
        Me.ckBO.TabIndex = 100
        Me.ckBO.Text = "B.O."
        Me.ckBO.UseVisualStyleBackColor = True
        '
        'tsStockCard
        '
        Me.tsStockCard.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsStockCard.Dock = System.Windows.Forms.DockStyle.None
        Me.tsStockCard.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsStockCard.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.GoStockCard, Me.ToolStripSeparator33, Me.PrintStockCard, Me.ToolStripSeparator34})
        Me.tsStockCard.Location = New System.Drawing.Point(1065, 9)
        Me.tsStockCard.Name = "tsStockCard"
        Me.tsStockCard.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsStockCard.Size = New System.Drawing.Size(127, 25)
        Me.tsStockCard.TabIndex = 123
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'GoStockCard
        '
        Me.GoStockCard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.GoStockCard.Image = CType(resources.GetObject("GoStockCard.Image"), System.Drawing.Image)
        Me.GoStockCard.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GoStockCard.Name = "GoStockCard"
        Me.GoStockCard.Size = New System.Drawing.Size(26, 22)
        Me.GoStockCard.Text = "&Go"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'PrintStockCard
        '
        Me.PrintStockCard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PrintStockCard.Image = CType(resources.GetObject("PrintStockCard.Image"), System.Drawing.Image)
        Me.PrintStockCard.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintStockCard.Name = "PrintStockCard"
        Me.PrintStockCard.Size = New System.Drawing.Size(80, 22)
        Me.PrintStockCard.Text = "&Print Preview"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'tbBalCase
        '
        Me.tbBalCase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbBalCase.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBalCase.Location = New System.Drawing.Point(665, 63)
        Me.tbBalCase.Name = "tbBalCase"
        Me.tbBalCase.ReadOnly = True
        Me.tbBalCase.Size = New System.Drawing.Size(72, 22)
        Me.tbBalCase.TabIndex = 124
        '
        'tbBalBags
        '
        Me.tbBalBags.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbBalBags.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBalBags.Location = New System.Drawing.Point(740, 63)
        Me.tbBalBags.Name = "tbBalBags"
        Me.tbBalBags.ReadOnly = True
        Me.tbBalBags.Size = New System.Drawing.Size(70, 22)
        Me.tbBalBags.TabIndex = 125
        '
        'tbBalPieces
        '
        Me.tbBalPieces.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbBalPieces.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBalPieces.Location = New System.Drawing.Point(812, 63)
        Me.tbBalPieces.Name = "tbBalPieces"
        Me.tbBalPieces.ReadOnly = True
        Me.tbBalPieces.Size = New System.Drawing.Size(78, 22)
        Me.tbBalPieces.TabIndex = 126
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(608, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "Balance :"
        '
        'lblItemDescription
        '
        Me.lblItemDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemDescription.Location = New System.Drawing.Point(252, 10)
        Me.lblItemDescription.Name = "lblItemDescription"
        Me.lblItemDescription.Size = New System.Drawing.Size(319, 22)
        Me.lblItemDescription.TabIndex = 128
        Me.lblItemDescription.Text = "ITEM DESCRIPTION"
        Me.lblItemDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblItemDescription.Visible = False
        '
        'frmStockCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 607)
        Me.Controls.Add(Me.lblItemDescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbBalPieces)
        Me.Controls.Add(Me.tbBalBags)
        Me.Controls.Add(Me.tbBalCase)
        Me.Controls.Add(Me.tsStockCard)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpStart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxWhs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbItemCode)
        Me.Controls.Add(Me.dgvStockCard)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockCard"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STOCK CARD"
        CType(Me.dgvStockCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tsStockCard.ResumeLayout(False)
        Me.tsStockCard.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvStockCard As System.Windows.Forms.DataGridView
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
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbItemCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxWhs As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ckGood As System.Windows.Forms.CheckBox
    Friend WithEvents ckBO As System.Windows.Forms.CheckBox
    Friend WithEvents tsStockCard As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GoStockCard As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintStockCard As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbBalCase As System.Windows.Forms.TextBox
    Friend WithEvents tbBalBags As System.Windows.Forms.TextBox
    Friend WithEvents tbBalPieces As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblItemDescription As System.Windows.Forms.Label
End Class
