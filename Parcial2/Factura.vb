Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO

Public Class Factura
    Public xlWorkBook As Excel.Workbook
    Public xlWorkSheet As Excel.Worksheet
    Public xlApp As Excel.Application
    Const Revision As Double = 20.0 'costos de revision
    Private Sub BtnExaminar_Click(sender As Object, e As EventArgs) Handles BtnExaminar.Click
        Dim folderBrowserDialog1 As New FolderBrowserDialog()

        If folderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            TextBoxRuta.Text = folderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub BtnFactura_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        If TextBoxRuta.Text = "" Or Not Directory.Exists(TextBoxRuta.Text) Then
            If Not Directory.Exists(TextBoxRuta.Text) Then
                MessageBox.Show("Especifique una ruta valida del ordenador antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Especifique una ruta en el ordenador antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Add()
            xlWorkSheet = CType(xlWorkBook.Sheets("Hoja1"), Excel.Worksheet)
            ' Guarda el libro de trabajo en la ruta especificada.
            If File.Exists(TextBoxRuta.Text & "\Factura.xlsx") Then
                'Pregunta si el archivo exite para reemplazarlo y si no crea un archivo nuevo
                Dim result As Integer = MessageBox.Show("Este archivo ya exite. Quieres reemplazarlo?", "File Exists", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Yes Then
                    '//////////////////////////////////////////////////
                    If Not IsExcelFileOpen(TextBoxRuta.Text & "\Factura.xlsx") Then
                        FormatoExcelJK()
                        ' Hacer algo con el archivo aquí
                        ' Guardar archivo aquí
                        File.Delete(TextBoxRuta.Text & "\Factura.xlsx")
                        xlWorkSheet.SaveAs(TextBoxRuta.Text & "\Factura.xlsx", Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook)
                    Else
                        MessageBox.Show("El archivo está abierto. Cierre el archivo y vuelva a intentarlo.", "Archivo abierto")
                    End If
                    '/////////////////////////////////////////////////////
                ElseIf result = DialogResult.No Then
                    FormatoExcelJK()
                    Dim encotrado As Boolean = False
                    ' Verifica si el archivo existe
                    Dim i As Integer = 1
                    'Si existe le pone el mism nombre pero con copia 
                    While encotrado = False
                        If File.Exists(TextBoxRuta.Text & "\Factura_Copia(" & i & ").xlsx") Then
                        Else
                            xlWorkBook.SaveAs(TextBoxRuta.Text & "\Factura_Copia(" & i & ").xlsx")
                            encotrado = True
                        End If
                        i += 1
                    End While
                End If
            Else
                FormatoExcelJK()
                xlWorkBook.SaveAs(TextBoxRuta.Text & "\Factura.xlsx")
            End If
            xlWorkBook.Close()
            xlApp.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
        End If
    End Sub

    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label22.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm tt")
    End Sub
    Private Function IsExcelFileOpen(ByVal fileName As String) As Boolean
        Dim fileInUse As Boolean = False
        Dim fs As FileStream = Nothing
        Try
            fs = File.Open(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None)
        Catch ex As Exception
            fileInUse = True
        Finally
            If fs IsNot Nothing Then
                fs.Close()
            End If
        End Try
        Return fileInUse
    End Function


    Public Sub FormatoExcelJK()
        'Personaliza el tipo de letra.
        xlWorkSheet.Range("B2:F24").Font.Name = "Arial"
        'Personaliza el tamaño de letra de las celdas.
        xlWorkSheet.Range("B2").Font.Size = 72
        xlWorkSheet.Range("D2:F8").Font.Size = 10
        xlWorkSheet.Range("B9:F23").Font.Size = 10
        xlWorkSheet.Range("B4:F24").Font.Size = 12
        xlWorkSheet.Range("D4:F4").Font.Size = 22
        ' Cambiar el color de letra de¡ las celdas
        xlWorkSheet.Range("B2:F10").Font.Color = Color.White
        xlWorkSheet.Range("B10:C10").Font.Color = Color.Black
        xlWorkSheet.Range("B11:B16").Font.Color = Color.White
        xlWorkSheet.Range("B17:F17").Font.Color = Color.White
        xlWorkSheet.Range("B19:F21").Font.Color = Color.White
        xlWorkSheet.Range("B23:F24").Font.Color = Color.White
        ' Hace que el texto sea negrita.
        xlWorkSheet.Range("B2:F8").Font.Bold = True
        xlWorkSheet.Range("B9:B16").Font.Bold = True
        xlWorkSheet.Range("C9:F10").Font.Bold = True
        xlWorkSheet.Range("B17:F17").Font.Bold = True
        xlWorkSheet.Range("B19:F19").Font.Bold = True
        xlWorkSheet.Range("B20").Font.Bold = True
        xlWorkSheet.Range("B21:F21").Font.Bold = True
        xlWorkSheet.Range("B23").Font.Bold = True
        xlWorkSheet.Range("B24:F24").Font.Bold = True
        ' Establecer el ancho y la altura de las celdas
        'columnas
        xlWorkSheet.Range("B1").ColumnWidth = 28.57
        xlWorkSheet.Range("C1").ColumnWidth = 28.14
        xlWorkSheet.Range("D1").ColumnWidth = 14.14
        xlWorkSheet.Range("E1").ColumnWidth = 31.43
        xlWorkSheet.Range("F1").ColumnWidth = 22.57
        'filas
        xlWorkSheet.Range("G2:G16").RowHeight = 16
        xlWorkSheet.Range("G4").RowHeight = 36
        xlWorkSheet.Range("G17").RowHeight = 23
        xlWorkSheet.Range("G18").RowHeight = 52
        xlWorkSheet.Range("G19").RowHeight = 23
        xlWorkSheet.Range("G20:G23").RowHeight = 19
        xlWorkSheet.Range("G24").RowHeight = 50
        ' Personaliza el color de  fondo.
        'color black
        xlWorkSheet.Range("B2:C8").Interior.Color = Color.Black
        xlWorkSheet.Range("D2:F2").Interior.Color = Color.Black
        xlWorkSheet.Range("D4:F4").Interior.Color = Color.Black
        xlWorkSheet.Range("D6:F6").Interior.Color = Color.Black
        xlWorkSheet.Range("D8:F8").Interior.Color = Color.Black
        xlWorkSheet.Range("D10:F10").Interior.Color = Color.Black
        xlWorkSheet.Range("B10").Interior.Color = Color.Black
        xlWorkSheet.Range("B11:B16").Interior.Color = Color.Black
        xlWorkSheet.Range("B19:F19").Interior.Color = Color.Black
        xlWorkSheet.Range("B24:F24").Interior.Color = Color.Black
        xlWorkSheet.Range("B24:F24").Interior.Color = Color.Black

        'color darkgray
        xlWorkSheet.Range("D3:F3").Interior.Color = Color.DarkGray
        xlWorkSheet.Range("D5:F5").Interior.Color = Color.DarkGray
        xlWorkSheet.Range("D7:F7").Interior.Color = Color.DarkGray
        xlWorkSheet.Range("B9").Interior.Color = Color.DarkGray
        xlWorkSheet.Range("D9").Interior.Color = Color.DarkGray
        xlWorkSheet.Range("B17:F17").Interior.Color = Color.DarkGray
        xlWorkSheet.Range("B21:F21").Interior.Color = Color.DarkGray
        xlWorkSheet.Range("B20").Interior.Color = Color.DarkGray
        xlWorkSheet.Range("B23").Interior.Color = Color.DarkGray
        'color gray
        xlWorkSheet.Range("E9:F9").Interior.Color = Color.Gray
        xlWorkSheet.Range("C9").Interior.Color = Color.Gray
        xlWorkSheet.Range("C20:F20").Interior.Color = Color.Gray
        xlWorkSheet.Range("C23:F23").Interior.Color = Color.Gray
        'color white
        xlWorkSheet.Range("D11:F11").Interior.Color = Color.White
        xlWorkSheet.Range("D13:F13").Interior.Color = Color.White
        xlWorkSheet.Range("D15:F15").Interior.Color = Color.White
        xlWorkSheet.Range("B18:F18").Interior.Color = Color.White
        'color smoke white
        xlWorkSheet.Range("D12:F12").Interior.Color = Color.WhiteSmoke
        xlWorkSheet.Range("D14:F14").Interior.Color = Color.WhiteSmoke
        xlWorkSheet.Range("D16:F16").Interior.Color = Color.WhiteSmoke
        xlWorkSheet.Range("B22:F22").Interior.Color = Color.WhiteSmoke
        ' Agrega datos a la hoja de trabajo.           Formato de tabla
        'fila , columna
        '--------------------------------------------------
        'Logo JK
        xlWorkSheet.Cells(2, 2) = "JK"
        '--------------------------------------------------------------
        'info de RUC
        'fila, columna
        xlWorkSheet.Cells(2, 4) = "DGI"
        xlWorkSheet.Cells(3, 4) = "Comprobante de Factura Electronica"
        xlWorkSheet.Cells(4, 4) = "EMPRESA JK"
        xlWorkSheet.Cells(5, 4) = "R.U.C 12425-224-951050 D.V. 101"
        xlWorkSheet.Cells(6, 4) = "DAVID, AV. 3RA, ENTRE AV. OBALDIA Y AV. BALBOA"
        xlWorkSheet.Cells(7, 4) = "Telefono: 775 -1034  o 6592-1274"
        xlWorkSheet.Cells(8, 4) = "FACTURA"
        '--------------------------------------------------------------
        'info del cliente
        'fila, columna
        xlWorkSheet.Cells(9, 2) = "No.Cliente"
        xlWorkSheet.Cells(10, 2) = "Cliente"
        xlWorkSheet.Cells(11, 2) = "Cedula"
        xlWorkSheet.Cells(12, 2) = "Telefono"
        xlWorkSheet.Cells(13, 2) = "Correo"
        xlWorkSheet.Cells(14, 2) = "Empleado Encargado"
        xlWorkSheet.Cells(16, 2) = "Fecha"
        'datos mandado del cliente
        xlWorkSheet.Cells(9, 3) = LabelNCliente.Text
        xlWorkSheet.Cells(10, 3) = LabelNombreCliente.Text
        xlWorkSheet.Cells(11, 3) = LabelCedula.Text
        xlWorkSheet.Cells(12, 3) = LabelTelefono.Text
        xlWorkSheet.Cells(13, 3) = Labelcorreo.Text
        xlWorkSheet.Cells(14, 3) = LabelEmpleadoEncargado.Text
        xlWorkSheet.Cells(16, 3) = Label22.Text 'fecha actual
        '-------------------------------------------------------------
        'tabla de costos
        'fila, columna
        xlWorkSheet.Cells(9, 4) = "No.Factura"
        xlWorkSheet.Cells(10, 4) = "Cantidad"
        xlWorkSheet.Cells(10, 5) = "Descripcion"
        xlWorkSheet.Cells(10, 6) = "Precio"
        xlWorkSheet.Cells(14, 5) = "Sub total"
        xlWorkSheet.Cells(15, 5) = "Impuesto (7%)"
        xlWorkSheet.Cells(16, 5) = "Total"
        xlWorkSheet.Cells(11, 4) = "1"
        xlWorkSheet.Cells(12, 4) = "1"
        xlWorkSheet.Cells(13, 4) = "1"
        xlWorkSheet.Cells(13, 5) = "Costos Adicionales"
        'datos de envio de tabla
        xlWorkSheet.Cells(9, 5) = LabelNFactura.Text
        xlWorkSheet.Cells(11, 5) = LabelRevision.Text
        xlWorkSheet.Cells(11, 6) = Revision.ToString("C")
        xlWorkSheet.Cells(12, 5) = LabelTipoReparacion.Text
        xlWorkSheet.Cells(12, 6) = LabelCostosReparacion.Text
        xlWorkSheet.Cells(14, 6) = LabelSubTotal.Text
        xlWorkSheet.Cells(15, 6) = LabelImpuestos.Text
        xlWorkSheet.Cells(16, 6) = LabelTotalPagar.Text
        xlWorkSheet.Cells(20, 3) = LabelTotalPagar.Text
        '----------------------------------------------------------
        'informacion adicional
        xlWorkSheet.Cells(17, 2) = "Reporte de Trazabilidad"
        xlWorkSheet.Cells(19, 2) = "Forma de Pago"
        xlWorkSheet.Cells(20, 2) = "Efectivo"
        xlWorkSheet.Cells(21, 2) = "Consulta tu Comprobante en"
        xlWorkSheet.Cells(22, 2) = "https://dgi-fep-test.mef.gob.pa:40001/Consultas"
        xlWorkSheet.Cells(23, 2) = "Cufe"
        xlWorkSheet.Cells(23, 3) = "FE012000012867-224-17267-3600022023062800000670565001011451232476"
        xlWorkSheet.Cells(24, 2) = "GRACIAS POR PREFERIRNOS"
        'Indormacion adiciona
        xlWorkSheet.Cells(18, 2) = TextBoxObservacion.Text
        '*********************************************************
        'centrar y combinar 
        ' Combinar celdas
        'logo
        xlWorkSheet.Range("B2:C8").Merge()
        'encabezado
        xlWorkSheet.Range("D2:F2").Merge()
        xlWorkSheet.Range("D3:F3").Merge()
        xlWorkSheet.Range("D4:F4").Merge()
        xlWorkSheet.Range("D5:F5").Merge()
        xlWorkSheet.Range("D6:F6").Merge()
        xlWorkSheet.Range("D7:F7").Merge()
        xlWorkSheet.Range("D8:F8").Merge()
        'datos de cliente
        'Tabla Precios
        xlWorkSheet.Range("E9:F9").Merge()
        'otros Datos
        xlWorkSheet.Range("B17:F17").Merge()
        xlWorkSheet.Range("B18:F18").Merge()
        xlWorkSheet.Range("B19:F19").Merge()
        xlWorkSheet.Range("C20:F20").Merge()
        xlWorkSheet.Range("B21:F21").Merge()
        xlWorkSheet.Range("B22:F22").Merge()
        xlWorkSheet.Range("C23:F23").Merge()
        xlWorkSheet.Range("B24:F24").Merge()


        ' Centra el contenido de cada celda.
        xlWorkSheet.Range("B2:F8").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("B9:B16").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("D9").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("D10:F10").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("D11:D16").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("E11:E13").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("E14:E16").HorizontalAlignment = Excel.Constants.xlRight
        xlWorkSheet.Range("B17:F17").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("B19:F19").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("B20").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("B21:F21").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("B22:F22").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("B23").HorizontalAlignment = Excel.Constants.xlCenter
        xlWorkSheet.Range("B24:F24").HorizontalAlignment = Excel.Constants.xlCenter
        ' Alinear el texto en el medio de la celda
        xlWorkSheet.Range("B2:F8").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xlWorkSheet.Range("B9:B16").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xlWorkSheet.Range("D9").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xlWorkSheet.Range("D10:F10").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xlWorkSheet.Range("D11:D16").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xlWorkSheet.Range("E11:E13").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xlWorkSheet.Range("D10:F10").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xlWorkSheet.Range("E14:E16").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xlWorkSheet.Range("B17:F17").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xlWorkSheet.Range("B19:F19").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xlWorkSheet.Range("B20:F24").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        ' Autoajustar contenido
        ' Autoajustar el alto de la fila 1

        xlWorkSheet.Range("C11").WrapText = True
        xlWorkSheet.Range("C14").WrapText = True
        xlWorkSheet.Range("C15").WrapText = True
        xlWorkSheet.Range("E11").WrapText = True
        xlWorkSheet.Range("E12").WrapText = True
        xlWorkSheet.Range("B18:F18").WrapText = True

        'todos los bordes
        'xlWorkSheet.Range("A1:A4").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        'xlWorkSheet.Range("A1:A4").Borders.Weight = Excel.XlBorderWeight.xlThin

        'borde de arriba en una sola celda
        'xlWorkSheet.Range("C2").Borders.Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        'xlWorkSheet.Range("C2").Borders.Item(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin

        'Borde de abajo en varias celdas
        'xlWorkSheet.Range("D1:D4").Borders.Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        'xlWorkSheet.Range("D1:D4").Borders.Item(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlThin

        'Borde de izquierda en varias celdas
        xlWorkSheet.Range("B2:B24").Borders.Item(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range("B2:B24").Borders.Item(Excel.XlBordersIndex.xlEdgeLeft).Weight = Excel.XlBorderWeight.xlThin
        'Borde de derecha en varias celdas
        xlWorkSheet.Range("F2:F24").Borders.Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range("F2:F24").Borders.Item(Excel.XlBordersIndex.xlEdgeRight).Weight = Excel.XlBorderWeight.xlThin
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class


