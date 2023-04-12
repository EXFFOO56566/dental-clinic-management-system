<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSickLeave
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSickLeave))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtVisitID = New System.Windows.Forms.TextBox()
        Me.txtReferenceNo = New System.Windows.Forms.TextBox()
        Me.dtpApplicationDate = New System.Windows.Forms.DateTimePicker()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.dtpLeaveFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpLeaveTo = New System.Windows.Forms.DateTimePicker()
        Me.txtDisease = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(538, 62)
        Me.Panel1.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(55, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sick Leave "
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(14, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 14)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Visit No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(14, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 14)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Reference No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(14, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 14)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Application Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(14, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 14)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Patient Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(14, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 14)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Disease"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(302, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 14)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "To"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(14, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 14)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Leave From"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(14, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 14)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Age"
        '
        'txtVisitID
        '
        Me.txtVisitID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVisitID.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVisitID.Location = New System.Drawing.Point(131, 20)
        Me.txtVisitID.Name = "txtVisitID"
        Me.txtVisitID.ReadOnly = True
        Me.txtVisitID.Size = New System.Drawing.Size(150, 22)
        Me.txtVisitID.TabIndex = 40
        '
        'txtReferenceNo
        '
        Me.txtReferenceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReferenceNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenceNo.Location = New System.Drawing.Point(131, 47)
        Me.txtReferenceNo.Name = "txtReferenceNo"
        Me.txtReferenceNo.Size = New System.Drawing.Size(150, 22)
        Me.txtReferenceNo.TabIndex = 0
        '
        'dtpApplicationDate
        '
        Me.dtpApplicationDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpApplicationDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpApplicationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpApplicationDate.Location = New System.Drawing.Point(131, 75)
        Me.dtpApplicationDate.Name = "dtpApplicationDate"
        Me.dtpApplicationDate.Size = New System.Drawing.Size(150, 22)
        Me.dtpApplicationDate.TabIndex = 1
        '
        'txtPatientName
        '
        Me.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPatientName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientName.Location = New System.Drawing.Point(131, 103)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(363, 22)
        Me.txtPatientName.TabIndex = 2
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(131, 131)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(150, 22)
        Me.txtAge.TabIndex = 3
        '
        'dtpLeaveFrom
        '
        Me.dtpLeaveFrom.CustomFormat = "dd-MMM-yyyy"
        Me.dtpLeaveFrom.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLeaveFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLeaveFrom.Location = New System.Drawing.Point(131, 159)
        Me.dtpLeaveFrom.Name = "dtpLeaveFrom"
        Me.dtpLeaveFrom.Size = New System.Drawing.Size(150, 22)
        Me.dtpLeaveFrom.TabIndex = 4
        '
        'dtpLeaveTo
        '
        Me.dtpLeaveTo.CustomFormat = "dd-MMM-yyyy"
        Me.dtpLeaveTo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLeaveTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLeaveTo.Location = New System.Drawing.Point(344, 159)
        Me.dtpLeaveTo.Name = "dtpLeaveTo"
        Me.dtpLeaveTo.Size = New System.Drawing.Size(150, 22)
        Me.dtpLeaveTo.TabIndex = 5
        '
        'txtDisease
        '
        Me.txtDisease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDisease.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisease.Location = New System.Drawing.Point(131, 187)
        Me.txtDisease.Multiline = True
        Me.txtDisease.Name = "txtDisease"
        Me.txtDisease.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDisease.Size = New System.Drawing.Size(363, 58)
        Me.txtDisease.TabIndex = 47
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDisease)
        Me.GroupBox1.Controls.Add(Me.txtVisitID)
        Me.GroupBox1.Controls.Add(Me.dtpLeaveTo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpLeaveFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPatientName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpApplicationDate)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtReferenceNo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 259)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 325)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(518, 59)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.DentalClinicManagementSystem.My.Resources.Resources._Exit
        Me.btnClose.Location = New System.Drawing.Point(305, 15)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(169, 33)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(131, 15)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(169, 33)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "SAVE && PRINT VIEW"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmSickLeave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 387)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSickLeave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sick Leave Application"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtVisitID As TextBox
    Friend WithEvents txtReferenceNo As TextBox
    Friend WithEvents dtpApplicationDate As DateTimePicker
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents dtpLeaveFrom As DateTimePicker
    Friend WithEvents dtpLeaveTo As DateTimePicker
    Friend WithEvents txtDisease As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
End Class
