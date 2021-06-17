Public Class Form1
    Dim x As String
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label1.Text = ComboBox1.Text
        x = Label1.Text

        Select Case x
            Case "rojo"
                Button1.BackColor = Color.Red
            Case "verde"
                Button1.BackColor = Color.Green
            Case "azul"
                Button1.BackColor = Color.Blue
            Case "amarillo"
                Button1.BackColor = Color.Yellow
            Case "gris"
                Button1.BackColor = Color.Gray
            Case "blanco"
                Button1.BackColor = Color.White
        End Select
    End Sub
End Class
