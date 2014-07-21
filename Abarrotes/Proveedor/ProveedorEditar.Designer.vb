<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProveedorEditar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CProveedor = New System.Windows.Forms.ComboBox()
        Me.Flow1 = New System.Windows.Forms.GroupBox()
        Me.Pic2 = New System.Windows.Forms.PictureBox()
        Me.Pic1 = New System.Windows.Forms.PictureBox()
        Me.TCorreo = New System.Windows.Forms.TextBox()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.Flow1.SuspendLayout()
        CType(Me.Pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 29)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Editar proveedor :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 19)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Proveedor :"
        '
        'CProveedor
        '
        Me.CProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CProveedor.FormattingEnabled = True
        Me.CProveedor.Location = New System.Drawing.Point(139, 56)
        Me.CProveedor.Name = "CProveedor"
        Me.CProveedor.Size = New System.Drawing.Size(226, 26)
        Me.CProveedor.TabIndex = 34
        '
        'Flow1
        '
        Me.Flow1.Controls.Add(Me.Pic2)
        Me.Flow1.Controls.Add(Me.Pic1)
        Me.Flow1.Controls.Add(Me.TCorreo)
        Me.Flow1.Controls.Add(Me.TTelefono)
        Me.Flow1.Controls.Add(Me.TNombre)
        Me.Flow1.Controls.Add(Me.Label4)
        Me.Flow1.Controls.Add(Me.Label3)
        Me.Flow1.Controls.Add(Me.Label2)
        Me.Flow1.Enabled = False
        Me.Flow1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Flow1.Location = New System.Drawing.Point(31, 103)
        Me.Flow1.Name = "Flow1"
        Me.Flow1.Size = New System.Drawing.Size(404, 136)
        Me.Flow1.TabIndex = 35
        Me.Flow1.TabStop = False
        Me.Flow1.Text = "Datos : "
        '
        'Pic2
        '
        Me.Pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pic2.Location = New System.Drawing.Point(366, 63)
        Me.Pic2.Name = "Pic2"
        Me.Pic2.Size = New System.Drawing.Size(25, 25)
        Me.Pic2.TabIndex = 40
        Me.Pic2.TabStop = False
        '
        'Pic1
        '
        Me.Pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pic1.Location = New System.Drawing.Point(366, 31)
        Me.Pic1.Name = "Pic1"
        Me.Pic1.Size = New System.Drawing.Size(25, 25)
        Me.Pic1.TabIndex = 39
        Me.Pic1.TabStop = False
        '
        'TCorreo
        '
        Me.TCorreo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.TCorreo.Location = New System.Drawing.Point(157, 95)
        Me.TCorreo.Name = "TCorreo"
        Me.TCorreo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TCorreo.Size = New System.Drawing.Size(234, 26)
        Me.TCorreo.TabIndex = 38
        '
        'TTelefono
        '
        Me.TTelefono.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.TTelefono.Location = New System.Drawing.Point(104, 62)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(255, 26)
        Me.TTelefono.TabIndex = 37
        '
        'TNombre
        '
        Me.TNombre.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.TNombre.Location = New System.Drawing.Point(104, 30)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(255, 26)
        Me.TNombre.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 18)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Correo electronico :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 18)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Telefono :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Nombre :"
        '
        'BCancelar
        '
        Me.BCancelar.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.BCancelar.Location = New System.Drawing.Point(213, 254)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(98, 28)
        Me.BCancelar.TabIndex = 42
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BGuardar
        '
        Me.BGuardar.Enabled = False
        Me.BGuardar.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.BGuardar.Location = New System.Drawing.Point(324, 254)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(98, 28)
        Me.BGuardar.TabIndex = 41
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'ProveedorEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 295)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.Flow1)
        Me.Controls.Add(Me.CProveedor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProveedorEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar proveedor"
        Me.Flow1.ResumeLayout(False)
        Me.Flow1.PerformLayout()
        CType(Me.Pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Flow1 As System.Windows.Forms.GroupBox
    Friend WithEvents TCorreo As System.Windows.Forms.TextBox
    Friend WithEvents TTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BCancelar As System.Windows.Forms.Button
    Friend WithEvents BGuardar As System.Windows.Forms.Button
    Friend WithEvents Pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic1 As System.Windows.Forms.PictureBox
End Class
