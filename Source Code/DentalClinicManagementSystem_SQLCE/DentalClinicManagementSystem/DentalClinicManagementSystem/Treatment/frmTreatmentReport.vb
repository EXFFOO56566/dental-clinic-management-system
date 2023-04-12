Public Class frmTreatmentReport
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrintView_Click(sender As Object, e As EventArgs) Handles btnPrintView.Click
        Dim SharedParameters As String = Format(dtpDateFrom.Value, "dd-MMM-yyyy") & " - " & Format(dtpDateTo.Value, "dd-MMM-yyyy")
        TreatmentBillList_View(" SELECT  VID, VisitingDate, AppointmentNo, Patient_ID, PatientName, SubTotal, Discount, TAX, Total, Paid, ChangeDue  FROM    Treatment " &
                               " WHERE        (VisitingDate >= '" & Format(dtpDateFrom.Value, "MM/dd/yyyy") & "' AND VisitingDate <= '" & Format(dtpDateTo.Value, "MM/dd/yyyy") & "') ", SharedParameters)
    End Sub

    Private Sub frmTreatmentReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
    End Sub
End Class