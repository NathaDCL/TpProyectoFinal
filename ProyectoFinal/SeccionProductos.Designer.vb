<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeccionProductos
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
        btnPLobby = New Button()
        btnPRefrescar = New Button()
        btnPModif = New Button()
        btnPBaja = New Button()
        btnPAlta = New Button()
        dgvMProductos = New DataGridView()
        CType(dgvMProductos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnPLobby
        ' 
        btnPLobby.Location = New Point(327, 374)
        btnPLobby.Name = "btnPLobby"
        btnPLobby.Size = New Size(120, 43)
        btnPLobby.TabIndex = 11
        btnPLobby.Text = "Lobby"
        btnPLobby.UseVisualStyleBackColor = True
        ' 
        ' btnPRefrescar
        ' 
        btnPRefrescar.Location = New Point(572, 278)
        btnPRefrescar.Name = "btnPRefrescar"
        btnPRefrescar.Size = New Size(90, 54)
        btnPRefrescar.TabIndex = 10
        btnPRefrescar.Text = "Refrescar"
        btnPRefrescar.UseVisualStyleBackColor = True
        ' 
        ' btnPModif
        ' 
        btnPModif.Location = New Point(420, 278)
        btnPModif.Name = "btnPModif"
        btnPModif.Size = New Size(90, 54)
        btnPModif.TabIndex = 9
        btnPModif.Text = "Modificacion"
        btnPModif.UseVisualStyleBackColor = True
        ' 
        ' btnPBaja
        ' 
        btnPBaja.Location = New Point(268, 278)
        btnPBaja.Name = "btnPBaja"
        btnPBaja.Size = New Size(80, 54)
        btnPBaja.TabIndex = 8
        btnPBaja.Text = "Desactivar o activar"
        btnPBaja.UseVisualStyleBackColor = True
        ' 
        ' btnPAlta
        ' 
        btnPAlta.Location = New Point(121, 278)
        btnPAlta.Name = "btnPAlta"
        btnPAlta.Size = New Size(80, 54)
        btnPAlta.TabIndex = 7
        btnPAlta.Text = "Alta"
        btnPAlta.UseVisualStyleBackColor = True
        ' 
        ' dgvMProductos
        ' 
        dgvMProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMProductos.Location = New Point(121, 35)
        dgvMProductos.Name = "dgvMProductos"
        dgvMProductos.Size = New Size(541, 214)
        dgvMProductos.TabIndex = 12
        ' 
        ' SeccionProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvMProductos)
        Controls.Add(btnPLobby)
        Controls.Add(btnPRefrescar)
        Controls.Add(btnPModif)
        Controls.Add(btnPBaja)
        Controls.Add(btnPAlta)
        Name = "SeccionProductos"
        Text = "SeccionProductos"
        CType(dgvMProductos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnPLobby As Button
    Friend WithEvents btnPRefrescar As Button
    Friend WithEvents btnPModif As Button
    Friend WithEvents btnPBaja As Button
    Friend WithEvents btnPAlta As Button
    Friend WithEvents dgvMProductos As DataGridView
End Class
