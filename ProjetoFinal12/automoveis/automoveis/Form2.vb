Public Class Form2

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form3.Show()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Form1.Show()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Form4.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub AutomóveisAlugadosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AutomóveisAlugadosToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub AutomóveisNãoAlugadosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AutomóveisNãoAlugadosToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Form7.Show()

    End Sub

    Private Sub AutomToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AutomToolStripMenuItem.Click
        Form8.Show()
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AjudaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AjudaToolStripMenuItem.Click

        Help.ShowHelp(Me, "relatorio.chm")
    End Sub

    Private Sub ManualDeAjudaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ManualDeAjudaToolStripMenuItem.Click



        Help.ShowHelp(Me, "relatorio.chm")
    End Sub
End Class