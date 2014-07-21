Public Class UsuarioEditar
    Public Tabla As New DataTable
    Private Validacion(9) As Boolean

    Private Sub UsuarioEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DB

        Tabla = db.Consultar("select * from usuario")
        If Tabla.Rows.Count > 0 Then
            For Each fila As DataRow In Tabla.Rows
                CUsuario.Items.Add(fila(0).ToString)
            Next
            For i As Integer = 1 To 9
                Validacion(i) = True
            Next
        Else
            MsgBox("Aun no hay ningun usuario registrado!", vbExclamation, "Información")
            CUsuario.Enabled = False
        End If
    End Sub

    Private Sub BBorrar_Click(sender As Object, e As EventArgs) Handles BBorrar.Click
        'Campos de texto
        TUsuario.Text = ""
        TPassword.Text = ""
        TTipo.SelectedIndex = -1
        TNombre.Text = ""
        TApellidos.Text = ""
        TNacimiento.Text = ""
        TSexo.SelectedIndex = -1
        'TSexo.Enabled = False
        TDireccion.Text = ""
        TTelefono.Text = ""

        ' Pictures de validacion 
        Pic1.BackgroundImage = Nothing
        Pic2.BackgroundImage = Nothing
        Pic3.BackgroundImage = Nothing
        Pic4.BackgroundImage = Nothing
        Pic5.BackgroundImage = Nothing
        Pic6.BackgroundImage = Nothing
        Pic7.BackgroundImage = Nothing
        Pic8.BackgroundImage = Nothing
        Pic9.BackgroundImage = Nothing

        'Enfoque a caja de texto usuario
        TUsuario.Focus()
    End Sub

    Private Sub TUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TUsuario.KeyPress
        If e.KeyChar = Chr(13) And BBorrar.Enabled = True = True Then
            TPassword.Focus()
        ElseIf Char.IsLetterOrDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TUsuario_TextChanged(sender As Object, e As EventArgs) Handles TUsuario.TextChanged
        If TUsuario.TextLength > 3 Then
            Validacion(1) = True
            Pic1.BackgroundImage = My.Resources.Select_2
            TPassword.Enabled = True
        Else
            Pic1.BackgroundImage = Nothing
            Eti1.Visible = False
            TPassword.Enabled = False
            BBorrar.Enabled = False
            Validacion(1) = False
        End If
    End Sub

    Private Sub TPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPassword.KeyPress
        If e.KeyChar = Chr(13) And BBorrar.Enabled = True = True Then
            TTipo.Focus()
        ElseIf Char.IsLetterOrDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TPassword_TextChanged(sender As Object, e As EventArgs) Handles TPassword.TextChanged
        If TPassword.TextLength < 1 Then
            Pic2.BackgroundImage = Nothing
            Eti2.Visible = False
            TTipo.Enabled = False
            Validacion(2) = False
        ElseIf TPassword.TextLength < 4 Then
            Pic2.BackgroundImage = My.Resources.Error_4
            Eti2.Visible = True
            TTipo.Enabled = False
            Validacion(2) = False
        Else
            Pic2.BackgroundImage = My.Resources.Select_2
            Eti2.Visible = False
            TTipo.Enabled = True
            Validacion(2) = True
        End If
    End Sub

    Private Sub TTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TTipo.SelectedIndexChanged
        Pic3.BackgroundImage = My.Resources.Select_2
        TNombre.Enabled = True
        TNombre.Focus()
        Validacion(3) = True
        If TTipo.SelectedIndex = -1 Then
            TNombre.Enabled = False
        End If
    End Sub

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        If e.KeyChar = Chr(13) And TNombre.TextLength > 2 Then
            TApellidos.Focus()
        Else
            e = Validar_Nombre(e, TNombre.Text)
        End If
    End Sub

    Private Sub TNombre_TextChanged(sender As Object, e As EventArgs) Handles TNombre.TextChanged
        If TNombre.TextLength > 2 Then
            Pic4.BackgroundImage = My.Resources.Select_2
            TApellidos.Enabled = True
            Validacion(4) = True
        ElseIf TNombre.TextLength > 0 Then
            Pic4.BackgroundImage = My.Resources.Error_4
            TApellidos.Enabled = False
            Validacion(4) = False
        Else
            Pic4.BackgroundImage = Nothing
            TApellidos.Enabled = False
            Validacion(4) = False
        End If
    End Sub

    Private Sub TApellidos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellidos.KeyPress
        If e.KeyChar = Chr(13) And TNombre.TextLength > 2 Then
            TNacimiento.Focus()
        Else
            e = Validar_Nombre(e, TApellidos.Text)
        End If
    End Sub

    Private Sub TApellidos_TextChanged(sender As Object, e As EventArgs) Handles TApellidos.TextChanged
        If TApellidos.TextLength > 2 Then
            Pic5.BackgroundImage = My.Resources.Select_2
            TNacimiento.Enabled = True
            Validacion(5) = True
        ElseIf TApellidos.TextLength > 0 Then
            Pic5.BackgroundImage = My.Resources.Error_4
            TNacimiento.Enabled = False
            Validacion(5) = False
        Else
            Pic5.BackgroundImage = Nothing
            TNacimiento.Enabled = False
            Validacion(5) = False
        End If
    End Sub

    Private Sub TNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles TNacimiento.ValueChanged
        If TApellidos.Enabled = True Then
            Pic6.BackgroundImage = My.Resources.Select_2
            TSexo.Enabled = True
            TSexo.Focus()
            Validacion(6) = True
        End If
    End Sub

    Private Sub TSexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TSexo.SelectedIndexChanged
        If TNacimiento.Enabled = True Then
            Pic7.BackgroundImage = My.Resources.Select_2
            TDireccion.Enabled = True
            TDireccion.Focus()
            Validacion(7) = True
        End If
    End Sub

    Private Sub TDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDireccion.KeyPress
        If e.KeyChar = Chr(13) And TDireccion.TextLength > 5 Then
            TTelefono.Focus()
        End If
    End Sub

    Private Sub TDireccion_TextChanged(sender As Object, e As EventArgs) Handles TDireccion.TextChanged
        If TDireccion.TextLength > 5 Then
            Pic8.BackgroundImage = My.Resources.Select_2
            TTelefono.Enabled = True
            Validacion(8) = True
        Else
            Pic8.BackgroundImage = Nothing
            TTelefono.Enabled = False
            Validacion(8) = False
        End If
    End Sub

    Private Sub TTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TTelefono.KeyPress
        If e.KeyChar = Chr(13) Then
        Else
            e = Validar_Numero(e)
        End If
    End Sub

    Private Sub TTelefono_TextChanged(sender As Object, e As EventArgs) Handles TTelefono.TextChanged
        If TTelefono.TextLength > 9 Then
            Pic9.BackgroundImage = My.Resources.Select_2
            BGuardar.Enabled = True
            Validacion(9) = True
        Else
            Pic9.BackgroundImage = Nothing
            BGuardar.Enabled = False
            Validacion(9) = False
        End If
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim Estado As Integer
        Dim db As New DB
        If ValidacionGeneral() Then
            Estado = db.Ejecutar("update usuario set IdUsuario='" & TUsuario.Text & "',Pass='" & TPassword.Text & "',Tipo='" & TTipo.Text & "',Nombre='" & TNombre.Text & "',Apellidos='" & TApellidos.Text & "',FechaNacimiento='" & TNacimiento.Text & "',Sexo='" & TSexo.Text & "',Direccion='" & TDireccion.Text & "',Telefono='" & TTelefono.Text & "' where IdUsuario='" & CUsuario.Text & "'")
            If Estado > 0 Then
                MsgBox("Registro actualizado correctamente!", vbInformation, "Informacion")
                CUsuario.Items.Clear()

                Tabla = db.Consultar("select * from usuario")
                If Tabla.Rows.Count > 0 Then
                    For Each fila As DataRow In Tabla.Rows
                        CUsuario.Items.Add(fila(0).ToString)
                    Next
                    BGuardar.Enabled = False
                    BBorrar.Enabled = False
                    Flow1.Enabled = False
                Else
                    MsgBox("Aun no hay ningun usuario registrado!", vbExclamation, "Información")
                End If

                BBorrar_Click(sender, e)
            Else
                MsgBox("Error al intentar guardar registro!", vbCritical, "Informacion")
            End If
        End If
    End Sub

    Private Function ValidacionGeneral() As Boolean
        Dim Resp As Boolean = True

        If Not Validacion(1) Then
            Resp = False
            MsgBox("Llene correctamente el campo: Usuario!", vbExclamation, "Informacion")
        ElseIf Not Validacion(2) Then
            Resp = False
            MsgBox("Llene correctamente el campo: Contraseña!", vbExclamation, "Informacion")
        ElseIf Not Validacion(3) Then
            Resp = False
            MsgBox("Llene correctamente el campo: Tipo!", vbExclamation, "Informacion")
        ElseIf Not Validacion(4) Then
            Resp = False
            MsgBox("Llene correctamente el campo: Nombre!", vbExclamation, "Informacion")
        ElseIf Not Validacion(5) Then
            Resp = False
            MsgBox("Llene correctamente el campo: Apellidos!", vbExclamation, "Informacion")
        ElseIf Not Validacion(6) Then
            Resp = False
            MsgBox("Llene correctamente el campo: Fecha de Nacimiento!", vbExclamation, "Informacion")
        ElseIf Not Validacion(7) Then
            Resp = False
            MsgBox("Llene correctamente el campo: Sexo!", vbExclamation, "Informacion")
        ElseIf Not Validacion(8) Then
            Resp = False
            MsgBox("Llene correctamente el campo: Direccion!", vbExclamation, "Informacion")
        ElseIf Not Validacion(9) Then
            Resp = False
            MsgBox("Llene correctamente el campo: Telefono!", vbExclamation, "Informacion")
        End If

        Return Resp
    End Function

    Private Sub CUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CUsuario.SelectedIndexChanged
        For Each Fila As DataRow In Tabla.Rows
            If Fila.Item(0).ToString = CUsuario.Text Then
                TUsuario.Text = Fila.Item(0).ToString
                TPassword.Text = Fila.Item(1).ToString
                TNombre.Text = Fila.Item(2).ToString
                TApellidos.Text = Fila.Item(3).ToString
                TNacimiento.Value = Fila.Item(4).ToString
                TSexo.SelectedItem = Fila.Item(5).ToString
                TDireccion.Text = Fila.Item(6).ToString
                TTelefono.Text = Fila.Item(7).ToString
                TTipo.SelectedItem = Fila.Item(8).ToString
            End If
        Next
        Flow1.Enabled = True
        BBorrar.Enabled = True
        'BGuardar.Enabled = True
    End Sub
End Class