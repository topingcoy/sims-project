<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerD))
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbxMainPrincipal = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.nuSpecial = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.nuCredit = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.nuPayTerms = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbxProvince = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbxOutletType = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxTerritory = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbShipTo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbTelno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbMobile = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbCustAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbTin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbCustName = New System.Windows.Forms.TextBox()
        Me.tbCustCode = New System.Windows.Forms.TextBox()
        Me.dgvSalesman = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddSalesman = New System.Windows.Forms.Button()
        Me.tsCustomer = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewCust = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveCust = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator32 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdateCust = New System.Windows.Forms.ToolStripButton()
        Me.ClearCust = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbxAllow = New System.Windows.Forms.ComboBox()
        Me.cbxActive = New System.Windows.Forms.ComboBox()
        Me.btnDeleteSalesman = New System.Windows.Forms.Button()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.lblOutlet = New System.Windows.Forms.Label()
        Me.lblProvince = New System.Windows.Forms.Label()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.pkno = New System.Windows.Forms.Label()
        CType(Me.nuSpecial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuCredit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuPayTerms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSalesman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsCustomer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 249)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 13)
        Me.Label15.TabIndex = 76
        Me.Label15.Text = "MAIN PRINCIPAL :"
        '
        'cbxMainPrincipal
        '
        Me.cbxMainPrincipal.FormattingEnabled = True
        Me.cbxMainPrincipal.Location = New System.Drawing.Point(118, 245)
        Me.cbxMainPrincipal.Name = "cbxMainPrincipal"
        Me.cbxMainPrincipal.Size = New System.Drawing.Size(80, 21)
        Me.cbxMainPrincipal.TabIndex = 75
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(518, 157)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 13)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "SPECIAL DISCOUNT :"
        '
        'nuSpecial
        '
        Me.nuSpecial.Location = New System.Drawing.Point(631, 152)
        Me.nuSpecial.Name = "nuSpecial"
        Me.nuSpecial.Size = New System.Drawing.Size(132, 22)
        Me.nuSpecial.TabIndex = 72
        Me.nuSpecial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(547, 129)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 13)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "CREDIT LIMIT :"
        '
        'nuCredit
        '
        Me.nuCredit.Location = New System.Drawing.Point(631, 124)
        Me.nuCredit.Name = "nuCredit"
        Me.nuCredit.Size = New System.Drawing.Size(132, 22)
        Me.nuCredit.TabIndex = 70
        Me.nuCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(531, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 13)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "PAYMENT TERMS :"
        '
        'nuPayTerms
        '
        Me.nuPayTerms.Location = New System.Drawing.Point(631, 96)
        Me.nuPayTerms.Name = "nuPayTerms"
        Me.nuPayTerms.Size = New System.Drawing.Size(132, 22)
        Me.nuPayTerms.TabIndex = 68
        Me.nuPayTerms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(49, 222)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "PROVINCE :"
        '
        'cbxProvince
        '
        Me.cbxProvince.FormattingEnabled = True
        Me.cbxProvince.Location = New System.Drawing.Point(118, 218)
        Me.cbxProvince.Name = "cbxProvince"
        Me.cbxProvince.Size = New System.Drawing.Size(80, 21)
        Me.cbxProvince.TabIndex = 66
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "OUTLET TYPE :"
        '
        'cbxOutletType
        '
        Me.cbxOutletType.FormattingEnabled = True
        Me.cbxOutletType.Location = New System.Drawing.Point(118, 191)
        Me.cbxOutletType.Name = "cbxOutletType"
        Me.cbxOutletType.Size = New System.Drawing.Size(80, 21)
        Me.cbxOutletType.TabIndex = 64
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(75, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "AREA :"
        '
        'cbxTerritory
        '
        Me.cbxTerritory.FormattingEnabled = True
        Me.cbxTerritory.Location = New System.Drawing.Point(118, 164)
        Me.cbxTerritory.Name = "cbxTerritory"
        Me.cbxTerritory.Size = New System.Drawing.Size(80, 21)
        Me.cbxTerritory.TabIndex = 62
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(62, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "SHIP TO :"
        '
        'tbShipTo
        '
        Me.tbShipTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbShipTo.Location = New System.Drawing.Point(118, 135)
        Me.tbShipTo.MaxLength = 50
        Me.tbShipTo.Name = "tbShipTo"
        Me.tbShipTo.Size = New System.Drawing.Size(375, 22)
        Me.tbShipTo.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(574, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "TEL.NO. :"
        '
        'tbTelno
        '
        Me.tbTelno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTelno.Location = New System.Drawing.Point(631, 68)
        Me.tbTelno.MaxLength = 15
        Me.tbTelno.Name = "tbTelno"
        Me.tbTelno.Size = New System.Drawing.Size(132, 22)
        Me.tbTelno.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(549, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "MOBILE NO. :"
        '
        'tbMobile
        '
        Me.tbMobile.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMobile.Location = New System.Drawing.Point(631, 40)
        Me.tbMobile.MaxLength = 15
        Me.tbMobile.Name = "tbMobile"
        Me.tbMobile.Size = New System.Drawing.Size(132, 22)
        Me.tbMobile.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "ADDRESS :"
        '
        'tbCustAddress
        '
        Me.tbCustAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCustAddress.Location = New System.Drawing.Point(118, 68)
        Me.tbCustAddress.MaxLength = 200
        Me.tbCustAddress.Multiline = True
        Me.tbCustAddress.Name = "tbCustAddress"
        Me.tbCustAddress.Size = New System.Drawing.Size(375, 61)
        Me.tbCustAddress.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(574, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "TIN NO. :"
        '
        'tbTin
        '
        Me.tbTin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTin.Location = New System.Drawing.Point(631, 12)
        Me.tbTin.MaxLength = 15
        Me.tbTin.Name = "tbTin"
        Me.tbTin.Size = New System.Drawing.Size(132, 22)
        Me.tbTin.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "CUSTOMER NAME :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "CUSTOMER CODE : "
        '
        'tbCustName
        '
        Me.tbCustName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCustName.Location = New System.Drawing.Point(118, 40)
        Me.tbCustName.MaxLength = 100
        Me.tbCustName.Name = "tbCustName"
        Me.tbCustName.Size = New System.Drawing.Size(375, 22)
        Me.tbCustName.TabIndex = 49
        '
        'tbCustCode
        '
        Me.tbCustCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCustCode.Location = New System.Drawing.Point(118, 12)
        Me.tbCustCode.MaxLength = 10
        Me.tbCustCode.Name = "tbCustCode"
        Me.tbCustCode.ReadOnly = True
        Me.tbCustCode.Size = New System.Drawing.Size(111, 22)
        Me.tbCustCode.TabIndex = 48
        '
        'dgvSalesman
        '
        Me.dgvSalesman.AllowUserToAddRows = False
        Me.dgvSalesman.AllowUserToDeleteRows = False
        Me.dgvSalesman.AllowUserToResizeRows = False
        Me.dgvSalesman.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSalesman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalesman.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column8, Me.Column4, Me.Column9, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSalesman.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSalesman.Location = New System.Drawing.Point(17, 272)
        Me.dgvSalesman.Name = "dgvSalesman"
        Me.dgvSalesman.RowHeadersVisible = False
        Me.dgvSalesman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSalesman.Size = New System.Drawing.Size(746, 87)
        Me.dgvSalesman.TabIndex = 80
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
        Me.Column2.HeaderText = "CODE"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 62
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "SALESMAN NAME"
        Me.Column3.Name = "Column3"
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "WHCODE"
        Me.Column8.Name = "Column8"
        Me.Column8.Visible = False
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "WAREHOUSE"
        Me.Column4.Name = "Column4"
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "OPCODE"
        Me.Column9.Name = "Column9"
        Me.Column9.Visible = False
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "TYPE-OPER."
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 90
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "PRICE"
        Me.Column6.Items.AddRange(New Object() {"A", "B", "C"})
        Me.Column6.Name = "Column6"
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column6.Width = 61
        '
        'Column7
        '
        Me.Column7.HeaderText = "PKNO"
        Me.Column7.Name = "Column7"
        Me.Column7.Visible = False
        '
        'btnAddSalesman
        '
        Me.btnAddSalesman.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAddSalesman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddSalesman.FlatAppearance.BorderSize = 0
        Me.btnAddSalesman.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSalesman.Location = New System.Drawing.Point(19, 362)
        Me.btnAddSalesman.Name = "btnAddSalesman"
        Me.btnAddSalesman.Size = New System.Drawing.Size(104, 23)
        Me.btnAddSalesman.TabIndex = 81
        Me.btnAddSalesman.Text = "&Assign Salesman"
        Me.btnAddSalesman.UseVisualStyleBackColor = False
        '
        'tsCustomer
        '
        Me.tsCustomer.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsCustomer.Dock = System.Windows.Forms.DockStyle.None
        Me.tsCustomer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsCustomer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.NewCust, Me.ToolStripSeparator1, Me.SaveCust, Me.ToolStripSeparator32, Me.UpdateCust, Me.ClearCust, Me.ToolStripSeparator33})
        Me.tsCustomer.Location = New System.Drawing.Point(581, 362)
        Me.tsCustomer.Name = "tsCustomer"
        Me.tsCustomer.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsCustomer.Size = New System.Drawing.Size(187, 25)
        Me.tsCustomer.TabIndex = 82
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'NewCust
        '
        Me.NewCust.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NewCust.Image = CType(resources.GetObject("NewCust.Image"), System.Drawing.Image)
        Me.NewCust.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewCust.Name = "NewCust"
        Me.NewCust.Size = New System.Drawing.Size(35, 22)
        Me.NewCust.Text = "&New"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'SaveCust
        '
        Me.SaveCust.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveCust.Image = CType(resources.GetObject("SaveCust.Image"), System.Drawing.Image)
        Me.SaveCust.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveCust.Name = "SaveCust"
        Me.SaveCust.Size = New System.Drawing.Size(35, 22)
        Me.SaveCust.Text = "&Save"
        '
        'ToolStripSeparator32
        '
        Me.ToolStripSeparator32.Name = "ToolStripSeparator32"
        Me.ToolStripSeparator32.Size = New System.Drawing.Size(6, 25)
        '
        'UpdateCust
        '
        Me.UpdateCust.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.UpdateCust.Image = CType(resources.GetObject("UpdateCust.Image"), System.Drawing.Image)
        Me.UpdateCust.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UpdateCust.Name = "UpdateCust"
        Me.UpdateCust.Size = New System.Drawing.Size(52, 22)
        Me.UpdateCust.Text = "&Update "
        Me.UpdateCust.ToolTipText = "UpdateCust"
        '
        'ClearCust
        '
        Me.ClearCust.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ClearCust.Image = CType(resources.GetObject("ClearCust.Image"), System.Drawing.Image)
        Me.ClearCust.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearCust.Name = "ClearCust"
        Me.ClearCust.Size = New System.Drawing.Size(38, 22)
        Me.ClearCust.Text = "&Clear"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(556, 186)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(167, 13)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "ALLOW PRODUCT DISCOUNT? :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(614, 209)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 13)
        Me.Label17.TabIndex = 84
        Me.Label17.Text = "ACCOUNT ACTIVE? :"
        '
        'cbxAllow
        '
        Me.cbxAllow.FormattingEnabled = True
        Me.cbxAllow.Items.AddRange(New Object() {"Y", "N"})
        Me.cbxAllow.Location = New System.Drawing.Point(730, 182)
        Me.cbxAllow.Name = "cbxAllow"
        Me.cbxAllow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbxAllow.Size = New System.Drawing.Size(33, 21)
        Me.cbxAllow.TabIndex = 85
        Me.cbxAllow.Text = "N"
        '
        'cbxActive
        '
        Me.cbxActive.FormattingEnabled = True
        Me.cbxActive.Items.AddRange(New Object() {"Y", "N"})
        Me.cbxActive.Location = New System.Drawing.Point(730, 205)
        Me.cbxActive.Name = "cbxActive"
        Me.cbxActive.Size = New System.Drawing.Size(33, 21)
        Me.cbxActive.TabIndex = 86
        Me.cbxActive.Text = "Y"
        '
        'btnDeleteSalesman
        '
        Me.btnDeleteSalesman.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnDeleteSalesman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteSalesman.FlatAppearance.BorderSize = 0
        Me.btnDeleteSalesman.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteSalesman.Location = New System.Drawing.Point(125, 362)
        Me.btnDeleteSalesman.Name = "btnDeleteSalesman"
        Me.btnDeleteSalesman.Size = New System.Drawing.Size(116, 23)
        Me.btnDeleteSalesman.TabIndex = 88
        Me.btnDeleteSalesman.Text = "&Remove Salesman"
        Me.btnDeleteSalesman.UseVisualStyleBackColor = False
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(206, 168)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(0, 13)
        Me.lblArea.TabIndex = 89
        '
        'lblOutlet
        '
        Me.lblOutlet.AutoSize = True
        Me.lblOutlet.Location = New System.Drawing.Point(206, 195)
        Me.lblOutlet.Name = "lblOutlet"
        Me.lblOutlet.Size = New System.Drawing.Size(0, 13)
        Me.lblOutlet.TabIndex = 90
        '
        'lblProvince
        '
        Me.lblProvince.AutoSize = True
        Me.lblProvince.Location = New System.Drawing.Point(206, 223)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(0, 13)
        Me.lblProvince.TabIndex = 91
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Location = New System.Drawing.Point(206, 249)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(0, 13)
        Me.lblMain.TabIndex = 92
        '
        'pkno
        '
        Me.pkno.AutoSize = True
        Me.pkno.Location = New System.Drawing.Point(798, 15)
        Me.pkno.Name = "pkno"
        Me.pkno.Size = New System.Drawing.Size(36, 13)
        Me.pkno.TabIndex = 93
        Me.pkno.Text = "PKNO"
        '
        'frmCustomerD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 396)
        Me.Controls.Add(Me.pkno)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.lblProvince)
        Me.Controls.Add(Me.lblOutlet)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.btnDeleteSalesman)
        Me.Controls.Add(Me.cbxActive)
        Me.Controls.Add(Me.cbxAllow)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.tsCustomer)
        Me.Controls.Add(Me.btnAddSalesman)
        Me.Controls.Add(Me.dgvSalesman)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cbxMainPrincipal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.nuSpecial)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.nuCredit)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.nuPayTerms)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbxProvince)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbxOutletType)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbxTerritory)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbShipTo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbTelno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbMobile)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbCustAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbTin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbCustName)
        Me.Controls.Add(Me.tbCustCode)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomerD"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CUSTOMER'S INFORMATION"
        CType(Me.nuSpecial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuCredit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuPayTerms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSalesman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsCustomer.ResumeLayout(False)
        Me.tsCustomer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbxMainPrincipal As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents nuSpecial As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents nuCredit As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents nuPayTerms As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbxProvince As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbxOutletType As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbxTerritory As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbShipTo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbTelno As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbCustAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbTin As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbCustName As System.Windows.Forms.TextBox
    Friend WithEvents tbCustCode As System.Windows.Forms.TextBox
    Friend WithEvents dgvSalesman As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddSalesman As System.Windows.Forms.Button
    Friend WithEvents tsCustomer As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveCust As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator32 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearCust As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cbxAllow As System.Windows.Forms.ComboBox
    Friend WithEvents cbxActive As System.Windows.Forms.ComboBox
    Friend WithEvents UpdateCust As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDeleteSalesman As System.Windows.Forms.Button
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents lblOutlet As System.Windows.Forms.Label
    Friend WithEvents lblProvince As System.Windows.Forms.Label
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents pkno As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewCust As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
