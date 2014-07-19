Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class DB

    'Datos MySQL
    Private UserdbM As String = "root"                  'Nombre de usuario de la Base de Datos
    Private PassworddbM As String = "82497EEW"          'Contraseña de la Base de Datos
    Private ServerdbM As String = "127.0.0.1"           'Servidor en caso de MySQL o Ubicacion en caso de Access
    Private DataBaseNameM As String = "facilventasoft"  'Nombre de la base de datos en caso de ser MySQL

    'Dato Access
    Private UserdbA As String = "Admin"                 'Nombre de usuario de la Base de Datos
    Private PassworddbA As String = ""                  'Contraseña de la Base de Datos
    Private ServerdbA As String = "db.mdb"              'Ubicacion en caso de Access

    Private DataBasetype As Byte = 1                    '1 -> MySQL     2 ->Access
    Private Conexion1 As New MySqlConnection            'Conexion a DB MySQL
    Private Conexion2 As New OleDbConnection            'Conexion a DB Access


    'Método dbOn
    Private Sub dbOn()
        If DataBasetype = 1 Then 'Base de datos MySQL
            Try
                Conexion1.ConnectionString = "Server=" & ServerdbM _
                    & "; Database=" & DataBaseNameM _
                    & "; User id=" & UserdbM _
                    & "; Password=" & PassworddbM                'Cadena de conexion a base de datos MySQL
                Conexion1.Open()                                'Abre la conexion a DB MySQL
            Catch ex As Exception
                'Si hay error al conectar con la base de datos MySL arroja el siguiente error
                MsgBox("No se pudo conectar con base de datos MySQL -> " + ex.Message, vbCritical, "Información")
                Exit Sub
            End Try
        Else                    'Base de datos Microsoft Access
            Try
                Conexion2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ServerdbA _
                    & "; User Id=" & UserdbA _
                    & ";Password=" & PassworddbA                 'Cadena de conexion a base de datos Access
                Conexion2.Open()                                'Se abre la coneccion a DB Access
            Catch ex As Exception
                'Si hay error al conectar con la base de datos Access arroja el siguiente error
                MsgBox("No se pudo conectar con base de datos Access -> " + ex.Message, vbCritical, "Información")
            End Try
        End If
    End Sub
    'Método dbOff
    Private Sub dbOff()

        If DataBasetype = 1 Then
            Try
                'Cerrar la conexion si esta abierta
                If Conexion1.State = ConnectionState.Open Then
                    Conexion1.Close() 'Cerrar la conexion
                    Conexion1.Dispose() 'Liberar recursos
                End If
            Catch ex As Exception
                'Si hay error al momento de cerrar la conexion muestra este mensaje
                MsgBox("Error al intentar cerrar la base de datos 'MySQL'! : " + ex.Message, vbCritical, "Información")
            End Try
        Else
            Try
                'Cerrar la conexion si esta abierta
                If Conexion2.State = ConnectionState.Open Then
                    Conexion2.Close() 'Cerrar la conexion
                    Conexion2.Dispose() 'Liberar recursos
                End If
            Catch ex As Exception
                'Si hay error al momento de cerrar la conexion muestra este mensaje
                MsgBox("Error al intentar cerrar la base de datos 'Access'! : " + ex.Message, vbCritical, "Información")
            End Try
        End If
    End Sub
    'Funcion Consultar
    Public Function Consultar(ByVal sql As String) As DataTable
        Dim Tabla As New DataTable(Nothing)
        Dim Respuesta1 As MySqlDataReader = Nothing     'Reader para DB MySQL
        Dim Respuesta2 As OleDbDataReader = Nothing     'Reader para DB Access
        Dim Query1 As New MySqlCommand                  'Comando para MySQL
        Dim Query2 As New OleDbCommand                  'Comando para Access

        dbOn()                                          'Se abre la conexion a la Base de datos

        If DataBasetype = 1 Then                        'Si base de datos seleccionada es MySQL
            Try
                Query1.Connection = Conexion1           'Se le asigna conexion al comando
                Query1.CommandText = sql                'Se le asigna cadena sql al comando
                Respuesta1 = Query1.ExecuteReader       'Se ejecuta el reader
                Tabla.Load(Respuesta1)                  'Los datos recibidos se pasan a la tabla llamada: 'Tabla'
                Respuesta1.Close()                      'Se cierra reader MySQL
            Catch ex As Exception
                'Si hay error al momento de cerrar la conexion muestra este mensaje
                MsgBox("Error al realizar consulta a la base de datos 'MySQL'! -> " + ex.Message, vbCritical, "Información")
            End Try
        Else
            Try
                Query2.Connection = Conexion2           'Se le asigna conexion al comando
                Query2.CommandText = sql                'Se le asigna cadena sql al comando
                Respuesta2 = Query2.ExecuteReader       'Se ejecuta el reader
                Tabla.Load(Respuesta2)                  'Los datos recibidos se pasan a la tabla llamada: 'Tabla'
                Respuesta2.Close()                      'Se cierra reader Access
            Catch ex As Exception
                'Si hay error al momento de cerrar la conexion muestra este mensaje
                MsgBox("Error al realizar cosulta a la base de datos 'Access'! -> " + ex.Message, vbCritical, "Información")
            End Try
        End If

        dbOff()                                     'Se cierra la Conexxion y se liberan los recursos
        Return Tabla                                'Se devuelve tabla con resultados de la consulta
    End Function
    'Funcion Ejecutar
    Public Function Ejecutar(ByVal sql As String) As Integer
        Dim Query1 As New MySqlCommand                  'Comando para MySQL
        Dim Query2 As New OleDbCommand                  'Comando para Access
        Dim Filas As Integer                            'Filas afectadas por sentencia SQL

        dbOn()                                          'Se abre la conexion a la Base de datos

        If DataBasetype = 1 Then                        'Si base de datos seleccionada es MySQL
            Try
                Query1.Connection = Conexion1           'Se le asigna conexion al comando
                Query1.CommandText = sql                'Se le asigna cadena sql al comando
                Filas = Query1.ExecuteNonQuery          'Almacena resultado de filas afectadas
            Catch ex As Exception
                'Si hay error al momento de cerrar la conexion muestra este mensaje
                MsgBox("Error al realizar consulta a la base de datos 'MySQL'! -> " + ex.Message, vbCritical, "Información")
            End Try
        Else
            Try
                Query2.Connection = Conexion2           'Se le asigna conexion al comando
                Query2.CommandText = sql                'Se le asigna cadena sql al comando
                Filas = Query2.ExecuteNonQuery          'Almacena resultado de filas afectadas
            Catch ex As Exception
                'Si hay error al momento de cerrar la conexion muestra este mensaje
                MsgBox("Error al realizar cosulta a la base de datos 'Access'! -> " + ex.Message, vbCritical, "Información")
            End Try
        End If

        dbOff()                                         'Se cierra la Conexxion y se liberan los recursos
        Return Filas
    End Function

End Class
