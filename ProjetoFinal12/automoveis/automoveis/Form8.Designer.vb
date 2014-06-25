<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Database1DataSet = New automoveis.Database1DataSet()
        Me.AutomóveisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutomóveisTableAdapter = New automoveis.Database1DataSetTableAdapters.AutomóveisTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AutomóveisBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutomóveisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutomóveisBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.AutomóveisBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "automoveis.Report4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, 37)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(542, 281)
        Me.ReportViewer1.TabIndex = 0
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.AutomóveisBindingSource1
        Me.ComboBox1.DisplayMember = "marca"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(59, 10)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "id"
        '
        'AutomóveisBindingSource1
        '
        Me.AutomóveisBindingSource1.DataMember = "Automóveis"
        Me.AutomóveisBindingSource1.DataSource = Me.Database1DataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Marca:"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 314)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form8"
        Me.Text = "Rent a Car :: Relatórios"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutomóveisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutomóveisBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AutomóveisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Database1DataSet As automoveis.Database1DataSet
    Friend WithEvents AutomóveisTableAdapter As automoveis.Database1DataSetTableAdapters.AutomóveisTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents AutomóveisBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
