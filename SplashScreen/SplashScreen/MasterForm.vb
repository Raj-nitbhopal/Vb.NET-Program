Public Class MasterForm
    Private Sub ImporrtantContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImporrtantContactToolStripMenuItem.Click
        MsgBox("Service Under Maintaince")
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = DateTime.Now.ToString()
    End Sub

    Private Sub ProductMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductMasterToolStripMenuItem.Click
        ProductMaster.Show()
    End Sub

    Private Sub SupplierMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierMasterToolStripMenuItem.Click
        SupplierMaster.Show()

    End Sub

    Private Sub UserMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserMasterToolStripMenuItem.Click
        UserMaster.Show()

    End Sub


    Private Sub btnProductMaster_Click(sender As Object, e As EventArgs) Handles btnProductMaster.Click
        ProductMaster.Show()

    End Sub

    Private Sub btnSupplierMaster_Click(sender As Object, e As EventArgs) Handles btnSupplierMaster.Click
        SupplierMaster.Show()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        MsgBox("Service Under Maintaince")
    End Sub

    Private Sub ContactToDeveloperToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContactToDeveloperToolStripMenuItem1.Click
        MsgBox("Service Under Maintaince")
    End Sub

    Private Sub SalesDateWiseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesDateWiseToolStripMenuItem.Click
        ReportMaster.Show()
    End Sub

    Private Sub CoustmerInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoustmerInvoiceToolStripMenuItem.Click
        PrintBill.Show()
    End Sub

    Private Sub btnPrintBill_Click(sender As Object, e As EventArgs) Handles btnPrintBill.Click
        PrintBill.Show()

    End Sub

    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        Me.Process1.StartInfo.FileName = "C:\Windows\System32\calc.exe"
        If MsgBox("Are you Sure To Open Calcolator ?", vbYesNo, "Confirm ") = vbYes Then
            Me.Process1.Start()
        End If
    End Sub

    Private Sub btnNotepad_Click(sender As Object, e As EventArgs) Handles btnNotepad.Click
        Me.Process1.StartInfo.FileName = "C:\Windows\System32\notepad.exe"
        If MsgBox("Are you Sure To Open Notepad ?", vbYesNo, "Confirm ") = vbYes Then
            Me.Process1.Start()
        End If
    End Sub

    Private Sub btnWord_Click(sender As Object, e As EventArgs) Handles btnWord.Click
        Me.Process1.StartInfo.FileName = "C:\Windows\System32\MSDRM\MsoIrmProtector.doc"
        If MsgBox("Are you Sure To Open Word ?", vbYesNo, "Confirm ") = vbYes Then
            Me.Process1.Start()
        End If
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Me.Process1.StartInfo.FileName = "C:\Windows\System32\MSDRM\MsoIrmProtector.xls"
        If MsgBox("Are you Sure To Open Excel ?", vbYesNo, "Confirm ") = vbYes Then
            Me.Process1.Start()
        End If
    End Sub

    Private Sub btnCurrentStock_Click(sender As Object, e As EventArgs) Handles btnCurrentStock.Click
        ReportMaster.Show()

    End Sub

    Private Sub ProductRecoderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductRecoderToolStripMenuItem.Click
        ProductMaster.Show()

    End Sub

    Private Sub CurrentStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CurrentStockToolStripMenuItem.Click
        ReportMaster.Show()
    End Sub

    Private Sub btnReorder_Click(sender As Object, e As EventArgs) Handles btnReorder.Click
        ReOrderMaster.Show()
    End Sub
End Class