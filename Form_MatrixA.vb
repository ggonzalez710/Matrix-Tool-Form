Public Class Form_MatrixA
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        'Send input to Form_Addition
        Form1.add.r1c1_A.Text = Val(r1c1.Text)
        Form1.add.r1c2_A.Text = Val(r1c2.Text)
        Form1.add.r1c3_A.Text = Val(r1c3.Text)

        Form1.add.r2c1_A.Text = Val(r2c1.Text)
        Form1.add.r2c2_A.Text = Val(r2c2.Text)
        Form1.add.r2c3_A.Text = Val(r2c3.Text)

        Form1.add.r3c1_A.Text = Val(r3c1.Text)
        Form1.add.r3c2_A.Text = Val(r3c2.Text)
        Form1.add.r3c3_A.Text = Val(r3c3.Text)

        'Send input to Form_Substraction
        Form1.substract.r1c1_A.Text = Val(r1c1.Text)
        Form1.substract.r1c2_A.Text = Val(r1c2.Text)
        Form1.substract.r1c3_A.Text = Val(r1c3.Text)

        Form1.substract.r2c1_A.Text = Val(r2c1.Text)
        Form1.substract.r2c2_A.Text = Val(r2c2.Text)
        Form1.substract.r2c3_A.Text = Val(r2c3.Text)

        Form1.substract.r3c1_A.Text = Val(r3c1.Text)
        Form1.substract.r3c2_A.Text = Val(r3c2.Text)
        Form1.substract.r3c3_A.Text = Val(r3c3.Text)

        'Send input to Form_Transpose
        Form1.transpose.r1c1_A.Text = Val(r1c1.Text)
        Form1.transpose.r1c2_A.Text = Val(r2c1.Text)
        Form1.transpose.r1c3_A.Text = Val(r3c1.Text)

        Form1.transpose.r2c1_A.Text = Val(r1c2.Text)
        Form1.transpose.r2c2_A.Text = Val(r2c2.Text)
        Form1.transpose.r2c3_A.Text = Val(r3c2.Text)

        Form1.transpose.r3c1_A.Text = Val(r1c3.Text)
        Form1.transpose.r3c2_A.Text = Val(r2c3.Text)
        Form1.transpose.r3c3_A.Text = Val(r3c3.Text)

        'Send input to Form_Multiplication
        Form1.multiply.r1c1_A.Text = Val(r1c1.Text)
        Form1.multiply.r1c2_A.Text = Val(r1c2.Text)
        Form1.multiply.r1c3_A.Text = Val(r1c3.Text)

        Form1.multiply.r2c1_A.Text = Val(r2c1.Text)
        Form1.multiply.r2c2_A.Text = Val(r2c2.Text)
        Form1.multiply.r2c3_A.Text = Val(r2c3.Text)

        Form1.multiply.r3c1_A.Text = Val(r3c1.Text)
        Form1.multiply.r3c2_A.Text = Val(r3c2.Text)
        Form1.multiply.r3c3_A.Text = Val(r3c3.Text)

        'Send input to Form_Determinant
        Form1.determinant.r1c1_A.Text = Val(r1c1.Text)
        Form1.determinant.r1c2_A.Text = Val(r1c2.Text)
        Form1.determinant.r1c3_A.Text = Val(r1c3.Text)

        Form1.determinant.r2c1_A.Text = Val(r2c1.Text)
        Form1.determinant.r2c2_A.Text = Val(r2c2.Text)
        Form1.determinant.r2c3_A.Text = Val(r2c3.Text)

        Form1.determinant.r3c1_A.Text = Val(r3c1.Text)
        Form1.determinant.r3c2_A.Text = Val(r3c2.Text)
        Form1.determinant.r3c3_A.Text = Val(r3c3.Text)

        Form1.tools_flagA = "True"
        If Form1.tools_flagB = "True" Then
            Form1.ToolsToolStripMenuItem.Enabled = "True"
        End If

        Me.Close()
    End Sub
End Class