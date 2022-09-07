<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchSalesmanInv
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchSalesmanInv))
        Me.dgvListSalesman = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgCheckbox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgSalesmanName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsMenu1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSelect = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator32 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtSearchSlsman = New System.Windows.Forms.TextBox()
        Me.btnCloseSalesman = New System.Windows.Forms.Button()
        Me.txtSalesmanName = New System.Windows.Forms.TextBox()
        Me.txtSlmncode = New System.Windows.Forms.TextBox()
        CType(Me.dgvListSalesman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListSalesman
        '
        Me.dgvListSalesman.AllowUserToAddRows = False
        Me.dgvListSalesman.AllowUserToDeleteRows = False
        Me.dgvListSalesman.AllowUserToResizeRows = False
        Me.dgvListSalesman.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListSalesman.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListSalesman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListSalesman.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.dgCheckbox, Me.dgCode, Me.dgSalesmanName, Me.Column4, Me.Column6, Me.Column5, Me.Column7})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListSalesman.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListSalesman.Location = New System.Drawing.Point(12, 37)
        Me.dgvListSalesman.Name = "dgvListSalesman"
        Me.dgvListSalesman.RowHeadersVisible = False
        Me.dgvListSalesman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListSalesman.Size = New System.Drawing.Size(586, 197)
        Me.dgvListSalesman.TabIndex = 88
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column1.Visible = False
        '
        'dgCheckbox
        '
        Me.dgCheckbox.HeaderText = ""
        Me.dgCheckbox.Name = "dgCheckbox"
        Me.dgCheckbox.Width = 30
        '
        'dgCode
        '
        Me.dgCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgCode.HeaderText = "CODE"
        Me.dgCode.Name = "dgCode"
        Me.dgCode.Width = 71
        '
        'dgSalesmanName
        '
        Me.dgSalesmanName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgSalesmanName.HeaderText = "SALESMAN NAME"
        Me.dgSalesmanName.Name = "dgSalesmanName"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "WHSCODE"
        Me.Column4.Name = "Column4"
        Me.Column4.Visible = False
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "WAREHOUSE"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 115
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "OPERCODE"
        Me.Column5.Name = "Column5"
        Me.Column5.Visible = False
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "TYPE-OPER"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 104
        '
        'tsMenu1
        '
        Me.tsMenu1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsMenu1.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMenu1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.btnSelect, Me.ToolStripSeparator32})
        Me.tsMenu1.Location = New System.Drawing.Point(12, 239)
        Me.tsMenu1.Name = "tsMenu1"
        Me.tsMenu1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsMenu1.Size = New System.Drawing.Size(68, 27)
        Me.tsMenu1.TabIndex = 90
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 27)
        '
        'btnSelect
        '
        Me.btnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSelect.Image = CType(resources.GetObject("btnSelect.Image"), System.Drawing.Image)
        Me.btnSelect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(53, 24)
        Me.btnSelect.Text = "&Select"
        '
        'ToolStripSeparator32
        '
        Me.ToolStripSeparator32.Name = "ToolStripSeparator32"
        Me.ToolStripSeparator32.Size = New System.Drawing.Size(6, 27)
        '
        'txtSearchSlsman
        '
        Me.txtSearchSlsman.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearchSlsman.Location = New System.Drawing.Point(12, 11)
        Me.txtSearchSlsman.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearchSlsman.MaxLength = 50
        Me.txtSearchSlsman.Name = "txtSearchSlsman"
        Me.txtSearchSlsman.Size = New System.Drawing.Size(178, 26)
        Me.txtSearchSlsman.TabIndex = 89
        '
        'btnCloseSalesman
        '
        Me.btnCloseSalesman.Location = New System.Drawing.Point(615, 69)
        Me.btnCloseSalesman.Name = "btnCloseSalesman"
        Me.btnCloseSalesman.Size = New System.Drawing.Size(75, 23)
        Me.btnCloseSalesman.TabIndex = 91
        Me.btnCloseSalesman.Text = "Close"
        Me.btnCloseSalesman.UseVisualStyleBackColor = True
        '
        'txtSalesmanName
        '
        Me.txtSalesmanName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSalesmanName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtSalesmanName.Location = New System.Drawing.Point(352, 312)
        Me.txtSalesmanName.MaxLength = 50
        Me.txtSalesmanName.Name = "txtSalesmanName"
        Me.txtSalesmanName.ReadOnly = True
        Me.txtSalesmanName.Size = New System.Drawing.Size(225, 26)
        Me.txtSalesmanName.TabIndex = 243
        '
        'txtSlmncode
        '
        Me.txtSlmncode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSlmncode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtSlmncode.Location = New System.Drawing.Point(107, 312)
        Me.txtSlmncode.MaxLength = 50
        Me.txtSlmncode.Name = "txtSlmncode"
        Me.txtSlmncode.Size = New System.Drawing.Size(241, 26)
        Me.txtSlmncode.TabIndex = 242
        '
        'frmSearchSalesmanInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(604, 269)
        Me.Controls.Add(Me.dgvListSalesman)
        Me.Controls.Add(Me.txtSalesmanName)
        Me.Controls.Add(Me.txtSlmncode)
        Me.Controls.Add(Me.tsMenu1)
        Me.Controls.Add(Me.txtSearchSlsman)
        Me.Controls.Add(Me.btnCloseSalesman)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(372, 182)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchSalesmanInv"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SALESMAN LIST"
        CType(Me.dgvListSalesman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenu1.ResumeLayout(False)
        Me.tsMenu1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListSalesman As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgCheckbox As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents dgCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgSalesmanName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsMenu1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator32 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtSearchSlsman As System.Windows.Forms.TextBox
    Friend WithEvents btnCloseSalesman As System.Windows.Forms.Button
    Friend WithEvents txtSalesmanName As System.Windows.Forms.TextBox
    Friend WithEvents txtSlmncode As System.Windows.Forms.TextBox
End Class
