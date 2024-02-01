<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbDepart = New System.Windows.Forms.ComboBox()
        Me.gboxDatos = New System.Windows.Forms.GroupBox()
        Me.tbSalario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbYears = New System.Windows.Forms.TextBox()
        Me.tbCedula = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbMaster = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.gboxDatos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(658, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GESTOR DE MÉRITOS DE COLABORADORES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del empleado: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cédula: "
        '
        'cbDepart
        '
        Me.cbDepart.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDepart.FormattingEnabled = True
        Me.cbDepart.Items.AddRange(New Object() {"INGENIERÍA", "RRHH", "SOPORTE TI", "SALUD", "SEGURIDAD", "ASEO", "MANTENIMIENTO"})
        Me.cbDepart.Location = New System.Drawing.Point(10, 245)
        Me.cbDepart.Name = "cbDepart"
        Me.cbDepart.Size = New System.Drawing.Size(173, 27)
        Me.cbDepart.TabIndex = 3
        Me.cbDepart.Text = "Departamento"
        '
        'gboxDatos
        '
        Me.gboxDatos.Controls.Add(Me.tbSalario)
        Me.gboxDatos.Controls.Add(Me.Label5)
        Me.gboxDatos.Controls.Add(Me.tbYears)
        Me.gboxDatos.Controls.Add(Me.tbCedula)
        Me.gboxDatos.Controls.Add(Me.tbNombre)
        Me.gboxDatos.Controls.Add(Me.Label4)
        Me.gboxDatos.Controls.Add(Me.Label2)
        Me.gboxDatos.Controls.Add(Me.rbMaster)
        Me.gboxDatos.Controls.Add(Me.cbDepart)
        Me.gboxDatos.Controls.Add(Me.Label3)
        Me.gboxDatos.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxDatos.Location = New System.Drawing.Point(12, 87)
        Me.gboxDatos.Name = "gboxDatos"
        Me.gboxDatos.Size = New System.Drawing.Size(391, 302)
        Me.gboxDatos.TabIndex = 5
        Me.gboxDatos.TabStop = False
        Me.gboxDatos.Text = "Datos personales"
        '
        'tbSalario
        '
        Me.tbSalario.Location = New System.Drawing.Point(206, 156)
        Me.tbSalario.Name = "tbSalario"
        Me.tbSalario.Size = New System.Drawing.Size(100, 27)
        Me.tbSalario.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Salario base: "
        '
        'tbYears
        '
        Me.tbYears.Location = New System.Drawing.Point(206, 114)
        Me.tbYears.Name = "tbYears"
        Me.tbYears.Size = New System.Drawing.Size(31, 27)
        Me.tbYears.TabIndex = 8
        '
        'tbCedula
        '
        Me.tbCedula.Location = New System.Drawing.Point(206, 73)
        Me.tbCedula.Name = "tbCedula"
        Me.tbCedula.Size = New System.Drawing.Size(125, 27)
        Me.tbCedula.TabIndex = 7
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(206, 31)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(164, 27)
        Me.tbNombre.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Años de servicio: "
        '
        'rbMaster
        '
        Me.rbMaster.AutoSize = True
        Me.rbMaster.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMaster.Location = New System.Drawing.Point(10, 201)
        Me.rbMaster.Name = "rbMaster"
        Me.rbMaster.Size = New System.Drawing.Size(191, 23)
        Me.rbMaster.TabIndex = 4
        Me.rbMaster.TabStop = True
        Me.rbMaster.Text = "Poseedor de maestría"
        Me.rbMaster.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(441, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(233, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btnVerificar
        '
        Me.btnVerificar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificar.Location = New System.Drawing.Point(441, 332)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(230, 37)
        Me.btnVerificar.TabIndex = 8
        Me.btnVerificar.Text = "Verificar "
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 406)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gboxDatos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = " SOFTWARE GESTIÓN DE MÉRITOS"
        Me.gboxDatos.ResumeLayout(False)
        Me.gboxDatos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbDepart As ComboBox
    Friend WithEvents gboxDatos As GroupBox
    Friend WithEvents tbYears As TextBox
    Friend WithEvents tbCedula As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents rbMaster As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnVerificar As Button
    Friend WithEvents tbSalario As TextBox
    Friend WithEvents Label5 As Label
End Class
