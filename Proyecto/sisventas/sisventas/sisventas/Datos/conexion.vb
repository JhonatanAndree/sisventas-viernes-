Imports System.Data.SqlClient
Public Class conexion
    'crear variable para conectar base de datos sql
    Protected cnn As New SqlConnection
    'creamos variable para que el usuario interactue con el sistema apareciendo su nombre
    Public idusuario As Integer
    'creamos funciones para conectar y desconectar dbsql
    Protected Function conectado()
        Try
            cnn = New SqlConnection("Data Source=DESKTOP-40KAEQC\SQLEXPRESS;Initial Catalog=sisventas;Integrated Security=True")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
