<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListOfVoucher
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListOfVoucher))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Column11 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(686, 62)
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
        Me.Label1.Size = New System.Drawing.Size(176, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "List Of Voucher"
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
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDateFrom.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(285, 70)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(138, 22)
        Me.dtpDateFrom.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(243, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 14)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "From"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDateTo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(456, 70)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(138, 22)
        Me.dtpDateTo.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(429, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 14)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "To"
        '
        'btnSearch
        '
        Me.btnSearch.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Find1
        Me.btnSearch.Location = New System.Drawing.Point(600, 68)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(81, 26)
        Me.btnSearch.TabIndex = 28
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = True
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column11, Me.Column12, Me.Column9, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkTurquoise
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(5, 100)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(676, 280)
        Me.DataGridView1.TabIndex = 29
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.DentalClinicManagementSystem.My.Resources.Resources._Exit
        Me.btnClose.Location = New System.Drawing.Point(565, 386)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(116, 33)
        Me.btnClose.TabIndex = 31
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Refresh
        Me.btnRefresh.Location = New System.Drawing.Point(443, 386)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(116, 33)
        Me.btnRefresh.TabIndex = 30
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(9, 386)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(35, 13)
        Me.lblCount.TabIndex = 32
        Me.lblCount.Text = "......."
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
        'Column9
        '
        Me.Column9.HeaderText = ""
        Me.Column9.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Print
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 35
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "VOUCHER_ID"
        Me.Column1.HeaderText = "VOUCHER ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 90
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "DateOfVoucher"
        DataGridViewCellStyle3.Format = "dd-MMM-yyyy"
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column2.HeaderText = "DATE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 90
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "PaymentMethod"
        Me.Column3.HeaderText = "PAYMENT METHOD"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "AccountsName"
        Me.Column4.HeaderText = "ACCOUNTS NAME"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 200
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "AccountsType"
        Me.Column5.HeaderText = "ACCOUNTS TYPE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "ReferenceNumber"
        Me.Column6.HeaderText = "REFERENCE NUMBER"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Remark"
        Me.Column7.HeaderText = "REMARK"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 200
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "Amount"
        Me.Column8.HeaderText = "AMOUNT"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'frmListOfVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 425)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dtpDateTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpDateFrom)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmListOfVoucher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List Of Voucher"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblCount As Label
    Friend WithEvents Column11 As DataGridViewImageColumn
    Friend WithEvents Column12 As DataGridViewImageColumn
    Friend WithEvents Column9 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
