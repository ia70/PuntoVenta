Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class DB
    Private Userdb As String = "Admin"          'Nombre de usuario de la Base de Datos
    Private Passworddb As String = ""           'Contraseña de la Base de Datos
    Private Serverdb As String = "db.mdb"       'Servidor en caso de MySQL o Ubicacion en caso de Access
    Private DataBaseName As String = ""           'Nombre de la base de datos en caso de ser MySQL
    Private DataBasetype As String = "Access"   '(Access,MySQL) Son los unico dos valores posibles

    Private Conexion1 As New MySqlConnection    'Conexion a DB MySQL
    Private Conexion2 As New OleDbConnection    'Conexion a DB Access



    'Método dbOn
    Private Sub dbOn()
        If DataBasetype = "MySQL" Then 'Base de datos MySQL
            Try
                Conexion1.ConnectionString = "Server=" & Serverdb _
                    & "; Database=" & DataBaseName _
                    & "; User id=" & Userdb _
                    & "; Password=" & Passworddb                'Cadena de conexion a base de datos MySQL
                Conexion1.Open()                                'Abre la conexion a DB MySQL
            Catch ex As Exception
                'Si hay error al conectar con la base de datos MySL arroja el siguiente error
                MsgBox("No se pudo conectar con base de datos MySQL : " + ex.Message, vbCritical, "Información")
                Exit Sub
            End Try
        Else                    'Base de datos Microsoft Access
            Try
                Conexion2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Serverdb _
                    & "; User Id=" & Userdb _
                    & ";Password=" & Passworddb                 'Cadena de conexion a base de datos Access
                Conexion2.Open()                                'Se abre la coneccion a DB Access
            Catch ex As 
                'Si hay error al conectar con la base de datos Access arroja el siguiente error
                MsgBox("No se pudo conectar con base de datos Access : " + ex.Message, vbCritical, "Información")
            End Try
        End If
    End Sub
    'Método dbOff
    Private Sub dbOff()

        If DataBasetype = "MySQL" Then
            Try
                'Cerrar la conexion si esta abierta
                If Conexion1.State = ConnectionState.Open Then
                    Conexion1.Close() 'Cerrar la conexion
                    Conexion1.Dispose() 'Liberar recursos
                End If
            Catch ex As Exception
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
                MsgBox("Error al intentar cerrar la base de datos 'Access'! : " + ex.Message, vbCritical, "Información")
            End Try
        End If
    End Sub

    Public Function Consultar(ByVal sql As String) As DataTable
        Dim Tabla As New DataTable
        Dim Respuesta1 As MySqlDataReader = Nothing 'Reader para DB MySQL
        Dim Respuesta2 As OleDbDataReader = Nothing 'Reader para DB Access
        Dim Query1 As MySqlCommand = Nothing        'Comando para MySQL
        Dim Query2 As OleDbCommand = Nothing        'Comando para Access

        dbOn()                                      'Se abre la conexion a la Base de datos

        If DataBasetype = "MySQL" Then              'Si base de datos seleccionada es MySQL
            Query1.Connection = Conexion1           'Se le asigna conexion al comando
            Query1.CommandText = sql                'Se le asigna cadena sql al comando
            Respuesta1 = Query1.ExecuteReader       'Se ejecuta el reader
            Tabla.Load(Respuesta1)                  'Los datos recibidos se pasan a la tabla llamada: 'Tabla'
        Else
            Query2.Connection = Conexion2
            Query2.CommandText = sql
            Respuesta2 = Query2.ExecuteReader
            Tabla.Load(Respuesta2)
        End If
        dbOff()
        Return Tabla
    End Function

    Public Function Agregar(ByVal sql As String) As Boolean

        Return True
    End Function

    Public Function Editar(ByVal sql As String) As Boolean

        Return True
    End Function

    Public Function Eliminar(ByVal sql As String) As Boolean

        Return True
    End Function
End Class
