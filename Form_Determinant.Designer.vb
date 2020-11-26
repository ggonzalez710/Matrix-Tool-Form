<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Determinant
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.r3c1_A = New System.Windows.Forms.RichTextBox()
        Me.r1c1_A = New System.Windows.Forms.RichTextBox()
        Me.r2c1_A = New System.Windows.Forms.RichTextBox()
        Me.r1c2_A = New System.Windows.Forms.RichTextBox()
        Me.r1c3_A = New System.Windows.Forms.RichTextBox()
        Me.r2c2_A = New System.Windows.Forms.RichTextBox()
        Me.r2c3_A = New System.Windows.Forms.RichTextBox()
        Me.r3c2_A = New System.Windows.Forms.RichTextBox()
        Me.r3c3_A = New System.Windows.Forms.RichTextBox()
        Me.r1c1_B = New System.Windows.Forms.RichTextBox()
        Me.r1c2_B = New System.Windows.Forms.RichTextBox()
        Me.r1c3_B = New System.Windows.Forms.RichTextBox()
        Me.r2c1_B = New System.Windows.Forms.RichTextBox()
        Me.r2c2_B = New System.Windows.Forms.RichTextBox()
        Me.r2c3_B = New System.Windows.Forms.RichTextBox()
        Me.r3c1_B = New System.Windows.Forms.RichTextBox()
        Me.r3c2_B = New System.Windows.Forms.RichTextBox()
        Me.r3c3_B = New System.Windows.Forms.RichTextBox()
        Me.result_A = New System.Windows.Forms.RichTextBox()
        Me.result_B = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DET A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(531, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DET B"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(272, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 29)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "="
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(683, 203)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(27, 29)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "="
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(767, 348)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(78, 29)
        Me.ExitButton.TabIndex = 34
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'r3c1_A
        '
        Me.r3c1_A.BackColor = System.Drawing.SystemColors.Control
        Me.r3c1_A.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.r3c1_A.Location = New System.Drawing.Point(98, 256)
        Me.r3c1_A.Name = "r3c1_A"
        Me.r3c1_A.ReadOnly = True
        Me.r3c1_A.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.r3c1_A.Size = New System.Drawing.Size(46, 57)
        Me.r3c1_A.TabIndex = 35
        Me.r3c1_A.Text = ""
        Me.r3c1_A.WordWrap = False
        '
        'r1c1_A
        '
        Me.r1c1_A.BackColor = System.Drawing.SystemColors.Control
        Me.r1c1_A.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.r1c1_A.Location = New System.Drawing.Point(98, 130)
        Me.r1c1_A.Name = "r1c1_A"
        Me.r1c1_A.ReadOnly = True
        Me.r1c1_A.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.r1c1_A.Size = New System.Drawing.Size(46, 57)
        Me.r1c1_A.TabIndex = 36
        Me.r1c1_A.Text = ""
        Me.r1c1_A.WordWrap = False
        '
        'r2c1_A
        '
        Me.r2c1_A.BackColor = System.Drawing.SystemColors.Control
        Me.r2c1_A.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.r2c1_A.Location = New System.Drawing.Point(98, 193)
        Me.r2c1_A.Name = "r2c1_A"
        Me.r2c1_A.ReadOnly = True
        Me.r2c1_A.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.r2c1_A.Size = New System.Drawing.Size(46, 57)
        Me.r2c1_A.TabIndex = 37
        Me.r2c1_A.Text = ""
        Me.r2c1_A.WordWrap = False
        '
        'r1c2_A
        '
        Me.r1c2_A.BackColor = System.Drawing.SystemColors.Control
        Me.r1c2_A.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.r1c2_A.Location = New System.Drawing.Point(150, 130)
        Me.r1c2_A.Name = "r1c2_A"
        Me.r1c2_A.ReadOnly = True
        Me.r1c2_A.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.r1c2_A.Size = New System.Drawing.Size(46, 57)
        Me.r1c2_A.TabIndex = 38
        Me.r1c2_A.Text = ""
        Me.r1c2_A.WordWrap = False
        '
        'r1c3_A
        '
        Me.r1c3_A.BackColor = System.Drawing.SystemColors.Control
        Me.r1c3_A.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.r1c3_A.Location = New System.Drawing.Point(202, 130)
        Me.r1c3_A.Name = "r1c3_A"
        Me.r1c3_A.ReadOnly = True
        Me.r1c3_A.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.r1c3_A.Size = New System.Drawing.Size(46, 57)
        Me.r1c3_A.TabIndex = 39
        Me.r1c3_A.Text = ""
        Me.r1c3_A.WordWrap = False
        '
        'r2c2_A
        '
        Me.r2c2_A.BackColor = System.Drawing.SystemColors.Control
        Me.r2c2_A.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.r2c2_A.Location = New System.Drawing.Point(150, 193)
        Me.r2c2_A.Name = "r2c2_A"
        Me.r2c2_A.ReadOnly = True
        Me.r2c2_A.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.r2c2_A.Size = New System.Drawing.Size(46, 57)
        Me.r2c2_A.TabIndex = 40
        Me.r2c2_A.Text = ""
        Me.r2c2_A.WordWrap = False
        '
        'r2c3_A
        '
        Me.r2c3_A.BackColor = System.Drawing.SystemColors.Control
        Me.r2c3_A.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.r2c3_A.Location = New System.Drawing.Point(202, 193)
        Me.r2c3_A.Name = "r2c3_A"
        Me.r2c3_A.ReadOnly = True
        Me.r2c3_A.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.r2c3_A.Size = New System.Drawing.Size(46, 57)
        Me.r2c3_A.TabIndex = 41
        Me.r2c3_A.Text = ""
        Me.r2c3_A.WordWrap = False
        '
        'r3c2_A
        '
        Me.r3c2_A.BackColor = System.Drawing.SystemColors.Control
        Me.r3c2_A.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.r3c2_A.Location = New System.Drawing.Point(150, 256)
        Me.r3c2_A.Name = "r3c2_A"
        Me.r3c2_A.ReadOnly = True
        Me.r3c2_A.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.r3c2_A.Size = New System.Drawing.Size(46, 57)
        Me.r3c2_A.TabIndex = 42
        Me.r3c2_A.Text = ""
        Me.r3c2_A.WordWrap = False
        '
        'r3c3_A
        '
        Me.r3c3_A.BackColor = System.Drawing.SystemColors.Control
        Me.r3c3_A.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.r3c3_A.Location = New System.Drawing.Point(202, 256)
        Me.r3c3_A.Name = "r3c3_A"
        Me.r3c3_A.ReadOnly = True
        Me.r3c3_A.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.r3c3_A.Size = New System.Drawing.Size(46, 57)
        Me.r3c3_A.TabIndex = 43
        Me.r3c3_A.Text = ""
        Me.r3c3_A.WordWrap = False
        '
        'r1c1_B
        '
        Me.r1c1_B.BackColor = System.Drawing.SystemColors.Control
        Me.r1c1_B.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.r1c1_B.Location = New System.Drawing.Point(507, 130)
        Me.r1c1_B.Name = "r1c1_B"
        Me.r1c1_B.ReadOnly = True
        Me.r1c1_B.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.r1c1_B.Size = New System.Drawing.Size(46, 57)
        Me.r1c1_B.TabIndex = 44
        Me.r1c1_B.Text = ""
        Me.r1c1_B.WordWrap = False
        '
        'r1c2_B
        '
        Me.r1c2_B.BackColor = System.Drawing.SystemColors.Control
        Me.r1c2_B.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.r1c2_B.Location = New System.Drawing.Point(559, 130)
        Me.r1c2_B.Name = "r1c2_B"
        Me.r1c2_B.ReadOnly = True
        Me.r1c2_B.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.r1c2_B.Size = New System.Drawing.Size(46, 57)
        Me.r1c2_B.TabIndex = 45
        Me.r1c2_B.Text = ""
        Me.r1c2_B.WordWrap = False
        '
        'r1c3_B
        '
        Me.r1c3_B.BackColor = System.Drawing.SystemColors.Control
        Me.r1c3_B.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.r1c3_B.Location = New System.Drawing.Point(611, 130)
        Me.r1c3_B.Name = "r1c3_B"
        Me.r1c3_B.ReadOnly = True
        Me.r1c3_B.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.r1c3_B.Size = New System.Drawing.Size(46, 57)
        Me.r1c3_B.TabIndex = 46
        Me.r1c3_B.Text = ""
        Me.r1c3_B.WordWrap = False
        '
        'r2c1_B
        '
        Me.r2c1_B.BackColor = System.Drawing.SystemColors.Control
        Me.r2c1_B.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.r2c1_B.Location = New System.Drawing.Point(507, 193)
        Me.r2c1_B.Name = "r2c1_B"
        Me.r2c1_B.ReadOnly = True
        Me.r2c1_B.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.r2c1_B.Size = New System.Drawing.Size(46, 57)
        Me.r2c1_B.TabIndex = 47
        Me.r2c1_B.Text = ""
        Me.r2c1_B.WordWrap = False
        '
        'r2c2_B
        '
        Me.r2c2_B.BackColor = System.Drawing.SystemColors.Control
        Me.r2c2_B.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.r2c2_B.Location = New System.Drawing.Point(559, 193)
        Me.r2c2_B.Name = "r2c2_B"
        Me.r2c2_B.ReadOnly = True
        Me.r2c2_B.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.r2c2_B.Size = New System.Drawing.Size(46, 57)
        Me.r2c2_B.TabIndex = 48
        Me.r2c2_B.Text = ""
        Me.r2c2_B.WordWrap = False
        '
        'r2c3_B
        '
        Me.r2c3_B.BackColor = System.Drawing.SystemColors.Control
        Me.r2c3_B.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.r2c3_B.Location = New System.Drawing.Point(611, 193)
        Me.r2c3_B.Name = "r2c3_B"
        Me.r2c3_B.ReadOnly = True
        Me.r2c3_B.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.r2c3_B.Size = New System.Drawing.Size(46, 57)
        Me.r2c3_B.TabIndex = 49
        Me.r2c3_B.Text = ""
        Me.r2c3_B.WordWrap = False
        '
        'r3c1_B
        '
        Me.r3c1_B.BackColor = System.Drawing.SystemColors.Control
        Me.r3c1_B.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.r3c1_B.Location = New System.Drawing.Point(507, 256)
        Me.r3c1_B.Name = "r3c1_B"
        Me.r3c1_B.ReadOnly = True
        Me.r3c1_B.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.r3c1_B.Size = New System.Drawing.Size(46, 57)
        Me.r3c1_B.TabIndex = 50
        Me.r3c1_B.Text = ""
        Me.r3c1_B.WordWrap = False
        '
        'r3c2_B
        '
        Me.r3c2_B.BackColor = System.Drawing.SystemColors.Control
        Me.r3c2_B.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.r3c2_B.Location = New System.Drawing.Point(559, 256)
        Me.r3c2_B.Name = "r3c2_B"
        Me.r3c2_B.ReadOnly = True
        Me.r3c2_B.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.r3c2_B.Size = New System.Drawing.Size(46, 57)
        Me.r3c2_B.TabIndex = 51
        Me.r3c2_B.Text = ""
        Me.r3c2_B.WordWrap = False
        '
        'r3c3_B
        '
        Me.r3c3_B.BackColor = System.Drawing.SystemColors.Control
        Me.r3c3_B.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.r3c3_B.Location = New System.Drawing.Point(611, 256)
        Me.r3c3_B.Name = "r3c3_B"
        Me.r3c3_B.ReadOnly = True
        Me.r3c3_B.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.r3c3_B.Size = New System.Drawing.Size(46, 57)
        Me.r3c3_B.TabIndex = 52
        Me.r3c3_B.Text = ""
        Me.r3c3_B.WordWrap = False
        '
        'result_A
        '
        Me.result_A.BackColor = System.Drawing.SystemColors.Control
        Me.result_A.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.result_A.Location = New System.Drawing.Point(324, 193)
        Me.result_A.Name = "result_A"
        Me.result_A.ReadOnly = True
        Me.result_A.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.result_A.Size = New System.Drawing.Size(46, 57)
        Me.result_A.TabIndex = 53
        Me.result_A.Text = ""
        Me.result_A.WordWrap = False
        '
        'result_B
        '
        Me.result_B.BackColor = System.Drawing.SystemColors.Control
        Me.result_B.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.result_B.Location = New System.Drawing.Point(738, 193)
        Me.result_B.Name = "result_B"
        Me.result_B.ReadOnly = True
        Me.result_B.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.result_B.Size = New System.Drawing.Size(46, 57)
        Me.result_B.TabIndex = 54
        Me.result_B.Text = ""
        Me.result_B.WordWrap = False
        '
        'Form_Determinant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 389)
        Me.ControlBox = False
        Me.Controls.Add(Me.result_B)
        Me.Controls.Add(Me.result_A)
        Me.Controls.Add(Me.r3c3_B)
        Me.Controls.Add(Me.r3c2_B)
        Me.Controls.Add(Me.r3c1_B)
        Me.Controls.Add(Me.r2c3_B)
        Me.Controls.Add(Me.r2c2_B)
        Me.Controls.Add(Me.r2c1_B)
        Me.Controls.Add(Me.r1c3_B)
        Me.Controls.Add(Me.r1c2_B)
        Me.Controls.Add(Me.r1c1_B)
        Me.Controls.Add(Me.r3c3_A)
        Me.Controls.Add(Me.r3c2_A)
        Me.Controls.Add(Me.r2c3_A)
        Me.Controls.Add(Me.r2c2_A)
        Me.Controls.Add(Me.r1c3_A)
        Me.Controls.Add(Me.r1c2_A)
        Me.Controls.Add(Me.r2c1_A)
        Me.Controls.Add(Me.r1c1_A)
        Me.Controls.Add(Me.r3c1_A)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Determinant"
        Me.Text = "Determinant of Matrices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents r3c1_A As RichTextBox
    Friend WithEvents r1c1_A As RichTextBox
    Friend WithEvents r2c1_A As RichTextBox
    Friend WithEvents r1c2_A As RichTextBox
    Friend WithEvents r1c3_A As RichTextBox
    Friend WithEvents r2c2_A As RichTextBox
    Friend WithEvents r2c3_A As RichTextBox
    Friend WithEvents r3c2_A As RichTextBox
    Friend WithEvents r3c3_A As RichTextBox
    Friend WithEvents r1c1_B As RichTextBox
    Friend WithEvents r1c2_B As RichTextBox
    Friend WithEvents r1c3_B As RichTextBox
    Friend WithEvents r2c1_B As RichTextBox
    Friend WithEvents r2c2_B As RichTextBox
    Friend WithEvents r2c3_B As RichTextBox
    Friend WithEvents r3c1_B As RichTextBox
    Friend WithEvents r3c2_B As RichTextBox
    Friend WithEvents r3c3_B As RichTextBox
    Friend WithEvents result_A As RichTextBox
    Friend WithEvents result_B As RichTextBox
End Class
