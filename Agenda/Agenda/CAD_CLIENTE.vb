
Imports System.Data.OleDb
Imports System.Data

Public Class CAD_CLIENTE

#Region "Propriedades"

    Public Property CODIGO As Integer
    Public Property NOME As String
    Public Property CEP As String
    Public Property ENDERECO As String
    Public Property NUMERO As String
    Public Property COMPLEMENTO As String
    Public Property BAIRRO As String
    Public Property UF As String
    Public Property FONE1 As String
    Public Property FONE2 As String


#End Region

#Region "Variáveis"

    Private DBCon As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; DATA SOURCE = AGENDA.ACCDB")
    Private DBCmd As OleDb.OleDbCommand
    Private DBDa As OleDb.OleDbDataAdapter
    Private objDR As OleDb.OleDbDataReader
    Private Paramns As New List(Of OleDb.OleDbParameter)

#End Region

#Region "Funções e Subrotinas"
    Public Function ExecutaQueryReader(ByVal Query As String) As Boolean

        '''<sumary>
        '''Função para consulta e retorno dos dados nas propreidades.
        '''</sumary>
        ''' <param name="Query"> Passa o comando SQL </param> 
        ''' <returns></returns>


        Dim blnOk As Boolean = False

        Try
            'abre conexão
            DBCon.Open()

            'Cria comando
            DBCmd = New OleDb.OleDbCommand(Query, DBCon)

            'Adiciona os parametros no comando
            Paramns.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            'Limpar lista de paramêtros
            Paramns.Clear()

            'Executa
            objDR = DBCmd.ExecuteReader

            'Preenche propriedades
            While objDR.Read()
                If Not IsDBNull(objDR("CODIGO")) Then Me.CODIGO = objDR("CODIGO").ToString
                If Not IsDBNull(objDR("NOME")) Then Me.NOME = objDR("NOME").ToString
                If Not IsDBNull(objDR("CEP")) Then Me.CEP = objDR("CEP").ToString
                If Not IsDBNull(objDR("ENDERECO")) Then Me.ENDERECO = objDR("ENDERECO").ToString
                If Not IsDBNull(objDR("NUMERO")) Then Me.NUMERO = objDR("NUMERO").ToString
                If Not IsDBNull(objDR("COMPLEMENTO")) Then Me.COMPLEMENTO = objDR("COMPLEMENTO").ToString
                If Not IsDBNull(objDR("BAIRRO")) Then Me.BAIRRO = objDR("BAIRRO").ToString
                If Not IsDBNull(objDR("UF")) Then Me.UF = objDR("UF").ToString
                If Not IsDBNull(objDR("FONE1")) Then Me.FONE1 = objDR("FONE1").ToString
                If Not IsDBNull(objDR("FONE2")) Then Me.FONE2 = objDR("FONE2").ToString
                blnOk = True
            End While

        Catch ex As Exception

            Throw ex

        Finally
            If DBCon.State = ConnectionState.Open Then
                DBCon.Close()
            End If

        End Try

        Return blnOk
    End Function

    Public Function ExecutaQuery(ByVal sql As String) As Boolean

        '''<sumary>
        '''Função para executar Inser, Update e Delete.
        '''</sumary>
        ''' <param name="sql"> Passa o comando SQL </param> 
        ''' <returns></returns>

        Dim blnOk As Boolean = False

        Try
            'abre conexão
            DBCon.Open()

            'Cria comando
            DBCmd = New OleDb.OleDbCommand(sql, DBCon)

            'Adiciona os parametros no comando
            Paramns.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            'Limpar lista de paramêtros
            Paramns.Clear()

            'Executa
            blnOk = DBCmd.ExecuteNonQuery

        Catch ex As Exception

            Throw ex

        Finally
            If DBCon.State = ConnectionState.Open Then
                DBCon.Close()
            End If

        End Try

        Return blnOk
    End Function

    Public Function ExecutaQueryDatatable(ByVal sql As String) As DataTable

        '''<sumary>
        '''Função para executar Select com retorno de mais de um resultado.
        '''</sumary>
        ''' <param name="sql"> Passa o comando SQL </param> 
        ''' <returns></returns>

        Dim dt As New DataTable

        Try
            'abre conexão
            DBCon.Open()

            'Cria comando
            DBCmd = New OleDb.OleDbCommand(sql, DBCon)

            'Adiciona os parametros no comando
            Paramns.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            'Limpar lista de paramêtros
            Paramns.Clear()

            'Executa
            DBDa = New OleDb.OleDbDataAdapter(DBCmd)

            DBDa.Fill(dt)

        Catch ex As Exception

            Throw ex

        Finally
            If DBCon.State = ConnectionState.Open Then
                DBCon.Close()
            End If

        End Try

        Return dt

    End Function

    Public Sub AddParam(ByVal Nome As String, ByVal Valor As Object)

        Dim Novo As New OleDb.OleDbParameter(Nome, Valor)

        Paramns.Add(Novo)
    End Sub

#End Region

End Class
