<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangePassword))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtRePassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Change Password"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(90, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Enter your Username && Password and press the submit button."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(531, 97)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(-3, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(531, 97)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "About.png")
        Me.ImageList1.Images.SetKeyName(1, "Apply.png")
        Me.ImageList1.Images.SetKeyName(2, "Back.png")
        Me.ImageList1.Images.SetKeyName(3, "Boss.png")
        Me.ImageList1.Images.SetKeyName(4, "Create.png")
        Me.ImageList1.Images.SetKeyName(5, "Delete.png")
        Me.ImageList1.Images.SetKeyName(6, "Disaster.png")
        Me.ImageList1.Images.SetKeyName(7, "Downloads folder.png")
        Me.ImageList1.Images.SetKeyName(8, "Erase.png")
        Me.ImageList1.Images.SetKeyName(9, "Favourites.png")
        Me.ImageList1.Images.SetKeyName(10, "Exit.png")
        Me.ImageList1.Images.SetKeyName(11, "Shield 16x16.png")
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ImageIndex = 10
        Me.btnClose.ImageList = Me.ImageList1
        Me.btnClose.Location = New System.Drawing.Point(224, 290)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(114, 32)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.White
        Me.btnSubmit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ImageIndex = 11
        Me.btnSubmit.ImageList = Me.ImageList1
        Me.btnSubmit.Location = New System.Drawing.Point(104, 290)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(114, 32)
        Me.btnSubmit.TabIndex = 12
        Me.btnSubmit.Text = "CHANGE"
        Me.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtRePassword
        '
        Me.txtRePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRePassword.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRePassword.Location = New System.Drawing.Point(91, 235)
        Me.txtRePassword.Name = "txtRePassword"
        Me.txtRePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRePassword.Size = New System.Drawing.Size(247, 22)
        Me.txtRePassword.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "CURRENT PASSWORD"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewPassword.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(91, 188)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(247, 22)
        Me.txtNewPassword.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "NEW PASSWORD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "NEW PASSWORD"
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrentPassword.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentPassword.Location = New System.Drawing.Point(91, 142)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCurrentPassword.Size = New System.Drawing.Size(247, 22)
        Me.txtCurrentPassword.TabIndex = 34
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(25, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(474, 162)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(25, 271)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(474, 61)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'frmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(514, 344)
        Me.Controls.Add(Me.txtRePassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCurrentPassword)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtRePassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCurrentPassword As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
End Class
