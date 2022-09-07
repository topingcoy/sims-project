<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGStoBOD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGStoBOD))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditGStoBO = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveGStoBO = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.SavePrintGStoBO = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewGStoBO = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsGStoBOitem = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAddGStoBO = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsEditGStoBO = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDeleteGStoBO = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbRemarks = New System.Windows.Forms.TextBox()
        Me.tbDocNo = New System.Windows.Forms.TextBox()
        Me.tbTransNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxPriceType = New System.Windows.Forms.ComboBox()
        Me.cbxWhs = New System.Windows.Forms.ComboBox()
        Me.dtpGStoBO = New System.Windows.Forms.DateTimePicker()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbGStoBOTotal = New System.Windows.Forms.TextBox()
        Me.tbAddedBy = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tsGStoBO = New System.Windows.Forms.ToolStrip()
        Me.dgvGStoBOItem = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsGStoBOitem.SuspendLayout()
        Me.tsGStoBO.SuspendLayout()
        CType(Me.dgvGStoBOItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "UNIT PRICE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 89
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'EditGStoBO
        '
        Me.EditGStoBO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditGStoBO.Image = CType(resources.GetObject("EditGStoBO.Image"), System.Drawing.Image)
        Me.EditGStoBO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditGStoBO.Name = "EditGStoBO"
        Me.EditGStoBO.Size = New System.Drawing.Size(31, 22)
        Me.EditGStoBO.Text = "&Edit"
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'SaveGStoBO
        '
        Me.SaveGStoBO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveGStoBO.Image = CType(resources.GetObject("SaveGStoBO.Image"), System.Drawing.Image)
        Me.SaveGStoBO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveGStoBO.Name = "SaveGStoBO"
        Me.SaveGStoBO.Size = New System.Drawing.Size(35, 22)
        Me.SaveGStoBO.Text = "&Save"
        Me.SaveGStoBO.ToolTipText = "S&ave "
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'SavePrintGStoBO
        '
        Me.SavePrintGStoBO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SavePrintGStoBO.Image = CType(resources.GetObject("SavePrintGStoBO.Image"), System.Drawing.Image)
        Me.SavePrintGStoBO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SavePrintGStoBO.Name = "SavePrintGStoBO"
        Me.SavePrintGStoBO.Size = New System.Drawing.Size(68, 22)
        Me.SavePrintGStoBO.Text = "Save+&Print"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'NewGStoBO
        '
        Me.NewGStoBO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NewGStoBO.Image = CType(resources.GetObject("NewGStoBO.Image"), System.Drawing.Image)
        Me.NewGStoBO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewGStoBO.Name = "NewGStoBO"
        Me.NewGStoBO.Size = New System.Drawing.Size(35, 22)
        Me.NewGStoBO.Text = "&New"
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "AMOUNT"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 80
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "PCKG"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 59
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "UNIT"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 57
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "QTY"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 51
        '
        'tsGStoBOitem
        '
        Me.tsGStoBOitem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsGStoBOitem.Dock = System.Windows.Forms.DockStyle.None
        Me.tsGStoBOitem.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsGStoBOitem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.tsAddGStoBO, Me.ToolStripSeparator6, Me.tsEditGStoBO, Me.ToolStripSeparator1, Me.tsDeleteGStoBO, Me.ToolStripSeparator8})
        Me.tsGStoBOitem.Location = New System.Drawing.Point(20, 419)
        Me.tsGStoBOitem.Name = "tsGStoBOitem"
        Me.tsGStoBOitem.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsGStoBOitem.Size = New System.Drawing.Size(135, 25)
        Me.tsGStoBOitem.TabIndex = 121
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tsAddGStoBO
        '
        Me.tsAddGStoBO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsAddGStoBO.Image = CType(resources.GetObject("tsAddGStoBO.Image"), System.Drawing.Image)
        Me.tsAddGStoBO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAddGStoBO.Name = "tsAddGStoBO"
        Me.tsAddGStoBO.Size = New System.Drawing.Size(33, 22)
        Me.tsAddGStoBO.Text = "&Add"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tsEditGStoBO
        '
        Me.tsEditGStoBO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsEditGStoBO.Image = CType(resources.GetObject("tsEditGStoBO.Image"), System.Drawing.Image)
        Me.tsEditGStoBO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEditGStoBO.Name = "tsEditGStoBO"
        Me.tsEditGStoBO.Size = New System.Drawing.Size(31, 22)
        Me.tsEditGStoBO.Text = "E&dit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsDeleteGStoBO
        '
        Me.tsDeleteGStoBO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsDeleteGStoBO.Image = CType(resources.GetObject("tsDeleteGStoBO.Image"), System.Drawing.Image)
        Me.tsDeleteGStoBO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDeleteGStoBO.Name = "tsDeleteGStoBO"
        Me.tsDeleteGStoBO.Size = New System.Drawing.Size(44, 22)
        Me.tsDeleteGStoBO.Text = "&Delete"
        Me.tsDeleteGStoBO.ToolTipText = "S&ave "
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'tbRemarks
        '
        Me.tbRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbRemarks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbRemarks.Location = New System.Drawing.Point(110, 104)
        Me.tbRemarks.MaxLength = 50
        Me.tbRemarks.Name = "tbRemarks"
        Me.tbRemarks.Size = New System.Drawing.Size(665, 22)
        Me.tbRemarks.TabIndex = 115
        '
        'tbDocNo
        '
        Me.tbDocNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDocNo.Location = New System.Drawing.Point(671, 41)
        Me.tbDocNo.MaxLength = 10
        Me.tbDocNo.Name = "tbDocNo"
        Me.tbDocNo.ReadOnly = True
        Me.tbDocNo.Size = New System.Drawing.Size(104, 22)
        Me.tbDocNo.TabIndex = 113
        '
        'tbTransNo
        '
        Me.tbTransNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTransNo.Location = New System.Drawing.Point(209, 25)
        Me.tbTransNo.MaxLength = 10
        Me.tbTransNo.Name = "tbTransNo"
        Me.tbTransNo.ReadOnly = True
        Me.tbTransNo.Size = New System.Drawing.Size(104, 22)
        Me.tbTransNo.TabIndex = 112
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(616, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "Doc No :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Price Type :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Convert From :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Date :"
        '
        'cbxPriceType
        '
        Me.cbxPriceType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxPriceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPriceType.FormattingEnabled = True
        Me.cbxPriceType.Items.AddRange(New Object() {"1", "A", "B", "C"})
        Me.cbxPriceType.Location = New System.Drawing.Point(110, 77)
        Me.cbxPriceType.Name = "cbxPriceType"
        Me.cbxPriceType.Size = New System.Drawing.Size(44, 21)
        Me.cbxPriceType.TabIndex = 107
        '
        'cbxWhs
        '
        Me.cbxWhs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxWhs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxWhs.FormattingEnabled = True
        Me.cbxWhs.Location = New System.Drawing.Point(110, 53)
        Me.cbxWhs.Name = "cbxWhs"
        Me.cbxWhs.Size = New System.Drawing.Size(277, 21)
        Me.cbxWhs.TabIndex = 106
        '
        'dtpGStoBO
        '
        Me.dtpGStoBO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpGStoBO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpGStoBO.Location = New System.Drawing.Point(110, 25)
        Me.dtpGStoBO.Name = "dtpGStoBO"
        Me.dtpGStoBO.Size = New System.Drawing.Size(93, 22)
        Me.dtpGStoBO.TabIndex = 105
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column2.HeaderText = "DESCRIPTION"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(578, 428)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "TOTAL :"
        '
        'tbGStoBOTotal
        '
        Me.tbGStoBOTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbGStoBOTotal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGStoBOTotal.Location = New System.Drawing.Point(628, 424)
        Me.tbGStoBOTotal.MaxLength = 50
        Me.tbGStoBOTotal.Name = "tbGStoBOTotal"
        Me.tbGStoBOTotal.ReadOnly = True
        Me.tbGStoBOTotal.Size = New System.Drawing.Size(146, 22)
        Me.tbGStoBOTotal.TabIndex = 119
        '
        'tbAddedBy
        '
        Me.tbAddedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbAddedBy.Location = New System.Drawing.Point(671, 66)
        Me.tbAddedBy.MaxLength = 10
        Me.tbAddedBy.Name = "tbAddedBy"
        Me.tbAddedBy.ReadOnly = True
        Me.tbAddedBy.Size = New System.Drawing.Size(104, 22)
        Me.tbAddedBy.TabIndex = 117
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "Remarks :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(606, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 118
        Me.Label6.Text = "Added By :"
        '
        'tsGStoBO
        '
        Me.tsGStoBO.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsGStoBO.Dock = System.Windows.Forms.DockStyle.None
        Me.tsGStoBO.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsGStoBO.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.NewGStoBO, Me.ToolStripSeparator33, Me.SavePrintGStoBO, Me.ToolStripSeparator34, Me.SaveGStoBO, Me.ToolStripSeparator35, Me.EditGStoBO, Me.ToolStripSeparator7})
        Me.tsGStoBO.Location = New System.Drawing.Point(572, 13)
        Me.tsGStoBO.Name = "tsGStoBO"
        Me.tsGStoBO.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsGStoBO.Size = New System.Drawing.Size(202, 25)
        Me.tsGStoBO.TabIndex = 114
        '
        'dgvGStoBOItem
        '
        Me.dgvGStoBOItem.AllowUserToAddRows = False
        Me.dgvGStoBOItem.AllowUserToDeleteRows = False
        Me.dgvGStoBOItem.AllowUserToResizeRows = False
        Me.dgvGStoBOItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvGStoBOItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGStoBOItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgvGStoBOItem.Location = New System.Drawing.Point(19, 133)
        Me.dgvGStoBOItem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvGStoBOItem.Name = "dgvGStoBOItem"
        Me.dgvGStoBOItem.ReadOnly = True
        Me.dgvGStoBOItem.RowHeadersVisible = False
        Me.dgvGStoBOItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGStoBOItem.Size = New System.Drawing.Size(756, 282)
        Me.dgvGStoBOItem.TabIndex = 104
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
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "ITEMCODE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 87
        '
        'frmGStoBOD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 458)
        Me.Controls.Add(Me.tsGStoBOitem)
        Me.Controls.Add(Me.tbRemarks)
        Me.Controls.Add(Me.tbDocNo)
        Me.Controls.Add(Me.tbTransNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxPriceType)
        Me.Controls.Add(Me.cbxWhs)
        Me.Controls.Add(Me.dtpGStoBO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbGStoBOTotal)
        Me.Controls.Add(Me.tbAddedBy)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tsGStoBO)
        Me.Controls.Add(Me.dgvGStoBOItem)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGStoBOD"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GOODSTOCK CONVERTED TO B.O."
        Me.tsGStoBOitem.ResumeLayout(False)
        Me.tsGStoBOitem.PerformLayout()
        Me.tsGStoBO.ResumeLayout(False)
        Me.tsGStoBO.PerformLayout()
        CType(Me.dgvGStoBOItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditGStoBO As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveGStoBO As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SavePrintGStoBO As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewGStoBO As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsGStoBOitem As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsAddGStoBO As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsEditGStoBO As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDeleteGStoBO As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbRemarks As System.Windows.Forms.TextBox
    Friend WithEvents tbDocNo As System.Windows.Forms.TextBox
    Friend WithEvents tbTransNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxPriceType As System.Windows.Forms.ComboBox
    Friend WithEvents cbxWhs As System.Windows.Forms.ComboBox
    Friend WithEvents dtpGStoBO As System.Windows.Forms.DateTimePicker
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbGStoBOTotal As System.Windows.Forms.TextBox
    Friend WithEvents tbAddedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tsGStoBO As System.Windows.Forms.ToolStrip
    Friend WithEvents dgvGStoBOItem As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
