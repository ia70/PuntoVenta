Public Class DepartamentoNuevo

    Private Sub TDepartamento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDepartamento.KeyPress
        If e.KeyChar = Chr(13) And TDepartamento.TextLength > 3 Then
            TDescripcion.Focus()
        Else
            e = Validar_NombreNumero(e, TDepartamento.Text)
        End If
    End Sub

    Private Sub TDepartamento_TextChanged(sender As Object, e As EventArgs) Handles TDepartamento.TextChanged
        If TDepartamento.TextLength > 3 Then
            Dim db As New DB
            Dim Tabla As New DataTable

            Tabla = db.Consultar("select * from departamento where Nombre='" & TDepartamento.Text & "'")
            If Tabla.Rows.Count > 0 Then
                Pic1.BackgroundImage = My.Resources.Error_4
                BGuardar.Enabled = False
            Else
                Pic1.BackgroundImage = My.Resources.Select_2
                BGuardar.Enabled = True
            End If
        Else
            Pic1.BackgroundImage = Nothing
            BGuardar.Enabled = False
        End If
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim db As New DB

        If db.Ejecutar("insert into departamento(Nombre,Descripcion,FechaRegistro) values('" & TDepartamento.Text & "','" & TDescripcion.Text & "','" & Date.Today.ToShortDateString & "')") Then
            MsgBox("Registro guardado correctamente!", vbInformation, "Información")
            TDepartamento.Text = ""
            TDescripcion.Text = ""
            TDepartamento.Focus()
        Else
            MsgBox("Error al intentar guardar registro!", vbCritical, "Información")
        End If
    End Sub
End Class