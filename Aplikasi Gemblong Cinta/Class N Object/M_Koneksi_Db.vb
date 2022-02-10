Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Module M_Koneksi_Db
    Public cmd As SqlCommand = Nothing
    Public reader As SqlDataReader = Nothing
    Public SQL_Kon As SqlConnection = Nothing
    Public sqlstr As String = Nothing
    Public x As Integer = Nothing
    Public cryRpt As New ReportDocument
    Public Sub koneksi_database()
        SQL_Kon = New SqlConnection("Data Source=./;Initial Catalog=Db_Penjualan_Gemblong;Persist Security Info=True;User ID=sa")
        SQL_Kon.Open()
    End Sub
End Module


