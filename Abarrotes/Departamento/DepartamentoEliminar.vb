Public Class DepartamentoEliminar

    Private Sub DepartamentoEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DB
        Dim tb As New DataTable

        tb = db.Consultar("select Nombre from departamento")
        If tb.Rows.Count > 0 Then
            For Each Fila As DataRow In tb.Rows
                CDepartamento.Items.Add(Fila.Item(0).ToString)
            Next
        Else
            MsgBox("Aun no hay ningun departamento registrado!", vbExclamation, "Información")
            BEliminar.Enabled = False
            CDepartamento.Enabled = False
        End If
    End Sub

    Private Sub CDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CDepartamento.SelectedIndexChanged
        BEliminar.Enabled = True
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim db As New DB

        If db.Ejecutar("delete from departamento where Nombre='" & CDepartamento.Text & "'") Then
            MsgBox("Registro eliminado correctamente!", vbInformation, "Información")
            CDepartamento.Items.Remove(CDepartamento.SelectedItem)
            If CDepartamento.Items.Count < 1 Then
                CDepartamento.Enabled = False
                BEliminar.Enabled = False
            Else
                BEliminar.Enabled = False
                CDepartamento.SelectedIndex = -1
            End If
        Else
            MsgBox("Error al intentar eliminar registro!", vbCritical, "Información")
        End If
    End Sub
End Class