Imports System.Data
Imports System.Data.OleDb

Module DataBaseCenter
    Private Conexion As New OleDbConnection     'Veriable de conexion a la basse de datos
    Private Consulta As New OleDbCommand        'Variable para consultas SQL
    Private Adaptador As New OleDbDataAdapter   'Adaptador para recibir consultas
    Private Tabla As New DataTable              'Tabla donde se almacena resultados de consulta


    '-- FUN DBopen ----- FUN DBopen ----- FUN DBopen ----- FUN DBopen ----- FUN DBopen ----- FUN DBopen ----- FUN DBopen ----- FUN DBopen ----- FUN DBopen ----- FUN DBopen ----- FUN DBopen ----- FUN DBopen ----- FUN DBopen ----- FUN DBopen ----- FUN DBopen ----- FUN DBopen ----- FUN DBopen ----- FUN DBopen ----- FUN DBopen ----- FUN DBopen ---
    Public Sub DBopen()
        'Conexion a la base de datos User: Administrador  Pasword: 82497EEW
        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb; User Id=Admin;Password=;"
                Consulta.Connection = Conexion      'Se le asicna a comando consulta la conexion existente a la DB
                Adaptador.SelectCommand.Connection = Conexion   'Se le asigna la coneccion al adaptador
                Conexion.Open()                     'Abre la Conexion a la DB
            End If
        Catch ex As Exception
            'Si hay error al estblecer la conexion ala base de datos arroja mensaje de error
            MsgBox("No se pudo conectar con la Base de Datos! " + ex.ToString, vbCritical + vbOKOnly, "Error")
            Exit Sub
        End Try
    End Sub
    '***********************************************************************************************************************************************************************************************************************************************************************************************************************************************************



    '-- FUN DBclose ---- FUN DBclose ---- FUN DBclose ---- FUN DBclose ---- FUN DBclose ---- FUN DBclose ---- FUN DBclose ---- FUN DBclose ---- FUN DBclose ---- FUN DBclose ---- FUN DBclose ---- FUN DBclose ---- FUN DBclose ---- FUN DBclose ---- FUN DBclose ---- FUN DBclose ---- FUN DBclose ---- FUN DBclose ---- FUN DBclose ---- FUN DBclose --
    Public Sub DBclose()
        Try
            'Cerrar la conexion si esta abierta
            If Conexion.State = ConnectionState.Open Then

                Conexion.Close() 'Cerrar la conexion
                Conexion.Dispose() 'Liberar recursos

            End If
        Catch ex As Exception
            MsgBox("Error al intentar cerrar conexion con la DB : " + ex.Message.ToString, vbCritical, "Información")
        End Try
    End Sub
    '***********************************************************************************************************************************************************************************************************************************************************************************************************************************************************



    '--- FUN FUsuarioAgregar ------ FUN FUsuarioAgregar ------ FUN FUsuarioAgregar ------ FUN FUsuarioAgregar ------ FUN FUsuarioAgregar ------ FUN FUsuarioAgregar ------ FUN FUsuarioAgregar ------ FUN FUsuarioAgregar ------ FUN FUsuarioAgregar ------ FUN FUsuarioAgregar ------ FUN FUsuarioAgregar ------ FUN FUsuarioAgregar ------ FUN FUsuarioAgregar
    Public Function FUsuarioAgregar(ByVal _Usuario As String, ByVal _Password As String, ByVal _Nombre As String,
                                 ByVal _Apellidos As String, ByVal _FechaNacimiento As String, ByVal _Direccion As String,
                                 ByVal _Tipo As String, ByVal _FechaRegistro As String) As Boolean

        'Se establece la consulta SQL al comando Consulta
        Consulta.CommandText = "INSERT INTO Usuario (IdUsuario, Pass, Nombre, Apellidos, FechaNacimiento, Direccion, Tipo, FechaRegistro) values('" & _Usuario & "','" & _Password & "','" & _Nombre & "','" & _Apellidos & "','" & _FechaNacimiento & "','" & _Direccion & "','" & _Tipo & "','" & _FechaRegistro & "')"
        DBopen()    'Llama al metodo que abre la conexion a la DB
        Try
            Consulta.ExecuteNonQuery()      'Ejecuta la consulta SQL almacenada en el comando Consulta
        Catch ex As Exception
            'Si hay problemas al crear el registro
            MsgBox("No se pudo guardar el registro! " + ex.ToString, vbCritical + vbOKOnly, "Error")
            DBclose()   'Llama al metodo que cierra la conexion a la DB
            Return False    'Se devulve false al componente que llamo esta funcion, indicando que no se pudo registrar el usuario
            Exit Function
        End Try
        DBclose()   'Llama al metodo que cierra la conexion a la DB
        MsgBox("¡Usuario guardado correctamente! ", vbInformation + vbOKOnly, "Información")
        Return True
    End Function
    '***********************************************************************************************************************************************************************************************************************************************************************************************************************************************************



    '--- FUN FUsuarioConsultar ------ FUN FUsuarioConsultar ------ FUN FUsuarioConsultar ------ FUN FUsuarioConsultar ------ FUN FUsuarioConsultar ------ FUN FUsuarioConsultar ------ FUN FUsuarioConsultar ------ FUN FUsuarioConsultar ------ FUN FUsuarioConsultar ------ FUN FUsuarioConsultar ------ FUN FUsuarioConsultar ------ FUN FUsuarioConsultar -
    Public Function FUsuarioCosultar(ByVal _UsuarioId As String) As Boolean
        Adaptador.SelectCommand.CommandText = "SELECT IdUsuario FROM Usuario WHERE IdUsuario = 'Liberty510'"
        DBopen()
        Adaptador.SelectCommand.ExecuteNonQuery()
        Adaptador.Fill(Tabla)

        For Each Fila As DataRow In Tabla.Rows
            MsgBox(Fila.Item(1), vbInformation, "Info")
        Next

        Return True
    End Function
    '***********************************************************************************************************************************************************************************************************************************************************************************************************************************************************



    '--- FUN FUsuarioTodos ------ FUN FUsuarioTodos ------ FUN FUsuarioTodos ------ FUN FUsuarioTodos ------ FUN FUsuarioTodos ------ FUN FUsuarioTodos ------ FUN FUsuarioTodos ------ FUN FUsuarioTodos ------ FUN FUsuarioTodos ------ FUN FUsuarioTodos ------ FUN FUsuarioTodos ------ FUN FUsuarioTodos ------ FUN FUsuarioTodos ------ FUN FUsuarioTodos
    Public Function FUsuarioTodos() As Boolean
        'Consulta.CommandText = ""
        Return True
    End Function
    '***********************************************************************************************************************************************************************************************************************************************************************************************************************************************************

End Module
