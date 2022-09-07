<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGSreturnSupplierH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGSreturnSupplierH))
        Me.dgvGSreturnSupplier = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.tsBOtoSupplier = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddBOreturn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditBOreturn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteBOreturn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.dgvGSreturnSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsBOtoSupplier.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvGSreturnSupplier
        '
        Me.dgvGSreturnSupplier.AllowUserToAddRows = False
        Me.dgvGSreturnSupplier.AllowUserToDeleteRows = False
        Me.dgvGSreturnSupplier.AllowUserToResizeRows = False
        Me.dgvGSreturnSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvGSreturnSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGSreturnSupplier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column6, Me.Column9})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGSreturnSupplier.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvGSreturnSupplier.Location = New System.Drawing.Point(12, 33)
        Me.dgvGSreturnSupplier.Name = "dgvGSreturnSupplier"
        Me.dgvGSreturnSupplier.ReadOnly = True
        Me.dgvGSreturnSupplier.RowHeadersVisible = False
        Me.dgvGSreturnSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGSreturnSupplier.Size = New System.Drawing.Size(696, 411)
        Me.dgvGSreturnSupplier.TabIndex = 41
        '
        'Column1
        '
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 39
        '
        'Column2
        '
        Me.Column2.HeaderText = "TRANS NO."
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 92
        '
        'Column3
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "DATE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 59
        '
        'Column5
        '
        Me.Column5.HeaderText = "FROM"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 305
        '
        'Column6
        '
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
        Me.Column9.HeaderText = "ENTERED BY"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 97
        '
        'tbSearch
        '
        Me.tbSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSearch.Location = New System.Drawing.Point(12, 4)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(192, 23)
        Me.tbSearch.TabIndex = 107
        '
        'tsBOtoSupplier
        '
        Me.tsBOtoSupplier.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsBOtoSupplier.Dock = System.Windows.Forms.DockStyle.None
        Me.tsBOtoSupplier.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsBOtoSupplier.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.AddBOreturn, Me.ToolStripSeparator33, Me.EditBOreturn, Me.ToolStripSeparator3, Me.DeleteBOreturn, Me.ToolStripSeparator4})
        Me.tsBOtoSupplier.Location = New System.Drawing.Point(228, 451)
        Me.tsBOtoSupplier.Name = "tsBOtoSupplier"
        Me.tsBOtoSupplier.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsBOtoSupplier.Size = New System.Drawing.Size(260, 25)
        Me.tsBOtoSupplier.TabIndex = 108
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
        'frmGSreturnSupplierH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 488)
        Me.Controls.Add(Me.tsBOtoSupplier)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.dgvGSreturnSupplier)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGSreturnSupplierH"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENTER GOOD STOCK RETURN TO SUPPLIER"
        CType(Me.dgvGSreturnSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsBOtoSupplier.ResumeLayout(False)
        Me.tsBOtoSupplier.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvGSreturnSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents tbSearch As System.Windows.Forms.TextBox
    Friend WithEvents tsBOtoSupplier As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddBOreturn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditBOreturn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteBOreturn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
