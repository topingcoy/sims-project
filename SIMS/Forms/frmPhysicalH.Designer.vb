<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhysicalH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhysicalH))
        Me.dgvTransferList = New System.Windows.Forms.DataGridView()
        Me.tsTransGo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.transGo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpTransfer2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpTransfer1 = New System.Windows.Forms.DateTimePicker()
        Me.tbTransferSearch = New System.Windows.Forms.TextBox()
        Me.tsTransfer = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddTransfer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditTransfer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteTransfer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvTransferList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsTransGo.SuspendLayout()
        Me.tsTransfer.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTransferList
        '
        Me.dgvTransferList.AllowUserToAddRows = False
        Me.dgvTransferList.AllowUserToDeleteRows = False
        Me.dgvTransferList.AllowUserToResizeRows = False
        Me.dgvTransferList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTransferList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransferList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvTransferList.Location = New System.Drawing.Point(12, 39)
        Me.dgvTransferList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvTransferList.Name = "dgvTransferList"
        Me.dgvTransferList.ReadOnly = True
        Me.dgvTransferList.RowHeadersVisible = False
        Me.dgvTransferList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTransferList.Size = New System.Drawing.Size(767, 348)
        Me.dgvTransferList.TabIndex = 60
        '
        'tsTransGo
        '
        Me.tsTransGo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsTransGo.Dock = System.Windows.Forms.DockStyle.None
        Me.tsTransGo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsTransGo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.transGo, Me.ToolStripSeparator2})
        Me.tsTransGo.Location = New System.Drawing.Point(736, 8)
        Me.tsTransGo.Name = "tsTransGo"
        Me.tsTransGo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsTransGo.Size = New System.Drawing.Size(43, 25)
        Me.tsTransGo.TabIndex = 65
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'transGo
        '
        Me.transGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.transGo.Image = CType(resources.GetObject("transGo.Image"), System.Drawing.Image)
        Me.transGo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.transGo.Name = "transGo"
        Me.transGo.Size = New System.Drawing.Size(28, 22)
        Me.transGo.Text = "GO"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Location = New System.Drawing.Point(607, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "To"
        '
        'dtpTransfer2
        '
        Me.dtpTransfer2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpTransfer2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTransfer2.Location = New System.Drawing.Point(635, 9)
        Me.dtpTransfer2.Name = "dtpTransfer2"
        Me.dtpTransfer2.Size = New System.Drawing.Size(93, 22)
        Me.dtpTransfer2.TabIndex = 67
        '
        'dtpTransfer1
        '
        Me.dtpTransfer1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpTransfer1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTransfer1.Location = New System.Drawing.Point(507, 9)
        Me.dtpTransfer1.Name = "dtpTransfer1"
        Me.dtpTransfer1.Size = New System.Drawing.Size(93, 22)
        Me.dtpTransfer1.TabIndex = 66
        '
        'tbTransferSearch
        '
        Me.tbTransferSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTransferSearch.Location = New System.Drawing.Point(12, 8)
        Me.tbTransferSearch.MaxLength = 50
        Me.tbTransferSearch.Name = "tbTransferSearch"
        Me.tbTransferSearch.Size = New System.Drawing.Size(248, 22)
        Me.tbTransferSearch.TabIndex = 69
        '
        'tsTransfer
        '
        Me.tsTransfer.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsTransfer.Dock = System.Windows.Forms.DockStyle.None
        Me.tsTransfer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsTransfer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.AddTransfer, Me.ToolStripSeparator8, Me.EditTransfer, Me.ToolStripSeparator9, Me.DeleteTransfer, Me.ToolStripSeparator10})
        Me.tsTransfer.Location = New System.Drawing.Point(243, 394)
        Me.tsTransfer.Name = "tsTransfer"
        Me.tsTransfer.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsTransfer.Size = New System.Drawing.Size(260, 25)
        Me.tsTransfer.TabIndex = 70
        Me.tsTransfer.Text = "ToolStrip1"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'AddTransfer
        '
        Me.AddTransfer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AddTransfer.Image = CType(resources.GetObject("AddTransfer.Image"), System.Drawing.Image)
        Me.AddTransfer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddTransfer.Name = "AddTransfer"
        Me.AddTransfer.Size = New System.Drawing.Size(66, 22)
        Me.AddTransfer.Text = "[F5] - ADD"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'EditTransfer
        '
        Me.EditTransfer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditTransfer.Image = CType(resources.GetObject("EditTransfer.Image"), System.Drawing.Image)
        Me.EditTransfer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditTransfer.Name = "EditTransfer"
        Me.EditTransfer.Size = New System.Drawing.Size(87, 22)
        Me.EditTransfer.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'DeleteTransfer
        '
        Me.DeleteTransfer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DeleteTransfer.Image = CType(resources.GetObject("DeleteTransfer.Image"), System.Drawing.Image)
        Me.DeleteTransfer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteTransfer.Name = "DeleteTransfer"
        Me.DeleteTransfer.Size = New System.Drawing.Size(80, 22)
        Me.DeleteTransfer.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
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
        Me.Column2.HeaderText = "WAREHOUSE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "AS OF"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 63
        '
        'Column4
        '
        Me.Column4.HeaderText = "REMARKS"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 400
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Added By"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 80
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Status"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 64
        '
        'frmPhysicalH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 424)
        Me.Controls.Add(Me.tsTransfer)
        Me.Controls.Add(Me.tbTransferSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpTransfer2)
        Me.Controls.Add(Me.dtpTransfer1)
        Me.Controls.Add(Me.tsTransGo)
        Me.Controls.Add(Me.dgvTransferList)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPhysicalH"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PHYSICAL INVENTORY LIST"
        CType(Me.dgvTransferList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsTransGo.ResumeLayout(False)
        Me.tsTransGo.PerformLayout()
        Me.tsTransfer.ResumeLayout(False)
        Me.tsTransfer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTransferList As System.Windows.Forms.DataGridView
    Friend WithEvents tsTransGo As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents transGo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpTransfer2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTransfer1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbTransferSearch As System.Windows.Forms.TextBox
    Friend WithEvents tsTransfer As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddTransfer As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditTransfer As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteTransfer As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
