Public Class ProveedorEditar
    Private Tabla As New DataTable
    Private Sub ProveedorEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DB

        Tabla = db.Consultar("select * from proveedor")
        If Tabla.Rows.Count > 0 Then
            For Each Fila As DataRow In Tabla.Rows
                CProveedor.Items.Add(Fila.Item(1).ToString)
            Next
        Else
            MsgBox("Aun no hay ningun proveedor registrado!", vbExclamation, "Información")
            CProveedor.Enabled = False
        End If
    End Sub

    Private Sub CProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CProveedor.SelectedIndexChanged

        For Each Fila As DataRow In Tabla.Rows
            If Fila.Item(1).ToString = CProveedor.Text Then
                TNombre.Text = Fila.Item(1).ToString
                TTelefono.Text = Fila.Item(2).ToString
                TCorreo.Text = Fila.Item(3).ToString
            End If
        Next

        Flow1.Enabled = True
        BGuardar.Enabled = True
    End Sub

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        If e.KeyChar = Chr(13) And TNombre.TextLength > 3 Then
            TTelefono.Focus()
        Else
            e = Validar_NombreNumero(e, TNombre.Text)
        End If
    End Sub

    Private Sub TNombre_TextChanged(sender As Object, e As EventArgs) Handles TNombre.TextChanged
        If TNombre.TextLength > 3 Then

            If TNombre.Text = CProveedor.Text Then
                Pic1.BackgroundImage = My.Resources.Select_2
                BGuardar.Enabled = True
            Else
                For Each Fila As DataRow In Tabla.Rows
                    If Fila.Item(1).ToString = TNombre.Text Then
                        Pic1.BackgroundImage = My.Resources.Error_4
                        BGuardar.Enabled = False
                        Exit Sub
                    End If
                Next
                Pic1.BackgroundImage = My.Resources.Select_2
                BGuardar.Enabled = True
            End If
        Else
            Pic1.BackgroundImage = Nothing
            BGuardar.Enabled = False
        End If



    End Sub

    Private Sub TTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TTelefono.KeyPress
        If e.KeyChar = Chr(13) And TTelefono.TextLength > 6 Then
            TCorreo.Focus()
        Else
            e = Validar_Numero(e)
        End If
    End Sub

    Private Sub TTelefono_TextChanged(sender As Object, e As EventArgs) Handles TTelefono.TextChanged
        If TTelefono.TextLength > 6 Then
            Pic2.BackgroundImage = My.Resources.Select_2
        Else
            Pic2.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If TTelefono.TextLength > 0 And TTelefono.TextLength < 7 Then
            MsgBox("Llene corectamente el campo telefono o dejelo vacio!", vbExclamation, "Información")
        ElseIf TCorreo.TextLength > 0 And TCorreo.TextLength < 8 Then
            MsgBox("Llene corectamente el campo correo electronico o dejelo vacio!", vbExclamation, "Información")
        Else
            Dim db As New DB
            If db.Ejecutar("update proveedor set Nombre='" & TNombre.Text & "',Telefono='" & TTelefono.Text & "',CorreoElectronico='" & TCorreo.Text & "' where Nombre='" & CProveedor.Text & "'") Then
                MsgBox("Registro actualizado correctamente!", vbInformation, "Información")
                TNombre.Text = ""
                TTelefono.Text = ""
                TCorreo.Text = ""
                CProveedor.Items.Clear()

                Tabla = db.Consultar("select * from proveedor")
                For Each Fila As DataRow In Tabla.Rows
                    CProveedor.Items.Add(Fila.Item(1).ToString)
                Next
                BGuardar.Enabled = False
                Flow1.Enabled = False
            End If
        End If
    End Sub
End Class