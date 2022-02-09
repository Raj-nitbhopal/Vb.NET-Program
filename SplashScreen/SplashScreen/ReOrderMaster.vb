Public Class ReOrderMaster



    Dim table As New DataTable()
    Private Sub cmbItemsName_GotFocus(sender As Object, e As EventArgs) Handles cmbItemsName.GotFocus
        Dim reader As OleDb.OleDbDataReader
        Dim texts As String
        If Not cc.State = ConnectionState.Open Then cc.Open()
        cmd.Connection = cc
        cmd.CommandText = " select distinct (ProductName) from ProductMaster order by ProductName"
        reader = cmd.ExecuteReader
        texts = cmbItemsName.Text
        cmbItemsName.Items.Clear()
        While reader.Read
            cmbItemsName.Items.Add(reader("ProductName"))
        End While
        cmbItemsName.Text = texts
        reader.Close()
        cmbItemsName.DroppedDown = True
    End Sub

    Private Sub ReOrderMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        table.Columns.Add("Items  Name")
        table.Columns.Add("No Of Quantity")
        Call Connect()
        'Design()
        Me.DataGridView1.Font = New Font("Modern No. 20", 13, FontStyle.Regular)
        DataGridView1.DataSource = table
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbItemsName.Text = "" Then
            MsgBox("Please Enter Medicine Name", vbInformation, "Empty Field")
            cmbItemsName.Focus()

        ElseIf txtQuantity.Text = "" Then
            MsgBox("Please Enter Category Type", vbInformation, "Empty Field")
            txtQuantity.Focus()



        Else
            'ListBox1.Items.Add(cmbItemsName.Text)
            Dim rows = DataGridView1.RowCount + 1
            table.Rows.Add(cmbItemsName.Text, txtQuantity.Text)
            DataGridView1.DataSource = table


        End If
        'Design()
        Dim TotalQuantity As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            TotalQuantity = TotalQuantity + DataGridView1.Rows(i).Cells(1).Value

        Next
        txtTotalQty.Text = TotalQuantity.ToString
    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        'If DataGridView1.Rows.Count > 0 Then
        '    If DataGridView1.SelectedRows.Count > 0 Then
        '        Dim ProductId = DataGridView1.SelectedRows(0).Cells(0).Value
        '        If Not cc.State = ConnectionState.Open Then cc.Open()
        '        cmd.Connection = cc
        '        Dim da As New OleDb.OleDbDataAdapter(" SELECT ItemName FROM ReOrder WHERE OrderNumber ='" & ItemName & "'", cc)
        '        Dim dt As New DataTable
        '        da.Fill(dt)

        '        cmbItemsName.Text = dt.Rows(0).Item("ItemName")
        '        txtQuantity.Text = dt.Rows(0).Item("Quantity")
        '    End If
        'End If


    End Sub

    'Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
    '    If Not cc.State = ConnectionState.Open Then cc.Open()
    '    cmd.Connection = cc

    '    cmd.CommandText = "Update ReOrder set ItemNmae='" & cmbItemsName.Text & "',Quantity='" & txtQuantity.Text & "'  Where ID = " & TextBox1.Text & ""
    '    cmd.ExecuteNonQuery()

    '    MsgBox(" Data Updated Successfully ", vbInformation, "Success")
    '    cmbItemsName.Visible = True
    '    btnAdd.Visible = True
    '    btnDelete.Visible = False
    '    btnUpdate.Visible = False
    '    TextBox1.Text = ""
    '    'Design()
    '    'ClearBox()
    'End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim Bill As New ReOrderReport
        Bill.SetParameterValue("OrderNumber", txtOrderNo.Text)
        Bill.SetParameterValue("OrderDate", dtmpOrderDate.Text)
        Bill.SetParameterValue("CompanyName", txtCompName1.Text)
        Bill.SetParameterValue("CompGSTIN", txtCompGSTIN1.Text)
        Bill.SetParameterValue("CompContact", txtCompCont1.Text)
        Bill.SetParameterValue("CompAddress", txtCompAddress1.Text)
        Bill.SetParameterValue("ItemName", cmbItemsName.Text)
        Bill.SetParameterValue("Quantity", txtQuantity.Text)
        'Bill.SetParameterValue("TotalQty", txtTotalQty.Text)
        ReOrderReportPrint.CrystalReportViewer1.ReportSource = Bill
        ReOrderReportPrint.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtOrderNo.Text = " " Or txtCompName.Text = "" Or txtCompCont.Text = "" Or txtCompCont1.Text = "" Or txtCompAddress.Text = "" Or txtCompAddress1.Text = "" Or txtCompGSTIN.Text = "" Or txtCompGSTIN1.Text = "" Then
            MsgBox("Some Fields are Empty", vbInformation, "Empty Field")
        Else
            If Not cc.State = ConnectionState.Open Then cc.Open()
            cmd.Connection = cc
            cmd.CommandText = "INSERT INTO ReOrder(OrderNumber,OrderDate,CompanyName,CompGSTIN,CompContact, CompAddress,ItemName, Quantity, TotalQty) VALUES('" & txtOrderNo.Text & "', '" & dtmpOrderDate.Text & "', '" & txtCompName1.Text & "', '" & txtCompGSTIN1.Text & "', '" & txtCompCont1.Text & "', '" & txtCompAddress1.Text & "', '" & cmbItemsName.Text & "', '" & txtQuantity.Text & "','" & txtTotalQty.Text & "')"

            cmd.ExecuteNonQuery()


            MsgBox(" Save Successfully", vbInformation, "Success")

        End If
    End Sub
End Class