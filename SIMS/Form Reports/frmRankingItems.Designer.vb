<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRankingItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRankingItems))
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.tbCustomer = New System.Windows.Forms.TextBox()
        Me.lblWhs = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbWhs = New System.Windows.Forms.TextBox()
        Me.lblSalesmanName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSalesman = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpListInvoice2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpListInvoice1 = New System.Windows.Forms.DateTimePicker()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbSupplier = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbCategory = New System.Windows.Forms.TextBox()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbBrand = New System.Windows.Forms.TextBox()
        Me.lblAreaTerritory = New System.Windows.Forms.Label()
        Me.lblAreaT = New System.Windows.Forms.Label()
        Me.tbArea = New System.Windows.Forms.TextBox()
        Me.lblOutletType = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbOutletType = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvBOReturnList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AMOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.tsRankingItems = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.Go = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintRankingItems = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.nuDisc1 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbRankItemTotal = New System.Windows.Forms.TextBox()
        CType(Me.dgvBOReturnList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOptions.SuspendLayout()
        Me.tsRankingItems.SuspendLayout()
        CType(Me.nuDisc1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCustomer
        '
        Me.lblCustomer.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(262, 158)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(316, 22)
        Me.lblCustomer.TabIndex = 145
        Me.lblCustomer.Text = "CUSTOMER NAME"
        Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCustomer.Visible = False
        '
        'tbCustomer
        '
        Me.tbCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbCustomer.Location = New System.Drawing.Point(163, 158)
        Me.tbCustomer.MaxLength = 50
        Me.tbCustomer.Name = "tbCustomer"
        Me.tbCustomer.Size = New System.Drawing.Size(92, 22)
        Me.tbCustomer.TabIndex = 143
        '
        'lblWhs
        '
        Me.lblWhs.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhs.Location = New System.Drawing.Point(262, 132)
        Me.lblWhs.Name = "lblWhs"
        Me.lblWhs.Size = New System.Drawing.Size(316, 22)
        Me.lblWhs.TabIndex = 142
        Me.lblWhs.Text = "WAREHOUSE NAME"
        Me.lblWhs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblWhs.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 13)
        Me.Label5.TabIndex = 141
        Me.Label5.Text = "Warehouse [Blank = All] :"
        '
        'tbWhs
        '
        Me.tbWhs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbWhs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbWhs.Location = New System.Drawing.Point(163, 132)
        Me.tbWhs.MaxLength = 50
        Me.tbWhs.Name = "tbWhs"
        Me.tbWhs.Size = New System.Drawing.Size(92, 22)
        Me.tbWhs.TabIndex = 140
        '
        'lblSalesmanName
        '
        Me.lblSalesmanName.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesmanName.Location = New System.Drawing.Point(262, 107)
        Me.lblSalesmanName.Name = "lblSalesmanName"
        Me.lblSalesmanName.Size = New System.Drawing.Size(316, 22)
        Me.lblSalesmanName.TabIndex = 139
        Me.lblSalesmanName.Text = "SALESMAN NAME"
        Me.lblSalesmanName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSalesmanName.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "Salesman [Blank = All] :"
        '
        'tbSalesman
        '
        Me.tbSalesman.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSalesman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSalesman.Location = New System.Drawing.Point(163, 107)
        Me.tbSalesman.MaxLength = 50
        Me.tbSalesman.Name = "tbSalesman"
        Me.tbSalesman.Size = New System.Drawing.Size(92, 22)
        Me.tbSalesman.TabIndex = 137
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "Ending Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 135
        Me.Label2.Text = "Stating Date :"
        '
        'dtpListInvoice2
        '
        Me.dtpListInvoice2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpListInvoice2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpListInvoice2.Location = New System.Drawing.Point(344, 5)
        Me.dtpListInvoice2.Name = "dtpListInvoice2"
        Me.dtpListInvoice2.Size = New System.Drawing.Size(93, 22)
        Me.dtpListInvoice2.TabIndex = 134
        '
        'dtpListInvoice1
        '
        Me.dtpListInvoice1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpListInvoice1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpListInvoice1.Location = New System.Drawing.Point(163, 5)
        Me.dtpListInvoice1.Name = "dtpListInvoice1"
        Me.dtpListInvoice1.Size = New System.Drawing.Size(93, 22)
        Me.dtpListInvoice1.TabIndex = 133
        '
        'lblSupplier
        '
        Me.lblSupplier.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplier.Location = New System.Drawing.Point(262, 31)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(316, 22)
        Me.lblSupplier.TabIndex = 148
        Me.lblSupplier.Text = "SUPPLIER NAME"
        Me.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSupplier.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 13)
        Me.Label9.TabIndex = 147
        Me.Label9.Text = "Supplier [Blank = All] :"
        '
        'tbSupplier
        '
        Me.tbSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSupplier.Location = New System.Drawing.Point(163, 31)
        Me.tbSupplier.MaxLength = 50
        Me.tbSupplier.Name = "tbSupplier"
        Me.tbSupplier.Size = New System.Drawing.Size(92, 22)
        Me.tbSupplier.TabIndex = 146
        '
        'lblCategory
        '
        Me.lblCategory.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(262, 56)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(316, 22)
        Me.lblCategory.TabIndex = 151
        Me.lblCategory.Text = "CATEGORY NAME"
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCategory.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 13)
        Me.Label10.TabIndex = 150
        Me.Label10.Text = "Category [Blank = All] :"
        '
        'tbCategory
        '
        Me.tbCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbCategory.Location = New System.Drawing.Point(163, 56)
        Me.tbCategory.MaxLength = 50
        Me.tbCategory.Name = "tbCategory"
        Me.tbCategory.Size = New System.Drawing.Size(92, 22)
        Me.tbCategory.TabIndex = 149
        '
        'lblBrand
        '
        Me.lblBrand.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrand.Location = New System.Drawing.Point(262, 81)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(316, 22)
        Me.lblBrand.TabIndex = 154
        Me.lblBrand.Text = "BRAND NAME"
        Me.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblBrand.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(52, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 13)
        Me.Label11.TabIndex = 153
        Me.Label11.Text = "Brand [Blank = All] :"
        '
        'tbBrand
        '
        Me.tbBrand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbBrand.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbBrand.Location = New System.Drawing.Point(163, 81)
        Me.tbBrand.MaxLength = 50
        Me.tbBrand.Name = "tbBrand"
        Me.tbBrand.Size = New System.Drawing.Size(92, 22)
        Me.tbBrand.TabIndex = 152
        '
        'lblAreaTerritory
        '
        Me.lblAreaTerritory.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreaTerritory.Location = New System.Drawing.Point(262, 183)
        Me.lblAreaTerritory.Name = "lblAreaTerritory"
        Me.lblAreaTerritory.Size = New System.Drawing.Size(316, 22)
        Me.lblAreaTerritory.TabIndex = 157
        Me.lblAreaTerritory.Text = "AREA/TERRITORY"
        Me.lblAreaTerritory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAreaTerritory.Visible = False
        '
        'lblAreaT
        '
        Me.lblAreaT.AutoSize = True
        Me.lblAreaT.Location = New System.Drawing.Point(13, 187)
        Me.lblAreaT.Name = "lblAreaT"
        Me.lblAreaT.Size = New System.Drawing.Size(146, 13)
        Me.lblAreaT.TabIndex = 156
        Me.lblAreaT.Text = "Area/Territory [Blank = All] :"
        '
        'tbArea
        '
        Me.tbArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbArea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbArea.Location = New System.Drawing.Point(163, 183)
        Me.tbArea.MaxLength = 50
        Me.tbArea.Name = "tbArea"
        Me.tbArea.Size = New System.Drawing.Size(92, 22)
        Me.tbArea.TabIndex = 155
        '
        'lblOutletType
        '
        Me.lblOutletType.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutletType.Location = New System.Drawing.Point(262, 208)
        Me.lblOutletType.Name = "lblOutletType"
        Me.lblOutletType.Size = New System.Drawing.Size(316, 22)
        Me.lblOutletType.TabIndex = 160
        Me.lblOutletType.Text = "OUTLET TYPE"
        Me.lblOutletType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblOutletType.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 13)
        Me.Label6.TabIndex = 159
        Me.Label6.Text = "Outlet Type [Blank = All] :"
        '
        'tbOutletType
        '
        Me.tbOutletType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbOutletType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbOutletType.Location = New System.Drawing.Point(163, 208)
        Me.tbOutletType.MaxLength = 50
        Me.tbOutletType.Name = "tbOutletType"
        Me.tbOutletType.Size = New System.Drawing.Size(92, 22)
        Me.tbOutletType.TabIndex = 158
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 13)
        Me.Label7.TabIndex = 161
        Me.Label7.Text = "Customer [Blank = All] :"
        '
        'dgvBOReturnList
        '
        Me.dgvBOReturnList.AllowUserToAddRows = False
        Me.dgvBOReturnList.AllowUserToResizeRows = False
        Me.dgvBOReturnList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvBOReturnList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBOReturnList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.AMOUNT})
        Me.dgvBOReturnList.Location = New System.Drawing.Point(12, 238)
        Me.dgvBOReturnList.Name = "dgvBOReturnList"
        Me.dgvBOReturnList.RowHeadersVisible = False
        Me.dgvBOReturnList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBOReturnList.Size = New System.Drawing.Size(829, 356)
        Me.dgvBOReturnList.TabIndex = 170
        '
        'Column1
        '
        Me.Column1.HeaderText = "RANK"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "ITEMCODE"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "ITEM DESCRIPTION"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 350
        '
        'Column4
        '
        Me.Column4.FillWeight = 120.0!
        Me.Column4.HeaderText = "CASES"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 60
        '
        'Column5
        '
        Me.Column5.FillWeight = 120.0!
        Me.Column5.HeaderText = "BAGS"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 60
        '
        'Column6
        '
        Me.Column6.FillWeight = 120.0!
        Me.Column6.HeaderText = "PIECES"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 60
        '
        'AMOUNT
        '
        Me.AMOUNT.HeaderText = "AMOUNT"
        Me.AMOUNT.Name = "AMOUNT"
        Me.AMOUNT.Width = 120
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.CheckBox2)
        Me.gbOptions.Controls.Add(Me.CheckBox1)
        Me.gbOptions.Location = New System.Drawing.Point(705, 132)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(136, 73)
        Me.gbOptions.TabIndex = 171
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = "Amount Base On?"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(11, 44)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox2.TabIndex = 176
        Me.CheckBox2.Text = "Unit Price"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(11, 21)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(95, 17)
        Me.CheckBox1.TabIndex = 175
        Me.CheckBox1.Text = "Supplier Cost"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'tsRankingItems
        '
        Me.tsRankingItems.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsRankingItems.Dock = System.Windows.Forms.DockStyle.None
        Me.tsRankingItems.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsRankingItems.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.Go, Me.ToolStripSeparator33, Me.PrintRankingItems, Me.ToolStripSeparator34})
        Me.tsRankingItems.Location = New System.Drawing.Point(713, 5)
        Me.tsRankingItems.Name = "tsRankingItems"
        Me.tsRankingItems.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsRankingItems.Size = New System.Drawing.Size(129, 25)
        Me.tsRankingItems.TabIndex = 172
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
        'PrintRankingItems
        '
        Me.PrintRankingItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PrintRankingItems.Image = CType(resources.GetObject("PrintRankingItems.Image"), System.Drawing.Image)
        Me.PrintRankingItems.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintRankingItems.Name = "PrintRankingItems"
        Me.PrintRankingItems.Size = New System.Drawing.Size(80, 22)
        Me.PrintRankingItems.Text = "Print Preview"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'nuDisc1
        '
        Me.nuDisc1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nuDisc1.DecimalPlaces = 2
        Me.nuDisc1.Location = New System.Drawing.Point(756, 85)
        Me.nuDisc1.Name = "nuDisc1"
        Me.nuDisc1.Size = New System.Drawing.Size(55, 22)
        Me.nuDisc1.TabIndex = 173
        Me.nuDisc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(692, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 174
        Me.Label4.Text = "Print Top :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(646, 605)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 243
        Me.Label8.Text = "TOTAL :"
        '
        'tbRankItemTotal
        '
        Me.tbRankItemTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbRankItemTotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbRankItemTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRankItemTotal.Location = New System.Drawing.Point(695, 600)
        Me.tbRankItemTotal.MaxLength = 50
        Me.tbRankItemTotal.Name = "tbRankItemTotal"
        Me.tbRankItemTotal.ReadOnly = True
        Me.tbRankItemTotal.Size = New System.Drawing.Size(130, 22)
        Me.tbRankItemTotal.TabIndex = 242
        '
        'frmRankingItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 631)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbRankItemTotal)
        Me.Controls.Add(Me.tsRankingItems)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvBOReturnList)
        Me.Controls.Add(Me.nuDisc1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblOutletType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbOutletType)
        Me.Controls.Add(Me.lblAreaTerritory)
        Me.Controls.Add(Me.lblAreaT)
        Me.Controls.Add(Me.tbArea)
        Me.Controls.Add(Me.lblBrand)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbBrand)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbCategory)
        Me.Controls.Add(Me.lblSupplier)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbSupplier)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.tbCustomer)
        Me.Controls.Add(Me.lblWhs)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbWhs)
        Me.Controls.Add(Me.lblSalesmanName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbSalesman)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpListInvoice2)
        Me.Controls.Add(Me.dtpListInvoice1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRankingItems"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALES RANKING OF ITEMS"
        CType(Me.dgvBOReturnList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.tsRankingItems.ResumeLayout(False)
        Me.tsRankingItems.PerformLayout()
        CType(Me.nuDisc1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents tbCustomer As System.Windows.Forms.TextBox
    Friend WithEvents lblWhs As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbWhs As System.Windows.Forms.TextBox
    Friend WithEvents lblSalesmanName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbSalesman As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpListInvoice2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpListInvoice1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbSupplier As System.Windows.Forms.TextBox
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbCategory As System.Windows.Forms.TextBox
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbBrand As System.Windows.Forms.TextBox
    Friend WithEvents lblAreaTerritory As System.Windows.Forms.Label
    Friend WithEvents lblAreaT As System.Windows.Forms.Label
    Friend WithEvents tbArea As System.Windows.Forms.TextBox
    Friend WithEvents lblOutletType As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbOutletType As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvBOReturnList As System.Windows.Forms.DataGridView
    Friend WithEvents gbOptions As System.Windows.Forms.GroupBox
    Friend WithEvents tsRankingItems As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Go As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintRankingItems As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents nuDisc1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbRankItemTotal As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AMOUNT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
