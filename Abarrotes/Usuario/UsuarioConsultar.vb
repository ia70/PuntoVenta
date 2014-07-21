Public Class UsuarioConsultar
    Public Tabla As New DataTable
    Private Sub UsuarioConsultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DB

        Tabla = db.Consultar("select * from usuario")
        If Tabla.Rows.Count > 0 Then
            For Each Fila As DataRow In Tabla.Rows
                CUsuario.Items.Add(Fila.Item(0).ToString)
            Next
        Else
            MsgBox("Aun no hay usuarios registrados!", vbExclamation, "Información")
            CUsuario.Enabled = False
        End If
    End Sub

    Private Sub CUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CUsuario.SelectedIndexChanged
        For Each Fila As DataRow In Tabla.Rows
            If Fila.Item(0).ToString = CUsuario.Text Then
                TPassword.Text = Fila.Item(1).ToString
                TTipo.Text = Fila.Item(8).ToString
                TNombre.Text = Fila.Item(2).ToString
                TApellidos.Text = Fila.Item(3).ToString
                TNacimiento.Text = Fila.Item(4).ToString
                TSexo.Text = Fila.Item(5).ToString
                TDireccion.Text = Fila.Item(6).ToString
                TRegistro.Text = Fila.Item(9).ToString
            End If
        Next
    End Sub
End Class