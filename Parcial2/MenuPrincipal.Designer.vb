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
        Me.BtnMax = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BibliotecaArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarLibroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarTodoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Version55ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NosotrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Border.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MovForm.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
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
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MovForm, 0, 0)
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
        Me.MovForm.ColumnCount = 5
        Me.MovForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.MovForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MovForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.MovForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.MovForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.MovForm.Controls.Add(Me.Label1, 0, 0)
        Me.MovForm.Controls.Add(Me.BtnMin, 2, 0)
        Me.MovForm.Controls.Add(Me.BtnMax, 3, 0)
        Me.MovForm.Controls.Add(Me.BtnClose, 4, 0)
        Me.MovForm.Controls.Add(Me.MenuStrip1, 1, 0)
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
        Me.Label1.BackColor = System.Drawing.Color.Blue
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
        Me.BtnMin.BackColor = System.Drawing.Color.Blue
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
        'BtnMax
        '
        Me.BtnMax.BackColor = System.Drawing.Color.Blue
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
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Blue
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
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Blue
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BibliotecaArchivosToolStripMenuItem, Me.NosotrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(110, 0)
        Me.MenuStrip1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.MenuStrip1.Size = New System.Drawing.Size(164, 30)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BibliotecaArchivosToolStripMenuItem
        '
        Me.BibliotecaArchivosToolStripMenuItem.BackColor = System.Drawing.Color.Blue
        Me.BibliotecaArchivosToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BibliotecaArchivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerLibrosToolStripMenuItem, Me.VerMenuToolStripMenuItem, Me.CerrarTodoToolStripMenuItem1, Me.Version55ToolStripMenuItem})
        Me.BibliotecaArchivosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BibliotecaArchivosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BibliotecaArchivosToolStripMenuItem.Name = "BibliotecaArchivosToolStripMenuItem"
        Me.BibliotecaArchivosToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.BibliotecaArchivosToolStripMenuItem.Size = New System.Drawing.Size(80, 28)
        Me.BibliotecaArchivosToolStripMenuItem.Text = "Biblioteca"
        '
        'VerLibrosToolStripMenuItem
        '
        Me.VerLibrosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VerLibrosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VerLibrosToolStripMenuItem.Name = "VerLibrosToolStripMenuItem"
        Me.VerLibrosToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.VerLibrosToolStripMenuItem.Text = "Ver Libros"
        '
        'VerMenuToolStripMenuItem
        '
        Me.VerMenuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VerMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.AgregarLibroToolStripMenuItem, Me.EliminarLibrosToolStripMenuItem})
        Me.VerMenuToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VerMenuToolStripMenuItem.Name = "VerMenuToolStripMenuItem"
        Me.VerMenuToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.VerMenuToolStripMenuItem.Text = "Opciones"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'AgregarLibroToolStripMenuItem
        '
        Me.AgregarLibroToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AgregarLibroToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AgregarLibroToolStripMenuItem.Name = "AgregarLibroToolStripMenuItem"
        Me.AgregarLibroToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
        Me.AgregarLibroToolStripMenuItem.Text = "Agregar Libros"
        '
        'EliminarLibrosToolStripMenuItem
        '
        Me.EliminarLibrosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EliminarLibrosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EliminarLibrosToolStripMenuItem.Name = "EliminarLibrosToolStripMenuItem"
        Me.EliminarLibrosToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
        Me.EliminarLibrosToolStripMenuItem.Text = "Eliminar Libros"
        '
        'CerrarTodoToolStripMenuItem1
        '
        Me.CerrarTodoToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CerrarTodoToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.CerrarTodoToolStripMenuItem1.Name = "CerrarTodoToolStripMenuItem1"
        Me.CerrarTodoToolStripMenuItem1.Size = New System.Drawing.Size(180, 24)
        Me.CerrarTodoToolStripMenuItem1.Text = "Cerrar Todo"
        '
        'Version55ToolStripMenuItem
        '
        Me.Version55ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Version55ToolStripMenuItem.Enabled = False
        Me.Version55ToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.Version55ToolStripMenuItem.Name = "Version55ToolStripMenuItem"
        Me.Version55ToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.Version55ToolStripMenuItem.Text = "Version 5.5"
        '
        'NosotrosToolStripMenuItem
        '
        Me.NosotrosToolStripMenuItem.BackColor = System.Drawing.Color.Blue
        Me.NosotrosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NosotrosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.NosotrosToolStripMenuItem.Name = "NosotrosToolStripMenuItem"
        Me.NosotrosToolStripMenuItem.Size = New System.Drawing.Size(82, 28)
        Me.NosotrosToolStripMenuItem.Text = "Nosotros"
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Border As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MovForm As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BibliotecaArchivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnMin As Button
    Friend WithEvents BtnMax As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents NosotrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarLibroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarLibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerLibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarTodoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Version55ToolStripMenuItem As ToolStripMenuItem
End Class
