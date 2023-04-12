<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrescription
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrescription))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtVisitID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNewPatient = New System.Windows.Forms.Button()
        Me.btnPatientList = New System.Windows.Forms.Button()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAppointmentNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpPrescriptionDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrescriptionID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnResetAll = New System.Windows.Forms.Button()
        Me.btnCreateNew = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.txtDodge = New System.Windows.Forms.TextBox()
        Me.cmbProduct = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column12 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPrintView = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(818, 62)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(55, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Prescription Drug"
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
        Me.GroupBox1.Controls.Add(Me.txtVisitID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnNewPatient)
        Me.GroupBox1.Controls.Add(Me.btnPatientList)
        Me.GroupBox1.Controls.Add(Me.txtGender)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtPatientName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtPatientID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtAppointmentNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpPrescriptionDate)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtPrescriptionID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(643, 107)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'txtVisitID
        '
        Me.txtVisitID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVisitID.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVisitID.Location = New System.Drawing.Point(384, 29)
        Me.txtVisitID.Name = "txtVisitID"
        Me.txtVisitID.Size = New System.Drawing.Size(97, 22)
        Me.txtVisitID.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(384, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 14)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "VISIT#"
        '
        'btnNewPatient
        '
        Me.btnNewPatient.Image = Global.DentalClinicManagementSystem.My.Resources.Resources._New
        Me.btnNewPatient.Location = New System.Drawing.Point(103, 72)
        Me.btnNewPatient.Name = "btnNewPatient"
        Me.btnNewPatient.Size = New System.Drawing.Size(29, 24)
        Me.btnNewPatient.TabIndex = 57
        Me.btnNewPatient.UseVisualStyleBackColor = True
        '
        'btnPatientList
        '
        Me.btnPatientList.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Table
        Me.btnPatientList.Location = New System.Drawing.Point(74, 72)
        Me.btnPatientList.Name = "btnPatientList"
        Me.btnPatientList.Size = New System.Drawing.Size(29, 24)
        Me.btnPatientList.TabIndex = 56
        Me.btnPatientList.UseVisualStyleBackColor = True
        '
        'txtGender
        '
        Me.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGender.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.Location = New System.Drawing.Point(504, 73)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(120, 22)
        Me.txtGender.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(504, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 14)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "GENDER"
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(384, 73)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(116, 22)
        Me.txtAge.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(384, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 14)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "AGE"
        '
        'txtPatientName
        '
        Me.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPatientName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientName.Location = New System.Drawing.Point(135, 73)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(244, 22)
        Me.txtPatientName.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(135, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 14)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "PATIENT NAME"
        '
        'txtPatientID
        '
        Me.txtPatientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPatientID.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientID.Location = New System.Drawing.Point(6, 73)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(67, 22)
        Me.txtPatientID.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 14)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "PATIENT ID"
        '
        'txtAppointmentNo
        '
        Me.txtAppointmentNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppointmentNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAppointmentNo.Location = New System.Drawing.Point(282, 29)
        Me.txtAppointmentNo.Name = "txtAppointmentNo"
        Me.txtAppointmentNo.Size = New System.Drawing.Size(97, 22)
        Me.txtAppointmentNo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(282, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 14)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "APPNT#"
        '
        'dtpPrescriptionDate
        '
        Me.dtpPrescriptionDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpPrescriptionDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPrescriptionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPrescriptionDate.Location = New System.Drawing.Point(135, 29)
        Me.dtpPrescriptionDate.Name = "dtpPrescriptionDate"
        Me.dtpPrescriptionDate.Size = New System.Drawing.Size(142, 22)
        Me.dtpPrescriptionDate.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(135, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 14)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "DATE"
        '
        'txtPrescriptionID
        '
        Me.txtPrescriptionID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrescriptionID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrescriptionID.ForeColor = System.Drawing.Color.Black
        Me.txtPrescriptionID.Location = New System.Drawing.Point(6, 29)
        Me.txtPrescriptionID.Name = "txtPrescriptionID"
        Me.txtPrescriptionID.ReadOnly = True
        Me.txtPrescriptionID.Size = New System.Drawing.Size(126, 23)
        Me.txtPrescriptionID.TabIndex = 41
        Me.txtPrescriptionID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 14)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "PRESCRIPTION#"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnClose)
        Me.GroupBox4.Controls.Add(Me.btnResetAll)
        Me.GroupBox4.Controls.Add(Me.btnCreateNew)
        Me.GroupBox4.Location = New System.Drawing.Point(656, 60)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(155, 107)
        Me.GroupBox4.TabIndex = 62
        Me.GroupBox4.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Image = Global.DentalClinicManagementSystem.My.Resources.Resources._Exit
        Me.btnClose.Location = New System.Drawing.Point(6, 73)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(143, 28)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnResetAll
        '
        Me.btnResetAll.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Redo
        Me.btnResetAll.Location = New System.Drawing.Point(6, 43)
        Me.btnResetAll.Name = "btnResetAll"
        Me.btnResetAll.Size = New System.Drawing.Size(143, 28)
        Me.btnResetAll.TabIndex = 2
        Me.btnResetAll.Text = "RESET"
        Me.btnResetAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnResetAll.UseVisualStyleBackColor = True
        '
        'btnCreateNew
        '
        Me.btnCreateNew.Image = Global.DentalClinicManagementSystem.My.Resources.Resources._New
        Me.btnCreateNew.Location = New System.Drawing.Point(6, 13)
        Me.btnCreateNew.Name = "btnCreateNew"
        Me.btnCreateNew.Size = New System.Drawing.Size(143, 28)
        Me.btnCreateNew.TabIndex = 0
        Me.btnCreateNew.Text = "CREATE NEW"
        Me.btnCreateNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCreateNew.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSaveChanges)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.txtRemark)
        Me.GroupBox2.Controls.Add(Me.txtQty)
        Me.GroupBox2.Controls.Add(Me.txtDuration)
        Me.GroupBox2.Controls.Add(Me.txtDodge)
        Me.GroupBox2.Controls.Add(Me.cmbProduct)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.btnPrintView)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(803, 307)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Save
        Me.btnSaveChanges.Location = New System.Drawing.Point(125, 267)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(131, 34)
        Me.btnSaveChanges.TabIndex = 71
        Me.btnSaveChanges.Text = "SAVE CHANGES"
        Me.btnSaveChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(586, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 14)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "REMARK"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(518, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 14)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "QTY"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(447, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 14)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "DURATION"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(383, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 14)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "DODGE"
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Create
        Me.btnAdd.Location = New System.Drawing.Point(766, 29)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(31, 24)
        Me.btnAdd.TabIndex = 66
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtRemark
        '
        Me.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemark.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemark.Location = New System.Drawing.Point(588, 30)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(172, 22)
        Me.txtRemark.TabIndex = 4
        '
        'txtQty
        '
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(518, 30)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(64, 22)
        Me.txtQty.TabIndex = 3
        '
        'txtDuration
        '
        Me.txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuration.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuration.Location = New System.Drawing.Point(450, 30)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(64, 22)
        Me.txtDuration.TabIndex = 2
        '
        'txtDodge
        '
        Me.txtDodge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDodge.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDodge.Location = New System.Drawing.Point(383, 30)
        Me.txtDodge.Name = "txtDodge"
        Me.txtDodge.Size = New System.Drawing.Size(64, 22)
        Me.txtDodge.TabIndex = 1
        '
        'cmbProduct
        '
        Me.cmbProduct.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Location = New System.Drawing.Point(7, 30)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(373, 22)
        Me.cmbProduct.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(7, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 14)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "MEDICINE NAME"
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column12, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(6, 59)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(791, 202)
        Me.DataGridView1.TabIndex = 3
        '
        'Column12
        '
        Me.Column12.HeaderText = ""
        Me.Column12.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Erase1
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column12.Width = 35
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "PCD_ID"
        Me.Column1.HeaderText = "PCD_ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "MedicineName"
        Me.Column2.HeaderText = "MEDICINE NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Dodge"
        Me.Column3.HeaderText = "DODGE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Duration"
        Me.Column4.HeaderText = "DURATION"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Qty"
        Me.Column5.HeaderText = "QTY"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 80
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Remark"
        Me.Column6.HeaderText = "REMARK"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 250
        '
        'btnPrintView
        '
        Me.btnPrintView.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Print
        Me.btnPrintView.Location = New System.Drawing.Point(6, 267)
        Me.btnPrintView.Name = "btnPrintView"
        Me.btnPrintView.Size = New System.Drawing.Size(113, 34)
        Me.btnPrintView.TabIndex = 2
        Me.btnPrintView.Text = "PRINT VIEW"
        Me.btnPrintView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrintView.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmPrescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 483)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPrescription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prescription"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnNewPatient As Button
    Friend WithEvents btnPatientList As Button
    Friend WithEvents txtGender As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAppointmentNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpPrescriptionDate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPrescriptionID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtVisitID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnResetAll As Button
    Friend WithEvents btnCreateNew As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnPrintView As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbProduct As ComboBox
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents txtDodge As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Column12 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnSaveChanges As Button
End Class
