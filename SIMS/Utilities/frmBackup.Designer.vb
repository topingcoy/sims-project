<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackup))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsNewUser = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Backup = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SelectedTablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllTablesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Restore = New System.Windows.Forms.ToolStripDropDownButton()
        Me.BrowseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreNowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgdeps = New System.Windows.Forms.DataGridView()
        Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.nos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsNewUser.SuspendLayout()
        CType(Me.dgdeps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsNewUser
        '
        Me.tsNewUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsNewUser.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsNewUser.Dock = System.Windows.Forms.DockStyle.None
        Me.tsNewUser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsNewUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.Backup, Me.Restore, Me.CheckAll, Me.ToolStripSeparator7})
        Me.tsNewUser.Location = New System.Drawing.Point(328, 9)
        Me.tsNewUser.Name = "tsNewUser"
        Me.tsNewUser.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsNewUser.Size = New System.Drawing.Size(269, 25)
        Me.tsNewUser.TabIndex = 102
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'Backup
        '
        Me.Backup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Backup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectedTablesToolStripMenuItem, Me.AllTablesToolStripMenuItem1, Me.SetLocationToolStripMenuItem})
        Me.Backup.Image = CType(resources.GetObject("Backup.Image"), System.Drawing.Image)
        Me.Backup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Backup.Name = "Backup"
        Me.Backup.Size = New System.Drawing.Size(59, 22)
        Me.Backup.Text = "&Backup"
        '
        'SelectedTablesToolStripMenuItem
        '
        Me.SelectedTablesToolStripMenuItem.Name = "SelectedTablesToolStripMenuItem"
        Me.SelectedTablesToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SelectedTablesToolStripMenuItem.Text = "&Selected Tables"
        '
        'AllTablesToolStripMenuItem1
        '
        Me.AllTablesToolStripMenuItem1.Name = "AllTablesToolStripMenuItem1"
        Me.AllTablesToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.AllTablesToolStripMenuItem1.Text = "&All Tables"
        '
        'SetLocationToolStripMenuItem
        '
        Me.SetLocationToolStripMenuItem.Name = "SetLocationToolStripMenuItem"
        Me.SetLocationToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SetLocationToolStripMenuItem.Text = "Set &Location"
        '
        'Restore
        '
        Me.Restore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Restore.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowseToolStripMenuItem, Me.RestoreNowToolStripMenuItem})
        Me.Restore.Image = CType(resources.GetObject("Restore.Image"), System.Drawing.Image)
        Me.Restore.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Restore.Name = "Restore"
        Me.Restore.Size = New System.Drawing.Size(134, 22)
        Me.Restore.Text = "&Restore Datable/Table"
        '
        'BrowseToolStripMenuItem
        '
        Me.BrowseToolStripMenuItem.Name = "BrowseToolStripMenuItem"
        Me.BrowseToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.BrowseToolStripMenuItem.Text = "&Browse"
        '
        'RestoreNowToolStripMenuItem
        '
        Me.RestoreNowToolStripMenuItem.Name = "RestoreNowToolStripMenuItem"
        Me.RestoreNowToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.RestoreNowToolStripMenuItem.Text = "&Restore Now"
        '
        'CheckAll
        '
        Me.CheckAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CheckAll.Image = CType(resources.GetObject("CheckAll.Image"), System.Drawing.Image)
        Me.CheckAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CheckAll.Name = "CheckAll"
        Me.CheckAll.Size = New System.Drawing.Size(61, 22)
        Me.CheckAll.Text = "&Check All"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'dgdeps
        '
        Me.dgdeps.AllowUserToAddRows = False
        Me.dgdeps.AllowUserToDeleteRows = False
        Me.dgdeps.AllowUserToResizeColumns = False
        Me.dgdeps.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgdeps.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgdeps.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdeps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdeps.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk, Me.nos, Me.tbn, Me.dm})
        Me.dgdeps.Location = New System.Drawing.Point(18, 73)
        Me.dgdeps.Name = "dgdeps"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgdeps.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgdeps.RowHeadersVisible = False
        Me.dgdeps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgdeps.Size = New System.Drawing.Size(578, 269)
        Me.dgdeps.TabIndex = 103
        '
        'chk
        '
        Me.chk.HeaderText = " "
        Me.chk.Name = "chk"
        Me.chk.Width = 20
        '
        'nos
        '
        Me.nos.HeaderText = "No."
        Me.nos.Name = "nos"
        Me.nos.Width = 35
        '
        'tbn
        '
        Me.tbn.HeaderText = "TableName"
        Me.tbn.Name = "tbn"
        Me.tbn.Width = 350
        '
        'dm
        '
        Me.dm.HeaderText = "Date Modified"
        Me.dm.Name = "dm"
        Me.dm.Width = 150
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Restore this database : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 47)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Last Backup :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Database location : "
        '
        'frmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 354)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgdeps)
        Me.Controls.Add(Me.tsNewUser)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBackup"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BACKUP DATABASE"
        Me.tsNewUser.ResumeLayout(False)
        Me.tsNewUser.PerformLayout()
        CType(Me.dgdeps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsNewUser As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Backup As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SelectedTablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllTablesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetLocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Restore As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents BrowseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreNowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dgdeps As System.Windows.Forms.DataGridView
    Friend WithEvents chk As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents nos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
