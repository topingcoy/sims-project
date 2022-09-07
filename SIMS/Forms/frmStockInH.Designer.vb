<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockInH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockInH))
        Me.dgvStocInList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbSearchStockIn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsStockIGo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.goStockIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.dtpstockin2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpstockin1 = New System.Windows.Forms.DateTimePicker()
        Me.tsStockIn = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddStockIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditStockIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteStockIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.dgvStocInList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsStockIGo.SuspendLayout()
        Me.tsStockIn.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvStocInList
        '
        Me.dgvStocInList.AllowUserToAddRows = False
        Me.dgvStocInList.AllowUserToDeleteRows = False
        Me.dgvStocInList.AllowUserToResizeRows = False
        Me.dgvStocInList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvStocInList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStocInList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvStocInList.Location = New System.Drawing.Point(12, 37)
        Me.dgvStocInList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvStocInList.Name = "dgvStocInList"
        Me.dgvStocInList.ReadOnly = True
        Me.dgvStocInList.RowHeadersVisible = False
        Me.dgvStocInList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStocInList.Size = New System.Drawing.Size(537, 322)
        Me.dgvStocInList.TabIndex = 61
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
        Me.Column4.HeaderText = "STOCK IN TO"
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
        'tbSearchStockIn
        '
        Me.tbSearchStockIn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchStockIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSearchStockIn.Location = New System.Drawing.Point(12, 10)
        Me.tbSearchStockIn.MaxLength = 50
        Me.tbSearchStockIn.Name = "tbSearchStockIn"
        Me.tbSearchStockIn.Size = New System.Drawing.Size(239, 22)
        Me.tbSearchStockIn.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Location = New System.Drawing.Point(382, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "To"
        '
        'tsStockIGo
        '
        Me.tsStockIGo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsStockIGo.Dock = System.Windows.Forms.DockStyle.None
        Me.tsStockIGo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsStockIGo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.goStockIn, Me.ToolStripSeparator2})
        Me.tsStockIGo.Location = New System.Drawing.Point(504, 9)
        Me.tsStockIGo.Name = "tsStockIGo"
        Me.tsStockIGo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsStockIGo.Size = New System.Drawing.Size(43, 25)
        Me.tsStockIGo.TabIndex = 70
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'dtpstockin2
        '
        Me.dtpstockin2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpstockin2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpstockin2.Location = New System.Drawing.Point(408, 10)
        Me.dtpstockin2.Name = "dtpstockin2"
        Me.dtpstockin2.Size = New System.Drawing.Size(93, 22)
        Me.dtpstockin2.TabIndex = 68
        '
        'dtpstockin1
        '
        Me.dtpstockin1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpstockin1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpstockin1.Location = New System.Drawing.Point(280, 10)
        Me.dtpstockin1.Name = "dtpstockin1"
        Me.dtpstockin1.Size = New System.Drawing.Size(93, 22)
        Me.dtpstockin1.TabIndex = 67
        '
        'tsStockIn
        '
        Me.tsStockIn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsStockIn.Dock = System.Windows.Forms.DockStyle.None
        Me.tsStockIn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsStockIn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.AddStockIn, Me.ToolStripSeparator8, Me.EditStockIn, Me.ToolStripSeparator9, Me.DeleteStockIn, Me.ToolStripSeparator10})
        Me.tsStockIn.Location = New System.Drawing.Point(147, 365)
        Me.tsStockIn.Name = "tsStockIn"
        Me.tsStockIn.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsStockIn.Size = New System.Drawing.Size(260, 25)
        Me.tsStockIn.TabIndex = 72
        Me.tsStockIn.Text = "ToolStrip1"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'frmStockInH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 396)
        Me.Controls.Add(Me.tsStockIn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tsStockIGo)
        Me.Controls.Add(Me.dtpstockin2)
        Me.Controls.Add(Me.dtpstockin1)
        Me.Controls.Add(Me.tbSearchStockIn)
        Me.Controls.Add(Me.dgvStocInList)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockInH"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MISCELLANEOUS STOCK IN LIST"
        CType(Me.dgvStocInList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsStockIGo.ResumeLayout(False)
        Me.tsStockIGo.PerformLayout()
        Me.tsStockIn.ResumeLayout(False)
        Me.tsStockIn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvStocInList As System.Windows.Forms.DataGridView
    Friend WithEvents tbSearchStockIn As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tsStockIGo As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents goStockIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dtpstockin2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpstockin1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tsStockIn As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddStockIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditStockIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteStockIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
