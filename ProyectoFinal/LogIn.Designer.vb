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
        Label1 = New Label()
        txtLContra = New TextBox()
        txtLUsuario = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        btnLLogin = New Button()
        btnLRegistro = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F)
        Label1.ImeMode = ImeMode.NoControl
        Label1.Location = New Point(602, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 32)
        Label1.TabIndex = 1
        Label1.Text = "AdminMAX"
        ' 
        ' txtLContra
        ' 
        txtLContra.Location = New Point(245, 179)
        txtLContra.Name = "txtLContra"
        txtLContra.Size = New Size(100, 23)
        txtLContra.TabIndex = 13
        ' 
        ' txtLUsuario
        ' 
        txtLUsuario.Location = New Point(272, 133)
        txtLUsuario.Name = "txtLUsuario"
        txtLUsuario.Size = New Size(100, 23)
        txtLUsuario.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ImeMode = ImeMode.NoControl
        Label5.Location = New Point(157, 182)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 15)
        Label5.TabIndex = 11
        Label5.Text = "Contraseña"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ImeMode = ImeMode.NoControl
        Label4.Location = New Point(157, 136)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 15)
        Label4.TabIndex = 10
        Label4.Text = "Nombre de usuario"
        ' 
        ' btnLLogin
        ' 
        btnLLogin.Location = New Point(177, 340)
        btnLLogin.Name = "btnLLogin"
        btnLLogin.Size = New Size(102, 36)
        btnLLogin.TabIndex = 14
        btnLLogin.Text = "Log In"
        btnLLogin.UseVisualStyleBackColor = True
        ' 
        ' btnLRegistro
        ' 
        btnLRegistro.Location = New Point(616, 340)
        btnLRegistro.Name = "btnLRegistro"
        btnLRegistro.Size = New Size(93, 36)
        btnLRegistro.TabIndex = 15
        btnLRegistro.Text = "Registro"
        btnLRegistro.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(598, 311)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 15)
        Label2.TabIndex = 16
        Label2.Text = "¿No te habías registrado?"
        ' 
        ' LogIn
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DodgerBlue
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(btnLRegistro)
        Controls.Add(btnLLogin)
        Controls.Add(txtLContra)
        Controls.Add(txtLUsuario)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Name = "LogIn"
        Text = "LogIn"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtLContra As TextBox
    Friend WithEvents txtLUsuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLLogin As Button
    Friend WithEvents btnLRegistro As Button
    Friend WithEvents Label2 As Label
End Class
