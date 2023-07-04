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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuario))
        Me.BtnFinalizar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btRegresar = New System.Windows.Forms.Button()
        Me.btConfirm2 = New System.Windows.Forms.Button()
        Me.bnCrearTicket = New System.Windows.Forms.Button()
        Me.lbPrioridad = New System.Windows.Forms.Label()
        Me.btConfirm1 = New System.Windows.Forms.Button()
        Me.gbDetalleTicket1 = New System.Windows.Forms.GroupBox()
        Me.cbEquipo = New System.Windows.Forms.ComboBox()
        Me.lbEquipo = New System.Windows.Forms.Label()
        Me.lbFechaShowLoad = New System.Windows.Forms.Label()
        Me.lbFechaActual = New System.Windows.Forms.Label()
        Me.cbComponente = New System.Windows.Forms.ComboBox()
        Me.lbComponente = New System.Windows.Forms.Label()
        Me.cbModelo = New System.Windows.Forms.ComboBox()
        Me.lbModelo = New System.Windows.Forms.Label()
        Me.gbDetalleTicket2 = New System.Windows.Forms.GroupBox()
        Me.lbExtras = New System.Windows.Forms.Label()
        Me.lbDias = New System.Windows.Forms.Label()
        Me.limiteChar = New System.Windows.Forms.Label()
        Me.lbFechaEstimada = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbDimeID = New System.Windows.Forms.Label()
        Me.btConfirm4 = New System.Windows.Forms.Button()
        Me.btConfirm3 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.gbDetalleTicket1.SuspendLayout()
        Me.gbDetalleTicket2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnFinalizar
        '
        Me.BtnFinalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFinalizar.BackColor = System.Drawing.Color.Black
        Me.BtnFinalizar.FlatAppearance.BorderSize = 0
        Me.BtnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFinalizar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnFinalizar.ForeColor = System.Drawing.Color.White
        Me.BtnFinalizar.Location = New System.Drawing.Point(531, 302)
        Me.BtnFinalizar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnFinalizar.MaximumSize = New System.Drawing.Size(180, 52)
        Me.BtnFinalizar.MinimumSize = New System.Drawing.Size(180, 52)
        Me.BtnFinalizar.Name = "BtnFinalizar"
        Me.BtnFinalizar.Size = New System.Drawing.Size(180, 52)
        Me.BtnFinalizar.TabIndex = 0
        Me.BtnFinalizar.Text = "Cancelar Proceso"
        Me.BtnFinalizar.UseVisualStyleBackColor = False
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(767, 450)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(767, 50)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 52)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(761, 396)
        Me.Panel2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(245, 9)
        Me.Label2.MaximumSize = New System.Drawing.Size(322, 25)
        Me.Label2.MinimumSize = New System.Drawing.Size(322, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(322, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Bienvenido, especifica tu problema"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Blue
        Me.Panel3.Controls.Add(Me.BtnFinalizar)
        Me.Panel3.Controls.Add(Me.btRegresar)
        Me.Panel3.Controls.Add(Me.btConfirm2)
        Me.Panel3.Controls.Add(Me.bnCrearTicket)
        Me.Panel3.Controls.Add(Me.lbPrioridad)
        Me.Panel3.Controls.Add(Me.btConfirm1)
        Me.Panel3.Controls.Add(Me.gbDetalleTicket1)
        Me.Panel3.Controls.Add(Me.gbDetalleTicket2)
        Me.Panel3.Controls.Add(Me.btConfirm4)
        Me.Panel3.Controls.Add(Me.btConfirm3)
        Me.Panel3.Location = New System.Drawing.Point(26, 18)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.MaximumSize = New System.Drawing.Size(711, 354)
        Me.Panel3.MinimumSize = New System.Drawing.Size(711, 354)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(711, 354)
        Me.Panel3.TabIndex = 9
        '
        'btRegresar
        '
        Me.btRegresar.BackColor = System.Drawing.Color.White
        Me.btRegresar.FlatAppearance.BorderSize = 0
        Me.btRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btRegresar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btRegresar.ForeColor = System.Drawing.Color.Black
        Me.btRegresar.Location = New System.Drawing.Point(0, 302)
        Me.btRegresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btRegresar.MaximumSize = New System.Drawing.Size(180, 52)
        Me.btRegresar.MinimumSize = New System.Drawing.Size(180, 52)
        Me.btRegresar.Name = "btRegresar"
        Me.btRegresar.Size = New System.Drawing.Size(180, 52)
        Me.btRegresar.TabIndex = 1
        Me.btRegresar.Text = "Regresar"
        Me.btRegresar.UseVisualStyleBackColor = False
        '
        'btConfirm2
        '
        Me.btConfirm2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btConfirm2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btConfirm2.FlatAppearance.BorderSize = 0
        Me.btConfirm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btConfirm2.Image = CType(resources.GetObject("btConfirm2.Image"), System.Drawing.Image)
        Me.btConfirm2.Location = New System.Drawing.Point(165, 254)
        Me.btConfirm2.Margin = New System.Windows.Forms.Padding(0)
        Me.btConfirm2.MaximumSize = New System.Drawing.Size(45, 42)
        Me.btConfirm2.MinimumSize = New System.Drawing.Size(45, 42)
        Me.btConfirm2.Name = "btConfirm2"
        Me.btConfirm2.Size = New System.Drawing.Size(45, 42)
        Me.btConfirm2.TabIndex = 8
        Me.btConfirm2.UseVisualStyleBackColor = True
        '
        'bnCrearTicket
        '
        Me.bnCrearTicket.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.bnCrearTicket.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bnCrearTicket.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.bnCrearTicket.FlatAppearance.BorderSize = 0
        Me.bnCrearTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnCrearTicket.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bnCrearTicket.ForeColor = System.Drawing.Color.White
        Me.bnCrearTicket.Location = New System.Drawing.Point(180, 302)
        Me.bnCrearTicket.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bnCrearTicket.Name = "bnCrearTicket"
        Me.bnCrearTicket.Size = New System.Drawing.Size(351, 51)
        Me.bnCrearTicket.TabIndex = 4
        Me.bnCrearTicket.Text = "ENVIAR"
        Me.bnCrearTicket.UseVisualStyleBackColor = False
        '
        'lbPrioridad
        '
        Me.lbPrioridad.AutoSize = True
        Me.lbPrioridad.BackColor = System.Drawing.Color.White
        Me.lbPrioridad.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbPrioridad.ForeColor = System.Drawing.Color.Red
        Me.lbPrioridad.Location = New System.Drawing.Point(22, 226)
        Me.lbPrioridad.Name = "lbPrioridad"
        Me.lbPrioridad.Size = New System.Drawing.Size(294, 19)
        Me.lbPrioridad.TabIndex = 5
        Me.lbPrioridad.Text = "Nota: se dará una prioridad alta a tu ticket"
        '
        'btConfirm1
        '
        Me.btConfirm1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btConfirm1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btConfirm1.FlatAppearance.BorderSize = 0
        Me.btConfirm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btConfirm1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btConfirm1.Image = CType(resources.GetObject("btConfirm1.Image"), System.Drawing.Image)
        Me.btConfirm1.Location = New System.Drawing.Point(82, 253)
        Me.btConfirm1.Margin = New System.Windows.Forms.Padding(0)
        Me.btConfirm1.MaximumSize = New System.Drawing.Size(45, 42)
        Me.btConfirm1.MinimumSize = New System.Drawing.Size(45, 42)
        Me.btConfirm1.Name = "btConfirm1"
        Me.btConfirm1.Size = New System.Drawing.Size(45, 42)
        Me.btConfirm1.TabIndex = 7
        Me.btConfirm1.UseVisualStyleBackColor = True
        '
        'gbDetalleTicket1
        '
        Me.gbDetalleTicket1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.gbDetalleTicket1.BackColor = System.Drawing.Color.Transparent
        Me.gbDetalleTicket1.Controls.Add(Me.cbEquipo)
        Me.gbDetalleTicket1.Controls.Add(Me.lbEquipo)
        Me.gbDetalleTicket1.Controls.Add(Me.lbFechaShowLoad)
        Me.gbDetalleTicket1.Controls.Add(Me.lbFechaActual)
        Me.gbDetalleTicket1.Controls.Add(Me.cbComponente)
        Me.gbDetalleTicket1.Controls.Add(Me.lbComponente)
        Me.gbDetalleTicket1.Controls.Add(Me.cbModelo)
        Me.gbDetalleTicket1.Controls.Add(Me.lbModelo)
        Me.gbDetalleTicket1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gbDetalleTicket1.ForeColor = System.Drawing.Color.White
        Me.gbDetalleTicket1.Location = New System.Drawing.Point(13, 23)
        Me.gbDetalleTicket1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbDetalleTicket1.MaximumSize = New System.Drawing.Size(330, 212)
        Me.gbDetalleTicket1.MinimumSize = New System.Drawing.Size(330, 212)
        Me.gbDetalleTicket1.Name = "gbDetalleTicket1"
        Me.gbDetalleTicket1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbDetalleTicket1.Size = New System.Drawing.Size(330, 212)
        Me.gbDetalleTicket1.TabIndex = 1
        Me.gbDetalleTicket1.TabStop = False
        Me.gbDetalleTicket1.Text = "Detalles"
        '
        'cbEquipo
        '
        Me.cbEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbEquipo.FormattingEnabled = True
        Me.cbEquipo.Items.AddRange(New Object() {"Laptop Dell", "Laptop HP", "Laptop Acer", "Laptop Asus", "Laptop Lenovo", "Mac", "PC"})
        Me.cbEquipo.Location = New System.Drawing.Point(121, 28)
        Me.cbEquipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbEquipo.Name = "cbEquipo"
        Me.cbEquipo.Size = New System.Drawing.Size(194, 25)
        Me.cbEquipo.TabIndex = 1
        '
        'lbEquipo
        '
        Me.lbEquipo.AutoSize = True
        Me.lbEquipo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbEquipo.ForeColor = System.Drawing.Color.White
        Me.lbEquipo.Location = New System.Drawing.Point(59, 32)
        Me.lbEquipo.Name = "lbEquipo"
        Me.lbEquipo.Size = New System.Drawing.Size(55, 19)
        Me.lbEquipo.TabIndex = 0
        Me.lbEquipo.Text = "Equipo"
        '
        'lbFechaShowLoad
        '
        Me.lbFechaShowLoad.AutoSize = True
        Me.lbFechaShowLoad.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbFechaShowLoad.ForeColor = System.Drawing.Color.Blue
        Me.lbFechaShowLoad.Location = New System.Drawing.Point(126, 31)
        Me.lbFechaShowLoad.Name = "lbFechaShowLoad"
        Me.lbFechaShowLoad.Size = New System.Drawing.Size(55, 19)
        Me.lbFechaShowLoad.TabIndex = 7
        Me.lbFechaShowLoad.Text = "Label6"
        '
        'lbFechaActual
        '
        Me.lbFechaActual.AutoSize = True
        Me.lbFechaActual.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbFechaActual.ForeColor = System.Drawing.Color.Blue
        Me.lbFechaActual.Location = New System.Drawing.Point(20, 32)
        Me.lbFechaActual.Name = "lbFechaActual"
        Me.lbFechaActual.Size = New System.Drawing.Size(55, 19)
        Me.lbFechaActual.TabIndex = 6
        Me.lbFechaActual.Text = "Label6"
        '
        'cbComponente
        '
        Me.cbComponente.BackColor = System.Drawing.SystemColors.Window
        Me.cbComponente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbComponente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbComponente.FormattingEnabled = True
        Me.cbComponente.Location = New System.Drawing.Point(121, 138)
        Me.cbComponente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbComponente.Name = "cbComponente"
        Me.cbComponente.Size = New System.Drawing.Size(194, 25)
        Me.cbComponente.TabIndex = 5
        '
        'lbComponente
        '
        Me.lbComponente.AutoSize = True
        Me.lbComponente.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbComponente.ForeColor = System.Drawing.Color.White
        Me.lbComponente.Location = New System.Drawing.Point(20, 141)
        Me.lbComponente.Name = "lbComponente"
        Me.lbComponente.Size = New System.Drawing.Size(95, 19)
        Me.lbComponente.TabIndex = 4
        Me.lbComponente.Text = "Componente"
        '
        'cbModelo
        '
        Me.cbModelo.BackColor = System.Drawing.SystemColors.Window
        Me.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbModelo.FormattingEnabled = True
        Me.cbModelo.Location = New System.Drawing.Point(121, 85)
        Me.cbModelo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbModelo.Name = "cbModelo"
        Me.cbModelo.Size = New System.Drawing.Size(194, 25)
        Me.cbModelo.TabIndex = 3
        '
        'lbModelo
        '
        Me.lbModelo.AutoSize = True
        Me.lbModelo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbModelo.ForeColor = System.Drawing.Color.White
        Me.lbModelo.Location = New System.Drawing.Point(56, 88)
        Me.lbModelo.Name = "lbModelo"
        Me.lbModelo.Size = New System.Drawing.Size(61, 19)
        Me.lbModelo.TabIndex = 2
        Me.lbModelo.Text = "Modelo"
        '
        'gbDetalleTicket2
        '
        Me.gbDetalleTicket2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.gbDetalleTicket2.BackColor = System.Drawing.Color.Transparent
        Me.gbDetalleTicket2.Controls.Add(Me.lbExtras)
        Me.gbDetalleTicket2.Controls.Add(Me.lbDias)
        Me.gbDetalleTicket2.Controls.Add(Me.limiteChar)
        Me.gbDetalleTicket2.Controls.Add(Me.lbFechaEstimada)
        Me.gbDetalleTicket2.Controls.Add(Me.Label8)
        Me.gbDetalleTicket2.Controls.Add(Me.tbDescripcion)
        Me.gbDetalleTicket2.Controls.Add(Me.Label7)
        Me.gbDetalleTicket2.Controls.Add(Me.lbDimeID)
        Me.gbDetalleTicket2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gbDetalleTicket2.ForeColor = System.Drawing.Color.White
        Me.gbDetalleTicket2.Location = New System.Drawing.Point(361, 23)
        Me.gbDetalleTicket2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbDetalleTicket2.MaximumSize = New System.Drawing.Size(330, 212)
        Me.gbDetalleTicket2.MinimumSize = New System.Drawing.Size(330, 212)
        Me.gbDetalleTicket2.Name = "gbDetalleTicket2"
        Me.gbDetalleTicket2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbDetalleTicket2.Size = New System.Drawing.Size(330, 212)
        Me.gbDetalleTicket2.TabIndex = 3
        Me.gbDetalleTicket2.TabStop = False
        Me.gbDetalleTicket2.Text = "Detalles extras"
        '
        'lbExtras
        '
        Me.lbExtras.AutoSize = True
        Me.lbExtras.BackColor = System.Drawing.Color.Black
        Me.lbExtras.ForeColor = System.Drawing.Color.White
        Me.lbExtras.Location = New System.Drawing.Point(20, 20)
        Me.lbExtras.Name = "lbExtras"
        Me.lbExtras.Size = New System.Drawing.Size(213, 19)
        Me.lbExtras.TabIndex = 2
        Me.lbExtras.Text = "Ya casi. Agrega detalles extras"
        '
        'lbDias
        '
        Me.lbDias.AutoSize = True
        Me.lbDias.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbDias.ForeColor = System.Drawing.Color.White
        Me.lbDias.Location = New System.Drawing.Point(170, 179)
        Me.lbDias.Name = "lbDias"
        Me.lbDias.Size = New System.Drawing.Size(49, 19)
        Me.lbDias.TabIndex = 7
        Me.lbDias.Text = "Label3"
        '
        'limiteChar
        '
        Me.limiteChar.AutoSize = True
        Me.limiteChar.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.limiteChar.Location = New System.Drawing.Point(273, 147)
        Me.limiteChar.Name = "limiteChar"
        Me.limiteChar.Size = New System.Drawing.Size(11, 13)
        Me.limiteChar.TabIndex = 6
        Me.limiteChar.Text = "-"
        '
        'lbFechaEstimada
        '
        Me.lbFechaEstimada.AutoSize = True
        Me.lbFechaEstimada.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbFechaEstimada.ForeColor = System.Drawing.Color.White
        Me.lbFechaEstimada.Location = New System.Drawing.Point(21, 180)
        Me.lbFechaEstimada.Name = "lbFechaEstimada"
        Me.lbFechaEstimada.Size = New System.Drawing.Size(49, 19)
        Me.lbFechaEstimada.TabIndex = 3
        Me.lbFechaEstimada.Text = "Label9"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(20, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 19)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Fecha estimada de solución"
        '
        'tbDescripcion
        '
        Me.tbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbDescripcion.Location = New System.Drawing.Point(25, 76)
        Me.tbDescripcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbDescripcion.Multiline = True
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbDescripcion.Size = New System.Drawing.Size(290, 64)
        Me.tbDescripcion.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(21, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Descripción"
        '
        'lbDimeID
        '
        Me.lbDimeID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lbDimeID.AutoSize = True
        Me.lbDimeID.ForeColor = System.Drawing.Color.Black
        Me.lbDimeID.Location = New System.Drawing.Point(109, 88)
        Me.lbDimeID.Name = "lbDimeID"
        Me.lbDimeID.Size = New System.Drawing.Size(53, 19)
        Me.lbDimeID.TabIndex = 2
        Me.lbDimeID.Text = "Label1"
        '
        'btConfirm4
        '
        Me.btConfirm4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btConfirm4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btConfirm4.FlatAppearance.BorderSize = 0
        Me.btConfirm4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btConfirm4.Image = CType(resources.GetObject("btConfirm4.Image"), System.Drawing.Image)
        Me.btConfirm4.Location = New System.Drawing.Point(528, 253)
        Me.btConfirm4.Margin = New System.Windows.Forms.Padding(0)
        Me.btConfirm4.MaximumSize = New System.Drawing.Size(45, 42)
        Me.btConfirm4.MinimumSize = New System.Drawing.Size(45, 42)
        Me.btConfirm4.Name = "btConfirm4"
        Me.btConfirm4.Size = New System.Drawing.Size(45, 42)
        Me.btConfirm4.TabIndex = 5
        Me.btConfirm4.UseVisualStyleBackColor = True
        '
        'btConfirm3
        '
        Me.btConfirm3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btConfirm3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btConfirm3.FlatAppearance.BorderSize = 0
        Me.btConfirm3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btConfirm3.Image = CType(resources.GetObject("btConfirm3.Image"), System.Drawing.Image)
        Me.btConfirm3.Location = New System.Drawing.Point(424, 253)
        Me.btConfirm3.Margin = New System.Windows.Forms.Padding(0)
        Me.btConfirm3.MaximumSize = New System.Drawing.Size(45, 42)
        Me.btConfirm3.MinimumSize = New System.Drawing.Size(45, 42)
        Me.btConfirm3.Name = "btConfirm3"
        Me.btConfirm3.Size = New System.Drawing.Size(45, 42)
        Me.btConfirm3.TabIndex = 4
        Me.btConfirm3.UseVisualStyleBackColor = True
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Usuario"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.gbDetalleTicket1.ResumeLayout(False)
        Me.gbDetalleTicket1.PerformLayout()
        Me.gbDetalleTicket2.ResumeLayout(False)
        Me.gbDetalleTicket2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnFinalizar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbDimeID As Label
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
    Friend WithEvents btConfirm3 As Button
    Friend WithEvents lbPrioridad As Label
    Friend WithEvents bnCrearTicket As Button
    Friend WithEvents limiteChar As Label
    Friend WithEvents lbDias As Label
    Friend WithEvents btRegresar As Button
    Friend WithEvents lbFechaShowLoad As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
End Class
