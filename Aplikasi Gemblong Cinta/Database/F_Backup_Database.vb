'   Database backup utility:
'   ========================
'   Copyright (C) 2007  Shabdar Ghata 
'   Email : ghata2002@gmail.com
'   URL : http://www.shabdar.org

'   This program is free software: you can redistribute it and/or modify
'   it under the terms of the GNU General Public License as published by
'   the Free Software Foundation, either version 3 of the License, or
'   (at your option) any later version.

'   This program is distributed in the hope that it will be useful,
'   but WITHOUT ANY WARRANTY; without even the implied warranty of
'   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'   GNU General Public License for more details.

'   You should have received a copy of the GNU General Public License
'   along with this program.  If not, see <http://www.gnu.org/licenses/>.

'   This program comes with ABSOLUTELY NO WARRANTY.

Imports System.Data
Imports System.Data.OleDb
Imports System.Reflection
Imports System.Threading
Public Class F_Backup_Database
    Dim OledbConnectionString As String
    Dim oScript As New C_Script
    Dim BackupPath As String = GetCurrentPath() + "BackupTemp\"
    Dim sFileName As String
    Private Sub frmDatabaseBackup_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        SaveSettingsAs(My.Application.Info.DirectoryPath + "\DefaultValues.backupsettings")
    End Sub

    'When process is running, disable controls on form
    Sub ShowProgressBar()
        SetControlPropertyValue(ProgressBar1, "Visible", True)
        SetControlPropertyValue(gbServerProperties, "Enabled", False)
        SetControlPropertyValue(gbOptions, "Enabled", False)
        SetControlPropertyValue(cmdImport, "Enabled", False)

        SetControlPropertyValue(cmdTablesSelectAll, "Enabled", False)
        SetControlPropertyValue(cmdTablesDeSelectAll, "Enabled", False)

        SetControlPropertyValue(cmdSpSelectAll, "Enabled", False)
        SetControlPropertyValue(cmdSpDeSelectAll, "Enabled", False)

        SetControlPropertyValue(cmdViewsSelectAll, "Enabled", False)
        SetControlPropertyValue(cmdViewsDeSelectAll, "Enabled", False)

        SetControlPropertyValue(cmdUDFSelectAll, "Enabled", False)
        SetControlPropertyValue(cmdUDFDeSelectAll, "Enabled", False)

        SetControlPropertyValue(cmdUDDSelectAll, "Enabled", False)
        SetControlPropertyValue(cmdUDDDeSelectAll, "Enabled", False)

        SetControlPropertyValue(cmdUserSelectAll, "Enabled", False)
        SetControlPropertyValue(cmdUserDeSelectAll, "Enabled", False)


        SetControlPropertyValue(dgTables, "ReadOnly", True)
        SetControlPropertyValue(dgSps, "ReadOnly", True)
        SetControlPropertyValue(dgViews, "ReadOnly", True)
        SetControlPropertyValue(dgUDFs, "ReadOnly", True)
        SetControlPropertyValue(dgUDDs, "ReadOnly", True)
        SetControlPropertyValue(dgUsers, "ReadOnly", True)

        'SetControlPropertyValue(lblPleasewait, "Visible", True)
        'ProgressBar1.Visible = True
        'lblPleasewait.Visible = True
    End Sub

    'When process completed, enable controls on form
    Sub HideProgressBar()
        SetControlPropertyValue(ProgressBar1, "Visible", False)
        'SetControlPropertyValue(lblPleasewait, "Visible", False)
        SetControlPropertyValue(lblObjectName, "Text", "")
        SetControlPropertyValue(lblStatus, "Text", "")
        'ProgressBar1.Visible = False
        'lblPleasewait.Visible = False

        SetControlPropertyValue(gbServerProperties, "Enabled", True)
        SetControlPropertyValue(gbOptions, "Enabled", True)
        SetControlPropertyValue(cmdImport, "Enabled", True)

        SetControlPropertyValue(cmdTablesSelectAll, "Enabled", True)
        SetControlPropertyValue(cmdTablesDeSelectAll, "Enabled", True)

        SetControlPropertyValue(cmdSpSelectAll, "Enabled", True)
        SetControlPropertyValue(cmdSpDeSelectAll, "Enabled", True)

        SetControlPropertyValue(cmdViewsSelectAll, "Enabled", True)
        SetControlPropertyValue(cmdViewsDeSelectAll, "Enabled", True)

        SetControlPropertyValue(cmdUDFSelectAll, "Enabled", True)
        SetControlPropertyValue(cmdUDFDeSelectAll, "Enabled", True)

        SetControlPropertyValue(cmdUDDSelectAll, "Enabled", True)
        SetControlPropertyValue(cmdUDDDeSelectAll, "Enabled", True)

        SetControlPropertyValue(cmdUserSelectAll, "Enabled", True)
        SetControlPropertyValue(cmdUserDeSelectAll, "Enabled", True)


        SetControlPropertyValue(dgTables, "ReadOnly", False)
        SetControlPropertyValue(dgSps, "ReadOnly", False)
        SetControlPropertyValue(dgViews, "ReadOnly", False)
        SetControlPropertyValue(dgUDFs, "ReadOnly", False)
        SetControlPropertyValue(dgUDDs, "ReadOnly", False)
        SetControlPropertyValue(dgUsers, "ReadOnly", False)
    End Sub

    Sub Center_Form()
        Dim maxwidth As Integer = Screen.PrimaryScreen.WorkingArea.Size.Width
        'Remove 10% top part of window
        Dim maxheight As Integer = Screen.PrimaryScreen.WorkingArea.Size.Height - Screen.PrimaryScreen.WorkingArea.Size.Height * 0.1
        Me.WindowState = FormWindowState.Maximized
        Me.Panel1.Left = (maxwidth - Me.Panel1.Width) / 2
        Me.Panel1.Top = ((maxheight - Me.Panel1.Height) / 2)
    End Sub

    Private Function GetCurrentPath() As String
        'Dim aPath As String
        'Dim aName As String
        'aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
        'aPath = System.IO.Path.GetDirectoryName(aName)
        Dim sPath As String = System.Reflection.Assembly.GetExecutingAssembly.Location
        Dim n As Integer = InStrRev(sPath, "\")
        If (n > 0) Then
            sPath = Mid(sPath, 1, n)
        End If
        Return sPath
    End Function

    Private Sub frmBackupDatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '  Center_Form()
            HideProgressBar()
            Initialize_Error_Provider()
            AddHandler cmdTablesSelectAll.Click, AddressOf cmdSelectAll_Click
            AddHandler cmdTablesDeSelectAll.Click, AddressOf cmdDeSelectAll_Click

            AddHandler cmdViewsSelectAll.Click, AddressOf cmdSelectAll_Click
            AddHandler cmdViewsDeSelectAll.Click, AddressOf cmdDeSelectAll_Click

            AddHandler cmdSpSelectAll.Click, AddressOf cmdSelectAll_Click
            AddHandler cmdSpDeSelectAll.Click, AddressOf cmdDeSelectAll_Click

            AddHandler cmdUDFSelectAll.Click, AddressOf cmdSelectAll_Click
            AddHandler cmdUDFDeSelectAll.Click, AddressOf cmdDeSelectAll_Click

            AddHandler cmdUDDSelectAll.Click, AddressOf cmdSelectAll_Click
            AddHandler cmdUDDDeSelectAll.Click, AddressOf cmdDeSelectAll_Click

            AddHandler cmdUserSelectAll.Click, AddressOf cmdSelectAll_Click
            AddHandler cmdUserDeSelectAll.Click, AddressOf cmdDeSelectAll_Click
            cmdImport.Enabled = False
            LoadSettingsFrom(My.Application.Info.DirectoryPath + "\DefaultValues.backupsettings")
            'BackupPath = "c:\tempbackup\" 'My.Application.Info.DirectoryPath + "\Temp\" + Format(DateTime.Now, "ddMMyyhhmmss") + "\"
        Catch ex As Exception
            MessageBox.Show(ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImport.Click
        Try
            If Me.ErrorProviderExtended1.ShowSummaryErrorMessage(Nothing) Then
                oScript.ConnectDatabaseWithRefresh(txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text)
                If chkData.Checked = False And chkStructure.Checked = False Then
                    MessageBox.Show("Please select structure or data to backup.", "Check", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
                ShowProgressBar()
                Panel1.Enabled = False
                ProgressBar1.Maximum = 8
                SetProgress(1)
                Me.Refresh()
                sFileName = C_Common.AskSaveAsFile()
                If sFileName <> "" Then
                    'txtFileName.Text = sFileName
                    Dim t1 As New Thread(AddressOf Export_Database)
                    t1.Start()
                    'Export_Database()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            Panel1.Enabled = True
            HideProgressBar()
        End Try
    End Sub
    Sub Export_Database()
        ShowProgressBar()
        If My.Computer.FileSystem.DirectoryExists(BackupPath) Then
            My.Computer.FileSystem.DeleteDirectory(BackupPath, FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(BackupPath) Then
            My.Computer.FileSystem.CreateDirectory(BackupPath)
        End If
        Dim DTScripts As New DataTable
        DTScripts.Columns.Add("ObjectName", "".GetType)
        DTScripts.Columns.Add("ObjectType", "".GetType)
        DTScripts.Columns.Add("ScriptSQL", "".GetType)
        'SetProgress(2)
        SetControlPropertyValue(lblObjectName, "Text", "Exporting tables...")
        GenerateFiles(DTScripts, dgTables, chkData.Checked, "table", chkStructure.Checked)
        'SetProgress(3)
        'lblObjectName.Text = "Exporting views..."
        SetControlPropertyValue(lblObjectName, "Text", "Exporting views...")
        GenerateFiles(DTScripts, dgViews, False, "view", chkStructure.Checked)
        'SetProgress(4)
        SetControlPropertyValue(lblObjectName, "Text", "Exporting procedures...")
        'lblObjectName.Text = "Exporting stored procedures..."
        GenerateFiles(DTScripts, dgSps, False, "sp", chkStructure.Checked)
        'SetProgress(5)
        SetControlPropertyValue(lblObjectName, "Text", "Exporting user defined functions...")
        'lblObjectName.Text = "Exporting user defined functions..."
        GenerateFiles(DTScripts, dgUDFs, False, "UDF", chkStructure.Checked)
        'SetProgress(6)
        ''lblObjectName.Text = "Exporting tables..."
        GenerateFiles(DTScripts, dgUDDs, False, "UDD", chkStructure.Checked)
        ''SetProgress(7)
        GenerateFiles(DTScripts, dgUsers, False, "User", chkStructure.Checked)
        ''SetProgress(8)
        C_Zip.ZipIT(BackupPath, sFileName)
        My.Computer.FileSystem.DeleteDirectory(BackupPath, FileIO.DeleteDirectoryOption.DeleteAllContents)
        MessageBox.Show("Database backup complete", "Backup Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        HideProgressBar()
    End Sub
    Sub GenerateFiles(ByRef DTScripts As DataTable, ByRef dg As DataGridView, ByVal bExportData As Boolean, ByVal pObjectType As String, ByVal bGenerateScripts As Boolean)
        If Not IsNothing(dg.DataSource) Then
            Dim DT As DataTable = CType(dg.DataSource, DataTable)
            Dim i As Integer
            SetControlPropertyValue(ProgressBar1, "Minimum", 0)
            SetControlPropertyValue(ProgressBar1, "Maximum", DT.Rows.Count)
            SetControlPropertyValue(ProgressBar1, "Value", 0)
            For i = 0 To DT.Rows.Count - 1
                If DT.Rows(i)("Select") = True Then
                    'scriptfile.WriteLine("------------------<" + CStr(DT.Rows(i)(pObjectType + "NAME")) + ">----------------------")
                    Dim ObjectName As String = CStr(DT.Rows(i)(pObjectType + "NAME"))
                    SetControlPropertyValue(lblStatus, "Text", "" + ObjectName + "")
                    If bGenerateScripts Then
                        Dim sSQL As String = oScript.GenerateScript(txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text, pObjectType, ObjectName)
                        DTScripts.Rows.Add(New Object() {DT.Rows(i)(pObjectType + "NAME"), pObjectType, sSQL})
                    End If
                    If bExportData Then
                        'SetControlPropertyValue(lblStatus, "Text", "Exporting data of '" + ObjectName + "'")
                        oScript.ExportData(txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text, DT.Rows(i)(pObjectType + "NAME"), DT.Rows(i)("Condition"), DT.Rows(i)("TotalRows"), BackupPath)
                    End If
                End If
                SetControlPropertyValue(ProgressBar1, "Value", i)
            Next
            DTScripts.TableName = "SQLScripts"
            DTScripts.WriteXml(BackupPath + "SQLScripts.xml")
        End If
    End Sub

    Function Get_Connection_String()
        Return "Provider=SQLOLEDB.1;data source=" + txtServerName.Text + ";user id=" + txtUsername.Text + ";Password=" + txtPassword.Text + ";database=" + txtDatabaseName.Text + ""
    End Function

    Private Sub cmdConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConnect.Click
        Try
            If Me.ErrorProviderExtended1.ShowSummaryErrorMessage(Nothing) Then
                'Check if this database exist.
                Dim CN As New OleDbConnection(Get_Connection_String())
                Try
                    CN.Open()
                    CN.Close()
                Catch
                    Throw
                End Try
                ShowProgressBar()
                Panel1.Enabled = False
                ProgressBar1.Maximum = 8
                SetProgress(1)
                Me.Refresh()
                Connect_To_Database()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            Panel1.Enabled = True
            HideProgressBar()
        End Try
    End Sub
    Sub Connect_To_Database()
        Try
            If (oScript.ConnectDatabaseWithRefresh(txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text)) Then
                cmdImport.Enabled = True
            End If
            SetProgress(3)
            'Dim oScript As New clsScript
            dgTables.DataSource = oScript.GetTableNames(txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text, txtNoOfRows.Text)
            dgViews.DataSource = oScript.GetViewNames(txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text)
            SetProgress(4)
            dgSps.DataSource = oScript.GetSPNames(txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text)
            SetProgress(5)
            dgUDFs.DataSource = oScript.GetUDFNames(txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text)
            SetProgress(6)
            dgUDDs.DataSource = oScript.GetUDDNames(txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text)
            SetProgress(7)
            dgUsers.DataSource = oScript.GetUserNames(txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text)
            SetProgress(8)
            Format_All_Grids()
        Catch ex As Exception
            MessageBox.Show(ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub
    'Sub Format_Grid(ByRef dg As DataGridView)
    '    Dim i As Integer
    '    If Not IsNothing(dg.DataSource) Then
    '        For i = 0 To dg.Columns.Count - 1
    '            If i = 0 Then dg.Columns(0).Width = 220
    '            If i = 1 Then dg.Columns(1).Width = 50
    '            If i = 2 Then dg.Columns(2).Width = 120
    '            If i = 3 Then dg.Columns(3).Width = 300
    '            If i = 4 Then dg.Columns(4).Width = 0
    '        Next
    '    End If
    'End Sub
    Sub Format_All_Grids()
        C_Common.Format_Grid_Backup(dgTables)
        C_Common.Format_Grid_Backup(dgViews)
        C_Common.Format_Grid_Backup(dgSps)
        C_Common.Format_Grid_Backup(dgUDFs)
        C_Common.Format_Grid_Backup(dgUDDs)
        C_Common.Format_Grid_Backup(dgUsers)
    End Sub
    Public Sub Change_Progress_Bar_Value(ByVal val As Integer)
        SetProgress(val)
    End Sub

    Private Sub cmdSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dg As DataGridView
            If InStr(sender.Name.ToUpper, "table".ToUpper) > 0 Then
                dg = dgTables
            End If
            If InStr(sender.Name.ToUpper, "view".ToUpper) > 0 Then
                dg = dgViews
            End If
            If InStr(sender.Name.ToUpper, "sp".ToUpper) > 0 Then
                dg = dgSps
            End If
            If InStr(sender.Name.ToUpper, "udf".ToUpper) > 0 Then
                dg = dgUDFs
            End If
            If InStr(sender.Name.ToUpper, "udd".ToUpper) > 0 Then
                dg = dgUDDs
            End If
            If InStr(sender.Name.ToUpper, "user".ToUpper) > 0 Then
                dg = dgUsers
            End If
            If Not IsNothing(dg.DataSource) Then
                Dim i As Integer
                Dim DT As DataTable
                DT = CType(dg.DataSource, DataTable)
                For i = 0 To DT.Rows.Count - 1
                    DT.Rows(i)("Select") = True
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub
    Private Sub cmdDeSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dg As DataGridView
            If InStr(sender.Name.ToUpper, "table".ToUpper) > 0 Then
                dg = dgTables
            End If
            If InStr(sender.Name.ToUpper, "view".ToUpper) > 0 Then
                dg = dgViews
            End If
            If InStr(sender.Name.ToUpper, "sp".ToUpper) > 0 Then
                dg = dgSps
            End If
            If InStr(sender.Name.ToUpper, "udf".ToUpper) > 0 Then
                dg = dgUDFs
            End If
            If InStr(sender.Name.ToUpper, "udd".ToUpper) > 0 Then
                dg = dgUDDs
            End If
            If InStr(sender.Name.ToUpper, "user".ToUpper) > 0 Then
                dg = dgUsers
            End If
            If Not IsNothing(dg.DataSource) Then
                Dim i As Integer
                Dim DT As DataTable
                DT = CType(dg.DataSource, DataTable)
                For i = 0 To DT.Rows.Count - 1
                    DT.Rows(i)("Select") = False
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub
    Sub SetProgress(ByVal iVal As Integer)
        'SetControlPropertyValue(lblPleasewait, "Visible", True)
        'SetControlPropertyValue(ProgressBar1, "Visible", True)
        SetControlPropertyValue(ProgressBar1, "Value", iVal)
        'ProgressBar1.Value = iVal
        'Me.Refresh()
    End Sub

    Private Sub cmdSaveSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sFileName As String = ""
        Dim filedialog1 As New SaveFileDialog
        filedialog1.Filter = "SQL Backup Settings Files|*.backupsettings"
        filedialog1.FileName = txtServerName.Text + "_" + txtDatabaseName.Text + "_" + Format(DateTime.Now, "ddMMMyyyy") + ".backupsettings"
        If filedialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            sFileName = filedialog1.FileName
            SaveSettingsAs(sFileName)
        End If
    End Sub
    Sub SaveSettingsAs(ByVal sFileName As String)

        Dim DT As New DataTable
        Dim DS As New DataSet
        'Save settings for database, server etc
        DT.Columns.Add("Server", "".GetType)
        DT.Columns.Add("Database", "".GetType)
        DT.Columns.Add("UserName", "".GetType)
        DT.Columns.Add("Password", "".GetType)
        DT.Columns.Add("chkData", True.GetType)
        DT.Columns.Add("chkStructure", True.GetType)
        DT.Columns.Add("NoOfRows", "".GetType)
        'DT.Columns.Add("BackupDir", "".GetType)
        DT.Rows.Add(New Object() {txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text, chkData.Checked, chkStructure.Checked, txtNoOfRows.Text})
        DT.TableName = "DefaultValues"
        DS.Tables.Add(DT)

        'AddTablesForSettingsSave(DS, dgTables, "table")
        'AddTablesForSettingsSave(DS, dgViews, "view")
        'AddTablesForSettingsSave(DS, dgSps, "sp")
        'AddTablesForSettingsSave(DS, dgUDFs, "udf")
        'AddTablesForSettingsSave(DS, dgUDDs, "udd")
        'AddTablesForSettingsSave(DS, dgUsers, "user")

        'Save settings for Presets

        'Create new preset table structure
        Dim DTPresetNew As New DataTable
        DTPresetNew.TableName = "Preset"
        DTPresetNew.Columns.Add("Server", "".GetType())
        DTPresetNew.Columns.Add("Database", "".GetType())
        DTPresetNew.Columns.Add("UserName", "".GetType())
        DTPresetNew.Columns.Add("Password", "".GetType())

        Dim DTPreset As DataTable
        Dim DSPreset As New DataSet
        'Read existing preset from XML file\
        If (My.Computer.FileSystem.FileExists(sFileName)) Then
            DSPreset.ReadXml(sFileName)
            DTPreset = DSPreset.Tables("Preset")
        End If
        If (Not IsNothing(DTPreset)) Then
            'Copy existing preset data into new preset
            DTPresetNew = DTPreset.Copy()
        End If

        'Check if this server and database already exist in old preset.
        Dim i As Integer
        Dim bFound As Boolean = False
        For i = 0 To DTPresetNew.Rows.Count - 1
            If DTPresetNew.Rows(i)("Server").ToString().ToUpper() = txtServerName.Text.ToUpper() Then
                bFound = True
                DTPresetNew.Rows(i)("UserName") = txtUsername.Text
                DTPresetNew.Rows(i)("Password") = txtPassword.Text
            End If
        Next
        'If this server and database doesn't exist, create new entry in preset.
        If (Not bFound) Then
            If (txtServerName.Text.Trim() <> "") Then
                DTPresetNew.Rows.Add(New Object() {txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text})
            End If
        End If
        DS.Tables.Add(DTPresetNew)

        DS.WriteXml(sFileName)
        DS.Tables.Clear()
    End Sub

    Sub AddTablesForSettingsSave(ByRef DS As DataSet, ByRef dg As DataGridView, ByVal objectTypeName As String)
        If Not IsNothing(dg.DataSource) Then
            Dim DTTables As DataTable = dg.DataSource
            DTTables.TableName = objectTypeName
            'DS.Tables.Remove(DTTables)
            DS.Tables.Add(DTTables)
        End If
    End Sub

    'This function loads default values for server,database, user name and password that were used last time for backup.
    Sub LoadSettingsFrom(ByVal sFileName As String)
        Dim DS As New DataSet
        If Not My.Computer.FileSystem.FileExists(sFileName) Then
            'MessageBox.Show("Settings file '" + sFileName + "' does not exists.", "File not exists", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If (My.Computer.FileSystem.FileExists(sFileName)) Then
            DS.ReadXml(sFileName)

            Dim DT As DataTable
            'Load Preset combo box
            DT = DS.Tables("Preset")
            If (Not IsNothing(DT)) Then
                txtPreset.DisplayMember = "Server"
                txtPreset.ValueMember = "Server"
                txtPreset.DataSource = DT
            End If

            'Fill default values for server, database etc.
            dt = DS.Tables(0)
            If DT.Rows.Count > 0 Then
                txtPreset.Text = DT.Rows(0)("Server")
                txtServerName.Text = DT.Rows(0)("Server")
                txtDatabaseName.Text = DT.Rows(0)("Database")
                txtUsername.Text = DT.Rows(0)("UserName")
                txtPassword.Text = DT.Rows(0)("Password")
                'BackupPath = DT.Rows(0)("BackupDir")
            Else
                txtServerName.Text = ""
                txtDatabaseName.Text = ""
                txtUsername.Text = ""
                txtPassword.Text = ""
                'BackupPath = "C:\DBBackup\"
            End If

            'If Not IsNothing(DS) Then
            '    ReadTablesFromSettingsDataset(DS, dgTables, "table")
            '    ReadTablesFromSettingsDataset(DS, dgViews, "view")
            '    ReadTablesFromSettingsDataset(DS, dgSps, "sp")
            '    ReadTablesFromSettingsDataset(DS, dgUDFs, "udf")
            '    ReadTablesFromSettingsDataset(DS, dgUDDs, "udd")
            '    ReadTablesFromSettingsDataset(DS, dgUsers, "user")
            'End If
            Format_All_Grids()
        End If
    End Sub

    Sub ReadTablesFromSettingsDataset(ByRef DS As DataSet, ByRef dg As DataGridView, ByVal objecttypename As String)
        If Not IsNothing(DS.Tables(objecttypename)) Then
            'DS.Tables(objecttypename).Columns("Select").DataType = True.GetType
            Dim dtTables As DataTable = DS.Tables(objecttypename)
            Dim DTNew As New DataTable
            Dim i As Integer
            For i = 0 To dtTables.Columns.Count - 1
                DTNew.Columns.Add(dtTables.Columns(i).ColumnName)
            Next
            DTNew.Columns("Select").DataType = True.GetType
            For i = 0 To dtTables.Rows.Count - 1
                If objecttypename = "table" Then
                    DTNew.Rows.Add(New Object() {dtTables.Rows(i)(0), dtTables.Rows(i)(1), dtTables.Rows(i)(2), dtTables.Rows(i)(3)})
                Else
                    DTNew.Rows.Add(New Object() {dtTables.Rows(i)(0), dtTables.Rows(i)(1)})
                End If
            Next
            dg.DataSource = DTNew
        End If
    End Sub

    Private Sub cmdLoadSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sFileName As String = ""
        Dim filedialog1 As New OpenFileDialog
        filedialog1.Filter = "SQL Backup Settings Files|*.backupsettings"
        filedialog1.FileName = txtServerName.Text + "_" + txtDatabaseName.Text + "_" + Format(DateTime.Now, "ddMMMyyyy") + ".backupsettings"
        If filedialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            sFileName = filedialog1.FileName
            LoadSettingsFrom(sFileName)
        End If
    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BackupPath = C_Common.AskDirectory
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Sub Initialize_Error_Provider()
        Try
            With Me
                .ErrorProviderExtended1.Controls.Add(.txtServerName, "Server Name")
                .ErrorProviderExtended1.Controls.Add(.txtDatabaseName, "Database Name")
                .ErrorProviderExtended1.Controls.Add(.txtUsername, "User Name")
                .ErrorProviderExtended1.SetErrorEvents()
            End With
        Catch ex As Exception
            'Logging.WriteError(ex)
        End Try
    End Sub
    'Declare delegate for making thread safe calls 
    Delegate Sub SetControlValueCallback(ByVal oControl As Control, ByVal propName As String, ByVal propValue As Object)

    'Method which invokes thread safe call 
    Private Sub SetControlPropertyValue(ByVal oControl As Control, ByVal propName As String, ByVal propValue As Object)
        If oControl.InvokeRequired Then
            Dim d As New SetControlValueCallback(AddressOf SetControlPropertyValue)
            oControl.Invoke(d, New Object() {oControl, propName, propValue})
        Else
            Dim t As Type = oControl.[GetType]()
            Dim props As PropertyInfo() = t.GetProperties()
            For Each p As PropertyInfo In props
                If p.Name.ToUpper() = propName.ToUpper() Then
                    p.SetValue(oControl, propValue, Nothing)
                End If
            Next
        End If
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtPreset_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPreset.SelectedIndexChanged
        Dim DS As New DataSet
        DS.ReadXml(My.Application.Info.DirectoryPath + "\DefaultValues.backupsettings")
        Dim DT As DataTable = DS.Tables("Preset")
        DT.DefaultView.RowFilter = "Server='" + txtPreset.Text + "'"
        If (DT.DefaultView.Count > 0) Then
            txtServerName.Text = DT.DefaultView(0)("Server")
            txtDatabaseName.Text = DT.DefaultView(0)("Database")
            txtUsername.Text = DT.DefaultView(0)("UserName")
            txtPassword.Text = DT.DefaultView(0)("Password")
        End If
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class
