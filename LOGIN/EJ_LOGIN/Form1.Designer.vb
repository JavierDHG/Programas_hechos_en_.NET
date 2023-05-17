<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_register = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.chb_mostrar = New System.Windows.Forms.CheckBox()
        Me.txb_password = New System.Windows.Forms.TextBox()
        Me.txb_user = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.EJ_LOGIN.My.Resources.Resources.User_Login
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 207)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btn_register)
        Me.GroupBox1.Controls.Add(Me.btn_exit)
        Me.GroupBox1.Controls.Add(Me.btn_login)
        Me.GroupBox1.Controls.Add(Me.chb_mostrar)
        Me.GroupBox1.Controls.Add(Me.txb_password)
        Me.GroupBox1.Controls.Add(Me.txb_user)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(228, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 217)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btn_register
        '
        Me.btn_register.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_register.Location = New System.Drawing.Point(146, 141)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(87, 32)
        Me.btn_register.TabIndex = 7
        Me.btn_register.Text = "Register"
        Me.btn_register.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_exit.Location = New System.Drawing.Point(280, 141)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 32)
        Me.btn_exit.TabIndex = 6
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_login
        '
        Me.btn_login.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_login.Location = New System.Drawing.Point(25, 141)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(75, 32)
        Me.btn_login.TabIndex = 5
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'chb_mostrar
        '
        Me.chb_mostrar.AutoSize = True
        Me.chb_mostrar.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chb_mostrar.ForeColor = System.Drawing.Color.White
        Me.chb_mostrar.Location = New System.Drawing.Point(107, 85)
        Me.chb_mostrar.Name = "chb_mostrar"
        Me.chb_mostrar.Size = New System.Drawing.Size(177, 23)
        Me.chb_mostrar.TabIndex = 4
        Me.chb_mostrar.Text = "Mostrar contraseña"
        Me.chb_mostrar.UseVisualStyleBackColor = True
        '
        'txb_password
        '
        Me.txb_password.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txb_password.Location = New System.Drawing.Point(107, 52)
        Me.txb_password.Name = "txb_password"
        Me.txb_password.Size = New System.Drawing.Size(188, 27)
        Me.txb_password.TabIndex = 3
        '
        'txb_user
        '
        Me.txb_user.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txb_user.Location = New System.Drawing.Point(107, 23)
        Me.txb_user.Name = "txb_user"
        Me.txb_user.Size = New System.Drawing.Size(188, 27)
        Me.txb_user.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(615, 231)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "INICIO DE SESION"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_login As Button
    Friend WithEvents chb_mostrar As CheckBox
    Friend WithEvents txb_password As TextBox
    Friend WithEvents txb_user As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_register As Button
End Class
