Public Class frmMenuPrincipal
    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        frmVenta.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCategoria.Click
        frmCategoria.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEmpleado.Click
        frmEmpleado.Show()
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        frmCliente.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        frmProducto.Show()
    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        frmProveedor.Show()
    End Sub

    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click
        Process.Start("calc.exe")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        Process.Start("wmplayer.exe")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Process.Start("https://google.com")
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("D:\programacion1\Cuarto Parcial\Systerre 2026.pdf")
    End Sub
End Class