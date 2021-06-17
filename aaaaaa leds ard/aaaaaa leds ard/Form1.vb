Imports System.IO.Ports
Public Class Form1
    Dim ass(5) As Char
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If CheckBox1.Checked = True Then
            PictureBox1.BackColor = Color.LightGreen
            ass(1) = "1"
        Else
            PictureBox1.BackColor = Color.Black
            ass(1) = "2"
        End If
        If CheckBox2.Checked = True Then
            PictureBox2.BackColor = Color.Red
            ass(2) = "3"
        Else
            PictureBox2.BackColor = Color.Black
            ass(2) = "4"
        End If
        If CheckBox3.Checked = True Then
            PictureBox3.BackColor = Color.Yellow
            ass(3) = "5"
        Else
            PictureBox3.BackColor = Color.Black
            ass(3) = "6"
        End If
        If CheckBox4.Checked = True Then
            PictureBox4.BackColor = Color.Blue
            ass(4) = "7"
        Else
            PictureBox4.BackColor = Color.Black
            ass(4) = "8"
        End If

        SerialPort1.Write(ass(1))
        SerialPort1.Write(ass(2))
        SerialPort1.Write(ass(3))
        SerialPort1.Write(ass(4))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SerialPort1.Open()
        Timer1.Enabled = True
    End Sub
End Class
