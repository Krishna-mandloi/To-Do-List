Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "admin" And TextBox2.Text = 1234 And TextBox3.Text = 1234) Then
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("wrong details plese fill corect detail")
        End If
    End Sub
End Class