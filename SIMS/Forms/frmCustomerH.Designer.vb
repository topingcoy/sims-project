<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerH))
        Me.tbSearchCust = New System.Windows.Forms.TextBox()
        Me.tscustomerlist = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsaddcust = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.tseditcust = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsdeletcust = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgvcustomerlist = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsCustomerH = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddCust = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditCust = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteCust = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tscustomerlist.SuspendLayout()
        CType(Me.dgvcustomerlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsCustomerH.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbSearchCust
        '
        Me.tbSearchCust.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchCust.Location = New System.Drawing.Point(12, 10)
        Me.tbSearchCust.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbSearchCust.MaxLength = 50
        Me.tbSearchCust.Name = "tbSearchCust"
        Me.tbSearchCust.Size = New System.Drawing.Size(270, 22)
        Me.tbSearchCust.TabIndex = 27
        '
        'tscustomerlist
        '
        Me.tscustomerlist.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tscustomerlist.Dock = System.Windows.Forms.DockStyle.None
        Me.tscustomerlist.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tscustomerlist.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator31, Me.tsaddcust, Me.ToolStripSeparator33, Me.tseditcust, Me.ToolStripSeparator34, Me.tsdeletcust, Me.ToolStripSeparator35})
        Me.tscustomerlist.Location = New System.Drawing.Point(355, 455)
        Me.tscustomerlist.Name = "tscustomerlist"
        Me.tscustomerlist.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tscustomerlist.Size = New System.Drawing.Size(260, 25)
        Me.tscustomerlist.TabIndex = 34
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(6, 25)
        '
        'tsaddcust
        '
        Me.tsaddcust.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsaddcust.Image = CType(resources.GetObject("tsaddcust.Image"), System.Drawing.Image)
        Me.tsaddcust.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsaddcust.Name = "tsaddcust"
        Me.tsaddcust.Size = New System.Drawing.Size(66, 22)
        Me.tsaddcust.Text = "[F5] - ADD"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(6, 25)
        '
        'tseditcust
        '
        Me.tseditcust.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tseditcust.Image = CType(resources.GetObject("tseditcust.Image"), System.Drawing.Image)
        Me.tseditcust.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tseditcust.Name = "tseditcust"
        Me.tseditcust.Size = New System.Drawing.Size(87, 22)
        Me.tseditcust.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'tsdeletcust
        '
        Me.tsdeletcust.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsdeletcust.Image = CType(resources.GetObject("tsdeletcust.Image"), System.Drawing.Image)
        Me.tsdeletcust.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsdeletcust.Name = "tsdeletcust"
        Me.tsdeletcust.Size = New System.Drawing.Size(80, 22)
        Me.tsdeletcust.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'dgvcustomerlist
        '
        Me.dgvcustomerlist.AllowUserToAddRows = False
        Me.dgvcustomerlist.AllowUserToResizeRows = False
        Me.dgvcustomerlist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvcustomerlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcustomerlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgvcustomerlist.Location = New System.Drawing.Point(13, 36)
        Me.dgvcustomerlist.Name = "dgvcustomerlist"
        Me.dgvcustomerlist.RowHeadersVisible = False
        Me.dgvcustomerlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvcustomerlist.Size = New System.Drawing.Size(1061, 510)
        Me.dgvcustomerlist.TabIndex = 35
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
        Me.Column3.HeaderText = "CUSTOMER NAME"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 230
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "ADDRESS"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "TERRITORY"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 87
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "PROVINCE"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 85
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "OUTLET-TYPE"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 99
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "STATUS"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 69
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "ADDED-BY"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 84
        '
        'tsCustomerH
        '
        Me.tsCustomerH.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsCustomerH.Dock = System.Windows.Forms.DockStyle.None
        Me.tsCustomerH.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsCustomerH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.AddCust, Me.ToolStripSeparator2, Me.EditCust, Me.ToolStripSeparator3, Me.DeleteCust, Me.ToolStripSeparator4})
        Me.tsCustomerH.Location = New System.Drawing.Point(443, 556)
        Me.tsCustomerH.Name = "tsCustomerH"
        Me.tsCustomerH.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsCustomerH.Size = New System.Drawing.Size(291, 25)
        Me.tsCustomerH.TabIndex = 36
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'AddCust
        '
        Me.AddCust.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AddCust.Image = CType(resources.GetObject("AddCust.Image"), System.Drawing.Image)
        Me.AddCust.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddCust.Name = "AddCust"
        Me.AddCust.Size = New System.Drawing.Size(66, 22)
        Me.AddCust.Text = "[F5] - ADD"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'EditCust
        '
        Me.EditCust.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditCust.Image = CType(resources.GetObject("EditCust.Image"), System.Drawing.Image)
        Me.EditCust.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditCust.Name = "EditCust"
        Me.EditCust.Size = New System.Drawing.Size(87, 22)
        Me.EditCust.Text = "[ENTER] - EDIT"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'DeleteCust
        '
        Me.DeleteCust.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DeleteCust.Image = CType(resources.GetObject("DeleteCust.Image"), System.Drawing.Image)
        Me.DeleteCust.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteCust.Name = "DeleteCust"
        Me.DeleteCust.Size = New System.Drawing.Size(80, 22)
        Me.DeleteCust.Text = "[F7] - DELETE"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'frmCustomerH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 586)
        Me.Controls.Add(Me.tsCustomerH)
        Me.Controls.Add(Me.dgvcustomerlist)
        Me.Controls.Add(Me.tscustomerlist)
        Me.Controls.Add(Me.tbSearchCust)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomerH"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUSTOMER LIST"
        Me.tscustomerlist.ResumeLayout(False)
        Me.tscustomerlist.PerformLayout()
        CType(Me.dgvcustomerlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsCustomerH.ResumeLayout(False)
        Me.tsCustomerH.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbSearchCust As System.Windows.Forms.TextBox
    Friend WithEvents tscustomerlist As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator31 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsaddcust As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator33 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tseditcust As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsdeletcust As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator35 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dgvcustomerlist As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsCustomerH As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddCust As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditCust As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteCust As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
End Class
