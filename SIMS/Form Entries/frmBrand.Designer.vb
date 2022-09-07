<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBrand))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbSearchBrand = New System.Windows.Forms.TextBox()
        Me.tsBrand = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAddBrand = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsEditBrand = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDeleteBrand = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.gbxBrand = New System.Windows.Forms.GroupBox()
        Me.tsgbxBrand = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveBrand = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearBrand = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseBrand = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbBrandName = New System.Windows.Forms.TextBox()
        Me.tbBrandCode = New System.Windows.Forms.TextBox()
        Me.dgvBrand = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsBrand.SuspendLayout()
        Me.gbxBrand.SuspendLayout()
        Me.tsgbxBrand.SuspendLayout()
        CType(Me.dgvBrand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbSearchBrand
        '
        Me.tbSearchBrand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchBrand.Location = New System.Drawing.Point(12, 12)
        Me.tbSearchBrand.MaxLength = 50
        Me.tbSearchBrand.Name = "tbSearchBrand"
        Me.tbSearchBrand.Size = New System.Drawing.Size(248, 22)
        Me.tbSearchBrand.TabIndex = 64
        '
        'tsBrand
        '
        Me.tsBrand.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsBrand.Dock = System.Windows.Forms.DockStyle.None
        Me.tsBrand.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsBrand.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsAddBrand, Me.ToolStripSeparator33, Me.tsEditBrand, Me.ToolStripSeparator34, Me.tsDeleteBrand, Me.ToolStripSeparator35})
        Me.tsBrand.Location = New System.Drawing.Point(106, 313)
        Me.tsBrand.Name = "tsBrand"
        Me.tsBrand.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsBrand.Size = New System.Drawing.Size(260, 25)
        Me.tsBrand.TabIndex = 63
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'tsAddBrand
        '
        Me.tsAddBrand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsAddBrand.Image = CType(resources.GetObject("tsAddBrand.Image"), System.Drawing.Image)
        Me.tsAddBrand.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAddBrand.Name = "tsAddBrand"
        Me.tsAddBrand.Size = New System.Drawing.Size(66, 22)
        Me.tsAddBrand.Text = "[F5] - ADD"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'tsEditBrand
        '
        Me.tsEditBrand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsEditBrand.Image = CType(resources.GetObject("tsEditBrand.Image"), System.Drawing.Image)
        Me.tsEditBrand.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEditBrand.Name = "tsEditBrand"
        Me.tsEditBrand.Size = New System.Drawing.Size(87, 22)
        Me.tsEditBrand.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'tsDeleteBrand
        '
        Me.tsDeleteBrand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsDeleteBrand.Image = CType(resources.GetObject("tsDeleteBrand.Image"), System.Drawing.Image)
        Me.tsDeleteBrand.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDeleteBrand.Name = "tsDeleteBrand"
        Me.tsDeleteBrand.Size = New System.Drawing.Size(80, 22)
        Me.tsDeleteBrand.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'gbxBrand
        '
        Me.gbxBrand.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbxBrand.Controls.Add(Me.tsgbxBrand)
        Me.gbxBrand.Controls.Add(Me.Label2)
        Me.gbxBrand.Controls.Add(Me.Label1)
        Me.gbxBrand.Controls.Add(Me.tbBrandName)
        Me.gbxBrand.Controls.Add(Me.tbBrandCode)
        Me.gbxBrand.Location = New System.Drawing.Point(50, 121)
        Me.gbxBrand.Name = "gbxBrand"
        Me.gbxBrand.Size = New System.Drawing.Size(384, 127)
        Me.gbxBrand.TabIndex = 62
        Me.gbxBrand.TabStop = False
        Me.gbxBrand.Text = "ADD BRAND"
        Me.gbxBrand.Visible = False
        '
        'tsgbxBrand
        '
        Me.tsgbxBrand.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsgbxBrand.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsgbxBrand.Dock = System.Windows.Forms.DockStyle.None
        Me.tsgbxBrand.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsgbxBrand.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.SaveBrand, Me.ToolStripSeparator7, Me.ClearBrand, Me.ToolStripSeparator9, Me.CloseBrand, Me.ToolStripSeparator10})
        Me.tsgbxBrand.Location = New System.Drawing.Point(216, 94)
        Me.tsgbxBrand.Name = "tsgbxBrand"
        Me.tsgbxBrand.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsgbxBrand.Size = New System.Drawing.Size(140, 25)
        Me.tsgbxBrand.TabIndex = 62
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'SaveBrand
        '
        Me.SaveBrand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveBrand.Image = CType(resources.GetObject("SaveBrand.Image"), System.Drawing.Image)
        Me.SaveBrand.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveBrand.Name = "SaveBrand"
        Me.SaveBrand.Size = New System.Drawing.Size(35, 22)
        Me.SaveBrand.Text = "&Save"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ClearBrand
        '
        Me.ClearBrand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ClearBrand.Image = CType(resources.GetObject("ClearBrand.Image"), System.Drawing.Image)
        Me.ClearBrand.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearBrand.Name = "ClearBrand"
        Me.ClearBrand.Size = New System.Drawing.Size(38, 22)
        Me.ClearBrand.Text = "&Clear"
        Me.ClearBrand.ToolTipText = "S&ave "
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'CloseBrand
        '
        Me.CloseBrand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CloseBrand.Image = CType(resources.GetObject("CloseBrand.Image"), System.Drawing.Image)
        Me.CloseBrand.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseBrand.Name = "CloseBrand"
        Me.CloseBrand.Size = New System.Drawing.Size(40, 22)
        Me.CloseBrand.Text = "Cl&ose"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "BRAND :"
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
        'tbBrandName
        '
        Me.tbBrandName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbBrandName.Location = New System.Drawing.Point(92, 67)
        Me.tbBrandName.MaxLength = 30
        Me.tbBrandName.Name = "tbBrandName"
        Me.tbBrandName.Size = New System.Drawing.Size(263, 22)
        Me.tbBrandName.TabIndex = 59
        '
        'tbBrandCode
        '
        Me.tbBrandCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbBrandCode.Location = New System.Drawing.Point(92, 39)
        Me.tbBrandCode.MaxLength = 5
        Me.tbBrandCode.Name = "tbBrandCode"
        Me.tbBrandCode.Size = New System.Drawing.Size(119, 22)
        Me.tbBrandCode.TabIndex = 58
        '
        'dgvBrand
        '
        Me.dgvBrand.AllowUserToAddRows = False
        Me.dgvBrand.AllowUserToDeleteRows = False
        Me.dgvBrand.AllowUserToResizeRows = False
        Me.dgvBrand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBrand.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Column2})
        Me.dgvBrand.Location = New System.Drawing.Point(12, 39)
        Me.dgvBrand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvBrand.Name = "dgvBrand"
        Me.dgvBrand.ReadOnly = True
        Me.dgvBrand.RowHeadersVisible = False
        Me.dgvBrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBrand.Size = New System.Drawing.Size(456, 267)
        Me.dgvBrand.TabIndex = 61
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
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column2.HeaderText = "BRAND NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'frmBrand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 346)
        Me.Controls.Add(Me.tbSearchBrand)
        Me.Controls.Add(Me.tsBrand)
        Me.Controls.Add(Me.gbxBrand)
        Me.Controls.Add(Me.dgvBrand)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(106, 313)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBrand"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANAGE BRAND"
        Me.tsBrand.ResumeLayout(False)
        Me.tsBrand.PerformLayout()
        Me.gbxBrand.ResumeLayout(False)
        Me.gbxBrand.PerformLayout()
        Me.tsgbxBrand.ResumeLayout(False)
        Me.tsgbxBrand.PerformLayout()
        CType(Me.dgvBrand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbSearchBrand As System.Windows.Forms.TextBox
    Friend WithEvents tsBrand As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsAddBrand As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsEditBrand As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDeleteBrand As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents gbxBrand As System.Windows.Forms.GroupBox
    Friend WithEvents tsgbxBrand As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveBrand As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearBrand As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseBrand As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbBrandName As System.Windows.Forms.TextBox
    Friend WithEvents tbBrandCode As System.Windows.Forms.TextBox
    Friend WithEvents dgvBrand As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
