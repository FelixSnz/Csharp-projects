Public Class Form1

    Dim SecActions As Integer = 0

    Dim arrSec() As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        arrSec = RandSecArr(SecActions, 1, 4)

        TextBox1.Text = String.Join("", arrSec)

    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        SecActions = NumericUpDown1.Value
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Function RandSecArr(max As Integer, lowerBound As Integer, upperbound As Integer) As String()
        Dim randNum As Integer
        Dim arrSecuence(max) As String
        Dim tempAct As String
        For i = 0 To max - 1
            If max <> 0 Then
                randNum = Int((upperbound - lowerBound + 1) * Rnd() + lowerBound)
                If randNum = 1 Then
                    If arrSecuence.Length = 0 Then
                        tempAct = "A" & "+"
                    End If
                    tempAct = "A" & RndSign()
                    arrSecuence(i) = tempAct
                ElseIf randNum = 2 Then
                    tempAct = "B" & RndSign()
                    arrSecuence(i) = tempAct
                ElseIf randNum = 3 Then
                    tempAct = "C" & RndSign()
                    arrSecuence(i) = tempAct
                ElseIf randNum = 4 Then
                    tempAct = "D" & RndSign()
                    arrSecuence(i) = tempAct
                End If
            End If
        Next
        Return arrSecuence
    End Function

    Function filterSec() As String()
        Dim PrivarrSec() As String
        Dim arrFiltered As Boolean = False

        PrivarrSec = RandSecArr(SecActions, 1, 4)

        While Not arrFiltered

            For Each i As String In PrivarrSec

            Next

        End While


    End Function


    Function RndSign() As String
        Dim randNum As Integer
        randNum = Int((2) * Rnd() + 0)

        If randNum = 1 Then
            Return "+"
        ElseIf randNum = 0 Then
            Return "-"
        End If

    End Function
End Class
