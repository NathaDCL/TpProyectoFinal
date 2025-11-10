<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaProductos
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
        btnPCancelarProductos = New Button()
        btnPAltaProductos = New Button()
        txtPCategoria = New TextBox()
        txtPPrecio = New TextBox()
        txtPNombre = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        Label9 = New Label()
        Label4 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnPCancelarProductos
        ' 
        btnPCancelarProductos.BackColor = Color.SteelBlue
        btnPCancelarProductos.FlatStyle = FlatStyle.Popup
        btnPCancelarProductos.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnPCancelarProductos.Location = New Point(611, 386)
        btnPCancelarProductos.Name = "btnPCancelarProductos"
        btnPCancelarProductos.Size = New Size(134, 32)
        btnPCancelarProductos.TabIndex = 15
        btnPCancelarProductos.Text = "Cancelar"
        btnPCancelarProductos.UseVisualStyleBackColor = False
        ' 
        ' btnPAltaProductos
        ' 
        btnPAltaProductos.BackColor = Color.SteelBlue
        btnPAltaProductos.FlatStyle = FlatStyle.Popup
        btnPAltaProductos.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnPAltaProductos.Location = New Point(127, 337)
        btnPAltaProductos.Name = "btnPAltaProductos"
        btnPAltaProductos.Size = New Size(138, 32)
        btnPAltaProductos.TabIndex = 14
        btnPAltaProductos.Text = "Dar Alta"
        btnPAltaProductos.UseVisualStyleBackColor = False
        ' 
        ' txtPCategoria
        ' 
        txtPCategoria.Font = New Font("Elephant", 8.999999F)
        txtPCategoria.Location = New Point(172, 197)
        txtPCategoria.Name = "txtPCategoria"
        txtPCategoria.Size = New Size(135, 23)
        txtPCategoria.TabIndex = 13
        ' 
        ' txtPPrecio
        ' 
        txtPPrecio.Font = New Font("Elephant", 8.999999F)
        txtPPrecio.Location = New Point(172, 279)
        txtPPrecio.Name = "txtPPrecio"
        txtPPrecio.Size = New Size(135, 23)
        txtPPrecio.TabIndex = 12
        ' 
        ' txtPNombre
        ' 
        txtPNombre.Font = New Font("Elephant", 8.999999F)
        txtPNombre.Location = New Point(172, 112)
        txtPNombre.Name = "txtPNombre"
        txtPNombre.Size = New Size(135, 23)
        txtPNombre.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Elephant", 11.9999981F)
        Label3.Location = New Point(64, 199)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 21)
        Label3.TabIndex = 10
        Label3.Text = "Categoria"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Elephant", 11.9999981F)
        Label2.Location = New Point(64, 281)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 21)
        Label2.TabIndex = 9
        Label2.Text = "Precio"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Elephant", 11.9999981F)
        Label1.Location = New Point(64, 114)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 21)
        Label1.TabIndex = 8
        Label1.Text = "Nombre"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label4)
        Panel1.Font = New Font("Elephant", 8.999999F)
        Panel1.Location = New Point(0, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(802, 73)
        Panel1.TabIndex = 38
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Peru
        Label9.Location = New Point(34, 21)
        Label9.Name = "Label9"
        Label9.Size = New Size(252, 32)
        Label9.TabIndex = 36
        Label9.Text = "Alta Productos"
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
        ' AltaProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(btnPCancelarProductos)
        Controls.Add(btnPAltaProductos)
        Controls.Add(txtPCategoria)
        Controls.Add(txtPPrecio)
        Controls.Add(txtPNombre)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AltaProductos"
        Text = "AltaProductos"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPCancelarProductos As Button
    Friend WithEvents btnPAltaProductos As Button
    Friend WithEvents txtPCategoria As TextBox
    Friend WithEvents txtPPrecio As TextBox
    Friend WithEvents txtPNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
End Class
