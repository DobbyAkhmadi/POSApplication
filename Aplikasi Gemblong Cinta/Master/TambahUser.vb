Imports System.Data.SqlClient
Public Class F_TambahUser

    Private Sub TxtNama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNama.TextChanged
        Dim i As Integer = TxtNama.SelectionStart
        TxtNama.Text = StrConv(TxtNama.Text, VbStrConv.ProperCase)
        TxtNama.SelectionStart = i
    End Sub

    Private Sub TextBoxX1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxX1.TextChanged
        Dim i As Integer = TextBoxX1.SelectionStart
        TextBoxX1.Text = StrConv(TextBoxX1.Text, VbStrConv.ProperCase)
        TextBoxX1.SelectionStart = i
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Me.Hide()
    End Sub
End Class