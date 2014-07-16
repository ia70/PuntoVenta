Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class DB
    Private Userdb As String = "Admin"          'Nombre de usuario de la Base de Datos
    Private Passworddb As String = ""           'Contraseña de la Base de Datos
    Private Serverdb As String = "db.mdb"       'Servidor en caso de MySQL o Ubicacion en caso de Access
    Private DataBaseName As String = ""           'Nombre de la base de datos en caso de ser MySQL
    Private DataBasetype As String = "Access"   '(Access,MySQL) Son los unico dos valores posibles



    Public Function Consultar(ByVal sql As String) As OleDbDataReader
        Dim Respuesta As OleDbDataReader

        Return Respuesta
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
