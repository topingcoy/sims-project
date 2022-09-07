<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListInvoicePerDay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListInvoicePerDay))
        Me.dgvInvoicePerDate = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSalesmanName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSalesman = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpListperInvoice1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpListperInvoice2 = New System.Windows.Forms.DateTimePicker()
        Me.tsListInvoicePerDay = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.Go = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintInvoicePerDay = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.dgvInvoicePerDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsListInvoicePerDay.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvInvoicePerDate
        '
        Me.dgvInvoicePerDate.AllowUserToAddRows = False
        Me.dgvInvoicePerDate.AllowUserToDeleteRows = False
        Me.dgvInvoicePerDate.AllowUserToResizeRows = False
        Me.dgvInvoicePerDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvInvoicePerDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoicePerDate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvInvoicePerDate.Location = New System.Drawing.Point(14, 60)
        Me.dgvInvoicePerDate.Name = "dgvInvoicePerDate"
        Me.dgvInvoicePerDate.ReadOnly = True
        Me.dgvInvoicePerDate.RowHeadersVisible = False
        Me.dgvInvoicePerDate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInvoicePerDate.Size = New System.Drawing.Size(1023, 555)
        Me.dgvInvoicePerDate.TabIndex = 170
        '
        'Column1
        '
        Me.Column1.HeaderText = "INVOICE-NO"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "DATE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "SALESMAN"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "CUSTOMER NAME"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 300
        '
        'Column5
        '
        Me.Column5.HeaderText = "ADDRESS"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 400
        '
        'lblSalesmanName
        '
        Me.lblSalesmanName.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesmanName.Location = New System.Drawing.Point(245, 33)
        Me.lblSalesmanName.Name = "lblSalesmanName"
        Me.lblSalesmanName.Size = New System.Drawing.Size(316, 22)
        Me.lblSalesmanName.TabIndex = 177
        Me.lblSalesmanName.Text = "SALESMAN NAME"
        Me.lblSalesmanName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSalesmanName.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 176
        Me.Label1.Text = "Salesman [Blank = All] :"
        '
        'tbSalesman
        '
        Me.tbSalesman.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSalesman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSalesman.Location = New System.Drawing.Point(146, 33)
        Me.tbSalesman.MaxLength = 50
        Me.tbSalesman.Name = "tbSalesman"
        Me.tbSalesman.Size = New System.Drawing.Size(92, 22)
        Me.tbSalesman.TabIndex = 175
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 174
        Me.Label3.Text = "Ending Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 173
        Me.Label2.Text = "Starting Date :"
        '
        'dtpListperInvoice1
        '
        Me.dtpListperInvoice1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpListperInvoice1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpListperInvoice1.Location = New System.Drawing.Point(145, 5)
        Me.dtpListperInvoice1.Name = "dtpListperInvoice1"
        Me.dtpListperInvoice1.Size = New System.Drawing.Size(93, 22)
        Me.dtpListperInvoice1.TabIndex = 171
        '
        'dtpListperInvoice2
        '
        Me.dtpListperInvoice2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpListperInvoice2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpListperInvoice2.Location = New System.Drawing.Point(323, 6)
        Me.dtpListperInvoice2.Name = "dtpListperInvoice2"
        Me.dtpListperInvoice2.Size = New System.Drawing.Size(93, 22)
        Me.dtpListperInvoice2.TabIndex = 172
        '
        'tsListInvoicePerDay
        '
        Me.tsListInvoicePerDay.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsListInvoicePerDay.Dock = System.Windows.Forms.DockStyle.None
        Me.tsListInvoicePerDay.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsListInvoicePerDay.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.Go, Me.ToolStripSeparator33, Me.PrintInvoicePerDay, Me.ToolStripSeparator34})
        Me.tsListInvoicePerDay.Location = New System.Drawing.Point(908, 9)
        Me.tsListInvoicePerDay.Name = "tsListInvoicePerDay"
        Me.tsListInvoicePerDay.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsListInvoicePerDay.Size = New System.Drawing.Size(160, 25)
        Me.tsListInvoicePerDay.TabIndex = 178
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
        'PrintInvoicePerDay
        '
        Me.PrintInvoicePerDay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PrintInvoicePerDay.Image = CType(resources.GetObject("PrintInvoicePerDay.Image"), System.Drawing.Image)
        Me.PrintInvoicePerDay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintInvoicePerDay.Name = "PrintInvoicePerDay"
        Me.PrintInvoicePerDay.Size = New System.Drawing.Size(80, 22)
        Me.PrintInvoicePerDay.Text = "Print Preview"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'frmListInvoicePerDay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 627)
        Me.Controls.Add(Me.tsListInvoicePerDay)
        Me.Controls.Add(Me.lblSalesmanName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbSalesman)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpListperInvoice1)
        Me.Controls.Add(Me.dtpListperInvoice2)
        Me.Controls.Add(Me.dgvInvoicePerDate)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListInvoicePerDay"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIST PER INVOICE PER DAY"
        CType(Me.dgvInvoicePerDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsListInvoicePerDay.ResumeLayout(False)
        Me.tsListInvoicePerDay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvInvoicePerDate As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblSalesmanName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbSalesman As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpListperInvoice1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpListperInvoice2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tsListInvoicePerDay As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Go As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintInvoicePerDay As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
End Class
