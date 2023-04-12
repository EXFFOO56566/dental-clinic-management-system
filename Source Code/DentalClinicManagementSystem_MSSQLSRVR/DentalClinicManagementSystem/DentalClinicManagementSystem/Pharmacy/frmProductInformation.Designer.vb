<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductInformation))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGenericName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpManufactureDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpExpirationDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUOM = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPurchasePrice = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSalesPrice = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lnkBrowse = New System.Windows.Forms.LinkLabel()
        Me.ProductImage = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ProductImage, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(637, 62)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(55, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Information"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DentalClinicManagementSystem.My.Resources.Resources.drugs_capsules_and_pills
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(20, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 39)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'txtProductID
        '
        Me.txtProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductID.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductID.Location = New System.Drawing.Point(32, 101)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.ReadOnly = True
        Me.txtProductID.Size = New System.Drawing.Size(222, 22)
        Me.txtProductID.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(32, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Product ID"
        '
        'txtProductName
        '
        Me.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(32, 144)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(222, 22)
        Me.txtProductName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(32, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Product Name"
        '
        'txtGenericName
        '
        Me.txtGenericName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGenericName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenericName.Location = New System.Drawing.Point(32, 187)
        Me.txtGenericName.Name = "txtGenericName"
        Me.txtGenericName.Size = New System.Drawing.Size(222, 22)
        Me.txtGenericName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(32, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 14)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Generic Name"
        '
        'dtpManufactureDate
        '
        Me.dtpManufactureDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpManufactureDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpManufactureDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpManufactureDate.Location = New System.Drawing.Point(32, 275)
        Me.dtpManufactureDate.Name = "dtpManufactureDate"
        Me.dtpManufactureDate.Size = New System.Drawing.Size(222, 22)
        Me.dtpManufactureDate.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(32, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 14)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Manufacture Date"
        '
        'dtpExpirationDate
        '
        Me.dtpExpirationDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpExpirationDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpExpirationDate.Location = New System.Drawing.Point(32, 320)
        Me.dtpExpirationDate.Name = "dtpExpirationDate"
        Me.dtpExpirationDate.Size = New System.Drawing.Size(222, 22)
        Me.dtpExpirationDate.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(32, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 14)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Expiration Date"
        '
        'txtBarcode
        '
        Me.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBarcode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(290, 144)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(121, 22)
        Me.txtBarcode.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(290, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 14)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Barcode"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(32, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 14)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Category"
        '
        'txtQuantity
        '
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(290, 232)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(121, 22)
        Me.txtQuantity.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(290, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 14)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Quantity"
        '
        'txtUOM
        '
        Me.txtUOM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUOM.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUOM.Location = New System.Drawing.Point(290, 187)
        Me.txtUOM.Name = "txtUOM"
        Me.txtUOM.Size = New System.Drawing.Size(121, 22)
        Me.txtUOM.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(290, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 14)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "UOM"
        '
        'txtPurchasePrice
        '
        Me.txtPurchasePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPurchasePrice.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchasePrice.Location = New System.Drawing.Point(290, 275)
        Me.txtPurchasePrice.Name = "txtPurchasePrice"
        Me.txtPurchasePrice.Size = New System.Drawing.Size(121, 22)
        Me.txtPurchasePrice.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(290, 258)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 14)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Purchase Price"
        '
        'txtSalesPrice
        '
        Me.txtSalesPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalesPrice.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesPrice.Location = New System.Drawing.Point(290, 320)
        Me.txtSalesPrice.Name = "txtSalesPrice"
        Me.txtSalesPrice.Size = New System.Drawing.Size(121, 22)
        Me.txtSalesPrice.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(290, 302)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 14)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Sales Price"
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(32, 233)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(222, 21)
        Me.cmbCategory.TabIndex = 2
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(145, 216)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(105, 13)
        Me.LinkLabel1.TabIndex = 35
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "ADD CATEGORY"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 291)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Information"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.lnkBrowse)
        Me.GroupBox3.Controls.Add(Me.ProductImage)
        Me.GroupBox3.Location = New System.Drawing.Point(446, 68)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(180, 291)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(6, 188)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(172, 42)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Note: This Image may appear distorted in this screen."
        '
        'lnkBrowse
        '
        Me.lnkBrowse.AutoSize = True
        Me.lnkBrowse.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkBrowse.Location = New System.Drawing.Point(6, 228)
        Me.lnkBrowse.Name = "lnkBrowse"
        Me.lnkBrowse.Size = New System.Drawing.Size(90, 13)
        Me.lnkBrowse.TabIndex = 0
        Me.lnkBrowse.TabStop = True
        Me.lnkBrowse.Text = "Browse Image"
        '
        'ProductImage
        '
        Me.ProductImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProductImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProductImage.ErrorImage = Global.DentalClinicManagementSystem.My.Resources.Resources.no_images
        Me.ProductImage.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.no_images
        Me.ProductImage.Location = New System.Drawing.Point(7, 15)
        Me.ProductImage.Name = "ProductImage"
        Me.ProductImage.Size = New System.Drawing.Size(167, 170)
        Me.ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductImage.TabIndex = 0
        Me.ProductImage.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(12, 358)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(614, 62)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.DentalClinicManagementSystem.My.Resources.Resources._Exit
        Me.btnClose.Location = New System.Drawing.Point(361, 374)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(116, 33)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Redo
        Me.btnReset.Location = New System.Drawing.Point(238, 374)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(116, 33)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "RESET"
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(114, 374)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 33)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmProductInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 430)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.txtSalesPrice)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPurchasePrice)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtUOM)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpExpirationDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpManufactureDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtGenericName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmProductInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Information"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ProductImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGenericName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpManufactureDate As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpExpirationDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUOM As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPurchasePrice As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtSalesPrice As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lnkBrowse As LinkLabel
    Friend WithEvents ProductImage As PictureBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
