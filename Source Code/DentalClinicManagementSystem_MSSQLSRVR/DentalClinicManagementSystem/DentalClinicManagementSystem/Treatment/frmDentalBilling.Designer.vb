<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDentalBilling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDentalBilling))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.NumericUpDown()
        Me.txtTAX = New System.Windows.Forms.NumericUpDown()
        Me.txtPaid = New System.Windows.Forms.NumericUpDown()
        Me.txtChangeDue = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPrintView = New System.Windows.Forms.Button()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTAX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPaid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 67)
        Me.Panel1.TabIndex = 31
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(307, 23)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(58, 22)
        Me.txtID.TabIndex = 32
        Me.txtID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(63, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Billing"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DentalClinicManagementSystem.My.Resources.Resources.sm_head_invoice
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(23, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 42)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(44, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "SUBTOTAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "DISCOUNT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 16)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "TAX"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "TOTAL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "PAID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 16)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "CHANGE / DUE"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.Location = New System.Drawing.Point(195, 97)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(181, 26)
        Me.txtSubtotal.TabIndex = 39
        Me.txtSubtotal.Text = "0"
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(195, 128)
        Me.txtDiscount.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(181, 26)
        Me.txtDiscount.TabIndex = 0
        '
        'txtTAX
        '
        Me.txtTAX.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTAX.Location = New System.Drawing.Point(195, 159)
        Me.txtTAX.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtTAX.Name = "txtTAX"
        Me.txtTAX.Size = New System.Drawing.Size(181, 26)
        Me.txtTAX.TabIndex = 1
        '
        'txtPaid
        '
        Me.txtPaid.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaid.Location = New System.Drawing.Point(195, 222)
        Me.txtPaid.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(181, 23)
        Me.txtPaid.TabIndex = 3
        '
        'txtChangeDue
        '
        Me.txtChangeDue.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangeDue.Location = New System.Drawing.Point(195, 250)
        Me.txtChangeDue.Name = "txtChangeDue"
        Me.txtChangeDue.ReadOnly = True
        Me.txtChangeDue.Size = New System.Drawing.Size(181, 26)
        Me.txtChangeDue.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(171, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 16)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(171, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 16)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(171, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 16)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(171, 195)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 16)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(171, 226)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 16)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(171, 254)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 16)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = ":"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 206)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Red
        Me.txtTotal.Location = New System.Drawing.Point(172, 110)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(181, 26)
        Me.txtTotal.TabIndex = 53
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnPrintView)
        Me.GroupBox2.Controls.Add(Me.btnSaveChanges)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 284)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 65)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Image = Global.DentalClinicManagementSystem.My.Resources.Resources._Exit
        Me.btnClose.Location = New System.Drawing.Point(267, 18)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(83, 34)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPrintView
        '
        Me.btnPrintView.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Print
        Me.btnPrintView.Location = New System.Drawing.Point(22, 18)
        Me.btnPrintView.Name = "btnPrintView"
        Me.btnPrintView.Size = New System.Drawing.Size(113, 34)
        Me.btnPrintView.TabIndex = 1
        Me.btnPrintView.Text = "PRINT VIEW"
        Me.btnPrintView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrintView.UseVisualStyleBackColor = True
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Save
        Me.btnSaveChanges.Location = New System.Drawing.Point(136, 18)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(130, 34)
        Me.btnSaveChanges.TabIndex = 0
        Me.btnSaveChanges.Text = "SAVE CHANGES"
        Me.btnSaveChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'frmDentalBilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 370)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtChangeDue)
        Me.Controls.Add(Me.txtPaid)
        Me.Controls.Add(Me.txtTAX)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDentalBilling"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dental Billing"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTAX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPaid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtDiscount As NumericUpDown
    Friend WithEvents txtTAX As NumericUpDown
    Friend WithEvents txtPaid As NumericUpDown
    Friend WithEvents txtChangeDue As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPrintView As Button
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents txtTotal As TextBox
End Class
