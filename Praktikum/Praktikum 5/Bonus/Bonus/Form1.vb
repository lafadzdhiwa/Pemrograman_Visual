Public Class Form1
    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        If (Val(txtmasa.Text) >= 20) Then
            txtketerangan.Text = "Anda Mendapat Bonus Berupa Mobil"

        ElseIf (txtmasa.Text >= 15) Then
            txtketerangan.Text = "Anda Mendapat Bonus Skin Legend"

        ElseIf (txtmasa.Text >= 10) Then
            txtketerangan.Text = "Anda Mendapat 5000 Diamond"

        ElseIf (txtmasa.Text >= 5) Then
            txtketerangan.Text = "Mendapat Uang 2 Juta Rupiah"

        Else
            txtketerangan.Text = "Maaf Anda Tidak Mendapatkan Bonus"
        End If
    End Sub
End Class
