Public Class Form1
    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Select Case txtjabatan.Text
            Case "Manager" : txtketerangan.Text = "Laptop, Flasdisk"

            Case "Bendahara" : txtketerangan.Text = "Buku catatan, Kalkulator"

            Case "HRD" : txtketerangan.Text = "Handphone, Buku Psikologi"

            Case "Enginer" : txtketerangan.Text = "Tool Kit"

            Case Else : txtketerangan.Text = "Maaf Anda Tidak Mendapat Bonus"
        End Select
    End Sub
End Class
