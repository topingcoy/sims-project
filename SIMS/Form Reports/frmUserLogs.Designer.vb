<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserLogs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserLogs))
        Me.dgvUserLogs = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxFromWhs = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.tsUserLogs = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.Go = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintUserLogs = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.chkAllTrans = New System.Windows.Forms.CheckBox()
        CType(Me.dgvUserLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsUserLogs.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvUserLogs
        '
        Me.dgvUserLogs.AllowUserToAddRows = False
        Me.dgvUserLogs.AllowUserToDeleteRows = False
        Me.dgvUserLogs.AllowUserToResizeRows = False
        Me.dgvUserLogs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvUserLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserLogs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvUserLogs.Location = New System.Drawing.Point(12, 33)
        Me.dgvUserLogs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvUserLogs.Name = "dgvUserLogs"
        Me.dgvUserLogs.ReadOnly = True
        Me.dgvUserLogs.RowHeadersVisible = False
        Me.dgvUserLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUserLogs.Size = New System.Drawing.Size(905, 492)
        Me.dgvUserLogs.TabIndex = 60
        '
        'Column1
        '
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "USER NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 130
        '
        'Column3
        '
        Me.Column3.HeaderText = "TRANSACTIONS"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 350
        '
        'Column4
        '
        Me.Column4.HeaderText = "MODULE"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "DATE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "TIME"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "User :"
        '
        'cbxFromWhs
        '
        Me.cbxFromWhs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxFromWhs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFromWhs.FormattingEnabled = True
        Me.cbxFromWhs.Location = New System.Drawing.Point(226, 7)
        Me.cbxFromWhs.Name = "cbxFromWhs"
        Me.cbxFromWhs.Size = New System.Drawing.Size(226, 21)
        Me.cbxFromWhs.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(458, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Transactions :"
        '
        'ComboBox1
        '
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(541, 7)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(226, 21)
        Me.ComboBox1.TabIndex = 81
        '
        'tsUserLogs
        '
        Me.tsUserLogs.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsUserLogs.Dock = System.Windows.Forms.DockStyle.None
        Me.tsUserLogs.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsUserLogs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.Go, Me.ToolStripSeparator33, Me.PrintUserLogs, Me.ToolStripSeparator34})
        Me.tsUserLogs.Location = New System.Drawing.Point(788, 3)
        Me.tsUserLogs.Name = "tsUserLogs"
        Me.tsUserLogs.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsUserLogs.Size = New System.Drawing.Size(129, 25)
        Me.tsUserLogs.TabIndex = 208
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'Go
        '
        Me.Go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Go.Image = CType(resources.GetObject("Go.Image"), System.Drawing.Image)
        Me.Go.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Go.Name = "Go"
        Me.Go.Size = New System.Drawing.Size(28, 22)
        Me.Go.Text = "&GO"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'PrintUserLogs
        '
        Me.PrintUserLogs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PrintUserLogs.Image = CType(resources.GetObject("PrintUserLogs.Image"), System.Drawing.Image)
        Me.PrintUserLogs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintUserLogs.Name = "PrintUserLogs"
        Me.PrintUserLogs.Size = New System.Drawing.Size(80, 22)
        Me.PrintUserLogs.Text = "Print Preview"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'chkAllTrans
        '
        Me.chkAllTrans.AutoSize = True
        Me.chkAllTrans.Location = New System.Drawing.Point(14, 10)
        Me.chkAllTrans.Name = "chkAllTrans"
        Me.chkAllTrans.Size = New System.Drawing.Size(106, 17)
        Me.chkAllTrans.TabIndex = 209
        Me.chkAllTrans.Text = "All Transactions"
        Me.chkAllTrans.UseVisualStyleBackColor = True
        '
        'frmUserLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 536)
        Me.Controls.Add(Me.chkAllTrans)
        Me.Controls.Add(Me.tsUserLogs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxFromWhs)
        Me.Controls.Add(Me.dgvUserLogs)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserLogs"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USER ACTIVITY LOGS"
        CType(Me.dgvUserLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsUserLogs.ResumeLayout(False)
        Me.tsUserLogs.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvUserLogs As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxFromWhs As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents tsUserLogs As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Go As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintUserLogs As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkAllTrans As System.Windows.Forms.CheckBox
End Class
