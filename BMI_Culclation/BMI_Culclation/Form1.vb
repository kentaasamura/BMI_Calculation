Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles TextBox3.TextChanged, Button1.Click
        Dim BMI As Double
        Dim hight As Double = Double.Parse(TextBox1.Text)
        Dim weight As Double = Double.Parse(TextBox2.Text)

        BMI = weight / (hight * hight)

        TextBox3.Text = Format(BMI, "0.0")

    End Sub

    Private Sub Label5_Click_1(sender As Object, e As EventArgs)
      
    End Sub



End Class
