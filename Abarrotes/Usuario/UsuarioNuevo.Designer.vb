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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BBorrar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Pic8 = New System.Windows.Forms.PictureBox()
        Me.Pic7 = New System.Windows.Forms.PictureBox()
        Me.Pic5 = New System.Windows.Forms.PictureBox()
        Me.Pic4 = New System.Windows.Forms.PictureBox()
        Me.Pic3 = New System.Windows.Forms.PictureBox()
        Me.Pic2 = New System.Windows.Forms.PictureBox()
        Me.Pic6 = New System.Windows.Forms.PictureBox()
        Me.Pic9 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Eti2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TUsuario = New System.Windows.Forms.TextBox()
        Me.Eti1 = New System.Windows.Forms.Label()
        Me.Pic1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        CType(Me.Pic8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellidos :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Dirección :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sexo :"
        '
        'TSexo
        '
        Me.TSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TSexo.Enabled = False
        Me.TSexo.FormattingEnabled = True
        Me.TSexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.TSexo.Location = New System.Drawing.Point(97, 97)
        Me.TSexo.Name = "TSexo"
        Me.TSexo.Size = New System.Drawing.Size(120, 26)
        Me.TSexo.TabIndex = 5
        '
        'TPassword
        '
        Me.TPassword.Enabled = False
        Me.TPassword.Location = New System.Drawing.Point(113, 0)
        Me.TPassword.MaxLength = 15
        Me.TPassword.Name = "TPassword"
        Me.TPassword.Size = New System.Drawing.Size(112, 26)
        Me.TPassword.TabIndex = 6
        Me.TPassword.UseSystemPasswordChar = True
        '
        'TNombre
        '
        Me.TNombre.Enabled = False
        Me.TNombre.Location = New System.Drawing.Point(105, 1)
        Me.TNombre.MaxLength = 30
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(254, 26)
        Me.TNombre.TabIndex = 7
        '
        'TApellidos
        '
        Me.TApellidos.Enabled = False
        Me.TApellidos.Location = New System.Drawing.Point(105, 31)
        Me.TApellidos.MaxLength = 30
        Me.TApellidos.Name = "TApellidos"
        Me.TApellidos.Size = New System.Drawing.Size(254, 26)
        Me.TApellidos.TabIndex = 8
        '
        'TDireccion
        '
        Me.TDireccion.Enabled = False
        Me.TDireccion.Location = New System.Drawing.Point(97, 129)
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
        Me.Label6.Location = New System.Drawing.Point(3, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tipo :"
        '
        'TTipo
        '
        Me.TTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TTipo.Enabled = False
        Me.TTipo.FormattingEnabled = True
        Me.TTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TTipo.Items.AddRange(New Object() {"Administrador", "Cajero"})
        Me.TTipo.Location = New System.Drawing.Point(104, 1)
        Me.TTipo.Name = "TTipo"
        Me.TTipo.Size = New System.Drawing.Size(120, 26)
        Me.TTipo.TabIndex = 11
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
        Me.BGuardar.Enabled = False
        Me.BGuardar.Location = New System.Drawing.Point(266, 214)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(93, 29)
        Me.BGuardar.TabIndex = 16
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'BBorrar
        '
        Me.BBorrar.Enabled = False
        Me.BBorrar.Location = New System.Drawing.Point(155, 214)
        Me.BBorrar.Name = "BBorrar"
        Me.BBorrar.Size = New System.Drawing.Size(93, 29)
        Me.BBorrar.TabIndex = 17
        Me.BBorrar.Text = "Borrar"
        Me.BBorrar.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(45, 214)
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
        Me.Label9.Location = New System.Drawing.Point(4, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 19)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Fecha de  Nacimiento :"
        '
        'TNacimiento
        '
        Me.TNacimiento.Enabled = False
        Me.TNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TNacimiento.Location = New System.Drawing.Point(187, 60)
        Me.TNacimiento.MaxDate = New Date(2010, 12, 31, 0, 0, 0, 0)
        Me.TNacimiento.MinDate = New Date(1975, 1, 1, 0, 0, 0, 0)
        Me.TNacimiento.Name = "TNacimiento"
        Me.TNacimiento.Size = New System.Drawing.Size(172, 26)
        Me.TNacimiento.TabIndex = 20
        Me.TNacimiento.Value = New Date(2010, 12, 31, 0, 0, 0, 0)
        '
        'Pic8
        '
        Me.Pic8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pic8.Location = New System.Drawing.Point(365, 129)
        Me.Pic8.Name = "Pic8"
        Me.Pic8.Size = New System.Drawing.Size(26, 26)
        Me.Pic8.TabIndex = 27
        Me.Pic8.TabStop = False
        '
        'Pic7
        '
        Me.Pic7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pic7.Location = New System.Drawing.Point(223, 97)
        Me.Pic7.Name = "Pic7"
        Me.Pic7.Size = New System.Drawing.Size(26, 26)
        Me.Pic7.TabIndex = 26
        Me.Pic7.TabStop = False
        '
        'Pic5
        '
        Me.Pic5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pic5.Location = New System.Drawing.Point(365, 31)
        Me.Pic5.Name = "Pic5"
        Me.Pic5.Size = New System.Drawing.Size(26, 26)
        Me.Pic5.TabIndex = 25
        Me.Pic5.TabStop = False
        '
        'Pic4
        '
        Me.Pic4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pic4.Location = New System.Drawing.Point(365, 1)
        Me.Pic4.Name = "Pic4"
        Me.Pic4.Size = New System.Drawing.Size(26, 26)
        Me.Pic4.TabIndex = 24
        Me.Pic4.TabStop = False
        '
        'Pic3
        '
        Me.Pic3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pic3.Location = New System.Drawing.Point(230, 1)
        Me.Pic3.Name = "Pic3"
        Me.Pic3.Size = New System.Drawing.Size(26, 26)
        Me.Pic3.TabIndex = 23
        Me.Pic3.TabStop = False
        '
        'Pic2
        '
        Me.Pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pic2.Location = New System.Drawing.Point(231, 1)
        Me.Pic2.Name = "Pic2"
        Me.Pic2.Size = New System.Drawing.Size(26, 26)
        Me.Pic2.TabIndex = 22
        Me.Pic2.TabStop = False
        '
        'Pic6
        '
        Me.Pic6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pic6.Location = New System.Drawing.Point(365, 60)
        Me.Pic6.Name = "Pic6"
        Me.Pic6.Size = New System.Drawing.Size(26, 26)
        Me.Pic6.TabIndex = 28
        Me.Pic6.TabStop = False
        '
        'Pic9
        '
        Me.Pic9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pic9.Location = New System.Drawing.Point(231, 160)
        Me.Pic9.Name = "Pic9"
        Me.Pic9.Size = New System.Drawing.Size(26, 26)
        Me.Pic9.TabIndex = 31
        Me.Pic9.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(97, 160)
        Me.TextBox1.MaxLength = 15
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBox1.Size = New System.Drawing.Size(128, 26)
        Me.TextBox1.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 19)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Telefono :"
        '
        'Eti2
        '
        Me.Eti2.AutoSize = True
        Me.Eti2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Eti2.ForeColor = System.Drawing.Color.Black
        Me.Eti2.Location = New System.Drawing.Point(102, 30)
        Me.Eti2.Name = "Eti2"
        Me.Eti2.Size = New System.Drawing.Size(132, 18)
        Me.Eti2.TabIndex = 33
        Me.Eti2.Text = "Min. 4 Caracteres"
        Me.Eti2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TUsuario)
        Me.Panel1.Controls.Add(Me.Eti1)
        Me.Panel1.Controls.Add(Me.Pic1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 48)
        Me.Panel1.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Usuario :"
        '
        'TUsuario
        '
        Me.TUsuario.Location = New System.Drawing.Point(105, 1)
        Me.TUsuario.MaxLength = 15
        Me.TUsuario.Name = "TUsuario"
        Me.TUsuario.Size = New System.Drawing.Size(120, 26)
        Me.TUsuario.TabIndex = 14
        '
        'Eti1
        '
        Me.Eti1.AutoSize = True
        Me.Eti1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Eti1.ForeColor = System.Drawing.Color.Black
        Me.Eti1.Location = New System.Drawing.Point(102, 30)
        Me.Eti1.Name = "Eti1"
        Me.Eti1.Size = New System.Drawing.Size(130, 18)
        Me.Eti1.TabIndex = 32
        Me.Eti1.Text = "Usuario Existente"
        Me.Eti1.Visible = False
        '
        'Pic1
        '
        Me.Pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pic1.Location = New System.Drawing.Point(231, 1)
        Me.Pic1.Name = "Pic1"
        Me.Pic1.Size = New System.Drawing.Size(26, 26)
        Me.Pic1.TabIndex = 21
        Me.Pic1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TPassword)
        Me.Panel2.Controls.Add(Me.Eti2)
        Me.Panel2.Controls.Add(Me.Pic2)
        Me.Panel2.Location = New System.Drawing.Point(3, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(260, 48)
        Me.Panel2.TabIndex = 35
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.TTipo)
        Me.Panel3.Controls.Add(Me.Pic3)
        Me.Panel3.Location = New System.Drawing.Point(3, 111)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(259, 30)
        Me.Panel3.TabIndex = 36
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(39, 53)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(402, 397)
        Me.FlowLayoutPanel1.TabIndex = 37
        '
        'Panel4
        '
        Me.Panel4.AutoSize = True
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.BCancelar)
        Me.Panel4.Controls.Add(Me.BBorrar)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Pic9)
        Me.Panel4.Controls.Add(Me.BGuardar)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.TSexo)
        Me.Panel4.Controls.Add(Me.Pic6)
        Me.Panel4.Controls.Add(Me.TNombre)
        Me.Panel4.Controls.Add(Me.Pic8)
        Me.Panel4.Controls.Add(Me.TApellidos)
        Me.Panel4.Controls.Add(Me.Pic7)
        Me.Panel4.Controls.Add(Me.TDireccion)
        Me.Panel4.Controls.Add(Me.Pic5)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Pic4)
        Me.Panel4.Controls.Add(Me.TNacimiento)
        Me.Panel4.Location = New System.Drawing.Point(3, 147)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(394, 246)
        Me.Panel4.TabIndex = 38
        '
        'UsuarioNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(464, 473)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label8)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UsuarioNuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Usuario"
        CType(Me.Pic8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BGuardar As System.Windows.Forms.Button
    Friend WithEvents BBorrar As System.Windows.Forms.Button
    Friend WithEvents BCancelar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic3 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic4 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic5 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic7 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic8 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic6 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic9 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Eti2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents Eti1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
End Class
