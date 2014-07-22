<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartamentoEditar
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
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Pic1 = New System.Windows.Forms.PictureBox()
        Me.TDepartamento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(251, 212)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(90, 27)
        Me.BCancelar.TabIndex = 9
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BGuardar
        '
        Me.BGuardar.Enabled = False
        Me.BGuardar.Location = New System.Drawing.Point(356, 212)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(90, 27)
        Me.BGuardar.TabIndex = 8
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Editar departamento"
        '
        'TDescripcion
        '
        Me.TDescripcion.Location = New System.Drawing.Point(103, 37)
        Me.TDescripcion.MaxLength = 250
        Me.TDescripcion.Multiline = True
        Me.TDescripcion.Name = "TDescripcion"
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
        'Pic1
        '
        Me.Pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pic1.Location = New System.Drawing.Point(386, 2)
        Me.Pic1.Name = "Pic1"
        Me.Pic1.Size = New System.Drawing.Size(25, 25)
        Me.Pic1.TabIndex = 12
        Me.Pic1.TabStop = False
        '
        'TDepartamento
        '
        Me.TDepartamento.Location = New System.Drawing.Point(201, 2)
        Me.TDepartamento.Name = "TDepartamento"
        Me.TDepartamento.Size = New System.Drawing.Size(179, 26)
        Me.TDepartamento.TabIndex = 11
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
        'CDepartamento
        '
        Me.CDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CDepartamento.FormattingEnabled = True
        Me.CDepartamento.Location = New System.Drawing.Point(154, 62)
        Me.CDepartamento.Name = "CDepartamento"
        Me.CDepartamento.Size = New System.Drawing.Size(201, 26)
        Me.CDepartamento.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Departamento :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TDepartamento)
        Me.Panel1.Controls.Add(Me.Pic1)
        Me.Panel1.Controls.Add(Me.TDescripcion)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(36, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 105)
        Me.Panel1.TabIndex = 17
        '
        'DepartamentoEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 248)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CDepartamento)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DepartamentoEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar departamento"
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BCancelar As System.Windows.Forms.Button
    Friend WithEvents BGuardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents TDepartamento As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
