
Public Class ProductMaster


    Private Sub ClearBox()
        txtProductId.Text = ""
        txtProductName.Text = ""
        cmbProCategory.Text = ""
        cmbPackageName.Text = ""
        txtPurchaseRate.Text = ""
        txtMrpRate.Text = ""
        txtItem.Text = ""
        cmbItem.Text = ""
        txtItemCost.Text = ""
        txtPackItem.Text = ""
        txtItemsCost.Text = ""
        txtWeight.Text = ""
        cmbRack.Text = ""
        txtQuantity.Text = ""
        txtSaleRate.Text = ""
        dtmpMfg.Text = ""
        dtmpExp.Text = ""
        txtBatchNo.Text = ""
        TextBox1.Text = ""
    End Sub
    Private Function Design()
        If Not cc.State = ConnectionState.Open Then cc.Open()
        cmd.Connection = cc
        Dim da As New OleDb.OleDbDataAdapter("SELECT ProductId as [Product ID],ProductName as [Product Name],CategoryName as [Category Name],PackageName as [Package Name],PurchaseRate as[Purchase Rate], MrpRate as  [MRP Rate], Item as [No of Item], ItemType as [Item Type], ItemCost as [Item Cost],BatchNo as [Batch No], PackItem as [Sub-Item In Pack],ItemsCost as [Sub-Item Cost],Weight as [Weight], Rack as [Rack Number], Quantity as [Total Quantity], SaleRate as [Selling Rate],MfgDate as [MFG Date], ExpDate as [Expiry Date] FROM ProductMaster", cc)
        Dim dt As New DataTable
        da.Fill(dt)
        dgv.DataSource = dt
        cc.Close()
        Return 0
    End Function





    Private Sub ProductMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Connect()
        Design()
        Me.dgv.Font = New Font("Modern No. 20", 13, FontStyle.Regular)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        If txtProductId.Text = " " Or txtProductName.Text = "" Or cmbProCategory.Text = "" Or cmbPackageName.Text = "" Or txtPurchaseRate.Text = "" Or txtMrpRate.Text = "" Or txtItem.Text = "" Or txtSaleRate.Text = "" Then
            MsgBox("Some Fields are Empty", vbInformation, "Empty Field")
        Else
            If Not cc.State = ConnectionState.Open Then cc.Open()
            cmd.Connection = cc
            cmd.CommandText = "INSERT INTO ProductMaster(ProductId, ProductName, CategoryName, PackageName, PurchaseRate, MrpRate,Item,ItemType,ItemCost,PackItem,ItemsCost,BatchNo,Weight,Rack, Quantity, SaleRate, MfgDate,ExpDate) VALUES('" & txtProductId.Text & "','" & txtProductName.Text & "','" & cmbProCategory.Text & "','" & cmbPackageName.Text & "','" & txtPurchaseRate.Text & "','" & txtMrpRate.Text & "','" & txtItem.Text & "','" & cmbItem.Text & "','" & txtItemCost.Text & "','" & txtPackItem.Text & "','" & txtItemsCost.Text & "','" & txtBatchNo.Text & "','" & txtWeight.Text & "', '" & cmbRack.Text & "','" & txtQuantity.Text & "','" & txtSaleRate.Text & "','" & dtmpMfg.Text & "','" & dtmpExp.Text & "')"

            cmd.ExecuteNonQuery()

            Design()
            MsgBox(" Save Successfully", vbInformation, "Success")
            ClearBox()
        End If
    End Sub


    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        If dgv.Rows.Count > 0 Then
            If dgv.SelectedRows.Count > 0 Then
                Dim ProductId = dgv.SelectedRows(0).Cells(0).Value
                If Not cc.State = ConnectionState.Open Then cc.Open()
                cmd.Connection = cc
                Dim da As New OleDb.OleDbDataAdapter(" SELECT * FROM ProductMaster WHERE ProductId =" & ProductId & "", cc)
                Dim dt As New DataTable
                da.Fill(dt)

                txtProductId.Text = dt.Rows(0).Item("ProductId")
                txtProductName.Text = dt.Rows(0).Item("ProductName")
                cmbProCategory.Text = dt.Rows(0).Item("CategoryName")
                cmbPackageName.Text = dt.Rows(0).Item("PackageName")
                txtPurchaseRate.Text = dt.Rows(0).Item("PurchaseRate")
                txtMrpRate.Text = dt.Rows(0).Item("MrpRate")
                txtItem.Text = dt.Rows(0).Item("Item")
                cmbItem.Text = dt.Rows(0).Item("ItemType")
                txtItemCost.Text = dt.Rows(0).Item("ItemCost")
                txtPackItem.Text = dt.Rows(0).Item("PackItem")
                txtItemsCost.Text = dt.Rows(0).Item("ItemsCost")
                txtBatchNo.Text = dt.Rows(0).Item("BatchNo")
                txtWeight.Text = dt.Rows(0).Item("Weight")
                cmbRack.Text = dt.Rows(0).Item("Rack")
                txtQuantity.Text = dt.Rows(0).Item("Quantity")
                txtSaleRate.Text = dt.Rows(0).Item("SaleRate")
                dtmpMfg.Text = dt.Rows(0).Item("MfgDate")
                dtmpExp.Text = dt.Rows(0).Item("ExpDate")
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
            cmd.CommandText = "DELETE From ProductMaster Where ID = " & TextBox1.Text & ""
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

        cmd.CommandText = "Update ProductMaster set ProductId='" & txtProductId.Text & "',ProductName='" & txtProductName.Text & "',CategoryName='" & cmbProCategory.Text & "',PackageName='" & cmbPackageName.Text & "',PurchaseRate='" & txtPurchaseRate.Text & "', MrpRate='" & txtMrpRate.Text & "',Item='" & txtItem.Text & "',ItemType='" & cmbItem.Text & "',ItemCost='" & txtItemCost.Text & "',PackItem='" & txtPackItem.Text & "',ItemsCost='" & txtItemsCost.Text & "', BatchNo= '" & txtBatchNo.Text & "',Weight='" & txtWeight.Text & "',Rack= '" & cmbRack.Text & "',Quantity='" & txtQuantity.Text & "',SaleRate='" & txtSaleRate.Text & "',MfgDate='" & dtmpMfg.Text & "',ExpDate='" & dtmpExp.Text & "' Where ID = " & TextBox1.Text & ""
        cmd.ExecuteNonQuery()
        MsgBox(" Data Updated Successfully ", vbInformation, "Success")
        txtProductId.Visible = True
        btnSave.Visible = True
        btnDelete.Visible = False
        btnUpdate.Visible = False
        TextBox1.Text = ""
        Design()
        ClearBox()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub



    Private Sub txtItemCost_GotFocus(sender As Object, e As EventArgs) Handles txtItemCost.GotFocus
        Me.txtItemsCost.Text = Val(txtPurchaseRate.Text) / Val(txtPackItem.Text)
    End Sub

    Private Sub txtQuantity_GotFocus(sender As Object, e As EventArgs) Handles txtQuantity.GotFocus
        Me.txtQuantity.Text = Val(txtItem.Text) * Val(txtPackItem.Text)
    End Sub

    Private Sub txtItem_GotFocus(sender As Object, e As EventArgs) Handles txtItem.GotFocus
        Me.txtItemCost.Text = Val(txtPurchaseRate.Text) / Val(txtItem.Text)
    End Sub
End Class