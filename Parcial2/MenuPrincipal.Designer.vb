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
        Me.NosotrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.LoginToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnMax = New System.Windows.Forms.Button()
        Me.MenuLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Border.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MovForm.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.SuspendLayout()
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
        Me.TableLayoutPanel1.Controls.Add(Me.SplitContainer1, 0, 1)
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
        Me.Label1.Size = New System.Drawing.Size(78, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "    DK - CODE"
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.NosotrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(110, 0)
        Me.MenuStrip1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.MenuStrip1.Size = New System.Drawing.Size(141, 30)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.InicioToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.InicioToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(57, 28)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.CerrarSessionToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.CerrarSessionToolStripMenuItem.Text = "Cerrar Session"
        '
        'IniciarSessionToolStripMenuItem
        '
        Me.IniciarSessionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IniciarSessionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.IniciarSessionToolStripMenuItem.Name = "IniciarSessionToolStripMenuItem"
        Me.IniciarSessionToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
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
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 32)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Size = New System.Drawing.Size(916, 464)
        Me.SplitContainer1.SplitterDistance = 305
        Me.SplitContainer1.TabIndex = 1
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
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
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
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
    Friend WithEvents SplitContainer1 As SplitContainer
End Class
