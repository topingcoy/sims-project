<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummaryCreditMemo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSummaryCreditMemo))
        Me.dgvSummaryCM = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblOutletType = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbOutletType = New System.Windows.Forms.TextBox()
        Me.lblAreaTerritory = New System.Windows.Forms.Label()
        Me.lblAreaT = New System.Windows.Forms.Label()
        Me.tbArea = New System.Windows.Forms.TextBox()
        Me.lblWhs = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbWhs = New System.Windows.Forms.TextBox()
        Me.lblSalesmanName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSalesman = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpCMEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpCMStart = New System.Windows.Forms.DateTimePicker()
        Me.tsSummaryCM = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.Go = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintSummaryCM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbTotalCM = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvSummaryCM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsSummaryCM.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSummaryCM
        '
        Me.dgvSummaryCM.AllowUserToAddRows = False
        Me.dgvSummaryCM.AllowUserToResizeRows = False
        Me.dgvSummaryCM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSummaryCM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSummaryCM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvSummaryCM.Location = New System.Drawing.Point(12, 147)
        Me.dgvSummaryCM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvSummaryCM.Name = "dgvSummaryCM"
        Me.dgvSummaryCM.RowHeadersVisible = False
        Me.dgvSummaryCM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSummaryCM.Size = New System.Drawing.Size(723, 293)
        Me.dgvSummaryCM.TabIndex = 18
        '
        'Column1
        '
        Me.Column1.HeaderText = "SALESMAN"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "CUSTOMER NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 300
        '
        'Column3
        '
        Me.Column3.HeaderText = "AMOUNT"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "APPLIED"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "BALANCE"
        Me.Column5.Name = "Column5"
        '
        'lblOutletType
        '
        Me.lblOutletType.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutletType.Location = New System.Drawing.Point(266, 120)
        Me.lblOutletType.Name = "lblOutletType"
        Me.lblOutletType.Size = New System.Drawing.Size(316, 22)
        Me.lblOutletType.TabIndex = 225
        Me.lblOutletType.Text = "OUTLET TYPE"
        Me.lblOutletType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblOutletType.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 13)
        Me.Label6.TabIndex = 224
        Me.Label6.Text = "Outlet Type [Blank = All] :"
        '
        'tbOutletType
        '
        Me.tbOutletType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbOutletType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbOutletType.Location = New System.Drawing.Point(167, 120)
        Me.tbOutletType.MaxLength = 50
        Me.tbOutletType.Name = "tbOutletType"
        Me.tbOutletType.Size = New System.Drawing.Size(92, 22)
        Me.tbOutletType.TabIndex = 223
        '
        'lblAreaTerritory
        '
        Me.lblAreaTerritory.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreaTerritory.Location = New System.Drawing.Point(266, 95)
        Me.lblAreaTerritory.Name = "lblAreaTerritory"
        Me.lblAreaTerritory.Size = New System.Drawing.Size(316, 22)
        Me.lblAreaTerritory.TabIndex = 222
        Me.lblAreaTerritory.Text = "AREA/TERRITORY"
        Me.lblAreaTerritory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAreaTerritory.Visible = False
        '
        'lblAreaT
        '
        Me.lblAreaT.AutoSize = True
        Me.lblAreaT.Location = New System.Drawing.Point(17, 99)
        Me.lblAreaT.Name = "lblAreaT"
        Me.lblAreaT.Size = New System.Drawing.Size(146, 13)
        Me.lblAreaT.TabIndex = 221
        Me.lblAreaT.Text = "Area/Territory [Blank = All] :"
        '
        'tbArea
        '
        Me.tbArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbArea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbArea.Location = New System.Drawing.Point(167, 95)
        Me.tbArea.MaxLength = 50
        Me.tbArea.Name = "tbArea"
        Me.tbArea.Size = New System.Drawing.Size(92, 22)
        Me.tbArea.TabIndex = 220
        '
        'lblWhs
        '
        Me.lblWhs.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhs.Location = New System.Drawing.Point(266, 70)
        Me.lblWhs.Name = "lblWhs"
        Me.lblWhs.Size = New System.Drawing.Size(316, 22)
        Me.lblWhs.TabIndex = 208
        Me.lblWhs.Text = "WAREHOUSE NAME"
        Me.lblWhs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblWhs.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 13)
        Me.Label5.TabIndex = 207
        Me.Label5.Text = "Warehouse [Blank = All] :"
        '
        'tbWhs
        '
        Me.tbWhs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbWhs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbWhs.Location = New System.Drawing.Point(167, 70)
        Me.tbWhs.MaxLength = 50
        Me.tbWhs.Name = "tbWhs"
        Me.tbWhs.Size = New System.Drawing.Size(92, 22)
        Me.tbWhs.TabIndex = 206
        '
        'lblSalesmanName
        '
        Me.lblSalesmanName.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesmanName.Location = New System.Drawing.Point(266, 45)
        Me.lblSalesmanName.Name = "lblSalesmanName"
        Me.lblSalesmanName.Size = New System.Drawing.Size(316, 22)
        Me.lblSalesmanName.TabIndex = 205
        Me.lblSalesmanName.Text = "SALESMAN NAME"
        Me.lblSalesmanName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSalesmanName.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 204
        Me.Label1.Text = "Salesman [Blank = All] :"
        '
        'tbSalesman
        '
        Me.tbSalesman.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSalesman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSalesman.Location = New System.Drawing.Point(167, 45)
        Me.tbSalesman.MaxLength = 50
        Me.tbSalesman.Name = "tbSalesman"
        Me.tbSalesman.Size = New System.Drawing.Size(92, 22)
        Me.tbSalesman.TabIndex = 203
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 229
        Me.Label3.Text = "Ending Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 228
        Me.Label2.Text = "Starting Date :"
        '
        'dtpCMEnd
        '
        Me.dtpCMEnd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpCMEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCMEnd.Location = New System.Drawing.Point(343, 17)
        Me.dtpCMEnd.Name = "dtpCMEnd"
        Me.dtpCMEnd.Size = New System.Drawing.Size(93, 22)
        Me.dtpCMEnd.TabIndex = 227
        '
        'dtpCMStart
        '
        Me.dtpCMStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpCMStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCMStart.Location = New System.Drawing.Point(166, 17)
        Me.dtpCMStart.Name = "dtpCMStart"
        Me.dtpCMStart.Size = New System.Drawing.Size(93, 22)
        Me.dtpCMStart.TabIndex = 226
        '
        'tsSummaryCM
        '
        Me.tsSummaryCM.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsSummaryCM.Dock = System.Windows.Forms.DockStyle.None
        Me.tsSummaryCM.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsSummaryCM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.Go, Me.ToolStripSeparator33, Me.PrintSummaryCM, Me.ToolStripSeparator34})
        Me.tsSummaryCM.Location = New System.Drawing.Point(602, 9)
        Me.tsSummaryCM.Name = "tsSummaryCM"
        Me.tsSummaryCM.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsSummaryCM.Size = New System.Drawing.Size(129, 25)
        Me.tsSummaryCM.TabIndex = 230
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
        'PrintSummaryCM
        '
        Me.PrintSummaryCM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PrintSummaryCM.Image = CType(resources.GetObject("PrintSummaryCM.Image"), System.Drawing.Image)
        Me.PrintSummaryCM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintSummaryCM.Name = "PrintSummaryCM"
        Me.PrintSummaryCM.Size = New System.Drawing.Size(80, 22)
        Me.PrintSummaryCM.Text = "Print Preview"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'tbTotalCM
        '
        Me.tbTotalCM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTotalCM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbTotalCM.Location = New System.Drawing.Point(416, 445)
        Me.tbTotalCM.MaxLength = 50
        Me.tbTotalCM.Name = "tbTotalCM"
        Me.tbTotalCM.ReadOnly = True
        Me.tbTotalCM.Size = New System.Drawing.Size(109, 22)
        Me.tbTotalCM.TabIndex = 231
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(366, 449)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 232
        Me.Label4.Text = "TOTAL :"
        '
        'frmSummaryCreditMemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 472)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbTotalCM)
        Me.Controls.Add(Me.tsSummaryCM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpCMEnd)
        Me.Controls.Add(Me.dtpCMStart)
        Me.Controls.Add(Me.lblOutletType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbOutletType)
        Me.Controls.Add(Me.lblAreaTerritory)
        Me.Controls.Add(Me.lblAreaT)
        Me.Controls.Add(Me.tbArea)
        Me.Controls.Add(Me.lblWhs)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbWhs)
        Me.Controls.Add(Me.lblSalesmanName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbSalesman)
        Me.Controls.Add(Me.dgvSummaryCM)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSummaryCreditMemo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUMMARY OF CREDIT MEMO"
        CType(Me.dgvSummaryCM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsSummaryCM.ResumeLayout(False)
        Me.tsSummaryCM.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSummaryCM As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblOutletType As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbOutletType As System.Windows.Forms.TextBox
    Friend WithEvents lblAreaTerritory As System.Windows.Forms.Label
    Friend WithEvents lblAreaT As System.Windows.Forms.Label
    Friend WithEvents tbArea As System.Windows.Forms.TextBox
    Friend WithEvents lblWhs As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbWhs As System.Windows.Forms.TextBox
    Friend WithEvents lblSalesmanName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbSalesman As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpCMEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCMStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents tsSummaryCM As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Go As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintSummaryCM As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbTotalCM As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
