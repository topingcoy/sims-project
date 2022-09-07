<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListofSalesInvoicesDetailed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListofSalesInvoicesDetailed))
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.chkSortSalesman = New System.Windows.Forms.CheckBox()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.chkSortCustomer = New System.Windows.Forms.CheckBox()
        Me.pbar1 = New System.Windows.Forms.ProgressBar()
        Me.txtGrandTotal = New System.Windows.Forms.TextBox()
        Me.txtCustomername = New System.Windows.Forms.TextBox()
        Me.txtSalesmanName = New System.Windows.Forms.TextBox()
        Me.tsListInvoice = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGo = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCustCode = New System.Windows.Forms.TextBox()
        Me.txtSlmncode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sDate2 = New System.Windows.Forms.DateTimePicker()
        Me.sDate1 = New System.Windows.Forms.DateTimePicker()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvInvoiceList1 = New System.Windows.Forms.DataGridView()
        Me.trnos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invnos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ddates = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salemans = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custnames = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgITemDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgqty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgunit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grsamnts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.disc1s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.netamnts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkCustomer = New System.Windows.Forms.CheckBox()
        Me.txtProfit = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.chkSalesman = New System.Windows.Forms.CheckBox()
        Me.tsListInvoice.SuspendLayout()
        Me.gbOptions.SuspendLayout()
        CType(Me.dgvInvoiceList1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkSortSalesman
        '
        Me.chkSortSalesman.AutoSize = True
        Me.chkSortSalesman.Enabled = False
        Me.chkSortSalesman.Location = New System.Drawing.Point(5, 21)
        Me.chkSortSalesman.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkSortSalesman.Name = "chkSortSalesman"
        Me.chkSortSalesman.Size = New System.Drawing.Size(141, 21)
        Me.chkSortSalesman.TabIndex = 136
        Me.chkSortSalesman.Text = "Sort by Salesman"
        Me.chkSortSalesman.UseVisualStyleBackColor = True
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 27)
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(43, 24)
        Me.btnPrint.Text = "&Print"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 27)
        '
        'chkSortCustomer
        '
        Me.chkSortCustomer.AutoSize = True
        Me.chkSortCustomer.Enabled = False
        Me.chkSortCustomer.Location = New System.Drawing.Point(5, 38)
        Me.chkSortCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkSortCustomer.Name = "chkSortCustomer"
        Me.chkSortCustomer.Size = New System.Drawing.Size(139, 21)
        Me.chkSortCustomer.TabIndex = 138
        Me.chkSortCustomer.Text = "Sort by Customer"
        Me.chkSortCustomer.UseVisualStyleBackColor = True
        '
        'pbar1
        '
        Me.pbar1.Location = New System.Drawing.Point(15, 610)
        Me.pbar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbar1.Name = "pbar1"
        Me.pbar1.Size = New System.Drawing.Size(1351, 10)
        Me.pbar1.TabIndex = 284
        Me.pbar1.Visible = False
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGrandTotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtGrandTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrandTotal.Location = New System.Drawing.Point(300, 645)
        Me.txtGrandTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGrandTotal.MaxLength = 50
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.ReadOnly = True
        Me.txtGrandTotal.Size = New System.Drawing.Size(93, 27)
        Me.txtGrandTotal.TabIndex = 285
        Me.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCustomername
        '
        Me.txtCustomername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCustomername.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtCustomername.Location = New System.Drawing.Point(359, 68)
        Me.txtCustomername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCustomername.MaxLength = 50
        Me.txtCustomername.Name = "txtCustomername"
        Me.txtCustomername.ReadOnly = True
        Me.txtCustomername.Size = New System.Drawing.Size(359, 22)
        Me.txtCustomername.TabIndex = 282
        '
        'txtSalesmanName
        '
        Me.txtSalesmanName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSalesmanName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtSalesmanName.Location = New System.Drawing.Point(359, 42)
        Me.txtSalesmanName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSalesmanName.MaxLength = 50
        Me.txtSalesmanName.Name = "txtSalesmanName"
        Me.txtSalesmanName.ReadOnly = True
        Me.txtSalesmanName.Size = New System.Drawing.Size(359, 22)
        Me.txtSalesmanName.TabIndex = 281
        '
        'tsListInvoice
        '
        Me.tsListInvoice.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsListInvoice.Dock = System.Windows.Forms.DockStyle.None
        Me.tsListInvoice.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsListInvoice.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.btnGo, Me.ToolStripSeparator33, Me.btnPrint, Me.ToolStripSeparator34, Me.btnClose})
        Me.tsListInvoice.Location = New System.Drawing.Point(1228, 9)
        Me.tsListInvoice.Name = "tsListInvoice"
        Me.tsListInvoice.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsListInvoice.Size = New System.Drawing.Size(96, 27)
        Me.tsListInvoice.TabIndex = 279
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 27)
        '
        'btnGo
        '
        Me.btnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnGo.Image = CType(resources.GetObject("btnGo.Image"), System.Drawing.Image)
        Me.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(32, 24)
        Me.btnGo.Text = "&Go"
        '
        'btnClose
        '
        Me.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(49, 24)
        Me.btnClose.Text = "&Close"
        Me.btnClose.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 17)
        Me.Label7.TabIndex = 278
        Me.Label7.Text = "Customer [Blank = All] :"
        '
        'txtCustCode
        '
        Me.txtCustCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCustCode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtCustCode.Location = New System.Drawing.Point(179, 66)
        Me.txtCustCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCustCode.MaxLength = 50
        Me.txtCustCode.Name = "txtCustCode"
        Me.txtCustCode.Size = New System.Drawing.Size(175, 22)
        Me.txtCustCode.TabIndex = 277
        '
        'txtSlmncode
        '
        Me.txtSlmncode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSlmncode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtSlmncode.Location = New System.Drawing.Point(179, 41)
        Me.txtSlmncode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSlmncode.MaxLength = 50
        Me.txtSlmncode.Name = "txtSlmncode"
        Me.txtSlmncode.Size = New System.Drawing.Size(175, 22)
        Me.txtSlmncode.TabIndex = 275
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(303, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 274
        Me.Label3.Text = "Ending Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 273
        Me.Label2.Text = "Stating Date :"
        '
        'sDate2
        '
        Me.sDate2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sDate2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.sDate2.Location = New System.Drawing.Point(404, 15)
        Me.sDate2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.sDate2.Name = "sDate2"
        Me.sDate2.Size = New System.Drawing.Size(107, 22)
        Me.sDate2.TabIndex = 272
        '
        'sDate1
        '
        Me.sDate1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sDate1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.sDate1.Location = New System.Drawing.Point(179, 15)
        Me.sDate1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.sDate1.Name = "sDate1"
        Me.sDate1.Size = New System.Drawing.Size(111, 22)
        Me.sDate1.TabIndex = 271
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.chkSortCustomer)
        Me.gbOptions.Controls.Add(Me.chkSortSalesman)
        Me.gbOptions.Location = New System.Drawing.Point(960, 32)
        Me.gbOptions.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbOptions.Size = New System.Drawing.Size(155, 69)
        Me.gbOptions.TabIndex = 280
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = "Options"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 17)
        Me.Label1.TabIndex = 276
        Me.Label1.Text = "Salesman [Blank = All] :"
        '
        'dgvInvoiceList1
        '
        Me.dgvInvoiceList1.AllowUserToAddRows = False
        Me.dgvInvoiceList1.AllowUserToResizeRows = False
        Me.dgvInvoiceList1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvInvoiceList1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoiceList1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.trnos, Me.invnos, Me.ddates, Me.salemans, Me.custnames, Me.dgITEM, Me.dgITemDesc, Me.dgqty, Me.dgunit, Me.grsamnts, Me.disc1s, Me.netamnts})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInvoiceList1.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgvInvoiceList1.Location = New System.Drawing.Point(15, 107)
        Me.dgvInvoiceList1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvInvoiceList1.Name = "dgvInvoiceList1"
        Me.dgvInvoiceList1.RowHeadersVisible = False
        Me.dgvInvoiceList1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInvoiceList1.Size = New System.Drawing.Size(1357, 500)
        Me.dgvInvoiceList1.TabIndex = 290
        '
        'trnos
        '
        Me.trnos.HeaderText = "TRANSNO"
        Me.trnos.Name = "trnos"
        Me.trnos.Visible = False
        Me.trnos.Width = 80
        '
        'invnos
        '
        Me.invnos.HeaderText = "INVOICE-NO"
        Me.invnos.Name = "invnos"
        Me.invnos.ReadOnly = True
        Me.invnos.Width = 80
        '
        'ddates
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ddates.DefaultCellStyle = DataGridViewCellStyle9
        Me.ddates.HeaderText = "DATE"
        Me.ddates.Name = "ddates"
        Me.ddates.ReadOnly = True
        Me.ddates.Width = 66
        '
        'salemans
        '
        Me.salemans.HeaderText = "SLMN"
        Me.salemans.Name = "salemans"
        Me.salemans.ReadOnly = True
        Me.salemans.Width = 50
        '
        'custnames
        '
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.custnames.DefaultCellStyle = DataGridViewCellStyle10
        Me.custnames.HeaderText = "CUSTOMER NAME"
        Me.custnames.Name = "custnames"
        Me.custnames.ReadOnly = True
        Me.custnames.Width = 175
        '
        'dgITEM
        '
        Me.dgITEM.HeaderText = "ITEM"
        Me.dgITEM.Name = "dgITEM"
        Me.dgITEM.ReadOnly = True
        Me.dgITEM.Width = 80
        '
        'dgITemDesc
        '
        Me.dgITemDesc.HeaderText = "ITEM DESCRIPTION"
        Me.dgITemDesc.Name = "dgITemDesc"
        Me.dgITemDesc.ReadOnly = True
        Me.dgITemDesc.Width = 350
        '
        'dgqty
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle11.Format = "N0"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.dgqty.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgqty.HeaderText = "QTY"
        Me.dgqty.Name = "dgqty"
        Me.dgqty.ReadOnly = True
        Me.dgqty.Width = 50
        '
        'dgunit
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.dgunit.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgunit.HeaderText = "UNIT"
        Me.dgunit.Name = "dgunit"
        Me.dgunit.ReadOnly = True
        Me.dgunit.Width = 40
        '
        'grsamnts
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.grsamnts.DefaultCellStyle = DataGridViewCellStyle13
        Me.grsamnts.HeaderText = "PRICE"
        Me.grsamnts.Name = "grsamnts"
        Me.grsamnts.ReadOnly = True
        '
        'disc1s
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.disc1s.DefaultCellStyle = DataGridViewCellStyle14
        Me.disc1s.HeaderText = "COST"
        Me.disc1s.Name = "disc1s"
        Me.disc1s.ReadOnly = True
        Me.disc1s.Width = 70
        '
        'netamnts
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N2"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.netamnts.DefaultCellStyle = DataGridViewCellStyle15
        Me.netamnts.HeaderText = "PROFIT"
        Me.netamnts.Name = "netamnts"
        Me.netamnts.ReadOnly = True
        Me.netamnts.Width = 90
        '
        'chkCustomer
        '
        Me.chkCustomer.AutoSize = True
        Me.chkCustomer.Location = New System.Drawing.Point(735, 69)
        Me.chkCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkCustomer.Name = "chkCustomer"
        Me.chkCustomer.Size = New System.Drawing.Size(115, 21)
        Me.chkCustomer.TabIndex = 289
        Me.chkCustomer.Text = "Blank for ALL"
        Me.chkCustomer.UseVisualStyleBackColor = True
        '
        'txtProfit
        '
        Me.txtProfit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProfit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtProfit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfit.Location = New System.Drawing.Point(207, 645)
        Me.txtProfit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtProfit.MaxLength = 50
        Me.txtProfit.Name = "txtProfit"
        Me.txtProfit.ReadOnly = True
        Me.txtProfit.Size = New System.Drawing.Size(91, 27)
        Me.txtProfit.TabIndex = 288
        Me.txtProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmount
        '
        Me.txtAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAmount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(21, 645)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAmount.MaxLength = 50
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(89, 27)
        Me.txtAmount.TabIndex = 287
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCost
        '
        Me.txtCost.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtCost.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(113, 645)
        Me.txtCost.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCost.MaxLength = 50
        Me.txtCost.Name = "txtCost"
        Me.txtCost.ReadOnly = True
        Me.txtCost.Size = New System.Drawing.Size(91, 27)
        Me.txtCost.TabIndex = 286
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkSalesman
        '
        Me.chkSalesman.AutoSize = True
        Me.chkSalesman.Location = New System.Drawing.Point(735, 44)
        Me.chkSalesman.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkSalesman.Name = "chkSalesman"
        Me.chkSalesman.Size = New System.Drawing.Size(115, 21)
        Me.chkSalesman.TabIndex = 283
        Me.chkSalesman.Text = "Blank for ALL"
        Me.chkSalesman.UseVisualStyleBackColor = True
        '
        'frmListofSalesInvoicesDetailed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1384, 625)
        Me.Controls.Add(Me.pbar1)
        Me.Controls.Add(Me.txtGrandTotal)
        Me.Controls.Add(Me.txtCustomername)
        Me.Controls.Add(Me.txtSalesmanName)
        Me.Controls.Add(Me.tsListInvoice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCustCode)
        Me.Controls.Add(Me.txtSlmncode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.sDate2)
        Me.Controls.Add(Me.sDate1)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvInvoiceList1)
        Me.Controls.Add(Me.chkCustomer)
        Me.Controls.Add(Me.txtProfit)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.chkSalesman)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListofSalesInvoicesDetailed"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LIST OF SALES INVOICES (With Item Detailed)"
        Me.tsListInvoice.ResumeLayout(False)
        Me.tsListInvoice.PerformLayout()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        CType(Me.dgvInvoiceList1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkSortSalesman As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkSortCustomer As System.Windows.Forms.CheckBox
    Friend WithEvents pbar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents txtGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomername As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesmanName As System.Windows.Forms.TextBox
    Friend WithEvents tsListInvoice As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCustCode As System.Windows.Forms.TextBox
    Friend WithEvents txtSlmncode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents sDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents sDate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbOptions As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvInvoiceList1 As System.Windows.Forms.DataGridView
    Friend WithEvents trnos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents invnos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ddates As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents salemans As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents custnames As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgITemDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgqty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgunit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grsamnts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents disc1s As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents netamnts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkCustomer As System.Windows.Forms.CheckBox
    Friend WithEvents txtProfit As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents chkSalesman As System.Windows.Forms.CheckBox
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
End Class
