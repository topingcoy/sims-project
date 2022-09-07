<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesReturnH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesReturnH))
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditReturn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddReturn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsReturnList = New System.Windows.Forms.ToolStrip()
        Me.DeleteReturn = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxViewPaid = New System.Windows.Forms.CheckBox()
        Me.tbSearchInvoice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpInvoice2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpInvoice1 = New System.Windows.Forms.DateTimePicker()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsReturnGo = New System.Windows.Forms.ToolStrip()
        Me.Go = New System.Windows.Forms.ToolStripButton()
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
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsReturnList.SuspendLayout()
        Me.tsReturnGo.SuspendLayout()
        CType(Me.dgvInvoiceList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'EditReturn
        '
        Me.EditReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditReturn.Image = CType(resources.GetObject("EditReturn.Image"), System.Drawing.Image)
        Me.EditReturn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditReturn.Name = "EditReturn"
        Me.EditReturn.Size = New System.Drawing.Size(87, 22)
        Me.EditReturn.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'AddReturn
        '
        Me.AddReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AddReturn.Image = CType(resources.GetObject("AddReturn.Image"), System.Drawing.Image)
        Me.AddReturn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddReturn.Name = "AddReturn"
        Me.AddReturn.Size = New System.Drawing.Size(66, 22)
        Me.AddReturn.Text = "[F5] - ADD"
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'tsReturnList
        '
        Me.tsReturnList.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsReturnList.Dock = System.Windows.Forms.DockStyle.None
        Me.tsReturnList.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsReturnList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.AddReturn, Me.ToolStripSeparator33, Me.EditReturn, Me.ToolStripSeparator34, Me.DeleteReturn, Me.ToolStripSeparator35})
        Me.tsReturnList.Location = New System.Drawing.Point(394, 477)
        Me.tsReturnList.Name = "tsReturnList"
        Me.tsReturnList.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsReturnList.Size = New System.Drawing.Size(260, 25)
        Me.tsReturnList.TabIndex = 63
        '
        'DeleteReturn
        '
        Me.DeleteReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DeleteReturn.Image = CType(resources.GetObject("DeleteReturn.Image"), System.Drawing.Image)
        Me.DeleteReturn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteReturn.Name = "DeleteReturn"
        Me.DeleteReturn.Size = New System.Drawing.Size(80, 22)
        Me.DeleteReturn.Text = "[F7] - DELETE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(709, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Date Range :"
        '
        'cbxViewPaid
        '
        Me.cbxViewPaid.AutoSize = True
        Me.cbxViewPaid.Location = New System.Drawing.Point(304, 14)
        Me.cbxViewPaid.Name = "cbxViewPaid"
        Me.cbxViewPaid.Size = New System.Drawing.Size(81, 17)
        Me.cbxViewPaid.TabIndex = 61
        Me.cbxViewPaid.Text = "View Paid?"
        Me.cbxViewPaid.UseVisualStyleBackColor = True
        '
        'tbSearchInvoice
        '
        Me.tbSearchInvoice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSearchInvoice.Location = New System.Drawing.Point(12, 9)
        Me.tbSearchInvoice.MaxLength = 50
        Me.tbSearchInvoice.Name = "tbSearchInvoice"
        Me.tbSearchInvoice.Size = New System.Drawing.Size(286, 22)
        Me.tbSearchInvoice.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Location = New System.Drawing.Point(887, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "To"
        '
        'dtpInvoice2
        '
        Me.dtpInvoice2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpInvoice2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInvoice2.Location = New System.Drawing.Point(915, 7)
        Me.dtpInvoice2.Name = "dtpInvoice2"
        Me.dtpInvoice2.Size = New System.Drawing.Size(93, 22)
        Me.dtpInvoice2.TabIndex = 57
        '
        'dtpInvoice1
        '
        Me.dtpInvoice1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpInvoice1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInvoice1.Location = New System.Drawing.Point(787, 7)
        Me.dtpInvoice1.Name = "dtpInvoice1"
        Me.dtpInvoice1.Size = New System.Drawing.Size(93, 22)
        Me.dtpInvoice1.TabIndex = 56
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsReturnGo
        '
        Me.tsReturnGo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsReturnGo.Dock = System.Windows.Forms.DockStyle.None
        Me.tsReturnGo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsReturnGo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.Go, Me.ToolStripSeparator2})
        Me.tsReturnGo.Location = New System.Drawing.Point(1012, 6)
        Me.tsReturnGo.Name = "tsReturnGo"
        Me.tsReturnGo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsReturnGo.Size = New System.Drawing.Size(43, 25)
        Me.tsReturnGo.TabIndex = 59
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
        'dgvInvoiceList
        '
        Me.dgvInvoiceList.AllowUserToAddRows = False
        Me.dgvInvoiceList.AllowUserToResizeRows = False
        Me.dgvInvoiceList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoiceList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.dgvInvoiceList.Location = New System.Drawing.Point(13, 37)
        Me.dgvInvoiceList.Name = "dgvInvoiceList"
        Me.dgvInvoiceList.RowHeadersVisible = False
        Me.dgvInvoiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInvoiceList.Size = New System.Drawing.Size(1043, 432)
        Me.dgvInvoiceList.TabIndex = 55
        '
        'Column1
        '
        Me.Column1.HeaderText = "SRS NO"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "DATE"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 76
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
        Me.Column8.HeaderText = "APPLIED-ON"
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
        Me.Column10.HeaderText = "STATUS"
        Me.Column10.Name = "Column10"
        Me.Column10.Visible = False
        Me.Column10.Width = 60
        '
        'frmSalesReturnH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 509)
        Me.Controls.Add(Me.tsReturnList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxViewPaid)
        Me.Controls.Add(Me.tbSearchInvoice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpInvoice2)
        Me.Controls.Add(Me.dtpInvoice1)
        Me.Controls.Add(Me.tsReturnGo)
        Me.Controls.Add(Me.dgvInvoiceList)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalesReturnH"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALES RETURN LIST"
        Me.tsReturnList.ResumeLayout(False)
        Me.tsReturnList.PerformLayout()
        Me.tsReturnGo.ResumeLayout(False)
        Me.tsReturnGo.PerformLayout()
        CType(Me.dgvInvoiceList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditReturn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddReturn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsReturnList As System.Windows.Forms.ToolStrip
    Friend WithEvents DeleteReturn As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxViewPaid As System.Windows.Forms.CheckBox
    Friend WithEvents tbSearchInvoice As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpInvoice2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInvoice1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsReturnGo As System.Windows.Forms.ToolStrip
    Friend WithEvents Go As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
