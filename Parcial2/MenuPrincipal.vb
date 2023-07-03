Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Data.SqlClient
Imports System.Data

Public Class MenuPrincipal
    Public conexion As New SqlConnection(Funciones.Conexion)
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
#Disable Warning CA1401 ' Los elementos P/Invoke no deben estar visibles
    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
#Enable Warning CA1401 ' Los elementos P/Invoke no deben estar visibles
    End Function
#Disable Warning CA1401 ' Los elementos P/Invoke no deben estar visibles
    <DllImport("user32.dll")>
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
#Enable Warning CA1401 ' Los elementos P/Invoke no deben estar visibles
    End Function
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = 2

    Private Sub MoveForm()
        ReleaseCapture()
        Dim unused = SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
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
    Private Class RenderMenu
        Inherits ToolStripProfessionalRenderer
        Public Sub New()
            MyBase.New(New Cols())
        End Sub
    End Class
    Private Class Cols
        Inherits ProfessionalColorTable

        'over de menu
        Public Overrides ReadOnly Property MenuItemSelected As Color
            ' cuando el menú está seleccionado
            Get
                Return System.Drawing.Color.FromArgb(0, 0, 192) 'Elige el color que desees para el fondo del menú seleccionado
            End Get
        End Property
        Public Overrides ReadOnly Property MenuItemSelectedGradientBegin As Color
            Get
                Return System.Drawing.Color.FromArgb(0, 0, 192) 'Elige el color que desees para el inicio del gradiente del menú seleccionado
            End Get
        End Property
        'sub menu
        Public Overrides ReadOnly Property MenuItemSelectedGradientEnd As Color
            Get
                Return System.Drawing.Color.FromArgb(0, 0, 192) 'Elige el color que desees para el final del gradiente del menú seleccionado
            End Get
        End Property
        'Seleccion de menu

        Public Overrides ReadOnly Property MenuItemPressedGradientBegin As Color
            Get
                Return System.Drawing.Color.FromArgb(0, 0, 192) 'Elige el color que desees para el inicio del gradiente del submenú seleccionado
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemPressedGradientEnd As Color
            Get
                Return System.Drawing.Color.FromArgb(0, 0, 192)  'Elige el color que desees para el final del gradiente del submenú seleccionado
            End Get
        End Property
    End Class
    Private Sub LlenarComboBox()
        Conexion.Open()
        ' Realizar la consulta a la base de datos
        Dim query As String = "SELECT idTicket FROM Ticket WHERE estado = 'Finalizado'"

        Dim command As New SqlCommand(query, Conexion)

        ' Ejecutar la consulta y obtener los resultados
        Dim reader As SqlDataReader = command.ExecuteReader()

        ' Limpiar el ComboBox
        cbFinalizados.Items.Clear()

        ' Agregar los elementos al ComboBox
        Dim foundResults As Boolean = False
        While reader.Read()
            cbFinalizados.Items.Add(reader("idTicket").ToString())
            foundResults = True
        End While

        reader.Close()

        Conexion.Close()

        If Not foundResults Then

        End If
    End Sub
    '------------------------------------------
    'opens de Problema 1
    Public Sub OpenProblema1()
        Dim mensaje As New Registrarse
        mensaje.MdiParent = Me
        If ContForms.TabCount >= 1 Then
            FinalizarSolicitudToolStripMenuItem.Visible = True
        End If
        If ContForms.TabCount = 0 Then
            FinalizarSolicitudToolStripMenuItem.Visible = False
        End If
        ' Si no hay nada abierto
        ContForms.Visible = True
        mensaje.Dock = DockStyle.Fill ' Hace que el formulario se ajuste al tamaño del TabPage
        ' Agrega el formulario al primer TabPage
        'titulo de pagina
        Dim newPage As New TabPage("Datos del Cliente")
        'mover tabb
        newPage.Controls.Add(mensaje)
        ContForms.TabPages.Add(newPage)
        'Visualizar Componentes para registro
        mensaje.tbNewUserName.Visible = True
        mensaje.tbPass.Visible = True
        mensaje.faltante4.Visible = True
        mensaje.faltante5.Visible = True
        mensaje.Label7.Visible = True
        mensaje.btMostrarVer.Visible = True
        mensaje.Show()
        Dim idTap As Integer = newPage.TabIndex
        ContForms.SelectedTab = newPage
    End Sub

    Public Sub OpenProblema2()
        Dim mensaje As New Usuario
        mensaje.MdiParent = Me
        If ContForms.TabCount >= 1 Then
            FinalizarSolicitudToolStripMenuItem.Visible = True
        End If
        If ContForms.TabCount = 0 Then
            FinalizarSolicitudToolStripMenuItem.Visible = False
        End If
        ' Si no hay nada abierto
        ContForms.Visible = True
        mensaje.Dock = DockStyle.Fill ' Hace que el formulario se ajuste al tamaño del TabPage
        ' Agrega el formulario al primer TabPage
        'titulo de pagina
        Dim newPage As New TabPage("Detalles del Tikect")
        'mover tabb
        newPage.Controls.Add(mensaje)
        ContForms.TabPages.Add(newPage)
        mensaje.Show()
        ContForms.SelectedTab = newPage
    End Sub

    Public Sub OpenProblema3()
        Dim mensaje As New Administracion
        mensaje.MdiParent = Me
        If ContForms.TabCount >= 1 Then
            FinalizarSolicitudToolStripMenuItem.Visible = True
        End If
        If ContForms.TabCount = 0 Then
            FinalizarSolicitudToolStripMenuItem.Visible = False
        End If
        ' Si no hay nada abierto
        ContForms.Visible = True
        mensaje.Dock = DockStyle.Fill ' Hace que el formulario se ajuste al tamaño del TabPage
        ' Agrega el formulario al primer TabPage
        'titulo de pagina
        Dim newPage As New TabPage("Administración")
        'mover tabb
        newPage.Controls.Add(mensaje)
        ContForms.TabPages.Add(newPage)
        mensaje.Show()
        Dim idTap As Integer = newPage.TabIndex
        ContForms.SelectedTab = newPage
    End Sub
    Public Sub OpenProblema4()
        ' Mostrar TabPage
        'TabPage.Parent = ContFormse
        Dim mensaje As New Empleados
        mensaje.MdiParent = Me
        If ContForms.TabCount >= 1 Then
            FinalizarSolicitudToolStripMenuItem.Visible = True
        End If
        If ContForms.TabCount = 0 Then
            FinalizarSolicitudToolStripMenuItem.Visible = False
        End If
        ' Si no hay nada abierto
        ContForms.Visible = True
        mensaje.Dock = DockStyle.Fill ' Hace que el formulario se ajuste al tamaño del TabPage
        ' Agrega el formulario al primer TabPage
        'titulo de pagina
        Dim newPage As New TabPage("Tareas Pendientes")
        'mover tabb
        newPage.Controls.Add(mensaje)
        ContForms.TabPages.Add(newPage)
        mensaje.Show()
        Dim idTap As Integer = newPage.TabIndex
        ContForms.SelectedTab = newPage
    End Sub

    Public Sub BusquedaRespuesta()
        Dim encontrado As Boolean = False
        If ContForms.TabCount > 0 Then
            For Each tp As TabPage In ContForms.TabPages
                If tp.Text = "Datos del Cliente" Then
                    ' Respuesta de cerrado
                    encontrado = True
                    Dim resultado As MsgBoxResult
                    resultado = CType(MessageBox.Show("¿Actualmente se esta realizando una solicitud, desea finalizar?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
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
    Public Sub BusquedaRespuesta3()
        Dim encontrado As Boolean = False
        If ContForms.TabCount > 0 Then
            For Each tp As TabPage In ContForms.TabPages
                If tp.Text = "Administración" Then
                    ' Respuesta de cerrado
                    encontrado = True
                    Dim resultado As MsgBoxResult
                    resultado = CType(MessageBox.Show("¿Actualmente se esta activo el modo Administración, desea finalizar?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
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
    Public Sub BusquedaRespuesta4()
        Dim encontrado As Boolean = False
        If ContForms.TabCount > 0 Then
            For Each tp As TabPage In ContForms.TabPages
                If tp.Text = "Tareas Pendientes" Then
                    ' Respuesta de cerrado
                    encontrado = True
                    Dim resultado As MsgBoxResult
                    resultado = CType(MessageBox.Show("¿Actualmente se estan realizando Tareas Pendientes, desea finalizar?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
                    If resultado = MsgBoxResult.No Then
                        ContForms.SelectedTab = tp
                    Else
                        'cierras el form agregar libro
                        ContForms.TabPages.Remove(tp)
                        OpenProblema4()
                    End If
                    Exit For
                End If
            Next
            If encontrado = False Then
                OpenProblema4()
            End If
        Else
            OpenProblema4()
        End If
    End Sub
    'vista principal de usuario
    Private Sub SolicitarTiketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitarTiketToolStripMenuItem.Click
        BusquedaRespuesta()
    End Sub

    Private Sub VerMisTiketsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerMisTiketsToolStripMenuItem.Click
        If VerMisTiketsToolStripMenuItem.Text = "Ocultar Tikets" Then
            ContForms.Visible = False
        Else
            ContForms.Visible = True
        End If
        If ContForms.TabCount > 1 Then
            FinalizarSolicitudToolStripMenuItem.Visible = True
        End If
        If ContForms.TabCount = 1 Then
            FinalizarSolicitudToolStripMenuItem.Visible = False
        End If
    End Sub
    Private Sub FinalizarSolicitudToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinalizarSolicitudToolStripMenuItem.Click
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea Cerrar Todo?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            Dim newPage As New TabPage("Tikets")
            newPage.Controls.Add(PanelTikets)
            ContForms.TabPages.Clear()
            FinalizarSolicitudToolStripMenuItem.Visible = False
            'mover tabb
            ContForms.TabPages.Add(newPage)
            ContForms.Visible = True
        End If
    End Sub

    Private Sub TicketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TicketToolStripMenuItem.Click
        If ContForms.Visible = True Then
            VerMisTiketsToolStripMenuItem.Text = "Ocultar Tikets"
        Else
            VerMisTiketsToolStripMenuItem.Text = "Ver Tikets"
        End If
    End Sub


    Public Sub AbrirPanelLogin()
        TableLayoutPanelLogin.ColumnStyles(0).Width = 300 '300
        BtnCerrarPanelLogin.Visible = True
    End Sub
    Public Sub CerrarPanelLogin()
        TableLayoutPanelLogin.ColumnStyles(0).Width = 0 '300
        BtnCerrarPanelLogin.Visible = False
    End Sub

    '---------------------------------------LOAD-------------------------------------------
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'colores de menu
        TableLayoutPanel1.Cursor = Cursors.Arrow
        MenuStrip1.Renderer = New RenderMenu()
        MenuStrip2.Renderer = New RenderMenu()
        lbDimeIDCorrectUser.Visible = False
        BtnSolicitudTiket.Visible = False
        TicketToolStripMenuItem.Visible = False
        ContForms.Visible = False
        FinalizarSolicitudToolStripMenuItem.Visible = False
        LlenarComboBox()

        'vista inicial de login
        'tablas
        TableLayoutPanelLogin.ColumnStyles(0).Width = 0 '300
        LoginToolStripMenuItem2.Text = "           LOGIN           "
        CerrarSessionToolStripMenuItem.Visible = False
        IniciarSessionToolStripMenuItem.Visible = True
        BtnCerrarPanelLogin.Visible = False
        ROLToolStripMenuItem.Visible = False

        'vista de Inicio
        AdministraciónToolStripMenuItem.Visible = False
        EquipoDeTrabajoToolStripMenuItem1.Visible = False
        TicketToolStripMenuItem.Visible = False
        TareasPendienteToolStripMenuItem.Visible = False
        'Tablas contenedoras de forms 
        tablaContenedoraForms.RowStyles(0).Height = 0 'opcion de actualizar
        ' Ocultar Tabpage
        ContForms.TabPages.Clear()
        ' Mostrar TabPage
        'TabPage.Parent = ContFormse
        'ocultar labels
        lbNombreCaj.ForeColor = Color.FromArgb(224, 224, 224)
        lbNombreCajero.ForeColor = Color.FromArgb(224, 224, 224)
        lbDimeIDCorrectUser.ForeColor = Color.FromArgb(224, 224, 224)
    End Sub

    Private Sub IniciarSessionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciarSessionToolStripMenuItem.Click
        AbrirPanelLogin()
    End Sub
    Private Sub BtnCerrarPanelLogin_Click(sender As Object, e As EventArgs) Handles BtnCerrarPanelLogin.Click
        CerrarPanelLogin()
    End Sub
    Private Sub CerrarSessionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSessionToolStripMenuItem.Click
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea Cerrar Session?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            Dim newPage As New TabPage("Tikets")
            newPage.Controls.Add(PanelTikets)
            ContForms.TabPages.Clear()
            FinalizarSolicitudToolStripMenuItem.Visible = False
            'mover tabb
            ContForms.TabPages.Add(newPage)
            ContForms.Visible = False
        End If
        'Cierre de session
        CerrarPanelLogin()
        ROLToolStripMenuItem.Visible = False
        ROLToolStripMenuItem.Text = ""
        LoginToolStripMenuItem2.Text = "           LOGIN           "
        IniciarSessionToolStripMenuItem.Visible = True
        CerrarSessionToolStripMenuItem.Visible = False

        'vista de CierreSession
        AdministraciónToolStripMenuItem.Visible = False
        EquipoDeTrabajoToolStripMenuItem1.Visible = False
        TicketToolStripMenuItem.Visible = False
        TareasPendienteToolStripMenuItem.Visible = False
        ' Ocultar Tabpage
        TabPage.Parent = Nothing
        ' Mostrar TabPage
        'TabPage.Parent = ContFormse
    End Sub
    Private Sub BtnAcceder_Click(sender As Object, e As EventArgs) Handles BtnAcceder.Click

        Dim usuario As String = tbUser.Text
        Dim contraseña As String = tbPass.Text

        Dim consultaExiste As String = "SELECT COUNT(*) FROM Usuario WHERE nombreUser = @Usuario AND passUser = @Contraseña"

        Using command As New SqlCommand(consultaExiste, Conexion)
            command.Parameters.AddWithValue("@Usuario", usuario)
            command.Parameters.AddWithValue("@Contraseña", contraseña)

            Conexion.Open()

            ' Ejecuta la consulta y obtén el resultado
            Dim resultado As Integer = Convert.ToInt32(command.ExecuteScalar())

            ' Verifica si el resultado es igual a 1 (usuario y contraseña válidos)
            If resultado = 1 Then

                'Realizar las acciones necesarias después del inicio de sesión exitoso
                CerrarPanelLogin()

                Dim idUsuarioCorrecto As String = ""
                Dim rolUsuarioEnter As String = ""

                Dim consultaId As String = "SELECT idUser FROM Usuario WHERE nombreUser = @NombreUsuario"

                Dim comando4 As New SqlCommand(consultaId, Conexion)

                comando4.Parameters.AddWithValue("NombreUsuario", tbUser.Text)

                Dim idUsuarioCor As Object = comando4.ExecuteScalar()

                If idUsuarioCor IsNot Nothing AndAlso Not DBNull.Value.Equals(idUsuarioCor) Then
                    lbDimeIDCorrectUser.Text = Convert.ToString(idUsuarioCor)
                End If

                Funciones.inicioSesionId = lbDimeIDCorrectUser.Text


                Dim rol As String = ObtenerRol(Funciones.inicioSesionId)

                Select Case rol
                    Case "empleado"
                        ' Ocultar Tabpage
                        ContForms.TabPages.Clear()

                        ' Mostrar TabPage
                        'TabPage.Parent = ContFormse
                        'datos de login
                        ROLToolStripMenuItem.Visible = True
                        ROLToolStripMenuItem.Text = "Empleado"
                        LoginToolStripMenuItem2.Text = tbUser.Text
                        IniciarSessionToolStripMenuItem.Visible = False
                        CerrarSessionToolStripMenuItem.Visible = True
                        'vista del empleado 
                        AdministraciónToolStripMenuItem.Visible = False
                        EquipoDeTrabajoToolStripMenuItem1.Visible = False
                        TicketToolStripMenuItem.Visible = False
                        TareasPendienteToolStripMenuItem.Visible = True

                        Dim userEmpleado As String = ""
                        Dim nombreEmpleado As String = ""

                        Dim consultaNombre As String = "select nombre From Usuario where nombreUser = @Nombre"

                        Dim comando As New SqlCommand(consultaNombre, conexion)

                        userEmpleado = tbUser.Text

                        comando.Parameters.AddWithValue("@Nombre", userEmpleado)

                        Dim dimeElNombre As Object = comando.ExecuteScalar()

                        If dimeElNombre IsNot Nothing AndAlso Not DBNull.Value.Equals(dimeElNombre) Then
                            nombreEmpleado = Convert.ToString(dimeElNombre)
                        End If

                        Funciones.inicioSesionEmpl = nombreEmpleado

                    Case "admin"
                        ' Ocultar Tabpage
                        ContForms.TabPages.Clear()

                        ' Mostrar TabPage
                        'TabPage.Parent = ContFormse
                        'datos de login
                        ROLToolStripMenuItem.Visible = True
                        ROLToolStripMenuItem.Text = "Admin"
                        LoginToolStripMenuItem2.Text = tbUser.Text
                        CerrarSessionToolStripMenuItem.Visible = True
                        IniciarSessionToolStripMenuItem.Visible = False
                        'vista de admin
                        AdministraciónToolStripMenuItem.Visible = True
                        EquipoDeTrabajoToolStripMenuItem1.Visible = True
                        TicketToolStripMenuItem.Visible = False
                        TareasPendienteToolStripMenuItem.Visible = True


                        Dim userAdmin As String = ""
                        Dim nombreadmin As String = ""

                        Dim consultaNombre As String = "select nombre From Usuario where nombreUser = @Nombre"

                        Dim comando As New SqlCommand(consultaNombre, conexion)

                        userAdmin = tbUser.Text

                        comando.Parameters.AddWithValue("@Nombre", userAdmin)

                        Dim dimeElNombre As Object = comando.ExecuteScalar()

                        If dimeElNombre IsNot Nothing AndAlso Not DBNull.Value.Equals(dimeElNombre) Then
                            nombreadmin = Convert.ToString(dimeElNombre)
                        End If

                        Funciones.inicioSesionEmpl = nombreadmin

                    Case "cajero"
                        ' Mostrar TabPage
                        ContForms.TabPages.Clear()

                        ' Mostrar TabPage

                        'datos de login
                        ROLToolStripMenuItem.Visible = True
                        ROLToolStripMenuItem.Text = "Cajero"
                        LoginToolStripMenuItem2.Text = tbUser.Text
                        lbDimeIDCorrectUser.Visible = True
                        BtnSolicitudTiket.Visible = True
                        TicketToolStripMenuItem.Visible = True
                        CerrarSessionToolStripMenuItem.Visible = True
                        IniciarSessionToolStripMenuItem.Visible = False
                        'vista de admin
                        AdministraciónToolStripMenuItem.Visible = False
                        EquipoDeTrabajoToolStripMenuItem1.Visible = False
                        TareasPendienteToolStripMenuItem.Visible = False

                        lbNombreCajero.Text = tbUser.Text

                        Dim consultaNombre As String = "select nombre From Usuario where nombreUser = @Nombre"

                        Dim comando As New SqlCommand(consultaNombre, Conexion)

                        comando.Parameters.AddWithValue("@Nombre", lbNombreCajero.Text)

                        Dim dimeElNombre As Object = comando.ExecuteScalar()

                        If dimeElNombre IsNot Nothing AndAlso Not DBNull.Value.Equals(dimeElNombre) Then
                            lbNombreCaj.Text = Convert.ToString(dimeElNombre)
                        End If

                        Funciones.UserLoginCajero = lbNombreCaj.Text

                        Conexion.Close()
                        '.........................................................................................
                        'Mostrar la tabla que relaciona los tickets y el empleado que realiza la sesión
                        vistaUsuarioTable()
                    Case Else
                        ' Ocultar Tabpage
                        ContForms.TabPages.Clear()

                        ' Mostrar TabPage
                        'TabPage.Parent = ContFormse
                        CerrarSessionToolStripMenuItem.Visible = False
                        IniciarSessionToolStripMenuItem.Visible = True
                        ROLToolStripMenuItem.Visible = False
                        MessageBox.Show("Rol no válido")
                End Select

                Conexion.Close()

            Else
                'Realizar las acciones necesarias después del inicio de sesión erróneo
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTOS", "Intentelo de nuevo.", MessageBoxButtons.OK)
                tbPass.Clear()
                tbUser.Clear()
            End If
            Conexion.Close()
        End Using
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnSolicitudTiket.Click
        BusquedaRespuesta()
        BtnSolicitudTiket.Enabled = False
    End Sub


    'Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    '     Dim newUserForm As New Registrarse()

    '    newUserForm.StartPosition = FormStartPosition.CenterScreen

    '   newUserForm.Show()

    'End Sub


    'Mostrar la tabla de ticket de x usuario. Como funcion
    Public Sub vistaUsuarioTable()

        Dim consultaCliente As String = "SELECT t.idTicket, u.nombre, t.equipo, t.modelo, t.estado
                                         FROM Usuario u
                                         JOIN TicketUser tU ON u.idUser = tu.IdsUser
                                         JOIN Ticket t ON t.idTicket = tu.IdsTicket
                                         JOIN UserRol uR ON uR.idURer = u.idUser
                                         WHERE uR.rolUser = 'user' 
                                         ORDER BY t.idTicket ASC;"

        Dim ejecutar As New SqlDataAdapter(consultaCliente, Conexion)


        Try

            Dim dataSet As New DataSet()

            ejecutar.Fill(dataSet)

            DGUserPrincipal.DataSource = dataSet.Tables(0)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Sub


    'Mostrar la tabla empleado con sus tareas si se inicia como empleado
    Public Sub vistaEmpleadoTable()

        Dim consultaEmpleado As String = "SELECT idTicket, equipo, modelo, tipodeDano FROM Ticket where responsable = @nomEmple;"


        Dim ejecutar As New SqlCommand(consultaEmpleado, Conexion)

        ejecutar.Parameters.AddWithValue("@nomEmple", "Tyler Blue")

        Try
            Dim tabla As New SqlDataAdapter(ejecutar)
            Dim dss As New DataSet
            tabla.Fill(dss, "Ticket")

            Me.DGUserPrincipal.DataSource = dss.Tables("Ticket")
            DGUserPrincipal.Columns("idTicket").HeaderText = "ID"
            DGUserPrincipal.Columns("equipo").HeaderText = "EQUIPO"
            DGUserPrincipal.Columns("modelo").HeaderText = "MODELO"
            DGUserPrincipal.Columns("tipodeDano").HeaderText = "DAÑO"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If tbPass.PasswordChar = "*" Then
            tbPass.PasswordChar = ControlChars.NullChar

        Else
            tbPass.PasswordChar = "*"
        End If
    End Sub


    Public Function ObtenerIDUsuario(nombreUsuario As String) As String

        Dim idUsuario As String = ""
        ' Variable para almacenar la ID del usuario

        Try
            Conexion.Open()

            Dim consulta As String = "SELECT idUser FROM Usuario WHERE nombreUser = @NombreUsuario"
            Dim comando As New SqlCommand(consulta, Conexion)
            comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario)

            Dim resultado As Object = comando.ExecuteScalar()

            If resultado IsNot Nothing AndAlso Not DBNull.Value.Equals(resultado) Then
                idUsuario = Convert.ToString(resultado)
            End If
        Catch ex As Exception
            ' Manejar la excepción apropiadamente
        Finally
            Conexion.Close()
        End Try

        Return idUsuario
    End Function


    Public Function ObtenerRol(nombreUsuario As String) As String
        Dim rolUser As String = ""

        Dim consultaRol As String = "SELECT rolUser FROM UserRol WHERE idURer = @IdCapturada"
        Dim commandRol As New SqlCommand(consultaRol, Conexion)

        commandRol.Parameters.AddWithValue("@IdCapturada", nombreUsuario)

        Dim resultadoo As Object = commandRol.ExecuteScalar()

        If resultadoo IsNot Nothing AndAlso Not DBNull.Value.Equals(resultadoo) Then
            rolUser = Convert.ToString(resultadoo)
        End If

        Return rolUser

    End Function


    'Filtrar por búsqueda de nombre del cliente 
    Private Sub tbFiltro_TextChanged(sender As Object, e As EventArgs) Handles tbFiltro.TextChanged

        Dim query As String = "SELECT t.idTicket, u.nombre, t.equipo, t.modelo, t.estado
                                FROM Usuario u
                                JOIN TicketUser tU ON u.idUser = tu.IdsUser
                                JOIN Ticket t ON t.idTicket = tu.IdsTicket
                                JOIN UserRol uR ON uR.idURer = u.idUser
                                WHERE uR.rolUser = 'user' and u.nombre LIKE @texto
                                ORDER BY t.idTicket ASC;"


        Using command As New SqlCommand(query, Conexion)
            Conexion.Open()
            command.Parameters.AddWithValue("@texto", "%" & tbFiltro.Text & "%")

            Using adapter As New SqlDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                DGUserPrincipal.DataSource = dataTable
            End Using
            Conexion.Close()
        End Using
    End Sub

    Private Sub VerRegistrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerRegistrosToolStripMenuItem.Click
        BusquedaRespuesta3()
        If ContForms.TabCount >= 1 Then
            CerrarPestañasToolStripMenuItem.Visible = True
        End If
        If ContForms.TabCount = 0 Then
            CerrarPestañasToolStripMenuItem.Visible = False
        End If
    End Sub
    Private Sub CerrarPestañasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarPestañasToolStripMenuItem.Click
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea Cerrar todas las ventanas?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            Dim newPage As New TabPage("Tikets")
            newPage.Controls.Add(PanelTikets)

            ContForms.TabPages.Clear()
            FinalizarSolicitudToolStripMenuItem.Visible = False
            'mover tabb
            ContForms.TabPages.Add(newPage)
            ContForms.Visible = True

            ' Ocultar Tabpage
            TabPage.Parent = Nothing

            ' Mostrar TabPage
            'TabPage.Parent = ContFormse

        End If
    End Sub

    Private Sub TicketToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TicketToolStripMenuItem1.Click
        ' Mostrar TabPage
        TabPage.Parent = ContForms
        ContForms.Visible = True
    End Sub

    Private Sub CrearNuevoTiketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearNuevoTiketToolStripMenuItem.Click
        BusquedaRespuesta()
    End Sub

    Private Sub VerTareasPendientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerTareasPendientesToolStripMenuItem.Click
        BusquedaRespuesta4()
    End Sub

    'agregar nuevos empleados 
    'opens de Problema 1
    Public Sub OpenProblema5()
        ' Ocultar Tabpage
        TabPage.Parent = Nothing

        ' Mostrar TabPage
        'TabPage.Parent = ContFormse
        Dim mensaje As New Registrarse
        mensaje.MdiParent = Me
        If ContForms.TabCount >= 1 Then
            FinalizarSolicitudToolStripMenuItem.Visible = True
        End If
        If ContForms.TabCount = 0 Then
            FinalizarSolicitudToolStripMenuItem.Visible = False
        End If
        ' Si no hay nada abierto
        ContForms.Visible = True
        mensaje.Dock = DockStyle.Fill ' Hace que el formulario se ajuste al tamaño del TabPage
        ' Agrega el formulario al primer TabPage
        'titulo de pagina
        Dim newPage As New TabPage("Agregar Empleado")
        'mover tabb
        newPage.Controls.Add(mensaje)
        ContForms.TabPages.Add(newPage)
        'Visualizar Componentes para registro
        mensaje.tbNewUserName.Visible = False
        mensaje.tbPass.Visible = False
        mensaje.faltante4.Visible = False
        mensaje.faltante5.Visible = False
        mensaje.Label7.Visible = False
        mensaje.btMostrarVer.Visible = False

        mensaje.Show()

        Dim idTap As Integer = newPage.TabIndex
        ContForms.SelectedTab = newPage
    End Sub
    Public Sub BusquedaRespuesta5()
        Dim encontrado As Boolean = False
        If ContForms.TabCount > 0 Then
            For Each tp As TabPage In ContForms.TabPages
                If tp.Text = "Agregar Empleado" Then
                    ' Respuesta de cerrado
                    encontrado = True
                    Dim resultado As MsgBoxResult
                    resultado = CType(MessageBox.Show("¿Actualmente se esta realizando un Registro de cliente, desea finalizarlo?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
                    If resultado = MsgBoxResult.No Then
                        ContForms.SelectedTab = tp
                    Else
                        'cierras el form agregar libro
                        ContForms.TabPages.Remove(tp)
                        OpenProblema5()
                    End If
                    Exit For
                End If
            Next
            If encontrado = False Then
                OpenProblema5()
            End If
        Else
            OpenProblema5()
        End If
    End Sub
    Private Sub AgregarNuevoEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarNuevoEmpleadoToolStripMenuItem.Click
        BusquedaRespuesta5()
    End Sub

    Private Sub AdministraciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministraciónToolStripMenuItem.Click
        ' Ocultar Tabpage
        ' Mostrar TabPage
        'TabPage.Parent = ContFormse
    End Sub
End Class
