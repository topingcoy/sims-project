<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookingARCollH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookingARCollH))
        Me.dgvDebitMemo = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbSearcDM = New System.Windows.Forms.TextBox()
        Me.tsMenu2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpCM2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpCM1 = New System.Windows.Forms.DateTimePicker()
        Me.tsMenu1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvDebitMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenu2.SuspendLayout()
        Me.tsMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDebitMemo
        '
        Me.dgvDebitMemo.AllowUserToAddRows = False
        Me.dgvDebitMemo.AllowUserToResizeRows = False
        Me.dgvDebitMemo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvDebitMemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDebitMemo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgvDebitMemo.Location = New System.Drawing.Point(13, 33)
        Me.dgvDebitMemo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvDebitMemo.Name = "dgvDebitMemo"
        Me.dgvDebitMemo.RowHeadersVisible = False
        Me.dgvDebitMemo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDebitMemo.Size = New System.Drawing.Size(850, 384)
        Me.dgvDebitMemo.TabIndex = 48
        '
        'Column1
        '
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 39
        '
        'Column2
        '
        Me.Column2.HeaderText = "DATE"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 75
        '
        'Column3
        '
        Me.Column3.HeaderText = "C.S. NO."
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "CUSTOMER NAME"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 340
        '
        'Column5
        '
        Me.Column5.HeaderText = "SALESMAN"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 75
        '
        'Column6
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column6.HeaderText = "AMOUNT"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "USER"
        Me.Column7.Name = "Column7"
        '
        'tbSearcDM
        '
        Me.tbSearcDM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearcDM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSearcDM.Location = New System.Drawing.Point(13, 5)
        Me.tbSearcDM.MaxLength = 50
        Me.tbSearcDM.Name = "tbSearcDM"
        Me.tbSearcDM.Size = New System.Drawing.Size(209, 22)
        Me.tbSearcDM.TabIndex = 50
        '
        'tsMenu2
        '
        Me.tsMenu2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsMenu2.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMenu2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenu2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnGo, Me.ToolStripSeparator2})
        Me.tsMenu2.Location = New System.Drawing.Point(820, 5)
        Me.tsMenu2.Name = "tsMenu2"
        Me.tsMenu2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsMenu2.Size = New System.Drawing.Size(43, 25)
        Me.tsMenu2.TabIndex = 59
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnGo
        '
        Me.btnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnGo.Image = CType(resources.GetObject("btnGo.Image"), System.Drawing.Image)
        Me.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(28, 22)
        Me.btnGo.Text = "GO"
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
        Me.Label1.Location = New System.Drawing.Point(691, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "To"
        '
        'dtpCM2
        '
        Me.dtpCM2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpCM2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCM2.Location = New System.Drawing.Point(717, 6)
        Me.dtpCM2.Name = "dtpCM2"
        Me.dtpCM2.Size = New System.Drawing.Size(93, 22)
        Me.dtpCM2.TabIndex = 56
        '
        'dtpCM1
        '
        Me.dtpCM1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpCM1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCM1.Location = New System.Drawing.Point(589, 6)
        Me.dtpCM1.Name = "dtpCM1"
        Me.dtpCM1.Size = New System.Drawing.Size(93, 22)
        Me.dtpCM1.TabIndex = 55
        '
        'tsMenu1
        '
        Me.tsMenu1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsMenu1.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMenu1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.btnAdd, Me.ToolStripSeparator33, Me.btnEdit, Me.ToolStripSeparator34, Me.btnDelete, Me.ToolStripSeparator35})
        Me.tsMenu1.Location = New System.Drawing.Point(293, 423)
        Me.tsMenu1.Name = "tsMenu1"
        Me.tsMenu1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsMenu1.Size = New System.Drawing.Size(260, 25)
        Me.tsMenu1.TabIndex = 60
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'btnAdd
        '
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(66, 22)
        Me.btnAdd.Text = "[F5] - ADD"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'btnEdit
        '
        Me.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(87, 22)
        Me.btnEdit.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 22)
        Me.btnDelete.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(512, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Date Range :"
        '
        'frmBookingARCollH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 453)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tsMenu1)
        Me.Controls.Add(Me.tsMenu2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpCM2)
        Me.Controls.Add(Me.dtpCM1)
        Me.Controls.Add(Me.tbSearcDM)
        Me.Controls.Add(Me.dgvDebitMemo)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBookingARCollH"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BOOKING A/R COLLECTION LIST"
        CType(Me.dgvDebitMemo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenu2.ResumeLayout(False)
        Me.tsMenu2.PerformLayout()
        Me.tsMenu1.ResumeLayout(False)
        Me.tsMenu1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDebitMemo As System.Windows.Forms.DataGridView
    Friend WithEvents tbSearcDM As System.Windows.Forms.TextBox
    Friend WithEvents tsMenu2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpCM2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCM1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tsMenu1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
