<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenta))
        Dim Id_ventaLabel As System.Windows.Forms.Label
        Dim IdfacturaLabel As System.Windows.Forms.Label
        Dim IdproductoLabel As System.Windows.Forms.Label
        Dim CantidadVentaLabel As System.Windows.Forms.Label
        Dim IdempleadoLabel As System.Windows.Forms.Label
        Me._Systerre2002_2003DataSet = New Sitra._Systerre2002_2003DataSet()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaTableAdapter = New Sitra._Systerre2002_2003DataSetTableAdapters.ventaTableAdapter()
        Me.TableAdapterManager = New Sitra._Systerre2002_2003DataSetTableAdapters.TableAdapterManager()
        Me.VentaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VentaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VentaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_ventaTextBox = New System.Windows.Forms.TextBox()
        Me.IdfacturaTextBox = New System.Windows.Forms.TextBox()
        Me.IdproductoTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadVentaTextBox = New System.Windows.Forms.TextBox()
        Me.IdempleadoTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Id_ventaLabel = New System.Windows.Forms.Label()
        IdfacturaLabel = New System.Windows.Forms.Label()
        IdproductoLabel = New System.Windows.Forms.Label()
        CantidadVentaLabel = New System.Windows.Forms.Label()
        IdempleadoLabel = New System.Windows.Forms.Label()
        CType(Me._Systerre2002_2003DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VentaBindingNavigator.SuspendLayout()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_Systerre2002_2003DataSet
        '
        Me._Systerre2002_2003DataSet.DataSetName = "_Systerre2002_2003DataSet"
        Me._Systerre2002_2003DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentaBindingSource
        '
        Me.VentaBindingSource.DataMember = "venta"
        Me.VentaBindingSource.DataSource = Me._Systerre2002_2003DataSet
        '
        'VentaTableAdapter
        '
        Me.VentaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.Copia_de_empleadoTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.facturaTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sitra._Systerre2002_2003DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        Me.TableAdapterManager.ventaTableAdapter = Me.VentaTableAdapter
        '
        'VentaBindingNavigator
        '
        Me.VentaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VentaBindingNavigator.BindingSource = Me.VentaBindingSource
        Me.VentaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VentaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VentaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VentaBindingNavigatorSaveItem})
        Me.VentaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VentaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VentaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VentaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VentaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VentaBindingNavigator.Name = "VentaBindingNavigator"
        Me.VentaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VentaBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.VentaBindingNavigator.TabIndex = 0
        Me.VentaBindingNavigator.Text = "BindingNavigator1"
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
        'VentaBindingNavigatorSaveItem
        '
        Me.VentaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VentaBindingNavigatorSaveItem.Image = CType(resources.GetObject("VentaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VentaBindingNavigatorSaveItem.Name = "VentaBindingNavigatorSaveItem"
        Me.VentaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.VentaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'VentaDataGridView
        '
        Me.VentaDataGridView.AutoGenerateColumns = False
        Me.VentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.VentaDataGridView.DataSource = Me.VentaBindingSource
        Me.VentaDataGridView.Location = New System.Drawing.Point(21, 221)
        Me.VentaDataGridView.Name = "VentaDataGridView"
        Me.VentaDataGridView.Size = New System.Drawing.Size(562, 220)
        Me.VentaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_venta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_venta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Idfactura"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Idfactura"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Idproducto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Idproducto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cantidadVenta"
        Me.DataGridViewTextBoxColumn4.HeaderText = "cantidadVenta"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Idempleado"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Idempleado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Id_ventaLabel
        '
        Id_ventaLabel.AutoSize = True
        Id_ventaLabel.Location = New System.Drawing.Point(35, 142)
        Id_ventaLabel.Name = "Id_ventaLabel"
        Id_ventaLabel.Size = New System.Drawing.Size(49, 13)
        Id_ventaLabel.TabIndex = 2
        Id_ventaLabel.Text = "Id venta:"
        '
        'Id_ventaTextBox
        '
        Me.Id_ventaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "Id_venta", True))
        Me.Id_ventaTextBox.Location = New System.Drawing.Point(90, 139)
        Me.Id_ventaTextBox.Name = "Id_ventaTextBox"
        Me.Id_ventaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_ventaTextBox.TabIndex = 3
        '
        'IdfacturaLabel
        '
        IdfacturaLabel.AutoSize = True
        IdfacturaLabel.Location = New System.Drawing.Point(32, 171)
        IdfacturaLabel.Name = "IdfacturaLabel"
        IdfacturaLabel.Size = New System.Drawing.Size(52, 13)
        IdfacturaLabel.TabIndex = 4
        IdfacturaLabel.Text = "Idfactura:"
        '
        'IdfacturaTextBox
        '
        Me.IdfacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "Idfactura", True))
        Me.IdfacturaTextBox.Location = New System.Drawing.Point(90, 168)
        Me.IdfacturaTextBox.Name = "IdfacturaTextBox"
        Me.IdfacturaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdfacturaTextBox.TabIndex = 5
        '
        'IdproductoLabel
        '
        IdproductoLabel.AutoSize = True
        IdproductoLabel.Location = New System.Drawing.Point(35, 197)
        IdproductoLabel.Name = "IdproductoLabel"
        IdproductoLabel.Size = New System.Drawing.Size(61, 13)
        IdproductoLabel.TabIndex = 6
        IdproductoLabel.Text = "Idproducto:"
        '
        'IdproductoTextBox
        '
        Me.IdproductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "Idproducto", True))
        Me.IdproductoTextBox.Location = New System.Drawing.Point(102, 194)
        Me.IdproductoTextBox.Name = "IdproductoTextBox"
        Me.IdproductoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdproductoTextBox.TabIndex = 7
        '
        'CantidadVentaLabel
        '
        CantidadVentaLabel.AutoSize = True
        CantidadVentaLabel.Location = New System.Drawing.Point(250, 168)
        CantidadVentaLabel.Name = "CantidadVentaLabel"
        CantidadVentaLabel.Size = New System.Drawing.Size(82, 13)
        CantidadVentaLabel.TabIndex = 8
        CantidadVentaLabel.Text = "cantidad Venta:"
        '
        'CantidadVentaTextBox
        '
        Me.CantidadVentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "cantidadVenta", True))
        Me.CantidadVentaTextBox.Location = New System.Drawing.Point(338, 164)
        Me.CantidadVentaTextBox.Name = "CantidadVentaTextBox"
        Me.CantidadVentaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CantidadVentaTextBox.TabIndex = 9
        '
        'IdempleadoLabel
        '
        IdempleadoLabel.AutoSize = True
        IdempleadoLabel.Location = New System.Drawing.Point(250, 194)
        IdempleadoLabel.Name = "IdempleadoLabel"
        IdempleadoLabel.Size = New System.Drawing.Size(65, 13)
        IdempleadoLabel.TabIndex = 10
        IdempleadoLabel.Text = "Idempleado:"
        '
        'IdempleadoTextBox
        '
        Me.IdempleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "Idempleado", True))
        Me.IdempleadoTextBox.Location = New System.Drawing.Point(321, 194)
        Me.IdempleadoTextBox.Name = "IdempleadoTextBox"
        Me.IdempleadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdempleadoTextBox.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Uighur", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 34)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Tabla: Venta"
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 497)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Id_ventaLabel)
        Me.Controls.Add(Me.Id_ventaTextBox)
        Me.Controls.Add(IdfacturaLabel)
        Me.Controls.Add(Me.IdfacturaTextBox)
        Me.Controls.Add(IdproductoLabel)
        Me.Controls.Add(Me.IdproductoTextBox)
        Me.Controls.Add(CantidadVentaLabel)
        Me.Controls.Add(Me.CantidadVentaTextBox)
        Me.Controls.Add(IdempleadoLabel)
        Me.Controls.Add(Me.IdempleadoTextBox)
        Me.Controls.Add(Me.VentaDataGridView)
        Me.Controls.Add(Me.VentaBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVenta"
        Me.Text = "Form16"
        CType(Me._Systerre2002_2003DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VentaBindingNavigator.ResumeLayout(False)
        Me.VentaBindingNavigator.PerformLayout()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _Systerre2002_2003DataSet As _Systerre2002_2003DataSet
    Friend WithEvents VentaBindingSource As BindingSource
    Friend WithEvents VentaTableAdapter As _Systerre2002_2003DataSetTableAdapters.ventaTableAdapter
    Friend WithEvents TableAdapterManager As _Systerre2002_2003DataSetTableAdapters.TableAdapterManager
    Friend WithEvents VentaBindingNavigator As BindingNavigator
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
    Friend WithEvents VentaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents VentaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Id_ventaTextBox As TextBox
    Friend WithEvents IdfacturaTextBox As TextBox
    Friend WithEvents IdproductoTextBox As TextBox
    Friend WithEvents CantidadVentaTextBox As TextBox
    Friend WithEvents IdempleadoTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
