<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategory))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbSearchCat = New System.Windows.Forms.TextBox()
        Me.tsCatetory = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAddCat = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsEditCat = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDeleteCat = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.gbxCategory = New System.Windows.Forms.GroupBox()
        Me.tsgbxCat = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveCat = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearCat = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseCat = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbCatName = New System.Windows.Forms.TextBox()
        Me.tbCatCode = New System.Windows.Forms.TextBox()
        Me.dgvCategory = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsCatetory.SuspendLayout()
        Me.gbxCategory.SuspendLayout()
        Me.tsgbxCat.SuspendLayout()
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbSearchCat
        '
        Me.tbSearchCat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchCat.Location = New System.Drawing.Point(12, 12)
        Me.tbSearchCat.MaxLength = 50
        Me.tbSearchCat.Name = "tbSearchCat"
        Me.tbSearchCat.Size = New System.Drawing.Size(248, 22)
        Me.tbSearchCat.TabIndex = 64
        '
        'tsCatetory
        '
        Me.tsCatetory.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsCatetory.Dock = System.Windows.Forms.DockStyle.None
        Me.tsCatetory.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsCatetory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsAddCat, Me.ToolStripSeparator33, Me.tsEditCat, Me.ToolStripSeparator34, Me.tsDeleteCat, Me.ToolStripSeparator35})
        Me.tsCatetory.Location = New System.Drawing.Point(106, 313)
        Me.tsCatetory.Name = "tsCatetory"
        Me.tsCatetory.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsCatetory.Size = New System.Drawing.Size(260, 25)
        Me.tsCatetory.TabIndex = 63
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'tsAddCat
        '
        Me.tsAddCat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsAddCat.Image = CType(resources.GetObject("tsAddCat.Image"), System.Drawing.Image)
        Me.tsAddCat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAddCat.Name = "tsAddCat"
        Me.tsAddCat.Size = New System.Drawing.Size(66, 22)
        Me.tsAddCat.Text = "[F5] - ADD"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'tsEditCat
        '
        Me.tsEditCat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsEditCat.Image = CType(resources.GetObject("tsEditCat.Image"), System.Drawing.Image)
        Me.tsEditCat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEditCat.Name = "tsEditCat"
        Me.tsEditCat.Size = New System.Drawing.Size(87, 22)
        Me.tsEditCat.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'tsDeleteCat
        '
        Me.tsDeleteCat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsDeleteCat.Image = CType(resources.GetObject("tsDeleteCat.Image"), System.Drawing.Image)
        Me.tsDeleteCat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDeleteCat.Name = "tsDeleteCat"
        Me.tsDeleteCat.Size = New System.Drawing.Size(80, 22)
        Me.tsDeleteCat.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'gbxCategory
        '
        Me.gbxCategory.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbxCategory.Controls.Add(Me.tsgbxCat)
        Me.gbxCategory.Controls.Add(Me.Label2)
        Me.gbxCategory.Controls.Add(Me.Label1)
        Me.gbxCategory.Controls.Add(Me.tbCatName)
        Me.gbxCategory.Controls.Add(Me.tbCatCode)
        Me.gbxCategory.Location = New System.Drawing.Point(50, 121)
        Me.gbxCategory.Name = "gbxCategory"
        Me.gbxCategory.Size = New System.Drawing.Size(384, 127)
        Me.gbxCategory.TabIndex = 62
        Me.gbxCategory.TabStop = False
        Me.gbxCategory.Text = "ADD CATEGORY"
        Me.gbxCategory.Visible = False
        '
        'tsgbxCat
        '
        Me.tsgbxCat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsgbxCat.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsgbxCat.Dock = System.Windows.Forms.DockStyle.None
        Me.tsgbxCat.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsgbxCat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.SaveCat, Me.ToolStripSeparator7, Me.ClearCat, Me.ToolStripSeparator9, Me.CloseCat, Me.ToolStripSeparator10})
        Me.tsgbxCat.Location = New System.Drawing.Point(216, 94)
        Me.tsgbxCat.Name = "tsgbxCat"
        Me.tsgbxCat.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsgbxCat.Size = New System.Drawing.Size(140, 25)
        Me.tsgbxCat.TabIndex = 62
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'SaveCat
        '
        Me.SaveCat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveCat.Image = CType(resources.GetObject("SaveCat.Image"), System.Drawing.Image)
        Me.SaveCat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveCat.Name = "SaveCat"
        Me.SaveCat.Size = New System.Drawing.Size(35, 22)
        Me.SaveCat.Text = "&Save"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ClearCat
        '
        Me.ClearCat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ClearCat.Image = CType(resources.GetObject("ClearCat.Image"), System.Drawing.Image)
        Me.ClearCat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearCat.Name = "ClearCat"
        Me.ClearCat.Size = New System.Drawing.Size(38, 22)
        Me.ClearCat.Text = "&Clear"
        Me.ClearCat.ToolTipText = "S&ave "
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'CloseCat
        '
        Me.CloseCat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CloseCat.Image = CType(resources.GetObject("CloseCat.Image"), System.Drawing.Image)
        Me.CloseCat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseCat.Name = "CloseCat"
        Me.CloseCat.Size = New System.Drawing.Size(40, 22)
        Me.CloseCat.Text = "Cl&ose"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
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
        'dgvCategory
        '
        Me.dgvCategory.AllowUserToAddRows = False
        Me.dgvCategory.AllowUserToDeleteRows = False
        Me.dgvCategory.AllowUserToResizeRows = False
        Me.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Column2})
        Me.dgvCategory.Location = New System.Drawing.Point(12, 39)
        Me.dgvCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvCategory.Name = "dgvCategory"
        Me.dgvCategory.ReadOnly = True
        Me.dgvCategory.RowHeadersVisible = False
        Me.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCategory.Size = New System.Drawing.Size(456, 267)
        Me.dgvCategory.TabIndex = 61
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
        Me.Column2.HeaderText = "CATEGORY"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'frmCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 347)
        Me.Controls.Add(Me.tbSearchCat)
        Me.Controls.Add(Me.tsCatetory)
        Me.Controls.Add(Me.gbxCategory)
        Me.Controls.Add(Me.dgvCategory)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCategory"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANAGE CATEGORY"
        Me.tsCatetory.ResumeLayout(False)
        Me.tsCatetory.PerformLayout()
        Me.gbxCategory.ResumeLayout(False)
        Me.gbxCategory.PerformLayout()
        Me.tsgbxCat.ResumeLayout(False)
        Me.tsgbxCat.PerformLayout()
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbSearchCat As System.Windows.Forms.TextBox
    Friend WithEvents tsCatetory As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsAddCat As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsEditCat As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDeleteCat As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents gbxCategory As System.Windows.Forms.GroupBox
    Friend WithEvents tsgbxCat As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveCat As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearCat As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseCat As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbCatName As System.Windows.Forms.TextBox
    Friend WithEvents tbCatCode As System.Windows.Forms.TextBox
    Friend WithEvents dgvCategory As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
