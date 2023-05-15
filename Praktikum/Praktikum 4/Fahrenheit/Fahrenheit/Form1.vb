Public Class Form1
    Private Sub convert_Click(sender As Object, e As EventArgs) Handles convert.Click
        Dim c, f, r, k As Integer
        f = CDec(txtfahrenheit.Text)
        c = tocelcius(f)
        r = toreamur(f)
        k = tokelvin(f)

        txtcelcius.Text = Str(c)
        txtreamur.Text = Str(r)
        txtkelvin.Text = Str(k)
    End Sub

    Private Function tocelcius(f As Decimal) As Decimal
        Dim c As Decimal
        c = (5 / 9) * (f - 32)
        Return c
    End Function

    Private Function toreamur(f As Decimal) As Decimal
        Dim r As Decimal
        r = (4 / 9) * (f - 32)
        Return r
    End Function

    Private Function tokelvin(f As Decimal) As Decimal
        Dim k As Decimal
        k = (5 / 9) * (f - 32) + 27
        Return k
    End Function
End Class
