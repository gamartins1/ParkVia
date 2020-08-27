<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFinalizarVeiculo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinalizarVeiculo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPlaca = New System.Windows.Forms.Label()
        Me.lblDataEntrada = New System.Windows.Forms.Label()
        Me.lblHoraEntrada = New System.Windows.Forms.Label()
        Me.lblVagaUsada = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblHoraSaida = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDataSaida = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblValorFinal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label1.Location = New System.Drawing.Point(56, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Finalizar veículo estacionado"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(114, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(21, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Placa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(21, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Data de entrada"
        '
        'lblPlaca
        '
        Me.lblPlaca.AutoSize = True
        Me.lblPlaca.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaca.ForeColor = System.Drawing.Color.Silver
        Me.lblPlaca.Location = New System.Drawing.Point(21, 155)
        Me.lblPlaca.Name = "lblPlaca"
        Me.lblPlaca.Size = New System.Drawing.Size(84, 18)
        Me.lblPlaca.TabIndex = 6
        Me.lblPlaca.Text = "XXX-0000"
        '
        'lblDataEntrada
        '
        Me.lblDataEntrada.AutoSize = True
        Me.lblDataEntrada.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataEntrada.ForeColor = System.Drawing.Color.Silver
        Me.lblDataEntrada.Location = New System.Drawing.Point(21, 221)
        Me.lblDataEntrada.Name = "lblDataEntrada"
        Me.lblDataEntrada.Size = New System.Drawing.Size(102, 18)
        Me.lblDataEntrada.TabIndex = 7
        Me.lblDataEntrada.Text = "00/00/0000"
        '
        'lblHoraEntrada
        '
        Me.lblHoraEntrada.AutoSize = True
        Me.lblHoraEntrada.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraEntrada.ForeColor = System.Drawing.Color.Silver
        Me.lblHoraEntrada.Location = New System.Drawing.Point(188, 221)
        Me.lblHoraEntrada.Name = "lblHoraEntrada"
        Me.lblHoraEntrada.Size = New System.Drawing.Size(82, 18)
        Me.lblHoraEntrada.TabIndex = 11
        Me.lblHoraEntrada.Text = "00:00:00"
        '
        'lblVagaUsada
        '
        Me.lblVagaUsada.AutoSize = True
        Me.lblVagaUsada.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVagaUsada.ForeColor = System.Drawing.Color.Silver
        Me.lblVagaUsada.Location = New System.Drawing.Point(188, 155)
        Me.lblVagaUsada.Name = "lblVagaUsada"
        Me.lblVagaUsada.Size = New System.Drawing.Size(28, 18)
        Me.lblVagaUsada.TabIndex = 10
        Me.lblVagaUsada.Text = "00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(188, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 18)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Hora de entrada"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(188, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 18)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Vaga usada"
        '
        'lblHoraSaida
        '
        Me.lblHoraSaida.AutoSize = True
        Me.lblHoraSaida.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraSaida.ForeColor = System.Drawing.Color.Silver
        Me.lblHoraSaida.Location = New System.Drawing.Point(188, 283)
        Me.lblHoraSaida.Name = "lblHoraSaida"
        Me.lblHoraSaida.Size = New System.Drawing.Size(82, 18)
        Me.lblHoraSaida.TabIndex = 15
        Me.lblHoraSaida.Text = "00:00:00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(188, 255)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 18)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Hora de saída"
        '
        'lblDataSaida
        '
        Me.lblDataSaida.AutoSize = True
        Me.lblDataSaida.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataSaida.ForeColor = System.Drawing.Color.Silver
        Me.lblDataSaida.Location = New System.Drawing.Point(21, 283)
        Me.lblDataSaida.Name = "lblDataSaida"
        Me.lblDataSaida.Size = New System.Drawing.Size(102, 18)
        Me.lblDataSaida.TabIndex = 13
        Me.lblDataSaida.Text = "00/00/0000"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightGray
        Me.Label11.Location = New System.Drawing.Point(21, 255)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 18)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Data de saída"
        '
        'lblValorFinal
        '
        Me.lblValorFinal.AutoSize = True
        Me.lblValorFinal.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorFinal.ForeColor = System.Drawing.Color.White
        Me.lblValorFinal.Location = New System.Drawing.Point(127, 377)
        Me.lblValorFinal.Name = "lblValorFinal"
        Me.lblValorFinal.Size = New System.Drawing.Size(73, 18)
        Me.lblValorFinal.TabIndex = 17
        Me.lblValorFinal.Text = "R$00,00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(113, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Valor final"
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.SystemColors.Control
        Me.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFinalizar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizar.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnFinalizar.Location = New System.Drawing.Point(98, 407)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(137, 28)
        Me.btnFinalizar.TabIndex = 18
        Me.btnFinalizar.Text = "Concluir serviço"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.Control
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFechar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnFechar.Location = New System.Drawing.Point(98, 441)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(137, 28)
        Me.btnFechar.TabIndex = 20
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'frmFinalizarVeiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(359, 471)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.lblValorFinal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblHoraSaida)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblDataSaida)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblHoraEntrada)
        Me.Controls.Add(Me.lblVagaUsada)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblDataEntrada)
        Me.Controls.Add(Me.lblPlaca)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFinalizarVeiculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ParkVia - Finalizar o veículo estacionado"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPlaca As Label
    Friend WithEvents lblDataEntrada As Label
    Friend WithEvents lblHoraEntrada As Label
    Friend WithEvents lblVagaUsada As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblHoraSaida As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblDataSaida As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblValorFinal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents btnFechar As Button
End Class
