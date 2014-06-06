Public Class adicionarnoticia
    Dim código_anterior As Integer
    Dim nome_anterior As String
    Dim distrito_anterior As String
    Dim sexo_anterior As String
    Dim dn_anterior As Date



    Private Sub FormPacientes2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DistritoComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        SexoComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        Me.Data_NascimentoDateTimePicker.Format = _
        DateTimePickerFormat.Short
        NomeTextBox.MaxLength = 50
        Dim adapter_distritos As New  _
        ConsultasDataSetTableAdapters.DistritosTableAdapter
        Dim tab_distritos As New ConsultasDataSet.DistritosDataTable
        adapter_distritos.Fill(tab_distritos)
        Dim registo As DataRow
        For Each registo In tab_distritos.Rows
            DistritoComboBox.Items.Add(registo.Item(0))
        Next
        SexoComboBox.Items.Add("M")
        SexoComboBox.Items.Add("F")

    End Sub

    Sub Adicionar()
        ButtonAdicionar.Enabled = True
        ButtonAlterar.Enabled = False
        Limpar_Campos()
    End Sub
    Sub Limpar_Campos()
        NomeTextBox.DataBindings.Clear()
        DistritoComboBox.DataBindings.Clear()
        SexoComboBox.DataBindings.Clear()
        NomeTextBox.Text = Nothing
        DistritoComboBox.Text = Nothing
        SexoComboBox.Text = Nothing
        NomeTextBox.Focus()
        Data_NascimentoDateTimePicker.Value = Now()
    End Sub

    Function Validar_dados() As Boolean
        If Len(NomeTextBox.Text) < 5 Then
            Validar_dados = False
            MsgBox("Erro no nome!", MsgBoxStyle.Critical, Me.Text)
            Return False
        End If
        If DistritoComboBox.Text = "" Then
            Validar_dados = False
            MsgBox("Erro no distrito!", MsgBoxStyle.Critical, Me.Text)
            Return False
        End If
        If SexoComboBox.Text = "" Then
            Validar_dados = False
            MsgBox("Erro no campo sexo!", MsgBoxStyle.Critical, _
            Me.Text)
            Return False
        End If
        If Data_NascimentoDateTimePicker.Value > Now() Then
            Validar_dados = False
            MsgBox("Erro na data de nascimento!", _
            MsgBoxStyle.Critical, Me.Text)
            Return False
        End If
        Return True
    End Function
    Private Sub ButtonAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdicionar.Click
        If Validar_dados() = False Then Exit Sub
        Dim adapter_pacientes As New  _
        ConsultasDataSetTableAdapters.PacientesTableAdapter
        Try
            adapter_pacientes.Insert(Me.NomeTextBox.Text, _
            Me.DistritoComboBox.Text, Me.SexoComboBox.Text, _
            Me.Data_NascimentoDateTimePicker.Value)
            MsgBox("Registo adicionado com sucesso!", _
            MsgBoxStyle.Information, Me.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Alterar(ByVal código As Integer, ByVal nome As String, _
ByVal distrito As String, ByVal sexo As String, _
ByVal dn As Date)
        ButtonAdicionar.Enabled = False
        ButtonAlterar.Enabled = True
        Limpar_Campos()
        NomeTextBox.Text = nome
        DistritoComboBox.Text = distrito
        SexoComboBox.Text = sexo
        Data_NascimentoDateTimePicker.Value = dn
        nome_anterior = nome
        distrito_anterior = distrito
        sexo_anterior = sexo
        dn_anterior = dn
        código_anterior = código
    End Sub





    Private Sub ButtonAlterar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonAlterar.Click
        If Validar_dados() = False Then Exit Sub
        Dim adapter_Pacientes As New  _
        ConsultasDataSetTableAdapters.PacientesTableAdapter
        Try
            adapter_Pacientes.Update(Me.NomeTextBox.Text, _
            Me.DistritoComboBox.Text, _
            Me.SexoComboBox.Text, _
            Me.Data_NascimentoDateTimePicker.Value, _
            código_anterior, nome_anterior, _
            distrito_anterior, sexo_anterior, _
            dn_anterior, código_anterior)
            MsgBox("Registo alterado com sucesso!", _
            MsgBoxStyle.Information, Me.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class