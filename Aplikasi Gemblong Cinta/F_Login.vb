Imports System.Data.SqlClient
Public Class F_Login

    Private Sub F_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtUser.ShortcutsEnabled = 0
        TxtPass.ShortcutsEnabled = 0
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Sub tampil()
        F_MainMenu.LbID.Text = reader(0)
        F_MainMenu.LbAkses.Text = reader(5)
        F_MainMenu.LbNama.Text = reader(1)
    End Sub

    Private Sub Btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnok.Click
        If TxtUser.Text = "" Then
            MsgBox("Isikan Data Pengguna", vbExclamation, "Pesan")
        ElseIf TxtPass.Text = "" Then
            MsgBox("Isikan Sandi Pengguna", vbExclamation, "Pesan")
        Else
            koneksi_database()
            sqlstr = "select * from petugas where username='" & TxtUser.Text & "'and password='" & TxtPass.Text & "'"
            cmd = New SqlCommand(sqlstr, SQL_Kon)
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                If reader.Item(5) = "Admin  " Then
                    MsgBox("Selamat Datang Di Aplikasi Penjualan", vbInformation, "Pesan")
                    tampil()
                    Me.Hide()
                    F_MainMenu.Show()
                    Call mati(False)
                    F_MainMenu.RibbonTabItem2.Focus()
                    TxtPass.Clear()
                    TxtUser.Clear()
                ElseIf reader.Item(5) = "Manager" Then
                    MsgBox("Selamat Datang Di Aplikasi Penjualan", vbInformation, "Pesan")
                    tampil()
                    Me.Hide()
                    Call mati(1)
                    F_MainMenu.Show()
                    TxtPass.Clear()
                    TxtUser.Clear()
                End If
            Else
                MsgBox("Nama Pengguna Atau Kata Sandi Salah", vbCritical, "Pesan Error")
            End If

            End If

    End Sub

    Private Sub TxtUser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtUser.KeyDown
        If e.KeyCode = Keys.Return Then
            TxtPass.Focus()
        End If
    End Sub
    Sub mati(ByVal a As Boolean)
        F_MainMenu.ButtonItem7.Visible = a
        F_MainMenu.ButtonItem5.Visible = a
        F_MainMenu.ButtonItem2.Visible = a
        F_MainMenu.ButtonItem1.Visible = a
        F_MainMenu.ButtonItem8.Visible = a
        F_MainMenu.ButtonItem9.Visible = a
        F_MainMenu.RibbonTabItem1.Visible = a
        F_MainMenu.RibbonTabItem3.Visible = a
        F_MainMenu.RibbonTabItem4.Visible = a
        F_MainMenu.ButtonItem10.Visible = a
        F_MainMenu.ButtonItem11.Visible = a
    End Sub
    Private Sub TxtPass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPass.KeyDown
        If e.KeyCode = Keys.Return Then
            e.Handled = 1
            Btnok.Focus()
            Btnok_Click(sender, e)
        End If
    End Sub

    Private Sub BtnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim a As String
        a = MsgBox("Konfigurasi?", vbQuestion + vbYesNo, "Pesan")
        If a = vbYes Then
            If InputBox("Masukan Kode yang diberikan oleh Admin ", vbInformation) = "a" Then
                MsgBox("Sukses", vbInformation, "Pesan ")

            Else
                MsgBox("Kode Salah", vbExclamation, "Pesan")
            End If
        End If
    End Sub

    Private Sub TxtUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUser.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub TxtUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUser.TextChanged
        Dim i As Integer = TxtUser.SelectionStart
        TxtUser.Text = StrConv(TxtUser.Text, VbStrConv.ProperCase)
        TxtUser.SelectionStart = i
    End Sub

    Private Sub TxtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPass.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub


    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        F_Password.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class