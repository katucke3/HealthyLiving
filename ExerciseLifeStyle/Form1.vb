Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub comboWorkout_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboWorkout.SelectedIndexChanged
        If comboWorkout.Text = "Jump Rope" Then
            MessageBox.Show("PictureBox1")
        End If
        If comboWorkout.Text = "Sit-Ups" Then
            MessageBox.Show("Person doing sit-ups")
        End If
        If comboWorkout.Text = "Jogging" Then
            MessageBox.Show("person jogging")
        End If
        If comboWorkout.Text = "Treadmill" Then
            MessageBox.Show("person running on treadmill")
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtboxMinutes.TextChanged


    End Sub
End Class
