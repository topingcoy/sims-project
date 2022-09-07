<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemH
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemH))
        Me.txtItemDescription = New System.Windows.Forms.TextBox()
        Me.dgvItemList = New System.Windows.Forms.DataGridView()
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
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsitem = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsadditem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsedititem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsgroup = New System.Windows.Forms.ToolStripButton()
        Me.tsdeleteitem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.gbgroupby = New System.Windows.Forms.GroupBox()
        Me.tsretgo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsgo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cbbrand = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbsegment = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbcategory = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbsupplier = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsitem.SuspendLayout()
        Me.gbgroupby.SuspendLayout()
        Me.tsretgo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtItemDescription
        '
        Me.txtItemDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemDescription.Location = New System.Drawing.Point(12, 9)
        Me.txtItemDescription.MaxLength = 50
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Size = New System.Drawing.Size(298, 22)
        Me.txtItemDescription.TabIndex = 53
        '
        'dgvItemList
        '
        Me.dgvItemList.AllowUserToAddRows = False
        Me.dgvItemList.AllowUserToResizeRows = False
        Me.dgvItemList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.dgvItemList.Location = New System.Drawing.Point(12, 36)
        Me.dgvItemList.Name = "dgvItemList"
        Me.dgvItemList.RowHeadersVisible = False
        Me.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItemList.Size = New System.Drawing.Size(970, 423)
        Me.dgvItemList.TabIndex = 52
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 39
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "ITEMCODE"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 87
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "ITEM DESCRIPTION"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "UNIT"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 57
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "PCKG"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 59
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column6.HeaderText = "PRICE/CASE"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 91
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column7.HeaderText = "PRICE/BAG"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 86
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column8.HeaderText = "PRICE/PC"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 78
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "QTY/CASE"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 81
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "QTY/BAG"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 76
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column11.HeaderText = "QTY/PC"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 68
        '
        'tsitem
        '
        Me.tsitem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsitem.Dock = System.Windows.Forms.DockStyle.None
        Me.tsitem.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsitem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsadditem, Me.ToolStripSeparator33, Me.tsedititem, Me.ToolStripSeparator34, Me.tsgroup, Me.tsdeleteitem, Me.ToolStripSeparator35})
        Me.tsitem.Location = New System.Drawing.Point(323, 465)
        Me.tsitem.Name = "tsitem"
        Me.tsitem.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsitem.Size = New System.Drawing.Size(350, 25)
        Me.tsitem.TabIndex = 56
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'tsadditem
        '
        Me.tsadditem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsadditem.Image = CType(resources.GetObject("tsadditem.Image"), System.Drawing.Image)
        Me.tsadditem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsadditem.Name = "tsadditem"
        Me.tsadditem.Size = New System.Drawing.Size(66, 22)
        Me.tsadditem.Text = "[F5] - ADD"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'tsedititem
        '
        Me.tsedititem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsedititem.Image = CType(resources.GetObject("tsedititem.Image"), System.Drawing.Image)
        Me.tsedititem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsedititem.Name = "tsedititem"
        Me.tsedititem.Size = New System.Drawing.Size(87, 22)
        Me.tsedititem.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'tsgroup
        '
        Me.tsgroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsgroup.Image = CType(resources.GetObject("tsgroup.Image"), System.Drawing.Image)
        Me.tsgroup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsgroup.Name = "tsgroup"
        Me.tsgroup.Size = New System.Drawing.Size(90, 22)
        Me.tsgroup.Text = "[F6] GROUP BY"
        '
        'tsdeleteitem
        '
        Me.tsdeleteitem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsdeleteitem.Image = CType(resources.GetObject("tsdeleteitem.Image"), System.Drawing.Image)
        Me.tsdeleteitem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsdeleteitem.Name = "tsdeleteitem"
        Me.tsdeleteitem.Size = New System.Drawing.Size(80, 22)
        Me.tsdeleteitem.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'gbgroupby
        '
        Me.gbgroupby.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbgroupby.Controls.Add(Me.tsretgo)
        Me.gbgroupby.Controls.Add(Me.cbbrand)
        Me.gbgroupby.Controls.Add(Me.Label4)
        Me.gbgroupby.Controls.Add(Me.cbsegment)
        Me.gbgroupby.Controls.Add(Me.Label3)
        Me.gbgroupby.Controls.Add(Me.cbcategory)
        Me.gbgroupby.Controls.Add(Me.Label2)
        Me.gbgroupby.Controls.Add(Me.cbsupplier)
        Me.gbgroupby.Controls.Add(Me.Label1)
        Me.gbgroupby.Location = New System.Drawing.Point(311, 176)
        Me.gbgroupby.Name = "gbgroupby"
        Me.gbgroupby.Size = New System.Drawing.Size(374, 157)
        Me.gbgroupby.TabIndex = 57
        Me.gbgroupby.TabStop = False
        Me.gbgroupby.Text = "Group By:"
        Me.gbgroupby.Visible = False
        '
        'tsretgo
        '
        Me.tsretgo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tsretgo.Dock = System.Windows.Forms.DockStyle.None
        Me.tsretgo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsretgo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsgo, Me.ToolStripSeparator2})
        Me.tsretgo.Location = New System.Drawing.Point(315, 126)
        Me.tsretgo.Name = "tsretgo"
        Me.tsretgo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsretgo.Size = New System.Drawing.Size(43, 25)
        Me.tsretgo.TabIndex = 60
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsgo
        '
        Me.tsgo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsgo.Image = CType(resources.GetObject("tsgo.Image"), System.Drawing.Image)
        Me.tsgo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsgo.Name = "tsgo"
        Me.tsgo.Size = New System.Drawing.Size(28, 22)
        Me.tsgo.Text = "GO"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'cbbrand
        '
        Me.cbbrand.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbbrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbrand.FormattingEnabled = True
        Me.cbbrand.Location = New System.Drawing.Point(88, 102)
        Me.cbbrand.Name = "cbbrand"
        Me.cbbrand.Size = New System.Drawing.Size(266, 21)
        Me.cbbrand.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Brand :"
        '
        'cbsegment
        '
        Me.cbsegment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbsegment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsegment.FormattingEnabled = True
        Me.cbsegment.Location = New System.Drawing.Point(88, 75)
        Me.cbsegment.Name = "cbsegment"
        Me.cbsegment.Size = New System.Drawing.Size(266, 21)
        Me.cbsegment.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Segment :"
        '
        'cbcategory
        '
        Me.cbcategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcategory.FormattingEnabled = True
        Me.cbcategory.Location = New System.Drawing.Point(88, 48)
        Me.cbcategory.Name = "cbcategory"
        Me.cbcategory.Size = New System.Drawing.Size(266, 21)
        Me.cbcategory.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Category :"
        '
        'cbsupplier
        '
        Me.cbsupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbsupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsupplier.FormattingEnabled = True
        Me.cbsupplier.Location = New System.Drawing.Point(88, 21)
        Me.cbsupplier.Name = "cbsupplier"
        Me.cbsupplier.Size = New System.Drawing.Size(266, 21)
        Me.cbsupplier.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Supplier :"
        '
        'frmItemH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 493)
        Me.Controls.Add(Me.gbgroupby)
        Me.Controls.Add(Me.tsitem)
        Me.Controls.Add(Me.txtItemDescription)
        Me.Controls.Add(Me.dgvItemList)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItemH"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ITEMCODE MAINTENANCE"
        CType(Me.dgvItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsitem.ResumeLayout(False)
        Me.tsitem.PerformLayout()
        Me.gbgroupby.ResumeLayout(False)
        Me.gbgroupby.PerformLayout()
        Me.tsretgo.ResumeLayout(False)
        Me.tsretgo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtItemDescription As System.Windows.Forms.TextBox
    Friend WithEvents dgvItemList As System.Windows.Forms.DataGridView
    Friend WithEvents tsitem As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsadditem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsedititem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsgroup As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsdeleteitem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents gbgroupby As System.Windows.Forms.GroupBox
    Friend WithEvents tsretgo As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsgo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cbbrand As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbsegment As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbcategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbsupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
