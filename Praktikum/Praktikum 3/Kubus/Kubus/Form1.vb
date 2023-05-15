Public Class Form1
    Private Sub hitung_Click(sender As Object, e As EventArgs) Handles hitung.Click
        Dim sisi, luas, volume As Integer
        sisi = Val(txtsisi.Text)

        volume = sisi ^ 3
        luas = 6 * (sisi ^ 2)

        txtluas.Text = Str(luas)
        txtvolume.Text = Str(volume)
    End Sub
End Class
