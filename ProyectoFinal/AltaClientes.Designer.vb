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
        Panel1 = New Panel()
        Label9 = New Label()
        Label4 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Elephant", 11.9999981F)
        Label1.Location = New Point(79, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 21)
        Label1.TabIndex = 0
        Label1.Text = "Cliente"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Elephant", 11.9999981F)
        Label2.Location = New Point(79, 198)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 21)
        Label2.TabIndex = 1
        Label2.Text = "Telefono"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Elephant", 11.9999981F)
        Label3.Location = New Point(79, 276)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 21)
        Label3.TabIndex = 2
        Label3.Text = "Correo"
        ' 
        ' txtCCliente
        ' 
        txtCCliente.Font = New Font("Elephant", 8.999999F)
        txtCCliente.Location = New Point(188, 116)
        txtCCliente.Name = "txtCCliente"
        txtCCliente.Size = New Size(129, 23)
        txtCCliente.TabIndex = 3
        ' 
        ' txtCTel
        ' 
        txtCTel.Font = New Font("Elephant", 8.999999F)
        txtCTel.Location = New Point(188, 198)
        txtCTel.Name = "txtCTel"
        txtCTel.Size = New Size(129, 23)
        txtCTel.TabIndex = 4
        ' 
        ' txtCCorreo
        ' 
        txtCCorreo.Font = New Font("Elephant", 8.999999F)
        txtCCorreo.Location = New Point(188, 276)
        txtCCorreo.Name = "txtCCorreo"
        txtCCorreo.Size = New Size(129, 23)
        txtCCorreo.TabIndex = 5
        ' 
        ' btnCAltaClientes
        ' 
        btnCAltaClientes.BackColor = Color.SteelBlue
        btnCAltaClientes.FlatStyle = FlatStyle.Popup
        btnCAltaClientes.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnCAltaClientes.Location = New Point(131, 342)
        btnCAltaClientes.Name = "btnCAltaClientes"
        btnCAltaClientes.Size = New Size(136, 32)
        btnCAltaClientes.TabIndex = 6
        btnCAltaClientes.Text = "Dar Alta"
        btnCAltaClientes.UseVisualStyleBackColor = False
        ' 
        ' btnCCancelarClientes
        ' 
        btnCCancelarClientes.BackColor = Color.SteelBlue
        btnCCancelarClientes.FlatStyle = FlatStyle.Popup
        btnCCancelarClientes.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnCCancelarClientes.Location = New Point(594, 381)
        btnCCancelarClientes.Name = "btnCCancelarClientes"
        btnCCancelarClientes.Size = New Size(132, 32)
        btnCCancelarClientes.TabIndex = 7
        btnCCancelarClientes.Text = "Cancelar"
        btnCCancelarClientes.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label4)
        Panel1.Font = New Font("Elephant", 8.999999F)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(802, 79)
        Panel1.TabIndex = 37
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Peru
        Label9.Location = New Point(34, 21)
        Label9.Name = "Label9"
        Label9.Size = New Size(220, 32)
        Label9.TabIndex = 36
        Label9.Text = "Alta Clientes"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Impact", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.MenuHighlight
        Label4.ImeMode = ImeMode.NoControl
        Label4.Location = New Point(583, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(162, 39)
        Label4.TabIndex = 27
        Label4.Text = "AdminMAX"
        ' 
        ' AltaClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
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
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
End Class
