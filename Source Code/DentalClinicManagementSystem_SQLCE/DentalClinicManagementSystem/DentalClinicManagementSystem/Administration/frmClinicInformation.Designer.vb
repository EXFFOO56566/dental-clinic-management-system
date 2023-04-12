<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClinicInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClinicInformation))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtReportHeader = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtClinicName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtReportFooter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lnkBrowse = New System.Windows.Forms.LinkLabel()
        Me.ClinicLogo = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ClinicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(499, 62)
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
        Me.Label1.Size = New System.Drawing.Size(207, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Clinic Information"
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
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(25, 144)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(240, 22)
        Me.txtPhone.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(25, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 14)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Phone"
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(25, 186)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(257, 46)
        Me.txtAddress.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(25, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 14)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Address"
        '
        'txtReportHeader
        '
        Me.txtReportHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReportHeader.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportHeader.Location = New System.Drawing.Point(25, 252)
        Me.txtReportHeader.Multiline = True
        Me.txtReportHeader.Name = "txtReportHeader"
        Me.txtReportHeader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReportHeader.Size = New System.Drawing.Size(257, 46)
        Me.txtReportHeader.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(25, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 14)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Report Header"
        '
        'txtClinicName
        '
        Me.txtClinicName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClinicName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClinicName.Location = New System.Drawing.Point(25, 96)
        Me.txtClinicName.Name = "txtClinicName"
        Me.txtClinicName.Size = New System.Drawing.Size(240, 26)
        Me.txtClinicName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(25, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 14)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Clinic Name"
        '
        'txtReportFooter
        '
        Me.txtReportFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReportFooter.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportFooter.Location = New System.Drawing.Point(25, 319)
        Me.txtReportFooter.Multiline = True
        Me.txtReportFooter.Name = "txtReportFooter"
        Me.txtReportFooter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReportFooter.Size = New System.Drawing.Size(257, 46)
        Me.txtReportFooter.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(25, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 14)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Report Footer"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.DentalClinicManagementSystem.My.Resources.Resources._Exit
        Me.btnClose.Location = New System.Drawing.Point(361, 389)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(116, 33)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(239, 389)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 33)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 313)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.lnkBrowse)
        Me.GroupBox3.Controls.Add(Me.ClinicLogo)
        Me.GroupBox3.Location = New System.Drawing.Point(307, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(180, 313)
        Me.GroupBox3.TabIndex = 34
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
        Me.lnkBrowse.TabIndex = 0
        Me.lnkBrowse.TabStop = True
        Me.lnkBrowse.Text = "Browse Image"
        '
        'ClinicLogo
        '
        Me.ClinicLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClinicLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ClinicLogo.ErrorImage = Global.DentalClinicManagementSystem.My.Resources.Resources.no_images
        Me.ClinicLogo.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.no_images
        Me.ClinicLogo.Location = New System.Drawing.Point(7, 15)
        Me.ClinicLogo.Name = "ClinicLogo"
        Me.ClinicLogo.Size = New System.Drawing.Size(167, 170)
        Me.ClinicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ClinicLogo.TabIndex = 0
        Me.ClinicLogo.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(12, 374)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(475, 59)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmClinicInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 439)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtReportFooter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtReportHeader)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtClinicName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "frmClinicInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clinic Information"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ClinicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtReportHeader As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtClinicName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtReportFooter As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lnkBrowse As LinkLabel
    Friend WithEvents ClinicLogo As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
