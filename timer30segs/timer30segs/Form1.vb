Public Class Form1
    Dim GreenTime As Integer = 10
    Dim YelowwTime As Integer = 5
    Dim RedTime As Integer = 15
    Dim time As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If time = 0 Then
            Button1.BackColor = Color.Green
            Button2.BackColor = Color.Gray
            Button3.BackColor = Color.Gray
        End If
        time = time + 1

        If time >= -1 And time <= GreenTime Then
            Button1.BackColor = Color.Green
            Button2.BackColor = Color.Gray
            Button3.BackColor = Color.Gray
        ElseIf time > 10 And time <= 15 Then
            Button3.BackColor = Color.Yellow
            Button1.BackColor = Color.Gray
            Button2.BackColor = Color.Gray
        ElseIf time > 15 And time <= 30 Then
            Button2.BackColor = Color.Red
            Button1.BackColor = Color.Gray
            Button3.BackColor = Color.Gray
        End If

        If time > 30 Then
            time = 0
            Button1.BackColor = Color.Green
            Button2.BackColor = Color.Gray
            Button3.BackColor = Color.Gray
        End If

        Label1.Text = time

    End Sub
End Class
