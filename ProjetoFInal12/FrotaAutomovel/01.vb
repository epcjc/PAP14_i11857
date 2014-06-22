Public Class _01

    Private Sub _01_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Automoveis1' table. You can move, or remove it, as needed.
        Me.Automoveis1TableAdapter.Fill(Me.Database1DataSet.Automoveis1)
        'TODO: This line of code loads data into the 'Database1DataSet.Automoveis' table. You can move, or remove it, as needed.
        Me.AutomoveisTableAdapter.Fill(Me.Database1DataSet.Automoveis)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class