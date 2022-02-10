Public Class F_Password
    Sub masuk()
        If TextBoxX1.Text = "123" Then
            '  F_Create_Database.Show()
            Me.Hide()
        Else
            MsgBox("Password Gagal", vbCritical, "Pesan")
            Me.Hide()
            TextBoxX1.Clear()
        End If
    End Sub
    Private Sub TextBoxX1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxX1.KeyDown
        If e.KeyCode = Keys.Return Then
            masuk()
            Me.Hide()
        End If
    End Sub

    Private Sub Btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnok.Click
        masuk()
        Me.Hide()
    End Sub

End Class