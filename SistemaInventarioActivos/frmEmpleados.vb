Imports System.Data.SqlClient
Public Class frmEmpleados

    Private tabla_departamentos As New DataTable
    Private tabla_puestos As New DataTable

    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DesactivarControles()
        'LlenarDatos()
        dgvEmpleados.AutoGenerateColumns = False
        Mostrar_Departamentos()
        cboDepartamento.SelectedIndex = -1
        Mostrar_Puestos()
        cboPuesto.SelectedIndex = -1

    End Sub

    Public Function Departamento_Listar(activo As Integer) As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT IdDepartamento, NombreD FROM Departamentos"
        Using adaptador = New SqlDataAdapter(sql, obtenerConexion)
            tabla.Rows.Clear()
            adaptador.Fill(tabla)
        End Using
        Return tabla

    End Function

    Private Sub Mostrar_Departamentos()
        tabla_departamentos = Departamento_Listar(True)
        cboDepartamento.DataSource = tabla_departamentos
        cboDepartamento.DisplayMember = "NombreD"
        cboDepartamento.ValueMember = "IdDepartamento"
    End Sub

    Public Function Puesto_Listar(activo As Integer) As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT IdPuesto, NombreP FROM Puestos"
        Using adaptador = New SqlDataAdapter(sql, obtenerConexion)
            tabla.Rows.Clear()
            adaptador.Fill(tabla)
        End Using
        Return tabla

    End Function

    Private Sub Mostrar_Puestos()
        tabla_puestos = Puesto_Listar(True)
        cboPuesto.DataSource = tabla_puestos
        cboPuesto.DisplayMember = "NombreP"
        cboPuesto.ValueMember = "IdPuesto"
    End Sub

    Sub DesactivarControles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False

        txtNombreE.Enabled = False
        txtIdentidad.Enabled = False
        txtCorreo.Enabled = False
        txtTelefono.Enabled = False
        txtDireccion.Enabled = False
        cboGenero.Enabled = False
        cboDepartamento.Enabled = False
        cboPuesto.Enabled = False

        btnNuevo.Enabled = True
    End Sub
    Sub ActivarControles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True

        txtNombreE.Enabled = True
        txtIdentidad.Enabled = True
        txtCorreo.Enabled = True
        txtTelefono.Enabled = True
        txtDireccion.Enabled = True
        cboGenero.Enabled = True
        cboDepartamento.Enabled = True
        cboPuesto.Enabled = True

        btnNuevo.Enabled = False
    End Sub
    Sub LimpiarControles()
        txtNombreE.Text = ""
        txtIdentidad.Text = ""
        txtCorreo.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        cboGenero.Text = ""
        cboDepartamento.Text = ""
        cboPuesto.Text = ""


        txtId.Text = ""
        txtBuscar.Text = ""

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call ActivarControles()
        LimpiarControles()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'insertar()
        'LlenarDatos()
        Call DesactivarControles()
        LimpiarControles()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Call DesactivarControles()
        LimpiarControles()

    End Sub
End Class