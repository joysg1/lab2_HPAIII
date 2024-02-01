<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbSalarioTotal = New System.Windows.Forms.Label()
        Me.lbAumentoStudy = New System.Windows.Forms.Label()
        Me.lbAumentoYears = New System.Windows.Forms.Label()
        Me.lbSalarioBase = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lbMensaje = New System.Windows.Forms.Label()
        Me.lbMensajeAuto = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SALARIO BASE: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "RESULTADOS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "AUMENTO POR ANTIGUEDAD: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(218, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "AUMENTO POR ESTUDIOS:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "SALARIO TOTAL: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbMensajeAuto)
        Me.GroupBox1.Controls.Add(Me.lbSalarioTotal)
        Me.GroupBox1.Controls.Add(Me.lbAumentoStudy)
        Me.GroupBox1.Controls.Add(Me.lbAumentoYears)
        Me.GroupBox1.Controls.Add(Me.lbSalarioBase)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 266)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CÁLCULOS REALIZADOS"
        '
        'lbSalarioTotal
        '
        Me.lbSalarioTotal.AutoSize = True
        Me.lbSalarioTotal.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSalarioTotal.Location = New System.Drawing.Point(286, 173)
        Me.lbSalarioTotal.Name = "lbSalarioTotal"
        Me.lbSalarioTotal.Size = New System.Drawing.Size(18, 19)
        Me.lbSalarioTotal.TabIndex = 10
        Me.lbSalarioTotal.Text = "0"
        '
        'lbAumentoStudy
        '
        Me.lbAumentoStudy.AutoSize = True
        Me.lbAumentoStudy.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAumentoStudy.Location = New System.Drawing.Point(286, 128)
        Me.lbAumentoStudy.Name = "lbAumentoStudy"
        Me.lbAumentoStudy.Size = New System.Drawing.Size(18, 19)
        Me.lbAumentoStudy.TabIndex = 9
        Me.lbAumentoStudy.Text = "0"
        '
        'lbAumentoYears
        '
        Me.lbAumentoYears.AutoSize = True
        Me.lbAumentoYears.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAumentoYears.Location = New System.Drawing.Point(286, 86)
        Me.lbAumentoYears.Name = "lbAumentoYears"
        Me.lbAumentoYears.Size = New System.Drawing.Size(18, 19)
        Me.lbAumentoYears.TabIndex = 8
        Me.lbAumentoYears.Text = "0"
        '
        'lbSalarioBase
        '
        Me.lbSalarioBase.AutoSize = True
        Me.lbSalarioBase.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSalarioBase.Location = New System.Drawing.Point(286, 38)
        Me.lbSalarioBase.Name = "lbSalarioBase"
        Me.lbSalarioBase.Size = New System.Drawing.Size(18, 19)
        Me.lbSalarioBase.TabIndex = 7
        Me.lbSalarioBase.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(513, 116)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 192)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(513, 333)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(185, 44)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lbMensaje
        '
        Me.lbMensaje.AutoSize = True
        Me.lbMensaje.Font = New System.Drawing.Font("Arial", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMensaje.Location = New System.Drawing.Point(12, 79)
        Me.lbMensaje.Name = "lbMensaje"
        Me.lbMensaje.Size = New System.Drawing.Size(73, 16)
        Me.lbMensaje.TabIndex = 10
        Me.lbMensaje.Text = "MENSAJE"
        '
        'lbMensajeAuto
        '
        Me.lbMensajeAuto.AutoSize = True
        Me.lbMensajeAuto.Font = New System.Drawing.Font("Arial", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMensajeAuto.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbMensajeAuto.Location = New System.Drawing.Point(6, 214)
        Me.lbMensajeAuto.Name = "lbMensajeAuto"
        Me.lbMensajeAuto.Size = New System.Drawing.Size(73, 16)
        Me.lbMensajeAuto.TabIndex = 11
        Me.lbMensajeAuto.Text = "MENSAJE"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 463)
        Me.Controls.Add(Me.lbMensaje)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "RESULTADOS FINALES BASADO EN MÉRITO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbSalarioTotal As Label
    Friend WithEvents lbAumentoStudy As Label
    Friend WithEvents lbAumentoYears As Label
    Friend WithEvents lbSalarioBase As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lbMensaje As Label
    Friend WithEvents lbMensajeAuto As Label
End Class
