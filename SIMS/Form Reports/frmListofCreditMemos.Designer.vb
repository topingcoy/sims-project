<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListofCreditMemos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListofCreditMemos))
        Me.dgvCreditMemo = New System.Windows.Forms.DataGridView()
        Me.tsCreditMemo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.Go = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintCreditMemo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpCMend = New System.Windows.Forms.DateTimePicker()
        Me.dtpCMstart = New System.Windows.Forms.DateTimePicker()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSalesman = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbCustomer = New System.Windows.Forms.TextBox()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.cbxSortSalesman = New System.Windows.Forms.CheckBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCreditMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsCreditMemo.SuspendLayout()
        Me.gbOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCreditMemo
        '
        Me.dgvCreditMemo.AllowUserToAddRows = False
        Me.dgvCreditMemo.AllowUserToResizeRows = False
        Me.dgvCreditMemo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCreditMemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCreditMemo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvCreditMemo.Location = New System.Drawing.Point(12, 91)
        Me.dgvCreditMemo.Name = "dgvCreditMemo"
        Me.dgvCreditMemo.RowHeadersVisible = False
        Me.dgvCreditMemo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCreditMemo.Size = New System.Drawing.Size(1029, 336)
        Me.dgvCreditMemo.TabIndex = 135
        '
        'tsCreditMemo
        '
        Me.tsCreditMemo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsCreditMemo.Dock = System.Windows.Forms.DockStyle.None
        Me.tsCreditMemo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsCreditMemo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.Go, Me.ToolStripSeparator33, Me.PrintCreditMemo, Me.ToolStripSeparator34})
        Me.tsCreditMemo.Location = New System.Drawing.Point(912, 9)
        Me.tsCreditMemo.Name = "tsCreditMemo"
        Me.tsCreditMemo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsCreditMemo.Size = New System.Drawing.Size(129, 25)
        Me.tsCreditMemo.TabIndex = 136
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
        'PrintCreditMemo
        '
        Me.PrintCreditMemo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PrintCreditMemo.Image = CType(resources.GetObject("PrintCreditMemo.Image"), System.Drawing.Image)
        Me.PrintCreditMemo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintCreditMemo.Name = "PrintCreditMemo"
        Me.PrintCreditMemo.Size = New System.Drawing.Size(80, 22)
        Me.PrintCreditMemo.Text = "Print Preview"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(242, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Ending Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Starting Date :"
        '
        'dtpCMend
        '
        Me.dtpCMend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpCMend.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCMend.Location = New System.Drawing.Point(321, 13)
        Me.dtpCMend.Name = "dtpCMend"
        Me.dtpCMend.Size = New System.Drawing.Size(93, 22)
        Me.dtpCMend.TabIndex = 138
        '
        'dtpCMstart
        '
        Me.dtpCMstart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpCMstart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCMstart.Location = New System.Drawing.Point(143, 12)
        Me.dtpCMstart.Name = "dtpCMstart"
        Me.dtpCMstart.Size = New System.Drawing.Size(93, 22)
        Me.dtpCMstart.TabIndex = 137
        '
        'lblCustomerName
        '
        Me.lblCustomerName.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(242, 38)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(316, 22)
        Me.lblCustomerName.TabIndex = 143
        Me.lblCustomerName.Text = "SALESMAN NAME"
        Me.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCustomerName.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "Salesman [Blank = All] :"
        '
        'tbSalesman
        '
        Me.tbSalesman.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSalesman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSalesman.Location = New System.Drawing.Point(143, 38)
        Me.tbSalesman.MaxLength = 50
        Me.tbSalesman.Name = "tbSalesman"
        Me.tbSalesman.Size = New System.Drawing.Size(92, 22)
        Me.tbSalesman.TabIndex = 141
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(242, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(316, 22)
        Me.Label6.TabIndex = 146
        Me.Label6.Text = "CUSTOMER NAME"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 13)
        Me.Label7.TabIndex = 145
        Me.Label7.Text = "Customer [Blank = All] :"
        '
        'tbCustomer
        '
        Me.tbCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbCustomer.Location = New System.Drawing.Point(143, 63)
        Me.tbCustomer.MaxLength = 50
        Me.tbCustomer.Name = "tbCustomer"
        Me.tbCustomer.Size = New System.Drawing.Size(92, 22)
        Me.tbCustomer.TabIndex = 144
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.CheckBox2)
        Me.gbOptions.Controls.Add(Me.cbxSortSalesman)
        Me.gbOptions.Location = New System.Drawing.Point(705, 17)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(194, 68)
        Me.gbOptions.TabIndex = 156
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = "Options"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(60, 44)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(114, 17)
        Me.CheckBox2.TabIndex = 138
        Me.CheckBox2.Text = "Sort by Customer"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'cbxSortSalesman
        '
        Me.cbxSortSalesman.AutoSize = True
        Me.cbxSortSalesman.Location = New System.Drawing.Point(60, 21)
        Me.cbxSortSalesman.Name = "cbxSortSalesman"
        Me.cbxSortSalesman.Size = New System.Drawing.Size(113, 17)
        Me.cbxSortSalesman.TabIndex = 136
        Me.cbxSortSalesman.Text = "Sort by Salesman"
        Me.cbxSortSalesman.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "C.M. NO"
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
        Me.Column3.HeaderText = "SALESMAN"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "CUSTOMER NAME"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 300
        '
        'Column5
        '
        Me.Column5.HeaderText = "AMOUNT"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "REMARKS"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 280
        '
        'frmListofCreditMemos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 439)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbCustomer)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbSalesman)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpCMend)
        Me.Controls.Add(Me.dtpCMstart)
        Me.Controls.Add(Me.tsCreditMemo)
        Me.Controls.Add(Me.dgvCreditMemo)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListofCreditMemos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIST OF CREDIT MEMOS"
        CType(Me.dgvCreditMemo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsCreditMemo.ResumeLayout(False)
        Me.tsCreditMemo.PerformLayout()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCreditMemo As System.Windows.Forms.DataGridView
    Friend WithEvents tsCreditMemo As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Go As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintCreditMemo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpCMend As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCMstart As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbSalesman As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbCustomer As System.Windows.Forms.TextBox
    Friend WithEvents gbOptions As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents cbxSortSalesman As System.Windows.Forms.CheckBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
