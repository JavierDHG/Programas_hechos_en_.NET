<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Inicio
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.llb_register = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chb_mostrar = New System.Windows.Forms.CheckBox()
        Me.txb_password = New System.Windows.Forms.TextBox()
        Me.txb_user = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.llb_register)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.chb_mostrar)
        Me.Panel1.Controls.Add(Me.txb_password)
        Me.Panel1.Controls.Add(Me.txb_user)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(94, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(254, 269)
        Me.Panel1.TabIndex = 0
        '
        'llb_register
        '
        Me.llb_register.ActiveLinkColor = System.Drawing.Color.SteelBlue
        Me.llb_register.AutoSize = True
        Me.llb_register.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.llb_register.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.llb_register.LinkColor = System.Drawing.Color.White
        Me.llb_register.Location = New System.Drawing.Point(73, 200)
        Me.llb_register.Margin = New System.Windows.Forms.Padding(3)
        Me.llb_register.Name = "llb_register"
        Me.llb_register.Size = New System.Drawing.Size(91, 19)
        Me.llb_register.TabIndex = 5
        Me.llb_register.TabStop = True
        Me.llb_register.Text = "Registrarme"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Compra_de_Coches.My.Resources.Resources.User_Login
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Location = New System.Drawing.Point(73, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(105, 89)
        Me.Panel2.TabIndex = 4
        '
        'chb_mostrar
        '
        Me.chb_mostrar.AutoSize = True
        Me.chb_mostrar.BackColor = System.Drawing.Color.Transparent
        Me.chb_mostrar.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chb_mostrar.ForeColor = System.Drawing.Color.White
        Me.chb_mostrar.Location = New System.Drawing.Point(3, 173)
        Me.chb_mostrar.Name = "chb_mostrar"
        Me.chb_mostrar.Size = New System.Drawing.Size(152, 21)
        Me.chb_mostrar.TabIndex = 3
        Me.chb_mostrar.Text = "Mostrar contraseña"
        Me.chb_mostrar.UseVisualStyleBackColor = False
        '
        'txb_password
        '
        Me.txb_password.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.txb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txb_password.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_password.Location = New System.Drawing.Point(3, 145)
        Me.txb_password.Name = "txb_password"
        Me.txb_password.PlaceholderText = "Contraseña"
        Me.txb_password.Size = New System.Drawing.Size(246, 22)
        Me.txb_password.TabIndex = 2
        '
        'txb_user
        '
        Me.txb_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.txb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txb_user.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_user.Location = New System.Drawing.Point(3, 98)
        Me.txb_user.Name = "txb_user"
        Me.txb_user.PlaceholderText = "Usuario"
        Me.txb_user.Size = New System.Drawing.Size(246, 22)
        Me.txb_user.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(83, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Compra_de_Coches.My.Resources.Resources.Login_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(440, 379)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(456, 418)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(456, 418)
        Me.Name = "frm_Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txb_password As TextBox
    Friend WithEvents txb_user As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents chb_mostrar As CheckBox
    Friend WithEvents llb_register As LinkLabel
    Friend WithEvents Panel2 As Panel
End Class
