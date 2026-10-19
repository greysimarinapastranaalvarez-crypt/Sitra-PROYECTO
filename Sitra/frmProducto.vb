Public Class frmProducto
    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Systerre2002_2003DataSet)

    End Sub

    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Systerre2002_2003DataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me._Systerre2002_2003DataSet.producto)

    End Sub

    Private Sub PrecioProducLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Id_productoTextBox_TextChanged(sender As Object, e As EventArgs) Handles Id_productoTextBox.TextChanged

    End Sub
End Class