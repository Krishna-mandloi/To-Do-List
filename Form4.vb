Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtTask.Text.Trim() <> "" Then
            lstTask.Items.Add(txtTask.Text)
            txtTask.Clear()
        Else
            MessageBox.Show("Please enter a task.")
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstTask.SelectedIndex >= 0 Then
            lstTask.Items.RemoveAt(lstTask.SelectedIndex)
        Else
            MessageBox.Show("Please select a task to remove.")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim saveDialog As New SaveFileDialog
        saveDialog.Filter = "Text Files (.txt)|.txt"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllLines(saveDialog.FileName, lstTask.Items.Cast(Of String)())
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openDialog As New OpenFileDialog
        openDialog.Filter = "Text Files (*.txt)|*.txt"

        If openDialog.ShowDialog() = DialogResult.OK Then
            Try
                lstTask.Items.Clear()
                Dim lines() As String = IO.File.ReadAllLines(openDialog.FileName)
                For Each line In lines
                    lstTask.Items.Add(line)
                Next
            Catch ex As Exception
                MessageBox.Show("Error loading tasks: " & ex.Message)
            End Try
        End If
    End Sub


End Class