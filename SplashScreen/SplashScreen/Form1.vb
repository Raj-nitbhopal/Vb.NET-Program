Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 1000 Then
            ProgressBar1.Value = ProgressBar1.Value + 1
        Else
            LoginForm.show()
            Timer1.Enabled = False
            Me.Hide()

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
    End Sub
End Class
