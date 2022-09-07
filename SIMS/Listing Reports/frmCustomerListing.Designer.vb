<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerListing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerListing))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblOutletType = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbOutletType = New System.Windows.Forms.TextBox()
        Me.lblAreaTerritory = New System.Windows.Forms.Label()
        Me.lblAreaT = New System.Windows.Forms.Label()
        Me.tbArea = New System.Windows.Forms.TextBox()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbBrand = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbCategory = New System.Windows.Forms.TextBox()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbSupplier = New System.Windows.Forms.TextBox()
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
        Me.dtpCustListEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpCustListStart = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvInvoiceList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsCustomerList = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.Go = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintCustomerList = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.cbxOnlyActive = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvInvoiceList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsCustomerList.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 13)
        Me.Label7.TabIndex = 189
        Me.Label7.Text = "Customer [Blank = All] :"
        '
        'lblOutletType
        '
        Me.lblOutletType.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutletType.Location = New System.Drawing.Point(266, 163)
        Me.lblOutletType.Name = "lblOutletType"
        Me.lblOutletType.Size = New System.Drawing.Size(316, 22)
        Me.lblOutletType.TabIndex = 188
        Me.lblOutletType.Text = "OUTLET TYPE"
        Me.lblOutletType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblOutletType.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 13)
        Me.Label6.TabIndex = 187
        Me.Label6.Text = "Outlet Type [Blank = All] :"
        '
        'tbOutletType
        '
        Me.tbOutletType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbOutletType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbOutletType.Location = New System.Drawing.Point(167, 163)
        Me.tbOutletType.MaxLength = 50
        Me.tbOutletType.Name = "tbOutletType"
        Me.tbOutletType.Size = New System.Drawing.Size(92, 22)
        Me.tbOutletType.TabIndex = 186
        '
        'lblAreaTerritory
        '
        Me.lblAreaTerritory.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreaTerritory.Location = New System.Drawing.Point(266, 88)
        Me.lblAreaTerritory.Name = "lblAreaTerritory"
        Me.lblAreaTerritory.Size = New System.Drawing.Size(316, 22)
        Me.lblAreaTerritory.TabIndex = 185
        Me.lblAreaTerritory.Text = "AREA/TERRITORY"
        Me.lblAreaTerritory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAreaTerritory.Visible = False
        '
        'lblAreaT
        '
        Me.lblAreaT.AutoSize = True
        Me.lblAreaT.Location = New System.Drawing.Point(17, 92)
        Me.lblAreaT.Name = "lblAreaT"
        Me.lblAreaT.Size = New System.Drawing.Size(146, 13)
        Me.lblAreaT.TabIndex = 184
        Me.lblAreaT.Text = "Area/Territory [Blank = All] :"
        '
        'tbArea
        '
        Me.tbArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbArea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbArea.Location = New System.Drawing.Point(167, 88)
        Me.tbArea.MaxLength = 50
        Me.tbArea.Name = "tbArea"
        Me.tbArea.Size = New System.Drawing.Size(92, 22)
        Me.tbArea.TabIndex = 183
        '
        'lblBrand
        '
        Me.lblBrand.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrand.Location = New System.Drawing.Point(265, 111)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(316, 22)
        Me.lblBrand.TabIndex = 182
        Me.lblBrand.Text = "BRAND NAME"
        Me.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblBrand.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 13)
        Me.Label11.TabIndex = 181
        Me.Label11.Text = "Who has Sales in Brand :"
        '
        'tbBrand
        '
        Me.tbBrand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbBrand.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbBrand.Location = New System.Drawing.Point(166, 111)
        Me.tbBrand.MaxLength = 50
        Me.tbBrand.Name = "tbBrand"
        Me.tbBrand.Size = New System.Drawing.Size(92, 22)
        Me.tbBrand.TabIndex = 180
        '
        'lblCategory
        '
        Me.lblCategory.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(265, 86)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(316, 22)
        Me.lblCategory.TabIndex = 179
        Me.lblCategory.Text = "CATEGORY NAME"
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCategory.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 13)
        Me.Label10.TabIndex = 178
        Me.Label10.Text = "Who has Sales in Category :"
        '
        'tbCategory
        '
        Me.tbCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbCategory.Location = New System.Drawing.Point(166, 86)
        Me.tbCategory.MaxLength = 50
        Me.tbCategory.Name = "tbCategory"
        Me.tbCategory.Size = New System.Drawing.Size(92, 22)
        Me.tbCategory.TabIndex = 177
        '
        'lblSupplier
        '
        Me.lblSupplier.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplier.Location = New System.Drawing.Point(265, 36)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(316, 22)
        Me.lblSupplier.TabIndex = 176
        Me.lblSupplier.Text = "SUPPLIER NAME"
        Me.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSupplier.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 13)
        Me.Label9.TabIndex = 175
        Me.Label9.Text = "Who has Sales in Supplier :"
        '
        'tbSupplier
        '
        Me.tbSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSupplier.Location = New System.Drawing.Point(166, 36)
        Me.tbSupplier.MaxLength = 50
        Me.tbSupplier.Name = "tbSupplier"
        Me.tbSupplier.Size = New System.Drawing.Size(92, 22)
        Me.tbSupplier.TabIndex = 174
        '
        'lblCustomer
        '
        Me.lblCustomer.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(266, 138)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(316, 22)
        Me.lblCustomer.TabIndex = 173
        Me.lblCustomer.Text = "CUSTOMER NAME"
        Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCustomer.Visible = False
        '
        'tbCustomer
        '
        Me.tbCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbCustomer.Location = New System.Drawing.Point(167, 138)
        Me.tbCustomer.MaxLength = 50
        Me.tbCustomer.Name = "tbCustomer"
        Me.tbCustomer.Size = New System.Drawing.Size(92, 22)
        Me.tbCustomer.TabIndex = 172
        '
        'lblWhs
        '
        Me.lblWhs.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhs.Location = New System.Drawing.Point(266, 113)
        Me.lblWhs.Name = "lblWhs"
        Me.lblWhs.Size = New System.Drawing.Size(316, 22)
        Me.lblWhs.TabIndex = 171
        Me.lblWhs.Text = "WAREHOUSE NAME"
        Me.lblWhs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblWhs.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 13)
        Me.Label5.TabIndex = 170
        Me.Label5.Text = "Warehouse [Blank = All] :"
        '
        'tbWhs
        '
        Me.tbWhs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbWhs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbWhs.Location = New System.Drawing.Point(167, 113)
        Me.tbWhs.MaxLength = 50
        Me.tbWhs.Name = "tbWhs"
        Me.tbWhs.Size = New System.Drawing.Size(92, 22)
        Me.tbWhs.TabIndex = 169
        '
        'lblSalesmanName
        '
        Me.lblSalesmanName.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesmanName.Location = New System.Drawing.Point(266, 38)
        Me.lblSalesmanName.Name = "lblSalesmanName"
        Me.lblSalesmanName.Size = New System.Drawing.Size(316, 22)
        Me.lblSalesmanName.TabIndex = 168
        Me.lblSalesmanName.Text = "SALESMAN NAME"
        Me.lblSalesmanName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSalesmanName.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "Salesman [Blank = All] :"
        '
        'tbSalesman
        '
        Me.tbSalesman.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSalesman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSalesman.Location = New System.Drawing.Point(167, 38)
        Me.tbSalesman.MaxLength = 50
        Me.tbSalesman.Name = "tbSalesman"
        Me.tbSalesman.Size = New System.Drawing.Size(92, 22)
        Me.tbSalesman.TabIndex = 166
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(265, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "Ending Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "Starting Date :"
        '
        'dtpCustListEnd
        '
        Me.dtpCustListEnd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpCustListEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCustListEnd.Location = New System.Drawing.Point(347, 12)
        Me.dtpCustListEnd.Name = "dtpCustListEnd"
        Me.dtpCustListEnd.Size = New System.Drawing.Size(93, 22)
        Me.dtpCustListEnd.TabIndex = 163
        '
        'dtpCustListStart
        '
        Me.dtpCustListStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpCustListStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCustListStart.Location = New System.Drawing.Point(166, 12)
        Me.dtpCustListStart.Name = "dtpCustListStart"
        Me.dtpCustListStart.Size = New System.Drawing.Size(93, 22)
        Me.dtpCustListStart.TabIndex = 162
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(266, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(316, 22)
        Me.Label4.TabIndex = 192
        Me.Label4.Text = "PROVINCE NAME"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(43, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 13)
        Me.Label8.TabIndex = 191
        Me.Label8.Text = "Province [Blank = All] :"
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox1.Location = New System.Drawing.Point(167, 63)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(92, 22)
        Me.TextBox1.TabIndex = 190
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(265, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(316, 22)
        Me.Label12.TabIndex = 195
        Me.Label12.Text = "CATEGORY NAME"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(35, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 13)
        Me.Label13.TabIndex = 194
        Me.Label13.Text = "Who has Sales In Item :"
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox2.Location = New System.Drawing.Point(166, 61)
        Me.TextBox2.MaxLength = 50
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(92, 22)
        Me.TextBox2.TabIndex = 193
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.tbSupplier)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.lblSupplier)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.tbCategory)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblCategory)
        Me.GroupBox1.Controls.Add(Me.tbBrand)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblBrand)
        Me.GroupBox1.Location = New System.Drawing.Point(671, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(598, 142)
        Me.GroupBox1.TabIndex = 196
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'dgvInvoiceList
        '
        Me.dgvInvoiceList.AllowUserToAddRows = False
        Me.dgvInvoiceList.AllowUserToResizeRows = False
        Me.dgvInvoiceList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoiceList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvInvoiceList.Location = New System.Drawing.Point(12, 191)
        Me.dgvInvoiceList.Name = "dgvInvoiceList"
        Me.dgvInvoiceList.RowHeadersVisible = False
        Me.dgvInvoiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInvoiceList.Size = New System.Drawing.Size(1257, 425)
        Me.dgvInvoiceList.TabIndex = 197
        '
        'Column1
        '
        Me.Column1.HeaderText = "CUST CODE"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "CUSTOMER NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 300
        '
        'Column3
        '
        Me.Column3.HeaderText = "ADDRESS"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 375
        '
        'Column4
        '
        Me.Column4.HeaderText = "AREA/TERRITORY"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 160
        '
        'Column5
        '
        Me.Column5.HeaderText = "CONTACT NO"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "OUTLET TYPE"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'tsCustomerList
        '
        Me.tsCustomerList.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsCustomerList.Dock = System.Windows.Forms.DockStyle.None
        Me.tsCustomerList.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsCustomerList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.Go, Me.ToolStripSeparator33, Me.PrintCustomerList, Me.ToolStripSeparator34})
        Me.tsCustomerList.Location = New System.Drawing.Point(1143, 4)
        Me.tsCustomerList.Name = "tsCustomerList"
        Me.tsCustomerList.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsCustomerList.Size = New System.Drawing.Size(129, 25)
        Me.tsCustomerList.TabIndex = 199
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
        'PrintCustomerList
        '
        Me.PrintCustomerList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PrintCustomerList.Image = CType(resources.GetObject("PrintCustomerList.Image"), System.Drawing.Image)
        Me.PrintCustomerList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintCustomerList.Name = "PrintCustomerList"
        Me.PrintCustomerList.Size = New System.Drawing.Size(80, 22)
        Me.PrintCustomerList.Text = "Print Preview"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'cbxOnlyActive
        '
        Me.cbxOnlyActive.AutoSize = True
        Me.cbxOnlyActive.Location = New System.Drawing.Point(671, 12)
        Me.cbxOnlyActive.Name = "cbxOnlyActive"
        Me.cbxOnlyActive.Size = New System.Drawing.Size(140, 17)
        Me.cbxOnlyActive.TabIndex = 196
        Me.cbxOnlyActive.Text = "Only Active Customer?"
        Me.cbxOnlyActive.UseVisualStyleBackColor = True
        '
        'frmCustomerListing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 625)
        Me.Controls.Add(Me.cbxOnlyActive)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbSalesman)
        Me.Controls.Add(Me.tsCustomerList)
        Me.Controls.Add(Me.lblSalesmanName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvInvoiceList)
        Me.Controls.Add(Me.tbWhs)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dtpCustListEnd)
        Me.Controls.Add(Me.lblWhs)
        Me.Controls.Add(Me.dtpCustListStart)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblAreaTerritory)
        Me.Controls.Add(Me.tbCustomer)
        Me.Controls.Add(Me.lblAreaT)
        Me.Controls.Add(Me.lblOutletType)
        Me.Controls.Add(Me.tbOutletType)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.tbArea)
        Me.Controls.Add(Me.Label6)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomerListing"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIST OF CUSTOMERS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvInvoiceList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsCustomerList.ResumeLayout(False)
        Me.tsCustomerList.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblOutletType As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbOutletType As System.Windows.Forms.TextBox
    Friend WithEvents lblAreaTerritory As System.Windows.Forms.Label
    Friend WithEvents lblAreaT As System.Windows.Forms.Label
    Friend WithEvents tbArea As System.Windows.Forms.TextBox
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbBrand As System.Windows.Forms.TextBox
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbCategory As System.Windows.Forms.TextBox
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbSupplier As System.Windows.Forms.TextBox
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
    Friend WithEvents dtpCustListEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCustListStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvInvoiceList As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsCustomerList As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Go As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintCustomerList As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cbxOnlyActive As System.Windows.Forms.CheckBox
End Class
