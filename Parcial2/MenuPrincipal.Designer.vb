<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.Border = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MovForm = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NosotrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerMisTiketsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitarTiketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinalizarSolicitudToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.LoginToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnMax = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.tablaContenedoraForms = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ContForms = New System.Windows.Forms.TabControl()
        Me.TabPage = New System.Windows.Forms.TabPage()
        Me.LabelBienvenidaUsuario = New System.Windows.Forms.Label()
        Me.BtnSolicitudTiket = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bnAcceder = New System.Windows.Forms.Button()
        Me.llbOlvidar = New System.Windows.Forms.LinkLabel()
        Me.checkPass = New System.Windows.Forms.CheckBox()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.MenuLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelTikets = New System.Windows.Forms.Panel()
        Me.Border.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MovForm.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.PanelMain.SuspendLayout()
        Me.tablaContenedoraForms.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.ContForms.SuspendLayout()
        Me.TabPage.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTikets.SuspendLayout()
        Me.SuspendLayout()
        '
        'Border
        '
        Me.Border.BackColor = System.Drawing.Color.Blue
        Me.Border.Controls.Add(Me.TableLayoutPanel1)
        Me.Border.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Border.Location = New System.Drawing.Point(0, 0)
        Me.Border.Margin = New System.Windows.Forms.Padding(0)
        Me.Border.Name = "Border"
        Me.Border.Padding = New System.Windows.Forms.Padding(2)
        Me.Border.Size = New System.Drawing.Size(920, 500)
        Me.Border.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MovForm, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(916, 496)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'MovForm
        '
        Me.MovForm.BackColor = System.Drawing.Color.Blue
        Me.MovForm.ColumnCount = 7
        Me.MovForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.MovForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MovForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.MovForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.MovForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.MovForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.MovForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.MovForm.Controls.Add(Me.Label1, 0, 0)
        Me.MovForm.Controls.Add(Me.BtnMin, 4, 0)
        Me.MovForm.Controls.Add(Me.MenuStrip1, 1, 0)
        Me.MovForm.Controls.Add(Me.MenuStrip2, 2, 0)
        Me.MovForm.Controls.Add(Me.BtnClose, 6, 0)
        Me.MovForm.Controls.Add(Me.BtnMax, 5, 0)
        Me.MovForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MovForm.Location = New System.Drawing.Point(0, 0)
        Me.MovForm.Margin = New System.Windows.Forms.Padding(0)
        Me.MovForm.Name = "MovForm"
        Me.MovForm.RowCount = 1
        Me.MovForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MovForm.Size = New System.Drawing.Size(916, 32)
        Me.MovForm.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Empresa JK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnMin
        '
        Me.BtnMin.BackColor = System.Drawing.Color.Transparent
        Me.BtnMin.BackgroundImage = Global.Parcial2.My.Resources.Resources.minimizar
        Me.BtnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnMin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnMin.FlatAppearance.BorderSize = 0
        Me.BtnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMin.Location = New System.Drawing.Point(766, 0)
        Me.BtnMin.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(50, 32)
        Me.BtnMin.TabIndex = 2
        Me.BtnMin.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.NosotrosToolStripMenuItem, Me.TicketToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(110, 0)
        Me.MenuStrip1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.MenuStrip1.Size = New System.Drawing.Size(202, 30)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.InicioToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.InicioToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(57, 28)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'NosotrosToolStripMenuItem
        '
        Me.NosotrosToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.NosotrosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NosotrosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.NosotrosToolStripMenuItem.Name = "NosotrosToolStripMenuItem"
        Me.NosotrosToolStripMenuItem.Size = New System.Drawing.Size(82, 28)
        Me.NosotrosToolStripMenuItem.Text = "Nosotros"
        '
        'TicketToolStripMenuItem
        '
        Me.TicketToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerMisTiketsToolStripMenuItem, Me.SolicitarTiketToolStripMenuItem, Me.FinalizarSolicitudToolStripMenuItem})
        Me.TicketToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TicketToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TicketToolStripMenuItem.Name = "TicketToolStripMenuItem"
        Me.TicketToolStripMenuItem.Size = New System.Drawing.Size(61, 28)
        Me.TicketToolStripMenuItem.Text = "Ticket"
        '
        'VerMisTiketsToolStripMenuItem
        '
        Me.VerMisTiketsToolStripMenuItem.Name = "VerMisTiketsToolStripMenuItem"
        Me.VerMisTiketsToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.VerMisTiketsToolStripMenuItem.Text = "Ver mis Tikets"
        '
        'SolicitarTiketToolStripMenuItem
        '
        Me.SolicitarTiketToolStripMenuItem.Name = "SolicitarTiketToolStripMenuItem"
        Me.SolicitarTiketToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.SolicitarTiketToolStripMenuItem.Text = "Solicitar tiket"
        '
        'FinalizarSolicitudToolStripMenuItem
        '
        Me.FinalizarSolicitudToolStripMenuItem.Name = "FinalizarSolicitudToolStripMenuItem"
        Me.FinalizarSolicitudToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.FinalizarSolicitudToolStripMenuItem.Text = "Finalizar Solicitud"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem2, Me.ToolStripMenuItem2})
        Me.MenuStrip2.Location = New System.Drawing.Point(656, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip2.Size = New System.Drawing.Size(100, 32)
        Me.MenuStrip2.TabIndex = 5
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'LoginToolStripMenuItem2
        '
        Me.LoginToolStripMenuItem2.BackColor = System.Drawing.Color.Transparent
        Me.LoginToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSessionToolStripMenuItem, Me.IniciarSessionToolStripMenuItem})
        Me.LoginToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LoginToolStripMenuItem2.ForeColor = System.Drawing.Color.White
        Me.LoginToolStripMenuItem2.Name = "LoginToolStripMenuItem2"
        Me.LoginToolStripMenuItem2.Padding = New System.Windows.Forms.Padding(25, 0, 25, 0)
        Me.LoginToolStripMenuItem2.Size = New System.Drawing.Size(100, 32)
        Me.LoginToolStripMenuItem2.Text = "Login"
        '
        'CerrarSessionToolStripMenuItem
        '
        Me.CerrarSessionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CerrarSessionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CerrarSessionToolStripMenuItem.Name = "CerrarSessionToolStripMenuItem"
        Me.CerrarSessionToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.CerrarSessionToolStripMenuItem.Text = "Cerrar Session"
        '
        'IniciarSessionToolStripMenuItem
        '
        Me.IniciarSessionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IniciarSessionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.IniciarSessionToolStripMenuItem.Name = "IniciarSessionToolStripMenuItem"
        Me.IniciarSessionToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.IniciarSessionToolStripMenuItem.Text = "Iniciar Session"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(12, 32)
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.BackgroundImage = Global.Parcial2.My.Resources.Resources.cerrar
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Location = New System.Drawing.Point(866, 0)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(50, 32)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnMax
        '
        Me.BtnMax.BackColor = System.Drawing.Color.Transparent
        Me.BtnMax.BackgroundImage = Global.Parcial2.My.Resources.Resources.max
        Me.BtnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnMax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnMax.FlatAppearance.BorderSize = 0
        Me.BtnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMax.Location = New System.Drawing.Point(816, 0)
        Me.BtnMax.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnMax.Name = "BtnMax"
        Me.BtnMax.Size = New System.Drawing.Size(50, 32)
        Me.BtnMax.TabIndex = 3
        Me.BtnMax.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PanelMain, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 32)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(916, 464)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelMain.Controls.Add(Me.tablaContenedoraForms)
        Me.PanelMain.Controls.Add(Me.Panel5)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(280, 0)
        Me.PanelMain.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(636, 464)
        Me.PanelMain.TabIndex = 5
        '
        'tablaContenedoraForms
        '
        Me.tablaContenedoraForms.ColumnCount = 1
        Me.tablaContenedoraForms.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablaContenedoraForms.Controls.Add(Me.Panel6, 0, 0)
        Me.tablaContenedoraForms.Controls.Add(Me.ContForms, 0, 1)
        Me.tablaContenedoraForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaContenedoraForms.Location = New System.Drawing.Point(0, 0)
        Me.tablaContenedoraForms.Margin = New System.Windows.Forms.Padding(0)
        Me.tablaContenedoraForms.Name = "tablaContenedoraForms"
        Me.tablaContenedoraForms.RowCount = 2
        Me.tablaContenedoraForms.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tablaContenedoraForms.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablaContenedoraForms.Size = New System.Drawing.Size(636, 464)
        Me.tablaContenedoraForms.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(636, 30)
        Me.Panel6.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(558, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(7, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(278, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Hay cambios en la solicitudes, actualiza para verlos." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ContForms
        '
        Me.ContForms.Controls.Add(Me.TabPage)
        Me.ContForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContForms.Location = New System.Drawing.Point(0, 30)
        Me.ContForms.Margin = New System.Windows.Forms.Padding(0)
        Me.ContForms.Name = "ContForms"
        Me.ContForms.SelectedIndex = 0
        Me.ContForms.Size = New System.Drawing.Size(636, 434)
        Me.ContForms.TabIndex = 3
        '
        'TabPage
        '
        Me.TabPage.Controls.Add(Me.PanelTikets)
        Me.TabPage.Location = New System.Drawing.Point(4, 24)
        Me.TabPage.Name = "TabPage"
        Me.TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage.Size = New System.Drawing.Size(628, 406)
        Me.TabPage.TabIndex = 0
        Me.TabPage.Text = "Tikets"
        Me.TabPage.UseVisualStyleBackColor = True
        '
        'LabelBienvenidaUsuario
        '
        Me.LabelBienvenidaUsuario.AutoSize = True
        Me.LabelBienvenidaUsuario.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelBienvenidaUsuario.Location = New System.Drawing.Point(36, 16)
        Me.LabelBienvenidaUsuario.Name = "LabelBienvenidaUsuario"
        Me.LabelBienvenidaUsuario.Size = New System.Drawing.Size(23, 30)
        Me.LabelBienvenidaUsuario.TabIndex = 1
        Me.LabelBienvenidaUsuario.Text = "*"
        '
        'BtnSolicitudTiket
        '
        Me.BtnSolicitudTiket.Location = New System.Drawing.Point(20, 73)
        Me.BtnSolicitudTiket.Name = "BtnSolicitudTiket"
        Me.BtnSolicitudTiket.Size = New System.Drawing.Size(141, 23)
        Me.BtnSolicitudTiket.TabIndex = 0
        Me.BtnSolicitudTiket.Text = "Solicitud de tiket"
        Me.BtnSolicitudTiket.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Global.Parcial2.My.Resources.Resources.Logo_2023
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel5.Location = New System.Drawing.Point(93, 97)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(475, 357)
        Me.Panel5.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.gbDatos, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(280, 464)
        Me.TableLayoutPanel3.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(4, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 50)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ACCEDE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbDatos.Controls.Add(Me.Label5)
        Me.gbDatos.Controls.Add(Me.Label3)
        Me.gbDatos.Controls.Add(Me.PictureBox3)
        Me.gbDatos.Controls.Add(Me.Label4)
        Me.gbDatos.Controls.Add(Me.PictureBox4)
        Me.gbDatos.Controls.Add(Me.Panel2)
        Me.gbDatos.Controls.Add(Me.Panel1)
        Me.gbDatos.Controls.Add(Me.PictureBox2)
        Me.gbDatos.Controls.Add(Me.PictureBox1)
        Me.gbDatos.Controls.Add(Me.bnAcceder)
        Me.gbDatos.Controls.Add(Me.llbOlvidar)
        Me.gbDatos.Controls.Add(Me.checkPass)
        Me.gbDatos.Controls.Add(Me.tbPass)
        Me.gbDatos.Controls.Add(Me.tbUser)
        Me.gbDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbDatos.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gbDatos.ForeColor = System.Drawing.Color.Black
        Me.gbDatos.Location = New System.Drawing.Point(4, 54)
        Me.gbDatos.Margin = New System.Windows.Forms.Padding(3, 3, 3, 9)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Padding = New System.Windows.Forms.Padding(2)
        Me.gbDatos.Size = New System.Drawing.Size(272, 400)
        Me.gbDatos.TabIndex = 2
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos de Usuario"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(50, 105)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 21)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Contraseña :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(52, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 21)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Usuario :"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Location = New System.Drawing.Point(52, 302)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.MaximumSize = New System.Drawing.Size(33, 27)
        Me.PictureBox3.MinimumSize = New System.Drawing.Size(33, 27)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(33, 27)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(113, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 18)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "or"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Location = New System.Drawing.Point(168, 302)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox4.MaximumSize = New System.Drawing.Size(33, 27)
        Me.PictureBox4.MinimumSize = New System.Drawing.Size(33, 27)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(33, 27)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.Location = New System.Drawing.Point(52, 161)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(184, 3)
        Me.Panel2.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lime
        Me.Panel1.Location = New System.Drawing.Point(52, 87)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(184, 3)
        Me.Panel1.TabIndex = 12
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(11, 135)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox2.MaximumSize = New System.Drawing.Size(33, 29)
        Me.PictureBox2.MinimumSize = New System.Drawing.Size(33, 29)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(11, 57)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(33, 29)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(33, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'bnAcceder
        '
        Me.bnAcceder.BackColor = System.Drawing.Color.Blue
        Me.bnAcceder.FlatAppearance.BorderSize = 0
        Me.bnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnAcceder.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bnAcceder.ForeColor = System.Drawing.Color.White
        Me.bnAcceder.Location = New System.Drawing.Point(82, 248)
        Me.bnAcceder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bnAcceder.Name = "bnAcceder"
        Me.bnAcceder.Size = New System.Drawing.Size(85, 31)
        Me.bnAcceder.TabIndex = 6
        Me.bnAcceder.Text = "Entrar"
        Me.bnAcceder.UseVisualStyleBackColor = False
        '
        'llbOlvidar
        '
        Me.llbOlvidar.AutoSize = True
        Me.llbOlvidar.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.llbOlvidar.Location = New System.Drawing.Point(113, 173)
        Me.llbOlvidar.Name = "llbOlvidar"
        Me.llbOlvidar.Size = New System.Drawing.Size(129, 18)
        Me.llbOlvidar.TabIndex = 5
        Me.llbOlvidar.TabStop = True
        Me.llbOlvidar.Text = "olvidé la contraseña"
        '
        'checkPass
        '
        Me.checkPass.AutoSize = True
        Me.checkPass.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.checkPass.Location = New System.Drawing.Point(5, 205)
        Me.checkPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.checkPass.Name = "checkPass"
        Me.checkPass.Size = New System.Drawing.Size(152, 22)
        Me.checkPass.TabIndex = 4
        Me.checkPass.Text = "Recordar contraseña"
        Me.checkPass.UseVisualStyleBackColor = True
        '
        'tbPass
        '
        Me.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPass.Location = New System.Drawing.Point(50, 135)
        Me.tbPass.Margin = New System.Windows.Forms.Padding(0)
        Me.tbPass.MaximumSize = New System.Drawing.Size(184, 26)
        Me.tbPass.MinimumSize = New System.Drawing.Size(184, 26)
        Me.tbPass.Multiline = True
        Me.tbPass.Name = "tbPass"
        Me.tbPass.Size = New System.Drawing.Size(184, 26)
        Me.tbPass.TabIndex = 3
        '
        'tbUser
        '
        Me.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbUser.Location = New System.Drawing.Point(50, 60)
        Me.tbUser.Margin = New System.Windows.Forms.Padding(0)
        Me.tbUser.MaximumSize = New System.Drawing.Size(184, 27)
        Me.tbUser.MinimumSize = New System.Drawing.Size(184, 27)
        Me.tbUser.Multiline = True
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(184, 27)
        Me.tbUser.TabIndex = 1
        '
        'MenuLogin
        '
        Me.MenuLogin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.MenuLogin.BackColor = System.Drawing.Color.Blue
        Me.MenuLogin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuLogin.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MenuLogin.ForeColor = System.Drawing.Color.White
        Me.MenuLogin.Name = "MenuLogin"
        Me.MenuLogin.Padding = New System.Windows.Forms.Padding(25, 0, 25, 0)
        Me.MenuLogin.Size = New System.Drawing.Size(100, 32)
        Me.MenuLogin.Text = "Login"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(69, 22)
        '
        'PanelTikets
        '
        Me.PanelTikets.Controls.Add(Me.LabelBienvenidaUsuario)
        Me.PanelTikets.Controls.Add(Me.BtnSolicitudTiket)
        Me.PanelTikets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTikets.Location = New System.Drawing.Point(3, 3)
        Me.PanelTikets.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelTikets.Name = "PanelTikets"
        Me.PanelTikets.Size = New System.Drawing.Size(622, 400)
        Me.PanelTikets.TabIndex = 2
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(920, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.Border)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(920, 500)
        Me.Name = "MenuPrincipal"
        Me.Text = " - CODE"
        Me.Border.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.MovForm.ResumeLayout(False)
        Me.MovForm.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.PanelMain.ResumeLayout(False)
        Me.tablaContenedoraForms.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ContForms.ResumeLayout(False)
        Me.TabPage.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTikets.ResumeLayout(False)
        Me.PanelTikets.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Border As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MovForm As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BtnMin As Button
    Friend WithEvents BtnMax As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents NosotrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents MenuLogin As ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CerrarSessionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IniciarSessionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bnAcceder As Button
    Friend WithEvents llbOlvidar As LinkLabel
    Friend WithEvents checkPass As CheckBox
    Friend WithEvents tbPass As TextBox
    Friend WithEvents tbUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelMain As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TicketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerMisTiketsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolicitarTiketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tablaContenedoraForms As TableLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents FinalizarSolicitudToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ContForms As TabControl
    Friend WithEvents TabPage As TabPage
    Friend WithEvents LabelBienvenidaUsuario As Label
    Friend WithEvents BtnSolicitudTiket As Button
    Friend WithEvents PanelTikets As Panel
End Class
