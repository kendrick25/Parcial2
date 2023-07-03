Imports System.Data.SqlClient
Public Class Registrarse

    Public conex As New SqlConnection("Data Source=DESKTOP-8ELH4DT;Initial Catalog=JKEnterprise;Integrated Security=True")


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bnCancelRegistro.Click
        Me.Close()
    End Sub

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

    Private Sub mostrarVer_Click(sender As Object, e As EventArgs) Handles btMostrarVer.Click

        If tbPass.PasswordChar = "*" Then
            tbPass.PasswordChar = ControlChars.NullChar

        Else
            tbPass.PasswordChar = "*"
        End If

    End Sub

    Private Sub btAgregarNew_Click(sender As Object, e As EventArgs) Handles btAgregarNew.Click
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
                    If tbNewUserName.Text = Nothing Then
                        faltante4.Visible = True
                    Else
                        faltante4.Visible = False
                        If tbPass.Text = Nothing Then
                            faltante5.Visible = True
                        Else
                            faltante5.Visible = False
                            If tbMail.Text = Nothing Then
                                faltante6.Visible = True
                            Else
                                faltante6.Visible = False

                                conex.Open()

                                Dim answer As Integer
                                answer = MsgBox("Confirmacion de registro", vbQuestion + vbYesNo)

                                If answer = vbYes Then


                                    Dim NewUsuario As New SqlCommand()

                                    NewUsuario.Connection = conex

                                    NewUsuario.CommandType = CommandType.StoredProcedure

                                    NewUsuario.CommandText = "NuevoUser"

                                    NewUsuario.Parameters.AddWithValue("idUsuario", lbIdAsignada.Text)
                                    NewUsuario.Parameters.AddWithValue("nombreUsu", tbNewUser.Text)
                                    NewUsuario.Parameters.AddWithValue("nombreLog", tbNewUserName.Text)
                                    NewUsuario.Parameters.AddWithValue("cedulaUsu", tbCedula.Text)
                                    NewUsuario.Parameters.AddWithValue("contactoUsu", tbTelefono.Text)
                                    NewUsuario.Parameters.AddWithValue("passUsu", tbPass.Text)
                                    NewUsuario.Parameters.AddWithValue("correoUsu", tbMail.Text)
                                    NewUsuario.Parameters.AddWithValue("rolUsu", "user")
                                    NewUsuario.Parameters.AddWithValue("estado", "Nuevo")

                                    NewUsuario.ExecuteNonQuery()

                                    'Crear nuevo usuario y almacenarlo en la base de datos. PENDIENTE

                                    Timer1.Enabled = True
                                    carga.Visible = True
                                    bnCancelRegistro.Enabled = False
                                Else

                                End If
                                ' xxxx
                                ' xxxx
                                conex.Close()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        carga.Value = carga.Value + 10
        If carga.Value >= 100 Then
            Timer1.Enabled = False
            MsgBox("Nombre de usuario: " & tbNewUserName.Text & vbNewLine & "Password: " & tbPass.Text _
            & vbNewLine & "¡ANÓTALOS!", , "REALIZADO")
            carga.Visible = False
            btAgregarNew.Enabled = False
            Me.Close()
        End If
    End Sub


End Class