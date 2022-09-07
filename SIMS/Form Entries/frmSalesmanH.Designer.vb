<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesmanH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesmanH))
        Me.tbSearchSlsman = New System.Windows.Forms.TextBox()
        Me.dgvSalesmanList = New System.Windows.Forms.DataGridView()
        Me.tsSalesman = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator36 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsaddsalesman = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator38 = New System.Windows.Forms.ToolStripSeparator()
        Me.tseditsalesman = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator39 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsdeletesalesman = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator40 = New System.Windows.Forms.ToolStripSeparator()
        Me.gbxSalesman = New System.Windows.Forms.GroupBox()
        Me.gbxAddSalesmn = New System.Windows.Forms.ToolStrip()
        Me.tsnew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tscloses = New System.Windows.Forms.ToolStripButton()
        Me.cboTO = New System.Windows.Forms.ComboBox()
        Me.cboWT = New System.Windows.Forms.ComboBox()
        Me.cboBT = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSalesmaname = New System.Windows.Forms.TextBox()
        Me.txtSalesmancode = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvSalesmanList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsSalesman.SuspendLayout()
        Me.gbxSalesman.SuspendLayout()
        Me.gbxAddSalesmn.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbSearchSlsman
        '
        Me.tbSearchSlsman.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchSlsman.Location = New System.Drawing.Point(12, 11)
        Me.tbSearchSlsman.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbSearchSlsman.MaxLength = 50
        Me.tbSearchSlsman.Name = "tbSearchSlsman"
        Me.tbSearchSlsman.Size = New System.Drawing.Size(313, 22)
        Me.tbSearchSlsman.TabIndex = 29
        '
        'dgvSalesmanList
        '
        Me.dgvSalesmanList.AllowUserToAddRows = False
        Me.dgvSalesmanList.AllowUserToResizeRows = False
        Me.dgvSalesmanList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSalesmanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalesmanList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column6, Me.Column8})
        Me.dgvSalesmanList.Location = New System.Drawing.Point(12, 37)
        Me.dgvSalesmanList.Name = "dgvSalesmanList"
        Me.dgvSalesmanList.RowHeadersVisible = False
        Me.dgvSalesmanList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSalesmanList.Size = New System.Drawing.Size(631, 330)
        Me.dgvSalesmanList.TabIndex = 28
        '
        'tsSalesman
        '
        Me.tsSalesman.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsSalesman.Dock = System.Windows.Forms.DockStyle.None
        Me.tsSalesman.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsSalesman.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator36, Me.tsaddsalesman, Me.ToolStripSeparator38, Me.tseditsalesman, Me.ToolStripSeparator39, Me.tsdeletesalesman, Me.ToolStripSeparator40})
        Me.tsSalesman.Location = New System.Drawing.Point(195, 373)
        Me.tsSalesman.Name = "tsSalesman"
        Me.tsSalesman.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsSalesman.Size = New System.Drawing.Size(260, 25)
        Me.tsSalesman.TabIndex = 32
        '
        'ToolStripSeparator36
        '
        Me.ToolStripSeparator36.Name = "ToolStripSeparator36"
        Me.ToolStripSeparator36.Size = New System.Drawing.Size(6, 25)
        '
        'tsaddsalesman
        '
        Me.tsaddsalesman.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsaddsalesman.Image = CType(resources.GetObject("tsaddsalesman.Image"), System.Drawing.Image)
        Me.tsaddsalesman.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsaddsalesman.Name = "tsaddsalesman"
        Me.tsaddsalesman.Size = New System.Drawing.Size(66, 22)
        Me.tsaddsalesman.Text = "[F5] - ADD"
        '
        'ToolStripSeparator38
        '
        Me.ToolStripSeparator38.Name = "ToolStripSeparator38"
        Me.ToolStripSeparator38.Size = New System.Drawing.Size(6, 25)
        '
        'tseditsalesman
        '
        Me.tseditsalesman.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tseditsalesman.Image = CType(resources.GetObject("tseditsalesman.Image"), System.Drawing.Image)
        Me.tseditsalesman.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tseditsalesman.Name = "tseditsalesman"
        Me.tseditsalesman.Size = New System.Drawing.Size(87, 22)
        Me.tseditsalesman.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator39
        '
        Me.ToolStripSeparator39.Name = "ToolStripSeparator39"
        Me.ToolStripSeparator39.Size = New System.Drawing.Size(6, 25)
        '
        'tsdeletesalesman
        '
        Me.tsdeletesalesman.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsdeletesalesman.Image = CType(resources.GetObject("tsdeletesalesman.Image"), System.Drawing.Image)
        Me.tsdeletesalesman.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsdeletesalesman.Name = "tsdeletesalesman"
        Me.tsdeletesalesman.Size = New System.Drawing.Size(80, 22)
        Me.tsdeletesalesman.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator40
        '
        Me.ToolStripSeparator40.Name = "ToolStripSeparator40"
        Me.ToolStripSeparator40.Size = New System.Drawing.Size(6, 25)
        '
        'gbxSalesman
        '
        Me.gbxSalesman.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbxSalesman.Controls.Add(Me.gbxAddSalesmn)
        Me.gbxSalesman.Controls.Add(Me.cboTO)
        Me.gbxSalesman.Controls.Add(Me.cboWT)
        Me.gbxSalesman.Controls.Add(Me.cboBT)
        Me.gbxSalesman.Controls.Add(Me.Label7)
        Me.gbxSalesman.Controls.Add(Me.Label6)
        Me.gbxSalesman.Controls.Add(Me.Label5)
        Me.gbxSalesman.Controls.Add(Me.Label2)
        Me.gbxSalesman.Controls.Add(Me.Label1)
        Me.gbxSalesman.Controls.Add(Me.txtSalesmaname)
        Me.gbxSalesman.Controls.Add(Me.txtSalesmancode)
        Me.gbxSalesman.Location = New System.Drawing.Point(151, 92)
        Me.gbxSalesman.Name = "gbxSalesman"
        Me.gbxSalesman.Size = New System.Drawing.Size(337, 231)
        Me.gbxSalesman.TabIndex = 33
        Me.gbxSalesman.TabStop = False
        Me.gbxSalesman.Text = "ADD SALESMAN"
        Me.gbxSalesman.Visible = False
        '
        'gbxAddSalesmn
        '
        Me.gbxAddSalesmn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gbxAddSalesmn.Dock = System.Windows.Forms.DockStyle.None
        Me.gbxAddSalesmn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.gbxAddSalesmn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsnew, Me.ToolStripSeparator33, Me.tssave, Me.ToolStripSeparator35, Me.ToolStripButton1, Me.ToolStripSeparator3, Me.tscloses})
        Me.gbxAddSalesmn.Location = New System.Drawing.Point(146, 198)
        Me.gbxAddSalesmn.Name = "gbxAddSalesmn"
        Me.gbxAddSalesmn.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.gbxAddSalesmn.Size = New System.Drawing.Size(169, 25)
        Me.gbxAddSalesmn.TabIndex = 74
        '
        'tsnew
        '
        Me.tsnew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsnew.Image = CType(resources.GetObject("tsnew.Image"), System.Drawing.Image)
        Me.tsnew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsnew.Name = "tsnew"
        Me.tsnew.Size = New System.Drawing.Size(35, 22)
        Me.tsnew.Text = "&New"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'tssave
        '
        Me.tssave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tssave.Image = CType(resources.GetObject("tssave.Image"), System.Drawing.Image)
        Me.tssave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssave.Name = "tssave"
        Me.tssave.Size = New System.Drawing.Size(35, 22)
        Me.tssave.Text = "&Save"
        Me.tssave.ToolTipText = "S&ave "
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(38, 22)
        Me.ToolStripButton1.Text = "&Clear"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tscloses
        '
        Me.tscloses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tscloses.Image = CType(resources.GetObject("tscloses.Image"), System.Drawing.Image)
        Me.tscloses.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tscloses.Name = "tscloses"
        Me.tscloses.Size = New System.Drawing.Size(40, 22)
        Me.tscloses.Text = "&Close"
        '
        'cboTO
        '
        Me.cboTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTO.FormattingEnabled = True
        Me.cboTO.Location = New System.Drawing.Point(97, 174)
        Me.cboTO.Name = "cboTO"
        Me.cboTO.Size = New System.Drawing.Size(217, 21)
        Me.cboTO.TabIndex = 48
        '
        'cboWT
        '
        Me.cboWT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWT.FormattingEnabled = True
        Me.cboWT.Location = New System.Drawing.Point(97, 147)
        Me.cboWT.Name = "cboWT"
        Me.cboWT.Size = New System.Drawing.Size(217, 21)
        Me.cboWT.TabIndex = 47
        '
        'cboBT
        '
        Me.cboBT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBT.FormattingEnabled = True
        Me.cboBT.Items.AddRange(New Object() {"B", "T"})
        Me.cboBT.Location = New System.Drawing.Point(216, 120)
        Me.cboBT.Name = "cboBT"
        Me.cboBT.Size = New System.Drawing.Size(40, 21)
        Me.cboBT.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "TYPE "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "WAREHOUSE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "B = BOOKING, T = TRUCK SALESMAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SALESMAN NAME "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CODE "
        '
        'txtSalesmaname
        '
        Me.txtSalesmaname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSalesmaname.Location = New System.Drawing.Point(19, 88)
        Me.txtSalesmaname.MaxLength = 50
        Me.txtSalesmaname.Name = "txtSalesmaname"
        Me.txtSalesmaname.Size = New System.Drawing.Size(295, 22)
        Me.txtSalesmaname.TabIndex = 1
        '
        'txtSalesmancode
        '
        Me.txtSalesmancode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSalesmancode.Location = New System.Drawing.Point(19, 45)
        Me.txtSalesmancode.MaxLength = 5
        Me.txtSalesmancode.Name = "txtSalesmancode"
        Me.txtSalesmancode.Size = New System.Drawing.Size(77, 22)
        Me.txtSalesmancode.TabIndex = 0
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
        Me.Column2.HeaderText = "CODE"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 62
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "SALESMAN NAME"
        Me.Column3.Name = "Column3"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "WAREHOUSE"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "TYPE-OPER"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 87
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "ADDED-BY"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 84
        '
        'frmSalesmanH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 406)
        Me.Controls.Add(Me.gbxSalesman)
        Me.Controls.Add(Me.tsSalesman)
        Me.Controls.Add(Me.tbSearchSlsman)
        Me.Controls.Add(Me.dgvSalesmanList)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalesmanH"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALESMAN LIST"
        CType(Me.dgvSalesmanList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsSalesman.ResumeLayout(False)
        Me.tsSalesman.PerformLayout()
        Me.gbxSalesman.ResumeLayout(False)
        Me.gbxSalesman.PerformLayout()
        Me.gbxAddSalesmn.ResumeLayout(False)
        Me.gbxAddSalesmn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbSearchSlsman As System.Windows.Forms.TextBox
    Friend WithEvents dgvSalesmanList As System.Windows.Forms.DataGridView
    Friend WithEvents tsSalesman As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator36 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsaddsalesman As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator38 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tseditsalesman As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator39 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsdeletesalesman As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator40 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents gbxSalesman As System.Windows.Forms.GroupBox
    Friend WithEvents gbxAddSalesmn As System.Windows.Forms.ToolStrip
    Friend WithEvents tsnew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tssave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tscloses As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboTO As System.Windows.Forms.ComboBox
    Friend WithEvents cboWT As System.Windows.Forms.ComboBox
    Friend WithEvents cboBT As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSalesmaname As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesmancode As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
