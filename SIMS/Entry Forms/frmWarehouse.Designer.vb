<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWarehouse
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWarehouse))
        Me.dgvWhs = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.gbxWarehouse = New System.Windows.Forms.GroupBox()
        Me.tsMenu2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveWhs = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdateWhs = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWhsname = New System.Windows.Forms.TextBox()
        Me.txtWhscode = New System.Windows.Forms.TextBox()
        Me.lblpkno = New System.Windows.Forms.Label()
        Me.tbSearchWhs = New System.Windows.Forms.TextBox()
        Me.tsMenu1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_AddWarehouse = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_RereshWhs = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_DeleteWhs = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.dgvWhs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxWarehouse.SuspendLayout()
        Me.tsMenu2.SuspendLayout()
        Me.tsMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvWhs
        '
        Me.dgvWhs.AllowUserToAddRows = False
        Me.dgvWhs.AllowUserToDeleteRows = False
        Me.dgvWhs.AllowUserToResizeRows = False
        Me.dgvWhs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvWhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWhs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Column2, Me.Column3, Me.Edit, Me.Delete})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvWhs.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvWhs.Location = New System.Drawing.Point(12, 39)
        Me.dgvWhs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvWhs.Name = "dgvWhs"
        Me.dgvWhs.ReadOnly = True
        Me.dgvWhs.RowHeadersVisible = False
        Me.dgvWhs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvWhs.Size = New System.Drawing.Size(413, 240)
        Me.dgvWhs.TabIndex = 17
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
        Me.Column2.HeaderText = "WAREHOUSE"
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
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Edit.Visible = False
        '
        'Delete
        '
        Me.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Delete.HeaderText = ""
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Delete.Visible = False
        '
        'gbxWarehouse
        '
        Me.gbxWarehouse.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbxWarehouse.Controls.Add(Me.tsMenu2)
        Me.gbxWarehouse.Controls.Add(Me.Label2)
        Me.gbxWarehouse.Controls.Add(Me.Label1)
        Me.gbxWarehouse.Controls.Add(Me.txtWhsname)
        Me.gbxWarehouse.Controls.Add(Me.txtWhscode)
        Me.gbxWarehouse.Controls.Add(Me.lblpkno)
        Me.gbxWarehouse.Location = New System.Drawing.Point(431, 39)
        Me.gbxWarehouse.Name = "gbxWarehouse"
        Me.gbxWarehouse.Size = New System.Drawing.Size(384, 127)
        Me.gbxWarehouse.TabIndex = 58
        Me.gbxWarehouse.TabStop = False
        Me.gbxWarehouse.Text = "ADD  WAREHOUSE"
        '
        'tsMenu2
        '
        Me.tsMenu2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsMenu2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsMenu2.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMenu2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenu2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.SaveWhs, Me.ToolStripSeparator7, Me.UpdateWhs, Me.ToolStripSeparator10})
        Me.tsMenu2.Location = New System.Drawing.Point(271, 97)
        Me.tsMenu2.Name = "tsMenu2"
        Me.tsMenu2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tsMenu2.Size = New System.Drawing.Size(105, 25)
        Me.tsMenu2.TabIndex = 62
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'SaveWhs
        '
        Me.SaveWhs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveWhs.Image = CType(resources.GetObject("SaveWhs.Image"), System.Drawing.Image)
        Me.SaveWhs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveWhs.Name = "SaveWhs"
        Me.SaveWhs.Size = New System.Drawing.Size(35, 22)
        Me.SaveWhs.Text = "&Save"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'UpdateWhs
        '
        Me.UpdateWhs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.UpdateWhs.Image = CType(resources.GetObject("UpdateWhs.Image"), System.Drawing.Image)
        Me.UpdateWhs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UpdateWhs.Name = "UpdateWhs"
        Me.UpdateWhs.Size = New System.Drawing.Size(49, 22)
        Me.UpdateWhs.Text = "&Update"
        Me.UpdateWhs.ToolTipText = "S&ave "
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "WAREHOUSE :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "CODE :"
        '
        'txtWhsname
        '
        Me.txtWhsname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtWhsname.Location = New System.Drawing.Point(92, 67)
        Me.txtWhsname.MaxLength = 30
        Me.txtWhsname.Name = "txtWhsname"
        Me.txtWhsname.Size = New System.Drawing.Size(284, 22)
        Me.txtWhsname.TabIndex = 59
        '
        'txtWhscode
        '
        Me.txtWhscode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtWhscode.Location = New System.Drawing.Point(92, 39)
        Me.txtWhscode.MaxLength = 5
        Me.txtWhscode.Name = "txtWhscode"
        Me.txtWhscode.Size = New System.Drawing.Size(85, 22)
        Me.txtWhscode.TabIndex = 58
        '
        'lblpkno
        '
        Me.lblpkno.AutoSize = True
        Me.lblpkno.Location = New System.Drawing.Point(119, 42)
        Me.lblpkno.Name = "lblpkno"
        Me.lblpkno.Size = New System.Drawing.Size(47, 13)
        Me.lblpkno.TabIndex = 64
        Me.lblpkno.Text = "lblpkno"
        '
        'tbSearchWhs
        '
        Me.tbSearchWhs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchWhs.Location = New System.Drawing.Point(12, 12)
        Me.tbSearchWhs.MaxLength = 50
        Me.tbSearchWhs.Name = "tbSearchWhs"
        Me.tbSearchWhs.Size = New System.Drawing.Size(177, 22)
        Me.tbSearchWhs.TabIndex = 60
        '
        'tsMenu1
        '
        Me.tsMenu1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsMenu1.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMenu1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.btn_AddWarehouse, Me.ToolStripSeparator1, Me.btn_RereshWhs, Me.ToolStripSeparator8, Me.btn_DeleteWhs, Me.ToolStripSeparator5})
        Me.tsMenu1.Location = New System.Drawing.Point(12, 283)
        Me.tsMenu1.Name = "tsMenu1"
        Me.tsMenu1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsMenu1.Size = New System.Drawing.Size(247, 25)
        Me.tsMenu1.TabIndex = 131
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'btn_AddWarehouse
        '
        Me.btn_AddWarehouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_AddWarehouse.Image = CType(resources.GetObject("btn_AddWarehouse.Image"), System.Drawing.Image)
        Me.btn_AddWarehouse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_AddWarehouse.Name = "btn_AddWarehouse"
        Me.btn_AddWarehouse.Size = New System.Drawing.Size(64, 22)
        Me.btn_AddWarehouse.Text = "[F5] - Add"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btn_RereshWhs
        '
        Me.btn_RereshWhs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_RereshWhs.Image = CType(resources.GetObject("btn_RereshWhs.Image"), System.Drawing.Image)
        Me.btn_RereshWhs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_RereshWhs.Name = "btn_RereshWhs"
        Me.btn_RereshWhs.Size = New System.Drawing.Size(81, 22)
        Me.btn_RereshWhs.Text = "[F6] - Refresh"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'btn_DeleteWhs
        '
        Me.btn_DeleteWhs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_DeleteWhs.Image = CType(resources.GetObject("btn_DeleteWhs.Image"), System.Drawing.Image)
        Me.btn_DeleteWhs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_DeleteWhs.Name = "btn_DeleteWhs"
        Me.btn_DeleteWhs.Size = New System.Drawing.Size(75, 22)
        Me.btn_DeleteWhs.Text = "[F7] - Delete"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'frmWarehouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(826, 315)
        Me.Controls.Add(Me.tsMenu1)
        Me.Controls.Add(Me.tbSearchWhs)
        Me.Controls.Add(Me.gbxWarehouse)
        Me.Controls.Add(Me.dgvWhs)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWarehouse"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANAGE WAREHOUSE"
        CType(Me.dgvWhs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxWarehouse.ResumeLayout(False)
        Me.gbxWarehouse.PerformLayout()
        Me.tsMenu2.ResumeLayout(False)
        Me.tsMenu2.PerformLayout()
        Me.tsMenu1.ResumeLayout(False)
        Me.tsMenu1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvWhs As System.Windows.Forms.DataGridView
    Friend WithEvents gbxWarehouse As System.Windows.Forms.GroupBox
    Friend WithEvents tsMenu2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveWhs As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UpdateWhs As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtWhsname As System.Windows.Forms.TextBox
    Friend WithEvents txtWhscode As System.Windows.Forms.TextBox
    Friend WithEvents tbSearchWhs As System.Windows.Forms.TextBox
    Friend WithEvents lblpkno As System.Windows.Forms.Label
    Friend WithEvents tsMenu1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_RereshWhs As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_DeleteWhs As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_AddWarehouse As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Edit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Delete As System.Windows.Forms.DataGridViewButtonColumn
End Class
