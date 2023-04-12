<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSales))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lnkInvoiceLists = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.cmbProduct = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grpItemDetails = New System.Windows.Forms.GroupBox()
        Me.txtPurchaseCost = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.txtAvailableQuantity = New System.Windows.Forms.TextBox()
        Me.btnAddCart = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.NumericUpDown()
        Me.txtSalesPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column11 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtChangeDue = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPaid = New System.Windows.Forms.NumericUpDown()
        Me.cmbMethod = New System.Windows.Forms.ComboBox()
        Me.txtTotalBill = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.btnNewSale = New System.Windows.Forms.Button()
        Me.chkPrintBill = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpItemDetails.SuspendLayout()
        CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.txtPaid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lnkInvoiceLists)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(855, 62)
        Me.Panel1.TabIndex = 2
        '
        'lnkInvoiceLists
        '
        Me.lnkInvoiceLists.AutoSize = True
        Me.lnkInvoiceLists.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkInvoiceLists.LinkColor = System.Drawing.Color.Red
        Me.lnkInvoiceLists.Location = New System.Drawing.Point(720, 26)
        Me.lnkInvoiceLists.Name = "lnkInvoiceLists"
        Me.lnkInvoiceLists.Size = New System.Drawing.Size(114, 16)
        Me.lnkInvoiceLists.TabIndex = 3
        Me.lnkInvoiceLists.TabStop = True
        Me.lnkInvoiceLists.Text = "INVOICE LISTS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(55, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "New Sale"
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtBarcode)
        Me.GroupBox1.Controls.Add(Me.cmbProduct)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 61)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(191, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 14)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Barcode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 14)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Product Name"
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(192, 30)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(85, 22)
        Me.txtBarcode.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.txtBarcode, "Input the item barcode and press the ""Enter"" key from keyboard.")
        '
        'cmbProduct
        '
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Location = New System.Drawing.Point(6, 30)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(164, 22)
        Me.cmbProduct.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(170, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 14)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "or"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grpItemDetails)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 179)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 218)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'grpItemDetails
        '
        Me.grpItemDetails.Controls.Add(Me.txtPurchaseCost)
        Me.grpItemDetails.Controls.Add(Me.Label10)
        Me.grpItemDetails.Controls.Add(Me.txtProductName)
        Me.grpItemDetails.Controls.Add(Me.txtProductID)
        Me.grpItemDetails.Controls.Add(Me.txtAvailableQuantity)
        Me.grpItemDetails.Controls.Add(Me.btnAddCart)
        Me.grpItemDetails.Controls.Add(Me.Label8)
        Me.grpItemDetails.Controls.Add(Me.Label9)
        Me.grpItemDetails.Controls.Add(Me.Label12)
        Me.grpItemDetails.Controls.Add(Me.txtQuantity)
        Me.grpItemDetails.Controls.Add(Me.txtSalesPrice)
        Me.grpItemDetails.Controls.Add(Me.Label7)
        Me.grpItemDetails.Location = New System.Drawing.Point(24, 8)
        Me.grpItemDetails.Name = "grpItemDetails"
        Me.grpItemDetails.Size = New System.Drawing.Size(243, 204)
        Me.grpItemDetails.TabIndex = 31
        Me.grpItemDetails.TabStop = False
        '
        'txtPurchaseCost
        '
        Me.txtPurchaseCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPurchaseCost.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchaseCost.Location = New System.Drawing.Point(88, 108)
        Me.txtPurchaseCost.Name = "txtPurchaseCost"
        Me.txtPurchaseCost.ReadOnly = True
        Me.txtPurchaseCost.Size = New System.Drawing.Size(43, 22)
        Me.txtPurchaseCost.TabIndex = 45
        Me.txtPurchaseCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPurchaseCost.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(5, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 14)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Quantity"
        '
        'txtProductName
        '
        Me.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(4, 56)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(222, 22)
        Me.txtProductName.TabIndex = 34
        '
        'txtProductID
        '
        Me.txtProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductID.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductID.Location = New System.Drawing.Point(88, 12)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.ReadOnly = True
        Me.txtProductID.Size = New System.Drawing.Size(53, 22)
        Me.txtProductID.TabIndex = 36
        Me.txtProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAvailableQuantity
        '
        Me.txtAvailableQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAvailableQuantity.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableQuantity.Location = New System.Drawing.Point(131, 83)
        Me.txtAvailableQuantity.Name = "txtAvailableQuantity"
        Me.txtAvailableQuantity.ReadOnly = True
        Me.txtAvailableQuantity.Size = New System.Drawing.Size(95, 22)
        Me.txtAvailableQuantity.TabIndex = 38
        Me.txtAvailableQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAddCart
        '
        Me.btnAddCart.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Create
        Me.btnAddCart.Location = New System.Drawing.Point(94, 164)
        Me.btnAddCart.Name = "btnAddCart"
        Me.btnAddCart.Size = New System.Drawing.Size(132, 28)
        Me.btnAddCart.TabIndex = 43
        Me.btnAddCart.Text = "ADD TO CART"
        Me.btnAddCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddCart.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(5, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 14)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Available Quantity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(4, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 14)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Product ID"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(5, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 14)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Sales Price"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(131, 136)
        Me.txtQuantity.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(95, 22)
        Me.txtQuantity.TabIndex = 42
        Me.txtQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtSalesPrice
        '
        Me.txtSalesPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalesPrice.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesPrice.Location = New System.Drawing.Point(131, 108)
        Me.txtSalesPrice.Name = "txtSalesPrice"
        Me.txtSalesPrice.ReadOnly = True
        Me.txtSalesPrice.Size = New System.Drawing.Size(95, 22)
        Me.txtSalesPrice.TabIndex = 39
        Me.txtSalesPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(4, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 14)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Product Name"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(301, 120)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(543, 277)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column11, Me.Column6, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkTurquoise
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(6, 13)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(531, 258)
        Me.DataGridView1.TabIndex = 12
        '
        'Column11
        '
        Me.Column11.Frozen = True
        Me.Column11.HeaderText = ""
        Me.Column11.Image = Global.DentalClinicManagementSystem.My.Resources.Resources._Erase
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column11.Width = 35
        '
        'Column6
        '
        Me.Column6.HeaderText = ""
        Me.Column6.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Create
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 35
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "PRODUCT_ID"
        Me.Column1.HeaderText = "PRO. ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 70
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "ProductName"
        Me.Column2.HeaderText = "PRODUCT NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 160
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Qty"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "QTY."
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 40
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "UnitSales"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column4.HeaderText = "UNIT"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 65
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "TotalSales"
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column5.HeaderText = "TOTAL"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnCustomer)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtCustomerName)
        Me.GroupBox4.Controls.Add(Me.txtPatientID)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(832, 60)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        '
        'btnCustomer
        '
        Me.btnCustomer.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Table
        Me.btnCustomer.Location = New System.Drawing.Point(88, 28)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(29, 24)
        Me.btnCustomer.TabIndex = 11
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 14)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Walk In Customer Name"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(123, 29)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(220, 22)
        Me.txtCustomerName.TabIndex = 9
        '
        'txtPatientID
        '
        Me.txtPatientID.Location = New System.Drawing.Point(9, 29)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(77, 22)
        Me.txtPatientID.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 14)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Patient ID#"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnSave)
        Me.GroupBox5.Controls.Add(Me.txtChangeDue)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.txtPaid)
        Me.GroupBox5.Controls.Add(Me.cmbMethod)
        Me.GroupBox5.Controls.Add(Me.txtTotalBill)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.txtBillNo)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.btnCheckout)
        Me.GroupBox5.Controls.Add(Me.btnNewSale)
        Me.GroupBox5.Controls.Add(Me.chkPrintBill)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 397)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(832, 83)
        Me.GroupBox5.TabIndex = 30
        Me.GroupBox5.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnSave.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(711, 45)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(115, 30)
        Me.btnSave.TabIndex = 50
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnSave, "To create a new bill click on this button.")
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtChangeDue
        '
        Me.txtChangeDue.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangeDue.Location = New System.Drawing.Point(479, 38)
        Me.txtChangeDue.Name = "txtChangeDue"
        Me.txtChangeDue.ReadOnly = True
        Me.txtChangeDue.Size = New System.Drawing.Size(113, 37)
        Me.txtChangeDue.TabIndex = 48
        Me.txtChangeDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.SeaShell
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(479, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 37)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "CHANGE DUE"
        '
        'txtPaid
        '
        Me.txtPaid.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtPaid.Location = New System.Drawing.Point(212, 39)
        Me.txtPaid.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(108, 37)
        Me.txtPaid.TabIndex = 46
        '
        'cmbMethod
        '
        Me.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMethod.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold)
        Me.cmbMethod.FormattingEnabled = True
        Me.cmbMethod.Items.AddRange(New Object() {"----", "CASH", "BANK"})
        Me.cmbMethod.Location = New System.Drawing.Point(326, 39)
        Me.cmbMethod.Name = "cmbMethod"
        Me.cmbMethod.Size = New System.Drawing.Size(145, 37)
        Me.cmbMethod.TabIndex = 45
        '
        'txtTotalBill
        '
        Me.txtTotalBill.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBill.Location = New System.Drawing.Point(88, 38)
        Me.txtTotalBill.Name = "txtTotalBill"
        Me.txtTotalBill.ReadOnly = True
        Me.txtTotalBill.Size = New System.Drawing.Size(118, 37)
        Me.txtTotalBill.TabIndex = 43
        Me.txtTotalBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.SeaShell
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(326, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(145, 53)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "PAYMENT METHOD"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Azure
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(212, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 56)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "PAID"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.SeaShell
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(88, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 37)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "TOTAL"
        '
        'txtBillNo
        '
        Me.txtBillNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBillNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillNo.Location = New System.Drawing.Point(10, 35)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.ReadOnly = True
        Me.txtBillNo.Size = New System.Drawing.Size(73, 22)
        Me.txtBillNo.TabIndex = 38
        Me.txtBillNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.SeaShell
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(10, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 34)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "INVOICE #"
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnCheckout.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCheckout.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Lightning
        Me.btnCheckout.Location = New System.Drawing.Point(598, 14)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(107, 61)
        Me.btnCheckout.TabIndex = 13
        Me.btnCheckout.Text = "CHECKOUT"
        Me.btnCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnCheckout, "To checkout this bill please click on this button.")
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'btnNewSale
        '
        Me.btnNewSale.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btnNewSale.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewSale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnNewSale.Image = Global.DentalClinicManagementSystem.My.Resources.Resources._New
        Me.btnNewSale.Location = New System.Drawing.Point(711, 14)
        Me.btnNewSale.Name = "btnNewSale"
        Me.btnNewSale.Size = New System.Drawing.Size(115, 30)
        Me.btnNewSale.TabIndex = 12
        Me.btnNewSale.Text = "NEW SALE"
        Me.btnNewSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnNewSale, "To create a new bill click on this button.")
        Me.btnNewSale.UseVisualStyleBackColor = False
        '
        'chkPrintBill
        '
        Me.chkPrintBill.AutoSize = True
        Me.chkPrintBill.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrintBill.Location = New System.Drawing.Point(6, 60)
        Me.chkPrintBill.Name = "chkPrintBill"
        Me.chkPrintBill.Size = New System.Drawing.Size(83, 17)
        Me.chkPrintBill.TabIndex = 49
        Me.chkPrintBill.Text = "Print View"
        Me.chkPrintBill.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Hints"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.Frozen = True
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.DentalClinicManagementSystem.My.Resources.Resources._Erase
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.Width = 35
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Create
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Width = 35
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 490)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "frmSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sale"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.grpItemDetails.ResumeLayout(False)
        Me.grpItemDetails.PerformLayout()
        CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.txtPaid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents cmbProduct As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnCustomer As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnNewSale As Button
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents txtSalesPrice As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtAvailableQuantity As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnAddCart As Button
    Friend WithEvents txtQuantity As NumericUpDown
    Friend WithEvents grpItemDetails As GroupBox
    Friend WithEvents btnCheckout As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label13 As Label
    Friend WithEvents txtBillNo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPaid As NumericUpDown
    Friend WithEvents cmbMethod As ComboBox
    Friend WithEvents txtTotalBill As TextBox
    Friend WithEvents txtChangeDue As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents chkPrintBill As CheckBox
    Friend WithEvents txtPurchaseCost As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Column11 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents lnkInvoiceLists As LinkLabel
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
End Class
