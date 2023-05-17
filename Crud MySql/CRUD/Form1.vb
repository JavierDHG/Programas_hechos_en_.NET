Imports MySql.Data.MySqlClient

Public Class frm_Inventario
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
            conn.ConnectionString = "server=localhost;user=root;password=;database=crud_inventario"
            conn.Open()
            consulta = "Select * from inventario"
            adaptador = New MySqlDataAdapter(consulta, conn)
            datos = New DataSet
            adaptador.Fill(datos, "inventario")
            dgv_Inventario.DataSource = datos
            dgv_Inventario.DataMember = "inventario"
            MsgBox("Conexion establecida")
        Catch ex As Exception
            MsgBox("Algo fallo" + ex.ToString)
            Me.Close()
        End Try
    End Sub
#End Region

#Region "Inventario_Load"
    Private Sub frm_Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
    End Sub
#End Region

#Region "btn_nuevo"
    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        BorrarCampos()
        btn_guardar.Enabled = True
    End Sub
#End Region

#Region "btn_guardar"
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If (txb_codigo.Text = "") Or (txb_nombre.Text = "") Or (txb_descripcion.Text = "") Or (txb_costo.Text = "") Or (txb_precio.Text = "") Or (txb_existencias.Text = "") Or (txb_obs.Text = "") Then
            MsgBox("Upsss, campos vacios", MsgBoxStyle.Information, "Confirmar")

        Else
            Try
                consulta = "Select * from inventario WHERE codigo ='" & txb_codigo.Text & "'"
                adaptador = New MySqlDataAdapter(consulta, conn)
                datos = New DataSet
                adaptador.Fill(datos, "inventario")
                lista = datos.Tables("inventario").Rows.Count

                If lista <> 0 Then
                    MsgBox("Ya existe este articulo en la base de datos", MsgBoxStyle.Information, "Confirmar")
                    BorrarCampos()
                    MostrarDatos()
                Else
                    entrada = "Insert into inventario (codigo,articulo,descripcion,costo,venta,existencias,observaciones)
                    Values ('" + txb_codigo.Text + "','" + txb_nombre.Text + "','" + txb_descripcion.Text + "','" + txb_costo.Text + "',
                    '" + txb_precio.Text + "','" + txb_existencias.Text + "','" + txb_obs.Text + "')"

                    adaptador = New MySqlDataAdapter(entrada, conn)
                    adaptador.Fill(DT)
                    conn.Close()
                    MsgBox("Se ha insertado correctamente", MsgBoxStyle.Information, "Confirmar")
                    BorrarCampos()
                    MostrarDatos()
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
        txb_codigo.Text = ""
        txb_nombre.Text = ""
        txb_descripcion.Text = ""
        txb_costo.Text = ""
        txb_precio.Text = ""
        txb_existencias.Text = ""
        txb_obs.Text = ""
    End Sub

#End Region

#Region "Mostrar los datos"
    Public Sub mostrar(ByVal sql As String, ByVal tabla As String)
        datos.Tables.Clear()
        adaptador = New MySqlDataAdapter(sql, conn)
        cmb = New MySqlCommandBuilder(adaptador)
        adaptador.Fill(datos, tabla)

    End Sub

    Public Sub MostrarDatos()
        mostrar("Select * From inventario", "inventario")
        dgv_Inventario.DataSource = datos.Tables("inventario")
    End Sub
#End Region

#Region "btn_editar"
    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        If (txb_codigo.Text = "") Or (txb_nombre.Text = "") Or (txb_descripcion.Text = "") Or (txb_costo.Text = "") Or (txb_precio.Text = "") Or (txb_existencias.Text = "") Or (txb_obs.Text = "") Then
            MsgBox("No se puede modificar el articulo, ya que no se ha seleccionado nada", MsgBoxStyle.Information, "Confirmar")
        Else
            Dim comand As New MySqlCommand("Update inventario set articulo='" & txb_nombre.Text & "',descripcion='" & txb_descripcion.Text & "',costo='" & txb_costo.Text & "',venta='" & txb_precio.Text & "',existencias='" & txb_existencias.Text & "',observaciones='" & txb_obs.Text & "' Where codigo='" & txb_codigo.Text & "'", conn)
            comand.ExecuteNonQuery()
            MsgBox("Datos actualizados correctamente", MsgBoxStyle.Information, "Confirmar")
            BorrarCampos()
            MostrarDatos()
            btn_guardar.Enabled = True
        End If
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
#End Region

#Region "btn_eliminar"
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        If (txb_codigo.Text = "") Or (txb_nombre.Text = "") Or (txb_descripcion.Text = "") Or (txb_costo.Text = "") Or (txb_precio.Text = "") Or (txb_existencias.Text = "") Or (txb_obs.Text = "") Then
            MsgBox("No se puede eliminar el articulo, ya que no se ha seleccionado nada", MsgBoxStyle.Information, "Confirmar")
        Else
            Dim comand As New MySqlCommand("Delete from inventario Where codigo ='" & txb_codigo.Text & "'", conn)
            comand.ExecuteNonQuery()
            MsgBox("Datos eliminados correctamente", MsgBoxStyle.Information, "Confirmar")
            BorrarCampos()
            MostrarDatos()
            btn_guardar.Enabled = True
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End If
    End Sub
#End Region

#Region "Traer los datos hacia el formulario"
    Private Sub dgv_Inventario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Inventario.CellClick
        Dim ind As Integer = dgv_Inventario.CurrentRow.Index

        txb_codigo.Text = dgv_Inventario(0, ind).Value
        txb_nombre.Text = dgv_Inventario(1, ind).Value
        txb_descripcion.Text = dgv_Inventario(2, ind).Value
        txb_costo.Text = dgv_Inventario(3, ind).Value
        txb_precio.Text = dgv_Inventario(4, ind).Value
        txb_existencias.Text = dgv_Inventario(5, ind).Value
        txb_obs.Text = dgv_Inventario(6, ind).Value
        btn_guardar.Enabled = False
    End Sub
#End Region

#Region "Busqueda Dinamica"
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles txb_busqueda.TextChanged
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim entrd As String = "Select * from inventario Where codigo Like '%" & txb_busqueda.Text & "%' Or articulo Like '%" & txb_busqueda.Text & "%'"
        adaptador = New MySqlDataAdapter(entrd, conn)
        datos = New DataSet
        adaptador.Fill(datos)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            dgv_Inventario.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try

    End Sub
#End Region

End Class