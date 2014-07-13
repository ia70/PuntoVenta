<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuarioNuevo
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TSexo = New System.Windows.Forms.ComboBox()
        Me.TPassword = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TApellidos = New System.Windows.Forms.TextBox()
        Me.TDireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TTipo = New System.Windows.Forms.ComboBox()
        Me.TUsuario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BBorrar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.P1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellidos :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Dirección :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sexo :"
        '
        'TSexo
        '
        Me.TSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TSexo.FormattingEnabled = True
        Me.TSexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.TSexo.Location = New System.Drawing.Point(133, 247)
        Me.TSexo.Name = "TSexo"
        Me.TSexo.Size = New System.Drawing.Size(120, 26)
        Me.TSexo.TabIndex = 5
        '
        'TPassword
        '
        Me.TPassword.Location = New System.Drawing.Point(141, 88)
        Me.TPassword.Name = "TPassword"
        Me.TPassword.Size = New System.Drawing.Size(120, 26)
        Me.TPassword.TabIndex = 6
        Me.TPassword.UseSystemPasswordChar = True
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(141, 152)
        Me.TNombre.MaxLength = 30
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(254, 26)
        Me.TNombre.TabIndex = 7
        '
        'TApellidos
        '
        Me.TApellidos.Location = New System.Drawing.Point(141, 181)
        Me.TApellidos.MaxLength = 30
        Me.TApellidos.Name = "TApellidos"
        Me.TApellidos.Size = New System.Drawing.Size(254, 26)
        Me.TApellidos.TabIndex = 8
        '
        'TDireccion
        '
        Me.TDireccion.Location = New System.Drawing.Point(133, 279)
        Me.TDireccion.MaxLength = 240
        Me.TDireccion.Name = "TDireccion"
        Me.TDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TDireccion.Size = New System.Drawing.Size(262, 26)
        Me.TDireccion.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tipo :"
        '
        'TTipo
        '
        Me.TTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TTipo.FormattingEnabled = True
        Me.TTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TTipo.Items.AddRange(New Object() {"Administrador", "Cajero"})
        Me.TTipo.Location = New System.Drawing.Point(141, 120)
        Me.TTipo.Name = "TTipo"
        Me.TTipo.Size = New System.Drawing.Size(120, 26)
        Me.TTipo.TabIndex = 11
        '
        'TUsuario
        '
        Me.TUsuario.Location = New System.Drawing.Point(141, 56)
        Me.TUsuario.Name = "TUsuario"
        Me.TUsuario.Size = New System.Drawing.Size(120, 26)
        Me.TUsuario.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Usuario :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(300, 29)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Datos del nuevo usuario:"
        '
        'BGuardar
        '
        Me.BGuardar.Location = New System.Drawing.Point(302, 330)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(93, 29)
        Me.BGuardar.TabIndex = 16
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'BBorrar
        '
        Me.BBorrar.Location = New System.Drawing.Point(191, 330)
        Me.BBorrar.Name = "BBorrar"
        Me.BBorrar.Size = New System.Drawing.Size(93, 29)
        Me.BBorrar.TabIndex = 17
        Me.BBorrar.Text = "Borrar"
        Me.BBorrar.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(81, 330)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(93, 29)
        Me.BCancelar.TabIndex = 18
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(40, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 19)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Fecha de  Nacimiento :"
        '
        'TNacimiento
        '
        Me.TNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TNacimiento.Location = New System.Drawing.Point(223, 210)
        Me.TNacimiento.MaxDate = New Date(2010, 12, 31, 0, 0, 0, 0)
        Me.TNacimiento.MinDate = New Date(1975, 1, 1, 0, 0, 0, 0)
        Me.TNacimiento.Name = "TNacimiento"
        Me.TNacimiento.Size = New System.Drawing.Size(172, 26)
        Me.TNacimiento.TabIndex = 20
        Me.TNacimiento.Value = New Date(2010, 12, 31, 0, 0, 0, 0)
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.Abarrotes.My.Resources.Resources.Select_2
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox7.Location = New System.Drawing.Point(401, 279)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox7.TabIndex = 27
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.Abarrotes.My.Resources.Resources.Select_2
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(259, 247)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox6.TabIndex = 26
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.Abarrotes.My.Resources.Resources.Select_2
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(401, 181)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox5.TabIndex = 25
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.Abarrotes.My.Resources.Resources.Select_2
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(401, 152)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Abarrotes.My.Resources.Resources.Select_2
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(267, 120)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Abarrotes.My.Resources.Resources.Select_2
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(267, 88)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'P1
        '
        Me.P1.BackgroundImage = Global.Abarrotes.My.Resources.Resources.Select_2
        Me.P1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.P1.Location = New System.Drawing.Point(267, 56)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(26, 26)
        Me.P1.TabIndex = 21
        Me.P1.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = Global.Abarrotes.My.Resources.Resources.Select_2
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox8.Location = New System.Drawing.Point(401, 210)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox8.TabIndex = 28
        Me.PictureBox8.TabStop = False
        '
        'UsuarioNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(436, 370)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.P1)
        Me.Controls.Add(Me.TNacimiento)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BBorrar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TUsuario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TTipo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TDireccion)
        Me.Controls.Add(Me.TApellidos)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.TPassword)
        Me.Controls.Add(Me.TSexo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UsuarioNuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Usuario"
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TSexo As System.Windows.Forms.ComboBox
    Friend WithEvents TPassword As System.Windows.Forms.TextBox
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents TApellidos As System.Windows.Forms.TextBox
    Friend WithEvents TDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TTipo As System.Windows.Forms.ComboBox
    Friend WithEvents TUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BGuardar As System.Windows.Forms.Button
    Friend WithEvents BBorrar As System.Windows.Forms.Button
    Friend WithEvents BCancelar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents P1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
End Class
