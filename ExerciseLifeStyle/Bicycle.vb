Public Class Bicycle
    Private Sub BicycleBox_Click(sender As Object, e As EventArgs) Handles BicycleBox.Click
        Me.BicycleBox.Image = Image.FromFile("C:\Users\Sam\Pictures\cycling.gif")
    End Sub
End Class