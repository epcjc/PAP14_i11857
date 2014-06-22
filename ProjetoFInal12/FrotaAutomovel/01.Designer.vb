<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _01
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
        Me.AutomoveisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New FrotaAutomovel.Database1DataSet()
        Me.AutomoveisTableAdapter = New FrotaAutomovel.Database1DataSetTableAdapters.AutomoveisTableAdapter()
        Me.Automoveis1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Automoveis1TableAdapter = New FrotaAutomovel.Database1DataSetTableAdapters.Automoveis1TableAdapter()
        CType(Me.AutomoveisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Automoveis1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Automoveis1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "FrotaAutomovel.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(412, 287)
        Me.ReportViewer1.TabIndex = 0
        '
        'AutomoveisBindingSource
        '
        Me.AutomoveisBindingSource.DataMember = "Automoveis"
        Me.AutomoveisBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AutomoveisTableAdapter
        '
        Me.AutomoveisTableAdapter.ClearBeforeFill = True
        '
        'Automoveis1BindingSource
        '
        Me.Automoveis1BindingSource.DataMember = "Automoveis1"
        Me.Automoveis1BindingSource.DataSource = Me.Database1DataSet
        '
        'Automoveis1TableAdapter
        '
        Me.Automoveis1TableAdapter.ClearBeforeFill = True
        '
        '_01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 287)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "_01"
        Me.Text = "_01"
        CType(Me.AutomoveisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Automoveis1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AutomoveisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Database1DataSet As FrotaAutomovel.Database1DataSet
    Friend WithEvents AutomoveisTableAdapter As FrotaAutomovel.Database1DataSetTableAdapters.AutomoveisTableAdapter
    Friend WithEvents Automoveis1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Automoveis1TableAdapter As FrotaAutomovel.Database1DataSetTableAdapters.Automoveis1TableAdapter
End Class
