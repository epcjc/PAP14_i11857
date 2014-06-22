Public Class Form1

    Private Sub InserirAluguerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InserirAluguerToolStripMenuItem.Click
        Automoveis.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Clientes.ShowDialog()
    End Sub

    Private Sub AlugueresToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AlugueresToolStripMenuItem.Click
        Alugueres.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem2.Click
      _01.Show()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
