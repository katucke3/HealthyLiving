Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub comboWorkout_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboWorkout.SelectedIndexChanged
        If (comboWorkout.Text = "Jump Rope") Then
            picWorkout.ImageLocation = "http://media3.giphy.com/media/3oz8xRsCP14cAnCtIA/giphy.gif"

        ElseIf (comboWorkout.Text = "Sit-Ups") Then
            picWorkout.ImageLocation = "https://media.giphy.com/media/KeAc9WTl07nYQ/giphy.gif"
        ElseIf (comboWorkout.Text = "Jogging") Then
            picWorkout.ImageLocation = "https://www.netanimations.net/skeltw2.gif"
        ElseIf (comboWorkout.Text = "Cycling") Then
            picWorkout.ImageLocation = "https://media.giphy.com/media/xTiTnAUgTbDrsUiHja/giphy.gif"
        ElseIf (comboWorkout.Text = "Treadmill") Then
            picWorkout.ImageLocation = "http://i.giftrunk.com/aqc1k6.gif"
        ElseIf (comboWorkout.Text = "Pull-Ups") Then
            picWorkout.ImageLocation = "http://i.imgur.com/1LCE5MW.gif"
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtboxMinutes.TextChanged


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub
End Class
