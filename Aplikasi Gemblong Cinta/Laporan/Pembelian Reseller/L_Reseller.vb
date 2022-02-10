Public Class L_Reseller

    Private Sub L_Reseller_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ComboBoxEx1.Text = "Pilih"
    End Sub

    Private Sub L_Penjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBoxEx1.Enabled = 0
        cryRpt.Load("CR_Penjualan_Reseller.rpt")
        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub ComboBoxEx1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBoxEx1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
        If ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        F_CariReseller_2.ShowDialog()
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        If ComboBoxEx1.Text = "Pilih" Then
            MsgBox("Pilih Data Yang Akan DI Tampilkan")
        Else
            CrystalReportViewer1.SelectionFormula = "{reseller.kode_reseller}='" & ComboBoxEx1.Text & "'"
            CrystalReportViewer1.ReportSource = cryRpt
            CrystalReportViewer1.RefreshReport()
        End If

    End Sub


End Class