Public Class Automoveis

    Private Sub AutomoveisBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles AutomoveisBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AutomoveisBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Automoveis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Automoveis' table. You can move, or remove it, as needed.
        Me.AutomoveisTableAdapter.Fill(Me.Database1DataSet.Automoveis)

    End Sub
End Class