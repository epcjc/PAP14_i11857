Public Class Form3

    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.Database1DataSet.clientes)

    End Sub
End Class