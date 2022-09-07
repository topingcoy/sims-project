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
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxWhsCode = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkGood = New System.Windows.Forms.CheckBox()
        Me.chkBO = New System.Windows.Forms.CheckBox()
        Me.tsStockCard = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGO = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtBalCase = New System.Windows.Forms.TextBox()
        Me.txtBalBags = New System.Windows.Forms.TextBox()
        Me.txtBalPcs = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtWarehouseName = New System.Windows.Forms.TextBox()
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
        Me.dgvStockCard.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column15, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14})
        Me.dgvStockCard.Location = New System.Drawing.Point(12, 85)
        Me.dgvStockCard.Name = "dgvStockCard"
        Me.dgvStockCard.RowHeadersVisible = False
        Me.dgvStockCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStockCard.Size = New System.Drawing.Size(1172, 503)
        Me.dgvStockCard.TabIndex = 8
        '
        'Column15
        '
        Me.Column15.HeaderText = "#"
        Me.Column15.Name = "Column15"
        Me.Column15.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "DATE"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 65
        '
        'Column2
        '
        Me.Column2.HeaderText = "TRANS"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 66
        '
        'Column3
        '
        Me.Column3.HeaderText = "DOCNO"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 73
        '
        'Column4
        '
        Me.Column4.HeaderText = "InCases"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 65
        '
        'Column5
        '
        Me.Column5.HeaderText = "InBags"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 65
        '
        'Column6
        '
        Me.Column6.HeaderText = "InPcs"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 65
        '
        'Column7
        '
        Me.Column7.HeaderText = "OutCases"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 65
        '
        'Column8
        '
        Me.Column8.HeaderText = "OutBags"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 65
        '
        'Column9
        '
        Me.Column9.HeaderText = "OutPcs"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 65
        '
        'Column10
        '
        Me.Column10.HeaderText = "BalCases"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 65
        '
        'Column11
        '
        Me.Column11.HeaderText = "BalBags"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 71
        '
        'Column12
        '
        Me.Column12.HeaderText = "BalPcs"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 65
        '
        'Column13
        '
        Me.Column13.HeaderText = "UNIT PRICE"
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 89
        '
        'Column14
        '
        Me.Column14.HeaderText = "PARTICULARS"
        Me.Column14.Name = "Column14"
        Me.Column14.Width = 263
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Item Code :"
        '
        'txtItemCode
        '
        Me.txtItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemCode.Location = New System.Drawing.Point(124, 6)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(93, 22)
        Me.txtItemCode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Warehouse :"
        '
        'cbxWhsCode
        '
        Me.cbxWhsCode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxWhsCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxWhsCode.FormattingEnabled = True
        Me.cbxWhsCode.Location = New System.Drawing.Point(124, 31)
        Me.cbxWhsCode.Name = "cbxWhsCode"
        Me.cbxWhsCode.Size = New System.Drawing.Size(93, 21)
        Me.cbxWhsCode.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Date to Start From :"
        '
        'dtpStart
        '
        Me.dtpStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStart.Location = New System.Drawing.Point(124, 56)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(93, 22)
        Me.dtpStart.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkGood)
        Me.GroupBox1.Controls.Add(Me.chkBO)
        Me.GroupBox1.Location = New System.Drawing.Point(664, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 48)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Option"
        '
        'chkGood
        '
        Me.chkGood.AutoSize = True
        Me.chkGood.Location = New System.Drawing.Point(6, 21)
        Me.chkGood.Name = "chkGood"
        Me.chkGood.Size = New System.Drawing.Size(86, 17)
        Me.chkGood.TabIndex = 5
        Me.chkGood.Text = "Good Stock"
        Me.chkGood.UseVisualStyleBackColor = True
        '
        'chkBO
        '
        Me.chkBO.AutoSize = True
        Me.chkBO.Location = New System.Drawing.Point(98, 21)
        Me.chkBO.Name = "chkBO"
        Me.chkBO.Size = New System.Drawing.Size(47, 17)
        Me.chkBO.TabIndex = 6
        Me.chkBO.Text = "B.O."
        Me.chkBO.UseVisualStyleBackColor = True
        '
        'tsStockCard
        '
        Me.tsStockCard.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsStockCard.Dock = System.Windows.Forms.DockStyle.None
        Me.tsStockCard.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsStockCard.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.btnGO, Me.ToolStripSeparator33, Me.btnPrint, Me.ToolStripSeparator34})
        Me.tsStockCard.Location = New System.Drawing.Point(1058, 9)
        Me.tsStockCard.Name = "tsStockCard"
        Me.tsStockCard.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsStockCard.Size = New System.Drawing.Size(127, 25)
        Me.tsStockCard.TabIndex = 7
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'btnGO
        '
        Me.btnGO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnGO.Image = CType(resources.GetObject("btnGO.Image"), System.Drawing.Image)
        Me.btnGO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGO.Name = "btnGO"
        Me.btnGO.Size = New System.Drawing.Size(26, 22)
        Me.btnGO.Text = "&Go"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 22)
        Me.btnPrint.Text = "&Print Preview"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'txtBalCase
        '
        Me.txtBalCase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBalCase.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalCase.Location = New System.Drawing.Point(665, 57)
        Me.txtBalCase.Name = "txtBalCase"
        Me.txtBalCase.ReadOnly = True
        Me.txtBalCase.Size = New System.Drawing.Size(72, 22)
        Me.txtBalCase.TabIndex = 124
        '
        'txtBalBags
        '
        Me.txtBalBags.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBalBags.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalBags.Location = New System.Drawing.Point(740, 57)
        Me.txtBalBags.Name = "txtBalBags"
        Me.txtBalBags.ReadOnly = True
        Me.txtBalBags.Size = New System.Drawing.Size(70, 22)
        Me.txtBalBags.TabIndex = 125
        '
        'txtBalPcs
        '
        Me.txtBalPcs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBalPcs.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalPcs.Location = New System.Drawing.Point(812, 57)
        Me.txtBalPcs.Name = "txtBalPcs"
        Me.txtBalPcs.ReadOnly = True
        Me.txtBalPcs.Size = New System.Drawing.Size(78, 22)
        Me.txtBalPcs.TabIndex = 126
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(608, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "Balance :"
        '
        'txtDescription
        '
        Me.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescription.Location = New System.Drawing.Point(221, 6)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(317, 22)
        Me.txtDescription.TabIndex = 1
        '
        'txtWarehouseName
        '
        Me.txtWarehouseName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtWarehouseName.Location = New System.Drawing.Point(221, 32)
        Me.txtWarehouseName.Name = "txtWarehouseName"
        Me.txtWarehouseName.Size = New System.Drawing.Size(317, 22)
        Me.txtWarehouseName.TabIndex = 3
        '
        'frmStockCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1197, 607)
        Me.Controls.Add(Me.txtWarehouseName)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBalPcs)
        Me.Controls.Add(Me.txtBalBags)
        Me.Controls.Add(Me.txtBalCase)
        Me.Controls.Add(Me.tsStockCard)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpStart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxWhsCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtItemCode)
        Me.Controls.Add(Me.dgvStockCard)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockCard"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxWhsCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkGood As System.Windows.Forms.CheckBox
    Friend WithEvents chkBO As System.Windows.Forms.CheckBox
    Friend WithEvents tsStockCard As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGO As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtBalCase As System.Windows.Forms.TextBox
    Friend WithEvents txtBalBags As System.Windows.Forms.TextBox
    Friend WithEvents txtBalPcs As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtWarehouseName As System.Windows.Forms.TextBox
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
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
End Class
