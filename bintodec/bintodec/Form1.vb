Public Class Form1
    Dim i As Integer
    Dim binary As String
    Dim binaryarray() As Char
    Dim dvalue As Integer = 0

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


        binary = TextBox1.Text

        TextBox2.Text = BinToDec(binary)

    End Sub

    Function BinToDec(binary As String) As Integer
        binaryarray = binary.ToCharArray
        dvalue = 0
        For i = 1 To binaryarray.Length
            If binaryarray(i - 1) = "1" Then
                dvalue = dvalue + Math.Pow(2, binaryarray.Length - i)
            End If
        Next
        Return dvalue
    End Function
End Class
