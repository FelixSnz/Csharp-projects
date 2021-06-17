Imports System
Imports System.IO.Ports

Public Class Form1

    Dim x1 As Integer = -1
    Dim y1 As Integer = 100
    Dim x2 As Integer = 0
    Dim y2 As Integer = 0

    Dim receivedData As String = ""



    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        receivedData = ReceiveSerialData()
        Label2.Text = receivedData & "v"

        x1 = x1 + 1
        y1 = 198 - (Val(receivedData) * 40 - 1)
        Label3.Text = y1.ToString
        PictureBox1.CreateGraphics.DrawLine(Pens.AliceBlue, x1, y1, x2, y2)
        x2 = x1
        y2 = y1

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SerialPort1.Close()
        SerialPort1.PortName = "COM3"
        SerialPort1.BaudRate = 9600
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.Default
        SerialPort1.ReadTimeout = 10000
        SerialPort1.Open()

        Timer1.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class
