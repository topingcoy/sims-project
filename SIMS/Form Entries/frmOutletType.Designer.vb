<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOutletType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOutletType))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbSearchOutlet = New System.Windows.Forms.TextBox()
        Me.gbxOutlet = New System.Windows.Forms.GroupBox()
        Me.tsgbxOutlet = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveOutlet = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearOutlet = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseOutlet = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbCatName = New System.Windows.Forms.TextBox()
        Me.tbCatCode = New System.Windows.Forms.TextBox()
        Me.dgvOutlet = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsOutlet = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAddOutlet = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsEditOutlet = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDeleteOutlet = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.gbxOutlet.SuspendLayout()
        Me.tsgbxOutlet.SuspendLayout()
        CType(Me.dgvOutlet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsOutlet.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbSearchOutlet
        '
        Me.tbSearchOutlet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchOutlet.Location = New System.Drawing.Point(12, 12)
        Me.tbSearchOutlet.MaxLength = 50
        Me.tbSearchOutlet.Name = "tbSearchOutlet"
        Me.tbSearchOutlet.Size = New System.Drawing.Size(248, 22)
        Me.tbSearchOutlet.TabIndex = 67
        '
        'gbxOutlet
        '
        Me.gbxOutlet.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbxOutlet.Controls.Add(Me.tsgbxOutlet)
        Me.gbxOutlet.Controls.Add(Me.Label2)
        Me.gbxOutlet.Controls.Add(Me.Label1)
        Me.gbxOutlet.Controls.Add(Me.tbCatName)
        Me.gbxOutlet.Controls.Add(Me.tbCatCode)
        Me.gbxOutlet.Location = New System.Drawing.Point(49, 113)
        Me.gbxOutlet.Name = "gbxOutlet"
        Me.gbxOutlet.Size = New System.Drawing.Size(384, 127)
        Me.gbxOutlet.TabIndex = 66
        Me.gbxOutlet.TabStop = False
        Me.gbxOutlet.Text = "ADD OUTLET TYPE"
        Me.gbxOutlet.Visible = False
        '
        'tsgbxOutlet
        '
        Me.tsgbxOutlet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsgbxOutlet.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsgbxOutlet.Dock = System.Windows.Forms.DockStyle.None
        Me.tsgbxOutlet.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsgbxOutlet.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.SaveOutlet, Me.ToolStripSeparator7, Me.ClearOutlet, Me.ToolStripSeparator9, Me.CloseOutlet, Me.ToolStripSeparator10})
        Me.tsgbxOutlet.Location = New System.Drawing.Point(216, 94)
        Me.tsgbxOutlet.Name = "tsgbxOutlet"
        Me.tsgbxOutlet.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsgbxOutlet.Size = New System.Drawing.Size(140, 25)
        Me.tsgbxOutlet.TabIndex = 62
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'SaveOutlet
        '
        Me.SaveOutlet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveOutlet.Image = CType(resources.GetObject("SaveOutlet.Image"), System.Drawing.Image)
        Me.SaveOutlet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveOutlet.Name = "SaveOutlet"
        Me.SaveOutlet.Size = New System.Drawing.Size(35, 22)
        Me.SaveOutlet.Text = "&Save"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ClearOutlet
        '
        Me.ClearOutlet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ClearOutlet.Image = CType(resources.GetObject("ClearOutlet.Image"), System.Drawing.Image)
        Me.ClearOutlet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearOutlet.Name = "ClearOutlet"
        Me.ClearOutlet.Size = New System.Drawing.Size(38, 22)
        Me.ClearOutlet.Text = "&Clear"
        Me.ClearOutlet.ToolTipText = "S&ave "
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'CloseOutlet
        '
        Me.CloseOutlet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CloseOutlet.Image = CType(resources.GetObject("CloseOutlet.Image"), System.Drawing.Image)
        Me.CloseOutlet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseOutlet.Name = "CloseOutlet"
        Me.CloseOutlet.Size = New System.Drawing.Size(40, 22)
        Me.CloseOutlet.Text = "Cl&ose"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "OUTLET :"
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
        'tbCatName
        '
        Me.tbCatName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCatName.Location = New System.Drawing.Point(92, 67)
        Me.tbCatName.MaxLength = 30
        Me.tbCatName.Name = "tbCatName"
        Me.tbCatName.Size = New System.Drawing.Size(263, 22)
        Me.tbCatName.TabIndex = 59
        '
        'tbCatCode
        '
        Me.tbCatCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCatCode.Location = New System.Drawing.Point(92, 39)
        Me.tbCatCode.MaxLength = 5
        Me.tbCatCode.Name = "tbCatCode"
        Me.tbCatCode.Size = New System.Drawing.Size(119, 22)
        Me.tbCatCode.TabIndex = 58
        '
        'dgvOutlet
        '
        Me.dgvOutlet.AllowUserToAddRows = False
        Me.dgvOutlet.AllowUserToDeleteRows = False
        Me.dgvOutlet.AllowUserToResizeRows = False
        Me.dgvOutlet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvOutlet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutlet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Column2})
        Me.dgvOutlet.Location = New System.Drawing.Point(12, 39)
        Me.dgvOutlet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvOutlet.Name = "dgvOutlet"
        Me.dgvOutlet.ReadOnly = True
        Me.dgvOutlet.RowHeadersVisible = False
        Me.dgvOutlet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOutlet.Size = New System.Drawing.Size(456, 267)
        Me.dgvOutlet.TabIndex = 65
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
        Me.Column2.HeaderText = "OUTLET TYPE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'tsOutlet
        '
        Me.tsOutlet.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsOutlet.Dock = System.Windows.Forms.DockStyle.None
        Me.tsOutlet.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsOutlet.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsAddOutlet, Me.ToolStripSeparator33, Me.tsEditOutlet, Me.ToolStripSeparator34, Me.tsDeleteOutlet, Me.ToolStripSeparator35})
        Me.tsOutlet.Location = New System.Drawing.Point(106, 313)
        Me.tsOutlet.Name = "tsOutlet"
        Me.tsOutlet.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsOutlet.Size = New System.Drawing.Size(260, 25)
        Me.tsOutlet.TabIndex = 68
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'tsAddOutlet
        '
        Me.tsAddOutlet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsAddOutlet.Image = CType(resources.GetObject("tsAddOutlet.Image"), System.Drawing.Image)
        Me.tsAddOutlet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAddOutlet.Name = "tsAddOutlet"
        Me.tsAddOutlet.Size = New System.Drawing.Size(66, 22)
        Me.tsAddOutlet.Text = "[F5] - ADD"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'tsEditOutlet
        '
        Me.tsEditOutlet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsEditOutlet.Image = CType(resources.GetObject("tsEditOutlet.Image"), System.Drawing.Image)
        Me.tsEditOutlet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEditOutlet.Name = "tsEditOutlet"
        Me.tsEditOutlet.Size = New System.Drawing.Size(87, 22)
        Me.tsEditOutlet.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'tsDeleteOutlet
        '
        Me.tsDeleteOutlet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsDeleteOutlet.Image = CType(resources.GetObject("tsDeleteOutlet.Image"), System.Drawing.Image)
        Me.tsDeleteOutlet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDeleteOutlet.Name = "tsDeleteOutlet"
        Me.tsDeleteOutlet.Size = New System.Drawing.Size(80, 22)
        Me.tsDeleteOutlet.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'frmOutletType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 351)
        Me.Controls.Add(Me.tsOutlet)
        Me.Controls.Add(Me.tbSearchOutlet)
        Me.Controls.Add(Me.gbxOutlet)
        Me.Controls.Add(Me.dgvOutlet)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOutletType"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANAGE OUTLET TYPE"
        Me.gbxOutlet.ResumeLayout(False)
        Me.gbxOutlet.PerformLayout()
        Me.tsgbxOutlet.ResumeLayout(False)
        Me.tsgbxOutlet.PerformLayout()
        CType(Me.dgvOutlet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsOutlet.ResumeLayout(False)
        Me.tsOutlet.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbSearchOutlet As System.Windows.Forms.TextBox
    Friend WithEvents gbxOutlet As System.Windows.Forms.GroupBox
    Friend WithEvents tsgbxOutlet As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveOutlet As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearOutlet As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseOutlet As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbCatName As System.Windows.Forms.TextBox
    Friend WithEvents tbCatCode As System.Windows.Forms.TextBox
    Friend WithEvents dgvOutlet As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsOutlet As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsAddOutlet As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsEditOutlet As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDeleteOutlet As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
End Class
