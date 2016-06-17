Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, TextBox3.TextChanged
        Dim BMI As Double
        Dim hight As Double = Double.Parse(TextBox1.Text)
        Dim weight As Double = Double.Parse(TextBox2.Text)
        Dim out As String

        BMI = weight / hight * hight

        out = BMI.ToString(BMI)

        TextBox3.Text = out

    End Sub

    Private Sub Label5_Click_1(sender As Object, e As EventArgs)
      
    End Sub


End Class
