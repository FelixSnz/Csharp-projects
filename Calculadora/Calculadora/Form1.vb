Public Class Form1
    Dim dValue As Double = 0
    Dim sValue As String = ""
    Dim vStored1 As Nullable(Of Double) = Nothing
    Dim vStored2 As Nullable(Of Double) = Nothing
    Dim resultado As Double
    Dim operation As String
    Private Sub num1_Click(sender As Object, e As EventArgs) Handles num1.Click
        If sValue.Length < 10 Then
            sValue = sValue & "1"
            Label1.Text = sValue
            dValue = Val(sValue)
        End If
    End Sub

    Private Sub num2_Click(sender As Object, e As EventArgs) Handles num2.Click
        If sValue.Length < 10 Then
            sValue = sValue & "2"
            Label1.Text = sValue
            dValue = Val(sValue)
        End If
    End Sub

    Private Sub num3_Click(sender As Object, e As EventArgs) Handles num3.Click
        If sValue.Length < 10 Then
            sValue = sValue & "3"
            Label1.Text = sValue
            dValue = Val(sValue)
        End If
    End Sub

    Private Sub num4_Click(sender As Object, e As EventArgs) Handles num4.Click
        If sValue.Length < 10 Then
            sValue = sValue & "4"
            Label1.Text = sValue
            dValue = Val(sValue)
        End If
    End Sub

    Private Sub num5_Click(sender As Object, e As EventArgs) Handles num5.Click
        If sValue.Length < 10 Then
            sValue = sValue & "5"
            Label1.Text = sValue
            dValue = Val(sValue)
        End If
    End Sub

    Private Sub num6_Click(sender As Object, e As EventArgs) Handles num6.Click
        If sValue.Length < 10 Then
            sValue = sValue & "6"
            Label1.Text = sValue
            dValue = Val(sValue)
        End If
    End Sub

    Private Sub num7_Click(sender As Object, e As EventArgs) Handles num7.Click
        If sValue.Length < 10 Then
            sValue = sValue & "7"
            Label1.Text = sValue
            dValue = Val(sValue)
        End If
    End Sub

    Private Sub num8_Click(sender As Object, e As EventArgs) Handles num8.Click
        If sValue.Length < 10 Then
            sValue = sValue & "8"
            Label1.Text = sValue
            dValue = Val(sValue)
        End If
    End Sub

    Private Sub num9_Click(sender As Object, e As EventArgs) Handles num9.Click
        If sValue.Length < 10 Then
            sValue = sValue & "9"
            Label1.Text = sValue
            dValue = Val(sValue)
        End If


    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If vStored1 IsNot Nothing Then
            vStored2 = dValue
            dValue = 0
            sValue = ""
            Label1.Text = sValue
        Else
            vStored1 = dValue
            dValue = 0
            sValue = dValue.ToString
            Label1.Text = sValue
        End If




        operation = "add"


    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        dValue = 0
        sValue = dValue.ToString
        Label1.Text = sValue
    End Sub

    Private Sub EqualButton_Click(sender As Object, e As EventArgs) Handles EqualButton.Click

        If vStored1 IsNot Nothing Then
            vStored2 = dValue
            dValue = 0
            sValue = dValue.ToString
            Label1.Text = sValue
        Else
            vStored1 = dValue
            dValue = 0
            sValue = dValue.ToString
            Label1.Text = sValue
        End If

        If operation = "add" Then
            resultado = vStored1 + vStored2
            Label1.Text = resultado.ToString
        ElseIf operation = "sub" Then
            resultado = vStored1 - vStored2
            Label1.Text = resultado.ToString
        ElseIf operation = "mul" Then
            resultado = vStored1 * vStored2
            Label1.Text = resultado.ToString
        ElseIf operation = "div" Then
            resultado = vStored1 / vStored2
            Label1.Text = resultado.ToString
        End If

        vStored2 = Nothing
        vStored1 = Nothing

        dValue = resultado
    End Sub

    Private Sub SubButton_Click(sender As Object, e As EventArgs) Handles SubButton.Click
        If vStored1 IsNot Nothing Then
            vStored2 = dValue
            dValue = 0
            sValue = ""
            Label1.Text = sValue
        Else
            vStored1 = dValue
            dValue = 0
            sValue = ""
            Label1.Text = sValue
        End If




        operation = "sub"
    End Sub

    Private Sub MulButton_Click(sender As Object, e As EventArgs) Handles MulButton.Click
        If vStored1 IsNot Nothing Then
            Label1.Text = ""
            vStored2 = dValue
            dValue = 0
            Label1.Text = sValue
        Else
            vStored1 = dValue
            dValue = 0
            sValue = "0"
            Label1.Text = sValue
        End If




        operation = "mul"
    End Sub

    Private Sub DivButton_Click(sender As Object, e As EventArgs) Handles DivButton.Click
        If vStored1 IsNot Nothing Then
            vStored2 = dValue
            dValue = 0
            sValue = dValue.ToString
            Label1.Text = sValue
        Else
            vStored1 = dValue
            dValue = 0
            sValue = ""
            Label1.Text = sValue
        End If




        operation = "div"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If sValue.Length < 10 Then
            sValue = sValue & "0"
            Label1.Text = sValue
            dValue = Val(sValue)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = dValue
    End Sub
End Class
