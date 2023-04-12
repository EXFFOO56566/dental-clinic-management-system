Public Class frmDentalScreen
    Private Sub LoadDentalNotationGrid()
        If rbPermanent.Checked = True Then
            FillDataGrid("SELECT  ctrlName, DentalNo, DentalNotation FROM    DentalNotation  WHERE   (DentalTypes = 'Permanent')", dgvDentalNotation)
        ElseIf rbPrimary.Checked = True Then
            FillDataGrid("SELECT  ctrlName, DentalNo, DentalNotation FROM    DentalNotation  WHERE   (DentalTypes = 'Primary')", dgvDentalNotation)
        End If
    End Sub
    Private Sub LoadDentalProcedures()
        FillDataGrid("SELECT        PROCEDURES_ID, DENTAL_PROCEDURES, PRICE FROM            DentalProcedures", dgvProcedures)
    End Sub
    Private Sub GetDentalNotation(ByVal btnName As String)
        Dim DentalNo As String = Split(btnName, "_")(2)
        Dim DentalNotation As String = Split(btnName, "_")(0).Replace("btn", String.Empty) + " " + Split(btnName, "_")(1)
        Dim DentalTypes As String = Split(btnName, "_")(0).Replace("btn", String.Empty)
        ExecuteSQLQuery("SELECT *  FROM    DentalNotation   WHERE  (ctrlName = '" + btnName + "')")
        If sqlDT.Rows.Count > 0 Then
            txtDentalNo.Text = sqlDT.Rows(0)("DentalNo")
            txtDentalNotation.Text = sqlDT.Rows(0)("DentalNotation")
        Else
            ExecuteSQLQuery(" INSERT INTO DentalNotation (ctrlName, DentalNo, DentalNotation, DentalTypes) VALUES ('" + btnName + "', '" + DentalNo + "', '" + DentalNotation + "', '" + DentalTypes + "') ")
            txtDentalNo.Text = DentalNo
            txtDentalNotation.Text = DentalNotation
        End If
    End Sub

    Private Sub btnPermanent_Molars_32_Click(sender As Object, e As EventArgs) Handles btnPermanent_Premolars_5.Click, btnPermanent_Premolars_4.Click, btnPermanent_Premolars_29.Click, btnPermanent_Premolars_28.Click, btnPermanent_Premolars_21.Click, btnPermanent_Premolars_20.Click, btnPermanent_Premolars_13.Click, btnPermanent_Premolars_12.Click, btnPermanent_Molars_32.Click, btnPermanent_Molars_31.Click, btnPermanent_Molars_30.Click, btnPermanent_Molars_3.Click, btnPermanent_Molars_2.Click, btnPermanent_molars_19.Click, btnPermanent_molars_18.Click, btnPermanent_molars_17.Click, btnPermanent_molars_16.Click, btnPermanent_molars_15.Click, btnPermanent_molars_14.Click, btnPermanent_Molars_1.Click, btnPermanent_Incisors_9.Click, btnPermanent_Incisors_8.Click, btnPermanent_Incisors_7.Click, btnPermanent_Incisors_26.Click, btnPermanent_Incisors_25.Click, btnPermanent_Incisors_24.Click, btnPermanent_Incisors_23.Click, btnPermanent_Incisors_10.Click, btnPermanent_Cuspid_6.Click, btnPermanent_Cuspid_27.Click, btnPermanent_Cuspid_22.Click, btnPermanent_Cuspid_11.Click
        GetDentalNotation(TryCast(sender, Button).Name)
    End Sub

    Private Sub btnPrimary_molars_1_Click(sender As Object, e As EventArgs) Handles btnPrimary_molars_9.Click, btnPrimary_molars_20.Click, btnPrimary_molars_2.Click, btnPrimary_molars_19.Click, btnPrimary_molars_12.Click, btnPrimary_molars_11.Click, btnPrimary_molars_10.Click, btnPrimary_molars_1.Click, btnPrimary_Incisors_7.Click, btnPrimary_Incisors_6.Click, btnPrimary_Incisors_5.Click, btnPrimary_Incisors_4.Click, btnPrimary_Incisors_17.Click, btnPrimary_Incisors_16.Click, btnPrimary_Incisors_15.Click, btnPrimary_Incisors_14.Click, btnPrimary_Cuspid_8.Click, btnPrimary_Cuspid_3.Click, btnPrimary_Cuspid_18.Click, btnPrimary_Cuspid_13.Click
        GetDentalNotation(TryCast(sender, Button).Name)
    End Sub

    Private Sub btnClearNotation_Click(sender As Object, e As EventArgs) Handles btnClearNotation.Click
        txtDentalNo.Text = ""
        txtDentalNotation.Text = ""
    End Sub

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

    Private Sub frmDentalScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If

        LoadDentalNotationGrid()
        LoadDentalProcedures()
        txtVisitingTime.Text = System.DateTime.Now.ToString("hh:mm tt")

        FillComboBox("SELECT  DISEASE_DIAGNOSIS_ID, Disease  FROM    DiseaseDiagnosis", "DISEASE_DIAGNOSIS_ID", "Disease", cmbDisease)


        If txtVisitID.Text = "" Then
            btnReset.PerformClick()
            TabControl1.Enabled = False
            TabControl2.Enabled = False
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            GroupBox5.Enabled = False
        Else
            TabControl1.Enabled = True
            TabControl2.Enabled = True
            GroupBox2.Enabled = True
            GroupBox3.Enabled = True
            GroupBox5.Enabled = True
            LoadTreatmentDetails(txtVisitID.Text)
        End If


    End Sub

    Private Sub rbPermanent_CheckedChanged(sender As Object, e As EventArgs) Handles rbPermanent.CheckedChanged
        LoadDentalNotationGrid()
    End Sub

    Private Sub rbPrimary_CheckedChanged(sender As Object, e As EventArgs) Handles rbPrimary.CheckedChanged
        LoadDentalNotationGrid()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtCtrlNo.Text = ""
        txtDntlNo.Text = ""
        txtDntlNotn.Text = ""
        LoadDentalNotationGrid()
    End Sub

    Private Sub dgvDentalNotation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDentalNotation.CellContentClick
        txtCtrlNo.Text = dgvDentalNotation.CurrentRow.Cells(1).Value
        txtDntlNo.Text = dgvDentalNotation.CurrentRow.Cells(2).Value
        txtDntlNotn.Text = dgvDentalNotation.CurrentRow.Cells(3).Value
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtDntlNo.Text = "" Or txtDntlNotn.Text = "" Then
            ErrorProvider1.SetError(txtDntlNo, "Mandatory field.")
            ErrorProvider1.SetError(txtDntlNotn, "Mandatory field.")
        Else
            ErrorProvider1.Clear()
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                ExecuteSQLQuery("UPDATE DentalNotation SET DentalNo='" + txtDntlNo.Text + "', DentalNotation='" + txtDntlNotn.Text + "' WHERE  ctrlName ='" + dgvDentalNotation.CurrentRow.Cells(1).Value + "' ")
                btnReset.PerformClick()
                MsgBox("Record updated successfully.", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub

    Private Sub txtSearchProcedure_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProcedure.TextChanged
        If txtSearchProcedure.Text = "" Then
            LoadDentalProcedures()
        Else
            FillDataGrid(" SELECT    PROCEDURES_ID, DENTAL_PROCEDURES, PRICE  FROM   DentalProcedures " &
                         "  WHERE   (DENTAL_PROCEDURES LIKE '%" + txtSearchProcedure.Text + "%') ", dgvProcedures)
        End If
    End Sub
    Private Sub btnCurrentTime_Click(sender As Object, e As EventArgs) Handles btnCurrentTime.Click
        txtVisitingTime.Text = System.DateTime.Now.ToString("hh:mm tt")
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        If MsgBox("Are you sure you want to create a new VISIT ID?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
            ExecuteSQLQuery(" INSERT INTO Treatment (VisitingDate, VisitingTime, AppointmentNo, Patient_ID, PatientName, PatientAge, Gender, CompliantSymptoms, PreviousDentalHistory, PastMedicalHistory, DentalHygienists, GumDisease, KeepingBadHabitsCheck,  " &
                            "  PlaqueTartarCavities, Accident, OralCancerDetection, Development, AestheticsOrthodontics, NextAppointment, NextAppointmentDate , RoutineCheckUp) VALUES ( " &
                            " '" & Format(dtpVisitingDate.Value, "MM/dd/yyyy") & "', '" & Format(Now, "hh:mm tt") & "', " & num_fltr(txtAppointmentNo.Text) & ", " & num_fltr(txtPatientID.Text) & ", '" + str_repl(txtPatientName.Text) + "', '" + str_repl(txtAge.Text) + "', '" + str_repl(txtGender.Text) + "', '', '', '', 0, 0, 0, " &
                            " 0, 0, 0, 0, 0, 0, '', 0 )")
            ExecuteSQLQuery("SELECT  VID FROM     Treatment  ORDER BY VID DESC")
            txtVisitID.Text = sqlDT.Rows(0)("VID")
        End If
    End Sub
    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        If txtVisitID.Text = "" Then
            MsgBox("Visiting ID not found.", MsgBoxStyle.Critical, "Error")
        Else
            ExecuteSQLQuery(" UPDATE Treatment SET VisitingDate='" & Format(dtpVisitingDate.Value, "MM/dd/yyyy") & "' , VisitingTime='" + str_repl(txtVisitingTime.Text) + "' , AppointmentNo=" & num_fltr(txtAppointmentNo.Text) & " , Patient_ID=" & num_fltr(txtPatientID.Text) & "  , PatientName='" + str_repl(txtPatientName.Text) + "' , PatientAge='" + str_repl(txtAge.Text) + "' , " &
                            " Gender='" + str_repl(txtGender.Text) + "' , CompliantSymptoms= '" + str_repl(txtCompliantSymptoms.Text) + "', PreviousDentalHistory='" + str_repl(txtPreviousDentalHistory.Text) + "' , PastMedicalHistory='" + str_repl(txtPastMedicalHistory.Text) + "' , DentalHygienists= '" & chkDentalHygienists.Checked & "' , GumDisease='" & chkGumDisease.Checked & "' , KeepingBadHabitsCheck= '" & chkKeepingBadHabitsCheck.Checked & "' , " &
                            " PlaqueTartarCavities= '" & chkPlaqueTartarCavities.Checked & "' , Accident= '" & chkAccident.Checked & "' , OralCancerDetection= '" & chkOralCancerDetection.Checked & "' , Development='" & chkDevelopment.Checked & "' , AestheticsOrthodontics='" & chkAestheticsOrthodontics.Checked & "' , NextAppointment='" & chkNextAppointment.Checked & "' , NextAppointmentDate='' , RoutineCheckUp='" & chkRoutineCheckUp.Checked & "' " &
                            " WHERE   (VID = " & num_fltr(txtVisitID.Text) & ") ")
            If chkNextAppointment.Checked = True Then
                Try
                    ExecuteSQLQuery("UPDATE Treatment SET NextAppointmentDate='" & Format(dtpNextAppointment.Value, "MM/dd/yyyy") & "' WHERE   (VID = " & num_fltr(txtVisitID.Text) & ") ")
                Catch ex As Exception

                End Try
            Else
                ExecuteSQLQuery("UPDATE Treatment SET NextAppointmentDate='' WHERE   (VID = " & num_fltr(txtVisitID.Text) & ") ")
            End If
            MsgBox("The data has been changed.", MsgBoxStyle.Information, "Information")
        End If
    End Sub
    Private Sub LoadTreatmentDetails(ByVal VID As Double)
        ExecuteSQLQuery("SELECT  *  FROM            Treatment   WHERE        (VID = " & num_fltr(VID) & ")")
        If sqlDT.Rows.Count > 0 Then
            dtpVisitingDate.Value = sqlDT.Rows(0)("VisitingDate")
            txtVisitingTime.Text = sqlDT.Rows(0)("VisitingTime")
            txtAppointmentNo.Text = sqlDT.Rows(0)("AppointmentNo")
            txtPatientID.Text = sqlDT.Rows(0)("Patient_ID")
            txtPatientName.Text = sqlDT.Rows(0)("PatientName")
            txtAge.Text = sqlDT.Rows(0)("PatientAge")
            txtGender.Text = sqlDT.Rows(0)("Gender")
            txtCompliantSymptoms.Text = sqlDT.Rows(0)("CompliantSymptoms")
            txtPreviousDentalHistory.Text = sqlDT.Rows(0)("PreviousDentalHistory")
            txtPastMedicalHistory.Text = sqlDT.Rows(0)("PastMedicalHistory")
            chkDentalHygienists.Checked = sqlDT.Rows(0)("DentalHygienists")
            chkGumDisease.Checked = sqlDT.Rows(0)("GumDisease")
            chkKeepingBadHabitsCheck.Checked = sqlDT.Rows(0)("KeepingBadHabitsCheck")
            chkPlaqueTartarCavities.Checked = sqlDT.Rows(0)("PlaqueTartarCavities")
            chkRoutineCheckUp.Checked = sqlDT.Rows(0)("RoutineCheckUp")
            chkAccident.Checked = sqlDT.Rows(0)("Accident")
            chkOralCancerDetection.Checked = sqlDT.Rows(0)("OralCancerDetection")
            chkDevelopment.Checked = sqlDT.Rows(0)("Development")
            chkAestheticsOrthodontics.Checked = sqlDT.Rows(0)("AestheticsOrthodontics")
            chkNextAppointment.Checked = sqlDT.Rows(0)("NextAppointment")
            If chkNextAppointment.Checked = True Then
                Try
                    dtpNextAppointment.Value = sqlDT.Rows(0)("NextAppointmentDate")
                Catch ex As Exception

                End Try
            End If
        End If
        FillDataGrid("SELECT   TRMPDC_ID, PrescribedProcedure, Remarks  FROM   TreatmentProcedure  WHERE  (VID = " & num_fltr(VID) & ")", dgvPrescribedProcedure)
        FillDataGrid("SELECT TDS_ID, Disease, Diagnosis  FROM TreatmentDisease  WHERE  (VID = " & num_fltr(VID) & ")", dgvDiagnosis)
    End Sub
    Private Sub btnResetAll_Click(sender As Object, e As EventArgs) Handles btnResetAll.Click
        txtVisitID.Text = ""
        dtpVisitingDate.Value = Now
        dtpNextAppointment.Value = Now
        txtVisitingTime.Text = System.DateTime.Now.ToString("hh:mm tt")
        txtAppointmentNo.Text = ""
        txtPatientID.Text = ""
        txtPatientName.Text = ""
        txtAge.Text = ""
        txtGender.Text = ""
        txtCompliantSymptoms.Text = ""
        txtPreviousDentalHistory.Text = ""
        txtPastMedicalHistory.Text = ""
        chkDentalHygienists.Checked = False
        chkGumDisease.Checked = False
        chkKeepingBadHabitsCheck.Checked = False
        chkPlaqueTartarCavities.Checked = False
        chkRoutineCheckUp.Checked = False
        chkAccident.Checked = False
        chkOralCancerDetection.Checked = False
        chkDevelopment.Checked = False
        chkAestheticsOrthodontics.Checked = False
        chkNextAppointment.Checked = False
        FillDataGrid("SELECT   TRMPDC_ID, PrescribedProcedure, Remarks  FROM   TreatmentProcedure  WHERE  (VID=0)", dgvPrescribedProcedure)
    End Sub

    Private Sub dgvProcedures_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProcedures.CellContentClick
        If txtDentalNotation.Text = "" Then
            ErrorProvider2.SetError(txtDentalNotation, "Mandatory field.")
        Else
            ErrorProvider2.Clear()
            Dim dental_notation As String = txtDentalNo.Text + " - " + txtDentalNotation.Text + " - " + dgvProcedures.CurrentRow.Cells(2).Value.ToString
            ExecuteSQLQuery(" INSERT INTO TreatmentProcedure (PrescribedProcedure, Remarks, VID, Price) VALUES  " &
                            " ('" + str_repl(dental_notation) + "', '', " & num_fltr(txtVisitID.Text) & ", " & num_fltr(dgvProcedures.CurrentRow.Cells(3).Value) & ") ")
            FillDataGrid("SELECT   TRMPDC_ID, PrescribedProcedure, Remarks  FROM   TreatmentProcedure  WHERE  (VID = " & num_fltr(txtVisitID.Text) & ")", dgvPrescribedProcedure)
        End If
    End Sub

    Private Sub dgvPrescribedProcedure_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrescribedProcedure.CellContentClick
        If e.ColumnIndex = 0 Then
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                ExecuteSQLQuery("DELETE FROM TreatmentProcedure WHERE  TRMPDC_ID =" & dgvPrescribedProcedure.CurrentRow.Cells(1).Value & " ")
                FillDataGrid("SELECT   TRMPDC_ID, PrescribedProcedure, Remarks  FROM   TreatmentProcedure  WHERE  (VID = " & num_fltr(txtVisitID.Text) & ")", dgvPrescribedProcedure)
                MsgBox("Record deleted successfully.", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub

    Private Sub dgvPrescribedProcedure_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrescribedProcedure.CellEndEdit
        Dim p As Integer
        If dgvPrescribedProcedure.RowCount > 0 Then
            For p = 0 To dgvPrescribedProcedure.RowCount - 1
                Dim TRMPDC_ID As String = dgvPrescribedProcedure.Rows(p).Cells("DataGridViewTextBoxColumn1").Value
                Dim PrescribedProcedure As String = dgvPrescribedProcedure.Rows(p).Cells("DataGridViewTextBoxColumn4").Value
                Dim Remarks As String = dgvPrescribedProcedure.Rows(p).Cells("Column4").Value
                ExecuteSQLQuery("UPDATE TreatmentProcedure SET    PrescribedProcedure='" + str_repl(PrescribedProcedure) + "', Remarks='" + str_repl(Remarks) + "'    WHERE        (TRMPDC_ID = " & num_fltr(TRMPDC_ID) & ") ")
            Next
        End If
    End Sub

    Private Sub chkNextAppointment_CheckedChanged(sender As Object, e As EventArgs) Handles chkNextAppointment.CheckedChanged
        If chkNextAppointment.Checked = True Then
            dtpNextAppointment.Enabled = True
        Else
            dtpNextAppointment.Enabled = False
        End If
    End Sub

    Private Sub txtVisitID_TextChanged(sender As Object, e As EventArgs) Handles txtVisitID.TextChanged
        If txtVisitID.Text = "" Then
            btnReset.PerformClick()
            TabControl1.Enabled = False
            TabControl2.Enabled = False
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            GroupBox5.Enabled = False
        Else
            TabControl1.Enabled = True
            TabControl2.Enabled = True
            GroupBox2.Enabled = True
            GroupBox3.Enabled = True
            GroupBox5.Enabled = True
            LoadTreatmentDetails(txtVisitID.Text)
        End If
    End Sub

    Private Sub btnAddDisease_Click(sender As Object, e As EventArgs) Handles btnAddDisease.Click
        Dim frmDisseDias As New frmDiseaseDiagnosis
        If (frmDisseDias.ShowDialog() = DialogResult.OK) Then
            FillComboBox("SELECT  DISEASE_DIAGNOSIS_ID, Disease  FROM    DiseaseDiagnosis", "DISEASE_DIAGNOSIS_ID", "Disease", cmbDisease)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim DntlProcedure As New frmDentalProcedures
        If (DntlProcedure.ShowDialog() = DialogResult.OK) Then
            LoadDentalProcedures()
        End If
    End Sub

    Private Sub btnDiseaseDiagnosis_Click(sender As Object, e As EventArgs) Handles btnDiseaseDiagnosis.Click
        ExecuteSQLQuery(" INSERT INTO  TreatmentDisease (VID, Disease, Diagnosis) VALUES (" & num_fltr(txtVisitID.Text) & ", '" + str_repl(cmbDisease.Text) + "', '" + str_repl(txtDiagnosis.Text) + "') ")
        FillDataGrid("SELECT TDS_ID, Disease, Diagnosis  FROM TreatmentDisease  WHERE  (VID = " & num_fltr(txtVisitID.Text) & ")", dgvDiagnosis)
        txtDiagnosis.Text = ""
    End Sub

    Private Sub dgvDiagnosis_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDiagnosis.CellContentClick
        If e.ColumnIndex = 0 Then
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                ExecuteSQLQuery("DELETE FROM TreatmentDisease WHERE  TDS_ID =" & dgvDiagnosis.CurrentRow.Cells(1).Value & " ")
                FillDataGrid("SELECT TDS_ID, Disease, Diagnosis  FROM TreatmentDisease  WHERE  (VID = " & num_fltr(txtVisitID.Text) & ")", dgvDiagnosis)
                MsgBox("Record deleted successfully.", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        With frmDentalBilling
            .txtID.Text = txtVisitID.Text
            .ShowDialog()
        End With
    End Sub

    Private Sub btnPatientForm_Click(sender As Object, e As EventArgs) Handles btnPatientForm.Click
        PatientForm_View(" SELECT        Treatment.VID, Treatment.VisitingDate, Treatment.VisitingTime, Treatment.AppointmentNo, Treatment.Patient_ID, Treatment.PatientName, Treatment.PatientAge, Treatment.Gender, Treatment.CompliantSymptoms, " &
                         " Treatment.PreviousDentalHistory, Treatment.PastMedicalHistory, Treatment.DentalHygienists, Treatment.GumDisease, Treatment.KeepingBadHabitsCheck, Treatment.PlaqueTartarCavities, Treatment.RoutineCheckUp, " &
                         " Treatment.Accident, Treatment.OralCancerDetection, Treatment.Development, Treatment.AestheticsOrthodontics, Treatment.NextAppointment, Treatment.NextAppointmentDate, TreatmentProcedure.PrescribedProcedure, " &
                         " TreatmentProcedure.Remarks, TreatmentDisease.Disease, TreatmentDisease.Diagnosis FROM            Treatment LEFT OUTER JOIN " &
                         " TreatmentDisease ON Treatment.VID = TreatmentDisease.VID LEFT OUTER JOIN TreatmentProcedure ON Treatment.VID = TreatmentProcedure.VID  WHERE        (Treatment.VID = " & num_fltr(txtVisitID.Text) & ") ")
    End Sub

    Private Sub btnSick_Leave_Form_Click(sender As Object, e As EventArgs) Handles btnSick_Leave_Form.Click
        If txtPatientID.Text = "" Or txtPatientName.Text = "" Then
            ErrorProvider1.SetError(txtPatientID, "Mandatory field.")
            ErrorProvider1.SetError(txtPatientName, "Mandatory field.")
        Else
            ErrorProvider1.Clear()
            With frmSickLeave
                .txtVisitID.Text = txtVisitID.Text
                .txtPatientName.Text = txtPatientName.Text
                .txtAge.Text = txtAge.Text
                .dtpApplicationDate.Value = dtpVisitingDate.Value
                .ShowDialog()
            End With
        End If
    End Sub
End Class