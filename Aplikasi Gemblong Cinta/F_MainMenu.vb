Public Class F_MainMenu

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        Dim a As String = MsgBox("Keluar Aplikasi?", vbQuestion + vbYesNo)
        If a = vbYes Then
            MsgBox("Terima Kasih", vbInformation, "Pesan")
            Me.Hide()
            F_Login.Show()
        End If
    End Sub

    Private Sub ButtonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem6.Click
        F_Konfigurasi.ShowDialog()
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        F_Barang.ShowDialog()
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        F_Reseller.ShowDialog()
    End Sub

    Private Sub ButtonItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem8.Click
        L_Filter_Penjualan.ShowDialog()
    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click
        F_Penjualan.ShowDialog()
    End Sub


    Private Sub ButtonItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        F_Petugas.ShowDialog()
    End Sub

    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem5.Click
        F_Petugas.ShowDialog()
    End Sub

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.Click
        L_Reseller.Show()
    End Sub

    Private Sub ButtonItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem9.Click
        L_Keuntungan.ShowDialog()
    End Sub

    Private Sub ButtonItem10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem10.Click
        F_Backup_Database.ShowDialog()
    End Sub

    Private Sub ButtonItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem11.Click
        F_DatabaseRestore.ShowDialog()
    End Sub

    Private Sub ButtonItem12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonItem12.Click
        L_Reseller.ShowDialog()
    End Sub
End Class