<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuthentication
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAuthentication))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(25, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter your Username && Password and press the submit button."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Authentication"
        '
        'txtUserName
        '
        Me.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtUserName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(230, 133)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(234, 26)
        Me.txtUserName.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(230, 179)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(234, 31)
        Me.txtPassword.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(230, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(230, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 14)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Password"
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
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.DentalClinicManagementSystem.My.Resources.Resources._9636223
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(28, 109)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(159, 149)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ImageIndex = 10
        Me.btnClose.ImageList = Me.ImageList1
        Me.btnClose.Location = New System.Drawing.Point(350, 219)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(114, 32)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.White
        Me.btnSubmit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ImageIndex = 1
        Me.btnSubmit.ImageList = Me.ImageList1
        Me.btnSubmit.Location = New System.Drawing.Point(230, 219)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(114, 32)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(-6, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(510, 97)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(-6, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(510, 97)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'frmAuthentication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(496, 275)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAuthentication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Authentication"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
End Class
