Public Class UsuarioNuevo

    Private Sub BBorrar_Click(sender As Object, e As EventArgs) Handles BBorrar.Click
        'Campos de texto
        TUsuario.Text = ""
        TPassword.Text = ""
        TTipo.SelectedIndex = -1
        TNombre.Text = ""
        TApellidos.Text = ""
        TNacimiento.Text = ""
        TSexo.SelectedIndex = -1
        TDireccion.Text = ""

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
            Dim db As New DB                'Se crea instancia a clase DB
            Dim tabla As DataTable          'Se crea DataTable donde recibira respuesta de la consulta

            'consulta para verificar si el usuario existe
            tabla = db.Consultar("select IdUsuario from usuario where IdUsuario='" & TUsuario.Text & "'")
            If tabla.Rows.Count < 1 Then
                TPassword.Enabled = True
                BBorrar.Enabled = True
                Pic1.BackgroundImage = My.Resources.Select_2
                Eti1.Visible = False
            Else
                BBorrar.Enabled = False
                TPassword.Enabled = False
                Pic1.BackgroundImage = My.Resources.Error_4
                Eti1.Visible = True
            End If
            tabla.Dispose()
        Else
            Pic1.BackgroundImage = Nothing
            Eti1.Visible = False
            TPassword.Enabled = False
            BBorrar.Enabled = False
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
        ElseIf TPassword.TextLength < 4 Then
            Pic2.BackgroundImage = My.Resources.Error_4
            Eti2.Visible = True
            TTipo.Enabled = False
        Else
            Pic2.BackgroundImage = My.Resources.Select_2
            Eti2.Visible = False
            TTipo.Enabled = True
        End If
    End Sub

    Private Sub TTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TTipo.SelectedIndexChanged
        Pic3.BackgroundImage = My.Resources.Select_2
        TNombre.Enabled = True
        TNombre.Focus()
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
        ElseIf TNombre.TextLength > 0 Then
            Pic4.BackgroundImage = My.Resources.Error_4
            TApellidos.Enabled = False
        Else
            Pic4.BackgroundImage = Nothing
            TApellidos.Enabled = False
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
        ElseIf TApellidos.TextLength > 0 Then
            Pic5.BackgroundImage = My.Resources.Error_4
            TNacimiento.Enabled = False
        Else
            Pic5.BackgroundImage = Nothing
            TNacimiento.Enabled = False
        End If
    End Sub
End Class