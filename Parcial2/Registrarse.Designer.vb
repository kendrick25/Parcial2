<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registrarse
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrarse))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbDetallesRegistro = New System.Windows.Forms.GroupBox()
        Me.faltante6 = New System.Windows.Forms.Label()
        Me.faltante5 = New System.Windows.Forms.Label()
        Me.faltante4 = New System.Windows.Forms.Label()
        Me.faltante3 = New System.Windows.Forms.Label()
        Me.faltante2 = New System.Windows.Forms.Label()
        Me.faltante1 = New System.Windows.Forms.Label()
        Me.btMostrarVer = New System.Windows.Forms.Button()
        Me.bnCancelRegistro = New System.Windows.Forms.Button()
        Me.carga = New System.Windows.Forms.ProgressBar()
        Me.btAgregarNew = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbMail = New System.Windows.Forms.TextBox()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.tbCedula = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbNewUserName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNewUser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbIdAsignada = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbDetallesRegistro.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gbDetallesRegistro.Controls.Add(Me.PictureBox1)
        Me.gbDetallesRegistro.Controls.Add(Me.faltante6)
        Me.gbDetallesRegistro.Controls.Add(Me.faltante5)
        Me.gbDetallesRegistro.Controls.Add(Me.faltante4)
        Me.gbDetallesRegistro.Controls.Add(Me.faltante3)
        Me.gbDetallesRegistro.Controls.Add(Me.faltante2)
        Me.gbDetallesRegistro.Controls.Add(Me.faltante1)
        Me.gbDetallesRegistro.Controls.Add(Me.btMostrarVer)
        Me.gbDetallesRegistro.Controls.Add(Me.bnCancelRegistro)
        Me.gbDetallesRegistro.Controls.Add(Me.carga)
        Me.gbDetallesRegistro.Controls.Add(Me.btAgregarNew)
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
        Me.gbDetallesRegistro.Location = New System.Drawing.Point(77, 69)
        Me.gbDetallesRegistro.Name = "gbDetallesRegistro"
        Me.gbDetallesRegistro.Size = New System.Drawing.Size(704, 445)
        Me.gbDetallesRegistro.TabIndex = 1
        Me.gbDetallesRegistro.TabStop = False
        Me.gbDetallesRegistro.Text = "Proporciona tus datos"
        '
        'faltante6
        '
        Me.faltante6.AutoSize = True
        Me.faltante6.ForeColor = System.Drawing.Color.Yellow
        Me.faltante6.Location = New System.Drawing.Point(644, 266)
        Me.faltante6.Name = "faltante6"
        Me.faltante6.Size = New System.Drawing.Size(21, 26)
        Me.faltante6.TabIndex = 25
        Me.faltante6.Text = "*"
        '
        'faltante5
        '
        Me.faltante5.AutoSize = True
        Me.faltante5.ForeColor = System.Drawing.Color.Yellow
        Me.faltante5.Location = New System.Drawing.Point(362, 199)
        Me.faltante5.Name = "faltante5"
        Me.faltante5.Size = New System.Drawing.Size(21, 26)
        Me.faltante5.TabIndex = 24
        Me.faltante5.Text = "*"
        '
        'faltante4
        '
        Me.faltante4.AutoSize = True
        Me.faltante4.ForeColor = System.Drawing.Color.Yellow
        Me.faltante4.Location = New System.Drawing.Point(644, 129)
        Me.faltante4.Name = "faltante4"
        Me.faltante4.Size = New System.Drawing.Size(21, 26)
        Me.faltante4.TabIndex = 23
        Me.faltante4.Text = "*"
        '
        'faltante3
        '
        Me.faltante3.AutoSize = True
        Me.faltante3.ForeColor = System.Drawing.Color.Yellow
        Me.faltante3.Location = New System.Drawing.Point(10, 266)
        Me.faltante3.Name = "faltante3"
        Me.faltante3.Size = New System.Drawing.Size(21, 26)
        Me.faltante3.TabIndex = 22
        Me.faltante3.Text = "*"
        '
        'faltante2
        '
        Me.faltante2.AutoSize = True
        Me.faltante2.ForeColor = System.Drawing.Color.Yellow
        Me.faltante2.Location = New System.Drawing.Point(10, 199)
        Me.faltante2.Name = "faltante2"
        Me.faltante2.Size = New System.Drawing.Size(21, 26)
        Me.faltante2.TabIndex = 21
        Me.faltante2.Text = "*"
        '
        'faltante1
        '
        Me.faltante1.AutoSize = True
        Me.faltante1.ForeColor = System.Drawing.Color.Yellow
        Me.faltante1.Location = New System.Drawing.Point(10, 129)
        Me.faltante1.Name = "faltante1"
        Me.faltante1.Size = New System.Drawing.Size(21, 26)
        Me.faltante1.TabIndex = 20
        Me.faltante1.Text = "*"
        '
        'btMostrarVer
        '
        Me.btMostrarVer.BackColor = System.Drawing.Color.White
        Me.btMostrarVer.BackgroundImage = CType(resources.GetObject("btMostrarVer.BackgroundImage"), System.Drawing.Image)
        Me.btMostrarVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btMostrarVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btMostrarVer.ForeColor = System.Drawing.Color.White
        Me.btMostrarVer.Location = New System.Drawing.Point(644, 192)
        Me.btMostrarVer.Name = "btMostrarVer"
        Me.btMostrarVer.Size = New System.Drawing.Size(31, 30)
        Me.btMostrarVer.TabIndex = 19
        Me.btMostrarVer.UseVisualStyleBackColor = False
        '
        'bnCancelRegistro
        '
        Me.bnCancelRegistro.BackColor = System.Drawing.Color.HotPink
        Me.bnCancelRegistro.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bnCancelRegistro.ForeColor = System.Drawing.Color.Black
        Me.bnCancelRegistro.Location = New System.Drawing.Point(28, 363)
        Me.bnCancelRegistro.Name = "bnCancelRegistro"
        Me.bnCancelRegistro.Size = New System.Drawing.Size(120, 43)
        Me.bnCancelRegistro.TabIndex = 18
        Me.bnCancelRegistro.Text = "CANCEL"
        Me.bnCancelRegistro.UseVisualStyleBackColor = False
        '
        'carga
        '
        Me.carga.Location = New System.Drawing.Point(488, 394)
        Me.carga.Name = "carga"
        Me.carga.Size = New System.Drawing.Size(187, 33)
        Me.carga.TabIndex = 17
        '
        'btAgregarNew
        '
        Me.btAgregarNew.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btAgregarNew.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btAgregarNew.ForeColor = System.Drawing.Color.Black
        Me.btAgregarNew.Location = New System.Drawing.Point(581, 345)
        Me.btAgregarNew.Name = "btAgregarNew"
        Me.btAgregarNew.Size = New System.Drawing.Size(67, 43)
        Me.btAgregarNew.TabIndex = 16
        Me.btAgregarNew.Text = "NEXT"
        Me.btAgregarNew.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lime
        Me.Panel2.Location = New System.Drawing.Point(0, 318)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(648, 4)
        Me.Panel2.TabIndex = 15
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
        'tbMail
        '
        Me.tbMail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbMail.Location = New System.Drawing.Point(458, 261)
        Me.tbMail.Multiline = True
        Me.tbMail.Name = "tbMail"
        Me.tbMail.Size = New System.Drawing.Size(180, 34)
        Me.tbMail.TabIndex = 13
        '
        'tbPass
        '
        Me.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPass.Location = New System.Drawing.Point(458, 194)
        Me.tbPass.Name = "tbPass"
        Me.tbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPass.Size = New System.Drawing.Size(180, 26)
        Me.tbPass.TabIndex = 12
        '
        'tbTelefono
        '
        Me.tbTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbTelefono.Location = New System.Drawing.Point(132, 261)
        Me.tbTelefono.Multiline = True
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(160, 34)
        Me.tbTelefono.TabIndex = 11
        '
        'tbCedula
        '
        Me.tbCedula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbCedula.Location = New System.Drawing.Point(132, 194)
        Me.tbCedula.Multiline = True
        Me.tbCedula.Name = "tbCedula"
        Me.tbCedula.Size = New System.Drawing.Size(160, 34)
        Me.tbCedula.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(370, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 22)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Correo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(389, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 22)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Pass:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(37, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 22)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Teléfono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(28, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cédula ID:"
        '
        'tbNewUserName
        '
        Me.tbNewUserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbNewUserName.Location = New System.Drawing.Point(458, 124)
        Me.tbNewUserName.Multiline = True
        Me.tbNewUserName.Name = "tbNewUserName"
        Me.tbNewUserName.Size = New System.Drawing.Size(180, 34)
        Me.tbNewUserName.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(337, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "User Name:"
        '
        'tbNewUser
        '
        Me.tbNewUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbNewUser.Location = New System.Drawing.Point(132, 124)
        Me.tbNewUser.Multiline = True
        Me.tbNewUser.Name = "tbNewUser"
        Me.tbNewUser.Size = New System.Drawing.Size(160, 34)
        Me.tbNewUser.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(37, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre: "
        '
        'lbIdAsignada
        '
        Me.lbIdAsignada.AutoSize = True
        Me.lbIdAsignada.Location = New System.Drawing.Point(157, 56)
        Me.lbIdAsignada.Name = "lbIdAsignada"
        Me.lbIdAsignada.Size = New System.Drawing.Size(74, 26)
        Me.lbIdAsignada.TabIndex = 1
        Me.lbIdAsignada.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(37, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID asignada: "
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(523, 345)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Registrarse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(828, 562)
        Me.Controls.Add(Me.gbDetallesRegistro)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registrarse"
        Me.Text = "Registrarse"
        Me.gbDetallesRegistro.ResumeLayout(False)
        Me.gbDetallesRegistro.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents carga As ProgressBar
    Friend WithEvents btAgregarNew As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents bnCancelRegistro As Button
    Friend WithEvents btMostrarVer As Button
    Friend WithEvents faltante2 As Label
    Friend WithEvents faltante1 As Label
    Friend WithEvents faltante3 As Label
    Friend WithEvents faltante4 As Label
    Friend WithEvents faltante6 As Label
    Friend WithEvents faltante5 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
