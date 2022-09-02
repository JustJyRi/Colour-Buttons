Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.BackColor = Color.Red
        Label1.Text = "Red"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.BackColor = Color.Blue
        Label1.Text = "Blue"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.BackColor = Color.SeaGreen
        Label1.Text = "Sea Green"
    End Sub
End Class
