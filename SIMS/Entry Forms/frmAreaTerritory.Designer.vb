<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAreaTerritory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAreaTerritory))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAreaName = New System.Windows.Forms.TextBox()
        Me.txtAreaCode = New System.Windows.Forms.TextBox()
        Me.lblpkno = New System.Windows.Forms.Label()
        Me.gbxArea = New System.Windows.Forms.GroupBox()
        Me.tsMenu2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnUpdate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtSearchArea = New System.Windows.Forms.TextBox()
        Me.dgvArea = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tsMenu1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.gbxArea.SuspendLayout()
        Me.tsMenu2.SuspendLayout()
        CType(Me.dgvArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "AREA NAME :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "CODE :"
        '
        'txtAreaName
        '
        Me.txtAreaName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAreaName.Location = New System.Drawing.Point(92, 67)
        Me.txtAreaName.MaxLength = 30
        Me.txtAreaName.Name = "txtAreaName"
        Me.txtAreaName.Size = New System.Drawing.Size(263, 22)
        Me.txtAreaName.TabIndex = 59
        '
        'txtAreaCode
        '
        Me.txtAreaCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAreaCode.Location = New System.Drawing.Point(92, 39)
        Me.txtAreaCode.MaxLength = 5
        Me.txtAreaCode.Name = "txtAreaCode"
        Me.txtAreaCode.Size = New System.Drawing.Size(85, 22)
        Me.txtAreaCode.TabIndex = 58
        '
        'lblpkno
        '
        Me.lblpkno.AutoSize = True
        Me.lblpkno.Location = New System.Drawing.Point(143, 42)
        Me.lblpkno.Name = "lblpkno"
        Me.lblpkno.Size = New System.Drawing.Size(34, 13)
        Me.lblpkno.TabIndex = 64
        Me.lblpkno.Text = "pkno"
        '
        'gbxArea
        '
        Me.gbxArea.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbxArea.Controls.Add(Me.tsMenu2)
        Me.gbxArea.Controls.Add(Me.Label2)
        Me.gbxArea.Controls.Add(Me.Label1)
        Me.gbxArea.Controls.Add(Me.txtAreaName)
        Me.gbxArea.Controls.Add(Me.txtAreaCode)
        Me.gbxArea.Controls.Add(Me.lblpkno)
        Me.gbxArea.Location = New System.Drawing.Point(431, 37)
        Me.gbxArea.Name = "gbxArea"
        Me.gbxArea.Size = New System.Drawing.Size(384, 127)
        Me.gbxArea.TabIndex = 69
        Me.gbxArea.TabStop = False
        Me.gbxArea.Text = "ADD AREA"
        '
        'tsMenu2
        '
        Me.tsMenu2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsMenu2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsMenu2.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMenu2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenu2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator7, Me.btnSave, Me.btnUpdate, Me.ToolStripSeparator10})
        Me.tsMenu2.Location = New System.Drawing.Point(256, 99)
        Me.tsMenu2.Name = "tsMenu2"
        Me.tsMenu2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tsMenu2.Size = New System.Drawing.Size(99, 25)
        Me.tsMenu2.TabIndex = 63
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(35, 22)
        Me.btnSave.Text = "&Save"
        '
        'btnUpdate
        '
        Me.btnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(49, 22)
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.ToolTipText = "S&ave "
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'txtSearchArea
        '
        Me.txtSearchArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearchArea.Location = New System.Drawing.Point(12, 10)
        Me.txtSearchArea.MaxLength = 50
        Me.txtSearchArea.Name = "txtSearchArea"
        Me.txtSearchArea.Size = New System.Drawing.Size(177, 22)
        Me.txtSearchArea.TabIndex = 70
        '
        'dgvArea
        '
        Me.dgvArea.AllowUserToAddRows = False
        Me.dgvArea.AllowUserToDeleteRows = False
        Me.dgvArea.AllowUserToResizeRows = False
        Me.dgvArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArea.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Column2, Me.Column3, Me.Edit, Me.Delete})
        Me.dgvArea.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvArea.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvArea.Location = New System.Drawing.Point(12, 37)
        Me.dgvArea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvArea.Name = "dgvArea"
        Me.dgvArea.ReadOnly = True
        Me.dgvArea.RowHeadersVisible = False
        Me.dgvArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvArea.Size = New System.Drawing.Size(413, 240)
        Me.dgvArea.TabIndex = 71
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "CODE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 62
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column2.HeaderText = "AREA NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "pkno"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Edit
        '
        Me.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Edit.HeaderText = ""
        Me.Edit.Image = CType(resources.GetObject("Edit.Image"), System.Drawing.Image)
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Edit.Visible = False
        '
        'Delete
        '
        Me.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Delete.HeaderText = ""
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Delete.Visible = False
        '
        'tsMenu1
        '
        Me.tsMenu1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsMenu1.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMenu1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.btnAdd, Me.ToolStripSeparator1, Me.btnRefresh, Me.ToolStripSeparator2, Me.btnDelete, Me.ToolStripSeparator5})
        Me.tsMenu1.Location = New System.Drawing.Point(9, 281)
        Me.tsMenu1.Name = "tsMenu1"
        Me.tsMenu1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsMenu1.Size = New System.Drawing.Size(247, 25)
        Me.tsMenu1.TabIndex = 133
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'btnAdd
        '
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(64, 22)
        Me.btnAdd.Text = "[F5] - Add"
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
        Me.btnRefresh.Size = New System.Drawing.Size(81, 22)
        Me.btnRefresh.Text = "[F6] - Refresh"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 22)
        Me.btnDelete.Text = "[F7] - Delete"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'frmAreaTerritory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 311)
        Me.Controls.Add(Me.tsMenu1)
        Me.Controls.Add(Me.gbxArea)
        Me.Controls.Add(Me.txtSearchArea)
        Me.Controls.Add(Me.dgvArea)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAreaTerritory"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANAGE AREA/TERRITORY"
        Me.gbxArea.ResumeLayout(False)
        Me.gbxArea.PerformLayout()
        Me.tsMenu2.ResumeLayout(False)
        Me.tsMenu2.PerformLayout()
        CType(Me.dgvArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenu1.ResumeLayout(False)
        Me.tsMenu1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAreaName As System.Windows.Forms.TextBox
    Friend WithEvents txtAreaCode As System.Windows.Forms.TextBox
    Friend WithEvents lblpkno As System.Windows.Forms.Label
    Friend WithEvents gbxArea As System.Windows.Forms.GroupBox
    Friend WithEvents tsMenu2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtSearchArea As System.Windows.Forms.TextBox
    Friend WithEvents dgvArea As System.Windows.Forms.DataGridView
    Friend WithEvents tsMenu1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Edit As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Delete As System.Windows.Forms.DataGridViewImageColumn
End Class
