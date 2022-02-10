<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Backup_Database
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Backup_Database))
        Me.chkStructure = New System.Windows.Forms.CheckBox()
        Me.chkData = New System.Windows.Forms.CheckBox()
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
        Me.txtNoOfRows = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtDatabaseName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.cmdImport = New System.Windows.Forms.Button()
        Me.gbServerProperties = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.txtPreset = New System.Windows.Forms.ComboBox()
        Me.cmdConnect = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblObjectName = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.ErrorProviderExtended1 = New Aplikasi_Gemblong_Cinta.ErrorProviderExtended()
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
        Me.gbOptions.SuspendLayout()
        Me.gbServerProperties.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProviderExtended1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkStructure
        '
        Me.chkStructure.AutoSize = True
        Me.chkStructure.Checked = True
        Me.chkStructure.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkStructure.Location = New System.Drawing.Point(459, 160)
        Me.chkStructure.Name = "chkStructure"
        Me.chkStructure.Size = New System.Drawing.Size(183, 17)
        Me.chkStructure.TabIndex = 25
        Me.chkStructure.Text = "Backup object structures (scripts)"
        Me.chkStructure.UseVisualStyleBackColor = True
        '
        'chkData
        '
        Me.chkData.AutoSize = True
        Me.chkData.Checked = True
        Me.chkData.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkData.Location = New System.Drawing.Point(459, 137)
        Me.chkData.Name = "chkData"
        Me.chkData.Size = New System.Drawing.Size(87, 17)
        Me.chkData.TabIndex = 18
        Me.chkData.Text = "Backup data"
        Me.chkData.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 49)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(349, 18)
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
        Me.TabControl1.Location = New System.Drawing.Point(9, 215)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(753, 262)
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
        Me.TabPage1.Size = New System.Drawing.Size(745, 236)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tables"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgTables
        '
        Me.dgTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTables.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgTables.Location = New System.Drawing.Point(3, 3)
        Me.dgTables.Name = "dgTables"
        Me.dgTables.Size = New System.Drawing.Size(739, 189)
        Me.dgTables.TabIndex = 11
        '
        'cmdTablesDeSelectAll
        '
        Me.cmdTablesDeSelectAll.Image = CType(resources.GetObject("cmdTablesDeSelectAll.Image"), System.Drawing.Image)
        Me.cmdTablesDeSelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTablesDeSelectAll.Location = New System.Drawing.Point(121, 202)
        Me.cmdTablesDeSelectAll.Name = "cmdTablesDeSelectAll"
        Me.cmdTablesDeSelectAll.Size = New System.Drawing.Size(110, 25)
        Me.cmdTablesDeSelectAll.TabIndex = 17
        Me.cmdTablesDeSelectAll.Text = "Batal"
        Me.cmdTablesDeSelectAll.UseVisualStyleBackColor = True
        '
        'cmdTablesSelectAll
        '
        Me.cmdTablesSelectAll.Image = CType(resources.GetObject("cmdTablesSelectAll.Image"), System.Drawing.Image)
        Me.cmdTablesSelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTablesSelectAll.Location = New System.Drawing.Point(5, 203)
        Me.cmdTablesSelectAll.Name = "cmdTablesSelectAll"
        Me.cmdTablesSelectAll.Size = New System.Drawing.Size(110, 25)
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
        Me.TabPage2.Size = New System.Drawing.Size(745, 236)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Views"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgViews
        '
        Me.dgViews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgViews.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgViews.Location = New System.Drawing.Point(3, 3)
        Me.dgViews.Name = "dgViews"
        Me.dgViews.Size = New System.Drawing.Size(739, 189)
        Me.dgViews.TabIndex = 18
        '
        'cmdViewsDeSelectAll
        '
        Me.cmdViewsDeSelectAll.Image = CType(resources.GetObject("cmdViewsDeSelectAll.Image"), System.Drawing.Image)
        Me.cmdViewsDeSelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdViewsDeSelectAll.Location = New System.Drawing.Point(121, 202)
        Me.cmdViewsDeSelectAll.Name = "cmdViewsDeSelectAll"
        Me.cmdViewsDeSelectAll.Size = New System.Drawing.Size(110, 25)
        Me.cmdViewsDeSelectAll.TabIndex = 20
        Me.cmdViewsDeSelectAll.Text = "Deselect All"
        Me.cmdViewsDeSelectAll.UseVisualStyleBackColor = True
        '
        'cmdViewsSelectAll
        '
        Me.cmdViewsSelectAll.Image = CType(resources.GetObject("cmdViewsSelectAll.Image"), System.Drawing.Image)
        Me.cmdViewsSelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdViewsSelectAll.Location = New System.Drawing.Point(5, 202)
        Me.cmdViewsSelectAll.Name = "cmdViewsSelectAll"
        Me.cmdViewsSelectAll.Size = New System.Drawing.Size(110, 25)
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
        Me.TabPage3.Size = New System.Drawing.Size(745, 236)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Stored Procedures"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgSps
        '
        Me.dgSps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSps.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgSps.Location = New System.Drawing.Point(0, 0)
        Me.dgSps.Name = "dgSps"
        Me.dgSps.Size = New System.Drawing.Size(745, 189)
        Me.dgSps.TabIndex = 21
        '
        'cmdSpDeSelectAll
        '
        Me.cmdSpDeSelectAll.Image = CType(resources.GetObject("cmdSpDeSelectAll.Image"), System.Drawing.Image)
        Me.cmdSpDeSelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSpDeSelectAll.Location = New System.Drawing.Point(121, 202)
        Me.cmdSpDeSelectAll.Name = "cmdSpDeSelectAll"
        Me.cmdSpDeSelectAll.Size = New System.Drawing.Size(110, 25)
        Me.cmdSpDeSelectAll.TabIndex = 23
        Me.cmdSpDeSelectAll.Text = "Deselect All"
        Me.cmdSpDeSelectAll.UseVisualStyleBackColor = True
        '
        'cmdSpSelectAll
        '
        Me.cmdSpSelectAll.Image = CType(resources.GetObject("cmdSpSelectAll.Image"), System.Drawing.Image)
        Me.cmdSpSelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSpSelectAll.Location = New System.Drawing.Point(5, 202)
        Me.cmdSpSelectAll.Name = "cmdSpSelectAll"
        Me.cmdSpSelectAll.Size = New System.Drawing.Size(110, 25)
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
        Me.TabPage4.Size = New System.Drawing.Size(745, 236)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "User Defined Functions"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgUDFs
        '
        Me.dgUDFs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUDFs.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgUDFs.Location = New System.Drawing.Point(0, 0)
        Me.dgUDFs.Name = "dgUDFs"
        Me.dgUDFs.Size = New System.Drawing.Size(745, 189)
        Me.dgUDFs.TabIndex = 21
        '
        'cmdUDFDeSelectAll
        '
        Me.cmdUDFDeSelectAll.Image = CType(resources.GetObject("cmdUDFDeSelectAll.Image"), System.Drawing.Image)
        Me.cmdUDFDeSelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUDFDeSelectAll.Location = New System.Drawing.Point(120, 202)
        Me.cmdUDFDeSelectAll.Name = "cmdUDFDeSelectAll"
        Me.cmdUDFDeSelectAll.Size = New System.Drawing.Size(110, 25)
        Me.cmdUDFDeSelectAll.TabIndex = 23
        Me.cmdUDFDeSelectAll.Text = "Deselect All"
        Me.cmdUDFDeSelectAll.UseVisualStyleBackColor = True
        '
        'cmdUDFSelectAll
        '
        Me.cmdUDFSelectAll.Image = CType(resources.GetObject("cmdUDFSelectAll.Image"), System.Drawing.Image)
        Me.cmdUDFSelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUDFSelectAll.Location = New System.Drawing.Point(5, 202)
        Me.cmdUDFSelectAll.Name = "cmdUDFSelectAll"
        Me.cmdUDFSelectAll.Size = New System.Drawing.Size(110, 25)
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
        Me.TabPage5.Size = New System.Drawing.Size(745, 236)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "User Defined Datatypes"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'dgUDDs
        '
        Me.dgUDDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUDDs.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgUDDs.Location = New System.Drawing.Point(0, 0)
        Me.dgUDDs.Name = "dgUDDs"
        Me.dgUDDs.Size = New System.Drawing.Size(745, 189)
        Me.dgUDDs.TabIndex = 21
        '
        'cmdUDDDeSelectAll
        '
        Me.cmdUDDDeSelectAll.Image = CType(resources.GetObject("cmdUDDDeSelectAll.Image"), System.Drawing.Image)
        Me.cmdUDDDeSelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUDDDeSelectAll.Location = New System.Drawing.Point(121, 202)
        Me.cmdUDDDeSelectAll.Name = "cmdUDDDeSelectAll"
        Me.cmdUDDDeSelectAll.Size = New System.Drawing.Size(110, 25)
        Me.cmdUDDDeSelectAll.TabIndex = 23
        Me.cmdUDDDeSelectAll.Text = "Deselect All"
        Me.cmdUDDDeSelectAll.UseVisualStyleBackColor = True
        '
        'cmdUDDSelectAll
        '
        Me.cmdUDDSelectAll.Image = CType(resources.GetObject("cmdUDDSelectAll.Image"), System.Drawing.Image)
        Me.cmdUDDSelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUDDSelectAll.Location = New System.Drawing.Point(5, 202)
        Me.cmdUDDSelectAll.Name = "cmdUDDSelectAll"
        Me.cmdUDDSelectAll.Size = New System.Drawing.Size(110, 25)
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
        Me.TabPage6.Size = New System.Drawing.Size(745, 236)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Users"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'dgUsers
        '
        Me.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsers.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgUsers.Location = New System.Drawing.Point(0, 0)
        Me.dgUsers.Name = "dgUsers"
        Me.dgUsers.Size = New System.Drawing.Size(745, 189)
        Me.dgUsers.TabIndex = 21
        '
        'cmdUserDeSelectAll
        '
        Me.cmdUserDeSelectAll.Image = CType(resources.GetObject("cmdUserDeSelectAll.Image"), System.Drawing.Image)
        Me.cmdUserDeSelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUserDeSelectAll.Location = New System.Drawing.Point(121, 202)
        Me.cmdUserDeSelectAll.Name = "cmdUserDeSelectAll"
        Me.cmdUserDeSelectAll.Size = New System.Drawing.Size(110, 25)
        Me.cmdUserDeSelectAll.TabIndex = 23
        Me.cmdUserDeSelectAll.Text = "Deselect All"
        Me.cmdUserDeSelectAll.UseVisualStyleBackColor = True
        '
        'cmdUserSelectAll
        '
        Me.cmdUserSelectAll.Image = CType(resources.GetObject("cmdUserSelectAll.Image"), System.Drawing.Image)
        Me.cmdUserSelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUserSelectAll.Location = New System.Drawing.Point(5, 202)
        Me.cmdUserSelectAll.Name = "cmdUserSelectAll"
        Me.cmdUserSelectAll.Size = New System.Drawing.Size(110, 25)
        Me.cmdUserSelectAll.TabIndex = 22
        Me.cmdUserSelectAll.Text = "Select All"
        Me.cmdUserSelectAll.UseVisualStyleBackColor = True
        '
        'txtNoOfRows
        '
        Me.txtNoOfRows.Location = New System.Drawing.Point(459, 111)
        Me.txtNoOfRows.Name = "txtNoOfRows"
        Me.txtNoOfRows.Size = New System.Drawing.Size(183, 20)
        Me.txtNoOfRows.TabIndex = 23
        Me.txtNoOfRows.Text = "TOP 100 PERCENT *"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(422, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Default No of rows to export :"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(151, 132)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(143, 20)
        Me.txtPassword.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Pengguna:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sandi Database:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(151, 105)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(143, 20)
        Me.txtUsername.TabIndex = 6
        Me.txtUsername.Text = "sa"
        '
        'txtDatabaseName
        '
        Me.txtDatabaseName.Location = New System.Drawing.Point(151, 79)
        Me.txtDatabaseName.Name = "txtDatabaseName"
        Me.txtDatabaseName.Size = New System.Drawing.Size(143, 20)
        Me.txtDatabaseName.TabIndex = 5
        Me.txtDatabaseName.Text = "Db_Penjualan_Gemblong"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Server :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Database :"
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.cmdImport)
        Me.gbOptions.Location = New System.Drawing.Point(402, 91)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(360, 120)
        Me.gbOptions.TabIndex = 28
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = "Options"
        '
        'cmdImport
        '
        Me.cmdImport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdImport.Image = Global.Aplikasi_Gemblong_Cinta.My.Resources.Resources.Check
        Me.cmdImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdImport.Location = New System.Drawing.Point(123, 27)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(114, 66)
        Me.cmdImport.TabIndex = 12
        Me.cmdImport.Text = "Mulai Backup"
        Me.cmdImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdImport.UseVisualStyleBackColor = True
        '
        'gbServerProperties
        '
        Me.gbServerProperties.Controls.Add(Me.Label5)
        Me.gbServerProperties.Controls.Add(Me.txtServerName)
        Me.gbServerProperties.Controls.Add(Me.txtPreset)
        Me.gbServerProperties.Controls.Add(Me.cmdConnect)
        Me.gbServerProperties.Controls.Add(Me.txtPassword)
        Me.gbServerProperties.Controls.Add(Me.Label2)
        Me.gbServerProperties.Controls.Add(Me.Label3)
        Me.gbServerProperties.Controls.Add(Me.Label1)
        Me.gbServerProperties.Controls.Add(Me.Label4)
        Me.gbServerProperties.Controls.Add(Me.txtDatabaseName)
        Me.gbServerProperties.Controls.Add(Me.txtUsername)
        Me.gbServerProperties.Location = New System.Drawing.Point(9, 10)
        Me.gbServerProperties.Name = "gbServerProperties"
        Me.gbServerProperties.Size = New System.Drawing.Size(387, 199)
        Me.gbServerProperties.TabIndex = 29
        Me.gbServerProperties.TabStop = False
        Me.gbServerProperties.Text = "Konfigurasi Database"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Server Awal :"
        '
        'txtServerName
        '
        Me.txtServerName.Location = New System.Drawing.Point(151, 56)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(143, 20)
        Me.txtServerName.TabIndex = 30
        '
        'txtPreset
        '
        Me.txtPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPreset.FormattingEnabled = True
        Me.txtPreset.Location = New System.Drawing.Point(151, 26)
        Me.txtPreset.Name = "txtPreset"
        Me.txtPreset.Size = New System.Drawing.Size(144, 21)
        Me.txtPreset.TabIndex = 29
        '
        'cmdConnect
        '
        Me.cmdConnect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdConnect.Image = CType(resources.GetObject("cmdConnect.Image"), System.Drawing.Image)
        Me.cmdConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdConnect.Location = New System.Drawing.Point(151, 158)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(100, 28)
        Me.cmdConnect.TabIndex = 15
        Me.cmdConnect.Text = "Tes Koneksi"
        Me.cmdConnect.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.gbOptions)
        Me.Panel1.Controls.Add(Me.chkData)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.chkStructure)
        Me.Panel1.Controls.Add(Me.gbServerProperties)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.txtNoOfRows)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 488)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.lblObjectName)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Location = New System.Drawing.Point(402, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 72)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'lblObjectName
        '
        Me.lblObjectName.AutoSize = True
        Me.lblObjectName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObjectName.Location = New System.Drawing.Point(6, 10)
        Me.lblObjectName.Name = "lblObjectName"
        Me.lblObjectName.Size = New System.Drawing.Size(15, 13)
        Me.lblObjectName.TabIndex = 34
        Me.lblObjectName.Text = "tt"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(6, 33)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(13, 13)
        Me.lblStatus.TabIndex = 33
        Me.lblStatus.Text = "tt"
        '
        'ErrorProviderExtended1
        '
        Me.ErrorProviderExtended1.ContainerControl = Me
        Me.ErrorProviderExtended1.SummaryMessage = "Please enter following mandatory fields,"
        '
        'F_Backup_Database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 488)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Backup_Database"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup Database"
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
        Me.gbOptions.ResumeLayout(False)
        Me.gbServerProperties.ResumeLayout(False)
        Me.gbServerProperties.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProviderExtended1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtDatabaseName As System.Windows.Forms.TextBox
    Friend WithEvents dgTables As System.Windows.Forms.DataGridView
    Friend WithEvents cmdImport As System.Windows.Forms.Button
    Friend WithEvents cmdConnect As System.Windows.Forms.Button
    Friend WithEvents cmdTablesDeSelectAll As System.Windows.Forms.Button
    Friend WithEvents cmdTablesSelectAll As System.Windows.Forms.Button
    Friend WithEvents txtNoOfRows As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgViews As System.Windows.Forms.DataGridView
    Friend WithEvents cmdViewsDeSelectAll As System.Windows.Forms.Button
    Friend WithEvents cmdViewsSelectAll As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents dgSps As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSpDeSelectAll As System.Windows.Forms.Button
    Friend WithEvents cmdSpSelectAll As System.Windows.Forms.Button
    Friend WithEvents dgUDFs As System.Windows.Forms.DataGridView
    Friend WithEvents cmdUDFDeSelectAll As System.Windows.Forms.Button
    Friend WithEvents cmdUDFSelectAll As System.Windows.Forms.Button
    Friend WithEvents dgUDDs As System.Windows.Forms.DataGridView
    Friend WithEvents cmdUDDDeSelectAll As System.Windows.Forms.Button
    Friend WithEvents cmdUDDSelectAll As System.Windows.Forms.Button
    Friend WithEvents dgUsers As System.Windows.Forms.DataGridView
    Friend WithEvents cmdUserDeSelectAll As System.Windows.Forms.Button
    Friend WithEvents cmdUserSelectAll As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents chkData As System.Windows.Forms.CheckBox
    Friend WithEvents chkStructure As System.Windows.Forms.CheckBox
    Friend WithEvents gbOptions As System.Windows.Forms.GroupBox
    Friend WithEvents gbServerProperties As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ErrorProviderExtended1 As Aplikasi_Gemblong_Cinta.ErrorProviderExtended
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblObjectName As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPreset As System.Windows.Forms.ComboBox
    Friend WithEvents txtServerName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
