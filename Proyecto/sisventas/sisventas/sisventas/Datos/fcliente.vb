Imports System.Data.SqlClient
Public Class fcliente
    'incluiremos a la clase conexión
    Inherits conexion
    'declaramos variable para enviar peticiones a la db
    Dim cmd As New SqlCommand
    'ahora declaramos la funcion publica MOSTRAR
    Public Function mostrar() As DataTable '(mostraremos una tabla)
        Try
            conectado()
            cmd = New SqlCommand("mostrar_cliente") 'llamamos a un procedimiento almacenado*
            cmd.CommandType = CommandType.StoredProcedure
            'ahora llamamos la cadena de conexion cnn
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then 'datos en memoria
                Dim dt As New DataTable 'permite crear una tabla en memoria de los registros cliente en dt
                Dim da As New SqlDataAdapter(cmd) 'permite ser el puente desde la base de datos y mostrar en la aplicacion
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    'nueva funcion que traerá todos los valores de vcliente en dts, devolviendo valor verdadero o falso
    Public Function insertar(ByVal dts As vcliente) As Boolean
        Try
            conectado()                                    'nos conectamos a la db
            cmd = New SqlCommand("insertar_cliente")       'enviamos parámetro a la DB (comando) (proceso almacenado)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn                           'nos conectamos

            'ahora enviamos los valores al procedimiento almacenado insertar_cliente
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellidos", dts.gapellidos)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@dni", dts.gdni)

            'declaramos una condicional
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

End Class
