Public Class Form1
    Private Sub hitung_Click(sender As Object, e As EventArgs) Handles hitung.Click
        Dim usia As Decimal

        If rbanak.Checked Then
            usia = 20000
        ElseIf rbdewasa.Checked Then
            usia = 50000
        ElseIf rblansia.Checked Then
            usia = 30000
        Else
            MessageBox.Show("Pilih Kategori Anda Dengan Sesuai")
        End If

        txtharga.Text = Format(Val(usia), "Rp,###,##,0.00")
    End Sub
End Class
