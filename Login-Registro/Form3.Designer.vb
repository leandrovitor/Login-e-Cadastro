<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CódigoLabel As System.Windows.Forms.Label
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim SenhaLabel As System.Windows.Forms.Label
        Dim E_mailLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim Data_de_nascimentoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.VideoaulaDataSet = New Login_Registro.videoaulaDataSet()
        Me.Tab_usersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tab_usersTableAdapter = New Login_Registro.videoaulaDataSetTableAdapters.tab_usersTableAdapter()
        Me.TableAdapterManager = New Login_Registro.videoaulaDataSetTableAdapters.TableAdapterManager()
        Me.CódigoTextBox = New System.Windows.Forms.TextBox()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.SenhaTextBox = New System.Windows.Forms.TextBox()
        Me.E_mailTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.Data_de_nascimentoTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CódigoLabel = New System.Windows.Forms.Label()
        UsuarioLabel = New System.Windows.Forms.Label()
        SenhaLabel = New System.Windows.Forms.Label()
        E_mailLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        Data_de_nascimentoLabel = New System.Windows.Forms.Label()
        CType(Me.VideoaulaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tab_usersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CódigoLabel
        '
        CódigoLabel.AutoSize = True
        CódigoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CódigoLabel.Location = New System.Drawing.Point(162, 25)
        CódigoLabel.Name = "CódigoLabel"
        CódigoLabel.Size = New System.Drawing.Size(56, 17)
        CódigoLabel.TabIndex = 1
        CódigoLabel.Text = "Código:"
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsuarioLabel.Location = New System.Drawing.Point(162, 87)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(61, 17)
        UsuarioLabel.TabIndex = 3
        UsuarioLabel.Text = "Usuário:"
        '
        'SenhaLabel
        '
        SenhaLabel.AutoSize = True
        SenhaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SenhaLabel.Location = New System.Drawing.Point(313, 85)
        SenhaLabel.Name = "SenhaLabel"
        SenhaLabel.Size = New System.Drawing.Size(53, 17)
        SenhaLabel.TabIndex = 5
        SenhaLabel.Text = "Senha:"
        '
        'E_mailLabel
        '
        E_mailLabel.AutoSize = True
        E_mailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        E_mailLabel.Location = New System.Drawing.Point(162, 144)
        E_mailLabel.Name = "E_mailLabel"
        E_mailLabel.Size = New System.Drawing.Size(51, 17)
        E_mailLabel.TabIndex = 7
        E_mailLabel.Text = "E-mail:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.Location = New System.Drawing.Point(161, 205)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(49, 17)
        NomeLabel.TabIndex = 9
        NomeLabel.Text = "Nome:"
        '
        'Data_de_nascimentoLabel
        '
        Data_de_nascimentoLabel.AutoSize = True
        Data_de_nascimentoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Data_de_nascimentoLabel.Location = New System.Drawing.Point(313, 205)
        Data_de_nascimentoLabel.Name = "Data_de_nascimentoLabel"
        Data_de_nascimentoLabel.Size = New System.Drawing.Size(140, 17)
        Data_de_nascimentoLabel.TabIndex = 11
        Data_de_nascimentoLabel.Text = "Data de Nascimento:"
        '
        'VideoaulaDataSet
        '
        Me.VideoaulaDataSet.DataSetName = "videoaulaDataSet"
        Me.VideoaulaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tab_usersBindingSource
        '
        Me.Tab_usersBindingSource.DataMember = "tab_users"
        Me.Tab_usersBindingSource.DataSource = Me.VideoaulaDataSet
        '
        'Tab_usersTableAdapter
        '
        Me.Tab_usersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tab_usersTableAdapter = Me.Tab_usersTableAdapter
        Me.TableAdapterManager.UpdateOrder = Login_Registro.videoaulaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CódigoTextBox
        '
        Me.CódigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tab_usersBindingSource, "Código", True))
        Me.CódigoTextBox.Enabled = False
        Me.CódigoTextBox.Location = New System.Drawing.Point(165, 50)
        Me.CódigoTextBox.Multiline = True
        Me.CódigoTextBox.Name = "CódigoTextBox"
        Me.CódigoTextBox.Size = New System.Drawing.Size(65, 34)
        Me.CódigoTextBox.TabIndex = 2
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tab_usersBindingSource, "usuario", True))
        Me.UsuarioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(164, 106)
        Me.UsuarioTextBox.Multiline = True
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(142, 32)
        Me.UsuarioTextBox.TabIndex = 4
        '
        'SenhaTextBox
        '
        Me.SenhaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tab_usersBindingSource, "senha", True))
        Me.SenhaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SenhaTextBox.Location = New System.Drawing.Point(315, 105)
        Me.SenhaTextBox.Multiline = True
        Me.SenhaTextBox.Name = "SenhaTextBox"
        Me.SenhaTextBox.Size = New System.Drawing.Size(142, 37)
        Me.SenhaTextBox.TabIndex = 6
        '
        'E_mailTextBox
        '
        Me.E_mailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tab_usersBindingSource, "e-mail", True))
        Me.E_mailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.E_mailTextBox.Location = New System.Drawing.Point(164, 164)
        Me.E_mailTextBox.Multiline = True
        Me.E_mailTextBox.Name = "E_mailTextBox"
        Me.E_mailTextBox.Size = New System.Drawing.Size(293, 32)
        Me.E_mailTextBox.TabIndex = 8
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tab_usersBindingSource, "nome", True))
        Me.NomeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox.Location = New System.Drawing.Point(164, 225)
        Me.NomeTextBox.Multiline = True
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(142, 40)
        Me.NomeTextBox.TabIndex = 10
        '
        'Data_de_nascimentoTextBox
        '
        Me.Data_de_nascimentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tab_usersBindingSource, "data de nascimento", True))
        Me.Data_de_nascimentoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_de_nascimentoTextBox.Location = New System.Drawing.Point(316, 225)
        Me.Data_de_nascimentoTextBox.Multiline = True
        Me.Data_de_nascimentoTextBox.Name = "Data_de_nascimentoTextBox"
        Me.Data_de_nascimentoTextBox.Size = New System.Drawing.Size(141, 40)
        Me.Data_de_nascimentoTextBox.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 46)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "NOVO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(135, 264)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Novo Usuário"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 206)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(123, 46)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "PRÓXIMO"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 143)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 46)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "ANTERIOR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 46)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "SALVAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-13, -13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(502, 309)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 284)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(CódigoLabel)
        Me.Controls.Add(Me.CódigoTextBox)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(SenhaLabel)
        Me.Controls.Add(Me.SenhaTextBox)
        Me.Controls.Add(E_mailLabel)
        Me.Controls.Add(Me.E_mailTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(Data_de_nascimentoLabel)
        Me.Controls.Add(Me.Data_de_nascimentoTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Usuário"
        CType(Me.VideoaulaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tab_usersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VideoaulaDataSet As videoaulaDataSet
    Friend WithEvents Tab_usersBindingSource As BindingSource
    Friend WithEvents Tab_usersTableAdapter As videoaulaDataSetTableAdapters.tab_usersTableAdapter
    Friend WithEvents TableAdapterManager As videoaulaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CódigoTextBox As TextBox
    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents SenhaTextBox As TextBox
    Friend WithEvents E_mailTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents Data_de_nascimentoTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
