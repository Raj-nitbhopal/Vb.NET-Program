Public Class SupplierMaster
    Public table As DataTable()
    Private Function Design()
        If Not cc.State = ConnectionState.Open Then cc.Open()
        cmd.Connection = cc
        Dim da As New OleDb.OleDbDataAdapter("SELECT RetailerId as [Retailer ID],RetailerName as [Retailer Name],Address as [Address ],ContactNo as [Contact  Number],AltContactNo as [Alt Contact No], Email as  [Email ID], CompName as [Company Name], CompContact as [Company Contact No], GST as [GST Number], CompAddress as [Company Address] FROM Retailer", cc)
        Dim dt As New DataTable
        da.Fill(dt)
        dgv1.DataSource = dt
        cc.Close()
        Return 0
    End Function

    Private Sub ClearBox()
        txtretailerId1.Text = ""
        txtRetailerName1.Text = ""
        txtRaddress.Text = ""
        txtRcontactNo1.Text = ""
        txtAltNumber.Text = ""
        txtRemail.Text = ""
        txtCompanyname.Text = ""
        txtCompCnumber.Text = ""
        txtGst.Text = ""
        txtCaddress.Text = ""
        TextBox1.Text = ""
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub



    Private Sub SupplierMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'table.Columns.Add("Medicine Name")
        'table.Columns.Add("Category Type")
        'table.Columns.Add("Batch Number")
        'table.Columns.Add("Quantity")
        'table.Columns.Add("MFG Date")
        'table.Columns.Add("Expiry Date")
        'table.Columns.Add("MRP Rate")
        'table.Columns.Add("Total Price")
        Call Connect()
        Design()
        Me.DataGridView1.Font = New Font("Modern No. 20", 13, FontStyle.Regular)
        DataGridView1.DataSource = table
    End Sub

    Private Sub btnSave1_Click(sender As Object, e As EventArgs) Handles btnSave1.Click
        If txtretailerId1.Text = " " Or txtRaddress.Text = "" Or txtAltNumber.Text = "" Or txtRcontactNo1.Text = "" Or txtCaddress.Text = "" Or txtCompanyname.Text = "" Or txtCompCnumber.Text = "" Or txtGst.Text = "" Then
            MsgBox("Some Fields are Empty", vbInformation, "Empty Field")
        Else
            If Not cc.State = ConnectionState.Open Then cc.Open()
            cmd.Connection = cc
            cmd.CommandText = "INSERT INTO Retailer(RetailerId, RetailerName, Address, ContactNo, AltContactNo, Email,CompName,CompContact,GST,CompAddress) VALUES('" & txtretailerId1.Text & "','" & txtRetailerName1.Text & "','" & txtRaddress.Text & "','" & txtRcontactNo1.Text & "','" & txtAltNumber.Text & "','" & txtRemail.Text & "','" & txtCompanyname.Text & "','" & txtCompCnumber.Text & "','" & txtGst.Text & "','" & txtCaddress.Text & "')"

            cmd.ExecuteNonQuery()

            Design()
            MsgBox(" Save Successfully", vbInformation, "Success")
            ClearBox()
        End If
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub

    Private Sub dgv1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        If dgv1.Rows.Count > 0 Then
            If dgv1.SelectedRows.Count > 0 Then
                Dim RetailerId = dgv1.SelectedRows(0).Cells(0).Value
                If Not cc.State = ConnectionState.Open Then cc.Open()
                cmd.Connection = cc
                Dim da As New OleDb.OleDbDataAdapter(" SELECT * FROM Retailer WHERE RetailerId =" & RetailerId & "", cc)
                Dim dt As New DataTable
                da.Fill(dt)
                txtretailerId1.Text = dt.Rows(0).Item("RetailerId")
                txtRetailerName1.Text = dt.Rows(0).Item("RetailerName")
                txtRaddress.Text = dt.Rows(0).Item("Address")
                txtRcontactNo1.Text = dt.Rows(0).Item("ContactNo")
                txtAltNumber.Text = dt.Rows(0).Item("AltContactNo")
                txtRemail.Text = dt.Rows(0).Item("Email")
                txtCompanyname.Text = dt.Rows(0).Item("CompName")
                txtCompCnumber.Text = dt.Rows(0).Item("CompContact")
                txtGst.Text = dt.Rows(0).Item("GST")
                txtCaddress.Text = dt.Rows(0).Item("CompAddress")
                TextBox1.Text = dt.Rows(0).Item("ID")
                btnSave1.Visible = False
                btnDelete1.Visible = True
                btnUpdate1.Visible = True
                Design()
            End If
        End If

    End Sub

    Private Sub btnDelete1_Click(sender As Object, e As EventArgs) Handles btnDelete1.Click
        If Not cc.State = ConnectionState.Open Then cc.Open()
        cmd.Connection = cc
        If MsgBox("Are you Sure To Delete ?", vbYesNo, "Confirm Delete") = vbYes Then
            cmd.CommandText = "DELETE From Retailer Where ID = " & TextBox1.Text & ""
            cmd.ExecuteNonQuery()
            MsgBox("Deleted Successfully", vbInformation, "Success")
            btnUpdate1.Visible = False
            btnSave1.Visible = True
            btnDelete1.Visible = False
            Design()
            ClearBox()
        End If

    End Sub

    Private Sub btnUpdate1_Click(sender As Object, e As EventArgs) Handles btnUpdate1.Click
        If Not cc.State = ConnectionState.Open Then cc.Open()
        cmd.Connection = cc

        cmd.CommandText = "Update Retailer set RetailerId='" & txtretailerId1.Text & "',RetailerName='" & txtRetailerName1.Text & "',Address='" & txtRaddress.Text & "',ContactNo='" & txtRcontactNo1.Text & "',AltContactNo='" & txtAltNumber.Text & "', Email='" & txtRemail.Text & "',CompName='" & txtCompanyname.Text & "',CompContact='" & txtCompCnumber.Text & "',GST='" & txtGst.Text & "',CompAddress='" & txtCaddress.Text & "' Where ID = " & TextBox1.Text & ""
        cmd.ExecuteNonQuery()
        MsgBox(" Data Updated Successfully ", vbInformation, "Success")
        txtretailerId1.Visible = True
        btnSave1.Visible = True
        btnDelete1.Visible = False
        btnUpdate1.Visible = False
        TextBox1.Text = ""
        Design()
        ClearBox()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub ReatilerInvoice_Click(sender As Object, e As EventArgs) Handles ReatilerInvoice.Click

    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged

    End Sub

    Private Sub cmbCategory_GotFocus(sender As Object, e As EventArgs) Handles cmbCategory.GotFocus
        Dim reader As OleDb.OleDbDataReader
        Dim texts As String
        If Not cc.State = ConnectionState.Open Then cc.Open()
        cmd.Connection = cc
        cmd.CommandText = " select distinct (CategoryName) from ProductMaster order by CategoryName"
        reader = cmd.ExecuteReader
        texts = cmbCategory.Text
        cmbCategory.Items.Clear()
        While reader.Read
            cmbCategory.Items.Add(reader("CategoryName"))
        End While
        cmbCategory.Text = texts
        reader.Close()
        cmbCategory.DroppedDown = True
    End Sub

    Private Sub txtProductName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtProductName_GotFocus(sender As Object, e As EventArgs)
        Dim reader As OleDb.OleDbDataReader
        Dim texts As String
        If Not cc.State = ConnectionState.Open Then cc.Open()
        cmd.Connection = cc
        cmd.CommandText = " select distinct (ProductName) from ProductMaster order by ProductName"
        reader = cmd.ExecuteReader
        texts = cmbProductName.Text
        cmbProductName.Items.Clear()
        While reader.Read
            cmbProductName.Items.Add(reader("ProductName"))
        End While
        cmbProductName.Text = texts
        reader.Close()
        cmbProductName.DroppedDown = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbProductName.Text = "" Then
            MsgBox("Please Enter Medicine Name", vbInformation, "Empty Field")
            cmbProductName.Focus()

        ElseIf cmbCategory.Text = "" Then
            MsgBox("Please Enter Category Type", vbInformation, "Empty Field")
            cmbCategory.Focus()
        ElseIf txtBatch.Text = "" Then
            MsgBox("Please Enter Batch Number", vbInformation, "Empty Field")
            txtBatch.Focus()



        Else

            Dim rows = DataGridView1.RowCount + 1
            'table.Rows.Add(cmbProductName.Text, cmbCategory.Text, txtBatch.Text, txtQuantity.Text, dtmpMfg.Text, dtmpExp.Text, txtMrpRate.Text, txtPrice.Text)
            DataGridView1.DataSource = table



        End If
        'Design()
        Dim TotalQuantity As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            TotalQuantity = TotalQuantity + DataGridView1.Rows(i).Cells(3).Value

        Next
        txtTotalQty.Text = TotalQuantity.ToString
        Dim SubTotal As Double = 0
        For intialization As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
            SubTotal = SubTotal + DataGridView1.Rows(intialization).Cells(7).Value
        Next
        txtsubTotal.Text = SubTotal.ToString
    End Sub

    Private Sub cmbRetailerid_GotFocus(sender As Object, e As EventArgs) Handles cmbRetailerid.GotFocus
        Dim reader As OleDb.OleDbDataReader
        Dim texts As String
        If Not cc.State = ConnectionState.Open Then cc.Open()
        cmd.Connection = cc
        cmd.CommandText = " select distinct (RetailerId) from Retailer order by RetailerId"
        reader = cmd.ExecuteReader
        texts = cmbRetailerid.Text
        cmbRetailerid.Items.Clear()
        While reader.Read
            cmbRetailerid.Items.Add(reader("RetailerId"))
        End While
        cmbRetailerid.Text = texts
        reader.Close()
        cmbRetailerid.DroppedDown = True
    End Sub

    Private Sub cmbRetailerName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRetailerName.SelectedIndexChanged

    End Sub

    Private Sub cmbRetailerName_GotFocus(sender As Object, e As EventArgs) Handles cmbRetailerName.GotFocus
        Dim reader As OleDb.OleDbDataReader
        Dim texts As String
        If Not cc.State = ConnectionState.Open Then cc.Open()
        cmd.Connection = cc
        cmd.CommandText = " select distinct (RetailerName) from Retailer order by RetailerName"
        reader = cmd.ExecuteReader
        texts = cmbRetailerName.Text
        cmbProductName.Items.Clear()
        While reader.Read
            cmbRetailerName.Items.Add(reader("RetailerName"))
        End While
        cmbRetailerName.Text = texts
        reader.Close()
        cmbRetailerName.DroppedDown = True
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class