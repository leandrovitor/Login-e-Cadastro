Public Class Form1
    Private Sub Tab_usersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tab_usersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VideoaulaDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VideoaulaDataSet.tab_users' table. You can move, or remove it, as needed.
        'Me.Tab_usersTableAdapter.Fill(Me.VideoaulaDataSet.tab_users)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim usuario As String
        Dim senha As String

        usuario = TextBox1.Text
        senha = TextBox2.Text


        If Me.Tab_usersTableAdapter.ScalarQueryLogin(usuario, senha) Then

            MsgBox("Login efetuado com sucesso!")
            Form2.Show()
            Me.Hide()
            TextBox1.Clear()
            TextBox2.Text = ""
        Else
            TextBox1.Text = "Erro ao logar no sistema!"
            TextBox1.BackColor = Color.Red

            TextBox2.Text = ""
        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = True

        Else
            TextBox2.UseSystemPasswordChar = False
        End If
    End Sub
End Class
