﻿Imports System.Data.SqlClient

Public Class frmArticulos
    Private tabla_marcas As New DataTable

    Private Sub frmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DesactivarControles()
        LlenarDatos()
        Mostrar_Marcas()
        cboMarca.SelectedIndex = -1

    End Sub
    Sub DesactivarControles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        btnMarcas.Enabled = False

        txtNombreA.Enabled = False
        txtCodigo.Enabled = False
        txtSerie.Enabled = False
        txtModelo.Enabled = False
        cboMarca.Enabled = False
        DTPFechaCompra.Enabled = False
        txtPrecio.Enabled = False
        txtDescripcion.Enabled = False

        btnNuevo.Enabled = True
    End Sub
    Sub ActivarControles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True
        btnMarcas.Enabled = True


        txtNombreA.Enabled = True
        txtCodigo.Enabled = True
        txtSerie.Enabled = True
        txtModelo.Enabled = True
        cboMarca.Enabled = True
        DTPFechaCompra.Enabled = True
        txtPrecio.Enabled = True
        txtDescripcion.Enabled = True

        btnNuevo.Enabled = False
    End Sub
    Sub LimpiarControles()
        txtNombreA.Text = ""
        txtCodigo.Text = ""
        txtSerie.Text = ""
        txtModelo.Text = ""
        cboMarca.Text = ""
        DTPFechaCompra.Text = ""
        txtPrecio.Text = ""
        txtDescripcion.Text = ""


        txtId.Text = ""
        txtBuscar.Text = ""

    End Sub
    Sub insertar()
        Dim sql As String
        Dim id As Integer
        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
            Exit Sub

        End If
        adaptador = New SqlDataAdapter("SELECT * FROM Articulos Where CodigoA = '" & txtCodigo.Text & "' ", obtenerConexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            txtCodigo.Text = tabla.Rows(0).Item("CodigoA")
            MsgBox("El registro ya existe en la base de datos ", vbInformation, "Sistema inventario")
            Exit Sub

        End If
        If txtNombreA.Text = "" Or txtCodigo.Text = "" Then
            MsgBox("Existen campos vacios ", vbInformation, "Sistema inventario")
            Exit Sub
        Else
            sql = "INSERT INTO Articulos(NombreA, NumeroSerie, CodigoA, IdMarca, Modelo, PrecioCompra, FechaCompra, EstadoArticulo, Descripcion)" &
                                            "VALUES ('" & txtNombreA.Text & "','" & txtSerie.Text & "','" & txtCodigo.Text & "','" & Trim(cboMarca.SelectedValue) &
                                            "','" & txtModelo.Text & "','" & txtPrecio.Text & "','" & DTPFechaCompra.Text & "','PENDIENTE','" & txtDescripcion.Text & "')"
            Dim conect As New SqlConnection(obtenerConexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar
            End Using
            conect.Close()
            MsgBox("Registro realizado exitosamente ", vbInformation, "Sistema inventario")
        End If
    End Sub
    Sub LlenarDatos()
        Dim sql As String
        sql = "SELECT Articulos.NombreA,Articulos.NumeroSerie,Articulos.CodigoA,Marcas.NombreM,Articulos.Modelo,Articulos.PrecioCompra,
                      Articulos.FechaCompra,Articulos.EstadoArticulo,Articulos.Descripcion
                      FROM Articulos INNER JOIN Marcas ON Articulos.IdMarca = Marcas.IdMarca"
        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerConexion)
            adaptador.Fill(tabla)
            dgvArticulos.DataSource = tabla
            lblTotalArticulos.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente error " + ex.ToString + "Sistema Inventario")
        End Try
    End Sub
    Public Function Marcas_Listar(activo As Integer) As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT IdMarca, NombreM FROM Marcas"
        Using adaptador = New SqlDataAdapter(sql, obtenerConexion)
            tabla.Rows.Clear()
            adaptador.Fill(tabla)
        End Using
        Return tabla
    End Function
    Private Sub Mostrar_Marcas()
        tabla_marcas = Marcas_Listar(True)
        cboMarca.DataSource = tabla_marcas
        cboMarca.DisplayMember = "NombreM"
        cboMarca.ValueMember = "IdMarca"
    End Sub

    Private Sub btnMarcas_Click(sender As Object, e As EventArgs) Handles btnMarcas.Click
        frmMarcas.ShowDialog()
    End Sub

    Private Sub cboMarca_Click(sender As Object, e As EventArgs) Handles cboMarca.Click
        Mostrar_Marcas()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call ActivarControles()
        LimpiarControles()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        insertar()
        'LlenarDatos()
        Call DesactivarControles()
        LimpiarControles()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Call DesactivarControles()
        LimpiarControles()
    End Sub
End Class