<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaVentasItems
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtVIIdproducto = New TextBox()
        txtVIPrecioU = New TextBox()
        txtVICantidad = New TextBox()
        btnVICancelar = New Button()
        btnVIAlta = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(137, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 1
        Label2.Text = "IdProducto"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(137, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 15)
        Label3.TabIndex = 2
        Label3.Text = "Precio Unitario"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(137, 227)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 3
        Label4.Text = "Cantidad"
        ' 
        ' txtVIIdproducto
        ' 
        txtVIIdproducto.Location = New Point(228, 90)
        txtVIIdproducto.Name = "txtVIIdproducto"
        txtVIIdproducto.Size = New Size(100, 23)
        txtVIIdproducto.TabIndex = 5
        ' 
        ' txtVIPrecioU
        ' 
        txtVIPrecioU.Location = New Point(228, 160)
        txtVIPrecioU.Name = "txtVIPrecioU"
        txtVIPrecioU.Size = New Size(100, 23)
        txtVIPrecioU.TabIndex = 6
        ' 
        ' txtVICantidad
        ' 
        txtVICantidad.Location = New Point(228, 224)
        txtVICantidad.Name = "txtVICantidad"
        txtVICantidad.Size = New Size(100, 23)
        txtVICantidad.TabIndex = 7
        ' 
        ' btnVICancelar
        ' 
        btnVICancelar.Location = New Point(642, 388)
        btnVICancelar.Name = "btnVICancelar"
        btnVICancelar.Size = New Size(80, 36)
        btnVICancelar.TabIndex = 8
        btnVICancelar.Text = "Salir"
        btnVICancelar.UseVisualStyleBackColor = True
        ' 
        ' btnVIAlta
        ' 
        btnVIAlta.Location = New Point(163, 371)
        btnVIAlta.Name = "btnVIAlta"
        btnVIAlta.Size = New Size(91, 40)
        btnVIAlta.TabIndex = 9
        btnVIAlta.Text = "Dar Alta"
        btnVIAlta.UseVisualStyleBackColor = True
        ' 
        ' AltaVentasItems
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnVIAlta)
        Controls.Add(btnVICancelar)
        Controls.Add(txtVICantidad)
        Controls.Add(txtVIPrecioU)
        Controls.Add(txtVIIdproducto)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "AltaVentasItems"
        Text = "AltaVentasItems"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVIIdproducto As TextBox
    Friend WithEvents txtVIPrecioU As TextBox
    Friend WithEvents txtVICantidad As TextBox
    Friend WithEvents btnVICancelar As Button
    Friend WithEvents btnVIAlta As Button
End Class
