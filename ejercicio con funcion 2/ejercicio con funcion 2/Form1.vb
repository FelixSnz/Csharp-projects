Public Class Form1
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Label2.Text = "Hexadecial: " & Hex(NumericUpDown1.Value).ToString
        Label3.Text = "Octal: " & Oct(NumericUpDown1.Value).ToString
        Label4.Text = "bin: " & Bin(NumericUpDown1.Value)
    End Sub

    Private Function Bin(decim As Integer) As String
        Dim binary As Integer
        Dim output As String
        While decim <> 0
            If decim Mod 2 = 0 Then
                binary = 0
            Else
                binary = 1
            End If
            decim = decim \ 2
            output = Convert.ToString(binary) & output
        End While
        If output Is Nothing Then
            Return "0"
        Else
            Return output
        End If
    End Function
End Class
