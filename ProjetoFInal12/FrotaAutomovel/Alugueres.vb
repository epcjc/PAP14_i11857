Public Class Alugueres

    Private Sub Alugueres_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Automoveis' table. You can move, or remove it, as needed.
        Me.AutomoveisTableAdapter.Fill(Me.Database1DataSet.Automoveis)
        'TODO: This line of code loads data into the 'Database1DataSet.Alugueres' table. You can move, or remove it, as needed.
        Me.AlugueresTableAdapter.Fill(Me.Database1DataSet.Alugueres)
        'TODO: This line of code loads data into the 'Database1DataSet.Clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.Database1DataSet.Clientes)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Me.AlugueresTableAdapter.Insert(Me.ComboBox2.SelectedValue, Me.ComboBox1.SelectedValue, Me.DateTimePicker1.Value, SqlTypes.SqlDateTime.Null)
            MessageBox.Show("Inserido com sucesso")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class