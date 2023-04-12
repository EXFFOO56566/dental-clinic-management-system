<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPermission
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPermission))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cmbUsers = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(503, 62)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(55, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Permission"
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnFind
        '
        Me.btnFind.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Find
        Me.btnFind.Location = New System.Drawing.Point(211, 84)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(88, 28)
        Me.btnFind.TabIndex = 1
        Me.btnFind.Text = "FIND"
        Me.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.DentalClinicManagementSystem.My.Resources.Resources._Exit
        Me.btnClose.Location = New System.Drawing.Point(137, 353)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(116, 33)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(15, 353)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 33)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cmbUsers
        '
        Me.cmbUsers.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUsers.FormattingEnabled = True
        Me.cmbUsers.Location = New System.Drawing.Point(15, 85)
        Me.cmbUsers.Name = "cmbUsers"
        Me.cmbUsers.Size = New System.Drawing.Size(176, 26)
        Me.cmbUsers.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 14)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "User Name"
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
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.chk})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(15, 119)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(476, 227)
        Me.DataGridView1.TabIndex = 38
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "FormCaption"
        Me.Column1.HeaderText = "ACTION NAME"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 355
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "FormName"
        Me.Column2.HeaderText = "FormName"
        Me.Column2.Name = "Column2"
        Me.Column2.Visible = False
        '
        'chk
        '
        Me.chk.DataPropertyName = "Active"
        Me.chk.HeaderText = ""
        Me.chk.Name = "chk"
        Me.chk.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frmPermission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 397)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbUsers)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPermission"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permission"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnFind As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbUsers As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents chk As DataGridViewCheckBoxColumn
End Class
