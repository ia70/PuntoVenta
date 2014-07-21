Public Class ProveedorNuevo
    Private Validacion As Boolean = False

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        If e.KeyChar = Chr(13) And TNombre.TextLength > 3 Then
            TTelefono.Focus()
        Else
            e = Validar_NombreNumero(e, TNombre.Text)
        End If
    End Sub
    Private Sub TNombre_TextChanged(sender As Object, e As EventArgs) Handles TNombre.TextChanged
        If TNombre.TextLength > 3 Then
            Dim db As New DB
            Dim Tabla As New DataTable
            Tabla = db.Consultar("select * from proveedor where Nombre='" & TNombre.Text & "'")
            If Tabla.Rows.Count > 0 Then
                Pic1.BackgroundImage = My.Resources.Error_4
                BGuardar.Enabled = False
                Validacion = False
            Else
                Pic1.BackgroundImage = My.Resources.Select_2
                BGuardar.Enabled = True
                Validacion = True
            End If
        Else
            Pic1.BackgroundImage = Nothing
            BGuardar.Enabled = False
            Validacion = False
        End If
    End Sub

    Private Sub TTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TTelefono.KeyPress
        If e.KeyChar = Chr(13) And TTelefono.TextLength > 9 Then
            TCorreo.Focus()
        Else
            e = Validar_Numero(e)
        End If
    End Sub

    Private Sub TTelefono_TextChanged(sender As Object, e As EventArgs) Handles TTelefono.TextChanged
        If TTelefono.TextLength > 9 Then
            Pic2.BackgroundImage = My.Resources.Select_2
        Else
            Pic2.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If Validacion Then
            If TTelefono.TextLength > 0 And TTelefono.TextLength < 10 Then
                MsgBox("Rallene el campo telefono adecuadamente o dejelo en blanco!", vbExclamation, "Información")
            ElseIf TCorreo.TextLength > 0 And TCorreo.TextLength < 8 Then
                MsgBox("Rallene el campo correo adecuadamente o dejelo en blanco!", vbExclamation, "Información")
            Else
                Dim db As New DB
                If db.Ejecutar("insert into proveedor(Nombre,Telefono,CorreoElectronico,FechaRegistro) values('" & TNombre.Text & "','" & TTelefono.Text & "','" & TCorreo.Text & "','" & Date.Today.ToShortDateString & "')") Then
                    MsgBox("Registro guardado correctamente!", vbInformation, "Información")
                    TNombre.Text = ""
                    TTelefono.Text = ""
                    TCorreo.Text = ""
                    BGuardar.Enabled = False
                Else
                    MsgBox("Error al intentar guardar el registro!", vbCritical, "Información")
                End If
            End If
        End If
    End Sub
End Class