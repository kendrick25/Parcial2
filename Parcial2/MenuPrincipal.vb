Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Data.SqlClient
Imports TallerPráctico3

Public Class MenuPrincipal
    'conexion kendrick
    Public conex As New SqlConnection("Data Source=DESKTOP-GQPJ6BS;Initial Catalog=Biblioteca;Integrated Security=True")
    'Conexion dilan
    'Public conex As New SqlConnection("Data Source=DESKTOP-8ELH4DT;Initial Catalog=Biblioteca;Integrated Security=True")

    ' Variables para guardar la posición y el tamaño del formulario
    Dim mouseDownm As Boolean = False
    Dim mouseX As Integer = 0
    Dim mouseY As Integer = 0
    Dim formWidth As Integer = 0
    Dim formHeight As Integer = 0

    ' Método para detectar cuando se presiona el mouse sobre el borde
    Private Sub Border_MouseDown(sender As Object, e As MouseEventArgs) Handles Border.MouseDown
        mouseDownm = True ' Indica que se presionó el mouse
        mouseX = e.X ' Guarda la posición X del mouse
        mouseY = e.Y ' Guarda la posición Y del mouse
        formWidth = Me.Width ' Guarda el ancho del formulario
        formHeight = Me.Height ' Guarda el alto del formulario
    End Sub

    ' Método para detectar cuando se mueve el mouse sobre el borde
    Private Sub Border_MouseMove(sender As Object, e As MouseEventArgs) Handles Border.MouseMove
        If mouseDownm Then ' Si se presionó el mouse
            Dim newWidth As Integer = formWidth + (e.X - mouseX) ' Calcula el nuevo ancho del formulario
            Dim newHeight As Integer = formHeight + (e.Y - mouseY) ' Calcula el nuevo alto del formulario
            Me.Size = New Size(newWidth, newHeight) ' Cambia el tamaño del formulario al nuevo tamaño

        Else ' Si no se presionó el mouse
            Dim val As Integer = 3
            If e.X < val And e.Y < val Then ' Si está cerca de la esquina superior izquierda
                Border.Cursor = Cursors.SizeNWSE ' Cambia el cursor a diagonal descendente
            ElseIf e.X > Border.Width - val And e.Y < val Then ' Si está cerca de la esquina superior derecha
                Border.Cursor = Cursors.SizeNESW ' Cambia el cursor a diagonal ascendente
            ElseIf e.X < val And e.Y > Border.Height - val Then ' Si está cerca de la esquina inferior izquierda
                Border.Cursor = Cursors.SizeNESW ' Cambia el cursor a diagonal ascendente
            ElseIf e.X > Border.Width - val And e.Y > Border.Height - val Then ' Si está cerca de la esquina inferior derecha
                Border.Cursor = Cursors.SizeNWSE ' Cambia el cursor a diagonal descendente
            ElseIf e.X < val Then ' Si está cerca del borde izquierdo
                Border.Cursor = Cursors.SizeWE ' Cambia el cursor a horizontal
            ElseIf e.X > Border.Width - val Then ' Si está cerca del borde derecho
                Border.Cursor = Cursors.SizeWE ' Cambia el cursor a horizontal
            ElseIf e.Y < val Then ' Si está cerca del borde superior
                Border.Cursor = Cursors.SizeNS ' Cambia el cursor a vertical
            ElseIf e.Y > Border.Height - val Then ' Si está cerca del borde inferior
                Border.Cursor = Cursors.SizeNS ' Cambia el cursor a vertical
            Else ' Si no está cerca de ningún borde
                Border.Cursor = Cursors.Arrow  ' Cambia el cursor al predeterminado
            End If
        End If
    End Sub

    ' Método para detectar cuando se suelta el mouse sobre el borde
    Private Sub Border_MouseUp(sender As Object, e As MouseEventArgs) Handles Border.MouseUp
        mouseDownm = False ' Indica que se soltó el mouse        
        Border.Cursor = Cursors.Arrow  ' Cambia el cursor al predeterminado
    End Sub


    'BOTONES DE VENTANA--------------------------------------------------------------------------------------------

    Private Sub BtnClose_Click_1(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea finalizar Todo?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            Me.Close()
        End If
    End Sub

    Private Sub BtnMax_Click_1(sender As Object, e As EventArgs) Handles BtnMax.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            'Button2.text  imagen de boton <-----
        Else
            Me.WindowState = FormWindowState.Maximized
            'Button2.text  imagen de boton <-----
        End If
    End Sub

    Private Sub BtnMin_Click_1(sender As Object, e As EventArgs) Handles BtnMin.Click
        If (Me.WindowState = FormWindowState.Normal) Or (Me.WindowState = FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub
    'Mover Ventana -------------------------------------------------------------------------------------------
    Public Enum ResizeDirection
        None = 0
        Left = 1
        TopLeft = 2
        Top = 3
        TopRight = 4
        Right = 5
        BottomRight = 6
        Bottom = 7
        BottomLeft = 8
    End Enum
    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    <DllImport("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = 2

    Private Sub MoveForm()
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub
    Private Sub MovFom_MouseDown(sender As Object, e As MouseEventArgs) Handles MovForm.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left And Me.WindowState <> FormWindowState.Maximized Then
            MoveForm()
        End If
    End Sub
    Private Sub MovFom_MouseUp(sender As Object, e As MouseEventArgs) Handles MovForm.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.WindowState = FormWindowState.Normal
        End If
        MovForm.Cursor = Cursors.Arrow
    End Sub
    ' ------------------colores de menu strip
    Private Class renderer
        Inherits ToolStripProfessionalRenderer
        Public Sub New()
            MyBase.New(New cols())
        End Sub
    End Class
    Private Class cols
        Inherits ProfessionalColorTable

        'over de menu
        Public Overrides ReadOnly Property MenuItemSelected As Color
            ' cuando el menú está seleccionado
            Get
                Return System.Drawing.Color.FromArgb(64, 64, 64) 'Elige el color que desees para el fondo del menú seleccionado
            End Get
        End Property
        Public Overrides ReadOnly Property MenuItemSelectedGradientBegin As Color
            Get
                Return System.Drawing.Color.FromArgb(64, 64, 64) 'Elige el color que desees para el inicio del gradiente del menú seleccionado
            End Get
        End Property
        'sub menu
        Public Overrides ReadOnly Property MenuItemSelectedGradientEnd As Color
            Get
                Return Color.FromArgb(64, 64, 64) 'Elige el color que desees para el final del gradiente del menú seleccionado
            End Get
        End Property
        'Seleccion de menu

        Public Overrides ReadOnly Property MenuItemPressedGradientBegin As Color
            Get
                Return Color.FromArgb(64, 64, 64) 'Elige el color que desees para el inicio del gradiente del submenú seleccionado
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemPressedGradientEnd As Color
            Get
                Return Color.FromArgb(64, 64, 64)  'Elige el color que desees para el final del gradiente del submenú seleccionado
            End Get
        End Property
    End Class
    '---------------------------------------LOAD-------------------------------------------
    Public Sub MostrarLibros()
        conex.Open()
        Dim consulta As String = "select Title,estadoLibro from Books WHERE estadoLibro='Libre'"
        Dim ejecutar As New SqlCommand(consulta, conex)
        Try
            Dim tabla As New SqlDataAdapter(ejecutar)
            Dim dss As New DataSet
            tabla.Fill(dss, "Books")
            Me.DataGridView1.DataSource = dss.Tables("Books")
            DataGridView1.Columns("Title").HeaderText = "Título del Libro"
            DataGridView1.Columns("estadoLibro").HeaderText = "Estado del Libro"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            conex.Close()
        End Try

    End Sub
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'colores de menu
        CerrarTodoToolStripMenuItem1.Visible = False
        ContForms.Visible = False
        TableLayoutPanel1.Cursor = Cursors.Arrow
        MenuStrip1.Renderer = New renderer()
        MenuStrip2.Renderer = New renderer()
        MostrarLibros()
        Dim Img As Image = My.Resources.Logo_2023
        Panel1.BackgroundImage = Img
        'nosotros visible
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False

    End Sub
    '------------------------------------------
    Private Sub BibliotecaArchivosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If ContForms.Visible = True Then
            'imagen de recursos
            Panel1.BackColor = Color.Black
            Panel1.BackgroundImage = Nothing
        Else
            'imagen de recursos
            Panel1.BackColor = Color.White
            Dim Img As Image = My.Resources.Logo_2023
            Panel1.BackgroundImage = Img
            Panel1.BackgroundImageLayout = ImageLayout.Zoom
        End If
        'nosotros visible
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Panel1.Visible = True
        If ContForms.Visible = True Then
            VerLibrosToolStripMenuItem.Text = "Ocultar Menu"

        Else
            VerLibrosToolStripMenuItem.Text = "Ver Libros"
        End If
        If ContForms.TabCount > 1 Then
            CerrarTodoToolStripMenuItem1.Visible = True
        End If
        If ContForms.TabCount = 1 Then
            CerrarTodoToolStripMenuItem1.Visible = False
        End If
    End Sub
    Private Sub VerLibrosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If ContForms.Visible = False Then
            ContForms.Visible = True
            'imagen de recursos
            Panel1.BackColor = Color.Black

            Panel1.BackgroundImage = Nothing
            'nosotros visible
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Panel1.Visible = True
        Else
            ContForms.Visible = False
            'imagen de recursos
            Panel1.BackColor = Color.White
            Dim Img As Image = My.Resources.Logo_2023
            Panel1.BackgroundImage = Img
            Panel1.BackgroundImageLayout = ImageLayout.Zoom
            'nosotros visible
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Panel1.Visible = True
        End If
    End Sub
    Private Sub CerrarTodoToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea Cerrar Todo?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            ContForms.TabPages.Clear()
            CerrarTodoToolStripMenuItem1.Visible = False
            Dim newPage As New TabPage("Menu Principal")
            'mover tabb
            newPage.Controls.Add(ContenidoMenuPrincipal)
            ContForms.TabPages.Add(newPage)
            ContForms.Visible = True
            If ContForms.Visible = True Then
                'imagen de recursos
                Panel1.BackColor = Color.Black
                Panel1.BackgroundImage = Nothing
            Else
                'imagen de recursos
                Panel1.BackColor = Color.White
                Dim Img As Image = My.Resources.Logo_2023
                Panel1.BackgroundImage = Img
                Panel1.BackgroundImageLayout = ImageLayout.Zoom
            End If
            'nosotros visible
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Panel1.Visible = True
        End If
    End Sub
    'opens de Problema 1
    Public Sub OpenProblema1()
        Dim mensaje As New AgregarLibros1  'Nombre del Form
        mensaje.MdiParent = Me
        If ContForms.TabCount >= 1 Then
            CerrarTodoToolStripMenuItem1.Visible = True
        End If
        If ContForms.TabCount = 0 Then
            CerrarTodoToolStripMenuItem1.Visible = False
        End If
        ' Si no hay nada abierto
        ContForms.Visible = True
        mensaje.Dock = DockStyle.Fill ' Hace que el formulario se ajuste al tamaño del TabPage
        ' Agrega el formulario al primer TabPage
        'titulo de pagina
        Dim newPage As New TabPage("Agregar Libros")
        'mover tabb
        newPage.Controls.Add(mensaje)
        ContForms.TabPages.Add(newPage)
        mensaje.Show()
        ContForms.SelectedTab = newPage
        'nosotros visible
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Panel1.Visible = True
        Panel1.BackgroundImage = Nothing
        Panel1.BackColor = Color.Black
    End Sub
    'open 2 eliminar libros
    Public Sub OpenProblema2()
        Dim mensaje As New EliminarLibros1   'Nombre del Form
        mensaje.MdiParent = Me
        If ContForms.TabCount >= 1 Then
            CerrarTodoToolStripMenuItem1.Visible = True
        End If
        If ContForms.TabCount = 0 Then
            CerrarTodoToolStripMenuItem1.Visible = False
        End If
        ' Si no hay nada abierto
        ContForms.Visible = True
        mensaje.Dock = DockStyle.Fill ' Hace que el formulario se ajuste al tamaño del TabPage
        ' Agrega el formulario al primer TabPage
        'borrar pagina
        'titulo de pagina
        Dim newPage As New TabPage("Eliminar Libros")
        'mover tabb
        newPage.Controls.Add(mensaje)
        ContForms.TabPages.Add(newPage)
        mensaje.Show()
        ContForms.SelectedTab = newPage
        'nosotros visible
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Panel1.Visible = True
        Panel1.BackgroundImage = Nothing
        Panel1.BackColor = Color.Black
    End Sub
    'Abrir Lista de Clientes
    Public Sub OpenProblema3()
        Dim mensaje As New Clientes  'Nombre del Form
        mensaje.MdiParent = Me
        If ContForms.TabCount >= 1 Then
            CerrarTodoToolStripMenuItem1.Visible = True
        End If
        If ContForms.TabCount = 0 Then
            CerrarTodoToolStripMenuItem1.Visible = False
        End If
        ' Si no hay nada abierto
        ContForms.Visible = True
        mensaje.Dock = DockStyle.Fill ' Hace que el formulario se ajuste al tamaño del TabPage
        ' Agrega el formulario al primer TabPage
        'borrar pagina
        'titulo de pagina
        Dim newPage As New TabPage("Clientes")
        'mover tabb
        newPage.Controls.Add(mensaje)

        ContForms.TabPages.Add(newPage)

        mensaje.Show()
        ContForms.SelectedTab = newPage
        'nosotros visible
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Panel1.Visible = True
        Panel1.BackgroundImage = Nothing
        Panel1.BackColor = Color.Black
    End Sub
    'opcion de barra de menu
    'Agregar Libros
    Public Sub BusquedaRespuesta()
        Dim encontrado As Boolean = False
        If ContForms.TabCount > 1 Then
            For Each tp As TabPage In ContForms.TabPages
                If tp.Text = "Agregar Libros" Then
                    ' Respuesta de cerrado
                    encontrado = True
                    Dim resultado As MsgBoxResult
                    resultado = CType(MessageBox.Show("¿Actualmente esta en uso el modo Agregar, desea finalizar?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
                    If resultado = MsgBoxResult.No Then
                        ContForms.SelectedTab = tp
                    Else
                        'cierras el form agregar libro
                        ContForms.TabPages.Remove(tp)
                        OpenProblema1()
                    End If
                    Exit For
                End If
            Next
            If encontrado = False Then
                OpenProblema1()
            End If
        Else
            OpenProblema1()
        End If
    End Sub
    Private Sub AgregarLibroToolStripMenuItem_Click(sender As Object, e As EventArgs)
        BusquedaRespuesta()
    End Sub
    Private Sub AbrirForm1_Click(sender As Object, e As EventArgs)
        BusquedaRespuesta()
    End Sub
    'Eliminar Libros
    Public Sub BusquedaRespuesta2()
        Dim encontrado As Boolean = False
        If ContForms.TabCount > 1 Then
            For Each tp As TabPage In ContForms.TabPages
                If tp.Text = "Eliminar Libros" Then
                    encontrado = True
                    ' Respuesta de cerrado
                    Dim resultado As MsgBoxResult
                    resultado = CType(MessageBox.Show("¿Actualmente esta en uso el modo Eliminar, desea finalizar?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
                    If resultado = MsgBoxResult.No Then
                        ContForms.SelectedTab = tp
                    Else
                        'cierras el form agregar libro
                        ContForms.TabPages.Remove(tp)
                        OpenProblema2()
                    End If
                    Exit For
                End If
            Next
            If encontrado = False Then
                OpenProblema2()
            End If
        Else
            OpenProblema2()
        End If
    End Sub
    Private Sub EliminarLibrosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        BusquedaRespuesta2()

    End Sub

    Private Sub BtnEliminarLibro_Click(sender As Object, e As EventArgs)
        BusquedaRespuesta2()
    End Sub
    'Lista de clientes
    Public Sub BusquedaRespuesta3()
        Dim encontrado As Boolean = False
        If ContForms.TabCount > 1 Then
            For Each tp As TabPage In ContForms.TabPages
                If tp.Text = "Clientes" Then
                    ' Respuesta de cerrado
                    encontrado = True
                    Dim resultado As MsgBoxResult
                    resultado = CType(MessageBox.Show("¿Actualmente esta en uso el modo Agregar, desea finalizar?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
                    If resultado = MsgBoxResult.No Then
                        ContForms.SelectedTab = tp
                    Else
                        'cierras el form agregar libro
                        ContForms.TabPages.Remove(tp)
                        OpenProblema3()
                    End If
                    Exit For
                End If
            Next
            If encontrado = False Then
                OpenProblema3()
            End If
        Else
            OpenProblema3()
        End If
    End Sub
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        BusquedaRespuesta3()
    End Sub
End Class
