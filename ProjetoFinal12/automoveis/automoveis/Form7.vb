Public Class Form7

    Private Sub Form7_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.clientes' table. You can move, or remove it, as needed.
        Me.clientesTableAdapter.Fill(Me.Database1DataSet.clientes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class