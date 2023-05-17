<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PanelSideMenu = New System.Windows.Forms.Panel()
        Me.PanelMediaSubmenu = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnMedia = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.PanelSideMenu.SuspendLayout()
        Me.PanelMediaSubmenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSideMenu
        '
        Me.PanelSideMenu.AutoScroll = True
        Me.PanelSideMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PanelSideMenu.Controls.Add(Me.PanelMediaSubmenu)
        Me.PanelSideMenu.Controls.Add(Me.btnMedia)
        Me.PanelSideMenu.Controls.Add(Me.PanelLogo)
        Me.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideMenu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PanelSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(250, 561)
        Me.PanelSideMenu.TabIndex = 0
        '
        'PanelMediaSubmenu
        '
        Me.PanelMediaSubmenu.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PanelMediaSubmenu.Controls.Add(Me.Button4)
        Me.PanelMediaSubmenu.Controls.Add(Me.Button3)
        Me.PanelMediaSubmenu.Controls.Add(Me.Button2)
        Me.PanelMediaSubmenu.Controls.Add(Me.Button1)
        Me.PanelMediaSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMediaSubmenu.Location = New System.Drawing.Point(0, 145)
        Me.PanelMediaSubmenu.Name = "PanelMediaSubmenu"
        Me.PanelMediaSubmenu.Size = New System.Drawing.Size(250, 165)
        Me.PanelMediaSubmenu.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Location = New System.Drawing.Point(0, 120)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(250, 40)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Button4"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(0, 80)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(250, 40)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(0, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(250, 40)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(250, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnMedia
        '
        Me.btnMedia.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnMedia.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMedia.FlatAppearance.BorderSize = 0
        Me.btnMedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedia.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMedia.Location = New System.Drawing.Point(0, 100)
        Me.btnMedia.Name = "btnMedia"
        Me.btnMedia.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnMedia.Size = New System.Drawing.Size(250, 45)
        Me.btnMedia.TabIndex = 1
        Me.btnMedia.Text = "Media"
        Me.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMedia.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(250, 100)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(58, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelChildForm
        '
        Me.PanelChildForm.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChildForm.Location = New System.Drawing.Point(250, 0)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(684, 561)
        Me.PanelChildForm.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 561)
        Me.Controls.Add(Me.PanelChildForm)
        Me.Controls.Add(Me.PanelSideMenu)
        Me.MinimumSize = New System.Drawing.Size(950, 600)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelSideMenu.ResumeLayout(False)
        Me.PanelMediaSubmenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSideMenu As Panel
    Friend WithEvents PanelMediaSubmenu As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnMedia As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelChildForm As Panel
End Class
