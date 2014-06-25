<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Database1DataSet = New automoveis.Database1DataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New automoveis.Database1DataSetTableAdapters.clientesTableAdapter()
        Me.AutomóveisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutomóveisTableAdapter = New automoveis.Database1DataSetTableAdapters.AutomóveisTableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AlugueresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlugueresTableAdapter = New automoveis.Database1DataSetTableAdapters.alugueresTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.identificacao_do_automovel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.identificacao_do_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data_de_inicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data_de_fim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutomóveisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlugueresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ClientesBindingSource
        Me.ComboBox1.DisplayMember = "nome"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(91, 10)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(145, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "id"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.AutomóveisBindingSource
        Me.ComboBox2.DisplayMember = "marca"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(91, 37)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(145, 21)
        Me.ComboBox2.TabIndex = 2
        Me.ComboBox2.ValueMember = "id"
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.AutomóveisBindingSource
        Me.ComboBox3.DisplayMember = "modelo"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(91, 61)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(145, 21)
        Me.ComboBox3.TabIndex = 3
        Me.ComboBox3.ValueMember = "id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Modelo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Automóvel:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(258, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Data de inicio:"
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.Database1DataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'AutomóveisBindingSource
        '
        Me.AutomóveisBindingSource.DataMember = "Automóveis"
        Me.AutomóveisBindingSource.DataSource = Me.Database1DataSet
        '
        'AutomóveisTableAdapter
        '
        Me.AutomóveisTableAdapter.ClearBeforeFill = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(339, 7)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(154, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(261, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(380, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Cancel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.identificacao_do_automovel, Me.identificacao_do_cliente, Me.data_de_inicio, Me.data_de_fim})
        Me.DataGridView1.DataSource = Me.AlugueresBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(4, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(502, 147)
        Me.DataGridView1.TabIndex = 11
        '
        'AlugueresBindingSource
        '
        Me.AlugueresBindingSource.DataMember = "alugueres"
        Me.AlugueresBindingSource.DataSource = Me.Database1DataSet
        '
        'AlugueresTableAdapter
        '
        Me.AlugueresTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(284, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Data fim:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(339, 35)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(154, 20)
        Me.DateTimePicker2.TabIndex = 13
        '
        'ComboBox4
        '
        Me.ComboBox4.DataSource = Me.AutomóveisBindingSource
        Me.ComboBox4.DisplayMember = "cor"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(91, 85)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(145, 21)
        Me.ComboBox4.TabIndex = 14
        Me.ComboBox4.ValueMember = "id"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Cor:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Matricula:"
        '
        'ComboBox5
        '
        Me.ComboBox5.DataSource = Me.AutomóveisBindingSource
        Me.ComboBox5.DisplayMember = "matricula"
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(91, 109)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(145, 21)
        Me.ComboBox5.TabIndex = 17
        Me.ComboBox5.ValueMember = "id"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'identificacao_do_automovel
        '
        Me.identificacao_do_automovel.DataPropertyName = "identificacao_do_automovel"
        Me.identificacao_do_automovel.HeaderText = "identificacao_do_automovel"
        Me.identificacao_do_automovel.Name = "identificacao_do_automovel"
        '
        'identificacao_do_cliente
        '
        Me.identificacao_do_cliente.DataPropertyName = "identificacao_do_cliente"
        Me.identificacao_do_cliente.HeaderText = "identificacao_do_cliente"
        Me.identificacao_do_cliente.Name = "identificacao_do_cliente"
        '
        'data_de_inicio
        '
        Me.data_de_inicio.DataPropertyName = "data_de_inicio"
        Me.data_de_inicio.HeaderText = "data_de_inicio"
        Me.data_de_inicio.Name = "data_de_inicio"
        '
        'data_de_fim
        '
        Me.data_de_fim.DataPropertyName = "data_de_fim"
        Me.data_de_fim.HeaderText = "data_de_fim"
        Me.data_de_fim.Name = "data_de_fim"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 286)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Rent a Car :: Alugueres"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutomóveisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlugueresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Database1DataSet As automoveis.Database1DataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As automoveis.Database1DataSetTableAdapters.clientesTableAdapter
    Friend WithEvents AutomóveisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AutomóveisTableAdapter As automoveis.Database1DataSetTableAdapters.AutomóveisTableAdapter
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents AlugueresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlugueresTableAdapter As automoveis.Database1DataSetTableAdapters.alugueresTableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents identificacao_do_automovel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents identificacao_do_cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents data_de_inicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents data_de_fim As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
