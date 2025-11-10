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
        btnPCategoria = New Button()
        btnPBCliente = New Button()
        Panel1 = New Panel()
        Label9 = New Label()
        Label3 = New Label()
        CType(dgvMProductos, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnPLobby
        ' 
        btnPLobby.BackColor = Color.SteelBlue
        btnPLobby.FlatStyle = FlatStyle.Popup
        btnPLobby.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnPLobby.Location = New Point(315, 389)
        btnPLobby.Name = "btnPLobby"
        btnPLobby.Size = New Size(163, 43)
        btnPLobby.TabIndex = 11
        btnPLobby.Text = "Lobby"
        btnPLobby.UseVisualStyleBackColor = False
        ' 
        ' btnPRefrescar
        ' 
        btnPRefrescar.BackColor = Color.SteelBlue
        btnPRefrescar.FlatStyle = FlatStyle.Popup
        btnPRefrescar.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnPRefrescar.Location = New Point(561, 319)
        btnPRefrescar.Name = "btnPRefrescar"
        btnPRefrescar.Size = New Size(133, 54)
        btnPRefrescar.TabIndex = 10
        btnPRefrescar.Text = "Refrescar"
        btnPRefrescar.UseVisualStyleBackColor = False
        ' 
        ' btnPModif
        ' 
        btnPModif.BackColor = Color.SteelBlue
        btnPModif.FlatStyle = FlatStyle.Popup
        btnPModif.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnPModif.Location = New Point(409, 319)
        btnPModif.Name = "btnPModif"
        btnPModif.Size = New Size(133, 54)
        btnPModif.TabIndex = 9
        btnPModif.Text = "Modificacion"
        btnPModif.UseVisualStyleBackColor = False
        ' 
        ' btnPBaja
        ' 
        btnPBaja.BackColor = Color.SteelBlue
        btnPBaja.FlatStyle = FlatStyle.Popup
        btnPBaja.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnPBaja.Location = New Point(257, 319)
        btnPBaja.Name = "btnPBaja"
        btnPBaja.Size = New Size(123, 54)
        btnPBaja.TabIndex = 8
        btnPBaja.Text = "Desactivar o activar"
        btnPBaja.UseVisualStyleBackColor = False
        ' 
        ' btnPAlta
        ' 
        btnPAlta.BackColor = Color.SteelBlue
        btnPAlta.FlatStyle = FlatStyle.Popup
        btnPAlta.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnPAlta.Location = New Point(110, 319)
        btnPAlta.Name = "btnPAlta"
        btnPAlta.Size = New Size(123, 54)
        btnPAlta.TabIndex = 7
        btnPAlta.Text = "Alta"
        btnPAlta.UseVisualStyleBackColor = False
        ' 
        ' dgvMProductos
        ' 
        dgvMProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMProductos.Location = New Point(130, 85)
        dgvMProductos.Name = "dgvMProductos"
        dgvMProductos.Size = New Size(537, 214)
        dgvMProductos.TabIndex = 12
        ' 
        ' btnPCategoria
        ' 
        btnPCategoria.BackColor = Color.SteelBlue
        btnPCategoria.FlatStyle = FlatStyle.Popup
        btnPCategoria.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnPCategoria.Location = New Point(682, 163)
        btnPCategoria.Name = "btnPCategoria"
        btnPCategoria.Size = New Size(106, 77)
        btnPCategoria.TabIndex = 13
        btnPCategoria.Text = "Busqueda por categoria"
        btnPCategoria.UseVisualStyleBackColor = False
        ' 
        ' btnPBCliente
        ' 
        btnPBCliente.BackColor = Color.SteelBlue
        btnPBCliente.FlatStyle = FlatStyle.Popup
        btnPBCliente.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnPBCliente.Location = New Point(10, 163)
        btnPBCliente.Name = "btnPBCliente"
        btnPBCliente.Size = New Size(106, 77)
        btnPBCliente.TabIndex = 14
        btnPBCliente.Text = "Busqueda por cliente"
        btnPBCliente.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label3)
        Panel1.Font = New Font("Elephant", 8.999999F)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(802, 79)
        Panel1.TabIndex = 37
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Peru
        Label9.Location = New Point(34, 21)
        Label9.Name = "Label9"
        Label9.Size = New Size(300, 32)
        Label9.TabIndex = 36
        Label9.Text = "Seccion Productos"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Impact", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.MenuHighlight
        Label3.ImeMode = ImeMode.NoControl
        Label3.Location = New Point(583, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(162, 39)
        Label3.TabIndex = 27
        Label3.Text = "AdminMAX"
        ' 
        ' SeccionProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(btnPBCliente)
        Controls.Add(btnPCategoria)
        Controls.Add(dgvMProductos)
        Controls.Add(btnPLobby)
        Controls.Add(btnPRefrescar)
        Controls.Add(btnPModif)
        Controls.Add(btnPBaja)
        Controls.Add(btnPAlta)
        Name = "SeccionProductos"
        Text = "SeccionProductos"
        CType(dgvMProductos, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnPLobby As Button
    Friend WithEvents btnPRefrescar As Button
    Friend WithEvents btnPModif As Button
    Friend WithEvents btnPBaja As Button
    Friend WithEvents btnPAlta As Button
    Friend WithEvents dgvMProductos As DataGridView
    Friend WithEvents btnPCategoria As Button
    Friend WithEvents btnPBCliente As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
End Class
