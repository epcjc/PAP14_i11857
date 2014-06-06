<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MédicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarPermiçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MédicosToolStripMenuItem, Me.PacientesToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1087, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MédicosToolStripMenuItem
        '
        Me.MédicosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaToolStripMenuItem, Me.AdicionarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MédicosToolStripMenuItem.Name = "MédicosToolStripMenuItem"
        Me.MédicosToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.MédicosToolStripMenuItem.Text = "Noticias"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ConsultaToolStripMenuItem.Text = "Consultar"
        '
        'AdicionarToolStripMenuItem
        '
        Me.AdicionarToolStripMenuItem.Name = "AdicionarToolStripMenuItem"
        Me.AdicionarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AdicionarToolStripMenuItem.Text = "Adicionar "
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'PacientesToolStripMenuItem
        '
        Me.PacientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem, Me.AdicionarToolStripMenuItem1, Me.AlterarPermiçõesToolStripMenuItem, Me.EliminarToolStripMenuItem1})
        Me.PacientesToolStripMenuItem.Name = "PacientesToolStripMenuItem"
        Me.PacientesToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.PacientesToolStripMenuItem.Text = "Utilizadores"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'AdicionarToolStripMenuItem1
        '
        Me.AdicionarToolStripMenuItem1.Name = "AdicionarToolStripMenuItem1"
        Me.AdicionarToolStripMenuItem1.Size = New System.Drawing.Size(167, 22)
        Me.AdicionarToolStripMenuItem1.Text = "Adicionar"
        '
        'AlterarPermiçõesToolStripMenuItem
        '
        Me.AlterarPermiçõesToolStripMenuItem.Name = "AlterarPermiçõesToolStripMenuItem"
        Me.AlterarPermiçõesToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AlterarPermiçõesToolStripMenuItem.Text = "Alterar Permições"
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(167, 22)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem1, Me.AdicionarToolStripMenuItem2, Me.EliminarToolStripMenuItem2})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.ConsultasToolStripMenuItem.Text = "Comentarios"
        '
        'ConsultarToolStripMenuItem1
        '
        Me.ConsultarToolStripMenuItem1.Name = "ConsultarToolStripMenuItem1"
        Me.ConsultarToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ConsultarToolStripMenuItem1.Text = "Consultar"
        '
        'AdicionarToolStripMenuItem2
        '
        Me.AdicionarToolStripMenuItem2.Name = "AdicionarToolStripMenuItem2"
        Me.AdicionarToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.AdicionarToolStripMenuItem2.Text = "Adicionar"
        '
        'EliminarToolStripMenuItem2
        '
        Me.EliminarToolStripMenuItem2.Name = "EliminarToolStripMenuItem2"
        Me.EliminarToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.EliminarToolStripMenuItem2.Text = "Eliminar"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 505)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1087, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1087, 481)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 527)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Projecto"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MédicosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PacientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdicionarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdicionarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdicionarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterarPermiçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
