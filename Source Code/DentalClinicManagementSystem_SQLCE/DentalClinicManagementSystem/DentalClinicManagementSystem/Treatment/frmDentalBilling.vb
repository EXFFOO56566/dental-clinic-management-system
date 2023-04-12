Public Class frmDentalBilling
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmDentalBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If

        ExecuteSQLQuery("SELECT   *  FROM      TreatmentProcedure   WHERE        (VID = " & num_fltr(txtID.Text) & ")")
        If sqlDT.Rows.Count > 0 Then
            ExecuteSQLQuery("SELECT    SUM(Price) AS Expr1  FROM   TreatmentProcedure   WHERE        (VID = " & num_fltr(txtID.Text) & ")")
            txtSubtotal.Text = sqlDT.Rows(0)("Expr1")
        Else
            txtSubtotal.Text = "0"
        End If
        ExecuteSQLQuery(" UPDATE Treatment SET SubTotal= " & num_fltr(txtSubtotal.Text) & "  WHERE        (VID = " & num_fltr(txtID.Text) & ") ")

        ExecuteSQLQuery("SELECT   * FROM   Treatment  WHERE   (VID = " & num_fltr(txtID.Text) & ")")
        If sqlDT.Rows.Count > 0 Then
            txtDiscount.Value = sqlDT.Rows(0)("Discount")
            txtTAX.Value = sqlDT.Rows(0)("TAX")
            txtTotal.Text = sqlDT.Rows(0)("Total")
            txtPaid.Value = sqlDT.Rows(0)("Paid")
            txtChangeDue.Text = sqlDT.Rows(0)("ChangeDue")
        End If
        CalculateBill()
    End Sub

    Private Sub CalculateBill()
        txtTotal.Text = Convert.ToDouble(num_fltr(txtSubtotal.Text)) + Convert.ToDouble(num_fltr(txtTAX.Value)) - Convert.ToDouble(num_fltr(txtDiscount.Value))
        txtChangeDue.Text = Convert.ToDouble(num_fltr(txtTotal.Text)) - Convert.ToDouble(num_fltr(txtPaid.Value))
    End Sub

    Private Sub txtDiscount_ValueChanged(sender As Object, e As EventArgs) Handles txtDiscount.ValueChanged
        CalculateBill()
    End Sub

    Private Sub txtTAX_ValueChanged(sender As Object, e As EventArgs) Handles txtTAX.ValueChanged
        CalculateBill()
    End Sub

    Private Sub txtPaid_ValueChanged(sender As Object, e As EventArgs) Handles txtPaid.ValueChanged
        CalculateBill()
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        CalculateBill()
        ExecuteSQLQuery(" UPDATE  Treatment SET      SubTotal=" & num_fltr(txtSubtotal.Text) & ", Discount=" & num_fltr(txtDiscount.Value) & ", TAX=" & num_fltr(txtTAX.Value) & ", " &
                        " Total=" & num_fltr(txtTotal.Text) & ", Paid=" & num_fltr(txtPaid.Value) & ", ChangeDue=" & num_fltr(txtChangeDue.Text) & " WHERE        (VID = " & num_fltr(txtID.Text) & ") ")
        MsgBox("Record has been updated successfully.", MsgBoxStyle.Information, "Information")
    End Sub

    Private Sub btnPrintView_Click(sender As Object, e As EventArgs) Handles btnPrintView.Click
        TreatmentBill_View(" SELECT        Treatment.VID, Treatment.VisitingDate, Treatment.VisitingTime, Treatment.AppointmentNo, Treatment.Patient_ID, Treatment.PatientName, Treatment.PatientAge, Treatment.Gender, Treatment.SubTotal, Treatment.Discount, " &
                           " Treatment.TAX, Treatment.Total, Treatment.Paid, Treatment.ChangeDue, TreatmentProcedure.PrescribedProcedure, TreatmentProcedure.Remarks, TreatmentProcedure.Price FROM            Treatment LEFT OUTER JOIN " &
                           " TreatmentProcedure ON Treatment.VID = TreatmentProcedure.VID  WHERE        (Treatment.VID = " & num_fltr(txtID.Text) & ") ")
    End Sub
End Class