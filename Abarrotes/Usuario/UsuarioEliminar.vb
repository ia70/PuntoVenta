Public Class UsuarioEliminar

    Private Sub UsuarioEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DB
        Dim Tabla As New DataTable

        Tabla = db.Consultar("select IdUsuario from usuario")
        If Tabla.Rows.Count < 1 Then
            MsgBox("Aun no hay ningun usuario registrado!", vbExclamation, "Información")
            TUsuario.Enabled = False
            Beliminar.Enabled = False
        Else
            For Each valor As DataRow In Tabla.Rows
                TUsuario.Items.Add(valor(0).ToString)
            Next
        End If
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click

    End Sub

    Private Sub TUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TUsuario.SelectedIndexChanged
        If TUsuario.Items.Count > 0 Then
            Dim db As New DB
            Dim Tabla As New DataTable

            Tabla = db.Consultar("select Nombre,Apellidos from usuario where IdUsuario='" & TUsuario.Text & "'")
            If Tabla.Rows.Count > 0 Then
                For Each valor As DataRow In Tabla.Rows
                    TNombre.Text = valor(0).ToString + " " + valor(1).ToString
                Next
            End If
        End If
    End Sub

    Private Sub Beliminar_Click(sender As Object, e As EventArgs) Handles Beliminar.Click
        If TUsuario.Items.Count > 0 Then
            Dim db As New DB
            If db.Ejecutar("delete from usuario where IdUsuario='" & TUsuario.Text & "'") Then
                MsgBox("Registro eliminado correctamente!", vbInformation, "Información")
                TNombre.Text = ""
                TUsuario.Items.Remove(TUsuario.Text)
                If TUsuario.Items.Count = 0 Then
                    TUsuario.Enabled = False
                    Beliminar.Enabled = False
                End If
            Else
                MsgBox("Error al intentar eliminar registro!", vbExclamation, "Información")
            End If
        Else
            MsgBox("No hay registro que eliminar!", vbExclamation, "Información")
        End If
    End Sub
End Class