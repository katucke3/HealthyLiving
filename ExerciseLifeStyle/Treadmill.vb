Public Class Treadmill
    Private Sub TreadmillBox_Click(sender As Object, e As EventArgs) Handles TreadmillBox.Click
        Me.TreadmillBox.Image = Image.FromFile("C:\Users\Sam\Pictures\treadmill.gif")
    End Sub
End Class