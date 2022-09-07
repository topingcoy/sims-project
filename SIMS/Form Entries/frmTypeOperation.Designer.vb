<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTypeOperation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTypeOperation))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbSearchTypeOper = New System.Windows.Forms.TextBox()
        Me.tsDeleteTypeOper = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsEditTypeOper = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAddTypeOper = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsTypeOperation = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbTypeOperName = New System.Windows.Forms.TextBox()
        Me.tbTypeOperCode = New System.Windows.Forms.TextBox()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseTypeOper = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearTypeOper = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveTypeOper = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsgbxTypeOper = New System.Windows.Forms.ToolStrip()
        Me.dgvTypeOper = New System.Windows.Forms.DataGridView()
        Me.gbxTypeOper = New System.Windows.Forms.GroupBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsTypeOperation.SuspendLayout()
        Me.tsgbxTypeOper.SuspendLayout()
        CType(Me.dgvTypeOper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxTypeOper.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbSearchTypeOper
        '
        Me.tbSearchTypeOper.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchTypeOper.Location = New System.Drawing.Point(14, 12)
        Me.tbSearchTypeOper.MaxLength = 50
        Me.tbSearchTypeOper.Name = "tbSearchTypeOper"
        Me.tbSearchTypeOper.Size = New System.Drawing.Size(248, 22)
        Me.tbSearchTypeOper.TabIndex = 64
        '
        'tsDeleteTypeOper
        '
        Me.tsDeleteTypeOper.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsDeleteTypeOper.Image = CType(resources.GetObject("tsDeleteTypeOper.Image"), System.Drawing.Image)
        Me.tsDeleteTypeOper.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDeleteTypeOper.Name = "tsDeleteTypeOper"
        Me.tsDeleteTypeOper.Size = New System.Drawing.Size(80, 22)
        Me.tsDeleteTypeOper.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'tsEditTypeOper
        '
        Me.tsEditTypeOper.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsEditTypeOper.Image = CType(resources.GetObject("tsEditTypeOper.Image"), System.Drawing.Image)
        Me.tsEditTypeOper.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEditTypeOper.Name = "tsEditTypeOper"
        Me.tsEditTypeOper.Size = New System.Drawing.Size(87, 22)
        Me.tsEditTypeOper.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'tsAddTypeOper
        '
        Me.tsAddTypeOper.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsAddTypeOper.Image = CType(resources.GetObject("tsAddTypeOper.Image"), System.Drawing.Image)
        Me.tsAddTypeOper.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAddTypeOper.Name = "tsAddTypeOper"
        Me.tsAddTypeOper.Size = New System.Drawing.Size(66, 22)
        Me.tsAddTypeOper.Text = "[F5] - ADD"
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'tsTypeOperation
        '
        Me.tsTypeOperation.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsTypeOperation.Dock = System.Windows.Forms.DockStyle.None
        Me.tsTypeOperation.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsTypeOperation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsAddTypeOper, Me.ToolStripSeparator33, Me.tsEditTypeOper, Me.ToolStripSeparator34, Me.tsDeleteTypeOper, Me.ToolStripSeparator35})
        Me.tsTypeOperation.Location = New System.Drawing.Point(108, 313)
        Me.tsTypeOperation.Name = "tsTypeOperation"
        Me.tsTypeOperation.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsTypeOperation.Size = New System.Drawing.Size(291, 25)
        Me.tsTypeOperation.TabIndex = 63
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
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
        'tbTypeOperName
        '
        Me.tbTypeOperName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTypeOperName.Location = New System.Drawing.Point(92, 67)
        Me.tbTypeOperName.MaxLength = 30
        Me.tbTypeOperName.Name = "tbTypeOperName"
        Me.tbTypeOperName.Size = New System.Drawing.Size(263, 22)
        Me.tbTypeOperName.TabIndex = 59
        '
        'tbTypeOperCode
        '
        Me.tbTypeOperCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTypeOperCode.Location = New System.Drawing.Point(92, 39)
        Me.tbTypeOperCode.MaxLength = 5
        Me.tbTypeOperCode.Name = "tbTypeOperCode"
        Me.tbTypeOperCode.Size = New System.Drawing.Size(119, 22)
        Me.tbTypeOperCode.TabIndex = 58
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'CloseTypeOper
        '
        Me.CloseTypeOper.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CloseTypeOper.Image = CType(resources.GetObject("CloseTypeOper.Image"), System.Drawing.Image)
        Me.CloseTypeOper.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseTypeOper.Name = "CloseTypeOper"
        Me.CloseTypeOper.Size = New System.Drawing.Size(40, 22)
        Me.CloseTypeOper.Text = "Cl&ose"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ClearTypeOper
        '
        Me.ClearTypeOper.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ClearTypeOper.Image = CType(resources.GetObject("ClearTypeOper.Image"), System.Drawing.Image)
        Me.ClearTypeOper.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearTypeOper.Name = "ClearTypeOper"
        Me.ClearTypeOper.Size = New System.Drawing.Size(38, 22)
        Me.ClearTypeOper.Text = "&Clear"
        Me.ClearTypeOper.ToolTipText = "S&ave "
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'SaveTypeOper
        '
        Me.SaveTypeOper.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveTypeOper.Image = CType(resources.GetObject("SaveTypeOper.Image"), System.Drawing.Image)
        Me.SaveTypeOper.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveTypeOper.Name = "SaveTypeOper"
        Me.SaveTypeOper.Size = New System.Drawing.Size(35, 22)
        Me.SaveTypeOper.Text = "&Save"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tsgbxTypeOper
        '
        Me.tsgbxTypeOper.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsgbxTypeOper.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsgbxTypeOper.Dock = System.Windows.Forms.DockStyle.None
        Me.tsgbxTypeOper.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsgbxTypeOper.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.SaveTypeOper, Me.ToolStripSeparator7, Me.ClearTypeOper, Me.ToolStripSeparator9, Me.CloseTypeOper, Me.ToolStripSeparator10})
        Me.tsgbxTypeOper.Location = New System.Drawing.Point(216, 94)
        Me.tsgbxTypeOper.Name = "tsgbxTypeOper"
        Me.tsgbxTypeOper.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsgbxTypeOper.Size = New System.Drawing.Size(140, 25)
        Me.tsgbxTypeOper.TabIndex = 62
        '
        'dgvTypeOper
        '
        Me.dgvTypeOper.AllowUserToAddRows = False
        Me.dgvTypeOper.AllowUserToDeleteRows = False
        Me.dgvTypeOper.AllowUserToResizeRows = False
        Me.dgvTypeOper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTypeOper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTypeOper.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Column2})
        Me.dgvTypeOper.Location = New System.Drawing.Point(14, 39)
        Me.dgvTypeOper.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvTypeOper.Name = "dgvTypeOper"
        Me.dgvTypeOper.ReadOnly = True
        Me.dgvTypeOper.RowHeadersVisible = False
        Me.dgvTypeOper.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTypeOper.Size = New System.Drawing.Size(456, 267)
        Me.dgvTypeOper.TabIndex = 61
        '
        'gbxTypeOper
        '
        Me.gbxTypeOper.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbxTypeOper.Controls.Add(Me.tsgbxTypeOper)
        Me.gbxTypeOper.Controls.Add(Me.Label2)
        Me.gbxTypeOper.Controls.Add(Me.Label1)
        Me.gbxTypeOper.Controls.Add(Me.tbTypeOperName)
        Me.gbxTypeOper.Controls.Add(Me.tbTypeOperCode)
        Me.gbxTypeOper.Location = New System.Drawing.Point(52, 121)
        Me.gbxTypeOper.Name = "gbxTypeOper"
        Me.gbxTypeOper.Size = New System.Drawing.Size(384, 127)
        Me.gbxTypeOper.TabIndex = 62
        Me.gbxTypeOper.TabStop = False
        Me.gbxTypeOper.Text = "ADD WAREHOUSE"
        Me.gbxTypeOper.Visible = False
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
        Me.Column2.HeaderText = "TYPE OF OPERATION"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'frmTypeOperation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 351)
        Me.Controls.Add(Me.tbSearchTypeOper)
        Me.Controls.Add(Me.tsTypeOperation)
        Me.Controls.Add(Me.gbxTypeOper)
        Me.Controls.Add(Me.dgvTypeOper)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTypeOperation"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANAGE TYPE OF OPERATION"
        Me.tsTypeOperation.ResumeLayout(False)
        Me.tsTypeOperation.PerformLayout()
        Me.tsgbxTypeOper.ResumeLayout(False)
        Me.tsgbxTypeOper.PerformLayout()
        CType(Me.dgvTypeOper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxTypeOper.ResumeLayout(False)
        Me.gbxTypeOper.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbSearchTypeOper As System.Windows.Forms.TextBox
    Friend WithEvents tsDeleteTypeOper As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsEditTypeOper As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsAddTypeOper As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsTypeOperation As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbTypeOperName As System.Windows.Forms.TextBox
    Friend WithEvents tbTypeOperCode As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseTypeOper As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearTypeOper As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveTypeOper As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsgbxTypeOper As System.Windows.Forms.ToolStrip
    Friend WithEvents dgvTypeOper As System.Windows.Forms.DataGridView
    Friend WithEvents gbxTypeOper As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
