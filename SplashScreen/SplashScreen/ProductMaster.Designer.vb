<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductMaster
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBatchNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbRack = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtmpExp = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtmpMfg = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSaleRate = New System.Windows.Forms.TextBox()
        Me.txtItemsCost = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtItemCost = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMrpRate = New System.Windows.Forms.TextBox()
        Me.cmbPackageName = New System.Windows.Forms.ComboBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPackItem = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.cmbItem = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPurchaseRate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbProCategory = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProductId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.dtmpExp)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.dtmpMfg)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtSaleRate)
        Me.GroupBox1.Controls.Add(Me.txtItemsCost)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtItemCost)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtMrpRate)
        Me.GroupBox1.Controls.Add(Me.cmbPackageName)
        Me.GroupBox1.Controls.Add(Me.txtProductName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtPackItem)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtItem)
        Me.GroupBox1.Controls.Add(Me.cmbItem)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPurchaseRate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbProCategory)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtProductId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1366, 682)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Master"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(479, 221)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 30)
        Me.TextBox1.TabIndex = 76
        Me.TextBox1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Location = New System.Drawing.Point(19, 343)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1337, 49)
        Me.Panel2.TabIndex = 75
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnUpdate.Location = New System.Drawing.Point(754, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(101, 39)
        Me.btnUpdate.TabIndex = 19
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnSave.Location = New System.Drawing.Point(429, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 39)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnDelete.Location = New System.Drawing.Point(591, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(104, 39)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Menu
        Me.Panel1.Controls.Add(Me.dgv)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Location = New System.Drawing.Point(10, 404)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 272)
        Me.Panel1.TabIndex = 73
        '
        'dgv
        '
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.NullValue = "0"
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv.Location = New System.Drawing.Point(0, 27)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv.Size = New System.Drawing.Size(1347, 237)
        Me.dgv.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label19.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 3)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(147, 21)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Product Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox2.Controls.Add(Me.txtBatchNo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmbRack)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtWeight)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1043, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(298, 137)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rack Master"
        '
        'txtBatchNo
        '
        Me.txtBatchNo.Location = New System.Drawing.Point(133, 22)
        Me.txtBatchNo.Name = "txtBatchNo"
        Me.txtBatchNo.Size = New System.Drawing.Size(159, 28)
        Me.txtBatchNo.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 21)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Batch No."
        '
        'cmbRack
        '
        Me.cmbRack.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbRack.Font = New System.Drawing.Font("Modern No. 20", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRack.FormattingEnabled = True
        Me.cmbRack.Items.AddRange(New Object() {"Rack1", "Rack2", "Rack3", "Rack4", "Rack5", "Rack6"})
        Me.cmbRack.Location = New System.Drawing.Point(133, 101)
        Me.cmbRack.Name = "cmbRack"
        Me.cmbRack.Size = New System.Drawing.Size(159, 28)
        Me.cmbRack.TabIndex = 12
        Me.cmbRack.Text = "SELECT"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(11, 103)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(116, 21)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Rack Number"
        '
        'txtWeight
        '
        Me.txtWeight.BackColor = System.Drawing.Color.GhostWhite
        Me.txtWeight.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(133, 62)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(159, 28)
        Me.txtWeight.TabIndex = 11
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(11, 69)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 21)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Weight "
        '
        'dtmpExp
        '
        Me.dtmpExp.CalendarTitleBackColor = System.Drawing.Color.GhostWhite
        Me.dtmpExp.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtmpExp.Location = New System.Drawing.Point(803, 293)
        Me.dtmpExp.Name = "dtmpExp"
        Me.dtmpExp.Size = New System.Drawing.Size(310, 28)
        Me.dtmpExp.TabIndex = 16
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label18.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(632, 293)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(105, 21)
        Me.Label18.TabIndex = 70
        Me.Label18.Text = "Expiry Date"
        '
        'dtmpMfg
        '
        Me.dtmpMfg.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtmpMfg.Location = New System.Drawing.Point(234, 291)
        Me.dtmpMfg.Name = "dtmpMfg"
        Me.dtmpMfg.Size = New System.Drawing.Size(296, 28)
        Me.dtmpMfg.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label17.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(10, 297)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(168, 21)
        Me.Label17.TabIndex = 68
        Me.Label17.Text = "Manufacturing Date"
        '
        'txtSaleRate
        '
        Me.txtSaleRate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSaleRate.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaleRate.Location = New System.Drawing.Point(803, 243)
        Me.txtSaleRate.Name = "txtSaleRate"
        Me.txtSaleRate.ReadOnly = True
        Me.txtSaleRate.Size = New System.Drawing.Size(180, 28)
        Me.txtSaleRate.TabIndex = 14
        '
        'txtItemsCost
        '
        Me.txtItemsCost.BackColor = System.Drawing.SystemColors.Control
        Me.txtItemsCost.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemsCost.Location = New System.Drawing.Point(803, 199)
        Me.txtItemsCost.Name = "txtItemsCost"
        Me.txtItemsCost.ReadOnly = True
        Me.txtItemsCost.Size = New System.Drawing.Size(180, 28)
        Me.txtItemsCost.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(632, 199)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(165, 21)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Sub-Items Unit Cost"
        '
        'txtItemCost
        '
        Me.txtItemCost.BackColor = System.Drawing.SystemColors.Control
        Me.txtItemCost.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCost.Location = New System.Drawing.Point(803, 154)
        Me.txtItemCost.Name = "txtItemCost"
        Me.txtItemCost.ReadOnly = True
        Me.txtItemCost.Size = New System.Drawing.Size(180, 28)
        Me.txtItemCost.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(632, 155)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 21)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Item Unit Cost"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(632, 246)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 21)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Sale Rate"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(632, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 21)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "MRP Rate"
        '
        'txtMrpRate
        '
        Me.txtMrpRate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtMrpRate.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMrpRate.Location = New System.Drawing.Point(803, 107)
        Me.txtMrpRate.Name = "txtMrpRate"
        Me.txtMrpRate.Size = New System.Drawing.Size(310, 28)
        Me.txtMrpRate.TabIndex = 6
        '
        'cmbPackageName
        '
        Me.cmbPackageName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmbPackageName.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPackageName.FormattingEnabled = True
        Me.cmbPackageName.Items.AddRange(New Object() {"Bag", "Cartoon", "Packet", "Bottles"})
        Me.cmbPackageName.Location = New System.Drawing.Point(803, 64)
        Me.cmbPackageName.Name = "cmbPackageName"
        Me.cmbPackageName.Size = New System.Drawing.Size(310, 29)
        Me.cmbPackageName.TabIndex = 4
        Me.cmbPackageName.Text = "SELECT"
        '
        'txtProductName
        '
        Me.txtProductName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtProductName.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(803, 21)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(310, 28)
        Me.txtProductName.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(632, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 21)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Package Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(632, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 21)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Product Name"
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.SystemColors.Control
        Me.txtQuantity.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(234, 243)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ReadOnly = True
        Me.txtQuantity.Size = New System.Drawing.Size(163, 28)
        Me.txtQuantity.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 247)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 21)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Quantity"
        '
        'txtPackItem
        '
        Me.txtPackItem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPackItem.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPackItem.Location = New System.Drawing.Point(234, 198)
        Me.txtPackItem.Name = "txtPackItem"
        Me.txtPackItem.Size = New System.Drawing.Size(163, 28)
        Me.txtPackItem.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 199)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(205, 21)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "No. of Sub-Items in Pack"
        '
        'txtItem
        '
        Me.txtItem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtItem.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.Location = New System.Drawing.Point(234, 155)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(163, 28)
        Me.txtItem.TabIndex = 7
        '
        'cmbItem
        '
        Me.cmbItem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmbItem.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItem.FormattingEnabled = True
        Me.cmbItem.Items.AddRange(New Object() {"Strip", "Pieces"})
        Me.cmbItem.Location = New System.Drawing.Point(407, 154)
        Me.cmbItem.Name = "cmbItem"
        Me.cmbItem.Size = New System.Drawing.Size(123, 29)
        Me.cmbItem.TabIndex = 8
        Me.cmbItem.Text = "SELECT"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(172, 21)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "No. of Items In Pack"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 21)
        Me.Label5.TabIndex = 39
        '
        'txtPurchaseRate
        '
        Me.txtPurchaseRate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPurchaseRate.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchaseRate.Location = New System.Drawing.Point(234, 111)
        Me.txtPurchaseRate.Name = "txtPurchaseRate"
        Me.txtPurchaseRate.Size = New System.Drawing.Size(163, 28)
        Me.txtPurchaseRate.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 21)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Purchase Rate"
        '
        'cmbProCategory
        '
        Me.cmbProCategory.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmbProCategory.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProCategory.FormattingEnabled = True
        Me.cmbProCategory.Items.AddRange(New Object() {"Tablet", "Syrup", "Balm", "Instruments", "Ointments", "Capsule"})
        Me.cmbProCategory.Location = New System.Drawing.Point(234, 69)
        Me.cmbProCategory.Name = "cmbProCategory"
        Me.cmbProCategory.Size = New System.Drawing.Size(296, 29)
        Me.cmbProCategory.TabIndex = 3
        Me.cmbProCategory.Text = "SELECT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 21)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Category Name"
        '
        'txtProductId
        '
        Me.txtProductId.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtProductId.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductId.Location = New System.Drawing.Point(234, 25)
        Me.txtProductId.Name = "txtProductId"
        Me.txtProductId.Size = New System.Drawing.Size(296, 28)
        Me.txtProductId.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Product ID"
        '
        'ProductMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 683)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ProductMaster"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPackItem As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtItem As TextBox
    Friend WithEvents cmbItem As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPurchaseRate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbProCategory As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProductId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtmpExp As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents dtmpMfg As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents txtSaleRate As TextBox
    Friend WithEvents txtItemsCost As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtItemCost As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMrpRate As TextBox
    Friend WithEvents cmbPackageName As ComboBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbRack As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgv As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtBatchNo As TextBox
    Friend WithEvents Label7 As Label
End Class
