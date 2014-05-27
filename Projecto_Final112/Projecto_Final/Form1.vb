Public Class Form1

    Private Sub ConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaToolStripMenuItem.Click
        Dim form As New FormMédicos
        form.MdiParent = Me
        form.Show()
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim form As New FormPacientes
        form.MdiParent = Me
        form.Show()
    End Sub
    Private Sub ConsultarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem1.Click
        Dim form As New FormConsultas
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub AdicionarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarToolStripMenuItem.Click
        Dim form As New FormMédicos2
        form.MdiParent = Me
        form.Show()
        form.Adicionar()
    End Sub

    Private Sub AdicionarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarToolStripMenuItem1.Click
        Dim form As New FormPacientes2
        form.MdiParent = Me
        form.Show()
        form.Adicionar()
    End Sub
    Private Sub AdicionarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarToolStripMenuItem2.Click
        Dim form As New FormConsultas2
        form.MdiParent = Me
        form.Show()
        form.Adicionar()
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = Now()
    End Sub
End Class
