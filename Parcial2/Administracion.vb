Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Public Class Administracion
    Public ContBoton As Boolean = False
    'conexion de  base de datos
    Public conexion As New SqlConnection(Funciones.Conexion)
    Private Sub BtnFinalizar_Click(sender As Object, e As EventArgs) Handles BtnFinalizar.Click
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea finalizar la Administracion?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            'borrar Pagina actual
            Dim tab As TabPage = MenuPrincipal.ContForms.SelectedTab
            MenuPrincipal.ContForms.TabPages.Remove(tab)
            Me.Close()
        End If
    End Sub
    'ver todo los tiketks
    Public Sub VerTodo()
        conexion.Open()
        ' Crear el comando y asignar el nombre del procedimiento almacenado
        Dim command As New SqlCommand("ObtenerTodosLosTickets", conexion)
        command.CommandType = CommandType.StoredProcedure
        Dim dataTable As New DataTable()
        ' Crear el adaptador y llenar la tabla
        Dim adapter As New SqlDataAdapter(command)
        adapter.Fill(dataTable)
        DataGridView1.Columns.Clear()

        DataGridView1.DataSource = dataTable
        DataGridView1.Columns("idTicket").HeaderText = "ID"
        DataGridView1.Columns("Nombre").HeaderText = "Nombre del CLiente"
        DataGridView1.Columns("estado").HeaderText = "Estado"
        DataGridView1.Columns("equipo").HeaderText = "Equipo"
        DataGridView1.Columns("modelo").HeaderText = "Modelo"
        DataGridView1.Columns("tipodeDano").HeaderText = "Tipo de Daño"
        DataGridView1.Columns("prioridad").HeaderText = "Prioridad"
        DataGridView1.Columns("descripcion").HeaderText = "Descripción del Cliente"
        DataGridView1.Columns("responsable").HeaderText = "Empleado Encargado"
        DataGridView1.Columns("tipoArreglo").HeaderText = "Tipo de Reparación"
        DataGridView1.Columns("observacion").HeaderText = "Observación del Encargado"
        DataGridView1.Columns("monto").HeaderText = "Monto Estimado a Pagar"
        DataGridView1.Columns("montoArreglo").HeaderText = "Monto de reparación"
        DataGridView1.Columns("costosExtras").HeaderText = "Costos Extras"
        DataGridView1.Columns("fechaCreacion").HeaderText = "Fecha de Creación"
        DataGridView1.Columns("fechaEstimacion").HeaderText = "Fecha de Estimación"
        DataGridView1.Columns("fechaCierre").HeaderText = "Fecha de Cierre"
        conexion.Close()
    End Sub
    'ver tikets Pagados
    Public Sub MostrarPagados()
        Dim dataTable As New DataTable()

        conexion.Open()

        ' Crear el comando y asignar el nombre del procedimiento almacenado
        Dim command As New SqlCommand("VerHistorialPago", conexion)
        command.CommandType = CommandType.StoredProcedure

        ' Crear el adaptador y llenar la tabla
        Dim adapter As New SqlDataAdapter(command)
        adapter.Fill(dataTable)
        DataGridView1.Columns.Clear()

        DataGridView1.DataSource = dataTable
        DataGridView1.Columns("idTicket").HeaderText = "ID"
        DataGridView1.Columns("Nombre").HeaderText = "Nombre del CLiente"
        DataGridView1.Columns("estado").HeaderText = "Estado"
        DataGridView1.Columns("equipo").HeaderText = "Equipo"
        DataGridView1.Columns("modelo").HeaderText = "Modelo"
        DataGridView1.Columns("tipodeDano").HeaderText = "Tipo de Daño"
        DataGridView1.Columns("prioridad").HeaderText = "Prioridad"
        DataGridView1.Columns("descripcion").HeaderText = "Descripción del Cliente"
        DataGridView1.Columns("responsable").HeaderText = "Empleado Encargado"
        DataGridView1.Columns("tipoArreglo").HeaderText = "Tipo de Reparación"
        DataGridView1.Columns("observacion").HeaderText = "Observación del Encargado"
        DataGridView1.Columns("monto").HeaderText = "Monto Estimado a Pagar"
        DataGridView1.Columns("montoArreglo").HeaderText = "Monto de reparación"
        DataGridView1.Columns("costosExtras").HeaderText = "Costos Extras"
        DataGridView1.Columns("fechaCreacion").HeaderText = "Fecha de Creación"
        DataGridView1.Columns("fechaEstimacion").HeaderText = "Fecha de Estimación"
        DataGridView1.Columns("fechaCierre").HeaderText = "Fecha de Cierre"
        conexion.Close()
    End Sub


    'tiketks Pendientes
    Public Sub MosstrartiketsPendientes()
        conexion.Open()

        Dim consulta As String = "Select idTicket,equipo,modelo,tipodeDano,prioridad,descripcion,fechaCreacion,fechaEstimacion,estado from Ticket where estado='Pendiente'"
        Dim ejecutar As New SqlCommand(consulta, conexion)
        Dim tabla As New SqlDataAdapter(ejecutar)
        Dim dss As New DataSet
        tabla.Fill(dss, "Ticket")
        DataGridView1.Columns.Clear()
        DataGridView1.DataSource = dss.Tables("Ticket")
        DataGridView1.Columns("idTicket").HeaderText = "ID"
        DataGridView1.Columns("estado").HeaderText = "Estado"
        DataGridView1.Columns("equipo").HeaderText = "Equipo"
        DataGridView1.Columns("modelo").HeaderText = "Modelo"
        DataGridView1.Columns("tipodeDano").HeaderText = "Tipo de Daño"
        DataGridView1.Columns("prioridad").HeaderText = "Prioridad"
        DataGridView1.Columns("descripcion").HeaderText = "Descripción del Cliente"
        DataGridView1.Columns("fechaCreacion").HeaderText = "Fecha de Creación"
        DataGridView1.Columns("fechaEstimacion").HeaderText = "Fecha de Estimacion"
        conexion.Close()
    End Sub
    'tikets En revision
    Public Sub MosstrartiketsRevision()
        conexion.Open()
        Dim consulta As String = "Select idTicket,equipo,modelo,tipodeDano,prioridad,descripcion,fechaCreacion,fechaEstimacion,responsable,estado from Ticket where estado='En Revisión'"
        Dim ejecutar As New SqlCommand(consulta, conexion)
        Dim tabla As New SqlDataAdapter(ejecutar)
        Dim dss As New DataSet
        tabla.Fill(dss, "Ticket")
        DataGridView1.Columns.Clear()
        DataGridView1.DataSource = dss.Tables("Ticket")
        DataGridView1.Columns("idTicket").HeaderText = "ID"
        DataGridView1.Columns("estado").HeaderText = "Equipo"
        DataGridView1.Columns("equipo").HeaderText = "Equipo"
        DataGridView1.Columns("modelo").HeaderText = "Modelo"
        DataGridView1.Columns("tipodeDano").HeaderText = "Tipo de Daño"
        DataGridView1.Columns("prioridad").HeaderText = "Prioridad"
        DataGridView1.Columns("descripcion").HeaderText = "Descripcion del Cliente"
        DataGridView1.Columns("fechaCreacion").HeaderText = "Fecha de Creación"
        DataGridView1.Columns("responsable").HeaderText = "Responsable"
        conexion.Close()
    End Sub
    'tikets En revision
    Public Sub MosstrartiketsFinalizados()
        conexion.Open()
        Dim consulta As String = "Select idTicket,equipo,modelo,tipodeDano,prioridad,descripcion,fechaCreacion,fechaCierre,observacion,responsable,monto,estado,tipoArreglo,montoArreglo,costosExtras from Ticket where estado='Finalizado'"
        Dim ejecutar As New SqlCommand(consulta, conexion)
        Dim tabla As New SqlDataAdapter(ejecutar)
        Dim dss As New DataSet
        tabla.Fill(dss, "Ticket")
        DataGridView1.DataSource = dss.Tables("Ticket")
        DataGridView1.Columns("idTicket").HeaderText = "ID"
        DataGridView1.Columns("estado").HeaderText = "Estado"
        DataGridView1.Columns("equipo").HeaderText = "Equipo"
        DataGridView1.Columns("modelo").HeaderText = "Modelo"
        DataGridView1.Columns("tipodeDano").HeaderText = "Tipo de Daño"
        DataGridView1.Columns("prioridad").HeaderText = "Prioridad"
        DataGridView1.Columns("descripcion").HeaderText = "Descripcion del Cliente"
        DataGridView1.Columns("fechaCreacion").HeaderText = "Fecha de Creación"
        DataGridView1.Columns("responsable").HeaderText = "Responsable"
        conexion.Close()
    End Sub
    'Mostrar tikets Pagados
    Public Sub HistorialPagos()
        Dim dataTable As New DataTable()
        conexion.Open()
        ' Crear el comando y asignar el nombre del procedimiento almacenado
        Dim command As New SqlCommand("HistorialPagos", conexion)
        command.CommandType = CommandType.StoredProcedure
        ' Crear el adaptador y llenar la tabla
        Dim adapter As New SqlDataAdapter(command)
        adapter.Fill(dataTable)
        DataGridView1.Columns.Clear()
        DataGridView1.DataSource = dataTable
        DataGridView1.Columns("idTicket").HeaderText = "ID"
        DataGridView1.Columns("nombre").HeaderText = "Nombre del CLiente"
        DataGridView1.Columns("estado").HeaderText = "Estado"
        DataGridView1.Columns("equipo").HeaderText = "Equipo"
        DataGridView1.Columns("modelo").HeaderText = "Modelo"
        DataGridView1.Columns("responsable").HeaderText = "Empleado Encargado"
        DataGridView1.Columns("tipoArreglo").HeaderText = "Tipo de Reparación"
        DataGridView1.Columns("observacion").HeaderText = "Observación del Encargado"
        DataGridView1.Columns("montoArreglo").HeaderText = "Monto de reparación"
        DataGridView1.Columns("costosExtras").HeaderText = "Costos Extras"
        DataGridView1.Columns("fechaCreacion").HeaderText = "Fecha de Creación"
        DataGridView1.Columns("fechaCierre").HeaderText = "Fecha de Cierre"
        conexion.Close()
    End Sub
    Public Sub AgendarEmpleado()

        conexion.Open()
        Dim consulta As String = "Select numeroTareas from UserRol  where idURer=(select idUser from Usuario  where nombre='" & ComboBoxEmpleados.Text & "')"
        Dim ejecutar As New SqlCommand(consulta, conexion)
        'Ejecutar comando
        Dim reader As SqlDataReader = ejecutar.ExecuteReader()
        Dim valor As Integer
        Dim leervalor As Integer
        If reader.Read() <> Nothing Then
            ' La variable es nula
            If reader.Read() Then
                'datos de cliente
                Integer.TryParse(reader("numeroTareas").ToString, leervalor)
            End If
        Else
            leervalor = 1
        End If
        valor = leervalor + 1
        reader.Close()
        conexion.Close()
        conexion.Open()
        Dim procAgendar As New SqlCommand()
        procAgendar.Connection = conexion
        procAgendar.CommandType = CommandType.StoredProcedure
        procAgendar.CommandText = "AgendarEmpleado"
        procAgendar.Parameters.AddWithValue("@idTicket ", TextBoxIdTicket.Text)
        procAgendar.Parameters.AddWithValue("@responsable", ComboBoxEmpleados.Text)
        procAgendar.Parameters.AddWithValue("@prioridad", "Media")
        procAgendar.Parameters.AddWithValue("@estado", "En Revisión")
        procAgendar.Parameters.AddWithValue("@observacion", TextBoxObservacion.Text)
        procAgendar.Parameters.AddWithValue("@numeroTareas", valor)
        'Ejecutar procedimiento
        procAgendar.ExecuteNonQuery()
        conexion.Close()
        LabelComplete.Visible = True
        LabelComplete.Text = "Cliente Agendado"
    End Sub
    Public Sub MostrarEmpleadosDisponible()
        ComboBoxEmpleados.Items.Clear()
        conexion.Open()
        Dim mostrarLibrosDisponibles As String = "select nombre
                                                    from Usuario i, UserRol u 
                                                    where i.idUser = u.idURer 
                                                    and (u.rolUser = 'empleado' 
                                                    or u.rolUser = 'admin' ) 
                                                    and u.estado = 'Disponible' 
                                                    and (u.numeroTareas < 10 or ISNULL(u.numeroTareas,'') = '' OR LEN(u.numeroTareas) = 0)"
        Dim llenar As New SqlCommand(mostrarLibrosDisponibles, conexion)
        Dim reader As SqlDataReader = llenar.ExecuteReader()
        While reader.Read()
            ComboBoxEmpleados.Items.Add(reader("nombre").ToString())
        End While
        reader.Close()
        conexion.Close()
    End Sub
    ' label para el numero de tarea de los empleados 
    Public Sub NumeroTareasEmpleado()
        conexion.Open()
        Dim mostrarLibrosDisponibles As String = "select numeroTareas from Usuario i, UserRol u 
                                                  where i.idUser = u.idURer and (u.rolUser = 'empleado' or u.rolUser = 'admin' ) 
                                                  and u.estado = 'Disponible' and u.numeroTareas < 10 and nombre='" & ComboBoxEmpleados.Text & "'"
        Dim llenar As New SqlCommand(mostrarLibrosDisponibles, conexion)
        Dim reader As SqlDataReader = llenar.ExecuteReader()
        While reader.Read()
            LabelTareas.Text = reader("numeroTareas").ToString()
        End While
        reader.Close()
        conexion.Close()
    End Sub
    Private Sub Administracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'datagridview
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ReadOnly = True
        'opciones
        ComboBoxOpciones.Items.Clear()
        ComboBoxOpciones.Items.Add("--Selecionar--")
        ComboBoxOpciones.Items.Add("Agendar")
        ComboBoxOpciones.Items.Add("Buscar")
        ComboBoxOpciones.Items.Add("Historial de Pagos")
        ComboBoxOpciones.SelectedIndex = 0
        'mostrar
        ComboBoxMostrar.Items.Clear()
        ComboBoxMostrar.Items.Add("--Selecionar--")
        ComboBoxMostrar.Items.Add("Prioridad Alta")
        ComboBoxMostrar.Items.Add("Prioridad Media")
        ComboBoxMostrar.Items.Add("Prioridad Baja")
        ComboBoxMostrar.Items.Add("N/D")
        ComboBoxMostrar.Items.Add("Todo")
        ComboBoxMostrar.SelectedIndex = 0
        'estados
        ComboBoxEstado.Items.Clear()
        ComboBoxEstado.Items.Add("Pendiente")
        ComboBoxEstado.Items.Add("En Revisión")
        ComboBoxEstado.Items.Add("Finalizado")
        ComboBoxEstado.Items.Add("Pagado")
        VerTodo()
        'tamaño de encabezado
        TableLayoutPanel1.RowStyles(2).Height = 0 '200
        TableLayoutPanel1.RowStyles(3).Height = 0 '200
        TableLayoutPanel1.RowStyles(4).Height = 0 '80

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd hh:mm tt"

        DateTimePicker1.ShowUpDown = True
        DateTimePicker1.DropDownAlign = LeftRightAlignment.Right

        'cosas no visibles
        LabelComplete.Visible = False
        LabelErrorID.Visible = False
        LabelTime.Visible = False
        BtnModificar.Visible = False
        ButtonMostrarOcultar.Visible = False
        BtnAcction.Visible = False
        BtnBorrarRegistro.Visible = False
        BtnBorrarTodo.Visible = False
        'No. de tareas
        LabelTextTarea.Visible = False
        LabelTareas.Visible = False
    End Sub

    Private Sub ComboBoxOpciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOpciones.SelectedIndexChanged
        If ComboBoxOpciones.SelectedItem.ToString() = "--Selecionar--" Then
            ComboBoxEmpleados.Items.Clear()
            ComboBoxMostrar.Visible = False
            LabelMostrar.Visible = False
            'text ID
            TextBoxIdTicket.Text = ""
            LabelIDTikect.Visible = False
            TextBoxIdTicket.Visible = False
            LabelErrorID.Visible = False
            'tamaño de encabezado
            TableLayoutPanel1.RowStyles(2).Height = 0 '200
            TableLayoutPanel1.RowStyles(3).Height = 0 '200
            TableLayoutPanel1.RowStyles(4).Height = 0 '80
            'mostrar boton
            ButtonMostrarOcultar.Visible = False
            'btn acciones
            BtnAcction.Visible = False
        Else
            'text ID
            LabelIDTikect.Visible = True
            TextBoxIdTicket.Visible = True
        End If
        If ComboBoxOpciones.Text = "Agendar" Then
            MosstrartiketsPendientes()
            LabelIDTikect.Text = "ID:"
            TextBoxIdTicket.Text = ""
            DateTimePicker1.Enabled = False
            'empleados y estado
            MostrarEmpleadosDisponible()
            ComboBoxEstado.Enabled = False
            'mostrar
            ComboBoxMostrar.SelectedItem = "Prioridad Alta"
            ComboBoxMostrar.Visible = False
            LabelMostrar.Visible = False
            'tamaño de encabezado
            TableLayoutPanel1.RowStyles(2).Height = 0 '200
            TableLayoutPanel1.RowStyles(3).Height = 0 '200
            TableLayoutPanel1.RowStyles(4).Height = 0 '80

            'mostrar boton
            ContBoton = False
            'Btn para agregar componentes
            BtnAgregarComponentes.Enabled = False
            ButtonMostrarOcultar.Visible = False
            'campos de busqueda
            ComboBoxEquipo.Enabled = False
            ComboBoxModelo.Enabled = False
            ComboBoxTipoDano.Enabled = False
            ComboBoxEstado.Enabled = False
            ComboBoxTipoReparacion.Enabled = False
            TextBoxObservacion.Enabled = False
            TextBoxDescripcionCliente.ReadOnly = True
        End If
        If ComboBoxOpciones.Text = "Buscar" Then
            VerTodo()
            LabelIDTikect.Text = "ID o Nombre :"
            DateTimePicker1.Enabled = True
            'empleados y estado
            MostrarEmpleadosDisponible()
            ComboBoxEstado.Enabled = False
            'mostrar
            ComboBoxMostrar.SelectedItem = "--Selecionar--"
            ComboBoxMostrar.Visible = True
            LabelMostrar.Visible = True
            'tamaño de encabezado
            TableLayoutPanel1.RowStyles(2).Height = 0 '200
            TableLayoutPanel1.RowStyles(3).Height = 0 '200
            TableLayoutPanel1.RowStyles(4).Height = 0 '80
            'mostrar boton
            ContBoton = False
            ButtonMostrarOcultar.Visible = True
            'Btn para agregar componentes
            BtnAgregarComponentes.Enabled = True
            'campos de busqueda
            ComboBoxEquipo.Enabled = True
            ComboBoxModelo.Enabled = True
            ComboBoxTipoDano.Enabled = True
            ComboBoxTipoReparacion.Enabled = True
            ComboBoxEstado.Enabled = True
            TextBoxObservacion.Enabled = True
            TextBoxDescripcionCliente.ReadOnly = False
        End If
        If ComboBoxOpciones.Text = "Historial de Pagos" Then
            TextBoxIdTicket.Text = ""
            LabelErrorID.Visible = False
            LabelComplete.Visible = False

            'Btn para agregar componentes
            BtnAgregarComponentes.Enabled = False
            ButtonMostrarOcultar.Visible = False
            LabelIDTikect.Text = "ID o Nombre :"
            HistorialPagos()
            ComboBoxMostrar.Visible = False
            LabelMostrar.Visible = False
            'tamaño de encabezado
            TableLayoutPanel1.RowStyles(2).Height = 0 '200
            TableLayoutPanel1.RowStyles(3).Height = 0 '200
            TableLayoutPanel1.RowStyles(4).Height = 0 '80
        End If
        If Not ContBoton Then
            Dim Img As Image = My.Resources.boton_abajo
            ButtonMostrarOcultar.BackgroundImage = Img
        End If
    End Sub
    Private Sub ButtonMostrarOcultar_Click(sender As Object, e As EventArgs) Handles ButtonMostrarOcultar.Click
        If ComboBoxOpciones.Text = "Agendar" Then
            If Not ContBoton Then
                'tamaño de encabezado
                TableLayoutPanel1.RowStyles(2).Height = 200 '200
                TableLayoutPanel1.RowStyles(3).Height = 200 '200
                TableLayoutPanel1.RowStyles(4).Height = 0 '80
                ContBoton = True
            Else
                'tamaño de encabezado
                TableLayoutPanel1.RowStyles(2).Height = 0 '200
                TableLayoutPanel1.RowStyles(3).Height = 0 '200
                TableLayoutPanel1.RowStyles(4).Height = 0 '80
                ContBoton = False
            End If
        End If
        If ComboBoxOpciones.Text = "Buscar" Then
            If Not ContBoton Then
                'tamaño de encabezado
                TableLayoutPanel1.RowStyles(2).Height = 200 '200
                TableLayoutPanel1.RowStyles(3).Height = 200 '200
                TableLayoutPanel1.RowStyles(4).Height = 80 '80
                ContBoton = True
            Else
                'tamaño de encabezado
                TableLayoutPanel1.RowStyles(2).Height = 0 '200
                TableLayoutPanel1.RowStyles(3).Height = 0 '200
                TableLayoutPanel1.RowStyles(4).Height = 0 '80
                ContBoton = False
            End If
        End If
        If ComboBoxOpciones.Text = "Historial de Pagos" Then
            If Not ContBoton Then
                TableLayoutPanel1.RowStyles(2).Height = 0 '200
                TableLayoutPanel1.RowStyles(3).Height = 0 '200
                TableLayoutPanel1.RowStyles(4).Height = 80 '80
                ContBoton = True
            Else
                'tamaño de encabezado
                TableLayoutPanel1.RowStyles(2).Height = 0 '200
                TableLayoutPanel1.RowStyles(3).Height = 0 '200
                TableLayoutPanel1.RowStyles(4).Height = 0 '80
                ContBoton = False
            End If
        End If
        If Not ContBoton Then
            Dim Img As Image = My.Resources.boton_abajo
            ButtonMostrarOcultar.BackgroundImage = Img
            TableLayoutPanel1.BackColor = Color.Transparent
        Else
            Dim Img As Image = My.Resources.boton_arriba
            ButtonMostrarOcultar.BackgroundImage = Img
            TableLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64)
        End If
    End Sub

    Private Sub BtnAcction_Click(sender As Object, e As EventArgs) Handles BtnAcction.Click
        If ComboBoxOpciones.Text = "Agendar" Then
            Dim numItems As Integer = ComboBoxOpciones.Items.Count
            If ComboBoxEmpleados.Text = "" Or TextBoxIdTicket.Text = "" Or numItems = 0 Then
                LabelComplete.Visible = True
                If ComboBoxEmpleados.Text = "" Or TextBoxIdTicket.Text = "" Then
                    LabelComplete.Text = "Error: Verifique que el campo ID o Responsable  no esten vacios"
                End If
                If numItems = 0 Then
                    LabelComplete.Text = "Error: No Se encuentran Empleados Disponibles para asignar tareas"
                End If
            Else
                AgendarEmpleado()
                MosstrartiketsPendientes()
                MostrarEmpleadosDisponible()
                'tamaño de encabezado
                TableLayoutPanel1.RowStyles(2).Height = 0 '200
                TableLayoutPanel1.RowStyles(3).Height = 0 '200
                TableLayoutPanel1.RowStyles(4).Height = 0 '80
                Dim Img As Image = My.Resources.boton_abajo
                ButtonMostrarOcultar.BackgroundImage = Img
                TableLayoutPanel1.BackColor = Color.Transparent
                ButtonMostrarOcultar.Visible = False
                ContBoton = False
                TextBoxIdTicket.Text = ""
            End If
        End If
        If ComboBoxOpciones.Text = "Buscar" And TextBoxIdTicket.Text <> "" Then
            Dim resultado As MsgBoxResult
            resultado = CType(MessageBox.Show("¿Desea Exportar una Factura para guradar el reporte?", "Se Cancelara el Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
            If resultado = MsgBoxResult.No Then
                CancelarPago()
            Else
                CancelarPago()
            End If
        End If
    End Sub
    Private Sub ComboBoxMostrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMostrar.SelectedIndexChanged
        If ComboBoxMostrar.Text = "Prioridad Alta" Then
            MosstrartiketsPendientes()
        End If
        If ComboBoxMostrar.Text = "Prioridad Media" Then
            MosstrartiketsRevision()
        End If
        If ComboBoxMostrar.Text = "Prioridad Baja" Then
            MosstrartiketsFinalizados()
        End If
        If ComboBoxMostrar.Text = "Todo" Or ComboBoxMostrar.Text = "--Selecionar--" Then
            VerTodo()
        End If
        If ComboBoxMostrar.Text = "N/D" Then
            MostrarPagados()
        End If
    End Sub

    Public Sub CancelarPago()
        conexion.Open()
        Dim procAgendar As New SqlCommand()
        procAgendar.Connection = conexion
        procAgendar.CommandType = CommandType.StoredProcedure
        procAgendar.CommandText = "CancelarPago"
        procAgendar.Parameters.AddWithValue("@idTicket ", TextBoxIdTicket.Text)
        procAgendar.Parameters.AddWithValue("@prioridad", "N/D")
        procAgendar.Parameters.AddWithValue("@estado", "Pagado")
        'Ejecutar procedimiento
        procAgendar.ExecuteNonQuery()
        conexion.Close()
        LabelComplete.Visible = Visible
        LabelComplete.Text = "--Monto de Cliente Cancelado--"
    End Sub
    Public Sub ImprimirFactura()
        conexion.Open()
        Dim procAgendar As New SqlCommand()
        procAgendar.Connection = conexion
        procAgendar.CommandType = CommandType.StoredProcedure
        procAgendar.CommandText = "ImprimirFactura"
        procAgendar.Parameters.AddWithValue("@idTicket ", TextBoxIdTicket.Text)
        'Ejecutar procedimiento
        Dim reader As SqlDataReader = procAgendar.ExecuteReader()
        If reader.Read() Then
            'datos de cliente
            Dim mensaje As New Factura
            mensaje.LabelNCliente.Text = reader("idUser").ToString()
            mensaje.LabelNombreCliente.Text = reader("nombre").ToString()
            mensaje.LabelCedula.Text = reader("cedula").ToString()
            mensaje.LabelTelefono.Text = reader("contacto").ToString()
            mensaje.Labelcorreo.Text = reader("correoUser").ToString()
            'falta correo
            'datos de equipo

            mensaje.LabelNFactura.Text = reader("idTicket").ToString()
            mensaje.LabelRevision.Text = "Revisión de equipo " & reader("equipo").ToString() & " de  modelo " & reader("modelo").ToString() & ". El cual fue mando a revision por el tipo de daño de" & reader("tipodeDano").ToString() & "."
            'datos de reparacion para factura
            mensaje.LabelEmpleadoEncargado.Text = " " & reader("responsable").ToString()
            mensaje.LabelTipoReparacion.Text = " " & reader("tipoArreglo").ToString()
            mensaje.TextBoxObservacion.Text = " " & reader("observacion").ToString()
            Dim costrep As Double
            Double.TryParse(reader("montoArreglo").ToString(), costrep)
            mensaje.LabelCostosReparacion.Text = costrep.ToString("C")
            Dim costext As Double
            Double.TryParse(reader("costosExtras").ToString(), costext)
            mensaje.LabelCostosExtras.Text = costext.ToString("C")
            'Calculo de Montos
            Dim montoArreglo As Double
            Dim costosExtras As Double
            Dim subtotal As Double
            Dim impuesto As Double
            Dim total As Double
            Double.TryParse(reader("montoArreglo").ToString(), montoArreglo)
            Double.TryParse(reader("costosExtras").ToString(), costosExtras)
            subtotal = 20 + costosExtras + montoArreglo
            impuesto = subtotal * 0.07
            total = subtotal + impuesto
            mensaje.LabelSubTotal.Text = subtotal.ToString("C")
            mensaje.LabelImpuestos.Text = impuesto.ToString("C")
            mensaje.LabelTotalPagar.Text = total.ToString("C")
            mensaje.LabelEfectivoPagar.Text = total.ToString("C")
            mensaje.Show()
        End If
        conexion.Close()
    End Sub

    Private Sub BtnGenerarFactura_Click(sender As Object, e As EventArgs) Handles BtnGenerarFactura.Click
        If TextBoxIdTicket.Text <> "" And (ComboBoxOpciones.Text = "Buscar" Or ComboBoxOpciones.Text = "Historial de Pagos") Then
            ImprimirFactura()
        End If
    End Sub
    'funcion de busqueda de datos Agendar
    Public Sub BuscarDatosAgendar()
        conexion.Open()
        Dim procAgendar As New SqlCommand()
        procAgendar.Connection = conexion
        procAgendar.CommandType = CommandType.StoredProcedure
        procAgendar.CommandText = "BusquedaDatosAgendar"
        procAgendar.Parameters.AddWithValue("@idTicket ", TextBoxIdTicket.Text)
        'Ejecutar procedimiento
        Dim reader As SqlDataReader = procAgendar.ExecuteReader()
        If reader.Read() Then
            'datos de cliente
            LabeIDusers.Text = reader("idUser").ToString()
            LabelName.Text = reader("nombre").ToString()
            LabelCedula.Text = reader("cedula").ToString()
            LabelCorreo.Text = reader("correoUser").ToString()
            'datos de equipo
            'equipo
            ComboBoxEquipo.Items.Clear()
            ComboBoxEquipo.Items.Add(reader("equipo").ToString())
            ComboBoxEquipo.SelectedItem = reader("equipo").ToString()
            'modelo
            ComboBoxModelo.Items.Clear()
            ComboBoxModelo.Items.Add(reader("modelo").ToString())
            ComboBoxModelo.SelectedItem = reader("modelo").ToString()
            'tipo de daño
            ComboBoxTipoDano.Items.Clear()
            ComboBoxTipoDano.Items.Add(reader("tipodeDano").ToString())
            ComboBoxTipoDano.SelectedItem = reader("tipodeDano").ToString()
            'descripcion
            TextBoxDescripcionCliente.Text = reader("descripcion").ToString()
            LabelPrioridad.Text = "Alta"
            ComboBoxEstado.SelectedItem = "Pendiente"
            TextBoxObservacion.Text = "--Reporte de Trasabilidad--" & vbNewLine &
                                      "No. de Tikect: " & TextBoxIdTicket.Text & vbNewLine &
                                      "Nombre de Cliente: " & reader("nombre").ToString() & vbNewLine &
                                      "Equipo enviado a Revisión: " & reader("equipo").ToString() & "-Modelo-" & reader("modelo").ToString() & vbNewLine &
                                      "Recibido por Empleado(a) de Caja: " & reader("observacion").ToString() & vbNewLine & 'falta mandar el nombre del empleado de caja
                                      "Fecha de Inicio: " & reader("fechaCreacion").ToString() & vbNewLine &
                                      "Fecha de Estimación de Reparación: " & reader("fechaEstimacion").ToString() & vbNewLine
            Dim fechaInicio As DateTime = reader("fechaCreacion").ToString()
            Dim fechaEstimacion As DateTime = reader("fechaEstimacion").ToString()
            Dim fechaFormateada As String = fechaInicio.ToString("yyyy/MM/dd")
            Dim fechaFormateada2 As String = fechaEstimacion.ToString("yyyy/MM/dd")
            LabelFechaInicio.Text = fechaFormateada
            LabelFechaEstimacion.Text = fechaFormateada2
            'cantidad de letras de multiline
            Dim caracteres As Integer = TextBoxObservacion.TextLength
            LabelContMultiline.Text = caracteres.ToString() & "/500"
        End If
        conexion.Close()
    End Sub

    'Control de Busqueda de ID
    'KeyPress para controlar ACSII para input a tabla
    Private Sub TextBoxIdTicket_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxIdTicket.KeyPress
        Dim allowedChars As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890´ " ' Agrega los caracteres permitidos aquí
        Dim currentText As String = TextBoxIdTicket.Text.Trim()
        If e.KeyChar <> " " AndAlso Not allowedChars.Contains(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

    End Sub
    Private Sub TextBoxIdTicket_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIdTicket.TextChanged
        'control de validacion de texto ingresado segun el modo
        Dim i As Integer
        For i = 1 To Len(TextBoxIdTicket.Text)
            If Not IsNumeric(Mid(TextBoxIdTicket.Text, i, 1)) Then
                If Not Mid(TextBoxIdTicket.Text, i, 1) Like "[A-Ñ-Z0-9 a-ñ-z]" Then
                    Dim Borrar As String = TextBoxIdTicket.Text.Remove(TextBoxIdTicket.Text.Length - 1)
                    TextBoxIdTicket.Text = Borrar
                    TextBoxIdTicket.SelectionStart = TextBoxIdTicket.Text.Length
                    Exit Sub
                End If
            End If
        Next i
        ' Verificar si el TextBox no está vacío
        If Not String.IsNullOrEmpty(TextBoxIdTicket.Text) Then
            ' Verificar si el primer carácter es un número
            If Char.IsDigit(TextBoxIdTicket.Text.Trim()) Then
                ' Eliminar todos los caracteres que no sean números
                TextBoxIdTicket.Text = New String(TextBoxIdTicket.Text.Where(Function(c) Char.IsDigit(c)).ToArray())
                TextBoxIdTicket.SelectionStart = TextBoxIdTicket.Text.Length
            Else
                If Char.IsLetter(TextBoxIdTicket.Text.Trim()) Then
                    Dim j As Integer
                    For j = 1 To Len(TextBoxIdTicket.Text)
                        If IsNumeric(Mid(TextBoxIdTicket.Text, j, 1)) Then
                            Dim Borrar As String = TextBoxIdTicket.Text.Remove(TextBoxIdTicket.Text.Length - 1)
                            TextBoxIdTicket.Text = Borrar
                            TextBoxIdTicket.SelectionStart = TextBoxIdTicket.Text.Length
                            Exit Sub
                        End If
                    Next j
                End If
            End If
        End If
        Dim valor As Double
        Dim cadena As String = TextBoxIdTicket.Text
        Double.TryParse(cadena, valor)
        If IsNumeric(TextBoxIdTicket.Text) And valor >= 2147483646 Then
            Dim Borrar As String = TextBoxIdTicket.Text.Remove(TextBoxIdTicket.Text.Length - 1)
            TextBoxIdTicket.Text = Borrar
            TextBoxIdTicket.SelectionStart = TextBoxIdTicket.Text.Length
            Exit Sub
        End If
        If TextBoxIdTicket.Text.Length >= 40 Then
            Dim Borrar As String = TextBoxIdTicket.Text.Remove(TextBoxIdTicket.Text.Length - 1)
            TextBoxIdTicket.Text = Borrar
            TextBoxIdTicket.SelectionStart = TextBoxIdTicket.Text.Length
            Exit Sub
        End If
        'Control de Acciones
        If TextBoxIdTicket.Text = "" Or TextBoxIdTicket.Text = “” Then
            DataGridView1.ClearSelection()
            ButtonMostrarOcultar.Visible = False
            BtnAcction.Visible = False
            LabelErrorID.Visible = True
            'tamaño de encabezado
            TableLayoutPanel1.RowStyles(2).Height = 0 '200
            TableLayoutPanel1.RowStyles(3).Height = 0 '200
            TableLayoutPanel1.RowStyles(4).Height = 0 '80
            If ComboBoxOpciones.Text = "Agendar" And (TextBoxIdTicket.Text = "" Or TextBoxIdTicket.Text = “”) Then
                MosstrartiketsPendientes()
            End If
            If ComboBoxOpciones.Text = "Historial de Pagos" And (TextBoxIdTicket.Text = "" Or TextBoxIdTicket.Text = “”) Then
                HistorialPagos()
            End If
            LabelComplete.Visible = False
        Else
            LabelErrorID.Visible = False
            '///////////////////////////////////////////////////////////
            If ComboBoxOpciones.Text = "Agendar" Then
                'codigo para seleccion de datagridview
                conexion.Open()
                Dim cmd As New SqlCommand("Select idTicket,equipo,modelo,tipodeDano,prioridad,descripcion,fechaCreacion,fechaEstimacion,estado from Ticket where estado='Pendiente' And idTicket LIKE @myValue", conexion)
                cmd.Parameters.AddWithValue("@myValue", "%" & TextBoxIdTicket.Text & "%")
                Dim tabla As New SqlDataAdapter(cmd)
                Dim dss As New DataSet
                tabla.Fill(dss, "Ticket")
                DataGridView1.ClearSelection()
                DataGridView1.Columns.Clear()
                DataGridView1.DataSource = dss.Tables("Ticket")
                DataGridView1.Columns("idTicket").HeaderText = "ID"
                DataGridView1.Columns("equipo").HeaderText = "Equipo"
                DataGridView1.Columns("modelo").HeaderText = "Modelo"
                DataGridView1.Columns("tipodeDano").HeaderText = "Tipo de Daño"
                DataGridView1.Columns("prioridad").HeaderText = "Prioridad"
                DataGridView1.Columns("descripcion").HeaderText = "Descripción del Cliente"
                DataGridView1.Columns("fechaCreacion").HeaderText = "Fecha de Creación"
                DataGridView1.Columns("fechaEstimacion").HeaderText = "Fecha de Estimación"
                DataGridView1.Columns("estado").HeaderText = "Estado"
                conexion.Close()
                Dim encotrado1 As Boolean = False
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If row.Cells("idTicket").Value IsNot Nothing AndAlso row.Cells("idTicket").Value = TextBoxIdTicket.Text Then
                        row.Selected = True
                        encotrado1 = True
                        'codigo para busqueda de datos en agenda
                        '--------------------------------------------
                        If IsNumeric(TextBoxIdTicket.Text) Then
                            Dim valornumerico As Integer
                            Integer.TryParse(TextBoxIdTicket.Text, valornumerico)
                            conexion.Open()
                            Dim procAgendar As New SqlCommand()
                            procAgendar.Connection = conexion
                            procAgendar.CommandType = CommandType.StoredProcedure
                            procAgendar.CommandText = "BusquedaDatosAgendar"
                            procAgendar.Parameters.AddWithValue("@idTicket ", valornumerico)
                            'Ejecutar procedimiento
                            Dim reader As SqlDataReader = procAgendar.ExecuteReader()
                            If reader.Read() Then
                                ButtonMostrarOcultar.Visible = True
                                BtnAcction.Visible = True
                                BtnAcction.Text = "Agendar"
                                ContBoton = False
                                Dim Img As Image = My.Resources.boton_abajo
                                ButtonMostrarOcultar.BackgroundImage = Img
                                TableLayoutPanel1.BackColor = Color.Transparent
                                LabelComplete.Visible = True
                                LabelComplete.Text = "Ticket encontrado"
                            Else
                                ButtonMostrarOcultar.Visible = False
                                BtnAcction.Visible = False
                                conexion.Close()
                                Exit Sub
                            End If
                            conexion.Close()
                            BuscarDatosAgendar()
                        Else
                            ButtonMostrarOcultar.Visible = False
                            BtnAcction.Visible = False
                        End If
                        '--------------------------------------------
                    End If
                Next
                If Not encotrado1 Then
                    LabelComplete.Visible = True
                    LabelComplete.Text = "Este Ticket no se encuentra"
                End If
            End If
            '-----------------------
            '///////////////////////////////////////////////////////////
            'codigo para busqueda en historial de pago
            If ComboBoxOpciones.Text = "Historial de Pagos" Then
                'codigo para seleccion de datagridview
                conexion.Open()
                Dim stringquery As String
                If IsNumeric(TextBoxIdTicket.Text) Then
                    stringquery = "T.idTicket LIKE " & TextBoxIdTicket.Text
                ElseIf Char.IsLetter(TextBoxIdTicket.Text) Then
                    stringquery = "U.nombre LIKE '%" & TextBoxIdTicket.Text & "%'"
                Else
                    stringquery = "T.idTicket LIKE '%%'"
                End If
                Dim cmd As New SqlCommand("SELECT T.idTicket,
                                           U.nombre,
                                           T.estado,
                                           T.equipo,
                                           T.modelo,
                                           T.responsable,
                                           T.tipoArreglo,
                                           T.observacion,
                                           T.montoArreglo,
                                           T.costosExtras,
                                           T.fechaCreacion,
                                           T.fechaCierre
                                           FROM Ticket T
                                           INNER JOIN TicketUser TU ON T.idTicket = TU.IdsTicket
                                           INNER JOIN Usuario U ON TU.IdsUser = U.idUser
                                           WHERE ISNUMERIC(U.idUser) = 0
                                                 AND PATINDEX('%[a-ñ-zA-Ñ-Z]%', U.idUser) > 0
                                                 AND T.estado = 'Pagado' AND (" & stringquery & ");", conexion)
                Dim tabla As New SqlDataAdapter(cmd)
                Dim dss As New DataSet
                tabla.Fill(dss, "Ticket")
                DataGridView1.ClearSelection()
                DataGridView1.Columns.Clear()
                DataGridView1.DataSource = dss.Tables("Ticket")
                DataGridView1.Columns("idTicket").HeaderText = "ID"
                DataGridView1.Columns("nombre").HeaderText = "Nombre del CLiente"
                DataGridView1.Columns("estado").HeaderText = "Estado"
                DataGridView1.Columns("equipo").HeaderText = "Equipo"
                DataGridView1.Columns("modelo").HeaderText = "Modelo"
                DataGridView1.Columns("responsable").HeaderText = "Empleado Encargado"
                DataGridView1.Columns("tipoArreglo").HeaderText = "Tipo de Reparación"
                DataGridView1.Columns("observacion").HeaderText = "Observación del Encargado"
                DataGridView1.Columns("montoArreglo").HeaderText = "Monto de reparación"
                DataGridView1.Columns("costosExtras").HeaderText = "Costos Extras"
                DataGridView1.Columns("fechaCreacion").HeaderText = "Fecha de Creación"
                DataGridView1.Columns("fechaCierre").HeaderText = "Fecha de Cierre"
                conexion.Close()
                Dim encontrado As Boolean = False
                '////////////////////////////////////////////////////////////////////////////////////////////
                If IsNumeric(TextBoxIdTicket.Text) Then
                    For Each row As DataGridViewRow In DataGridView1.Rows
                        If row.Cells("idTicket").Value IsNot Nothing AndAlso row.Cells("idTicket").Value = TextBoxIdTicket.Text Then
                            row.Selected = True
                            encontrado = True
                            'codigo para busqueda de datos en historia numeros
                            '--------------------------------------------
                            ButtonMostrarOcultar.Visible = True
                            BtnAcction.Visible = True
                            BtnAcction.Text = "Borrar"
                            ContBoton = False
                            Dim Img As Image = My.Resources.boton_abajo
                            ButtonMostrarOcultar.BackgroundImage = Img
                            TableLayoutPanel1.BackColor = Color.Transparent
                            '--------------------------------------------
                        Else
                        End If
                    Next
                    If Not encontrado Then
                        ButtonMostrarOcultar.Visible = False
                        BtnAcction.Visible = False
                    End If
                Else
                    '////////////////////////////////////////////////////////////////////////////////////////////
                    For Each row As DataGridViewRow In DataGridView1.Rows
                        If row.Cells("nombre").Value IsNot Nothing AndAlso row.Cells("nombre").Value.ToString().ToLower() = TextBoxIdTicket.Text Or row.Cells("nombre").Value.ToString() = TextBoxIdTicket.Text Then
                            row.Selected = True
                            'codigo para busqueda de datos en historia letras
                            '--------------------------------------------
                            encontrado = True
                            '--------------------------------------------
                            ButtonMostrarOcultar.Visible = True
                            BtnAcction.Visible = True
                            BtnAcction.Text = "Borrar"
                            ContBoton = False
                            Dim Img As Image = My.Resources.boton_abajo
                            ButtonMostrarOcultar.BackgroundImage = Img
                            TableLayoutPanel1.BackColor = Color.Transparent
                            '--------------------------------------------
                        Else
                        End If
                    Next
                    If Not encontrado Then
                        ButtonMostrarOcultar.Visible = False
                        BtnAcction.Visible = False
                    End If
                End If

            End If
            '/////////////////////////////////////////////////////////
            'codigo para buscar
            If ComboBoxOpciones.Text = "Buscar" Then
                'codigo para seleccion de datagridview
                conexion.Open()
                Dim stringquery As String
                If IsNumeric(TextBoxIdTicket.Text) Then
                    stringquery = "T.idTicket LIKE " & TextBoxIdTicket.Text
                ElseIf Char.IsLetter(TextBoxIdTicket.Text) Then
                    stringquery = "U.nombre LIKE '%" & TextBoxIdTicket.Text & "%'"
                Else
                    stringquery = "T.idTicket LIKE '%%'"
                End If
                Dim cmd As New SqlCommand("SELECT T.idTicket,
                                           U.nombre,
                                           T.estado,
                                           T.equipo,
                                           T.modelo,
										   T.tipodeDano,
										   T.descripcion,
										   T.prioridad,
                                           T.responsable,
                                           T.tipoArreglo,
                                           T.observacion,
										   T.monto,
										   T.montoArreglo,
                                           T.costosExtras,
                                           T.fechaCreacion,
										   T.fechaEstimacion,
                                           T.fechaCierre

                                           FROM Ticket T
                                           INNER JOIN TicketUser TU ON T.idTicket = TU.IdsTicket
                                           INNER JOIN Usuario U ON TU.IdsUser = U.idUser
                                           WHERE ISNUMERIC(U.idUser) = 0
                                                 AND PATINDEX('%[a-ñ-zA-Ñ-Z]%', U.idUser) > 0
                                                 AND   (" & stringquery & ");", conexion)
                Dim tabla As New SqlDataAdapter(cmd)
                Dim dss As New DataSet
                tabla.Fill(dss, "Ticket")
                DataGridView1.ClearSelection()
                DataGridView1.Columns.Clear()
                DataGridView1.DataSource = dss.Tables("Ticket")
                'descripcion del cliente
                DataGridView1.Columns("idTicket").HeaderText = "ID"
                DataGridView1.Columns("Nombre").HeaderText = "Nombre del CLiente"
                DataGridView1.Columns("estado").HeaderText = "Estado"
                DataGridView1.Columns("equipo").HeaderText = "Equipo"
                DataGridView1.Columns("modelo").HeaderText = "Modelo"
                DataGridView1.Columns("descripcion").HeaderText = "Descripción del Cliente"
                'responsable y ttipo de reparacion
                DataGridView1.Columns("prioridad").HeaderText = "Prioridad"
                DataGridView1.Columns("tipoArreglo").HeaderText = "Tipo de Reparación"
                'costos
                DataGridView1.Columns("monto").HeaderText = "Monto Estimado a Pagar"
                DataGridView1.Columns("costosExtras").HeaderText = "Costos Extras"
                DataGridView1.Columns("montoArreglo").HeaderText = "Monto de reparación"

                DataGridView1.Columns("responsable").HeaderText = "Empleado Encargado"
                DataGridView1.Columns("tipodeDano").HeaderText = "Tipo de Daño"
                DataGridView1.Columns("observacion").HeaderText = "Observación del Encargado"
                'fechas
                DataGridView1.Columns("fechaCreacion").HeaderText = "Fecha de Creación"
                DataGridView1.Columns("fechaEstimacion").HeaderText = "Fecha de Estimación"
                DataGridView1.Columns("fechaCierre").HeaderText = "Fecha de Cierre"
                conexion.Close()
                Dim encontrado As Boolean = False
                '////////////////////////////////////////////////////////////////////////////////////////////
                If IsNumeric(TextBoxIdTicket.Text) Then
                    For Each row As DataGridViewRow In DataGridView1.Rows
                        If row.Cells("idTicket").Value IsNot Nothing AndAlso row.Cells("idTicket").Value = TextBoxIdTicket.Text Then
                            row.Selected = True
                            encontrado = True
                            'codigo para busqueda de datos en historia numeros
                            '--------------------------------------------
                            ButtonMostrarOcultar.Visible = True
                            BtnAcction.Visible = True
                            BtnAcction.Text = "Borrar"
                            ContBoton = False
                            Dim Img As Image = My.Resources.boton_abajo
                            ButtonMostrarOcultar.BackgroundImage = Img
                            TableLayoutPanel1.BackColor = Color.Transparent
                            '--------------------------------------------
                        Else
                        End If
                    Next
                    If Not encontrado Then
                        ButtonMostrarOcultar.Visible = False
                        BtnAcction.Visible = False
                    End If
                Else
                    '////////////////////////////////////////////////////////////////////////////////////////////
                    For Each row As DataGridViewRow In DataGridView1.Rows
                        If row.Cells("nombre").Value IsNot Nothing AndAlso row.Cells("nombre").Value.ToString().ToLower() = TextBoxIdTicket.Text Or row.Cells("nombre").Value.ToString() = TextBoxIdTicket.Text Then
                            row.Selected = True
                            'codigo para busqueda de datos en historia letras
                            '--------------------------------------------
                            encontrado = True
                            '--------------------------------------------
                            ButtonMostrarOcultar.Visible = True
                            BtnAcction.Visible = True
                            BtnAcction.Text = "Borrar"
                            ContBoton = False
                            Dim Img As Image = My.Resources.boton_abajo
                            ButtonMostrarOcultar.BackgroundImage = Img
                            TableLayoutPanel1.BackColor = Color.Transparent
                            '--------------------------------------------
                        Else
                        End If
                    Next
                    If Not encontrado Then
                        ButtonMostrarOcultar.Visible = False
                        BtnAcction.Visible = False
                    End If
                End If

            End If
        End If
    End Sub
    'Cosas Extras
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim minTime As TimeSpan = New TimeSpan(9, 0, 0) ' Hora mínima: 9:00 AM
        Dim maxTime As TimeSpan = New TimeSpan(18, 0, 0) ' Hora máxima: 6:00 PM
        DateTimePicker1.MinDate = DateTime.Today
        Dim selectedTime As TimeSpan = DateTimePicker1.Value.TimeOfDay

        ' Comprobar si la hora seleccionada está fuera del rango permitido
        If selectedTime <minTime OrElse selectedTime > maxTime Then
            ' Establecer la hora seleccionada dentro del rango permitido
            Dim newTime As DateTime = DateTimePicker1.Value.Date.Add(minTime)

            ' Actualizar el valor del control DateTimePicker
            DateTimePicker1.Value = newTime
        End If
    End Sub

    Private Sub ComboBoxEquipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEquipo.SelectedIndexChanged
        If ComboBoxEquipo.SelectedItem() = "PC" Then
            Dim Img As Image = My.Resources.Pc
            PictureBox2.BackgroundImage = Img
        End If
        If ComboBoxEquipo.SelectedItem() = "Laptop" Then
            Dim Img As Image = My.Resources.laptop
            PictureBox2.BackgroundImage = Img
        End If
    End Sub

    Private Sub TextBoxObservacion_TextChanged(sender As Object, e As EventArgs) Handles TextBoxObservacion.TextChanged
        If TextBoxObservacion.Enabled Then
            LabelContMultiline.BackColor = Color.White ' Color de fondo cuando está habilitado
        Else
            LabelContMultiline.BackColor = Color.WhiteSmoke ' Color de fondo cuando está deshabilitado
        End If
        If TextBoxObservacion.TextLength > 500 Then
            Dim Borrar As String = TextBoxObservacion.Text.Remove(TextBoxObservacion.Text.Length - 1)
            TextBoxObservacion.Text = Borrar
            TextBoxObservacion.SelectionStart = TextBoxObservacion.Text.Length
            Dim valor As Integer = TextBoxObservacion.Text.Length
            LabelContMultiline.Text = valor.ToString() & "/500"
            Exit Sub
        End If
        Dim caracteres As Integer = TextBoxObservacion.TextLength
        LabelContMultiline.Text = caracteres.ToString() & "/500"
    End Sub

    Private Sub ComboBoxEmpleados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEmpleados.SelectedIndexChanged
        If ComboBoxEmpleados.SelectedItem <> "" Then
            LabelTextTarea.Visible = True
            LabelTareas.Visible = True
            NumeroTareasEmpleado()
        Else
            LabelTextTarea.Visible = False
            LabelTareas.Visible = False
        End If
    End Sub





    Public Sub BuscarDatosTodo()
        conexion.Open()
        Dim procAgendar As New SqlCommand()
        procAgendar.Connection = conexion
        procAgendar.CommandType = CommandType.StoredProcedure
        procAgendar.CommandText = "BuscarDatosTodo"
        procAgendar.Parameters.AddWithValue("@idTicket ", TextBoxIdTicket.Text)
        'Ejecutar procedimiento
        Dim reader As SqlDataReader = procAgendar.ExecuteReader()
        If reader.Read() Then
            'datos de cliente
            LabeIDusers.Text = reader("idUser").ToString()
            LabelName.Text = reader("nombre").ToString()
            LabelCedula.Text = reader("cedula").ToString()
            LabelCorreo.Text = reader("correoUser").ToString()
            'datos de equipo
            'equipo
            ComboBoxEquipo.Items.Clear()
            ComboBoxEquipo.Items.Add(reader("equipo").ToString())
            ComboBoxEquipo.SelectedItem = reader("equipo").ToString()
            'modelo
            ComboBoxModelo.Items.Clear()
            ComboBoxModelo.Items.Add(reader("modelo").ToString())
            ComboBoxModelo.SelectedItem = reader("modelo").ToString()
            'tipo de daño
            ComboBoxTipoDano.Items.Clear()
            ComboBoxTipoDano.Items.Add(reader("tipodeDano").ToString())
            ComboBoxTipoDano.SelectedItem = reader("tipodeDano").ToString()
            'descripcion
            TextBoxDescripcionCliente.Text = reader("descripcion").ToString()
            LabelPrioridad.Text = "Alta"
            ComboBoxEstado.SelectedItem = "Pendiente"
            TextBoxObservacion.Text = "--Reporte de Trasabilidad--" & vbNewLine &
                                      "No. de Tikect: " & TextBoxIdTicket.Text & vbNewLine &
                                      "Nombre de Cliente: " & reader("nombre").ToString() & vbNewLine &
                                      "Equipo enviado a Revisión: " & reader("equipo").ToString() & "-Modelo-" & reader("modelo").ToString() & vbNewLine &
                                      "Recibido por Empleado(a) de Caja: " & reader("observacion").ToString() & vbNewLine & 'falta mandar el nombre del empleado de caja
                                      "Fecha de Inicio: " & reader("fechaCreacion").ToString() & vbNewLine &
                                      "Fecha de Estimación de Reparación: " & reader("fechaEstimacion").ToString() & vbNewLine &
                                      "-----Costos Adicionales-----" & vbNewLine
            Dim fechaInicio As DateTime = reader("fechaCreacion").ToString()
            Dim fechaEstimacion As DateTime = reader("fechaEstimacion").ToString()
            Dim fechaFormateada As String = fechaInicio.ToString("yyyy/MM/dd")
            Dim fechaFormateada2 As String = fechaEstimacion.ToString("yyyy/MM/dd")
            LabelFechaInicio.Text = fechaFormateada
            LabelFechaEstimacion.Text = fechaFormateada2
            'cantidad de letras de multiline
            Dim caracteres As Integer = TextBoxObservacion.TextLength
            LabelContMultiline.Text = caracteres.ToString() & "/500"
        End If
        conexion.Close()
    End Sub

End Class