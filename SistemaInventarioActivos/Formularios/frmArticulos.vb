Imports System.Data.SqlClient

Public Class frmArticulos
    Private tabla_marcas As New DataTable

    Private Sub frmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Marcas()
        cboMarca.SelectedIndex = -1

    End Sub
    Sub DesactivarControles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        btnMarcas.Enabled = False

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
        btnMarcas.Enabled = True


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
End Class