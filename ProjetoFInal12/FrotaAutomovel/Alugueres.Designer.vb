<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alugueres
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New FrotaAutomovel.Database1DataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClientesTableAdapter = New FrotaAutomovel.Database1DataSetTableAdapters.ClientesTableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.AutomoveisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AlugueresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlugueresTableAdapter = New FrotaAutomovel.Database1DataSetTableAdapters.AlugueresTableAdapter()
        Me.AutomoveisTableAdapter = New FrotaAutomovel.Database1DataSetTableAdapters.AutomoveisTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CilindradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnoDeAquisiçaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatriculaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutomoveisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlugueresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ClientesBindingSource
        Me.ComboBox1.DisplayMember = "Nome"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(313, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "ID"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.Database1DataSetBindingSource
        '
        'Database1DataSetBindingSource
        '
        Me.Database1DataSetBindingSource.DataSource = Me.Database1DataSet
        Me.Database1DataSetBindingSource.Position = 0
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(265, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente:"
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.AutomoveisBindingSource
        Me.ComboBox2.DisplayMember = "Marca"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(313, 51)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 2
        Me.ComboBox2.ValueMember = "ID"
        '
        'AutomoveisBindingSource
        '
        Me.AutomoveisBindingSource.DataMember = "Automoveis"
        Me.AutomoveisBindingSource.DataSource = Me.Database1DataSet
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.AutomoveisBindingSource
        Me.ComboBox3.DisplayMember = "Modelo"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(313, 79)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 3
        Me.ComboBox3.ValueMember = "Modelo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Automovel:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Modelo:"
        '
        'AlugueresBindingSource
        '
        Me.AlugueresBindingSource.DataMember = "Alugueres"
        Me.AlugueresBindingSource.DataSource = Me.Database1DataSet
        '
        'AlugueresTableAdapter
        '
        Me.AlugueresTableAdapter.ClearBeforeFill = True
        '
        'AutomoveisTableAdapter
        '
        Me.AutomoveisTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MarcaDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.CorDataGridViewTextBoxColumn, Me.CilindradaDataGridViewTextBoxColumn, Me.AnoDeAquisiçaoDataGridViewTextBoxColumn, Me.MatriculaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AutomoveisBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 151)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(625, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CorDataGridViewTextBoxColumn
        '
        Me.CorDataGridViewTextBoxColumn.DataPropertyName = "Cor"
        Me.CorDataGridViewTextBoxColumn.HeaderText = "Cor"
        Me.CorDataGridViewTextBoxColumn.Name = "CorDataGridViewTextBoxColumn"
        Me.CorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CilindradaDataGridViewTextBoxColumn
        '
        Me.CilindradaDataGridViewTextBoxColumn.DataPropertyName = "Cilindrada"
        Me.CilindradaDataGridViewTextBoxColumn.HeaderText = "Cilindrada"
        Me.CilindradaDataGridViewTextBoxColumn.Name = "CilindradaDataGridViewTextBoxColumn"
        Me.CilindradaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnoDeAquisiçaoDataGridViewTextBoxColumn
        '
        Me.AnoDeAquisiçaoDataGridViewTextBoxColumn.DataPropertyName = "Ano de Aquisiçao"
        Me.AnoDeAquisiçaoDataGridViewTextBoxColumn.HeaderText = "Ano de Aquisiçao"
        Me.AnoDeAquisiçaoDataGridViewTextBoxColumn.Name = "AnoDeAquisiçaoDataGridViewTextBoxColumn"
        Me.AnoDeAquisiçaoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MatriculaDataGridViewTextBoxColumn
        '
        Me.MatriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula"
        Me.MatriculaDataGridViewTextBoxColumn.HeaderText = "Matricula"
        Me.MatriculaDataGridViewTextBoxColumn.Name = "MatriculaDataGridViewTextBoxColumn"
        Me.MatriculaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(152, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Data de Inicio:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(234, 112)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(426, 324)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 19)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Inserir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Alugueres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 348)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Alugueres"
        Me.Text = "Alugueres"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutomoveisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlugueresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Database1DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Database1DataSet As FrotaAutomovel.Database1DataSet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As FrotaAutomovel.Database1DataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AlugueresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlugueresTableAdapter As FrotaAutomovel.Database1DataSetTableAdapters.AlugueresTableAdapter
    Friend WithEvents AutomoveisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AutomoveisTableAdapter As FrotaAutomovel.Database1DataSetTableAdapters.AutomoveisTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MarcaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CilindradaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnoDeAquisiçaoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatriculaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
