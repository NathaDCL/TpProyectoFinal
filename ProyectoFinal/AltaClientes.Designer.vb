<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaClientes
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
        Label2 = New Label()
        Label3 = New Label()
        txtCCliente = New TextBox()
        txtCTel = New TextBox()
        txtCCorreo = New TextBox()
        btnCAltaClientes = New Button()
        btnCCancelarClientes = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(109, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 0
        Label1.Text = "Cliente"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(109, 179)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 15)
        Label2.TabIndex = 1
        Label2.Text = "Telefono"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(109, 257)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 2
        Label3.Text = "Correo"
        ' 
        ' txtCCliente
        ' 
        txtCCliente.Location = New Point(189, 94)
        txtCCliente.Name = "txtCCliente"
        txtCCliente.Size = New Size(100, 23)
        txtCCliente.TabIndex = 3
        ' 
        ' txtCTel
        ' 
        txtCTel.Location = New Point(189, 176)
        txtCTel.Name = "txtCTel"
        txtCTel.Size = New Size(100, 23)
        txtCTel.TabIndex = 4
        ' 
        ' txtCCorreo
        ' 
        txtCCorreo.Location = New Point(189, 254)
        txtCCorreo.Name = "txtCCorreo"
        txtCCorreo.Size = New Size(100, 23)
        txtCCorreo.TabIndex = 5
        ' 
        ' btnCAltaClientes
        ' 
        btnCAltaClientes.Location = New Point(179, 353)
        btnCAltaClientes.Name = "btnCAltaClientes"
        btnCAltaClientes.Size = New Size(87, 32)
        btnCAltaClientes.TabIndex = 6
        btnCAltaClientes.Text = "Dar Alta"
        btnCAltaClientes.UseVisualStyleBackColor = True
        ' 
        ' btnCCancelarClientes
        ' 
        btnCCancelarClientes.Location = New Point(613, 369)
        btnCCancelarClientes.Name = "btnCCancelarClientes"
        btnCCancelarClientes.Size = New Size(83, 32)
        btnCCancelarClientes.TabIndex = 7
        btnCCancelarClientes.Text = "Cancelar"
        btnCCancelarClientes.UseVisualStyleBackColor = True
        ' 
        ' AltaClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCCancelarClientes)
        Controls.Add(btnCAltaClientes)
        Controls.Add(txtCCorreo)
        Controls.Add(txtCTel)
        Controls.Add(txtCCliente)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AltaClientes"
        Text = "AltaClientes"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCCliente As TextBox
    Friend WithEvents txtCTel As TextBox
    Friend WithEvents txtCCorreo As TextBox
    Friend WithEvents btnCAltaClientes As Button
    Friend WithEvents btnCCancelarClientes As Button
End Class
