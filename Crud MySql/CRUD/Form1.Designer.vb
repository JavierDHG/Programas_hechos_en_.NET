<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Inventario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txb_codigo = New System.Windows.Forms.TextBox()
        Me.txb_nombre = New System.Windows.Forms.TextBox()
        Me.txb_costo = New System.Windows.Forms.TextBox()
        Me.txb_descripcion = New System.Windows.Forms.TextBox()
        Me.txb_existencias = New System.Windows.Forms.TextBox()
        Me.txb_precio = New System.Windows.Forms.TextBox()
        Me.txb_obs = New System.Windows.Forms.TextBox()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.dgv_Inventario = New System.Windows.Forms.DataGridView()
        Me.txb_busqueda = New System.Windows.Forms.TextBox()
        CType(Me.dgv_Inventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txb_codigo
        '
        Me.txb_codigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.txb_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txb_codigo.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_codigo.ForeColor = System.Drawing.Color.White
        Me.txb_codigo.Location = New System.Drawing.Point(12, 25)
        Me.txb_codigo.Name = "txb_codigo"
        Me.txb_codigo.PlaceholderText = "Codigo del producto"
        Me.txb_codigo.Size = New System.Drawing.Size(268, 28)
        Me.txb_codigo.TabIndex = 0
        '
        'txb_nombre
        '
        Me.txb_nombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.txb_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txb_nombre.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_nombre.ForeColor = System.Drawing.Color.White
        Me.txb_nombre.Location = New System.Drawing.Point(12, 59)
        Me.txb_nombre.Name = "txb_nombre"
        Me.txb_nombre.PlaceholderText = "Nombre del Producto"
        Me.txb_nombre.Size = New System.Drawing.Size(268, 28)
        Me.txb_nombre.TabIndex = 1
        '
        'txb_costo
        '
        Me.txb_costo.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.txb_costo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txb_costo.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_costo.ForeColor = System.Drawing.Color.White
        Me.txb_costo.Location = New System.Drawing.Point(12, 127)
        Me.txb_costo.Name = "txb_costo"
        Me.txb_costo.PlaceholderText = "Costo del producto"
        Me.txb_costo.Size = New System.Drawing.Size(268, 28)
        Me.txb_costo.TabIndex = 3
        '
        'txb_descripcion
        '
        Me.txb_descripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.txb_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txb_descripcion.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_descripcion.ForeColor = System.Drawing.Color.White
        Me.txb_descripcion.Location = New System.Drawing.Point(12, 93)
        Me.txb_descripcion.Name = "txb_descripcion"
        Me.txb_descripcion.PlaceholderText = "Descripcion del producto"
        Me.txb_descripcion.Size = New System.Drawing.Size(268, 28)
        Me.txb_descripcion.TabIndex = 2
        '
        'txb_existencias
        '
        Me.txb_existencias.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.txb_existencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txb_existencias.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_existencias.ForeColor = System.Drawing.Color.White
        Me.txb_existencias.Location = New System.Drawing.Point(12, 195)
        Me.txb_existencias.Name = "txb_existencias"
        Me.txb_existencias.PlaceholderText = "Numero de existencias"
        Me.txb_existencias.Size = New System.Drawing.Size(268, 28)
        Me.txb_existencias.TabIndex = 5
        '
        'txb_precio
        '
        Me.txb_precio.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.txb_precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txb_precio.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_precio.ForeColor = System.Drawing.Color.White
        Me.txb_precio.Location = New System.Drawing.Point(12, 161)
        Me.txb_precio.Name = "txb_precio"
        Me.txb_precio.PlaceholderText = "Precio del producto"
        Me.txb_precio.Size = New System.Drawing.Size(268, 28)
        Me.txb_precio.TabIndex = 4
        '
        'txb_obs
        '
        Me.txb_obs.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.txb_obs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txb_obs.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_obs.ForeColor = System.Drawing.Color.White
        Me.txb_obs.Location = New System.Drawing.Point(12, 229)
        Me.txb_obs.Name = "txb_obs"
        Me.txb_obs.PlaceholderText = "Observacion"
        Me.txb_obs.Size = New System.Drawing.Size(268, 28)
        Me.txb_obs.TabIndex = 6
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_nuevo.FlatAppearance.BorderSize = 0
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_nuevo.ForeColor = System.Drawing.Color.White
        Me.btn_nuevo.Location = New System.Drawing.Point(354, 50)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(248, 37)
        Me.btn_nuevo.TabIndex = 7
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_guardar.FlatAppearance.BorderSize = 0
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Location = New System.Drawing.Point(354, 93)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(248, 37)
        Me.btn_guardar.TabIndex = 8
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_eliminar.FlatAppearance.BorderSize = 0
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_eliminar.ForeColor = System.Drawing.Color.White
        Me.btn_eliminar.Location = New System.Drawing.Point(354, 179)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(248, 37)
        Me.btn_eliminar.TabIndex = 10
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_editar.FlatAppearance.BorderSize = 0
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_editar.ForeColor = System.Drawing.Color.White
        Me.btn_editar.Location = New System.Drawing.Point(354, 136)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(248, 37)
        Me.btn_editar.TabIndex = 9
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'dgv_Inventario
        '
        Me.dgv_Inventario.AllowUserToAddRows = False
        Me.dgv_Inventario.AllowUserToDeleteRows = False
        Me.dgv_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Inventario.Location = New System.Drawing.Point(12, 263)
        Me.dgv_Inventario.Name = "dgv_Inventario"
        Me.dgv_Inventario.ReadOnly = True
        Me.dgv_Inventario.RowTemplate.Height = 25
        Me.dgv_Inventario.Size = New System.Drawing.Size(744, 150)
        Me.dgv_Inventario.TabIndex = 11
        '
        'txb_busqueda
        '
        Me.txb_busqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.txb_busqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txb_busqueda.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_busqueda.ForeColor = System.Drawing.Color.White
        Me.txb_busqueda.Location = New System.Drawing.Point(354, 229)
        Me.txb_busqueda.Name = "txb_busqueda"
        Me.txb_busqueda.PlaceholderText = "Buscar"
        Me.txb_busqueda.Size = New System.Drawing.Size(402, 28)
        Me.txb_busqueda.TabIndex = 12
        '
        'frm_Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(879, 450)
        Me.Controls.Add(Me.txb_busqueda)
        Me.Controls.Add(Me.dgv_Inventario)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.txb_obs)
        Me.Controls.Add(Me.txb_existencias)
        Me.Controls.Add(Me.txb_precio)
        Me.Controls.Add(Me.txb_costo)
        Me.Controls.Add(Me.txb_descripcion)
        Me.Controls.Add(Me.txb_nombre)
        Me.Controls.Add(Me.txb_codigo)
        Me.Name = "frm_Inventario"
        Me.Text = "Inventario"
        CType(Me.dgv_Inventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txb_codigo As TextBox
    Friend WithEvents txb_nombre As TextBox
    Friend WithEvents txb_costo As TextBox
    Friend WithEvents txb_descripcion As TextBox
    Friend WithEvents txb_existencias As TextBox
    Friend WithEvents txb_precio As TextBox
    Friend WithEvents txb_obs As TextBox
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents dgv_Inventario As DataGridView
    Friend WithEvents txb_busqueda As TextBox
End Class
