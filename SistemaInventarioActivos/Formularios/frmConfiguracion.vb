Imports System.IO
Public Class frmConfiguracion
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        If txtIp.Text = "" Or txtUser.Text = "" Or txtBd.Text = "" Then
            MsgBox("Completar todos los campos", vbCritical, "Operación Cancelada")
        End If
        Dim archivo As StreamWriter
        Try
            archivo = New StreamWriter(Application.StartupPath + "\IP.txt")
            archivo.WriteLine(txtIp.Text.Trim)
            archivo.Flush()
            archivo.Close()

            archivo = New StreamWriter(Application.StartupPath + "\BD.txt")
            archivo.WriteLine(txtBd.Text.Trim)
            archivo.Flush()
            archivo.Close()

            archivo = New StreamWriter(Application.StartupPath + "\USER.txt")
            archivo.WriteLine(txtUser.Text.Trim)
            archivo.Flush()
            archivo.Close()

            archivo = New StreamWriter(Application.StartupPath + "\PASS.txt")
            archivo.WriteLine(txtPass.Text.Trim)
            archivo.Flush()
            archivo.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class