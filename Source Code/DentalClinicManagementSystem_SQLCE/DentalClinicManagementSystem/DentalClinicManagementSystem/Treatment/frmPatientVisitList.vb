Public Class frmPatientVisitList
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub LoadPatientVisitData()
        sqlSTR = "SELECT   VID, VisitingDate, VisitingTime, AppointmentNo, Patient_ID, PatientName, PatientAge, Gender, NextAppointmentDate  FROM   Treatment"
        FillDataGrid(sqlSTR, DataGridView1)
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            lblCount.Text = sqlDT.Rows.Count.ToString & " Record Found."
        Else
            lblCount.Text = "No Record Found."
        End If
    End Sub

    Private Sub frmPatientVisitList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
        LoadPatientVisitData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadPatientVisitData()
    End Sub

    Private Sub txtCriteria_TextChanged(sender As Object, e As EventArgs) Handles txtCriteria.TextChanged
        If cmbParameter.Text = "" Then
            ErrorProvider1.SetError(cmbParameter, "Mandatory field.")
            LoadPatientVisitData()
        ElseIf txtCriteria.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider2.SetError(txtCriteria, "Mandatory field.")
            LoadPatientVisitData()
        Else
            ErrorProvider1.Clear()
            ErrorProvider2.Clear()
            sqlSTR = " SELECT        VID, VisitingDate, VisitingTime, AppointmentNo, Patient_ID,  " &
                     " PatientName, PatientAge, Gender, NextAppointmentDate  FROM            Treatment " &
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        sqlSTR = "SELECT   VID, VisitingDate, VisitingTime, AppointmentNo, Patient_ID, PatientName, PatientAge, Gender, NextAppointmentDate  FROM   Treatment" &
                 "  WHERE        (VisitingDate >= '" & Format(dtpDateFrom.Value, "MM/dd/yyyy") & "' AND VisitingDate <= '" & Format(dtpDateTo.Value, "MM/dd/yyyy") & "') "
        FillDataGrid(sqlSTR, DataGridView1)
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            lblCount.Text = sqlDT.Rows.Count.ToString & " Record Found."
        Else
            lblCount.Text = "No Record Found."
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 Then
            If MsgBox("Are you sure you want to edit this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                With frmDentalScreen
                    .MdiParent = frmMDIParent
                    .Show()
                    .txtVisitID.Text = DataGridView1.CurrentRow.Cells(2).Value
                End With
            End If
        ElseIf e.ColumnIndex = 1 Then
            If MsgBox("Are you sure you want to permanently delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                ExecuteSQLQuery("DELETE FROM Treatment WHERE  VID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                ExecuteSQLQuery("DELETE FROM TreatmentDisease WHERE  VID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                ExecuteSQLQuery("DELETE FROM TreatmentProcedure WHERE  VID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                LoadPatientVisitData()
                MsgBox("Record deleted successfully.", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub
End Class