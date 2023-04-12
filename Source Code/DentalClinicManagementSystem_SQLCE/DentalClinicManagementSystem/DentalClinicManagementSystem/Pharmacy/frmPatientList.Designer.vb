<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientList
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtCriteria = New System.Windows.Forms.TextBox()
        Me.cmbParameter = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column11 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txtCriteria
        '
        Me.txtCriteria.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriteria.Location = New System.Drawing.Point(196, 24)
        Me.txtCriteria.Name = "txtCriteria"
        Me.txtCriteria.Size = New System.Drawing.Size(167, 22)
        Me.txtCriteria.TabIndex = 10
        '
        'cmbParameter
        '
        Me.cmbParameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbParameter.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbParameter.FormattingEnabled = True
        Me.cmbParameter.Items.AddRange(New Object() {"Patient_ID", "PatientName", "ParentNames", "Gender", "Age", "Occupation", "Address", "ContactNo", "Reference"})
        Me.cmbParameter.Location = New System.Drawing.Point(7, 24)
        Me.cmbParameter.Name = "cmbParameter"
        Me.cmbParameter.Size = New System.Drawing.Size(164, 22)
        Me.cmbParameter.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(196, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "CRITERIA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 14)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "PARAMETER"
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column11, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkTurquoise
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(7, 52)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(740, 237)
        Me.DataGridView1.TabIndex = 11
        '
        'Column11
        '
        Me.Column11.HeaderText = ""
        Me.Column11.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Yes
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column11.Width = 35
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Patient_ID"
        Me.Column1.HeaderText = "PATIENT ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "PatientName"
        Me.Column2.HeaderText = "PATIENT NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "ParentNames"
        Me.Column3.HeaderText = "PARENTS NAME"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Gender"
        Me.Column4.HeaderText = "GENDER"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 60
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Age"
        Me.Column5.HeaderText = "AGE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 50
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Occupation"
        Me.Column6.HeaderText = "OCCUPATION"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Address"
        Me.Column7.HeaderText = "ADDRESS"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 200
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "ContactNo"
        Me.Column8.HeaderText = "CONTACT NO"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "Reference"
        Me.Column9.HeaderText = "REFERENCE"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "DateOfEnroll"
        DataGridViewCellStyle3.Format = "dd-MM-yyyy"
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column10.HeaderText = "DATE ENROLL"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(7, 292)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(28, 13)
        Me.lblCount.TabIndex = 28
        Me.lblCount.Text = "......."
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Create
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.Width = 35
        '
        'frmPatientList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 312)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtCriteria)
        Me.Controls.Add(Me.cmbParameter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPatientList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Popup Patient List"
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents txtCriteria As TextBox
    Friend WithEvents cmbParameter As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblCount As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Column11 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
End Class
