<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducto))
        Dim Id_productoLabel As System.Windows.Forms.Label
        Dim DescripcionProducLabel As System.Windows.Forms.Label
        Dim PrecioProducLabel As System.Windows.Forms.Label
        Dim IdcategoriaLabel As System.Windows.Forms.Label
        Dim IdproveedorLabel As System.Windows.Forms.Label
        Me._Systerre2002_2003DataSet = New Sitra._Systerre2002_2003DataSet()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New Sitra._Systerre2002_2003DataSetTableAdapters.productoTableAdapter()
        Me.TableAdapterManager = New Sitra._Systerre2002_2003DataSetTableAdapters.TableAdapterManager()
        Me.ProductoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_productoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionProducTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioProducTextBox = New System.Windows.Forms.TextBox()
        Me.IdcategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.IdproveedorTextBox = New System.Windows.Forms.TextBox()
        Id_productoLabel = New System.Windows.Forms.Label()
        DescripcionProducLabel = New System.Windows.Forms.Label()
        PrecioProducLabel = New System.Windows.Forms.Label()
        IdcategoriaLabel = New System.Windows.Forms.Label()
        IdproveedorLabel = New System.Windows.Forms.Label()
        CType(Me._Systerre2002_2003DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductoBindingNavigator.SuspendLayout()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_Systerre2002_2003DataSet
        '
        Me._Systerre2002_2003DataSet.DataSetName = "_Systerre2002_2003DataSet"
        Me._Systerre2002_2003DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me._Systerre2002_2003DataSet
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.Copia_de_empleadoTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.facturaTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sitra._Systerre2002_2003DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'ProductoBindingNavigator
        '
        Me.ProductoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductoBindingNavigator.BindingSource = Me.ProductoBindingSource
        Me.ProductoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductoBindingNavigatorSaveItem})
        Me.ProductoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductoBindingNavigator.Name = "ProductoBindingNavigator"
        Me.ProductoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductoBindingNavigator.Size = New System.Drawing.Size(704, 25)
        Me.ProductoBindingNavigator.TabIndex = 0
        Me.ProductoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'ProductoBindingNavigatorSaveItem
        '
        Me.ProductoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductoBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductoBindingNavigatorSaveItem.Name = "ProductoBindingNavigatorSaveItem"
        Me.ProductoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ProductoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.AutoGenerateColumns = False
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.Location = New System.Drawing.Point(23, 235)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.Size = New System.Drawing.Size(559, 220)
        Me.ProductoDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_producto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_producto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descripcionProduc"
        Me.DataGridViewTextBoxColumn2.HeaderText = "descripcionProduc"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "precioProduc"
        Me.DataGridViewTextBoxColumn3.HeaderText = "precioProduc"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Idcategoria"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Idcategoria"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Idproveedor"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Idproveedor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Id_productoLabel
        '
        Id_productoLabel.AutoSize = True
        Id_productoLabel.Location = New System.Drawing.Point(46, 124)
        Id_productoLabel.Name = "Id_productoLabel"
        Id_productoLabel.Size = New System.Drawing.Size(87, 13)
        Id_productoLabel.TabIndex = 2
        Id_productoLabel.Text = "codigo producto:"
        '
        'Id_productoTextBox
        '
        Me.Id_productoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Id_producto", True))
        Me.Id_productoTextBox.Location = New System.Drawing.Point(141, 121)
        Me.Id_productoTextBox.Name = "Id_productoTextBox"
        Me.Id_productoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_productoTextBox.TabIndex = 3
        '
        'DescripcionProducLabel
        '
        DescripcionProducLabel.AutoSize = True
        DescripcionProducLabel.Location = New System.Drawing.Point(46, 160)
        DescripcionProducLabel.Name = "DescripcionProducLabel"
        DescripcionProducLabel.Size = New System.Drawing.Size(64, 13)
        DescripcionProducLabel.TabIndex = 4
        DescripcionProducLabel.Text = "descripcion:"
        '
        'DescripcionProducTextBox
        '
        Me.DescripcionProducTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "descripcionProduc", True))
        Me.DescripcionProducTextBox.Location = New System.Drawing.Point(116, 157)
        Me.DescripcionProducTextBox.Name = "DescripcionProducTextBox"
        Me.DescripcionProducTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionProducTextBox.TabIndex = 5
        '
        'PrecioProducLabel
        '
        PrecioProducLabel.AutoSize = True
        PrecioProducLabel.Location = New System.Drawing.Point(46, 193)
        PrecioProducLabel.Name = "PrecioProducLabel"
        PrecioProducLabel.Size = New System.Drawing.Size(39, 13)
        PrecioProducLabel.TabIndex = 6
        PrecioProducLabel.Text = "precio:"
        AddHandler PrecioProducLabel.Click, AddressOf Me.PrecioProducLabel_Click
        '
        'PrecioProducTextBox
        '
        Me.PrecioProducTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "precioProduc", True))
        Me.PrecioProducTextBox.Location = New System.Drawing.Point(91, 193)
        Me.PrecioProducTextBox.Name = "PrecioProducTextBox"
        Me.PrecioProducTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecioProducTextBox.TabIndex = 7
        '
        'IdcategoriaLabel
        '
        IdcategoriaLabel.AutoSize = True
        IdcategoriaLabel.Location = New System.Drawing.Point(278, 160)
        IdcategoriaLabel.Name = "IdcategoriaLabel"
        IdcategoriaLabel.Size = New System.Drawing.Size(59, 13)
        IdcategoriaLabel.TabIndex = 8
        IdcategoriaLabel.Text = "idcategoria"
        '
        'IdcategoriaTextBox
        '
        Me.IdcategoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Idcategoria", True))
        Me.IdcategoriaTextBox.Location = New System.Drawing.Point(347, 160)
        Me.IdcategoriaTextBox.Name = "IdcategoriaTextBox"
        Me.IdcategoriaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdcategoriaTextBox.TabIndex = 9
        '
        'IdproveedorLabel
        '
        IdproveedorLabel.AutoSize = True
        IdproveedorLabel.Location = New System.Drawing.Point(274, 189)
        IdproveedorLabel.Name = "IdproveedorLabel"
        IdproveedorLabel.Size = New System.Drawing.Size(67, 13)
        IdproveedorLabel.TabIndex = 10
        IdproveedorLabel.Text = "Idproveedor:"
        '
        'IdproveedorTextBox
        '
        Me.IdproveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Idproveedor", True))
        Me.IdproveedorTextBox.Location = New System.Drawing.Point(347, 189)
        Me.IdproveedorTextBox.Name = "IdproveedorTextBox"
        Me.IdproveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdproveedorTextBox.TabIndex = 11
        '
        'frmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(704, 564)
        Me.Controls.Add(Id_productoLabel)
        Me.Controls.Add(Me.Id_productoTextBox)
        Me.Controls.Add(DescripcionProducLabel)
        Me.Controls.Add(Me.DescripcionProducTextBox)
        Me.Controls.Add(PrecioProducLabel)
        Me.Controls.Add(Me.PrecioProducTextBox)
        Me.Controls.Add(IdcategoriaLabel)
        Me.Controls.Add(Me.IdcategoriaTextBox)
        Me.Controls.Add(IdproveedorLabel)
        Me.Controls.Add(Me.IdproveedorTextBox)
        Me.Controls.Add(Me.ProductoDataGridView)
        Me.Controls.Add(Me.ProductoBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProducto"
        Me.Text = "Form14"
        CType(Me._Systerre2002_2003DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductoBindingNavigator.ResumeLayout(False)
        Me.ProductoBindingNavigator.PerformLayout()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _Systerre2002_2003DataSet As _Systerre2002_2003DataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As _Systerre2002_2003DataSetTableAdapters.productoTableAdapter
    Friend WithEvents TableAdapterManager As _Systerre2002_2003DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductoBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ProductoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProductoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Id_productoTextBox As TextBox
    Friend WithEvents DescripcionProducTextBox As TextBox
    Friend WithEvents PrecioProducTextBox As TextBox
    Friend WithEvents IdcategoriaTextBox As TextBox
    Friend WithEvents IdproveedorTextBox As TextBox
End Class
