<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeccionVentas
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
        btnVAlta = New Button()
        btnVHistorial = New Button()
        btnVFechas = New Button()
        btnVLobby = New Button()
        SuspendLayout()
        ' 
        ' btnVAlta
        ' 
        btnVAlta.Location = New Point(86, 222)
        btnVAlta.Name = "btnVAlta"
        btnVAlta.Size = New Size(107, 45)
        btnVAlta.TabIndex = 0
        btnVAlta.Text = "Alta"
        btnVAlta.UseVisualStyleBackColor = True
        ' 
        ' btnVHistorial
        ' 
        btnVHistorial.Location = New Point(321, 222)
        btnVHistorial.Name = "btnVHistorial"
        btnVHistorial.Size = New Size(107, 45)
        btnVHistorial.TabIndex = 1
        btnVHistorial.Text = "Historial"
        btnVHistorial.UseVisualStyleBackColor = True
        ' 
        ' btnVFechas
        ' 
        btnVFechas.Location = New Point(590, 222)
        btnVFechas.Name = "btnVFechas"
        btnVFechas.Size = New Size(107, 45)
        btnVFechas.TabIndex = 2
        btnVFechas.Text = "Búsqueda entre fechas"
        btnVFechas.UseVisualStyleBackColor = True
        ' 
        ' btnVLobby
        ' 
        btnVLobby.Location = New Point(321, 366)
        btnVLobby.Name = "btnVLobby"
        btnVLobby.Size = New Size(120, 43)
        btnVLobby.TabIndex = 12
        btnVLobby.Text = "Lobby"
        btnVLobby.UseVisualStyleBackColor = True
        ' 
        ' SeccionVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnVLobby)
        Controls.Add(btnVFechas)
        Controls.Add(btnVHistorial)
        Controls.Add(btnVAlta)
        Name = "SeccionVentas"
        Text = "SeccionVentas"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnVAlta As Button
    Friend WithEvents btnVHistorial As Button
    Friend WithEvents btnVFechas As Button
    Friend WithEvents btnVLobby As Button
End Class
