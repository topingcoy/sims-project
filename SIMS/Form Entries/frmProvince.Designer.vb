<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProvince
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProvince))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbSearcHProv = New System.Windows.Forms.TextBox()
        Me.gbxProvince = New System.Windows.Forms.GroupBox()
        Me.tsgbxProv = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveProv = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearProv = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseProv = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbProvName = New System.Windows.Forms.TextBox()
        Me.tbProvCode = New System.Windows.Forms.TextBox()
        Me.dgvProvince = New System.Windows.Forms.DataGridView()
        Me.tsProvince = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAddProv = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsEditProv = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDeleteProv = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbxProvince.SuspendLayout()
        Me.tsgbxProv.SuspendLayout()
        CType(Me.dgvProvince, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsProvince.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbSearcHProv
        '
        Me.tbSearcHProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearcHProv.Location = New System.Drawing.Point(12, 12)
        Me.tbSearcHProv.MaxLength = 50
        Me.tbSearcHProv.Name = "tbSearcHProv"
        Me.tbSearcHProv.Size = New System.Drawing.Size(248, 22)
        Me.tbSearcHProv.TabIndex = 67
        '
        'gbxProvince
        '
        Me.gbxProvince.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbxProvince.Controls.Add(Me.tsgbxProv)
        Me.gbxProvince.Controls.Add(Me.Label2)
        Me.gbxProvince.Controls.Add(Me.Label1)
        Me.gbxProvince.Controls.Add(Me.tbProvName)
        Me.gbxProvince.Controls.Add(Me.tbProvCode)
        Me.gbxProvince.Location = New System.Drawing.Point(49, 121)
        Me.gbxProvince.Name = "gbxProvince"
        Me.gbxProvince.Size = New System.Drawing.Size(384, 127)
        Me.gbxProvince.TabIndex = 66
        Me.gbxProvince.TabStop = False
        Me.gbxProvince.Text = "ADD PROVINCE"
        Me.gbxProvince.Visible = False
        '
        'tsgbxProv
        '
        Me.tsgbxProv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsgbxProv.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsgbxProv.Dock = System.Windows.Forms.DockStyle.None
        Me.tsgbxProv.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsgbxProv.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.SaveProv, Me.ToolStripSeparator7, Me.ClearProv, Me.ToolStripSeparator9, Me.CloseProv, Me.ToolStripSeparator10})
        Me.tsgbxProv.Location = New System.Drawing.Point(216, 94)
        Me.tsgbxProv.Name = "tsgbxProv"
        Me.tsgbxProv.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsgbxProv.Size = New System.Drawing.Size(140, 25)
        Me.tsgbxProv.TabIndex = 62
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'SaveProv
        '
        Me.SaveProv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveProv.Image = CType(resources.GetObject("SaveProv.Image"), System.Drawing.Image)
        Me.SaveProv.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveProv.Name = "SaveProv"
        Me.SaveProv.Size = New System.Drawing.Size(35, 22)
        Me.SaveProv.Text = "&Save"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ClearProv
        '
        Me.ClearProv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ClearProv.Image = CType(resources.GetObject("ClearProv.Image"), System.Drawing.Image)
        Me.ClearProv.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearProv.Name = "ClearProv"
        Me.ClearProv.Size = New System.Drawing.Size(38, 22)
        Me.ClearProv.Text = "&Clear"
        Me.ClearProv.ToolTipText = "S&ave "
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'CloseProv
        '
        Me.CloseProv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CloseProv.Image = CType(resources.GetObject("CloseProv.Image"), System.Drawing.Image)
        Me.CloseProv.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseProv.Name = "CloseProv"
        Me.CloseProv.Size = New System.Drawing.Size(40, 22)
        Me.CloseProv.Text = "Cl&ose"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "PROVINCE  :"
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
        'tbProvName
        '
        Me.tbProvName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbProvName.Location = New System.Drawing.Point(92, 67)
        Me.tbProvName.MaxLength = 30
        Me.tbProvName.Name = "tbProvName"
        Me.tbProvName.Size = New System.Drawing.Size(263, 22)
        Me.tbProvName.TabIndex = 59
        '
        'tbProvCode
        '
        Me.tbProvCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbProvCode.Location = New System.Drawing.Point(92, 39)
        Me.tbProvCode.MaxLength = 5
        Me.tbProvCode.Name = "tbProvCode"
        Me.tbProvCode.Size = New System.Drawing.Size(119, 22)
        Me.tbProvCode.TabIndex = 58
        '
        'dgvProvince
        '
        Me.dgvProvince.AllowUserToAddRows = False
        Me.dgvProvince.AllowUserToDeleteRows = False
        Me.dgvProvince.AllowUserToResizeRows = False
        Me.dgvProvince.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvProvince.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProvince.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Column2})
        Me.dgvProvince.Location = New System.Drawing.Point(12, 39)
        Me.dgvProvince.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvProvince.Name = "dgvProvince"
        Me.dgvProvince.ReadOnly = True
        Me.dgvProvince.RowHeadersVisible = False
        Me.dgvProvince.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProvince.Size = New System.Drawing.Size(456, 267)
        Me.dgvProvince.TabIndex = 65
        '
        'tsProvince
        '
        Me.tsProvince.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsProvince.Dock = System.Windows.Forms.DockStyle.None
        Me.tsProvince.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsProvince.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsAddProv, Me.ToolStripSeparator33, Me.tsEditProv, Me.ToolStripSeparator34, Me.tsDeleteProv, Me.ToolStripSeparator35})
        Me.tsProvince.Location = New System.Drawing.Point(106, 313)
        Me.tsProvince.Name = "tsProvince"
        Me.tsProvince.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsProvince.Size = New System.Drawing.Size(260, 25)
        Me.tsProvince.TabIndex = 68
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'tsAddProv
        '
        Me.tsAddProv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsAddProv.Image = CType(resources.GetObject("tsAddProv.Image"), System.Drawing.Image)
        Me.tsAddProv.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAddProv.Name = "tsAddProv"
        Me.tsAddProv.Size = New System.Drawing.Size(66, 22)
        Me.tsAddProv.Text = "[F5] - ADD"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'tsEditProv
        '
        Me.tsEditProv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsEditProv.Image = CType(resources.GetObject("tsEditProv.Image"), System.Drawing.Image)
        Me.tsEditProv.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEditProv.Name = "tsEditProv"
        Me.tsEditProv.Size = New System.Drawing.Size(87, 22)
        Me.tsEditProv.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'tsDeleteProv
        '
        Me.tsDeleteProv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsDeleteProv.Image = CType(resources.GetObject("tsDeleteProv.Image"), System.Drawing.Image)
        Me.tsDeleteProv.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDeleteProv.Name = "tsDeleteProv"
        Me.tsDeleteProv.Size = New System.Drawing.Size(80, 22)
        Me.tsDeleteProv.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
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
        Me.Column1.HeaderText = "CODE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 62
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "PROVINCE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'frmProvince
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 347)
        Me.Controls.Add(Me.tsProvince)
        Me.Controls.Add(Me.tbSearcHProv)
        Me.Controls.Add(Me.gbxProvince)
        Me.Controls.Add(Me.dgvProvince)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProvince"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANAGE PROVINCE"
        Me.gbxProvince.ResumeLayout(False)
        Me.gbxProvince.PerformLayout()
        Me.tsgbxProv.ResumeLayout(False)
        Me.tsgbxProv.PerformLayout()
        CType(Me.dgvProvince, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsProvince.ResumeLayout(False)
        Me.tsProvince.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbSearcHProv As System.Windows.Forms.TextBox
    Friend WithEvents gbxProvince As System.Windows.Forms.GroupBox
    Friend WithEvents tsgbxProv As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveProv As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearProv As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseProv As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbProvName As System.Windows.Forms.TextBox
    Friend WithEvents tbProvCode As System.Windows.Forms.TextBox
    Friend WithEvents dgvProvince As System.Windows.Forms.DataGridView
    Friend WithEvents tsProvince As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsAddProv As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsEditProv As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDeleteProv As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
