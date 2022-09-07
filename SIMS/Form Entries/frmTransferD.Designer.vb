<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransferD))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.tsStockTransfer = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewTransfer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.SavePrintTransfer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveTransfer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditTransfer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.tsTransferAdd = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbTransferTotal = New System.Windows.Forms.TextBox()
        Me.tbTransNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbAddedBy = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxToWhs = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxPriceType = New System.Windows.Forms.ComboBox()
        Me.cbxFromWhs = New System.Windows.Forms.ComboBox()
        Me.dtpTransfer = New System.Windows.Forms.DateTimePicker()
        Me.dgvTransferItem = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsStockTransfer.SuspendLayout()
        Me.tsTransferAdd.SuspendLayout()
        CType(Me.dgvTransferItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeleteItem
        '
        Me.DeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DeleteItem.Image = CType(resources.GetObject("DeleteItem.Image"), System.Drawing.Image)
        Me.DeleteItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteItem.Name = "DeleteItem"
        Me.DeleteItem.Size = New System.Drawing.Size(44, 22)
        Me.DeleteItem.Text = "&Delete"
        Me.DeleteItem.ToolTipText = "S&ave "
        '
        'tsStockTransfer
        '
        Me.tsStockTransfer.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsStockTransfer.Dock = System.Windows.Forms.DockStyle.None
        Me.tsStockTransfer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsStockTransfer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.NewTransfer, Me.ToolStripSeparator33, Me.SavePrintTransfer, Me.ToolStripSeparator34, Me.SaveTransfer, Me.ToolStripSeparator35, Me.EditTransfer, Me.ToolStripSeparator7})
        Me.tsStockTransfer.Location = New System.Drawing.Point(618, 6)
        Me.tsStockTransfer.Name = "tsStockTransfer"
        Me.tsStockTransfer.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsStockTransfer.Size = New System.Drawing.Size(202, 25)
        Me.tsStockTransfer.TabIndex = 88
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'NewTransfer
        '
        Me.NewTransfer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NewTransfer.Image = CType(resources.GetObject("NewTransfer.Image"), System.Drawing.Image)
        Me.NewTransfer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewTransfer.Name = "NewTransfer"
        Me.NewTransfer.Size = New System.Drawing.Size(35, 22)
        Me.NewTransfer.Text = "&New"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'SavePrintTransfer
        '
        Me.SavePrintTransfer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SavePrintTransfer.Image = CType(resources.GetObject("SavePrintTransfer.Image"), System.Drawing.Image)
        Me.SavePrintTransfer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SavePrintTransfer.Name = "SavePrintTransfer"
        Me.SavePrintTransfer.Size = New System.Drawing.Size(68, 22)
        Me.SavePrintTransfer.Text = "Save+&Print"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'SaveTransfer
        '
        Me.SaveTransfer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveTransfer.Image = CType(resources.GetObject("SaveTransfer.Image"), System.Drawing.Image)
        Me.SaveTransfer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveTransfer.Name = "SaveTransfer"
        Me.SaveTransfer.Size = New System.Drawing.Size(35, 22)
        Me.SaveTransfer.Text = "&Save"
        Me.SaveTransfer.ToolTipText = "S&ave "
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'EditTransfer
        '
        Me.EditTransfer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditTransfer.Image = CType(resources.GetObject("EditTransfer.Image"), System.Drawing.Image)
        Me.EditTransfer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditTransfer.Name = "EditTransfer"
        Me.EditTransfer.Size = New System.Drawing.Size(31, 22)
        Me.EditTransfer.Text = "&Edit"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Location = New System.Drawing.Point(289, 73)
        Me.TextBox3.MaxLength = 10
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(104, 22)
        Me.TextBox3.TabIndex = 87
        '
        'tsTransferAdd
        '
        Me.tsTransferAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsTransferAdd.Dock = System.Windows.Forms.DockStyle.None
        Me.tsTransferAdd.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsTransferAdd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.AddItem, Me.ToolStripSeparator6, Me.EditItem, Me.ToolStripSeparator1, Me.DeleteItem, Me.ToolStripSeparator8})
        Me.tsTransferAdd.Location = New System.Drawing.Point(13, 439)
        Me.tsTransferAdd.Name = "tsTransferAdd"
        Me.tsTransferAdd.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsTransferAdd.Size = New System.Drawing.Size(135, 25)
        Me.tsTransferAdd.TabIndex = 91
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'AddItem
        '
        Me.AddItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AddItem.Image = CType(resources.GetObject("AddItem.Image"), System.Drawing.Image)
        Me.AddItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddItem.Name = "AddItem"
        Me.AddItem.Size = New System.Drawing.Size(33, 22)
        Me.AddItem.Text = "&Add"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'EditItem
        '
        Me.EditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditItem.Image = CType(resources.GetObject("EditItem.Image"), System.Drawing.Image)
        Me.EditItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditItem.Name = "EditItem"
        Me.EditItem.Size = New System.Drawing.Size(31, 22)
        Me.EditItem.Text = "E&dit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(627, 446)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "TOTAL :"
        '
        'tbTransferTotal
        '
        Me.tbTransferTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTransferTotal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTransferTotal.Location = New System.Drawing.Point(677, 442)
        Me.tbTransferTotal.MaxLength = 50
        Me.tbTransferTotal.Name = "tbTransferTotal"
        Me.tbTransferTotal.ReadOnly = True
        Me.tbTransferTotal.Size = New System.Drawing.Size(146, 22)
        Me.tbTransferTotal.TabIndex = 89
        '
        'tbTransNo
        '
        Me.tbTransNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTransNo.Location = New System.Drawing.Point(215, 22)
        Me.tbTransNo.MaxLength = 10
        Me.tbTransNo.Name = "tbTransNo"
        Me.tbTransNo.ReadOnly = True
        Me.tbTransNo.Size = New System.Drawing.Size(104, 22)
        Me.tbTransNo.TabIndex = 86
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(478, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Added By :"
        '
        'tbAddedBy
        '
        Me.tbAddedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbAddedBy.Location = New System.Drawing.Point(543, 73)
        Me.tbAddedBy.MaxLength = 10
        Me.tbAddedBy.Name = "tbAddedBy"
        Me.tbAddedBy.ReadOnly = True
        Me.tbAddedBy.Size = New System.Drawing.Size(104, 22)
        Me.tbAddedBy.TabIndex = 84
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(234, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Doc No :"
        '
        'txtItemCode
        '
        Me.txtItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemCode.Location = New System.Drawing.Point(392, -205)
        Me.txtItemCode.MaxLength = 10
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.ReadOnly = True
        Me.txtItemCode.Size = New System.Drawing.Size(104, 22)
        Me.txtItemCode.TabIndex = 82
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(470, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Transfer To :"
        '
        'cbxToWhs
        '
        Me.cbxToWhs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxToWhs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxToWhs.FormattingEnabled = True
        Me.cbxToWhs.Location = New System.Drawing.Point(543, 48)
        Me.cbxToWhs.Name = "cbxToWhs"
        Me.cbxToWhs.Size = New System.Drawing.Size(277, 21)
        Me.cbxToWhs.TabIndex = 80
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Price Type :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Transfer From :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Date :"
        '
        'cbxPriceType
        '
        Me.cbxPriceType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxPriceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPriceType.FormattingEnabled = True
        Me.cbxPriceType.Items.AddRange(New Object() {"1", "A", "B", "C", "D", "E"})
        Me.cbxPriceType.Location = New System.Drawing.Point(116, 73)
        Me.cbxPriceType.Name = "cbxPriceType"
        Me.cbxPriceType.Size = New System.Drawing.Size(44, 21)
        Me.cbxPriceType.TabIndex = 76
        '
        'cbxFromWhs
        '
        Me.cbxFromWhs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxFromWhs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFromWhs.FormattingEnabled = True
        Me.cbxFromWhs.Location = New System.Drawing.Point(116, 48)
        Me.cbxFromWhs.Name = "cbxFromWhs"
        Me.cbxFromWhs.Size = New System.Drawing.Size(277, 21)
        Me.cbxFromWhs.TabIndex = 75
        '
        'dtpTransfer
        '
        Me.dtpTransfer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpTransfer.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTransfer.Location = New System.Drawing.Point(116, 22)
        Me.dtpTransfer.Name = "dtpTransfer"
        Me.dtpTransfer.Size = New System.Drawing.Size(93, 22)
        Me.dtpTransfer.TabIndex = 74
        '
        'dgvTransferItem
        '
        Me.dgvTransferItem.AllowUserToAddRows = False
        Me.dgvTransferItem.AllowUserToDeleteRows = False
        Me.dgvTransferItem.AllowUserToResizeRows = False
        Me.dgvTransferItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTransferItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransferItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgvTransferItem.Location = New System.Drawing.Point(13, 106)
        Me.dgvTransferItem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvTransferItem.Name = "dgvTransferItem"
        Me.dgvTransferItem.ReadOnly = True
        Me.dgvTransferItem.RowHeadersVisible = False
        Me.dgvTransferItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTransferItem.Size = New System.Drawing.Size(809, 329)
        Me.dgvTransferItem.TabIndex = 73
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 39
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.HeaderText = "ITEMCODE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 87
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column2.HeaderText = "DESCRIPTION"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "QTY"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 51
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "UNIT"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 57
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "PCKG"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 59
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "UNIT PRICE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 89
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "AMOUNT"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 80
        '
        'frmTransferD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 474)
        Me.Controls.Add(Me.tsStockTransfer)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.tsTransferAdd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbTransferTotal)
        Me.Controls.Add(Me.tbTransNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbAddedBy)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtItemCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbxToWhs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxPriceType)
        Me.Controls.Add(Me.cbxFromWhs)
        Me.Controls.Add(Me.dtpTransfer)
        Me.Controls.Add(Me.dgvTransferItem)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransferD"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STOCK TRANSFER "
        Me.tsStockTransfer.ResumeLayout(False)
        Me.tsStockTransfer.PerformLayout()
        Me.tsTransferAdd.ResumeLayout(False)
        Me.tsTransferAdd.PerformLayout()
        CType(Me.dgvTransferItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsStockTransfer As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewTransfer As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SavePrintTransfer As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveTransfer As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditTransfer As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents tsTransferAdd As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbTransferTotal As System.Windows.Forms.TextBox
    Friend WithEvents tbTransNo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbAddedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxToWhs As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxPriceType As System.Windows.Forms.ComboBox
    Friend WithEvents cbxFromWhs As System.Windows.Forms.ComboBox
    Friend WithEvents dtpTransfer As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvTransferItem As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
