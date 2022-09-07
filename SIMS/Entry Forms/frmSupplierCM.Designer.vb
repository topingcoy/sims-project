<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplierCM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupplierCM))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbxSupplierCM = New System.Windows.Forms.GroupBox()
        Me.pbar1 = New System.Windows.Forms.ProgressBar()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbRem4 = New System.Windows.Forms.TextBox()
        Me.tbRem3 = New System.Windows.Forms.TextBox()
        Me.tbRem2 = New System.Windows.Forms.TextBox()
        Me.tbRem1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSupplierName = New System.Windows.Forms.TextBox()
        Me.tbTransnoCM = New System.Windows.Forms.TextBox()
        Me.cbxSupplier = New System.Windows.Forms.ComboBox()
        Me.tsSupplierCM = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSavePrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbCMAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpCMDate = New System.Windows.Forms.DateTimePicker()
        Me.tbCMNo = New System.Windows.Forms.TextBox()
        Me.dgvSupplierCM = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BALANCE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbSearchCM = New System.Windows.Forms.TextBox()
        Me.tsSupplierCMenu = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsRereshCM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteSupCM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.gbxSupplierCM.SuspendLayout()
        Me.tsSupplierCM.SuspendLayout()
        CType(Me.dgvSupplierCM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsSupplierCMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxSupplierCM
        '
        Me.gbxSupplierCM.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbxSupplierCM.Controls.Add(Me.pbar1)
        Me.gbxSupplierCM.Controls.Add(Me.Label11)
        Me.gbxSupplierCM.Controls.Add(Me.Label10)
        Me.gbxSupplierCM.Controls.Add(Me.Label9)
        Me.gbxSupplierCM.Controls.Add(Me.Label8)
        Me.gbxSupplierCM.Controls.Add(Me.tbRem4)
        Me.gbxSupplierCM.Controls.Add(Me.tbRem3)
        Me.gbxSupplierCM.Controls.Add(Me.tbRem2)
        Me.gbxSupplierCM.Controls.Add(Me.tbRem1)
        Me.gbxSupplierCM.Controls.Add(Me.Label7)
        Me.gbxSupplierCM.Controls.Add(Me.tbUser)
        Me.gbxSupplierCM.Controls.Add(Me.Label1)
        Me.gbxSupplierCM.Controls.Add(Me.tbSupplierName)
        Me.gbxSupplierCM.Controls.Add(Me.tbTransnoCM)
        Me.gbxSupplierCM.Controls.Add(Me.cbxSupplier)
        Me.gbxSupplierCM.Controls.Add(Me.tsSupplierCM)
        Me.gbxSupplierCM.Controls.Add(Me.Label4)
        Me.gbxSupplierCM.Controls.Add(Me.Label3)
        Me.gbxSupplierCM.Controls.Add(Me.Label2)
        Me.gbxSupplierCM.Controls.Add(Me.tbCMAmount)
        Me.gbxSupplierCM.Controls.Add(Me.Label5)
        Me.gbxSupplierCM.Controls.Add(Me.Label6)
        Me.gbxSupplierCM.Controls.Add(Me.dtpCMDate)
        Me.gbxSupplierCM.Controls.Add(Me.tbCMNo)
        Me.gbxSupplierCM.Location = New System.Drawing.Point(566, 28)
        Me.gbxSupplierCM.Name = "gbxSupplierCM"
        Me.gbxSupplierCM.Size = New System.Drawing.Size(393, 287)
        Me.gbxSupplierCM.TabIndex = 47
        Me.gbxSupplierCM.TabStop = False
        Me.gbxSupplierCM.Text = "ENTER SUPPLIER CREDIT MEMO"
        '
        'pbar1
        '
        Me.pbar1.Location = New System.Drawing.Point(0, 275)
        Me.pbar1.Name = "pbar1"
        Me.pbar1.Size = New System.Drawing.Size(393, 12)
        Me.pbar1.TabIndex = 131
        Me.pbar1.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(62, 198)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 13)
        Me.Label11.TabIndex = 139
        Me.Label11.Text = "4:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(62, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 13)
        Me.Label10.TabIndex = 138
        Me.Label10.Text = "3:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(62, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 13)
        Me.Label9.TabIndex = 137
        Me.Label9.Text = "2:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(62, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 13)
        Me.Label8.TabIndex = 136
        Me.Label8.Text = "1:"
        '
        'tbRem4
        '
        Me.tbRem4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbRem4.Location = New System.Drawing.Point(85, 194)
        Me.tbRem4.MaxLength = 100
        Me.tbRem4.Name = "tbRem4"
        Me.tbRem4.Size = New System.Drawing.Size(298, 22)
        Me.tbRem4.TabIndex = 135
        '
        'tbRem3
        '
        Me.tbRem3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbRem3.Location = New System.Drawing.Point(85, 170)
        Me.tbRem3.MaxLength = 100
        Me.tbRem3.Name = "tbRem3"
        Me.tbRem3.Size = New System.Drawing.Size(298, 22)
        Me.tbRem3.TabIndex = 134
        '
        'tbRem2
        '
        Me.tbRem2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbRem2.Location = New System.Drawing.Point(85, 146)
        Me.tbRem2.MaxLength = 100
        Me.tbRem2.Name = "tbRem2"
        Me.tbRem2.Size = New System.Drawing.Size(298, 22)
        Me.tbRem2.TabIndex = 133
        '
        'tbRem1
        '
        Me.tbRem1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbRem1.Location = New System.Drawing.Point(85, 122)
        Me.tbRem1.MaxLength = 100
        Me.tbRem1.Name = "tbRem1"
        Me.tbRem1.Size = New System.Drawing.Size(298, 22)
        Me.tbRem1.TabIndex = 132
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(239, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 131
        Me.Label7.Text = "Added By:"
        '
        'tbUser
        '
        Me.tbUser.Location = New System.Drawing.Point(299, 74)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.ReadOnly = True
        Me.tbUser.Size = New System.Drawing.Size(85, 22)
        Me.tbUser.TabIndex = 130
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(238, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "Trans No.:"
        '
        'tbSupplierName
        '
        Me.tbSupplierName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSupplierName.Location = New System.Drawing.Point(151, 98)
        Me.tbSupplierName.Name = "tbSupplierName"
        Me.tbSupplierName.Size = New System.Drawing.Size(233, 22)
        Me.tbSupplierName.TabIndex = 128
        '
        'tbTransnoCM
        '
        Me.tbTransnoCM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTransnoCM.Location = New System.Drawing.Point(299, 51)
        Me.tbTransnoCM.MaxLength = 15
        Me.tbTransnoCM.Name = "tbTransnoCM"
        Me.tbTransnoCM.ReadOnly = True
        Me.tbTransnoCM.Size = New System.Drawing.Size(85, 22)
        Me.tbTransnoCM.TabIndex = 74
        '
        'cbxSupplier
        '
        Me.cbxSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSupplier.FormattingEnabled = True
        Me.cbxSupplier.Location = New System.Drawing.Point(66, 99)
        Me.cbxSupplier.Name = "cbxSupplier"
        Me.cbxSupplier.Size = New System.Drawing.Size(80, 21)
        Me.cbxSupplier.TabIndex = 126
        '
        'tsSupplierCM
        '
        Me.tsSupplierCM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsSupplierCM.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsSupplierCM.Dock = System.Windows.Forms.DockStyle.None
        Me.tsSupplierCM.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsSupplierCM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.btnNew, Me.ToolStripSeparator1, Me.btnSavePrint, Me.ToolStripSeparator6, Me.btnSave, Me.ToolStripSeparator4, Me.btnPrint, Me.ToolStripSeparator11})
        Me.tsSupplierCM.Location = New System.Drawing.Point(177, 219)
        Me.tsSupplierCM.Name = "tsSupplierCM"
        Me.tsSupplierCM.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsSupplierCM.Size = New System.Drawing.Size(207, 25)
        Me.tsSupplierCM.TabIndex = 75
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnNew
        '
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(35, 22)
        Me.btnNew.Text = "&New"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnSavePrint
        '
        Me.btnSavePrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSavePrint.Image = CType(resources.GetObject("btnSavePrint.Image"), System.Drawing.Image)
        Me.btnSavePrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSavePrint.Name = "btnSavePrint"
        Me.btnSavePrint.Size = New System.Drawing.Size(68, 22)
        Me.btnSavePrint.Text = "Save+&Print"
        Me.btnSavePrint.ToolTipText = "Sa&ve+Print"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(35, 22)
        Me.btnSave.Text = "&Save"
        Me.btnSave.ToolTipText = "S&ave "
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(36, 22)
        Me.btnPrint.Text = "P&rint"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Remarks :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Amount :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "CM No. :"
        '
        'tbCMAmount
        '
        Me.tbCMAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCMAmount.Location = New System.Drawing.Point(66, 75)
        Me.tbCMAmount.MaxLength = 50
        Me.tbCMAmount.Name = "tbCMAmount"
        Me.tbCMAmount.Size = New System.Drawing.Size(80, 22)
        Me.tbCMAmount.TabIndex = 67
        Me.tbCMAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Supplier :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Date :"
        '
        'dtpCMDate
        '
        Me.dtpCMDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCMDate.Location = New System.Drawing.Point(66, 29)
        Me.dtpCMDate.Name = "dtpCMDate"
        Me.dtpCMDate.Size = New System.Drawing.Size(80, 22)
        Me.dtpCMDate.TabIndex = 63
        '
        'tbCMNo
        '
        Me.tbCMNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCMNo.Location = New System.Drawing.Point(66, 52)
        Me.tbCMNo.MaxLength = 12
        Me.tbCMNo.Name = "tbCMNo"
        Me.tbCMNo.Size = New System.Drawing.Size(80, 22)
        Me.tbCMNo.TabIndex = 29
        Me.tbCMNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvSupplierCM
        '
        Me.dgvSupplierCM.AllowUserToAddRows = False
        Me.dgvSupplierCM.AllowUserToDeleteRows = False
        Me.dgvSupplierCM.AllowUserToResizeRows = False
        Me.dgvSupplierCM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSupplierCM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSupplierCM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSupplierCM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column3, Me.DataGridViewTextBoxColumn2, Me.column1, Me.DataGridViewTextBoxColumn3, Me.Column4, Me.DataGridViewTextBoxColumn4, Me.Column26, Me.BALANCE, Me.Column2, Me.colEdit, Me.colDelete, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSupplierCM.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvSupplierCM.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvSupplierCM.Location = New System.Drawing.Point(12, 28)
        Me.dgvSupplierCM.Name = "dgvSupplierCM"
        Me.dgvSupplierCM.ReadOnly = True
        Me.dgvSupplierCM.RowHeadersVisible = False
        Me.dgvSupplierCM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSupplierCM.Size = New System.Drawing.Size(549, 287)
        Me.dgvSupplierCM.TabIndex = 55
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "TRANSNO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "DATE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 58
        '
        'column1
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.column1.HeaderText = "TYPE"
        Me.column1.Name = "column1"
        Me.column1.ReadOnly = True
        Me.column1.Width = 35
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.HeaderText = "CM NO."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 72
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "SUPCODE"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn4.HeaderText = "SUPPLIER"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Column26
        '
        Me.Column26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Column26.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column26.HeaderText = "AMOUNT"
        Me.Column26.Name = "Column26"
        Me.Column26.ReadOnly = True
        Me.Column26.Width = 80
        '
        'BALANCE
        '
        Me.BALANCE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.BALANCE.DefaultCellStyle = DataGridViewCellStyle7
        Me.BALANCE.HeaderText = "BALANCE"
        Me.BALANCE.Name = "BALANCE"
        Me.BALANCE.ReadOnly = True
        Me.BALANCE.Width = 78
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column2.HeaderText = "ADDED BY"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'colEdit
        '
        Me.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colEdit.HeaderText = ""
        Me.colEdit.Name = "colEdit"
        Me.colEdit.ReadOnly = True
        Me.colEdit.Visible = False
        '
        'colDelete
        '
        Me.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDelete.HeaderText = ""
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        Me.colDelete.Visible = False
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "REM1"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "REM2"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "REM3"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "REM4"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'tbSearchCM
        '
        Me.tbSearchCM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchCM.Location = New System.Drawing.Point(12, 4)
        Me.tbSearchCM.Name = "tbSearchCM"
        Me.tbSearchCM.Size = New System.Drawing.Size(169, 22)
        Me.tbSearchCM.TabIndex = 129
        '
        'tsSupplierCMenu
        '
        Me.tsSupplierCMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsSupplierCMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.tsSupplierCMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsSupplierCMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsRereshCM, Me.ToolStripSeparator8, Me.DeleteSupCM, Me.ToolStripSeparator2})
        Me.tsSupplierCMenu.Location = New System.Drawing.Point(12, 318)
        Me.tsSupplierCMenu.Name = "tsSupplierCMenu"
        Me.tsSupplierCMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsSupplierCMenu.Size = New System.Drawing.Size(190, 25)
        Me.tsSupplierCMenu.TabIndex = 130
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'tsRereshCM
        '
        Me.tsRereshCM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsRereshCM.Image = CType(resources.GetObject("tsRereshCM.Image"), System.Drawing.Image)
        Me.tsRereshCM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsRereshCM.Name = "tsRereshCM"
        Me.tsRereshCM.Size = New System.Drawing.Size(89, 22)
        Me.tsRereshCM.Text = "[F5] - REFRESH"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'DeleteSupCM
        '
        Me.DeleteSupCM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DeleteSupCM.Image = CType(resources.GetObject("DeleteSupCM.Image"), System.Drawing.Image)
        Me.DeleteSupCM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteSupCM.Name = "DeleteSupCM"
        Me.DeleteSupCM.Size = New System.Drawing.Size(80, 22)
        Me.DeleteSupCM.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'frmSupplierCM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(970, 346)
        Me.Controls.Add(Me.tsSupplierCMenu)
        Me.Controls.Add(Me.tbSearchCM)
        Me.Controls.Add(Me.gbxSupplierCM)
        Me.Controls.Add(Me.dgvSupplierCM)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSupplierCM"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUPPLIER CREDIT MEMO"
        Me.gbxSupplierCM.ResumeLayout(False)
        Me.gbxSupplierCM.PerformLayout()
        Me.tsSupplierCM.ResumeLayout(False)
        Me.tsSupplierCM.PerformLayout()
        CType(Me.dgvSupplierCM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsSupplierCMenu.ResumeLayout(False)
        Me.tsSupplierCMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxSupplierCM As System.Windows.Forms.GroupBox
    Friend WithEvents tsSupplierCM As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSavePrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbTransnoCM As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbCMAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpCMDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbCMNo As System.Windows.Forms.TextBox
    Friend WithEvents cbxSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents dgvSupplierCM As System.Windows.Forms.DataGridView
    Friend WithEvents tbSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents tbSearchCM As System.Windows.Forms.TextBox
    Friend WithEvents tsSupplierCMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteSupCM As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbUser As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsRereshCM As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbRem4 As System.Windows.Forms.TextBox
    Friend WithEvents tbRem3 As System.Windows.Forms.TextBox
    Friend WithEvents tbRem2 As System.Windows.Forms.TextBox
    Friend WithEvents tbRem1 As System.Windows.Forms.TextBox
    Friend WithEvents pbar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BALANCE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEdit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
