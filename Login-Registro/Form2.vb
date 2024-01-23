Public Class Form2
    Private Sub NovoUsuárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoUsuárioToolStripMenuItem.Click
        Form3.Show()
        Me.Visible = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class