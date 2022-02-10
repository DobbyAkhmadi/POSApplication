Imports System.Data.SqlClient
Public Class F_Barang
    Public aas As String
    Private Sub F_Buku_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim x As Integer
        x = MsgBox("Keluar Form Barang ?", vbQuestion + vbYesNo, "Pesan")
        If x = vbYes Then
            DataGridViewX1.Rows.Clear()
            Me.Hide()
        Else
            e.Cancel = True
        End If
    End Sub

    Sub mati_Grup(ByVal x As Boolean)
        GroupPanel1.Enabled = x
    End Sub
    Sub mati_buton(ByVal a As Boolean)
        BtnBaru.Enabled = Not a
        BtnSimpan.Enabled = a
        BtnUbah.Enabled = a
        BtnHapus.Enabled = a
        BtnBatal.Enabled = a

    End Sub
    Sub simpan(ByVal q As Boolean)
        BtnBaru.Enabled = Not q
        BtnSimpan.Enabled = q
        BtnBatal.Enabled = q
    End Sub

    Sub cb_cari()
        CbCari.Items.Clear()
        CbCari.Items.Add("Kode Barang")
        CbCari.Items.Add("Rasa")
    End Sub
    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        Tampil_Data()
        GroupPanel2.Enabled = 1
        cb_cari()
    End Sub

    Private Sub BtnBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBaru.Click
        Auto()
        bersih2()
        GroupPanel1.Enabled = 1
        simpan(True)
        TxtRasa.Focus()
        DataGridViewX1.Enabled = 0
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Dim x As String
        x = MsgBox("Batal Input?", vbQuestion + vbYesNo, "Pesan")
        If x = vbYes Then
            mati_Grup(0)
            mati_buton(0)
            GroupPanel2.Enabled = 0
            bersih()
            DataGridViewX1.Enabled = 1

        End If
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        If CbCari.Text = "Pilih" Then
            MsgBox("Pilih Berdasarkan", vbInformation, "Pesan")
        Else
            tampil()
        End If
    End Sub


#Region "Validasi"

    Private Sub TxtNmaPeng_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRasa.KeyPress
        If ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar >= "!" And e.KeyChar <= "+")) Then
            e.Handled() = True
        End If
    End Sub
    Private Sub TxtNmaPeng_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRasa.TextChanged
        Dim i As Integer = TxtRasa.SelectionStart
        TxtRasa.Text = StrConv(TxtRasa.Text, VbStrConv.ProperCase)
        TxtRasa.SelectionStart = i
    End Sub

    Private Sub Txtstok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtstok.KeyPress
        If Not (((e.KeyChar >= Chr(48)) And (e.KeyChar <= Chr(57))) Or (e.KeyChar = Chr(8))) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Txtjudul_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtstok.TextChanged
        Dim i As Integer = Txtstok.SelectionStart
        Txtstok.Text = StrConv(Txtstok.Text, VbStrConv.ProperCase)
        Txtstok.SelectionStart = i
    End Sub

    Private Sub TxtHargaBeli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHargaBeli.KeyPress
        If Not (((e.KeyChar >= Chr(48)) And (e.KeyChar <= Chr(57))) Or (e.KeyChar = Chr(8))) Then
            e.KeyChar = ""
        End If
    End Sub


    Private Sub TxtKota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtHargaBeli.TextChanged
        Dim i As Integer = TxtHargaBeli.SelectionStart
        TxtHargaBeli.Text = StrConv(TxtHargaBeli.Text, VbStrConv.ProperCase)
        TxtHargaBeli.SelectionStart = i
    End Sub

    Private Sub TxtHargaJual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHargaJual.KeyPress
        If Not (((e.KeyChar >= Chr(48)) And (e.KeyChar <= Chr(57))) Or (e.KeyChar = Chr(8))) Then
            e.KeyChar = ""
        End If
    End Sub

    
    Private Sub TxtNama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtHargaJual.TextChanged
        Dim i As Integer = TxtHargaJual.SelectionStart
        TxtHargaJual.Text = StrConv(TxtHargaJual.Text, VbStrConv.ProperCase)
        TxtHargaJual.SelectionStart = i
    End Sub

    Private Sub TxtKunci_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtKunci.KeyDown
        If e.KeyCode = Keys.Return Then
            If CbCari.Text = "Pilih" Then
                MsgBox("Cari Berdasarkan Kategori")
                TxtKunci.Clear()
            Else
                tampil()
            End If
        End If
    End Sub
    Private Sub TxtKunci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtKunci.TextChanged
        Dim i As Integer = TxtKunci.SelectionStart
        TxtKunci.Text = StrConv(TxtKunci.Text, VbStrConv.ProperCase)
        TxtKunci.SelectionStart = i
    End Sub
    Private Sub CbCari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbCari.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
        If ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
    End Sub
#End Region
    Sub Auto()
        koneksi_database()
        Dim strku As String
        cmd = New SqlCommand("select count(*) from Barang", SQL_Kon)
        strku = cmd.ExecuteScalar + 1
        strku = "000".Substring(1, 3 - Len(strku)) + strku
        'substring sama kek middle
        TxtNo.Text = "BRG" + strku
        cmd.Dispose()
        SQL_Kon.Close()
    End Sub
    '#Region "DML"
    Private Sub Tampil_Data()
        koneksi_database()
        sqlstr = "Select * from barang"
        Try
            cmd = New SqlCommand(sqlstr, SQL_Kon)
            reader = cmd.ExecuteReader()
            DataGridViewX1.Rows.Clear()
            Do While reader.Read()
                x = DataGridViewX1.Rows.Add()
                DataGridViewX1.Rows(x).Cells(0).Value = reader(0)
                DataGridViewX1.Rows(x).Cells(1).Value = reader(1)
                DataGridViewX1.Rows(x).Cells(2).Value = reader(2)
                DataGridViewX1.Rows(x).Cells(3).Value = reader(3)
                DataGridViewX1.Rows(x).Cells(4).Value = reader(4)
            Loop
        Finally
            If reader IsNot Nothing Then reader.Close()
        End Try
        SQL_Kon.Close()
    End Sub
    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TxtRasa.Text = "" Then
            MsgBox("Isikan Data Rasa", vbExclamation, "Pesan")
        ElseIf Txtstok.Text = "" Then
            MsgBox("Isikan Data Stok", vbExclamation, "Pesan")
        ElseIf TxtHargaBeli.Text = "" Then
            MsgBox("Isikan Data Harga Beli", vbExclamation, "Pesan")
        ElseIf TxtHargaJual.Text = "" Then
            MsgBox("Isikan Data Harga Jual", vbExclamation, "Pesan")
        Else
            Dim a As String
            a = MsgBox("Simpan Data?", vbQuestion + vbYesNo, "Pesan")
            If a = vbYes Then
                Try
                    Call koneksi_database()
                    With cmd
                        .Connection = SQL_Kon
                        .CommandText = "insert into barang values (@1,@2,@3,@4,@5)"
                        .Parameters.AddWithValue("@1", TxtNo.Text)
                        .Parameters.AddWithValue("@2", TxtRasa.Text)
                        .Parameters.AddWithValue("@3", TxtHargaBeli.Text)
                        .Parameters.AddWithValue("@4", TxtHargaJual.Text)
                        .Parameters.AddWithValue("@5", Txtstok.Text)
                    End With
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Telah Di Simpan", vbInformation, "Pesan")
                    Tampil_Data()
                    DataGridViewX1.Enabled = True
                    mati_buton(0)
                    mati_Grup(0)
                    Call bersih()
                    cmd.Dispose()
                    cmd.Parameters.Clear()
                    SQL_Kon.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If

    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        Dim x As String
        x = MsgBox("Ubah Data?", vbQuestion + MsgBoxStyle.YesNo, "Pesan")
        If x = vbYes Then
            Try
                Call koneksi_database()
                sqlstr = "update barang set rasa=@1,harga_beli=@2,harga_jual=@3,stok=@4 where kode_barang=@5"
                cmd = New SqlCommand(sqlstr, SQL_Kon)
                cmd.Parameters.AddWithValue("@5", TxtNo.Text)
                cmd.Parameters.AddWithValue("@1", TxtRasa.Text)
                cmd.Parameters.AddWithValue("@4", Txtstok.Text)
                cmd.Parameters.AddWithValue("@2", TxtHargaBeli.Text)
                cmd.Parameters.AddWithValue("@3", TxtHargaJual.Text)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                Call Tampil_Data()
                mati_buton(0)
                mati_Grup(0)
                Call bersih()
                MsgBox("Data Berhasil Di Ubah", vbInformation, "Pesan")
                SQL_Kon.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        Dim x As String
        x = MsgBox("Hapus Data?", vbQuestion + MsgBoxStyle.YesNo, "Pesan")
        If x = vbYes Then
            Try
                koneksi_database()
                cmd = New SqlCommand("delete barang where kode_barang='" & DataGridViewX1.Item(0, DataGridViewX1.CurrentRow.Index).Value.ToString & "'", SQL_Kon)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("Data Telah Di Hapus", vbInformation, "Pesan")
                Call Tampil_Data()
                mati_buton(0)
                mati_Grup(0)
                Call bersih()
                SQL_Kon.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub




    Private Sub DataGridViewX1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick
        Try
            x = DataGridViewX1.CurrentCell.RowIndex
            TxtNo.Text = DataGridViewX1.Rows(x).Cells(0).Value.ToString
            TxtRasa.Text = DataGridViewX1.Rows(x).Cells(1).Value.ToString
            TxtHargaBeli.Text = DataGridViewX1.Rows(x).Cells(2).Value.ToString
            TxtHargaJual.Text = DataGridViewX1.Rows(x).Cells(3).Value.ToString
            Txtstok.Text = DataGridViewX1.Rows(x).Cells(4).Value.ToString
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DataGridViewX1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentDoubleClick
        BtnUbah.Enabled = 1
        BtnHapus.Enabled = 1
        BtnBatal.Enabled = 1
        BtnBaru.Enabled = 0
        GroupPanel1.Enabled = 1
    End Sub
    Sub bersih2()
        Txtstok.Clear()
        TxtHargaBeli.Clear()
        TxtKunci.Clear()
        TxtHargaJual.Clear()
        TxtRasa.Clear()
    End Sub
    Sub bersih()
        Txtstok.Clear()
        TxtHargaBeli.Clear()
        TxtKunci.Clear()
        TxtHargaJual.Clear()
        TxtRasa.Clear()
        TxtNo.Clear()
    End Sub




    Private Sub CbCari_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbCari.SelectedIndexChanged

        If CbCari.SelectedIndex = 0 Then
            aas = "kode_barang"
        ElseIf CbCari.SelectedIndex = 1 Then
            aas = "rasa"
        End If
    End Sub

    Sub tampil()
        SQL_Kon.Open()
        Dim x As String
        sqlstr = "select * from barang where " & aas & " like'%" & TxtKunci.Text & "%'"
        Try
            cmd = New SqlCommand(sqlstr, SQL_Kon)
            reader = cmd.ExecuteReader()
            DataGridViewX1.Rows.Clear()
            Do While reader.Read()
                x = DataGridViewX1.Rows.Add()
                DataGridViewX1.Rows(x).Cells(0).Value = reader(0)
                DataGridViewX1.Rows(x).Cells(1).Value = reader(1)
                DataGridViewX1.Rows(x).Cells(2).Value = reader(2)
                DataGridViewX1.Rows(x).Cells(3).Value = reader(3)
                DataGridViewX1.Rows(x).Cells(4).Value = reader(4)
            Loop
            cmd.Dispose()
        Finally
            If reader IsNot Nothing Then reader.Close()
        End Try
        SQL_Kon.Close()
    End Sub

  
    Private Sub F_Barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BtnRefresh.Focus()
        mati_Grup(0)
        mati_buton(0)
        GroupPanel2.Enabled = 0
    End Sub

 
End Class