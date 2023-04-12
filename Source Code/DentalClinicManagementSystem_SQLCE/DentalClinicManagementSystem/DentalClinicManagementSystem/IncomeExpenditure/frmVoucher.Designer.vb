<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVoucher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVoucher))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtpDateOfVoucher = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVoucherID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtReferenceNumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.rbRevenue = New System.Windows.Forms.RadioButton()
        Me.rbExpense = New System.Windows.Forms.RadioButton()
        Me.cmbAccountName = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 62)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(55, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Voucher"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DentalClinicManagementSystem.My.Resources.Resources.money_bag
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(20, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 39)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'dtpDateOfVoucher
        '
        Me.dtpDateOfVoucher.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDateOfVoucher.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateOfVoucher.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOfVoucher.Location = New System.Drawing.Point(20, 240)
        Me.dtpDateOfVoucher.Name = "dtpDateOfVoucher"
        Me.dtpDateOfVoucher.Size = New System.Drawing.Size(219, 22)
        Me.dtpDateOfVoucher.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(20, 222)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 14)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(20, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 14)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Voucher Type"
        '
        'txtVoucherID
        '
        Me.txtVoucherID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVoucherID.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucherID.Location = New System.Drawing.Point(20, 99)
        Me.txtVoucherID.Name = "txtVoucherID"
        Me.txtVoucherID.ReadOnly = True
        Me.txtVoucherID.Size = New System.Drawing.Size(90, 22)
        Me.txtVoucherID.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(20, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 14)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Voucher ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(20, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 14)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Account Name"
        '
        'txtAmount
        '
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(266, 145)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(222, 22)
        Me.txtAmount.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(266, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 14)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Amount"
        '
        'txtReferenceNumber
        '
        Me.txtReferenceNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReferenceNumber.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenceNumber.Location = New System.Drawing.Point(266, 99)
        Me.txtReferenceNumber.Name = "txtReferenceNumber"
        Me.txtReferenceNumber.Size = New System.Drawing.Size(222, 22)
        Me.txtReferenceNumber.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(266, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 14)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Reference Number"
        '
        'txtRemark
        '
        Me.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemark.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemark.Location = New System.Drawing.Point(257, 175)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemark.Size = New System.Drawing.Size(222, 22)
        Me.txtRemark.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(257, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 14)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Remark"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'rbRevenue
        '
        Me.rbRevenue.AutoSize = True
        Me.rbRevenue.Checked = True
        Me.rbRevenue.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRevenue.Location = New System.Drawing.Point(23, 148)
        Me.rbRevenue.Name = "rbRevenue"
        Me.rbRevenue.Size = New System.Drawing.Size(82, 18)
        Me.rbRevenue.TabIndex = 4
        Me.rbRevenue.TabStop = True
        Me.rbRevenue.Text = "Revenue"
        Me.rbRevenue.UseVisualStyleBackColor = True
        '
        'rbExpense
        '
        Me.rbExpense.AutoSize = True
        Me.rbExpense.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbExpense.Location = New System.Drawing.Point(104, 148)
        Me.rbExpense.Name = "rbExpense"
        Me.rbExpense.Size = New System.Drawing.Size(80, 18)
        Me.rbExpense.TabIndex = 5
        Me.rbExpense.Text = "Expense"
        Me.rbExpense.UseVisualStyleBackColor = True
        '
        'cmbAccountName
        '
        Me.cmbAccountName.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.cmbAccountName.FormattingEnabled = True
        Me.cmbAccountName.Location = New System.Drawing.Point(20, 195)
        Me.cmbAccountName.Name = "cmbAccountName"
        Me.cmbAccountName.Size = New System.Drawing.Size(219, 22)
        Me.cmbAccountName.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbPaymentMethod)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.txtRemark)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 210)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'cmbPaymentMethod
        '
        Me.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPaymentMethod.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.cmbPaymentMethod.FormattingEnabled = True
        Me.cmbPaymentMethod.Items.AddRange(New Object() {"CASH", "BANK"})
        Me.cmbPaymentMethod.Location = New System.Drawing.Point(257, 130)
        Me.cmbPaymentMethod.Name = "cmbPaymentMethod"
        Me.cmbPaymentMethod.Size = New System.Drawing.Size(113, 22)
        Me.cmbPaymentMethod.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(257, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 14)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Payment Method"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(130, 111)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(98, 13)
        Me.LinkLabel1.TabIndex = 40
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "ADD ACCOUNT"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.DentalClinicManagementSystem.My.Resources.Resources._Exit
        Me.btnClose.Location = New System.Drawing.Point(381, 287)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(116, 33)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Redo
        Me.btnReset.Location = New System.Drawing.Point(260, 287)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(116, 33)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "RESET"
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(137, 287)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 33)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(9, 273)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(528, 57)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        '
        'frmVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 337)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbAccountName)
        Me.Controls.Add(Me.rbExpense)
        Me.Controls.Add(Me.rbRevenue)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtReferenceNumber)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpDateOfVoucher)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtVoucherID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmVoucher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voucher"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dtpDateOfVoucher As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtVoucherID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtReferenceNumber As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents rbRevenue As RadioButton
    Friend WithEvents rbExpense As RadioButton
    Friend WithEvents cmbAccountName As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents Label8 As Label
End Class
