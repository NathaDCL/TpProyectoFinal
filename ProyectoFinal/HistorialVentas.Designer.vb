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
        CType(dgvMVentas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnVFechas
        ' 
        btnVFechas.Location = New Point(324, 376)
        btnVFechas.Name = "btnVFechas"
        btnVFechas.Size = New Size(107, 45)
        btnVFechas.TabIndex = 3
        btnVFechas.Text = "Búsqueda entre fechas"
        btnVFechas.UseVisualStyleBackColor = True
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
        btnHVCancelar.Location = New Point(634, 385)
        btnHVCancelar.Name = "btnHVCancelar"
        btnHVCancelar.Size = New Size(80, 36)
        btnHVCancelar.TabIndex = 14
        btnHVCancelar.Text = "Salir"
        btnHVCancelar.UseVisualStyleBackColor = True
        ' 
        ' txtHVFechauno
        ' 
        txtHVFechauno.Location = New Point(204, 317)
        txtHVFechauno.Name = "txtHVFechauno"
        txtHVFechauno.Size = New Size(100, 23)
        txtHVFechauno.TabIndex = 15
        ' 
        ' txtHVFechados
        ' 
        txtHVFechados.Location = New Point(567, 317)
        txtHVFechados.Name = "txtHVFechados"
        txtHVFechados.Size = New Size(100, 23)
        txtHVFechados.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 320)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 15)
        Label1.TabIndex = 17
        Label1.Text = "Fecha inicio(AAAA-MM-DD)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(418, 320)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 15)
        Label2.TabIndex = 18
        Label2.Text = "Fecha fin(AAAA-MM-DD)"
        ' 
        ' btnVRefrescar
        ' 
        btnVRefrescar.Location = New Point(75, 376)
        btnVRefrescar.Name = "btnVRefrescar"
        btnVRefrescar.Size = New Size(107, 45)
        btnVRefrescar.TabIndex = 19
        btnVRefrescar.Text = "Refrescar"
        btnVRefrescar.UseVisualStyleBackColor = True
        ' 
        ' HistorialVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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
End Class
