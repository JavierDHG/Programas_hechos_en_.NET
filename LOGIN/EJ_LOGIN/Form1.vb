Imports MySql.Data.MySqlClient
Imports System.Data
Imports MySql.Data
Public Class frm_login

    Dim conexion As New bdconexion
    Dim consulta As String
    Dim ad As MySqlDataAdapter
    Dim sw As Boolean = False
    Dim odataset As New DataSet
    Public usuariolog As String
    Dim cmd As MySqlCommand

    Private cmb As MySqlCommandBuilder
    Dim conn As New MySqlConnection
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim lista As Byte

    Function ValidarUser(ByVal user As String, ByVal pass As String) As Boolean
        Try
            odataset.Clear()
            conexion.conabrir()
            consulta = "select * from tbl_sesion where User='" & user & "' and Password='" & pass & "'"
            ad = New MySqlDataAdapter(consulta, conexion.objetocn)
            ad.Fill(odataset, "tbl_sesion")
            If (odataset.Tables("tbl_sesion").Rows.Count() <> 0) Then
                MessageBox.Show("Se ha logueado correctamente", "Confirmacion")
                sw = True
            Else
                MessageBox.Show("Datos incorrectos", "Error")
                MessageBox.Show("Intentalo nuevamente", "Error")
                txb_password.Clear()
                txb_user.Clear()
                txb_user.Focus()
            End If
        Catch ex As Exception

        End Try
        Return (sw)
        usuariolog = user
    End Function



    Public Sub conectar()
        Try
            conn.ConnectionString = "server=localhost;user=root;password=;database=crud_inventario"
            conn.Open()
            consulta = "Select * from inventario"
            adaptador = New MySqlDataAdapter(consulta, conn)
            datos = New DataSet
            adaptador.Fill(datos, "inventario")

            MsgBox("Conexion establecida")
        Catch ex As Exception
            MsgBox("Algo fallo" + ex.ToString)
            Me.Close()
        End Try
    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        If (ValidarUser(txb_user.Text, txb_password.Text)) Then
            frm_Menuprincipal.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        If MsgBox("Desea salir del sistema...", MsgBoxStyle.OkCancel, "Cerrar sesion!") = MsgBoxResult.Ok Then
            Application.Exit()
        End If

    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        txb_password.PasswordChar = ("*")
    End Sub

    Private Sub chb_mostrar_CheckedChanged(sender As Object, e As EventArgs) Handles chb_mostrar.CheckedChanged
        If chb_mostrar.Checked Then
            txb_password.PasswordChar = ("")
        Else
            txb_password.PasswordChar = ("*")
        End If
    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
    End Sub

End Class
