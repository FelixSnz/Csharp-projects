Public Class Form1
    Dim parcial1, parcial2, parcial3 As Double

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        parcial1 = NumericUpDown1.Value
        parcial2 = NumericUpDown2.Value
        parcial3 = NumericUpDown3.Value


        Label2.Text = "Promedio" & Promedio(parcial1, parcial2, parcial3).ToString
    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged
        parcial1 = NumericUpDown1.Value
        parcial2 = NumericUpDown2.Value
        parcial3 = NumericUpDown3.Value


        Label2.Text = "Promedio" & Promedio(parcial1, parcial2, parcial3).ToString
    End Sub

    Function Promedio(PrimerPar As Double, SegundoPar As Double, TercerPar As Double) As Double
        Dim prom As Double
        prom = (PrimerPar + SegundoPar + TercerPar) / 3
        Return prom
    End Function

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        parcial1 = NumericUpDown1.Value
        parcial2 = NumericUpDown2.Value
        parcial3 = NumericUpDown3.Value


        Label2.Text = "Promedio" & Promedio(parcial1, parcial2, parcial3).ToString
    End Sub
End Class


