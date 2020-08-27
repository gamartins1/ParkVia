Public Class frmFinalizarVeiculo
    Dim valorServico, valorHora, valorHoraAdicional, valorDiaria As Double
    Dim vaga, diferencaData, totalMinutos, horasAdicionais As Integer
    Dim diferencaHora As TimeSpan

    Sub cobrarDiaria()
        sql = "SELECT nomeItem, valorItem FROM tbTabelaValores WHERE nomeItem = 'DIÁRIA'"
        rs = db.Execute(UCase(sql))
        valorDiaria = CDbl(rs.Fields(1).Value)
        valorServico = valorDiaria * diferencaData
        lblValorFinal.Text = "R$" & Format(valorServico, "00.00")

    End Sub

    Sub cobrarHoras()
        totalMinutos = diferencaHora.TotalMinutes * -1

        Select Case totalMinutos
            Case > 121 'Segue uma lógica diferente devido as horas adicionais
                MsgBox("Mais de duas horas", vbInformation)
                horasAdicionais = (diferencaHora.TotalHours * -1) - 2 'Define o total de horas adicionais descontando o valor padrão de duas horas
                If (diferencaHora.TotalHours * -1) > 6 Then 'Se o total de horas foi mais que 6, cobra diária
                    diferencaData = 1
                    cobrarDiaria()
                    Exit Sub
                Else
                    sql = "SELECT nomeItem, valorItem FROM tbTabelaValores WHERE (tempoItem <= 120 AND " _
                        & "tempoItem > 90) OR nomeItem = 'HORA ADICIONAL'"
                    rs = db.Execute(UCase(sql))
                    For i = 0 To 1
                        If i = 0 Then
                            valorHora = rs.Fields(1).Value
                        Else
                            valorHoraAdicional = rs.Fields(1).Value
                        End If
                        rs.MoveNext()
                    Next
                End If
                Exit Sub
            Case 95 To 120
                MsgBox("Mais de 1:35 horas, cobrar 2:00 horas", vbInformation)
                sql = "SELECT nomeItem, valorItem FROM tbTabelaValores WHERE tempoItem <= 120 AND " _
                    & "tempoItem > 90"
            Case 65 To 94
                MsgBox("Mais de 1:05 horas, cobrar 1:30 hora", vbInformation)
                sql = "SELECT nomeItem, valorItem FROM tbTabelaValores WHERE tempoItem <= 90 AND " _
                    & "tempoItem > 60"
            Case 35 To 64
                MsgBox("Mais de 35 minutos, cobrar 1:00 hora", vbInformation)
                sql = "SELECT nomeItem, valorItem FROM tbTabelaValores WHERE tempoItem <= 60 AND " _
                    & "tempoItem > 30"
            Case 20 To 34
                MsgBox("Mais de 20 minutos, cobrar 30 Minutos", vbInformation)
                sql = "SELECT nomeItem, valorItem FROM tbTabelaValores WHERE tempoItem <= 30 AND " _
                    & "tempoItem > 15"
            Case 5 To 19
                MsgBox("Mais de 5 minutos, cobrar 15 minutos", vbInformation)
                sql = "SELECT nomeItem, valorItem FROM tbTabelaValores WHERE tempoItem < 16"
            Case < 5
                MsgBox("Não será cobrado, menos de 5 minutos", vbInformation)
                Exit Sub
        End Select
        rs = db.Execute(UCase(sql))
        If rs.EOF = False Then
            valorHora = rs.Fields(1).Value
        End If
        lblValorFinal.Text = "R$" & Format(valorHora, "00.00")
    End Sub
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click

        If diferencaData > 0 Then
            resp = MsgBox(
              "====================================" & vbCrLf _
            & "============ CUPOM FISCAL ==============" & vbCrLf _
            & "====================================" & vbCrLf & vbCrLf _
            & "DATA DE ENTRADA: " & lblDataEntrada.Text & vbCrLf _
            & "HORA DE ENTRADA: " & lblHoraEntrada.Text & vbCrLf & vbCrLf _
            & "DATA DE SAÍDA: " & lblDataSaida.Text & vbCrLf _
            & "HORA DE SAÍDA: " & lblHoraSaida.Text & vbCrLf & vbCrLf _
            & "QTD. DIÁRIAS: " & diferencaData & vbCrLf _
            & "VALOR DIÁRIA: R$" & Format(valorServico, "00.00") & vbCrLf _
            & "VALOR HORA DE BASE: R$00,00" & vbCrLf & vbCrLf _
            & "VAGA USADA: " & vaga & vbCrLf _
            & "PLACA: " & lblPlaca.Text & vbCrLf _
            & "====================================" & vbCrLf & vbCrLf _
            & "VALOR FINAL: " & lblValorFinal.Text & vbCrLf, vbOKCancel, "ParkVia")

        Else
            resp = MsgBox(
              "====================================" & vbCrLf _
            & "============ CUPOM FISCAL ==============" & vbCrLf _
            & "====================================" & vbCrLf & vbCrLf _
            & "DATA DE ENTRADA: " & lblDataEntrada.Text & vbCrLf _
            & "HORA DE ENTRADA: " & lblHoraEntrada.Text & vbCrLf & vbCrLf _
            & "DATA DE SAÍDA: " & lblDataSaida.Text & vbCrLf _
            & "HORA DE SAÍDA: " & lblHoraSaida.Text & vbCrLf & vbCrLf _
            & "QTD. DIÁRIAS: " & diferencaData & vbCrLf _
            & "VALOR DIÁRIA: R$00,00" & vbCrLf _
            & "QTD. HORAS: " & diferencaHora.Hours & vbCrLf _
            & "VALOR HORA DE BASE: R$" & valorHora & vbCrLf & vbCrLf _
            & "VAGA USADA: " & vaga & vbCrLf _
            & "PLACA: " & lblPlaca.Text & vbCrLf _
            & "====================================" & vbCrLf & vbCrLf _
            & "VALOR FINAL: " & lblValorFinal.Text & vbCrLf, vbOKCancel, "Parkvia")
        End If
        If resp = vbOK Then
            Try
                sql = "UPDATE tbVeiculoEstacionado SET dataSaida = '" & lblDataSaida.Text & "', " _
                    & "horaSaida = '" & lblHoraSaida.Text & "', statusVeiculo = 'FINALIZADO', " _
                    & "valorEstadia = '" & lblValorFinal.Text & "' WHERE vagaUsada = " & vaga _
                    & " AND statusVeiculo = 'ESTACIONADO'"
                rs = db.Execute(UCase(sql))
                MsgBox("Serviço finalizado com sucesso", vbOKOnly & vbInformation, "ParkVia")

                Select Case vaga
                    Case 1
                        frmEstacionamento.lblPlaca1.Text = "XXX-0000"
                        frmEstacionamento.lblHora1.Text = "00:00:00"
                        frmEstacionamento.lblData1.Text = "--/--/----"
                        frmEstacionamento.pbVaga1.BackgroundImage = Nothing
                    Case 2
                        frmEstacionamento.lblPlaca2.Text = "XXX-0000"
                        frmEstacionamento.lblHora2.Text = "00:00:00"
                        frmEstacionamento.lblData2.Text = "--/--/----"
                        frmEstacionamento.pbVaga2.BackgroundImage = Nothing
                    Case 3
                        frmEstacionamento.lblPlaca3.Text = "XXX-0000"
                        frmEstacionamento.lblHora3.Text = "00:00:00"
                        frmEstacionamento.lblData3.Text = "--/--/----"
                        frmEstacionamento.pbVaga3.BackgroundImage = Nothing
                    Case 4
                        frmEstacionamento.lblPlaca4.Text = "XXX-0000"
                        frmEstacionamento.lblHora4.Text = "00:00:00"
                        frmEstacionamento.lblData4.Text = "--/--/----"
                        frmEstacionamento.pbVaga4.BackgroundImage = Nothing
                    Case 5
                        frmEstacionamento.lblPlaca5.Text = "XXX-0000"
                        frmEstacionamento.lblHora5.Text = "00:00:00"
                        frmEstacionamento.lblData5.Text = "--/--/----"
                        frmEstacionamento.pbVaga5.BackgroundImage = Nothing
                    Case 6
                        frmEstacionamento.lblPlaca6.Text = "XXX-0000"
                        frmEstacionamento.lblHora6.Text = "00:00:00"
                        frmEstacionamento.lblData6.Text = "--/--/----"
                        frmEstacionamento.pbVaga6.BackgroundImage = Nothing
                    Case 7
                        frmEstacionamento.lblPlaca7.Text = "XXX-0000"
                        frmEstacionamento.lblHora7.Text = "00:00:00"
                        frmEstacionamento.lblData7.Text = "--/--/----"
                        frmEstacionamento.pbVaga7.BackgroundImage = Nothing
                    Case 8
                        frmEstacionamento.lblPlaca8.Text = "XXX-0000"
                        frmEstacionamento.lblHora8.Text = "00:00:00"
                        frmEstacionamento.lblData8.Text = "--/--/----"
                        frmEstacionamento.pbVaga8.BackgroundImage = Nothing
                    Case 9
                        frmEstacionamento.lblPlaca9.Text = "XXX-0000"
                        frmEstacionamento.lblHora9.Text = "00:00:00"
                        frmEstacionamento.lblData9.Text = "--/--/----"
                        frmEstacionamento.pbVaga9.BackgroundImage = Nothing
                    Case 10
                        frmEstacionamento.lblPlaca10.Text = "XXX-0000"
                        frmEstacionamento.lblHora10.Text = "00:00:00"
                        frmEstacionamento.lblData10.Text = "--/--/----"
                        frmEstacionamento.pbVaga10.BackgroundImage = Nothing
                    Case 11
                        frmEstacionamento.lblPlaca11.Text = "XXX-0000"
                        frmEstacionamento.lblHora11.Text = "00:00:00"
                        frmEstacionamento.lblData11.Text = "--/--/----"
                        frmEstacionamento.pbVaga11.BackgroundImage = Nothing
                    Case 12
                        frmEstacionamento.lblPlaca12.Text = "XXX-0000"
                        frmEstacionamento.lblHora12.Text = "00:00:00"
                        frmEstacionamento.lblData12.Text = "--/--/----"
                        frmEstacionamento.pbVaga12.BackgroundImage = Nothing
                    Case 13
                        frmEstacionamento.lblPlaca13.Text = "XXX-0000"
                        frmEstacionamento.lblHora13.Text = "00:00:00"
                        frmEstacionamento.lblData13.Text = "--/--/----"
                        frmEstacionamento.pbVaga13.BackgroundImage = Nothing
                    Case 14
                        frmEstacionamento.lblPlaca14.Text = "XXX-0000"
                        frmEstacionamento.lblHora14.Text = "00:00:00"
                        frmEstacionamento.lblData14.Text = "--/--/----"
                        frmEstacionamento.pbVaga14.BackgroundImage = Nothing
                    Case 15
                        frmEstacionamento.lblPlaca15.Text = "XXX-0000"
                        frmEstacionamento.lblHora15.Text = "00:00:00"
                        frmEstacionamento.lblData15.Text = "--/--/----"
                        frmEstacionamento.pbVaga15.BackgroundImage = Nothing
                    Case 16
                        frmEstacionamento.lblPlaca16.Text = "XXX-0000"
                        frmEstacionamento.lblHora16.Text = "00:00:00"
                        frmEstacionamento.lblData16.Text = "--/--/----"
                        frmEstacionamento.pbVaga16.BackgroundImage = Nothing
                    Case 17
                        frmEstacionamento.lblPlaca17.Text = "XXX-0000"
                        frmEstacionamento.lblHora17.Text = "00:00:00"
                        frmEstacionamento.lblData17.Text = "--/--/----"
                        frmEstacionamento.pbVaga17.BackgroundImage = Nothing
                    Case 18
                        frmEstacionamento.lblPlaca18.Text = "XXX-0000"
                        frmEstacionamento.lblHora18.Text = "00:00:00"
                        frmEstacionamento.lblData18.Text = "--/--/----"
                        frmEstacionamento.pbVaga18.BackgroundImage = Nothing
                    Case 19
                        frmEstacionamento.lblPlaca19.Text = "XXX-0000"
                        frmEstacionamento.lblHora19.Text = "00:00:00"
                        frmEstacionamento.lblData19.Text = "--/--/----"
                        frmEstacionamento.pbVaga19.BackgroundImage = Nothing
                    Case 20
                        frmEstacionamento.lblPlaca20.Text = "XXX-0000"
                        frmEstacionamento.lblHora20.Text = "00:00:00"
                        frmEstacionamento.lblData20.Text = "--/--/----"
                        frmEstacionamento.pbVaga20.BackgroundImage = Nothing
                    Case 21
                        frmEstacionamento.lblPlaca21.Text = "XXX-0000"
                        frmEstacionamento.lblHora21.Text = "00:00:00"
                        frmEstacionamento.lblData21.Text = "--/--/----"
                        frmEstacionamento.pbVaga21.BackgroundImage = Nothing
                    Case 22
                        frmEstacionamento.lblPlaca22.Text = "XXX-0000"
                        frmEstacionamento.lblHora22.Text = "00:00:00"
                        frmEstacionamento.lblData22.Text = "--/--/----"
                        frmEstacionamento.pbVaga22.BackgroundImage = Nothing
                    Case 23
                        frmEstacionamento.lblPlaca23.Text = "XXX-0000"
                        frmEstacionamento.lblHora23.Text = "00:00:00"
                        frmEstacionamento.lblData23.Text = "--/--/----"
                        frmEstacionamento.pbVaga23.BackgroundImage = Nothing
                    Case 24
                        frmEstacionamento.lblPlaca24.Text = "XXX-0000"
                        frmEstacionamento.lblHora24.Text = "00:00:00"
                        frmEstacionamento.lblData24.Text = "--/--/----"
                        frmEstacionamento.pbVaga24.BackgroundImage = Nothing
                    Case 25
                        frmEstacionamento.lblPlaca25.Text = "XXX-0000"
                        frmEstacionamento.lblHora25.Text = "00:00:00"
                        frmEstacionamento.lblData25.Text = "--/--/----"
                        frmEstacionamento.pbVaga25.BackgroundImage = Nothing
                    Case 26
                        frmEstacionamento.lblPlaca26.Text = "XXX-0000"
                        frmEstacionamento.lblHora26.Text = "00:00:00"
                        frmEstacionamento.lblData26.Text = "--/--/----"
                        frmEstacionamento.pbVaga26.BackgroundImage = Nothing
                    Case 27
                        frmEstacionamento.lblPlaca27.Text = "XXX-0000"
                        frmEstacionamento.lblHora27.Text = "00:00:00"
                        frmEstacionamento.lblData27.Text = "--/--/----"
                        frmEstacionamento.pbVaga27.BackgroundImage = Nothing
                    Case 28
                        frmEstacionamento.lblPlaca28.Text = "XXX-0000"
                        frmEstacionamento.lblHora28.Text = "00:00:00"
                        frmEstacionamento.lblData28.Text = "--/--/----"
                        frmEstacionamento.pbVaga28.BackgroundImage = Nothing
                End Select

                frmEstacionamento.carregarCarrosEstacionados()
                Me.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub frmFinalizarVeiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            vaga = lblVagaUsada.Text
            lblValorFinal.Text = "R$00,00"
            conexaoBanco()
            sql = "SELECT placaVeiculo, vagaUsada, dataEntrada, horaEntrada, statusVeiculo FROM" _
                & " tbVeiculoEstacionado WHERE statusVeiculo = 'ESTACIONADO' AND vagaUsada = " & vaga
            rs = db.Execute(UCase(sql))
            If rs.EOF = False Then
                lblHoraEntrada.Text = rs.Fields(3).Value
                diferencaData = DateDiff(DateInterval.Day, CDate(lblDataEntrada.Text), CDate(lblDataSaida.Text))
                diferencaHora = CDate(lblHoraEntrada.Text) - CDate(lblHoraSaida.Text)
            Else
                MsgBox("Erro ao carregar informações do veículo", vbCritical)
                Me.Close()
            End If

            If diferencaData > 0 Then 'Se for diária
                cobrarDiaria()
            Else 'Se não for diária vai cobrar por hora
                cobrarHoras()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Me.Close()
        End Try
    End Sub
End Class