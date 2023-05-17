Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hidenSubmenu()
    End Sub

    Private Sub hidenSubmenu()
        PanelMediaSubmenu.Visible = False ' Para ocultar los paneles de submenu
    End Sub
    Private Sub showSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hidenSubmenu() 'Para ocultar algun submenu abierto
            submenu.Visible = True
        Else
            submenu.Visible = False 'Si esta visible, que lo oculte
        End If
    End Sub

    Private Sub btnMedia_Click(sender As Object, e As EventArgs) Handles btnMedia.Click
        showSubmenu(PanelMediaSubmenu)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openChildForm(New Form2) 'Para instanciar el formulario creado
        '...
        'aqui iria mi codigo
        '...
        hidenSubmenu()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        openChildForm(New Form2) 'Para instanciar el formulario creado
        '...
        'aqui iria mi codigo
        '...
        hidenSubmenu()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '...
        'aqui iria mi codigo
        '...
        hidenSubmenu()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '...
        'aqui iria mi codigo
        '...
        hidenSubmenu()
    End Sub

    'Para abrir un unico formulario contenedor 
    Private currentForm As Form = Nothing 'Para almacenar el formulario que se abre
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close() 'Si existe un formulario abierto, se cierra
        currentForm = childForm 'Para guardar el formulario que se abre
        childForm.TopLevel = False 'Para que el formulario se comporte como un control
        childForm.FormBorderStyle = FormBorderStyle.None 'Para quitar borde de formulario
        childForm.Dock = DockStyle.Fill 'Para rellenar todo el panel contenedor
        PanelChildForm.Controls.Add(childForm) 'Se agrega el formulario a la lista del contenedor
        childForm.BringToFront() 'Por si se tiene el logo, se trae el formulario hacia el frente
        childForm.Show() 'Para mostrar el formulario hijo
    End Sub
End Class
