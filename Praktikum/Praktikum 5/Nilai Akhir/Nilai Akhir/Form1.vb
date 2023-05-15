Public Class Form1
    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        If (Val(txtnilai.Text) >= 60) Then
            xtketerangan.Text = "Anda Lulus"
        Else
            xtketerangan.Text = "Anda Tidak Lulus, Silakan Mengulang Tahun Berikutnya"
        End If
    End Sub
End Class
