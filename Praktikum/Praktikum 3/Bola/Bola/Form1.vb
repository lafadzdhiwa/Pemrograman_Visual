Public Class Form1
    Private Sub hitung_Click(sender As Object, e As EventArgs) Handles hitung.Click
        Dim r, volume, luas As Integer
        r = Val(txtjari.Text)

        volume = (4 * 3.14 * (r ^ 3)) / 3
        luas = 4 * 3.14 * (r ^ 2)

        txtluas.Text = Str(luas)
        txtvolume.Text = Str(volume)
    End Sub
End Class
