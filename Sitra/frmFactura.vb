Public Class frmFactura
    Private Sub FacturaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FacturaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FacturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Systerre2002_2003DataSet)

    End Sub

    Private Sub frmFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Systerre2002_2003DataSet.factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me._Systerre2002_2003DataSet.factura)

    End Sub

    Private Sub FechaFacturaDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles FechaFacturaDateTimePicker.ValueChanged

    End Sub

    Private Sub Id_facturaTextBox_TextChanged(sender As Object, e As EventArgs) Handles Id_facturaTextBox.TextChanged

    End Sub
End Class