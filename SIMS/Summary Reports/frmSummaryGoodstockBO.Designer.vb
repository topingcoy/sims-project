<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummaryGoodstockBO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSummaryGoodstockBO))
        Me.tbTotalCases = New System.Windows.Forms.TextBox()
        Me.tbTotalAmount = New System.Windows.Forms.TextBox()
        Me.tbTotalPcs = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbxPriceType = New System.Windows.Forms.ComboBox()
        Me.tbTotalBags = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbTitle3 = New System.Windows.Forms.TextBox()
        Me.dtpEndCol3 = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartCol3 = New System.Windows.Forms.DateTimePicker()
        Me.tbTitle2 = New System.Windows.Forms.TextBox()
        Me.dtpEndCol2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartCol2 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbTitle1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpEndCol1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartCol1 = New System.Windows.Forms.DateTimePicker()
        Me.tbCategory = New System.Windows.Forms.TextBox()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.tbItem = New System.Windows.Forms.TextBox()
        Me.lblOutletType = New System.Windows.Forms.Label()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PrintSummaryReceiving = New System.Windows.Forms.ToolStripButton()
        Me.tbWhs = New System.Windows.Forms.TextBox()
        Me.lblAreaT = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbBrand = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAreaTerritory = New System.Windows.Forms.Label()
        Me.tbSupplier = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblWhs = New System.Windows.Forms.Label()
        Me.Go = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsSummaryGoodstockBO = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgvSummaryGoodstockBO = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.tsSummaryGoodstockBO.SuspendLayout()
        CType(Me.dgvSummaryGoodstockBO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbTotalCases
        '
        Me.tbTotalCases.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTotalCases.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbTotalCases.Location = New System.Drawing.Point(639, 523)
        Me.tbTotalCases.MaxLength = 20
        Me.tbTotalCases.Name = "tbTotalCases"
        Me.tbTotalCases.ReadOnly = True
        Me.tbTotalCases.Size = New System.Drawing.Size(78, 22)
        Me.tbTotalCases.TabIndex = 285
        '
        'tbTotalAmount
        '
        Me.tbTotalAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTotalAmount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbTotalAmount.Location = New System.Drawing.Point(915, 523)
        Me.tbTotalAmount.MaxLength = 20
        Me.tbTotalAmount.Name = "tbTotalAmount"
        Me.tbTotalAmount.ReadOnly = True
        Me.tbTotalAmount.Size = New System.Drawing.Size(102, 22)
        Me.tbTotalAmount.TabIndex = 283
        '
        'tbTotalPcs
        '
        Me.tbTotalPcs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTotalPcs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbTotalPcs.Location = New System.Drawing.Point(807, 523)
        Me.tbTotalPcs.MaxLength = 20
        Me.tbTotalPcs.Name = "tbTotalPcs"
        Me.tbTotalPcs.ReadOnly = True
        Me.tbTotalPcs.Size = New System.Drawing.Size(78, 22)
        Me.tbTotalPcs.TabIndex = 282
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(589, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 281
        Me.Label14.Text = "Price Type :"
        '
        'cbxPriceType
        '
        Me.cbxPriceType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxPriceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPriceType.FormattingEnabled = True
        Me.cbxPriceType.Items.AddRange(New Object() {"1", "A", "B", "C"})
        Me.cbxPriceType.Location = New System.Drawing.Point(656, 17)
        Me.cbxPriceType.Name = "cbxPriceType"
        Me.cbxPriceType.Size = New System.Drawing.Size(44, 21)
        Me.cbxPriceType.TabIndex = 280
        '
        'tbTotalBags
        '
        Me.tbTotalBags.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTotalBags.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbTotalBags.Location = New System.Drawing.Point(723, 523)
        Me.tbTotalBags.MaxLength = 20
        Me.tbTotalBags.Name = "tbTotalBags"
        Me.tbTotalBags.ReadOnly = True
        Me.tbTotalBags.Size = New System.Drawing.Size(78, 22)
        Me.tbTotalBags.TabIndex = 284
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbTitle3)
        Me.GroupBox2.Controls.Add(Me.dtpEndCol3)
        Me.GroupBox2.Controls.Add(Me.dtpStartCol3)
        Me.GroupBox2.Controls.Add(Me.tbTitle2)
        Me.GroupBox2.Controls.Add(Me.dtpEndCol2)
        Me.GroupBox2.Controls.Add(Me.dtpStartCol2)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.tbTitle1)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dtpEndCol1)
        Me.GroupBox2.Controls.Add(Me.dtpStartCol1)
        Me.GroupBox2.Location = New System.Drawing.Point(590, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(447, 125)
        Me.GroupBox2.TabIndex = 277
        Me.GroupBox2.TabStop = False
        '
        'tbTitle3
        '
        Me.tbTitle3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTitle3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbTitle3.Location = New System.Drawing.Point(308, 96)
        Me.tbTitle3.MaxLength = 20
        Me.tbTitle3.Name = "tbTitle3"
        Me.tbTitle3.Size = New System.Drawing.Size(123, 22)
        Me.tbTitle3.TabIndex = 260
        '
        'dtpEndCol3
        '
        Me.dtpEndCol3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpEndCol3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndCol3.Location = New System.Drawing.Point(198, 97)
        Me.dtpEndCol3.Name = "dtpEndCol3"
        Me.dtpEndCol3.Size = New System.Drawing.Size(93, 22)
        Me.dtpEndCol3.TabIndex = 259
        '
        'dtpStartCol3
        '
        Me.dtpStartCol3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpStartCol3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartCol3.Location = New System.Drawing.Point(89, 97)
        Me.dtpStartCol3.Name = "dtpStartCol3"
        Me.dtpStartCol3.Size = New System.Drawing.Size(93, 22)
        Me.dtpStartCol3.TabIndex = 258
        '
        'tbTitle2
        '
        Me.tbTitle2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTitle2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbTitle2.Location = New System.Drawing.Point(308, 68)
        Me.tbTitle2.MaxLength = 20
        Me.tbTitle2.Name = "tbTitle2"
        Me.tbTitle2.Size = New System.Drawing.Size(123, 22)
        Me.tbTitle2.TabIndex = 257
        '
        'dtpEndCol2
        '
        Me.dtpEndCol2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpEndCol2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndCol2.Location = New System.Drawing.Point(198, 69)
        Me.dtpEndCol2.Name = "dtpEndCol2"
        Me.dtpEndCol2.Size = New System.Drawing.Size(93, 22)
        Me.dtpEndCol2.TabIndex = 256
        '
        'dtpStartCol2
        '
        Me.dtpStartCol2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpStartCol2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartCol2.Location = New System.Drawing.Point(89, 69)
        Me.dtpStartCol2.Name = "dtpStartCol2"
        Me.dtpStartCol2.Size = New System.Drawing.Size(93, 22)
        Me.dtpStartCol2.TabIndex = 255
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 254
        Me.Label13.Text = "Column 3"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 253
        Me.Label12.Text = "Column 2"
        '
        'tbTitle1
        '
        Me.tbTitle1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTitle1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbTitle1.Location = New System.Drawing.Point(308, 40)
        Me.tbTitle1.MaxLength = 20
        Me.tbTitle1.Name = "tbTitle1"
        Me.tbTitle1.Size = New System.Drawing.Size(123, 22)
        Me.tbTitle1.TabIndex = 252
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(329, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 13)
        Me.Label11.TabIndex = 251
        Me.Label11.Text = "COLUMN TITLE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(211, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 250
        Me.Label10.Text = "END DATE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(96, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 249
        Me.Label9.Text = "START DATE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 248
        Me.Label3.Text = "COLUMN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 247
        Me.Label2.Text = "Column 1"
        '
        'dtpEndCol1
        '
        Me.dtpEndCol1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpEndCol1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndCol1.Location = New System.Drawing.Point(198, 41)
        Me.dtpEndCol1.Name = "dtpEndCol1"
        Me.dtpEndCol1.Size = New System.Drawing.Size(93, 22)
        Me.dtpEndCol1.TabIndex = 246
        '
        'dtpStartCol1
        '
        Me.dtpStartCol1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpStartCol1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartCol1.Location = New System.Drawing.Point(89, 41)
        Me.dtpStartCol1.Name = "dtpStartCol1"
        Me.dtpStartCol1.Size = New System.Drawing.Size(93, 22)
        Me.dtpStartCol1.TabIndex = 245
        '
        'tbCategory
        '
        Me.tbCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbCategory.Location = New System.Drawing.Point(152, 64)
        Me.tbCategory.MaxLength = 15
        Me.tbCategory.Name = "tbCategory"
        Me.tbCategory.Size = New System.Drawing.Size(92, 22)
        Me.tbCategory.TabIndex = 201
        '
        'lblCustomer
        '
        Me.lblCustomer.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(251, 89)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(272, 22)
        Me.lblCustomer.TabIndex = 200
        Me.lblCustomer.Text = "BRAND NAME"
        Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCustomer.Visible = False
        '
        'tbItem
        '
        Me.tbItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbItem.Location = New System.Drawing.Point(152, 114)
        Me.tbItem.MaxLength = 15
        Me.tbItem.Name = "tbItem"
        Me.tbItem.Size = New System.Drawing.Size(92, 22)
        Me.tbItem.TabIndex = 204
        '
        'lblOutletType
        '
        Me.lblOutletType.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutletType.Location = New System.Drawing.Point(251, 114)
        Me.lblOutletType.Name = "lblOutletType"
        Me.lblOutletType.Size = New System.Drawing.Size(272, 22)
        Me.lblOutletType.TabIndex = 206
        Me.lblOutletType.Text = "ITEM DESCRIPTION"
        Me.lblOutletType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblOutletType.Visible = False
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 205
        Me.Label6.Text = "Item [Blank = All] :"
        '
        'PrintSummaryReceiving
        '
        Me.PrintSummaryReceiving.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PrintSummaryReceiving.Image = CType(resources.GetObject("PrintSummaryReceiving.Image"), System.Drawing.Image)
        Me.PrintSummaryReceiving.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintSummaryReceiving.Name = "PrintSummaryReceiving"
        Me.PrintSummaryReceiving.Size = New System.Drawing.Size(80, 22)
        Me.PrintSummaryReceiving.Text = "Print Preview"
        '
        'tbWhs
        '
        Me.tbWhs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbWhs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbWhs.Location = New System.Drawing.Point(152, 39)
        Me.tbWhs.MaxLength = 15
        Me.tbWhs.Name = "tbWhs"
        Me.tbWhs.Size = New System.Drawing.Size(92, 22)
        Me.tbWhs.TabIndex = 196
        '
        'lblAreaT
        '
        Me.lblAreaT.AutoSize = True
        Me.lblAreaT.Location = New System.Drawing.Point(24, 68)
        Me.lblAreaT.Name = "lblAreaT"
        Me.lblAreaT.Size = New System.Drawing.Size(123, 13)
        Me.lblAreaT.TabIndex = 202
        Me.lblAreaT.Text = "Category [Blank = All] :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 13)
        Me.Label8.TabIndex = 209
        Me.Label8.Text = "Supplier [Blank = All] :"
        '
        'tbBrand
        '
        Me.tbBrand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbBrand.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbBrand.Location = New System.Drawing.Point(152, 89)
        Me.tbBrand.MaxLength = 15
        Me.tbBrand.Name = "tbBrand"
        Me.tbBrand.Size = New System.Drawing.Size(92, 22)
        Me.tbBrand.TabIndex = 199
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 13)
        Me.Label5.TabIndex = 197
        Me.Label5.Text = "Warehouse [Blank = All] :"
        '
        'lblAreaTerritory
        '
        Me.lblAreaTerritory.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreaTerritory.Location = New System.Drawing.Point(251, 64)
        Me.lblAreaTerritory.Name = "lblAreaTerritory"
        Me.lblAreaTerritory.Size = New System.Drawing.Size(272, 22)
        Me.lblAreaTerritory.TabIndex = 203
        Me.lblAreaTerritory.Text = "CATEGORY"
        Me.lblAreaTerritory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAreaTerritory.Visible = False
        '
        'tbSupplier
        '
        Me.tbSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSupplier.Location = New System.Drawing.Point(152, 14)
        Me.tbSupplier.MaxLength = 15
        Me.tbSupplier.Name = "tbSupplier"
        Me.tbSupplier.Size = New System.Drawing.Size(92, 22)
        Me.tbSupplier.TabIndex = 208
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 207
        Me.Label7.Text = "Brand [Blank = All] :"
        '
        'lblWhs
        '
        Me.lblWhs.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhs.Location = New System.Drawing.Point(251, 39)
        Me.lblWhs.Name = "lblWhs"
        Me.lblWhs.Size = New System.Drawing.Size(272, 22)
        Me.lblWhs.TabIndex = 198
        Me.lblWhs.Text = "WAREHOUSE NAME"
        Me.lblWhs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblWhs.Visible = False
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
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'tsSummaryGoodstockBO
        '
        Me.tsSummaryGoodstockBO.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsSummaryGoodstockBO.Dock = System.Windows.Forms.DockStyle.None
        Me.tsSummaryGoodstockBO.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsSummaryGoodstockBO.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.Go, Me.ToolStripSeparator33, Me.PrintSummaryReceiving, Me.ToolStripSeparator34})
        Me.tsSummaryGoodstockBO.Location = New System.Drawing.Point(908, 6)
        Me.tsSummaryGoodstockBO.Name = "tsSummaryGoodstockBO"
        Me.tsSummaryGoodstockBO.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsSummaryGoodstockBO.Size = New System.Drawing.Size(129, 25)
        Me.tsSummaryGoodstockBO.TabIndex = 278
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'dgvSummaryGoodstockBO
        '
        Me.dgvSummaryGoodstockBO.AllowUserToAddRows = False
        Me.dgvSummaryGoodstockBO.AllowUserToResizeRows = False
        Me.dgvSummaryGoodstockBO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSummaryGoodstockBO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSummaryGoodstockBO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgvSummaryGoodstockBO.Location = New System.Drawing.Point(13, 165)
        Me.dgvSummaryGoodstockBO.Name = "dgvSummaryGoodstockBO"
        Me.dgvSummaryGoodstockBO.RowHeadersVisible = False
        Me.dgvSummaryGoodstockBO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSummaryGoodstockBO.Size = New System.Drawing.Size(1024, 352)
        Me.dgvSummaryGoodstockBO.TabIndex = 279
        '
        'Column1
        '
        Me.Column1.HeaderText = "ITEM DESCRIPTION"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 350
        '
        'Column2
        '
        Me.Column2.HeaderText = "SUPPLIER"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "CATEGORY"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "CASES"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "BAGS"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "PIECES"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "AMOUNT"
        Me.Column7.Name = "Column7"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbCategory)
        Me.GroupBox1.Controls.Add(Me.lblCustomer)
        Me.GroupBox1.Controls.Add(Me.tbItem)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblOutletType)
        Me.GroupBox1.Controls.Add(Me.tbWhs)
        Me.GroupBox1.Controls.Add(Me.lblAreaT)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbBrand)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblAreaTerritory)
        Me.GroupBox1.Controls.Add(Me.tbSupplier)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblWhs)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(539, 144)
        Me.GroupBox1.TabIndex = 276
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(251, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 22)
        Me.Label4.TabIndex = 210
        Me.Label4.Text = "SUPPLIER NAME"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'frmSummaryGoodstockBO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 551)
        Me.Controls.Add(Me.tbTotalCases)
        Me.Controls.Add(Me.tbTotalAmount)
        Me.Controls.Add(Me.tbTotalPcs)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbxPriceType)
        Me.Controls.Add(Me.tbTotalBags)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.tsSummaryGoodstockBO)
        Me.Controls.Add(Me.dgvSummaryGoodstockBO)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSummaryGoodstockBO"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUMMARY OF GOODSTOCK CONVERTED TO B.O."
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tsSummaryGoodstockBO.ResumeLayout(False)
        Me.tsSummaryGoodstockBO.PerformLayout()
        CType(Me.dgvSummaryGoodstockBO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbTotalCases As System.Windows.Forms.TextBox
    Friend WithEvents tbTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents tbTotalPcs As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbxPriceType As System.Windows.Forms.ComboBox
    Friend WithEvents tbTotalBags As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbTitle3 As System.Windows.Forms.TextBox
    Friend WithEvents dtpEndCol3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartCol3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbTitle2 As System.Windows.Forms.TextBox
    Friend WithEvents dtpEndCol2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartCol2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbTitle1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpEndCol1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartCol1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbCategory As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents tbItem As System.Windows.Forms.TextBox
    Friend WithEvents lblOutletType As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PrintSummaryReceiving As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbWhs As System.Windows.Forms.TextBox
    Friend WithEvents lblAreaT As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbBrand As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblAreaTerritory As System.Windows.Forms.Label
    Friend WithEvents tbSupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblWhs As System.Windows.Forms.Label
    Friend WithEvents Go As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsSummaryGoodstockBO As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dgvSummaryGoodstockBO As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
