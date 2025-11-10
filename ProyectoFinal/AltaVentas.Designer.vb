<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaVentas
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
        txtVIdCliente = New TextBox()
        txtVFecha = New TextBox()
        btnAVCrear = New Button()
        btnAVCancelar = New Button()
        Panel1 = New Panel()
        Label9 = New Label()
        Label4 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Gray
        Label1.Font = New Font("Elephant", 11.9999981F)
        Label1.Location = New Point(36, 210)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 21)
        Label1.TabIndex = 0
        Label1.Text = "IdCliente"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Gray
        Label2.Font = New Font("Elephant", 11.9999981F)
        Label2.Location = New Point(36, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(193, 21)
        Label2.TabIndex = 1
        Label2.Text = "Fecha(AAAA-MM-DD)"
        ' 
        ' txtVIdCliente
        ' 
        txtVIdCliente.Font = New Font("Elephant", 8.999999F)
        txtVIdCliente.Location = New Point(247, 210)
        txtVIdCliente.Name = "txtVIdCliente"
        txtVIdCliente.Size = New Size(159, 23)
        txtVIdCliente.TabIndex = 2
        ' 
        ' txtVFecha
        ' 
        txtVFecha.Font = New Font("Elephant", 8.999999F)
        txtVFecha.Location = New Point(247, 140)
        txtVFecha.Name = "txtVFecha"
        txtVFecha.Size = New Size(159, 23)
        txtVFecha.TabIndex = 3
        ' 
        ' btnAVCrear
        ' 
        btnAVCrear.BackColor = Color.SteelBlue
        btnAVCrear.FlatStyle = FlatStyle.Popup
        btnAVCrear.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnAVCrear.Location = New Point(152, 315)
        btnAVCrear.Name = "btnAVCrear"
        btnAVCrear.Size = New Size(134, 43)
        btnAVCrear.TabIndex = 4
        btnAVCrear.Text = "Crear Venta"
        btnAVCrear.UseVisualStyleBackColor = False
        ' 
        ' btnAVCancelar
        ' 
        btnAVCancelar.BackColor = Color.SteelBlue
        btnAVCancelar.FlatStyle = FlatStyle.Popup
        btnAVCancelar.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnAVCancelar.Location = New Point(584, 390)
        btnAVCancelar.Name = "btnAVCancelar"
        btnAVCancelar.Size = New Size(134, 32)
        btnAVCancelar.TabIndex = 16
        btnAVCancelar.Text = "Cancelar"
        btnAVCancelar.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label4)
        Panel1.Font = New Font("Elephant", 8.999999F)
        Panel1.Location = New Point(1, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(802, 81)
        Panel1.TabIndex = 39
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Peru
        Label9.Location = New Point(34, 21)
        Label9.Name = "Label9"
        Label9.Size = New Size(194, 32)
        Label9.TabIndex = 36
        Label9.Text = "Alta Ventas"
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
        ' AltaVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(btnAVCancelar)
        Controls.Add(btnAVCrear)
        Controls.Add(txtVFecha)
        Controls.Add(txtVIdCliente)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AltaVentas"
        Text = "AltaVentas"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtVIdCliente As TextBox
    Friend WithEvents txtVFecha As TextBox
    Friend WithEvents btnAVCrear As Button
    Friend WithEvents btnAVCancelar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
End Class
