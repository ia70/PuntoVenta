Public Class ProveedorConsultar
    Private Tabla As New DataTable
    Private Sub ProveedorConsultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DB

        Tabla = db.Consultar("select * from proveedor")
        If Tabla.Rows.Count > 0 Then
            For Each Fila As DataRow In Tabla.Rows
                CProveedor.Items.Add(Fila.Item(1).ToString)
            Next
        Else
            MsgBox("Aun no hay ningun proveedor registrado!", vbExclamation, "Informacion")
            CProveedor.Enabled = False
        End If
    End Sub

    Private Sub CProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CProveedor.SelectedIndexChanged
        For Each Fila As DataRow In Tabla.Rows
            If Fila.Item(1).ToString = CProveedor.Text Then
                TNombre.Text = Fila.Item(1).ToString
                TTelefono.Text = Fila.Item(2).ToString
                TCorreo.Text = Fila.Item(3).ToString
                TFechaRegistro.Text = Fila.Item(4).ToString
                Exit For
            End If
        Next
    End Sub
End Class