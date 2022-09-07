<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchTypeOper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchTypeOper))
        Me.dgvListTypeOper = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsListTypeOper = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsSelect = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator32 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbSearchTypeOper = New System.Windows.Forms.TextBox()
        CType(Me.dgvListTypeOper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsListTypeOper.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListTypeOper
        '
        Me.dgvListTypeOper.AllowUserToAddRows = False
        Me.dgvListTypeOper.AllowUserToResizeRows = False
        Me.dgvListTypeOper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListTypeOper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListTypeOper.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvListTypeOper.Location = New System.Drawing.Point(14, 34)
        Me.dgvListTypeOper.Name = "dgvListTypeOper"
        Me.dgvListTypeOper.RowHeadersVisible = False
        Me.dgvListTypeOper.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListTypeOper.Size = New System.Drawing.Size(453, 323)
        Me.dgvListTypeOper.TabIndex = 85
        '
        'Column1
        '
        Me.Column1.HeaderText = "SELECT"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "WAREHOUSE NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 280
        '
        'Column3
        '
        Me.Column3.HeaderText = "CODE"
        Me.Column3.Name = "Column3"
        '
        'tsListTypeOper
        '
        Me.tsListTypeOper.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsListTypeOper.Dock = System.Windows.Forms.DockStyle.None
        Me.tsListTypeOper.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsListTypeOper.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsSelect, Me.ToolStripSeparator32})
        Me.tsListTypeOper.Location = New System.Drawing.Point(409, 360)
        Me.tsListTypeOper.Name = "tsListTypeOper"
        Me.tsListTypeOper.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsListTypeOper.Size = New System.Drawing.Size(57, 25)
        Me.tsListTypeOper.TabIndex = 87
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
        'tbSearchTypeOper
        '
        Me.tbSearchTypeOper.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchTypeOper.Location = New System.Drawing.Point(14, 7)
        Me.tbSearchTypeOper.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbSearchTypeOper.MaxLength = 50
        Me.tbSearchTypeOper.Name = "tbSearchTypeOper"
        Me.tbSearchTypeOper.Size = New System.Drawing.Size(218, 22)
        Me.tbSearchTypeOper.TabIndex = 86
        '
        'frmSearchTypeOper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 393)
        Me.Controls.Add(Me.dgvListTypeOper)
        Me.Controls.Add(Me.tsListTypeOper)
        Me.Controls.Add(Me.tbSearchTypeOper)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchTypeOper"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIST TYPE OF OPERATION"
        CType(Me.dgvListTypeOper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsListTypeOper.ResumeLayout(False)
        Me.tsListTypeOper.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListTypeOper As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsListTypeOper As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator32 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbSearchTypeOper As System.Windows.Forms.TextBox
End Class
