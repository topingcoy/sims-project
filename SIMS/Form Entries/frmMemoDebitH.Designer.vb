<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemoDebitH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMemoDebitH))
        Me.tsDM = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewDM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SavePrintDM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveDM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditDM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseDM = New System.Windows.Forms.ToolStripButton()
        Me.dtpCMDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbDebitMemo = New System.Windows.Forms.GroupBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgvDebitMemo = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsDeditMemoH = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAddDM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsEditDM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDeleteDM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsrcvgo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsgo = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxViewPaid = New System.Windows.Forms.CheckBox()
        Me.dtpCM2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpCM1 = New System.Windows.Forms.DateTimePicker()
        Me.tbSearcDM = New System.Windows.Forms.TextBox()
        Me.dgvDM = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.tbCustCode = New System.Windows.Forms.TextBox()
        Me.tbTransno = New System.Windows.Forms.TextBox()
        Me.tbDMDocno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbDMAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbDMNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tsDM.SuspendLayout()
        Me.gbDebitMemo.SuspendLayout()
        CType(Me.dgvDebitMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsDeditMemoH.SuspendLayout()
        Me.tsrcvgo.SuspendLayout()
        CType(Me.dgvDM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsDM
        '
        Me.tsDM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsDM.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsDM.Dock = System.Windows.Forms.DockStyle.None
        Me.tsDM.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsDM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.NewDM, Me.ToolStripSeparator4, Me.SavePrintDM, Me.ToolStripSeparator5, Me.SaveDM, Me.ToolStripSeparator6, Me.EditDM, Me.ToolStripSeparator7, Me.CloseDM})
        Me.tsDM.Location = New System.Drawing.Point(211, 14)
        Me.tsDM.Name = "tsDM"
        Me.tsDM.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsDM.Size = New System.Drawing.Size(242, 25)
        Me.tsDM.TabIndex = 75
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'NewDM
        '
        Me.NewDM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NewDM.Image = CType(resources.GetObject("NewDM.Image"), System.Drawing.Image)
        Me.NewDM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewDM.Name = "NewDM"
        Me.NewDM.Size = New System.Drawing.Size(35, 22)
        Me.NewDM.Text = "&New"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'SavePrintDM
        '
        Me.SavePrintDM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SavePrintDM.Image = CType(resources.GetObject("SavePrintDM.Image"), System.Drawing.Image)
        Me.SavePrintDM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SavePrintDM.Name = "SavePrintDM"
        Me.SavePrintDM.Size = New System.Drawing.Size(68, 22)
        Me.SavePrintDM.Text = "Save+&Print"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'SaveDM
        '
        Me.SaveDM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveDM.Image = CType(resources.GetObject("SaveDM.Image"), System.Drawing.Image)
        Me.SaveDM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveDM.Name = "SaveDM"
        Me.SaveDM.Size = New System.Drawing.Size(35, 22)
        Me.SaveDM.Text = "&Save"
        Me.SaveDM.ToolTipText = "S&ave "
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'EditDM
        '
        Me.EditDM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditDM.Image = CType(resources.GetObject("EditDM.Image"), System.Drawing.Image)
        Me.EditDM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditDM.Name = "EditDM"
        Me.EditDM.Size = New System.Drawing.Size(31, 22)
        Me.EditDM.Text = "&Edit"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'CloseDM
        '
        Me.CloseDM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CloseDM.Image = CType(resources.GetObject("CloseDM.Image"), System.Drawing.Image)
        Me.CloseDM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseDM.Name = "CloseDM"
        Me.CloseDM.Size = New System.Drawing.Size(40, 22)
        Me.CloseDM.Text = "&Close"
        '
        'dtpCMDate
        '
        Me.dtpCMDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCMDate.Location = New System.Drawing.Point(77, 33)
        Me.dtpCMDate.Name = "dtpCMDate"
        Me.dtpCMDate.Size = New System.Drawing.Size(93, 22)
        Me.dtpCMDate.TabIndex = 63
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Date :"
        '
        'gbDebitMemo
        '
        Me.gbDebitMemo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbDebitMemo.Controls.Add(Me.dgvDM)
        Me.gbDebitMemo.Controls.Add(Me.lblCustomerName)
        Me.gbDebitMemo.Controls.Add(Me.tbCustCode)
        Me.gbDebitMemo.Controls.Add(Me.tbTransno)
        Me.gbDebitMemo.Controls.Add(Me.tbDMDocno)
        Me.gbDebitMemo.Controls.Add(Me.Label4)
        Me.gbDebitMemo.Controls.Add(Me.Label3)
        Me.gbDebitMemo.Controls.Add(Me.Label2)
        Me.gbDebitMemo.Controls.Add(Me.tbDMAmount)
        Me.gbDebitMemo.Controls.Add(Me.Label5)
        Me.gbDebitMemo.Controls.Add(Me.tbDMNo)
        Me.gbDebitMemo.Controls.Add(Me.tsDM)
        Me.gbDebitMemo.Controls.Add(Me.Label6)
        Me.gbDebitMemo.Controls.Add(Me.dtpCMDate)
        Me.gbDebitMemo.Location = New System.Drawing.Point(178, 72)
        Me.gbDebitMemo.Name = "gbDebitMemo"
        Me.gbDebitMemo.Size = New System.Drawing.Size(468, 276)
        Me.gbDebitMemo.TabIndex = 55
        Me.gbDebitMemo.TabStop = False
        Me.gbDebitMemo.Text = "DEBIT MEMO"
        Me.gbDebitMemo.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'dgvDebitMemo
        '
        Me.dgvDebitMemo.AllowUserToAddRows = False
        Me.dgvDebitMemo.AllowUserToResizeRows = False
        Me.dgvDebitMemo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvDebitMemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDebitMemo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgvDebitMemo.Location = New System.Drawing.Point(13, 35)
        Me.dgvDebitMemo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvDebitMemo.Name = "dgvDebitMemo"
        Me.dgvDebitMemo.RowHeadersVisible = False
        Me.dgvDebitMemo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDebitMemo.Size = New System.Drawing.Size(786, 333)
        Me.dgvDebitMemo.TabIndex = 47
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
        Me.Column2.HeaderText = "DATE"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 75
        '
        'Column3
        '
        Me.Column3.HeaderText = "C.M. NO."
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "CUSTOMER NAME"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 250
        '
        'Column5
        '
        Me.Column5.HeaderText = "SALESMAN"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "AMOUNT"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "BALANCE"
        Me.Column7.Name = "Column7"
        '
        'tsDeditMemoH
        '
        Me.tsDeditMemoH.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsDeditMemoH.Dock = System.Windows.Forms.DockStyle.None
        Me.tsDeditMemoH.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsDeditMemoH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsAddDM, Me.ToolStripSeparator33, Me.tsEditDM, Me.ToolStripSeparator34, Me.tsDeleteDM, Me.ToolStripSeparator35})
        Me.tsDeditMemoH.Location = New System.Drawing.Point(281, 374)
        Me.tsDeditMemoH.Name = "tsDeditMemoH"
        Me.tsDeditMemoH.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsDeditMemoH.Size = New System.Drawing.Size(263, 25)
        Me.tsDeditMemoH.TabIndex = 48
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'tsAddDM
        '
        Me.tsAddDM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsAddDM.Image = CType(resources.GetObject("tsAddDM.Image"), System.Drawing.Image)
        Me.tsAddDM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAddDM.Name = "tsAddDM"
        Me.tsAddDM.Size = New System.Drawing.Size(66, 22)
        Me.tsAddDM.Text = "[F5] - ADD"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'tsEditDM
        '
        Me.tsEditDM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsEditDM.Image = CType(resources.GetObject("tsEditDM.Image"), System.Drawing.Image)
        Me.tsEditDM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEditDM.Name = "tsEditDM"
        Me.tsEditDM.Size = New System.Drawing.Size(89, 22)
        Me.tsEditDM.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'tsDeleteDM
        '
        Me.tsDeleteDM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsDeleteDM.Image = CType(resources.GetObject("tsDeleteDM.Image"), System.Drawing.Image)
        Me.tsDeleteDM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDeleteDM.Name = "tsDeleteDM"
        Me.tsDeleteDM.Size = New System.Drawing.Size(81, 22)
        Me.tsDeleteDM.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'tsrcvgo
        '
        Me.tsrcvgo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsrcvgo.Dock = System.Windows.Forms.DockStyle.None
        Me.tsrcvgo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsrcvgo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsgo, Me.ToolStripSeparator2})
        Me.tsrcvgo.Location = New System.Drawing.Point(756, 7)
        Me.tsrcvgo.Name = "tsrcvgo"
        Me.tsrcvgo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsrcvgo.Size = New System.Drawing.Size(43, 25)
        Me.tsrcvgo.TabIndex = 54
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsgo
        '
        Me.tsgo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsgo.Image = CType(resources.GetObject("tsgo.Image"), System.Drawing.Image)
        Me.tsgo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsgo.Name = "tsgo"
        Me.tsgo.Size = New System.Drawing.Size(28, 22)
        Me.tsgo.Text = "GO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Location = New System.Drawing.Point(627, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "To"
        '
        'cbxViewPaid
        '
        Me.cbxViewPaid.AutoSize = True
        Me.cbxViewPaid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxViewPaid.Location = New System.Drawing.Point(258, 11)
        Me.cbxViewPaid.Name = "cbxViewPaid"
        Me.cbxViewPaid.Size = New System.Drawing.Size(99, 17)
        Me.cbxViewPaid.TabIndex = 52
        Me.cbxViewPaid.Text = "View Applied?"
        Me.cbxViewPaid.UseVisualStyleBackColor = True
        '
        'dtpCM2
        '
        Me.dtpCM2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpCM2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCM2.Location = New System.Drawing.Point(653, 8)
        Me.dtpCM2.Name = "dtpCM2"
        Me.dtpCM2.Size = New System.Drawing.Size(93, 22)
        Me.dtpCM2.TabIndex = 51
        '
        'dtpCM1
        '
        Me.dtpCM1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpCM1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCM1.Location = New System.Drawing.Point(525, 8)
        Me.dtpCM1.Name = "dtpCM1"
        Me.dtpCM1.Size = New System.Drawing.Size(93, 22)
        Me.dtpCM1.TabIndex = 50
        '
        'tbSearcDM
        '
        Me.tbSearcDM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearcDM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSearcDM.Location = New System.Drawing.Point(13, 8)
        Me.tbSearcDM.MaxLength = 50
        Me.tbSearcDM.Name = "tbSearcDM"
        Me.tbSearcDM.Size = New System.Drawing.Size(239, 22)
        Me.tbSearcDM.TabIndex = 49
        '
        'dgvDM
        '
        Me.dgvDM.AllowUserToDeleteRows = False
        Me.dgvDM.AllowUserToResizeRows = False
        Me.dgvDM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgvDM.Location = New System.Drawing.Point(78, 142)
        Me.dgvDM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvDM.Name = "dgvDM"
        Me.dgvDM.RowHeadersVisible = False
        Me.dgvDM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDM.Size = New System.Drawing.Size(370, 127)
        Me.dgvDM.TabIndex = 136
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 39
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "REMARKS"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'lblCustomerName
        '
        Me.lblCustomerName.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(177, 115)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(271, 22)
        Me.lblCustomerName.TabIndex = 135
        Me.lblCustomerName.Text = "CUSTOMER NAME"
        Me.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCustomerName.Visible = False
        '
        'tbCustCode
        '
        Me.tbCustCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCustCode.Location = New System.Drawing.Point(78, 115)
        Me.tbCustCode.Name = "tbCustCode"
        Me.tbCustCode.Size = New System.Drawing.Size(93, 22)
        Me.tbCustCode.TabIndex = 134
        Me.tbCustCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbTransno
        '
        Me.tbTransno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTransno.Location = New System.Drawing.Point(177, 59)
        Me.tbTransno.Name = "tbTransno"
        Me.tbTransno.ReadOnly = True
        Me.tbTransno.Size = New System.Drawing.Size(98, 22)
        Me.tbTransno.TabIndex = 133
        Me.tbTransno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbDMDocno
        '
        Me.tbDMDocno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDMDocno.Location = New System.Drawing.Point(177, 87)
        Me.tbDMDocno.Name = "tbDMDocno"
        Me.tbDMDocno.ReadOnly = True
        Me.tbDMDocno.Size = New System.Drawing.Size(98, 22)
        Me.tbDMDocno.TabIndex = 132
        Me.tbDMDocno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Remarks :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "Amount :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "CM No. :"
        '
        'tbDMAmount
        '
        Me.tbDMAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDMAmount.Location = New System.Drawing.Point(78, 87)
        Me.tbDMAmount.Name = "tbDMAmount"
        Me.tbDMAmount.Size = New System.Drawing.Size(93, 22)
        Me.tbDMAmount.TabIndex = 128
        Me.tbDMAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 127
        Me.Label5.Text = "Customer :"
        '
        'tbDMNo
        '
        Me.tbDMNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDMNo.Location = New System.Drawing.Point(78, 59)
        Me.tbDMNo.Name = "tbDMNo"
        Me.tbDMNo.Size = New System.Drawing.Size(93, 22)
        Me.tbDMNo.TabIndex = 126
        Me.tbDMNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(448, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Date Range :"
        '
        'frmMemoDebitH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 406)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.gbDebitMemo)
        Me.Controls.Add(Me.dgvDebitMemo)
        Me.Controls.Add(Me.tsDeditMemoH)
        Me.Controls.Add(Me.tsrcvgo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxViewPaid)
        Me.Controls.Add(Me.dtpCM2)
        Me.Controls.Add(Me.dtpCM1)
        Me.Controls.Add(Me.tbSearcDM)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMemoDebitH"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DEBIT MEMO LIST"
        Me.tsDM.ResumeLayout(False)
        Me.tsDM.PerformLayout()
        Me.gbDebitMemo.ResumeLayout(False)
        Me.gbDebitMemo.PerformLayout()
        CType(Me.dgvDebitMemo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsDeditMemoH.ResumeLayout(False)
        Me.tsDeditMemoH.PerformLayout()
        Me.tsrcvgo.ResumeLayout(False)
        Me.tsrcvgo.PerformLayout()
        CType(Me.dgvDM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsDM As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewDM As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SavePrintDM As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveDM As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditDM As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseDM As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtpCMDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gbDebitMemo As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dgvDebitMemo As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsDeditMemoH As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsAddDM As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsEditDM As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDeleteDM As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsrcvgo As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsgo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxViewPaid As System.Windows.Forms.CheckBox
    Friend WithEvents dtpCM2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCM1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbSearcDM As System.Windows.Forms.TextBox
    Friend WithEvents dgvDM As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents tbCustCode As System.Windows.Forms.TextBox
    Friend WithEvents tbTransno As System.Windows.Forms.TextBox
    Friend WithEvents tbDMDocno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbDMAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbDMNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
