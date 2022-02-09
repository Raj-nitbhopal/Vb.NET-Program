<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MasterForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RackMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoustmerInvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToDeveloperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurrentStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductRecoderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesDateWiseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OthersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToDeveloperToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImporrtantContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnProductMaster = New System.Windows.Forms.Button()
        Me.btnPrintBill = New System.Windows.Forms.Button()
        Me.btnCurrentStock = New System.Windows.Forms.Button()
        Me.btnSupplierMaster = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvSearch = New System.Windows.Forms.DataGridView()
        Me.cmbSearchList = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnReorder = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnCalculator = New System.Windows.Forms.Button()
        Me.btnNotepad = New System.Windows.Forms.Button()
        Me.btnWord = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.Process1 = New System.Diagnostics.Process()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterFormToolStripMenuItem, Me.SellToolStripMenuItem, Me.ContactToDeveloperToolStripMenuItem, Me.TransactionsToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.OthersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(259, 57)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(635, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterFormToolStripMenuItem
        '
        Me.MasterFormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductMasterToolStripMenuItem, Me.SupplierMasterToolStripMenuItem, Me.RackMasterToolStripMenuItem, Me.UserMasterToolStripMenuItem})
        Me.MasterFormToolStripMenuItem.Name = "MasterFormToolStripMenuItem"
        Me.MasterFormToolStripMenuItem.Size = New System.Drawing.Size(131, 26)
        Me.MasterFormToolStripMenuItem.Text = "Master Form"
        '
        'ProductMasterToolStripMenuItem
        '
        Me.ProductMasterToolStripMenuItem.Name = "ProductMasterToolStripMenuItem"
        Me.ProductMasterToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.ProductMasterToolStripMenuItem.Text = "Product Master"
        '
        'SupplierMasterToolStripMenuItem
        '
        Me.SupplierMasterToolStripMenuItem.Name = "SupplierMasterToolStripMenuItem"
        Me.SupplierMasterToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.SupplierMasterToolStripMenuItem.Text = "Supplier Master"
        '
        'RackMasterToolStripMenuItem
        '
        Me.RackMasterToolStripMenuItem.Name = "RackMasterToolStripMenuItem"
        Me.RackMasterToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.RackMasterToolStripMenuItem.Text = "Rack Master"
        '
        'UserMasterToolStripMenuItem
        '
        Me.UserMasterToolStripMenuItem.Name = "UserMasterToolStripMenuItem"
        Me.UserMasterToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.UserMasterToolStripMenuItem.Text = "User Master"
        '
        'SellToolStripMenuItem
        '
        Me.SellToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CoustmerInvoiceToolStripMenuItem})
        Me.SellToolStripMenuItem.Name = "SellToolStripMenuItem"
        Me.SellToolStripMenuItem.Size = New System.Drawing.Size(116, 26)
        Me.SellToolStripMenuItem.Text = "Sell Master"
        '
        'CoustmerInvoiceToolStripMenuItem
        '
        Me.CoustmerInvoiceToolStripMenuItem.Name = "CoustmerInvoiceToolStripMenuItem"
        Me.CoustmerInvoiceToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CoustmerInvoiceToolStripMenuItem.Text = "Coustmer Invoice"
        '
        'ContactToDeveloperToolStripMenuItem
        '
        Me.ContactToDeveloperToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurrentStockToolStripMenuItem, Me.ProductRecoderToolStripMenuItem, Me.SalesDateWiseToolStripMenuItem})
        Me.ContactToDeveloperToolStripMenuItem.Name = "ContactToDeveloperToolStripMenuItem"
        Me.ContactToDeveloperToolStripMenuItem.Size = New System.Drawing.Size(87, 26)
        Me.ContactToDeveloperToolStripMenuItem.Text = "Reports"
        '
        'CurrentStockToolStripMenuItem
        '
        Me.CurrentStockToolStripMenuItem.Name = "CurrentStockToolStripMenuItem"
        Me.CurrentStockToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CurrentStockToolStripMenuItem.Text = "Current Stock"
        '
        'ProductRecoderToolStripMenuItem
        '
        Me.ProductRecoderToolStripMenuItem.Name = "ProductRecoderToolStripMenuItem"
        Me.ProductRecoderToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ProductRecoderToolStripMenuItem.Text = "Product Recoder "
        '
        'SalesDateWiseToolStripMenuItem
        '
        Me.SalesDateWiseToolStripMenuItem.Name = "SalesDateWiseToolStripMenuItem"
        Me.SalesDateWiseToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SalesDateWiseToolStripMenuItem.Text = "Sales- DateWise"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.TransactionsToolStripMenuItem.Text = "Transactions"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(87, 26)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'OthersToolStripMenuItem
        '
        Me.OthersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ContactToDeveloperToolStripMenuItem1, Me.ImporrtantContactToolStripMenuItem})
        Me.OthersToolStripMenuItem.Name = "OthersToolStripMenuItem"
        Me.OthersToolStripMenuItem.Size = New System.Drawing.Size(78, 26)
        Me.OthersToolStripMenuItem.Text = "Others"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(259, 26)
        Me.ToolStripMenuItem1.Text = "Vendor Contact No"
        '
        'ContactToDeveloperToolStripMenuItem1
        '
        Me.ContactToDeveloperToolStripMenuItem1.Name = "ContactToDeveloperToolStripMenuItem1"
        Me.ContactToDeveloperToolStripMenuItem1.Size = New System.Drawing.Size(259, 26)
        Me.ContactToDeveloperToolStripMenuItem1.Text = "Contact To Developer"
        '
        'ImporrtantContactToolStripMenuItem
        '
        Me.ImporrtantContactToolStripMenuItem.Name = "ImporrtantContactToolStripMenuItem"
        Me.ImporrtantContactToolStripMenuItem.Size = New System.Drawing.Size(259, 26)
        Me.ImporrtantContactToolStripMenuItem.Text = "Importants Contacts"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 604)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(0, 357)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(251, 85)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(0, 442)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ShowWeekNumbers = True
        Me.MonthCalendar1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btnProductMaster
        '
        Me.btnProductMaster.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnProductMaster.BackgroundImage = CType(resources.GetObject("btnProductMaster.BackgroundImage"), System.Drawing.Image)
        Me.btnProductMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnProductMaster.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnProductMaster.FlatAppearance.BorderSize = 5
        Me.btnProductMaster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnProductMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductMaster.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductMaster.Location = New System.Drawing.Point(626, 415)
        Me.btnProductMaster.Name = "btnProductMaster"
        Me.btnProductMaster.Size = New System.Drawing.Size(140, 140)
        Me.btnProductMaster.TabIndex = 3
        Me.btnProductMaster.UseVisualStyleBackColor = False
        '
        'btnPrintBill
        '
        Me.btnPrintBill.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPrintBill.BackgroundImage = CType(resources.GetObject("btnPrintBill.BackgroundImage"), System.Drawing.Image)
        Me.btnPrintBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrintBill.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnPrintBill.FlatAppearance.BorderSize = 5
        Me.btnPrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintBill.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintBill.Location = New System.Drawing.Point(626, 212)
        Me.btnPrintBill.Name = "btnPrintBill"
        Me.btnPrintBill.Size = New System.Drawing.Size(140, 140)
        Me.btnPrintBill.TabIndex = 4
        Me.btnPrintBill.UseVisualStyleBackColor = False
        '
        'btnCurrentStock
        '
        Me.btnCurrentStock.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCurrentStock.BackgroundImage = CType(resources.GetObject("btnCurrentStock.BackgroundImage"), System.Drawing.Image)
        Me.btnCurrentStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCurrentStock.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCurrentStock.FlatAppearance.BorderSize = 5
        Me.btnCurrentStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCurrentStock.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurrentStock.Location = New System.Drawing.Point(809, 212)
        Me.btnCurrentStock.Name = "btnCurrentStock"
        Me.btnCurrentStock.Size = New System.Drawing.Size(140, 140)
        Me.btnCurrentStock.TabIndex = 5
        Me.btnCurrentStock.UseVisualStyleBackColor = False
        '
        'btnSupplierMaster
        '
        Me.btnSupplierMaster.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSupplierMaster.BackgroundImage = CType(resources.GetObject("btnSupplierMaster.BackgroundImage"), System.Drawing.Image)
        Me.btnSupplierMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSupplierMaster.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnSupplierMaster.FlatAppearance.BorderSize = 5
        Me.btnSupplierMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplierMaster.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplierMaster.Location = New System.Drawing.Point(994, 211)
        Me.btnSupplierMaster.Name = "btnSupplierMaster"
        Me.btnSupplierMaster.Size = New System.Drawing.Size(140, 140)
        Me.btnSupplierMaster.TabIndex = 6
        Me.btnSupplierMaster.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderSize = 5
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1178, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 140)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(622, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 22)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Stock Recorder"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(621, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Print Bill"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(802, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Current Stock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(990, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Retailer Master"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1174, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 24)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Sell Report"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.dgvSearch)
        Me.GroupBox2.Controls.Add(Me.cmbSearchList)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(266, 179)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(349, 482)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Medicine"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSearch.Location = New System.Drawing.Point(96, 137)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(131, 36)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'dgvSearch
        '
        Me.dgvSearch.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.Location = New System.Drawing.Point(6, 190)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.Size = New System.Drawing.Size(337, 286)
        Me.dgvSearch.TabIndex = 3
        '
        'cmbSearchList
        '
        Me.cmbSearchList.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchList.FormattingEnabled = True
        Me.cmbSearchList.Items.AddRange(New Object() {"Medicine Name", "Batch Number", "Composition", "Rack Number"})
        Me.cmbSearchList.Location = New System.Drawing.Point(6, 33)
        Me.cmbSearchList.Name = "cmbSearchList"
        Me.cmbSearchList.Size = New System.Drawing.Size(337, 32)
        Me.cmbSearchList.TabIndex = 2
        Me.cmbSearchList.Text = "Search By"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(6, 86)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(337, 30)
        Me.txtSearch.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.BorderSize = 5
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(809, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 140)
        Me.Button2.TabIndex = 14
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(802, 381)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 21)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "DateWise Report"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(990, 381)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 24)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Re-Order Form"
        '
        'btnReorder
        '
        Me.btnReorder.BackgroundImage = CType(resources.GetObject("btnReorder.BackgroundImage"), System.Drawing.Image)
        Me.btnReorder.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnReorder.FlatAppearance.BorderSize = 5
        Me.btnReorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReorder.Location = New System.Drawing.Point(994, 416)
        Me.btnReorder.Name = "btnReorder"
        Me.btnReorder.Size = New System.Drawing.Size(140, 140)
        Me.btnReorder.TabIndex = 17
        Me.btnReorder.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1174, 381)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 24)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Transactios"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button4.FlatAppearance.BorderSize = 5
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(1178, 415)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(140, 140)
        Me.Button4.TabIndex = 19
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnCalculator
        '
        Me.btnCalculator.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCalculator.BackgroundImage = CType(resources.GetObject("btnCalculator.BackgroundImage"), System.Drawing.Image)
        Me.btnCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalculator.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCalculator.FlatAppearance.BorderSize = 3
        Me.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculator.Location = New System.Drawing.Point(626, 592)
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.Size = New System.Drawing.Size(143, 69)
        Me.btnCalculator.TabIndex = 0
        Me.btnCalculator.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCalculator.UseVisualStyleBackColor = False
        '
        'btnNotepad
        '
        Me.btnNotepad.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNotepad.BackgroundImage = CType(resources.GetObject("btnNotepad.BackgroundImage"), System.Drawing.Image)
        Me.btnNotepad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNotepad.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnNotepad.FlatAppearance.BorderSize = 3
        Me.btnNotepad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotepad.Location = New System.Drawing.Point(809, 592)
        Me.btnNotepad.Name = "btnNotepad"
        Me.btnNotepad.Size = New System.Drawing.Size(140, 69)
        Me.btnNotepad.TabIndex = 1
        Me.btnNotepad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNotepad.UseVisualStyleBackColor = False
        '
        'btnWord
        '
        Me.btnWord.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnWord.BackgroundImage = CType(resources.GetObject("btnWord.BackgroundImage"), System.Drawing.Image)
        Me.btnWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnWord.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnWord.FlatAppearance.BorderSize = 3
        Me.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWord.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWord.Location = New System.Drawing.Point(994, 592)
        Me.btnWord.Name = "btnWord"
        Me.btnWord.Size = New System.Drawing.Size(140, 69)
        Me.btnWord.TabIndex = 2
        Me.btnWord.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnWord.UseVisualStyleBackColor = False
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExcel.BackgroundImage = CType(resources.GetObject("btnExcel.BackgroundImage"), System.Drawing.Image)
        Me.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnExcel.FlatAppearance.BorderSize = 3
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Location = New System.Drawing.Point(1178, 592)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(140, 69)
        Me.btnExcel.TabIndex = 3
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'MasterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1358, 687)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnWord)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnNotepad)
        Me.Controls.Add(Me.btnReorder)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnCalculator)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSupplierMaster)
        Me.Controls.Add(Me.btnCurrentStock)
        Me.Controls.Add(Me.btnPrintBill)
        Me.Controls.Add(Me.btnProductMaster)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MasterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SellToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactToDeveloperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OthersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContactToDeveloperToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ImporrtantContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupplierMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RackMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CurrentStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductRecoderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesDateWiseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CoustmerInvoiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnProductMaster As Button
    Friend WithEvents btnPrintBill As Button
    Friend WithEvents btnCurrentStock As Button
    Friend WithEvents btnSupplierMaster As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbSearchList As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvSearch As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnReorder As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents btnExcel As Button
    Friend WithEvents btnWord As Button
    Friend WithEvents btnNotepad As Button
    Friend WithEvents btnCalculator As Button
    Friend WithEvents Process1 As Process
End Class
