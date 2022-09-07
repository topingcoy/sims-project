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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAreaTerritory))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbAreaName = New System.Windows.Forms.TextBox()
        Me.tbAreaCode = New System.Windows.Forms.TextBox()
        Me.gbxCategory = New System.Windows.Forms.GroupBox()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDeleteArea = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsEditArea = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAddArea = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAreaTerritory = New System.Windows.Forms.ToolStrip()
        Me.tbSearchAreaTerritory = New System.Windows.Forms.TextBox()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAreaTerritory = New System.Windows.Forms.DataGridView()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveArea = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearArea = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseArea = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsgbxArea = New System.Windows.Forms.ToolStrip()
        Me.gbxCategory.SuspendLayout()
        Me.tsAreaTerritory.SuspendLayout()
        CType(Me.dgvAreaTerritory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsgbxArea.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "CATEGORY  :"
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
        'tbAreaName
        '
        Me.tbAreaName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbAreaName.Location = New System.Drawing.Point(92, 67)
        Me.tbAreaName.MaxLength = 30
        Me.tbAreaName.Name = "tbAreaName"
        Me.tbAreaName.Size = New System.Drawing.Size(263, 22)
        Me.tbAreaName.TabIndex = 59
        '
        'tbAreaCode
        '
        Me.tbAreaCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbAreaCode.Location = New System.Drawing.Point(92, 39)
        Me.tbAreaCode.MaxLength = 5
        Me.tbAreaCode.Name = "tbAreaCode"
        Me.tbAreaCode.Size = New System.Drawing.Size(119, 22)
        Me.tbAreaCode.TabIndex = 58
        '
        'gbxCategory
        '
        Me.gbxCategory.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbxCategory.Controls.Add(Me.tsgbxArea)
        Me.gbxCategory.Controls.Add(Me.Label2)
        Me.gbxCategory.Controls.Add(Me.Label1)
        Me.gbxCategory.Controls.Add(Me.tbAreaName)
        Me.gbxCategory.Controls.Add(Me.tbAreaCode)
        Me.gbxCategory.Location = New System.Drawing.Point(46, 123)
        Me.gbxCategory.Name = "gbxCategory"
        Me.gbxCategory.Size = New System.Drawing.Size(384, 127)
        Me.gbxCategory.TabIndex = 66
        Me.gbxCategory.TabStop = False
        Me.gbxCategory.Text = "ADD AREA/TERRITORY"
        Me.gbxCategory.Visible = False
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'tsDeleteArea
        '
        Me.tsDeleteArea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsDeleteArea.Image = CType(resources.GetObject("tsDeleteArea.Image"), System.Drawing.Image)
        Me.tsDeleteArea.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDeleteArea.Name = "tsDeleteArea"
        Me.tsDeleteArea.Size = New System.Drawing.Size(80, 22)
        Me.tsDeleteArea.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'tsEditArea
        '
        Me.tsEditArea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsEditArea.Image = CType(resources.GetObject("tsEditArea.Image"), System.Drawing.Image)
        Me.tsEditArea.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEditArea.Name = "tsEditArea"
        Me.tsEditArea.Size = New System.Drawing.Size(87, 22)
        Me.tsEditArea.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'tsAddArea
        '
        Me.tsAddArea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsAddArea.Image = CType(resources.GetObject("tsAddArea.Image"), System.Drawing.Image)
        Me.tsAddArea.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAddArea.Name = "tsAddArea"
        Me.tsAddArea.Size = New System.Drawing.Size(66, 22)
        Me.tsAddArea.Text = "[F5] - ADD"
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'tsAreaTerritory
        '
        Me.tsAreaTerritory.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsAreaTerritory.Dock = System.Windows.Forms.DockStyle.None
        Me.tsAreaTerritory.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsAreaTerritory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsAddArea, Me.ToolStripSeparator33, Me.tsEditArea, Me.ToolStripSeparator34, Me.tsDeleteArea, Me.ToolStripSeparator35})
        Me.tsAreaTerritory.Location = New System.Drawing.Point(108, 313)
        Me.tsAreaTerritory.Name = "tsAreaTerritory"
        Me.tsAreaTerritory.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsAreaTerritory.Size = New System.Drawing.Size(291, 25)
        Me.tsAreaTerritory.TabIndex = 67
        '
        'tbSearchAreaTerritory
        '
        Me.tbSearchAreaTerritory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchAreaTerritory.Location = New System.Drawing.Point(14, 12)
        Me.tbSearchAreaTerritory.MaxLength = 50
        Me.tbSearchAreaTerritory.Name = "tbSearchAreaTerritory"
        Me.tbSearchAreaTerritory.Size = New System.Drawing.Size(248, 22)
        Me.tbSearchAreaTerritory.TabIndex = 68
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column2.HeaderText = "AREA/TERRITORY"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "CODE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 62
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 39
        '
        'dgvAreaTerritory
        '
        Me.dgvAreaTerritory.AllowUserToAddRows = False
        Me.dgvAreaTerritory.AllowUserToDeleteRows = False
        Me.dgvAreaTerritory.AllowUserToResizeRows = False
        Me.dgvAreaTerritory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAreaTerritory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAreaTerritory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Column2})
        Me.dgvAreaTerritory.Location = New System.Drawing.Point(14, 39)
        Me.dgvAreaTerritory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvAreaTerritory.Name = "dgvAreaTerritory"
        Me.dgvAreaTerritory.ReadOnly = True
        Me.dgvAreaTerritory.RowHeadersVisible = False
        Me.dgvAreaTerritory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAreaTerritory.Size = New System.Drawing.Size(456, 267)
        Me.dgvAreaTerritory.TabIndex = 65
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'SaveArea
        '
        Me.SaveArea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveArea.Image = CType(resources.GetObject("SaveArea.Image"), System.Drawing.Image)
        Me.SaveArea.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveArea.Name = "SaveArea"
        Me.SaveArea.Size = New System.Drawing.Size(35, 22)
        Me.SaveArea.Text = "&Save"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ClearArea
        '
        Me.ClearArea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ClearArea.Image = CType(resources.GetObject("ClearArea.Image"), System.Drawing.Image)
        Me.ClearArea.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearArea.Name = "ClearArea"
        Me.ClearArea.Size = New System.Drawing.Size(38, 22)
        Me.ClearArea.Text = "&Clear"
        Me.ClearArea.ToolTipText = "S&ave "
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'CloseArea
        '
        Me.CloseArea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CloseArea.Image = CType(resources.GetObject("CloseArea.Image"), System.Drawing.Image)
        Me.CloseArea.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseArea.Name = "CloseArea"
        Me.CloseArea.Size = New System.Drawing.Size(40, 22)
        Me.CloseArea.Text = "Cl&ose"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'tsgbxArea
        '
        Me.tsgbxArea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsgbxArea.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsgbxArea.Dock = System.Windows.Forms.DockStyle.None
        Me.tsgbxArea.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsgbxArea.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.SaveArea, Me.ToolStripSeparator7, Me.ClearArea, Me.ToolStripSeparator9, Me.CloseArea, Me.ToolStripSeparator10})
        Me.tsgbxArea.Location = New System.Drawing.Point(215, 92)
        Me.tsgbxArea.Name = "tsgbxArea"
        Me.tsgbxArea.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsgbxArea.Size = New System.Drawing.Size(140, 25)
        Me.tsgbxArea.TabIndex = 62
        '
        'frmAreaTerritory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 347)
        Me.Controls.Add(Me.gbxCategory)
        Me.Controls.Add(Me.dgvAreaTerritory)
        Me.Controls.Add(Me.tsAreaTerritory)
        Me.Controls.Add(Me.tbSearchAreaTerritory)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAreaTerritory"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANAGE AREA/TERRITORY"
        Me.gbxCategory.ResumeLayout(False)
        Me.gbxCategory.PerformLayout()
        Me.tsAreaTerritory.ResumeLayout(False)
        Me.tsAreaTerritory.PerformLayout()
        CType(Me.dgvAreaTerritory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsgbxArea.ResumeLayout(False)
        Me.tsgbxArea.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbAreaName As System.Windows.Forms.TextBox
    Friend WithEvents tbAreaCode As System.Windows.Forms.TextBox
    Friend WithEvents gbxCategory As System.Windows.Forms.GroupBox
    Friend WithEvents tsgbxArea As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveArea As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearArea As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseArea As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDeleteArea As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsEditArea As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsAddArea As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsAreaTerritory As System.Windows.Forms.ToolStrip
    Friend WithEvents tbSearchAreaTerritory As System.Windows.Forms.TextBox
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvAreaTerritory As System.Windows.Forms.DataGridView
End Class
