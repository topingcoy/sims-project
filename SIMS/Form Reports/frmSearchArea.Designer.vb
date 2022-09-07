<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchArea
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchArea))
        Me.dgvListAreaTerritory = New System.Windows.Forms.DataGridView()
        Me.tsListAreaTerritory = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsSelect = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator32 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbSearchArea = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvListAreaTerritory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsListAreaTerritory.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListAreaTerritory
        '
        Me.dgvListAreaTerritory.AllowUserToAddRows = False
        Me.dgvListAreaTerritory.AllowUserToResizeRows = False
        Me.dgvListAreaTerritory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListAreaTerritory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListAreaTerritory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvListAreaTerritory.Location = New System.Drawing.Point(14, 34)
        Me.dgvListAreaTerritory.Name = "dgvListAreaTerritory"
        Me.dgvListAreaTerritory.RowHeadersVisible = False
        Me.dgvListAreaTerritory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListAreaTerritory.Size = New System.Drawing.Size(453, 323)
        Me.dgvListAreaTerritory.TabIndex = 88
        '
        'tsListAreaTerritory
        '
        Me.tsListAreaTerritory.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsListAreaTerritory.Dock = System.Windows.Forms.DockStyle.None
        Me.tsListAreaTerritory.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsListAreaTerritory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsSelect, Me.ToolStripSeparator32})
        Me.tsListAreaTerritory.Location = New System.Drawing.Point(409, 360)
        Me.tsListAreaTerritory.Name = "tsListAreaTerritory"
        Me.tsListAreaTerritory.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsListAreaTerritory.Size = New System.Drawing.Size(57, 25)
        Me.tsListAreaTerritory.TabIndex = 90
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
        'tbSearchArea
        '
        Me.tbSearchArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchArea.Location = New System.Drawing.Point(14, 7)
        Me.tbSearchArea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbSearchArea.MaxLength = 50
        Me.tbSearchArea.Name = "tbSearchArea"
        Me.tbSearchArea.Size = New System.Drawing.Size(218, 22)
        Me.tbSearchArea.TabIndex = 89
        '
        'Column1
        '
        Me.Column1.HeaderText = "SELECT"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "AREA/TERRITORY NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 280
        '
        'Column3
        '
        Me.Column3.HeaderText = "CODE"
        Me.Column3.Name = "Column3"
        '
        'frmSearchArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 393)
        Me.Controls.Add(Me.dgvListAreaTerritory)
        Me.Controls.Add(Me.tsListAreaTerritory)
        Me.Controls.Add(Me.tbSearchArea)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchArea"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIST AREA/TERRITORY"
        CType(Me.dgvListAreaTerritory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsListAreaTerritory.ResumeLayout(False)
        Me.tsListAreaTerritory.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListAreaTerritory As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsListAreaTerritory As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator32 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbSearchArea As System.Windows.Forms.TextBox
End Class
