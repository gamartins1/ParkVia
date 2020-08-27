Public Class frmEstacionamento
    Dim coordenadas, coordenadasIniciais As New Point
    Dim vaga As Integer
    Dim hora As DateTime

    Dim dia, hour, minuto, segundo As Integer
    Dim dataHoraEntrada As Date
    Dim duration As TimeSpan
    Dim horasEmUso As String

    Private Sub pbNovoCarro_MouseMove(sender As Object, e As MouseEventArgs) Handles pbNovoCarro.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            sender.top = MousePosition.Y - coordenadas.X
            sender.left = MousePosition.X - coordenadas.Y
        End If
    End Sub

    Private Sub pbNovoCarro_MouseDown(ByVal sender As Object, e As MouseEventArgs) Handles pbNovoCarro.MouseDown
        coordenadas.X = MousePosition.Y - sender.top
        coordenadas.Y = MousePosition.X - sender.left
    End Sub

    Private Sub frmEstacionamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        coordenadasIniciais.X = pbNovoCarro.Location.X
        coordenadasIniciais.Y = pbNovoCarro.Location.Y
        carregarCarrosEstacionados()
    End Sub

#Region "Drag Enters"
    Private Sub pbVaga1_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga1.DragEnter

        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga2_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga2.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga3_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga3.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga4_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga4.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga5_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga5.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga6_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga6.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga7_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga7.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga8_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga8.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga9_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga9.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga10_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga10.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga11_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga11.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga12_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga12.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga13_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga13.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga14_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga14.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga15_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga15.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga16_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga16.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga17_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga17.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga18_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga18.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga19_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga19.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga20_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga20.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga21_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga21.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga22_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga22.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga23_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga23.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga24_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga24.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga25_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga25.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga26_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga26.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga27_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga27.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbVaga28_DragEnter(sender As Object, e As DragEventArgs) Handles pbVaga28.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
#End Region

    Public Sub carregarCarrosEstacionados()
        'Vai ser usado pra carregar os carros estacionados
        'o laço vai correr no banco e buscar se há carros estacionados
        'caso haja, via switch case vai verificar a vaga e passar os dados
        Try
            conexaoBanco()
            sql = "SELECT placaVeiculo, vagaUsada, dataEntrada, horaEntrada, statusVeiculo FROM tbVeiculoEstacionado " _
                & "WHERE statusVeiculo = 'ESTACIONADO'"
            rs = db.Execute(UCase(sql))
            Do While rs.EOF = False

                Dim vaga = rs.Fields(1).Value
                Select Case vaga
#Region "Switch cases"
                    Case 1
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)

                        duration = DateTime.Now - dataHoraEntrada
                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca1.Text = rs.Fields(0).Value
                            lblData1.Text = rs.Fields(2).Value
                            lblHora1.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            lblHora1.Text = duration.ToString
                            Timer1.Enabled = True
                            lblPlaca1.Text = rs.Fields(0).Value
                            lblData1.Text = rs.Fields(2).Value
                        End If
                        pbVaga1.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 2
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)

                        duration = DateTime.Now - dataHoraEntrada
                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca2.Text = rs.Fields(0).Value
                            lblData2.Text = rs.Fields(2).Value
                            lblHora2.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora2.Text = horasEmUso
                            Timer2.Enabled = True
                            lblPlaca2.Text = rs.Fields(0).Value
                            lblData2.Text = rs.Fields(2).Value
                        End If
                        pbVaga2.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 3
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)
                        duration = DateTime.Now - dataHoraEntrada

                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca3.Text = rs.Fields(0).Value
                            lblData3.Text = rs.Fields(2).Value
                            lblHora3.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora3.Text = horasEmUso
                            Timer3.Enabled = True
                            lblPlaca3.Text = rs.Fields(0).Value
                            lblData3.Text = rs.Fields(2).Value
                        End If
                        pbVaga3.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 4
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)
                        duration = DateTime.Now - dataHoraEntrada

                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca4.Text = rs.Fields(0).Value
                            lblData4.Text = rs.Fields(2).Value
                            lblHora4.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora4.Text = horasEmUso
                            Timer4.Enabled = True
                            lblPlaca4.Text = rs.Fields(0).Value
                            lblData4.Text = rs.Fields(2).Value
                        End If
                        pbVaga4.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 5
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)
                        duration = DateTime.Now - dataHoraEntrada

                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca5.Text = rs.Fields(0).Value
                            lblData5.Text = rs.Fields(2).Value
                            lblHora5.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora5.Text = horasEmUso
                            Timer5.Enabled = True
                            lblPlaca5.Text = rs.Fields(0).Value
                            lblData5.Text = rs.Fields(2).Value
                        End If
                        pbVaga5.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 6
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)
                        duration = DateTime.Now - dataHoraEntrada

                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca6.Text = rs.Fields(0).Value
                            lblData6.Text = rs.Fields(2).Value
                            lblHora6.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora6.Text = horasEmUso
                            Timer6.Enabled = True
                            lblPlaca6.Text = rs.Fields(0).Value
                            lblData6.Text = rs.Fields(2).Value
                        End If
                        pbVaga6.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 7
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)
                        duration = DateTime.Now - dataHoraEntrada

                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca7.Text = rs.Fields(0).Value
                            lblData7.Text = rs.Fields(2).Value
                            lblHora7.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora7.Text = horasEmUso
                            Timer7.Enabled = True
                            lblPlaca7.Text = rs.Fields(0).Value
                            lblData7.Text = rs.Fields(2).Value
                        End If
                        pbVaga7.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 8
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)
                        duration = DateTime.Now - dataHoraEntrada

                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca8.Text = rs.Fields(0).Value
                            lblData8.Text = rs.Fields(2).Value
                            lblHora8.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora8.Text = horasEmUso
                            Timer8.Enabled = True
                            lblPlaca8.Text = rs.Fields(0).Value
                            lblData8.Text = rs.Fields(2).Value
                        End If
                        pbVaga8.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 9
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)

                        duration = DateTime.Now - dataHoraEntrada
                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca9.Text = rs.Fields(0).Value
                            lblData9.Text = rs.Fields(2).Value
                            lblHora9.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora9.Text = horasEmUso
                            Timer9.Enabled = True
                            lblPlaca9.Text = rs.Fields(0).Value
                            lblData9.Text = rs.Fields(2).Value
                        End If
                        pbVaga9.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 10
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)
                        duration = DateTime.Now - dataHoraEntrada

                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca10.Text = rs.Fields(0).Value
                            lblData10.Text = rs.Fields(2).Value
                            lblHora10.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora10.Text = horasEmUso
                            Timer10.Enabled = True
                            lblPlaca10.Text = rs.Fields(0).Value
                            lblData10.Text = rs.Fields(2).Value
                        End If
                        pbVaga10.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 11
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)
                        duration = DateTime.Now - dataHoraEntrada

                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca11.Text = rs.Fields(0).Value
                            lblData11.Text = rs.Fields(2).Value
                            lblHora11.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora11.Text = horasEmUso
                            Timer11.Enabled = True
                            lblPlaca11.Text = rs.Fields(0).Value
                            lblData11.Text = rs.Fields(2).Value
                        End If
                        pbVaga11.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 12
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)

                        duration = DateTime.Now - dataHoraEntrada
                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca12.Text = rs.Fields(0).Value
                            lblData12.Text = rs.Fields(2).Value
                            lblHora12.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora12.Text = horasEmUso
                            Timer12.Enabled = True
                            lblPlaca12.Text = rs.Fields(0).Value
                            lblData12.Text = rs.Fields(2).Value
                        End If
                        pbVaga12.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 13
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)

                        duration = DateTime.Now - dataHoraEntrada
                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca13.Text = rs.Fields(0).Value
                            lblData13.Text = rs.Fields(2).Value
                            lblHora13.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora13.Text = horasEmUso
                            Timer13.Enabled = True
                            lblPlaca13.Text = rs.Fields(0).Value
                            lblData13.Text = rs.Fields(2).Value
                        End If
                        pbVaga13.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 14
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)

                        duration = DateTime.Now - dataHoraEntrada
                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca14.Text = rs.Fields(0).Value
                            lblData14.Text = rs.Fields(2).Value
                            lblHora14.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora14.Text = horasEmUso
                            Timer14.Enabled = True
                            lblPlaca14.Text = rs.Fields(0).Value
                            lblData14.Text = rs.Fields(2).Value
                        End If
                        pbVaga14.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 15
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)

                        duration = DateTime.Now - dataHoraEntrada
                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca15.Text = rs.Fields(0).Value
                            lblData15.Text = rs.Fields(2).Value
                            lblHora15.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora15.Text = horasEmUso
                            Timer15.Enabled = True
                            lblPlaca15.Text = rs.Fields(0).Value
                            lblData15.Text = rs.Fields(2).Value
                        End If
                        pbVaga15.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 16
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)

                        duration = DateTime.Now - dataHoraEntrada
                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca16.Text = rs.Fields(0).Value
                            lblData16.Text = rs.Fields(2).Value
                            lblHora16.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora16.Text = horasEmUso
                            Timer16.Enabled = True
                            lblPlaca16.Text = rs.Fields(0).Value
                            lblData16.Text = rs.Fields(2).Value
                        End If
                        pbVaga16.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 17
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)

                        duration = DateTime.Now - dataHoraEntrada
                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca17.Text = rs.Fields(0).Value
                            lblData17.Text = rs.Fields(2).Value
                            lblHora17.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora17.Text = horasEmUso
                            Timer17.Enabled = True
                            lblPlaca17.Text = rs.Fields(0).Value
                            lblData17.Text = rs.Fields(2).Value
                        End If
                        pbVaga17.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 18
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)

                        duration = DateTime.Now - dataHoraEntrada
                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca18.Text = rs.Fields(0).Value
                            lblData18.Text = rs.Fields(2).Value
                            lblHora18.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora18.Text = horasEmUso
                            Timer18.Enabled = True
                            lblPlaca18.Text = rs.Fields(0).Value
                            lblData18.Text = rs.Fields(2).Value
                        End If
                        pbVaga18.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 19
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)

                        duration = DateTime.Now - dataHoraEntrada

                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca19.Text = rs.Fields(0).Value
                            lblData19.Text = rs.Fields(2).Value
                            lblHora19.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora19.Text = horasEmUso
                            Timer19.Enabled = True
                            lblPlaca19.Text = rs.Fields(0).Value
                            lblData19.Text = rs.Fields(2).Value
                        End If
                        pbVaga19.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 20
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)
                        duration = DateTime.Now - dataHoraEntrada

                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca20.Text = rs.Fields(0).Value
                            lblData20.Text = rs.Fields(2).Value
                            lblHora20.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora20.Text = horasEmUso
                            Timer20.Enabled = True
                            lblPlaca20.Text = rs.Fields(0).Value
                            lblData20.Text = rs.Fields(2).Value
                        End If
                        pbVaga20.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 21
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)

                        duration = DateTime.Now - dataHoraEntrada
                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca21.Text = rs.Fields(0).Value
                            lblData21.Text = rs.Fields(2).Value
                            lblHora21.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora21.Text = horasEmUso
                            Timer21.Enabled = True
                            lblPlaca21.Text = rs.Fields(0).Value
                            lblData21.Text = rs.Fields(2).Value
                        End If
                        pbVaga21.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 22
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)

                        duration = DateTime.Now - dataHoraEntrada
                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca22.Text = rs.Fields(0).Value
                            lblData22.Text = rs.Fields(2).Value
                            lblHora22.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora22.Text = horasEmUso
                            Timer22.Enabled = True
                            lblPlaca22.Text = rs.Fields(0).Value
                            lblData22.Text = rs.Fields(2).Value
                        End If
                        pbVaga22.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 23
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)

                        duration = DateTime.Now - dataHoraEntrada
                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca23.Text = rs.Fields(0).Value
                            lblData23.Text = rs.Fields(2).Value
                            lblHora23.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora23.Text = horasEmUso
                            Timer23.Enabled = True
                            lblPlaca23.Text = rs.Fields(0).Value
                            lblData23.Text = rs.Fields(2).Value
                        End If
                        pbVaga23.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 24
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)

                        duration = DateTime.Now - dataHoraEntrada
                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca24.Text = rs.Fields(0).Value
                            lblData24.Text = rs.Fields(2).Value
                            lblHora24.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora24.Text = horasEmUso
                            Timer24.Enabled = True
                            lblPlaca24.Text = rs.Fields(0).Value
                            lblData24.Text = rs.Fields(2).Value
                        End If
                        pbVaga24.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 25
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)

                        duration = DateTime.Now - dataHoraEntrada
                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca25.Text = rs.Fields(0).Value
                            lblData25.Text = rs.Fields(2).Value
                            lblHora25.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora25.Text = horasEmUso
                            Timer25.Enabled = True
                            lblPlaca25.Text = rs.Fields(0).Value
                            lblData25.Text = rs.Fields(2).Value
                        End If
                        pbVaga25.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 26
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)

                        duration = DateTime.Now - dataHoraEntrada
                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca26.Text = rs.Fields(0).Value
                            lblData26.Text = rs.Fields(2).Value
                            lblHora26.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora26.Text = horasEmUso
                            Timer26.Enabled = True
                            lblPlaca26.Text = rs.Fields(0).Value
                            lblData26.Text = rs.Fields(2).Value
                        End If
                        pbVaga26.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 27
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)

                        duration = DateTime.Now - dataHoraEntrada
                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca27.Text = rs.Fields(0).Value
                            lblData27.Text = rs.Fields(2).Value
                            lblHora27.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora27.Text = horasEmUso
                            Timer27.Enabled = True
                            lblPlaca27.Text = rs.Fields(0).Value
                            lblData27.Text = rs.Fields(2).Value
                        End If
                        pbVaga27.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
                    Case 28
                        dataHoraEntrada = CDate(rs.Fields(2).Value & " " & rs.Fields(3).Value)

                        duration = DateTime.Now - dataHoraEntrada
                        If DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) <> 0 Then
                            lblPlaca28.Text = rs.Fields(0).Value
                            lblData28.Text = rs.Fields(2).Value
                            lblHora28.Text = DateDiff(DateInterval.Day, dataHoraEntrada, DateTime.Now) & " Diária(s)"
                        Else
                            horasEmUso = duration.ToString
                            lblHora28.Text = horasEmUso
                            Timer28.Enabled = True
                            lblPlaca28.Text = rs.Fields(0).Value
                            lblData28.Text = rs.Fields(2).Value
                        End If
                        pbVaga28.BackgroundImage = Image.FromFile(Application.StartupPath + "\img\car.png")
#End Region
                End Select
                rs.MoveNext()
            Loop
            db.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#Region "Drag Drop"
    Private Sub pbVaga1_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga1.DragDrop
        If pbVaga1.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 1
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga2_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga2.DragDrop
        If pbVaga2.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 2
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga3_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga3.DragDrop
        If pbVaga3.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 3
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga4_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga4.DragDrop
        If pbVaga4.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 4
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga5_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga5.DragDrop
        If pbVaga5.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 5
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga6_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga6.DragDrop
        If pbVaga6.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 6
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Public Sub pbVaga7_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga7.DragDrop
        If pbVaga7.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 7
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga8_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga8.DragDrop
        If pbVaga8.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 8
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga9_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga9.DragDrop
        If pbVaga9.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 9
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga10_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga10.DragDrop
        If pbVaga10.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 10
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga11_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga11.DragDrop
        If pbVaga11.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 11
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga12_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga12.DragDrop
        If pbVaga12.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 12
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga13_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga13.DragDrop
        If pbVaga13.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 13
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga14_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga14.DragDrop
        If pbVaga14.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 14
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga15_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga15.DragDrop
        If pbVaga15.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 15
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga16_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga16.DragDrop
        If pbVaga16.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 16
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga17_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga17.DragDrop
        If pbVaga17.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 17
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga18_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga18.DragDrop
        If pbVaga18.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 18
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga19_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga19.DragDrop
        If pbVaga19.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 19
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga20_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga20.DragDrop
        If pbVaga20.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 20
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga21_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga21.DragDrop
        If pbVaga21.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 21
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga22_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga22.DragDrop
        If pbVaga22.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 22
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga23_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga23.DragDrop
        If pbVaga23.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 23
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga24_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga24.DragDrop
        If pbVaga24.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 24
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga25_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga25.DragDrop
        If pbVaga25.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 25
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga26_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga26.DragDrop
        If pbVaga26.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 26
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga27_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga27.DragDrop
        If pbVaga27.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 27
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

    Private Sub pbVaga28_DragDrop(sender As Object, e As DragEventArgs) Handles pbVaga28.DragDrop
        If pbVaga28.BackgroundImage Is Nothing Then
            resp = MsgBox("Deseja adicionar um veículo?", vbQuestion + vbYesNo, "Novo Veículo")
            If resp = MsgBoxResult.Yes Then
                frmNovoVeiculoEstacionado.vagaUsada = 28
                frmNovoVeiculoEstacionado.ShowDialog()
            End If
        Else
            MsgBox("Já há um veículo nessa vaga", vbCritical)
        End If
    End Sub

#End Region

#Region "Timers"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        hora = CDate(lblHora1.Text).AddSeconds(1)
        lblHora1.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        hora = CDate(lblHora2.Text).AddSeconds(1)
        lblHora2.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        hora = CDate(lblHora3.Text).AddSeconds(1)
        lblHora3.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        hora = CDate(lblHora4.Text).AddSeconds(1)
        lblHora4.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        hora = CDate(lblHora5.Text).AddSeconds(1)
        lblHora5.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        hora = CDate(lblHora6.Text).AddSeconds(1)
        lblHora6.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        hora = CDate(lblHora7.Text).AddSeconds(1)
        lblHora7.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        hora = CDate(lblHora8.Text).AddSeconds(1)
        lblHora8.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        hora = CDate(lblHora9.Text).AddSeconds(1)
        lblHora9.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        hora = CDate(lblHora10.Text).AddSeconds(1)
        lblHora10.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        hora = CDate(lblHora11.Text).AddSeconds(1)
        lblHora11.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick
        hora = CDate(lblHora12.Text).AddSeconds(1)
        lblHora12.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer13_Tick(sender As Object, e As EventArgs) Handles Timer13.Tick
        hora = CDate(lblHora13.Text).AddSeconds(1)
        lblHora13.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer14_Tick(sender As Object, e As EventArgs) Handles Timer14.Tick
        hora = CDate(lblHora14.Text).AddSeconds(1)
        lblHora14.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer15_Tick(sender As Object, e As EventArgs) Handles Timer15.Tick
        hora = CDate(lblHora15.Text).AddSeconds(1)
        lblHora15.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer16_Tick(sender As Object, e As EventArgs) Handles Timer16.Tick
        hora = CDate(lblHora16.Text).AddSeconds(1)
        lblHora16.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer17_Tick(sender As Object, e As EventArgs) Handles Timer17.Tick
        hora = CDate(lblHora17.Text).AddSeconds(1)
        lblHora17.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer18_Tick(sender As Object, e As EventArgs) Handles Timer18.Tick
        hora = CDate(lblHora18.Text).AddSeconds(1)
        lblHora18.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer19_Tick(sender As Object, e As EventArgs) Handles Timer19.Tick
        hora = CDate(lblHora19.Text).AddSeconds(1)
        lblHora19.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer20_Tick(sender As Object, e As EventArgs) Handles Timer20.Tick
        hora = CDate(lblHora20.Text).AddSeconds(1)
        lblHora20.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer21_Tick(sender As Object, e As EventArgs) Handles Timer21.Tick
        hora = CDate(lblHora21.Text).AddSeconds(1)
        lblHora21.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer22_Tick(sender As Object, e As EventArgs) Handles Timer22.Tick
        hora = CDate(lblHora22.Text).AddSeconds(1)
        lblHora22.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer23_Tick(sender As Object, e As EventArgs) Handles Timer23.Tick
        hora = CDate(lblHora23.Text).AddSeconds(1)
        lblHora23.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer24_Tick(sender As Object, e As EventArgs) Handles Timer24.Tick
        hora = CDate(lblHora24.Text).AddSeconds(1)
        lblHora24.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer25_Tick(sender As Object, e As EventArgs) Handles Timer25.Tick
        hora = CDate(lblHora25.Text).AddSeconds(1)
        lblHora25.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer26_Tick(sender As Object, e As EventArgs) Handles Timer26.Tick
        hora = CDate(lblHora26.Text).AddSeconds(1)
        lblHora26.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer27_Tick(sender As Object, e As EventArgs) Handles Timer27.Tick
        hora = CDate(lblHora27.Text).AddSeconds(1)
        lblHora27.Text = hora.ToLongTimeString
    End Sub

    Private Sub Timer28_Tick(sender As Object, e As EventArgs) Handles Timer28.Tick
        hora = CDate(lblHora28.Text).AddSeconds(1)
        lblHora28.Text = hora.ToLongTimeString
    End Sub
#End Region

    Private Sub pbNovoCarro_MouseUp(sender As Object, e As MouseEventArgs) Handles pbNovoCarro.MouseUp
        pbNovoCarro.SendToBack()

        If e.Button = MouseButtons.Left Then
            pbNovoCarro.DoDragDrop(pbNovoCarro.BackgroundImage, DragDropEffects.Copy)
        End If
        pbNovoCarro.Location = New Point(coordenadasIniciais.X, coordenadasIniciais.Y)
        pbNovoCarro.BringToFront()
    End Sub

    Private Sub FinalizarVeículoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinalizarVeículoToolStripMenuItem.Click
        Dim vagaSelecionada = (sender.GetCurrentParent()).SourceControl.tag
        If IsNothing((sender.GetCurrentParent()).SourceControl.backgroundImage) Then
            MsgBox("Não há veículos nessa vaga", vbCritical)
            Exit Sub
        End If
        Select Case vagaSelecionada
            Case 1
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData1.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca1.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl1.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 2
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData2.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca2.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl2.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 3
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData3.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca3.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl3.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 4
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData4.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca4.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl4.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 5
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData5.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca5.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl5.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 6
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData6.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca6.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl6.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 7
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData7.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca7.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl7.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 8
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData8.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca8.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl8.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 9
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData9.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca9.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl9.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 10
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData10.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca10.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl10.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 11
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData11.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca11.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl11.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 12
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData12.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca12.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl12.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 13
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData13.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca13.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl13.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 14
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData14.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca14.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl14.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 15
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData15.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca15.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl15.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 16
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData16.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca16.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl16.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 17
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData17.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca17.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl17.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 18
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData18.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca18.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl18.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 19
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData19.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca19.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl19.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 20
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData20.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca20.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl20.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 21
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData21.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca21.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl21.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 22
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData22.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca22.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl22.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 23
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData23.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca23.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl23.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 24
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData24.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca24.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl24.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 25
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData25.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca25.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl25.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 26
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData26.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca26.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl26.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 27
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData27.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca27.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl27.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
            Case 28
                frmFinalizarVeiculo.lblDataEntrada.Text = lblData28.Text
                frmFinalizarVeiculo.lblPlaca.Text = lblPlaca28.Text
                frmFinalizarVeiculo.lblVagaUsada.Text = lbl28.Text
                frmFinalizarVeiculo.lblHoraSaida.Text = DateTime.Now.ToLongTimeString
                frmFinalizarVeiculo.lblDataSaida.Text = DateTime.Now.ToShortDateString
                frmFinalizarVeiculo.ShowDialog()
        End Select
    End Sub

End Class