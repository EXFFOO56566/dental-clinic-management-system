<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListOfUsers
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListOfUsers))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column11 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtCriteria = New System.Windows.Forms.TextBox()
        Me.cmbParameter = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(851, 62)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(55, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "List Of Users"
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
        'ErrorProvider2
        '
        Me.ErrorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider2.ContainerControl = Me
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column11, Me.Column12, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column9, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkTurquoise
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(8, 113)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(832, 266)
        Me.DataGridView1.TabIndex = 5
        '
        'Column11
        '
        Me.Column11.HeaderText = ""
        Me.Column11.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Modify
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column11.Width = 35
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
        Me.Column1.DataPropertyName = "UserID"
        Me.Column1.HeaderText = "USER ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "FullName"
        Me.Column2.HeaderText = "FULL NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "UserName"
        Me.Column3.HeaderText = "USER NAME"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "ContactNo"
        Me.Column4.HeaderText = "CONTACT NO"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "UserType"
        Me.Column5.HeaderText = "USER TYPE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "Designation"
        Me.Column9.HeaderText = "DESIGNATION"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 110
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "JoiningDate"
        DataGridViewCellStyle3.Format = "dd-MM-yyyy"
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column6.HeaderText = "JOINING DATE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "RegistrationDate"
        DataGridViewCellStyle4.Format = "dd-MM-yyyy"
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column7.HeaderText = "REG. DATE"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "LastLogonDateTime"
        DataGridViewCellStyle5.Format = "dd-MM-yyyy h:mm"
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column8.HeaderText = "LAST LOGON DATE-TIME"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 150
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(8, 385)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(35, 13)
        Me.lblCount.TabIndex = 28
        Me.lblCount.Text = "......."
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.DentalClinicManagementSystem.My.Resources.Resources._Exit
        Me.btnClose.Location = New System.Drawing.Point(724, 386)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(116, 33)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Refresh
        Me.btnRefresh.Location = New System.Drawing.Point(602, 386)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(116, 33)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'txtCriteria
        '
        Me.txtCriteria.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriteria.Location = New System.Drawing.Point(199, 84)
        Me.txtCriteria.Name = "txtCriteria"
        Me.txtCriteria.Size = New System.Drawing.Size(167, 22)
        Me.txtCriteria.TabIndex = 1
        '
        'cmbParameter
        '
        Me.cmbParameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbParameter.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbParameter.FormattingEnabled = True
        Me.cmbParameter.Items.AddRange(New Object() {"UserID", "FullName", "UserName", "ContactNo", "UserType", "Designation"})
        Me.cmbParameter.Location = New System.Drawing.Point(10, 84)
        Me.cmbParameter.Name = "cmbParameter"
        Me.cmbParameter.Size = New System.Drawing.Size(164, 22)
        Me.cmbParameter.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(199, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 14)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "CRITERIA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 14)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "PARAMETER"
        '
        'frmListOfUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 429)
        Me.Controls.Add(Me.txtCriteria)
        Me.Controls.Add(Me.cmbParameter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmListOfUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List Of Users"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblCount As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtCriteria As TextBox
    Friend WithEvents cmbParameter As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Column11 As DataGridViewImageColumn
    Friend WithEvents Column12 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
