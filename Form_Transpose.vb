Public Class Form_Transpose
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Form1.close_flag = "True"
        Me.Hide()
    End Sub

    Private Sub Form_Transpose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExitButton.Select()
    End Sub
End Class