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
        SuspendLayout()
        ' 
        ' btnRLogin
        ' 
        btnRLogin.ImeMode = ImeMode.NoControl
        btnRLogin.Location = New Point(551, 392)
        btnRLogin.Name = "btnRLogin"
        btnRLogin.Size = New Size(109, 40)
        btnRLogin.TabIndex = 13
        btnRLogin.Text = "Loguearse"
        btnRLogin.UseVisualStyleBackColor = True
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.ImeMode = ImeMode.NoControl
        btnRegistrar.Location = New Point(147, 395)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(110, 34)
        btnRegistrar.TabIndex = 25
        btnRegistrar.Text = "Registrarse"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' txtRCContra
        ' 
        txtRCContra.Location = New Point(236, 308)
        txtRCContra.Name = "txtRCContra"
        txtRCContra.Size = New Size(100, 23)
        txtRCContra.TabIndex = 24
        ' 
        ' txtRContra
        ' 
        txtRContra.Location = New Point(196, 261)
        txtRContra.Name = "txtRContra"
        txtRContra.Size = New Size(100, 23)
        txtRContra.TabIndex = 23
        ' 
        ' txtRUsuario
        ' 
        txtRUsuario.Location = New Point(223, 215)
        txtRUsuario.Name = "txtRUsuario"
        txtRUsuario.Size = New Size(100, 23)
        txtRUsuario.TabIndex = 22
        ' 
        ' txtRAP
        ' 
        txtRAP.Location = New Point(185, 168)
        txtRAP.Name = "txtRAP"
        txtRAP.Size = New Size(100, 23)
        txtRAP.TabIndex = 21
        ' 
        ' txtRNom
        ' 
        txtRNom.Location = New Point(185, 116)
        txtRNom.Name = "txtRNom"
        txtRNom.Size = New Size(100, 23)
        txtRNom.TabIndex = 20
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(546, 363)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 15)
        Label1.TabIndex = 26
        Label1.Text = "¿Ya estás registrado?"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F)
        Label2.ImeMode = ImeMode.NoControl
        Label2.Location = New Point(592, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 32)
        Label2.TabIndex = 27
        Label2.Text = "AdminMAX"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(97, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 28
        Label3.Text = "Nombre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(97, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 29
        Label4.Text = "Apellido"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(97, 218)
        Label5.Name = "Label5"
        Label5.Size = New Size(109, 15)
        Label5.TabIndex = 30
        Label5.Text = "Nombre de usuario"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(97, 269)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 15)
        Label6.TabIndex = 31
        Label6.Text = "Contraseña"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(97, 316)
        Label7.Name = "Label7"
        Label7.Size = New Size(122, 15)
        Label7.TabIndex = 32
        Label7.Text = "Confirmar contraseña"
        ' 
        ' RegistroUsuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ClientSize = New Size(800, 450)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
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
End Class
