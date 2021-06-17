Public Class Form1
    Dim x1 As Integer = 0
    Dim y1 As Integer = 100
    Dim x2 As Integer = 0
    Dim y2 As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        PictureBox1.Refresh()
        PictureBox1.CreateGraphics.DrawLine(Pens.Blue, 0, 100, 300, 100)
        x1 = 0
        y1 = 100
        x2 = 0
        y2 = 0

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        y2 = Rnd() * 200
        x2 = x1 + 5
        PictureBox1.CreateGraphics.DrawLine(Pens.Blue, x1, y1, x2, y2)
        y1 = y2
        x1 = x2

        If x2 = 300 Then
            PictureBox1.Refresh()
            PictureBox1.CreateGraphics.DrawLine(Pens.Blue, 0, 100, 300, 100)
            x1 = 0
            y1 = 100
            x2 = 0
            y2 = 0
        End If

    End Sub
End Class
