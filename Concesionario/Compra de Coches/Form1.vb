Imports MySql.Data.MySqlClient

Public Class frm_Inicio

#Region "Variables"
    Private cmb As MySqlCommandBuilder
    Public usuariolog As String
    Dim conn As New MySqlConnection
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim lista As Byte
    Dim consulta As String
    Dim entrada As String
    Dim odataset As New DataSet
    Dim sw As Boolean = False

#End Region

#Region "Conexion"
    Public Sub conectar()
        Try
            conn.ConnectionString = "server=localhost;user=root;password=;database=concesionario"
            conn.Open()
            consulta = "Select * from usuarios"
            MsgBox("Conexion establecida")
        Catch ex As Exception
            MsgBox("Algo fallo" + ex.ToString)
            Me.Close()
        End Try
    End Sub

    Private Sub frm_Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        txb_password.PasswordChar = ("*")
    End Sub
#End Region

#Region "Validar Usuario"
    Function ValidarUser(ByVal user As String, ByVal pass As String) As Boolean
        Try
            odataset.Clear()
            consulta = "select * from usuarios where Usuario='" & user & "' and Contraseña='" & pass & "'"
            adaptador = New MySqlDataAdapter(consulta, conn)
            adaptador.Fill(odataset, "usuarios")
            If (odataset.Tables("usuarios").Rows.Count() <> 0) Then
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
#End Region

#Region "Mostrar contraseña"
    Private Sub chb_mostrar_CheckedChanged(sender As Object, e As EventArgs) Handles chb_mostrar.CheckedChanged
        If chb_mostrar.Checked Then
            txb_password.PasswordChar = ("")
        Else
            txb_password.PasswordChar = ("*")
        End If
    End Sub
#End Region

#Region "Registrar"
    Private Sub llb_register_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llb_register.LinkClicked
        frm_register.Show()
        Me.Hide()
    End Sub
#End Region

#Region "Login"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ValidarUser(txb_user.Text, txb_password.Text)) Then
            frm_Menuprincipal.Show()
            Me.Hide()
        End If
    End Sub
#End Region

End Class
