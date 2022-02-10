Public Class L_Faktur

    Private Sub L_Faktur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cryRpt.Load("CR_Faktur.rpt")
        CrystalReportViewer1.SelectionFormula = "{Head_Jual.no_transaksi}='" & F_Penjualan.LbNomer.Text & "'"
        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class