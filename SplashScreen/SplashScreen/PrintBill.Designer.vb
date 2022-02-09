<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintBill
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRefered = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtmpExp = New System.Windows.Forms.DateTimePicker()
        Me.dtmpMfg = New System.Windows.Forms.DateTimePicker()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbProductName = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTotalQ = New System.Windows.Forms.TextBox()
        Me.txtsubTotal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMrpRate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBatch = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtDiscAmnt = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.txtDues = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtPaidamo = New System.Windows.Forms.TextBox()
        Me.cmbPayment = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtgstamount = New System.Windows.Forms.TextBox()
        Me.txtgstRate = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtmpBillDate = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.GroupBox1.Controls.Add(Me.txtContactNo)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.dtmpBillDate)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtRefered)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.txtBillNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1235, 104)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'txtRefered
        '
        Me.txtRefered.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefered.Location = New System.Drawing.Point(995, 63)
        Me.txtRefered.Name = "txtRefered"
        Me.txtRefered.Size = New System.Drawing.Size(199, 28)
        Me.txtRefered.TabIndex = 4
        Me.txtRefered.Text = "Dr. Rajan Kumar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(877, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Reffered By"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(582, 27)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(214, 30)
        Me.txtAddress.TabIndex = 3
        Me.txtAddress.Text = "Patna"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(139, 63)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(197, 28)
        Me.txtCustomerName.TabIndex = 2
        Me.txtCustomerName.Text = "Rajan Kumar"
        '
        'txtBillNo
        '
        Me.txtBillNo.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillNo.Location = New System.Drawing.Point(139, 29)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.Size = New System.Drawing.Size(197, 28)
        Me.txtBillNo.TabIndex = 0
        Me.txtBillNo.Text = "MS1001"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(430, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Customer Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bill Number"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.dtmpExp)
        Me.GroupBox2.Controls.Add(Me.dtmpMfg)
        Me.GroupBox2.Controls.Add(Me.txtPrice)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.cmbProductName)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtTotalQ)
        Me.GroupBox2.Controls.Add(Me.txtsubTotal)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.txtQuantity)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtMrpRate)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtBatch)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cmbCategory)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1235, 268)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product Information"
        '
        'dtmpExp
        '
        Me.dtmpExp.Location = New System.Drawing.Point(802, 56)
        Me.dtmpExp.Name = "dtmpExp"
        Me.dtmpExp.Size = New System.Drawing.Size(116, 28)
        Me.dtmpExp.TabIndex = 10
        '
        'dtmpMfg
        '
        Me.dtmpMfg.Location = New System.Drawing.Point(662, 57)
        Me.dtmpMfg.Name = "dtmpMfg"
        Me.dtmpMfg.Size = New System.Drawing.Size(134, 28)
        Me.dtmpMfg.TabIndex = 9
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(1030, 56)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(100, 28)
        Me.txtPrice.TabIndex = 12
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Green
        Me.Label21.Location = New System.Drawing.Point(1026, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(51, 21)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "Price"
        '
        'cmbProductName
        '
        Me.cmbProductName.FormattingEnabled = True
        Me.cmbProductName.Location = New System.Drawing.Point(6, 55)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(294, 29)
        Me.cmbProductName.TabIndex = 5
        Me.cmbProductName.Text = "Corex"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Green
        Me.Label18.Location = New System.Drawing.Point(421, 238)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(125, 21)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Total Quantity"
        '
        'txtTotalQ
        '
        Me.txtTotalQ.Location = New System.Drawing.Point(553, 238)
        Me.txtTotalQ.Name = "txtTotalQ"
        Me.txtTotalQ.ReadOnly = True
        Me.txtTotalQ.Size = New System.Drawing.Size(100, 28)
        Me.txtTotalQ.TabIndex = 14
        '
        'txtsubTotal
        '
        Me.txtsubTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtsubTotal.Location = New System.Drawing.Point(1020, 235)
        Me.txtsubTotal.Name = "txtsubTotal"
        Me.txtsubTotal.ReadOnly = True
        Me.txtsubTotal.Size = New System.Drawing.Size(113, 28)
        Me.txtsubTotal.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Green
        Me.Label15.Location = New System.Drawing.Point(907, 238)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 21)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Sub Total"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.Green
        Me.Label31.Location = New System.Drawing.Point(798, 24)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(87, 21)
        Me.Label31.TabIndex = 15
        Me.Label31.Text = "Exp. Date"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.Green
        Me.Label30.Location = New System.Drawing.Point(658, 25)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(87, 21)
        Me.Label30.TabIndex = 13
        Me.Label30.Text = "Mfg. Date"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1223, 140)
        Me.DataGridView1.TabIndex = 12
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAdd.Location = New System.Drawing.Point(1136, 43)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 43)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(553, 55)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 28)
        Me.txtQuantity.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Green
        Me.Label11.Location = New System.Drawing.Point(920, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 21)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "MRP"
        '
        'txtMrpRate
        '
        Me.txtMrpRate.Location = New System.Drawing.Point(924, 56)
        Me.txtMrpRate.Name = "txtMrpRate"
        Me.txtMrpRate.Size = New System.Drawing.Size(100, 28)
        Me.txtMrpRate.TabIndex = 11
        Me.txtMrpRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Green
        Me.Label10.Location = New System.Drawing.Point(549, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 21)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Quantity"
        '
        'txtBatch
        '
        Me.txtBatch.Location = New System.Drawing.Point(428, 56)
        Me.txtBatch.Name = "txtBatch"
        Me.txtBatch.Size = New System.Drawing.Size(119, 28)
        Me.txtBatch.TabIndex = 7
        Me.txtBatch.Text = "BATCH34W"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Green
        Me.Label9.Location = New System.Drawing.Point(421, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 21)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Batch No."
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Tablet", "Syrup", "Balm", "Accessories", "Instruments", "others"})
        Me.cmbCategory.Location = New System.Drawing.Point(304, 55)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(115, 29)
        Me.cmbCategory.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(300, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 21)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Category"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(6, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Medicine Name"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtDiscAmnt)
        Me.GroupBox3.Controls.Add(Me.btnPrint)
        Me.GroupBox3.Controls.Add(Me.txtDues)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtRemark)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtTotalAmount)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.btnCancel)
        Me.GroupBox3.Controls.Add(Me.btnSubmit)
        Me.GroupBox3.Controls.Add(Me.txtPaidamo)
        Me.GroupBox3.Controls.Add(Me.cmbPayment)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtDiscount)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtgstamount)
        Me.GroupBox3.Controls.Add(Me.txtgstRate)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Green
        Me.GroupBox3.Location = New System.Drawing.Point(11, 396)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1236, 186)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tax Information"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 133)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(116, 21)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Disc. Amount"
        '
        'txtDiscAmnt
        '
        Me.txtDiscAmnt.Location = New System.Drawing.Point(140, 133)
        Me.txtDiscAmnt.Name = "txtDiscAmnt"
        Me.txtDiscAmnt.ReadOnly = True
        Me.txtDiscAmnt.Size = New System.Drawing.Size(161, 28)
        Me.txtDiscAmnt.TabIndex = 19
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnPrint.FlatAppearance.BorderSize = 3
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrint.Location = New System.Drawing.Point(956, 130)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(115, 40)
        Me.btnPrint.TabIndex = 26
        Me.btnPrint.Text = "Print Bill"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'txtDues
        '
        Me.txtDues.Location = New System.Drawing.Point(484, 95)
        Me.txtDues.Name = "txtDues"
        Me.txtDues.ReadOnly = True
        Me.txtDues.Size = New System.Drawing.Size(170, 28)
        Me.txtDues.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(324, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 21)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Dues Amount"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(484, 130)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(170, 28)
        Me.txtRemark.TabIndex = 24
        Me.txtRemark.Text = "NA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(324, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 21)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Remark If Any"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalAmount.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.ForeColor = System.Drawing.Color.Red
        Me.txtTotalAmount.Location = New System.Drawing.Point(996, 36)
        Me.txtTotalAmount.MaxLength = 12
        Me.txtTotalAmount.Multiline = True
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(205, 39)
        Me.txtTotalAmount.TabIndex = 20
        Me.txtTotalAmount.Text = "0.00"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(821, 45)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(162, 25)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "Total Amount"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.BorderSize = 3
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Location = New System.Drawing.Point(1086, 130)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(115, 40)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnSubmit.FlatAppearance.BorderSize = 3
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnSubmit.Location = New System.Drawing.Point(825, 130)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(115, 40)
        Me.btnSubmit.TabIndex = 25
        Me.btnSubmit.Text = "Save"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtPaidamo
        '
        Me.txtPaidamo.Location = New System.Drawing.Point(484, 26)
        Me.txtPaidamo.Name = "txtPaidamo"
        Me.txtPaidamo.Size = New System.Drawing.Size(170, 28)
        Me.txtPaidamo.TabIndex = 21
        Me.txtPaidamo.Text = "0.00"
        '
        'cmbPayment
        '
        Me.cmbPayment.FormattingEnabled = True
        Me.cmbPayment.Items.AddRange(New Object() {"Cash", "Patym", "Debit Card", "Credit Card", "Others"})
        Me.cmbPayment.Location = New System.Drawing.Point(484, 60)
        Me.cmbPayment.Name = "cmbPayment"
        Me.cmbPayment.Size = New System.Drawing.Size(170, 29)
        Me.cmbPayment.TabIndex = 22
        Me.cmbPayment.Text = "Cash"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(324, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 21)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Payment By"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(324, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(109, 21)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Paid amount"
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(140, 95)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(161, 28)
        Me.txtDiscount.TabIndex = 18
        Me.txtDiscount.Text = "0.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 95)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 21)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "% Discount"
        '
        'txtgstamount
        '
        Me.txtgstamount.Location = New System.Drawing.Point(140, 61)
        Me.txtgstamount.Name = "txtgstamount"
        Me.txtgstamount.ReadOnly = True
        Me.txtgstamount.Size = New System.Drawing.Size(161, 28)
        Me.txtgstamount.TabIndex = 17
        '
        'txtgstRate
        '
        Me.txtgstRate.Location = New System.Drawing.Point(140, 27)
        Me.txtgstRate.Name = "txtgstRate"
        Me.txtgstRate.Size = New System.Drawing.Size(161, 28)
        Me.txtgstRate.TabIndex = 16
        Me.txtgstRate.Text = "0.00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 21)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "GST Amount"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 21)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "GST Rate"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(877, 26)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(84, 21)
        Me.Label22.TabIndex = 9
        Me.Label22.Text = "Bill Date"
        '
        'dtmpBillDate
        '
        Me.dtmpBillDate.Location = New System.Drawing.Point(994, 20)
        Me.dtmpBillDate.Name = "dtmpBillDate"
        Me.dtmpBillDate.Size = New System.Drawing.Size(200, 28)
        Me.dtmpBillDate.TabIndex = 10
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(430, 68)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(134, 21)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "Contact Number"
        '
        'txtContactNo
        '
        Me.txtContactNo.Location = New System.Drawing.Point(582, 63)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(214, 28)
        Me.txtContactNo.TabIndex = 12
        Me.txtContactNo.Text = "7870702602"
        '
        'PrintBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1258, 594)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrintBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PrintBill"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtRefered As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtBillNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtMrpRate As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBatch As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtPaidamo As TextBox
    Friend WithEvents cmbPayment As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtgstamount As TextBox
    Friend WithEvents txtgstRate As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDues As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents txtTotalQ As TextBox
    Friend WithEvents txtsubTotal As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtDiscAmnt As TextBox
    Friend WithEvents cmbProductName As ComboBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents dtmpExp As DateTimePicker
    Friend WithEvents dtmpMfg As DateTimePicker
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents dtmpBillDate As DateTimePicker
    Friend WithEvents Label22 As Label
End Class
