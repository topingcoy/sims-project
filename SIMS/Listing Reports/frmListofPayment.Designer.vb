<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListofPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListofPayment))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpListInvoiceEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpListInvoiceStart = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.cbxSortSalesman = New System.Windows.Forms.CheckBox()
        Me.dgvPayment = New System.Windows.Forms.DataGridView()
        Me.tsPaymentList = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.Go = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintPaymentList = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsPaymentList.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(195, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Ending Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Starting Date :"
        '
        'dtpListInvoiceEnd
        '
        Me.dtpListInvoiceEnd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpListInvoiceEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpListInvoiceEnd.Location = New System.Drawing.Point(276, 10)
        Me.dtpListInvoiceEnd.Name = "dtpListInvoiceEnd"
        Me.dtpListInvoiceEnd.Size = New System.Drawing.Size(93, 22)
        Me.dtpListInvoiceEnd.TabIndex = 61
        '
        'dtpListInvoiceStart
        '
        Me.dtpListInvoiceStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpListInvoiceStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpListInvoiceStart.Location = New System.Drawing.Point(99, 9)
        Me.dtpListInvoiceStart.Name = "dtpListInvoiceStart"
        Me.dtpListInvoiceStart.Size = New System.Drawing.Size(93, 22)
        Me.dtpListInvoiceStart.TabIndex = 60
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(728, 15)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(114, 17)
        Me.CheckBox2.TabIndex = 138
        Me.CheckBox2.Text = "Sort by Customer"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'cbxSortSalesman
        '
        Me.cbxSortSalesman.AutoSize = True
        Me.cbxSortSalesman.Location = New System.Drawing.Point(633, 15)
        Me.cbxSortSalesman.Name = "cbxSortSalesman"
        Me.cbxSortSalesman.Size = New System.Drawing.Size(89, 17)
        Me.cbxSortSalesman.TabIndex = 136
        Me.cbxSortSalesman.Text = "Sort by Date"
        Me.cbxSortSalesman.UseVisualStyleBackColor = True
        '
        'dgvPayment
        '
        Me.dgvPayment.AllowUserToAddRows = False
        Me.dgvPayment.AllowUserToResizeRows = False
        Me.dgvPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPayment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.dgvPayment.Location = New System.Drawing.Point(12, 38)
        Me.dgvPayment.Name = "dgvPayment"
        Me.dgvPayment.RowHeadersVisible = False
        Me.dgvPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPayment.Size = New System.Drawing.Size(1251, 465)
        Me.dgvPayment.TabIndex = 171
        '
        'tsPaymentList
        '
        Me.tsPaymentList.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsPaymentList.Dock = System.Windows.Forms.DockStyle.None
        Me.tsPaymentList.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsPaymentList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.Go, Me.ToolStripSeparator33, Me.PrintPaymentList, Me.ToolStripSeparator34})
        Me.tsPaymentList.Location = New System.Drawing.Point(1136, 9)
        Me.tsPaymentList.Name = "tsPaymentList"
        Me.tsPaymentList.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsPaymentList.Size = New System.Drawing.Size(129, 25)
        Me.tsPaymentList.TabIndex = 172
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
        'PrintPaymentList
        '
        Me.PrintPaymentList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PrintPaymentList.Image = CType(resources.GetObject("PrintPaymentList.Image"), System.Drawing.Image)
        Me.PrintPaymentList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPaymentList.Name = "PrintPaymentList"
        Me.PrintPaymentList.Size = New System.Drawing.Size(80, 22)
        Me.PrintPaymentList.Text = "Print Preview"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'Column1
        '
        Me.Column1.HeaderText = "DOC/OR NO"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "DATE"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 75
        '
        'Column3
        '
        Me.Column3.HeaderText = "CUSTOMER NAME"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 300
        '
        'Column4
        '
        Me.Column4.HeaderText = "AMOUNT"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.FillWeight = 120.0!
        Me.Column5.HeaderText = "PAID FOR: REF NO."
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "AMT PAID"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "BANK NAME"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "CHECK NO"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "CHECK DATE"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "CHECK AMT"
        Me.Column10.Name = "Column10"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(577, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "Option :"
        '
        'frmListofPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1279, 515)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.cbxSortSalesman)
        Me.Controls.Add(Me.tsPaymentList)
        Me.Controls.Add(Me.dgvPayment)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpListInvoiceEnd)
        Me.Controls.Add(Me.dtpListInvoiceStart)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListofPayment"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIST OF PAYMENT/COLLECTION"
        CType(Me.dgvPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsPaymentList.ResumeLayout(False)
        Me.tsPaymentList.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpListInvoiceEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpListInvoiceStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents cbxSortSalesman As System.Windows.Forms.CheckBox
    Friend WithEvents dgvPayment As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsPaymentList As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Go As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintPaymentList As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
