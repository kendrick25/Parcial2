<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnFinalizar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbExtras = New System.Windows.Forms.Label()
        Me.gbDetalleTicket2 = New System.Windows.Forms.GroupBox()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbDetalleTicket1 = New System.Windows.Forms.GroupBox()
        Me.btConfirm2 = New System.Windows.Forms.Button()
        Me.btConfirm1 = New System.Windows.Forms.Button()
        Me.lbFechaActual = New System.Windows.Forms.Label()
        Me.cbComponente = New System.Windows.Forms.ComboBox()
        Me.lbComponente = New System.Windows.Forms.Label()
        Me.cbModelo = New System.Windows.Forms.ComboBox()
        Me.lbModelo = New System.Windows.Forms.Label()
        Me.cbEquipo = New System.Windows.Forms.ComboBox()
        Me.lbEquipo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbFechaEstimada = New System.Windows.Forms.Label()
        Me.bnConfirm3 = New System.Windows.Forms.Button()
        Me.btConfirm4 = New System.Windows.Forms.Button()
        Me.bnCrearTicket = New System.Windows.Forms.Button()
        Me.lbPrioridad = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.gbDetalleTicket2.SuspendLayout()
        Me.gbDetalleTicket1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnFinalizar
        '
        Me.BtnFinalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFinalizar.Location = New System.Drawing.Point(789, 0)
        Me.BtnFinalizar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnFinalizar.Name = "BtnFinalizar"
        Me.BtnFinalizar.Size = New System.Drawing.Size(86, 31)
        Me.BtnFinalizar.TabIndex = 0
        Me.BtnFinalizar.Text = "Finalizar"
        Me.BtnFinalizar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(877, 600)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnFinalizar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(877, 67)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(682, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbPrioridad)
        Me.Panel2.Controls.Add(Me.bnCrearTicket)
        Me.Panel2.Controls.Add(Me.lbExtras)
        Me.Panel2.Controls.Add(Me.gbDetalleTicket2)
        Me.Panel2.Controls.Add(Me.gbDetalleTicket1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(871, 527)
        Me.Panel2.TabIndex = 2
        '
        'lbExtras
        '
        Me.lbExtras.AutoSize = True
        Me.lbExtras.Location = New System.Drawing.Point(590, 65)
        Me.lbExtras.Name = "lbExtras"
        Me.lbExtras.Size = New System.Drawing.Size(208, 20)
        Me.lbExtras.TabIndex = 2
        Me.lbExtras.Text = "Ya casi. Agrega detalles extras"
        '
        'gbDetalleTicket2
        '
        Me.gbDetalleTicket2.Controls.Add(Me.btConfirm4)
        Me.gbDetalleTicket2.Controls.Add(Me.bnConfirm3)
        Me.gbDetalleTicket2.Controls.Add(Me.lbFechaEstimada)
        Me.gbDetalleTicket2.Controls.Add(Me.Label8)
        Me.gbDetalleTicket2.Controls.Add(Me.tbDescripcion)
        Me.gbDetalleTicket2.Controls.Add(Me.Label7)
        Me.gbDetalleTicket2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.gbDetalleTicket2.Location = New System.Drawing.Point(449, 88)
        Me.gbDetalleTicket2.Name = "gbDetalleTicket2"
        Me.gbDetalleTicket2.Size = New System.Drawing.Size(377, 339)
        Me.gbDetalleTicket2.TabIndex = 3
        Me.gbDetalleTicket2.TabStop = False
        Me.gbDetalleTicket2.Text = "Detalles extras"
        '
        'tbDescripcion
        '
        Me.tbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbDescripcion.Location = New System.Drawing.Point(35, 82)
        Me.tbDescripcion.Multiline = True
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbDescripcion.Size = New System.Drawing.Size(303, 84)
        Me.tbDescripcion.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(6, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 22)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Descripción"
        '
        'gbDetalleTicket1
        '
        Me.gbDetalleTicket1.Controls.Add(Me.btConfirm2)
        Me.gbDetalleTicket1.Controls.Add(Me.btConfirm1)
        Me.gbDetalleTicket1.Controls.Add(Me.lbFechaActual)
        Me.gbDetalleTicket1.Controls.Add(Me.cbComponente)
        Me.gbDetalleTicket1.Controls.Add(Me.lbComponente)
        Me.gbDetalleTicket1.Controls.Add(Me.cbModelo)
        Me.gbDetalleTicket1.Controls.Add(Me.lbModelo)
        Me.gbDetalleTicket1.Controls.Add(Me.cbEquipo)
        Me.gbDetalleTicket1.Controls.Add(Me.lbEquipo)
        Me.gbDetalleTicket1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.gbDetalleTicket1.Location = New System.Drawing.Point(44, 65)
        Me.gbDetalleTicket1.Name = "gbDetalleTicket1"
        Me.gbDetalleTicket1.Size = New System.Drawing.Size(377, 362)
        Me.gbDetalleTicket1.TabIndex = 1
        Me.gbDetalleTicket1.TabStop = False
        Me.gbDetalleTicket1.Text = "Detalles"
        '
        'btConfirm2
        '
        Me.btConfirm2.Location = New System.Drawing.Point(204, 303)
        Me.btConfirm2.Name = "btConfirm2"
        Me.btConfirm2.Size = New System.Drawing.Size(53, 38)
        Me.btConfirm2.TabIndex = 8
        Me.btConfirm2.UseVisualStyleBackColor = True
        '
        'btConfirm1
        '
        Me.btConfirm1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btConfirm1.Location = New System.Drawing.Point(124, 303)
        Me.btConfirm1.Name = "btConfirm1"
        Me.btConfirm1.Size = New System.Drawing.Size(53, 38)
        Me.btConfirm1.TabIndex = 7
        Me.btConfirm1.UseVisualStyleBackColor = True
        '
        'lbFechaActual
        '
        Me.lbFechaActual.AutoSize = True
        Me.lbFechaActual.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbFechaActual.ForeColor = System.Drawing.Color.Blue
        Me.lbFechaActual.Location = New System.Drawing.Point(151, 27)
        Me.lbFechaActual.Name = "lbFechaActual"
        Me.lbFechaActual.Size = New System.Drawing.Size(67, 24)
        Me.lbFechaActual.TabIndex = 6
        Me.lbFechaActual.Text = "Label6"
        '
        'cbComponente
        '
        Me.cbComponente.FormattingEnabled = True
        Me.cbComponente.Location = New System.Drawing.Point(134, 229)
        Me.cbComponente.Name = "cbComponente"
        Me.cbComponente.Size = New System.Drawing.Size(221, 33)
        Me.cbComponente.TabIndex = 5
        '
        'lbComponente
        '
        Me.lbComponente.AutoSize = True
        Me.lbComponente.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbComponente.Location = New System.Drawing.Point(18, 234)
        Me.lbComponente.Name = "lbComponente"
        Me.lbComponente.Size = New System.Drawing.Size(110, 22)
        Me.lbComponente.TabIndex = 4
        Me.lbComponente.Text = "Componente"
        '
        'cbModelo
        '
        Me.cbModelo.FormattingEnabled = True
        Me.cbModelo.Location = New System.Drawing.Point(134, 159)
        Me.cbModelo.Name = "cbModelo"
        Me.cbModelo.Size = New System.Drawing.Size(221, 33)
        Me.cbModelo.TabIndex = 3
        '
        'lbModelo
        '
        Me.lbModelo.AutoSize = True
        Me.lbModelo.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbModelo.Location = New System.Drawing.Point(60, 164)
        Me.lbModelo.Name = "lbModelo"
        Me.lbModelo.Size = New System.Drawing.Size(68, 22)
        Me.lbModelo.TabIndex = 2
        Me.lbModelo.Text = "Modelo"
        '
        'cbEquipo
        '
        Me.cbEquipo.FormattingEnabled = True
        Me.cbEquipo.Location = New System.Drawing.Point(134, 84)
        Me.cbEquipo.Name = "cbEquipo"
        Me.cbEquipo.Size = New System.Drawing.Size(221, 33)
        Me.cbEquipo.TabIndex = 1
        '
        'lbEquipo
        '
        Me.lbEquipo.AutoSize = True
        Me.lbEquipo.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbEquipo.Location = New System.Drawing.Point(65, 89)
        Me.lbEquipo.Name = "lbEquipo"
        Me.lbEquipo.Size = New System.Drawing.Size(63, 22)
        Me.lbEquipo.TabIndex = 0
        Me.lbEquipo.Text = "Equipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(260, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(370, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Bienvenido, especifica tu problema"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(6, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(220, 23)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Fecha estimada de solución"
        '
        'lbFechaEstimada
        '
        Me.lbFechaEstimada.AutoSize = True
        Me.lbFechaEstimada.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbFechaEstimada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbFechaEstimada.Location = New System.Drawing.Point(35, 224)
        Me.lbFechaEstimada.Name = "lbFechaEstimada"
        Me.lbFechaEstimada.Size = New System.Drawing.Size(67, 24)
        Me.lbFechaEstimada.TabIndex = 3
        Me.lbFechaEstimada.Text = "Label9"
        '
        'bnConfirm3
        '
        Me.bnConfirm3.Location = New System.Drawing.Point(128, 279)
        Me.bnConfirm3.Name = "bnConfirm3"
        Me.bnConfirm3.Size = New System.Drawing.Size(53, 38)
        Me.bnConfirm3.TabIndex = 4
        Me.bnConfirm3.UseVisualStyleBackColor = True
        '
        'btConfirm4
        '
        Me.btConfirm4.Location = New System.Drawing.Point(203, 280)
        Me.btConfirm4.Name = "btConfirm4"
        Me.btConfirm4.Size = New System.Drawing.Size(53, 38)
        Me.btConfirm4.TabIndex = 5
        Me.btConfirm4.UseVisualStyleBackColor = True
        '
        'bnCrearTicket
        '
        Me.bnCrearTicket.BackColor = System.Drawing.Color.SkyBlue
        Me.bnCrearTicket.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.bnCrearTicket.Location = New System.Drawing.Point(389, 445)
        Me.bnCrearTicket.Name = "bnCrearTicket"
        Me.bnCrearTicket.Size = New System.Drawing.Size(99, 51)
        Me.bnCrearTicket.TabIndex = 4
        Me.bnCrearTicket.Text = "ENVIAR"
        Me.bnCrearTicket.UseVisualStyleBackColor = False
        '
        'lbPrioridad
        '
        Me.lbPrioridad.AutoSize = True
        Me.lbPrioridad.ForeColor = System.Drawing.Color.Red
        Me.lbPrioridad.Location = New System.Drawing.Point(62, 460)
        Me.lbPrioridad.Name = "lbPrioridad"
        Me.lbPrioridad.Size = New System.Drawing.Size(289, 20)
        Me.lbPrioridad.TabIndex = 5
        Me.lbPrioridad.Text = "Nota: se dará una prioridad alta a tu ticket"
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Usuario"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.gbDetalleTicket2.ResumeLayout(False)
        Me.gbDetalleTicket2.PerformLayout()
        Me.gbDetalleTicket1.ResumeLayout(False)
        Me.gbDetalleTicket1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnFinalizar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lbExtras As Label
    Friend WithEvents gbDetalleTicket2 As GroupBox
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents gbDetalleTicket1 As GroupBox
    Friend WithEvents btConfirm2 As Button
    Friend WithEvents btConfirm1 As Button
    Friend WithEvents lbFechaActual As Label
    Friend WithEvents cbComponente As ComboBox
    Friend WithEvents lbComponente As Label
    Friend WithEvents cbModelo As ComboBox
    Friend WithEvents lbModelo As Label
    Friend WithEvents cbEquipo As ComboBox
    Friend WithEvents lbEquipo As Label
    Friend WithEvents lbFechaEstimada As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btConfirm4 As Button
    Friend WithEvents bnConfirm3 As Button
    Friend WithEvents lbPrioridad As Label
    Friend WithEvents bnCrearTicket As Button
End Class
