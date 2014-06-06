<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adicionarcliente
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
        Dim ContribuinteLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim DistritoLabel As System.Windows.Forms.Label
        Me.ConsultasDataSet = New Projecto_Final.ConsultasDataSet
        Me.MédicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MédicosTableAdapter = New Projecto_Final.ConsultasDataSetTableAdapters.MédicosTableAdapter
        Me.TableAdapterManager = New Projecto_Final.ConsultasDataSetTableAdapters.TableAdapterManager
        Me.ContribuinteMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.NomeTextBox = New System.Windows.Forms.TextBox
        Me.DistritoComboBox = New System.Windows.Forms.ComboBox
        Me.ButtonAdicionar = New System.Windows.Forms.Button
        Me.ButtonAlterar = New System.Windows.Forms.Button
        ContribuinteLabel = New System.Windows.Forms.Label
        NomeLabel = New System.Windows.Forms.Label
        DistritoLabel = New System.Windows.Forms.Label
        CType(Me.ConsultasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MédicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConsultasDataSet
        '
        Me.ConsultasDataSet.DataSetName = "ConsultasDataSet"
        Me.ConsultasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MédicosBindingSource
        '
        Me.MédicosBindingSource.DataMember = "Médicos"
        Me.MédicosBindingSource.DataSource = Me.ConsultasDataSet
        '
        'MédicosTableAdapter
        '
        Me.MédicosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ConsultasTableAdapter = Nothing
        Me.TableAdapterManager.DistritosTableAdapter = Nothing
        Me.TableAdapterManager.MédicosTableAdapter = Me.MédicosTableAdapter
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Projecto_Final.ConsultasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ContribuinteLabel
        '
        ContribuinteLabel.AutoSize = True
        ContribuinteLabel.Location = New System.Drawing.Point(23, 18)
        ContribuinteLabel.Name = "ContribuinteLabel"
        ContribuinteLabel.Size = New System.Drawing.Size(66, 13)
        ContribuinteLabel.TabIndex = 1
        ContribuinteLabel.Text = "Contribuinte:"
        '
        'ContribuinteMaskedTextBox
        '
        Me.ContribuinteMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MédicosBindingSource, "Contribuinte", True))
        Me.ContribuinteMaskedTextBox.Location = New System.Drawing.Point(95, 15)
        Me.ContribuinteMaskedTextBox.Name = "ContribuinteMaskedTextBox"
        Me.ContribuinteMaskedTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ContribuinteMaskedTextBox.TabIndex = 2
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(23, 44)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MédicosBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(95, 41)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(121, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'DistritoLabel
        '
        DistritoLabel.AutoSize = True
        DistritoLabel.Location = New System.Drawing.Point(23, 70)
        DistritoLabel.Name = "DistritoLabel"
        DistritoLabel.Size = New System.Drawing.Size(42, 13)
        DistritoLabel.TabIndex = 5
        DistritoLabel.Text = "Distrito:"
        '
        'DistritoComboBox
        '
        Me.DistritoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MédicosBindingSource, "Distrito", True))
        Me.DistritoComboBox.FormattingEnabled = True
        Me.DistritoComboBox.Location = New System.Drawing.Point(95, 67)
        Me.DistritoComboBox.Name = "DistritoComboBox"
        Me.DistritoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DistritoComboBox.TabIndex = 6
        '
        'ButtonAdicionar
        '
        Me.ButtonAdicionar.Location = New System.Drawing.Point(35, 127)
        Me.ButtonAdicionar.Name = "ButtonAdicionar"
        Me.ButtonAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdicionar.TabIndex = 7
        Me.ButtonAdicionar.Text = "Adicionar"
        Me.ButtonAdicionar.UseVisualStyleBackColor = True
        '
        'ButtonAlterar
        '
        Me.ButtonAlterar.Location = New System.Drawing.Point(125, 127)
        Me.ButtonAlterar.Name = "ButtonAlterar"
        Me.ButtonAlterar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAlterar.TabIndex = 8
        Me.ButtonAlterar.Text = "Alterar"
        Me.ButtonAlterar.UseVisualStyleBackColor = True
        '
        'FormMédicos2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 188)
        Me.Controls.Add(Me.ButtonAlterar)
        Me.Controls.Add(Me.ButtonAdicionar)
        Me.Controls.Add(ContribuinteLabel)
        Me.Controls.Add(Me.ContribuinteMaskedTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(DistritoLabel)
        Me.Controls.Add(Me.DistritoComboBox)
        Me.Name = "FormMédicos2"
        Me.Text = "FormMédicos2"
        CType(Me.ConsultasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MédicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConsultasDataSet As Projecto_Final.ConsultasDataSet
    Friend WithEvents MédicosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MédicosTableAdapter As Projecto_Final.ConsultasDataSetTableAdapters.MédicosTableAdapter
    Friend WithEvents TableAdapterManager As Projecto_Final.ConsultasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ContribuinteMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DistritoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonAdicionar As System.Windows.Forms.Button
    Friend WithEvents ButtonAlterar As System.Windows.Forms.Button
End Class
