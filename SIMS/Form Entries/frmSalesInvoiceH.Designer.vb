<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesInvoiceH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesInvoiceH))
        Me.dgvInvoiceList = New System.Windows.Forms.DataGridView()
        Me.tsInvoiceGo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Go = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpInvoice2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpInvoice1 = New System.Windows.Forms.DateTimePicker()
        Me.tbSearchInvoice = New System.Windows.Forms.TextBox()
        Me.cbxViewPaid = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tsInvoiceList = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddInvoice = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditInvoice = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteInvoice = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
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
        CType(Me.dgvInvoiceList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsInvoiceGo.SuspendLayout()
        Me.tsInvoiceList.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvInvoiceList
        '
        Me.dgvInvoiceList.AllowUserToAddRows = False
        Me.dgvInvoiceList.AllowUserToResizeRows = False
        Me.dgvInvoiceList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoiceList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.dgvInvoiceList.Location = New System.Drawing.Point(13, 40)
        Me.dgvInvoiceList.Name = "dgvInvoiceList"
        Me.dgvInvoiceList.RowHeadersVisible = False
        Me.dgvInvoiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInvoiceList.Size = New System.Drawing.Size(1043, 432)
        Me.dgvInvoiceList.TabIndex = 41
        '
        'tsInvoiceGo
        '
        Me.tsInvoiceGo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsInvoiceGo.Dock = System.Windows.Forms.DockStyle.None
        Me.tsInvoiceGo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsInvoiceGo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.Go, Me.ToolStripSeparator2})
        Me.tsInvoiceGo.Location = New System.Drawing.Point(1012, 9)
        Me.tsInvoiceGo.Name = "tsInvoiceGo"
        Me.tsInvoiceGo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsInvoiceGo.Size = New System.Drawing.Size(43, 25)
        Me.tsInvoiceGo.TabIndex = 50
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Go
        '
        Me.Go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Go.Image = CType(resources.GetObject("Go.Image"), System.Drawing.Image)
        Me.Go.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Go.Name = "Go"
        Me.Go.Size = New System.Drawing.Size(28, 22)
        Me.Go.Text = "GO"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Location = New System.Drawing.Point(887, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "To"
        '
        'dtpInvoice2
        '
        Me.dtpInvoice2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpInvoice2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInvoice2.Location = New System.Drawing.Point(915, 10)
        Me.dtpInvoice2.Name = "dtpInvoice2"
        Me.dtpInvoice2.Size = New System.Drawing.Size(93, 22)
        Me.dtpInvoice2.TabIndex = 48
        '
        'dtpInvoice1
        '
        Me.dtpInvoice1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpInvoice1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInvoice1.Location = New System.Drawing.Point(787, 10)
        Me.dtpInvoice1.Name = "dtpInvoice1"
        Me.dtpInvoice1.Size = New System.Drawing.Size(93, 22)
        Me.dtpInvoice1.TabIndex = 47
        '
        'tbSearchInvoice
        '
        Me.tbSearchInvoice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSearchInvoice.Location = New System.Drawing.Point(12, 12)
        Me.tbSearchInvoice.MaxLength = 50
        Me.tbSearchInvoice.Name = "tbSearchInvoice"
        Me.tbSearchInvoice.Size = New System.Drawing.Size(286, 22)
        Me.tbSearchInvoice.TabIndex = 51
        '
        'cbxViewPaid
        '
        Me.cbxViewPaid.AutoSize = True
        Me.cbxViewPaid.Location = New System.Drawing.Point(304, 17)
        Me.cbxViewPaid.Name = "cbxViewPaid"
        Me.cbxViewPaid.Size = New System.Drawing.Size(81, 17)
        Me.cbxViewPaid.TabIndex = 52
        Me.cbxViewPaid.Text = "View Paid?"
        Me.cbxViewPaid.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(709, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Date Range :"
        '
        'tsInvoiceList
        '
        Me.tsInvoiceList.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsInvoiceList.Dock = System.Windows.Forms.DockStyle.None
        Me.tsInvoiceList.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsInvoiceList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.AddInvoice, Me.ToolStripSeparator33, Me.EditInvoice, Me.ToolStripSeparator34, Me.DeleteInvoice, Me.ToolStripSeparator35})
        Me.tsInvoiceList.Location = New System.Drawing.Point(394, 480)
        Me.tsInvoiceList.Name = "tsInvoiceList"
        Me.tsInvoiceList.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsInvoiceList.Size = New System.Drawing.Size(260, 25)
        Me.tsInvoiceList.TabIndex = 54
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'AddInvoice
        '
        Me.AddInvoice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AddInvoice.Image = CType(resources.GetObject("AddInvoice.Image"), System.Drawing.Image)
        Me.AddInvoice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddInvoice.Name = "AddInvoice"
        Me.AddInvoice.Size = New System.Drawing.Size(66, 22)
        Me.AddInvoice.Text = "[F5] - ADD"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'EditInvoice
        '
        Me.EditInvoice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditInvoice.Image = CType(resources.GetObject("EditInvoice.Image"), System.Drawing.Image)
        Me.EditInvoice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditInvoice.Name = "EditInvoice"
        Me.EditInvoice.Size = New System.Drawing.Size(87, 22)
        Me.EditInvoice.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'DeleteInvoice
        '
        Me.DeleteInvoice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DeleteInvoice.Image = CType(resources.GetObject("DeleteInvoice.Image"), System.Drawing.Image)
        Me.DeleteInvoice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteInvoice.Name = "DeleteInvoice"
        Me.DeleteInvoice.Size = New System.Drawing.Size(80, 22)
        Me.DeleteInvoice.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'Column1
        '
        Me.Column1.HeaderText = "INVOCE-NO"
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
        Me.Column3.Width = 350
        '
        'Column4
        '
        Me.Column4.HeaderText = "SALESMAN"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 75
        '
        'Column5
        '
        Me.Column5.HeaderText = "WHS"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 75
        '
        'Column6
        '
        Me.Column6.HeaderText = "AMOUNT"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 90
        '
        'Column7
        '
        Me.Column7.HeaderText = "BALANCE"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 90
        '
        'Column8
        '
        Me.Column8.HeaderText = "PAID-ON"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 75
        '
        'Column9
        '
        Me.Column9.HeaderText = "ENTERED-BY"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 90
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "STATUS"
        Me.Column10.Name = "Column10"
        Me.Column10.Visible = False
        Me.Column10.Width = 69
        '
        'frmSalesInvoiceH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 509)
        Me.Controls.Add(Me.tsInvoiceList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxViewPaid)
        Me.Controls.Add(Me.tbSearchInvoice)
        Me.Controls.Add(Me.tsInvoiceGo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpInvoice2)
        Me.Controls.Add(Me.dtpInvoice1)
        Me.Controls.Add(Me.dgvInvoiceList)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalesInvoiceH"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALES INVOICE LIST"
        CType(Me.dgvInvoiceList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsInvoiceGo.ResumeLayout(False)
        Me.tsInvoiceGo.PerformLayout()
        Me.tsInvoiceList.ResumeLayout(False)
        Me.tsInvoiceList.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvInvoiceList As System.Windows.Forms.DataGridView
    Friend WithEvents tsInvoiceGo As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Go As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpInvoice2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInvoice1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbSearchInvoice As System.Windows.Forms.TextBox
    Friend WithEvents cbxViewPaid As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tsInvoiceList As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddInvoice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditInvoice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteInvoice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
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
End Class
