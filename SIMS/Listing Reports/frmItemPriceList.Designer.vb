<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemPriceList
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemPriceList))
        Me.dgvPriceList = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxPriceType = New System.Windows.Forms.ComboBox()
        Me.tbCategory = New System.Windows.Forms.TextBox()
        Me.tbSupplier = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxCategory = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxSupplier = New System.Windows.Forms.ComboBox()
        Me.tsGeneratePriceList = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.checkboxAll = New System.Windows.Forms.CheckBox()
        Me.pbar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.dgvPriceList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsGeneratePriceList.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPriceList
        '
        Me.dgvPriceList.AllowUserToAddRows = False
        Me.dgvPriceList.AllowUserToResizeRows = False
        Me.dgvPriceList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPriceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPriceList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column9, Me.Column10})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPriceList.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPriceList.Location = New System.Drawing.Point(12, 93)
        Me.dgvPriceList.Name = "dgvPriceList"
        Me.dgvPriceList.RowHeadersVisible = False
        Me.dgvPriceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPriceList.Size = New System.Drawing.Size(996, 477)
        Me.dgvPriceList.TabIndex = 208
        '
        'Column8
        '
        Me.Column8.HeaderText = "#"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 39
        '
        'Column1
        '
        Me.Column1.HeaderText = "ITEMCODE"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 87
        '
        'Column2
        '
        Me.Column2.HeaderText = "ITEM DESCRIPTION"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 420
        '
        'Column3
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "PCS/CASE"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 81
        '
        'Column4
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "PCS/BAG"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 76
        '
        'Column5
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "PRICE/CASE"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 91
        '
        'Column6
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column6.HeaderText = "PRICE/BAG"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 86
        '
        'Column7
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column7.HeaderText = "PRICE/PIECE"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 93
        '
        'Column9
        '
        Me.Column9.HeaderText = "SUP"
        Me.Column9.Name = "Column9"
        Me.Column9.Visible = False
        '
        'Column10
        '
        Me.Column10.HeaderText = "CAT"
        Me.Column10.Name = "Column10"
        Me.Column10.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 212
        Me.Label1.Text = "Price Type :"
        '
        'cbxPriceType
        '
        Me.cbxPriceType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxPriceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPriceType.FormattingEnabled = True
        Me.cbxPriceType.Items.AddRange(New Object() {"1", "A", "B", "C"})
        Me.cbxPriceType.Location = New System.Drawing.Point(76, 66)
        Me.cbxPriceType.Name = "cbxPriceType"
        Me.cbxPriceType.Size = New System.Drawing.Size(44, 21)
        Me.cbxPriceType.TabIndex = 211
        '
        'tbCategory
        '
        Me.tbCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCategory.Location = New System.Drawing.Point(172, 39)
        Me.tbCategory.MaxLength = 10
        Me.tbCategory.Name = "tbCategory"
        Me.tbCategory.ReadOnly = True
        Me.tbCategory.Size = New System.Drawing.Size(196, 22)
        Me.tbCategory.TabIndex = 218
        '
        'tbSupplier
        '
        Me.tbSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSupplier.Location = New System.Drawing.Point(172, 12)
        Me.tbSupplier.MaxLength = 10
        Me.tbSupplier.Name = "tbSupplier"
        Me.tbSupplier.ReadOnly = True
        Me.tbSupplier.Size = New System.Drawing.Size(196, 22)
        Me.tbSupplier.TabIndex = 217
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 216
        Me.Label4.Text = "Category :"
        '
        'cbxCategory
        '
        Me.cbxCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCategory.FormattingEnabled = True
        Me.cbxCategory.Location = New System.Drawing.Point(76, 39)
        Me.cbxCategory.Name = "cbxCategory"
        Me.cbxCategory.Size = New System.Drawing.Size(91, 21)
        Me.cbxCategory.TabIndex = 215
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 214
        Me.Label3.Text = "Supplier :"
        '
        'cbxSupplier
        '
        Me.cbxSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSupplier.FormattingEnabled = True
        Me.cbxSupplier.Location = New System.Drawing.Point(76, 12)
        Me.cbxSupplier.Name = "cbxSupplier"
        Me.cbxSupplier.Size = New System.Drawing.Size(91, 21)
        Me.cbxSupplier.TabIndex = 213
        '
        'tsGeneratePriceList
        '
        Me.tsGeneratePriceList.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsGeneratePriceList.Dock = System.Windows.Forms.DockStyle.None
        Me.tsGeneratePriceList.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsGeneratePriceList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.btnGo, Me.ToolStripSeparator33, Me.btnPrint, Me.ToolStripSeparator34, Me.btnRefresh})
        Me.tsGeneratePriceList.Location = New System.Drawing.Point(878, 10)
        Me.tsGeneratePriceList.Name = "tsGeneratePriceList"
        Me.tsGeneratePriceList.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsGeneratePriceList.Size = New System.Drawing.Size(133, 25)
        Me.tsGeneratePriceList.TabIndex = 219
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'btnGo
        '
        Me.btnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnGo.Image = CType(resources.GetObject("btnGo.Image"), System.Drawing.Image)
        Me.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(26, 22)
        Me.btnGo.Text = "&Go"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(36, 22)
        Me.btnPrint.Text = "&Print"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'btnRefresh
        '
        Me.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(50, 22)
        Me.btnRefresh.Text = "&Refresh"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 13)
        Me.Label2.TabIndex = 220
        Me.Label2.Text = "1 = Cost Price, A,B,C = SRP Price"
        '
        'checkboxAll
        '
        Me.checkboxAll.AutoSize = True
        Me.checkboxAll.Location = New System.Drawing.Point(374, 42)
        Me.checkboxAll.Name = "checkboxAll"
        Me.checkboxAll.Size = New System.Drawing.Size(126, 17)
        Me.checkboxAll.TabIndex = 221
        Me.checkboxAll.Text = "Blank - All Category"
        Me.checkboxAll.UseVisualStyleBackColor = True
        '
        'pbar1
        '
        Me.pbar1.Location = New System.Drawing.Point(13, 576)
        Me.pbar1.Name = "pbar1"
        Me.pbar1.Size = New System.Drawing.Size(991, 10)
        Me.pbar1.TabIndex = 222
        Me.pbar1.Visible = False
        '
        'frmItemPriceList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 598)
        Me.Controls.Add(Me.pbar1)
        Me.Controls.Add(Me.checkboxAll)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tsGeneratePriceList)
        Me.Controls.Add(Me.tbCategory)
        Me.Controls.Add(Me.tbSupplier)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbxCategory)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxSupplier)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxPriceType)
        Me.Controls.Add(Me.dgvPriceList)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItemPriceList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ITEM PRICE LIST"
        CType(Me.dgvPriceList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsGeneratePriceList.ResumeLayout(False)
        Me.tsGeneratePriceList.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPriceList As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxPriceType As System.Windows.Forms.ComboBox
    Friend WithEvents tbCategory As System.Windows.Forms.TextBox
    Friend WithEvents tbSupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents tsGeneratePriceList As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents checkboxAll As System.Windows.Forms.CheckBox
    Friend WithEvents pbar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
