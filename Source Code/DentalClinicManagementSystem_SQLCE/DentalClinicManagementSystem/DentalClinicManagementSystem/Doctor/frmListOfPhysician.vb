Public Class frmListOfPhysician
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub LoadDoctorsData()
        sqlSTR = "SELECT  DOCTOR_ID, DoctorName, Speciality, Qualification, Address, ContactNumber, CommencementDate  FROM       PhysiciansInformation "
        FillDataGrid(sqlSTR, DataGridView1)
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            lblCount.Text = sqlDT.Rows.Count.ToString & " Record Found."
        Else
            lblCount.Text = "No Record Found."
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadDoctorsData()
    End Sub

    Private Sub frmListOfPhysician_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
        LoadDoctorsData()
    End Sub

    Private Sub txtCriteria_TextChanged(sender As Object, e As EventArgs) Handles txtCriteria.TextChanged
        If cmbParameter.Text = "" Then
            ErrorProvider1.SetError(cmbParameter, "Mandatory field.")
            LoadDoctorsData()
        ElseIf txtCriteria.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider2.SetError(txtCriteria, "Mandatory field.")
            LoadDoctorsData()
        Else
            ErrorProvider1.Clear()
            ErrorProvider2.Clear()
            sqlSTR = " SELECT  DOCTOR_ID, DoctorName, Speciality, Qualification, Address, " &
                     " ContactNumber, CommencementDate  FROM      PhysiciansInformation  " &
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
                With frmPhysiciansInformation
                    .MdiParent = frmMDIParent
                    .Show()
                    ExecuteSQLQuery(" SELECT * FROM PhysiciansInformation WHERE  DOCTOR_ID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                    If sqlDT.Rows.Count > 0 Then
                        .txtAddress.Text = sqlDT.Rows(0)("Address")
                        .txtContactNumber.Text = sqlDT.Rows(0)("ContactNumber")
                        .txtDoctorID.Text = sqlDT.Rows(0)("DOCTOR_ID")
                        .txtDoctorName.Text = sqlDT.Rows(0)("DoctorName")
                        .txtQualification.Text = sqlDT.Rows(0)("Qualification")
                        .txtSpeciality.Text = sqlDT.Rows(0)("Speciality")
                        .dtpCommencementDate.Value = sqlDT.Rows(0)("CommencementDate")
                        .btnSave.Text = "UPDATE"
                    End If
                End With
            End If
        ElseIf e.ColumnIndex = 1 Then
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                ExecuteSQLQuery("DELETE FROM PhysiciansInformation WHERE  DOCTOR_ID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                LoadDoctorsData()
                MsgBox("Record deleted successfully.", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub
End Class