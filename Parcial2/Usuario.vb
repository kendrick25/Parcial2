Imports System.Data.SqlClient

Public Class Usuario

    Public conexion As New SqlConnection(Funciones.Conexion)

    'Se se finaliza el ticket con botón "cancelar proceso" del form del ticket. Se eliminan el tab actual y el
    'anterior. Queda pendiente controlar que no se puedan abrir mas tabs en el modo "Abrir Ticket"
    Private Sub BtnFinalizar_Click(sender As Object, e As EventArgs) Handles BtnFinalizar.Click
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea finalizar la solicitud de ticktet actual?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            'borrar Pagina actual
            Dim tab As TabPage = MenuPrincipal.ContForms.SelectedTab
            Dim ids As Integer = MenuPrincipal.ContForms.SelectedIndex
            MenuPrincipal.ContForms.TabPages.Remove(tab)
            MenuPrincipal.ContForms.TabPages.RemoveAt(ids - 1)
            Me.Close()
            Registrarse.Close()
            MenuPrincipal.BtnSolicitudTiket.Enabled = True


            'Si se cancela el proceso, los datos que se habian almacenado temporalmente del cliente, se borran
            conexion.Open()

            Dim NewUsuario As New SqlCommand()

            NewUsuario.Connection = conexion

            NewUsuario.CommandType = CommandType.StoredProcedure

            NewUsuario.CommandText = "DarDeBaja"

            NewUsuario.Parameters.AddWithValue("@nombreUsu", Funciones.nombreToCancel)

            NewUsuario.ExecuteNonQuery()

            conexion.Close()

        End If
    End Sub


    'Se se confirma otro ticket, se limpia el form para ingresar datos nuevamente
    Public Sub CleanToOtherTicket()

        gbDetalleTicket2.Enabled = False
        gbDetalleTicket1.Enabled = True
        cbEquipo.Text = Nothing
        cbComponente.Text = Nothing
        cbModelo.Text = Nothing
        cbModelo.Items.Clear()
        cbComponente.Items.Clear()

        lbDias.Text = Nothing
        tbDescripcion.Text = Nothing
        lbFechaEstimada.Text = Nothing
        limiteChar.Visible = True
        limiteChar.Text = Nothing

        btConfirm1.Enabled = True
        btConfirm2.Enabled = False
        btConfirm3.Enabled = False
        btConfirm4.Enabled = False

        lbPrioridad.Visible = False
        lbExtras.Visible = False

        lbDias.Visible = False
        bnCrearTicket.Enabled = False

    End Sub


    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btConfirm2.Enabled = False
        gbDetalleTicket2.Enabled = False
        btConfirm4.Enabled = False
        lbPrioridad.Visible = False
        lbExtras.Visible = False
        lbDias.Visible = False
        bnCrearTicket.Enabled = False
        btConfirm3.Enabled = False
        limiteChar.Text = Nothing
        lbFechaActual.Visible = False
        lbFechaEstimada.Visible = False
        lbDimeID.Visible = False

        'Establece la fecha actual
        lbFechaActual.Text = DateTime.Now.ToString("yyyy-MM-dd")
        lbFechaShowLoad.Text = Date.Today


        'La asigno al label el valor que contendrá la id para poder mandar el ticket con el procedimiento
        lbDimeID.Text = Funciones.idAsig


    End Sub


    'Funciones que llenan los combobox con las opciones
    Private Sub cbEquipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEquipo.SelectedIndexChanged

        Select Case cbEquipo.SelectedIndex

            Case 0 'DELL
                ' Limpiar ComboBox2 y agregar elementos correspondientes a la opción 1
                cbModelo.Items.Clear()
                cbModelo.Items.Add("DELL 11 – 3120 Intel Celeron")
                cbModelo.Items.Add("Dell Inspiron 15 3000 Series 3511")
                cbModelo.Items.Add("Dell Latitude E6420")
                cbModelo.Items.Add("Dell Latitude 5400 14")
                cbModelo.Items.Add("Dell Vostro 3400")
                cbModelo.Items.Add("DELL XPS 9300")
                cbModelo.Items.Add("Dell XPS 13 9310")
                llenarComponentesLaptop()

            Case 1 'HP
                ' Limpiar ComboBox2 y agregar elementos correspondientes a la opción 2
                cbModelo.Items.Clear()
                cbModelo.Items.Add("HP 15-EF2520LA 15")
                cbModelo.Items.Add("BUNDLE HP LAPTOP 15-EF2526LA")
                cbModelo.Items.Add("INTEL CELERON N4120")
                cbModelo.Items.Add("HP Spectre x360 14")
                cbModelo.Items.Add("HP Omen")
                cbModelo.Items.Add("HP Stream 11")
                cbModelo.Items.Add("HP ZBook Fury 15 G7")
                llenarComponentesLaptop()

            Case 2 'ACER
                ' Limpiar ComboBox2 y agregar elementos correspondientes a la opción 3

                cbModelo.Items.Clear()
                cbModelo.Items.Add("INTEL CELERON 4020")
                cbModelo.Items.Add("ACER  NX HN2AL 019")
                cbModelo.Items.Add("ACER  NX HN2AL 016")
                cbModelo.Items.Add("ACER AMD RYZEN 3 3250U")
                cbModelo.Items.Add("ACER NITRO 5")
                cbModelo.Items.Add("ACER NH.QFMAL.003 NITRO 5")
                cbModelo.Items.Add("Acer Swift 5 Intel EVO Thin")
                llenarComponentesLaptop()

            Case 3 'ASUS
                ' Limpiar ComboBox2 y agregar elementos correspondientes a la opción 4

                cbModelo.Items.Clear()
                cbModelo.Items.Add("Asus ZenBook 13 OLED")
                cbModelo.Items.Add("Vivobook S 14 Flip TP3402")
                cbModelo.Items.Add("ASUS Vivobook S 14 Flip TN3402")
                cbModelo.Items.Add("ASUS P1511")
                cbModelo.Items.Add("ASUS BR1100F")
                cbModelo.Items.Add("ASUS E510")
                cbModelo.Items.Add("ASUS VivoBook F515")
                llenarComponentesLaptop()

            Case 4 'LENOVO
                ' Limpiar ComboBox2 y agregar elementos correspondientes a la opción 5
                cbModelo.Items.Clear()
                cbModelo.Items.Add("E15 2da Gen")
                cbModelo.Items.Add("ThinkBook 14 2da Gen")
                cbModelo.Items.Add("V15")
                cbModelo.Items.Add("ThinkBook 16p 2da Gen")
                cbModelo.Items.Add("L14")
                cbModelo.Items.Add("Legion 5 Pro 7ma Gen")
                cbModelo.Items.Add("E15 3era Gen")
                cbModelo.Items.Add("ThinkPad X1 Carbon 10ma Gen")
                cbModelo.Items.Add("Lenovo ThinkPad X1 Carbon Gen 9")
                cbModelo.Items.Add("L13 Yoga 2da Gen")
                llenarComponentesLaptop()

            Case 5 'MAC
                ' Limpiar ComboBox2 y agregar elementos correspondientes a la opción 6

                cbModelo.Items.Clear()
                cbModelo.Items.Add("MacBook Pro")
                cbModelo.Items.Add("MacBook Air")
                cbModelo.Items.Add("Apple MacBook Pro 16 M1 Max")
                cbModelo.Items.Add("MacBook Air M1")
                cbModelo.Items.Add("MacBook Pro 14-in and 16-in M1")
                cbModelo.Items.Add("MacBook Air M2")
                cbModelo.Items.Add("MacBook Pro 13-in. M2")
                llenarComponentesLaptop()

            Case 6 'PC
                ' Limpiar ComboBox2 y agregar elementos correspondientes a la opción 7
                cbModelo.Items.Clear()
                cbModelo.Items.Add("HP")
                cbModelo.Items.Add("Dell")
                cbModelo.Items.Add("Lenovo")
                cbModelo.Items.Add("Acer")
                llenarComponentesPC()

            Case Else
                ' Si no se selecciona ninguna opción, limpiar ComboBox2
                cbModelo.Items.Clear()
                cbComponente.Items.Clear()
        End Select


    End Sub


    'Boton verde de confirmacion del primer groupbox
    Private Sub btConfirm1_Click(sender As Object, e As EventArgs) Handles btConfirm1.Click

        If cbEquipo.SelectedItem = Nothing Then
            MessageBox.Show("Selecciona tu equipo.", "EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            If cbModelo.SelectedItem = Nothing Then
                MessageBox.Show("Selecciona el modelo.", "MODELO", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                If cbComponente.SelectedItem = Nothing Then
                    MessageBox.Show("Selecciona componente afectado.", "PARTE", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    btConfirm1.Enabled = False
                    gbDetalleTicket1.Enabled = False
                    btConfirm2.Enabled = True
                    gbDetalleTicket2.Enabled = True
                    lbPrioridad.Visible = True
                    lbExtras.Visible = True
                    estableceEstimado()
                    lbFechaEstimada.Text = estableceFechaEstimada(Val(lbDias.Text), lbFechaActual.Text)
                    btConfirm3.Enabled = True
                    lbFechaEstimada.Visible = True
                End If

            End If
        End If

    End Sub


    'Boton verde de cancelacion del primer groupbox
    Private Sub btConfirm2_Click(sender As Object, e As EventArgs) Handles btConfirm2.Click
        btConfirm1.Enabled = True
        gbDetalleTicket1.Enabled = True
        gbDetalleTicket2.Enabled = False
        btConfirm2.Enabled = False
        lbPrioridad.Visible = False
        lbExtras.Visible = False
        btConfirm3.Enabled = False
        lbFechaEstimada.Visible = False
    End Sub



    Private Sub tbDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDescripcion.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
        End If

        Dim maxLength As Integer = 250

        ' Verificar si se ha alcanzado el límite de caracteres permitidos
        If tbDescripcion.TextLength >= maxLength AndAlso e.KeyChar <> ControlChars.Back Then
            ' Si se ha alcanzado el límite y no es una tecla de retroceso, cancelar el evento KeyPress
            e.Handled = True
        End If

    End Sub


    'Boton verde de confirmacion del segundo groupbox
    Private Sub bnConfirm3_Click(sender As Object, e As EventArgs) Handles btConfirm3.Click

        If tbDescripcion.Text = Nothing Then
            MessageBox.Show("Escribe una descripcion breve.", "SOBRE TU PROBLEMA", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Else
            btConfirm3.Enabled = False
            gbDetalleTicket2.Enabled = False
            btConfirm4.Enabled = True
            lbPrioridad.Visible = False
            lbExtras.Visible = False
            limiteChar.Visible = False
            bnCrearTicket.Enabled = True
            btConfirm2.Enabled = False
        End If

    End Sub


    ''Boton verde de cancelacion del segundo groupbox
    Private Sub btConfirm4_Click(sender As Object, e As EventArgs) Handles btConfirm4.Click
        btConfirm3.Enabled = True
        gbDetalleTicket2.Enabled = True
        btConfirm4.Enabled = False
        lbPrioridad.Visible = True
        lbExtras.Visible = True
        limiteChar.Visible = True
        bnCrearTicket.Enabled = False
        btConfirm2.Enabled = True
    End Sub


    'Funcion que establece el valor de los dias de estimacion por el componente que se selecciona
    Public Sub estableceEstimado()
        If cbComponente.SelectedItem = "Tarjeta gráfica" Or cbComponente.SelectedItem = "Tarjeta Madre" Then
            lbDias.Text = "10"
        ElseIf cbComponente.SelectedItem = "Puertos USB" Then
            lbDias.Text = "6"
        ElseIf cbComponente.SelectedItem = "Bahías y discos duros" Or cbComponente.SelectedItem = "Disco duro" Then
            lbDias.Text = "5"
        ElseIf cbComponente.SelectedItem = "Teclado" Or cbComponente.SelectedItem = "Conector de energía" Then
            lbDias.Text = "7"
        ElseIf cbComponente.SelectedItem = "Refrigeración" Or cbComponente.SelectedItem = "Memoria RAM" Then
            lbDias.Text = "8"
        ElseIf cbComponente.SelectedItem = "Monitor" Or cbComponente.SelectedItem = "Cargador" Or cbComponente.SelectedItem = "Pantalla" Then
            lbDias.Text = "4"
        ElseIf cbComponente.SelectedItem = "Ventilador del procesador" Or cbComponente.SelectedItem = "Ventiladores" Then
            lbDias.Text = "12"
        ElseIf cbComponente.SelectedItem = "Disipador y procesador" Or cbComponente.SelectedItem = "Placa base" Then
            lbDias.Text = "15"
        ElseIf cbComponente.SelectedItem = "Windows" Or cbComponente.SelectedItem = "Fuente de alimentación" Then
            lbDias.Text = "9"
        End If
    End Sub



    'Función para establecer una fecha estimada de reparación y la hora a partir de la cual se puede visitar el sitio
    Public Function estableceFechaEstimada(dias As Integer, Fecha As String) As String

        Dim fechaNormal As Date = Fecha
        Dim fechaHoraEstimada, fechaHora As Date
        Dim horaAtencion As Date = TimeSerial(9, 0, 0)
        fechaHora = fechaNormal.Add(horaAtencion.TimeOfDay)

        ' Genera la fecha estimada sumando los días a la fecha inicial
        fechaHoraEstimada = DateAdd("d", dias, fechaHora)

        ' Imprime la fecha estimada
        Return fechaHoraEstimada
    End Function


    'Llena los componentes de todas la marcas de laptop
    Public Sub llenarComponentesLaptop()
        cbComponente.Items.Clear()
        cbComponente.Items.Add("Teclado")
        cbComponente.Items.Add("Disco duro")
        cbComponente.Items.Add("Memoria RAM")
        cbComponente.Items.Add("Pantalla")
        cbComponente.Items.Add("Tarjeta Madre")
        cbComponente.Items.Add("Ventilador del procesador")
        cbComponente.Items.Add("Conector de energía")
        cbComponente.Items.Add("Cargador")
        cbComponente.Items.Add("Windows")
        cbComponente.Items.Add("Puertos USB")
    End Sub


    'Llena los componentes de todas la marcas de PC
    Public Sub llenarComponentesPC()
        cbComponente.Items.Clear()
        cbComponente.Items.Add("Placa base")
        cbComponente.Items.Add("Windows")
        cbComponente.Items.Add("Monitor")
        cbComponente.Items.Add("Disipador y procesador")
        cbComponente.Items.Add("Bahías y discos duros")
        cbComponente.Items.Add("Tarjeta gráfica")
        cbComponente.Items.Add("Memoria RAM")
        cbComponente.Items.Add("Fuente de alimentación")
        cbComponente.Items.Add("Ventiladores")
        cbComponente.Items.Add("Refrigeración")
        cbComponente.Items.Add("Puertos USB")
    End Sub


    'Botón para enviar el ticket con todos los campos llenos
    Private Sub bnCrearTicket_Click(sender As Object, e As EventArgs) Handles bnCrearTicket.Click

        'AGREGAR PROCEDIMIENTO PARA CREAR LA TABLA CON LOS DATOS DEL USUARIO

        Dim answer5 As Integer

        answer5 = MsgBox("¿DESEAS ENVIAR EL TICKET?. ¡NO SE PODRÁ CANCELAR!", vbYesNo)

        If answer5 = vbYes Then

            'Si se confirma el ticket, se guardan los datos del cliente y se agrega el ticket que esta relacionado con él.

            AgregarDatosTicket()

            MessageBox.Show("TICKET ENVIADO CON EXITO", "GRACIAS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim resultado As DialogResult = MessageBox.Show("¿DESEA SOLICITAR OTRO TICKET?", "?", MessageBoxButtons.YesNo)

            If resultado = DialogResult.Yes Then

                'Refrescar form
                Me.Refresh()

                'Limpiar campos
                CleanToOtherTicket()

            ElseIf resultado = DialogResult.No Then

                Dim tab As TabPage = MenuPrincipal.ContForms.SelectedTab
                Dim ids As Integer = MenuPrincipal.ContForms.SelectedIndex
                MenuPrincipal.ContForms.TabPages.Remove(tab)
                MenuPrincipal.ContForms.TabPages.RemoveAt(ids - 1)
                Me.Close()
                Registrarse.Close()
                MenuPrincipal.BtnSolicitudTiket.Enabled = True
                MenuPrincipal.vistaUsuarioTable()

            End If


        Else
            'Devuelve a la pantalla
        End If

    End Sub


    'Botón que regresa a tab de datos del cliente (anterior asumiendo que no se puede abrir mas tabs)
    Private Sub btRegresar_Click(sender As Object, e As EventArgs) Handles btRegresar.Click
        'Cuando se esta ingresando los datos del ticket puedo regresar al tab de alado
        Dim id As Integer = MenuPrincipal.ContForms.SelectedIndex
        MenuPrincipal.ContForms.SelectTab(id - 1)
    End Sub



    'Funcion que agrega ticket con base al cliente que lo solicitó
    Public Sub AgregarDatosTicket()

        conexion.Open()

        'Procedimiento para enviar ticket

        Dim NewTicket As New SqlCommand()

        NewTicket.Connection = conexion

        NewTicket.CommandType = CommandType.StoredProcedure

        NewTicket.CommandText = "NuevoTicket"
        Dim Fecha As DateTime = lbFechaActual.Text
        Dim FechaEstimada As DateTime = lbFechaEstimada.Text
        NewTicket.Parameters.AddWithValue("@idRequest", Funciones.idAsig)
        NewTicket.Parameters.AddWithValue("@equipo", cbEquipo.SelectedItem)
        NewTicket.Parameters.AddWithValue("@modeloEq", cbModelo.SelectedItem)
        NewTicket.Parameters.AddWithValue("@TipodeDano", cbComponente.SelectedItem)
        NewTicket.Parameters.AddWithValue("@prio", "Alta")
        NewTicket.Parameters.AddWithValue("@descrip", tbDescripcion.Text)
        NewTicket.Parameters.AddWithValue("@FechaCreac", Fecha)
        NewTicket.Parameters.AddWithValue("@FechaEsti", FechaEstimada)
        NewTicket.Parameters.AddWithValue("@estado", "Enviado")
        NewTicket.Parameters.AddWithValue("@Observacion", Funciones.UserLoginCajero)

        'Ejecutar procedimiento

        NewTicket.ExecuteNonQuery()

        conexion.Close()

    End Sub


    'Para mostrar los límites de caracteres en el textobox descripcion
    Private Sub tbDescripcion_TextChanged(sender As Object, e As EventArgs) Handles tbDescripcion.TextChanged

        Dim maxLength As Integer = 250
        limiteChar.Text = tbDescripcion.TextLength.ToString & "/" & maxLength

    End Sub

End Class