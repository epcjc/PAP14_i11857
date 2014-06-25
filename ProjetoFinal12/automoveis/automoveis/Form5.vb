Public Class Form5

    Private Sub Form5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Automóveis' table. You can move, or remove it, as needed.
        Me.AutomóveisTableAdapter.Fill(Me.Database1DataSet.Automóveis)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class