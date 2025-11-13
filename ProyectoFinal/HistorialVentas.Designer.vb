<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistorialVentas
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
        btnVFechas = New Button()
        dgvMVentas = New DataGridView()
        btnHVCancelar = New Button()
        txtHVFechauno = New TextBox()
        txtHVFechados = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnVRefrescar = New Button()
        Panel1 = New Panel()
        Label9 = New Label()
        Label3 = New Label()
        btnVDetalle = New Button()
        CType(dgvMVentas, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnVFechas
        ' 
        btnVFechas.BackColor = Color.SteelBlue
        btnVFechas.FlatStyle = FlatStyle.Popup
        btnVFechas.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnVFechas.Location = New Point(317, 372)
        btnVFechas.Name = "btnVFechas"
        btnVFechas.Size = New Size(155, 62)
        btnVFechas.TabIndex = 3
        btnVFechas.Text = "Búsqueda entre fechas"
        btnVFechas.UseVisualStyleBackColor = False
        ' 
        ' dgvMVentas
        ' 
        dgvMVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMVentas.Location = New Point(161, 78)
        dgvMVentas.Name = "dgvMVentas"
        dgvMVentas.Size = New Size(444, 200)
        dgvMVentas.TabIndex = 13
        ' 
        ' btnHVCancelar
        ' 
        btnHVCancelar.BackColor = Color.SteelBlue
        btnHVCancelar.FlatStyle = FlatStyle.Popup
        btnHVCancelar.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnHVCancelar.Location = New Point(62, 381)
        btnHVCancelar.Name = "btnHVCancelar"
        btnHVCancelar.Size = New Size(149, 45)
        btnHVCancelar.TabIndex = 14
        btnHVCancelar.Text = "Salir"
        btnHVCancelar.UseVisualStyleBackColor = False
        ' 
        ' txtHVFechauno
        ' 
        txtHVFechauno.Font = New Font("Elephant", 8.999999F)
        txtHVFechauno.Location = New Point(634, 318)
        txtHVFechauno.Name = "txtHVFechauno"
        txtHVFechauno.Size = New Size(153, 23)
        txtHVFechauno.TabIndex = 15
        ' 
        ' txtHVFechados
        ' 
        txtHVFechados.Font = New Font("Elephant", 8.999999F)
        txtHVFechados.Location = New Point(249, 317)
        txtHVFechados.Name = "txtHVFechados"
        txtHVFechados.Size = New Size(153, 23)
        txtHVFechados.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Elephant", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 319)
        Label1.Name = "Label1"
        Label1.Size = New Size(240, 21)
        Label1.TabIndex = 17
        Label1.Text = "Fecha inicio(AAAA-MM-DD)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Elephant", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(418, 320)
        Label2.Name = "Label2"
        Label2.Size = New Size(218, 21)
        Label2.TabIndex = 18
        Label2.Text = "Fecha fin(AAAA-MM-DD)"
        ' 
        ' btnVRefrescar
        ' 
        btnVRefrescar.BackColor = Color.SteelBlue
        btnVRefrescar.FlatStyle = FlatStyle.Popup
        btnVRefrescar.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnVRefrescar.Location = New Point(634, 162)
        btnVRefrescar.Name = "btnVRefrescar"
        btnVRefrescar.Size = New Size(149, 45)
        btnVRefrescar.TabIndex = 19
        btnVRefrescar.Text = "Refrescar"
        btnVRefrescar.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label3)
        Panel1.Font = New Font("Elephant", 8.999999F)
        Panel1.Location = New Point(0, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(802, 73)
        Panel1.TabIndex = 41
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Peru
        Label9.Location = New Point(34, 21)
        Label9.Name = "Label9"
        Label9.Size = New Size(163, 32)
        Label9.TabIndex = 36
        Label9.Text = "Historial"
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
        ' btnVDetalle
        ' 
        btnVDetalle.BackColor = Color.SteelBlue
        btnVDetalle.FlatStyle = FlatStyle.Popup
        btnVDetalle.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold)
        btnVDetalle.Location = New Point(596, 381)
        btnVDetalle.Name = "btnVDetalle"
        btnVDetalle.Size = New Size(149, 45)
        btnVDetalle.TabIndex = 42
        btnVDetalle.Text = "Ir a detalle"
        btnVDetalle.UseVisualStyleBackColor = False
        ' 
        ' HistorialVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(800, 450)
        Controls.Add(btnVDetalle)
        Controls.Add(Panel1)
        Controls.Add(btnVRefrescar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtHVFechados)
        Controls.Add(txtHVFechauno)
        Controls.Add(btnHVCancelar)
        Controls.Add(dgvMVentas)
        Controls.Add(btnVFechas)
        Name = "HistorialVentas"
        Text = "HistorialVentas"
        CType(dgvMVentas, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnVFechas As Button
    Friend WithEvents dgvMVentas As DataGridView
    Friend WithEvents btnHVCancelar As Button
    Friend WithEvents txtHVFechauno As TextBox
    Friend WithEvents txtHVFechados As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVRefrescar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnVDetalle As Button
End Class
