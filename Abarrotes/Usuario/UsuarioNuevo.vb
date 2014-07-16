Public Class UsuarioNuevo

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TUsuario.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If FUsuarioAgregar(TUsuario.Text, TPassword.Text, TNombre.Text, TApellidos.Text, TNacimiento.Text,
                        TDireccion.Text, TTipo.Text, Date.Today.ToShortDateString) Then
            Button2_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BBorrar.Click
        TUsuario.Text = ""
        TPassword.Text = ""
        TNombre.Text = ""
        TApellidos.Text = ""
        TTipo.SelectedIndex = -1
        TSexo.SelectedIndex = -1
        TDireccion.Text = ""
        TUsuario.Focus()
    End Sub

    Private Sub BGuardar_LostFocus(sender As Object, e As EventArgs) Handles BGuardar.LostFocus

    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Pic1.BackgroundImage = My.Resources.Error_4
        FUsuarioCosultar(TUsuario.Text)
    End Sub
End Class