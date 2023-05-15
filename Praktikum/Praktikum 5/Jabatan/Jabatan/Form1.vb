Public Class Form1
    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Select Case txtkode.Text
            Case "MGR" : txtketerangan.Text = "Manager"

            Case "SKR" : txtketerangan.Text = "Sekretaris"

            Case "BDH" : txtketerangan.Text = "Bendahara"

            Case Else : txtketerangan.Text = "Staff"
        End Select
    End Sub
End Class
