Imports System.Text
Imports System.Data.SqlClient

Friend Module Funciones
    'Funcion para conexion de base de datos
    Public Function Conexion() As String
        'Conexion Kembrish
        Dim cadenaconexion As String = "Data Source=DESKTOP-GQPJ6BS;Initial Catalog=JKEnterprise;Integrated Security=True"
        'Conexion de Dilan
        'Dim cadenaconexion As String = "Data Source=DESKTOP-8ELH4DT;Initial Catalog=JKEnterprise;Integrated Security=True"

        Return cadenaconexion
    End Function

    'Variables globales que captan datos para pasar de un form a otro

    Public UserLoginCajero As String 'Almacena el nombre del cajero que inicia sesión

    Public inicioSesionId As String 'Almacena el id del cajero que inicia sesión

    Public inicioSesionEmpl As String ''Almacena el nombre del empleado que inicia sesión

    'Public userID As String

    Public idAsig, nombreToCancel As String 'Almacena la id random que se genera cuando se inicia el progreso de un
    'ticket para pasarla al form del ticket y hacer la relación ticket-cliente. NombreToCancel toma el nombre del
    'cliente del cual se va a cancelar el ticket y borrarlo de la base de datos.


    'Genera la id random cuando se inicia un ticket
    Function GenerarID() As String
        ' Configuración
        Dim longitud As Integer = 5 ' Longitud del ID
        Dim caracteresPermitidos As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789" ' Caracteres permitidos para el ID

        ' Generar ID aleatorio
        Dim rnd As New Random()
        Dim sb As New StringBuilder()

        For i As Integer = 1 To longitud
            Dim index As Integer = rnd.Next(0, caracteresPermitidos.Length)
            sb.Append(caracteresPermitidos(index))
        Next

        Return sb.ToString()
    End Function


    'Función para generar una pass random ya que el cliente se almacenará en la base de datos, pero no debe
    'proporcionar ni username ni pass al momento de abrir el ticket. Por lo tanto se agregan random.
    Function GenerarPass() As String
        ' Configuración
        Dim longit As Integer = 5 ' Longitud del Pass
        Dim caracteresPermitidos As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789" ' Caracteres permitidos para el ID

        ' Generar ID aleatorio
        Dim rndon As New Random()
        Dim sbGen As New StringBuilder()

        For i As Integer = 1 To longit
            Dim index As Integer = rndon.Next(0, caracteresPermitidos.Length)
            sbGen.Append(caracteresPermitidos(index))
        Next

        Return sbGen.ToString()
    End Function




End Module
