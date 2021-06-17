Public Class Form1
    Dim valores(10) As Single
    Dim i, j As Integer
    Dim sum As Single
    Dim count As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        For i = 0 To 10
            valores(i) = Format(Rnd(), "0.000")
            TextBox1.Text = TextBox1.Text & valores(i).ToString & vbNewLine
            sum = sum + valores(i)
            count = count + 1

        Next

        Label1.Text = valores(NumericUpDown1.Value)
        Label2.Text = "promedio:" & Format((sum / count), "0.000")


    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Label1.Text = valores(NumericUpDown1.Value)
    End Sub

End Class
