'   Database backup utility:
'   ========================
'   Copyright (C) 2007  Shabdar Ghata (Email : ghata2002@gmail.com)

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
Imports System.Threading
Imports System.Reflection
Public Class F_DatabaseRestore
    Dim OledbConnectionString As String
    Dim oScript As New C_Script
    Dim RestorePath As String = GetCurrentPath() + "RestoreTemp\"

    Sub ShowProgressBar()
        SetControlPropertyValue(ProgressBar1, "Visible", True)
    End Sub
    Sub HideProgressBar()
        SetControlPropertyValue(ProgressBar1, "Visible", False)
    End Sub

    Private Sub frmDatabaseRestore_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        SaveSettingsAs(My.Application.Info.DirectoryPath + "\DefaultValues.backupsettings")
    End Sub

    Private Sub frmBackupDatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' Center_Form()
            Clear_Form()
            Initialize_Error_Provider()
            HideProgressBar()
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
            LoadSettingsFrom(My.Application.Info.DirectoryPath + "\DefaultValues.backupsettings")
            'txtBackupDir.Text = "c:\temp\" 'My.Application.Info.DirectoryPath + "\Temp\" + Format(DateTime.Now, "ddMMyyhhmmss") + "\"
            cmdRestore.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub cmdRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRestore.Click
        If Me.ErrorProviderExtended1.ShowSummaryErrorMessage(Nothing) Then
            Dim t1 As New Thread(AddressOf Import_Click)
            t1.Start()
        End If
        'Import_Click()
    End Sub
    Sub Import_Click()
        If (txtBackupFile.Text = "") Then
            MessageBox.Show("Please select a backup file.", "Select File", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Enable_Form()
            Exit Sub
        End If
        Disable_Form()
        Try
            SetControlPropertyValue(lblStatus, "Text", "Checking database...")
            oScript.ConnectDatabaseWithRefresh(txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text)
            If (IsNothing(oScript.db)) Then
                SetControlPropertyValue(lblStatus, "Text", "Creating database...")
                oScript.CreateNewDatabase(txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text)
            Else
                If (Not rdDrop.Checked And Not rdAppend.Checked) Then
                    MessageBox.Show("This database already exist. Please specify in options if you want to drop existing database or append.", "Database exists", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    SetControlPropertyValue(lblStatus, "Text", "")
                    'lblStatus.Text = ""
                    Enable_Form()
                    Exit Sub
                End If
                If (rdDrop.Checked) Then
                    SetControlPropertyValue(lblStatus, "Text", "Dropping database...")
                    'lblStatus.Text = "Dropping database..."
                    oScript.DropDatabase(txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text)
                    SetControlPropertyValue(lblStatus, "Text", "Creating database...")
                    'lblStatus.Text = "Creating database..."
                    oScript.CreateNewDatabase(txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text)
                End If
            End If
            'If chkDropDB.Checked Then
            '    Dim ans = MessageBox.Show("You have selected to drop any existing database with name '" + txtDatabaseName.Text + "'" + vbNewLine + "Are you sure you want to continue?", "Drop Database", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            '    If ans = vbNo Then
            '        Exit Sub
            '    End If
            '    oScript.DropDatabase(txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text)
            'End If
            'If chkCreateDB.Checked Then
            '    oScript.CreateNewDatabase(txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text)
            'End If
            If chkData.Checked = False And chkStructure.Checked = False Then
                MessageBox.Show("Please select structure or data to restore.", "Check", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            ShowProgressBar()
            'SetControlPropertyValue(gbExport, "Enabled", False)
            '            gbExport.Enabled = False
            SetControlPropertyValue(ProgressBar1, "Maximum", 8)
            'ProgressBar1.Maximum = 8
            SetProgress(1)
            ' Me.Refresh()
            'Dim t1 As New Thread(AddressOf Import_Database)
            't1.Start()

            Import_Database()
        Catch ex As Exception
            MessageBox.Show(ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            'SetControlPropertyValue(gbExport, "Enabled", True)
            HideProgressBar()
            Enable_Form()
        End Try
        Enable_Form()
        Clear_Form()
    End Sub
    Sub Import_Database()
        Try
            'Restore_Objects(dgTables)
            'Restore_Objects(dgUDFs)
            'Restore_Objects(dgUDDs)
            'Restore_Objects(dgViews)
            'Restore_Objects(dgSps)
            'Restore_Objects(dgUsers)
            If chkStructure.Checked Then
                Dim DS As New DataSet
                'lblStatus.Text = "Reading scripts..."
                SetControlPropertyValue(lblStatus, "Text", "Reading scripts...")
                DS.ReadXml(RestorePath + "SQLScripts.xml")
                If DS.Tables.Count > 0 Then
                    Dim DT As DataTable = DS.Tables(0)
                    Dim i As Integer
                    DT.Columns.Add("Executed", False.GetType)
                    DT.Columns.Add("Select", False.GetType)
                    DT.Columns.Add("Status")
                    For i = 0 To DT.Rows.Count - 1
                        DT.Rows(i)("Executed") = False
                        DT.Rows(i)("Select") = False
                        DT.Rows(i)("Status") = ""
                    Next
                    GetSelectedObjects(DT, dgTables, "TableName")
                    GetSelectedObjects(DT, dgViews, "ViewName")
                    GetSelectedObjects(DT, dgSps, "SPName")
                    GetSelectedObjects(DT, dgUDFs, "UDFName")
                    GetSelectedObjects(DT, dgUDDs, "UDDName")
                    GetSelectedObjects(DT, dgUsers, "UserName")

                    SetControlPropertyValue(lblStatus, "Text", "Creating objects...")
                    oScript.ExecuteScriptWithDependency(DT, lblObjectName, ProgressBar1)

                    GetStatus(DT, dgTables, "TableName")
                    GetStatus(DT, dgViews, "ViewName")
                    GetStatus(DT, dgSps, "SPName")
                    GetStatus(DT, dgUDFs, "UDFName")
                    GetStatus(DT, dgUDDs, "UDDName")
                    GetStatus(DT, dgUsers, "UserName")

                End If
            End If
            If chkData.Checked Then
                Restore_Data()
            End If
            Try
                My.Computer.FileSystem.DeleteDirectory(RestorePath, FileIO.DeleteDirectoryOption.DeleteAllContents)
            Catch
            End Try
            MessageBox.Show("Database restore complete", "Restore Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub
    Sub GetSelectedObjects(ByRef DTObjects As DataTable, ByRef dg As DataGridView, ByRef ObjectNameColumn As String)
        Dim i As Integer
        If Not IsNothing(dg.DataSource) Then
            Dim dt As DataTable = dg.DataSource
            For i = 0 To DTObjects.Rows.Count - 1
                dt.DefaultView.RowFilter = ObjectNameColumn + "='" + DTObjects.Rows(i)("ObjectName") + "'"
                If dt.DefaultView.Count > 0 Then
                    DTObjects.Rows(i)("Select") = dt.DefaultView(0)("Select")
                End If
            Next
            dt.DefaultView.RowFilter = Nothing
        End If
    End Sub
    Sub GetStatus(ByRef DTObjects As DataTable, ByRef dg As DataGridView, ByRef ObjectNameColumn As String)
        Dim i As Integer
        If Not IsNothing(dg.DataSource) Then
            Dim dt As DataTable = dg.DataSource
            For i = 0 To dt.Rows.Count - 1
                DTObjects.DefaultView.RowFilter = "ObjectName='" + dt.Rows(i)(ObjectNameColumn) + "'"
                If DTObjects.DefaultView.Count > 0 Then
                    dt.Rows(i)("status") = DTObjects.DefaultView(0)("status")
                End If
            Next
            DTObjects.DefaultView.RowFilter = Nothing
        End If
    End Sub
    Sub Restore_Data()
        'lblStatus.Text = "Restoring Data..."
        SetControlPropertyValue(lblStatus, "Text", "Restoring Data...")
        Dim i As Integer
        If Not IsNothing(dgTables.DataSource) Then
            Dim DT As DataTable = CType(dgTables.DataSource, DataTable)
            SetControlPropertyValue(ProgressBar1, "Value", 0)
            SetControlPropertyValue(ProgressBar1, "Minimum", 0)
            SetControlPropertyValue(ProgressBar1, "Maximum", DT.Rows.Count)
            For i = 0 To DT.Rows.Count - 1

                If DT.Rows(i)("select") = True Then
                    Try
                        SetControlPropertyValue(lblObjectName, "Text", DT.Rows(i)("TableName").ToString())
                        'lblObjectName.Text = DT.Rows(i)("TableName").ToString()
                        DT.Rows(i)("status") += " " + oScript.ImportData(DT.Rows(i)("TableName"), RestorePath, chkDeleteExistingData.Checked)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
                SetControlPropertyValue(ProgressBar1, "Value", i)
            Next
        End If
    End Sub
    Sub GenerateFiles(ByRef DTScripts As DataTable, ByRef dg As DataGridView, ByVal bExportData As Boolean, ByVal pObjectType As String)
        Try
            If Not IsNothing(dg) Then
                Dim DT As DataTable = CType(dg.DataSource, DataTable)
                Dim i As Integer
                For i = 0 To DT.Rows.Count - 1
                    'scriptfile.WriteLine("------------------<" + CStr(DT.Rows(i)(pObjectType + "NAME")) + ">----------------------")
                    Dim sSQL As String = oScript.GenerateScript(txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text, pObjectType, CStr(DT.Rows(i)(pObjectType + "NAME")))
                    DTScripts.Rows.Add(New Object() {DT.Rows(i)(pObjectType + "NAME"), pObjectType, sSQL})
                    If bExportData Then
                        oScript.ExportData(txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text, DT.Rows(i)(pObjectType + "NAME"), DT.Rows(i)("Condition"), DT.Rows(i)("TotalRows"), RestorePath)
                    End If
                Next
                DTScripts.TableName = "SQLScripts"
                DTScripts.WriteXml(RestorePath + "SQLScripts.xml")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Function Get_Connection_String()
        Return "Provider=SQLOLEDB.1;data source=" + txtServerName.Text + ";user id=" + txtUsername.Text + ";Password=" + txtPassword.Text + ";database=" + txtDatabaseName.Text + ""
    End Function

    'Private Sub cmdConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'End Sub
    Sub Read_Extracted_Dir()
        Try
            'oScript.ConnectDatabaseWithRefresh(txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text)
            'If chkCreateDB.Checked Then
            '    oScript.DropDatabase(txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text)
            '    oScript.CreateNewDatabase(txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text)
            'End If

            SetProgress(3)
            Dim DS As New DataSet
            DS.ReadXml(RestorePath + "SQLScripts.xml")
            If DS.Tables.Count > 0 Then
                Dim DT As DataTable = DS.Tables(0)
                DT.DefaultView.RowFilter = "ObjectType='table'"
                Get_Objects(DT, dgTables, "TableName")
                SetProgress(4)
                DT.DefaultView.RowFilter = "ObjectType='view'"
                Get_Objects(DT, dgViews, "ViewName")
                SetProgress(5)
                DT.DefaultView.RowFilter = "ObjectType='sp'"
                Get_Objects(DT, dgSps, "SPName")
                SetProgress(7)
                DT.DefaultView.RowFilter = "ObjectType='udf'"
                Get_Objects(DT, dgUDFs, "UDFName")
                SetProgress(8)
                DT.DefaultView.RowFilter = "ObjectType='udd'"
                Get_Objects(DT, dgUDDs, "UDDName")
                SetProgress(7)
                DT.DefaultView.RowFilter = "ObjectType='user'"
                Get_Objects(DT, dgUsers, "UserName")
                SetProgress(8)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub
    Sub Get_Objects(ByRef DT As DataTable, ByRef dg As DataGridView, ByVal ObjectTypeName As String)
        Dim i As Integer
        Dim DTObjects As New DataTable
        DTObjects.Columns.Add(ObjectTypeName, "".GetType)
        DTObjects.Columns.Add("Select", True.GetType)
        DTObjects.Columns.Add("ScriptSQL", "".GetType)
        DTObjects.Columns.Add("Status", "".GetType)
        For i = 0 To DT.DefaultView.Count - 1
            DTObjects.Rows.Add(New Object() {DT.DefaultView(i)("ObjectName"), True, DT.DefaultView(i)("ScriptSQL")})
        Next
        dg.DataSource = DTObjects
        C_Common.Format_Grid_Backup(dg)
    End Sub
    'Sub FormatGrid(ByVal ObjectTypeName As String, ByRef dg As DataGridView)
    '    dg.Columns(ObjectTypeName.ToUpper).Width = 250
    '    dg.Columns("Select").Width = 50
    '    dg.Columns("ScriptSQL").Width = 300
    '    dg.Columns("Status").Width = 300
    'End Sub
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
        SetControlPropertyValue(ProgressBar1, "Value", iVal)
        'ProgressBar1.Value = iVal
        'Me.Refresh()
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
        'DT.Columns.Add("BackupDir", "".GetType)
        DT.Columns.Add("chkCreateDB", True.GetType)
        DT.Columns.Add("chkDropDB", True.GetType)
        DT.Rows.Add(New Object() {txtServerName.Text, txtDatabaseName.Text, txtUsername.Text, txtPassword.Text, chkData.Checked, chkStructure.Checked, True, True})
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
    Sub LoadSettingsFrom(ByVal sFileName As String)
        Dim DS As New DataSet
        Dim DT As DataTable
        If My.Computer.FileSystem.FileExists(sFileName) Then
            DS.ReadXml(sFileName)
            DT = DS.Tables("Preset")
            If (Not IsNothing(DT)) Then
                txtPreset.DisplayMember = "Server"
                txtPreset.ValueMember = "Server"
                txtPreset.DataSource = DT
            End If
            DT = DS.Tables(0)
            If DT.Rows.Count > 0 Then
                txtPreset.Text = DT.Rows(0)("Server")
                txtServerName.Text = DT.Rows(0)("Server")
                txtDatabaseName.Text = DT.Rows(0)("Database")
                txtUsername.Text = DT.Rows(0)("UserName")
                txtPassword.Text = DT.Rows(0)("Password")
                'txtBackupDir.Text = DT.Rows(0)("BackupDir")
                'chkCreateDB.Checked = DT.Rows(0)("chkCreateDB")
                'chkCreateDB.Checked = DT.Rows(0)("chkDropDB")
                chkStructure.Checked = DT.Rows(0)("chkStructure")
                chkData.Checked = DT.Rows(0)("chkData")
            Else
                txtServerName.Text = ""
                txtDatabaseName.Text = ""
                txtUsername.Text = ""
                txtPassword.Text = ""
                'txtBackupDir.Text = "C:\DBBackup\"
            End If
        Else
            txtServerName.Text = ""
            txtDatabaseName.Text = ""
            txtUsername.Text = ""
            txtPassword.Text = ""
            'txtBackupDir.Text = "C:\DBBackup\"
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
    End Sub
    Sub ReadTablesFromSettingsDataset(ByRef DS As DataSet, ByRef dg As DataGridView, ByVal objecttypename As String)
        If Not IsNothing(DS.Tables(objecttypename)) Then
            'DS.Tables(objecttypename).Columns("Select").DataType = True.GetType
            Dim dtTables As DataTable = DS.Tables(objecttypename)
            Dim DTNew As New DataTable
            Dim i As Integer
            For i = 0 To 2 'DTTables.Columns.Count - 1
                DTNew.Columns.Add(dtTables.Columns(i).ColumnName)
            Next
            DTNew.Columns.Add("Status", "".GetType)
            DTNew.Columns("Select").DataType = True.GetType

            For i = 0 To dtTables.Rows.Count - 1
                If objecttypename = "table" Then
                    DTNew.Rows.Add(New Object() {dtTables.Rows(i)(0), dtTables.Rows(i)(1), dtTables.Rows(i)(2), ""})
                Else
                    DTNew.Rows.Add(New Object() {dtTables.Rows(i)(0), dtTables.Rows(i)(1), ""})
                End If
            Next
            dg.DataSource = Nothing
            dg.DataSource = DTNew
            C_Common.Format_Grid_Backup(dg)
        End If
    End Sub
    Sub Format_All_Grids()
        C_Common.Format_Grid_Restore(dgTables)
        C_Common.Format_Grid_Restore(dgViews)
        C_Common.Format_Grid_Restore(dgSps)
        C_Common.Format_Grid_Restore(dgUDFs)
        C_Common.Format_Grid_Restore(dgUDDs)
        C_Common.Format_Grid_Restore(dgUsers)
    End Sub

    Private Sub chkStructure_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStructure.CheckedChanged
        If Not chkStructure.Checked Then
            'chkCreateDB.Checked = False
            'chkDropDB.Checked = False
            'chkCreateDB.Enabled = False
            'chkDropDB.Enabled = False
        Else
            'chkCreateDB.Checked = True
            'chkDropDB.Checked = True
            'chkCreateDB.Enabled = True
            'chkDropDB.Enabled = True
        End If
    End Sub

    Private Sub cmdOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpenFile.Click
        Dim sFile As String = C_Common.AskOpenFile()
        If sFile <> "" Then
            txtBackupFile.Text = sFile
            'clsZip.UnzipIT(txtBackupFile.Text, txtBackupDir.Text)
            C_Zip.UnzipIT(txtBackupFile.Text, RestorePath)
            Try
                ShowProgressBar()
                ProgressBar1.Maximum = 8
                SetProgress(1)
                Me.Refresh()
                Read_Extracted_Dir()
                Format_All_Grids()
                cmdRestore.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                HideProgressBar()
            End Try
        End If
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
    Private Sub gbExport_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub Center_Form()
        Dim maxwidth As Integer = Screen.PrimaryScreen.WorkingArea.Size.Width
        'Remove 10% top part of window
        Dim maxheight As Integer = Screen.PrimaryScreen.WorkingArea.Size.Height - Screen.PrimaryScreen.WorkingArea.Size.Height * 0.1
        Me.WindowState = FormWindowState.Maximized
        gbExport.Left = (maxwidth - gbExport.Width) / 2
        gbExport.Top = ((maxheight - gbExport.Height) / 2)
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
    Sub Disable_Form()
        '   SetControlPropertyValue(cmdExit, "Enabled", False)
        SetControlPropertyValue(gbLogin, "Enabled", False)
        SetControlPropertyValue(gbOptions, "Enabled", False)
        SetControlPropertyValue(cmdRestore, "Enabled", False)


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
    End Sub
    Sub Enable_Form()
        'SetControlPropertyValue(cmdExit, "Enabled", True)
        SetControlPropertyValue(gbLogin, "Enabled", True)
        SetControlPropertyValue(gbOptions, "Enabled", True)
        SetControlPropertyValue(cmdRestore, "Enabled", True)

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
    Sub Clear_Form()
        SetControlPropertyValue(lblObjectName, "Text", "")
        SetControlPropertyValue(lblStatus, "Text", "")
        SetControlPropertyValue(ProgressBar1, "Value", 0)
    End Sub

    Private Sub dgTables_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgTables.DataError

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

End Class

