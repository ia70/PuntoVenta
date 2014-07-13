Imports System.Data
Imports System.Data.OleDb

Module DataBaseCenter
    Private Conexion As New OleDbConnection     'Veriable de conexion a la basse de datos
    Private Consulta As New OleDbCommand        'Variable para consultas SQL
    Public Sub DBopen()
        'Conexion a la base de datos User: Administrador  Pasword: 82497EEW
        Try
            Conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb; User Id=Admin;Password=;"
            Conexion.Open()
        Catch ex As Exception
            'Si hay error al estblecer la conexion ala base de datos arroja mensaje de error
            MsgBox("No se pudo conectar con la Base de Datos! " + ex.ToString, vbCritical + vbOKOnly, "Error")
            Exit Sub
        End Try
    End Sub

    Public Sub DBclose()
        Conexion.Close()
    End Sub

    'FUNCIONES -****- FUNCIONES -****- FUNCIONES -****- FUNCIONES -****- FUNCIONES -****- FUNCIONES -****- FUNCIONES -****- FUNCIONES -****- FUNCIONES -****- FUNCIONES -****- FUNCIONES -****- FUNCIONES -****- FUNCIONES -****- FUNCIONES -****- FUNCIONES -****- FUNCIONES -****- FUNCIONES -****- FUNCIONES -****- FUNCIONES -****- FUNCIONES -****- 


    Public Function FUsuarioAgregar(ByVal _Usuario As String, ByVal _Password As String, ByVal _Nombre As String,
                                 ByVal _Apellidos As String, ByVal _FechaNacimiento As String, ByVal _Direccion As String,
                                 ByVal _Tipo As String, ByVal _FechaRegistro As String) As Boolean

        Consulta.Connection = Conexion
        Consulta.CommandText = "INSERT INTO Usuario (IdUsuario, Pass, Nombre, Apellidos, FechaNacimiento, Direccion, Tipo, FechaRegistro) values('" & _Usuario & "','" & _Password & "','" & _Nombre & "','" & _Apellidos & "','" & _FechaNacimiento & "','" & _Direccion & "','" & _Tipo & "','" & _FechaRegistro & "')"
        DBopen()
        Try
            Consulta.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("No se pudo guardar el registro! " + ex.ToString, vbCritical + vbOKOnly, "Error")
            DBclose()
            Return False
            Exit Function
        End Try
        DBclose()
        MsgBox("¡Usuario guardado correctamente! ", vbInformation + vbOKOnly, "Información")
        Return True
    End Function

    Public Function FUsuarioCosultar(ByVal _UsuarioId As String) As Boolean

    End Function

    Public Function FUsuarioTodos()
        'Consulta.CommandText = ""
    End Function

End Module
