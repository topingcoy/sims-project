<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemoCreditH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMemoCreditH))
        Me.dgvwarehouse = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsCreditMemoH = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsADDCM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsEditCM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDeleteCM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.cbxViewPaid = New System.Windows.Forms.CheckBox()
        Me.dtpCM2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpCM1 = New System.Windows.Forms.DateTimePicker()
        Me.tbSearchCM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsrcvgo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsgo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.gbCreditMemo = New System.Windows.Forms.GroupBox()
        Me.tsCM = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewCM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SavePrintCM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveCM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditCM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseCM = New System.Windows.Forms.ToolStripButton()
        Me.tbTransno = New System.Windows.Forms.TextBox()
        Me.tbCMDocno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbCMAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpCMDate = New System.Windows.Forms.DateTimePicker()
        Me.tbCMNo = New System.Windows.Forms.TextBox()
        Me.tbCustomerCode = New System.Windows.Forms.TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.dgvCM = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvwarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsCreditMemoH.SuspendLayout()
        Me.tsrcvgo.SuspendLayout()
        Me.gbCreditMemo.SuspendLayout()
        Me.tsCM.SuspendLayout()
        CType(Me.dgvCM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvwarehouse
        '
        Me.dgvwarehouse.AllowUserToAddRows = False
        Me.dgvwarehouse.AllowUserToResizeRows = False
        Me.dgvwarehouse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvwarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvwarehouse.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgvwarehouse.Location = New System.Drawing.Point(12, 34)
        Me.dgvwarehouse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvwarehouse.Name = "dgvwarehouse"
        Me.dgvwarehouse.RowHeadersVisible = False
        Me.dgvwarehouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvwarehouse.Size = New System.Drawing.Size(786, 333)
        Me.dgvwarehouse.TabIndex = 17
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
        'tsCreditMemoH
        '
        Me.tsCreditMemoH.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsCreditMemoH.Dock = System.Windows.Forms.DockStyle.None
        Me.tsCreditMemoH.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsCreditMemoH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsADDCM, Me.ToolStripSeparator33, Me.tsEditCM, Me.ToolStripSeparator34, Me.tsDeleteCM, Me.ToolStripSeparator35})
        Me.tsCreditMemoH.Location = New System.Drawing.Point(280, 373)
        Me.tsCreditMemoH.Name = "tsCreditMemoH"
        Me.tsCreditMemoH.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsCreditMemoH.Size = New System.Drawing.Size(263, 25)
        Me.tsCreditMemoH.TabIndex = 37
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'tsADDCM
        '
        Me.tsADDCM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsADDCM.Image = CType(resources.GetObject("tsADDCM.Image"), System.Drawing.Image)
        Me.tsADDCM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsADDCM.Name = "tsADDCM"
        Me.tsADDCM.Size = New System.Drawing.Size(66, 22)
        Me.tsADDCM.Text = "[F5] - ADD"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'tsEditCM
        '
        Me.tsEditCM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsEditCM.Image = CType(resources.GetObject("tsEditCM.Image"), System.Drawing.Image)
        Me.tsEditCM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEditCM.Name = "tsEditCM"
        Me.tsEditCM.Size = New System.Drawing.Size(89, 22)
        Me.tsEditCM.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'tsDeleteCM
        '
        Me.tsDeleteCM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsDeleteCM.Image = CType(resources.GetObject("tsDeleteCM.Image"), System.Drawing.Image)
        Me.tsDeleteCM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDeleteCM.Name = "tsDeleteCM"
        Me.tsDeleteCM.Size = New System.Drawing.Size(81, 22)
        Me.tsDeleteCM.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'cbxViewPaid
        '
        Me.cbxViewPaid.AutoSize = True
        Me.cbxViewPaid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxViewPaid.Location = New System.Drawing.Point(258, 10)
        Me.cbxViewPaid.Name = "cbxViewPaid"
        Me.cbxViewPaid.Size = New System.Drawing.Size(99, 17)
        Me.cbxViewPaid.TabIndex = 43
        Me.cbxViewPaid.Text = "View Applied?"
        Me.cbxViewPaid.UseVisualStyleBackColor = True
        '
        'dtpCM2
        '
        Me.dtpCM2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpCM2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCM2.Location = New System.Drawing.Point(652, 7)
        Me.dtpCM2.Name = "dtpCM2"
        Me.dtpCM2.Size = New System.Drawing.Size(93, 22)
        Me.dtpCM2.TabIndex = 42
        '
        'dtpCM1
        '
        Me.dtpCM1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpCM1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCM1.Location = New System.Drawing.Point(524, 7)
        Me.dtpCM1.Name = "dtpCM1"
        Me.dtpCM1.Size = New System.Drawing.Size(93, 22)
        Me.dtpCM1.TabIndex = 41
        '
        'tbSearchCM
        '
        Me.tbSearchCM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchCM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSearchCM.Location = New System.Drawing.Point(12, 7)
        Me.tbSearchCM.MaxLength = 50
        Me.tbSearchCM.Name = "tbSearchCM"
        Me.tbSearchCM.Size = New System.Drawing.Size(239, 22)
        Me.tbSearchCM.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Location = New System.Drawing.Point(626, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "To"
        '
        'tsrcvgo
        '
        Me.tsrcvgo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsrcvgo.Dock = System.Windows.Forms.DockStyle.None
        Me.tsrcvgo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsrcvgo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsgo, Me.ToolStripSeparator2})
        Me.tsrcvgo.Location = New System.Drawing.Point(755, 6)
        Me.tsrcvgo.Name = "tsrcvgo"
        Me.tsrcvgo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsrcvgo.Size = New System.Drawing.Size(43, 25)
        Me.tsrcvgo.TabIndex = 45
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'gbCreditMemo
        '
        Me.gbCreditMemo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbCreditMemo.Controls.Add(Me.dgvCM)
        Me.gbCreditMemo.Controls.Add(Me.lblCustomerName)
        Me.gbCreditMemo.Controls.Add(Me.tbCustomerCode)
        Me.gbCreditMemo.Controls.Add(Me.tsCM)
        Me.gbCreditMemo.Controls.Add(Me.tbTransno)
        Me.gbCreditMemo.Controls.Add(Me.tbCMDocno)
        Me.gbCreditMemo.Controls.Add(Me.Label4)
        Me.gbCreditMemo.Controls.Add(Me.Label3)
        Me.gbCreditMemo.Controls.Add(Me.Label2)
        Me.gbCreditMemo.Controls.Add(Me.tbCMAmount)
        Me.gbCreditMemo.Controls.Add(Me.Label5)
        Me.gbCreditMemo.Controls.Add(Me.Label6)
        Me.gbCreditMemo.Controls.Add(Me.dtpCMDate)
        Me.gbCreditMemo.Controls.Add(Me.tbCMNo)
        Me.gbCreditMemo.Location = New System.Drawing.Point(177, 73)
        Me.gbCreditMemo.Name = "gbCreditMemo"
        Me.gbCreditMemo.Size = New System.Drawing.Size(468, 276)
        Me.gbCreditMemo.TabIndex = 46
        Me.gbCreditMemo.TabStop = False
        Me.gbCreditMemo.Text = "CREDIT MEMO"
        Me.gbCreditMemo.Visible = False
        '
        'tsCM
        '
        Me.tsCM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsCM.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsCM.Dock = System.Windows.Forms.DockStyle.None
        Me.tsCM.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsCM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.NewCM, Me.ToolStripSeparator4, Me.SavePrintCM, Me.ToolStripSeparator5, Me.SaveCM, Me.ToolStripSeparator6, Me.EditCM, Me.ToolStripSeparator7, Me.CloseCM})
        Me.tsCM.Location = New System.Drawing.Point(211, 14)
        Me.tsCM.Name = "tsCM"
        Me.tsCM.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsCM.Size = New System.Drawing.Size(242, 25)
        Me.tsCM.TabIndex = 75
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'NewCM
        '
        Me.NewCM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NewCM.Image = CType(resources.GetObject("NewCM.Image"), System.Drawing.Image)
        Me.NewCM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewCM.Name = "NewCM"
        Me.NewCM.Size = New System.Drawing.Size(35, 22)
        Me.NewCM.Text = "&New"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'SavePrintCM
        '
        Me.SavePrintCM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SavePrintCM.Image = CType(resources.GetObject("SavePrintCM.Image"), System.Drawing.Image)
        Me.SavePrintCM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SavePrintCM.Name = "SavePrintCM"
        Me.SavePrintCM.Size = New System.Drawing.Size(68, 22)
        Me.SavePrintCM.Text = "Save+&Print"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'SaveCM
        '
        Me.SaveCM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveCM.Image = CType(resources.GetObject("SaveCM.Image"), System.Drawing.Image)
        Me.SaveCM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveCM.Name = "SaveCM"
        Me.SaveCM.Size = New System.Drawing.Size(35, 22)
        Me.SaveCM.Text = "&Save"
        Me.SaveCM.ToolTipText = "S&ave "
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'EditCM
        '
        Me.EditCM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditCM.Image = CType(resources.GetObject("EditCM.Image"), System.Drawing.Image)
        Me.EditCM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditCM.Name = "EditCM"
        Me.EditCM.Size = New System.Drawing.Size(31, 22)
        Me.EditCM.Text = "&Edit"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'CloseCM
        '
        Me.CloseCM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CloseCM.Image = CType(resources.GetObject("CloseCM.Image"), System.Drawing.Image)
        Me.CloseCM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseCM.Name = "CloseCM"
        Me.CloseCM.Size = New System.Drawing.Size(40, 22)
        Me.CloseCM.Text = "&Close"
        '
        'tbTransno
        '
        Me.tbTransno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTransno.Location = New System.Drawing.Point(176, 61)
        Me.tbTransno.Name = "tbTransno"
        Me.tbTransno.ReadOnly = True
        Me.tbTransno.Size = New System.Drawing.Size(98, 22)
        Me.tbTransno.TabIndex = 74
        Me.tbTransno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCMDocno
        '
        Me.tbCMDocno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCMDocno.Location = New System.Drawing.Point(176, 89)
        Me.tbCMDocno.Name = "tbCMDocno"
        Me.tbCMDocno.ReadOnly = True
        Me.tbCMDocno.Size = New System.Drawing.Size(98, 22)
        Me.tbCMDocno.TabIndex = 73
        Me.tbCMDocno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Remarks :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Amount :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "CM No. :"
        '
        'tbCMAmount
        '
        Me.tbCMAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCMAmount.Location = New System.Drawing.Point(77, 89)
        Me.tbCMAmount.Name = "tbCMAmount"
        Me.tbCMAmount.Size = New System.Drawing.Size(93, 22)
        Me.tbCMAmount.TabIndex = 67
        Me.tbCMAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Customer :"
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
        'dtpCMDate
        '
        Me.dtpCMDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCMDate.Location = New System.Drawing.Point(77, 33)
        Me.dtpCMDate.Name = "dtpCMDate"
        Me.dtpCMDate.Size = New System.Drawing.Size(93, 22)
        Me.dtpCMDate.TabIndex = 63
        '
        'tbCMNo
        '
        Me.tbCMNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCMNo.Location = New System.Drawing.Point(77, 61)
        Me.tbCMNo.Name = "tbCMNo"
        Me.tbCMNo.Size = New System.Drawing.Size(93, 22)
        Me.tbCMNo.TabIndex = 29
        Me.tbCMNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCustomerCode
        '
        Me.tbCustomerCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCustomerCode.Location = New System.Drawing.Point(77, 117)
        Me.tbCustomerCode.Name = "tbCustomerCode"
        Me.tbCustomerCode.Size = New System.Drawing.Size(93, 22)
        Me.tbCustomerCode.TabIndex = 76
        Me.tbCustomerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCustomerName
        '
        Me.lblCustomerName.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(176, 118)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(271, 22)
        Me.lblCustomerName.TabIndex = 124
        Me.lblCustomerName.Text = "CUSTOMER NAME"
        Me.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCustomerName.Visible = False
        '
        'dgvCM
        '
        Me.dgvCM.AllowUserToDeleteRows = False
        Me.dgvCM.AllowUserToResizeRows = False
        Me.dgvCM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgvCM.Location = New System.Drawing.Point(77, 144)
        Me.dgvCM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvCM.Name = "dgvCM"
        Me.dgvCM.RowHeadersVisible = False
        Me.dgvCM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCM.Size = New System.Drawing.Size(370, 127)
        Me.dgvCM.TabIndex = 125
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(448, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Date Range :"
        '
        'frmMemoCreditH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 402)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.gbCreditMemo)
        Me.Controls.Add(Me.tsrcvgo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxViewPaid)
        Me.Controls.Add(Me.dtpCM2)
        Me.Controls.Add(Me.dtpCM1)
        Me.Controls.Add(Me.tbSearchCM)
        Me.Controls.Add(Me.tsCreditMemoH)
        Me.Controls.Add(Me.dgvwarehouse)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMemoCreditH"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CREDIT MEMO LIST"
        CType(Me.dgvwarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsCreditMemoH.ResumeLayout(False)
        Me.tsCreditMemoH.PerformLayout()
        Me.tsrcvgo.ResumeLayout(False)
        Me.tsrcvgo.PerformLayout()
        Me.gbCreditMemo.ResumeLayout(False)
        Me.gbCreditMemo.PerformLayout()
        Me.tsCM.ResumeLayout(False)
        Me.tsCM.PerformLayout()
        CType(Me.dgvCM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvwarehouse As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsCreditMemoH As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsADDCM As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsEditCM As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDeleteCM As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cbxViewPaid As System.Windows.Forms.CheckBox
    Friend WithEvents dtpCM2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCM1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbSearchCM As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tsrcvgo As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsgo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents gbCreditMemo As System.Windows.Forms.GroupBox
    Friend WithEvents tsCM As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewCM As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SavePrintCM As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveCM As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditCM As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseCM As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbTransno As System.Windows.Forms.TextBox
    Friend WithEvents tbCMDocno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbCMAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpCMDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbCMNo As System.Windows.Forms.TextBox
    Friend WithEvents tbCustomerCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents dgvCM As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
