Public Class Form1

    Private Sub AutomóveisBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles AutomóveisBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AutomóveisBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Automóveis' table. You can move, or remove it, as needed.
        Me.AutomóveisTableAdapter.Fill(Me.Database1DataSet.Automóveis)

    End Sub
End Class