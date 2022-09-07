<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListDeletedInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListDeletedInvoice))
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.cbxItemDetails = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.cbxSortSalesman = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrinDeletedInvoice = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.Go = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDeletedInvoice = New System.Windows.Forms.ToolStrip()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvListDeletedInvoice = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbCustomer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbWhs = New System.Windows.Forms.TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSalesman = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDeletedInvoiceEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpDeletedInvoiceStart = New System.Windows.Forms.DateTimePicker()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.gbOptions.SuspendLayout()
        Me.tsDeletedInvoice.SuspendLayout()
        CType(Me.dgvListDeletedInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.cbxItemDetails)
        Me.gbOptions.Controls.Add(Me.CheckBox2)
        Me.gbOptions.Controls.Add(Me.cbxSortSalesman)
        Me.gbOptions.Controls.Add(Me.CheckBox1)
        Me.gbOptions.Location = New System.Drawing.Point(668, 12)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(214, 100)
        Me.gbOptions.TabIndex = 155
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = "Options"
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
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'PrinDeletedInvoice
        '
        Me.PrinDeletedInvoice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PrinDeletedInvoice.Image = CType(resources.GetObject("PrinDeletedInvoice.Image"), System.Drawing.Image)
        Me.PrinDeletedInvoice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrinDeletedInvoice.Name = "PrinDeletedInvoice"
        Me.PrinDeletedInvoice.Size = New System.Drawing.Size(80, 22)
        Me.PrinDeletedInvoice.Text = "Print Preview"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'tsDeletedInvoice
        '
        Me.tsDeletedInvoice.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsDeletedInvoice.Dock = System.Windows.Forms.DockStyle.None
        Me.tsDeletedInvoice.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsDeletedInvoice.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.Go, Me.ToolStripSeparator33, Me.PrinDeletedInvoice, Me.ToolStripSeparator34})
        Me.tsDeletedInvoice.Location = New System.Drawing.Point(1006, 11)
        Me.tsDeletedInvoice.Name = "tsDeletedInvoice"
        Me.tsDeletedInvoice.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsDeletedInvoice.Size = New System.Drawing.Size(129, 25)
        Me.tsDeletedInvoice.TabIndex = 154
        '
        'Column9
        '
        Me.Column9.HeaderText = "NET INV AMT"
        Me.Column9.Name = "Column9"
        '
        'Column8
        '
        Me.Column8.HeaderText = "SP DISC"
        Me.Column8.Name = "Column8"
        '
        'Column7
        '
        Me.Column7.HeaderText = "NET AMT"
        Me.Column7.Name = "Column7"
        '
        'Column6
        '
        Me.Column6.HeaderText = "DISCOUNT"
        Me.Column6.Name = "Column6"
        '
        'Column5
        '
        Me.Column5.HeaderText = "GROSS AMT"
        Me.Column5.Name = "Column5"
        '
        'Column4
        '
        Me.Column4.HeaderText = "CUSTOMER NAME"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 300
        '
        'Column3
        '
        Me.Column3.HeaderText = "SALESMAN"
        Me.Column3.Name = "Column3"
        '
        'Column2
        '
        Me.Column2.HeaderText = "DATE"
        Me.Column2.Name = "Column2"
        '
        'dgvListDeletedInvoice
        '
        Me.dgvListDeletedInvoice.AllowUserToAddRows = False
        Me.dgvListDeletedInvoice.AllowUserToResizeRows = False
        Me.dgvListDeletedInvoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListDeletedInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListDeletedInvoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgvListDeletedInvoice.Location = New System.Drawing.Point(16, 120)
        Me.dgvListDeletedInvoice.Name = "dgvListDeletedInvoice"
        Me.dgvListDeletedInvoice.RowHeadersVisible = False
        Me.dgvListDeletedInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListDeletedInvoice.Size = New System.Drawing.Size(1122, 496)
        Me.dgvListDeletedInvoice.TabIndex = 153
        '
        'Column1
        '
        Me.Column1.HeaderText = "DOC-NO"
        Me.Column1.Name = "Column1"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(255, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(316, 22)
        Me.Label6.TabIndex = 152
        Me.Label6.Text = "CUSTOMER NAME"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 13)
        Me.Label7.TabIndex = 151
        Me.Label7.Text = "Customer [Blank = All] :"
        '
        'tbCustomer
        '
        Me.tbCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbCustomer.Location = New System.Drawing.Point(156, 90)
        Me.tbCustomer.MaxLength = 10
        Me.tbCustomer.Name = "tbCustomer"
        Me.tbCustomer.Size = New System.Drawing.Size(92, 22)
        Me.tbCustomer.TabIndex = 150
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(255, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(316, 22)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "WAREHOUSE NAME"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 13)
        Me.Label5.TabIndex = 148
        Me.Label5.Text = "Warehouse [Blank = All] :"
        '
        'tbWhs
        '
        Me.tbWhs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbWhs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbWhs.Location = New System.Drawing.Point(156, 64)
        Me.tbWhs.MaxLength = 10
        Me.tbWhs.Name = "tbWhs"
        Me.tbWhs.Size = New System.Drawing.Size(92, 22)
        Me.tbWhs.TabIndex = 147
        '
        'lblCustomerName
        '
        Me.lblCustomerName.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(255, 39)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(316, 22)
        Me.lblCustomerName.TabIndex = 146
        Me.lblCustomerName.Text = "SALESMAN NAME"
        Me.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCustomerName.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "Salesman [Blank = All] :"
        '
        'tbSalesman
        '
        Me.tbSalesman.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSalesman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSalesman.Location = New System.Drawing.Point(156, 39)
        Me.tbSalesman.MaxLength = 10
        Me.tbSalesman.Name = "tbSalesman"
        Me.tbSalesman.Size = New System.Drawing.Size(92, 22)
        Me.tbSalesman.TabIndex = 144
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(254, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "Ending Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "Stating Date :"
        '
        'dtpDeletedInvoiceEnd
        '
        Me.dtpDeletedInvoiceEnd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpDeletedInvoiceEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDeletedInvoiceEnd.Location = New System.Drawing.Point(336, 12)
        Me.dtpDeletedInvoiceEnd.Name = "dtpDeletedInvoiceEnd"
        Me.dtpDeletedInvoiceEnd.Size = New System.Drawing.Size(93, 22)
        Me.dtpDeletedInvoiceEnd.TabIndex = 141
        '
        'dtpDeletedInvoiceStart
        '
        Me.dtpDeletedInvoiceStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpDeletedInvoiceStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDeletedInvoiceStart.Location = New System.Drawing.Point(155, 13)
        Me.dtpDeletedInvoiceStart.Name = "dtpDeletedInvoiceStart"
        Me.dtpDeletedInvoiceStart.Size = New System.Drawing.Size(93, 22)
        Me.dtpDeletedInvoiceStart.TabIndex = 140
        '
        'TextBox5
        '
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(1022, 622)
        Me.TextBox5.MaxLength = 50
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(92, 22)
        Me.TextBox5.TabIndex = 160
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox4
        '
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(924, 622)
        Me.TextBox4.MaxLength = 50
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(92, 22)
        Me.TextBox4.TabIndex = 159
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(826, 622)
        Me.TextBox3.MaxLength = 50
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(92, 22)
        Me.TextBox3.TabIndex = 158
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(728, 622)
        Me.TextBox2.MaxLength = 50
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(92, 22)
        Me.TextBox2.TabIndex = 157
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(630, 622)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(92, 22)
        Me.TextBox1.TabIndex = 156
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmListDeletedInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 646)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.tsDeletedInvoice)
        Me.Controls.Add(Me.dgvListDeletedInvoice)
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
        Me.Controls.Add(Me.dtpDeletedInvoiceEnd)
        Me.Controls.Add(Me.dtpDeletedInvoiceStart)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListDeletedInvoice"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIST OF DELETED SALES INVOICES"
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.tsDeletedInvoice.ResumeLayout(False)
        Me.tsDeletedInvoice.PerformLayout()
        CType(Me.dgvListDeletedInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbOptions As System.Windows.Forms.GroupBox
    Friend WithEvents cbxItemDetails As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents cbxSortSalesman As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrinDeletedInvoice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Go As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDeletedInvoice As System.Windows.Forms.ToolStrip
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvListDeletedInvoice As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbWhs As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbSalesman As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDeletedInvoiceEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDeletedInvoiceStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
