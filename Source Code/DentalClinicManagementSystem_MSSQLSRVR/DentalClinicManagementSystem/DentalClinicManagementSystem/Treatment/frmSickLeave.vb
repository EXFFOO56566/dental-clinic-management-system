Public Class frmSickLeave
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmSickLeave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If

        ExecuteSQLQuery("SELECT   * FROM            TreatmentSickLeave  WHERE        (VID = " & num_fltr(txtVisitID.Text) & ")")
        If sqlDT.Rows.Count > 0 Then
            txtReferenceNo.Text = sqlDT.Rows(0)("ReferenceNo")
            dtpApplicationDate.Value = sqlDT.Rows(0)("ApplicationDate")
            txtPatientName.Text = sqlDT.Rows(0)("PatientName")
            txtAge.Text = sqlDT.Rows(0)("Age")
            dtpLeaveFrom.Value = sqlDT.Rows(0)("LeaveFrom")
            dtpLeaveTo.Value = sqlDT.Rows(0)("LeaveTo")
            txtDisease.Text = sqlDT.Rows(0)("Disease")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtPatientName.Text = "" Or txtAge.Text = "" Or txtDisease.Text = "" Then
            ErrorProvider1.SetError(txtPatientName, "Mandatory field.")
            ErrorProvider1.SetError(txtPatientName, "Mandatory field.")
            ErrorProvider1.SetError(txtDisease, "Mandatory field.")
        Else
            ErrorProvider1.Clear()
            Dim TotalLeaveDays As String
            Dim dt1 As DateTime = Convert.ToDateTime(dtpLeaveFrom.Text)
            Dim dt2 As DateTime = Convert.ToDateTime(dtpLeaveTo.Text)
            Dim ts As TimeSpan = dt2.Subtract(dt1)
            If Convert.ToInt32(ts.Days) >= 0 Then
                TotalLeaveDays = Convert.ToInt32(ts.Days) + 1
            Else
                ErrorProvider1.SetError(dtpLeaveFrom, "Invalid.")
                ErrorProvider1.SetError(dtpLeaveTo, "Invalid.")
                MsgBox("Invalid Leave Date range", MsgBoxStyle.Critical, "Critical")
                Exit Sub
            End If
            ErrorProvider1.Clear()
            ExecuteSQLQuery("SELECT   * FROM            TreatmentSickLeave  WHERE        (VID = " & num_fltr(txtVisitID.Text) & ")")
            If sqlDT.Rows.Count > 0 Then
                ExecuteSQLQuery(" UPDATE TreatmentSickLeave SET ReferenceNo='" + str_repl(txtReferenceNo.Text) + "', ApplicationDate= '" & Format(dtpApplicationDate.Value, "MM/dd/yyyy") & "', PatientName='" + str_repl(txtPatientName.Text) + "', " &
                                " Age='" + str_repl(txtAge.Text) + "', LeaveFrom= '" & Format(dtpLeaveFrom.Value, "MM/dd/yyyy") & "', LeaveTo= '" & Format(dtpLeaveTo.Value, "MM/dd/yyyy") & "', Disease='" + str_repl(txtDisease.Text) + "', DateDuration='" + TotalLeaveDays + "' " &
                                " WHERE        (VID = " & num_fltr(txtVisitID.Text) & ") ")
                MsgBox("Record has been updated successfully.", MsgBoxStyle.Information, "Information")
            Else
                ExecuteSQLQuery(" INSERT INTO TreatmentSickLeave (ReferenceNo, ApplicationDate, PatientName, LeaveFrom, LeaveTo, Disease, DateDuration, Age, VID) VALUES  " &
                                " ( '" + str_repl(txtReferenceNo.Text) + "', '" & Format(dtpApplicationDate.Value, "MM/dd/yyyy") & "', '" + str_repl(txtPatientName.Text) + "',   " &
                                " '" & Format(dtpLeaveFrom.Value, "MM/dd/yyyy") & "', '" & Format(dtpLeaveTo.Value, "MM/dd/yyyy") & "', '" + str_repl(txtDisease.Text) + "', '" + TotalLeaveDays + "', '" + str_repl(txtAge.Text) + "', " & num_fltr(txtVisitID.Text) & " ) ")
                MsgBox("Record has been saved successfully.", MsgBoxStyle.Information, "Information")
            End If
            SickLeaveForm_View(" SELECT  VID, ReferenceNo, ApplicationDate, PatientName, Age, LeaveFrom, LeaveTo, Disease, DateDuration " &
                               " FROM    TreatmentSickLeave WHERE        (VID = " & num_fltr(txtVisitID.Text) & ") ")
        End If
    End Sub
End Class