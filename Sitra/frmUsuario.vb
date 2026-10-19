Public Class frmUsuario
    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsuarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Systerre2002_2003DataSet)

    End Sub

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Systerre2002_2003DataSet.usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me._Systerre2002_2003DataSet.usuario)

    End Sub

    Private Sub Id_usuarioLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class