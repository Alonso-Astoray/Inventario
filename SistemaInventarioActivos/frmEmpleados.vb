Imports System.Data.SqlClient
Public Class frmEmpleados

    Private tabla_departamentos As New DataTable
    Private tabla_puestos As New DataTable

    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DesactivarControles()
        LlenarDatos()
        dgvEmpleados.AutoGenerateColumns = False
        Mostrar_Departamentos()
        cboDepartamento.SelectedIndex = -1
        Mostrar_Puestos()
        cboPuesto.SelectedIndex = -1

    End Sub
    Sub LlenarDatos()
        Dim sql As String
        sql = "SELECT Empleados.IdEmpleado, Empleados.Nombre, Empleados.Identidad, Empleados.Genero, Empleados.Telefono, Empleados.Correo, Empleados.Direccion, Departamentos.NombreD,
                      Puestos.NombreP FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento
                                                         INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto "
        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerConexion)
            adaptador.Fill(tabla)
            dgvEmpleados.DataSource = tabla
            lblTotalEmpleados.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente error " + ex.ToString + "Sistema Inventario")
        End Try
    End Sub
    Sub BuscarDatos()
        If rbNombreEmpleado.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado, Empleados.Nombre, Empleados.Identidad, Empleados.Genero, Empleados.Telefono, Empleados.Correo, Empleados.Direccion, Departamentos.NombreD,
                      Puestos.NombreP FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento
                                                         INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto
                                           WHERE Empleados.Nombre LIKE '%" & txtBuscar.Text & "%'", obtenerConexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvEmpleados.DataSource = tabla
                lblTotalEmpleados.Text = tabla.Rows.Count
            Else
                dgvEmpleados.DataSource = ""
            End If
        End If
        If rbIdentidad.Checked Then
                If txtBuscar.Text = "" Then
                    LlenarDatos()
                End If
                adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado, Empleados.Nombre, Empleados.Identidad, Empleados.Genero, Empleados.Telefono, Empleados.Correo, Empleados.Direccion, Departamentos.NombreD,
                      Puestos.NombreP FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento
                                                         INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto
                                           WHERE Empleados.Identidad LIKE '%" & txtBuscar.Text & "%'", obtenerConexion)
                tabla.Clear()
                adaptador.Fill(tabla)
                If tabla.Rows.Count > 0 Then
                    dgvEmpleados.DataSource = tabla
                    lblTotalEmpleados.Text = tabla.Rows.Count
                Else
                    dgvEmpleados.DataSource = ""
                End If
            End If

            If rbDepartamento.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado, Empleados.Nombre, Empleados.Identidad, Empleados.Genero, Empleados.Telefono, Empleados.Correo, Empleados.Direccion, Departamentos.NombreD,
                      Puestos.NombreP FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento
                                                         INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto
                                           WHERE Departamentos.NombreD LIKE '%" & txtBuscar.Text & "%'", obtenerConexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvEmpleados.DataSource = tabla
                lblTotalEmpleados.Text = tabla.Rows.Count
            Else
                dgvEmpleados.DataSource = ""
            End If
        End If

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
    Sub insertar()
        Dim sql As String
        Dim id As Integer
        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
            Exit Sub

        End If
        adaptador = New SqlDataAdapter("SELECT * FROM Empleados Where Identidad = '" & txtIdentidad.Text & "' ", obtenerConexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            txtIdentidad.Text = tabla.Rows(0).Item("Identidad")
            MsgBox("El registro ya existe en la base de datos ", vbInformation, "Sistema inventario")
            Exit Sub

        End If
        If txtNombreE.Text = "" Or txtIdentidad.Text = "" Or cboGenero.Text = "" Or cboDepartamento.Text = "" Or cboPuesto.Text = "" Then
            MsgBox("Existen campos vacios ", vbInformation, "Sistema inventario")
            Exit Sub
        Else
            sql = "INSERT INTO Empleados(Nombre, Identidad, Genero, Telefono, Correo, Direccion,IdPuesto,IdDepartamento) VALUES ('" & txtNombreE.Text & "','" & txtIdentidad.Text &
                "','" & cboGenero.Text & "','" & txtTelefono.Text & "','" & txtCorreo.Text & "','" & txtDireccion.Text &
                "','" & Trim(cboPuesto.SelectedValue) & "','" & cboDepartamento.SelectedValue & "')"
            Dim conect As New SqlConnection(obtenerConexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar
            End Using
            conect.Close()
            MsgBox("Registro realizado exitosamente ", vbInformation, "Sistema inventario")
        End If
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call ActivarControles()
        LimpiarControles()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        insertar()
        LlenarDatos()
        Call DesactivarControles()
        LimpiarControles()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Call DesactivarControles()
        LimpiarControles()

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDatos()

    End Sub

    Private Sub rbIdentidad_CheckedChanged(sender As Object, e As EventArgs) Handles rbIdentidad.CheckedChanged

    End Sub

    Private Sub rbNombreEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreEmpleado.CheckedChanged

    End Sub
End Class