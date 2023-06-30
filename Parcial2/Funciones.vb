Imports System.Text
Module Funciones

    Public UserLoginName As String
    Public userID As String

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

End Module
