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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatrixAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatrixBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ATToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AXBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DETADETBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1160, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InputToolStripMenuItem
        '
        Me.InputToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MatrixAToolStripMenuItem, Me.MatrixBToolStripMenuItem})
        Me.InputToolStripMenuItem.Name = "InputToolStripMenuItem"
        Me.InputToolStripMenuItem.Size = New System.Drawing.Size(70, 29)
        Me.InputToolStripMenuItem.Text = "Input"
        '
        'MatrixAToolStripMenuItem
        '
        Me.MatrixAToolStripMenuItem.Name = "MatrixAToolStripMenuItem"
        Me.MatrixAToolStripMenuItem.Size = New System.Drawing.Size(180, 34)
        Me.MatrixAToolStripMenuItem.Text = "Matrix A"
        '
        'MatrixBToolStripMenuItem
        '
        Me.MatrixBToolStripMenuItem.Name = "MatrixBToolStripMenuItem"
        Me.MatrixBToolStripMenuItem.Size = New System.Drawing.Size(180, 34)
        Me.MatrixBToolStripMenuItem.Text = "Matrix B"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABToolStripMenuItem, Me.ABToolStripMenuItem1, Me.ATToolStripMenuItem, Me.AXBToolStripMenuItem, Me.DETADETBToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(69, 29)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'ABToolStripMenuItem
        '
        Me.ABToolStripMenuItem.Name = "ABToolStripMenuItem"
        Me.ABToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ABToolStripMenuItem.Text = "A + B"
        '
        'ABToolStripMenuItem1
        '
        Me.ABToolStripMenuItem1.Name = "ABToolStripMenuItem1"
        Me.ABToolStripMenuItem1.Size = New System.Drawing.Size(270, 34)
        Me.ABToolStripMenuItem1.Text = "A - B"
        '
        'ATToolStripMenuItem
        '
        Me.ATToolStripMenuItem.Name = "ATToolStripMenuItem"
        Me.ATToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ATToolStripMenuItem.Text = "A^T , B^T"
        '
        'AXBToolStripMenuItem
        '
        Me.AXBToolStripMenuItem.Name = "AXBToolStripMenuItem"
        Me.AXBToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.AXBToolStripMenuItem.Text = "A x B"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(78, 29)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'DETADETBToolStripMenuItem
        '
        Me.DETADETBToolStripMenuItem.Name = "DETADETBToolStripMenuItem"
        Me.DETADETBToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.DETADETBToolStripMenuItem.Text = "DET A, DET B"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 686)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Matrix Tool Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MatrixAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MatrixBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ATToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AXBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DETADETBToolStripMenuItem As ToolStripMenuItem
End Class
