Imports MySql.Data.MySqlClient
Public Class frm_register

#Region "Variables"
    Private cmb As MySqlCommandBuilder
    Dim conn As New MySqlConnection
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim lista As Byte
    Dim consulta As String
    Dim entrada As String
    Dim DT As New DataTable
#End Region

#Region "Conexion"
    Public Sub conectar()
        Try
            conn.ConnectionString = "server=localhost;user=root;password=;database=concesionario"
            conn.Open()
            consulta = "Select * from usuarios"
        Catch ex As Exception
            MsgBox("Algo fallo" + ex.ToString)
            Me.Close()
        End Try
    End Sub

    Private Sub frm_register(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        txb_contraseña.PasswordChar = "*"
    End Sub
#End Region

#Region "Registrarse"
    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        If (txb_cedula.Text = "") Or (txb_nombre.Text = "") Or (txb_apellidos.Text = "") Or (txb_celular.Text = "") Or (txb_correo.Text = "") Or (txb_ocupacion.Text = "") Or (txb_usuario.Text = "") Or (txb_contraseña.Text = "") Then
            MsgBox("Upsss, campos vacios", MsgBoxStyle.Information, "Confirmar")
        Else
            Try
                consulta = "Select * from usuarios WHERE Cedula ='" & txb_cedula.Text & "'"
                adaptador = New MySqlDataAdapter(consulta, conn)
                datos = New DataSet
                adaptador.Fill(datos, "usuarios")
                lista = datos.Tables("usuarios").Rows.Count

                If lista <> 0 Then
                    MsgBox("Ya existe este articulo en la base de datos", MsgBoxStyle.Information, "Confirmar")
                    BorrarCampos()
                Else
                    entrada = "Insert into usuarios (Cedula,Nombre,Apellidos,Celular,Correo,Ocupación,Usuario,Contraseña)
                    Values ('" + txb_cedula.Text + "','" + txb_nombre.Text + "','" + txb_apellidos.Text + "','" + txb_celular.Text + "',
                    '" + txb_correo.Text + "','" + txb_ocupacion.Text + "','" + txb_usuario.Text + "','" + txb_contraseña.Text + "')"

                    adaptador = New MySqlDataAdapter(entrada, conn)
                    adaptador.Fill(DT)
                    conn.Close()
                    MsgBox("Se ha insertado correctamente", MsgBoxStyle.Information, "Confirmar")
                    BorrarCampos()
                End If

            Catch ex As Exception
                MsgBox("Error Critico, no se inserto el dato", MsgBoxStyle.Critical, "Error" + ex.Message)
            Finally
                conn.Dispose()
            End Try
        End If
    End Sub
#End Region

#Region "Borrar los campos"
    Public Sub BorrarCampos()
        txb_cedula.Text = ""
        txb_nombre.Text = ""
        txb_apellidos.Text = ""
        txb_celular.Text = ""
        txb_correo.Text = ""
        txb_ocupacion.Text = ""
        txb_usuario.Text = ""
        txb_contraseña.Text = ""
    End Sub
#End Region

#Region "Salir"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Desea salir del sistema...", MsgBoxStyle.OkCancel, "Cerrar sesion!") = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub
#End Region

#Region "Volver"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_Inicio.Show()
        Me.Hide()
    End Sub
#End Region
End Class