<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeccionClientes
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
        btnCAlta = New Button()
        btnCBaja = New Button()
        btnCModif = New Button()
        SuspendLayout()
        ' 
        ' btnCAlta
        ' 
        btnCAlta.Location = New Point(105, 183)
        btnCAlta.Name = "btnCAlta"
        btnCAlta.Size = New Size(80, 54)
        btnCAlta.TabIndex = 0
        btnCAlta.Text = "Alta"
        btnCAlta.UseVisualStyleBackColor = True
        ' 
        ' btnCBaja
        ' 
        btnCBaja.Location = New Point(312, 183)
        btnCBaja.Name = "btnCBaja"
        btnCBaja.Size = New Size(80, 54)
        btnCBaja.TabIndex = 1
        btnCBaja.Text = "Baja"
        btnCBaja.UseVisualStyleBackColor = True
        ' 
        ' btnCModif
        ' 
        btnCModif.Location = New Point(553, 183)
        btnCModif.Name = "btnCModif"
        btnCModif.Size = New Size(90, 54)
        btnCModif.TabIndex = 2
        btnCModif.Text = "Modificacion"
        btnCModif.UseVisualStyleBackColor = True
        ' 
        ' SeccionClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCModif)
        Controls.Add(btnCBaja)
        Controls.Add(btnCAlta)
        Name = "SeccionClientes"
        Text = "SeccionClientes"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnCAlta As Button
    Friend WithEvents btnCBaja As Button
    Friend WithEvents btnCModif As Button
End Class
