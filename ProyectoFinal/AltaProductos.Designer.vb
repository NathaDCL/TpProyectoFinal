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
        SuspendLayout()
        ' 
        ' btnPCancelarProductos
        ' 
        btnPCancelarProductos.Location = New Point(611, 347)
        btnPCancelarProductos.Name = "btnPCancelarProductos"
        btnPCancelarProductos.Size = New Size(83, 32)
        btnPCancelarProductos.TabIndex = 15
        btnPCancelarProductos.Text = "Cancelar"
        btnPCancelarProductos.UseVisualStyleBackColor = True
        ' 
        ' btnPAltaProductos
        ' 
        btnPAltaProductos.Location = New Point(177, 331)
        btnPAltaProductos.Name = "btnPAltaProductos"
        btnPAltaProductos.Size = New Size(87, 32)
        btnPAltaProductos.TabIndex = 14
        btnPAltaProductos.Text = "Dar Alta"
        btnPAltaProductos.UseVisualStyleBackColor = True
        ' 
        ' txtPCategoria
        ' 
        txtPCategoria.Location = New Point(187, 157)
        txtPCategoria.Name = "txtPCategoria"
        txtPCategoria.Size = New Size(100, 23)
        txtPCategoria.TabIndex = 13
        ' 
        ' txtPPrecio
        ' 
        txtPPrecio.Location = New Point(187, 239)
        txtPPrecio.Name = "txtPPrecio"
        txtPPrecio.Size = New Size(100, 23)
        txtPPrecio.TabIndex = 12
        ' 
        ' txtPNombre
        ' 
        txtPNombre.Location = New Point(187, 72)
        txtPNombre.Name = "txtPNombre"
        txtPNombre.Size = New Size(100, 23)
        txtPNombre.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(107, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 10
        Label3.Text = "Categoria"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(107, 242)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 15)
        Label2.TabIndex = 9
        Label2.Text = "Precio"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(107, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 8
        Label1.Text = "Nombre"
        ' 
        ' AltaProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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
End Class
