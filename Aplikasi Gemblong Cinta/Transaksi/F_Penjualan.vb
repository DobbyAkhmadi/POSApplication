Imports System.Data.SqlClient
Public Class F_Penjualan
    
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        F_CariBarang.ShowDialog()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        F_CariReseller.ShowDialog()
    End Sub
   

    Sub button(ByVal x As Boolean)
        BtnBaru.Enabled = Not x
        BtnSimpan.Enabled = x
        BtnTambah.Enabled = x
        BtnBatal.Enabled = x
    End Sub
    Sub baru(ByVal a As Boolean)
        BtnBaru.Enabled = Not a
        BtnSimpan.Enabled = a
        BtnBatal.Enabled = a
    End Sub
    Sub otomatis_()
        koneksi_database()
        Dim no As String
        sqlstr = "select no_transaksi from head_jual where left (no_transaksi,4)='" & Now.ToString("yyMM") & "'order by no_transaksi desc"
        cmd = New SqlCommand(sqlstr, SQL_Kon)
        reader = cmd.ExecuteReader
        If reader.HasRows = False Then
            no = 1
        Else
            reader.Read()
            no = Val(reader.Item(0).ToString.Substring(4, 3)) + 1
        End If
        no = "000".Substring(0, 3 - Len(no)) + no
        LbNomer.Text = Now.ToString("yyMM") + no
        reader.Close()
        cmd.Dispose()
    End Sub


    Private Sub BtnBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBaru.Click
        otomatis_()
        baru(1)
        LblTanggal.Text = Now.ToString("dd/MMM/yyyy")
        ButtonX1.Enabled = 1
        ButtonX2.Enabled = 1
        ButtonX2.Focus()
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Dim xss As String = MsgBox("Batal Input ?", vbQuestion + vbYesNo, "Pesan")
        If xss = vbYes Then
            button(0)
            mati(0)
            pembayaran(0)
            Txttot.Clear()
            TxtBayar.Clear()
            TxtKemb.Clear()
            DataGridViewX1.Rows.Clear()
            LbNomer.Text = "-"
            LblTanggal.Text = "-"
        End If
    End Sub

    Private Sub ComboBoxEx1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxEx1.TextChanged
        koneksi_database()
        sqlstr = "select * from Reseller where kode_reseller='" & ComboBoxEx1.Text & "'"
        cmd = New SqlCommand(sqlstr, SQL_Kon)
        reader = cmd.ExecuteReader
        If reader.Read Then
            LbNama.Text = reader.Item(1)
            Lbalamat.Text = reader(2)
            Lbtelp.Text = reader(3)
            Lbrek.Text = reader(4)
        End If
        cmd.Dispose()
        reader.Close()
    End Sub

  
    Private Sub CBBarang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBBarang.TextChanged
        koneksi_database()
        sqlstr = "select * from barang where kode_barang='" & CBBarang.Text & "'"
        cmd = New SqlCommand(sqlstr, SQL_Kon)
        reader = cmd.ExecuteReader
        If reader.Read Then
            Lbrasa.Text = reader.Item(1)
            Lbharag.Text = reader.Item(3)
        End If
        cmd.Dispose()
        reader.Close()
        '  SQL_Kon.Close()
    End Sub
    Sub mati(ByVal x As Boolean)
        BtnSimpan.Enabled = x
        BtnBaru.Enabled = Not x
        BtnBatal.Enabled = x
        ButtonX1.Enabled = x
        ButtonX2.Enabled = x
        Txtjum.Enabled = x
        BtnTambah.Enabled = x
    End Sub
    Sub pembayaran(ByVal a As Boolean)
        TxtBayar.Enabled = a
        TxtKemb.Enabled = a
        Txttot.Enabled = a
    End Sub

    Sub total()
        Dim tot As Double=0
        For x As Integer = 0 To DataGridViewX1.RowCount - 1
            tot = tot + DataGridViewX1.Rows(x).Cells(4).Value
        Next
        Txttot.Text = tot
    End Sub
    Private Sub F_Penjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mati(0)
        pembayaran(0)
    End Sub
    Sub bersih1()
        CBBarang.Text = "Cari Barang"
        Lbrasa.Text = "-"
        Lbharag.Text = "-"
        Txtjum.Clear()
        LabelX16.Text = "-"
    End Sub
    Sub bersih()
        CBBarang.Text = "Cari Barang"
        Lbrasa.Text = "-"
        Lbharag.Text = "-"
        Txtjum.Clear()
        LabelX16.Text = "-"
        ComboBoxEx1.Text = "Cari Reseller"
        LbNama.Text = "-"
        Lbalamat.Text = "-"
        LbNomer.Text = "-"
        Lbrek.Text = "-"
    End Sub
    Private Sub Lbharag_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lbharag.TextChanged
        Txtjum.Enabled = 1
    End Sub

    Private Sub Txtjum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtjum.KeyPress
        BtnTambah.Enabled = 1
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        If CBBarang.Text = "Cari Barang" Then
            MsgBox("Pilih Barang Yang Di Cari", vbExclamation, "Pesan")
        ElseIf Txtjum.Text = "" Then
            MsgBox("Isikan Jumlah Barang", vbExclamation, "Pesan")
        Else
            ' koneksi_database()
            sqlstr = "select stok from barang where kode_barang='" & CBBarang.Text & "'"
            cmd = New SqlCommand(sqlstr, SQL_Kon)
            reader = cmd.ExecuteReader
            If reader.Read Then
                If Val(Txtjum.Text) > reader(0) Then
                    MsgBox("Jumlah Tidak Boleh Kurang Dari Stok", vbExclamation, "Pesan")
                ElseIf reader(0) = 0 Then
                    MsgBox("Stok Habis", vbExclamation, "Pesan")
                Else

                    DataGridViewX1.Rows.Add(CBBarang.Text, Lbrasa.Text, Lbharag.Text, Txtjum.Text, LabelX16.Text)
                    total()
                    bersih1()
                End If
            End If
            reader.Close()
        End If
        TxtBayar.Enabled = 1
        TxtKemb.Enabled = 1
    End Sub
   

    Private Sub DataGridViewX1_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridViewX1.UserDeletedRow
        total()
    End Sub

    Private Sub DataGridViewX1_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridViewX1.UserDeletingRow
        If MsgBox("Data Akan Di Hapus?", vbQuestion + vbYesNo, "Pesan") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Txtjum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtjum.TextChanged
        LabelX16.Text = Val(Txtjum.Text) * Val(Lbharag.Text)
    End Sub

    Private Sub TxtBayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBayar.TextChanged
        TxtKemb.Text = Val(TxtBayar.Text) - Val(Txttot.Text)
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Dim z As String
        z = MsgBox("Simpan Data Peminjaman?", vbQuestion + vbYesNo, "Pesan")
        If z = vbYes Then
            If ComboBoxEx1.Text = "Cari Reseller" Then
                MsgBox("Pilih Reseller Terlebih Dahulu", vbExclamation, "Pesan")
            Else
                koneksi_database()
                With cmd
                    .Connection = SQL_Kon
                    .CommandText = "insert into Head_Jual values (@1,@2,@3,@4,@5)"
                    .Parameters.AddWithValue("@1", LbNomer.Text)
                    .Parameters.AddWithValue("@2", ComboBoxEx1.Text)
                    .Parameters.AddWithValue("@3", F_MainMenu.LbID.Text)
                    .Parameters.AddWithValue("@4", LblTanggal.Text)
                    .Parameters.AddWithValue("@5", Txttot.Text)
                End With
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                cmd.Parameters.Clear()

                For i As Integer = 0 To DataGridViewX1.RowCount - 1
                    With cmd
                        .Connection = SQL_Kon
                        .CommandText = "insert into Detail_Jual values(@1,@2,@3,@4)"
                        .Parameters.AddWithValue("@1", LbNomer.Text)
                        .Parameters.AddWithValue("@2", DataGridViewX1.Rows(i).Cells(0).Value)
                        .Parameters.AddWithValue("@3", DataGridViewX1.Rows(i).Cells(2).Value)
                        .Parameters.AddWithValue("@4", DataGridViewX1.Rows(i).Cells(3).Value)
                    End With
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    cmd.Parameters.Clear()

                    With cmd
                        .Connection = SQL_Kon
                        .CommandText = "update barang set stok=stok-@6 where kode_barang=@7"
                        .Parameters.AddWithValue("@7", DataGridViewX1.Rows(i).Cells(0).Value)
                        .Parameters.AddWithValue("@6 ", DataGridViewX1.Rows(i).Cells(3).Value)
                    End With
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    cmd.Parameters.Clear()
                Next
                SQL_Kon.Close()
                MsgBox("Data Sudah Dimasukan", vbInformation, "Terima Kasih")
                button(0)
                mati(0)
                pembayaran(0)
                Txttot.Clear()
                TxtBayar.Clear()
                TxtKemb.Clear()
                DataGridViewX1.Rows.Clear()
                L_Faktur.ShowDialog()
                LbNomer.Text = "-"
                LblTanggal.Text = "-"
                bersih()
            End If
        End If
    End Sub
End Class