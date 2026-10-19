<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFactura))
        Dim Id_facturaLabel As System.Windows.Forms.Label
        Dim FechaFacturaLabel As System.Windows.Forms.Label
        Dim IdclienteLabel As System.Windows.Forms.Label
        Me._Systerre2002_2003DataSet = New Sitra._Systerre2002_2003DataSet()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaTableAdapter = New Sitra._Systerre2002_2003DataSetTableAdapters.facturaTableAdapter()
        Me.TableAdapterManager = New Sitra._Systerre2002_2003DataSetTableAdapters.TableAdapterManager()
        Me.FacturaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FacturaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FacturaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_facturaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaFacturaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdclienteTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Id_facturaLabel = New System.Windows.Forms.Label()
        FechaFacturaLabel = New System.Windows.Forms.Label()
        IdclienteLabel = New System.Windows.Forms.Label()
        CType(Me._Systerre2002_2003DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FacturaBindingNavigator.SuspendLayout()
        CType(Me.FacturaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_Systerre2002_2003DataSet
        '
        Me._Systerre2002_2003DataSet.DataSetName = "_Systerre2002_2003DataSet"
        Me._Systerre2002_2003DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "factura"
        Me.FacturaBindingSource.DataSource = Me._Systerre2002_2003DataSet
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.Copia_de_empleadoTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.facturaTableAdapter = Me.FacturaTableAdapter
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sitra._Systerre2002_2003DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'FacturaBindingNavigator
        '
        Me.FacturaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FacturaBindingNavigator.BindingSource = Me.FacturaBindingSource
        Me.FacturaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FacturaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FacturaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FacturaBindingNavigatorSaveItem})
        Me.FacturaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FacturaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FacturaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FacturaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FacturaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FacturaBindingNavigator.Name = "FacturaBindingNavigator"
        Me.FacturaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FacturaBindingNavigator.Size = New System.Drawing.Size(610, 25)
        Me.FacturaBindingNavigator.TabIndex = 0
        Me.FacturaBindingNavigator.Text = "BindingNavigator1"
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
        'FacturaBindingNavigatorSaveItem
        '
        Me.FacturaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FacturaBindingNavigatorSaveItem.Image = CType(resources.GetObject("FacturaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FacturaBindingNavigatorSaveItem.Name = "FacturaBindingNavigatorSaveItem"
        Me.FacturaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.FacturaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'FacturaDataGridView
        '
        Me.FacturaDataGridView.AutoGenerateColumns = False
        Me.FacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.FacturaDataGridView.DataSource = Me.FacturaBindingSource
        Me.FacturaDataGridView.Location = New System.Drawing.Point(36, 193)
        Me.FacturaDataGridView.Name = "FacturaDataGridView"
        Me.FacturaDataGridView.Size = New System.Drawing.Size(397, 220)
        Me.FacturaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_factura"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_factura"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fechaFactura"
        Me.DataGridViewTextBoxColumn2.HeaderText = "fechaFactura"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Idcliente"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Idcliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Id_facturaLabel
        '
        Id_facturaLabel.AutoSize = True
        Id_facturaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_facturaLabel.Location = New System.Drawing.Point(33, 116)
        Id_facturaLabel.Name = "Id_facturaLabel"
        Id_facturaLabel.Size = New System.Drawing.Size(124, 18)
        Id_facturaLabel.TabIndex = 2
        Id_facturaLabel.Text = "Codigo factura:"
        '
        'Id_facturaTextBox
        '
        Me.Id_facturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Id_factura", True))
        Me.Id_facturaTextBox.Location = New System.Drawing.Point(166, 117)
        Me.Id_facturaTextBox.Name = "Id_facturaTextBox"
        Me.Id_facturaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_facturaTextBox.TabIndex = 3
        '
        'FechaFacturaLabel
        '
        FechaFacturaLabel.AutoSize = True
        FechaFacturaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaFacturaLabel.Location = New System.Drawing.Point(33, 143)
        FechaFacturaLabel.Name = "FechaFacturaLabel"
        FechaFacturaLabel.Size = New System.Drawing.Size(54, 18)
        FechaFacturaLabel.TabIndex = 4
        FechaFacturaLabel.Text = "fecha:"
        '
        'FechaFacturaDateTimePicker
        '
        Me.FechaFacturaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FacturaBindingSource, "fechaFactura", True))
        Me.FechaFacturaDateTimePicker.Location = New System.Drawing.Point(93, 141)
        Me.FechaFacturaDateTimePicker.Name = "FechaFacturaDateTimePicker"
        Me.FechaFacturaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaFacturaDateTimePicker.TabIndex = 5
        '
        'IdclienteLabel
        '
        IdclienteLabel.AutoSize = True
        IdclienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdclienteLabel.Location = New System.Drawing.Point(33, 168)
        IdclienteLabel.Name = "IdclienteLabel"
        IdclienteLabel.Size = New System.Drawing.Size(75, 18)
        IdclienteLabel.TabIndex = 6
        IdclienteLabel.Text = "Idcliente:"
        '
        'IdclienteTextBox
        '
        Me.IdclienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Idcliente", True))
        Me.IdclienteTextBox.Location = New System.Drawing.Point(114, 166)
        Me.IdclienteTextBox.Name = "IdclienteTextBox"
        Me.IdclienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdclienteTextBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Uighur", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(247, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 31)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Tabla: Factura"
        '
        'frmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(610, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Id_facturaLabel)
        Me.Controls.Add(Me.Id_facturaTextBox)
        Me.Controls.Add(FechaFacturaLabel)
        Me.Controls.Add(Me.FechaFacturaDateTimePicker)
        Me.Controls.Add(IdclienteLabel)
        Me.Controls.Add(Me.IdclienteTextBox)
        Me.Controls.Add(Me.FacturaDataGridView)
        Me.Controls.Add(Me.FacturaBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFactura"
        Me.Text = "Form13"
        CType(Me._Systerre2002_2003DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FacturaBindingNavigator.ResumeLayout(False)
        Me.FacturaBindingNavigator.PerformLayout()
        CType(Me.FacturaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _Systerre2002_2003DataSet As _Systerre2002_2003DataSet
    Friend WithEvents FacturaBindingSource As BindingSource
    Friend WithEvents FacturaTableAdapter As _Systerre2002_2003DataSetTableAdapters.facturaTableAdapter
    Friend WithEvents TableAdapterManager As _Systerre2002_2003DataSetTableAdapters.TableAdapterManager
    Friend WithEvents FacturaBindingNavigator As BindingNavigator
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
    Friend WithEvents FacturaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FacturaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Id_facturaTextBox As TextBox
    Friend WithEvents FechaFacturaDateTimePicker As DateTimePicker
    Friend WithEvents IdclienteTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
