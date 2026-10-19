Public Class frmCliente
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Systerre2002_2003DataSet)

    End Sub

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Systerre2002_2003DataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me._Systerre2002_2003DataSet.cliente)

    End Sub

    Private Sub ClienteDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClienteDataGridView.CellContentClick

    End Sub

    Private Sub NombreClienteTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreClienteTextBox.TextChanged

    End Sub

    Private Sub DireccionClienteLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class