Public Class frmPrescription
    Private Sub btnPatientList_Click(sender As Object, e As EventArgs) Handles btnPatientList.Click
        Dim PatientList As New frmPatientList
        If (PatientList.ShowDialog() = DialogResult.OK) Then
            txtPatientID.Text = PatientList.RTN_Patient_ID
            txtPatientName.Text = PatientList.RTN_Patient_NAME
            txtAge.Text = PatientList.RTN_Patient_AGE
            txtGender.Text = PatientList.RTN_Patient_SEX
        End If
    End Sub

    Private Sub btnNewPatient_Click(sender As Object, e As EventArgs) Handles btnNewPatient.Click
        frmPatientInformation.MdiParent = frmMDIParent
        frmPatientInformation.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmPrescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If

        If txtPrescriptionID.Text = "" Then
            GroupBox2.Enabled = False
        Else
            GroupBox2.Enabled = True
            LoadData(num_fltr(txtPrescriptionID.Text))
        End If
        FillComboBox("SELECT  PRODUCT_ID,  ProductName  FROM   ProductInformation", "PRODUCT_ID", "ProductName", cmbProduct)
    End Sub

    Private Sub txtPrescriptionID_TextChanged(sender As Object, e As EventArgs) Handles txtPrescriptionID.TextChanged
        If txtPrescriptionID.Text = "" Then
            GroupBox2.Enabled = False
        Else
            GroupBox2.Enabled = True
            LoadData(num_fltr(txtPrescriptionID.Text))
        End If
    End Sub

    Private Sub btnResetAll_Click(sender As Object, e As EventArgs) Handles btnResetAll.Click
        txtVisitID.Text = ""
        dtpPrescriptionDate.Value = Now
        txtAppointmentNo.Text = ""
        txtPatientID.Text = ""
        txtPatientName.Text = ""
        txtAge.Text = ""
        txtGender.Text = ""
        txtPrescriptionID.Text = ""
        txtDodge.Text = ""
        txtDuration.Text = ""
        txtQty.Text = ""
        txtRemark.Text = ""
        GroupBox2.Enabled = False
        LoadData(0)
    End Sub

    Private Sub LoadData(ByVal PRESCRIPTION_ID As Double)
        FillDataGrid("SELECT        PCD_ID, MedicineName, Dodge, Duration, Qty, Remark  FROM    PrescriptionDetail  WHERE    (PRESCRIPTION_ID = " & PRESCRIPTION_ID & ")", DataGridView1)
        ExecuteSQLQuery("SELECT  * FROM       Prescription   WHERE   (PRESCRIPTION_ID = " & PRESCRIPTION_ID & ")")
        If sqlDT.Rows.Count > 0 Then
            txtVisitID.Text = sqlDT.Rows(0)("VisitID")
            dtpPrescriptionDate.Value = sqlDT.Rows(0)("PrescriptionDate")
            txtAppointmentNo.Text = sqlDT.Rows(0)("AppointmentNo")
            txtPatientID.Text = sqlDT.Rows(0)("Patient_ID")
            txtPatientName.Text = sqlDT.Rows(0)("PatientName")
            txtAge.Text = sqlDT.Rows(0)("Age")
            txtGender.Text = sqlDT.Rows(0)("Gender")
            txtPrescriptionID.Text = sqlDT.Rows(0)("PRESCRIPTION_ID")
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbProduct.Text = "" Then
            ErrorProvider1.SetError(cmbProduct, "Mandatory field.")
        Else
            ErrorProvider1.Clear()
            ExecuteSQLQuery("INSERT INTO PrescriptionDetail (PRESCRIPTION_ID, MedicineName, Dodge, Duration, Qty, Remark) VALUES  " &
                            " (" & num_fltr(txtPrescriptionID.Text) & ", '" + str_repl(cmbProduct.Text) + "', '" + str_repl(txtDodge.Text) + "', '" + str_repl(txtDuration.Text) + "', '" + str_repl(txtQty.Text) + "', '" + str_repl(txtRemark.Text) + "') ")
            LoadData(num_fltr(txtPrescriptionID.Text))
        End If
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        If MsgBox("Are you sure you want to create a new PRESCRIPTION?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
            ExecuteSQLQuery(" INSERT Prescription (PrescriptionDate, AppointmentNo, VisitID, Patient_ID, PatientName, Age, Gender) VALUES " &
                            " ('" & Format(dtpPrescriptionDate.Value, "MM/dd/yyyy") & "', '" + str_repl(txtAppointmentNo.Text) + "', '" + str_repl(txtVisitID.Text) + "', " & num_fltr(txtPatientID.Text) & ", '" + str_repl(txtPatientName.Text) + "', '" + str_repl(txtAge.Text) + "', '" + str_repl(txtGender.Text) + "') ")
            ExecuteSQLQuery("SELECT  PRESCRIPTION_ID FROM     Prescription  ORDER BY PRESCRIPTION_ID DESC")
            txtPrescriptionID.Text = sqlDT.Rows(0)("PRESCRIPTION_ID")
        End If
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        ExecuteSQLQuery(" UPDATE Prescription SET PrescriptionDate='" & Format(dtpPrescriptionDate.Value, "MM/dd/yyyy") & "', AppointmentNo='" + str_repl(txtAppointmentNo.Text) + "', " &
                        " VisitID='" + str_repl(txtVisitID.Text) + "', Patient_ID=" & num_fltr(txtPatientID.Text) & ", PatientName='" + str_repl(txtPatientName.Text) + "', Age='" + str_repl(txtAge.Text) + "', Gender='" + str_repl(txtGender.Text) + "'  WHERE        (PRESCRIPTION_ID = " & num_fltr(txtPrescriptionID.Text) & ") ")
        MsgBox("The data has been changed.", MsgBoxStyle.Information, "Information")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 Then
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                ExecuteSQLQuery("DELETE FROM Prescription WHERE  PRESCRIPTION_ID =" & DataGridView1.CurrentRow.Cells(1).Value & " ")
                LoadData(num_fltr(txtPrescriptionID.Text))
                MsgBox("Record deleted successfully.", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub

    Private Sub btnPrintView_Click(sender As Object, e As EventArgs) Handles btnPrintView.Click
        Prescription_View(" SELECT  Prescription.PRESCRIPTION_ID, Prescription.PrescriptionDate, Prescription.AppointmentNo, Prescription.VisitID, Prescription.Patient_ID, Prescription.PatientName, Prescription.Age, Prescription.Gender, " &
                          " PrescriptionDetail.MedicineName, PrescriptionDetail.Dodge, PrescriptionDetail.Duration, PrescriptionDetail.Qty, PrescriptionDetail.Remark " &
                          " FROM    Prescription LEFT OUTER JOIN PrescriptionDetail ON Prescription.PRESCRIPTION_ID = PrescriptionDetail.PRESCRIPTION_ID  WHERE        (Prescription.PRESCRIPTION_ID = " & num_fltr(txtPrescriptionID.Text) & ") ")
    End Sub
End Class