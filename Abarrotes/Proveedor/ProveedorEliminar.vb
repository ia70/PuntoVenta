Public Class ProveedorEliminar

    Private Sub ProveedorEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DB
        Dim Tabla As New DataTable

        Tabla = db.Consultar("select Nombre from proveedor")
        If Tabla.Rows.Count > 0 Then
            For Each Fila As DataRow In Tabla.Rows
                CProveedor.Items.Add(Fila.Item(0).ToString)
            Next
        Else
            MsgBox("Aun no hay ningun proveedor registrado!", vbExclamation, "Información")
            CProveedor.Enabled = False
        End If
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim db As New DB

        If db.Ejecutar("delete from proveedor where Nombre='" & CProveedor.Text & "'") Then
            MsgBox("Registro eliminado correctamente!", vbInformation, "Información")
            CProveedor.Items.Remove(CProveedor.SelectedItem)
            If CProveedor.Items.Count < 1 Then
                CProveedor.Enabled = False
            Else
                CProveedor.SelectedIndex = -1
                BEliminar.Enabled = False
            End If
        Else
            MsgBox("Error al intentar eliminar registro", vbCritical, "Información")
        End If
    End Sub

    Private Sub CProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CProveedor.SelectedIndexChanged
        BEliminar.Enabled = True
    End Sub
End Class