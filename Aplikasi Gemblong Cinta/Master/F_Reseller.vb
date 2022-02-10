Imports System.Data.SqlClient
Imports System.IO
Public Class F_Reseller

    Private Sub F_Member_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim x As Integer
        x = MsgBox("Keluar Form Reseller?", vbQuestion + vbYesNo, "Pesan")
        If x = vbYes Then
            mati(0)
            bersih()
            GroupPanel1.Enabled = 0
            tombol(0)
            DataGridViewX1.Enabled = True
            PictureBox1.Image = My.Resources.no_photo_female
            Me.Hide()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Tampil_Data()
        Call koneksi_database()
        sqlstr = "Select * from Reseller"
        Try
            cmd = New SqlCommand(sqlstr, SQL_Kon)
            reader = cmd.ExecuteReader()
            DataGridViewX1.Rows.Clear()
            Do While reader.Read() = True
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
    Sub Auto()
        Call koneksi_database()
        Dim strku As String
        cmd = New SqlCommand("select count(*) from reseller", SQL_Kon)
        strku = cmd.ExecuteScalar + 1
        strku = "0000".Substring(1, 4 - Len(strku)) + strku
        'substring sama kek middle
        TxtNo.Text = "RES" + strku
        cmd.Dispose()
        '  SQL_Kon.Close()
    End Sub
    Sub bersih()
        TxtNo.Clear()
        TxtNama.Clear()
        TxtRek.Clear()
        Txtalamat.Clear()
        TxtTelp.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub
    Sub bersih2()

        TxtNama.Clear()
        TxtRek.Clear()
        Txtalamat.Clear()

    End Sub
    Private Sub F_Member_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tampil_Data()
        mati(0)
        GroupPanel1.Enabled = 0
        tombol(0)
    End Sub
    Sub mati(ByVal ax As Boolean)
        BtnBaru.Enabled = Not ax
        BtnSimpan.Enabled = ax
        BtnUbah.Enabled = ax
        BtnHapus.Enabled = ax
        BtnBatal.Enabled = ax
        PictureBox1.Enabled = ax
    End Sub
    Sub tombol(ByVal b As Boolean)
        BtnBaru.Enabled = Not b
        BtnSimpan.Enabled = b
        BtnBatal.Enabled = b
    End Sub
    Private Sub BtnBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBaru.Click
        Auto()
        'otomatis_()
        DataGridViewX1.Enabled = 0
        PictureBox1.Image = My.Resources.no_photo_female
        GroupPanel1.Enabled = 1
        PictureBox1.Enabled = 1
        bersih2()
        tombol(1)

    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Dim x As String
        x = MsgBox("Batal Input?", vbQuestion + vbYesNo, "Pesan")
        If x = vbYes Then
            mati(0)
            bersih()
            GroupPanel1.Enabled = 0
            tombol(0)
            DataGridViewX1.Enabled = True
            PictureBox1.Image = My.Resources.no_photo_female
            
        End If
    End Sub

    Dim a As String = Nothing
    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click

        If TxtNama.Text = "" Then
            MsgBox("Inputkan Nama Reseller", vbExclamation, "Pesan")
        ElseIf Txtalamat.Text = "" Then
            MsgBox("Inputkan Alamat Reseller", vbExclamation, "Pesan")
        ElseIf TxtRek.Text = "" Then
            MsgBox("Inputkan Nomor Rekening Reseller", vbExclamation, "Pesan")
        ElseIf TxtTelp.Text = "" Then
            MsgBox("Inputkan Nomor Telepon Reseller", vbExclamation, "Pesan")
        Else
            ' Try
            Call koneksi_database()
            Dim ms As New MemoryStream()
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            With cmd
                .Connection = SQL_Kon
                .CommandText = "insert into reseller values (@1,@2,@3,@4,@5,@6,@7)"
                .Parameters.AddWithValue("@1", TxtNo.Text)
                .Parameters.AddWithValue("@2", TxtNama.Text)
                .Parameters.AddWithValue("@3", Txtalamat.Text)
                .Parameters.AddWithValue("@4", TxtTelp.Text)
                .Parameters.AddWithValue("@5", TxtRek.Text)
                .Parameters.AddWithValue("@6", a)
                Dim data As Byte() = ms.GetBuffer()
                Dim p As New SqlParameter("@7", SqlDbType.Image)
                p.Value = data
                cmd.Parameters.Add(p)
            End With
            cmd.ExecuteNonQuery()
            MsgBox("Data Telah Di Simpan", vbInformation, "Pesan")
            Tampil_Data()
            DataGridViewX1.Enabled = True
            cmd.Dispose()
            cmd.Parameters.Clear()
            mati(0)
            GroupPanel1.Enabled = False
            bersih()
            'PictureBox1.Dispose()
            PictureBox1.Image = My.Resources.no_photo_female
            SQL_Kon.Close()

        End If

        ' Catch ex As Exception
        'MsgBox(ex.Message)
        ' End Try



        reader.Close()

    End Sub

    Private Sub DataGridViewX1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick
        x = DataGridViewX1.CurrentCell.RowIndex
        TxtNo.Text = DataGridViewX1.Rows(x).Cells(0).Value.ToString
        TxtNama.Text = DataGridViewX1.Rows(x).Cells(1).Value.ToString
        Txtalamat.Text = DataGridViewX1.Rows(x).Cells(2).Value.ToString
        TxtTelp.Text = DataGridViewX1.Rows(x).Cells(3).Value.ToString
        TxtRek.Text = DataGridViewX1.Rows(x).Cells(4).Value.ToString
        If DataGridViewX1.Rows(x).Cells(5).Value.ToString = "L" Then
            RadioButton1.Checked = True
        ElseIf DataGridViewX1.Rows(x).Cells(5).Value.ToString = "P" Then
            RadioButton2.Checked = True
        End If
        Call koneksi_database()
        Dim xcz As String = ("select poto from reseller where kode_reseller='" & DataGridViewX1.Item(0, DataGridViewX1.CurrentRow.Index).Value & "'")
        cmd = New SqlCommand(xcz, SQL_Kon)
        Dim ImgStream As New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte()))
        PictureBox1.Image = Image.FromStream(ImgStream)
        ImgStream.Dispose()

        SQL_Kon.Close()
    End Sub

    

    Private Sub TxtAlama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtalamat.TextChanged
        Dim i As Integer = Txtalamat.SelectionStart
        Txtalamat.Text = StrConv(Txtalamat.Text, VbStrConv.ProperCase)
        Txtalamat.SelectionStart = i
    End Sub


    

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try
            OpenFileDialog1.Filter = "Image Files|*.jpg;*.png;*.bmp"
            OpenFileDialog1.ShowDialog()
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DataGridViewX1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentDoubleClick
        BtnUbah.Enabled = 1
        BtnHapus.Enabled = 1
        BtnBatal.Enabled = 1
        BtnBaru.Enabled = 0
        GroupPanel1.Enabled = 1
        PictureBox1.Enabled = True
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        Dim x As String
        x = MsgBox("Ubah Data?", vbQuestion + vbYesNo, "Pesan")
        If x = vbYes Then
            ' Try

            koneksi_database()
            Dim ms As New MemoryStream()
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            sqlstr = "update reseller set [nama_reseller]=@1,[alamat]=@2,[no_telp]=@3,[rekening]=@4,[jenis_kelamin]=@5,[poto]=@6 where [kode_reseller]=@7"
            cmd = New SqlCommand(sqlstr, SQL_Kon)
            cmd.Parameters.AddWithValue("@1", TxtNama.Text)
            cmd.Parameters.AddWithValue("@2", Txtalamat.Text)
            cmd.Parameters.AddWithValue("@3", TxtTelp.Text)
            cmd.Parameters.AddWithValue("@4", TxtRek.Text)
            cmd.Parameters.AddWithValue("@5", a)
            cmd.Parameters.AddWithValue("@7", TxtNo.Text)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@6", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            Call Tampil_Data()
            Call bersih()
            mati(0)
            GroupPanel1.Enabled = False
            MsgBox("Data Telah Di Ubah", vbInformation, "Pesan")
            SQL_Kon.Close()
            '  Catch ex As Exception
            '     MsgBox("Pilih Poto Kembali", vbExclamation, "Pesan")
            'End Try

        End If


    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        Dim x As String
        x = MsgBox("Hapus Data?", vbQuestion + vbYesNo, "Pesan")
        If x = vbYes Then
            Try
                koneksi_database()
                cmd = New SqlCommand("delete reseller where kode_reseller='" & DataGridViewX1.Item(0, DataGridViewX1.CurrentRow.Index).Value.ToString & "'", SQL_Kon)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("Data Telah Di Hapus", vbInformation, "Pesan")
                Call Tampil_Data()
                mati(0)
                GroupPanel1.Enabled = 0
                tombol(0)
                PictureBox1.Image = My.Resources.no_photo_female
                Call bersih()
                SQL_Kon.Close()
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub TxtNama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNama.KeyPress
        If ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar >= "!" And e.KeyChar <= "+")) Then
            e.Handled() = True
        End If
    End Sub


    Private Sub TxtNama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNama.TextChanged
        Dim i As Integer = TxtNama.SelectionStart
        TxtNama.Text = StrConv(TxtNama.Text, VbStrConv.ProperCase)
        TxtNama.SelectionStart = i
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        a = "L"
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        a = "P"
    End Sub

    Private Sub TxtRek_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (((e.KeyChar >= Chr(48)) And (e.KeyChar <= Chr(57))) Or (e.KeyChar = Chr(8))) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtTelp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelp.KeyPress
        If Not (((e.KeyChar >= Chr(48)) And (e.KeyChar <= Chr(57))) Or (e.KeyChar = Chr(8))) Then
            e.KeyChar = ""
        End If
    End Sub
End Class