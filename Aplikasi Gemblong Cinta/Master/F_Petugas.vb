Imports System.Data.SqlClient
Public Class F_Petugas
    Public aas As String
    Private Sub F_Buku_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim x As Integer
        x = MsgBox("Keluar Form Petugas ?", vbQuestion + vbYesNo, "Pesan")
        If x = vbYes Then
            DataGridViewX1.Rows.Clear()
            Me.Hide()
        Else
            e.Cancel = True
        End If
    End Sub

    Sub mati_Grup(ByVal x As Boolean)
        GroupPanel1.Enabled = x
        GroupPanel2.Enabled = x
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

    
    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Tampil_Data()
     
    End Sub

    Private Sub BtnBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBaru.Click
        Auto()
        bersihey()
        GroupPanel1.Enabled = 1
        simpan(True)
        TxtNma.Focus()
        DataGridViewX1.Enabled = 0
        GroupPanel2.Enabled = 1
        ButtonX1.Enabled = 1
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Dim x As String
        x = MsgBox("Batal Input?", vbQuestion + vbYesNo, "Pesan")
        If x = vbYes Then
            mati_Grup(0)
            mati_buton(0)
            ' bersih()
            bersihey()
            DataGridViewX1.Enabled = 1
            TxtNo.Clear()

        End If
    End Sub




#Region "Validasi"

    Private Sub TxtNmaPeng_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNma.KeyPress
        If ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar >= "!" And e.KeyChar <= "+")) Then
            e.Handled() = True
        End If
    End Sub
    Private Sub TxtNmaPeng_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNma.TextChanged
        Dim i As Integer = TxtNma.SelectionStart
        TxtNma.Text = StrConv(TxtNma.Text, VbStrConv.ProperCase)
        TxtNma.SelectionStart = i
    End Sub

    Private Sub Txtjudul_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtalamat.TextChanged
        Dim i As Integer = Txtalamat.SelectionStart
        Txtalamat.Text = StrConv(Txtalamat.Text, VbStrConv.ProperCase)
        Txtalamat.SelectionStart = i
    End Sub

    Private Sub TxtKota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar >= "!" And e.KeyChar <= "+")) Then
            e.Handled() = True
        End If
    End Sub

    Private Sub TxtNama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar >= "!" And e.KeyChar <= "+")) Then
            e.Handled() = True
        End If
    End Sub


    Private Sub CbCari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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
        cmd = New SqlCommand("select count(*) from petugas", SQL_Kon)
        strku = cmd.ExecuteScalar + 1
        strku = "000".Substring(1, 3 - Len(strku)) + strku
        'substring sama kek middle
        TxtNo.Text = "PTG" + strku
        cmd.Dispose()
        SQL_Kon.Close()
    End Sub
    '#Region "DML"
    Private Sub Tampil_Data()
        koneksi_database()
        sqlstr = "Select * from petugas"
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
                DataGridViewX1.Rows(x).Cells(5).Value = reader(5)
            Loop
        Finally
            If reader IsNot Nothing Then reader.Close()
        End Try
        SQL_Kon.Close()
    End Sub
    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TxtNma.Text = "" Then
            MsgBox("Isikan Nama Petugas", vbExclamation, "Pesan")
        ElseIf Txtalamat.Text = "" Then
            MsgBox("Isikan Alamat Petugas", vbExclamation, "Pesan")
        ElseIf TxtTelp.Text = "" Then
            MsgBox("Isikan No Telp Petugas", vbExclamation, "Pesan")
        ElseIf ComboBoxEx1.Text = "Pilih" Then
            MsgBox("Pilih Jabatan", vbExclamation, "Pesan")
        ElseIf F_TambahUser.TxtNama.Text = "" And F_TambahUser.TextBoxX1.Text = "" Then
            MsgBox("Isikan Data Login", vbExclamation, "Pesan")
        Else
            Dim a As String
            a = MsgBox("Simpan Data?", vbQuestion + vbYesNo, "Pesan")
            If a = vbYes Then
                Try
                    Call koneksi_database()
                    With cmd
                        .Connection = SQL_Kon
                        .CommandText = "insert into petugas values (@1,@2,@3,@4,@5,@6,@7,@8)"
                        .Parameters.AddWithValue("@1", TxtNo.Text)
                        .Parameters.AddWithValue("@2", TxtNma.Text)
                        .Parameters.AddWithValue("@3", Txtalamat.Text)
                        .Parameters.AddWithValue("@4", TxtTelp.Text)
                        .Parameters.AddWithValue("@5", xxx)
                        .Parameters.AddWithValue("@6", ComboBoxEx1.Text)
                        .Parameters.AddWithValue("@7", F_TambahUser.TxtNama.Text)
                        .Parameters.AddWithValue("@8", F_TambahUser.TextBoxX1.Text)
                    End With
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Telah Di Simpan", vbInformation, "Pesan")
                    Tampil_Data()
                    DataGridViewX1.Enabled = True
                    mati_buton(0)
                    mati_Grup(0)
                    Call bersihey()
                    TxtNo.Clear()
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
                    sqlstr = "update petugas set [nama]=@1,[alamat]=@2,[no_telp]=@3,[jeniskelamin]=@4,[jabatan]=@5 where [id_petugas]=@8"
                    cmd = New SqlCommand(sqlstr, SQL_Kon)
                    cmd.Parameters.AddWithValue("@8", TxtNo.Text)
                    cmd.Parameters.AddWithValue("@1", TxtNma.Text)
                    cmd.Parameters.AddWithValue("@2", Txtalamat.Text)
                    cmd.Parameters.AddWithValue("@3", TxtTelp.Text)
                    cmd.Parameters.AddWithValue("@4", xxx)
                    cmd.Parameters.AddWithValue("@5", ComboBoxEx1.Text)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    Call Tampil_Data()
                    mati_buton(0)
                    mati_Grup(0)
                Call bersihey()
                TxtNo.Clear()
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
                cmd = New SqlCommand("delete petugas where id_petugas='" & DataGridViewX1.Item(0, DataGridViewX1.CurrentRow.Index).Value.ToString & "'", SQL_Kon)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("Data Telah Di Hapus", vbInformation, "Pesan")
                Call Tampil_Data()
                mati_buton(0)
                mati_Grup(0)
                TxtNo.Clear()
                Call bersihey()
                SQL_Kon.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Sub bersihey()
        '  TxtNo.Clear()
        TxtNma.Clear()
        Txtalamat.Clear()
        TxtTelp.Clear()
        RadioButton1.Checked = 0
        RadioButton2.Checked = 0
        ComboBoxEx1.Text = "Pilih"

    End Sub

    Private Sub DataGridViewX1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick

        Try
            x = DataGridViewX1.CurrentCell.RowIndex
            TxtNo.Text = DataGridViewX1.Rows(x).Cells(0).Value.ToString
            TxtNma.Text = DataGridViewX1.Rows(x).Cells(1).Value.ToString
            Txtalamat.Text = DataGridViewX1.Rows(x).Cells(2).Value.ToString
            TxtTelp.Text = DataGridViewX1.Rows(x).Cells(3).Value.ToString
            If DataGridViewX1.Rows(x).Cells(4).Value.ToString = "L" Then
                RadioButton1.Checked = 1
            ElseIf DataGridViewX1.Rows(x).Cells(4).Value.ToString = "P" Then
                RadioButton2.Checked = 1
            End If
            ComboBoxEx1.Text = DataGridViewX1.Rows(x).Cells(5).Value.ToString

        Catch ex As Exception

        End Try

    End Sub

    Private Sub DataGridViewX1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentDoubleClick
        BtnUbah.Enabled = 1
        BtnHapus.Enabled = 1
        BtnBatal.Enabled = 1
        BtnBaru.Enabled = 0
        GroupPanel1.Enabled = 1
        GroupPanel2.Enabled = 1
        ButtonX1.Enabled = 0

    End Sub
    Sub bersih2()
        Txtalamat.Clear()
        TxtNma.Clear()

    End Sub
    Sub bersih()
        Txtalamat.Clear()
        TxtNma.Clear()
        TxtNo.Clear()

    End Sub






    Private Sub TxtTahun_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (((e.KeyChar >= Chr(48)) And (e.KeyChar <= Chr(57))) Or (e.KeyChar = Chr(8))) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Txtper_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (((e.KeyChar >= Chr(48)) And (e.KeyChar <= Chr(57))) Or (e.KeyChar = Chr(8))) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtStok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (((e.KeyChar >= Chr(48)) And (e.KeyChar <= Chr(57))) Or (e.KeyChar = Chr(8))) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub F_Barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mati_Grup(0)
        mati_buton(0)
    End Sub
    Dim xxx As String
 


    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Tampil_Data()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        F_TambahUser.ShowDialog()
    End Sub

    Private Sub ComboBoxEx1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBoxEx1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
        If ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        xxx = "L"
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        xxx = "P"
    End Sub
End Class