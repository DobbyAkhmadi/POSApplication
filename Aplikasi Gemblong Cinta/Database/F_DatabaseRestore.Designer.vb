<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_DatabaseRestore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_DatabaseRestore))
        Me.chkDeleteExistingData = New System.Windows.Forms.CheckBox()
        Me.chkStructure = New System.Windows.Forms.CheckBox()
        Me.chkData = New System.Windows.Forms.CheckBox()
        Me.gbProgress = New System.Windows.Forms.GroupBox()
        Me.lblObjectName = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgTables = New System.Windows.Forms.DataGridView()
        Me.cmdTablesDeSelectAll = New System.Windows.Forms.Button()
        Me.cmdTablesSelectAll = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgViews = New System.Windows.Forms.DataGridView()
        Me.cmdViewsDeSelectAll = New System.Windows.Forms.Button()
        Me.cmdViewsSelectAll = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgSps = New System.Windows.Forms.DataGridView()
        Me.cmdSpDeSelectAll = New System.Windows.Forms.Button()
        Me.cmdSpSelectAll = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgUDFs = New System.Windows.Forms.DataGridView()
        Me.cmdUDFDeSelectAll = New System.Windows.Forms.Button()
        Me.cmdUDFSelectAll = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.dgUDDs = New System.Windows.Forms.DataGridView()
        Me.cmdUDDDeSelectAll = New System.Windows.Forms.Button()
        Me.cmdUDDSelectAll = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.dgUsers = New System.Windows.Forms.DataGridView()
        Me.cmdUserDeSelectAll = New System.Windows.Forms.Button()
        Me.cmdUserSelectAll = New System.Windows.Forms.Button()
        Me.cmdRestore = New System.Windows.Forms.Button()
        Me.gbLogin = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPreset = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBackupFile = New System.Windows.Forms.TextBox()
        Me.cmdOpenFile = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtDatabaseName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.rdAppend = New System.Windows.Forms.RadioButton()
        Me.rdDrop = New System.Windows.Forms.RadioButton()
        Me.gbExport = New System.Windows.Forms.Panel()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.rdNone = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ErrorProviderExtended1 = New Aplikasi_Gemblong_Cinta.ErrorProviderExtended()
        Me.gbProgress.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgTables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgViews, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgSps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgUDFs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgUDDs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.dgUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLogin.SuspendLayout()
        Me.gbExport.SuspendLayout()
        Me.gbOptions.SuspendLayout()
        CType(Me.ErrorProviderExtended1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkDeleteExistingData
        '
        Me.chkDeleteExistingData.AutoSize = True
        Me.chkDeleteExistingData.Checked = True
        Me.chkDeleteExistingData.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDeleteExistingData.Location = New System.Drawing.Point(12, 70)
        Me.chkDeleteExistingData.Name = "chkDeleteExistingData"
        Me.chkDeleteExistingData.Size = New System.Drawing.Size(133, 17)
        Me.chkDeleteExistingData.TabIndex = 30
        Me.chkDeleteExistingData.Text = "Hapus Data Yang Ada"
        Me.chkDeleteExistingData.UseVisualStyleBackColor = True
        '
        'chkStructure
        '
        Me.chkStructure.AutoSize = True
        Me.chkStructure.Checked = True
        Me.chkStructure.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkStructure.Location = New System.Drawing.Point(12, 24)
        Me.chkStructure.Name = "chkStructure"
        Me.chkStructure.Size = New System.Drawing.Size(134, 17)
        Me.chkStructure.TabIndex = 27
        Me.chkStructure.Text = "Restore Struktur Objek"
        Me.chkStructure.UseVisualStyleBackColor = True
        '
        'chkData
        '
        Me.chkData.AutoSize = True
        Me.chkData.Checked = True
        Me.chkData.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkData.Location = New System.Drawing.Point(12, 47)
        Me.chkData.Name = "chkData"
        Me.chkData.Size = New System.Drawing.Size(87, 17)
        Me.chkData.TabIndex = 26
        Me.chkData.Text = "Restore data"
        Me.chkData.UseVisualStyleBackColor = True
        '
        'gbProgress
        '
        Me.gbProgress.Controls.Add(Me.lblObjectName)
        Me.gbProgress.Controls.Add(Me.lblStatus)
        Me.gbProgress.Controls.Add(Me.ProgressBar1)
        Me.gbProgress.Location = New System.Drawing.Point(428, 16)
        Me.gbProgress.Name = "gbProgress"
        Me.gbProgress.Size = New System.Drawing.Size(339, 82)
        Me.gbProgress.TabIndex = 2
        Me.gbProgress.TabStop = False
        '
        'lblObjectName
        '
        Me.lblObjectName.AutoSize = True
        Me.lblObjectName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObjectName.Location = New System.Drawing.Point(6, 10)
        Me.lblObjectName.Name = "lblObjectName"
        Me.lblObjectName.Size = New System.Drawing.Size(15, 13)
        Me.lblObjectName.TabIndex = 36
        Me.lblObjectName.Text = "tt"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(6, 33)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(13, 13)
        Me.lblStatus.TabIndex = 35
        Me.lblStatus.Text = "tt"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 55)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(320, 18)
        Me.ProgressBar1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(17, 202)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(751, 258)
        Me.TabControl1.TabIndex = 24
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgTables)
        Me.TabPage1.Controls.Add(Me.cmdTablesDeSelectAll)
        Me.TabPage1.Controls.Add(Me.cmdTablesSelectAll)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(743, 232)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tables"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgTables
        '
        Me.dgTables.AllowUserToAddRows = False
        Me.dgTables.AllowUserToDeleteRows = False
        Me.dgTables.AllowUserToResizeRows = False
        Me.dgTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTables.Location = New System.Drawing.Point(6, 9)
        Me.dgTables.Name = "dgTables"
        Me.dgTables.Size = New System.Drawing.Size(731, 189)
        Me.dgTables.TabIndex = 11
        '
        'cmdTablesDeSelectAll
        '
        Me.cmdTablesDeSelectAll.Location = New System.Drawing.Point(95, 203)
        Me.cmdTablesDeSelectAll.Name = "cmdTablesDeSelectAll"
        Me.cmdTablesDeSelectAll.Size = New System.Drawing.Size(86, 22)
        Me.cmdTablesDeSelectAll.TabIndex = 17
        Me.cmdTablesDeSelectAll.Text = "Batal"
        Me.cmdTablesDeSelectAll.UseVisualStyleBackColor = True
        '
        'cmdTablesSelectAll
        '
        Me.cmdTablesSelectAll.Location = New System.Drawing.Point(3, 203)
        Me.cmdTablesSelectAll.Name = "cmdTablesSelectAll"
        Me.cmdTablesSelectAll.Size = New System.Drawing.Size(86, 22)
        Me.cmdTablesSelectAll.TabIndex = 16
        Me.cmdTablesSelectAll.Text = "Pilih Semua"
        Me.cmdTablesSelectAll.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgViews)
        Me.TabPage2.Controls.Add(Me.cmdViewsDeSelectAll)
        Me.TabPage2.Controls.Add(Me.cmdViewsSelectAll)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(743, 232)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Views"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgViews
        '
        Me.dgViews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgViews.Location = New System.Drawing.Point(8, 8)
        Me.dgViews.Name = "dgViews"
        Me.dgViews.Size = New System.Drawing.Size(731, 189)
        Me.dgViews.TabIndex = 18
        '
        'cmdViewsDeSelectAll
        '
        Me.cmdViewsDeSelectAll.Location = New System.Drawing.Point(97, 202)
        Me.cmdViewsDeSelectAll.Name = "cmdViewsDeSelectAll"
        Me.cmdViewsDeSelectAll.Size = New System.Drawing.Size(86, 22)
        Me.cmdViewsDeSelectAll.TabIndex = 20
        Me.cmdViewsDeSelectAll.Text = "Deselect All"
        Me.cmdViewsDeSelectAll.UseVisualStyleBackColor = True
        '
        'cmdViewsSelectAll
        '
        Me.cmdViewsSelectAll.Location = New System.Drawing.Point(5, 202)
        Me.cmdViewsSelectAll.Name = "cmdViewsSelectAll"
        Me.cmdViewsSelectAll.Size = New System.Drawing.Size(86, 22)
        Me.cmdViewsSelectAll.TabIndex = 19
        Me.cmdViewsSelectAll.Text = "Select All"
        Me.cmdViewsSelectAll.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgSps)
        Me.TabPage3.Controls.Add(Me.cmdSpDeSelectAll)
        Me.TabPage3.Controls.Add(Me.cmdSpSelectAll)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(743, 232)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Stored Procedures"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgSps
        '
        Me.dgSps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSps.Location = New System.Drawing.Point(8, 8)
        Me.dgSps.Name = "dgSps"
        Me.dgSps.Size = New System.Drawing.Size(731, 189)
        Me.dgSps.TabIndex = 21
        '
        'cmdSpDeSelectAll
        '
        Me.cmdSpDeSelectAll.Location = New System.Drawing.Point(97, 202)
        Me.cmdSpDeSelectAll.Name = "cmdSpDeSelectAll"
        Me.cmdSpDeSelectAll.Size = New System.Drawing.Size(86, 22)
        Me.cmdSpDeSelectAll.TabIndex = 23
        Me.cmdSpDeSelectAll.Text = "Deselect All"
        Me.cmdSpDeSelectAll.UseVisualStyleBackColor = True
        '
        'cmdSpSelectAll
        '
        Me.cmdSpSelectAll.Location = New System.Drawing.Point(5, 202)
        Me.cmdSpSelectAll.Name = "cmdSpSelectAll"
        Me.cmdSpSelectAll.Size = New System.Drawing.Size(86, 22)
        Me.cmdSpSelectAll.TabIndex = 22
        Me.cmdSpSelectAll.Text = "Select All"
        Me.cmdSpSelectAll.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgUDFs)
        Me.TabPage4.Controls.Add(Me.cmdUDFDeSelectAll)
        Me.TabPage4.Controls.Add(Me.cmdUDFSelectAll)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(743, 232)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "User Defined Functions"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgUDFs
        '
        Me.dgUDFs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUDFs.Location = New System.Drawing.Point(8, 8)
        Me.dgUDFs.Name = "dgUDFs"
        Me.dgUDFs.Size = New System.Drawing.Size(731, 189)
        Me.dgUDFs.TabIndex = 21
        '
        'cmdUDFDeSelectAll
        '
        Me.cmdUDFDeSelectAll.Location = New System.Drawing.Point(97, 202)
        Me.cmdUDFDeSelectAll.Name = "cmdUDFDeSelectAll"
        Me.cmdUDFDeSelectAll.Size = New System.Drawing.Size(86, 22)
        Me.cmdUDFDeSelectAll.TabIndex = 23
        Me.cmdUDFDeSelectAll.Text = "Deselect All"
        Me.cmdUDFDeSelectAll.UseVisualStyleBackColor = True
        '
        'cmdUDFSelectAll
        '
        Me.cmdUDFSelectAll.Location = New System.Drawing.Point(5, 202)
        Me.cmdUDFSelectAll.Name = "cmdUDFSelectAll"
        Me.cmdUDFSelectAll.Size = New System.Drawing.Size(86, 22)
        Me.cmdUDFSelectAll.TabIndex = 22
        Me.cmdUDFSelectAll.Text = "Select All"
        Me.cmdUDFSelectAll.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.dgUDDs)
        Me.TabPage5.Controls.Add(Me.cmdUDDDeSelectAll)
        Me.TabPage5.Controls.Add(Me.cmdUDDSelectAll)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(743, 232)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "User Defined Datatypes"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'dgUDDs
        '
        Me.dgUDDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUDDs.Location = New System.Drawing.Point(8, 8)
        Me.dgUDDs.Name = "dgUDDs"
        Me.dgUDDs.Size = New System.Drawing.Size(731, 189)
        Me.dgUDDs.TabIndex = 21
        '
        'cmdUDDDeSelectAll
        '
        Me.cmdUDDDeSelectAll.Location = New System.Drawing.Point(97, 202)
        Me.cmdUDDDeSelectAll.Name = "cmdUDDDeSelectAll"
        Me.cmdUDDDeSelectAll.Size = New System.Drawing.Size(86, 22)
        Me.cmdUDDDeSelectAll.TabIndex = 23
        Me.cmdUDDDeSelectAll.Text = "Deselect All"
        Me.cmdUDDDeSelectAll.UseVisualStyleBackColor = True
        '
        'cmdUDDSelectAll
        '
        Me.cmdUDDSelectAll.Location = New System.Drawing.Point(5, 202)
        Me.cmdUDDSelectAll.Name = "cmdUDDSelectAll"
        Me.cmdUDDSelectAll.Size = New System.Drawing.Size(86, 22)
        Me.cmdUDDSelectAll.TabIndex = 22
        Me.cmdUDDSelectAll.Text = "Select All"
        Me.cmdUDDSelectAll.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.dgUsers)
        Me.TabPage6.Controls.Add(Me.cmdUserDeSelectAll)
        Me.TabPage6.Controls.Add(Me.cmdUserSelectAll)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(743, 232)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Users"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'dgUsers
        '
        Me.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsers.Location = New System.Drawing.Point(8, 8)
        Me.dgUsers.Name = "dgUsers"
        Me.dgUsers.Size = New System.Drawing.Size(731, 189)
        Me.dgUsers.TabIndex = 21
        '
        'cmdUserDeSelectAll
        '
        Me.cmdUserDeSelectAll.Location = New System.Drawing.Point(97, 202)
        Me.cmdUserDeSelectAll.Name = "cmdUserDeSelectAll"
        Me.cmdUserDeSelectAll.Size = New System.Drawing.Size(86, 22)
        Me.cmdUserDeSelectAll.TabIndex = 23
        Me.cmdUserDeSelectAll.Text = "Deselect All"
        Me.cmdUserDeSelectAll.UseVisualStyleBackColor = True
        '
        'cmdUserSelectAll
        '
        Me.cmdUserSelectAll.Location = New System.Drawing.Point(5, 202)
        Me.cmdUserSelectAll.Name = "cmdUserSelectAll"
        Me.cmdUserSelectAll.Size = New System.Drawing.Size(86, 22)
        Me.cmdUserSelectAll.TabIndex = 22
        Me.cmdUserSelectAll.Text = "Select All"
        Me.cmdUserSelectAll.UseVisualStyleBackColor = True
        '
        'cmdRestore
        '
        Me.cmdRestore.Location = New System.Drawing.Point(324, 466)
        Me.cmdRestore.Name = "cmdRestore"
        Me.cmdRestore.Size = New System.Drawing.Size(125, 29)
        Me.cmdRestore.TabIndex = 12
        Me.cmdRestore.Text = "Mulai Restore"
        Me.cmdRestore.UseVisualStyleBackColor = True
        '
        'gbLogin
        '
        Me.gbLogin.Controls.Add(Me.Label5)
        Me.gbLogin.Controls.Add(Me.txtPreset)
        Me.gbLogin.Controls.Add(Me.Label6)
        Me.gbLogin.Controls.Add(Me.txtBackupFile)
        Me.gbLogin.Controls.Add(Me.cmdOpenFile)
        Me.gbLogin.Controls.Add(Me.txtPassword)
        Me.gbLogin.Controls.Add(Me.Label3)
        Me.gbLogin.Controls.Add(Me.Label4)
        Me.gbLogin.Controls.Add(Me.txtUsername)
        Me.gbLogin.Controls.Add(Me.txtDatabaseName)
        Me.gbLogin.Controls.Add(Me.Label1)
        Me.gbLogin.Controls.Add(Me.Label2)
        Me.gbLogin.Controls.Add(Me.txtServerName)
        Me.gbLogin.Location = New System.Drawing.Point(15, 16)
        Me.gbLogin.Name = "gbLogin"
        Me.gbLogin.Size = New System.Drawing.Size(407, 180)
        Me.gbLogin.TabIndex = 10
        Me.gbLogin.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Nama Server Default :"
        '
        'txtPreset
        '
        Me.txtPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPreset.FormattingEnabled = True
        Me.txtPreset.Location = New System.Drawing.Point(138, 17)
        Me.txtPreset.Name = "txtPreset"
        Me.txtPreset.Size = New System.Drawing.Size(144, 21)
        Me.txtPreset.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "File Backup :"
        '
        'txtBackupFile
        '
        Me.txtBackupFile.Location = New System.Drawing.Point(138, 150)
        Me.txtBackupFile.Name = "txtBackupFile"
        Me.txtBackupFile.ReadOnly = True
        Me.txtBackupFile.Size = New System.Drawing.Size(144, 20)
        Me.txtBackupFile.TabIndex = 19
        '
        'cmdOpenFile
        '
        Me.cmdOpenFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdOpenFile.Location = New System.Drawing.Point(288, 148)
        Me.cmdOpenFile.Name = "cmdOpenFile"
        Me.cmdOpenFile.Size = New System.Drawing.Size(91, 24)
        Me.cmdOpenFile.TabIndex = 18
        Me.cmdOpenFile.Text = "Cari File......"
        Me.cmdOpenFile.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(139, 123)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(143, 20)
        Me.txtPassword.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama User :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password :"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(139, 96)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(143, 20)
        Me.txtUsername.TabIndex = 6
        '
        'txtDatabaseName
        '
        Me.txtDatabaseName.Location = New System.Drawing.Point(139, 70)
        Me.txtDatabaseName.Name = "txtDatabaseName"
        Me.txtDatabaseName.Size = New System.Drawing.Size(143, 20)
        Me.txtDatabaseName.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server Lokal :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Database :"
        '
        'txtServerName
        '
        Me.txtServerName.Location = New System.Drawing.Point(139, 44)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(143, 20)
        Me.txtServerName.TabIndex = 4
        '
        'rdAppend
        '
        Me.rdAppend.AutoSize = True
        Me.rdAppend.Location = New System.Drawing.Point(162, 43)
        Me.rdAppend.Name = "rdAppend"
        Me.rdAppend.Size = New System.Drawing.Size(108, 17)
        Me.rdAppend.TabIndex = 22
        Me.rdAppend.Text = "Database Default"
        Me.rdAppend.UseVisualStyleBackColor = True
        '
        'rdDrop
        '
        Me.rdDrop.AutoSize = True
        Me.rdDrop.Location = New System.Drawing.Point(162, 19)
        Me.rdDrop.Name = "rdDrop"
        Me.rdDrop.Size = New System.Drawing.Size(155, 17)
        Me.rdDrop.TabIndex = 21
        Me.rdDrop.Text = "Buang Database Yang Ada"
        Me.rdDrop.UseVisualStyleBackColor = True
        '
        'gbExport
        '
        Me.gbExport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gbExport.Controls.Add(Me.gbOptions)
        Me.gbExport.Controls.Add(Me.Label7)
        Me.gbExport.Controls.Add(Me.cmdRestore)
        Me.gbExport.Controls.Add(Me.gbProgress)
        Me.gbExport.Controls.Add(Me.gbLogin)
        Me.gbExport.Controls.Add(Me.TabControl1)
        Me.gbExport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbExport.Location = New System.Drawing.Point(0, 0)
        Me.gbExport.Name = "gbExport"
        Me.gbExport.Size = New System.Drawing.Size(784, 512)
        Me.gbExport.TabIndex = 2
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.rdNone)
        Me.gbOptions.Controls.Add(Me.rdDrop)
        Me.gbOptions.Controls.Add(Me.rdAppend)
        Me.gbOptions.Controls.Add(Me.chkData)
        Me.gbOptions.Controls.Add(Me.chkStructure)
        Me.gbOptions.Controls.Add(Me.chkDeleteExistingData)
        Me.gbOptions.Location = New System.Drawing.Point(428, 99)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(340, 97)
        Me.gbOptions.TabIndex = 32
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = "Options"
        '
        'rdNone
        '
        Me.rdNone.AutoSize = True
        Me.rdNone.Checked = True
        Me.rdNone.Location = New System.Drawing.Point(162, 65)
        Me.rdNone.Name = "rdNone"
        Me.rdNone.Size = New System.Drawing.Size(121, 17)
        Me.rdNone.TabIndex = 31
        Me.rdNone.TabStop = True
        Me.rdNone.Text = "Buat Database Baru"
        Me.rdNone.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(782, 16)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Restore Database"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrorProviderExtended1
        '
        Me.ErrorProviderExtended1.ContainerControl = Me
        Me.ErrorProviderExtended1.SummaryMessage = "Please enter following mandatory fields,"
        '
        'F_DatabaseRestore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 512)
        Me.Controls.Add(Me.gbExport)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_DatabaseRestore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Restore"
        Me.gbProgress.ResumeLayout(False)
        Me.gbProgress.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgTables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgViews, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgSps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgUDFs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.dgUDDs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.dgUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLogin.ResumeLayout(False)
        Me.gbLogin.PerformLayout()
        Me.gbExport.ResumeLayout(False)
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        CType(Me.ErrorProviderExtended1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbProgress As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgTables As System.Windows.Forms.DataGridView
    Friend WithEvents cmdTablesDeSelectAll As System.Windows.Forms.Button
    Friend WithEvents cmdTablesSelectAll As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgViews As System.Windows.Forms.DataGridView
    Friend WithEvents cmdViewsDeSelectAll As System.Windows.Forms.Button
    Friend WithEvents cmdViewsSelectAll As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgSps As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSpDeSelectAll As System.Windows.Forms.Button
    Friend WithEvents cmdSpSelectAll As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents dgUDFs As System.Windows.Forms.DataGridView
    Friend WithEvents cmdUDFDeSelectAll As System.Windows.Forms.Button
    Friend WithEvents cmdUDFSelectAll As System.Windows.Forms.Button
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents dgUDDs As System.Windows.Forms.DataGridView
    Friend WithEvents cmdUDDDeSelectAll As System.Windows.Forms.Button
    Friend WithEvents cmdUDDSelectAll As System.Windows.Forms.Button
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents dgUsers As System.Windows.Forms.DataGridView
    Friend WithEvents cmdUserDeSelectAll As System.Windows.Forms.Button
    Friend WithEvents cmdUserSelectAll As System.Windows.Forms.Button
    Friend WithEvents cmdRestore As System.Windows.Forms.Button
    Friend WithEvents gbLogin As System.Windows.Forms.GroupBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtDatabaseName As System.Windows.Forms.TextBox
    Friend WithEvents txtServerName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkStructure As System.Windows.Forms.CheckBox
    Friend WithEvents chkData As System.Windows.Forms.CheckBox
    Friend WithEvents chkDeleteExistingData As System.Windows.Forms.CheckBox
    Friend WithEvents cmdOpenFile As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBackupFile As System.Windows.Forms.TextBox
    Friend WithEvents rdDrop As System.Windows.Forms.RadioButton
    Friend WithEvents rdAppend As System.Windows.Forms.RadioButton
    Friend WithEvents gbExport As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblObjectName As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents gbOptions As System.Windows.Forms.GroupBox
    Friend WithEvents ErrorProviderExtended1 As Aplikasi_Gemblong_Cinta.ErrorProviderExtended
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPreset As System.Windows.Forms.ComboBox
    Friend WithEvents rdNone As System.Windows.Forms.RadioButton
End Class
