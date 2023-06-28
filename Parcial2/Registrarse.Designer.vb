<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrarse
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrarse))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbDetallesRegistro = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbIdAsignada = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNewUser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNewUserName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbCedula = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.tbMail = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gbDetallesRegistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(220, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido al registro de usuario"
        '
        'gbDetallesRegistro
        '
        Me.gbDetallesRegistro.BackColor = System.Drawing.Color.Transparent
        Me.gbDetallesRegistro.Controls.Add(Me.ProgressBar1)
        Me.gbDetallesRegistro.Controls.Add(Me.Button1)
        Me.gbDetallesRegistro.Controls.Add(Me.Panel2)
        Me.gbDetallesRegistro.Controls.Add(Me.Panel1)
        Me.gbDetallesRegistro.Controls.Add(Me.tbMail)
        Me.gbDetallesRegistro.Controls.Add(Me.tbPass)
        Me.gbDetallesRegistro.Controls.Add(Me.tbTelefono)
        Me.gbDetallesRegistro.Controls.Add(Me.tbCedula)
        Me.gbDetallesRegistro.Controls.Add(Me.Label8)
        Me.gbDetallesRegistro.Controls.Add(Me.Label7)
        Me.gbDetallesRegistro.Controls.Add(Me.Label6)
        Me.gbDetallesRegistro.Controls.Add(Me.Label5)
        Me.gbDetallesRegistro.Controls.Add(Me.tbNewUserName)
        Me.gbDetallesRegistro.Controls.Add(Me.Label4)
        Me.gbDetallesRegistro.Controls.Add(Me.tbNewUser)
        Me.gbDetallesRegistro.Controls.Add(Me.Label3)
        Me.gbDetallesRegistro.Controls.Add(Me.lbIdAsignada)
        Me.gbDetallesRegistro.Controls.Add(Me.Label2)
        Me.gbDetallesRegistro.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gbDetallesRegistro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbDetallesRegistro.Location = New System.Drawing.Point(105, 69)
        Me.gbDetallesRegistro.Name = "gbDetallesRegistro"
        Me.gbDetallesRegistro.Size = New System.Drawing.Size(648, 445)
        Me.gbDetallesRegistro.TabIndex = 1
        Me.gbDetallesRegistro.TabStop = False
        Me.gbDetallesRegistro.Text = "Proporciona tus datos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(6, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID asignada: "
        '
        'lbIdAsignada
        '
        Me.lbIdAsignada.AutoSize = True
        Me.lbIdAsignada.Location = New System.Drawing.Point(115, 61)
        Me.lbIdAsignada.Name = "lbIdAsignada"
        Me.lbIdAsignada.Size = New System.Drawing.Size(74, 26)
        Me.lbIdAsignada.TabIndex = 1
        Me.lbIdAsignada.Text = "Label3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre: "
        '
        'tbNewUser
        '
        Me.tbNewUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbNewUser.Location = New System.Drawing.Point(104, 124)
        Me.tbNewUser.Multiline = True
        Me.tbNewUser.Name = "tbNewUser"
        Me.tbNewUser.Size = New System.Drawing.Size(160, 34)
        Me.tbNewUser.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(327, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "User Name:"
        '
        'tbNewUserName
        '
        Me.tbNewUserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbNewUserName.Location = New System.Drawing.Point(448, 124)
        Me.tbNewUserName.Multiline = True
        Me.tbNewUserName.Name = "tbNewUserName"
        Me.tbNewUserName.Size = New System.Drawing.Size(180, 34)
        Me.tbNewUserName.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(0, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cédula ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(9, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 22)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Teléfono:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(379, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 22)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Pass:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(360, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 22)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Correo:"
        '
        'tbCedula
        '
        Me.tbCedula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbCedula.Location = New System.Drawing.Point(104, 194)
        Me.tbCedula.Multiline = True
        Me.tbCedula.Name = "tbCedula"
        Me.tbCedula.Size = New System.Drawing.Size(160, 34)
        Me.tbCedula.TabIndex = 10
        '
        'tbTelefono
        '
        Me.tbTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbTelefono.Location = New System.Drawing.Point(104, 261)
        Me.tbTelefono.Multiline = True
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(160, 34)
        Me.tbTelefono.TabIndex = 11
        '
        'tbPass
        '
        Me.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPass.Location = New System.Drawing.Point(448, 194)
        Me.tbPass.Multiline = True
        Me.tbPass.Name = "tbPass"
        Me.tbPass.Size = New System.Drawing.Size(180, 34)
        Me.tbPass.TabIndex = 12
        '
        'tbMail
        '
        Me.tbMail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbMail.Location = New System.Drawing.Point(448, 261)
        Me.tbMail.Multiline = True
        Me.tbMail.Name = "tbMail"
        Me.tbMail.Size = New System.Drawing.Size(180, 34)
        Me.tbMail.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Turquoise
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 4)
        Me.Panel1.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lime
        Me.Panel2.Location = New System.Drawing.Point(0, 318)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(648, 4)
        Me.Panel2.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(272, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 43)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "SIGN IN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(223, 393)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(187, 33)
        Me.ProgressBar1.TabIndex = 17
        '
        'Registrarse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(828, 562)
        Me.Controls.Add(Me.gbDetallesRegistro)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registrarse"
        Me.Text = "Registrarse"
        Me.gbDetallesRegistro.ResumeLayout(False)
        Me.gbDetallesRegistro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gbDetallesRegistro As GroupBox
    Friend WithEvents tbMail As TextBox
    Friend WithEvents tbPass As TextBox
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents tbCedula As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbNewUserName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbNewUser As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbIdAsignada As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
End Class
