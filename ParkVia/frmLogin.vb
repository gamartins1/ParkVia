Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If txtUsuario.Text = "" Or txtSenha.Text = "" Then
                MsgBox("Preencha os campos de usurário e senha pra continuar", vbOKOnly + MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txtUsuario.Text.Substring(0, 2) = "" Then
                MsgBox(txtUsuario.Text.Substring(0, 2))
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class