<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListSalesman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListSalesman))
        Me.dgvListSalesman = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbSearchSlsman = New System.Windows.Forms.TextBox()
        Me.tsListSalesman = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsSelect = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator32 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.dgvListSalesman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsListSalesman.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListSalesman
        '
        Me.dgvListSalesman.AllowUserToAddRows = False
        Me.dgvListSalesman.AllowUserToResizeRows = False
        Me.dgvListSalesman.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListSalesman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListSalesman.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvListSalesman.Location = New System.Drawing.Point(12, 33)
        Me.dgvListSalesman.Name = "dgvListSalesman"
        Me.dgvListSalesman.RowHeadersVisible = False
        Me.dgvListSalesman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListSalesman.Size = New System.Drawing.Size(453, 323)
        Me.dgvListSalesman.TabIndex = 29
        '
        'Column1
        '
        Me.Column1.HeaderText = "SELECT"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "SALESMAN NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 280
        '
        'Column3
        '
        Me.Column3.HeaderText = "CODE"
        Me.Column3.Name = "Column3"
        '
        'tbSearchSlsman
        '
        Me.tbSearchSlsman.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchSlsman.Location = New System.Drawing.Point(12, 6)
        Me.tbSearchSlsman.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbSearchSlsman.MaxLength = 50
        Me.tbSearchSlsman.Name = "tbSearchSlsman"
        Me.tbSearchSlsman.Size = New System.Drawing.Size(218, 22)
        Me.tbSearchSlsman.TabIndex = 30
        '
        'tsListSalesman
        '
        Me.tsListSalesman.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsListSalesman.Dock = System.Windows.Forms.DockStyle.None
        Me.tsListSalesman.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsListSalesman.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsSelect, Me.ToolStripSeparator32})
        Me.tsListSalesman.Location = New System.Drawing.Point(408, 360)
        Me.tsListSalesman.Name = "tsListSalesman"
        Me.tsListSalesman.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsListSalesman.Size = New System.Drawing.Size(57, 25)
        Me.tsListSalesman.TabIndex = 83
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
        'frmListSalesman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 389)
        Me.Controls.Add(Me.tsListSalesman)
        Me.Controls.Add(Me.tbSearchSlsman)
        Me.Controls.Add(Me.dgvListSalesman)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListSalesman"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALESMAN LIST"
        CType(Me.dgvListSalesman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsListSalesman.ResumeLayout(False)
        Me.tsListSalesman.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListSalesman As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbSearchSlsman As System.Windows.Forms.TextBox
    Friend WithEvents tsListSalesman As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator32 As System.Windows.Forms.ToolStripSeparator
End Class
