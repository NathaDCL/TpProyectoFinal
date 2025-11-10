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
        btnVLobby = New Button()
        Panel1 = New Panel()
        Label9 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnVAlta
        ' 
        btnVAlta.BackColor = Color.SteelBlue
        btnVAlta.FlatStyle = FlatStyle.Popup
        btnVAlta.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnVAlta.Location = New Point(167, 245)
        btnVAlta.Name = "btnVAlta"
        btnVAlta.Size = New Size(132, 45)
        btnVAlta.TabIndex = 0
        btnVAlta.Text = "Alta"
        btnVAlta.UseVisualStyleBackColor = False
        ' 
        ' btnVHistorial
        ' 
        btnVHistorial.BackColor = Color.SteelBlue
        btnVHistorial.FlatStyle = FlatStyle.Popup
        btnVHistorial.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnVHistorial.Location = New Point(485, 245)
        btnVHistorial.Name = "btnVHistorial"
        btnVHistorial.Size = New Size(132, 45)
        btnVHistorial.TabIndex = 1
        btnVHistorial.Text = "Historial"
        btnVHistorial.UseVisualStyleBackColor = False
        ' 
        ' btnVLobby
        ' 
        btnVLobby.BackColor = Color.SteelBlue
        btnVLobby.FlatStyle = FlatStyle.Popup
        btnVLobby.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnVLobby.Location = New Point(325, 365)
        btnVLobby.Name = "btnVLobby"
        btnVLobby.Size = New Size(145, 43)
        btnVLobby.TabIndex = 12
        btnVLobby.Text = "Lobby"
        btnVLobby.UseVisualStyleBackColor = False
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
        Panel1.TabIndex = 38
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Peru
        Label9.Location = New Point(34, 21)
        Label9.Name = "Label9"
        Label9.Size = New Size(242, 32)
        Label9.TabIndex = 36
        Label9.Text = "Seccion Ventas"
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Wide Latin", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(285, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(206, 29)
        Label1.TabIndex = 39
        Label1.Text = "Opciones"
        ' 
        ' SeccionVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(btnVLobby)
        Controls.Add(btnVHistorial)
        Controls.Add(btnVAlta)
        Name = "SeccionVentas"
        Text = "SeccionVentas"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnVAlta As Button
    Friend WithEvents btnVHistorial As Button
    Friend WithEvents btnVLobby As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
