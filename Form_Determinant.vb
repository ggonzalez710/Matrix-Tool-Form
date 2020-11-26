Public Class Form_Determinant
    Private Sub Form_Determinant_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        result_A.Text = Val(r1c1_A.Text) * ((Val(r2c2_A.Text) * Val(r3c3_A.Text) - Val(r2c3_A.Text) * Val(r3c2_A.Text))) _
                        - Val(r1c2_A.Text) * ((Val(r2c1_A.Text) * Val(r3c3_A.Text) - Val(r2c3_A.Text) * Val(r3c1_A.Text))) _
                        + Val(r1c3_A.Text) * ((Val(r2c1_A.Text) * Val(r3c2_A.Text) - Val(r2c2_A.Text) * Val(r3c1_A.Text)))

        result_B.Text = Val(r1c1_B.Text) * ((Val(r2c2_B.Text) * Val(r3c3_B.Text) - Val(r2c3_B.Text) * Val(r3c2_B.Text))) _
                        - Val(r1c2_B.Text) * ((Val(r2c1_B.Text) * Val(r3c3_B.Text) - Val(r2c3_B.Text) * Val(r3c1_B.Text))) _
                        + Val(r1c3_B.Text) * ((Val(r2c1_B.Text) * Val(r3c2_B.Text) - Val(r2c2_B.Text) * Val(r3c1_B.Text)))

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Form1.close_flag = "True"
        Me.Hide()
    End Sub

End Class