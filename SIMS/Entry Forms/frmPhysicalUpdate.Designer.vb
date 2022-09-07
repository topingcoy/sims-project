<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhysicalUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhysicalUpdate))
        Me.dgvUpdate = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkup = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.tsproll = New System.Windows.Forms.ToolStrip()
        Me.tsrupdate_all = New System.Windows.Forms.ToolStripButton()
        Me.chkalltrans = New System.Windows.Forms.CheckBox()
        CType(Me.dgvUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsproll.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvUpdate
        '
        Me.dgvUpdate.AllowUserToAddRows = False
        Me.dgvUpdate.AllowUserToDeleteRows = False
        Me.dgvUpdate.AllowUserToResizeRows = False
        Me.dgvUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUpdate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.chkup, Me.Column3, Me.Column7, Me.Column4, Me.Column5, Me.Column6, Me.Column2})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUpdate.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvUpdate.Location = New System.Drawing.Point(12, 26)
        Me.dgvUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvUpdate.Name = "dgvUpdate"
        Me.dgvUpdate.RowHeadersVisible = False
        Me.dgvUpdate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUpdate.Size = New System.Drawing.Size(601, 371)
        Me.dgvUpdate.TabIndex = 63
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'chkup
        '
        Me.chkup.HeaderText = " "
        Me.chkup.Name = "chkup"
        Me.chkup.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.chkup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.chkup.Width = 30
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "TRANS-NO"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 87
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "WHS"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 57
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "WAREHOUSE NAME"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column5.HeaderText = "DATE"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 58
        '
        'Column6
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column6.HeaderText = "UPDATED?"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 63
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 5
        '
        'tsproll
        '
        Me.tsproll.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsproll.AutoSize = False
        Me.tsproll.Dock = System.Windows.Forms.DockStyle.None
        Me.tsproll.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsrupdate_all})
        Me.tsproll.Location = New System.Drawing.Point(12, 407)
        Me.tsproll.Name = "tsproll"
        Me.tsproll.Size = New System.Drawing.Size(601, 30)
        Me.tsproll.TabIndex = 64
        Me.tsproll.Text = "ToolStrip1"
        '
        'tsrupdate_all
        '
        Me.tsrupdate_all.AutoSize = False
        Me.tsrupdate_all.Image = CType(resources.GetObject("tsrupdate_all.Image"), System.Drawing.Image)
        Me.tsrupdate_all.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsrupdate_all.Name = "tsrupdate_all"
        Me.tsrupdate_all.Size = New System.Drawing.Size(100, 29)
        Me.tsrupdate_all.Text = "Update all"
        '
        'chkalltrans
        '
        Me.chkalltrans.AutoSize = True
        Me.chkalltrans.Location = New System.Drawing.Point(12, 4)
        Me.chkalltrans.Name = "chkalltrans"
        Me.chkalltrans.Size = New System.Drawing.Size(138, 17)
        Me.chkalltrans.TabIndex = 65
        Me.chkalltrans.Text = "Check all transactions"
        Me.chkalltrans.UseVisualStyleBackColor = True
        '
        'frmPhysicalUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 446)
        Me.Controls.Add(Me.chkalltrans)
        Me.Controls.Add(Me.tsproll)
        Me.Controls.Add(Me.dgvUpdate)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPhysicalUpdate"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UPDATE TO ACTUAL INVENTORY"
        CType(Me.dgvUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsproll.ResumeLayout(False)
        Me.tsproll.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvUpdate As System.Windows.Forms.DataGridView
    Friend WithEvents tsproll As System.Windows.Forms.ToolStrip
    Friend WithEvents tsrupdate_all As System.Windows.Forms.ToolStripButton
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkup As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents chkalltrans As System.Windows.Forms.CheckBox
End Class
