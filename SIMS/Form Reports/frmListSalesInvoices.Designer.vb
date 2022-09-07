<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListSalesInvoices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListSalesInvoices))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpListInvoiceEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpListInvoiceStart = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSalesman = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbWhs = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbCustomer = New System.Windows.Forms.TextBox()
        Me.cbxItemDetails = New System.Windows.Forms.CheckBox()
        Me.dgvInvoiceList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsListInvoice = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.Go = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintListInvoice = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.cbxSortSalesman = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        CType(Me.dgvInvoiceList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsListInvoice.SuspendLayout()
        Me.gbOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Stating Date :"
        '
        'dtpListInvoiceEnd
        '
        Me.dtpListInvoiceEnd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpListInvoiceEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpListInvoiceEnd.Location = New System.Drawing.Point(333, 8)
        Me.dtpListInvoiceEnd.Name = "dtpListInvoiceEnd"
        Me.dtpListInvoiceEnd.Size = New System.Drawing.Size(93, 22)
        Me.dtpListInvoiceEnd.TabIndex = 55
        '
        'dtpListInvoiceStart
        '
        Me.dtpListInvoiceStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpListInvoiceStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpListInvoiceStart.Location = New System.Drawing.Point(152, 9)
        Me.dtpListInvoiceStart.Name = "dtpListInvoiceStart"
        Me.dtpListInvoiceStart.Size = New System.Drawing.Size(93, 22)
        Me.dtpListInvoiceStart.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Ending Date :"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(252, 35)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(316, 22)
        Me.lblCustomerName.TabIndex = 126
        Me.lblCustomerName.Text = "SALESMAN NAME"
        Me.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCustomerName.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Salesman [Blank = All] :"
        '
        'tbSalesman
        '
        Me.tbSalesman.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSalesman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSalesman.Location = New System.Drawing.Point(153, 35)
        Me.tbSalesman.MaxLength = 50
        Me.tbSalesman.Name = "tbSalesman"
        Me.tbSalesman.Size = New System.Drawing.Size(92, 22)
        Me.tbSalesman.TabIndex = 124
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(252, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(316, 22)
        Me.Label4.TabIndex = 129
        Me.Label4.Text = "WAREHOUSE NAME"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 13)
        Me.Label5.TabIndex = 128
        Me.Label5.Text = "Warehouse [Blank = All] :"
        '
        'tbWhs
        '
        Me.tbWhs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbWhs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbWhs.Location = New System.Drawing.Point(153, 60)
        Me.tbWhs.MaxLength = 50
        Me.tbWhs.Name = "tbWhs"
        Me.tbWhs.Size = New System.Drawing.Size(92, 22)
        Me.tbWhs.TabIndex = 127
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(252, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(316, 22)
        Me.Label6.TabIndex = 132
        Me.Label6.Text = "CUSTOMER NAME"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 13)
        Me.Label7.TabIndex = 131
        Me.Label7.Text = "Customer [Blank = All] :"
        '
        'tbCustomer
        '
        Me.tbCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbCustomer.Location = New System.Drawing.Point(153, 86)
        Me.tbCustomer.MaxLength = 50
        Me.tbCustomer.Name = "tbCustomer"
        Me.tbCustomer.Size = New System.Drawing.Size(92, 22)
        Me.tbCustomer.TabIndex = 130
        '
        'cbxItemDetails
        '
        Me.cbxItemDetails.AutoSize = True
        Me.cbxItemDetails.Location = New System.Drawing.Point(60, 14)
        Me.cbxItemDetails.Name = "cbxItemDetails"
        Me.cbxItemDetails.Size = New System.Drawing.Size(132, 17)
        Me.cbxItemDetails.TabIndex = 133
        Me.cbxItemDetails.Text = "Include Item Details?"
        Me.cbxItemDetails.UseVisualStyleBackColor = True
        '
        'dgvInvoiceList
        '
        Me.dgvInvoiceList.AllowUserToAddRows = False
        Me.dgvInvoiceList.AllowUserToResizeRows = False
        Me.dgvInvoiceList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoiceList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgvInvoiceList.Location = New System.Drawing.Point(13, 116)
        Me.dgvInvoiceList.Name = "dgvInvoiceList"
        Me.dgvInvoiceList.RowHeadersVisible = False
        Me.dgvInvoiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInvoiceList.Size = New System.Drawing.Size(1122, 496)
        Me.dgvInvoiceList.TabIndex = 134
        '
        'Column1
        '
        Me.Column1.HeaderText = "DOC-NO"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "DATE"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "SALESMAN"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "CUSTOMER NAME"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 300
        '
        'Column5
        '
        Me.Column5.HeaderText = "GROSS AMT"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "DISCOUNT"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "NET AMT"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "SP DISC"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "NET INV AMT"
        Me.Column9.Name = "Column9"
        '
        'tsListInvoice
        '
        Me.tsListInvoice.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsListInvoice.Dock = System.Windows.Forms.DockStyle.None
        Me.tsListInvoice.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsListInvoice.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.Go, Me.ToolStripSeparator33, Me.PrintListInvoice, Me.ToolStripSeparator34})
        Me.tsListInvoice.Location = New System.Drawing.Point(1003, 7)
        Me.tsListInvoice.Name = "tsListInvoice"
        Me.tsListInvoice.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsListInvoice.Size = New System.Drawing.Size(129, 25)
        Me.tsListInvoice.TabIndex = 135
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
        'PrintListInvoice
        '
        Me.PrintListInvoice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PrintListInvoice.Image = CType(resources.GetObject("PrintListInvoice.Image"), System.Drawing.Image)
        Me.PrintListInvoice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintListInvoice.Name = "PrintListInvoice"
        Me.PrintListInvoice.Size = New System.Drawing.Size(80, 22)
        Me.PrintListInvoice.Text = "Print Preview"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'cbxSortSalesman
        '
        Me.cbxSortSalesman.AutoSize = True
        Me.cbxSortSalesman.Location = New System.Drawing.Point(60, 35)
        Me.cbxSortSalesman.Name = "cbxSortSalesman"
        Me.cbxSortSalesman.Size = New System.Drawing.Size(113, 17)
        Me.cbxSortSalesman.TabIndex = 136
        Me.cbxSortSalesman.Text = "Sort by Salesman"
        Me.cbxSortSalesman.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(60, 58)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(124, 17)
        Me.CheckBox1.TabIndex = 137
        Me.CheckBox1.Text = "Sort by Warehouse"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(60, 81)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(114, 17)
        Me.CheckBox2.TabIndex = 138
        Me.CheckBox2.Text = "Sort by Customer"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.cbxItemDetails)
        Me.gbOptions.Controls.Add(Me.CheckBox2)
        Me.gbOptions.Controls.Add(Me.cbxSortSalesman)
        Me.gbOptions.Controls.Add(Me.CheckBox1)
        Me.gbOptions.Location = New System.Drawing.Point(665, 8)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(214, 100)
        Me.gbOptions.TabIndex = 139
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = "Options"
        '
        'frmListSalesInvoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 623)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.tsListInvoice)
        Me.Controls.Add(Me.dgvInvoiceList)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbCustomer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbWhs)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbSalesman)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpListInvoiceEnd)
        Me.Controls.Add(Me.dtpListInvoiceStart)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListSalesInvoices"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIST OF SALES INVOICES"
        CType(Me.dgvInvoiceList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsListInvoice.ResumeLayout(False)
        Me.tsListInvoice.PerformLayout()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpListInvoiceEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpListInvoiceStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbSalesman As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbWhs As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbCustomer As System.Windows.Forms.TextBox
    Friend WithEvents cbxItemDetails As System.Windows.Forms.CheckBox
    Friend WithEvents dgvInvoiceList As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsListInvoice As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Go As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintListInvoice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cbxSortSalesman As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents gbOptions As System.Windows.Forms.GroupBox
End Class
