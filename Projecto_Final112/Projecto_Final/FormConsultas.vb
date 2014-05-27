Public Class FormConsultas

    Private Sub FormConsultas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LISTAGEM DE CONSULTAS
        DataGridView1.AutoSizeColumnsMode = _
        DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.EditMode = _
        DataGridViewEditMode.EditProgrammatically
        Dim adapter_consultas As New  _
        ConsultasDataSetTableAdapters.ConsultasTableAdapter
        Dim tab_consultas As New ConsultasDataSet.ConsultasDataTable
        adapter_consultas.Fill(tab_consultas)
        Dim adapter_pacientes As New  _
        ConsultasDataSetTableAdapters.PacientesTableAdapter
        Dim tab_pacientes As New ConsultasDataSet.PacientesDataTable
        adapter_pacientes.Fill(tab_pacientes)
        Dim adapter_médicos As New  _
        ConsultasDataSetTableAdapters.MédicosTableAdapter
        Dim tab_médicos As New ConsultasDataSet.MédicosDataTable
        adapter_médicos.Fill(tab_médicos)
        Dim coluna As DataColumn
        For Each coluna In tab_consultas.Columns
            DataGridView1.Columns.Add(coluna.ColumnName, _
            coluna.ColumnName)
        Next
        Dim idx_linha As Integer
        Dim idx_coluna As Integer
        Dim valor
        idx_linha = 0
        Dim linha As DataRow
        For Each linha In tab_consultas.Rows
            Dim linha_datagrid As New DataGridViewRow
            DataGridView1.Rows.Add(linha_datagrid)
            idx_coluna = 0
            For Each coluna In tab_consultas.Columns
                valor = _
                tab_consultas.Rows(idx_linha).Item(idx_coluna)
                If idx_coluna = 2 Then valor = _
                tab_pacientes.FindByCódigo(valor).Nome
                If idx_coluna = 3 Then valor = _
                tab_médicos.FindByContribuinte(valor).Nome
                If IsDate(valor) Then valor = _
                Microsoft.VisualBasic.FormatDateTime(valor, _
                DateFormat.ShortDate)
                DataGridView1.Rows(idx_linha).Cells(idx_coluna).Value = _
                valor
                idx_coluna = idx_coluna + 1
            Next
            idx_linha = idx_linha + 1
        Next

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim consulta As Integer
        Dim paciente As String
        Dim médico As String
        Dim data As Date
        consulta = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        data = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        paciente = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        médico = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        Dim form As New FormConsultas2
        form.MdiParent = Form1
        form.Show()
        form.Alterar(consulta, data, paciente, médico)

    End Sub
End Class