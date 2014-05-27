<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultas2
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
        Dim ConsultaLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim PacienteLabel As System.Windows.Forms.Label
        Dim MédicoLabel As System.Windows.Forms.Label
        Me.ConsultasDataSet = New Projecto_Final.ConsultasDataSet
        Me.ConsultasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultasTableAdapter = New Projecto_Final.ConsultasDataSetTableAdapters.ConsultasTableAdapter
        Me.TableAdapterManager = New Projecto_Final.ConsultasDataSetTableAdapters.TableAdapterManager
        Me.ConsultaTextBox = New System.Windows.Forms.TextBox
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.PacienteComboBox = New System.Windows.Forms.ComboBox
        Me.MédicoComboBox = New System.Windows.Forms.ComboBox
        Me.ButtonAdicionar = New System.Windows.Forms.Button
        Me.ButtonAlterar = New System.Windows.Forms.Button
        ConsultaLabel = New System.Windows.Forms.Label
        DataLabel = New System.Windows.Forms.Label
        PacienteLabel = New System.Windows.Forms.Label
        MédicoLabel = New System.Windows.Forms.Label
        CType(Me.ConsultasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConsultasDataSet
        '
        Me.ConsultasDataSet.DataSetName = "ConsultasDataSet"
        Me.ConsultasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConsultasBindingSource
        '
        Me.ConsultasBindingSource.DataMember = "Consultas"
        Me.ConsultasBindingSource.DataSource = Me.ConsultasDataSet
        '
        'ConsultasTableAdapter
        '
        Me.ConsultasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ConsultasTableAdapter = Me.ConsultasTableAdapter
        Me.TableAdapterManager.DistritosTableAdapter = Nothing
        Me.TableAdapterManager.MédicosTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Projecto_Final.ConsultasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ConsultaLabel
        '
        ConsultaLabel.AutoSize = True
        ConsultaLabel.Location = New System.Drawing.Point(12, 22)
        ConsultaLabel.Name = "ConsultaLabel"
        ConsultaLabel.Size = New System.Drawing.Size(51, 13)
        ConsultaLabel.TabIndex = 1
        ConsultaLabel.Text = "Consulta:"
        '
        'ConsultaTextBox
        '
        Me.ConsultaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsultasBindingSource, "Consulta", True))
        Me.ConsultaTextBox.Location = New System.Drawing.Point(70, 19)
        Me.ConsultaTextBox.Name = "ConsultaTextBox"
        Me.ConsultaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ConsultaTextBox.TabIndex = 2
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(12, 49)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(33, 13)
        DataLabel.TabIndex = 3
        DataLabel.Text = "Data:"
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ConsultasBindingSource, "Data", True))
        Me.DataDateTimePicker.Location = New System.Drawing.Point(70, 45)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataDateTimePicker.TabIndex = 4
        '
        'PacienteLabel
        '
        PacienteLabel.AutoSize = True
        PacienteLabel.Location = New System.Drawing.Point(12, 74)
        PacienteLabel.Name = "PacienteLabel"
        PacienteLabel.Size = New System.Drawing.Size(52, 13)
        PacienteLabel.TabIndex = 5
        PacienteLabel.Text = "Paciente:"
        '
        'PacienteComboBox
        '
        Me.PacienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsultasBindingSource, "Paciente", True))
        Me.PacienteComboBox.FormattingEnabled = True
        Me.PacienteComboBox.Location = New System.Drawing.Point(70, 71)
        Me.PacienteComboBox.Name = "PacienteComboBox"
        Me.PacienteComboBox.Size = New System.Drawing.Size(200, 21)
        Me.PacienteComboBox.TabIndex = 6
        '
        'MédicoLabel
        '
        MédicoLabel.AutoSize = True
        MédicoLabel.Location = New System.Drawing.Point(12, 101)
        MédicoLabel.Name = "MédicoLabel"
        MédicoLabel.Size = New System.Drawing.Size(45, 13)
        MédicoLabel.TabIndex = 7
        MédicoLabel.Text = "Médico:"
        '
        'MédicoComboBox
        '
        Me.MédicoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsultasBindingSource, "Médico", True))
        Me.MédicoComboBox.FormattingEnabled = True
        Me.MédicoComboBox.Location = New System.Drawing.Point(70, 98)
        Me.MédicoComboBox.Name = "MédicoComboBox"
        Me.MédicoComboBox.Size = New System.Drawing.Size(200, 21)
        Me.MédicoComboBox.TabIndex = 8
        '
        'ButtonAdicionar
        '
        Me.ButtonAdicionar.Location = New System.Drawing.Point(60, 151)
        Me.ButtonAdicionar.Name = "ButtonAdicionar"
        Me.ButtonAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdicionar.TabIndex = 9
        Me.ButtonAdicionar.Text = "Adicionar"
        Me.ButtonAdicionar.UseVisualStyleBackColor = True
        '
        'ButtonAlterar
        '
        Me.ButtonAlterar.Location = New System.Drawing.Point(160, 151)
        Me.ButtonAlterar.Name = "ButtonAlterar"
        Me.ButtonAlterar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAlterar.TabIndex = 10
        Me.ButtonAlterar.Text = "Alterar"
        Me.ButtonAlterar.UseVisualStyleBackColor = True
        '
        'FormConsultas2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 202)
        Me.Controls.Add(Me.ButtonAlterar)
        Me.Controls.Add(Me.ButtonAdicionar)
        Me.Controls.Add(ConsultaLabel)
        Me.Controls.Add(Me.ConsultaTextBox)
        Me.Controls.Add(DataLabel)
        Me.Controls.Add(Me.DataDateTimePicker)
        Me.Controls.Add(PacienteLabel)
        Me.Controls.Add(Me.PacienteComboBox)
        Me.Controls.Add(MédicoLabel)
        Me.Controls.Add(Me.MédicoComboBox)
        Me.Name = "FormConsultas2"
        Me.Text = "FormConsultas2"
        CType(Me.ConsultasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConsultasDataSet As Projecto_Final.ConsultasDataSet
    Friend WithEvents ConsultasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConsultasTableAdapter As Projecto_Final.ConsultasDataSetTableAdapters.ConsultasTableAdapter
    Friend WithEvents TableAdapterManager As Projecto_Final.ConsultasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ConsultaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PacienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MédicoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonAdicionar As System.Windows.Forms.Button
    Friend WithEvents ButtonAlterar As System.Windows.Forms.Button
End Class
