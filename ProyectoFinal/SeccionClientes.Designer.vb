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
        dgvMClientes = New DataGridView()
        btnCRefrescar = New Button()
        btnCLobby = New Button()
        CType(dgvMClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCAlta
        ' 
        btnCAlta.Location = New Point(118, 289)
        btnCAlta.Name = "btnCAlta"
        btnCAlta.Size = New Size(80, 54)
        btnCAlta.TabIndex = 0
        btnCAlta.Text = "Alta"
        btnCAlta.UseVisualStyleBackColor = True
        ' 
        ' btnCBaja
        ' 
        btnCBaja.Location = New Point(265, 289)
        btnCBaja.Name = "btnCBaja"
        btnCBaja.Size = New Size(80, 54)
        btnCBaja.TabIndex = 1
        btnCBaja.Text = "Desactivar o activar"
        btnCBaja.UseVisualStyleBackColor = True
        ' 
        ' btnCModif
        ' 
        btnCModif.Location = New Point(417, 289)
        btnCModif.Name = "btnCModif"
        btnCModif.Size = New Size(90, 54)
        btnCModif.TabIndex = 2
        btnCModif.Text = "Modificacion"
        btnCModif.UseVisualStyleBackColor = True
        ' 
        ' dgvMClientes
        ' 
        dgvMClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMClientes.Location = New Point(118, 50)
        dgvMClientes.Name = "dgvMClientes"
        dgvMClientes.Size = New Size(541, 214)
        dgvMClientes.TabIndex = 4
        ' 
        ' btnCRefrescar
        ' 
        btnCRefrescar.Location = New Point(569, 289)
        btnCRefrescar.Name = "btnCRefrescar"
        btnCRefrescar.Size = New Size(90, 54)
        btnCRefrescar.TabIndex = 5
        btnCRefrescar.Text = "Refrescar"
        btnCRefrescar.UseVisualStyleBackColor = True
        ' 
        ' btnCLobby
        ' 
        btnCLobby.Location = New Point(324, 385)
        btnCLobby.Name = "btnCLobby"
        btnCLobby.Size = New Size(120, 43)
        btnCLobby.TabIndex = 6
        btnCLobby.Text = "Lobby"
        btnCLobby.UseVisualStyleBackColor = True
        ' 
        ' SeccionClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCLobby)
        Controls.Add(btnCRefrescar)
        Controls.Add(dgvMClientes)
        Controls.Add(btnCModif)
        Controls.Add(btnCBaja)
        Controls.Add(btnCAlta)
        Name = "SeccionClientes"
        Text = "SeccionClientes"
        CType(dgvMClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnCAlta As Button
    Friend WithEvents btnCBaja As Button
    Friend WithEvents btnCModif As Button
    Friend WithEvents dgvMClientes As DataGridView
    Friend WithEvents btnCRefrescar As Button
    Friend WithEvents btnCLobby As Button
End Class
