Public Class Form1
    Private Sub hitung_Click_1(sender As Object, e As EventArgs) Handles hitung.Click
        Dim panjang, lebar, luas, keliling As Integer

        panjang = Val(txtpanjang.Text)
        lebar = Val(txtlebar.Text)

        luas = Val(txtpanjang.Text)
        txtluas.Text = Val(txtkeliling.Text)

        luas = (panjang * lebar)
        keliling = (2 * (panjang + lebar))
        txtkeliling.Text = keliling
    End Sub
End Class