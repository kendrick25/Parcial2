Imports System.Data.SqlClient
Public Class Usuario

    Public conex As New SqlConnection("Data Source=DESKTOP-8ELH4DT;Initial Catalog=JKEnterprise;Integrated Security=True")


    'Variables publicas que van a contener el id y nombre de usuario para cuando hago el load de nuevo ticket 
    'Estas ya traen valor del modulo "Funciones"
    'No se ha controlado que si se ingresan valores que no estan en la base de datos tanto de user como pass... mando estos valores
    'asumiendo que son correctos tanto pass como user y que existen en la base de datos...


    Public idUsuario As String = ""
    Public usuarioName As String = ""

    Private Sub BtnFinalizar_Click(sender As Object, e As EventArgs) Handles BtnFinalizar.Click
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea finalizar la solicitud de ticktet actual?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            'borrar Pagina actual
            Dim tab As TabPage = MenuPrincipal.ContForms.SelectedTab
            MenuPrincipal.ContForms.TabPages.Remove(tab)
            Me.Close()
        End If
    End Sub

    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btConfirm2.Enabled = False
        gbDetalleTicket2.Enabled = False
        btConfirm4.Enabled = False
        lbPrioridad.Visible = False
        lbExtras.Visible = False
        lbDias.Visible = False
        bnCrearTicket.Enabled = False
        'Establece la fecha actual

        lbFechaActual.Text = DateTime.Now.ToString("yyyy-MM-dd")

        'Obtiene la cadena nombre_de_usuario proveniente del login

        usuarioName = Funciones.UserLoginName



        'Variable para almacenar la Id de usuario cuyo nombre coincida con el de arriba
        'Esta variable globar se le asigna el valor de ID que trae del inicio de sesion
        idUsuario = Funciones.userID


        'La asigno al texbox que contendrá la id para poder mandar el ticket con el procedimiento
        lbDimeID.Text = idUsuario

    End Sub

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
                End If

            End If
        End If

    End Sub

    Private Sub btConfirm2_Click(sender As Object, e As EventArgs) Handles btConfirm2.Click
        btConfirm1.Enabled = True
        gbDetalleTicket1.Enabled = True
        gbDetalleTicket2.Enabled = False
        btConfirm2.Enabled = False
        lbPrioridad.Visible = False
        lbExtras.Visible = False
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

        limiteChar.Text = tbDescripcion.TextLength.ToString & "/" & maxLength
    End Sub

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
        End If

    End Sub


    Private Sub btConfirm4_Click(sender As Object, e As EventArgs) Handles btConfirm4.Click
        btConfirm3.Enabled = True
        gbDetalleTicket2.Enabled = True
        btConfirm4.Enabled = False
        lbPrioridad.Visible = True
        lbExtras.Visible = True
        limiteChar.Visible = True
        bnCrearTicket.Enabled = False
    End Sub


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

    Public Function estableceFechaEstimada(dias As Integer, Fecha As String) As String

        Dim fechaEstimada As Date
        ' Genera la fecha estimada sumando los días a la fecha inicial
        fechaEstimada = DateAdd("d", dias, Fecha)

        ' Imprime la fecha estimada
        Return fechaEstimada
    End Function

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

    Public Sub llenarComponentesPC()
        cbComponente.Items.Clear()
        cbComponente.Items.Add("Placa base")
        cbComponente.Items.Add("Window")
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

    Private Sub bnCrearTicket_Click(sender As Object, e As EventArgs) Handles bnCrearTicket.Click

        conex.Open()

        'Procedimiento para enviar ticket

        Dim NewTicket As New SqlCommand()
        'Procedimiento almacenado para eliminar el libro seleccionado del combo
        NewTicket.Connection = conex

        NewTicket.CommandType = CommandType.StoredProcedure

        NewTicket.CommandText = "NuevoTicket"

        NewTicket.Parameters.AddWithValue("@idRequest", lbDimeID.Text)
        NewTicket.Parameters.AddWithValue("@equipo", cbEquipo.SelectedItem)
        NewTicket.Parameters.AddWithValue("@modeloEq", cbModelo.SelectedItem)
        NewTicket.Parameters.AddWithValue("@TipodeDano", cbComponente.SelectedItem)
        NewTicket.Parameters.AddWithValue("@prio", "Alta")
        NewTicket.Parameters.AddWithValue("@descrip", tbDescripcion.Text)
        NewTicket.Parameters.AddWithValue("@FechaCreac", lbFechaActual.Text)
        NewTicket.Parameters.AddWithValue("@FechaEsti", lbFechaEstimada.Text)
        NewTicket.Parameters.AddWithValue("@estado", "En revisión")



        'Ejecutar procedimiento

        Dim answer5 As Integer

        answer5 = MsgBox("¿DESEAS ENVIAR EL TICKET? ", vbYesNo)
        If answer5 = vbYes Then
            NewTicket.ExecuteNonQuery()
        Else
            'Devuelve a la pantalla
        End If

        conex.Close()


        'Crear ticket con los datos suministrados y agregarlos a la data base. PENDIENTE
    End Sub



End Class