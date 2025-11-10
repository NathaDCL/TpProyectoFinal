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
        Label4 = New Label()
        txtVIIdproducto = New TextBox()
        txtVICantidad = New TextBox()
        btnVICancelar = New Button()
        btnVIAlta = New Button()
        Panel1 = New Panel()
        Label9 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Elephant", 11.9999981F)
        Label2.Location = New Point(44, 144)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 21)
        Label2.TabIndex = 1
        Label2.Text = "IdProducto"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Elephant", 11.9999981F)
        Label4.Location = New Point(44, 227)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 21)
        Label4.TabIndex = 3
        Label4.Text = "Cantidad"
        ' 
        ' txtVIIdproducto
        ' 
        txtVIIdproducto.Font = New Font("Elephant", 8.999999F)
        txtVIIdproducto.Location = New Point(166, 142)
        txtVIIdproducto.Name = "txtVIIdproducto"
        txtVIIdproducto.Size = New Size(143, 23)
        txtVIIdproducto.TabIndex = 5
        ' 
        ' txtVICantidad
        ' 
        txtVICantidad.Font = New Font("Elephant", 8.999999F)
        txtVICantidad.Location = New Point(166, 225)
        txtVICantidad.Name = "txtVICantidad"
        txtVICantidad.Size = New Size(143, 23)
        txtVICantidad.TabIndex = 7
        ' 
        ' btnVICancelar
        ' 
        btnVICancelar.BackColor = Color.SteelBlue
        btnVICancelar.FlatStyle = FlatStyle.Popup
        btnVICancelar.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnVICancelar.Location = New Point(605, 390)
        btnVICancelar.Name = "btnVICancelar"
        btnVICancelar.Size = New Size(119, 36)
        btnVICancelar.TabIndex = 8
        btnVICancelar.Text = "Salir"
        btnVICancelar.UseVisualStyleBackColor = False
        ' 
        ' btnVIAlta
        ' 
        btnVIAlta.BackColor = Color.SteelBlue
        btnVIAlta.FlatStyle = FlatStyle.Popup
        btnVIAlta.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnVIAlta.Location = New Point(114, 310)
        btnVIAlta.Name = "btnVIAlta"
        btnVIAlta.Size = New Size(130, 40)
        btnVIAlta.TabIndex = 9
        btnVIAlta.Text = "Dar Alta"
        btnVIAlta.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label1)
        Panel1.Font = New Font("Elephant", 8.999999F)
        Panel1.Location = New Point(1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(802, 73)
        Panel1.TabIndex = 40
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Peru
        Label9.Location = New Point(34, 21)
        Label9.Name = "Label9"
        Label9.Size = New Size(286, 32)
        Label9.TabIndex = 36
        Label9.Text = "Alta Ventas Items"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.MenuHighlight
        Label1.ImeMode = ImeMode.NoControl
        Label1.Location = New Point(583, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 39)
        Label1.TabIndex = 27
        Label1.Text = "AdminMAX"
        ' 
        ' AltaVentasItems
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(btnVIAlta)
        Controls.Add(btnVICancelar)
        Controls.Add(txtVICantidad)
        Controls.Add(txtVIIdproducto)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Name = "AltaVentasItems"
        Text = "AltaVentasItems"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVIIdproducto As TextBox
    Friend WithEvents txtVICantidad As TextBox
    Friend WithEvents btnVICancelar As Button
    Friend WithEvents btnVIAlta As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
End Class
