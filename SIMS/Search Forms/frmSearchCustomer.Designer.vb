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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchCustomer))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgCustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgCheckbox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripSeparator32 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSelect = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsListCustomer = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.txtSearchCustomer = New System.Windows.Forms.TextBox()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCustomerList = New System.Windows.Forms.DataGridView()
        Me.txtCustCode = New System.Windows.Forms.TextBox()
        Me.txtCustomername = New System.Windows.Forms.TextBox()
        Me.tsListCustomer.SuspendLayout()
        CType(Me.dgvCustomerList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Delete
        '
        Me.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Delete.HeaderText = ""
        Me.Delete.Name = "Delete"
        Me.Delete.Visible = False
        '
        'Column18
        '
        Me.Column18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column18.HeaderText = "PKNO"
        Me.Column18.Name = "Column18"
        Me.Column18.Visible = False
        '
        'Column17
        '
        Me.Column17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column17.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column17.HeaderText = "ACTIVE"
        Me.Column17.Name = "Column17"
        Me.Column17.Visible = False
        '
        'Column16
        '
        Me.Column16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column16.HeaderText = "ALLOWPCT"
        Me.Column16.Name = "Column16"
        Me.Column16.Visible = False
        '
        'Column15
        '
        Me.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column15.HeaderText = "SPDISC"
        Me.Column15.Name = "Column15"
        Me.Column15.Visible = False
        '
        'Column14
        '
        Me.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column14.HeaderText = "CREDITLIMIT"
        Me.Column14.Name = "Column14"
        Me.Column14.Visible = False
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column13.HeaderText = "PAYTERMS"
        Me.Column13.Name = "Column13"
        Me.Column13.Visible = False
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column12.HeaderText = "TELNO"
        Me.Column12.Name = "Column12"
        Me.Column12.Visible = False
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column11.HeaderText = "MOBILENO"
        Me.Column11.Name = "Column11"
        Me.Column11.Visible = False
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "TINNO"
        Me.Column10.Name = "Column10"
        Me.Column10.Visible = False
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "MAINP"
        Me.Column9.Name = "Column9"
        Me.Column9.Visible = False
        '
        'Column23
        '
        Me.Column23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column23.HeaderText = "MAINCODE"
        Me.Column23.Name = "Column23"
        Me.Column23.Visible = False
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "PROVINCE"
        Me.Column8.Name = "Column8"
        Me.Column8.Visible = False
        '
        'Column22
        '
        Me.Column22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column22.HeaderText = "PROVCODE"
        Me.Column22.Name = "Column22"
        Me.Column22.Visible = False
        '
        'Edit
        '
        Me.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Edit.HeaderText = ""
        Me.Edit.Name = "Edit"
        Me.Edit.Visible = False
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "OUTLET-TYPE"
        Me.Column7.Name = "Column7"
        Me.Column7.Visible = False
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "AREA/TERRITORY"
        Me.Column6.Name = "Column6"
        Me.Column6.Visible = False
        '
        'Column20
        '
        Me.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column20.HeaderText = "AREACODE"
        Me.Column20.Name = "Column20"
        Me.Column20.Visible = False
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "SHIPTO"
        Me.Column5.Name = "Column5"
        Me.Column5.Visible = False
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "ADDRESS"
        Me.Column4.Name = "Column4"
        '
        'dgCustomerName
        '
        Me.dgCustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgCustomerName.HeaderText = "CUSTOMER-NAME"
        Me.dgCustomerName.Name = "dgCustomerName"
        Me.dgCustomerName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCustomerName.Width = 150
        '
        'dgCode
        '
        Me.dgCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgCode.HeaderText = "CODE"
        Me.dgCode.Name = "dgCode"
        Me.dgCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCode.Width = 71
        '
        'dgCheckbox
        '
        Me.dgCheckbox.HeaderText = ""
        Me.dgCheckbox.Name = "dgCheckbox"
        Me.dgCheckbox.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCheckbox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgCheckbox.Width = 45
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'ToolStripSeparator32
        '
        Me.ToolStripSeparator32.Name = "ToolStripSeparator32"
        Me.ToolStripSeparator32.Size = New System.Drawing.Size(6, 27)
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
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 27)
        '
        'tsListCustomer
        '
        Me.tsListCustomer.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsListCustomer.Dock = System.Windows.Forms.DockStyle.None
        Me.tsListCustomer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsListCustomer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.btnSelect, Me.ToolStripSeparator32, Me.ToolStripButton1})
        Me.tsListCustomer.Location = New System.Drawing.Point(12, 385)
        Me.tsListCustomer.Name = "tsListCustomer"
        Me.tsListCustomer.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsListCustomer.Size = New System.Drawing.Size(91, 27)
        Me.tsListCustomer.TabIndex = 88
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'txtSearchCustomer
        '
        Me.txtSearchCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearchCustomer.Location = New System.Drawing.Point(12, 3)
        Me.txtSearchCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearchCustomer.MaxLength = 50
        Me.txtSearchCustomer.Name = "txtSearchCustomer"
        Me.txtSearchCustomer.Size = New System.Drawing.Size(190, 26)
        Me.txtSearchCustomer.TabIndex = 87
        '
        'Column21
        '
        Me.Column21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column21.HeaderText = "OUTLETCODE"
        Me.Column21.Name = "Column21"
        Me.Column21.Visible = False
        '
        'dgvCustomerList
        '
        Me.dgvCustomerList.AllowUserToAddRows = False
        Me.dgvCustomerList.AllowUserToDeleteRows = False
        Me.dgvCustomerList.AllowUserToResizeRows = False
        Me.dgvCustomerList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.dgCheckbox, Me.dgCode, Me.dgCustomerName, Me.Column4, Me.Column5, Me.Column20, Me.Column6, Me.Column21, Me.Column7, Me.Column22, Me.Column8, Me.Column23, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Edit, Me.Delete})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCustomerList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCustomerList.Location = New System.Drawing.Point(12, 29)
        Me.dgvCustomerList.Name = "dgvCustomerList"
        Me.dgvCustomerList.RowHeadersVisible = False
        Me.dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomerList.Size = New System.Drawing.Size(686, 353)
        Me.dgvCustomerList.TabIndex = 89
        '
        'txtCustCode
        '
        Me.txtCustCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCustCode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtCustCode.Location = New System.Drawing.Point(181, 444)
        Me.txtCustCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCustCode.MaxLength = 50
        Me.txtCustCode.Name = "txtCustCode"
        Me.txtCustCode.Size = New System.Drawing.Size(229, 26)
        Me.txtCustCode.TabIndex = 278
        '
        'txtCustomername
        '
        Me.txtCustomername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCustomername.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtCustomername.Location = New System.Drawing.Point(416, 446)
        Me.txtCustomername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCustomername.MaxLength = 50
        Me.txtCustomername.Name = "txtCustomername"
        Me.txtCustomername.ReadOnly = True
        Me.txtCustomername.Size = New System.Drawing.Size(359, 26)
        Me.txtCustomername.TabIndex = 283
        '
        'frmSearchCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(711, 415)
        Me.Controls.Add(Me.txtCustomername)
        Me.Controls.Add(Me.txtCustCode)
        Me.Controls.Add(Me.tsListCustomer)
        Me.Controls.Add(Me.txtSearchCustomer)
        Me.Controls.Add(Me.dgvCustomerList)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchCustomer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUSTOMER LIST"
        Me.tsListCustomer.ResumeLayout(False)
        Me.tsListCustomer.PerformLayout()
        CType(Me.dgvCustomerList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Delete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Edit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgCustomerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgCheckbox As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator32 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsListCustomer As System.Windows.Forms.ToolStrip
    Friend WithEvents txtSearchCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Column21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvCustomerList As System.Windows.Forms.DataGridView
    Friend WithEvents txtCustCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomername As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
