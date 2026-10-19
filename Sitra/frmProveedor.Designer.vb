<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedor))
        Dim IdproveedorLabel As System.Windows.Forms.Label
        Dim NombreproveedorLabel As System.Windows.Forms.Label
        Dim DireccionproveedorLabel As System.Windows.Forms.Label
        Dim TelefonoproveedorLabel As System.Windows.Forms.Label
        Me._Systerre2002_2003DataSet = New Sitra._Systerre2002_2003DataSet()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter = New Sitra._Systerre2002_2003DataSetTableAdapters.proveedorTableAdapter()
        Me.TableAdapterManager = New Sitra._Systerre2002_2003DataSetTableAdapters.TableAdapterManager()
        Me.ProveedorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ProveedorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdproveedorTextBox = New System.Windows.Forms.TextBox()
        Me.NombreproveedorTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionproveedorTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoproveedorTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        IdproveedorLabel = New System.Windows.Forms.Label()
        NombreproveedorLabel = New System.Windows.Forms.Label()
        DireccionproveedorLabel = New System.Windows.Forms.Label()
        TelefonoproveedorLabel = New System.Windows.Forms.Label()
        CType(Me._Systerre2002_2003DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProveedorBindingNavigator.SuspendLayout()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_Systerre2002_2003DataSet
        '
        Me._Systerre2002_2003DataSet.DataSetName = "_Systerre2002_2003DataSet"
        Me._Systerre2002_2003DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "proveedor"
        Me.ProveedorBindingSource.DataSource = Me._Systerre2002_2003DataSet
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.proveedorTableAdapter = Me.ProveedorTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sitra._Systerre2002_2003DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'ProveedorBindingNavigator
        '
        Me.ProveedorBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProveedorBindingNavigator.BindingSource = Me.ProveedorBindingSource
        Me.ProveedorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProveedorBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProveedorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProveedorBindingNavigatorSaveItem})
        Me.ProveedorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProveedorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProveedorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProveedorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProveedorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProveedorBindingNavigator.Name = "ProveedorBindingNavigator"
        Me.ProveedorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProveedorBindingNavigator.Size = New System.Drawing.Size(582, 25)
        Me.ProveedorBindingNavigator.TabIndex = 0
        Me.ProveedorBindingNavigator.Text = "BindingNavigator1"
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
        'ProveedorBindingNavigatorSaveItem
        '
        Me.ProveedorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProveedorBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProveedorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProveedorBindingNavigatorSaveItem.Name = "ProveedorBindingNavigatorSaveItem"
        Me.ProveedorBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ProveedorBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ProveedorDataGridView
        '
        Me.ProveedorDataGridView.AutoGenerateColumns = False
        Me.ProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ProveedorDataGridView.DataSource = Me.ProveedorBindingSource
        Me.ProveedorDataGridView.Location = New System.Drawing.Point(24, 231)
        Me.ProveedorDataGridView.Name = "ProveedorDataGridView"
        Me.ProveedorDataGridView.Size = New System.Drawing.Size(473, 220)
        Me.ProveedorDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Idproveedor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Idproveedor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombreproveedor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombreproveedor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "direccionproveedor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "direccionproveedor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "telefonoproveedor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "telefonoproveedor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'IdproveedorLabel
        '
        IdproveedorLabel.AutoSize = True
        IdproveedorLabel.Location = New System.Drawing.Point(30, 140)
        IdproveedorLabel.Name = "IdproveedorLabel"
        IdproveedorLabel.Size = New System.Drawing.Size(67, 13)
        IdproveedorLabel.TabIndex = 2
        IdproveedorLabel.Text = "Idproveedor:"
        '
        'IdproveedorTextBox
        '
        Me.IdproveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Idproveedor", True))
        Me.IdproveedorTextBox.Location = New System.Drawing.Point(103, 140)
        Me.IdproveedorTextBox.Name = "IdproveedorTextBox"
        Me.IdproveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdproveedorTextBox.TabIndex = 3
        '
        'NombreproveedorLabel
        '
        NombreproveedorLabel.AutoSize = True
        NombreproveedorLabel.Location = New System.Drawing.Point(30, 181)
        NombreproveedorLabel.Name = "NombreproveedorLabel"
        NombreproveedorLabel.Size = New System.Drawing.Size(45, 13)
        NombreproveedorLabel.TabIndex = 4
        NombreproveedorLabel.Text = "nombre:"
        '
        'NombreproveedorTextBox
        '
        Me.NombreproveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "nombreproveedor", True))
        Me.NombreproveedorTextBox.Location = New System.Drawing.Point(81, 181)
        Me.NombreproveedorTextBox.Name = "NombreproveedorTextBox"
        Me.NombreproveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreproveedorTextBox.TabIndex = 5
        '
        'DireccionproveedorLabel
        '
        DireccionproveedorLabel.AutoSize = True
        DireccionproveedorLabel.Location = New System.Drawing.Point(284, 143)
        DireccionproveedorLabel.Name = "DireccionproveedorLabel"
        DireccionproveedorLabel.Size = New System.Drawing.Size(53, 13)
        DireccionproveedorLabel.TabIndex = 6
        DireccionproveedorLabel.Text = "direccion:"
        '
        'DireccionproveedorTextBox
        '
        Me.DireccionproveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "direccionproveedor", True))
        Me.DireccionproveedorTextBox.Location = New System.Drawing.Point(343, 143)
        Me.DireccionproveedorTextBox.Name = "DireccionproveedorTextBox"
        Me.DireccionproveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionproveedorTextBox.TabIndex = 7
        '
        'TelefonoproveedorLabel
        '
        TelefonoproveedorLabel.AutoSize = True
        TelefonoproveedorLabel.Location = New System.Drawing.Point(284, 181)
        TelefonoproveedorLabel.Name = "TelefonoproveedorLabel"
        TelefonoproveedorLabel.Size = New System.Drawing.Size(48, 13)
        TelefonoproveedorLabel.TabIndex = 8
        TelefonoproveedorLabel.Text = "telefono:"
        '
        'TelefonoproveedorTextBox
        '
        Me.TelefonoproveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "telefonoproveedor", True))
        Me.TelefonoproveedorTextBox.Location = New System.Drawing.Point(338, 181)
        Me.TelefonoproveedorTextBox.Name = "TelefonoproveedorTextBox"
        Me.TelefonoproveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoproveedorTextBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Uighur", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(253, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 34)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Tabla: Proveedor"
        '
        'frmProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(582, 503)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IdproveedorLabel)
        Me.Controls.Add(Me.IdproveedorTextBox)
        Me.Controls.Add(NombreproveedorLabel)
        Me.Controls.Add(Me.NombreproveedorTextBox)
        Me.Controls.Add(DireccionproveedorLabel)
        Me.Controls.Add(Me.DireccionproveedorTextBox)
        Me.Controls.Add(TelefonoproveedorLabel)
        Me.Controls.Add(Me.TelefonoproveedorTextBox)
        Me.Controls.Add(Me.ProveedorDataGridView)
        Me.Controls.Add(Me.ProveedorBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProveedor"
        Me.Text = "Form15"
        CType(Me._Systerre2002_2003DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProveedorBindingNavigator.ResumeLayout(False)
        Me.ProveedorBindingNavigator.PerformLayout()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _Systerre2002_2003DataSet As _Systerre2002_2003DataSet
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As _Systerre2002_2003DataSetTableAdapters.proveedorTableAdapter
    Friend WithEvents TableAdapterManager As _Systerre2002_2003DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProveedorBindingNavigator As BindingNavigator
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
    Friend WithEvents ProveedorBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProveedorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents IdproveedorTextBox As TextBox
    Friend WithEvents NombreproveedorTextBox As TextBox
    Friend WithEvents DireccionproveedorTextBox As TextBox
    Friend WithEvents TelefonoproveedorTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
