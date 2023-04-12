<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPhysiciansInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhysiciansInformation))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtSpeciality = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDoctorName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDoctorID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQualification = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpCommencementDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(573, 62)
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
        Me.Label1.Size = New System.Drawing.Size(229, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Doctors Information"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DentalClinicManagementSystem.My.Resources.Resources.doctor_headers
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
        'txtSpeciality
        '
        Me.txtSpeciality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSpeciality.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpeciality.Location = New System.Drawing.Point(33, 195)
        Me.txtSpeciality.Name = "txtSpeciality"
        Me.txtSpeciality.Size = New System.Drawing.Size(222, 22)
        Me.txtSpeciality.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(33, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 14)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Speciality"
        '
        'txtDoctorName
        '
        Me.txtDoctorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDoctorName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorName.Location = New System.Drawing.Point(33, 149)
        Me.txtDoctorName.Name = "txtDoctorName"
        Me.txtDoctorName.Size = New System.Drawing.Size(222, 22)
        Me.txtDoctorName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(33, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 14)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Doctor Name"
        '
        'txtDoctorID
        '
        Me.txtDoctorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDoctorID.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorID.Location = New System.Drawing.Point(33, 106)
        Me.txtDoctorID.Name = "txtDoctorID"
        Me.txtDoctorID.ReadOnly = True
        Me.txtDoctorID.Size = New System.Drawing.Size(88, 22)
        Me.txtDoctorID.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(33, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 14)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Doctor ID"
        '
        'txtQualification
        '
        Me.txtQualification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQualification.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQualification.Location = New System.Drawing.Point(33, 239)
        Me.txtQualification.Name = "txtQualification"
        Me.txtQualification.Size = New System.Drawing.Size(222, 22)
        Me.txtQualification.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(33, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 14)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Qualification"
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(280, 107)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(242, 64)
        Me.txtAddress.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(280, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 14)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Address"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactNumber.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.Location = New System.Drawing.Point(280, 195)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(222, 22)
        Me.txtContactNumber.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(280, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 14)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Contact Number"
        '
        'dtpCommencementDate
        '
        Me.dtpCommencementDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpCommencementDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCommencementDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCommencementDate.Location = New System.Drawing.Point(280, 239)
        Me.dtpCommencementDate.Name = "dtpCommencementDate"
        Me.dtpCommencementDate.Size = New System.Drawing.Size(222, 22)
        Me.dtpCommencementDate.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(280, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 14)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Date of Commencement"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 204)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Doctors Information"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.DentalClinicManagementSystem.My.Resources.Resources._Exit
        Me.btnClose.Location = New System.Drawing.Point(354, 288)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(116, 33)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Redo
        Me.btnReset.Location = New System.Drawing.Point(231, 288)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(116, 33)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "RESET"
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(107, 288)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 33)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(12, 275)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(552, 54)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'frmPhysiciansInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 343)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtpCommencementDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQualification)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSpeciality)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDoctorName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDoctorID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPhysiciansInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctors Information"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents txtSpeciality As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDoctorName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDoctorID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQualification As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpCommencementDate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
