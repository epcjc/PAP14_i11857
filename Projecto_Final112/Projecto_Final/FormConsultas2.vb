Public Class FormConsultas2
    Dim consulta_anterior As Integer
    Dim data_anterior As Date
    Dim paciente_anterior As String
    Dim médico_anterior As String

    Private Sub ConsultasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ConsultasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConsultasDataSet)

    End Sub

    Private Sub FormConsultas2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PacienteComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        MédicoComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        DataDateTimePicker.Format = DateTimePickerFormat.Short
        Dim adapter_pacientes As New  _
        ConsultasDataSetTableAdapters.PacientesTableAdapter
        Dim tab_Pacientes As New ConsultasDataSet.PacientesDataTable
        adapter_pacientes.Fill(tab_Pacientes)
        Dim registo As DataRow
        'PARA SE OBTER O NOME DO PACIENTE EM VEZ DO CÓDIGO ASSOCIADO, RECORRE-SE AO ITEM 1
        For Each registo In tab_Pacientes.Rows
            PacienteComboBox.Items.Add(registo.Item(1))
        Next
        Dim adapter_médicos As New  _
        ConsultasDataSetTableAdapters.MédicosTableAdapter
        Dim tab_Médicos As New ConsultasDataSet.MédicosDataTable
        adapter_médicos.Fill(tab_Médicos)
        'PARA SE OBTER O NOME DO MÉDICO EM VEZ DO CÓDIGO ASSOCIADO, RECORRE-SE AO ITEM 1
        For Each registo In tab_Médicos.Rows
            MédicoComboBox.Items.Add(registo.Item(1))
        Next


    End Sub
    Sub Adicionar()
        ButtonAdicionar.Enabled = True
        ButtonAlterar.Enabled = False
        Limpar_Campos()
    End Sub
    Sub Limpar_Campos()
        ConsultaTextBox.DataBindings.Clear()
        'DESACTIVAÇÃO DO CAMPO CONSULTA (CAMPO SEQUENCIAL)
        ConsultaTextBox.Enabled = False
        DataDateTimePicker.DataBindings.Clear()
        PacienteComboBox.DataBindings.Clear()
        MédicoComboBox.DataBindings.Clear()
        ConsultaTextBox.Text = Nothing
        DataDateTimePicker.Value = Now()
        PacienteComboBox.Text = Nothing
        MédicoComboBox.Text = Nothing
    End Sub
    Function Validar_dados() As Boolean
        If MédicoComboBox.Text = "" Then
            Validar_dados = False
            MsgBox("Erro no nome do médico!", _
            MsgBoxStyle.Critical, Me.Text)
            Return False
        End If
        If PacienteComboBox.Text = "" Then
            Validar_dados = False
            MsgBox("Erro no nome do paciente!", MsgBoxStyle.Critical, _
            Me.Text)
            Return False
        End If
        Return True
    End Function

    Private Sub ButtonAdicionar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonAdicionar.Click
        If Validar_dados() = False Then Exit Sub
        Dim adapter_médicos As New  _
        ConsultasDataSetTableAdapters.MédicosTableAdapter
        Dim tab_Médicos As New ConsultasDataSet.MédicosDataTable
        adapter_médicos.Fill(tab_Médicos)
        Dim registo_médicos() As DataRow
        registo_médicos = tab_Médicos.Select("nome='" & _
        MédicoComboBox.Text & "'")
        Dim médico As Long
        médico = registo_médicos(0).Item(0)
        Dim adapter_pacientes As New  _
        ConsultasDataSetTableAdapters.PacientesTableAdapter
        Dim tab_pacientes As New ConsultasDataSet.PacientesDataTable
        adapter_pacientes.Fill(tab_pacientes)
        Dim registo_pacientes() As DataRow
        registo_pacientes = tab_pacientes.Select("nome='" & _
        PacienteComboBox.Text & "'")
        Dim paciente As Long
        paciente = registo_pacientes(0).Item(0)
        Dim adapter_consultas As New  _
        ConsultasDataSetTableAdapters.ConsultasTableAdapter
        Try
            adapter_consultas.Insert(DataDateTimePicker.Value, _
            paciente, médico)
            MsgBox("Registo adicionado com sucesso!", _
            MsgBoxStyle.Information, Me.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub Alterar(ByVal consulta As Integer, ByVal data As Date, _
ByVal paciente As String, ByVal médico As String)
        ButtonAdicionar.Enabled = False
        ButtonAlterar.Enabled = True
        Limpar_Campos()
        ConsultaTextBox.Text = consulta
        PacienteComboBox.Text = paciente
        MédicoComboBox.Text = médico
        DataDateTimePicker.Value = data
        consulta_anterior = consulta
        paciente_anterior = paciente
        médico_anterior = médico
        data_anterior = data
    End Sub

    Private Sub ButtonAlterar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonAlterar.Click
        If Validar_dados() = False Then Exit Sub
        Dim adapter_Consultas As New  _
        ConsultasDataSetTableAdapters.ConsultasTableAdapter
        Dim adapter_médicos As New  _
        ConsultasDataSetTableAdapters.MédicosTableAdapter
        Dim tab_Médicos As New ConsultasDataSet.MédicosDataTable
        adapter_médicos.Fill(tab_Médicos)
        Dim registo_médicos() As DataRow
        registo_médicos = tab_Médicos.Select("nome='" & _
        MédicoComboBox.Text & "'")
        Dim médico As Long
        médico = registo_médicos(0).Item(0)
        Dim adapter_pacientes As New  _
        ConsultasDataSetTableAdapters.PacientesTableAdapter
        Dim tab_pacientes As New ConsultasDataSet.PacientesDataTable
        adapter_pacientes.Fill(tab_pacientes)
        Dim registo_pacientes() As DataRow
        registo_pacientes = tab_pacientes.Select("nome='" & _
        PacienteComboBox.Text & "'")
        Dim paciente As Long
        paciente = registo_pacientes(0).Item(0)
        'DETERMINAR CÓDIGO DO MÉDICO ANTERIOR
        registo_médicos = tab_Médicos.Select("nome='" & _
        médico_anterior & "'")
        Dim médico_ant As Long
        médico_ant = registo_médicos(0).Item(0)
        'DETERMINAR CÓDIGO DO PACIENTE ANTERIOR
        registo_pacientes = tab_pacientes.Select("nome='" & _
        paciente_anterior & "'")
        Dim paciente_ant As Long
        paciente_ant = registo_pacientes(0).Item(0)
        Try
            adapter_Consultas.Update(DataDateTimePicker.Value, _
            paciente, médico, consulta_anterior, data_anterior, _
            paciente_ant, médico_ant, consulta_anterior)
            MsgBox("Registo alterado com sucesso!", _
            MsgBoxStyle.Information, Me.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class