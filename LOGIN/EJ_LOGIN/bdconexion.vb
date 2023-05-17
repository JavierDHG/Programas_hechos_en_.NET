Imports MySql.Data.MySqlClient
Public Class bdconexion
    Dim cad As String
    Dim cn As MySqlConnection
    Public Sub conabrir()
        cad = "Server=localhost; database=login; uid=root; pwd=; port=3306"
        cn = New MySqlConnection(cad)
        cn.Open()
    End Sub
    Public Sub concerrar()
        cn.Close()
        cn.Dispose()
    End Sub
    Public Function cadena() As String
        cadena = cad
    End Function
    Public Function objetocn() As MySqlConnection
        objetocn = cn
    End Function
End Class
