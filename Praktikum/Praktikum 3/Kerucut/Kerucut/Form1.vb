Public Class Form1
    Private Sub hitung_Click(sender As Object, e As EventArgs) Handles hitung.Click
        Dim jari, garis, tinggi, volume, luas As Integer
        jari = Val(txtjari.Text)
        garis = Val(txtgaris.Text)
        tinggi = Val(txttinggi.Text)

        volume = (3.14 * (jari ^ 2) * tinggi) / 3
        luas = 3.14 * jari * (jari + garis)

        txtluas.Text = Str(luas)
        txtvolume.Text = Str(volume)
    End Sub
End Class
