<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesReport
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesReport))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbDatePaidBill = New System.Windows.Forms.RadioButton()
        Me.cmbProduct = New System.Windows.Forms.ComboBox()
        Me.rbDateItemName = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbDateDueBill = New System.Windows.Forms.RadioButton()
        Me.rbDateCustomerName = New System.Windows.Forms.RadioButton()
        Me.rbDate = New System.Windows.Forms.RadioButton()
        Me.rbDatePatientID = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPrintView = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(540, 62)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(55, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pharmacy  > Sales Report"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DentalClinicManagementSystem.My.Resources.Resources.listview_head
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(20, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 39)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCustomer)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.txtPatientID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.rbDatePaidBill)
        Me.GroupBox1.Controls.Add(Me.cmbProduct)
        Me.GroupBox1.Controls.Add(Me.rbDateItemName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.rbDateDueBill)
        Me.GroupBox1.Controls.Add(Me.rbDateCustomerName)
        Me.GroupBox1.Controls.Add(Me.rbDate)
        Me.GroupBox1.Controls.Add(Me.rbDatePatientID)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(522, 208)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'btnCustomer
        '
        Me.btnCustomer.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Table
        Me.btnCustomer.Location = New System.Drawing.Point(480, 40)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(29, 24)
        Me.btnCustomer.TabIndex = 46
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(294, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Customer Name"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(397, 68)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(112, 21)
        Me.txtCustomerName.TabIndex = 44
        '
        'txtPatientID
        '
        Me.txtPatientID.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtPatientID.Location = New System.Drawing.Point(397, 41)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(77, 21)
        Me.txtPatientID.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(321, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Patient ID#"
        '
        'rbDatePaidBill
        '
        Me.rbDatePaidBill.AutoSize = True
        Me.rbDatePaidBill.Location = New System.Drawing.Point(47, 92)
        Me.rbDatePaidBill.Name = "rbDatePaidBill"
        Me.rbDatePaidBill.Size = New System.Drawing.Size(198, 18)
        Me.rbDatePaidBill.TabIndex = 39
        Me.rbDatePaidBill.Text = "FILTER BY DATE && PAID BILL"
        Me.rbDatePaidBill.UseVisualStyleBackColor = True
        '
        'cmbProduct
        '
        Me.cmbProduct.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Location = New System.Drawing.Point(68, 176)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(219, 21)
        Me.cmbProduct.TabIndex = 36
        '
        'rbDateItemName
        '
        Me.rbDateItemName.AutoSize = True
        Me.rbDateItemName.Location = New System.Drawing.Point(47, 141)
        Me.rbDateItemName.Name = "rbDateItemName"
        Me.rbDateItemName.Size = New System.Drawing.Size(206, 18)
        Me.rbDateItemName.TabIndex = 38
        Me.rbDateItemName.Text = "FILTER BY DATE && ITEM NAME"
        Me.rbDateItemName.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(68, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "ITEM LIST :"
        '
        'rbDateDueBill
        '
        Me.rbDateDueBill.AutoSize = True
        Me.rbDateDueBill.Location = New System.Drawing.Point(47, 116)
        Me.rbDateDueBill.Name = "rbDateDueBill"
        Me.rbDateDueBill.Size = New System.Drawing.Size(224, 18)
        Me.rbDateDueBill.TabIndex = 37
        Me.rbDateDueBill.Text = "FILTER BY DATE && PAYMENT DUE"
        Me.rbDateDueBill.UseVisualStyleBackColor = True
        '
        'rbDateCustomerName
        '
        Me.rbDateCustomerName.AutoSize = True
        Me.rbDateCustomerName.Location = New System.Drawing.Point(47, 68)
        Me.rbDateCustomerName.Name = "rbDateCustomerName"
        Me.rbDateCustomerName.Size = New System.Drawing.Size(245, 18)
        Me.rbDateCustomerName.TabIndex = 36
        Me.rbDateCustomerName.Text = "FILTER BY DATE && CUSTOMER NAME"
        Me.rbDateCustomerName.UseVisualStyleBackColor = True
        '
        'rbDate
        '
        Me.rbDate.AutoSize = True
        Me.rbDate.Checked = True
        Me.rbDate.Location = New System.Drawing.Point(47, 21)
        Me.rbDate.Name = "rbDate"
        Me.rbDate.Size = New System.Drawing.Size(120, 18)
        Me.rbDate.TabIndex = 34
        Me.rbDate.TabStop = True
        Me.rbDate.Text = "FILTER BY DATE"
        Me.rbDate.UseVisualStyleBackColor = True
        '
        'rbDatePatientID
        '
        Me.rbDatePatientID.AutoSize = True
        Me.rbDatePatientID.Location = New System.Drawing.Point(47, 44)
        Me.rbDatePatientID.Name = "rbDatePatientID"
        Me.rbDatePatientID.Size = New System.Drawing.Size(206, 18)
        Me.rbDatePatientID.TabIndex = 35
        Me.rbDatePatientID.Text = "FILTER BY DATE && PATIENT ID"
        Me.rbDatePatientID.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpDateTo)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.dtpDateFrom)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 269)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(522, 45)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDateTo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(239, 15)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(138, 22)
        Me.dtpDateTo.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(26, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 14)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "From"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDateFrom.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(70, 15)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(138, 22)
        Me.dtpDateFrom.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(212, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 14)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "To"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnClose)
        Me.GroupBox3.Controls.Add(Me.btnPrintView)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 309)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(522, 55)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.DentalClinicManagementSystem.My.Resources.Resources._Exit
        Me.btnClose.Location = New System.Drawing.Point(229, 11)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(116, 33)
        Me.btnClose.TabIndex = 32
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPrintView
        '
        Me.btnPrintView.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintView.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Print
        Me.btnPrintView.Location = New System.Drawing.Point(112, 10)
        Me.btnPrintView.Name = "btnPrintView"
        Me.btnPrintView.Size = New System.Drawing.Size(113, 34)
        Me.btnPrintView.TabIndex = 33
        Me.btnPrintView.Text = "PRINT VIEW"
        Me.btnPrintView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrintView.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmSalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 371)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "frmSalesReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pharmacy  > Sales Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbProduct As ComboBox
    Friend WithEvents rbDate As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents rbDatePatientID As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPrintView As Button
    Friend WithEvents rbDateItemName As RadioButton
    Friend WithEvents rbDateDueBill As RadioButton
    Friend WithEvents rbDateCustomerName As RadioButton
    Friend WithEvents rbDatePaidBill As RadioButton
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents btnCustomer As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
