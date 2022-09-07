<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchCategory))
        Me.dgvListCategory = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsListCategory = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsSelect = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator32 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbSearchCategory = New System.Windows.Forms.TextBox()
        CType(Me.dgvListCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsListCategory.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListCategory
        '
        Me.dgvListCategory.AllowUserToAddRows = False
        Me.dgvListCategory.AllowUserToResizeRows = False
        Me.dgvListCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListCategory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvListCategory.Location = New System.Drawing.Point(12, 33)
        Me.dgvListCategory.Name = "dgvListCategory"
        Me.dgvListCategory.RowHeadersVisible = False
        Me.dgvListCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListCategory.Size = New System.Drawing.Size(453, 323)
        Me.dgvListCategory.TabIndex = 85
        '
        'Column1
        '
        Me.Column1.HeaderText = "SELECT"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "CATEGORY NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 280
        '
        'Column3
        '
        Me.Column3.HeaderText = "CODE"
        Me.Column3.Name = "Column3"
        '
        'tsListCategory
        '
        Me.tsListCategory.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsListCategory.Dock = System.Windows.Forms.DockStyle.None
        Me.tsListCategory.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsListCategory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsSelect, Me.ToolStripSeparator32})
        Me.tsListCategory.Location = New System.Drawing.Point(407, 359)
        Me.tsListCategory.Name = "tsListCategory"
        Me.tsListCategory.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsListCategory.Size = New System.Drawing.Size(57, 25)
        Me.tsListCategory.TabIndex = 87
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
        'tbSearchCategory
        '
        Me.tbSearchCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchCategory.Location = New System.Drawing.Point(12, 6)
        Me.tbSearchCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbSearchCategory.MaxLength = 50
        Me.tbSearchCategory.Name = "tbSearchCategory"
        Me.tbSearchCategory.Size = New System.Drawing.Size(218, 22)
        Me.tbSearchCategory.TabIndex = 86
        '
        'frmSearchCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 389)
        Me.Controls.Add(Me.dgvListCategory)
        Me.Controls.Add(Me.tsListCategory)
        Me.Controls.Add(Me.tbSearchCategory)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchCategory"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CATEGORY LIST"
        CType(Me.dgvListCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsListCategory.ResumeLayout(False)
        Me.tsListCategory.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListCategory As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsListCategory As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator32 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbSearchCategory As System.Windows.Forms.TextBox
End Class
