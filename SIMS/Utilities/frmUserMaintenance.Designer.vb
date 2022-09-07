<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserMaintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserMaintenance))
        Me.tbSearchUser = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvUserList = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gbxCreateUser = New System.Windows.Forms.GroupBox()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbComfirmPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbFullname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxRole = New System.Windows.Forms.ComboBox()
        Me.tsSaveUser = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveUser = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsClear = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.gbxCreateUser.SuspendLayout()
        Me.tsSaveUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbSearchUser
        '
        Me.tbSearchUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearchUser.Location = New System.Drawing.Point(3, 6)
        Me.tbSearchUser.MaxLength = 50
        Me.tbSearchUser.Name = "tbSearchUser"
        Me.tbSearchUser.Size = New System.Drawing.Size(138, 22)
        Me.tbSearchUser.TabIndex = 58
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(10, 11)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(608, 332)
        Me.TabControl1.TabIndex = 60
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvUserList)
        Me.TabPage1.Controls.Add(Me.tbSearchUser)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(600, 306)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LIST OF USERS"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvUserList
        '
        Me.dgvUserList.AllowUserToAddRows = False
        Me.dgvUserList.AllowUserToDeleteRows = False
        Me.dgvUserList.AllowUserToResizeRows = False
        Me.dgvUserList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Column2, Me.Column3, Me.delete})
        Me.dgvUserList.Location = New System.Drawing.Point(4, 32)
        Me.dgvUserList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvUserList.Name = "dgvUserList"
        Me.dgvUserList.ReadOnly = True
        Me.dgvUserList.RowHeadersVisible = False
        Me.dgvUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUserList.Size = New System.Drawing.Size(586, 269)
        Me.dgvUserList.TabIndex = 18
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 39
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "USER NAME"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 93
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column2.HeaderText = "FULL NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "ROLE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 59
        '
        'delete
        '
        Me.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.delete.HeaderText = ""
        Me.delete.Name = "delete"
        Me.delete.ReadOnly = True
        Me.delete.Width = 5
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gbxCreateUser)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(600, 306)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CREATE USER"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gbxCreateUser
        '
        Me.gbxCreateUser.Controls.Add(Me.tbUsername)
        Me.gbxCreateUser.Controls.Add(Me.Label5)
        Me.gbxCreateUser.Controls.Add(Me.tbComfirmPass)
        Me.gbxCreateUser.Controls.Add(Me.Label3)
        Me.gbxCreateUser.Controls.Add(Me.tbFullname)
        Me.gbxCreateUser.Controls.Add(Me.Label2)
        Me.gbxCreateUser.Controls.Add(Me.cbxRole)
        Me.gbxCreateUser.Controls.Add(Me.tsSaveUser)
        Me.gbxCreateUser.Controls.Add(Me.Label1)
        Me.gbxCreateUser.Controls.Add(Me.tbPassword)
        Me.gbxCreateUser.Controls.Add(Me.Label4)
        Me.gbxCreateUser.Location = New System.Drawing.Point(16, 26)
        Me.gbxCreateUser.Name = "gbxCreateUser"
        Me.gbxCreateUser.Size = New System.Drawing.Size(571, 264)
        Me.gbxCreateUser.TabIndex = 76
        Me.gbxCreateUser.TabStop = False
        '
        'tbUsername
        '
        Me.tbUsername.Location = New System.Drawing.Point(190, 55)
        Me.tbUsername.MaxLength = 50
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(263, 22)
        Me.tbUsername.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(121, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Full Name :"
        '
        'tbComfirmPass
        '
        Me.tbComfirmPass.Location = New System.Drawing.Point(190, 108)
        Me.tbComfirmPass.MaxLength = 50
        Me.tbComfirmPass.Name = "tbComfirmPass"
        Me.tbComfirmPass.Size = New System.Drawing.Size(263, 22)
        Me.tbComfirmPass.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "ReType Password :"
        '
        'tbFullname
        '
        Me.tbFullname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbFullname.Location = New System.Drawing.Point(190, 163)
        Me.tbFullname.MaxLength = 50
        Me.tbFullname.Name = "tbFullname"
        Me.tbFullname.Size = New System.Drawing.Size(263, 22)
        Me.tbFullname.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Password :"
        '
        'cbxRole
        '
        Me.cbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRole.FormattingEnabled = True
        Me.cbxRole.Items.AddRange(New Object() {"Administrator", "Invoicer/Biller", "Accounting", "Inventory Clerk", "Guest", ""})
        Me.cbxRole.Location = New System.Drawing.Point(190, 136)
        Me.cbxRole.Name = "cbxRole"
        Me.cbxRole.Size = New System.Drawing.Size(263, 21)
        Me.cbxRole.TabIndex = 73
        '
        'tsSaveUser
        '
        Me.tsSaveUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsSaveUser.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tsSaveUser.Dock = System.Windows.Forms.DockStyle.None
        Me.tsSaveUser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsSaveUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.SaveUser, Me.ToolStripSeparator7, Me.tsClear, Me.ToolStripSeparator9})
        Me.tsSaveUser.Location = New System.Drawing.Point(358, 188)
        Me.tsSaveUser.Name = "tsSaveUser"
        Me.tsSaveUser.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsSaveUser.Size = New System.Drawing.Size(94, 25)
        Me.tsSaveUser.TabIndex = 75
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'SaveUser
        '
        Me.SaveUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveUser.Image = CType(resources.GetObject("SaveUser.Image"), System.Drawing.Image)
        Me.SaveUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveUser.Name = "SaveUser"
        Me.SaveUser.Size = New System.Drawing.Size(35, 22)
        Me.SaveUser.Text = "&Save"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'tsClear
        '
        Me.tsClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsClear.Image = CType(resources.GetObject("tsClear.Image"), System.Drawing.Image)
        Me.tsClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsClear.Name = "tsClear"
        Me.tsClear.Size = New System.Drawing.Size(38, 22)
        Me.tsClear.Text = "&Clear"
        Me.tsClear.ToolTipText = "S&ave "
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Username :"
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(190, 81)
        Me.tbPassword.MaxLength = 50
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(263, 22)
        Me.tbPassword.TabIndex = 68
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(123, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "User Role :"
        '
        'frmUserMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 348)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserMaintenance"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USER MAINTENANCE"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.gbxCreateUser.ResumeLayout(False)
        Me.gbxCreateUser.PerformLayout()
        Me.tsSaveUser.ResumeLayout(False)
        Me.tsSaveUser.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbSearchUser As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvUserList As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbFullname As System.Windows.Forms.TextBox
    Friend WithEvents tsSaveUser As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveUser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxRole As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbComfirmPass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbPassword As System.Windows.Forms.TextBox
    Friend WithEvents tbUsername As System.Windows.Forms.TextBox
    Friend WithEvents gbxCreateUser As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents delete As System.Windows.Forms.DataGridViewButtonColumn
End Class
