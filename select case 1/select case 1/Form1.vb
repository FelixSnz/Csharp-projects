Public Class Form1
    Dim counter As Integer = 0
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Label1.Text = UCase(Label1.Text)

        Else
            Label1.Text = LCase(Label1.Text)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        counter = counter + 1
        If counter = 1 Then
            Me.BackColor = Color.Aquamarine
        ElseIf counter = 2 Then
            Me.BackColor = Color.Gray
        ElseIf counter = 3 Then
            counter = 1

        End If


    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
