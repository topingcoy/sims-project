<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchProvince
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchProvince))
        Me.dgvListProvince = New System.Windows.Forms.DataGridView()
        Me.tsListProvince = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsSelect = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator32 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbSearchProvince = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvListProvince, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsListProvince.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListProvince
        '
        Me.dgvListProvince.AllowUserToAddRows = False
        Me.dgvListProvince.AllowUserToResizeRows = False
        Me.dgvListProvince.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListProvince.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListProvince.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvListProvince.Location = New System.Drawing.Point(16, 36)
        Me.dgvListProvince.Name = "dgvListProvince"
        Me.dgvListProvince.RowHeadersVisible = False
        Me.dgvListProvince.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListProvince.Size = New System.Drawing.Size(453, 323)
        Me.dgvListProvince.TabIndex = 91
        '
        'tsListProvince
        '
        Me.tsListProvince.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsListProvince.Dock = System.Windows.Forms.DockStyle.None
        Me.tsListProvince.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsListProvince.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsSelect, Me.ToolStripSeparator32})
        Me.tsListProvince.Location = New System.Drawing.Point(411, 362)
        Me.tsListProvince.Name = "tsListProvince"
        Me.tsListProvince.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsListProvince.Size = New System.Drawing.Size(88, 25)
        Me.tsListProvince.TabIndex = 93
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
        'tbSearchProvince
        '
        Me.tbSearchProvince.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchProvince.Location = New System.Drawing.Point(16, 9)
        Me.tbSearchProvince.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbSearchProvince.MaxLength = 50
        Me.tbSearchProvince.Name = "tbSearchProvince"
        Me.tbSearchProvince.Size = New System.Drawing.Size(218, 22)
        Me.tbSearchProvince.TabIndex = 92
        '
        'Column1
        '
        Me.Column1.HeaderText = "SELECT"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "PROVINCE NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 280
        '
        'Column3
        '
        Me.Column3.HeaderText = "CODE"
        Me.Column3.Name = "Column3"
        '
        'frmSearchProvince
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 397)
        Me.Controls.Add(Me.dgvListProvince)
        Me.Controls.Add(Me.tsListProvince)
        Me.Controls.Add(Me.tbSearchProvince)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchProvince"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIST OF PROVINCE"
        CType(Me.dgvListProvince, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsListProvince.ResumeLayout(False)
        Me.tsListProvince.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListProvince As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsListProvince As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator32 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbSearchProvince As System.Windows.Forms.TextBox
End Class
