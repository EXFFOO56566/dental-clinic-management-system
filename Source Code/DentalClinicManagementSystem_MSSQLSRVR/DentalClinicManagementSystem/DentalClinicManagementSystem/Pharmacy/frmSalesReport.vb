Public Class frmSalesReport
    Dim sls_SQL As String = " SELECT    PharmacyBilling.BILL_NO, PharmacyBilling.BILLING_DATE, PharmacyBilling.Patient_ID, PharmacyBilling.WalkInCustomerName, PharmacyBilling.Total, PharmacyBilling.Paid_PAYMENT, PharmacyBilling.DUE_PAYMENT, " &
                            " PharmacyBilling.PAYMENT_METHOD, ProductInformation.ProductName, PharmacyBillingDetails.Qty, ProductInformation.UOM, PharmacyBillingDetails.TotalCost, PharmacyBillingDetails.TotalSales, " &
                            " PharmacyBillingDetails.UnitSales FROM     PharmacyBilling LEFT OUTER JOIN PharmacyBillingDetails ON PharmacyBilling.BILL_NO = PharmacyBillingDetails.BILL_NO LEFT OUTER JOIN " &
                            " ProductInformation ON PharmacyBillingDetails.PRODUCT_ID = ProductInformation.PRODUCT_ID  "
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
        FillComboBox("SELECT  PRODUCT_ID,  ProductName  FROM   ProductInformation", "PRODUCT_ID", "ProductName", cmbProduct)
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Dim PatientList As New frmPatientList
        If (PatientList.ShowDialog() = DialogResult.OK) Then
            txtPatientID.Text = PatientList.RTN_Patient_ID
        End If
    End Sub

    Private Sub btnPrintView_Click(sender As Object, e As EventArgs) Handles btnPrintView.Click
        Dim SharedParameters, CustomCriteria As String
        If rbDate.Checked = True Then
            SharedParameters = Format(dtpDateFrom.Value, "dd-MMM-yyyy") & " - " & Format(dtpDateTo.Value, "dd-MMM-yyyy")
            CustomCriteria = " WHERE        (PharmacyBilling.BILLING_DATE >= '" & Format(dtpDateFrom.Value, "MM/dd/yyyy") & "' AND PharmacyBilling.BILLING_DATE <= '" & Format(dtpDateTo.Value, "MM/dd/yyyy") & "')"
            Pharmacy_Sales_List(sls_SQL & CustomCriteria, SharedParameters)
        ElseIf rbDatePatientID.Checked = True Then
            If txtPatientID.Text = "" Then
                ErrorProvider1.Clear()
                ErrorProvider1.SetError(txtPatientID, "Mandatory field.")
            Else
                ErrorProvider1.Clear()
                SharedParameters = Format(dtpDateFrom.Value, "dd-MMM-yyyy") & " - " & Format(dtpDateTo.Value, "dd-MMM-yyyy") & " -  PATIENT ID # " & txtPatientID.Text
                CustomCriteria = " WHERE        (PharmacyBilling.BILLING_DATE >= '" & Format(dtpDateFrom.Value, "MM/dd/yyyy") & "' AND PharmacyBilling.BILLING_DATE <= '" & Format(dtpDateTo.Value, "MM/dd/yyyy") & "') AND (PharmacyBilling.Patient_ID = " & num_fltr(txtPatientID.Text) & ")  "
                Pharmacy_Sales_List(sls_SQL & CustomCriteria, SharedParameters)
            End If
        ElseIf rbDateCustomerName.Checked = True Then
            If txtCustomerName.Text = "" Then
                ErrorProvider1.Clear()
                ErrorProvider1.SetError(txtCustomerName, "Mandatory field.")
            Else
                ErrorProvider1.Clear()
                CustomCriteria = " WHERE        (PharmacyBilling.BILLING_DATE >= '" & Format(dtpDateFrom.Value, "MM/dd/yyyy") & "' AND PharmacyBilling.BILLING_DATE <= '" & Format(dtpDateTo.Value, "MM/dd/yyyy") & "') AND (PharmacyBilling.WalkInCustomerName LIKE N'%" + str_repl(txtCustomerName.Text) + "%')  "
                ExecuteSQLQuery(sls_SQL & CustomCriteria)
                Dim cust_name As String
                If sqlDT.Rows.Count > 0 Then
                    cust_name = sqlDT.Rows(0)("WalkInCustomerName")
                Else
                    cust_name = "[CUSTOMER NAME NOT MATCH.]"
                End If
                SharedParameters = Format(dtpDateFrom.Value, "dd-MMM-yyyy") & " - " & Format(dtpDateTo.Value, "dd-MMM-yyyy") & " -  CUSTOMER NAME # " & cust_name
                Pharmacy_Sales_List(sls_SQL & CustomCriteria, SharedParameters)
            End If
        ElseIf rbDatePaidBill.Checked = True Then
            SharedParameters = " PAID BILL,  " & Format(dtpDateFrom.Value, "dd-MMM-yyyy") & " - " & Format(dtpDateTo.Value, "dd-MMM-yyyy")
            CustomCriteria = " WHERE        (PharmacyBilling.BILLING_DATE >= '" & Format(dtpDateFrom.Value, "MM/dd/yyyy") & "' AND PharmacyBilling.BILLING_DATE <= '" & Format(dtpDateTo.Value, "MM/dd/yyyy") & "') AND (PharmacyBilling.Paid_PAYMENT >= PharmacyBilling.DUE_PAYMENT)"
            Pharmacy_Sales_List(sls_SQL & CustomCriteria, SharedParameters)
        ElseIf rbDateDueBill.Checked = True Then
            SharedParameters = " PAYMENT DUE BILL,  " & Format(dtpDateFrom.Value, "dd-MMM-yyyy") & " - " & Format(dtpDateTo.Value, "dd-MMM-yyyy")
            CustomCriteria = " WHERE        (PharmacyBilling.BILLING_DATE >= '" & Format(dtpDateFrom.Value, "MM/dd/yyyy") & "' AND PharmacyBilling.BILLING_DATE <= '" & Format(dtpDateTo.Value, "MM/dd/yyyy") & "') AND (PharmacyBilling.Paid_PAYMENT <= PharmacyBilling.DUE_PAYMENT)"
            Pharmacy_Sales_List(sls_SQL & CustomCriteria, SharedParameters)
        ElseIf rbDateItemName.Checked = True Then
            If cmbProduct.SelectedValue Is Nothing Or cmbProduct.SelectedIndex = -1 Then
                ErrorProvider1.SetError(cmbProduct, "Please select a username.")
            Else
                ErrorProvider1.Clear()
                SharedParameters = "ITEM WISE SALE ,  " & Format(dtpDateFrom.Value, "dd-MMM-yyyy") & " - " & Format(dtpDateTo.Value, "dd-MMM-yyyy")
                CustomCriteria = " WHERE        (PharmacyBilling.BILLING_DATE >= '" & Format(dtpDateFrom.Value, "MM/dd/yyyy") & "' AND PharmacyBilling.BILLING_DATE <= '" & Format(dtpDateTo.Value, "MM/dd/yyyy") & "') AND (PharmacyBillingDetails.PRODUCT_ID = " & num_fltr(cmbProduct.SelectedValue) & ")"
                Pharmacy_Sales_List(sls_SQL & CustomCriteria, SharedParameters)
            End If
        End If
    End Sub
End Class