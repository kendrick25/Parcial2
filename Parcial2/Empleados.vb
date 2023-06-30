Imports System.Data.SqlClient
Public Class Empleados

    Public conex As New SqlConnection("Data Source=DESKTOP-8ELH4DT;Initial Catalog=JKEnterprise;Integrated Security=True")
    Private Sub btRevisionEmpleado_Click(sender As Object, e As EventArgs) Handles btRevisionEmpleado.Click


        'Condicionales que muestran los asteriscos para indicar que faltan campos por llenar
        If cbTipoArreglo.Text = Nothing Then
            Label23.Visible = True
        Else
            Label23.Visible = False
            If tbMontoArreglo.Text = Nothing Then
                Label24.Visible = True
            Else
                Label24.Visible = False

                If tbObsEmpl.Text = Nothing Then
                    MessageBox.Show("OBSERVACION DE EMPLEADO", "REDACTA", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    If tbCostosExtras.Text = Nothing Then
                        Label20.Visible = True
                        Dim answer As Integer
                        answer = MsgBox("ESTAS A PUNTO DE NO AGREGAR PRECIO EXTRA. CONTINUAR?", vbQuestion + vbYesNo + vbDefaultButton2, "CUIDADO")

                        If answer = vbYes Then
                            conex.Open()

                            'Agrega el update al ticket

                            Dim ActualizacionEmpl As New SqlCommand()
                            'Procedimiento almacenado para eliminar el libro seleccionado del combo
                            ActualizacionEmpl.Connection = conex

                            ActualizacionEmpl.CommandType = CommandType.StoredProcedure

                            ActualizacionEmpl.CommandText = "ActualizacionEmpleado"

                            ActualizacionEmpl.Parameters.AddWithValue("@idTicketRev", Val(tbIdForTarea.Text))
                            ActualizacionEmpl.Parameters.AddWithValue("@ObservEmpl", tbObsEmpl.Text)
                            ActualizacionEmpl.Parameters.AddWithValue("@TTipoArreglo", cbTipoArreglo.SelectedItem)
                            ActualizacionEmpl.Parameters.AddWithValue("@montoArreglo", Val(tbMontoArreglo.Text))
                            ActualizacionEmpl.Parameters.AddWithValue("@costosExt", Val(tbCostosExtras.Text))

                            'Ejecutar procedimiento

                            Dim answer3 As Integer

                            answer3 = MsgBox("¿DESEAS REALIZAR UPDATE DEL CASO? ", vbYesNo)
                            If answer3 = vbYes Then
                                ActualizacionEmpl.ExecuteNonQuery()
                            Else
                                'Devuelve a la pantalla
                            End If

                        End If
                        conex.Close()

                    Else
                        Label20.Visible = False

                        conex.Open()

                        'Agrega el update al ticket

                        Dim ActualizacionEmpl As New SqlCommand()
                        'Procedimiento almacenado para eliminar el libro seleccionado del combo
                        ActualizacionEmpl.Connection = conex

                        ActualizacionEmpl.CommandType = CommandType.StoredProcedure

                        ActualizacionEmpl.CommandText = "ActualizacionEmpleado"

                        ActualizacionEmpl.Parameters.AddWithValue("@idTicketRev", Val(tbIdForTarea.Text))
                        ActualizacionEmpl.Parameters.AddWithValue("@ObservEmpl", tbObsEmpl.Text)
                        ActualizacionEmpl.Parameters.AddWithValue("@TTipoArreglo", cbTipoArreglo.SelectedItem)
                        ActualizacionEmpl.Parameters.AddWithValue("@montoArreglo", Val(tbMontoArreglo.Text))
                        ActualizacionEmpl.Parameters.AddWithValue("@costosExt", Val(tbCostosExtras.Text))
                        ActualizacionEmpl.Parameters.AddWithValue("@estado", "finalizado")


                        'Ejecutar procedimiento

                        Dim answer3 As Integer

                        answer3 = MsgBox("¿DESEAS REALIZAR UPDATE DEL CASO? ", vbYesNo)
                        If answer3 = vbYes Then
                            ActualizacionEmpl.ExecuteNonQuery()
                        Else
                            'Devuelve a la pantalla
                        End If

                        conex.Close()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btAccesoTarea_Click(sender As Object, e As EventArgs) Handles btAccesoTarea.Click
        'Seccion que realiza o no una tarea asignada por el admin
        If tbIdForTarea.Text = Nothing Then
            MessageBox.Show("ESCRIBE UNA ID QUE SE ENCUENTRE EN LA TABLA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            Dim modelo As String = ""
            Dim equipo As String = ""
            Dim componente As String = ""
            Dim descrip As String = ""


            'Verificar si lo que se escribe en la cajita de texto existe en la data base

            conex.Open()

            Dim VerificaTarea As String = "SELECT COUNT(*) FROM Ticket WHERE idTicket = @ID"

            Dim Command As New SqlCommand(VerificaTarea, conex)

            Command.Parameters.AddWithValue("@ID", Val(tbIdForTarea.Text))

            Dim count As Integer = CInt(command.ExecuteScalar())

            If count > 0 Then

                Dim idCapturada As Integer = Val(tbIdForTarea.Text)

                btAccesoTarea.Enabled = False
                btCancelTarea.Enabled = True
                tbIdForTarea.Enabled = False

                'Capturar el equipo que corresponde con la ID
                Dim consultaEquipo As String = "select equipo From Ticket where idTicket = @CapturadaID"
                Dim comando1 As New SqlCommand(consultaEquipo, conex)
                comando1.Parameters.AddWithValue("@CapturadaID", idCapturada)

                'Capturar el modelo que corresponda con la ID
                Dim consultaModelo As String = "select modelo From Ticket where idTicket = @CapturadaID"
                Dim comando2 As New SqlCommand(consultaModelo, conex)
                comando2.Parameters.AddWithValue("@CapturadaID", idCapturada)

                'Capturar el componente que corresponda con la ID
                Dim consultaComponente As String = "select tipodeDano From Ticket where idTicket = @CapturadaID"
                Dim comando3 As New SqlCommand(consultaComponente, conex)
                comando3.Parameters.AddWithValue("@CapturadaID", idCapturada)

                'Capturar la descripcion del ticket con esa ID
                Dim consultaDescrip As String = "select descripcion From Ticket where idTicket = @CapturadaID"
                Dim comando4 As New SqlCommand(consultaDescrip, conex)
                comando4.Parameters.AddWithValue("@CapturadaID", idCapturada)
                'Obtener finalmente la id del usuario que inicio sesión. Corta la bocha.

                Dim dimeEquipo As Object = comando1.ExecuteScalar()
                Dim dimeModelo As Object = comando2.ExecuteScalar()
                Dim dimeComponente As Object = comando3.ExecuteScalar()
                Dim dimeDescrip As Object = comando4.ExecuteScalar()

                If dimeEquipo IsNot Nothing AndAlso Not DBNull.Value.Equals(dimeEquipo) Then
                    equipo = Convert.ToString(dimeEquipo)
                End If
                If dimeModelo IsNot Nothing AndAlso Not DBNull.Value.Equals(dimeModelo) Then
                    modelo = Convert.ToString(dimeModelo)
                End If
                If dimeComponente IsNot Nothing AndAlso Not DBNull.Value.Equals(dimeComponente) Then
                    componente = Convert.ToString(dimeComponente)
                End If
                If dimeDescrip IsNot Nothing AndAlso Not DBNull.Value.Equals(dimeDescrip) Then
                    descrip = Convert.ToString(dimeDescrip)
                End If
                tbEquipo.Text = equipo
                tbModelo.Text = modelo
                tbTipoDano.Text = componente
                tbDescripcionUser.Text = descrip

                btRevisionEmpleado.Enabled = True

                'MsgBox("La ID existe en la tabla")
            Else
                'Si no existe la id que se introdujo, manda mensaje de error. 

                MessageBox.Show("SELECCIONA UNA ID QUE SE ENCUENTRE EN LA TABLA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbIdForTarea.Text = Nothing
            End If

        End If
        conex.Close()
    End Sub

    Private Sub btCancelTarea_Click(sender As Object, e As EventArgs) Handles btCancelTarea.Click
        'Boton para regresar la accion y dejar de seguir con el trato del ticket
        tbIdForTarea.Enabled = True
        btAccesoTarea.Enabled = True
        btCancelTarea.Enabled = False
        tbEquipo.Text = Nothing
        tbModelo.Text = Nothing
        tbTipoDano.Text = Nothing
        tbDescripcionUser.Text = Nothing
        btRevisionEmpleado.Enabled = False
    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cuando se abre el form, oculta componentes que no deben ser visibles o activos
        btCancelTarea.Enabled = False
        Label23.Visible = False
        btRevisionEmpleado.Enabled = False
        Label24.Visible = False
        Label20.Visible = False
        vistaEmpleadoTable()

    End Sub

    Public Sub vistaEmpleadoTable()

        Dim consultaEmpleado As String = "SELECT idTicket, equipo, modelo, tipodeDano FROM Ticket where responsable = @nomEmple;"


        Dim ejecutar As New SqlCommand(consultaEmpleado, conex)

        ejecutar.Parameters.AddWithValue("@nomEmple", "Tyler Blue")

        Try
            Dim tabla As New SqlDataAdapter(ejecutar)
            Dim dss As New DataSet
            tabla.Fill(dss, "Ticket")

            Me.DGtareasEmp.DataSource = dss.Tables("Ticket")
            DGtareasEmp.Columns("idTicket").HeaderText = "ID"
            DGtareasEmp.Columns("equipo").HeaderText = "EQUIPO"
            DGtareasEmp.Columns("modelo").HeaderText = "MODELO"
            DGtareasEmp.Columns("tipodeDano").HeaderText = "DAÑO"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            conex.Close()
        End Try
    End Sub

    Private Sub tbObsEmpl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbObsEmpl.KeyPress
        Dim allowedChars As String = "áéíóúabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ., " ' Agrega los caracteres permitidos aquí
        If Not allowedChars.Contains(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

        Dim maxLength As Integer = 255

        ' Verificar si se ha alcanzado el límite de caracteres permitidos
        If tbObsEmpl.TextLength >= maxLength AndAlso e.KeyChar <> ControlChars.Back Then
            ' Si se ha alcanzado el límite y no es una tecla de retroceso, cancelar el evento KeyPress
            e.Handled = True
        End If

    End Sub

    Private Sub tbCostosExtras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCostosExtras.KeyPress
        Dim allowedChars As String = "1234567890." ' Agrega los caracteres permitidos aquí
        If Not allowedChars.Contains(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

        Dim maxLength As Integer = 6

        ' Verificar si se ha alcanzado el límite de caracteres permitidos
        If tbCostosExtras.TextLength >= maxLength AndAlso e.KeyChar <> ControlChars.Back Then
            ' Si se ha alcanzado el límite y no es una tecla de retroceso, cancelar el evento KeyPress
            e.Handled = True
        End If

    End Sub


End Class