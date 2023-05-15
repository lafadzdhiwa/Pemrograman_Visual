Public Class Form1
    Private Sub hitung_Click(sender As Object, e As EventArgs) Handles hitung.Click
        Dim jari, tinggi, volume, luas As Integer
        jari = Val(txtjari.Text)
        tinggi = Val(txttinggi.Text)

        volume = 3.14 * (jari ^ 2) * tinggi
        luas = 2 * 3.14 * jari * (jari + tinggi)

        txtluas.Text = Str(luas)
        txtvolume.Text = Str(volume)
    End Sub
End Class
