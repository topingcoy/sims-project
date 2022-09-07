<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockOutD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockOutD))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsStockOutD = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAddOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsEditOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDeleteOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbStockOUTTotal = New System.Windows.Forms.TextBox()
        Me.tbAddedBy = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbRemarks = New System.Windows.Forms.TextBox()
        Me.tsStockOut = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.SavePrintOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbDocNo = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPriceType = New System.Windows.Forms.ComboBox()
        Me.cboWhs = New System.Windows.Forms.ComboBox()
        Me.dtpStockIn = New System.Windows.Forms.DateTimePicker()
        Me.dgvStockInD = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsStockOutD.SuspendLayout()
        Me.tsStockOut.SuspendLayout()
        CType(Me.dgvStockInD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsStockOutD
        '
        Me.tsStockOutD.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsStockOutD.Dock = System.Windows.Forms.DockStyle.None
        Me.tsStockOutD.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsStockOutD.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.tsAddOut, Me.ToolStripSeparator6, Me.tsEditOut, Me.ToolStripSeparator1, Me.tsDeleteOut, Me.ToolStripSeparator8})
        Me.tsStockOutD.Location = New System.Drawing.Point(16, 417)
        Me.tsStockOutD.Name = "tsStockOutD"
        Me.tsStockOutD.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsStockOutD.Size = New System.Drawing.Size(135, 25)
        Me.tsStockOutD.TabIndex = 103
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tsAddOut
        '
        Me.tsAddOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsAddOut.Image = CType(resources.GetObject("tsAddOut.Image"), System.Drawing.Image)
        Me.tsAddOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAddOut.Name = "tsAddOut"
        Me.tsAddOut.Size = New System.Drawing.Size(33, 22)
        Me.tsAddOut.Text = "&Add"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tsEditOut
        '
        Me.tsEditOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsEditOut.Image = CType(resources.GetObject("tsEditOut.Image"), System.Drawing.Image)
        Me.tsEditOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEditOut.Name = "tsEditOut"
        Me.tsEditOut.Size = New System.Drawing.Size(31, 22)
        Me.tsEditOut.Text = "E&dit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsDeleteOut
        '
        Me.tsDeleteOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsDeleteOut.Image = CType(resources.GetObject("tsDeleteOut.Image"), System.Drawing.Image)
        Me.tsDeleteOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDeleteOut.Name = "tsDeleteOut"
        Me.tsDeleteOut.Size = New System.Drawing.Size(44, 22)
        Me.tsDeleteOut.Text = "&Delete"
        Me.tsDeleteOut.ToolTipText = "S&ave "
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(574, 426)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "TOTAL :"
        '
        'tbStockOUTTotal
        '
        Me.tbStockOUTTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbStockOUTTotal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStockOUTTotal.Location = New System.Drawing.Point(624, 422)
        Me.tbStockOUTTotal.MaxLength = 50
        Me.tbStockOUTTotal.Name = "tbStockOUTTotal"
        Me.tbStockOUTTotal.ReadOnly = True
        Me.tbStockOUTTotal.Size = New System.Drawing.Size(146, 22)
        Me.tbStockOUTTotal.TabIndex = 101
        '
        'tbAddedBy
        '
        Me.tbAddedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbAddedBy.Location = New System.Drawing.Point(667, 64)
        Me.tbAddedBy.MaxLength = 10
        Me.tbAddedBy.Name = "tbAddedBy"
        Me.tbAddedBy.ReadOnly = True
        Me.tbAddedBy.Size = New System.Drawing.Size(104, 22)
        Me.tbAddedBy.TabIndex = 99
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Remarks :"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(602, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Added By :"
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "AMOUNT"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 80
        '
        'tbRemarks
        '
        Me.tbRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbRemarks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbRemarks.Location = New System.Drawing.Point(106, 102)
        Me.tbRemarks.MaxLength = 50
        Me.tbRemarks.Name = "tbRemarks"
        Me.tbRemarks.Size = New System.Drawing.Size(665, 22)
        Me.tbRemarks.TabIndex = 97
        '
        'tsStockOut
        '
        Me.tsStockOut.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsStockOut.Dock = System.Windows.Forms.DockStyle.None
        Me.tsStockOut.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsStockOut.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.NewOut, Me.ToolStripSeparator33, Me.SavePrintOut, Me.ToolStripSeparator34, Me.SaveOut, Me.ToolStripSeparator35, Me.EditOut, Me.ToolStripSeparator7})
        Me.tsStockOut.Location = New System.Drawing.Point(568, 11)
        Me.tsStockOut.Name = "tsStockOut"
        Me.tsStockOut.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsStockOut.Size = New System.Drawing.Size(202, 25)
        Me.tsStockOut.TabIndex = 96
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'NewOut
        '
        Me.NewOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NewOut.Image = CType(resources.GetObject("NewOut.Image"), System.Drawing.Image)
        Me.NewOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewOut.Name = "NewOut"
        Me.NewOut.Size = New System.Drawing.Size(35, 22)
        Me.NewOut.Text = "&New"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'SavePrintOut
        '
        Me.SavePrintOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SavePrintOut.Image = CType(resources.GetObject("SavePrintOut.Image"), System.Drawing.Image)
        Me.SavePrintOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SavePrintOut.Name = "SavePrintOut"
        Me.SavePrintOut.Size = New System.Drawing.Size(68, 22)
        Me.SavePrintOut.Text = "Save+&Print"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'SaveOut
        '
        Me.SaveOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveOut.Image = CType(resources.GetObject("SaveOut.Image"), System.Drawing.Image)
        Me.SaveOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveOut.Name = "SaveOut"
        Me.SaveOut.Size = New System.Drawing.Size(35, 22)
        Me.SaveOut.Text = "&Save"
        Me.SaveOut.ToolTipText = "S&ave "
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'EditOut
        '
        Me.EditOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditOut.Image = CType(resources.GetObject("EditOut.Image"), System.Drawing.Image)
        Me.EditOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditOut.Name = "EditOut"
        Me.EditOut.Size = New System.Drawing.Size(31, 22)
        Me.EditOut.Text = "&Edit"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'tbDocNo
        '
        Me.tbDocNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDocNo.Location = New System.Drawing.Point(667, 39)
        Me.tbDocNo.MaxLength = 10
        Me.tbDocNo.Name = "tbDocNo"
        Me.tbDocNo.ReadOnly = True
        Me.tbDocNo.Size = New System.Drawing.Size(104, 22)
        Me.tbDocNo.TabIndex = 95
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Location = New System.Drawing.Point(205, 23)
        Me.TextBox2.MaxLength = 10
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(104, 22)
        Me.TextBox2.TabIndex = 94
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(612, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Doc No :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Price Type :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Stock Out From :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Date :"
        '
        'cboPriceType
        '
        Me.cboPriceType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboPriceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPriceType.FormattingEnabled = True
        Me.cboPriceType.Items.AddRange(New Object() {"1", "A", "B", "C"})
        Me.cboPriceType.Location = New System.Drawing.Point(106, 75)
        Me.cboPriceType.Name = "cboPriceType"
        Me.cboPriceType.Size = New System.Drawing.Size(44, 21)
        Me.cboPriceType.TabIndex = 89
        '
        'cboWhs
        '
        Me.cboWhs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboWhs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWhs.FormattingEnabled = True
        Me.cboWhs.Location = New System.Drawing.Point(106, 51)
        Me.cboWhs.Name = "cboWhs"
        Me.cboWhs.Size = New System.Drawing.Size(277, 21)
        Me.cboWhs.TabIndex = 88
        '
        'dtpStockIn
        '
        Me.dtpStockIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpStockIn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStockIn.Location = New System.Drawing.Point(106, 23)
        Me.dtpStockIn.Name = "dtpStockIn"
        Me.dtpStockIn.Size = New System.Drawing.Size(93, 22)
        Me.dtpStockIn.TabIndex = 87
        '
        'dgvStockInD
        '
        Me.dgvStockInD.AllowUserToAddRows = False
        Me.dgvStockInD.AllowUserToDeleteRows = False
        Me.dgvStockInD.AllowUserToResizeRows = False
        Me.dgvStockInD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvStockInD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStockInD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgvStockInD.Location = New System.Drawing.Point(15, 131)
        Me.dgvStockInD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvStockInD.Name = "dgvStockInD"
        Me.dgvStockInD.ReadOnly = True
        Me.dgvStockInD.RowHeadersVisible = False
        Me.dgvStockInD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStockInD.Size = New System.Drawing.Size(756, 282)
        Me.dgvStockInD.TabIndex = 86
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "UNIT PRICE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 89
        '
        'frmStockOutD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 454)
        Me.Controls.Add(Me.tsStockOutD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbStockOUTTotal)
        Me.Controls.Add(Me.tbAddedBy)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbRemarks)
        Me.Controls.Add(Me.tsStockOut)
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
        Me.Name = "frmStockOutD"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MISCELLANEOUS STOCK OUT"
        Me.tsStockOutD.ResumeLayout(False)
        Me.tsStockOutD.PerformLayout()
        Me.tsStockOut.ResumeLayout(False)
        Me.tsStockOut.PerformLayout()
        CType(Me.dgvStockInD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsStockOutD As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsAddOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsEditOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDeleteOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbStockOUTTotal As System.Windows.Forms.TextBox
    Friend WithEvents tbAddedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbRemarks As System.Windows.Forms.TextBox
    Friend WithEvents tsStockOut As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SavePrintOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbDocNo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPriceType As System.Windows.Forms.ComboBox
    Friend WithEvents cboWhs As System.Windows.Forms.ComboBox
    Friend WithEvents dtpStockIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvStockInD As System.Windows.Forms.DataGridView
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
