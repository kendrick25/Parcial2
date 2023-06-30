Imports System.Data.SqlClient
Public Class Administracion
    'conexion  kembrish
    Public conex As New SqlConnection("Data Source=DESKTOP-GQPJ6BS;Initial Catalog=JKEnterprise;Integrated Security=True")
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
        Dim dataTable As New DataTable()

        conex.Open()

            ' Crear el comando y asignar el nombre del procedimiento almacenado
            Dim command As New SqlCommand("ObtenerTodosLosTickets", conex)
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
        conex.Close()
    End Sub
    'ver tikets Pagados
    Public Sub MostrarPagados()
        Dim dataTable As New DataTable()

        conex.Open()

        ' Crear el comando y asignar el nombre del procedimiento almacenado
        Dim command As New SqlCommand("VerHistorialPago", conex)
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
        conex.Close()
    End Sub


    'tiketks Pendientes
    Public Sub MosstrartiketsPendientes()
        conex.Open()

        Dim consulta As String = "Select idTicket,equipo,modelo,tipodeDano,prioridad,descripcion,fechaCreacion,fechaEstimacion,estado from Ticket where estado='Pendiente'"
        Dim ejecutar As New SqlCommand(consulta, conex)
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
        conex.Close()
    End Sub
    'tikets En revision
    Public Sub MosstrartiketsRevision()
        conex.Open()
        Dim consulta As String = "Select idTicket,equipo,modelo,tipodeDano,prioridad,descripcion,fechaCreacion,fechaEstimacion,responsable,estado from Ticket where estado='En Revisión'"
        Dim ejecutar As New SqlCommand(consulta, conex)
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
        conex.Close()
    End Sub
    'tikets En revision
    Public Sub MosstrartiketsFinalizados()
        conex.Open()
        Dim consulta As String = "Select idTicket,equipo,modelo,tipodeDano,prioridad,descripcion,fechaCreacion,fechaCierre,observacion,responsable,monto,estado,tipoArreglo,montoArreglo,costosExtras from Ticket where estado='Finalizado'"
        Dim ejecutar As New SqlCommand(consulta, conex)
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
        conex.Close()
    End Sub
    'Mostrar tikets Pagados
    Public Sub HistorialPagos()
        Dim dataTable As New DataTable()
        conex.Open()
        ' Crear el comando y asignar el nombre del procedimiento almacenado
        Dim command As New SqlCommand("HistorialPagos", conex)
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
        DataGridView1.Columns("responsable").HeaderText = "Empleado Encargado"
        DataGridView1.Columns("tipoArreglo").HeaderText = "Tipo de Reparación"
        DataGridView1.Columns("observacion").HeaderText = "Observación del Encargado"
        DataGridView1.Columns("montoArreglo").HeaderText = "Monto de reparación"
        DataGridView1.Columns("costosExtras").HeaderText = "Costos Extras"
        DataGridView1.Columns("fechaCreacion").HeaderText = "Fecha de Creación"
        DataGridView1.Columns("fechaCierre").HeaderText = "Fecha de Cierre"
        conex.Close()
    End Sub
    Public Sub AgendarEmpleado()
        conex.Open()
        Dim procAgendar As New SqlCommand()
        procAgendar.Connection = conex
        procAgendar.CommandType = CommandType.StoredProcedure
        procAgendar.CommandText = "AgendarEmpleado"
        procAgendar.Parameters.AddWithValue("@idTicket ", TextBoxIdTicket.Text)
        procAgendar.Parameters.AddWithValue("@responsable", ComboBoxEmpleados.Text)
        procAgendar.Parameters.AddWithValue("@prioridad", "Media")
        procAgendar.Parameters.AddWithValue("@estado", "En Revisión")
        'Ejecutar procedimiento
        procAgendar.ExecuteNonQuery()
        conex.Close()
        LabelComplete.Visible = Visible
        LabelComplete.Text = "Cliente Agendado"
    End Sub

    Public Sub ModoAgendar()

    End Sub
    Public Sub MostrarEmpleadosDisponible()
        ComboBoxEmpleados.Items.Clear()
        conex.Open()
        Dim mostrarLibrosDisponibles As String = "select nombre from Usuario i, UserRol u where i.idUser = u.idURer and u.rolUser = 'empleado' and u.estado = 'Disponible'"
        Dim llenar As New SqlCommand(mostrarLibrosDisponibles, conex)
        Dim reader As SqlDataReader = llenar.ExecuteReader()
        While reader.Read()
            ComboBoxEmpleados.Items.Add(reader("nombre").ToString())
        End While
        reader.Close()
        conex.Close()
    End Sub
    Public Sub DatosCliente()

    End Sub
    Private Sub Administracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VerTodo()
        'opciones
        ComboBoxOpciones.Items.Add("--Selecionar--")
        ComboBoxOpciones.Items.Add("Agendar")
        ComboBoxOpciones.Items.Add("Buscar")
        ComboBoxOpciones.Items.Add("Historial de Pagos")
        ComboBoxOpciones.SelectedIndex = 0
        'ComboBoxOpciones.Items.Clear()
        ComboBoxMostrar.Items.Add("--Selecionar--")
        ComboBoxMostrar.Items.Add("Prioridad Alta")
        ComboBoxMostrar.Items.Add("Prioridad Media")
        ComboBoxMostrar.Items.Add("Prioridad Baja")
        ComboBoxMostrar.Items.Add("N/D")
        ComboBoxMostrar.Items.Add("Todo")
        ComboBoxMostrar.SelectedIndex = 0
        'cosasNovisible
        LabelComplete.Visible = False
    End Sub

    Private Sub ComboBoxOpciones_Click(sender As Object, e As EventArgs) Handles ComboBoxOpciones.Click
        If ComboBoxOpciones.SelectedItem.ToString() = "--Selecionar--" Then

        End If
        If ComboBoxOpciones.Text = "Agendar" Then
            MostrarEmpleadosDisponible()
        End If
        If ComboBoxOpciones.Text = "Buscar" Then
            MostrarEmpleadosDisponible()
        End If
        If ComboBoxOpciones.Text = "Historial de Pagos" Then
            HistorialPagos()
        End If
    End Sub
    'btn de acciones
    Private Sub BtnAcction_Click(sender As Object, e As EventArgs) Handles BtnAcction.Click
        If ComboBoxOpciones.Text = "Agendar" And ComboBoxEmpleados.Text <> "" And TextBoxIdTicket.Text <> "" Then
            AgendarEmpleado()
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
        If ComboBoxMostrar.Text = "Todo" Then
            VerTodo()
        End If
        If ComboBoxMostrar.Text = "N/D" Then
            MostrarPagados()
        End If
    End Sub

    Public Sub ModoPago()

    End Sub
    Public Sub CancelarPago()
        conex.Open()
        Dim procAgendar As New SqlCommand()
        procAgendar.Connection = conex
        procAgendar.CommandType = CommandType.StoredProcedure
        procAgendar.CommandText = "CancelarPago"
        procAgendar.Parameters.AddWithValue("@idTicket ", TextBoxIdTicket.Text)
        procAgendar.Parameters.AddWithValue("@prioridad", "N/D")
        procAgendar.Parameters.AddWithValue("@estado", "Pagado")
        'Ejecutar procedimiento
        procAgendar.ExecuteNonQuery()
        conex.Close()
        LabelComplete.Visible = Visible
        LabelComplete.Text = "--Monto de Cliente Cancelado--"
    End Sub
    Public Sub ImprimirFactura()
        conex.Open()
        Dim procAgendar As New SqlCommand()
        procAgendar.Connection = conex
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
            mensaje.LabelTelefono.Text = reader("correoUser").ToString()
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
        conex.Close()
    End Sub

    Private Sub BtnGenerarFactura_Click(sender As Object, e As EventArgs) Handles BtnGenerarFactura.Click
        If TextBoxIdTicket.Text <> "" Then
            ImprimirFactura()
        End If
    End Sub

End Class