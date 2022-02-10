Imports System.Data.SqlClient
Public Class F_CariReseller
    Dim aas As String
    Private Sub F_CariAnggota_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CbCari.Items.Clear()
        CbCari.Text = "Pilih"
        TxtKunci.Clear()
        DataGridViewX1.Rows.Clear()
        PictureBox1.Image = My.Resources.no_photo_female
    End Sub

    Sub tampil2()
        koneksi_database()
        Dim x As String
        sqlstr = "select * from reseller where " & aas & " like'%" & TxtKunci.Text & "%'"
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
                koneksi_database()
                Dim xcz As String = ("select poto from reseller where kode_reseller='" & DataGridViewX1.Item(0, DataGridViewX1.CurrentRow.Index).Value & "'")
                cmd = New SqlCommand(xcz, SQL_Kon)
                Dim ImgStream As New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte()))
                PictureBox1.Image = Image.FromStream(ImgStream)
                ImgStream.Dispose()
            Loop
            cmd.Dispose()
        Finally
            If reader IsNot Nothing Then reader.Close()
        End Try
    End Sub

    Sub tampil()
        Call koneksi_database()
        sqlstr = "Select * from reseller"
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
            Loop
        Finally
            If reader IsNot Nothing Then reader.Close()
        End Try
        SQL_Kon.Close()
    End Sub

    Private Sub CbCari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbCari.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
        If ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
    End Sub

    Private Sub DataGridViewX1_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick
        Call koneksi_database()
        Dim xcz As String = ("select poto from reseller where kode_reseller='" & DataGridViewX1.Item(0, DataGridViewX1.CurrentRow.Index).Value & "'")
        cmd = New SqlCommand(xcz, SQL_Kon)
        Dim ImgStream As New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte()))
        PictureBox1.Image = Image.FromStream(ImgStream)
        ImgStream.Dispose()
        SQL_Kon.Close()
    End Sub

    Private Sub DataGridViewX1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentDoubleClick
        Dim a As String
        a = DataGridViewX1.Item(0, DataGridViewX1.CurrentRow.Index).Value.ToString
        F_Penjualan.ComboBoxEx1.Text = a
        Me.Hide()
    End Sub

    Private Sub CbCari_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbCari.SelectedIndexChanged
        If CbCari.SelectedIndex = 0 Then
            aas = "kode_reseller"
        ElseIf CbCari.SelectedIndex = 1 Then
            aas = "nama_reseller"
        End If
    End Sub


    Private Sub TxtKunci_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtKunci.KeyDown

        If e.KeyCode = Keys.Return Then
            If CbCari.Text = "Pilih" Then
                MsgBox("Pilih Kategori", vbExclamation, "Pesan")
            Else
                tampil2()
            End If
        End If
    End Sub


    Private Sub TxtKunci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtKunci.TextChanged
        Dim i As Integer = TxtKunci.SelectionStart
        TxtKunci.Text = StrConv(TxtKunci.Text, VbStrConv.ProperCase)
        TxtKunci.SelectionStart = i
    End Sub
    Sub xx()
        Call koneksi_database()
        Dim xcz As String = ("select poto from reseller where kode_res='" & DataGridViewX1.Item(0, DataGridViewX1.CurrentRow.Index).Value & "'")
        cmd = New SqlCommand(xcz, SQL_Kon)
        Dim ImgStream As New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte()))
        PictureBox1.Image = Image.FromStream(ImgStream)
        ImgStream.Dispose()
        SQL_Kon.Close()
        TxtKunci.Clear()
        CbCari.Text = "Pilih"
    End Sub


    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        tampil()
    End Sub
End Class