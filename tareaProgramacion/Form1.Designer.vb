<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdoMasculino = New System.Windows.Forms.RadioButton()
        Me.rdoFemenino = New System.Windows.Forms.RadioButton()
        Me.rdoOtros = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(67, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(67, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(44, 80)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ShortcutsEnabled = False
        Me.txtNombre.Size = New System.Drawing.Size(166, 20)
        Me.txtNombre.TabIndex = 2
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(44, 171)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.ShortcutsEnabled = False
        Me.txtApellido.Size = New System.Drawing.Size(166, 20)
        Me.txtApellido.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdoOtros)
        Me.Panel1.Controls.Add(Me.rdoFemenino)
        Me.Panel1.Controls.Add(Me.rdoMasculino)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(12, 223)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 215)
        Me.Panel1.TabIndex = 4
        '
        'rdoMasculino
        '
        Me.rdoMasculino.AutoSize = True
        Me.rdoMasculino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMasculino.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rdoMasculino.Location = New System.Drawing.Point(57, 48)
        Me.rdoMasculino.Name = "rdoMasculino"
        Me.rdoMasculino.Size = New System.Drawing.Size(107, 24)
        Me.rdoMasculino.TabIndex = 0
        Me.rdoMasculino.TabStop = True
        Me.rdoMasculino.Text = "Masculino"
        Me.rdoMasculino.UseVisualStyleBackColor = True
        '
        'rdoFemenino
        '
        Me.rdoFemenino.AutoSize = True
        Me.rdoFemenino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFemenino.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rdoFemenino.Location = New System.Drawing.Point(57, 102)
        Me.rdoFemenino.Name = "rdoFemenino"
        Me.rdoFemenino.Size = New System.Drawing.Size(106, 24)
        Me.rdoFemenino.TabIndex = 1
        Me.rdoFemenino.TabStop = True
        Me.rdoFemenino.Text = "Femenino"
        Me.rdoFemenino.UseVisualStyleBackColor = True
        '
        'rdoOtros
        '
        Me.rdoOtros.AutoSize = True
        Me.rdoOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoOtros.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rdoOtros.Location = New System.Drawing.Point(59, 158)
        Me.rdoOtros.Name = "rdoOtros"
        Me.rdoOtros.Size = New System.Drawing.Size(62, 24)
        Me.rdoOtros.TabIndex = 2
        Me.rdoOtros.TabStop = True
        Me.rdoOtros.Text = "Otro"
        Me.rdoOtros.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(254, 441)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(270, 480)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(270, 480)
        Me.Name = "Form1"
        Me.Text = "Tarea"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rdoOtros As RadioButton
    Friend WithEvents rdoFemenino As RadioButton
    Friend WithEvents rdoMasculino As RadioButton
End Class
