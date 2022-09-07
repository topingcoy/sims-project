<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGSreturnSupplierD
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGSreturnSupplierD))
        Me.dgvRcvItem = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsGSreturnSupplier = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAddItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbWarehouse = New System.Windows.Forms.TextBox()
        Me.tbSupplier = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxSupplier = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxWarehouse = New System.Windows.Forms.ComboBox()
        Me.RcvDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbRemarks = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxPriceType = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbDisc3Net = New System.Windows.Forms.TextBox()
        Me.tbDisc2Net = New System.Windows.Forms.TextBox()
        Me.tbDisc1Net = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbNetAmount = New System.Windows.Forms.TextBox()
        Me.tbDisc3 = New System.Windows.Forms.TextBox()
        Me.tbDisc2 = New System.Windows.Forms.TextBox()
        Me.tbDisc1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbGrossAmt = New System.Windows.Forms.TextBox()
        Me.NuPD3 = New System.Windows.Forms.NumericUpDown()
        Me.NuPD2 = New System.Windows.Forms.NumericUpDown()
        Me.NuPD1 = New System.Windows.Forms.NumericUpDown()
        Me.pbar1 = New System.Windows.Forms.ProgressBar()
        Me.tsGSreturn = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsSsavePrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvRcvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsGSreturnSupplier.SuspendLayout()
        CType(Me.NuPD3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuPD2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuPD1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsGSreturn.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvRcvItem
        '
        Me.dgvRcvItem.AllowUserToAddRows = False
        Me.dgvRcvItem.AllowUserToResizeRows = False
        Me.dgvRcvItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Wheat
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRcvItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRcvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRcvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column10, Me.Column11})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRcvItem.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvRcvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.dgvRcvItem.Location = New System.Drawing.Point(12, 114)
        Me.dgvRcvItem.Name = "dgvRcvItem"
        Me.dgvRcvItem.RowHeadersVisible = False
        Me.dgvRcvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvRcvItem.Size = New System.Drawing.Size(730, 270)
        Me.dgvRcvItem.TabIndex = 67
        '
        'Column1
        '
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 35
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "ITEMCODE"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 89
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "DESCRIPTION"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "QTY"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 53
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "UNIT"
        Me.Column5.Items.AddRange(New Object() {"C", "B", "P"})
        Me.Column5.Name = "Column5"
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column5.Width = 58
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column6.HeaderText = "PCKG"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 61
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column10.HeaderText = "COST/PC"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 81
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Column11.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column11.HeaderText = "AMOUNT"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column11.Width = 83
        '
        'tsGSreturnSupplier
        '
        Me.tsGSreturnSupplier.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsGSreturnSupplier.Dock = System.Windows.Forms.DockStyle.None
        Me.tsGSreturnSupplier.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsGSreturnSupplier.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnAdd, Me.ToolStripSeparator7, Me.tsAddItem, Me.ToolStripSeparator2})
        Me.tsGSreturnSupplier.Location = New System.Drawing.Point(12, 399)
        Me.tsGSreturnSupplier.Name = "tsGSreturnSupplier"
        Me.tsGSreturnSupplier.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsGSreturnSupplier.Size = New System.Drawing.Size(168, 25)
        Me.tsGSreturnSupplier.TabIndex = 83
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnAdd
        '
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(35, 22)
        Me.btnAdd.Text = "&ADD"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'tsAddItem
        '
        Me.tsAddItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsAddItem.Image = CType(resources.GetObject("tsAddItem.Image"), System.Drawing.Image)
        Me.tsAddItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAddItem.Name = "tsAddItem"
        Me.tsAddItem.Size = New System.Drawing.Size(112, 22)
        Me.tsAddItem.Text = "[F3 -SEARCH ITEM]"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tbWarehouse
        '
        Me.tbWarehouse.BackColor = System.Drawing.SystemColors.Control
        Me.tbWarehouse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbWarehouse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbWarehouse.Location = New System.Drawing.Point(186, 59)
        Me.tbWarehouse.Name = "tbWarehouse"
        Me.tbWarehouse.ReadOnly = True
        Me.tbWarehouse.Size = New System.Drawing.Size(261, 23)
        Me.tbWarehouse.TabIndex = 101
        '
        'tbSupplier
        '
        Me.tbSupplier.BackColor = System.Drawing.SystemColors.Control
        Me.tbSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSupplier.Location = New System.Drawing.Point(186, 33)
        Me.tbSupplier.Name = "tbSupplier"
        Me.tbSupplier.ReadOnly = True
        Me.tbSupplier.Size = New System.Drawing.Size(261, 23)
        Me.tbSupplier.TabIndex = 100
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Supplier :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Warehouse :"
        '
        'cbxSupplier
        '
        Me.cbxSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSupplier.FormattingEnabled = True
        Me.cbxSupplier.Location = New System.Drawing.Point(87, 34)
        Me.cbxSupplier.Name = "cbxSupplier"
        Me.cbxSupplier.Size = New System.Drawing.Size(93, 23)
        Me.cbxSupplier.TabIndex = 96
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Date :"
        '
        'cbxWarehouse
        '
        Me.cbxWarehouse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxWarehouse.FormattingEnabled = True
        Me.cbxWarehouse.Location = New System.Drawing.Point(87, 60)
        Me.cbxWarehouse.Name = "cbxWarehouse"
        Me.cbxWarehouse.Size = New System.Drawing.Size(93, 23)
        Me.cbxWarehouse.TabIndex = 95
        '
        'RcvDate
        '
        Me.RcvDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RcvDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RcvDate.Location = New System.Drawing.Point(87, 7)
        Me.RcvDate.Name = "RcvDate"
        Me.RcvDate.Size = New System.Drawing.Size(93, 23)
        Me.RcvDate.TabIndex = 94
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Remarks :"
        '
        'tbRemarks
        '
        Me.tbRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbRemarks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbRemarks.Location = New System.Drawing.Point(87, 87)
        Me.tbRemarks.Name = "tbRemarks"
        Me.tbRemarks.Size = New System.Drawing.Size(655, 23)
        Me.tbRemarks.TabIndex = 108
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(186, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 15)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "Price Type :"
        '
        'cbxPriceType
        '
        Me.cbxPriceType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxPriceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPriceType.FormattingEnabled = True
        Me.cbxPriceType.Items.AddRange(New Object() {"1", "A", "B", "C", "D", "E"})
        Me.cbxPriceType.Location = New System.Drawing.Point(252, 7)
        Me.cbxPriceType.Name = "cbxPriceType"
        Me.cbxPriceType.Size = New System.Drawing.Size(39, 23)
        Me.cbxPriceType.TabIndex = 112
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(455, 470)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 15)
        Me.Label15.TabIndex = 133
        Me.Label15.Text = "%"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(455, 451)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 15)
        Me.Label14.TabIndex = 132
        Me.Label14.Text = "%"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(455, 430)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 15)
        Me.Label13.TabIndex = 131
        Me.Label13.Text = "%"
        '
        'tbDisc3Net
        '
        Me.tbDisc3Net.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDisc3Net.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDisc3Net.Location = New System.Drawing.Point(318, 474)
        Me.tbDisc3Net.Name = "tbDisc3Net"
        Me.tbDisc3Net.ReadOnly = True
        Me.tbDisc3Net.Size = New System.Drawing.Size(131, 22)
        Me.tbDisc3Net.TabIndex = 130
        Me.tbDisc3Net.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbDisc3Net.Visible = False
        '
        'tbDisc2Net
        '
        Me.tbDisc2Net.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDisc2Net.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDisc2Net.Location = New System.Drawing.Point(318, 447)
        Me.tbDisc2Net.Name = "tbDisc2Net"
        Me.tbDisc2Net.ReadOnly = True
        Me.tbDisc2Net.Size = New System.Drawing.Size(131, 22)
        Me.tbDisc2Net.TabIndex = 129
        Me.tbDisc2Net.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbDisc2Net.Visible = False
        '
        'tbDisc1Net
        '
        Me.tbDisc1Net.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDisc1Net.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDisc1Net.Location = New System.Drawing.Point(318, 419)
        Me.tbDisc1Net.Name = "tbDisc1Net"
        Me.tbDisc1Net.ReadOnly = True
        Me.tbDisc1Net.Size = New System.Drawing.Size(131, 22)
        Me.tbDisc1Net.TabIndex = 128
        Me.tbDisc1Net.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbDisc1Net.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(535, 477)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 15)
        Me.Label12.TabIndex = 127
        Me.Label12.Text = "Less Disck 3 :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(535, 452)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 15)
        Me.Label11.TabIndex = 126
        Me.Label11.Text = "Less Disc 2 :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(535, 428)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 15)
        Me.Label10.TabIndex = 125
        Me.Label10.Text = "Less Disc 1 :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(520, 500)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 15)
        Me.Label9.TabIndex = 124
        Me.Label9.Text = "NET AMOUNT :"
        '
        'tbNetAmount
        '
        Me.tbNetAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNetAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNetAmount.ForeColor = System.Drawing.Color.Red
        Me.tbNetAmount.Location = New System.Drawing.Point(610, 495)
        Me.tbNetAmount.Name = "tbNetAmount"
        Me.tbNetAmount.ReadOnly = True
        Me.tbNetAmount.Size = New System.Drawing.Size(131, 23)
        Me.tbNetAmount.TabIndex = 123
        Me.tbNetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbDisc3
        '
        Me.tbDisc3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDisc3.Location = New System.Drawing.Point(610, 471)
        Me.tbDisc3.Name = "tbDisc3"
        Me.tbDisc3.ReadOnly = True
        Me.tbDisc3.Size = New System.Drawing.Size(131, 23)
        Me.tbDisc3.TabIndex = 122
        Me.tbDisc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbDisc2
        '
        Me.tbDisc2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDisc2.Location = New System.Drawing.Point(610, 447)
        Me.tbDisc2.Name = "tbDisc2"
        Me.tbDisc2.ReadOnly = True
        Me.tbDisc2.Size = New System.Drawing.Size(131, 23)
        Me.tbDisc2.TabIndex = 121
        Me.tbDisc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbDisc1
        '
        Me.tbDisc1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDisc1.Location = New System.Drawing.Point(610, 423)
        Me.tbDisc1.Name = "tbDisc1"
        Me.tbDisc1.ReadOnly = True
        Me.tbDisc1.Size = New System.Drawing.Size(131, 23)
        Me.tbDisc1.TabIndex = 120
        Me.tbDisc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(507, 405)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 15)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "GROSS AMOUNT :"
        '
        'tbGrossAmt
        '
        Me.tbGrossAmt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbGrossAmt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGrossAmt.Location = New System.Drawing.Point(610, 400)
        Me.tbGrossAmt.Name = "tbGrossAmt"
        Me.tbGrossAmt.ReadOnly = True
        Me.tbGrossAmt.Size = New System.Drawing.Size(131, 22)
        Me.tbGrossAmt.TabIndex = 118
        Me.tbGrossAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NuPD3
        '
        Me.NuPD3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NuPD3.DecimalPlaces = 2
        Me.NuPD3.Location = New System.Drawing.Point(474, 469)
        Me.NuPD3.Name = "NuPD3"
        Me.NuPD3.Size = New System.Drawing.Size(55, 23)
        Me.NuPD3.TabIndex = 117
        Me.NuPD3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NuPD2
        '
        Me.NuPD2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NuPD2.DecimalPlaces = 2
        Me.NuPD2.Location = New System.Drawing.Point(474, 447)
        Me.NuPD2.Name = "NuPD2"
        Me.NuPD2.Size = New System.Drawing.Size(55, 23)
        Me.NuPD2.TabIndex = 116
        Me.NuPD2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NuPD1
        '
        Me.NuPD1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NuPD1.DecimalPlaces = 2
        Me.NuPD1.Location = New System.Drawing.Point(474, 426)
        Me.NuPD1.Name = "NuPD1"
        Me.NuPD1.Size = New System.Drawing.Size(55, 23)
        Me.NuPD1.TabIndex = 115
        Me.NuPD1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbar1
        '
        Me.pbar1.Location = New System.Drawing.Point(12, 386)
        Me.pbar1.Name = "pbar1"
        Me.pbar1.Size = New System.Drawing.Size(730, 12)
        Me.pbar1.TabIndex = 134
        Me.pbar1.Visible = False
        '
        'tsGSreturn
        '
        Me.tsGSreturn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsGSreturn.Dock = System.Windows.Forms.DockStyle.None
        Me.tsGSreturn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsGSreturn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsSsavePrint, Me.ToolStripSeparator34, Me.tsSave, Me.ToolStripSeparator35, Me.tsClose, Me.ToolStripSeparator8})
        Me.tsGSreturn.Location = New System.Drawing.Point(573, 7)
        Me.tsGSreturn.Name = "tsGSreturn"
        Me.tsGSreturn.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsGSreturn.Size = New System.Drawing.Size(170, 25)
        Me.tsGSreturn.TabIndex = 135
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'tsSsavePrint
        '
        Me.tsSsavePrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsSsavePrint.Image = CType(resources.GetObject("tsSsavePrint.Image"), System.Drawing.Image)
        Me.tsSsavePrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSsavePrint.Name = "tsSsavePrint"
        Me.tsSsavePrint.Size = New System.Drawing.Size(68, 22)
        Me.tsSsavePrint.Text = "Save+&Print"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'tsSave
        '
        Me.tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(35, 22)
        Me.tsSave.Text = "&Save"
        Me.tsSave.ToolTipText = "S&ave "
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'tsClose
        '
        Me.tsClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsClose.Image = CType(resources.GetObject("tsClose.Image"), System.Drawing.Image)
        Me.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsClose.Name = "tsClose"
        Me.tsClose.Size = New System.Drawing.Size(40, 22)
        Me.tsClose.Text = "&Close"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox1.Location = New System.Drawing.Point(634, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(107, 23)
        Me.TextBox1.TabIndex = 136
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox2.Location = New System.Drawing.Point(634, 62)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(107, 23)
        Me.TextBox2.TabIndex = 137
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(577, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "TransNo :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(572, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 139
        Me.Label7.Text = "Added By:"
        '
        'frmGSreturnSupplierD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 517)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.tsGSreturn)
        Me.Controls.Add(Me.pbar1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tbDisc3Net)
        Me.Controls.Add(Me.tbDisc2Net)
        Me.Controls.Add(Me.tbDisc1Net)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbNetAmount)
        Me.Controls.Add(Me.tbDisc3)
        Me.Controls.Add(Me.tbDisc2)
        Me.Controls.Add(Me.tbDisc1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbGrossAmt)
        Me.Controls.Add(Me.NuPD3)
        Me.Controls.Add(Me.NuPD2)
        Me.Controls.Add(Me.NuPD1)
        Me.Controls.Add(Me.cbxPriceType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbRemarks)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbWarehouse)
        Me.Controls.Add(Me.tbSupplier)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxSupplier)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxWarehouse)
        Me.Controls.Add(Me.RcvDate)
        Me.Controls.Add(Me.tsGSreturnSupplier)
        Me.Controls.Add(Me.dgvRcvItem)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "frmGSreturnSupplierD"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENTER GOOD STOCK RETURN TO SUPPLIER"
        CType(Me.dgvRcvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsGSreturnSupplier.ResumeLayout(False)
        Me.tsGSreturnSupplier.PerformLayout()
        CType(Me.NuPD3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuPD2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuPD1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsGSreturn.ResumeLayout(False)
        Me.tsGSreturn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvRcvItem As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsGSreturnSupplier As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsAddItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbWarehouse As System.Windows.Forms.TextBox
    Friend WithEvents tbSupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxWarehouse As System.Windows.Forms.ComboBox
    Friend WithEvents RcvDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxPriceType As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbDisc3Net As System.Windows.Forms.TextBox
    Friend WithEvents tbDisc2Net As System.Windows.Forms.TextBox
    Friend WithEvents tbDisc1Net As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbNetAmount As System.Windows.Forms.TextBox
    Friend WithEvents tbDisc3 As System.Windows.Forms.TextBox
    Friend WithEvents tbDisc2 As System.Windows.Forms.TextBox
    Friend WithEvents tbDisc1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbGrossAmt As System.Windows.Forms.TextBox
    Friend WithEvents NuPD3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NuPD2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NuPD1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents pbar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents tsGSreturn As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsSsavePrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
