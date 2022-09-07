<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceivingH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceivingH))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Go = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsRcvGo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rcvdtp2 = New System.Windows.Forms.DateTimePicker()
        Me.rcvdtp1 = New System.Windows.Forms.DateTimePicker()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDeleteRcv = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsEditRcv = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAddRcv = New System.Windows.Forms.ToolStripButton()
        Me.tsRcvList = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbsearchrcv = New System.Windows.Forms.TextBox()
        Me.dgrcvlist = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tsRcvGo.SuspendLayout()
        Me.tsRcvList.SuspendLayout()
        CType(Me.dgrcvlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsRcvGo
        '
        Me.tsRcvGo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsRcvGo.Dock = System.Windows.Forms.DockStyle.None
        Me.tsRcvGo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsRcvGo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.Go, Me.ToolStripSeparator2})
        Me.tsRcvGo.Location = New System.Drawing.Point(1066, 6)
        Me.tsRcvGo.Name = "tsRcvGo"
        Me.tsRcvGo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsRcvGo.Size = New System.Drawing.Size(43, 25)
        Me.tsRcvGo.TabIndex = 46
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
        Me.Label1.Location = New System.Drawing.Point(941, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "To"
        '
        'rcvdtp2
        '
        Me.rcvdtp2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rcvdtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rcvdtp2.Location = New System.Drawing.Point(969, 7)
        Me.rcvdtp2.Name = "rcvdtp2"
        Me.rcvdtp2.Size = New System.Drawing.Size(93, 22)
        Me.rcvdtp2.TabIndex = 44
        '
        'rcvdtp1
        '
        Me.rcvdtp1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rcvdtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rcvdtp1.Location = New System.Drawing.Point(841, 7)
        Me.rcvdtp1.Name = "rcvdtp1"
        Me.rcvdtp1.Size = New System.Drawing.Size(93, 22)
        Me.rcvdtp1.TabIndex = 43
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'tsDeleteRcv
        '
        Me.tsDeleteRcv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsDeleteRcv.Image = CType(resources.GetObject("tsDeleteRcv.Image"), System.Drawing.Image)
        Me.tsDeleteRcv.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDeleteRcv.Name = "tsDeleteRcv"
        Me.tsDeleteRcv.Size = New System.Drawing.Size(80, 22)
        Me.tsDeleteRcv.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'tsEditRcv
        '
        Me.tsEditRcv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsEditRcv.Image = CType(resources.GetObject("tsEditRcv.Image"), System.Drawing.Image)
        Me.tsEditRcv.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEditRcv.Name = "tsEditRcv"
        Me.tsEditRcv.Size = New System.Drawing.Size(87, 22)
        Me.tsEditRcv.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'tsAddRcv
        '
        Me.tsAddRcv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsAddRcv.Image = CType(resources.GetObject("tsAddRcv.Image"), System.Drawing.Image)
        Me.tsAddRcv.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAddRcv.Name = "tsAddRcv"
        Me.tsAddRcv.Size = New System.Drawing.Size(66, 22)
        Me.tsAddRcv.Text = "[F5] - ADD"
        '
        'tsRcvList
        '
        Me.tsRcvList.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsRcvList.Dock = System.Windows.Forms.DockStyle.None
        Me.tsRcvList.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsRcvList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsAddRcv, Me.ToolStripSeparator33, Me.tsEditRcv, Me.ToolStripSeparator34, Me.tsDeleteRcv, Me.ToolStripSeparator35})
        Me.tsRcvList.Location = New System.Drawing.Point(421, 475)
        Me.tsRcvList.Name = "tsRcvList"
        Me.tsRcvList.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsRcvList.Size = New System.Drawing.Size(260, 25)
        Me.tsRcvList.TabIndex = 42
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'tbsearchrcv
        '
        Me.tbsearchrcv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbsearchrcv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbsearchrcv.Location = New System.Drawing.Point(13, 6)
        Me.tbsearchrcv.MaxLength = 50
        Me.tbsearchrcv.Name = "tbsearchrcv"
        Me.tbsearchrcv.Size = New System.Drawing.Size(230, 22)
        Me.tbsearchrcv.TabIndex = 41
        '
        'dgrcvlist
        '
        Me.dgrcvlist.AllowUserToAddRows = False
        Me.dgrcvlist.AllowUserToResizeRows = False
        Me.dgrcvlist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgrcvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrcvlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgrcvlist.Location = New System.Drawing.Point(12, 34)
        Me.dgrcvlist.Name = "dgrcvlist"
        Me.dgrcvlist.RowHeadersVisible = False
        Me.dgrcvlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrcvlist.Size = New System.Drawing.Size(1097, 436)
        Me.dgrcvlist.TabIndex = 40
        '
        'Column1
        '
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 40
        '
        'Column2
        '
        Me.Column2.HeaderText = "DOC NO."
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "DATE"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 85
        '
        'Column4
        '
        Me.Column4.HeaderText = "INVOICE NO"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "WAREHOUSE"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column6.HeaderText = "AMOUNT"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "PO-NO."
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "SUPPLIER"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 300
        '
        'Column9
        '
        Me.Column9.HeaderText = "ENTERED BY"
        Me.Column9.Name = "Column9"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(763, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Date Range :"
        '
        'frmReceivingH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 504)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tsRcvGo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rcvdtp2)
        Me.Controls.Add(Me.rcvdtp1)
        Me.Controls.Add(Me.tsRcvList)
        Me.Controls.Add(Me.tbsearchrcv)
        Me.Controls.Add(Me.dgrcvlist)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReceivingH"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECEIVING LIST"
        Me.tsRcvGo.ResumeLayout(False)
        Me.tsRcvGo.PerformLayout()
        Me.tsRcvList.ResumeLayout(False)
        Me.tsRcvList.PerformLayout()
        CType(Me.dgrcvlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Go As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsRcvGo As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rcvdtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents rcvdtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDeleteRcv As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsEditRcv As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsAddRcv As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsRcvList As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbsearchrcv As System.Windows.Forms.TextBox
    Friend WithEvents dgrcvlist As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
