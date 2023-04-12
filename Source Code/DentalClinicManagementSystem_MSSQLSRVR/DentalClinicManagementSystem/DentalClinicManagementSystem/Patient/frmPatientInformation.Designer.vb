<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatientInformation))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtOccupation = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpDateOfEnroll = New System.Windows.Forms.DateTimePicker()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.txtParentNames = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lnkBrowse = New System.Windows.Forms.LinkLabel()
        Me.PatientImage = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PatientImage, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(780, 62)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(55, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Patient Information"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DentalClinicManagementSystem.My.Resources.Resources.infor_head
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(20, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 39)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(59, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patient ID"
        '
        'txtPatientID
        '
        Me.txtPatientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPatientID.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientID.Location = New System.Drawing.Point(59, 107)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.ReadOnly = True
        Me.txtPatientID.Size = New System.Drawing.Size(222, 22)
        Me.txtPatientID.TabIndex = 2
        '
        'txtPatientName
        '
        Me.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPatientName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientName.Location = New System.Drawing.Point(59, 151)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(222, 22)
        Me.txtPatientName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(59, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Patient Name"
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(59, 283)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(222, 22)
        Me.txtAge.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(59, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 14)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Age"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(59, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Gender"
        '
        'txtContactNo
        '
        Me.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(316, 238)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(219, 22)
        Me.txtContactNo.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(316, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 14)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Contact No. "
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(316, 150)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(239, 63)
        Me.txtAddress.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(316, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 14)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Address"
        '
        'txtOccupation
        '
        Me.txtOccupation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOccupation.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOccupation.Location = New System.Drawing.Point(59, 328)
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.Size = New System.Drawing.Size(222, 22)
        Me.txtOccupation.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(59, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 14)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Occupation"
        '
        'txtReference
        '
        Me.txtReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReference.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReference.Location = New System.Drawing.Point(316, 283)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(219, 22)
        Me.txtReference.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(316, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 14)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Reference"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(316, 310)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 14)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Date"
        '
        'dtpDateOfEnroll
        '
        Me.dtpDateOfEnroll.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDateOfEnroll.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateOfEnroll.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOfEnroll.Location = New System.Drawing.Point(316, 328)
        Me.dtpDateOfEnroll.Name = "dtpDateOfEnroll"
        Me.dtpDateOfEnroll.Size = New System.Drawing.Size(219, 22)
        Me.dtpDateOfEnroll.TabIndex = 8
        '
        'cmbGender
        '
        Me.cmbGender.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cmbGender.Location = New System.Drawing.Point(59, 239)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(222, 22)
        Me.cmbGender.TabIndex = 2
        '
        'txtParentNames
        '
        Me.txtParentNames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtParentNames.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParentNames.Location = New System.Drawing.Point(59, 195)
        Me.txtParentNames.Name = "txtParentNames"
        Me.txtParentNames.Size = New System.Drawing.Size(222, 22)
        Me.txtParentNames.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(59, 178)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 14)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Parent Names"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 293)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(12, 366)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(758, 62)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.lnkBrowse)
        Me.GroupBox3.Controls.Add(Me.PatientImage)
        Me.GroupBox3.Location = New System.Drawing.Point(590, 75)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(180, 293)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(6, 188)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(172, 42)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Note: This Image may appear distorted in this screen."
        '
        'lnkBrowse
        '
        Me.lnkBrowse.AutoSize = True
        Me.lnkBrowse.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkBrowse.Location = New System.Drawing.Point(6, 228)
        Me.lnkBrowse.Name = "lnkBrowse"
        Me.lnkBrowse.Size = New System.Drawing.Size(90, 13)
        Me.lnkBrowse.TabIndex = 29
        Me.lnkBrowse.TabStop = True
        Me.lnkBrowse.Text = "Browse Image"
        '
        'PatientImage
        '
        Me.PatientImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PatientImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PatientImage.ErrorImage = Global.DentalClinicManagementSystem.My.Resources.Resources.no_images
        Me.PatientImage.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.no_images
        Me.PatientImage.Location = New System.Drawing.Point(7, 15)
        Me.PatientImage.Name = "PatientImage"
        Me.PatientImage.Size = New System.Drawing.Size(167, 170)
        Me.PatientImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PatientImage.TabIndex = 0
        Me.PatientImage.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.DentalClinicManagementSystem.My.Resources.Resources._Exit
        Me.btnClose.Location = New System.Drawing.Point(360, 382)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(116, 33)
        Me.btnClose.TabIndex = 24
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Redo
        Me.btnReset.Location = New System.Drawing.Point(239, 382)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(116, 33)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "RESET"
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(116, 382)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 33)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
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
        'frmPatientInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 443)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtParentNames)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.dtpDateOfEnroll)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtOccupation)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtContactNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPatientName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPatientID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPatientInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Information"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PatientImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtOccupation As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtReference As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpDateOfEnroll As DateTimePicker
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents txtParentNames As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lnkBrowse As LinkLabel
    Friend WithEvents PatientImage As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
