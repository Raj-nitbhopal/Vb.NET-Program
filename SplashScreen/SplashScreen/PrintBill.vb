Public Class PrintBill
    Dim table As New DataTable()
    Private Sub PrintBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        table.Columns.Add("Medicine Name")
        table.Columns.Add("Category Type")
        table.Columns.Add("Batch Number")
        table.Columns.Add("Quantity")
        table.Columns.Add("MFG Date")
        table.Columns.Add("Expiry Date")
        table.Columns.Add("MRP Rate")
        table.Columns.Add("Total Price")
        Call Connect()
        'Design()
        Me.DataGridView1.Font = New Font("Modern No. 20", 13, FontStyle.Regular)
        DataGridView1.DataSource = table
    End Sub
    'Private Function Design()
    '    If Not cc.State = ConnectionState.Open Then cc.Open()
    '    cmd.Connection = cc
    '    Dim da As New OleDb.OleDbDataAdapter("SELECT ProductName as [Product Name],CategoryName as [Category Name],BatchNo as [Batch No] ,MfgDate as [MFG Date], ExpDate as [Expiry Date], MrpRate as  [MRP Rate] FROM ProductMaster", cc)
    '    Dim dt As New DataTable
    '    da.Fill(dt)
    '    ' DataGridView1.DataSource = dt
    '    cc.Close()

    '    Return 0
    'End Function
    Private Sub ClearBox()
        txtCustomerName.Text = ""
        txtBillNo.Text = ""
        txtAddress.Text = ""
        txtBatch.Text = ""
        txtgstamount.Text = ""
        txtDiscount.Text = ""
        dtmpMfg.Text = ""
        dtmpExp.Text = ""
        txtMrpRate.Text = ""
        txtPaidamo.Text = ""
        cmbProductName.Text = ""
        txtQuantity.Text = ""
        txtRefered.Text = ""
        txtRemark.Text = ""
        txtgstRate.Text = ""
        txtTotalAmount.Text = ""
        txtDues.Text = ""
        txtDiscAmnt.Text = ""
        txtsubTotal.Text = ""
        txtTotalQ.Text = ""
        cmbCategory.Text = ""
        txtPrice.Text = ""
        dtmpBillDate.Text = ""
        txtContactNo.Text = ""
        cmbPayment.Text = ""



    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If txtBillNo.Text = " " Or txtCustomerName.Text = "" Or txtAddress.Text = "" Or txtRefered.Text = "" Or txtgstamount.Text = "" Or txtPaidamo.Text = "" Or txtDues.Text = "" Or txtTotalAmount.Text = "" Then
            MsgBox("Some Fields are Empty", vbInformation, "Empty Field")
        Else
            If Not cc.State = ConnectionState.Open Then cc.Open()
            cmd.Connection = cc

            cmd.CommandText = "INSERT INTO CustomerBill(BillNumber, CustomerName, CustAddress,ContactNo,BillDate,Refered,ProductName,CategoryName,BatchNo,Quantity,MfgDate,ExpDate,MrpRate,Price,TotalQty,SubTotal, GstRate, GstAmount, Discount,DiscAmount,TotalAmount,PaidAmount,DuesAmount,PaymentBy,Remark) VALUES('" & txtBillNo.Text & "','" & txtCustomerName.Text & "','" & txtAddress.Text & "','" & txtContactNo.Text & "','" & dtmpBillDate.Text & "','" & txtRefered.Text & "','" & cmbProductName.Text & "','" & cmbCategory.Text & "','" & txtBatch.Text & "','" & txtQuantity.Text & "','" & dtmpMfg.Text & "','" & dtmpExp.Text & "','" & txtMrpRate.Text & "','" & txtPrice.Text & "','" & txtTotalQ.Text & "','" & txtsubTotal.Text & "','" & txtgstRate.Text & "','" & txtgstamount.Text & "','" & txtDiscount.Text & "','" & txtDiscAmnt.Text & "','" & txtTotalAmount.Text & "','" & txtPaidamo.Text & "','" & txtDues.Text & "','" & cmbPayment.Text & "','" & txtRemark.Text & "')"

            cmd.ExecuteNonQuery()

            'Design()
            MsgBox(" Save Successfully", vbInformation, "Success")





        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim Bill As New CustomerBill
        Bill.SetParameterValue("BillNumber", txtBillNo.Text)
        Bill.SetParameterValue("CustomerName", txtCustomerName.Text)
        Bill.SetParameterValue("CustAddress", txtAddress.Text)
        Bill.SetParameterValue("Refered", txtRefered.Text)
        Bill.SetParameterValue("ProductName", cmbProductName.Text)
        Bill.SetParameterValue("BatchNo", txtBatch.Text)
        Bill.SetParameterValue("Quantity", txtQuantity.Text)
        Bill.SetParameterValue("MfgDate", dtmpMfg.Text)
        Bill.SetParameterValue("ExpDate", dtmpExp.Text)
        Bill.SetParameterValue("MrpRate", txtMrpRate.Text)
        Bill.SetParameterValue("Price", txtPrice.Text)
        Bill.SetParameterValue("TotalQty", txtTotalQ.Text)
        Bill.SetParameterValue("SubTotal", txtsubTotal.Text)
        Bill.SetParameterValue("GstRate", txtgstRate.Text)
        Bill.SetParameterValue("GstAmount", txtgstamount.Text)
        Bill.SetParameterValue("Discount", txtDiscount.Text)
        Bill.SetParameterValue("DiscAmount", txtDiscAmnt.Text)
        Bill.SetParameterValue("TotalAmount", txtTotalAmount.Text)
        Bill.SetParameterValue("PaidAmount", txtPaidamo.Text)
        Bill.SetParameterValue("DuesAmount", txtDues.Text)
        Bill.SetParameterValue("PaymentBy", cmbPayment.Text)
        PrintBill1.CrystalReportViewer1.ReportSource = Bill
        PrintBill1.ShowDialog()
        'Me.Refresh()
        ClearBox()


    End Sub





    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtBillNo_TextChanged(sender As Object, e As EventArgs) Handles txtBillNo.TextChanged

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

    Private Sub txtBatch_TextChanged(sender As Object, e As EventArgs) Handles txtBatch.TextChanged

    End Sub

    Private Sub cmbProductName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductName.SelectedIndexChanged

    End Sub

    Private Sub cmbProductName_GotFocus(sender As Object, e As EventArgs) Handles cmbProductName.GotFocus
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
        Dim da As New OleDb.OleDbDataAdapter("SELECT ProductName as [Product Name],CategoryName as [Category Name],BatchNo as [Batch No] ,MfgDate as [MFG Date], ExpDate as [Expiry Date], MrpRate as  [MRP Rate] FROM ProductMaster", cc)
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
            table.Rows.Add(cmbProductName.Text, cmbCategory.Text, txtBatch.Text, txtQuantity.Text, dtmpMfg.Text, dtmpExp.Text, txtMrpRate.Text, txtPrice.Text)
            DataGridView1.DataSource = table

            'Dim Quantity As Int32
            'Dim TotalQuantity As Int32
            ''If ob1.checked Then
            'For Each row As DataGridViewRow In DataGridView1.Rows
            '        Quantity = Val(row.Cells("Quantity").Value.replace(",", "")) + Val(Quantity)

            '    Next
            '    If txtTotalQ.Text <> "" Then Quantity = txtTotalQ.Text
            ''Else
            'For Each row As DataGridViewRow In DataGridView1.Rows
            '    Quantity = Val(row.Cells("Quantity").Value.replace(",", "")) + Val(Quantity)
            '    'TotalQuantity = Val(row.Cells)

            '    '    For Each row As DataGridViewRow In DataGridView1.Rows
            '    '    SubTotal = Val(row.Cells("Price").Value.replace(",", "")) + Val(SubTotal)

            'Next

            ''If txtsubTotal.Text <> "" Then SubTotal = txtsubTotal.Text

        End If
        'Design()
        Dim TotalQuantity As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            TotalQuantity = TotalQuantity + DataGridView1.Rows(i).Cells(3).Value

        Next
        txtTotalQ.Text = TotalQuantity.ToString
        Dim SubTotal As Double = 0
        For intialization As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
            SubTotal = SubTotal + DataGridView1.Rows(intialization).Cells(7).Value
        Next
        txtsubTotal.Text = SubTotal.ToString
    End Sub

    Private Sub txtPrice_GotFocus(sender As Object, e As EventArgs) Handles txtPrice.GotFocus
        txtPrice.Text = Val(txtQuantity.Text) * Val(txtMrpRate.Text)
    End Sub

    Private Sub txtgstamount_GotFocus(sender As Object, e As EventArgs) Handles txtgstamount.GotFocus
        txtgstamount.Text = (Val(txtsubTotal.Text) * Val(txtgstRate.Text)) / 100
    End Sub

    Private Sub txtDiscAmnt_GotFocus(sender As Object, e As EventArgs) Handles txtDiscAmnt.GotFocus
        txtDiscAmnt.Text = (Val(txtsubTotal.Text) * Val(txtDiscount.Text)) / 100
    End Sub

    Private Sub txtTotalAmount_GotFocus(sender As Object, e As EventArgs) Handles txtTotalAmount.GotFocus
        txtTotalAmount.Text = (Val(txtgstamount.Text) + Val(txtsubTotal.Text)) - Val(txtDiscAmnt.Text)
    End Sub

    Private Sub txtDues_GotFocus(sender As Object, e As EventArgs) Handles txtDues.GotFocus
        txtDues.Text = Val(txtTotalAmount.Text) - Val(txtPaidamo.Text)
    End Sub

    Private Sub txtTotalQ_TextChanged(sender As Object, e As EventArgs) Handles txtTotalQ.TextChanged

    End Sub

    Private Sub txtBillNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBillNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtCustomerName.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
        End If
    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

    End Sub

    Private Sub txtAddress_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtRefered.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
        End If
    End Sub

    Private Sub txtRefered_TextChanged(sender As Object, e As EventArgs) Handles txtRefered.TextChanged

    End Sub

    Private Sub txtRefered_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRefered.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cmbProductName.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
        End If
    End Sub



    Private Sub cmbCategory_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbCategory.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtBatch.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
        End If
    End Sub

    Private Sub txtBatch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBatch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtQuantity.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
        End If
    End Sub

    Private Sub dtmpMfg_ValueChanged(sender As Object, e As EventArgs) Handles dtmpMfg.ValueChanged

    End Sub

    Private Sub dtmpMfg_KeyDown(sender As Object, e As KeyEventArgs) Handles dtmpMfg.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dtmpExp.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
        End If
    End Sub

    Private Sub txtMrpRate_TextChanged(sender As Object, e As EventArgs) Handles txtMrpRate.TextChanged

    End Sub

    Private Sub txtMrpRate_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMrpRate.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtPrice.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
        End If
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged

    End Sub

    Private Sub txtPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnAdd.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
        End If
    End Sub
End Class