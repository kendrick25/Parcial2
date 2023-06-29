Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO

Public Class Factura

    Private Sub BtnExaminar_Click(sender As Object, e As EventArgs) Handles BtnExaminar.Click
        Dim folderBrowserDialog1 As New FolderBrowserDialog()

        If folderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            TextBoxRuta.Text = folderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub BtnFactura_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        Dim xlApp As Excel.Application
        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add()
        xlWorkSheet = CType(xlWorkBook.Sheets("Hoja1"), Excel.Worksheet)

        ' Agrega datos a la hoja de trabajo.           Formato de tabla
        'fila , columna
        xlWorkSheet.Cells(1, 1) = "JK"
        xlWorkSheet.Cells(6, 1) = "1"
        xlWorkSheet.Cells(8, 1) = "1" & "1"
        xlWorkSheet.Cells(9, 1) = "1" & "2"
        xlWorkSheet.Cells(10, 1) = "1" & "3"

        ' Personaliza el tipo de letra y tamaño.
        xlWorkSheet.Range("A1:A4").Font.Name = "Arial"
        xlWorkSheet.Range("A2:A4").Font.Size = 12
        xlWorkSheet.Range("A1").Font.Size = 30

        ' Cambiar el color de letra de una celda
        xlWorkSheet.Range("A1").Font.Color = Color.White
        ' Personaliza el fondo.
        xlWorkSheet.Range("A2:A4").Interior.ColorIndex = 6
        xlWorkSheet.Range("A1").Interior.Color = RGB(64, 64, 64)

        ' Hace que el texto sea negrita.
        xlWorkSheet.Range("A1:A4").Font.Bold = True


        ' Centra el contenido de cada celda.
        xlWorkSheet.Range("A1:A4").HorizontalAlignment = Excel.Constants.xlCenter

        ' Establecer el ancho y la altura de las celdas
        xlWorkSheet.Range("A1").ColumnWidth = 20
        xlWorkSheet.Range("A1").RowHeight = 30
        ' Combinar celdas
        xlWorkSheet.Range("A1:B1").Merge()

        ' Agregar bordes a las celdas
        'todos los bordes
        xlWorkSheet.Range("A1:A4").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range("A1:A4").Borders.Weight = Excel.XlBorderWeight.xlThin
        'arriba
        xlWorkSheet.Range("C2:C4").Borders.Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range("C2:C4").Borders.Item(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
        'abajo
        xlWorkSheet.Range("D1:D4").Borders.Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range("D1:D4").Borders.Item(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlThin
        'izquierda
        xlWorkSheet.Range("F1:F4").Borders.Item(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range("F1:F4").Borders.Item(Excel.XlBordersIndex.xlEdgeLeft).Weight = Excel.XlBorderWeight.xlThin
        'derecha
        xlWorkSheet.Range("H1:H4").Borders.Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        xlWorkSheet.Range("H1:H4").Borders.Item(Excel.XlBordersIndex.xlEdgeRight).Weight = Excel.XlBorderWeight.xlThin
        ' Guarda el libro de trabajo en la ruta especificada.
        If File.Exists(TextBoxRuta.Text & "\Factura.xlsx") Then
            Dim result As Integer = MessageBox.Show("Este archivo ya exite. Quieres reemplazarlo?", "File Exists", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                File.Delete(TextBoxRuta.Text & "\Factura.xlsx")
                xlWorkBook.SaveAs(TextBoxRuta.Text & "\Factura.xlsx")
            ElseIf result = DialogResult.No Then
                Dim encotrado As Boolean = False
                ' Check if the file exists.
                Dim i As Integer = 1
                ' If the file exists, add a number to the end of the file name.
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
            xlWorkBook.SaveAs(TextBoxRuta.Text & "\Factura.xlsx")
        End If
        xlWorkBook.Close()
        xlApp.Quit()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
    End Sub

    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label37_Click(sender As Object, e As EventArgs) Handles Label37.Click

    End Sub
End Class


