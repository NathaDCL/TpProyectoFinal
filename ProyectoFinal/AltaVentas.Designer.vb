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
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(163, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 0
        Label1.Text = "IdCliente"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(163, 200)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 15)
        Label2.TabIndex = 1
        Label2.Text = "Fecha(AAAA-MM-DD)"
        ' 
        ' txtVIdCliente
        ' 
        txtVIdCliente.Location = New Point(241, 96)
        txtVIdCliente.Name = "txtVIdCliente"
        txtVIdCliente.Size = New Size(100, 23)
        txtVIdCliente.TabIndex = 2
        ' 
        ' txtVFecha
        ' 
        txtVFecha.Location = New Point(304, 197)
        txtVFecha.Name = "txtVFecha"
        txtVFecha.Size = New Size(100, 23)
        txtVFecha.TabIndex = 3
        ' 
        ' btnAVCrear
        ' 
        btnAVCrear.Location = New Point(217, 333)
        btnAVCrear.Name = "btnAVCrear"
        btnAVCrear.Size = New Size(93, 43)
        btnAVCrear.TabIndex = 4
        btnAVCrear.Text = "Crear Venta"
        btnAVCrear.UseVisualStyleBackColor = True
        ' 
        ' btnAVCancelar
        ' 
        btnAVCancelar.Location = New Point(598, 357)
        btnAVCancelar.Name = "btnAVCancelar"
        btnAVCancelar.Size = New Size(83, 32)
        btnAVCancelar.TabIndex = 16
        btnAVCancelar.Text = "Cancelar"
        btnAVCancelar.UseVisualStyleBackColor = True
        ' 
        ' AltaVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnAVCancelar)
        Controls.Add(btnAVCrear)
        Controls.Add(txtVFecha)
        Controls.Add(txtVIdCliente)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AltaVentas"
        Text = "AltaVentas"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtVIdCliente As TextBox
    Friend WithEvents txtVFecha As TextBox
    Friend WithEvents btnAVCrear As Button
    Friend WithEvents btnAVCancelar As Button
End Class
