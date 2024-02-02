<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargoActivos
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
        Me.DTPFechaCompra = New System.Windows.Forms.DateTimePicker()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnArticulos = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbMarca = New System.Windows.Forms.RadioButton()
        Me.rbCodigoA = New System.Windows.Forms.RadioButton()
        Me.rbNombreArticulo = New System.Windows.Forms.RadioButton()
        Me.lblTotalActivosAsignados = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvActivosAsignados = New System.Windows.Forms.DataGridView()
        Me.IdArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombreE = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtIdArticulo = New System.Windows.Forms.TextBox()
        Me.txtNombreA = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.btnEmpleadosId = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvActivosAsignados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTPFechaCompra
        '
        Me.DTPFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaCompra.Location = New System.Drawing.Point(367, 80)
        Me.DTPFechaCompra.Name = "DTPFechaCompra"
        Me.DTPFechaCompra.Size = New System.Drawing.Size(209, 20)
        Me.DTPFechaCompra.TabIndex = 83
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(92, 48)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(125, 20)
        Me.txtIdentidad.TabIndex = 82
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(270, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 13)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "Fecha de Entrega"
        '
        'btnArticulos
        '
        Me.btnArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArticulos.Location = New System.Drawing.Point(223, 19)
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Size = New System.Drawing.Size(36, 23)
        Me.btnArticulos.TabIndex = 80
        Me.btnArticulos.Text = "..."
        Me.btnArticulos.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbMarca)
        Me.Panel1.Controls.Add(Me.rbCodigoA)
        Me.Panel1.Controls.Add(Me.rbNombreArticulo)
        Me.Panel1.Controls.Add(Me.lblTotalActivosAsignados)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvActivosAsignados)
        Me.Panel1.Location = New System.Drawing.Point(26, 175)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(882, 286)
        Me.Panel1.TabIndex = 79
        '
        'rbMarca
        '
        Me.rbMarca.AutoSize = True
        Me.rbMarca.Location = New System.Drawing.Point(223, 25)
        Me.rbMarca.Name = "rbMarca"
        Me.rbMarca.Size = New System.Drawing.Size(55, 17)
        Me.rbMarca.TabIndex = 7
        Me.rbMarca.TabStop = True
        Me.rbMarca.Text = "Marca"
        Me.rbMarca.UseVisualStyleBackColor = True
        '
        'rbCodigoA
        '
        Me.rbCodigoA.AutoSize = True
        Me.rbCodigoA.Location = New System.Drawing.Point(124, 25)
        Me.rbCodigoA.Name = "rbCodigoA"
        Me.rbCodigoA.Size = New System.Drawing.Size(96, 17)
        Me.rbCodigoA.TabIndex = 6
        Me.rbCodigoA.Text = "Codigo Articulo"
        Me.rbCodigoA.UseVisualStyleBackColor = True
        '
        'rbNombreArticulo
        '
        Me.rbNombreArticulo.AutoSize = True
        Me.rbNombreArticulo.Checked = True
        Me.rbNombreArticulo.Location = New System.Drawing.Point(18, 25)
        Me.rbNombreArticulo.Name = "rbNombreArticulo"
        Me.rbNombreArticulo.Size = New System.Drawing.Size(100, 17)
        Me.rbNombreArticulo.TabIndex = 5
        Me.rbNombreArticulo.TabStop = True
        Me.rbNombreArticulo.Text = "Nombre Articulo"
        Me.rbNombreArticulo.UseVisualStyleBackColor = True
        '
        'lblTotalActivosAsignados
        '
        Me.lblTotalActivosAsignados.AutoSize = True
        Me.lblTotalActivosAsignados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalActivosAsignados.Location = New System.Drawing.Point(147, 257)
        Me.lblTotalActivosAsignados.Name = "lblTotalActivosAsignados"
        Me.lblTotalActivosAsignados.Size = New System.Drawing.Size(43, 16)
        Me.lblTotalActivosAsignados.TabIndex = 4
        Me.lblTotalActivosAsignados.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Empleados Registrados:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(321, 22)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(468, 20)
        Me.txtBuscar.TabIndex = 1
        '
        'dgvActivosAsignados
        '
        Me.dgvActivosAsignados.AllowUserToAddRows = False
        Me.dgvActivosAsignados.AllowUserToDeleteRows = False
        Me.dgvActivosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActivosAsignados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdArticulo, Me.NombreA, Me.NumeroSerie, Me.CodigoA, Me.NombreM, Me.Modelo, Me.PrecioCompra, Me.EstadoArticulo, Me.FechaCompra, Me.Descripcion})
        Me.dgvActivosAsignados.Location = New System.Drawing.Point(18, 48)
        Me.dgvActivosAsignados.Name = "dgvActivosAsignados"
        Me.dgvActivosAsignados.ReadOnly = True
        Me.dgvActivosAsignados.RowHeadersVisible = False
        Me.dgvActivosAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActivosAsignados.Size = New System.Drawing.Size(861, 206)
        Me.dgvActivosAsignados.TabIndex = 0
        '
        'IdArticulo
        '
        Me.IdArticulo.DataPropertyName = "IdArticulo"
        Me.IdArticulo.HeaderText = "ID"
        Me.IdArticulo.Name = "IdArticulo"
        Me.IdArticulo.ReadOnly = True
        Me.IdArticulo.Visible = False
        '
        'NombreA
        '
        Me.NombreA.DataPropertyName = "NombreA"
        Me.NombreA.HeaderText = "NOMBRE DEL ACTIVO"
        Me.NombreA.Name = "NombreA"
        Me.NombreA.ReadOnly = True
        Me.NombreA.Width = 146
        '
        'NumeroSerie
        '
        Me.NumeroSerie.DataPropertyName = "NumeroSerie"
        Me.NumeroSerie.HeaderText = "NUMERO DE SERIE"
        Me.NumeroSerie.Name = "NumeroSerie"
        Me.NumeroSerie.ReadOnly = True
        Me.NumeroSerie.Width = 70
        '
        'CodigoA
        '
        Me.CodigoA.DataPropertyName = "CodigoA"
        Me.CodigoA.HeaderText = "CODIGO"
        Me.CodigoA.Name = "CodigoA"
        Me.CodigoA.ReadOnly = True
        Me.CodigoA.Width = 52
        '
        'NombreM
        '
        Me.NombreM.DataPropertyName = "NombreM"
        Me.NombreM.HeaderText = "MARCA"
        Me.NombreM.Name = "NombreM"
        Me.NombreM.ReadOnly = True
        Me.NombreM.Width = 52
        '
        'Modelo
        '
        Me.Modelo.DataPropertyName = "Modelo"
        Me.Modelo.HeaderText = "MODELO"
        Me.Modelo.Name = "Modelo"
        Me.Modelo.ReadOnly = True
        Me.Modelo.Width = 60
        '
        'PrecioCompra
        '
        Me.PrecioCompra.DataPropertyName = "PrecioCompra"
        Me.PrecioCompra.HeaderText = "PRECIO DE COMPRA"
        Me.PrecioCompra.Name = "PrecioCompra"
        Me.PrecioCompra.ReadOnly = True
        Me.PrecioCompra.Width = 90
        '
        'EstadoArticulo
        '
        Me.EstadoArticulo.DataPropertyName = "EstadoArticulo"
        Me.EstadoArticulo.HeaderText = "ESTADO"
        Me.EstadoArticulo.Name = "EstadoArticulo"
        Me.EstadoArticulo.ReadOnly = True
        Me.EstadoArticulo.Visible = False
        Me.EstadoArticulo.Width = 180
        '
        'FechaCompra
        '
        Me.FechaCompra.DataPropertyName = "FechaCompra"
        Me.FechaCompra.HeaderText = "FECHA DE COMPRA"
        Me.FechaCompra.Name = "FechaCompra"
        Me.FechaCompra.ReadOnly = True
        Me.FechaCompra.Width = 66
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "DESCRIPCION"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 232
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(833, 108)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 42)
        Me.btnBuscar.TabIndex = 78
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(914, 108)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 42)
        Me.btnCancelar.TabIndex = 77
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(914, 60)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 42)
        Me.btnEliminar.TabIndex = 76
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(833, 60)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 42)
        Me.btnEditar.TabIndex = 75
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(914, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 42)
        Me.btnGuardar.TabIndex = 74
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(833, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 42)
        Me.btnNuevo.TabIndex = 73
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'cboMarca
        '
        Me.cboMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(677, 81)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(127, 21)
        Me.cboMarca.TabIndex = 72
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(92, 108)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(631, 52)
        Me.txtDescripcion.TabIndex = 71
        '
        'txtNombreE
        '
        Me.txtNombreE.Location = New System.Drawing.Point(367, 51)
        Me.txtNombreE.Name = "txtNombreE"
        Me.txtNombreE.Size = New System.Drawing.Size(209, 20)
        Me.txtNombreE.TabIndex = 70
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(92, 77)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(167, 20)
        Me.txtCodigo.TabIndex = 69
        '
        'txtIdArticulo
        '
        Me.txtIdArticulo.Location = New System.Drawing.Point(367, 22)
        Me.txtIdArticulo.Name = "txtIdArticulo"
        Me.txtIdArticulo.Size = New System.Drawing.Size(209, 20)
        Me.txtIdArticulo.TabIndex = 68
        '
        'txtNombreA
        '
        Me.txtNombreA.Location = New System.Drawing.Point(92, 22)
        Me.txtNombreA.Name = "txtNombreA"
        Me.txtNombreA.Size = New System.Drawing.Size(125, 20)
        Me.txtNombreA.TabIndex = 67
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(804, 82)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(23, 20)
        Me.txtId.TabIndex = 66
        Me.txtId.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(593, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 26)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Estado del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Activo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Descripcion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(265, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Nombre de articulo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(267, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Nombre Empleado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "N.Identidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 26)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Codigo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inventario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Codigo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(593, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "Departamento"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(582, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "N. De Serie"
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(677, 51)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(127, 20)
        Me.txtDepartamento.TabIndex = 86
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(677, 19)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(127, 20)
        Me.txtSerie.TabIndex = 87
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(804, 51)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(23, 20)
        Me.TextBox3.TabIndex = 88
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(804, 19)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(23, 20)
        Me.TextBox4.TabIndex = 89
        '
        'btnEmpleadosId
        '
        Me.btnEmpleadosId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleadosId.Location = New System.Drawing.Point(223, 45)
        Me.btnEmpleadosId.Name = "btnEmpleadosId"
        Me.btnEmpleadosId.Size = New System.Drawing.Size(36, 23)
        Me.btnEmpleadosId.TabIndex = 90
        Me.btnEmpleadosId.Text = "..."
        Me.btnEmpleadosId.UseVisualStyleBackColor = True
        '
        'frmCargoActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 478)
        Me.Controls.Add(Me.btnEmpleadosId)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.txtDepartamento)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DTPFechaCompra)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnArticulos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cboMarca)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtNombreE)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtIdArticulo)
        Me.Controls.Add(Me.txtNombreA)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCargoActivos"
        Me.Text = "frmCargoActivos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvActivosAsignados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DTPFechaCompra As DateTimePicker
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnArticulos As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbMarca As RadioButton
    Friend WithEvents rbCodigoA As RadioButton
    Friend WithEvents rbNombreArticulo As RadioButton
    Friend WithEvents lblTotalActivosAsignados As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvActivosAsignados As DataGridView
    Friend WithEvents IdArticulo As DataGridViewTextBoxColumn
    Friend WithEvents NombreA As DataGridViewTextBoxColumn
    Friend WithEvents NumeroSerie As DataGridViewTextBoxColumn
    Friend WithEvents CodigoA As DataGridViewTextBoxColumn
    Friend WithEvents NombreM As DataGridViewTextBoxColumn
    Friend WithEvents Modelo As DataGridViewTextBoxColumn
    Friend WithEvents PrecioCompra As DataGridViewTextBoxColumn
    Friend WithEvents EstadoArticulo As DataGridViewTextBoxColumn
    Friend WithEvents FechaCompra As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents cboMarca As ComboBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombreE As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtIdArticulo As TextBox
    Friend WithEvents txtNombreA As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btnEmpleadosId As Button
End Class
