Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()

    End Sub

    Private Sub LoginForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub



    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUserId.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtPassword.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
        End If
    End Sub



    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnLogin.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim texts As String
        If Not cc.State = ConnectionState.Open Then cc.Open()
        cmd.Connection = cc
        Dim da As New OleDb.OleDbDataAdapter("SELECT count(L_userName) FROM UserMaster where L_userName = '" & txtUserId.Text & "' and L_Password = '" & txtPassword.Text & "'", cc)
        Dim dt As New DataTable
        da.Fill(dt)
        texts = dt.Rows(0).Item(0)
        If texts > 0 Then
            MasterForm.show()
            Me.Hide()
        Else
            MsgBox(" Invalid UserId or Password", vbInformation, "Error in Login")
            btnCreate.Show()

            txtUserId.Clear()
            txtPassword.Clear()
            txtUserId.Focus()

        End If

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        UserMaster.Show()

    End Sub
End Class