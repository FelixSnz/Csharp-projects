Public Class Form1
    Dim x1 As Integer = -1
    Dim y1 As Integer = 100
    Dim x2 As Integer = 0
    Dim y2 As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Refresh()
        x1 = -1
        y1 = 0
        x2 = 0
        y2 = 0
        For i = 0 To 300

            x1 = x1 + 1
            y1 = -1 * Math.Sin(i * (2 * Math.PI / 150)) * 100 + 100

            x2 = x1
            y2 = y1
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Refresh()
        x1 = -1
        y1 = 0
        x2 = 0
        y2 = 0

        For i = 0 To 300
            x1 = x1 + 1
            y1 = -1 * Math.Cos(i * (2 * Math.PI / 150)) * 100 + 100
            PictureBox1.CreateGraphics.DrawLine(Pens.AliceBlue, x1, y1, x2, y2)
            x2 = x1
            y2 = y1
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
