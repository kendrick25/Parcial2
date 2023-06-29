Imports System.Data.SqlClient
Public Class Usuario


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

        'Obtiene la cadena nombre_de_usuario proveniente del login

        Dim usuarioName As String = Funciones.UserLoginName

        'Variable para almacenar la Id de usuario cuyo nombre coincida con el de arriba
        Dim idUsuario As Integer

        'Establecer conexion con la DB

        Dim conexion As New SqlConnection("Data Source=DESKTOP-8ELH4DT;Initial Catalog=JKEnterprise;Integrated Security=True")

        Try
            conexion.Open()
            'Consulta para obtener el ID y tener la relacion entre el ticket que se esta abriendo
            'y el usuario que lo abre. Se realiza con parámetro para la ejecución.

            Dim consultaId As String = "select idUser From Usuario where nombre = @NombreUsuario"

            Dim comando As New SqlCommand(consultaId, conexion)

            comando.Parameters.AddWithValue("@NombreUsuario", usuarioName)

            'Obtener finalmente la id del usuario que inicio sesión. Corta la bocha.

            Dim dimeLaId As Object = comando.ExecuteScalar()

            If dimeLaId IsNot Nothing AndAlso Not DBNull.Value.Equals(dimeLaId) Then
                idUsuario = Convert.ToBase64String(dimeLaId)
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try



    End Sub

End Class