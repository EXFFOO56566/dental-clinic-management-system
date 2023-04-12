Public Class frmPrescriptionList
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub LoadPrescriptionData()
        sqlSTR = "SELECT        PRESCRIPTION_ID, PrescriptionDate, AppointmentNo, VisitID, Patient_ID, PatientName, Age, Gender   FROM     Prescription "
        FillDataGrid(sqlSTR, DataGridView1)
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            lblCount.Text = sqlDT.Rows.Count.ToString & " Record Found."
        Else
            lblCount.Text = "No Record Found."
        End If
    End Sub

    Private Sub frmPrescriptionList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If

        LoadPrescriptionData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadPrescriptionData()
    End Sub

    Private Sub txtCriteria_TextChanged(sender As Object, e As EventArgs) Handles txtCriteria.TextChanged
        If cmbParameter.Text = "" Then
            ErrorProvider1.SetError(cmbParameter, "Mandatory field.")
            LoadPrescriptionData()
        ElseIf txtCriteria.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider2.SetError(txtCriteria, "Mandatory field.")
            LoadPrescriptionData()
        Else
            ErrorProvider1.Clear()
            ErrorProvider2.Clear()
            sqlSTR = " SELECT        PRESCRIPTION_ID, PrescriptionDate, AppointmentNo, VisitID,  " &
                     " Patient_ID, PatientName, Age, Gender   FROM     Prescription " &
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
        sqlSTR = "SELECT        PRESCRIPTION_ID, PrescriptionDate, AppointmentNo, VisitID, Patient_ID, PatientName, Age, Gender   FROM     Prescription " &
                 "  WHERE        (PrescriptionDate >= '" & Format(dtpDateFrom.Value, "MM/dd/yyyy") & "' AND PrescriptionDate <= '" & Format(dtpDateTo.Value, "MM/dd/yyyy") & "') "
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
                With frmPrescription
                    .MdiParent = frmMDIParent
                    .txtPrescriptionID.Text = DataGridView1.CurrentRow.Cells(2).Value
                    .Show()
                End With
            End If
        ElseIf e.ColumnIndex = 1 Then
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                ExecuteSQLQuery("DELETE FROM Prescription WHERE  PRESCRIPTION_ID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                ExecuteSQLQuery("DELETE FROM PrescriptionDetail WHERE  PRESCRIPTION_ID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                LoadPrescriptionData()
                MsgBox("Record deleted successfully.", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub
End Class