Imports System.Data.SqlClient
Public Class F_CariBarang

    Private Sub F_CariBuku_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CbCari.Items.Clear()
        CbCari.Text = "Pilih"
    End Sub

    Private Sub F_CariBuku_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cari_cb()
    End Sub

    Sub cari_cb()
        CbCari.Items.Add("Kode Barang")
        CbCari.Items.Add("Rasa")
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Call koneksi_database()
        sqlstr = "Select * from barang"
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
        reader.Close()
        SQL_Kon.Close()
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
    Private Sub CbCari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbCari.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
        If ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
    End Sub

    Private Sub DataGridViewX1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentDoubleClick
        Dim a As String
        a = DataGridViewX1.Item(0, DataGridViewX1.CurrentRow.Index).Value.ToString
        F_Penjualan.CBBarang.Text = a
        Me.Close()
    End Sub
    Dim aas As String
    Private Sub CbCari_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbCari.SelectedIndexChanged
        If CbCari.SelectedIndex = 0 Then
            aas = "kode_barang"
        ElseIf CbCari.SelectedIndex = 1 Then
            aas = "rasa"
        End If
    End Sub

    Private Sub TxtKunci_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtKunci.KeyDown
        If e.KeyCode = Keys.Return Then
            If CbCari.Text = "Pilih" Then
                MsgBox("Pilih Berdasarkan", vbInformation, "Pesan")
            Else
                tampil()
            End If
        End If
    End Sub
End Class