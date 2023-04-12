Public Class frmPatientList
    Public Property RTN_Patient_ID As String
    Public Property RTN_Patient_NAME As String
    Public Property RTN_Patient_AGE As String
    Public Property RTN_Patient_SEX As String
    Private Sub LoadPatientData()
        sqlSTR = "SELECT        Patient_ID, PatientName, ParentNames, Gender, Age, Occupation, Address, ContactNo, Reference, DateOfEnroll  FROM            PatientInformation"
        FillDataGrid(sqlSTR, DataGridView1)
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            lblCount.Text = sqlDT.Rows.Count.ToString & " Record Found."
        Else
            lblCount.Text = "No Record Found."
        End If
    End Sub

    Private Sub frmPatientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
        LoadPatientData()
    End Sub

    Private Sub txtCriteria_TextChanged(sender As Object, e As EventArgs) Handles txtCriteria.TextChanged
        If cmbParameter.Text = "" Then
            ErrorProvider1.SetError(cmbParameter, "Mandatory field.")
            LoadPatientData()
        ElseIf txtCriteria.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider2.SetError(txtCriteria, "Mandatory field.")
            LoadPatientData()
        Else
            ErrorProvider1.Clear()
            ErrorProvider2.Clear()
            sqlSTR = "  SELECT        Patient_ID, PatientName, ParentNames, Gender, Age, Occupation,  " &
                     " Address, ContactNo, Reference, DateOfEnroll  FROM            PatientInformation " &
                     " WHERE   (" + cmbParameter.Text + " LIKE '%" + txtCriteria.Text + "%') "
            FillDataGrid(sqlSTR, DataGridView1)
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                lblCount.Text = sqlDT.Rows.Count.ToString & " Record Found."
            Else
                lblCount.Text = "No Record Found."
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 Then
            Me.RTN_Patient_ID = DataGridView1.CurrentRow.Cells(1).Value
            Me.RTN_Patient_NAME = DataGridView1.CurrentRow.Cells(2).Value
            Me.RTN_Patient_SEX = DataGridView1.CurrentRow.Cells(4).Value
            Me.RTN_Patient_AGE = DataGridView1.CurrentRow.Cells(5).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub
End Class