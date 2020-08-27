Public Class frmNovoVeiculoEstacionado
    Public vagaUsada As Integer
    Dim hora As DateTime
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        Try
            conexaoBanco()
            sql = "SELECT placaVeiculo, vagaUsada, statusVeiculo FROM tbVeiculoEstacionado WHERE " _
                        & "vagaUsada = " & txtVagaEstacionada.Text & " AND statusVeiculo = 'ESTACIONADO'"
            rs = db.Execute(UCase(sql))

            If rs.EOF = False Then
                MsgBox("Já há um veículo nessa vaga, tente novamente", vbCritical)
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
        End Try
        Select Case vagaUsada
            Case 1
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                        & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                        & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                        & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga1.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()

                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 2
                Try
                    conexaoBanco()

                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga2.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 3
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga3.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 4
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga4.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 5
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga5.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 6
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga6.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 7
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga7.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 8
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga8.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 9
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga9.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 10
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga10.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 11
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga11.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 12
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga12.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 13
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga13.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 14
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga14.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 15
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga15.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 16
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga16.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 17
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga17.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 18
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga18.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 19
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga19.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 20
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga20.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 21
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga21.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 22
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga22.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 23
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga23.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 24
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga24.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 25
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga25.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 26
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga26.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 27
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga27.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case 28
                Try
                    conexaoBanco()
                    sql = "INSERT INTO tbVeiculoEstacionado (placaVeiculo, vagaUsada, dataEntrada, HoraEntrada, " _
                            & "statusVeiculo, obsVeiculoEstacionado) VALUES ('" & txtPlaca.Text & "', " & txtVagaEstacionada.Text _
                            & ", '" & txtDataEntrada.Text & "', '" & txtHoraEntrada.Text & "', 'ESTACIONADO', '" _
                            & txtObs.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Veículo estacionado", vbInformation, vbOK)
                    frmEstacionamento.pbVaga28.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    frmEstacionamento.carregarCarrosEstacionados()
                    Me.Hide()
                Catch ex As Exception
                    MsgBox("Erro ao registrar o veículo estacionado", vbCritical)
                End Try
            Case Else
        End Select
    End Sub

    Private Sub frmNovoVeiculoEstacionado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtVagaEstacionada.Text = vagaUsada
        txtVagaEstacionada.Enabled = False
        txtDataEntrada.Text = DateTime.Today
        txtHoraEntrada.Text = DateTime.Now.ToLongTimeString
        txtPlaca.Clear()
        txtPlaca.Focus()
        txtObs.Clear()
        Timer1.Enabled = True
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        hora = CDate(txtHoraEntrada.Text).AddSeconds(1)
        txtHoraEntrada.Text = hora.ToLongTimeString
    End Sub
End Class