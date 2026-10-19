Public Class frmVenta
    Private Sub VentaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VentaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VentaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Systerre2002_2003DataSet)

    End Sub

    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Systerre2002_2003DataSet.venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter.Fill(Me._Systerre2002_2003DataSet.venta)

    End Sub

    Private Sub CantidadVentaTextBox_TextChanged(sender As Object, e As EventArgs) Handles CantidadVentaTextBox.TextChanged

    End Sub
End Class