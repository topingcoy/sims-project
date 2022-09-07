<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesInvoiceD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesInvoiceD))
        Me.dgvInvoiceItem = New System.Windows.Forms.DataGridView()
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbRemarks = New System.Windows.Forms.TextBox()
        Me.tsInvoiceItem = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAddItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsEditItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpInvoiceDate = New System.Windows.Forms.DateTimePicker()
        Me.tbCustomer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbSalesman = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tsInvoiceD = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewInvoice = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.SavePrintInvoice = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveInvoice = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.Editinvoice = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbPriceType = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbWarehouse = New System.Windows.Forms.TextBox()
        Me.tbInvoiceNo = New System.Windows.Forms.TextBox()
        Me.tbPoNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.chkdisc1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.dgvInvoiceTotal = New System.Windows.Forms.DataGridView()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nuDisc3 = New System.Windows.Forms.NumericUpDown()
        Me.nuDisc2 = New System.Windows.Forms.NumericUpDown()
        Me.nuDisc1 = New System.Windows.Forms.NumericUpDown()
        Me.lblSalesman = New System.Windows.Forms.Label()
        Me.lblWarehouse = New System.Windows.Forms.Label()
        Me.tbTransno = New System.Windows.Forms.TextBox()
        Me.cbxCash = New System.Windows.Forms.CheckBox()
        Me.cbTerms = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbGrossAmt = New System.Windows.Forms.TextBox()
        CType(Me.dgvInvoiceItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsInvoiceItem.SuspendLayout()
        Me.tsInvoiceD.SuspendLayout()
        CType(Me.dgvInvoiceTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuDisc3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuDisc2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuDisc1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInvoiceItem
        '
        Me.dgvInvoiceItem.AllowUserToAddRows = False
        Me.dgvInvoiceItem.AllowUserToResizeRows = False
        Me.dgvInvoiceItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvInvoiceItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoiceItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.dgvInvoiceItem.Location = New System.Drawing.Point(12, 128)
        Me.dgvInvoiceItem.Name = "dgvInvoiceItem"
        Me.dgvInvoiceItem.RowHeadersVisible = False
        Me.dgvInvoiceItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInvoiceItem.Size = New System.Drawing.Size(1016, 360)
        Me.dgvInvoiceItem.TabIndex = 115
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
        Me.Column4.HeaderText = "QTY"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 51
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "UNIT"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 57
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "PCKG"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 59
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "UNIT-PRICE"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 90
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "%DISC"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 65
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "GRS-AMOUNT"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 105
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "DISCOUNT"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 87
        '
        'Column11
        '
        Me.Column11.HeaderText = "NET-AMOUNT"
        Me.Column11.Name = "Column11"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 524)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Remarks :"
        '
        'tbRemarks
        '
        Me.tbRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbRemarks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbRemarks.Location = New System.Drawing.Point(71, 520)
        Me.tbRemarks.MaxLength = 50
        Me.tbRemarks.Multiline = True
        Me.tbRemarks.Name = "tbRemarks"
        Me.tbRemarks.Size = New System.Drawing.Size(387, 52)
        Me.tbRemarks.TabIndex = 116
        '
        'tsInvoiceItem
        '
        Me.tsInvoiceItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsInvoiceItem.Dock = System.Windows.Forms.DockStyle.None
        Me.tsInvoiceItem.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsInvoiceItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.tsAddItem, Me.ToolStripSeparator6, Me.tsEditItem, Me.ToolStripSeparator1, Me.tsDeleteItem, Me.ToolStripSeparator8})
        Me.tsInvoiceItem.Location = New System.Drawing.Point(13, 492)
        Me.tsInvoiceItem.Name = "tsInvoiceItem"
        Me.tsInvoiceItem.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsInvoiceItem.Size = New System.Drawing.Size(135, 25)
        Me.tsInvoiceItem.TabIndex = 118
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tsAddItem
        '
        Me.tsAddItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsAddItem.Image = CType(resources.GetObject("tsAddItem.Image"), System.Drawing.Image)
        Me.tsAddItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAddItem.Name = "tsAddItem"
        Me.tsAddItem.Size = New System.Drawing.Size(33, 22)
        Me.tsAddItem.Text = "&Add"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tsEditItem
        '
        Me.tsEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsEditItem.Image = CType(resources.GetObject("tsEditItem.Image"), System.Drawing.Image)
        Me.tsEditItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEditItem.Name = "tsEditItem"
        Me.tsEditItem.Size = New System.Drawing.Size(31, 22)
        Me.tsEditItem.Text = "E&dit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsDeleteItem
        '
        Me.tsDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsDeleteItem.Image = CType(resources.GetObject("tsDeleteItem.Image"), System.Drawing.Image)
        Me.tsDeleteItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDeleteItem.Name = "tsDeleteItem"
        Me.tsDeleteItem.Size = New System.Drawing.Size(44, 22)
        Me.tsDeleteItem.Text = "&Delete"
        Me.tsDeleteItem.ToolTipText = "S&ave "
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Invoice Date :"
        '
        'dtpInvoiceDate
        '
        Me.dtpInvoiceDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInvoiceDate.Location = New System.Drawing.Point(117, 12)
        Me.dtpInvoiceDate.Name = "dtpInvoiceDate"
        Me.dtpInvoiceDate.Size = New System.Drawing.Size(93, 22)
        Me.dtpInvoiceDate.TabIndex = 119
        '
        'tbCustomer
        '
        Me.tbCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbCustomer.Location = New System.Drawing.Point(117, 38)
        Me.tbCustomer.MaxLength = 50
        Me.tbCustomer.Name = "tbCustomer"
        Me.tbCustomer.Size = New System.Drawing.Size(126, 22)
        Me.tbCustomer.TabIndex = 121
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Customer Code :"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(250, 38)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(271, 22)
        Me.lblCustomerName.TabIndex = 123
        Me.lblCustomerName.Text = "CUSTOMER NAME"
        Me.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCustomerName.Visible = False
        '
        'lblAddress
        '
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(118, 66)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(403, 22)
        Me.lblAddress.TabIndex = 124
        Me.lblAddress.Text = "CUSTOMER ADDRESS"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAddress.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Address :"
        '
        'tbSalesman
        '
        Me.tbSalesman.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSalesman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSalesman.Location = New System.Drawing.Point(117, 91)
        Me.tbSalesman.MaxLength = 50
        Me.tbSalesman.Name = "tbSalesman"
        Me.tbSalesman.Size = New System.Drawing.Size(126, 22)
        Me.tbSalesman.TabIndex = 126
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 127
        Me.Label6.Text = "Salesman :"
        '
        'tsInvoiceD
        '
        Me.tsInvoiceD.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsInvoiceD.Dock = System.Windows.Forms.DockStyle.None
        Me.tsInvoiceD.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsInvoiceD.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.NewInvoice, Me.ToolStripSeparator33, Me.SavePrintInvoice, Me.ToolStripSeparator34, Me.SaveInvoice, Me.ToolStripSeparator35, Me.Editinvoice, Me.ToolStripSeparator7})
        Me.tsInvoiceD.Location = New System.Drawing.Point(828, 12)
        Me.tsInvoiceD.Name = "tsInvoiceD"
        Me.tsInvoiceD.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsInvoiceD.Size = New System.Drawing.Size(202, 25)
        Me.tsInvoiceD.TabIndex = 128
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'NewInvoice
        '
        Me.NewInvoice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NewInvoice.Image = CType(resources.GetObject("NewInvoice.Image"), System.Drawing.Image)
        Me.NewInvoice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewInvoice.Name = "NewInvoice"
        Me.NewInvoice.Size = New System.Drawing.Size(35, 22)
        Me.NewInvoice.Text = "&New"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'SavePrintInvoice
        '
        Me.SavePrintInvoice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SavePrintInvoice.Image = CType(resources.GetObject("SavePrintInvoice.Image"), System.Drawing.Image)
        Me.SavePrintInvoice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SavePrintInvoice.Name = "SavePrintInvoice"
        Me.SavePrintInvoice.Size = New System.Drawing.Size(68, 22)
        Me.SavePrintInvoice.Text = "Save+&Print"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'SaveInvoice
        '
        Me.SaveInvoice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveInvoice.Image = CType(resources.GetObject("SaveInvoice.Image"), System.Drawing.Image)
        Me.SaveInvoice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveInvoice.Name = "SaveInvoice"
        Me.SaveInvoice.Size = New System.Drawing.Size(35, 22)
        Me.SaveInvoice.Text = "&Save"
        Me.SaveInvoice.ToolTipText = "S&ave "
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'Editinvoice
        '
        Me.Editinvoice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Editinvoice.Image = CType(resources.GetObject("Editinvoice.Image"), System.Drawing.Image)
        Me.Editinvoice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Editinvoice.Name = "Editinvoice"
        Me.Editinvoice.Size = New System.Drawing.Size(31, 22)
        Me.Editinvoice.Text = "&Edit"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(563, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 130
        Me.Label7.Text = "Price Type :"
        '
        'tbPriceType
        '
        Me.tbPriceType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbPriceType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbPriceType.Location = New System.Drawing.Point(631, 16)
        Me.tbPriceType.MaxLength = 50
        Me.tbPriceType.Name = "tbPriceType"
        Me.tbPriceType.ReadOnly = True
        Me.tbPriceType.Size = New System.Drawing.Size(45, 22)
        Me.tbPriceType.TabIndex = 129
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(554, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 132
        Me.Label8.Text = "Warehouse :"
        '
        'tbWarehouse
        '
        Me.tbWarehouse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbWarehouse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbWarehouse.Location = New System.Drawing.Point(631, 42)
        Me.tbWarehouse.MaxLength = 50
        Me.tbWarehouse.Name = "tbWarehouse"
        Me.tbWarehouse.ReadOnly = True
        Me.tbWarehouse.Size = New System.Drawing.Size(126, 22)
        Me.tbWarehouse.TabIndex = 131
        '
        'tbInvoiceNo
        '
        Me.tbInvoiceNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbInvoiceNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbInvoiceNo.Location = New System.Drawing.Point(631, 68)
        Me.tbInvoiceNo.MaxLength = 50
        Me.tbInvoiceNo.Name = "tbInvoiceNo"
        Me.tbInvoiceNo.Size = New System.Drawing.Size(126, 22)
        Me.tbInvoiceNo.TabIndex = 133
        '
        'tbPoNo
        '
        Me.tbPoNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbPoNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbPoNo.Location = New System.Drawing.Point(631, 95)
        Me.tbPoNo.MaxLength = 50
        Me.tbPoNo.Name = "tbPoNo"
        Me.tbPoNo.Size = New System.Drawing.Size(126, 22)
        Me.tbPoNo.TabIndex = 134
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(559, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 135
        Me.Label9.Text = "Invoice No :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(573, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 136
        Me.Label10.Text = "P.O. No :"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox2.Location = New System.Drawing.Point(592, 571)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(147, 17)
        Me.CheckBox2.TabIndex = 143
        Me.CheckBox2.Text = " Check if Amount Disc 3"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'chkdisc1
        '
        Me.chkdisc1.AutoSize = True
        Me.chkdisc1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkdisc1.Location = New System.Drawing.Point(593, 520)
        Me.chkdisc1.Name = "chkdisc1"
        Me.chkdisc1.Size = New System.Drawing.Size(147, 17)
        Me.chkdisc1.TabIndex = 141
        Me.chkdisc1.Text = " Check if Amount Disc 1"
        Me.chkdisc1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.Location = New System.Drawing.Point(593, 546)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(147, 17)
        Me.CheckBox1.TabIndex = 142
        Me.CheckBox1.Text = " Check if Amount Disc 2"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'dgvInvoiceTotal
        '
        Me.dgvInvoiceTotal.AllowUserToAddRows = False
        Me.dgvInvoiceTotal.AllowUserToDeleteRows = False
        Me.dgvInvoiceTotal.AllowUserToResizeColumns = False
        Me.dgvInvoiceTotal.AllowUserToResizeRows = False
        Me.dgvInvoiceTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvInvoiceTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoiceTotal.ColumnHeadersVisible = False
        Me.dgvInvoiceTotal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column12, Me.Column13})
        Me.dgvInvoiceTotal.Location = New System.Drawing.Point(805, 494)
        Me.dgvInvoiceTotal.Name = "dgvInvoiceTotal"
        Me.dgvInvoiceTotal.ReadOnly = True
        Me.dgvInvoiceTotal.RowHeadersVisible = False
        Me.dgvInvoiceTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInvoiceTotal.Size = New System.Drawing.Size(223, 115)
        Me.dgvInvoiceTotal.TabIndex = 140
        '
        'Column12
        '
        Me.Column12.HeaderText = "Label"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column13
        '
        Me.Column13.HeaderText = "Amount"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 120
        '
        'nuDisc3
        '
        Me.nuDisc3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nuDisc3.DecimalPlaces = 2
        Me.nuDisc3.Location = New System.Drawing.Point(743, 568)
        Me.nuDisc3.Name = "nuDisc3"
        Me.nuDisc3.Size = New System.Drawing.Size(55, 22)
        Me.nuDisc3.TabIndex = 139
        Me.nuDisc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nuDisc2
        '
        Me.nuDisc2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nuDisc2.DecimalPlaces = 2
        Me.nuDisc2.Location = New System.Drawing.Point(744, 543)
        Me.nuDisc2.Name = "nuDisc2"
        Me.nuDisc2.Size = New System.Drawing.Size(55, 22)
        Me.nuDisc2.TabIndex = 138
        Me.nuDisc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nuDisc1
        '
        Me.nuDisc1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nuDisc1.DecimalPlaces = 2
        Me.nuDisc1.Location = New System.Drawing.Point(744, 517)
        Me.nuDisc1.Name = "nuDisc1"
        Me.nuDisc1.Size = New System.Drawing.Size(55, 22)
        Me.nuDisc1.TabIndex = 137
        Me.nuDisc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSalesman
        '
        Me.lblSalesman.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesman.Location = New System.Drawing.Point(249, 91)
        Me.lblSalesman.Name = "lblSalesman"
        Me.lblSalesman.Size = New System.Drawing.Size(271, 22)
        Me.lblSalesman.TabIndex = 144
        Me.lblSalesman.Text = "SALESMAN NAME"
        Me.lblSalesman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSalesman.Visible = False
        '
        'lblWarehouse
        '
        Me.lblWarehouse.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarehouse.Location = New System.Drawing.Point(763, 43)
        Me.lblWarehouse.Name = "lblWarehouse"
        Me.lblWarehouse.Size = New System.Drawing.Size(267, 22)
        Me.lblWarehouse.TabIndex = 145
        Me.lblWarehouse.Text = "WAHOUSE NAME"
        Me.lblWarehouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblWarehouse.Visible = False
        '
        'tbTransno
        '
        Me.tbTransno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTransno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbTransno.Location = New System.Drawing.Point(216, 12)
        Me.tbTransno.MaxLength = 50
        Me.tbTransno.Name = "tbTransno"
        Me.tbTransno.ReadOnly = True
        Me.tbTransno.Size = New System.Drawing.Size(126, 22)
        Me.tbTransno.TabIndex = 146
        Me.tbTransno.Visible = False
        '
        'cbxCash
        '
        Me.cbxCash.AutoSize = True
        Me.cbxCash.Location = New System.Drawing.Point(947, 69)
        Me.cbxCash.Name = "cbxCash"
        Me.cbxCash.Size = New System.Drawing.Size(81, 17)
        Me.cbxCash.TabIndex = 147
        Me.cbxCash.Text = "Paid Cash?"
        Me.cbxCash.UseVisualStyleBackColor = True
        '
        'cbTerms
        '
        Me.cbTerms.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTerms.FormattingEnabled = True
        Me.cbTerms.Items.AddRange(New Object() {"COD", "CWO", "7 Days", "15 Days", "30 Days", "45 Days", "60 Days", "90 Days"})
        Me.cbTerms.Location = New System.Drawing.Point(947, 91)
        Me.cbTerms.Name = "cbTerms"
        Me.cbTerms.Size = New System.Drawing.Size(81, 21)
        Me.cbTerms.TabIndex = 148
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(900, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 149
        Me.Label3.Text = "Terms :"
        '
        'tbGrossAmt
        '
        Me.tbGrossAmt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbGrossAmt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbGrossAmt.Location = New System.Drawing.Point(672, 492)
        Me.tbGrossAmt.MaxLength = 50
        Me.tbGrossAmt.Name = "tbGrossAmt"
        Me.tbGrossAmt.ReadOnly = True
        Me.tbGrossAmt.Size = New System.Drawing.Size(126, 22)
        Me.tbGrossAmt.TabIndex = 150
        Me.tbGrossAmt.Visible = False
        '
        'frmSalesInvoiceD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 615)
        Me.Controls.Add(Me.tbGrossAmt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbTerms)
        Me.Controls.Add(Me.cbxCash)
        Me.Controls.Add(Me.tbTransno)
        Me.Controls.Add(Me.lblWarehouse)
        Me.Controls.Add(Me.lblSalesman)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.chkdisc1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.dgvInvoiceTotal)
        Me.Controls.Add(Me.nuDisc3)
        Me.Controls.Add(Me.nuDisc2)
        Me.Controls.Add(Me.nuDisc1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbPoNo)
        Me.Controls.Add(Me.tbInvoiceNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbWarehouse)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbPriceType)
        Me.Controls.Add(Me.tsInvoiceD)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbSalesman)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbCustomer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpInvoiceDate)
        Me.Controls.Add(Me.tsInvoiceItem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbRemarks)
        Me.Controls.Add(Me.dgvInvoiceItem)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalesInvoiceD"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALES INVOICE"
        CType(Me.dgvInvoiceItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsInvoiceItem.ResumeLayout(False)
        Me.tsInvoiceItem.PerformLayout()
        Me.tsInvoiceD.ResumeLayout(False)
        Me.tsInvoiceD.PerformLayout()
        CType(Me.dgvInvoiceTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuDisc3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuDisc2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuDisc1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvInvoiceItem As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbRemarks As System.Windows.Forms.TextBox
    Friend WithEvents tsInvoiceItem As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsAddItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsEditItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpInvoiceDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbSalesman As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tsInvoiceD As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewInvoice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SavePrintInvoice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveInvoice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Editinvoice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbPriceType As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbWarehouse As System.Windows.Forms.TextBox
    Friend WithEvents tbInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents tbPoNo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkdisc1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents dgvInvoiceTotal As System.Windows.Forms.DataGridView
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nuDisc3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nuDisc2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nuDisc1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSalesman As System.Windows.Forms.Label
    Friend WithEvents lblWarehouse As System.Windows.Forms.Label
    Friend WithEvents tbTransno As System.Windows.Forms.TextBox
    Friend WithEvents cbxCash As System.Windows.Forms.CheckBox
    Friend WithEvents cbTerms As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbGrossAmt As System.Windows.Forms.TextBox
End Class
