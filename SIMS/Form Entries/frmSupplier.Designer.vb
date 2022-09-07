<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupplier))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbxSupplier = New System.Windows.Forms.GroupBox()
        Me.tsgbxSup = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveSup = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearSup = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseSup = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSupName = New System.Windows.Forms.TextBox()
        Me.tbSupCode = New System.Windows.Forms.TextBox()
        Me.dgvSupplier = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsSupplier = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAddSup = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsEditSup = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDeleteSup = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbSearchSup = New System.Windows.Forms.TextBox()
        Me.gbxSupplier.SuspendLayout()
        Me.tsgbxSup.SuspendLayout()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsSupplier.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxSupplier
        '
        Me.gbxSupplier.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbxSupplier.Controls.Add(Me.tsgbxSup)
        Me.gbxSupplier.Controls.Add(Me.Label2)
        Me.gbxSupplier.Controls.Add(Me.Label1)
        Me.gbxSupplier.Controls.Add(Me.tbSupName)
        Me.gbxSupplier.Controls.Add(Me.tbSupCode)
        Me.gbxSupplier.Location = New System.Drawing.Point(52, 126)
        Me.gbxSupplier.Name = "gbxSupplier"
        Me.gbxSupplier.Size = New System.Drawing.Size(384, 127)
        Me.gbxSupplier.TabIndex = 60
        Me.gbxSupplier.TabStop = False
        Me.gbxSupplier.Text = "ADD SUPPLIER"
        Me.gbxSupplier.Visible = False
        '
        'tsgbxSup
        '
        Me.tsgbxSup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsgbxSup.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsgbxSup.Dock = System.Windows.Forms.DockStyle.None
        Me.tsgbxSup.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsgbxSup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.SaveSup, Me.ToolStripSeparator7, Me.ClearSup, Me.ToolStripSeparator9, Me.CloseSup, Me.ToolStripSeparator10})
        Me.tsgbxSup.Location = New System.Drawing.Point(216, 94)
        Me.tsgbxSup.Name = "tsgbxSup"
        Me.tsgbxSup.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsgbxSup.Size = New System.Drawing.Size(140, 25)
        Me.tsgbxSup.TabIndex = 62
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'SaveSup
        '
        Me.SaveSup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveSup.Image = CType(resources.GetObject("SaveSup.Image"), System.Drawing.Image)
        Me.SaveSup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveSup.Name = "SaveSup"
        Me.SaveSup.Size = New System.Drawing.Size(35, 22)
        Me.SaveSup.Text = "&Save"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ClearSup
        '
        Me.ClearSup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ClearSup.Image = CType(resources.GetObject("ClearSup.Image"), System.Drawing.Image)
        Me.ClearSup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearSup.Name = "ClearSup"
        Me.ClearSup.Size = New System.Drawing.Size(38, 22)
        Me.ClearSup.Text = "&Clear"
        Me.ClearSup.ToolTipText = "S&ave "
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'CloseSup
        '
        Me.CloseSup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CloseSup.Image = CType(resources.GetObject("CloseSup.Image"), System.Drawing.Image)
        Me.CloseSup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseSup.Name = "CloseSup"
        Me.CloseSup.Size = New System.Drawing.Size(40, 22)
        Me.CloseSup.Text = "Cl&ose"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "SUPPLIER :"
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
        'tbSupName
        '
        Me.tbSupName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSupName.Location = New System.Drawing.Point(92, 67)
        Me.tbSupName.MaxLength = 30
        Me.tbSupName.Name = "tbSupName"
        Me.tbSupName.Size = New System.Drawing.Size(263, 22)
        Me.tbSupName.TabIndex = 59
        '
        'tbSupCode
        '
        Me.tbSupCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSupCode.Location = New System.Drawing.Point(92, 39)
        Me.tbSupCode.MaxLength = 5
        Me.tbSupCode.Name = "tbSupCode"
        Me.tbSupCode.Size = New System.Drawing.Size(119, 22)
        Me.tbSupCode.TabIndex = 58
        '
        'dgvSupplier
        '
        Me.dgvSupplier.AllowUserToAddRows = False
        Me.dgvSupplier.AllowUserToDeleteRows = False
        Me.dgvSupplier.AllowUserToResizeRows = False
        Me.dgvSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSupplier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Column2})
        Me.dgvSupplier.Location = New System.Drawing.Point(12, 39)
        Me.dgvSupplier.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvSupplier.Name = "dgvSupplier"
        Me.dgvSupplier.ReadOnly = True
        Me.dgvSupplier.RowHeadersVisible = False
        Me.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSupplier.Size = New System.Drawing.Size(456, 267)
        Me.dgvSupplier.TabIndex = 59
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
        Me.Column2.HeaderText = "SUPPLIER"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'tsSupplier
        '
        Me.tsSupplier.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsSupplier.Dock = System.Windows.Forms.DockStyle.None
        Me.tsSupplier.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsSupplier.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsAddSup, Me.ToolStripSeparator33, Me.tsEditSup, Me.ToolStripSeparator34, Me.tsDeleteSup, Me.ToolStripSeparator35})
        Me.tsSupplier.Location = New System.Drawing.Point(106, 313)
        Me.tsSupplier.Name = "tsSupplier"
        Me.tsSupplier.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsSupplier.Size = New System.Drawing.Size(260, 25)
        Me.tsSupplier.TabIndex = 61
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'tsAddSup
        '
        Me.tsAddSup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsAddSup.Image = CType(resources.GetObject("tsAddSup.Image"), System.Drawing.Image)
        Me.tsAddSup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAddSup.Name = "tsAddSup"
        Me.tsAddSup.Size = New System.Drawing.Size(66, 22)
        Me.tsAddSup.Text = "[F5] - ADD"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'tsEditSup
        '
        Me.tsEditSup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsEditSup.Image = CType(resources.GetObject("tsEditSup.Image"), System.Drawing.Image)
        Me.tsEditSup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEditSup.Name = "tsEditSup"
        Me.tsEditSup.Size = New System.Drawing.Size(87, 22)
        Me.tsEditSup.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'tsDeleteSup
        '
        Me.tsDeleteSup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsDeleteSup.Image = CType(resources.GetObject("tsDeleteSup.Image"), System.Drawing.Image)
        Me.tsDeleteSup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDeleteSup.Name = "tsDeleteSup"
        Me.tsDeleteSup.Size = New System.Drawing.Size(80, 22)
        Me.tsDeleteSup.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'tbSearchSup
        '
        Me.tbSearchSup.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchSup.Location = New System.Drawing.Point(12, 12)
        Me.tbSearchSup.MaxLength = 50
        Me.tbSearchSup.Name = "tbSearchSup"
        Me.tbSearchSup.Size = New System.Drawing.Size(248, 22)
        Me.tbSearchSup.TabIndex = 62
        '
        'frmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 347)
        Me.Controls.Add(Me.tbSearchSup)
        Me.Controls.Add(Me.tsSupplier)
        Me.Controls.Add(Me.gbxSupplier)
        Me.Controls.Add(Me.dgvSupplier)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSupplier"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANAGE SUPPLIER"
        Me.gbxSupplier.ResumeLayout(False)
        Me.gbxSupplier.PerformLayout()
        Me.tsgbxSup.ResumeLayout(False)
        Me.tsgbxSup.PerformLayout()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsSupplier.ResumeLayout(False)
        Me.tsSupplier.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxSupplier As System.Windows.Forms.GroupBox
    Friend WithEvents tsgbxSup As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveSup As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearSup As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseSup As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbSupName As System.Windows.Forms.TextBox
    Friend WithEvents tbSupCode As System.Windows.Forms.TextBox
    Friend WithEvents dgvSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents tsSupplier As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsAddSup As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsEditSup As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDeleteSup As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbSearchSup As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
