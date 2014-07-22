<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartamentoConsultar
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CDepartamento = New System.Windows.Forms.ComboBox()
        Me.BCerar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.Label()
        Me.TFechaRegistro = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TFechaRegistro)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TNombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TDescripcion)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(36, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 134)
        Me.Panel1.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre del departamento :"
        '
        'TDescripcion
        '
        Me.TDescripcion.Enabled = False
        Me.TDescripcion.Location = New System.Drawing.Point(102, 34)
        Me.TDescripcion.MaxLength = 250
        Me.TDescripcion.Multiline = True
        Me.TDescripcion.Name = "TDescripcion"
        Me.TDescripcion.ReadOnly = True
        Me.TDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TDescripcion.Size = New System.Drawing.Size(308, 59)
        Me.TDescripcion.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-3, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Descripción :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 18)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Departamento :"
        '
        'CDepartamento
        '
        Me.CDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CDepartamento.FormattingEnabled = True
        Me.CDepartamento.Location = New System.Drawing.Point(154, 62)
        Me.CDepartamento.Name = "CDepartamento"
        Me.CDepartamento.Size = New System.Drawing.Size(201, 26)
        Me.CDepartamento.TabIndex = 21
        '
        'BCerar
        '
        Me.BCerar.Location = New System.Drawing.Point(356, 241)
        Me.BCerar.Name = "BCerar"
        Me.BCerar.Size = New System.Drawing.Size(90, 27)
        Me.BCerar.TabIndex = 19
        Me.BCerar.Text = "Cerrar"
        Me.BCerar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 29)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Consultar departamento"
        '
        'TNombre
        '
        Me.TNombre.AutoSize = True
        Me.TNombre.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.ForeColor = System.Drawing.Color.Teal
        Me.TNombre.Location = New System.Drawing.Point(191, 5)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(0, 18)
        Me.TNombre.TabIndex = 15
        '
        'TFechaRegistro
        '
        Me.TFechaRegistro.AutoSize = True
        Me.TFechaRegistro.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TFechaRegistro.ForeColor = System.Drawing.Color.Teal
        Me.TFechaRegistro.Location = New System.Drawing.Point(152, 106)
        Me.TFechaRegistro.Name = "TFechaRegistro"
        Me.TFechaRegistro.Size = New System.Drawing.Size(0, 18)
        Me.TFechaRegistro.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-4, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 18)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Fecha de creación : "
        '
        'DepartamentoConsultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 274)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CDepartamento)
        Me.Controls.Add(Me.BCerar)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DepartamentoConsultar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar departamento"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TFechaRegistro As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TNombre As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents BCerar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
