<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lobby
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
        btnLClientes = New Button()
        SuspendLayout()
        ' 
        ' btnLClientes
        ' 
        btnLClientes.Location = New Point(90, 192)
        btnLClientes.Name = "btnLClientes"
        btnLClientes.Size = New Size(105, 55)
        btnLClientes.TabIndex = 0
        btnLClientes.Text = "Clientes"
        btnLClientes.UseVisualStyleBackColor = True
        ' 
        ' Lobby
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLClientes)
        Name = "Lobby"
        Text = "Lobby"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnLClientes As Button
End Class
