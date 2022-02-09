<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReOrderMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtOrderNo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCompAddress1 = New System.Windows.Forms.TextBox()
        Me.txtCompCont1 = New System.Windows.Forms.TextBox()
        Me.txtCompGSTIN1 = New System.Windows.Forms.TextBox()
        Me.txtCompName1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCompAddress = New System.Windows.Forms.TextBox()
        Me.txtCompCont = New System.Windows.Forms.TextBox()
        Me.txtCompGSTIN = New System.Windows.Forms.TextBox()
        Me.txtCompName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtmpOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTotalQty = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cmbItemsName = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(13, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(419, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(479, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Order Date"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.txtOrderNo)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtCompAddress1)
        Me.Panel1.Controls.Add(Me.txtCompCont1)
        Me.Panel1.Controls.Add(Me.txtCompGSTIN1)
        Me.Panel1.Controls.Add(Me.txtCompName1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtCompAddress)
        Me.Panel1.Controls.Add(Me.txtCompCont)
        Me.Panel1.Controls.Add(Me.txtCompGSTIN)
        Me.Panel1.Controls.Add(Me.txtCompName)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.dtmpOrderDate)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(817, 277)
        Me.Panel1.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(423, 235)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 28)
        Me.TextBox1.TabIndex = 23
        Me.TextBox1.Visible = False
        '
        'txtOrderNo
        '
        Me.txtOrderNo.Location = New System.Drawing.Point(181, 12)
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.Size = New System.Drawing.Size(204, 28)
        Me.txtOrderNo.TabIndex = 22
        Me.txtOrderNo.Text = "MS1001"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label15.Location = New System.Drawing.Point(13, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(119, 21)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Order Number"
        '
        'txtCompAddress1
        '
        Me.txtCompAddress1.Location = New System.Drawing.Point(587, 198)
        Me.txtCompAddress1.Multiline = True
        Me.txtCompAddress1.Name = "txtCompAddress1"
        Me.txtCompAddress1.Size = New System.Drawing.Size(204, 65)
        Me.txtCompAddress1.TabIndex = 20
        '
        'txtCompCont1
        '
        Me.txtCompCont1.Location = New System.Drawing.Point(587, 160)
        Me.txtCompCont1.Name = "txtCompCont1"
        Me.txtCompCont1.Size = New System.Drawing.Size(204, 28)
        Me.txtCompCont1.TabIndex = 19
        '
        'txtCompGSTIN1
        '
        Me.txtCompGSTIN1.Location = New System.Drawing.Point(587, 124)
        Me.txtCompGSTIN1.Name = "txtCompGSTIN1"
        Me.txtCompGSTIN1.Size = New System.Drawing.Size(204, 28)
        Me.txtCompGSTIN1.TabIndex = 18
        '
        'txtCompName1
        '
        Me.txtCompName1.Location = New System.Drawing.Point(587, 86)
        Me.txtCompName1.Name = "txtCompName1"
        Me.txtCompName1.Size = New System.Drawing.Size(204, 28)
        Me.txtCompName1.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Green
        Me.Label9.Location = New System.Drawing.Point(419, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 21)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Company Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Green
        Me.Label10.Location = New System.Drawing.Point(419, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 21)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Compnay GSTIN"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Green
        Me.Label11.Location = New System.Drawing.Point(419, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(155, 21)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Company Cont. No."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Green
        Me.Label12.Location = New System.Drawing.Point(419, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 21)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Company Name"
        '
        'txtCompAddress
        '
        Me.txtCompAddress.Location = New System.Drawing.Point(181, 198)
        Me.txtCompAddress.Multiline = True
        Me.txtCompAddress.Name = "txtCompAddress"
        Me.txtCompAddress.Size = New System.Drawing.Size(204, 65)
        Me.txtCompAddress.TabIndex = 12
        Me.txtCompAddress.Text = "National Business College, Nala Road Patna-16"
        '
        'txtCompCont
        '
        Me.txtCompCont.Location = New System.Drawing.Point(181, 160)
        Me.txtCompCont.Name = "txtCompCont"
        Me.txtCompCont.Size = New System.Drawing.Size(204, 28)
        Me.txtCompCont.TabIndex = 11
        Me.txtCompCont.Text = "7870702602"
        '
        'txtCompGSTIN
        '
        Me.txtCompGSTIN.Location = New System.Drawing.Point(181, 124)
        Me.txtCompGSTIN.Name = "txtCompGSTIN"
        Me.txtCompGSTIN.Size = New System.Drawing.Size(204, 28)
        Me.txtCompGSTIN.TabIndex = 10
        Me.txtCompGSTIN.Text = "QWERTYUIOP!@QW"
        '
        'txtCompName
        '
        Me.txtCompName.Location = New System.Drawing.Point(181, 86)
        Me.txtCompName.Name = "txtCompName"
        Me.txtCompName.Size = New System.Drawing.Size(204, 28)
        Me.txtCompName.TabIndex = 9
        Me.txtCompName.Text = "Medical Shop Management System"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(13, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 21)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Company Address"
        '
        'dtmpOrderDate
        '
        Me.dtmpOrderDate.Location = New System.Drawing.Point(580, 9)
        Me.dtmpOrderDate.Name = "dtmpOrderDate"
        Me.dtmpOrderDate.Size = New System.Drawing.Size(200, 28)
        Me.dtmpOrderDate.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 21)
        Me.Label7.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(13, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Compnay GSTIN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(13, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Company Cont. No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(13, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Company Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.txtTotalQty)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.cmbItemsName)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 283)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(817, 301)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Items Details"
        '
        'txtTotalQty
        '
        Me.txtTotalQty.Location = New System.Drawing.Point(522, 265)
        Me.txtTotalQty.Name = "txtTotalQty"
        Me.txtTotalQty.Size = New System.Drawing.Size(100, 28)
        Me.txtTotalQty.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(419, 271)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 21)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Total Qty."
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.BorderSize = 3
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(666, 255)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(125, 40)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnPrint.FlatAppearance.BorderSize = 3
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Location = New System.Drawing.Point(666, 199)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(125, 40)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "Print Report"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnDelete.FlatAppearance.BorderSize = 3
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(666, 143)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(125, 40)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnSave.FlatAppearance.BorderSize = 3
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(666, 88)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(125, 40)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnAdd.FlatAppearance.BorderSize = 3
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(666, 31)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(125, 40)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'cmbItemsName
        '
        Me.cmbItemsName.FormattingEnabled = True
        Me.cmbItemsName.Location = New System.Drawing.Point(107, 31)
        Me.cmbItemsName.Name = "cmbItemsName"
        Me.cmbItemsName.Size = New System.Drawing.Size(278, 29)
        Me.cmbItemsName.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(107, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(515, 191)
        Me.DataGridView1.TabIndex = 4
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(522, 34)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 28)
        Me.txtQuantity.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Green
        Me.Label14.Location = New System.Drawing.Point(419, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 21)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Quantity"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Green
        Me.Label13.Location = New System.Drawing.Point(6, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 21)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Item Nmae"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 21
        Me.ListBox1.Location = New System.Drawing.Point(28, 187)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(24, 25)
        Me.ListBox1.TabIndex = 13
        '
        'ReOrderMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 584)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReOrderMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReOrderMaster"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtmpOrderDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCompAddress1 As TextBox
    Friend WithEvents txtCompCont1 As TextBox
    Friend WithEvents txtCompGSTIN1 As TextBox
    Friend WithEvents txtCompName1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCompAddress As TextBox
    Friend WithEvents txtCompCont As TextBox
    Friend WithEvents txtCompGSTIN As TextBox
    Friend WithEvents txtCompName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtOrderNo As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents cmbItemsName As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtTotalQty As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox1 As ListBox
End Class
