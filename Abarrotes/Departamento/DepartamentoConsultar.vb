Public Class DepartamentoConsultar
    Private tb As New DataTable

    Private Sub DepartamentoConsultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DB

        tb = db.Consultar("select * from departamento")
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
                TNombre.Text = Fila.Item(1).ToString
                TDescripcion.Text = Fila.Item(2).ToString()
                TFechaRegistro.Text = Fila.Item(3).ToString
                Exit For
            End If
        Next
        TDescripcion.Enabled = True
    End Sub
End Class