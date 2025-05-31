Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "admin" And TextBox2.Text = 1234) Then
            Form4.Show()
            Me.Hide()
        Else
            MessageBox.Show("wrong details plese sign up")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class