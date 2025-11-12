<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroUsuario
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
        btnRLogin = New Button()
        btnRegistrar = New Button()
        txtRCContra = New TextBox()
        txtRContra = New TextBox()
        txtRUsuario = New TextBox()
        txtRAP = New TextBox()
        txtRNom = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Panel1 = New Panel()
        Label9 = New Label()
        Label8 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnRLogin
        ' 
        btnRLogin.BackColor = Color.SteelBlue
        btnRLogin.FlatStyle = FlatStyle.Popup
        btnRLogin.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRLogin.ImeMode = ImeMode.NoControl
        btnRLogin.Location = New Point(555, 363)
        btnRLogin.Name = "btnRLogin"
        btnRLogin.Size = New Size(122, 40)
        btnRLogin.TabIndex = 13
        btnRLogin.Text = "Loguearse"
        btnRLogin.UseVisualStyleBackColor = False
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.BackColor = Color.SteelBlue
        btnRegistrar.FlatStyle = FlatStyle.Popup
        btnRegistrar.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegistrar.ImeMode = ImeMode.NoControl
        btnRegistrar.Location = New Point(116, 363)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(122, 40)
        btnRegistrar.TabIndex = 25
        btnRegistrar.Text = "Registrarse"
        btnRegistrar.UseVisualStyleBackColor = False
        ' 
        ' txtRCContra
        ' 
        txtRCContra.Font = New Font("Elephant", 8.999999F)
        txtRCContra.Location = New Point(242, 309)
        txtRCContra.Name = "txtRCContra"
        txtRCContra.PasswordChar = "*"c
        txtRCContra.Size = New Size(125, 23)
        txtRCContra.TabIndex = 24
        ' 
        ' txtRContra
        ' 
        txtRContra.Font = New Font("Elephant", 8.999999F)
        txtRContra.Location = New Point(242, 263)
        txtRContra.Name = "txtRContra"
        txtRContra.PasswordChar = "*"c
        txtRContra.Size = New Size(125, 23)
        txtRContra.TabIndex = 23
        ' 
        ' txtRUsuario
        ' 
        txtRUsuario.Font = New Font("Elephant", 8.999999F)
        txtRUsuario.Location = New Point(242, 215)
        txtRUsuario.Name = "txtRUsuario"
        txtRUsuario.Size = New Size(125, 23)
        txtRUsuario.TabIndex = 22
        ' 
        ' txtRAP
        ' 
        txtRAP.Font = New Font("Elephant", 8.999999F)
        txtRAP.Location = New Point(242, 165)
        txtRAP.Name = "txtRAP"
        txtRAP.Size = New Size(125, 23)
        txtRAP.TabIndex = 21
        ' 
        ' txtRNom
        ' 
        txtRNom.Font = New Font("Elephant", 8.999999F)
        txtRNom.Location = New Point(242, 116)
        txtRNom.Name = "txtRNom"
        txtRNom.Size = New Size(125, 23)
        txtRNom.TabIndex = 20
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Elephant", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(534, 340)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 20)
        Label1.TabIndex = 26
        Label1.Text = "¿Ya estás registrado?"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Impact", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.MenuHighlight
        Label2.ImeMode = ImeMode.NoControl
        Label2.Location = New Point(583, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(162, 39)
        Label2.TabIndex = 27
        Label2.Text = "AdminMAX"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Elephant", 11.9999981F)
        Label3.Location = New Point(55, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 21)
        Label3.TabIndex = 28
        Label3.Text = "Nombre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Elephant", 11.9999981F)
        Label4.Location = New Point(55, 167)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 21)
        Label4.TabIndex = 29
        Label4.Text = "Apellido"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Elephant", 11.9999981F)
        Label5.Location = New Point(55, 217)
        Label5.Name = "Label5"
        Label5.Size = New Size(159, 21)
        Label5.TabIndex = 30
        Label5.Text = "Nombre de usuario"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Elephant", 11.9999981F)
        Label6.Location = New Point(55, 265)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 21)
        Label6.TabIndex = 31
        Label6.Text = "Contraseña"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Elephant", 11.9999981F)
        Label7.Location = New Point(55, 311)
        Label7.Name = "Label7"
        Label7.Size = New Size(183, 21)
        Label7.TabIndex = 32
        Label7.Text = "Confirmar contraseña"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label2)
        Panel1.Font = New Font("Elephant", 8.999999F)
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(802, 79)
        Panel1.TabIndex = 33
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Peru
        Label9.Location = New Point(56, 21)
        Label9.Name = "Label9"
        Label9.Size = New Size(152, 32)
        Label9.TabIndex = 35
        Label9.Text = "Registro"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(425, 103)
        Label8.Name = "Label8"
        Label8.Size = New Size(363, 19)
        Label8.TabIndex = 34
        Label8.Text = "Antes de comenzar debes registrarte"
        ' 
        ' RegistroUsuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(800, 450)
        Controls.Add(Label8)
        Controls.Add(Panel1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(btnRLogin)
        Controls.Add(btnRegistrar)
        Controls.Add(txtRCContra)
        Controls.Add(txtRContra)
        Controls.Add(txtRUsuario)
        Controls.Add(txtRAP)
        Controls.Add(txtRNom)
        Name = "RegistroUsuario"
        Text = "RegistroUsuario"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnRLogin As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents txtRCContra As TextBox
    Friend WithEvents txtRContra As TextBox
    Friend WithEvents txtRUsuario As TextBox
    Friend WithEvents txtRAP As TextBox
    Friend WithEvents txtRNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
