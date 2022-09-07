<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockInD
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockInD))
        Me.dgvStockInD = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPriceType = New System.Windows.Forms.ComboBox()
        Me.cboWhs = New System.Windows.Forms.ComboBox()
        Me.dtpStockIn = New System.Windows.Forms.DateTimePicker()
        Me.tbDocNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tsStockIn = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.SavePrintIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbRemarks = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbAddedBy = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbStockInTotal = New System.Windows.Forms.TextBox()
        Me.tsStockInD = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAddIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsEditIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDeleteIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.dgvStockInD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsStockIn.SuspendLayout()
        Me.tsStockInD.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvStockInD
        '
        Me.dgvStockInD.AllowUserToAddRows = False
        Me.dgvStockInD.AllowUserToDeleteRows = False
        Me.dgvStockInD.AllowUserToResizeRows = False
        Me.dgvStockInD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvStockInD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStockInD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgvStockInD.Location = New System.Drawing.Point(13, 129)
        Me.dgvStockInD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvStockInD.Name = "dgvStockInD"
        Me.dgvStockInD.ReadOnly = True
        Me.dgvStockInD.RowHeadersVisible = False
        Me.dgvStockInD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStockInD.Size = New System.Drawing.Size(756, 282)
        Me.dgvStockInD.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 39
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "ITEMCODE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 87
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "DESCRIPTION"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "QTY"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 51
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "UNIT"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 57
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "PCKG"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 59
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "UNIT PRICE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 89
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "AMOUNT"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 80
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Location = New System.Drawing.Point(184, 22)
        Me.TextBox2.MaxLength = 10
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(104, 22)
        Me.TextBox2.TabIndex = 76
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Price Type :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Stock In To :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Date :"
        '
        'cboPriceType
        '
        Me.cboPriceType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboPriceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPriceType.FormattingEnabled = True
        Me.cboPriceType.Items.AddRange(New Object() {"1", "A", "B", "C"})
        Me.cboPriceType.Location = New System.Drawing.Point(85, 73)
        Me.cboPriceType.Name = "cboPriceType"
        Me.cboPriceType.Size = New System.Drawing.Size(44, 21)
        Me.cboPriceType.TabIndex = 71
        '
        'cboWhs
        '
        Me.cboWhs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboWhs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWhs.FormattingEnabled = True
        Me.cboWhs.Location = New System.Drawing.Point(85, 48)
        Me.cboWhs.Name = "cboWhs"
        Me.cboWhs.Size = New System.Drawing.Size(277, 21)
        Me.cboWhs.TabIndex = 70
        '
        'dtpStockIn
        '
        Me.dtpStockIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpStockIn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStockIn.Location = New System.Drawing.Point(85, 22)
        Me.dtpStockIn.Name = "dtpStockIn"
        Me.dtpStockIn.Size = New System.Drawing.Size(93, 22)
        Me.dtpStockIn.TabIndex = 69
        '
        'tbDocNo
        '
        Me.tbDocNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDocNo.Location = New System.Drawing.Point(665, 37)
        Me.tbDocNo.MaxLength = 10
        Me.tbDocNo.Name = "tbDocNo"
        Me.tbDocNo.ReadOnly = True
        Me.tbDocNo.Size = New System.Drawing.Size(104, 22)
        Me.tbDocNo.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(610, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Doc No :"
        '
        'tsStockIn
        '
        Me.tsStockIn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsStockIn.Dock = System.Windows.Forms.DockStyle.None
        Me.tsStockIn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsStockIn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.NewIn, Me.ToolStripSeparator33, Me.SavePrintIn, Me.ToolStripSeparator34, Me.SaveIn, Me.ToolStripSeparator35, Me.EditIn, Me.ToolStripSeparator7})
        Me.tsStockIn.Location = New System.Drawing.Point(566, 9)
        Me.tsStockIn.Name = "tsStockIn"
        Me.tsStockIn.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsStockIn.Size = New System.Drawing.Size(202, 25)
        Me.tsStockIn.TabIndex = 78
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'NewIn
        '
        Me.NewIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NewIn.Image = CType(resources.GetObject("NewIn.Image"), System.Drawing.Image)
        Me.NewIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewIn.Name = "NewIn"
        Me.NewIn.Size = New System.Drawing.Size(35, 22)
        Me.NewIn.Text = "&New"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'SavePrintIn
        '
        Me.SavePrintIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SavePrintIn.Image = CType(resources.GetObject("SavePrintIn.Image"), System.Drawing.Image)
        Me.SavePrintIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SavePrintIn.Name = "SavePrintIn"
        Me.SavePrintIn.Size = New System.Drawing.Size(68, 22)
        Me.SavePrintIn.Text = "Save+&Print"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'SaveIn
        '
        Me.SaveIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveIn.Image = CType(resources.GetObject("SaveIn.Image"), System.Drawing.Image)
        Me.SaveIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveIn.Name = "SaveIn"
        Me.SaveIn.Size = New System.Drawing.Size(35, 22)
        Me.SaveIn.Text = "&Save"
        Me.SaveIn.ToolTipText = "S&ave "
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'EditIn
        '
        Me.EditIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditIn.Image = CType(resources.GetObject("EditIn.Image"), System.Drawing.Image)
        Me.EditIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditIn.Name = "EditIn"
        Me.EditIn.Size = New System.Drawing.Size(31, 22)
        Me.EditIn.Text = "&Edit"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'tbRemarks
        '
        Me.tbRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbRemarks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbRemarks.Location = New System.Drawing.Point(85, 100)
        Me.tbRemarks.MaxLength = 50
        Me.tbRemarks.Name = "tbRemarks"
        Me.tbRemarks.Size = New System.Drawing.Size(684, 22)
        Me.tbRemarks.TabIndex = 79
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Remarks :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(600, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Added By :"
        '
        'tbAddedBy
        '
        Me.tbAddedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbAddedBy.Location = New System.Drawing.Point(665, 62)
        Me.tbAddedBy.MaxLength = 10
        Me.tbAddedBy.Name = "tbAddedBy"
        Me.tbAddedBy.ReadOnly = True
        Me.tbAddedBy.Size = New System.Drawing.Size(104, 22)
        Me.tbAddedBy.TabIndex = 81
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(572, 424)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "TOTAL :"
        '
        'tbStockInTotal
        '
        Me.tbStockInTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbStockInTotal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStockInTotal.Location = New System.Drawing.Point(622, 420)
        Me.tbStockInTotal.MaxLength = 50
        Me.tbStockInTotal.Name = "tbStockInTotal"
        Me.tbStockInTotal.ReadOnly = True
        Me.tbStockInTotal.Size = New System.Drawing.Size(146, 22)
        Me.tbStockInTotal.TabIndex = 83
        '
        'tsStockInD
        '
        Me.tsStockInD.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsStockInD.Dock = System.Windows.Forms.DockStyle.None
        Me.tsStockInD.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsStockInD.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.tsAddIn, Me.ToolStripSeparator6, Me.tsEditIn, Me.ToolStripSeparator1, Me.tsDeleteIn, Me.ToolStripSeparator8})
        Me.tsStockInD.Location = New System.Drawing.Point(14, 415)
        Me.tsStockInD.Name = "tsStockInD"
        Me.tsStockInD.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsStockInD.Size = New System.Drawing.Size(135, 25)
        Me.tsStockInD.TabIndex = 85
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tsAddIn
        '
        Me.tsAddIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsAddIn.Image = CType(resources.GetObject("tsAddIn.Image"), System.Drawing.Image)
        Me.tsAddIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAddIn.Name = "tsAddIn"
        Me.tsAddIn.Size = New System.Drawing.Size(33, 22)
        Me.tsAddIn.Text = "&Add"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tsEditIn
        '
        Me.tsEditIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsEditIn.Image = CType(resources.GetObject("tsEditIn.Image"), System.Drawing.Image)
        Me.tsEditIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEditIn.Name = "tsEditIn"
        Me.tsEditIn.Size = New System.Drawing.Size(31, 22)
        Me.tsEditIn.Text = "E&dit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsDeleteIn
        '
        Me.tsDeleteIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsDeleteIn.Image = CType(resources.GetObject("tsDeleteIn.Image"), System.Drawing.Image)
        Me.tsDeleteIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDeleteIn.Name = "tsDeleteIn"
        Me.tsDeleteIn.Size = New System.Drawing.Size(44, 22)
        Me.tsDeleteIn.Text = "&Delete"
        Me.tsDeleteIn.ToolTipText = "S&ave "
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'frmStockInD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 454)
        Me.Controls.Add(Me.tsStockInD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbStockInTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbAddedBy)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbRemarks)
        Me.Controls.Add(Me.tsStockIn)
        Me.Controls.Add(Me.tbDocNo)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboPriceType)
        Me.Controls.Add(Me.cboWhs)
        Me.Controls.Add(Me.dtpStockIn)
        Me.Controls.Add(Me.dgvStockInD)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockInD"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MISCELLANEOUS STOCK IN"
        CType(Me.dgvStockInD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsStockIn.ResumeLayout(False)
        Me.tsStockIn.PerformLayout()
        Me.tsStockInD.ResumeLayout(False)
        Me.tsStockInD.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvStockInD As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPriceType As System.Windows.Forms.ComboBox
    Friend WithEvents cboWhs As System.Windows.Forms.ComboBox
    Friend WithEvents dtpStockIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbDocNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tsStockIn As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SavePrintIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbAddedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbStockInTotal As System.Windows.Forms.TextBox
    Friend WithEvents tsStockInD As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsAddIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsEditIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDeleteIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
