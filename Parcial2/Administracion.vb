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
    'tiketks Pendientes
    Public Sub MosstrartiketsPendientes()
        conex.Open()

        Dim consulta As String = "Select idTicket,equipo,modelo,tipodeDano,prioridad,descripcion,fechaCreacion,fechaEstimacion from Ticket where estado='Pendiente'"
        Dim ejecutar As New SqlCommand(consulta, conex)
        Dim tabla As New SqlDataAdapter(ejecutar)
        Dim dss As New DataSet
        tabla.Fill(dss, "Ticket")
        DataGridView1.DataSource = dss.Tables("Ticket")
        DataGridView1.Columns("idTicket").HeaderText = "ID"
        DataGridView1.Columns("equipo").HeaderText = "Equipo"
        DataGridView1.Columns("modelo").HeaderText = "Modelo"
        DataGridView1.Columns("tipodeDano").HeaderText = "Tipo de Daño"
        DataGridView1.Columns("prioridad").HeaderText = "Prioridad"
        DataGridView1.Columns("descripcion").HeaderText = "Descripcion del Cliente"
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
        DataGridView1.DataSource = dss.Tables("Ticket")
        DataGridView1.Columns("idTicket").HeaderText = "ID"
        DataGridView1.Columns("equipo").HeaderText = "Equipo"
        DataGridView1.Columns("modelo").HeaderText = "Modelo"
        DataGridView1.Columns("tipodeDano").HeaderText = "Tipo de Daño"
        DataGridView1.Columns("prioridad").HeaderText = "Prioridad"
        DataGridView1.Columns("descripcion").HeaderText = "Descripcion del Cliente"
        DataGridView1.Columns("fechaCreacion").HeaderText = "Fecha de Creación"
        DataGridView1.Columns("responsable").HeaderText = "Responsable"
        DataGridView1.Columns("estado").HeaderText = "Estado"
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
        DataGridView1.Columns("equipo").HeaderText = "Equipo"
        DataGridView1.Columns("modelo").HeaderText = "Modelo"
        DataGridView1.Columns("tipodeDano").HeaderText = "Tipo de Daño"
        DataGridView1.Columns("prioridad").HeaderText = "Prioridad"
        DataGridView1.Columns("descripcion").HeaderText = "Descripcion del Cliente"
        DataGridView1.Columns("fechaCreacion").HeaderText = "Fecha de Creación"
        DataGridView1.Columns("responsable").HeaderText = "Responsable"
        DataGridView1.Columns("estado").HeaderText = "Estado"
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
        ComboBoxOpciones.Items.Add("-Selecionar-")
        ComboBoxOpciones.Items.Add("Agendar")
        ComboBoxOpciones.Items.Add("Buscar")
        ComboBoxOpciones.Items.Add("Historial de Pagos")
        ComboBoxOpciones.SelectedIndex = 0
        'ComboBoxOpciones.Items.Clear()
        'cosasNovisible
        LabelComplete.Visible = False
        RadioButtonPrioridadAlta.Select()
    End Sub

    Private Sub ComboBoxOpciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOpciones.SelectedIndexChanged
        If ComboBoxOpciones.Text = "Agendar" Or ComboBoxOpciones.Text = "Buscar" Then
            MostrarEmpleadosDisponible()
        End If
    End Sub
    'btn de acciones
    Private Sub BtnAcction_Click(sender As Object, e As EventArgs) Handles BtnAcction.Click
        If ComboBoxOpciones.Text = "Agendar" And ComboBoxEmpleados.Text <> "" And TextBoxIdTicket.Text <> "" Then
            AgendarEmpleado()
        End If
        If ComboBoxOpciones.Text = "Buscar" And RadioButtonPrioridadAlta.Checked = True And TextBoxIdTicket.Text <> "" Then
            Dim resultado As MsgBoxResult
            resultado = CType(MessageBox.Show("¿Desea Exportar una Factura para guradar el reporte?", "Se Cancelara el Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
            If resultado = MsgBoxResult.No Then
                CancelarPago()
            Else
                CancelarPago()
            End If
        End If
    End Sub
    Private Sub RadioButtonPrioridadAlta_Click(sender As Object, e As EventArgs) Handles RadioButtonPrioridadAlta.Click
        MosstrartiketsPendientes()
    End Sub

    Private Sub RadioButtonPrioridadMedia_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPrioridadMedia.CheckedChanged
        MosstrartiketsRevision()
    End Sub

    Private Sub RadioButtonPrioridadBaja_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPrioridadBaja.CheckedChanged
        MosstrartiketsFinalizados()
    End Sub

    Public Sub ModoPago()

    End Sub
    Public Sub CancelarPago()
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
    Public Sub ImprimirFactura()
        Factura.Show()
        conex.Open()
        Dim cmd As New SqlCommand("Select * from Ticket where idTicket='" & TextBoxIdTicket.Text & "'", conex)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            Factura.Label1.Text = reader("idTicket").ToString()
            Factura.Label1.Text = reader("equipo").ToString()
            Factura.Label1.Text = reader("modelo").ToString()
            Factura.Label1.Text = reader("tipodeDano").ToString()
            Factura.Label1.Text = reader("prioridad").ToString()

            Factura.Label1.Text = reader("descripcion").ToString()
            Factura.Label1.Text = reader("fechaCreacion").ToString()
            Factura.Label1.Text = reader("fechaEstimacion").ToString()
            Factura.Label1.Text = reader("fechaCierre").ToString()

            Factura.Label1.Text = reader("observacion").ToString()
            Factura.Label1.Text = reader("responsable").ToString()
            Factura.Label1.Text = reader("estado").ToString()
            Factura.Label1.Text = reader("tipoArreglo").ToString()
            Factura.Label1.Text = reader("montoArreglo").ToString()
            Factura.Label1.Text = reader("costosExtras").ToString()

            Factura.Label1.Text = reader("monto").ToString()
        End If
        conex.Close()
    End Sub
End Class