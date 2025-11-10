<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtLContra = New TextBox()
        txtLUsuario = New TextBox()
        btnLLogin = New Button()
        btnLRegistro = New Button()
        Label2 = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label9 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtLContra
        ' 
        txtLContra.Font = New Font("Elephant", 8.999999F)
        txtLContra.Location = New Point(263, 225)
        txtLContra.Name = "txtLContra"
        txtLContra.PasswordChar = "*"c
        txtLContra.Size = New Size(134, 23)
        txtLContra.TabIndex = 13
        ' 
        ' txtLUsuario
        ' 
        txtLUsuario.Font = New Font("Elephant", 8.999999F)
        txtLUsuario.Location = New Point(263, 182)
        txtLUsuario.Name = "txtLUsuario"
        txtLUsuario.Size = New Size(134, 23)
        txtLUsuario.TabIndex = 12
        ' 
        ' btnLLogin
        ' 
        btnLLogin.BackColor = Color.SteelBlue
        btnLLogin.FlatStyle = FlatStyle.Popup
        btnLLogin.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnLLogin.Location = New Point(185, 340)
        btnLLogin.Name = "btnLLogin"
        btnLLogin.Size = New Size(120, 36)
        btnLLogin.TabIndex = 14
        btnLLogin.Text = "Log In"
        btnLLogin.UseVisualStyleBackColor = False
        ' 
        ' btnLRegistro
        ' 
        btnLRegistro.BackColor = Color.SteelBlue
        btnLRegistro.FlatStyle = FlatStyle.Popup
        btnLRegistro.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnLRegistro.Location = New Point(583, 340)
        btnLRegistro.Name = "btnLRegistro"
        btnLRegistro.Size = New Size(111, 36)
        btnLRegistro.TabIndex = 15
        btnLRegistro.Text = "Registro"
        btnLRegistro.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Elephant", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(544, 317)
        Label2.Name = "Label2"
        Label2.Size = New Size(201, 20)
        Label2.TabIndex = 16
        Label2.Text = "¿No te habías registrado?"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label3)
        Panel1.Font = New Font("Elephant", 8.999999F)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(802, 79)
        Panel1.TabIndex = 34
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Impact", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.MenuHighlight
        Label3.ImeMode = ImeMode.NoControl
        Label3.Location = New Point(583, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(162, 39)
        Label3.TabIndex = 27
        Label3.Text = "AdminMAX"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Elephant", 11.9999981F)
        Label6.Location = New Point(88, 229)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 21)
        Label6.TabIndex = 36
        Label6.Text = "Contraseña"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Elephant", 11.9999981F)
        Label5.Location = New Point(88, 181)
        Label5.Name = "Label5"
        Label5.Size = New Size(159, 21)
        Label5.TabIndex = 35
        Label5.Text = "Nombre de usuario"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Peru
        Label9.Location = New Point(57, 21)
        Label9.Name = "Label9"
        Label9.Size = New Size(104, 32)
        Label9.TabIndex = 36
        Label9.Text = "Log In"
        ' 
        ' LogIn
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(btnLRegistro)
        Controls.Add(btnLLogin)
        Controls.Add(txtLContra)
        Controls.Add(txtLUsuario)
        Name = "LogIn"
        Text = "LogIn"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtLContra As TextBox
    Friend WithEvents txtLUsuario As TextBox
    Friend WithEvents btnLLogin As Button
    Friend WithEvents btnLRegistro As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
End Class
