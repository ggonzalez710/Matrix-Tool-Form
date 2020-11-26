Public Class Form_Addition
    Private Sub Form_Addition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        r1c1_C.Text = Val(r1c1_A.Text) + Val(r1c1_B.Text)
        r1c2_C.Text = Val(r1c2_A.Text) + Val(r1c2_B.Text)
        r1c3_C.Text = Val(r1c3_A.Text) + Val(r1c3_B.Text)
        r2c1_C.Text = Val(r2c1_A.Text) + Val(r2c1_B.Text)
        r2c2_C.Text = Val(r2c2_A.Text) + Val(r2c2_B.Text)
        r2c3_C.Text = Val(r2c3_A.Text) + Val(r2c3_B.Text)
        r3c1_C.Text = Val(r3c1_A.Text) + Val(r3c1_B.Text)
        r3c2_C.Text = Val(r3c2_A.Text) + Val(r3c2_B.Text)
        r3c3_C.Text = Val(r3c3_A.Text) + Val(r3c3_B.Text)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Form1.close_flag = "True"
        Me.Hide()
    End Sub

End Class