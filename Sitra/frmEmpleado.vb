Public Class frmEmpleado
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub EmpleadoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpleadoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Systerre2002_2003DataSet)

    End Sub

    Private Sub frmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Systerre2002_2003DataSet.empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me._Systerre2002_2003DataSet.empleado)

    End Sub

    Private Sub EmpleadoDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpleadoDataGridView.CellContentClick

    End Sub

    Private Sub DireccionEmpleadoTextBox_TextChanged(sender As Object, e As EventArgs) Handles DireccionEmpleadoTextBox.TextChanged

    End Sub

    Private Sub DireccionEmpleadoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EdadEmpleadoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IdusuarioTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdusuarioTextBox.TextChanged

    End Sub

    Private Sub IdusuarioLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TelefonoEmpleadoTextBox_TextChanged(sender As Object, e As EventArgs) Handles TelefonoEmpleadoTextBox.TextChanged

    End Sub

    Private Sub NombreEmpleadoTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreEmpleadoTextBox.TextChanged

    End Sub
End Class