<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemD))
        Me.gbxItem = New System.Windows.Forms.GroupBox()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.cbxFree = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nuPcBag = New System.Windows.Forms.NumericUpDown()
        Me.nupPcsCase = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxUnit = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxBrand = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxCategory = New System.Windows.Forms.ComboBox()
        Me.cbxSupplier = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbItemDescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbItemCode = New System.Windows.Forms.TextBox()
        Me.lblpk = New System.Windows.Forms.Label()
        Me.btnCalcPriceC = New System.Windows.Forms.Button()
        Me.btnCalcPriceB = New System.Windows.Forms.Button()
        Me.btnCalcPriceA = New System.Windows.Forms.Button()
        Me.btnCalcCostPc = New System.Windows.Forms.Button()
        Me.ClearItem = New System.Windows.Forms.ToolStripButton()
        Me.UpdateItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveItem = New System.Windows.Forms.ToolStripButton()
        Me.tsItem = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbxObsolet = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.nuItemDisc = New System.Windows.Forms.NumericUpDown()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbGross = New System.Windows.Forms.TextBox()
        Me.tbCostPc = New System.Windows.Forms.TextBox()
        Me.tbNetDisc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.grpSRP = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbPriceCaseC = New System.Windows.Forms.TextBox()
        Me.tbPricePcC = New System.Windows.Forms.TextBox()
        Me.tbPriceBagC = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbPriceCaseB = New System.Windows.Forms.TextBox()
        Me.tbPricePcB = New System.Windows.Forms.TextBox()
        Me.tbPriceBagB = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbPriceCaseA = New System.Windows.Forms.TextBox()
        Me.tbPricePcA = New System.Windows.Forms.TextBox()
        Me.tbPriceBagA = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.grpSupplier = New System.Windows.Forms.GroupBox()
        Me.gbxItem.SuspendLayout()
        CType(Me.nuPcBag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupPcsCase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsItem.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nuItemDisc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSRP.SuspendLayout()
        Me.grpSupplier.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxItem
        '
        Me.gbxItem.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.gbxItem.Controls.Add(Me.lblBrand)
        Me.gbxItem.Controls.Add(Me.lblCategory)
        Me.gbxItem.Controls.Add(Me.lblSupplier)
        Me.gbxItem.Controls.Add(Me.cbxFree)
        Me.gbxItem.Controls.Add(Me.Label4)
        Me.gbxItem.Controls.Add(Me.nuPcBag)
        Me.gbxItem.Controls.Add(Me.nupPcsCase)
        Me.gbxItem.Controls.Add(Me.Label9)
        Me.gbxItem.Controls.Add(Me.Label8)
        Me.gbxItem.Controls.Add(Me.cbxUnit)
        Me.gbxItem.Controls.Add(Me.Label7)
        Me.gbxItem.Controls.Add(Me.cbxBrand)
        Me.gbxItem.Controls.Add(Me.Label5)
        Me.gbxItem.Controls.Add(Me.cbxCategory)
        Me.gbxItem.Controls.Add(Me.cbxSupplier)
        Me.gbxItem.Controls.Add(Me.Label3)
        Me.gbxItem.Controls.Add(Me.Label6)
        Me.gbxItem.Controls.Add(Me.tbItemDescription)
        Me.gbxItem.Controls.Add(Me.Label2)
        Me.gbxItem.Controls.Add(Me.Label1)
        Me.gbxItem.Controls.Add(Me.tbItemCode)
        Me.gbxItem.Location = New System.Drawing.Point(12, 7)
        Me.gbxItem.Name = "gbxItem"
        Me.gbxItem.Size = New System.Drawing.Size(591, 209)
        Me.gbxItem.TabIndex = 78
        Me.gbxItem.TabStop = False
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Location = New System.Drawing.Point(191, 128)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(0, 13)
        Me.lblBrand.TabIndex = 92
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(191, 102)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(0, 13)
        Me.lblCategory.TabIndex = 91
        '
        'lblSupplier
        '
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.Location = New System.Drawing.Point(192, 74)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(0, 13)
        Me.lblSupplier.TabIndex = 90
        '
        'cbxFree
        '
        Me.cbxFree.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxFree.FormattingEnabled = True
        Me.cbxFree.Items.AddRange(New Object() {"Y", "N"})
        Me.cbxFree.Location = New System.Drawing.Point(83, 181)
        Me.cbxFree.Name = "cbxFree"
        Me.cbxFree.Size = New System.Drawing.Size(47, 21)
        Me.cbxFree.TabIndex = 89
        Me.cbxFree.Text = "N"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(136, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 13)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Is This Free Item (No Price)?"
        '
        'nuPcBag
        '
        Me.nuPcBag.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nuPcBag.Location = New System.Drawing.Point(375, 157)
        Me.nuPcBag.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nuPcBag.Name = "nuPcBag"
        Me.nuPcBag.Size = New System.Drawing.Size(89, 22)
        Me.nuPcBag.TabIndex = 71
        Me.nuPcBag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nuPcBag.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nupPcsCase
        '
        Me.nupPcsCase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nupPcsCase.Location = New System.Drawing.Point(207, 156)
        Me.nupPcsCase.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nupPcsCase.Name = "nupPcsCase"
        Me.nupPcsCase.Size = New System.Drawing.Size(89, 22)
        Me.nupPcsCase.TabIndex = 70
        Me.nupPcsCase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nupPcsCase.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(305, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Pieces/Bag :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(133, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Pieces/Case :"
        '
        'cbxUnit
        '
        Me.cbxUnit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxUnit.FormattingEnabled = True
        Me.cbxUnit.Items.AddRange(New Object() {"C", "B", "P"})
        Me.cbxUnit.Location = New System.Drawing.Point(83, 154)
        Me.cbxUnit.Name = "cbxUnit"
        Me.cbxUnit.Size = New System.Drawing.Size(47, 21)
        Me.cbxUnit.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Unit :"
        '
        'cbxBrand
        '
        Me.cbxBrand.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxBrand.FormattingEnabled = True
        Me.cbxBrand.Location = New System.Drawing.Point(86, 123)
        Me.cbxBrand.Name = "cbxBrand"
        Me.cbxBrand.Size = New System.Drawing.Size(97, 21)
        Me.cbxBrand.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Brand :"
        '
        'cbxCategory
        '
        Me.cbxCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxCategory.FormattingEnabled = True
        Me.cbxCategory.Location = New System.Drawing.Point(86, 96)
        Me.cbxCategory.Name = "cbxCategory"
        Me.cbxCategory.Size = New System.Drawing.Size(97, 21)
        Me.cbxCategory.TabIndex = 56
        '
        'cbxSupplier
        '
        Me.cbxSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxSupplier.FormattingEnabled = True
        Me.cbxSupplier.Location = New System.Drawing.Point(87, 69)
        Me.cbxSupplier.Name = "cbxSupplier"
        Me.cbxSupplier.Size = New System.Drawing.Size(97, 21)
        Me.cbxSupplier.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Category :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Supplier :"
        '
        'tbItemDescription
        '
        Me.tbItemDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbItemDescription.Location = New System.Drawing.Point(87, 43)
        Me.tbItemDescription.MaxLength = 40
        Me.tbItemDescription.Name = "tbItemDescription"
        Me.tbItemDescription.Size = New System.Drawing.Size(384, 22)
        Me.tbItemDescription.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Description :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Item Code :"
        '
        'tbItemCode
        '
        Me.tbItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbItemCode.Location = New System.Drawing.Point(87, 17)
        Me.tbItemCode.MaxLength = 10
        Me.tbItemCode.Name = "tbItemCode"
        Me.tbItemCode.Size = New System.Drawing.Size(97, 22)
        Me.tbItemCode.TabIndex = 47
        '
        'lblpk
        '
        Me.lblpk.AutoSize = True
        Me.lblpk.Location = New System.Drawing.Point(631, 33)
        Me.lblpk.Name = "lblpk"
        Me.lblpk.Size = New System.Drawing.Size(20, 13)
        Me.lblpk.TabIndex = 90
        Me.lblpk.Text = "pk"
        '
        'btnCalcPriceC
        '
        Me.btnCalcPriceC.Location = New System.Drawing.Point(625, 162)
        Me.btnCalcPriceC.Name = "btnCalcPriceC"
        Me.btnCalcPriceC.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcPriceC.TabIndex = 86
        Me.btnCalcPriceC.Text = "CalcPriceC"
        Me.btnCalcPriceC.UseVisualStyleBackColor = True
        '
        'btnCalcPriceB
        '
        Me.btnCalcPriceB.Location = New System.Drawing.Point(625, 133)
        Me.btnCalcPriceB.Name = "btnCalcPriceB"
        Me.btnCalcPriceB.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcPriceB.TabIndex = 84
        Me.btnCalcPriceB.Text = "CalcPriceB"
        Me.btnCalcPriceB.UseVisualStyleBackColor = True
        '
        'btnCalcPriceA
        '
        Me.btnCalcPriceA.Location = New System.Drawing.Point(625, 107)
        Me.btnCalcPriceA.Name = "btnCalcPriceA"
        Me.btnCalcPriceA.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcPriceA.TabIndex = 83
        Me.btnCalcPriceA.Text = "CalcPriceA"
        Me.btnCalcPriceA.UseVisualStyleBackColor = True
        '
        'btnCalcCostPc
        '
        Me.btnCalcCostPc.Location = New System.Drawing.Point(625, 80)
        Me.btnCalcCostPc.Name = "btnCalcCostPc"
        Me.btnCalcCostPc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcCostPc.TabIndex = 82
        Me.btnCalcCostPc.Text = "CalcCostPc"
        Me.btnCalcCostPc.UseVisualStyleBackColor = True
        '
        'ClearItem
        '
        Me.ClearItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ClearItem.Image = CType(resources.GetObject("ClearItem.Image"), System.Drawing.Image)
        Me.ClearItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearItem.Name = "ClearItem"
        Me.ClearItem.Size = New System.Drawing.Size(38, 22)
        Me.ClearItem.Text = "&Clear"
        '
        'UpdateItem
        '
        Me.UpdateItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.UpdateItem.Image = CType(resources.GetObject("UpdateItem.Image"), System.Drawing.Image)
        Me.UpdateItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UpdateItem.Name = "UpdateItem"
        Me.UpdateItem.Size = New System.Drawing.Size(49, 22)
        Me.UpdateItem.Text = "&Update"
        Me.UpdateItem.ToolTipText = "S&ave "
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'SaveItem
        '
        Me.SaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveItem.Image = CType(resources.GetObject("SaveItem.Image"), System.Drawing.Image)
        Me.SaveItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveItem.Name = "SaveItem"
        Me.SaveItem.Size = New System.Drawing.Size(35, 22)
        Me.SaveItem.Text = "&Save"
        '
        'tsItem
        '
        Me.tsItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsItem.Dock = System.Windows.Forms.DockStyle.None
        Me.tsItem.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveItem, Me.ToolStripSeparator33, Me.UpdateItem, Me.ToolStripSeparator35, Me.ClearItem})
        Me.tsItem.Location = New System.Drawing.Point(435, 350)
        Me.tsItem.Name = "tsItem"
        Me.tsItem.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsItem.Size = New System.Drawing.Size(137, 25)
        Me.tsItem.TabIndex = 81
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.cbxObsolet)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.nuItemDisc)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 343)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(374, 37)
        Me.GroupBox2.TabIndex = 79
        Me.GroupBox2.TabStop = False
        '
        'cbxObsolet
        '
        Me.cbxObsolet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxObsolet.FormattingEnabled = True
        Me.cbxObsolet.Items.AddRange(New Object() {"Y", "N"})
        Me.cbxObsolet.Location = New System.Drawing.Point(137, 11)
        Me.cbxObsolet.Name = "cbxObsolet"
        Me.cbxObsolet.Size = New System.Drawing.Size(47, 21)
        Me.cbxObsolet.TabIndex = 90
        Me.cbxObsolet.Text = "N"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 14)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(129, 13)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "Phase Out or Obsolete?"
        '
        'nuItemDisc
        '
        Me.nuItemDisc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nuItemDisc.Location = New System.Drawing.Point(302, 10)
        Me.nuItemDisc.Name = "nuItemDisc"
        Me.nuItemDisc.Size = New System.Drawing.Size(66, 22)
        Me.nuItemDisc.TabIndex = 44
        Me.nuItemDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(231, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 13)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "% Discount :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(47, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Gross :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 79)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Cost per Piece :"
        '
        'tbGross
        '
        Me.tbGross.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbGross.Location = New System.Drawing.Point(92, 23)
        Me.tbGross.MaxLength = 20
        Me.tbGross.Name = "tbGross"
        Me.tbGross.Size = New System.Drawing.Size(92, 22)
        Me.tbGross.TabIndex = 27
        Me.tbGross.Text = "0"
        Me.tbGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCostPc
        '
        Me.tbCostPc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCostPc.Location = New System.Drawing.Point(92, 75)
        Me.tbCostPc.MaxLength = 20
        Me.tbCostPc.Name = "tbCostPc"
        Me.tbCostPc.Size = New System.Drawing.Size(92, 22)
        Me.tbCostPc.TabIndex = 31
        Me.tbCostPc.Text = "0"
        Me.tbCostPc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbNetDisc
        '
        Me.tbNetDisc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNetDisc.Location = New System.Drawing.Point(92, 49)
        Me.tbNetDisc.MaxLength = 20
        Me.tbNetDisc.Name = "tbNetDisc"
        Me.tbNetDisc.Size = New System.Drawing.Size(92, 22)
        Me.tbNetDisc.TabIndex = 29
        Me.tbNetDisc.Text = "0"
        Me.tbNetDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Net of Disc :"
        '
        'grpSRP
        '
        Me.grpSRP.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.grpSRP.Controls.Add(Me.Label18)
        Me.grpSRP.Controls.Add(Me.tbPriceCaseC)
        Me.grpSRP.Controls.Add(Me.tbPricePcC)
        Me.grpSRP.Controls.Add(Me.tbPriceBagC)
        Me.grpSRP.Controls.Add(Me.Label17)
        Me.grpSRP.Controls.Add(Me.tbPriceCaseB)
        Me.grpSRP.Controls.Add(Me.tbPricePcB)
        Me.grpSRP.Controls.Add(Me.tbPriceBagB)
        Me.grpSRP.Controls.Add(Me.Label16)
        Me.grpSRP.Controls.Add(Me.Label13)
        Me.grpSRP.Controls.Add(Me.Label14)
        Me.grpSRP.Controls.Add(Me.tbPriceCaseA)
        Me.grpSRP.Controls.Add(Me.tbPricePcA)
        Me.grpSRP.Controls.Add(Me.tbPriceBagA)
        Me.grpSRP.Controls.Add(Me.Label15)
        Me.grpSRP.Location = New System.Drawing.Point(210, 226)
        Me.grpSRP.Name = "grpSRP"
        Me.grpSRP.Size = New System.Drawing.Size(393, 110)
        Me.grpSRP.TabIndex = 75
        Me.grpSRP.TabStop = False
        Me.grpSRP.Text = "Unit Price"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(320, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 13)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "C"
        '
        'tbPriceCaseC
        '
        Me.tbPriceCaseC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbPriceCaseC.Location = New System.Drawing.Point(282, 29)
        Me.tbPriceCaseC.MaxLength = 20
        Me.tbPriceCaseC.Name = "tbPriceCaseC"
        Me.tbPriceCaseC.Size = New System.Drawing.Size(92, 22)
        Me.tbPriceCaseC.TabIndex = 40
        Me.tbPriceCaseC.Text = "0"
        Me.tbPriceCaseC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbPricePcC
        '
        Me.tbPricePcC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbPricePcC.Location = New System.Drawing.Point(282, 81)
        Me.tbPricePcC.MaxLength = 20
        Me.tbPricePcC.Name = "tbPricePcC"
        Me.tbPricePcC.Size = New System.Drawing.Size(92, 22)
        Me.tbPricePcC.TabIndex = 42
        Me.tbPricePcC.Text = "0"
        Me.tbPricePcC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbPriceBagC
        '
        Me.tbPriceBagC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbPriceBagC.Location = New System.Drawing.Point(282, 55)
        Me.tbPriceBagC.MaxLength = 20
        Me.tbPriceBagC.Name = "tbPriceBagC"
        Me.tbPriceBagC.Size = New System.Drawing.Size(92, 22)
        Me.tbPriceBagC.TabIndex = 41
        Me.tbPriceBagC.Text = "0"
        Me.tbPriceBagC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(222, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 13)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "B"
        '
        'tbPriceCaseB
        '
        Me.tbPriceCaseB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbPriceCaseB.Location = New System.Drawing.Point(184, 29)
        Me.tbPriceCaseB.MaxLength = 20
        Me.tbPriceCaseB.Name = "tbPriceCaseB"
        Me.tbPriceCaseB.Size = New System.Drawing.Size(92, 22)
        Me.tbPriceCaseB.TabIndex = 36
        Me.tbPriceCaseB.Text = "0"
        Me.tbPriceCaseB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbPricePcB
        '
        Me.tbPricePcB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbPricePcB.Location = New System.Drawing.Point(184, 81)
        Me.tbPricePcB.MaxLength = 20
        Me.tbPricePcB.Name = "tbPricePcB"
        Me.tbPricePcB.Size = New System.Drawing.Size(92, 22)
        Me.tbPricePcB.TabIndex = 38
        Me.tbPricePcB.Text = "0"
        Me.tbPricePcB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbPriceBagB
        '
        Me.tbPriceBagB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbPriceBagB.Location = New System.Drawing.Point(184, 55)
        Me.tbPriceBagB.MaxLength = 20
        Me.tbPriceBagB.Name = "tbPriceBagB"
        Me.tbPriceBagB.Size = New System.Drawing.Size(92, 22)
        Me.tbPriceBagB.TabIndex = 37
        Me.tbPriceBagB.Text = "0"
        Me.tbPriceBagB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(122, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(14, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "A"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Price/Case :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 85)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Price/Piece :"
        '
        'tbPriceCaseA
        '
        Me.tbPriceCaseA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbPriceCaseA.Location = New System.Drawing.Point(84, 29)
        Me.tbPriceCaseA.MaxLength = 20
        Me.tbPriceCaseA.Name = "tbPriceCaseA"
        Me.tbPriceCaseA.Size = New System.Drawing.Size(92, 22)
        Me.tbPriceCaseA.TabIndex = 27
        Me.tbPriceCaseA.Text = "0"
        Me.tbPriceCaseA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbPricePcA
        '
        Me.tbPricePcA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbPricePcA.Location = New System.Drawing.Point(84, 81)
        Me.tbPricePcA.MaxLength = 20
        Me.tbPricePcA.Name = "tbPricePcA"
        Me.tbPricePcA.Size = New System.Drawing.Size(92, 22)
        Me.tbPricePcA.TabIndex = 31
        Me.tbPricePcA.Text = "0"
        Me.tbPricePcA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbPriceBagA
        '
        Me.tbPriceBagA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbPriceBagA.Location = New System.Drawing.Point(84, 55)
        Me.tbPriceBagA.MaxLength = 20
        Me.tbPriceBagA.Name = "tbPriceBagA"
        Me.tbPriceBagA.Size = New System.Drawing.Size(92, 22)
        Me.tbPriceBagA.TabIndex = 29
        Me.tbPriceBagA.Text = "0"
        Me.tbPriceBagA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(21, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Price/Bag :"
        '
        'grpSupplier
        '
        Me.grpSupplier.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.grpSupplier.Controls.Add(Me.Label10)
        Me.grpSupplier.Controls.Add(Me.Label12)
        Me.grpSupplier.Controls.Add(Me.tbGross)
        Me.grpSupplier.Controls.Add(Me.tbCostPc)
        Me.grpSupplier.Controls.Add(Me.tbNetDisc)
        Me.grpSupplier.Controls.Add(Me.Label11)
        Me.grpSupplier.Location = New System.Drawing.Point(12, 225)
        Me.grpSupplier.Name = "grpSupplier"
        Me.grpSupplier.Size = New System.Drawing.Size(193, 109)
        Me.grpSupplier.TabIndex = 74
        Me.grpSupplier.TabStop = False
        Me.grpSupplier.Text = "Supplier Cost"
        '
        'frmItemD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 392)
        Me.Controls.Add(Me.lblpk)
        Me.Controls.Add(Me.gbxItem)
        Me.Controls.Add(Me.tsItem)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpSRP)
        Me.Controls.Add(Me.grpSupplier)
        Me.Controls.Add(Me.btnCalcCostPc)
        Me.Controls.Add(Me.btnCalcPriceA)
        Me.Controls.Add(Me.btnCalcPriceB)
        Me.Controls.Add(Me.btnCalcPriceC)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItemD"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ITEM CODE"
        Me.gbxItem.ResumeLayout(False)
        Me.gbxItem.PerformLayout()
        CType(Me.nuPcBag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupPcsCase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsItem.ResumeLayout(False)
        Me.tsItem.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nuItemDisc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSRP.ResumeLayout(False)
        Me.grpSRP.PerformLayout()
        Me.grpSupplier.ResumeLayout(False)
        Me.grpSupplier.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxItem As System.Windows.Forms.GroupBox
    Friend WithEvents nuPcBag As System.Windows.Forms.NumericUpDown
    Friend WithEvents nupPcsCase As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbxUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbxBrand As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cbxSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbItemDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbItemCode As System.Windows.Forms.TextBox
    Friend WithEvents ClearItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UpdateItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsItem As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents nuItemDisc As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbGross As System.Windows.Forms.TextBox
    Friend WithEvents tbCostPc As System.Windows.Forms.TextBox
    Friend WithEvents tbNetDisc As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents grpSRP As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tbPriceCaseC As System.Windows.Forms.TextBox
    Friend WithEvents tbPricePcC As System.Windows.Forms.TextBox
    Friend WithEvents tbPriceBagC As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tbPriceCaseB As System.Windows.Forms.TextBox
    Friend WithEvents tbPricePcB As System.Windows.Forms.TextBox
    Friend WithEvents tbPriceBagB As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbPriceCaseA As System.Windows.Forms.TextBox
    Friend WithEvents tbPricePcA As System.Windows.Forms.TextBox
    Friend WithEvents tbPriceBagA As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents grpSupplier As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalcPriceC As System.Windows.Forms.Button
    Friend WithEvents btnCalcPriceB As System.Windows.Forms.Button
    Friend WithEvents btnCalcPriceA As System.Windows.Forms.Button
    Friend WithEvents btnCalcCostPc As System.Windows.Forms.Button
    Friend WithEvents cbxFree As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxObsolet As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblpk As System.Windows.Forms.Label
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
End Class
