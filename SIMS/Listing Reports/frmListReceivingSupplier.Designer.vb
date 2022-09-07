<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListReceivingSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListReceivingSupplier))
        Me.dgvListSupplier = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbSupplier = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpListInvoice2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpListInvoice1 = New System.Windows.Forms.DateTimePicker()
        Me.lblWhs = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbWhs = New System.Windows.Forms.TextBox()
        Me.tsListReceiving = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.Go = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintListReceiving = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.cbxItemDetails = New System.Windows.Forms.CheckBox()
        Me.cbxSortSalesman = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.dgvListSuppierItemDetail = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvListSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsListReceiving.SuspendLayout()
        Me.gbOptions.SuspendLayout()
        CType(Me.dgvListSuppierItemDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListSupplier
        '
        Me.dgvListSupplier.AllowUserToAddRows = False
        Me.dgvListSupplier.AllowUserToResizeRows = False
        Me.dgvListSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListSupplier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgvListSupplier.Location = New System.Drawing.Point(12, 91)
        Me.dgvListSupplier.Name = "dgvListSupplier"
        Me.dgvListSupplier.RowHeadersVisible = False
        Me.dgvListSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListSupplier.Size = New System.Drawing.Size(1039, 404)
        Me.dgvListSupplier.TabIndex = 172
        '
        'Column1
        '
        Me.Column1.HeaderText = "INVOICE-NO"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "DATE"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "SUPPLIER"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "WAREHOUSE"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "GROSS AMT"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "DISC1"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "DISC2"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "DISC3"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "NET AMT"
        Me.Column9.Name = "Column9"
        '
        'lblSupplier
        '
        Me.lblSupplier.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplier.Location = New System.Drawing.Point(256, 38)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(316, 22)
        Me.lblSupplier.TabIndex = 179
        Me.lblSupplier.Text = "SUPPLIER NAME"
        Me.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSupplier.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 13)
        Me.Label9.TabIndex = 178
        Me.Label9.Text = "Supplier [Blank = All] :"
        '
        'tbSupplier
        '
        Me.tbSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSupplier.Location = New System.Drawing.Point(157, 38)
        Me.tbSupplier.MaxLength = 50
        Me.tbSupplier.Name = "tbSupplier"
        Me.tbSupplier.Size = New System.Drawing.Size(92, 22)
        Me.tbSupplier.TabIndex = 177
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 176
        Me.Label3.Text = "Ending Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 175
        Me.Label2.Text = "Stating Date :"
        '
        'dtpListInvoice2
        '
        Me.dtpListInvoice2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpListInvoice2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpListInvoice2.Location = New System.Drawing.Point(337, 12)
        Me.dtpListInvoice2.Name = "dtpListInvoice2"
        Me.dtpListInvoice2.Size = New System.Drawing.Size(93, 22)
        Me.dtpListInvoice2.TabIndex = 174
        '
        'dtpListInvoice1
        '
        Me.dtpListInvoice1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpListInvoice1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpListInvoice1.Location = New System.Drawing.Point(156, 12)
        Me.dtpListInvoice1.Name = "dtpListInvoice1"
        Me.dtpListInvoice1.Size = New System.Drawing.Size(93, 22)
        Me.dtpListInvoice1.TabIndex = 173
        '
        'lblWhs
        '
        Me.lblWhs.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhs.Location = New System.Drawing.Point(256, 63)
        Me.lblWhs.Name = "lblWhs"
        Me.lblWhs.Size = New System.Drawing.Size(316, 22)
        Me.lblWhs.TabIndex = 182
        Me.lblWhs.Text = "WAREHOUSE NAME"
        Me.lblWhs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblWhs.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 13)
        Me.Label5.TabIndex = 181
        Me.Label5.Text = "Warehouse [Blank = All] :"
        '
        'tbWhs
        '
        Me.tbWhs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbWhs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbWhs.Location = New System.Drawing.Point(157, 63)
        Me.tbWhs.MaxLength = 50
        Me.tbWhs.Name = "tbWhs"
        Me.tbWhs.Size = New System.Drawing.Size(92, 22)
        Me.tbWhs.TabIndex = 180
        '
        'tsListReceiving
        '
        Me.tsListReceiving.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsListReceiving.Dock = System.Windows.Forms.DockStyle.None
        Me.tsListReceiving.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsListReceiving.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.Go, Me.ToolStripSeparator33, Me.PrintListReceiving, Me.ToolStripSeparator34})
        Me.tsListReceiving.Location = New System.Drawing.Point(921, 9)
        Me.tsListReceiving.Name = "tsListReceiving"
        Me.tsListReceiving.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsListReceiving.Size = New System.Drawing.Size(129, 25)
        Me.tsListReceiving.TabIndex = 183
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
        'PrintListReceiving
        '
        Me.PrintListReceiving.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PrintListReceiving.Image = CType(resources.GetObject("PrintListReceiving.Image"), System.Drawing.Image)
        Me.PrintListReceiving.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintListReceiving.Name = "PrintListReceiving"
        Me.PrintListReceiving.Size = New System.Drawing.Size(80, 22)
        Me.PrintListReceiving.Text = "Print Preview"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.cbxItemDetails)
        Me.gbOptions.Controls.Add(Me.cbxSortSalesman)
        Me.gbOptions.Controls.Add(Me.CheckBox1)
        Me.gbOptions.Location = New System.Drawing.Point(670, 9)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(214, 76)
        Me.gbOptions.TabIndex = 184
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
        'cbxSortSalesman
        '
        Me.cbxSortSalesman.AutoSize = True
        Me.cbxSortSalesman.Location = New System.Drawing.Point(60, 35)
        Me.cbxSortSalesman.Name = "cbxSortSalesman"
        Me.cbxSortSalesman.Size = New System.Drawing.Size(108, 17)
        Me.cbxSortSalesman.TabIndex = 136
        Me.cbxSortSalesman.Text = "Sort by Supplier"
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
        'dgvListSuppierItemDetail
        '
        Me.dgvListSuppierItemDetail.AllowUserToAddRows = False
        Me.dgvListSuppierItemDetail.AllowUserToResizeRows = False
        Me.dgvListSuppierItemDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListSuppierItemDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListSuppierItemDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column10, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.dgvListSuppierItemDetail.Location = New System.Drawing.Point(12, 91)
        Me.dgvListSuppierItemDetail.Name = "dgvListSuppierItemDetail"
        Me.dgvListSuppierItemDetail.RowHeadersVisible = False
        Me.dgvListSuppierItemDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListSuppierItemDetail.Size = New System.Drawing.Size(1038, 404)
        Me.dgvListSuppierItemDetail.TabIndex = 185
        Me.dgvListSuppierItemDetail.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "INVOICE-NO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "DATE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "QTY"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'Column10
        '
        Me.Column10.HeaderText = "UNIT"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 40
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "ITEM DESCRIPTION"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 300
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "U/COST"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "DISC1"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "DISC2"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 80
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "DISC3"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 80
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "NET AMT"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'frmListReceivingSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 535)
        Me.Controls.Add(Me.dgvListSuppierItemDetail)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.tsListReceiving)
        Me.Controls.Add(Me.lblWhs)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbWhs)
        Me.Controls.Add(Me.lblSupplier)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbSupplier)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpListInvoice2)
        Me.Controls.Add(Me.dtpListInvoice1)
        Me.Controls.Add(Me.dgvListSupplier)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListReceivingSupplier"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIST OF RECEIVING FROM SUPPLIER"
        CType(Me.dgvListSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsListReceiving.ResumeLayout(False)
        Me.tsListReceiving.PerformLayout()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        CType(Me.dgvListSuppierItemDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbSupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpListInvoice2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpListInvoice1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblWhs As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbWhs As System.Windows.Forms.TextBox
    Friend WithEvents tsListReceiving As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Go As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintListReceiving As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents gbOptions As System.Windows.Forms.GroupBox
    Friend WithEvents cbxItemDetails As System.Windows.Forms.CheckBox
    Friend WithEvents cbxSortSalesman As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents dgvListSuppierItemDetail As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
