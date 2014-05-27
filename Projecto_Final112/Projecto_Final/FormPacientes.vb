Public Class FormPacientes

    Private Sub FormPacientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LISTAGEM DE PACIENTES
        DataGridView1.AutoSizeColumnsMode = _
        DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.EditMode = _
        DataGridViewEditMode.EditProgrammatically
        Dim adapter_pacientes As New  _
        ConsultasDataSetTableAdapters.PacientesTableAdapter
        Dim tab_pacientes As New ConsultasDataSet.PacientesDataTable
        adapter_pacientes.Fill(tab_pacientes)
        Dim coluna As DataColumn
        For Each coluna In tab_pacientes.Columns
            DataGridView1.Columns.Add(coluna.ColumnName, _
            coluna.ColumnName)
        Next
        Dim idx_linha As Integer
        idx_linha = 0
        Dim valor
        Dim linha As DataRow
        For Each linha In tab_pacientes.Rows
            Dim linha_datagrid As New DataGridViewRow
            DataGridView1.Rows.Add(linha_datagrid)
            Dim idx_coluna As Integer
            idx_coluna = 0
            For Each coluna In tab_pacientes.Columns
                valor = tab_pacientes.Rows(idx_linha).Item(idx_coluna)
                If IsDate(valor) Then valor = _
                Microsoft.VisualBasic.FormatDateTime(valor, _
                DateFormat.ShortDate)
                DataGridView1.Rows(idx_linha).Cells(idx_coluna).Value = valor
                idx_coluna = idx_coluna + 1
            Next
            idx_linha = idx_linha + 1
        Next

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim código As Integer
        Dim nome As String
        Dim distrito As String
        Dim sexo As String
        Dim dn As Date
        código = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        nome = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        distrito = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        sexo = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        dn = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        Dim form As New FormPacientes2
        form.MdiParent = Form1
        form.Show()
        form.Alterar(código, nome, distrito, sexo, dn)

    End Sub
End Class