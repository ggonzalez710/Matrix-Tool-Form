Public Class Form1
    Public tools_flagA As Boolean
    Public tools_flagB As Boolean
    Public close_flag As Boolean

    Public add As New Form_Addition
    Public substract As New Form_Substraction
    Public transpose As New Form_Transpose
    Public multiply As New Form_Multiplication
    Public determinant As New Form_Determinant

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolsToolStripMenuItem.Enabled = "False"
    End Sub

    Private Sub MatrixAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatrixAToolStripMenuItem.Click
        Dim matA As New Form_MatrixA

        If close_flag = "True" Then
            add.Close()
            substract.Close()
            transpose.Close()
            multiply.Close()
            determinant.Close()
            add = New Form_Addition
            substract = New Form_Substraction
            transpose = New Form_Transpose
            multiply = New Form_Multiplication
            determinant = New Form_Determinant
            close_flag = "False"
        End If

        matA.MdiParent = Me
        matA.Show()
        matA.StartPosition = FormStartPosition.Manual
        matA.Location = New Point(0, 0)

    End Sub

    Private Sub MatrixBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatrixBToolStripMenuItem.Click
        Dim matB As New Form_MatrixB

        If close_flag = "True" Then
            add.Close()
            substract.Close()
            transpose.Close()
            multiply.Close()
            determinant.Close()
            add = New Form_Addition
            substract = New Form_Substraction
            transpose = New Form_Transpose
            multiply = New Form_Multiplication
            determinant = New Form_Determinant
            close_flag = "False"
        End If

        matB.MdiParent = Me
        matB.Show()
        matB.StartPosition = FormStartPosition.Manual
        matB.Location = New Point(0, 0)
    End Sub

    Private Sub ABToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABToolStripMenuItem.Click
        add.MdiParent = Me
        add.StartPosition = FormStartPosition.CenterScreen
        add.Show()
    End Sub

    Private Sub ABToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ABToolStripMenuItem1.Click
        substract.MdiParent = Me
        substract.StartPosition = FormStartPosition.CenterScreen
        substract.Show()
    End Sub

    Private Sub ATToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ATToolStripMenuItem.Click
        transpose.MdiParent = Me
        transpose.StartPosition = FormStartPosition.CenterScreen
        transpose.Show()
    End Sub

    Private Sub AXBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AXBToolStripMenuItem.Click
        multiply.MdiParent = Me
        multiply.StartPosition = FormStartPosition.CenterScreen
        multiply.Show()
    End Sub

    Private Sub DETADETBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DETADETBToolStripMenuItem.Click
        determinant.MdiParent = Me
        determinant.StartPosition = FormStartPosition.CenterScreen
        determinant.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about As New Form_About

        about.MdiParent = Me
        about.StartPosition = FormStartPosition.CenterScreen
        about.Show()
    End Sub
End Class
