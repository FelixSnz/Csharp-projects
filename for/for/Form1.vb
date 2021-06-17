Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim valor As Integer = 0

        For i = 0 To 10
            valor = valor + i
        Next


        Label1.Text = Val(valor)
    End Sub
End Class
