<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhysicalD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhysicalD))
        Me.dgvPhysiclitem = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.cbxWhs = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpPhysical = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbRemarks = New System.Windows.Forms.TextBox()
        Me.tsPhysicalD = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewPhysical = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.SavePrintPhysical = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.SavePhysical = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditPhysical = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsPhysicalitem = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAddOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsEditOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDeleteOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tbTransNo = New System.Windows.Forms.TextBox()
        Me.tbAddedBy = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvPhysiclitem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsPhysicalD.SuspendLayout()
        Me.tsPhysicalitem.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPhysiclitem
        '
        Me.dgvPhysiclitem.AllowUserToAddRows = False
        Me.dgvPhysiclitem.AllowUserToDeleteRows = False
        Me.dgvPhysiclitem.AllowUserToResizeRows = False
        Me.dgvPhysiclitem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPhysiclitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPhysiclitem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.dgvPhysiclitem.Location = New System.Drawing.Point(12, 94)
        Me.dgvPhysiclitem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvPhysiclitem.Name = "dgvPhysiclitem"
        Me.dgvPhysiclitem.ReadOnly = True
        Me.dgvPhysiclitem.RowHeadersVisible = False
        Me.dgvPhysiclitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPhysiclitem.Size = New System.Drawing.Size(756, 424)
        Me.dgvPhysiclitem.TabIndex = 87
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
        Me.Column3.HeaderText = "CASES"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 64
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "PCKG"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 59
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "BAGS"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 59
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "PCKG"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 59
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "PIECES"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 66
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "VAR CS"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "VAR BGS"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "VAR PC"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        '
        'cbxWhs
        '
        Me.cbxWhs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxWhs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxWhs.FormattingEnabled = True
        Me.cbxWhs.Location = New System.Drawing.Point(115, 40)
        Me.cbxWhs.Name = "cbxWhs"
        Me.cbxWhs.Size = New System.Drawing.Size(305, 21)
        Me.cbxWhs.TabIndex = 89
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Warehouse :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Inventory Date :"
        '
        'dtpPhysical
        '
        Me.dtpPhysical.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpPhysical.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPhysical.Location = New System.Drawing.Point(115, 12)
        Me.dtpPhysical.Name = "dtpPhysical"
        Me.dtpPhysical.Size = New System.Drawing.Size(93, 22)
        Me.dtpPhysical.TabIndex = 92
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-70, -182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Trans No."
        '
        'tbRemarks
        '
        Me.tbRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbRemarks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbRemarks.Location = New System.Drawing.Point(115, 67)
        Me.tbRemarks.MaxLength = 50
        Me.tbRemarks.Name = "tbRemarks"
        Me.tbRemarks.Size = New System.Drawing.Size(652, 22)
        Me.tbRemarks.TabIndex = 99
        '
        'tsPhysicalD
        '
        Me.tsPhysicalD.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsPhysicalD.Dock = System.Windows.Forms.DockStyle.None
        Me.tsPhysicalD.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsPhysicalD.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.NewPhysical, Me.ToolStripSeparator33, Me.SavePrintPhysical, Me.ToolStripSeparator34, Me.SavePhysical, Me.ToolStripSeparator35, Me.EditPhysical, Me.ToolStripSeparator7})
        Me.tsPhysicalD.Location = New System.Drawing.Point(564, 5)
        Me.tsPhysicalD.Name = "tsPhysicalD"
        Me.tsPhysicalD.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsPhysicalD.Size = New System.Drawing.Size(202, 25)
        Me.tsPhysicalD.TabIndex = 101
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'NewPhysical
        '
        Me.NewPhysical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NewPhysical.Image = CType(resources.GetObject("NewPhysical.Image"), System.Drawing.Image)
        Me.NewPhysical.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewPhysical.Name = "NewPhysical"
        Me.NewPhysical.Size = New System.Drawing.Size(35, 22)
        Me.NewPhysical.Text = "&New"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'SavePrintPhysical
        '
        Me.SavePrintPhysical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SavePrintPhysical.Image = CType(resources.GetObject("SavePrintPhysical.Image"), System.Drawing.Image)
        Me.SavePrintPhysical.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SavePrintPhysical.Name = "SavePrintPhysical"
        Me.SavePrintPhysical.Size = New System.Drawing.Size(68, 22)
        Me.SavePrintPhysical.Text = "Save+&Print"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'SavePhysical
        '
        Me.SavePhysical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SavePhysical.Image = CType(resources.GetObject("SavePhysical.Image"), System.Drawing.Image)
        Me.SavePhysical.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SavePhysical.Name = "SavePhysical"
        Me.SavePhysical.Size = New System.Drawing.Size(35, 22)
        Me.SavePhysical.Text = "&Save"
        Me.SavePhysical.ToolTipText = "S&ave "
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'EditPhysical
        '
        Me.EditPhysical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditPhysical.Image = CType(resources.GetObject("EditPhysical.Image"), System.Drawing.Image)
        Me.EditPhysical.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditPhysical.Name = "EditPhysical"
        Me.EditPhysical.Size = New System.Drawing.Size(31, 22)
        Me.EditPhysical.Text = "&Edit"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'tsPhysicalitem
        '
        Me.tsPhysicalitem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsPhysicalitem.Dock = System.Windows.Forms.DockStyle.None
        Me.tsPhysicalitem.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsPhysicalitem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.tsAddOut, Me.ToolStripSeparator6, Me.tsEditOut, Me.ToolStripSeparator1, Me.tsDeleteOut, Me.ToolStripSeparator8, Me.ToolStripButton1})
        Me.tsPhysicalitem.Location = New System.Drawing.Point(10, 522)
        Me.tsPhysicalitem.Name = "tsPhysicalitem"
        Me.tsPhysicalitem.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsPhysicalitem.Size = New System.Drawing.Size(245, 25)
        Me.tsPhysicalitem.TabIndex = 104
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripButton1.Text = "&Load Default Items"
        '
        'tbTransNo
        '
        Me.tbTransNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTransNo.Location = New System.Drawing.Point(298, 14)
        Me.tbTransNo.MaxLength = 10
        Me.tbTransNo.Name = "tbTransNo"
        Me.tbTransNo.ReadOnly = True
        Me.tbTransNo.Size = New System.Drawing.Size(122, 22)
        Me.tbTransNo.TabIndex = 105
        '
        'tbAddedBy
        '
        Me.tbAddedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbAddedBy.Location = New System.Drawing.Point(662, 41)
        Me.tbAddedBy.MaxLength = 10
        Me.tbAddedBy.Name = "tbAddedBy"
        Me.tbAddedBy.ReadOnly = True
        Me.tbAddedBy.Size = New System.Drawing.Size(104, 22)
        Me.tbAddedBy.TabIndex = 106
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(597, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Added By :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(237, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Trans No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Remarks :"
        '
        'frmPhysicalD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 554)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbAddedBy)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbTransNo)
        Me.Controls.Add(Me.tsPhysicalitem)
        Me.Controls.Add(Me.tsPhysicalD)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbRemarks)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpPhysical)
        Me.Controls.Add(Me.cbxWhs)
        Me.Controls.Add(Me.dgvPhysiclitem)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPhysicalD"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PHYSICAL INVENTORY"
        CType(Me.dgvPhysiclitem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsPhysicalD.ResumeLayout(False)
        Me.tsPhysicalD.PerformLayout()
        Me.tsPhysicalitem.ResumeLayout(False)
        Me.tsPhysicalitem.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPhysiclitem As System.Windows.Forms.DataGridView
    Friend WithEvents cbxWhs As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpPhysical As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbRemarks As System.Windows.Forms.TextBox
    Friend WithEvents tsPhysicalD As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewPhysical As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SavePrintPhysical As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SavePhysical As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditPhysical As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsPhysicalitem As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsAddOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsEditOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDeleteOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbTransNo As System.Windows.Forms.TextBox
    Friend WithEvents tbAddedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
