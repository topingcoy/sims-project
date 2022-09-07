<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGStoBOH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGStoBOH))
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteStockIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditStockIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddStockIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsGStoBO = New System.Windows.Forms.ToolStrip()
        Me.dtpGStoBO2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpGStoBO1 = New System.Windows.Forms.DateTimePicker()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.goGStoBO = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsStockIGo = New System.Windows.Forms.ToolStrip()
        Me.tbSearchGoodstockBO = New System.Windows.Forms.TextBox()
        Me.dgvGStoBOList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsGStoBO.SuspendLayout()
        Me.tsStockIGo.SuspendLayout()
        CType(Me.dgvGStoBOList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'DeleteStockIn
        '
        Me.DeleteStockIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DeleteStockIn.Image = CType(resources.GetObject("DeleteStockIn.Image"), System.Drawing.Image)
        Me.DeleteStockIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteStockIn.Name = "DeleteStockIn"
        Me.DeleteStockIn.Size = New System.Drawing.Size(80, 22)
        Me.DeleteStockIn.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'EditStockIn
        '
        Me.EditStockIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditStockIn.Image = CType(resources.GetObject("EditStockIn.Image"), System.Drawing.Image)
        Me.EditStockIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditStockIn.Name = "EditStockIn"
        Me.EditStockIn.Size = New System.Drawing.Size(87, 22)
        Me.EditStockIn.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'AddStockIn
        '
        Me.AddStockIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AddStockIn.Image = CType(resources.GetObject("AddStockIn.Image"), System.Drawing.Image)
        Me.AddStockIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddStockIn.Name = "AddStockIn"
        Me.AddStockIn.Size = New System.Drawing.Size(66, 22)
        Me.AddStockIn.Text = "[F5] - ADD"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tsGStoBO
        '
        Me.tsGStoBO.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsGStoBO.Dock = System.Windows.Forms.DockStyle.None
        Me.tsGStoBO.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsGStoBO.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.AddStockIn, Me.ToolStripSeparator8, Me.EditStockIn, Me.ToolStripSeparator9, Me.DeleteStockIn, Me.ToolStripSeparator10})
        Me.tsGStoBO.Location = New System.Drawing.Point(149, 364)
        Me.tsGStoBO.Name = "tsGStoBO"
        Me.tsGStoBO.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsGStoBO.Size = New System.Drawing.Size(260, 25)
        Me.tsGStoBO.TabIndex = 79
        Me.tsGStoBO.Text = "ToolStrip1"
        '
        'dtpGStoBO2
        '
        Me.dtpGStoBO2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpGStoBO2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpGStoBO2.Location = New System.Drawing.Point(410, 9)
        Me.dtpGStoBO2.Name = "dtpGStoBO2"
        Me.dtpGStoBO2.Size = New System.Drawing.Size(93, 22)
        Me.dtpGStoBO2.TabIndex = 76
        '
        'dtpGStoBO1
        '
        Me.dtpGStoBO1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpGStoBO1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpGStoBO1.Location = New System.Drawing.Point(282, 9)
        Me.dtpGStoBO1.Name = "dtpGStoBO1"
        Me.dtpGStoBO1.Size = New System.Drawing.Size(93, 22)
        Me.dtpGStoBO1.TabIndex = 75
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'goGStoBO
        '
        Me.goGStoBO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.goGStoBO.Image = CType(resources.GetObject("goGStoBO.Image"), System.Drawing.Image)
        Me.goGStoBO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.goGStoBO.Name = "goGStoBO"
        Me.goGStoBO.Size = New System.Drawing.Size(28, 22)
        Me.goGStoBO.Text = "GO"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Location = New System.Drawing.Point(384, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "To"
        '
        'tsStockIGo
        '
        Me.tsStockIGo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsStockIGo.Dock = System.Windows.Forms.DockStyle.None
        Me.tsStockIGo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsStockIGo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.goGStoBO, Me.ToolStripSeparator2})
        Me.tsStockIGo.Location = New System.Drawing.Point(506, 8)
        Me.tsStockIGo.Name = "tsStockIGo"
        Me.tsStockIGo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsStockIGo.Size = New System.Drawing.Size(43, 25)
        Me.tsStockIGo.TabIndex = 77
        '
        'tbSearchGoodstockBO
        '
        Me.tbSearchGoodstockBO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchGoodstockBO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSearchGoodstockBO.Location = New System.Drawing.Point(14, 9)
        Me.tbSearchGoodstockBO.MaxLength = 50
        Me.tbSearchGoodstockBO.Name = "tbSearchGoodstockBO"
        Me.tbSearchGoodstockBO.Size = New System.Drawing.Size(239, 22)
        Me.tbSearchGoodstockBO.TabIndex = 74
        '
        'dgvGStoBOList
        '
        Me.dgvGStoBOList.AllowUserToAddRows = False
        Me.dgvGStoBOList.AllowUserToDeleteRows = False
        Me.dgvGStoBOList.AllowUserToResizeRows = False
        Me.dgvGStoBOList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvGStoBOList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGStoBOList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvGStoBOList.Location = New System.Drawing.Point(14, 36)
        Me.dgvGStoBOList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvGStoBOList.Name = "dgvGStoBOList"
        Me.dgvGStoBOList.ReadOnly = True
        Me.dgvGStoBOList.RowHeadersVisible = False
        Me.dgvGStoBOList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGStoBOList.Size = New System.Drawing.Size(537, 322)
        Me.dgvGStoBOList.TabIndex = 73
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 39
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "DOC NO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 76
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "DATE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 58
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = " INTO"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "ADDED BY"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 83
        '
        'frmGStoBOH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 396)
        Me.Controls.Add(Me.tsGStoBO)
        Me.Controls.Add(Me.dtpGStoBO2)
        Me.Controls.Add(Me.dtpGStoBO1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tsStockIGo)
        Me.Controls.Add(Me.tbSearchGoodstockBO)
        Me.Controls.Add(Me.dgvGStoBOList)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGStoBOH"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GOODSTOCK CONVERTED TO B.O. LIST"
        Me.tsGStoBO.ResumeLayout(False)
        Me.tsGStoBO.PerformLayout()
        Me.tsStockIGo.ResumeLayout(False)
        Me.tsStockIGo.PerformLayout()
        CType(Me.dgvGStoBOList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteStockIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditStockIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddStockIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsGStoBO As System.Windows.Forms.ToolStrip
    Friend WithEvents dtpGStoBO2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpGStoBO1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents goGStoBO As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tsStockIGo As System.Windows.Forms.ToolStrip
    Friend WithEvents tbSearchGoodstockBO As System.Windows.Forms.TextBox
    Friend WithEvents dgvGStoBOList As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
