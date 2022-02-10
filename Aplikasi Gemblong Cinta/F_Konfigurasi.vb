Imports System.Data.SqlClient
Public Class F_Konfigurasi

    Private Sub Btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnok.Click
        If TxtUser.Text = "" Then
            MsgBox("Isikan Data Pengguna", vbExclamation, "Pesan")
        ElseIf TxtPass.Text = "" Then
            MsgBox("Isikan Sandi Pengguna", vbExclamation, "Pesan")
        Else
            Call koneksi_database()
            sqlstr = "select * from petugas where username='" & TxtUser.Text & "'and password='" & TxtPass.Text & "'"
            cmd = New SqlCommand(sqlstr, SQL_Kon)
            reader = cmd.ExecuteReader
            If reader.Read Then
                MsgBox("Konfirmasi Sandi Sukses, Sekarang Dapat Mengubah Sandi Pengguna", vbInformation, "Pesan")
                TxtUser.Enabled = 0
                TxtPass.Enabled = 0
                Btnok.Enabled = 0
                ButtonX1.Enabled = 1
                TextBoxX1.Enabled = 1
                TextBoxX2.Text = reader.Item(1)
                TxtPass.Clear()
                '  TxtUser.Clear()
            Else
                MsgBox("Username Atau Password Salah", vbExclamation, "Pesan")
            End If
            reader.Close()
        End If
    End Sub

    Private Sub F_Konfigurasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBoxX2.Enabled = 0
        TextBoxX1.Enabled = 0
        ButtonX1.Enabled = 0
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim a As String
        a = MsgBox("Ubah Kata Sandi?", vbQuestion + vbYesNo, "Pesan")
        If a = vbYes Then
            With cmd
                .Connection = SQL_Kon
                .CommandText = "update petugas set password='" & TextBoxX1.Text & "' where username='" & TxtUser.Text & "' and id_petugas='" & F_MainMenu.LbID.Text & "'"
                .ExecuteNonQuery()
                MsgBox("Kata Sandi Telah Di Ubah", vbInformation, "Pesan")
                Me.Hide()
            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            cmd.Parameters.Clear()
        End If
       

    End Sub
End Class