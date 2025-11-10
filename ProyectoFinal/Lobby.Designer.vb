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
        btnLProductos = New Button()
        btnLVentas = New Button()
        Panel1 = New Panel()
        Label9 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnLClientes
        ' 
        btnLClientes.BackColor = Color.SteelBlue
        btnLClientes.FlatStyle = FlatStyle.Popup
        btnLClientes.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnLClientes.Location = New Point(115, 218)
        btnLClientes.Name = "btnLClientes"
        btnLClientes.Size = New Size(111, 53)
        btnLClientes.TabIndex = 0
        btnLClientes.Text = "Clientes"
        btnLClientes.UseVisualStyleBackColor = False
        ' 
        ' btnLProductos
        ' 
        btnLProductos.BackColor = Color.SteelBlue
        btnLProductos.FlatStyle = FlatStyle.Popup
        btnLProductos.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnLProductos.Location = New Point(332, 218)
        btnLProductos.Name = "btnLProductos"
        btnLProductos.Size = New Size(111, 53)
        btnLProductos.TabIndex = 1
        btnLProductos.Text = "Productos"
        btnLProductos.UseVisualStyleBackColor = False
        ' 
        ' btnLVentas
        ' 
        btnLVentas.BackColor = Color.SteelBlue
        btnLVentas.FlatStyle = FlatStyle.Popup
        btnLVentas.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnLVentas.Location = New Point(556, 218)
        btnLVentas.Name = "btnLVentas"
        btnLVentas.Size = New Size(116, 53)
        btnLVentas.TabIndex = 2
        btnLVentas.Text = "Ventas"
        btnLVentas.UseVisualStyleBackColor = False
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
        Panel1.TabIndex = 35
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Peru
        Label9.Location = New Point(57, 21)
        Label9.Name = "Label9"
        Label9.Size = New Size(102, 32)
        Label9.TabIndex = 36
        Label9.Text = "Lobby"
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
        Label1.Location = New Point(278, 111)
        Label1.Name = "Label1"
        Label1.Size = New Size(222, 29)
        Label1.TabIndex = 36
        Label1.Text = "Secciones"
        ' 
        ' Lobby
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(btnLVentas)
        Controls.Add(btnLProductos)
        Controls.Add(btnLClientes)
        Name = "Lobby"
        Text = "Lobby"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLClientes As Button
    Friend WithEvents btnLProductos As Button
    Friend WithEvents btnLVentas As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
