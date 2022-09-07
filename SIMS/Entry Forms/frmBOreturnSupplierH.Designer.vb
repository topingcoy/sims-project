<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBOreturnSupplierH
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBOreturnSupplierH))
        Me.dgvBOreturnSupplier = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsBOtoSupplier = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddBOreturn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditBOreturn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteBOreturn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tsRcvGo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.boRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Go = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdate2 = New System.Windows.Forms.DateTimePicker()
        Me.rdate1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvBOreturnSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsBOtoSupplier.SuspendLayout()
        Me.tsRcvGo.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvBOreturnSupplier
        '
        Me.dgvBOreturnSupplier.AllowUserToAddRows = False
        Me.dgvBOreturnSupplier.AllowUserToDeleteRows = False
        Me.dgvBOreturnSupplier.AllowUserToResizeRows = False
        Me.dgvBOreturnSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvBOreturnSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBOreturnSupplier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column7, Me.Column5, Me.Column4, Me.Column6, Me.Column9})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBOreturnSupplier.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBOreturnSupplier.Location = New System.Drawing.Point(12, 41)
        Me.dgvBOreturnSupplier.Name = "dgvBOreturnSupplier"
        Me.dgvBOreturnSupplier.ReadOnly = True
        Me.dgvBOreturnSupplier.RowHeadersVisible = False
        Me.dgvBOreturnSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBOreturnSupplier.Size = New System.Drawing.Size(837, 411)
        Me.dgvBOreturnSupplier.TabIndex = 109
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
        Me.Column2.HeaderText = "TRANS NO."
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 92
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "DATE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 59
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "DOC NO"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 78
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "FROM"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 65
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "RETURN TO"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column6.HeaderText = "AMOUNT"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 83
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "ADDED BY"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 87
        '
        'tsBOtoSupplier
        '
        Me.tsBOtoSupplier.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsBOtoSupplier.Dock = System.Windows.Forms.DockStyle.None
        Me.tsBOtoSupplier.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsBOtoSupplier.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.AddBOreturn, Me.ToolStripSeparator33, Me.EditBOreturn, Me.ToolStripSeparator3, Me.DeleteBOreturn, Me.ToolStripSeparator4})
        Me.tsBOtoSupplier.Location = New System.Drawing.Point(304, 455)
        Me.tsBOtoSupplier.Name = "tsBOtoSupplier"
        Me.tsBOtoSupplier.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsBOtoSupplier.Size = New System.Drawing.Size(260, 25)
        Me.tsBOtoSupplier.TabIndex = 111
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'AddBOreturn
        '
        Me.AddBOreturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AddBOreturn.Image = CType(resources.GetObject("AddBOreturn.Image"), System.Drawing.Image)
        Me.AddBOreturn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddBOreturn.Name = "AddBOreturn"
        Me.AddBOreturn.Size = New System.Drawing.Size(66, 22)
        Me.AddBOreturn.Text = "[F5] - ADD"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'EditBOreturn
        '
        Me.EditBOreturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditBOreturn.Image = CType(resources.GetObject("EditBOreturn.Image"), System.Drawing.Image)
        Me.EditBOreturn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditBOreturn.Name = "EditBOreturn"
        Me.EditBOreturn.Size = New System.Drawing.Size(87, 22)
        Me.EditBOreturn.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'DeleteBOreturn
        '
        Me.DeleteBOreturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DeleteBOreturn.Image = CType(resources.GetObject("DeleteBOreturn.Image"), System.Drawing.Image)
        Me.DeleteBOreturn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteBOreturn.Name = "DeleteBOreturn"
        Me.DeleteBOreturn.Size = New System.Drawing.Size(80, 22)
        Me.DeleteBOreturn.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tbSearch
        '
        Me.tbSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSearch.Location = New System.Drawing.Point(12, 12)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(192, 23)
        Me.tbSearch.TabIndex = 110
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(447, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Date Range :"
        '
        'tsRcvGo
        '
        Me.tsRcvGo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsRcvGo.Dock = System.Windows.Forms.DockStyle.None
        Me.tsRcvGo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsRcvGo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.boRefresh, Me.ToolStripSeparator5, Me.Go, Me.ToolStripSeparator2})
        Me.tsRcvGo.Location = New System.Drawing.Point(752, 9)
        Me.tsRcvGo.Name = "tsRcvGo"
        Me.tsRcvGo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsRcvGo.Size = New System.Drawing.Size(97, 25)
        Me.tsRcvGo.TabIndex = 115
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'boRefresh
        '
        Me.boRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.boRefresh.Image = CType(resources.GetObject("boRefresh.Image"), System.Drawing.Image)
        Me.boRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boRefresh.Name = "boRefresh"
        Me.boRefresh.Size = New System.Drawing.Size(50, 22)
        Me.boRefresh.Text = "&Refresh"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Go
        '
        Me.Go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Go.Image = CType(resources.GetObject("Go.Image"), System.Drawing.Image)
        Me.Go.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Go.Name = "Go"
        Me.Go.Size = New System.Drawing.Size(26, 22)
        Me.Go.Text = "&Go"
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
        Me.Label1.Location = New System.Drawing.Point(625, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 15)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "To"
        '
        'rdate2
        '
        Me.rdate2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdate2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rdate2.Location = New System.Drawing.Point(653, 12)
        Me.rdate2.Name = "rdate2"
        Me.rdate2.Size = New System.Drawing.Size(93, 23)
        Me.rdate2.TabIndex = 113
        '
        'rdate1
        '
        Me.rdate1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdate1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rdate1.Location = New System.Drawing.Point(525, 12)
        Me.rdate1.Name = "rdate1"
        Me.rdate1.Size = New System.Drawing.Size(93, 23)
        Me.rdate1.TabIndex = 112
        '
        'frmBOreturnSupplierH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 488)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tsRcvGo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rdate2)
        Me.Controls.Add(Me.rdate1)
        Me.Controls.Add(Me.dgvBOreturnSupplier)
        Me.Controls.Add(Me.tsBOtoSupplier)
        Me.Controls.Add(Me.tbSearch)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBOreturnSupplierH"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENTER B.O. RETURN TO SUPPLIER"
        CType(Me.dgvBOreturnSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsBOtoSupplier.ResumeLayout(False)
        Me.tsBOtoSupplier.PerformLayout()
        Me.tsRcvGo.ResumeLayout(False)
        Me.tsRcvGo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBOreturnSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents tsBOtoSupplier As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddBOreturn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditBOreturn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteBOreturn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbSearch As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tsRcvGo As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents boRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Go As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdate1 As System.Windows.Forms.DateTimePicker
End Class
