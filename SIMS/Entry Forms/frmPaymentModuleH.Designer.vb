<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentModuleH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentModuleH))
        Me.dgvDebitMemo = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbSearcDM = New System.Windows.Forms.TextBox()
        Me.tsGOPayment = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsgo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpCM2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpCM1 = New System.Windows.Forms.DateTimePicker()
        Me.tsPayment = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAddPayment = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsEditPayment = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDeletePayment = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvDebitMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsGOPayment.SuspendLayout()
        Me.tsPayment.SuspendLayout()
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
        Me.dgvDebitMemo.Size = New System.Drawing.Size(788, 384)
        Me.dgvDebitMemo.TabIndex = 48
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
        Me.Column4.Width = 250
        '
        'Column5
        '
        Me.Column5.HeaderText = "SALESMAN"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "AMOUNT"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "ENTERED BY"
        Me.Column7.Name = "Column7"
        '
        'tbSearcDM
        '
        Me.tbSearcDM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearcDM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSearcDM.Location = New System.Drawing.Point(13, 5)
        Me.tbSearcDM.MaxLength = 50
        Me.tbSearcDM.Name = "tbSearcDM"
        Me.tbSearcDM.Size = New System.Drawing.Size(239, 22)
        Me.tbSearcDM.TabIndex = 50
        '
        'tsGOPayment
        '
        Me.tsGOPayment.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsGOPayment.Dock = System.Windows.Forms.DockStyle.None
        Me.tsGOPayment.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsGOPayment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsgo, Me.ToolStripSeparator2})
        Me.tsGOPayment.Location = New System.Drawing.Point(758, 5)
        Me.tsGOPayment.Name = "tsGOPayment"
        Me.tsGOPayment.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsGOPayment.Size = New System.Drawing.Size(43, 25)
        Me.tsGOPayment.TabIndex = 59
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Location = New System.Drawing.Point(629, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "To"
        '
        'dtpCM2
        '
        Me.dtpCM2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpCM2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCM2.Location = New System.Drawing.Point(655, 6)
        Me.dtpCM2.Name = "dtpCM2"
        Me.dtpCM2.Size = New System.Drawing.Size(93, 22)
        Me.dtpCM2.TabIndex = 56
        '
        'dtpCM1
        '
        Me.dtpCM1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpCM1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCM1.Location = New System.Drawing.Point(527, 6)
        Me.dtpCM1.Name = "dtpCM1"
        Me.dtpCM1.Size = New System.Drawing.Size(93, 22)
        Me.dtpCM1.TabIndex = 55
        '
        'tsPayment
        '
        Me.tsPayment.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsPayment.Dock = System.Windows.Forms.DockStyle.None
        Me.tsPayment.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsPayment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsAddPayment, Me.ToolStripSeparator33, Me.tsEditPayment, Me.ToolStripSeparator34, Me.tsDeletePayment, Me.ToolStripSeparator35})
        Me.tsPayment.Location = New System.Drawing.Point(278, 423)
        Me.tsPayment.Name = "tsPayment"
        Me.tsPayment.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsPayment.Size = New System.Drawing.Size(294, 25)
        Me.tsPayment.TabIndex = 60
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'tsAddPayment
        '
        Me.tsAddPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsAddPayment.Image = CType(resources.GetObject("tsAddPayment.Image"), System.Drawing.Image)
        Me.tsAddPayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAddPayment.Name = "tsAddPayment"
        Me.tsAddPayment.Size = New System.Drawing.Size(66, 22)
        Me.tsAddPayment.Text = "[F5] - ADD"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'tsEditPayment
        '
        Me.tsEditPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsEditPayment.Image = CType(resources.GetObject("tsEditPayment.Image"), System.Drawing.Image)
        Me.tsEditPayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEditPayment.Name = "tsEditPayment"
        Me.tsEditPayment.Size = New System.Drawing.Size(89, 22)
        Me.tsEditPayment.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'tsDeletePayment
        '
        Me.tsDeletePayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsDeletePayment.Image = CType(resources.GetObject("tsDeletePayment.Image"), System.Drawing.Image)
        Me.tsDeletePayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDeletePayment.Name = "tsDeletePayment"
        Me.tsDeletePayment.Size = New System.Drawing.Size(81, 22)
        Me.tsDeletePayment.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(450, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Date Range :"
        '
        'frmPaymentModuleH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 451)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tsPayment)
        Me.Controls.Add(Me.tsGOPayment)
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
        Me.Name = "frmPaymentModuleH"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAYMENT LIST"
        CType(Me.dgvDebitMemo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsGOPayment.ResumeLayout(False)
        Me.tsGOPayment.PerformLayout()
        Me.tsPayment.ResumeLayout(False)
        Me.tsPayment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDebitMemo As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbSearcDM As System.Windows.Forms.TextBox
    Friend WithEvents tsGOPayment As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsgo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpCM2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCM1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tsPayment As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsAddPayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsEditPayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDeletePayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
