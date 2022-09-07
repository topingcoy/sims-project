<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchBrand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchBrand))
        Me.dgvListBrand = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsListBrand = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsSelect = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator32 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbSearchBrand = New System.Windows.Forms.TextBox()
        CType(Me.dgvListBrand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsListBrand.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListBrand
        '
        Me.dgvListBrand.AllowUserToAddRows = False
        Me.dgvListBrand.AllowUserToResizeRows = False
        Me.dgvListBrand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListBrand.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvListBrand.Location = New System.Drawing.Point(14, 35)
        Me.dgvListBrand.Name = "dgvListBrand"
        Me.dgvListBrand.RowHeadersVisible = False
        Me.dgvListBrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListBrand.Size = New System.Drawing.Size(453, 323)
        Me.dgvListBrand.TabIndex = 88
        '
        'Column1
        '
        Me.Column1.HeaderText = "SELECT"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "BRAND NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 280
        '
        'Column3
        '
        Me.Column3.HeaderText = "CODE"
        Me.Column3.Name = "Column3"
        '
        'tsListBrand
        '
        Me.tsListBrand.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsListBrand.Dock = System.Windows.Forms.DockStyle.None
        Me.tsListBrand.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsListBrand.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsSelect, Me.ToolStripSeparator32})
        Me.tsListBrand.Location = New System.Drawing.Point(409, 361)
        Me.tsListBrand.Name = "tsListBrand"
        Me.tsListBrand.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsListBrand.Size = New System.Drawing.Size(57, 25)
        Me.tsListBrand.TabIndex = 90
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
        'tbSearchBrand
        '
        Me.tbSearchBrand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchBrand.Location = New System.Drawing.Point(14, 8)
        Me.tbSearchBrand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbSearchBrand.MaxLength = 50
        Me.tbSearchBrand.Name = "tbSearchBrand"
        Me.tbSearchBrand.Size = New System.Drawing.Size(218, 22)
        Me.tbSearchBrand.TabIndex = 89
        '
        'frmSearchBrand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 393)
        Me.Controls.Add(Me.dgvListBrand)
        Me.Controls.Add(Me.tsListBrand)
        Me.Controls.Add(Me.tbSearchBrand)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchBrand"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEARCH BRAND"
        CType(Me.dgvListBrand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsListBrand.ResumeLayout(False)
        Me.tsListBrand.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListBrand As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsListBrand As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator32 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbSearchBrand As System.Windows.Forms.TextBox
End Class
