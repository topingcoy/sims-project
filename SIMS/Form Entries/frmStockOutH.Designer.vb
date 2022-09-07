<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockOutH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockOutH))
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteStockOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditStockOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddStockOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsStockOut = New System.Windows.Forms.ToolStrip()
        Me.dtpstockin2 = New System.Windows.Forms.DateTimePicker()
        Me.dgvStockOutList = New System.Windows.Forms.DataGridView()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.goStockIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsStockOGo = New System.Windows.Forms.ToolStrip()
        Me.tbSearchStockOut = New System.Windows.Forms.TextBox()
        Me.dtpstockin1 = New System.Windows.Forms.DateTimePicker()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsStockOut.SuspendLayout()
        CType(Me.dgvStockOutList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsStockOGo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'DeleteStockOut
        '
        Me.DeleteStockOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DeleteStockOut.Image = CType(resources.GetObject("DeleteStockOut.Image"), System.Drawing.Image)
        Me.DeleteStockOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteStockOut.Name = "DeleteStockOut"
        Me.DeleteStockOut.Size = New System.Drawing.Size(81, 22)
        Me.DeleteStockOut.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'EditStockOut
        '
        Me.EditStockOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditStockOut.Image = CType(resources.GetObject("EditStockOut.Image"), System.Drawing.Image)
        Me.EditStockOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditStockOut.Name = "EditStockOut"
        Me.EditStockOut.Size = New System.Drawing.Size(89, 22)
        Me.EditStockOut.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'AddStockOut
        '
        Me.AddStockOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AddStockOut.Image = CType(resources.GetObject("AddStockOut.Image"), System.Drawing.Image)
        Me.AddStockOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddStockOut.Name = "AddStockOut"
        Me.AddStockOut.Size = New System.Drawing.Size(66, 22)
        Me.AddStockOut.Text = "[F5] - ADD"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tsStockOut
        '
        Me.tsStockOut.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsStockOut.Dock = System.Windows.Forms.DockStyle.None
        Me.tsStockOut.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsStockOut.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.AddStockOut, Me.ToolStripSeparator8, Me.EditStockOut, Me.ToolStripSeparator9, Me.DeleteStockOut, Me.ToolStripSeparator10})
        Me.tsStockOut.Location = New System.Drawing.Point(149, 364)
        Me.tsStockOut.Name = "tsStockOut"
        Me.tsStockOut.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsStockOut.Size = New System.Drawing.Size(263, 25)
        Me.tsStockOut.TabIndex = 79
        '
        'dtpstockin2
        '
        Me.dtpstockin2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpstockin2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpstockin2.Location = New System.Drawing.Point(410, 9)
        Me.dtpstockin2.Name = "dtpstockin2"
        Me.dtpstockin2.Size = New System.Drawing.Size(93, 22)
        Me.dtpstockin2.TabIndex = 76
        '
        'dgvStockOutList
        '
        Me.dgvStockOutList.AllowUserToAddRows = False
        Me.dgvStockOutList.AllowUserToDeleteRows = False
        Me.dgvStockOutList.AllowUserToResizeRows = False
        Me.dgvStockOutList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvStockOutList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStockOutList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvStockOutList.Location = New System.Drawing.Point(14, 36)
        Me.dgvStockOutList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvStockOutList.Name = "dgvStockOutList"
        Me.dgvStockOutList.ReadOnly = True
        Me.dgvStockOutList.RowHeadersVisible = False
        Me.dgvStockOutList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStockOutList.Size = New System.Drawing.Size(537, 322)
        Me.dgvStockOutList.TabIndex = 73
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'goStockIn
        '
        Me.goStockIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.goStockIn.Image = CType(resources.GetObject("goStockIn.Image"), System.Drawing.Image)
        Me.goStockIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.goStockIn.Name = "goStockIn"
        Me.goStockIn.Size = New System.Drawing.Size(28, 22)
        Me.goStockIn.Text = "GO"
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
        'tsStockOGo
        '
        Me.tsStockOGo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsStockOGo.Dock = System.Windows.Forms.DockStyle.None
        Me.tsStockOGo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsStockOGo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.goStockIn, Me.ToolStripSeparator2})
        Me.tsStockOGo.Location = New System.Drawing.Point(506, 8)
        Me.tsStockOGo.Name = "tsStockOGo"
        Me.tsStockOGo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsStockOGo.Size = New System.Drawing.Size(43, 25)
        Me.tsStockOGo.TabIndex = 77
        '
        'tbSearchStockOut
        '
        Me.tbSearchStockOut.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchStockOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSearchStockOut.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearchStockOut.Location = New System.Drawing.Point(14, 9)
        Me.tbSearchStockOut.MaxLength = 50
        Me.tbSearchStockOut.Name = "tbSearchStockOut"
        Me.tbSearchStockOut.Size = New System.Drawing.Size(173, 22)
        Me.tbSearchStockOut.TabIndex = 74
        '
        'dtpstockin1
        '
        Me.dtpstockin1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpstockin1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpstockin1.Location = New System.Drawing.Point(282, 9)
        Me.dtpstockin1.Name = "dtpstockin1"
        Me.dtpstockin1.Size = New System.Drawing.Size(93, 22)
        Me.dtpstockin1.TabIndex = 75
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
        Me.Column2.HeaderText = "DOC NO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = "DATE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 60
        '
        'Column4
        '
        Me.Column4.HeaderText = "STOCK OUT FROM"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 240
        '
        'Column5
        '
        Me.Column5.HeaderText = "ENTERED BY"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'frmStockOutH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 396)
        Me.Controls.Add(Me.tsStockOut)
        Me.Controls.Add(Me.dtpstockin2)
        Me.Controls.Add(Me.dgvStockOutList)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tsStockOGo)
        Me.Controls.Add(Me.tbSearchStockOut)
        Me.Controls.Add(Me.dtpstockin1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockOutH"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MISCELLANEOUS STOCK OUT LIST"
        Me.tsStockOut.ResumeLayout(False)
        Me.tsStockOut.PerformLayout()
        CType(Me.dgvStockOutList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsStockOGo.ResumeLayout(False)
        Me.tsStockOGo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteStockOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditStockOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddStockOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsStockOut As System.Windows.Forms.ToolStrip
    Friend WithEvents dtpstockin2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvStockOutList As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents goStockIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tsStockOGo As System.Windows.Forms.ToolStrip
    Friend WithEvents tbSearchStockOut As System.Windows.Forms.TextBox
    Friend WithEvents dtpstockin1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
