<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserInformation))
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtpJoiningDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRePassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbUserType = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lnkBrowse = New System.Windows.Forms.LinkLabel()
        Me.UserImage = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.UserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(695, 62)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(55, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User Information"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DentalClinicManagementSystem.My.Resources.Resources.round_account_button_with_user_inside
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(20, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 39)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'dtpJoiningDate
        '
        Me.dtpJoiningDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpJoiningDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpJoiningDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpJoiningDate.Location = New System.Drawing.Point(267, 275)
        Me.dtpJoiningDate.Name = "dtpJoiningDate"
        Me.dtpJoiningDate.Size = New System.Drawing.Size(219, 22)
        Me.dtpJoiningDate.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(267, 257)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 14)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Joining Date"
        '
        'txtContactNo
        '
        Me.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(267, 186)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(219, 22)
        Me.txtContactNo.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(267, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 14)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Contact No. "
        '
        'txtFullName
        '
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(23, 143)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(222, 22)
        Me.txtFullName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(23, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 14)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Full Name"
        '
        'txtUserID
        '
        Me.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserID.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(23, 99)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(222, 22)
        Me.txtUserID.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(23, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 14)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "USER ID"
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtUserName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(23, 185)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(222, 22)
        Me.txtUserName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(23, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 14)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "User Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(267, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 14)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "User Type"
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(23, 228)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(222, 23)
        Me.txtPassword.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(23, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 14)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Password"
        '
        'txtRePassword
        '
        Me.txtRePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRePassword.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRePassword.Location = New System.Drawing.Point(23, 275)
        Me.txtRePassword.Name = "txtRePassword"
        Me.txtRePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRePassword.Size = New System.Drawing.Size(222, 23)
        Me.txtRePassword.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(23, 257)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 14)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Re Password"
        '
        'txtDesignation
        '
        Me.txtDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesignation.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesignation.Location = New System.Drawing.Point(267, 143)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(219, 22)
        Me.txtDesignation.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(267, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 14)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Designation"
        '
        'cmbUserType
        '
        Me.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Items.AddRange(New Object() {"Administrator", "Doctor", "Receptionist", "Cashier", "Assistant"})
        Me.cmbUserType.Location = New System.Drawing.Point(267, 230)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(219, 21)
        Me.cmbUserType.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 242)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.lnkBrowse)
        Me.GroupBox3.Controls.Add(Me.UserImage)
        Me.GroupBox3.Location = New System.Drawing.Point(519, 66)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(166, 242)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(6, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(151, 42)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Note: This Image may appear distorted in this screen."
        '
        'lnkBrowse
        '
        Me.lnkBrowse.AutoSize = True
        Me.lnkBrowse.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkBrowse.Location = New System.Drawing.Point(6, 207)
        Me.lnkBrowse.Name = "lnkBrowse"
        Me.lnkBrowse.Size = New System.Drawing.Size(90, 13)
        Me.lnkBrowse.TabIndex = 0
        Me.lnkBrowse.TabStop = True
        Me.lnkBrowse.Text = "Browse Image"
        '
        'UserImage
        '
        Me.UserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UserImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UserImage.ErrorImage = Global.DentalClinicManagementSystem.My.Resources.Resources.no_images
        Me.UserImage.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.no_images
        Me.UserImage.Location = New System.Drawing.Point(7, 15)
        Me.UserImage.Name = "UserImage"
        Me.UserImage.Size = New System.Drawing.Size(150, 145)
        Me.UserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserImage.TabIndex = 0
        Me.UserImage.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(12, 305)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(673, 57)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.DentalClinicManagementSystem.My.Resources.Resources._Exit
        Me.btnClose.Location = New System.Drawing.Point(371, 320)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(116, 33)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Redo
        Me.btnReset.Location = New System.Drawing.Point(251, 320)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(116, 33)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "RESET"
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(127, 320)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 33)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmUserInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 375)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmbUserType)
        Me.Controls.Add(Me.txtDesignation)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtRePassword)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpJoiningDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtContactNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUserInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Information"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.UserImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpJoiningDate As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRePassword As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDesignation As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbUserType As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lnkBrowse As LinkLabel
    Friend WithEvents UserImage As PictureBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
