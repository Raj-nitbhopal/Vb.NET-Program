'Public Class ReportMaster

'    Private headerchecbox As CheckBox = New CheckBox
'    Private Sub ReportMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        Call Connect()
'        Call Design()
'        DataGridView1.ReadOnly = False
'        Dim headercelllocation As Point = Me.DataGridView1.GetCellDisplayRectangle(-1, -1, True).Location
'        headerchecbox.Location = New Point(headercelllocation.X + 8, headercelllocation.Y + 1)
'        headerchecbox.BackColor = Color.White
'        headerchecbox.Size = New Size(18, 18)
'        AddHandler headerchecbox.Click, AddressOf HeadercheckBox_Clicked
'        DataGridView1.Controls.Add(headerchecbox)
'        Dim checkBoxColumn As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
'        checkBoxColumn.HeaderText = ""
'        checkBoxColumn.Width = 30
'        checkBoxColumn.Name = "CheckBoxColumn "
'        DataGridView1.Columns.Insert(0, checkBoxColumn)
'        AddHandler DataGridView1.CellContentClick, AddressOf DataGridView1_CellClick
'        DataGridView1.RowHeadersVisible = False
'        DataGridView1.Columns(1).Visible = False
'        Dim C As DataGridViewColumn = DataGridView1.Columns(2)
'        C.Width = 100
'        Dim C1 As DataGridViewColumn = DataGridView1.Columns(3)
'        C1.Width = 100
'        Dim C2 As DataGridViewColumn = DataGridView1.Columns(4)
'        C2.Width = 100
'        Dim C3 As DataGridViewColumn = DataGridView1.Columns(5)
'        C3.Width = 100
'        Dim C4 As DataGridViewColumn = DataGridView1.Columns(6)
'        C4.Width = 100

'        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Times New Roman", 12, FontStyle.Bold, GraphicsUnit.Point)
'        DataGridView1.DefaultCellStyle.Font = New Font("Times new Roman", 10, FontStyle.Italic, GraphicsUnit.Point)
'    End Sub

'    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

'    End Sub
'    Private Sub HeadercheckBox_Clicked(ByVal sender As Object, ByVal e As EventArgs)
'        'Neccessary to end the edit mode of cell
'        DataGridView1.EndEdit()
'        'Loop and Check and Uncheck all row CheckBoxes based on Header Cell CheckBox
'        For Each row As DataGridView In DataGridView1.Rows

'            Dim CheckBox As DataGridViewCheckBoxCell = (TryCast(row.Cells("CheckBoxColumn"), DataGridViewCheckBoxCell))
'            CheckBox.Value = headerchecbox.Checked
'        Next
'    End Sub

'    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

'    End Sub

'    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
'        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then
'            'Loop To verify whether all row CheckBox are Checked or not
'            Dim ischecked As Boolean = True
'            For Each rows1 As DataGridView In DataGridView1.Rows
'                If Convert.ToBoolean(rows1.cells("CheckBoxColumn").editedformatedvalue) = False Then
'                    ischecked = False
'                    Exit For
'                End If
'            Next
'            headerchecbox.Checked = ischecked
'        End If
'    End Sub
'    Private Function Design()
'        If Not cc.State = ConnectionState.Open Then cc.Open()
'        cmd.Connection = cc
'        Dim das As New OleDb.OleDbDataAdapter("Select * from ProductMaster", cc)
'        Dim dts As New DataTable
'        Dim FromDate As DateTime = DateTimePicker1.Text
'        Dim FillDate As DateTime = DateTimePicker2.Text
'        das.Fill(dts)
'        Dim invtable As String = dts.Rows(0).Item("invtable").ToString
'        Dim da As New OleDb.OleDbDataAdapter("select ID ")
'        Dim dt As New DataTable
'        da.Fill(dt)
'        DataGridView1.DataSource = dt
'        cc.Close()
'        For inti = DataGridView1.Rows.Count - 1 To 0 Step -1
'            For Intj = inti - 1 To 0 Step -1
'                If DataGridView1.Rows(inti).Cells(2).Value = DataGridView1.Rows(inti).Cells(2).Value Then
'                    DataGridView1.Rows.RemoveAt(inti)
'                    Exit For
'                End If
'            Next
'        Next


'        Return 0
'    End Function

'    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
'        Design()

'    End Sub

'    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
'        If DataGridView1.Rows.Count > 0 Then
'            Dim Column_value As String
'            Column_value = DataGridView1.CurrentRow.Index
'            Dim BillNo As String = DataGridView1.Rows(Column_value).Cells(2).Value
'            If Not cc.State = ConnectionState.Open Then cc.Open()
'            cmd.Connection = cc
'            Dim da As New OleDb.OleDbDataAdapter("Select * from ProductMaster", cc)
'            Dim dt As New DataTable
'            da.Fill(dt)
'            Dim invtable As String = dt.Rows(0).Item("invtable").ToString
'            Dim das As New OleDb.OleDbDataAdapter("Select from " & invtable & " where Billno=" & BillNo & "", cc)
'            Dim dts As New DataTable
'            das.Fill(dts)

'        End If

'    End Sub
'End Class