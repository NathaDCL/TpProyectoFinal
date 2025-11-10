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
        btnCTotal = New Button()
        rbCAsc = New RadioButton()
        rbCDsc = New RadioButton()
        Panel1 = New Panel()
        Label9 = New Label()
        Label3 = New Label()
        CType(dgvMClientes, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCAlta
        ' 
        btnCAlta.BackColor = Color.SteelBlue
        btnCAlta.FlatStyle = FlatStyle.Popup
        btnCAlta.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnCAlta.Location = New Point(97, 322)
        btnCAlta.Name = "btnCAlta"
        btnCAlta.Size = New Size(125, 54)
        btnCAlta.TabIndex = 0
        btnCAlta.Text = "Alta"
        btnCAlta.UseVisualStyleBackColor = False
        ' 
        ' btnCBaja
        ' 
        btnCBaja.BackColor = Color.SteelBlue
        btnCBaja.FlatStyle = FlatStyle.Popup
        btnCBaja.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnCBaja.Location = New Point(244, 322)
        btnCBaja.Name = "btnCBaja"
        btnCBaja.Size = New Size(125, 54)
        btnCBaja.TabIndex = 1
        btnCBaja.Text = "Desactivar o activar"
        btnCBaja.UseVisualStyleBackColor = False
        ' 
        ' btnCModif
        ' 
        btnCModif.BackColor = Color.SteelBlue
        btnCModif.FlatStyle = FlatStyle.Popup
        btnCModif.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnCModif.Location = New Point(396, 322)
        btnCModif.Name = "btnCModif"
        btnCModif.Size = New Size(135, 54)
        btnCModif.TabIndex = 2
        btnCModif.Text = "Modificacion"
        btnCModif.UseVisualStyleBackColor = False
        ' 
        ' dgvMClientes
        ' 
        dgvMClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMClientes.Location = New Point(125, 85)
        dgvMClientes.Name = "dgvMClientes"
        dgvMClientes.Size = New Size(541, 214)
        dgvMClientes.TabIndex = 4
        ' 
        ' btnCRefrescar
        ' 
        btnCRefrescar.BackColor = Color.SteelBlue
        btnCRefrescar.FlatStyle = FlatStyle.Popup
        btnCRefrescar.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnCRefrescar.Location = New Point(548, 322)
        btnCRefrescar.Name = "btnCRefrescar"
        btnCRefrescar.Size = New Size(135, 54)
        btnCRefrescar.TabIndex = 5
        btnCRefrescar.Text = "Refrescar"
        btnCRefrescar.UseVisualStyleBackColor = False
        ' 
        ' btnCLobby
        ' 
        btnCLobby.BackColor = Color.SteelBlue
        btnCLobby.FlatStyle = FlatStyle.Popup
        btnCLobby.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnCLobby.Location = New Point(303, 385)
        btnCLobby.Name = "btnCLobby"
        btnCLobby.Size = New Size(165, 43)
        btnCLobby.TabIndex = 6
        btnCLobby.Text = "Lobby"
        btnCLobby.UseVisualStyleBackColor = False
        ' 
        ' btnCTotal
        ' 
        btnCTotal.BackColor = Color.SteelBlue
        btnCTotal.FlatStyle = FlatStyle.Popup
        btnCTotal.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnCTotal.Location = New Point(8, 173)
        btnCTotal.Name = "btnCTotal"
        btnCTotal.Size = New Size(111, 57)
        btnCTotal.TabIndex = 8
        btnCTotal.Text = "Busqueda > total"
        btnCTotal.UseVisualStyleBackColor = False
        ' 
        ' rbCAsc
        ' 
        rbCAsc.AutoSize = True
        rbCAsc.Font = New Font("Ravie", 9F)
        rbCAsc.Location = New Point(670, 173)
        rbCAsc.Name = "rbCAsc"
        rbCAsc.Size = New Size(118, 21)
        rbCAsc.TabIndex = 9
        rbCAsc.TabStop = True
        rbCAsc.Text = "Ascendente"
        rbCAsc.UseVisualStyleBackColor = True
        ' 
        ' rbCDsc
        ' 
        rbCDsc.AutoSize = True
        rbCDsc.Font = New Font("Ravie", 9F)
        rbCDsc.Location = New Point(670, 212)
        rbCDsc.Name = "rbCDsc"
        rbCDsc.Size = New Size(132, 21)
        rbCDsc.TabIndex = 10
        rbCDsc.TabStop = True
        rbCDsc.Text = "Descendiente"
        rbCDsc.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label3)
        Panel1.Font = New Font("Elephant", 8.999999F)
        Panel1.Location = New Point(1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(802, 79)
        Panel1.TabIndex = 36
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Peru
        Label9.Location = New Point(34, 21)
        Label9.Name = "Label9"
        Label9.Size = New Size(268, 32)
        Label9.TabIndex = 36
        Label9.Text = "Seccion Clientes"
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
        ' SeccionClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(rbCDsc)
        Controls.Add(rbCAsc)
        Controls.Add(btnCTotal)
        Controls.Add(btnCLobby)
        Controls.Add(btnCRefrescar)
        Controls.Add(dgvMClientes)
        Controls.Add(btnCModif)
        Controls.Add(btnCBaja)
        Controls.Add(btnCAlta)
        Name = "SeccionClientes"
        Text = "SeccionClientes"
        CType(dgvMClientes, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCAlta As Button
    Friend WithEvents btnCBaja As Button
    Friend WithEvents btnCModif As Button
    Friend WithEvents dgvMClientes As DataGridView
    Friend WithEvents btnCRefrescar As Button
    Friend WithEvents btnCLobby As Button
    Friend WithEvents btnCTotal As Button
    Friend WithEvents rbCAsc As RadioButton
    Friend WithEvents rbCDsc As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
End Class
