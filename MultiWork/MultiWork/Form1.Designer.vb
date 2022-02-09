<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtLCD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCLEAR_LCD = New System.Windows.Forms.Button()
        Me.btnFactorial = New System.Windows.Forms.Button()
        Me.btnTable = New System.Windows.Forms.Button()
        Me.btnPallindrome = New System.Windows.Forms.Button()
        Me.btnArmstrong = New System.Windows.Forms.Button()
        Me.btnPrime = New System.Windows.Forms.Button()
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtLCD
        '
        Me.txtLCD.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLCD.Location = New System.Drawing.Point(25, 81)
        Me.txtLCD.Multiline = True
        Me.txtLCD.Name = "txtLCD"
        Me.txtLCD.Size = New System.Drawing.Size(339, 39)
        Me.txtLCD.TabIndex = 21
        Me.txtLCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 21)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ENTER  NUMBER"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(390, 502)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 37)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(524, 502)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 37)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCLEAR_LCD
        '
        Me.btnCLEAR_LCD.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLEAR_LCD.Location = New System.Drawing.Point(390, 431)
        Me.btnCLEAR_LCD.Name = "btnCLEAR_LCD"
        Me.btnCLEAR_LCD.Size = New System.Drawing.Size(225, 54)
        Me.btnCLEAR_LCD.TabIndex = 17
        Me.btnCLEAR_LCD.Text = "CLEAR_LCD"
        Me.btnCLEAR_LCD.UseVisualStyleBackColor = True
        '
        'btnFactorial
        '
        Me.btnFactorial.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactorial.Location = New System.Drawing.Point(390, 366)
        Me.btnFactorial.Name = "btnFactorial"
        Me.btnFactorial.Size = New System.Drawing.Size(225, 49)
        Me.btnFactorial.TabIndex = 16
        Me.btnFactorial.Text = "PRINT FACTORIAL"
        Me.btnFactorial.UseVisualStyleBackColor = True
        '
        'btnTable
        '
        Me.btnTable.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTable.Location = New System.Drawing.Point(390, 296)
        Me.btnTable.Name = "btnTable"
        Me.btnTable.Size = New System.Drawing.Size(225, 54)
        Me.btnTable.TabIndex = 15
        Me.btnTable.Text = "PRINT TABLE "
        Me.btnTable.UseVisualStyleBackColor = True
        '
        'btnPallindrome
        '
        Me.btnPallindrome.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPallindrome.Location = New System.Drawing.Point(390, 229)
        Me.btnPallindrome.Name = "btnPallindrome"
        Me.btnPallindrome.Size = New System.Drawing.Size(225, 51)
        Me.btnPallindrome.TabIndex = 14
        Me.btnPallindrome.Text = "CHECK PALLINDROME NUMBER"
        Me.btnPallindrome.UseVisualStyleBackColor = True
        '
        'btnArmstrong
        '
        Me.btnArmstrong.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArmstrong.Location = New System.Drawing.Point(390, 162)
        Me.btnArmstrong.Name = "btnArmstrong"
        Me.btnArmstrong.Size = New System.Drawing.Size(225, 52)
        Me.btnArmstrong.TabIndex = 13
        Me.btnArmstrong.Text = "CHECK ARMSTRONG NUMBER"
        Me.btnArmstrong.UseVisualStyleBackColor = True
        '
        'btnPrime
        '
        Me.btnPrime.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrime.Location = New System.Drawing.Point(390, 93)
        Me.btnPrime.Name = "btnPrime"
        Me.btnPrime.Size = New System.Drawing.Size(225, 54)
        Me.btnPrime.TabIndex = 12
        Me.btnPrime.Text = "CHECK PRIME NUMBER"
        Me.btnPrime.UseVisualStyleBackColor = True
        '
        'lstResult
        '
        Me.lstResult.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.ItemHeight = 21
        Me.lstResult.Location = New System.Drawing.Point(25, 140)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(339, 403)
        Me.lstResult.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(633, 573)
        Me.Controls.Add(Me.txtLCD)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCLEAR_LCD)
        Me.Controls.Add(Me.btnFactorial)
        Me.Controls.Add(Me.btnTable)
        Me.Controls.Add(Me.btnPallindrome)
        Me.Controls.Add(Me.btnArmstrong)
        Me.Controls.Add(Me.btnPrime)
        Me.Controls.Add(Me.lstResult)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLCD As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCLEAR_LCD As Button
    Friend WithEvents btnFactorial As Button
    Friend WithEvents btnTable As Button
    Friend WithEvents btnPallindrome As Button
    Friend WithEvents btnArmstrong As Button
    Friend WithEvents btnPrime As Button
    Friend WithEvents lstResult As ListBox
End Class
