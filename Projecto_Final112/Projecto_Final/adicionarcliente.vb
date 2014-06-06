Public Class adicionarcliente
    Dim contribuinte_anterior As Integer
    Dim nome_anterior As String
    Dim distrito_anterior As String

    Private Sub MédicosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MédicosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConsultasDataSet)

    End Sub

    Private Sub FormMédicos2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DistritoComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        NomeTextBox.MaxLength = 50
        ContribuinteMaskedTextBox.Mask = "000000000"
        Dim adapter_distritos As New  _
        ConsultasDataSetTableAdapters.DistritosTableAdapter
        Dim tab_distritos As New ConsultasDataSet.DistritosDataTable
        adapter_distritos.Fill(tab_distritos)
        Dim registo As DataRow
        For Each registo In tab_distritos.Rows
            DistritoComboBox.Items.Add(registo.Item(0))
        Next

    End Sub

    Sub Adicionar()
        ButtonAdicionar.Enabled = True
        ButtonAlterar.Enabled = False
        Limpar_Campos()
    End Sub
    Sub Limpar_Campos()
        ContribuinteMaskedTextBox.DataBindings.Clear()
        NomeTextBox.DataBindings.Clear()
        DistritoComboBox.DataBindings.Clear()
        ContribuinteMaskedTextBox.Text = Nothing
        NomeTextBox.Text = Nothing
        DistritoComboBox.Text = Nothing
        ContribuinteMaskedTextBox.Focus()
    End Sub
    Function Validar_dados() As Boolean
        If Me.ContribuinteMaskedTextBox.MaskFull = False Then
            Validar_dados = False
            MsgBox("Erro no número de contribuinte!", _
               MsgBoxStyle.Critical, Me.Text)
            Return False
        End If
        If Len(NomeTextBox.Text) < 5 Then
            Validar_dados = False

            MsgBox("Erro no nome!", MsgBoxStyle.Critical, Me.Text)
            Return False
        End If
        If DistritoComboBox.Text = "" Then
            Validar_dados = False
            MsgBox("Erro no Distrito!", MsgBoxStyle.Critical, Me.Text)
            Return False
        End If
        Return True
    End Function

    Private Sub ButtonAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdicionar.Click
        If Validar_dados() = False Then Exit Sub
        Dim adapter_médicos As New  _
        ConsultasDataSetTableAdapters.MédicosTableAdapter
        Try
            adapter_médicos.Insert(Me.ContribuinteMaskedTextBox.Text, _
            Me.NomeTextBox.Text, Me.DistritoComboBox.Text)
            MsgBox("Registo adicionado com sucesso!", _
            MsgBoxStyle.Information, Me.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.ContribuinteMaskedTextBox.SelectAll()
            Me.ContribuinteMaskedTextBox.Focus()
        End Try
    End Sub
    Sub Alterar(ByVal contribuinte As Integer, ByVal nome As String, _
ByVal distrito As String)
        ButtonAdicionar.Enabled = False
        ButtonAlterar.Enabled = True
        Limpar_Campos()
        ContribuinteMaskedTextBox.Text = contribuinte
        NomeTextBox.Text = nome
        DistritoComboBox.Text = distrito
        contribuinte_anterior = contribuinte
        nome_anterior = nome
        distrito_anterior = distrito
    End Sub

    Private Sub ButtonAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAlterar.Click
        If Validar_dados() = False Then Exit Sub
        Dim adapter_médicos As New  _
        ConsultasDataSetTableAdapters.MédicosTableAdapter
        Try
            adapter_médicos.Update(Me.ContribuinteMaskedTextBox.Text, _
            Me.NomeTextBox.Text, Me.DistritoComboBox.Text, _
            contribuinte_anterior, nome_anterior, distrito_anterior)
            MsgBox("Registo alterado com sucesso!", _
            MsgBoxStyle.Information, Me.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
            Me.ContribuinteMaskedTextBox.SelectAll()
            Me.ContribuinteMaskedTextBox.Focus()
        End Try

    End Sub
End Class