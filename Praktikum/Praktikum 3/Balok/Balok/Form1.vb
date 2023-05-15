Public Class Form1
    Private Sub hitung_Click(sender As Object, e As EventArgs) Handles hitung.Click
        Dim panjang, lebar, tinggi, volume, luas As Integer
        panjang = Val(txtpanjang.Text)
        lebar = Val(txtlebar.Text)
        tinggi = Val(txttinggi.Text)

        volume = panjang * lebar * tinggi
        luas = 2 * ((panjang * lebar) + (panjang * tinggi) + (lebar * tinggi))

        txtluas.Text = Str(luas)
        txtvolume.Text = Str(volume)
    End Sub
End Class
