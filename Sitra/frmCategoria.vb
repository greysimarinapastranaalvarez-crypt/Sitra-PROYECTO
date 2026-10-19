Public Class frmCategoria
    Private Sub CategoriaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CategoriaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CategoriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Systerre2002_2003DataSet)

    End Sub

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Systerre2002_2003DataSet.categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me._Systerre2002_2003DataSet.categoria)

    End Sub

    Private Sub Id_categoriaLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Id_categoriaLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CategoriaDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CategoriaDataGridView.CellContentClick

    End Sub

    Private Sub DescripcioncatTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Id_categoriaTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DescripcioncatLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Id_categoriaTextBox_TextChanged(sender As Object, e As EventArgs) Handles Id_categoriaTextBox.TextChanged

    End Sub
End Class