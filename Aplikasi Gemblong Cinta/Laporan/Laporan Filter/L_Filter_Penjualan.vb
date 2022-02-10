Public Class L_Filter_Penjualan

    Private Sub L_Filter_Peminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupPanel1.Enabled = False
        GroupPanel3.Enabled = False
        DateTimeInput1.Value = Now
        DateTimeInput2.Value = Now
        DateTimeInput3.Value = Now
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        GroupPanel1.Enabled = 1
        GroupPanel3.Enabled = 0
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GroupPanel1.Enabled = 0
        GroupPanel3.Enabled = 0
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        GroupPanel1.Enabled = 0
        GroupPanel3.Enabled = 1

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If RadioButton1.Checked Then
            cryRpt.Load("CR_Penjualan Harian.rpt")
            L_Harian.CrystalReportViewer1.ReportSource = cryRpt
            L_Harian.CrystalReportViewer1.SelectionFormula = "date({Head_jual.Tanggal})= #" & DateTimeInput1.Value & "#"
            L_Harian.CrystalReportViewer1.RefreshReport()
            L_Harian.ShowDialog()
        ElseIf RadioButton3.Checked Then
            If DateTimeInput2.Value > DateTimeInput3.Value Then
                MsgBox("Tanggal Tidak Boleh Kurang Dari Tanggal Sekarang", vbInformation, "Pesan")
            Else
                MsgBox("Dari Tanggal    " & DateTimeInput2.Value.ToString("dd/MMM/yyyy") & "   Sampai Dengan   " & DateTimeInput3.Value.ToString("dd/MMM/yyyy") & MsgBoxStyle.OkOnly)
                cryRpt.Load("CR_Penjualan Periode.rpt")
                L_Filter.CrystalReportViewer1.SelectionFormula = "date({Head_jual.Tanggal}) >= #" & DateTimeInput2.Value & "# and date({Head_jual.Tanggal})<=#" & DateTimeInput3.Value & "#"
                L_Filter.CrystalReportViewer1.ReportSource = cryRpt
                L_Filter.CrystalReportViewer1.RefreshReport()
                L_Filter.ShowDialog()
            End If
          
        End If
    End Sub
End Class