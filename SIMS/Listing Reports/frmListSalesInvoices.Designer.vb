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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtDisc2 = New System.Windows.Forms.TextBox()
        Me.txtGross = New System.Windows.Forms.TextBox()
        Me.txtDisc1 = New System.Windows.Forms.TextBox()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.chkSortCustomer = New System.Windows.Forms.CheckBox()
        Me.txtGrandTotal = New System.Windows.Forms.TextBox()
        Me.chkSortSalesman = New System.Windows.Forms.CheckBox()
        Me.pbar1 = New System.Windows.Forms.ProgressBar()
        Me.txtCustomername = New System.Windows.Forms.TextBox()
        Me.txtSalesmanName = New System.Windows.Forms.TextBox()
        Me.tsListInvoice = New System.Windows.Forms.ToolStrip()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCustCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSlmncode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sDate2 = New System.Windows.Forms.DateTimePicker()
        Me.sDate1 = New System.Windows.Forms.DateTimePicker()
        Me.chkSalesman = New System.Windows.Forms.CheckBox()
        Me.chkCustomer = New System.Windows.Forms.CheckBox()
        Me.netamnts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.disc2s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.disc1s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grsamnts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custnames = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salemans = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ddates = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invnos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trnos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvInvoiceList1 = New System.Windows.Forms.DataGridView()
        Me.tsListInvoice.SuspendLayout()
        Me.gbOptions.SuspendLayout()
        CType(Me.dgvInvoiceList1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDisc2
        '
        Me.txtDisc2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDisc2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtDisc2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisc2.Location = New System.Drawing.Point(206, 576)
        Me.txtDisc2.MaxLength = 50
        Me.txtDisc2.Name = "txtDisc2"
        Me.txtDisc2.ReadOnly = True
        Me.txtDisc2.Size = New System.Drawing.Size(91, 27)
        Me.txtDisc2.TabIndex = 248
        Me.txtDisc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGross
        '
        Me.txtGross.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGross.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtGross.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGross.Location = New System.Drawing.Point(20, 576)
        Me.txtGross.MaxLength = 50
        Me.txtGross.Name = "txtGross"
        Me.txtGross.ReadOnly = True
        Me.txtGross.Size = New System.Drawing.Size(90, 27)
        Me.txtGross.TabIndex = 247
        Me.txtGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDisc1
        '
        Me.txtDisc1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDisc1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtDisc1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisc1.Location = New System.Drawing.Point(112, 576)
        Me.txtDisc1.MaxLength = 50
        Me.txtDisc1.Name = "txtDisc1"
        Me.txtDisc1.ReadOnly = True
        Me.txtDisc1.Size = New System.Drawing.Size(91, 27)
        Me.txtDisc1.TabIndex = 246
        Me.txtDisc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 27)
        '
        'btnGo
        '
        Me.btnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnGo.Image = CType(resources.GetObject("btnGo.Image"), System.Drawing.Image)
        Me.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(32, 24)
        Me.btnGo.Text = "&Go"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 27)
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(43, 24)
        Me.btnPrint.Text = "&Print"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 27)
        '
        'chkSortCustomer
        '
        Me.chkSortCustomer.AutoSize = True
        Me.chkSortCustomer.Location = New System.Drawing.Point(6, 38)
        Me.chkSortCustomer.Name = "chkSortCustomer"
        Me.chkSortCustomer.Size = New System.Drawing.Size(139, 23)
        Me.chkSortCustomer.TabIndex = 138
        Me.chkSortCustomer.Text = "Sort by Customer"
        Me.chkSortCustomer.UseVisualStyleBackColor = True
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGrandTotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtGrandTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrandTotal.Location = New System.Drawing.Point(299, 576)
        Me.txtGrandTotal.MaxLength = 50
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.ReadOnly = True
        Me.txtGrandTotal.Size = New System.Drawing.Size(93, 27)
        Me.txtGrandTotal.TabIndex = 245
        Me.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkSortSalesman
        '
        Me.chkSortSalesman.AutoSize = True
        Me.chkSortSalesman.Location = New System.Drawing.Point(6, 21)
        Me.chkSortSalesman.Name = "chkSortSalesman"
        Me.chkSortSalesman.Size = New System.Drawing.Size(136, 23)
        Me.chkSortSalesman.TabIndex = 136
        Me.chkSortSalesman.Text = "Sort by Salesman"
        Me.chkSortSalesman.UseVisualStyleBackColor = True
        '
        'pbar1
        '
        Me.pbar1.Location = New System.Drawing.Point(14, 551)
        Me.pbar1.Name = "pbar1"
        Me.pbar1.Size = New System.Drawing.Size(955, 5)
        Me.pbar1.TabIndex = 244
        Me.pbar1.Visible = False
        '
        'txtCustomername
        '
        Me.txtCustomername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCustomername.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtCustomername.Location = New System.Drawing.Point(250, 63)
        Me.txtCustomername.MaxLength = 50
        Me.txtCustomername.Name = "txtCustomername"
        Me.txtCustomername.ReadOnly = True
        Me.txtCustomername.Size = New System.Drawing.Size(225, 26)
        Me.txtCustomername.TabIndex = 242
        '
        'txtSalesmanName
        '
        Me.txtSalesmanName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSalesmanName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtSalesmanName.Location = New System.Drawing.Point(250, 37)
        Me.txtSalesmanName.MaxLength = 50
        Me.txtSalesmanName.Name = "txtSalesmanName"
        Me.txtSalesmanName.ReadOnly = True
        Me.txtSalesmanName.Size = New System.Drawing.Size(225, 26)
        Me.txtSalesmanName.TabIndex = 241
        '
        'tsListInvoice
        '
        Me.tsListInvoice.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsListInvoice.Dock = System.Windows.Forms.DockStyle.None
        Me.tsListInvoice.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsListInvoice.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.btnGo, Me.ToolStripSeparator33, Me.btnPrint, Me.ToolStripSeparator34})
        Me.tsListInvoice.Location = New System.Drawing.Point(886, 10)
        Me.tsListInvoice.Name = "tsListInvoice"
        Me.tsListInvoice.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsListInvoice.Size = New System.Drawing.Size(96, 27)
        Me.tsListInvoice.TabIndex = 239
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.chkSortCustomer)
        Me.gbOptions.Controls.Add(Me.chkSortSalesman)
        Me.gbOptions.Location = New System.Drawing.Point(625, 29)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(155, 69)
        Me.gbOptions.TabIndex = 240
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = "Options"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 19)
        Me.Label7.TabIndex = 237
        Me.Label7.Text = "Customer [Blank = All] :"
        '
        'txtCustCode
        '
        Me.txtCustCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCustCode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtCustCode.Location = New System.Drawing.Point(153, 63)
        Me.txtCustCode.MaxLength = 50
        Me.txtCustCode.Name = "txtCustCode"
        Me.txtCustCode.Size = New System.Drawing.Size(93, 26)
        Me.txtCustCode.TabIndex = 236
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 19)
        Me.Label1.TabIndex = 235
        Me.Label1.Text = "Salesman [Blank = All] :"
        '
        'txtSlmncode
        '
        Me.txtSlmncode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSlmncode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtSlmncode.Location = New System.Drawing.Point(153, 37)
        Me.txtSlmncode.MaxLength = 50
        Me.txtSlmncode.Name = "txtSlmncode"
        Me.txtSlmncode.Size = New System.Drawing.Size(93, 26)
        Me.txtSlmncode.TabIndex = 234
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(249, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 19)
        Me.Label3.TabIndex = 233
        Me.Label3.Text = "Ending Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 232
        Me.Label2.Text = "Stating Date :"
        '
        'sDate2
        '
        Me.sDate2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sDate2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.sDate2.Location = New System.Drawing.Point(331, 10)
        Me.sDate2.Name = "sDate2"
        Me.sDate2.Size = New System.Drawing.Size(93, 26)
        Me.sDate2.TabIndex = 231
        '
        'sDate1
        '
        Me.sDate1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sDate1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.sDate1.Location = New System.Drawing.Point(153, 11)
        Me.sDate1.Name = "sDate1"
        Me.sDate1.Size = New System.Drawing.Size(93, 26)
        Me.sDate1.TabIndex = 230
        '
        'chkSalesman
        '
        Me.chkSalesman.AutoSize = True
        Me.chkSalesman.Location = New System.Drawing.Point(481, 40)
        Me.chkSalesman.Name = "chkSalesman"
        Me.chkSalesman.Size = New System.Drawing.Size(112, 23)
        Me.chkSalesman.TabIndex = 243
        Me.chkSalesman.Text = "Blank for ALL"
        Me.chkSalesman.UseVisualStyleBackColor = True
        '
        'chkCustomer
        '
        Me.chkCustomer.AutoSize = True
        Me.chkCustomer.Location = New System.Drawing.Point(481, 65)
        Me.chkCustomer.Name = "chkCustomer"
        Me.chkCustomer.Size = New System.Drawing.Size(112, 23)
        Me.chkCustomer.TabIndex = 249
        Me.chkCustomer.Text = "Blank for ALL"
        Me.chkCustomer.UseVisualStyleBackColor = True
        '
        'netamnts
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.netamnts.DefaultCellStyle = DataGridViewCellStyle1
        Me.netamnts.HeaderText = "NET-AMOUNT"
        Me.netamnts.Name = "netamnts"
        Me.netamnts.Width = 110
        '
        'disc2s
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.disc2s.DefaultCellStyle = DataGridViewCellStyle2
        Me.disc2s.HeaderText = "DISC2"
        Me.disc2s.Name = "disc2s"
        Me.disc2s.Width = 70
        '
        'disc1s
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.disc1s.DefaultCellStyle = DataGridViewCellStyle3
        Me.disc1s.HeaderText = "DISC1"
        Me.disc1s.Name = "disc1s"
        Me.disc1s.Width = 70
        '
        'grsamnts
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.grsamnts.DefaultCellStyle = DataGridViewCellStyle4
        Me.grsamnts.HeaderText = "GROSS AMT"
        Me.grsamnts.Name = "grsamnts"
        '
        'custnames
        '
        Me.custnames.HeaderText = "CUSTOMER NAME"
        Me.custnames.Name = "custnames"
        Me.custnames.Width = 228
        '
        'salemans
        '
        Me.salemans.HeaderText = "SALESMAN"
        Me.salemans.Name = "salemans"
        Me.salemans.Width = 70
        '
        'ddates
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ddates.DefaultCellStyle = DataGridViewCellStyle5
        Me.ddates.HeaderText = "DATE"
        Me.ddates.Name = "ddates"
        Me.ddates.Width = 66
        '
        'invnos
        '
        Me.invnos.HeaderText = "INVOICE-NO"
        Me.invnos.Name = "invnos"
        '
        'trnos
        '
        Me.trnos.HeaderText = "TRANSNO"
        Me.trnos.Name = "trnos"
        Me.trnos.Width = 80
        '
        'nos
        '
        Me.nos.HeaderText = "#"
        Me.nos.Name = "nos"
        Me.nos.Width = 42
        '
        'dgvInvoiceList1
        '
        Me.dgvInvoiceList1.AllowUserToAddRows = False
        Me.dgvInvoiceList1.AllowUserToResizeRows = False
        Me.dgvInvoiceList1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvInvoiceList1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoiceList1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nos, Me.trnos, Me.invnos, Me.ddates, Me.salemans, Me.custnames, Me.grsamnts, Me.disc1s, Me.disc2s, Me.netamnts})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInvoiceList1.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvInvoiceList1.Location = New System.Drawing.Point(14, 104)
        Me.dgvInvoiceList1.Name = "dgvInvoiceList1"
        Me.dgvInvoiceList1.RowHeadersVisible = False
        Me.dgvInvoiceList1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInvoiceList1.Size = New System.Drawing.Size(955, 444)
        Me.dgvInvoiceList1.TabIndex = 250
        '
        'frmListSalesInvoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(985, 558)
        Me.Controls.Add(Me.dgvInvoiceList1)
        Me.Controls.Add(Me.chkCustomer)
        Me.Controls.Add(Me.txtDisc2)
        Me.Controls.Add(Me.txtGross)
        Me.Controls.Add(Me.txtDisc1)
        Me.Controls.Add(Me.txtGrandTotal)
        Me.Controls.Add(Me.pbar1)
        Me.Controls.Add(Me.chkSalesman)
        Me.Controls.Add(Me.txtCustomername)
        Me.Controls.Add(Me.txtSalesmanName)
        Me.Controls.Add(Me.tsListInvoice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCustCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSlmncode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.sDate2)
        Me.Controls.Add(Me.sDate1)
        Me.Controls.Add(Me.gbOptions)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListSalesInvoices"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIST OF SALES INVOICES"
        Me.tsListInvoice.ResumeLayout(False)
        Me.tsListInvoice.PerformLayout()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        CType(Me.dgvInvoiceList1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDisc2 As System.Windows.Forms.TextBox
    Friend WithEvents txtGross As System.Windows.Forms.TextBox
    Friend WithEvents txtDisc1 As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkSortCustomer As System.Windows.Forms.CheckBox
    Friend WithEvents txtGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents chkSortSalesman As System.Windows.Forms.CheckBox
    Friend WithEvents pbar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents txtCustomername As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesmanName As System.Windows.Forms.TextBox
    Friend WithEvents tsListInvoice As System.Windows.Forms.ToolStrip
    Friend WithEvents gbOptions As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCustCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSlmncode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents sDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents sDate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkSalesman As System.Windows.Forms.CheckBox
    Friend WithEvents chkCustomer As System.Windows.Forms.CheckBox
    Friend WithEvents netamnts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents disc2s As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents disc1s As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grsamnts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents custnames As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents salemans As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ddates As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents invnos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trnos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvInvoiceList1 As System.Windows.Forms.DataGridView
End Class
