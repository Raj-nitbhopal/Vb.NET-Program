Public Class UserMaster
    Private Sub ClearBox()
        txtUserId.Text = ""
        txtName.Text = ""
        txtAddress.Text = ""
        txtAlternate.Text = ""
        txtContact.Text = ""
        txtEmail.Text = ""
        txtPassword.Text = ""
        txtPassword.Text = ""

    End Sub
    Private Function Design()
        If Not cc.State = ConnectionState.Open Then cc.Open()
        cmd.Connection = cc
        Dim da As New OleDb.OleDbDataAdapter("SELECT UserId as [User ID], UserName as [User Name], Address as [Address], ContactNo as [Contact No], Alternate as [Alternate No], EmailId as [Email ID], L_userName as [Login userName], L_Password as [Login Password] FROM UserMaster", cc)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        cc.Close()
        Return 0
    End Function
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtUserId.Text = " " Or txtName.Text = "" Or txtContact.Text = "" Or txtAlternate.Text = "" Or txtAddress.Text = "" Or txtEmail.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Some Fields are Empty", vbInformation, "Empty Field")
        Else
            If Not cc.State = ConnectionState.Open Then cc.Open()
            cmd.Connection = cc
            cmd.CommandText = "INSERT INTO UserMaster(UserId,UserName,Address,ContactNo,Alternate, EmailId,L_userName, L_Password) VALUES('" & txtUserId.Text & "', '" & txtName.Text & "', '" & txtAddress.Text & "', '" & txtContact.Text & "', '" & txtAlternate.Text & "', '" & txtEmail.Text & "', '" & txtUsername.Text & "', '" & txtPassword.Text & "')"

            cmd.ExecuteNonQuery()

            Design()
            MsgBox(" Save Successfully", vbInformation, "Success")
            ClearBox()
        End If
    End Sub

    Private Sub UserMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
        Design()
        Me.DataGridView1.Font = New Font("Modern No. 20", 13, FontStyle.Regular)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If DataGridView1.Rows.Count > 0 Then
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim UserId = DataGridView1.SelectedRows(0).Cells(0).Value
                If Not cc.State = ConnectionState.Open Then cc.Open()
                cmd.Connection = cc
                Dim da As New OleDb.OleDbDataAdapter(" Select * FROM UserMaster WHERE UserId =" & UserId & "", cc)
                Dim dt As New DataTable
                da.Fill(dt)
                txtUserId.Text = dt.Rows(0).Item("UserId")
                txtName.Text = dt.Rows(0).Item("UserName")
                txtAddress.Text = dt.Rows(0).Item("Address")
                txtContact.Text = dt.Rows(0).Item("ContactNo")
                txtAlternate.Text = dt.Rows(0).Item("Alternate")
                txtEmail.Text = dt.Rows(0).Item("EmailId")
                txtUsername.Text = dt.Rows(0).Item("L_Username")
                txtPassword.Text = dt.Rows(0).Item("L_Password")

                TextBox1.Text = dt.Rows(0).Item("ID")
                btnSave.Visible = False
                btnDelete.Visible = True
                btnUpdate.Visible = True
                Design()

            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If Not cc.State = ConnectionState.Open Then cc.Open()
        cmd.Connection = cc
        If MsgBox("Are you Sure To Delete ?", vbYesNo, "Confirm Delete") = vbYes Then
            cmd.CommandText = "DELETE From UserMaster Where ID = " & TextBox1.Text & ""
            cmd.ExecuteNonQuery()
            MsgBox("Deleted Successfully", vbInformation, "Success")
            btnUpdate.Visible = False
            btnSave.Visible = True
            btnDelete.Visible = False
            Design()
            ClearBox()
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not cc.State = ConnectionState.Open Then cc.Open()
        cmd.Connection = cc

        cmd.CommandText = "Update UserMaster Set UserId='" & txtUserId.Text & "',UserName='" & txtName.Text & "',Address='" & txtAddress.Text & "',ContactNo='" & txtContact.Text & "',Alternate='" & txtAlternate.Text & "', EmailId='" & txtEmail.Text & "',L_userName='" & txtUsername.Text & "',L_Password='" & txtPassword.Text & "' Where ID = " & TextBox1.Text & ""
        cmd.ExecuteNonQuery()
        MsgBox(" Data Updated Successfully ", vbInformation, "Success")
        txtUserId.Visible = True
        btnSave.Visible = True
        btnDelete.Visible = False
        btnUpdate.Visible = False
        TextBox1.Text = ""
        Design()
        ClearBox()
    End Sub
End Class