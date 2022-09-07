<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGStoBOH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGStoBOH))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsMenu1 = New System.Windows.Forms.ToolStrip()
        Me.dtpGStoBO2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpGStoBO1 = New System.Windows.Forms.DateTimePicker()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsGo = New System.Windows.Forms.ToolStrip()
        Me.tbSearchGoodstockBO = New System.Windows.Forms.TextBox()
        Me.dgvGStoBOList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tsMenu1.SuspendLayout()
        Me.tsGo.SuspendLayout()
        CType(Me.dgvGStoBOList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tsMenu1
        '
        Me.tsMenu1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsMenu1.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMenu1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.btnAdd, Me.ToolStripSeparator8, Me.btnEdit, Me.ToolStripSeparator9, Me.btnDelete, Me.ToolStripSeparator10})
        Me.tsMenu1.Location = New System.Drawing.Point(176, 364)
        Me.tsMenu1.Name = "tsMenu1"
        Me.tsMenu1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsMenu1.Size = New System.Drawing.Size(260, 25)
        Me.tsMenu1.TabIndex = 79
        Me.tsMenu1.Text = "ToolStrip1"
        '
        'dtpGStoBO2
        '
        Me.dtpGStoBO2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpGStoBO2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpGStoBO2.Location = New System.Drawing.Point(463, 9)
        Me.dtpGStoBO2.Name = "dtpGStoBO2"
        Me.dtpGStoBO2.Size = New System.Drawing.Size(93, 22)
        Me.dtpGStoBO2.TabIndex = 76
        '
        'dtpGStoBO1
        '
        Me.dtpGStoBO1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpGStoBO1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpGStoBO1.Location = New System.Drawing.Point(335, 9)
        Me.dtpGStoBO1.Name = "dtpGStoBO1"
        Me.dtpGStoBO1.Size = New System.Drawing.Size(93, 22)
        Me.dtpGStoBO1.TabIndex = 75
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnGo
        '
        Me.btnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnGo.Image = CType(resources.GetObject("btnGo.Image"), System.Drawing.Image)
        Me.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(26, 22)
        Me.btnGo.Text = "&Go"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Location = New System.Drawing.Point(437, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "To"
        '
        'tsGo
        '
        Me.tsGo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsGo.Dock = System.Windows.Forms.DockStyle.None
        Me.tsGo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsGo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnGo, Me.ToolStripSeparator2})
        Me.tsGo.Location = New System.Drawing.Point(559, 8)
        Me.tsGo.Name = "tsGo"
        Me.tsGo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsGo.Size = New System.Drawing.Size(41, 25)
        Me.tsGo.TabIndex = 77
        '
        'tbSearchGoodstockBO
        '
        Me.tbSearchGoodstockBO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchGoodstockBO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSearchGoodstockBO.Location = New System.Drawing.Point(14, 9)
        Me.tbSearchGoodstockBO.MaxLength = 50
        Me.tbSearchGoodstockBO.Name = "tbSearchGoodstockBO"
        Me.tbSearchGoodstockBO.Size = New System.Drawing.Size(160, 22)
        Me.tbSearchGoodstockBO.TabIndex = 74
        '
        'dgvGStoBOList
        '
        Me.dgvGStoBOList.AllowUserToAddRows = False
        Me.dgvGStoBOList.AllowUserToDeleteRows = False
        Me.dgvGStoBOList.AllowUserToResizeRows = False
        Me.dgvGStoBOList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGStoBOList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGStoBOList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGStoBOList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column5})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGStoBOList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvGStoBOList.Location = New System.Drawing.Point(14, 36)
        Me.dgvGStoBOList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvGStoBOList.Name = "dgvGStoBOList"
        Me.dgvGStoBOList.ReadOnly = True
        Me.dgvGStoBOList.RowHeadersVisible = False
        Me.dgvGStoBOList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGStoBOList.Size = New System.Drawing.Size(586, 322)
        Me.dgvGStoBOList.TabIndex = 73
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "TRANS NO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 86
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "DATE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 58
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = " INTO"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column6.HeaderText = "AMOUNT"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 80
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "ADDED BY"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 83
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(258, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Date Range :"
        '
        'frmGStoBOH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(612, 392)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tsMenu1)
        Me.Controls.Add(Me.dtpGStoBO2)
        Me.Controls.Add(Me.dtpGStoBO1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tsGo)
        Me.Controls.Add(Me.tbSearchGoodstockBO)
        Me.Controls.Add(Me.dgvGStoBOList)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGStoBOH"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GOODSTOCK CONVERTED TO B.O. LIST"
        Me.tsMenu1.ResumeLayout(False)
        Me.tsMenu1.PerformLayout()
        Me.tsGo.ResumeLayout(False)
        Me.tsGo.PerformLayout()
        CType(Me.dgvGStoBOList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsMenu1 As System.Windows.Forms.ToolStrip
    Friend WithEvents dtpGStoBO2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpGStoBO1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tsGo As System.Windows.Forms.ToolStrip
    Friend WithEvents tbSearchGoodstockBO As System.Windows.Forms.TextBox
    Friend WithEvents dgvGStoBOList As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
