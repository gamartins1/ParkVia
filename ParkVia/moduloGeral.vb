Module moduloGeral
    Public resp
    Public sql
    Public i As Integer

    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public conexao = Application.StartupPath & "\banco\parkVia.mdb"

    Sub conexaoBanco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & conexao)
        Catch ex As Exception
            MsgBox("Erro ao conectar!" & vbCrLf & ex.ToString)
        End Try
    End Sub
End Module
