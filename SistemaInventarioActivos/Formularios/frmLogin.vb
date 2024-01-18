Imports System.Data.SqlClient
Public Class frmLogin



    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Existen datos vacios", vbExclamation, "Operación Cancelada")

        Else
            Try
                conexion.Open()
                adaptador = New SqlDataAdapter("SELECT * FROM Usuarios WHERE Usuario ='" & UsernameTextBox.Text & "' AND Password ='" & PasswordTextBox.Text & "' ", conexion)
                tabla.Clear()
                adaptador.Fill(tabla)
                If tabla.Rows.Count = 1 Then
                    MsgBox("Datos verificados", vbInformation, "Operacion Completada")
                    UsernameTextBox.Text = ""
                    PasswordTextBox.Text = ""
                    Me.Hide()
                    frmPrincipal.Show()
                Else
                    MsgBox("Nombre de usuario o contraseña no validos", vbExclamation, "Operación Cancelada")
                    UsernameTextBox.Text = ""
                    PasswordTextBox.Text = ""
                End If
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")

            End Try
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click
        frmConfiguracion.Show()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Establecerconexion()
    End Sub
End Class
