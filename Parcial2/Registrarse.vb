Imports System.Data.SqlClient
Public Class Registrarse
    'Conexion de Kembrish
    Public conex As New SqlConnection("Data Source=DESKTOP-GQPJ6BS;Initial Catalog=JKEnterprise;Integrated Security=True")
    'Conexion de Dilan
    'Public conex As New SqlConnection("Data Source=DESKTOP-8ELH4DT;Initial Catalog=JKEnterprise;Integrated Security=True")


    'Botón para cancelar el progreso de ticket. Cierra el form de los datos del usuario
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bnCancelRegistro.Click
        If tbNewUser.Text <> "" Or tbCedula.Text <> "" Or tbTelefono.Text <> "" Or tbNewUserName.Text <> "" Then
            Dim resultado As MsgBoxResult
            resultado = CType(MessageBox.Show("Hay campos llenos, ¿Desea finalizar el Registro.?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
            If resultado = MsgBoxResult.No Then
            Else
                'borrar Pagina actual
                Dim tab As TabPage = MenuPrincipal.ContForms.SelectedTab
                MenuPrincipal.ContForms.TabPages.Remove(tab)
                Me.Close()
            End If
        Else
            Dim tab As TabPage = MenuPrincipal.ContForms.SelectedTab
            MenuPrincipal.ContForms.TabPages.Remove(tab)
            Me.Close()
        End If
    End Sub


    'Load del form de datos del cliente
    Private Sub Registrarse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbIdAsignada.Text = Funciones.GenerarID()
        faltante1.Visible = False
        faltante2.Visible = False
        faltante3.Visible = False
        faltante4.Visible = False
        faltante5.Visible = False
        faltante6.Visible = False
        carga.Visible = False
        carga.Minimum = 0
        carga.Maximum = 100
        btAgregarNew.Enabled = False
    End Sub



    Private Sub tbNewUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNewUser.KeyPress
        Dim allowedChars As String = "áéíóúabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ " ' Agrega los caracteres permitidos aquí
        If Not allowedChars.Contains(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

        Dim maxLength As Integer = 40

        ' Verificar si se ha alcanzado el límite de caracteres permitidos
        If tbNewUser.TextLength >= maxLength AndAlso e.KeyChar <> ControlChars.Back Then
            ' Si se ha alcanzado el límite y no es una tecla de retroceso, cancelar el evento KeyPress
            e.Handled = True
        End If
    End Sub

    Private Sub tbCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCedula.KeyPress
        Dim allowedChars As String = "-ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890" ' Agrega los caracteres permitidos aquí
        If Not allowedChars.Contains(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

        Dim maxLength As Integer = 15

        ' Verificar si se ha alcanzado el límite de caracteres permitidos
        If tbCedula.TextLength >= maxLength AndAlso e.KeyChar <> ControlChars.Back Then
            ' Si se ha alcanzado el límite y no es una tecla de retroceso, cancelar el evento KeyPress
            e.Handled = True
        End If

    End Sub

    Private Sub tbTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTelefono.KeyPress
        Dim allowedChars As String = "-1234567890" ' Agrega los caracteres permitidos aquí
        If Not allowedChars.Contains(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

        Dim maxLength As Integer = 10

        ' Verificar si se ha alcanzado el límite de caracteres permitidos
        If tbTelefono.TextLength >= maxLength AndAlso e.KeyChar <> ControlChars.Back Then
            ' Si se ha alcanzado el límite y no es una tecla de retroceso, cancelar el evento KeyPress
            e.Handled = True
        End If

    End Sub

    Private Sub tbNewUserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNewUserName.KeyPress
        Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890" ' Agrega los caracteres permitidos aquí
        If Not allowedChars.Contains(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

        Dim maxLength As Integer = 15

        ' Verificar si se ha alcanzado el límite de caracteres permitidos
        If tbNewUserName.TextLength >= maxLength AndAlso e.KeyChar <> ControlChars.Back Then
            ' Si se ha alcanzado el límite y no es una tecla de retroceso, cancelar el evento KeyPress
            e.Handled = True
        End If

    End Sub

    Private Sub tbMail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbMail.KeyPress
        Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890@.-_" ' Agrega los caracteres permitidos aquí
        If Not allowedChars.Contains(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

        Dim maxLength As Integer = 40

        ' Verificar si se ha alcanzado el límite de caracteres permitidos
        If tbMail.TextLength >= maxLength AndAlso e.KeyChar <> ControlChars.Back Then
            ' Si se ha alcanzado el límite y no es una tecla de retroceso, cancelar el evento KeyPress
            e.Handled = True
        End If

    End Sub


    'Permite ver la contraseña con el botón del ojito
    Private Sub mostrarVer_Click(sender As Object, e As EventArgs) Handles btMostrarVer.Click

        If tbPass.PasswordChar = "*" Then
            tbPass.PasswordChar = ControlChars.NullChar

        Else
            tbPass.PasswordChar = "*"
        End If

    End Sub


    'Botón que dice "next" cuando se agregan los datos del usuario
    Private Sub btAgregarNew_Click(sender As Object, e As EventArgs) Handles btAgregarNew.Click
        bnCancelRegistro.Enabled = False
        MenuPrincipal.OpenProblema2()
        btAgregarNew.Enabled = False
    End Sub


    'Timer cuando se hace el check de los datos del cliente y se carga la barra
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        carga.Value = carga.Value + 10
        If carga.Value >= 100 Then
            Timer1.Enabled = False
            'MsgBox("Nombre de usuario: " & tbNewUserName.Text & vbNewLine & "Password: " & tbPass.Text _
            '& vbNewLine & "¡ANÓTALOS!", , "REALIZADO")
            carga.Visible = False
            PictureBox1.Enabled = False
        End If
    End Sub


    'Check para procesar los datos del cliente actual y habilitar el botón next.
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        'Se almacenan en las variables globales la id random asignada y tambien el nombre por si se cancela el 
        'proceso del ticket

        Funciones.idAsig = lbIdAsignada.Text
        Funciones.nombreToCancel = tbNewUser.Text

        'No se requiere indicar contraseña ni username del cliente, por lo tanto solo se validan ciertos campos.
        'Cuando se estén agregando los campos de ticket, se establecen los username y pass del cliente automaticamente
        'aunque no se vayan a utilizar.

        If tbNewUser.Text = Nothing Then
            faltante1.Visible = True

        Else
            faltante1.Visible = False
            If tbCedula.Text = Nothing Then
                faltante2.Visible = True
            Else
                faltante2.Visible = False
                If tbTelefono.Text = Nothing Then
                    faltante3.Visible = True
                Else
                    faltante3.Visible = False

                    If tbMail.Text = Nothing Then
                        faltante6.Visible = True
                    Else
                        faltante6.Visible = False

                        Timer1.Enabled = True
                        carga.Visible = True
                        btAgregarNew.Enabled = True
                        bnCancelRegistro.Enabled = False
                        AgregarDatosUsuario()

                        'Cuando se acepta, se llama a la funcion agregar datos usuario que guarda temporamente
                        'los datos del cliente almenos que se cancele el ticket con el botón "cancelar proceso"

                    End If

                End If
            End If
        End If

    End Sub


    'Procedimiento que almacena los datos del usuario temporalmente o definitivamente si se envia el ticket
    Public Sub AgregarDatosUsuario()

        conex.Open()

        Dim passUsu As String = ""
        Dim userName As String = ""

        'llamar al modulo funciones para establecer una pass random.

        passUsu = Funciones.GenerarPass()

        'Borra los espacios del nombre y apellido que suministro el cliente y lo establece como username

        userName = EliminarEspacios(tbNewUser.Text)


        Dim NewUsuario As New SqlCommand()

        NewUsuario.Connection = conex

        NewUsuario.CommandType = CommandType.StoredProcedure

        NewUsuario.CommandText = "NuevoUser"

        NewUsuario.Parameters.AddWithValue("idUsuario", lbIdAsignada.Text)
        NewUsuario.Parameters.AddWithValue("nombreUsu", tbNewUser.Text)
        NewUsuario.Parameters.AddWithValue("nombreLog", userName)
        NewUsuario.Parameters.AddWithValue("cedulaUsu", tbCedula.Text)
        NewUsuario.Parameters.AddWithValue("contactoUsu", tbTelefono.Text)
        NewUsuario.Parameters.AddWithValue("passUsu", passUsu)
        NewUsuario.Parameters.AddWithValue("correoUsu", tbMail.Text)
        NewUsuario.Parameters.AddWithValue("rolUsu", "user")
        NewUsuario.Parameters.AddWithValue("estado", "Nuevo")

        NewUsuario.ExecuteNonQuery()

        conex.Close()

    End Sub


    'Recibe el nombre del usuario y genera un username sin espacios
    Function EliminarEspacios(ByVal texto As String) As String
        Dim resultado As String = ""

        For Each caracter As Char In texto
            If Not Char.IsWhiteSpace(caracter) Then
                resultado += caracter
            End If
        Next

        Return resultado
    End Function


End Class