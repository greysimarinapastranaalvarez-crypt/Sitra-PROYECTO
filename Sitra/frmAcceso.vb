Public Class frmAcceso
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmAcceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        End 
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If txtClave.Text = "123" Then
            MsgBox("Bienvenido al sistema", vbInformation, "Mensaje")
            Me.Hide()
            frmMenuPrincipal.Show()

        Else
            MsgBox("Contraseña incorrecta", vbCritical, "Mensaje")
            txtClave.Text = ""
            txtClave.Focus()

        End If
    End Sub
End Class