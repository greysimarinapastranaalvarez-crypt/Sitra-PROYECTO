<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        Me.btnFactura = New System.Windows.Forms.Button()
        Me.btnProducto = New System.Windows.Forms.Button()
        Me.btnProveedor = New System.Windows.Forms.Button()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnCategoria = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.btnEmpleado = New System.Windows.Forms.Button()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.btnCalculadoraW = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFactura
        '
        Me.btnFactura.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactura.Image = Global.Sitra.My.Resources.Resources.iCandy_Junior_049
        Me.btnFactura.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFactura.Location = New System.Drawing.Point(31, 107)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(88, 59)
        Me.btnFactura.TabIndex = 15
        Me.btnFactura.Text = "Factura"
        Me.btnFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFactura.UseVisualStyleBackColor = True
        '
        'btnProducto
        '
        Me.btnProducto.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProducto.Image = Global.Sitra.My.Resources.Resources.krfb_32x32_32
        Me.btnProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProducto.Location = New System.Drawing.Point(138, 107)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(88, 59)
        Me.btnProducto.TabIndex = 14
        Me.btnProducto.Text = "Producto"
        Me.btnProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProducto.UseVisualStyleBackColor = True
        '
        'btnProveedor
        '
        Me.btnProveedor.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProveedor.Image = Global.Sitra.My.Resources.Resources.kthememgr_32x32_32
        Me.btnProveedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProveedor.Location = New System.Drawing.Point(242, 107)
        Me.btnProveedor.Name = "btnProveedor"
        Me.btnProveedor.Size = New System.Drawing.Size(88, 59)
        Me.btnProveedor.TabIndex = 13
        Me.btnProveedor.Text = "Proveedor"
        Me.btnProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProveedor.UseVisualStyleBackColor = True
        '
        'btnUsuario
        '
        Me.btnUsuario.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuario.Image = Global.Sitra.My.Resources.Resources.guy_blue1
        Me.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUsuario.Location = New System.Drawing.Point(31, 172)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(88, 59)
        Me.btnUsuario.TabIndex = 12
        Me.btnUsuario.Text = "Usuario"
        Me.btnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUsuario.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Sitra.My.Resources.Resources.delete
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(245, 302)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 59)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Salir"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnCategoria
        '
        Me.btnCategoria.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoria.Image = Global.Sitra.My.Resources.Resources.file_edit
        Me.btnCategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCategoria.Location = New System.Drawing.Point(31, 42)
        Me.btnCategoria.Name = "btnCategoria"
        Me.btnCategoria.Size = New System.Drawing.Size(88, 59)
        Me.btnCategoria.TabIndex = 10
        Me.btnCategoria.Text = "Categoria"
        Me.btnCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCategoria.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCliente.Image = Global.Sitra.My.Resources.Resources.user_2
        Me.btnCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCliente.Location = New System.Drawing.Point(138, 42)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(88, 59)
        Me.btnCliente.TabIndex = 9
        Me.btnCliente.Text = "Cliente"
        Me.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'btnEmpleado
        '
        Me.btnEmpleado.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleado.Image = Global.Sitra.My.Resources.Resources.user_1
        Me.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEmpleado.Location = New System.Drawing.Point(242, 42)
        Me.btnEmpleado.Name = "btnEmpleado"
        Me.btnEmpleado.Size = New System.Drawing.Size(88, 59)
        Me.btnEmpleado.TabIndex = 8
        Me.btnEmpleado.Text = "Empleado"
        Me.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEmpleado.UseVisualStyleBackColor = True
        '
        'btnVenta
        '
        Me.btnVenta.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVenta.Image = Global.Sitra.My.Resources.Resources.kate_32x32_32
        Me.btnVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVenta.Location = New System.Drawing.Point(138, 172)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(88, 59)
        Me.btnVenta.TabIndex = 7
        Me.btnVenta.Text = "  Venta"
        Me.btnVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVenta.UseVisualStyleBackColor = True
        '
        'btnCalculadoraW
        '
        Me.btnCalculadoraW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculadoraW.Location = New System.Drawing.Point(242, 172)
        Me.btnCalculadoraW.Name = "btnCalculadoraW"
        Me.btnCalculadoraW.Size = New System.Drawing.Size(88, 59)
        Me.btnCalculadoraW.TabIndex = 16
        Me.btnCalculadoraW.Text = "Calculadora de Windows"
        Me.btnCalculadoraW.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(33, 237)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 59)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Calculadora basica"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(33, 302)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 59)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Reproducir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(138, 237)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(88, 59)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Manual Tecnico"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(138, 302)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(88, 59)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "Navegador"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(245, 238)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(85, 58)
        Me.Button7.TabIndex = 21
        Me.Button7.Text = "Manual del usuario"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(405, 410)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCalculadoraW)
        Me.Controls.Add(Me.btnFactura)
        Me.Controls.Add(Me.btnProducto)
        Me.Controls.Add(Me.btnProveedor)
        Me.Controls.Add(Me.btnUsuario)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnCategoria)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.btnEmpleado)
        Me.Controls.Add(Me.btnVenta)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenuPrincipal"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVenta As Button
    Friend WithEvents btnEmpleado As Button
    Friend WithEvents btnCliente As Button
    Friend WithEvents btnCategoria As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnUsuario As Button
    Friend WithEvents btnProveedor As Button
    Friend WithEvents btnProducto As Button
    Friend WithEvents btnFactura As Button
    Friend WithEvents btnCalculadoraW As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
