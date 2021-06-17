
Imports System
Imports System.IO.Ports
Public Class Form1

    Dim receivedData As String = ""
    Dim dat1, dat2, dat3, dat4 As String
    Dim arrData(5) As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SerialPort1.Close()
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        serial_com()
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim caca As String
        Dim arr() As String


        caca = SerialPort1.ReadExisting()



        arr = caca.Split("/")

        If arr.Length > 3 Then
            If arr(0) IsNot Nothing Then
                TextBox1.Text = arr(0).ToString & "v"
            End If

            If arr(1) IsNot Nothing Then
                TextBox2.Text = arr(1).ToString & "v"
            End If

            If arr(2) IsNot Nothing Then
                TextBox3.Text = arr(2).ToString & "v"
            End If

            If arr(3) IsNot Nothing Then
                TextBox4.Text = arr(3).ToString & "v"
            End If

        End If


    End Sub

    Function serial_com()
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
    End Function
End Class
