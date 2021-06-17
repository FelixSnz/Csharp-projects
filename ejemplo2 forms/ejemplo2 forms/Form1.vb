Public Class Form1

    Private Sub Form3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form3ToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub Form2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form2ToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub SiToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub RojoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RojoToolStripMenuItem.Click
        Me.BackColor = Color.DarkRed
    End Sub

    Private Sub AzulToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AzulToolStripMenuItem.Click
        Me.BackColor = Color.Blue
    End Sub

    Private Sub VerdeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerdeToolStripMenuItem.Click
        Me.BackColor = Color.DarkGreen
    End Sub

    Private Sub OscuroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OscuroToolStripMenuItem.Click
        Me.BackColor = Color.DarkBlue
    End Sub

    Private Sub ClaroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClaroToolStripMenuItem.Click
        Me.BackColor = Color.LightBlue
    End Sub

    Private Sub OscuroToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles OscuroToolStripMenuItem2.Click
        Me.BackColor = Color.DarkGreen
    End Sub

    Private Sub ClaroToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ClaroToolStripMenuItem2.Click
        Me.BackColor = Color.LightGreen
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        AskForExit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AskForExit()
    End Sub

    Function AskForExit()
        Dim x As Integer
        x = MsgBox("seguro?", vbOKCancel, "salir?")
        If x = 1 Then
            End
        End If
    End Function
End Class
