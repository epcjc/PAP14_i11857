Public Class FormMédicos


    Private Sub FormMédicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LISTAGEM DE MÉDICOS
        DataGridView1.AutoSizeColumnsMode = _
        DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.EditMode = _
        DataGridViewEditMode.EditProgrammatically
        Dim adapter_médicos As New  _
        ConsultasDataSetTableAdapters.MédicosTableAdapter
        Dim tab_médicos As New ConsultasDataSet.MédicosDataTable
        adapter_médicos.Fill(tab_médicos)
        Dim coluna As DataColumn
        For Each coluna In tab_médicos.Columns
            DataGridView1.Columns.Add(coluna.ColumnName, _
            coluna.ColumnName)
        Next
        Dim linha As DataRow
        Dim idx_linha As Integer
        Dim idx_coluna As Integer
        idx_linha = 0
        For Each linha In tab_médicos.Rows
            Dim linha_datagrid As New DataGridViewRow
            DataGridView1.Rows.Add(linha_datagrid)
            idx_coluna = 0
            For Each coluna In tab_médicos.Columns
                DataGridView1.Rows(idx_linha).Cells(idx_coluna).Value = _
                tab_médicos.Rows(idx_linha).Item(idx_coluna)

                idx_coluna = idx_coluna + 1
            Next
            idx_linha = idx_linha + 1
        Next

    End Sub


    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim contribuinte As Integer
        Dim nome As String
        Dim distrito As String
        contribuinte = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        nome = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        distrito = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Dim form As New FormMédicos2
        form.MdiParent = Form1
        form.Show()
        form.Alterar(contribuinte, nome, distrito)

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim contribuinte As Integer
        Dim nome As String
        Dim distrito As String
        'OBRIGAR O UTILIZADOR A SELECCIONAR 1 REGISTO POR COMPLETO
        If DataGridView1.SelectedRows.Count <> 1 Then
            MsgBox("Deverá seleccionar um registo por completo!")
            Exit Sub
        End If
        contribuinte = DataGridView1.SelectedRows(0).Cells(0).Value
        nome = DataGridView1.SelectedRows(0).Cells(1).Value
        distrito = DataGridView1.SelectedRows(0).Cells(2).Value
        Dim adapter_médicos As New  _
        ConsultasDataSetTableAdapters.MédicosTableAdapter
        Dim tab_médicos As New ConsultasDataSet.MédicosDataTable
        adapter_médicos.Fill(tab_médicos)
        Try
            adapter_médicos.Delete(contribuinte, nome, distrito)
            MsgBox("Registo eliminado com sucesso!", _
            MsgBoxStyle.Critical, Me.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class