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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWarehouse))
        Me.dgvWhs = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gBxWarehouse = New System.Windows.Forms.GroupBox()
        Me.tsgbxWhs = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveWhs = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearWhs = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseWhs = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbWhsName = New System.Windows.Forms.TextBox()
        Me.tbWhsCode = New System.Windows.Forms.TextBox()
        Me.tsWhs = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAddWhs = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsEditWhs = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDeleteWhs = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbSearchWhs = New System.Windows.Forms.TextBox()
        CType(Me.dgvWhs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gBxWarehouse.SuspendLayout()
        Me.tsgbxWhs.SuspendLayout()
        Me.tsWhs.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvWhs
        '
        Me.dgvWhs.AllowUserToAddRows = False
        Me.dgvWhs.AllowUserToDeleteRows = False
        Me.dgvWhs.AllowUserToResizeRows = False
        Me.dgvWhs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvWhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWhs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Column2})
        Me.dgvWhs.Location = New System.Drawing.Point(12, 39)
        Me.dgvWhs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvWhs.Name = "dgvWhs"
        Me.dgvWhs.ReadOnly = True
        Me.dgvWhs.RowHeadersVisible = False
        Me.dgvWhs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvWhs.Size = New System.Drawing.Size(456, 267)
        Me.dgvWhs.TabIndex = 17
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
        Me.Column2.HeaderText = "WAREHOUSE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'gBxWarehouse
        '
        Me.gBxWarehouse.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gBxWarehouse.Controls.Add(Me.tsgbxWhs)
        Me.gBxWarehouse.Controls.Add(Me.Label2)
        Me.gBxWarehouse.Controls.Add(Me.Label1)
        Me.gBxWarehouse.Controls.Add(Me.tbWhsName)
        Me.gBxWarehouse.Controls.Add(Me.tbWhsCode)
        Me.gBxWarehouse.Location = New System.Drawing.Point(50, 121)
        Me.gBxWarehouse.Name = "gBxWarehouse"
        Me.gBxWarehouse.Size = New System.Drawing.Size(384, 127)
        Me.gBxWarehouse.TabIndex = 58
        Me.gBxWarehouse.TabStop = False
        Me.gBxWarehouse.Text = "ADD WAREHOUSE"
        Me.gBxWarehouse.Visible = False
        '
        'tsgbxWhs
        '
        Me.tsgbxWhs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsgbxWhs.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsgbxWhs.Dock = System.Windows.Forms.DockStyle.None
        Me.tsgbxWhs.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsgbxWhs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.SaveWhs, Me.ToolStripSeparator7, Me.ClearWhs, Me.ToolStripSeparator9, Me.CloseWhs, Me.ToolStripSeparator10})
        Me.tsgbxWhs.Location = New System.Drawing.Point(216, 94)
        Me.tsgbxWhs.Name = "tsgbxWhs"
        Me.tsgbxWhs.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsgbxWhs.Size = New System.Drawing.Size(140, 25)
        Me.tsgbxWhs.TabIndex = 62
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
        'ClearWhs
        '
        Me.ClearWhs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ClearWhs.Image = CType(resources.GetObject("ClearWhs.Image"), System.Drawing.Image)
        Me.ClearWhs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearWhs.Name = "ClearWhs"
        Me.ClearWhs.Size = New System.Drawing.Size(38, 22)
        Me.ClearWhs.Text = "&Clear"
        Me.ClearWhs.ToolTipText = "S&ave "
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'CloseWhs
        '
        Me.CloseWhs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CloseWhs.Image = CType(resources.GetObject("CloseWhs.Image"), System.Drawing.Image)
        Me.CloseWhs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseWhs.Name = "CloseWhs"
        Me.CloseWhs.Size = New System.Drawing.Size(40, 22)
        Me.CloseWhs.Text = "Cl&ose"
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
        'tbWhsName
        '
        Me.tbWhsName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbWhsName.Location = New System.Drawing.Point(92, 67)
        Me.tbWhsName.MaxLength = 30
        Me.tbWhsName.Name = "tbWhsName"
        Me.tbWhsName.Size = New System.Drawing.Size(263, 22)
        Me.tbWhsName.TabIndex = 59
        '
        'tbWhsCode
        '
        Me.tbWhsCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbWhsCode.Location = New System.Drawing.Point(92, 39)
        Me.tbWhsCode.MaxLength = 5
        Me.tbWhsCode.Name = "tbWhsCode"
        Me.tbWhsCode.Size = New System.Drawing.Size(119, 22)
        Me.tbWhsCode.TabIndex = 58
        '
        'tsWhs
        '
        Me.tsWhs.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsWhs.Dock = System.Windows.Forms.DockStyle.None
        Me.tsWhs.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsWhs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsAddWhs, Me.ToolStripSeparator33, Me.tsEditWhs, Me.ToolStripSeparator34, Me.tsDeleteWhs, Me.ToolStripSeparator35})
        Me.tsWhs.Location = New System.Drawing.Point(106, 313)
        Me.tsWhs.Name = "tsWhs"
        Me.tsWhs.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsWhs.Size = New System.Drawing.Size(291, 25)
        Me.tsWhs.TabIndex = 59
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'tsAddWhs
        '
        Me.tsAddWhs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsAddWhs.Image = CType(resources.GetObject("tsAddWhs.Image"), System.Drawing.Image)
        Me.tsAddWhs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAddWhs.Name = "tsAddWhs"
        Me.tsAddWhs.Size = New System.Drawing.Size(66, 22)
        Me.tsAddWhs.Text = "[F5] - ADD"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'tsEditWhs
        '
        Me.tsEditWhs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsEditWhs.Image = CType(resources.GetObject("tsEditWhs.Image"), System.Drawing.Image)
        Me.tsEditWhs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEditWhs.Name = "tsEditWhs"
        Me.tsEditWhs.Size = New System.Drawing.Size(87, 22)
        Me.tsEditWhs.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'tsDeleteWhs
        '
        Me.tsDeleteWhs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsDeleteWhs.Image = CType(resources.GetObject("tsDeleteWhs.Image"), System.Drawing.Image)
        Me.tsDeleteWhs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDeleteWhs.Name = "tsDeleteWhs"
        Me.tsDeleteWhs.Size = New System.Drawing.Size(80, 22)
        Me.tsDeleteWhs.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'tbSearchWhs
        '
        Me.tbSearchWhs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchWhs.Location = New System.Drawing.Point(12, 12)
        Me.tbSearchWhs.MaxLength = 50
        Me.tbSearchWhs.Name = "tbSearchWhs"
        Me.tbSearchWhs.Size = New System.Drawing.Size(248, 22)
        Me.tbSearchWhs.TabIndex = 60
        '
        'frmWarehouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 347)
        Me.Controls.Add(Me.tbSearchWhs)
        Me.Controls.Add(Me.tsWhs)
        Me.Controls.Add(Me.gBxWarehouse)
        Me.Controls.Add(Me.dgvWhs)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWarehouse"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANAGE WAREHOUSE"
        CType(Me.dgvWhs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gBxWarehouse.ResumeLayout(False)
        Me.gBxWarehouse.PerformLayout()
        Me.tsgbxWhs.ResumeLayout(False)
        Me.tsgbxWhs.PerformLayout()
        Me.tsWhs.ResumeLayout(False)
        Me.tsWhs.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvWhs As System.Windows.Forms.DataGridView
    Friend WithEvents gBxWarehouse As System.Windows.Forms.GroupBox
    Friend WithEvents tsgbxWhs As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveWhs As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearWhs As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseWhs As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbWhsName As System.Windows.Forms.TextBox
    Friend WithEvents tbWhsCode As System.Windows.Forms.TextBox
    Friend WithEvents tsWhs As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsAddWhs As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsEditWhs As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDeleteWhs As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbSearchWhs As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
