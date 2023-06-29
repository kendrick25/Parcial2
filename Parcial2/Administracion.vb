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

    Public Sub Mosstrartikets()
        conex.Open()
        Dim consulta As String = "select idTicket,equipo,modelo,tipodeDano,prioridad,descripcion,fechaCreacion,fechaEstimacion,fechaCierre,observacion,responsable,monto,estado,tipoArreglo,montoArreglo,costosExtras from Ticket"
        Dim ejecutar As New SqlCommand(consulta, conex)
        Try
            Dim tabla As New SqlDataAdapter(ejecutar)
            Dim dss As New DataSet
            tabla.Fill(dss, "Ticket")

            DataGridView1.DataSource = dss.Tables("Cliente")
            DataGridView1.Columns("idTicket").HeaderText = "ID"
            DataGridView1.Columns("equipo").HeaderText = "Equipo"
            DataGridView1.Columns("modelo").HeaderText = "Modelo"
            DataGridView1.Columns("tipodeDano").HeaderText = "Tipo de Daño"
            DataGridView1.Columns("prioridad").HeaderText = "Prioridad"
            DataGridView1.Columns("descripcion").HeaderText = "Descripcion del Cliente"
            DataGridView1.Columns("fechaCreacion").HeaderText = "Fecha de Creación"
            DataGridView1.Columns("fechaEstimacion").HeaderText = "Fecha de Estimacion"
            DataGridView1.Columns("fechaCierre").HeaderText = "Fecha de Estimaciónn"
            DataGridView1.Columns("observacion").HeaderText = "Observación"

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            conex.Close()
        End Try
    End Sub
    Private Sub Administracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mosstrartikets()
    End Sub
End Class