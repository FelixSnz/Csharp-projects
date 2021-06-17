Public Class Form1
    Dim con As Boolean = True
    Dim counter As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Timer1.Enabled = True Then
            Timer1.Enabled = False
        Else
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Timer2.Enabled = True
        Else
            Timer2.Enabled = False
            counter = 0
            Label2.Text = counter.ToString
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        counter = counter + 1
        Label2.Text = counter.ToString
    End Sub
End Class
