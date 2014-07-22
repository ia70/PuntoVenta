Public Class DepartamentoEditar
    Private tb As New DataTable

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
            If Tabla.Rows.Count > 0 And Not TDepartamento.Text = CDepartamento.Text Then
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

        If db.Ejecutar("update departamento set Nombre='" & TDepartamento.Text & "',Descripcion='" & TDescripcion.Text & "' where Nombre='" & CDepartamento.Text & "'") Then
            MsgBox("Registro actualizado correctamente!", vbInformation, "Información")
            TDepartamento.Text = ""
            TDescripcion.Text = ""
            DepartamentoEditar_Load(sender, e)
            Panel1.Enabled = False
            TDepartamento.Focus()
        Else
            MsgBox("Error al intentar guardar registro!", vbCritical, "Información")
        End If
    End Sub

    Private Sub DepartamentoEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DB

        tb = db.Consultar("select * from departamento")
        CDepartamento.Items.Clear()
        If tb.Rows.Count > 0 Then
            For Each Fila As DataRow In tb.Rows
                CDepartamento.Items.Add(Fila.Item(1).ToString)
            Next
        Else
            MsgBox("Aun no hay ningun departamento registrado!", vbExclamation, "Información")
            CDepartamento.Enabled = False
        End If
    End Sub

    Private Sub CDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CDepartamento.SelectedIndexChanged

        For Each Fila As DataRow In tb.Rows
            If Fila.Item(1).ToString = CDepartamento.Text Then
                TDepartamento.Text = Fila.Item(1).ToString
                TDescripcion.Text = Fila.Item(2).ToString
                Exit For
            End If
        Next
        Panel1.Enabled = True
        BGuardar.Enabled = True
    End Sub
End Class