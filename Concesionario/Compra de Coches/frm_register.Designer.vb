<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_register
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txb_contraseña = New System.Windows.Forms.TextBox()
        Me.txb_usuario = New System.Windows.Forms.TextBox()
        Me.txb_ocupacion = New System.Windows.Forms.TextBox()
        Me.txb_correo = New System.Windows.Forms.TextBox()
        Me.txb_celular = New System.Windows.Forms.TextBox()
        Me.txb_apellidos = New System.Windows.Forms.TextBox()
        Me.txb_nombre = New System.Windows.Forms.TextBox()
        Me.txb_cedula = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_register = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.BackgroundImage = Global.Compra_de_Coches.My.Resources.Resources.FondoR
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.txb_contraseña)
        Me.Panel2.Controls.Add(Me.txb_usuario)
        Me.Panel2.Controls.Add(Me.txb_ocupacion)
        Me.Panel2.Controls.Add(Me.txb_correo)
        Me.Panel2.Controls.Add(Me.txb_celular)
        Me.Panel2.Controls.Add(Me.txb_apellidos)
        Me.Panel2.Controls.Add(Me.txb_nombre)
        Me.Panel2.Controls.Add(Me.txb_cedula)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.btn_register)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(74, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(362, 363)
        Me.Panel2.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(254, 324)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txb_contraseña
        '
        Me.txb_contraseña.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txb_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txb_contraseña.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_contraseña.Location = New System.Drawing.Point(101, 286)
        Me.txb_contraseña.Name = "txb_contraseña"
        Me.txb_contraseña.PlaceholderText = "Contraseña"
        Me.txb_contraseña.Size = New System.Drawing.Size(183, 22)
        Me.txb_contraseña.TabIndex = 10
        '
        'txb_usuario
        '
        Me.txb_usuario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txb_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txb_usuario.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_usuario.Location = New System.Drawing.Point(101, 257)
        Me.txb_usuario.Name = "txb_usuario"
        Me.txb_usuario.PlaceholderText = "Usuario"
        Me.txb_usuario.Size = New System.Drawing.Size(183, 22)
        Me.txb_usuario.TabIndex = 9
        '
        'txb_ocupacion
        '
        Me.txb_ocupacion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txb_ocupacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txb_ocupacion.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_ocupacion.Location = New System.Drawing.Point(101, 228)
        Me.txb_ocupacion.Name = "txb_ocupacion"
        Me.txb_ocupacion.PlaceholderText = "Ocupación"
        Me.txb_ocupacion.Size = New System.Drawing.Size(183, 22)
        Me.txb_ocupacion.TabIndex = 8
        '
        'txb_correo
        '
        Me.txb_correo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txb_correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txb_correo.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_correo.Location = New System.Drawing.Point(101, 199)
        Me.txb_correo.Name = "txb_correo"
        Me.txb_correo.PlaceholderText = "Correo"
        Me.txb_correo.Size = New System.Drawing.Size(183, 22)
        Me.txb_correo.TabIndex = 7
        '
        'txb_celular
        '
        Me.txb_celular.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txb_celular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txb_celular.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_celular.Location = New System.Drawing.Point(101, 170)
        Me.txb_celular.Name = "txb_celular"
        Me.txb_celular.PlaceholderText = "Celular"
        Me.txb_celular.Size = New System.Drawing.Size(183, 22)
        Me.txb_celular.TabIndex = 6
        '
        'txb_apellidos
        '
        Me.txb_apellidos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txb_apellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txb_apellidos.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_apellidos.Location = New System.Drawing.Point(101, 141)
        Me.txb_apellidos.Name = "txb_apellidos"
        Me.txb_apellidos.PlaceholderText = "Apellidos"
        Me.txb_apellidos.Size = New System.Drawing.Size(183, 22)
        Me.txb_apellidos.TabIndex = 5
        '
        'txb_nombre
        '
        Me.txb_nombre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txb_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txb_nombre.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_nombre.Location = New System.Drawing.Point(101, 112)
        Me.txb_nombre.Name = "txb_nombre"
        Me.txb_nombre.PlaceholderText = "Nombre"
        Me.txb_nombre.Size = New System.Drawing.Size(183, 22)
        Me.txb_nombre.TabIndex = 4
        '
        'txb_cedula
        '
        Me.txb_cedula.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txb_cedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txb_cedula.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_cedula.Location = New System.Drawing.Point(101, 83)
        Me.txb_cedula.Name = "txb_cedula"
        Me.txb_cedula.PlaceholderText = "Cédula"
        Me.txb_cedula.Size = New System.Drawing.Size(183, 22)
        Me.txb_cedula.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(146, 324)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_register
        '
        Me.btn_register.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_register.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_register.Location = New System.Drawing.Point(21, 324)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(102, 23)
        Me.btn_register.TabIndex = 1
        Me.btn_register.Text = "Registrarse"
        Me.btn_register.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Compra_de_Coches.My.Resources.Resources.Register
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(160, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(75, 74)
        Me.Panel1.TabIndex = 0
        '
        'frm_register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(517, 387)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(533, 426)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(533, 426)
        Me.Name = "frm_register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_register"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents txb_contraseña As TextBox
    Friend WithEvents txb_usuario As TextBox
    Friend WithEvents txb_ocupacion As TextBox
    Friend WithEvents txb_correo As TextBox
    Friend WithEvents txb_celular As TextBox
    Friend WithEvents txb_apellidos As TextBox
    Friend WithEvents txb_nombre As TextBox
    Friend WithEvents txb_cedula As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_register As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
End Class
