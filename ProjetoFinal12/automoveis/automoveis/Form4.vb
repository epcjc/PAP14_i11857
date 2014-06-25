Public Class Form4

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.alugueres' table. You can move, or remove it, as needed.
        Me.AlugueresTableAdapter.Fill(Me.Database1DataSet.alugueres)
        'TODO: This line of code loads data into the 'Database1DataSet.Automóveis' table. You can move, or remove it, as needed.
        Me.AutomóveisTableAdapter.Fill(Me.Database1DataSet.Automóveis)
        'TODO: This line of code loads data into the 'Database1DataSet.clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.Database1DataSet.clientes)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Me.AlugueresTableAdapter.Insert(Me.ComboBox1.SelectedValue, Me.ComboBox2.SelectedValue, Me.DateTimePicker1.Value, Me.DateTimePicker2.Value)
            MessageBox.Show("Success!")

        Catch ex As Exception
            MessageBox.show(ex.ToString)



        End Try
    End Sub
End Class