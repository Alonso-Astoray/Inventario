<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMarcas
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalMarcas = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvMarcas = New System.Windows.Forms.DataGridView()
        Me.IdDepartamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtDescripcionM = New System.Windows.Forms.TextBox()
        Me.txtNombreM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTotalMarcas)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvMarcas)
        Me.Panel1.Location = New System.Drawing.Point(45, 172)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(525, 249)
        Me.Panel1.TabIndex = 33
        '
        'lblTotalMarcas
        '
        Me.lblTotalMarcas.AutoSize = True
        Me.lblTotalMarcas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMarcas.Location = New System.Drawing.Point(122, 227)
        Me.lblTotalMarcas.Name = "lblTotalMarcas"
        Me.lblTotalMarcas.Size = New System.Drawing.Size(43, 16)
        Me.lblTotalMarcas.TabIndex = 4
        Me.lblTotalMarcas.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Usuarios Registrados:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(200, 15)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(312, 20)
        Me.txtBuscar.TabIndex = 1
        '
        'dgvMarcas
        '
        Me.dgvMarcas.AllowUserToAddRows = False
        Me.dgvMarcas.AllowUserToDeleteRows = False
        Me.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMarcas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDepartamento, Me.NombreD, Me.DescripcionD})
        Me.dgvMarcas.Location = New System.Drawing.Point(18, 48)
        Me.dgvMarcas.Name = "dgvMarcas"
        Me.dgvMarcas.ReadOnly = True
        Me.dgvMarcas.RowHeadersVisible = False
        Me.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMarcas.Size = New System.Drawing.Size(505, 169)
        Me.dgvMarcas.TabIndex = 0
        '
        'IdDepartamento
        '
        Me.IdDepartamento.DataPropertyName = "IdDepartamento"
        Me.IdDepartamento.HeaderText = "ID"
        Me.IdDepartamento.Name = "IdDepartamento"
        Me.IdDepartamento.ReadOnly = True
        Me.IdDepartamento.Visible = False
        '
        'NombreD
        '
        Me.NombreD.DataPropertyName = "NombreD"
        Me.NombreD.HeaderText = "NOMBRE DEPARTAMENTO"
        Me.NombreD.Name = "NombreD"
        Me.NombreD.ReadOnly = True
        Me.NombreD.Width = 200
        '
        'DescripcionD
        '
        Me.DescripcionD.DataPropertyName = "DescripcionD"
        Me.DescripcionD.HeaderText = "DESCRIPCION"
        Me.DescripcionD.Name = "DescripcionD"
        Me.DescripcionD.ReadOnly = True
        Me.DescripcionD.Width = 302
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(414, 124)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 42)
        Me.btnBuscar.TabIndex = 32
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(495, 124)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 42)
        Me.btnCancelar.TabIndex = 31
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(495, 76)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 42)
        Me.btnEliminar.TabIndex = 30
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(414, 76)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 42)
        Me.btnEditar.TabIndex = 29
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(495, 28)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 42)
        Me.btnGuardar.TabIndex = 28
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(414, 28)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 42)
        Me.btnNuevo.TabIndex = 27
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(33, 6)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(35, 20)
        Me.txtId.TabIndex = 26
        Me.txtId.Visible = False
        '
        'txtDescripcionM
        '
        Me.txtDescripcionM.Location = New System.Drawing.Point(110, 63)
        Me.txtDescripcionM.Multiline = True
        Me.txtDescripcionM.Name = "txtDescripcionM"
        Me.txtDescripcionM.Size = New System.Drawing.Size(261, 78)
        Me.txtDescripcionM.TabIndex = 25
        '
        'txtNombreM
        '
        Me.txtNombreM.Location = New System.Drawing.Point(110, 28)
        Me.txtNombreM.Name = "txtNombreM"
        Me.txtNombreM.Size = New System.Drawing.Size(261, 20)
        Me.txtNombreM.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Nombre de Marca"
        '
        'frmMarcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtDescripcionM)
        Me.Controls.Add(Me.txtNombreM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMarcas"
        Me.Text = "frmMarcas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvMarcas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotalMarcas As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvMarcas As DataGridView
    Friend WithEvents IdDepartamento As DataGridViewTextBoxColumn
    Friend WithEvents NombreD As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionD As DataGridViewTextBoxColumn
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtDescripcionM As TextBox
    Friend WithEvents txtNombreM As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
