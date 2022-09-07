<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailofOutsRcv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetailofOutsRcv))
        Me.dgvDetailofOuts = New System.Windows.Forms.DataGridView()
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
        Me.tsDetailofOuts = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.Go = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintDetailsofOuts = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.dptOREndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpORstartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpORendDate = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpCufOff = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblOutletType = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbOutletType = New System.Windows.Forms.TextBox()
        Me.lblAreaTerritory = New System.Windows.Forms.Label()
        Me.lblAreaT = New System.Windows.Forms.Label()
        Me.tbArea = New System.Windows.Forms.TextBox()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.tbCustomer = New System.Windows.Forms.TextBox()
        Me.lblWhs = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbWhs = New System.Windows.Forms.TextBox()
        Me.tbSalesman = New System.Windows.Forms.TextBox()
        Me.lblSalesmanName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkTypeOper = New System.Windows.Forms.CheckBox()
        Me.chkOutletType = New System.Windows.Forms.CheckBox()
        Me.chkArea = New System.Windows.Forms.CheckBox()
        Me.chkCustomer = New System.Windows.Forms.CheckBox()
        Me.chkWarehouse = New System.Windows.Forms.CheckBox()
        Me.chkSalesman = New System.Windows.Forms.CheckBox()
        CType(Me.dgvDetailofOuts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsDetailofOuts.SuspendLayout()
        Me.gbOptions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDetailofOuts
        '
        Me.dgvDetailofOuts.AllowUserToAddRows = False
        Me.dgvDetailofOuts.AllowUserToResizeRows = False
        Me.dgvDetailofOuts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvDetailofOuts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetailofOuts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.dgvDetailofOuts.Location = New System.Drawing.Point(12, 163)
        Me.dgvDetailofOuts.Name = "dgvDetailofOuts"
        Me.dgvDetailofOuts.RowHeadersVisible = False
        Me.dgvDetailofOuts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetailofOuts.Size = New System.Drawing.Size(1140, 434)
        Me.dgvDetailofOuts.TabIndex = 208
        '
        'Column1
        '
        Me.Column1.HeaderText = "CUSTOMER"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 300
        '
        'Column2
        '
        Me.Column2.HeaderText = "TERM"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 50
        '
        'Column3
        '
        Me.Column3.HeaderText = "DATE"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 75
        '
        'Column4
        '
        Me.Column4.HeaderText = "DOC NO"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "AMOUNT"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "CURRENT"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "1-6DAYS"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "7-15DAYS"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "16-20DAYS"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "21-29DAYS"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "30DAYS&ABOVE"
        Me.Column11.Name = "Column11"
        '
        'tsDetailofOuts
        '
        Me.tsDetailofOuts.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsDetailofOuts.Dock = System.Windows.Forms.DockStyle.None
        Me.tsDetailofOuts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsDetailofOuts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.Go, Me.ToolStripSeparator33, Me.PrintDetailsofOuts, Me.ToolStripSeparator34})
        Me.tsDetailofOuts.Location = New System.Drawing.Point(1025, 5)
        Me.tsDetailofOuts.Name = "tsDetailofOuts"
        Me.tsDetailofOuts.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsDetailofOuts.Size = New System.Drawing.Size(129, 25)
        Me.tsDetailofOuts.TabIndex = 238
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
        'PrintDetailsofOuts
        '
        Me.PrintDetailsofOuts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PrintDetailsofOuts.Image = CType(resources.GetObject("PrintDetailsofOuts.Image"), System.Drawing.Image)
        Me.PrintDetailsofOuts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintDetailsofOuts.Name = "PrintDetailsofOuts"
        Me.PrintDetailsofOuts.Size = New System.Drawing.Size(80, 22)
        Me.PrintDetailsofOuts.Text = "Print Preview"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.dptOREndDate)
        Me.gbOptions.Controls.Add(Me.dtpORstartDate)
        Me.gbOptions.Controls.Add(Me.dtpORendDate)
        Me.gbOptions.Controls.Add(Me.Label10)
        Me.gbOptions.Controls.Add(Me.Label4)
        Me.gbOptions.Controls.Add(Me.dtpCufOff)
        Me.gbOptions.Location = New System.Drawing.Point(858, 40)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(296, 116)
        Me.gbOptions.TabIndex = 237
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = "Options"
        '
        'dptOREndDate
        '
        Me.dptOREndDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dptOREndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dptOREndDate.Location = New System.Drawing.Point(187, 80)
        Me.dptOREndDate.Name = "dptOREndDate"
        Me.dptOREndDate.Size = New System.Drawing.Size(93, 22)
        Me.dptOREndDate.TabIndex = 249
        '
        'dtpORstartDate
        '
        Me.dtpORstartDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpORstartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpORstartDate.Location = New System.Drawing.Point(187, 52)
        Me.dtpORstartDate.Name = "dtpORstartDate"
        Me.dtpORstartDate.Size = New System.Drawing.Size(93, 22)
        Me.dtpORstartDate.TabIndex = 248
        '
        'dtpORendDate
        '
        Me.dtpORendDate.AutoSize = True
        Me.dtpORendDate.Location = New System.Drawing.Point(87, 85)
        Me.dtpORendDate.Name = "dtpORendDate"
        Me.dtpORendDate.Size = New System.Drawing.Size(96, 13)
        Me.dtpORendDate.TabIndex = 247
        Me.dtpORendDate.Text = "OR Ending Date :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(83, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 13)
        Me.Label10.TabIndex = 246
        Me.Label10.Text = "OR Starting Date :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 13)
        Me.Label4.TabIndex = 245
        Me.Label4.Text = "Cut Off Date [Blank for Today] :"
        '
        'dtpCufOff
        '
        Me.dtpCufOff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpCufOff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCufOff.Location = New System.Drawing.Point(187, 24)
        Me.dtpCufOff.Name = "dtpCufOff"
        Me.dtpCufOff.Size = New System.Drawing.Size(93, 22)
        Me.dtpCufOff.TabIndex = 244
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 13)
        Me.Label7.TabIndex = 236
        Me.Label7.Text = "Customer [Blank = All] :"
        '
        'lblOutletType
        '
        Me.lblOutletType.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutletType.Location = New System.Drawing.Point(264, 110)
        Me.lblOutletType.Name = "lblOutletType"
        Me.lblOutletType.Size = New System.Drawing.Size(316, 22)
        Me.lblOutletType.TabIndex = 235
        Me.lblOutletType.Text = "OUTLET TYPE"
        Me.lblOutletType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblOutletType.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 13)
        Me.Label6.TabIndex = 234
        Me.Label6.Text = "Outlet Type [Blank = All] :"
        '
        'tbOutletType
        '
        Me.tbOutletType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbOutletType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbOutletType.Location = New System.Drawing.Point(165, 110)
        Me.tbOutletType.MaxLength = 50
        Me.tbOutletType.Name = "tbOutletType"
        Me.tbOutletType.Size = New System.Drawing.Size(92, 22)
        Me.tbOutletType.TabIndex = 233
        '
        'lblAreaTerritory
        '
        Me.lblAreaTerritory.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreaTerritory.Location = New System.Drawing.Point(264, 85)
        Me.lblAreaTerritory.Name = "lblAreaTerritory"
        Me.lblAreaTerritory.Size = New System.Drawing.Size(316, 22)
        Me.lblAreaTerritory.TabIndex = 232
        Me.lblAreaTerritory.Text = "AREA/TERRITORY"
        Me.lblAreaTerritory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAreaTerritory.Visible = False
        '
        'lblAreaT
        '
        Me.lblAreaT.AutoSize = True
        Me.lblAreaT.Location = New System.Drawing.Point(15, 89)
        Me.lblAreaT.Name = "lblAreaT"
        Me.lblAreaT.Size = New System.Drawing.Size(146, 13)
        Me.lblAreaT.TabIndex = 231
        Me.lblAreaT.Text = "Area/Territory [Blank = All] :"
        '
        'tbArea
        '
        Me.tbArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbArea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbArea.Location = New System.Drawing.Point(165, 85)
        Me.tbArea.MaxLength = 50
        Me.tbArea.Name = "tbArea"
        Me.tbArea.Size = New System.Drawing.Size(92, 22)
        Me.tbArea.TabIndex = 230
        '
        'lblCustomer
        '
        Me.lblCustomer.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(264, 60)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(316, 22)
        Me.lblCustomer.TabIndex = 220
        Me.lblCustomer.Text = "CUSTOMER NAME"
        Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCustomer.Visible = False
        '
        'tbCustomer
        '
        Me.tbCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbCustomer.Location = New System.Drawing.Point(165, 60)
        Me.tbCustomer.MaxLength = 50
        Me.tbCustomer.Name = "tbCustomer"
        Me.tbCustomer.Size = New System.Drawing.Size(92, 22)
        Me.tbCustomer.TabIndex = 219
        '
        'lblWhs
        '
        Me.lblWhs.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhs.Location = New System.Drawing.Point(264, 34)
        Me.lblWhs.Name = "lblWhs"
        Me.lblWhs.Size = New System.Drawing.Size(316, 22)
        Me.lblWhs.TabIndex = 218
        Me.lblWhs.Text = "WAREHOUSE NAME"
        Me.lblWhs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblWhs.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 13)
        Me.Label5.TabIndex = 217
        Me.Label5.Text = "Warehouse [Blank = All] :"
        '
        'tbWhs
        '
        Me.tbWhs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbWhs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbWhs.Location = New System.Drawing.Point(165, 34)
        Me.tbWhs.MaxLength = 50
        Me.tbWhs.Name = "tbWhs"
        Me.tbWhs.Size = New System.Drawing.Size(92, 22)
        Me.tbWhs.TabIndex = 216
        '
        'tbSalesman
        '
        Me.tbSalesman.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSalesman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSalesman.Location = New System.Drawing.Point(165, 9)
        Me.tbSalesman.MaxLength = 50
        Me.tbSalesman.Name = "tbSalesman"
        Me.tbSalesman.Size = New System.Drawing.Size(92, 22)
        Me.tbSalesman.TabIndex = 213
        '
        'lblSalesmanName
        '
        Me.lblSalesmanName.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesmanName.Location = New System.Drawing.Point(264, 9)
        Me.lblSalesmanName.Name = "lblSalesmanName"
        Me.lblSalesmanName.Size = New System.Drawing.Size(316, 22)
        Me.lblSalesmanName.TabIndex = 215
        Me.lblSalesmanName.Text = "SALESMAN NAME"
        Me.lblSalesmanName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSalesmanName.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 214
        Me.Label1.Text = "Salesman [Blank = All] :"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(264, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(316, 22)
        Me.Label8.TabIndex = 243
        Me.Label8.Text = "TYPE OF OPERATION"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 13)
        Me.Label9.TabIndex = 242
        Me.Label9.Text = "Type Oper [Blank = All] :"
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox1.Location = New System.Drawing.Point(165, 135)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(92, 22)
        Me.TextBox1.TabIndex = 241
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkTypeOper)
        Me.GroupBox1.Controls.Add(Me.chkOutletType)
        Me.GroupBox1.Controls.Add(Me.chkArea)
        Me.GroupBox1.Controls.Add(Me.chkCustomer)
        Me.GroupBox1.Controls.Add(Me.chkWarehouse)
        Me.GroupBox1.Controls.Add(Me.chkSalesman)
        Me.GroupBox1.Location = New System.Drawing.Point(604, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 116)
        Me.GroupBox1.TabIndex = 250
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sort By"
        '
        'chkTypeOper
        '
        Me.chkTypeOper.AutoSize = True
        Me.chkTypeOper.Location = New System.Drawing.Point(123, 80)
        Me.chkTypeOper.Name = "chkTypeOper"
        Me.chkTypeOper.Size = New System.Drawing.Size(119, 17)
        Me.chkTypeOper.TabIndex = 255
        Me.chkTypeOper.Text = "Type of Operation"
        Me.chkTypeOper.UseVisualStyleBackColor = True
        '
        'chkOutletType
        '
        Me.chkOutletType.AutoSize = True
        Me.chkOutletType.Location = New System.Drawing.Point(123, 55)
        Me.chkOutletType.Name = "chkOutletType"
        Me.chkOutletType.Size = New System.Drawing.Size(85, 17)
        Me.chkOutletType.TabIndex = 254
        Me.chkOutletType.Text = "Outlet Type"
        Me.chkOutletType.UseVisualStyleBackColor = True
        '
        'chkArea
        '
        Me.chkArea.AutoSize = True
        Me.chkArea.Location = New System.Drawing.Point(123, 29)
        Me.chkArea.Name = "chkArea"
        Me.chkArea.Size = New System.Drawing.Size(95, 17)
        Me.chkArea.TabIndex = 253
        Me.chkArea.Text = "Area/Territory"
        Me.chkArea.UseVisualStyleBackColor = True
        '
        'chkCustomer
        '
        Me.chkCustomer.AutoSize = True
        Me.chkCustomer.Location = New System.Drawing.Point(6, 79)
        Me.chkCustomer.Name = "chkCustomer"
        Me.chkCustomer.Size = New System.Drawing.Size(75, 17)
        Me.chkCustomer.TabIndex = 252
        Me.chkCustomer.Text = "Customer"
        Me.chkCustomer.UseVisualStyleBackColor = True
        '
        'chkWarehouse
        '
        Me.chkWarehouse.AutoSize = True
        Me.chkWarehouse.Location = New System.Drawing.Point(6, 55)
        Me.chkWarehouse.Name = "chkWarehouse"
        Me.chkWarehouse.Size = New System.Drawing.Size(85, 17)
        Me.chkWarehouse.TabIndex = 251
        Me.chkWarehouse.Text = "Warehouse"
        Me.chkWarehouse.UseVisualStyleBackColor = True
        '
        'chkSalesman
        '
        Me.chkSalesman.AutoSize = True
        Me.chkSalesman.Location = New System.Drawing.Point(6, 32)
        Me.chkSalesman.Name = "chkSalesman"
        Me.chkSalesman.Size = New System.Drawing.Size(74, 17)
        Me.chkSalesman.TabIndex = 0
        Me.chkSalesman.Text = "Salesman"
        Me.chkSalesman.UseVisualStyleBackColor = True
        '
        'frmDetailofOutsRcv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1166, 605)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.tsDetailofOuts)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblOutletType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbOutletType)
        Me.Controls.Add(Me.lblAreaTerritory)
        Me.Controls.Add(Me.lblAreaT)
        Me.Controls.Add(Me.tbArea)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.tbCustomer)
        Me.Controls.Add(Me.lblWhs)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbWhs)
        Me.Controls.Add(Me.lblSalesmanName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbSalesman)
        Me.Controls.Add(Me.dgvDetailofOuts)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailofOutsRcv"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DETAIL OF OUTSTANDING RECEIVABLE"
        CType(Me.dgvDetailofOuts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsDetailofOuts.ResumeLayout(False)
        Me.tsDetailofOuts.PerformLayout()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDetailofOuts As System.Windows.Forms.DataGridView
    Friend WithEvents tsDetailofOuts As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Go As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintDetailsofOuts As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents gbOptions As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblOutletType As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbOutletType As System.Windows.Forms.TextBox
    Friend WithEvents lblAreaTerritory As System.Windows.Forms.Label
    Friend WithEvents lblAreaT As System.Windows.Forms.Label
    Friend WithEvents tbArea As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents tbCustomer As System.Windows.Forms.TextBox
    Friend WithEvents lblWhs As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbWhs As System.Windows.Forms.TextBox
    Friend WithEvents tbSalesman As System.Windows.Forms.TextBox
    Friend WithEvents lblSalesmanName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dptOREndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpORstartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpORendDate As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpCufOff As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTypeOper As System.Windows.Forms.CheckBox
    Friend WithEvents chkOutletType As System.Windows.Forms.CheckBox
    Friend WithEvents chkArea As System.Windows.Forms.CheckBox
    Friend WithEvents chkCustomer As System.Windows.Forms.CheckBox
    Friend WithEvents chkWarehouse As System.Windows.Forms.CheckBox
    Friend WithEvents chkSalesman As System.Windows.Forms.CheckBox
End Class
