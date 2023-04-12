Public Class frmInvoiceLists
    Public Property RTN_INV_NO As String

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        sqlSTR = " SELECT        BILL_NO, BILLING_DATE, Patient_ID, WalkInCustomerName, Total, Paid_PAYMENT, DUE_PAYMENT, PAYMENT_METHOD " &
                 " FROM          PharmacyBilling  WHERE        (BILLING_DATE >= '" & Format(dtpDateFrom.Value, "MM/dd/yyyy") & "' AND BILLING_DATE <= '" & Format(dtpDateTo.Value, "MM/dd/yyyy") & "') "
        FillDataGrid(sqlSTR, DataGridView1)
    End Sub

    Private Sub frmInvoiceLists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
        btnSearch.PerformClick()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 Then
            Me.RTN_INV_NO = DataGridView1.CurrentRow.Cells(2).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
        ElseIf e.ColumnIndex = 1 Then
            If MsgBox("Are you sure you want to print view this bill?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                Pharmacy_Bill_View(" SELECT        PharmacyBilling.BILL_NO, PharmacyBilling.BILLING_DATE, PharmacyBilling.Patient_ID, PharmacyBilling.WalkInCustomerName, PharmacyBilling.Total, PharmacyBilling.Paid_PAYMENT, PharmacyBilling.DUE_PAYMENT, " &
                                   " PharmacyBilling.PAYMENT_METHOD, ProductInformation.ProductName, PharmacyBillingDetails.Qty, ProductInformation.UOM, PharmacyBillingDetails.TotalCost, PharmacyBillingDetails.TotalSales,  " &
                                   " PharmacyBillingDetails.UnitSales FROM            PharmacyBilling LEFT OUTER JOIN  PharmacyBillingDetails ON PharmacyBilling.BILL_NO = PharmacyBillingDetails.BILL_NO LEFT OUTER JOIN " &
                                   " ProductInformation ON PharmacyBillingDetails.PRODUCT_ID = ProductInformation.PRODUCT_ID WHERE        (PharmacyBilling.BILL_NO = " & DataGridView1.CurrentRow.Cells(2).Value & ") ")
            End If
        End If
    End Sub
End Class