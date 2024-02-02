<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulos
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
        Me.btnMarcas = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbMarca = New System.Windows.Forms.RadioButton()
        Me.rbCodigoA = New System.Windows.Forms.RadioButton()
        Me.rbNombreArticulo = New System.Windows.Forms.RadioButton()
        Me.lblTotalArticulos = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvArticulos = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.txtNombreA = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.DTPFechaCompra = New System.Windows.Forms.DateTimePicker()
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
        Me.Panel1.SuspendLayout()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMarcas
        '
        Me.btnMarcas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarcas.Location = New System.Drawing.Point(646, 76)
        Me.btnMarcas.Name = "btnMarcas"
        Me.btnMarcas.Size = New System.Drawing.Size(36, 23)
        Me.btnMarcas.TabIndex = 54
        Me.btnMarcas.Text = "..."
        Me.btnMarcas.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbMarca)
        Me.Panel1.Controls.Add(Me.rbCodigoA)
        Me.Panel1.Controls.Add(Me.rbNombreArticulo)
        Me.Panel1.Controls.Add(Me.lblTotalArticulos)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvArticulos)
        Me.Panel1.Location = New System.Drawing.Point(47, 153)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(806, 257)
        Me.Panel1.TabIndex = 53
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
        'lblTotalArticulos
        '
        Me.lblTotalArticulos.AutoSize = True
        Me.lblTotalArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalArticulos.Location = New System.Drawing.Point(142, 227)
        Me.lblTotalArticulos.Name = "lblTotalArticulos"
        Me.lblTotalArticulos.Size = New System.Drawing.Size(43, 16)
        Me.lblTotalArticulos.TabIndex = 4
        Me.lblTotalArticulos.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 229)
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
        'dgvArticulos
        '
        Me.dgvArticulos.AllowUserToAddRows = False
        Me.dgvArticulos.AllowUserToDeleteRows = False
        Me.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdArticulo, Me.NombreA, Me.NumeroSerie, Me.CodigoA, Me.NombreM, Me.Modelo, Me.PrecioCompra, Me.EstadoArticulo, Me.FechaCompra, Me.Descripcion})
        Me.dgvArticulos.Location = New System.Drawing.Point(18, 48)
        Me.dgvArticulos.Name = "dgvArticulos"
        Me.dgvArticulos.ReadOnly = True
        Me.dgvArticulos.RowHeadersVisible = False
        Me.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvArticulos.Size = New System.Drawing.Size(771, 169)
        Me.dgvArticulos.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(697, 105)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 42)
        Me.btnBuscar.TabIndex = 52
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(778, 105)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 42)
        Me.btnCancelar.TabIndex = 51
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(778, 57)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 42)
        Me.btnEliminar.TabIndex = 50
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(697, 57)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 42)
        Me.btnEditar.TabIndex = 49
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(778, 9)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 42)
        Me.btnGuardar.TabIndex = 48
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(697, 9)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 42)
        Me.btnNuevo.TabIndex = 47
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'cboMarca
        '
        Me.cboMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(490, 78)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(150, 21)
        Me.cboMarca.TabIndex = 45
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(92, 73)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(328, 52)
        Me.txtDescripcion.TabIndex = 43
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(490, 105)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(192, 20)
        Me.txtModelo.TabIndex = 42
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(490, 21)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(192, 20)
        Me.txtCodigo.TabIndex = 41
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(490, 47)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(192, 20)
        Me.txtSerie.TabIndex = 40
        '
        'txtNombreA
        '
        Me.txtNombreA.Location = New System.Drawing.Point(91, 21)
        Me.txtNombreA.Name = "txtNombreA"
        Me.txtNombreA.Size = New System.Drawing.Size(329, 20)
        Me.txtNombreA.TabIndex = 39
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(1, 1)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(58, 20)
        Me.txtId.TabIndex = 38
        Me.txtId.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(447, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Marca"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Descripcion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(422, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "N. De Serie"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(442, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Modelo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(444, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Codigo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(222, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Fecha de Compra"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(91, 47)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(125, 20)
        Me.txtPrecio.TabIndex = 57
        '
        'DTPFechaCompra
        '
        Me.DTPFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaCompra.Location = New System.Drawing.Point(319, 47)
        Me.DTPFechaCompra.Name = "DTPFechaCompra"
        Me.DTPFechaCompra.Size = New System.Drawing.Size(101, 20)
        Me.DTPFechaCompra.TabIndex = 58
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
        'frmArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 419)
        Me.Controls.Add(Me.DTPFechaCompra)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnMarcas)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cboMarca)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.txtNombreA)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmArticulos"
        Me.Text = "Registro de Articulos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMarcas As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbMarca As RadioButton
    Friend WithEvents rbCodigoA As RadioButton
    Friend WithEvents rbNombreArticulo As RadioButton
    Friend WithEvents lblTotalArticulos As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvArticulos As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents cboMarca As ComboBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents txtNombreA As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents DTPFechaCompra As DateTimePicker
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
End Class
