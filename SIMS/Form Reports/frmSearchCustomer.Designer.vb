<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchCustomer))
        Me.dgvListCustomer = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbSearchCustomer = New System.Windows.Forms.TextBox()
        Me.tsListCustomer = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsSelect = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator32 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.dgvListCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsListCustomer.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListCustomer
        '
        Me.dgvListCustomer.AllowUserToAddRows = False
        Me.dgvListCustomer.AllowUserToResizeRows = False
        Me.dgvListCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvListCustomer.Location = New System.Drawing.Point(12, 38)
        Me.dgvListCustomer.Name = "dgvListCustomer"
        Me.dgvListCustomer.RowHeadersVisible = False
        Me.dgvListCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListCustomer.Size = New System.Drawing.Size(904, 362)
        Me.dgvListCustomer.TabIndex = 31
        '
        'Column1
        '
        Me.Column1.HeaderText = "SELECT"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "CUSTOMER NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 280
        '
        'Column3
        '
        Me.Column3.HeaderText = "CODE"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "AREA/TERRITORY"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "ADDRESS"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 350
        '
        'tbSearchCustomer
        '
        Me.tbSearchCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchCustomer.Location = New System.Drawing.Point(12, 11)
        Me.tbSearchCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbSearchCustomer.MaxLength = 50
        Me.tbSearchCustomer.Name = "tbSearchCustomer"
        Me.tbSearchCustomer.Size = New System.Drawing.Size(253, 22)
        Me.tbSearchCustomer.TabIndex = 32
        '
        'tsListCustomer
        '
        Me.tsListCustomer.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsListCustomer.Dock = System.Windows.Forms.DockStyle.None
        Me.tsListCustomer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsListCustomer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsSelect, Me.ToolStripSeparator32})
        Me.tsListCustomer.Location = New System.Drawing.Point(859, 403)
        Me.tsListCustomer.Name = "tsListCustomer"
        Me.tsListCustomer.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsListCustomer.Size = New System.Drawing.Size(57, 25)
        Me.tsListCustomer.TabIndex = 85
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'tsSelect
        '
        Me.tsSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsSelect.Image = CType(resources.GetObject("tsSelect.Image"), System.Drawing.Image)
        Me.tsSelect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSelect.Name = "tsSelect"
        Me.tsSelect.Size = New System.Drawing.Size(42, 22)
        Me.tsSelect.Text = "&Select"
        '
        'ToolStripSeparator32
        '
        Me.ToolStripSeparator32.Name = "ToolStripSeparator32"
        Me.ToolStripSeparator32.Size = New System.Drawing.Size(6, 25)
        '
        'frmListCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 432)
        Me.Controls.Add(Me.tsListCustomer)
        Me.Controls.Add(Me.tbSearchCustomer)
        Me.Controls.Add(Me.dgvListCustomer)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListCustomer"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUSTOMER LIST"
        CType(Me.dgvListCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsListCustomer.ResumeLayout(False)
        Me.tsListCustomer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents tbSearchCustomer As System.Windows.Forms.TextBox
    Friend WithEvents tsListCustomer As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator32 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
