<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPacientes2
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
        Me.components = New System.ComponentModel.Container
        Dim NomeLabel As System.Windows.Forms.Label
        Dim DistritoLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim Data_NascimentoLabel As System.Windows.Forms.Label
        Me.ConsultasDataSet = New Projecto_Final.ConsultasDataSet
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesTableAdapter = New Projecto_Final.ConsultasDataSetTableAdapters.PacientesTableAdapter
        Me.TableAdapterManager = New Projecto_Final.ConsultasDataSetTableAdapters.TableAdapterManager
        Me.NomeTextBox = New System.Windows.Forms.TextBox
        Me.DistritoComboBox = New System.Windows.Forms.ComboBox
        Me.SexoComboBox = New System.Windows.Forms.ComboBox
        Me.Data_NascimentoDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.ButtonAdicionar = New System.Windows.Forms.Button
        Me.ButtonAlterar = New System.Windows.Forms.Button
        NomeLabel = New System.Windows.Forms.Label
        DistritoLabel = New System.Windows.Forms.Label
        SexoLabel = New System.Windows.Forms.Label
        Data_NascimentoLabel = New System.Windows.Forms.Label
        CType(Me.ConsultasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConsultasDataSet
        '
        Me.ConsultasDataSet.DataSetName = "ConsultasDataSet"
        Me.ConsultasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PacientesBindingSource
        '
        Me.PacientesBindingSource.DataMember = "Pacientes"
        Me.PacientesBindingSource.DataSource = Me.ConsultasDataSet
        '
        'PacientesTableAdapter
        '
        Me.PacientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ConsultasTableAdapter = Nothing
        Me.TableAdapterManager.DistritosTableAdapter = Nothing
        Me.TableAdapterManager.MédicosTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Me.PacientesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Projecto_Final.ConsultasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(18, 33)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(116, 30)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'DistritoLabel
        '
        DistritoLabel.AutoSize = True
        DistritoLabel.Location = New System.Drawing.Point(18, 59)
        DistritoLabel.Name = "DistritoLabel"
        DistritoLabel.Size = New System.Drawing.Size(42, 13)
        DistritoLabel.TabIndex = 5
        DistritoLabel.Text = "Distrito:"
        '
        'DistritoComboBox
        '
        Me.DistritoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Distrito", True))
        Me.DistritoComboBox.FormattingEnabled = True
        Me.DistritoComboBox.Location = New System.Drawing.Point(116, 56)
        Me.DistritoComboBox.Name = "DistritoComboBox"
        Me.DistritoComboBox.Size = New System.Drawing.Size(200, 21)
        Me.DistritoComboBox.TabIndex = 6
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Location = New System.Drawing.Point(18, 86)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(34, 13)
        SexoLabel.TabIndex = 7
        SexoLabel.Text = "Sexo:"
        '
        'SexoComboBox
        '
        Me.SexoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Sexo", True))
        Me.SexoComboBox.FormattingEnabled = True
        Me.SexoComboBox.Location = New System.Drawing.Point(116, 83)
        Me.SexoComboBox.Name = "SexoComboBox"
        Me.SexoComboBox.Size = New System.Drawing.Size(200, 21)
        Me.SexoComboBox.TabIndex = 8
        '
        'Data_NascimentoLabel
        '
        Data_NascimentoLabel.AutoSize = True
        Data_NascimentoLabel.Location = New System.Drawing.Point(18, 114)
        Data_NascimentoLabel.Name = "Data_NascimentoLabel"
        Data_NascimentoLabel.Size = New System.Drawing.Size(92, 13)
        Data_NascimentoLabel.TabIndex = 9
        Data_NascimentoLabel.Text = "Data Nascimento:"
        '
        'Data_NascimentoDateTimePicker
        '
        Me.Data_NascimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PacientesBindingSource, "Data_Nascimento", True))
        Me.Data_NascimentoDateTimePicker.Location = New System.Drawing.Point(116, 110)
        Me.Data_NascimentoDateTimePicker.Name = "Data_NascimentoDateTimePicker"
        Me.Data_NascimentoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Data_NascimentoDateTimePicker.TabIndex = 10
        '
        'ButtonAdicionar
        '
        Me.ButtonAdicionar.Location = New System.Drawing.Point(66, 156)
        Me.ButtonAdicionar.Name = "ButtonAdicionar"
        Me.ButtonAdicionar.Size = New System.Drawing.Size(85, 30)
        Me.ButtonAdicionar.TabIndex = 11
        Me.ButtonAdicionar.Text = "Adicionar"
        Me.ButtonAdicionar.UseVisualStyleBackColor = True
        '
        'ButtonAlterar
        '
        Me.ButtonAlterar.Location = New System.Drawing.Point(179, 156)
        Me.ButtonAlterar.Name = "ButtonAlterar"
        Me.ButtonAlterar.Size = New System.Drawing.Size(85, 30)
        Me.ButtonAlterar.TabIndex = 12
        Me.ButtonAlterar.Text = "Alterar"
        Me.ButtonAlterar.UseVisualStyleBackColor = True
        '
        'FormPacientes2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 270)
        Me.Controls.Add(Me.ButtonAlterar)
        Me.Controls.Add(Me.ButtonAdicionar)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(DistritoLabel)
        Me.Controls.Add(Me.DistritoComboBox)
        Me.Controls.Add(SexoLabel)
        Me.Controls.Add(Me.SexoComboBox)
        Me.Controls.Add(Data_NascimentoLabel)
        Me.Controls.Add(Me.Data_NascimentoDateTimePicker)
        Me.Name = "FormPacientes2"
        Me.Text = "FormPacientes2"
        CType(Me.ConsultasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConsultasDataSet As Projecto_Final.ConsultasDataSet
    Friend WithEvents PacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PacientesTableAdapter As Projecto_Final.ConsultasDataSetTableAdapters.PacientesTableAdapter
    Friend WithEvents TableAdapterManager As Projecto_Final.ConsultasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DistritoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SexoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Data_NascimentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonAdicionar As System.Windows.Forms.Button
    Friend WithEvents ButtonAlterar As System.Windows.Forms.Button
End Class
