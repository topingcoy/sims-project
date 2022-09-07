<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBOReturnH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBOReturnH))
        Me.dgvBOList = New System.Windows.Forms.DataGridView()
        Me.Go = New System.Windows.Forms.ToolStripButton()
        Me.tsBOGo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxViewPaid = New System.Windows.Forms.CheckBox()
        Me.tbSearchBO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpBO2 = New System.Windows.Forms.DateTimePicker()
        Me.DeleteBO = New System.Windows.Forms.ToolStripButton()
        Me.tsBOList = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddBO = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditBO = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.dtpBO1 = New System.Windows.Forms.DateTimePicker()
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
        CType(Me.dgvBOList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsBOGo.SuspendLayout()
        Me.tsBOList.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvBOList
        '
        Me.dgvBOList.AllowUserToAddRows = False
        Me.dgvBOList.AllowUserToResizeRows = False
        Me.dgvBOList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvBOList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBOList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.dgvBOList.Location = New System.Drawing.Point(13, 37)
        Me.dgvBOList.Name = "dgvBOList"
        Me.dgvBOList.RowHeadersVisible = False
        Me.dgvBOList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBOList.Size = New System.Drawing.Size(1043, 432)
        Me.dgvBOList.TabIndex = 64
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
        'tsBOGo
        '
        Me.tsBOGo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsBOGo.Dock = System.Windows.Forms.DockStyle.None
        Me.tsBOGo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsBOGo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.Go, Me.ToolStripSeparator2})
        Me.tsBOGo.Location = New System.Drawing.Point(1012, 6)
        Me.tsBOGo.Name = "tsBOGo"
        Me.tsBOGo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsBOGo.Size = New System.Drawing.Size(43, 25)
        Me.tsBOGo.TabIndex = 68
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(709, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Date Range :"
        '
        'cbxViewPaid
        '
        Me.cbxViewPaid.AutoSize = True
        Me.cbxViewPaid.Location = New System.Drawing.Point(304, 14)
        Me.cbxViewPaid.Name = "cbxViewPaid"
        Me.cbxViewPaid.Size = New System.Drawing.Size(81, 17)
        Me.cbxViewPaid.TabIndex = 70
        Me.cbxViewPaid.Text = "View Paid?"
        Me.cbxViewPaid.UseVisualStyleBackColor = True
        '
        'tbSearchBO
        '
        Me.tbSearchBO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchBO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSearchBO.Location = New System.Drawing.Point(12, 9)
        Me.tbSearchBO.MaxLength = 50
        Me.tbSearchBO.Name = "tbSearchBO"
        Me.tbSearchBO.Size = New System.Drawing.Size(286, 22)
        Me.tbSearchBO.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Location = New System.Drawing.Point(887, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "To"
        '
        'dtpBO2
        '
        Me.dtpBO2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpBO2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBO2.Location = New System.Drawing.Point(915, 7)
        Me.dtpBO2.Name = "dtpBO2"
        Me.dtpBO2.Size = New System.Drawing.Size(93, 22)
        Me.dtpBO2.TabIndex = 66
        '
        'DeleteBO
        '
        Me.DeleteBO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DeleteBO.Image = CType(resources.GetObject("DeleteBO.Image"), System.Drawing.Image)
        Me.DeleteBO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteBO.Name = "DeleteBO"
        Me.DeleteBO.Size = New System.Drawing.Size(80, 22)
        Me.DeleteBO.Text = "[F7] - DELETE"
        '
        'tsBOList
        '
        Me.tsBOList.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsBOList.Dock = System.Windows.Forms.DockStyle.None
        Me.tsBOList.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsBOList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.AddBO, Me.ToolStripSeparator33, Me.EditBO, Me.ToolStripSeparator34, Me.DeleteBO, Me.ToolStripSeparator35})
        Me.tsBOList.Location = New System.Drawing.Point(394, 477)
        Me.tsBOList.Name = "tsBOList"
        Me.tsBOList.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsBOList.Size = New System.Drawing.Size(291, 25)
        Me.tsBOList.TabIndex = 72
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'AddBO
        '
        Me.AddBO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AddBO.Image = CType(resources.GetObject("AddBO.Image"), System.Drawing.Image)
        Me.AddBO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddBO.Name = "AddBO"
        Me.AddBO.Size = New System.Drawing.Size(66, 22)
        Me.AddBO.Text = "[F5] - ADD"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'EditBO
        '
        Me.EditBO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditBO.Image = CType(resources.GetObject("EditBO.Image"), System.Drawing.Image)
        Me.EditBO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditBO.Name = "EditBO"
        Me.EditBO.Size = New System.Drawing.Size(87, 22)
        Me.EditBO.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'dtpBO1
        '
        Me.dtpBO1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpBO1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBO1.Location = New System.Drawing.Point(787, 7)
        Me.dtpBO1.Name = "dtpBO1"
        Me.dtpBO1.Size = New System.Drawing.Size(93, 22)
        Me.dtpBO1.TabIndex = 65
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
        'frmBOReturnH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 509)
        Me.Controls.Add(Me.dgvBOList)
        Me.Controls.Add(Me.tsBOGo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxViewPaid)
        Me.Controls.Add(Me.tbSearchBO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpBO2)
        Me.Controls.Add(Me.tsBOList)
        Me.Controls.Add(Me.dtpBO1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBOReturnH"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "B.O. RETURN"
        CType(Me.dgvBOList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsBOGo.ResumeLayout(False)
        Me.tsBOGo.PerformLayout()
        Me.tsBOList.ResumeLayout(False)
        Me.tsBOList.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBOList As System.Windows.Forms.DataGridView
    Friend WithEvents Go As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBOGo As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxViewPaid As System.Windows.Forms.CheckBox
    Friend WithEvents tbSearchBO As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpBO2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DeleteBO As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBOList As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddBO As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditBO As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dtpBO1 As System.Windows.Forms.DateTimePicker
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
