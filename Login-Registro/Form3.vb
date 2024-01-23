Public Class Form3
    Private Sub Tab_usersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tab_usersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VideoaulaDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VideoaulaDataSet.tab_users' table. You can move, or remove it, as needed.
        Me.Tab_usersTableAdapter.Fill(Me.VideoaulaDataSet.tab_users)

    End Sub
    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form2.Visible = True
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form2.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tab_usersBindingSource.AddNew()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Tab_usersBindingSource.MovePrevious()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Tab_usersBindingSource.MoveNext()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error GoTo ErroSalvar

        Tab_usersBindingSource.EndEdit()
        Tab_usersTableAdapter.Update(Me.VideoaulaDataSet.tab_users)

        MsgBox("Cadastro Salvo com Sucesso!")

ErroSalvar:
    End Sub
End Class