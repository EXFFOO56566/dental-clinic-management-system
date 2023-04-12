Public Class frmListOfPatient
    Private Sub frmListOfPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
        LoadPatientData()
    End Sub
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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
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
            If MsgBox("Are you sure you want to edit this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                With frmPatientInformation
                    .MdiParent = frmMDIParent
                    .Show()
                    ExecuteSQLQuery(" SELECT * FROM PatientInformation WHERE  Patient_ID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                    If sqlDT.Rows.Count > 0 Then
                        .txtAddress.Text = sqlDT.Rows(0)("Address")
                        .cmbGender.Text = sqlDT.Rows(0)("Gender")
                        .txtAge.Text = sqlDT.Rows(0)("Age")
                        .txtContactNo.Text = sqlDT.Rows(0)("ContactNo")
                        .txtOccupation.Text = sqlDT.Rows(0)("Occupation")
                        .txtParentNames.Text = sqlDT.Rows(0)("ParentNames")
                        .txtPatientID.Text = sqlDT.Rows(0)("Patient_ID")
                        .txtPatientName.Text = sqlDT.Rows(0)("PatientName")
                        .txtReference.Text = sqlDT.Rows(0)("Reference")
                        .dtpDateOfEnroll.Value = sqlDT.Rows(0)("DateOfEnroll")
                        Try
                            .PatientImage.ImageLocation = Application.StartupPath + "\Upload\Patient\" + sqlDT.Rows(0)("Photo_File_Name")
                        Catch ex As Exception
                        End Try
                        .btnSave.Text = "UPDATE"
                    End If
                End With
            End If
        ElseIf e.ColumnIndex = 1 Then
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                ExecuteSQLQuery("DELETE FROM PatientInformation WHERE  Patient_ID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                LoadPatientData()
                MsgBox("Record deleted successfully.", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub
End Class