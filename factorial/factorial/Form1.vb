Public Class Form1
    Dim i As Integer
    Dim valor As Integer
    Dim factorial As ULong = 1
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

        factorial = 1


        For i = 1 To Val(NumericUpDown1.Value)
            factorial = factorial * i

        Next

        Label2.Text = factorial.ToString





    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        factorial = 1
    End Sub
End Class
