<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockInH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockInH))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsMenu2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.goStockIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.dtpS2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpS1 = New System.Windows.Forms.DateTimePicker()
        Me.tsMenu1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvStockInList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsMenu2.SuspendLayout()
        Me.tsMenu1.SuspendLayout()
        CType(Me.dgvStockInList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtSearch.Location = New System.Drawing.Point(12, 10)
        Me.txtSearch.MaxLength = 50
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(176, 22)
        Me.txtSearch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Location = New System.Drawing.Point(382, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "To"
        '
        'tsMenu2
        '
        Me.tsMenu2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsMenu2.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMenu2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenu2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnRefresh, Me.ToolStripSeparator3, Me.goStockIn, Me.ToolStripSeparator2})
        Me.tsMenu2.Location = New System.Drawing.Point(504, 9)
        Me.tsMenu2.Name = "tsMenu2"
        Me.tsMenu2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsMenu2.Size = New System.Drawing.Size(97, 25)
        Me.tsMenu2.TabIndex = 70
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnRefresh
        '
        Me.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(50, 22)
        Me.btnRefresh.Text = "&Refresh"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'goStockIn
        '
        Me.goStockIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.goStockIn.Image = CType(resources.GetObject("goStockIn.Image"), System.Drawing.Image)
        Me.goStockIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.goStockIn.Name = "goStockIn"
        Me.goStockIn.Size = New System.Drawing.Size(26, 22)
        Me.goStockIn.Text = "&Go"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'dtpS2
        '
        Me.dtpS2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpS2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpS2.Location = New System.Drawing.Point(408, 10)
        Me.dtpS2.Name = "dtpS2"
        Me.dtpS2.Size = New System.Drawing.Size(93, 22)
        Me.dtpS2.TabIndex = 68
        '
        'dtpS1
        '
        Me.dtpS1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpS1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpS1.Location = New System.Drawing.Point(280, 10)
        Me.dtpS1.Name = "dtpS1"
        Me.dtpS1.Size = New System.Drawing.Size(93, 22)
        Me.dtpS1.TabIndex = 67
        '
        'tsMenu1
        '
        Me.tsMenu1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsMenu1.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMenu1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.btnAdd, Me.ToolStripSeparator8, Me.btnEdit, Me.ToolStripSeparator9, Me.btnDelete, Me.ToolStripSeparator10})
        Me.tsMenu1.Location = New System.Drawing.Point(161, 375)
        Me.tsMenu1.Name = "tsMenu1"
        Me.tsMenu1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsMenu1.Size = New System.Drawing.Size(260, 25)
        Me.tsMenu1.TabIndex = 72
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'btnAdd
        '
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(66, 22)
        Me.btnAdd.Text = "[F5] - ADD"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'btnEdit
        '
        Me.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(87, 22)
        Me.btnEdit.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 22)
        Me.btnDelete.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(203, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Date Range :"
        '
        'dgvStockInList
        '
        Me.dgvStockInList.AllowUserToAddRows = False
        Me.dgvStockInList.AllowUserToDeleteRows = False
        Me.dgvStockInList.AllowUserToResizeRows = False
        Me.dgvStockInList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvStockInList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStockInList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column5})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStockInList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStockInList.Location = New System.Drawing.Point(14, 37)
        Me.dgvStockInList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvStockInList.Name = "dgvStockInList"
        Me.dgvStockInList.ReadOnly = True
        Me.dgvStockInList.RowHeadersVisible = False
        Me.dgvStockInList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStockInList.Size = New System.Drawing.Size(589, 331)
        Me.dgvStockInList.TabIndex = 74
        '
        'Column1
        '
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "TRANSNO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 83
        '
        'Column3
        '
        Me.Column3.HeaderText = "DATE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 58
        '
        'Column4
        '
        Me.Column4.HeaderText = "STOCK IN TO"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 255
        '
        'Column6
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column6.HeaderText = "AMOUNT"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 80
        '
        'Column5
        '
        Me.Column5.HeaderText = "ENTERED BY"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 93
        '
        'frmStockInH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(612, 406)
        Me.Controls.Add(Me.dgvStockInList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tsMenu1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tsMenu2)
        Me.Controls.Add(Me.dtpS2)
        Me.Controls.Add(Me.dtpS1)
        Me.Controls.Add(Me.txtSearch)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockInH"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MISCELLANEOUS STOCK IN LIST"
        Me.tsMenu2.ResumeLayout(False)
        Me.tsMenu2.PerformLayout()
        Me.tsMenu1.ResumeLayout(False)
        Me.tsMenu1.PerformLayout()
        CType(Me.dgvStockInList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tsMenu2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents goStockIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dtpS2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpS1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tsMenu1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvStockInList As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
