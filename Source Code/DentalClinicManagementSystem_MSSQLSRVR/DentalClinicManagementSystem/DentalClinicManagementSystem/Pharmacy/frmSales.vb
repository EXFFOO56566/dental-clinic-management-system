Public Class frmSales
    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If


        FillComboBox("SELECT  PRODUCT_ID,  ProductName  FROM   ProductInformation", "PRODUCT_ID", "ProductName", cmbProduct)
        cmbProduct.SelectedIndex = -1
        grpItemDetails.Visible = False
        chkPrintBill.Checked = My.Settings.PrintBill

        ExecuteSQLQuery("SELECT  BILL_NO FROM     PharmacyBilling  ORDER BY BILL_NO DESC")
        If sqlDT.Rows.Count > 0 Then
            Dim BILL_NO As Double = sqlDT.Rows(0)("BILL_NO")
            ExecuteSQLQuery("SELECT * FROM      PharmacyBillingDetails  WHERE   (BILL_NO = " & num_fltr(BILL_NO) & ")")
            If sqlDT.Rows.Count > 0 Then

                ExecuteSQLQuery(" INSERT INTO PharmacyBilling (BILLING_DATE, WalkInCustomerName, Total, Paid_PAYMENT, DUE_PAYMENT, PAYMENT_METHOD, Patient_ID) VALUES " &
                                    " ('" & Format(Now, "MM/dd/yyyy") & "', '', 0, 0, 0, '----', 0) ")
                txtPaid.Value = "0"
                ExecuteSQLQuery("SELECT  BILL_NO FROM     PharmacyBilling  ORDER BY BILL_NO DESC")
                txtBillNo.Text = sqlDT.Rows(0)("BILL_NO")
                LoadCartItem()

            Else
                Dim msg As String
                msg = "An incomplete bill was recently found! "
                msg = msg & Chr(10) & "Do you want to complete this bill?"
                If MsgBox(msg, MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Empty!") = MsgBoxResult.Yes Then
                    txtBillNo.Text = BILL_NO
                    LoadCartItem()
                Else
                    ExecuteSQLQuery(" INSERT INTO PharmacyBilling (BILLING_DATE, WalkInCustomerName, Total, Paid_PAYMENT, DUE_PAYMENT, PAYMENT_METHOD, Patient_ID) VALUES " &
                                    " ('" & Format(Now, "MM/dd/yyyy") & "', '', 0, 0, 0, '----', 0) ")
                    txtPaid.Value = "0"
                    ExecuteSQLQuery("SELECT  BILL_NO FROM     PharmacyBilling  ORDER BY BILL_NO DESC")
                    txtBillNo.Text = sqlDT.Rows(0)("BILL_NO")
                    LoadCartItem()
                End If
            End If
        Else
            If MsgBox("Are you sure you want to create a new bill?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                ExecuteSQLQuery(" INSERT INTO PharmacyBilling (BILLING_DATE, WalkInCustomerName, Total, Paid_PAYMENT, DUE_PAYMENT, PAYMENT_METHOD, Patient_ID) VALUES " &
                                " ('" & Format(Now, "MM/dd/yyyy") & "', '', 0, 0, 0, '----', 0) ")
                txtPaid.Value = "0"
                ExecuteSQLQuery("SELECT  BILL_NO FROM     PharmacyBilling  ORDER BY BILL_NO DESC")
                txtBillNo.Text = sqlDT.Rows(0)("BILL_NO")
                LoadCartItem()
            End If
        End If
    End Sub
    Private Sub FindOutItem(ByVal PRODUCT_ID As String)
        ExecuteSQLQuery("SELECT  *  FROM            ProductInformation  WHERE   (PRODUCT_ID = " & num_fltr(PRODUCT_ID) & ")")
        If sqlDT.Rows.Count > 0 Then
            grpItemDetails.Visible = True
            txtProductID.Text = sqlDT.Rows(0)("PRODUCT_ID")
            txtProductName.Text = sqlDT.Rows(0)("ProductName")
            txtAvailableQuantity.Text = sqlDT.Rows(0)("Quantity")
            txtSalesPrice.Text = Math.Round(sqlDT.Rows(0)("SalesPrice"), 2)
            txtPurchaseCost.Text = Math.Round(sqlDT.Rows(0)("PurchasePrice"), 2)
            txtQuantity.Value = 1
            txtQuantity.Select()
        Else
            grpItemDetails.Visible = False
        End If
    End Sub
    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Dim PatientList As New frmPatientList
        If (PatientList.ShowDialog() = DialogResult.OK) Then
            txtPatientID.Text = PatientList.RTN_Patient_ID
            txtCustomerName.Text = PatientList.RTN_Patient_NAME
        End If
    End Sub

    Private Sub btnAddCart_Click(sender As Object, e As EventArgs) Handles btnAddCart.Click
        grpItemDetails.Visible = False
        AddItemToCart(txtProductID.Text, txtQuantity.Value)
    End Sub
    Private Sub AddItemToCart(ByVal PRODUCT_ID As Double, ByVal Qty As Double)
        ExecuteSQLQuery("SELECT   *  FROM   PharmacyBillingDetails   WHERE    (BILL_NO = " & txtBillNo.Text & ") AND (PRODUCT_ID =  " & PRODUCT_ID & ") ")
        If sqlDT.Rows.Count > 0 Then
            ExecuteSQLQuery(" UPDATE PharmacyBillingDetails SET Qty = Qty + " & Qty & ", TotalCost=TotalCost+ " & Qty * Val(txtPurchaseCost.Text) & ", TotalSales = TotalSales + " & Qty * Val(txtSalesPrice.Text) & " " &
                            " WHERE    (BILL_NO = " & txtBillNo.Text & ") AND (PRODUCT_ID =  " & PRODUCT_ID & ") ")
            ExecuteSQLQuery(" UPDATE ProductInformation SET Quantity = Quantity -" & Qty & "  WHERE  (PRODUCT_ID = " & PRODUCT_ID & ") ")
        Else
            ExecuteSQLQuery("INSERT INTO PharmacyBillingDetails (BILL_NO, PRODUCT_ID, Qty, UnitCost, UnitSales, TotalCost, TotalSales) VALUES ( " & txtBillNo.Text & ", " & PRODUCT_ID & ", " &
                            "" & Qty & ", " & txtPurchaseCost.Text & ", " & txtSalesPrice.Text & ", " & Qty * Val(txtPurchaseCost.Text) & ", " & Qty * Val(txtSalesPrice.Text) & " )")
            ExecuteSQLQuery(" UPDATE ProductInformation SET Quantity = Quantity - " & Qty & "  WHERE  (PRODUCT_ID = " & PRODUCT_ID & ") ")
        End If
        LoadCartItem()
    End Sub
    Private Sub LoadCartItem()
        sqlSTR = " SELECT PharmacyBillingDetails.PRODUCT_ID, ProductInformation.ProductName, PharmacyBillingDetails.Qty, PharmacyBillingDetails.UnitSales, PharmacyBillingDetails.TotalSales " &
                 " FROM   PharmacyBillingDetails LEFT OUTER JOIN ProductInformation ON PharmacyBillingDetails.PRODUCT_ID = ProductInformation.PRODUCT_ID " &
                 " WHERE  (PharmacyBillingDetails.BILL_NO = " & txtBillNo.Text & ") "
        FillDataGrid(sqlSTR, DataGridView1)

        ExecuteSQLQuery("SELECT    *  FROM      PharmacyBillingDetails  WHERE    (BILL_NO = " & txtBillNo.Text & ")")
        If sqlDT.Rows.Count > 0 Then
            ExecuteSQLQuery(" SELECT   SUM(TotalSales) AS Expr1  FROM    PharmacyBillingDetails   WHERE    (BILL_NO = " & txtBillNo.Text & ") ")
            If sqlDT.Rows.Count > 0 Then
                txtTotalBill.Text = Math.Round(sqlDT.Rows(0)("Expr1"), 2)
            End If
        Else
            txtTotalBill.Text = "0"
        End If

        ExecuteSQLQuery("SELECT   *  FROM    PharmacyBilling   WHERE   (BILL_NO = " & num_fltr(txtBillNo.Text) & ")")
        If sqlDT.Rows.Count > 0 Then
            txtPatientID.Text = sqlDT.Rows(0)("Patient_ID")
            txtCustomerName.Text = sqlDT.Rows(0)("WalkInCustomerName")
            txtPaid.Value = sqlDT.Rows(0)("Paid_PAYMENT")
            cmbMethod.Text = sqlDT.Rows(0)("PAYMENT_METHOD")
        End If


    End Sub
    Private Sub cmbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProduct.SelectedIndexChanged
        Try
            FindOutItem(cmbProduct.SelectedValue.ToString)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            ExecuteSQLQuery("SELECT  *  FROM      ProductInformation  WHERE (Barcode = '" + str_repl(txtBarcode.Text) + "')")
            If sqlDT.Rows.Count > 0 Then
                txtBarcode.Text = ""
                FindOutItem(sqlDT.Rows(0)("PRODUCT_ID").ToString)
            Else
                txtBarcode.Text = ""
                MsgBox("Sorry! Barcode does not match.", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub
    Private Sub txtQuantity_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQuantity.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAddCart.PerformClick()
        End If
    End Sub
    Private Sub LoadCalculation()
        Dim change_due As Double = num_fltr(Val(txtTotalBill.Text)) - num_fltr(Val(txtPaid.Value))
        txtChangeDue.Text = Math.Round(change_due, 2)
    End Sub
    Private Sub txtTotalBill_TextChanged(sender As Object, e As EventArgs) Handles txtTotalBill.TextChanged
        LoadCalculation()
    End Sub

    Private Sub chkPrintBill_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrintBill.CheckedChanged
        My.Settings.PrintBill = chkPrintBill.Checked
        My.Settings.Save()
    End Sub

    Private Sub btnNewSale_Click(sender As Object, e As EventArgs) Handles btnNewSale.Click
        ExecuteSQLQuery("SELECT * FROM      PharmacyBillingDetails  WHERE   (BILL_NO = " & num_fltr(txtBillNo.Text) & ")")
        If sqlDT.Rows.Count > 0 Then
            If MsgBox("Are you sure you want to create a new bill?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                ExecuteSQLQuery(" INSERT INTO PharmacyBilling (BILLING_DATE, WalkInCustomerName, Total, Paid_PAYMENT, DUE_PAYMENT, PAYMENT_METHOD, Patient_ID) VALUES " &
                                " ('" & Format(Now, "MM/dd/yyyy") & "', '', 0, 0, 0, '----', 0) ")
                txtPaid.Value = "0"
                ExecuteSQLQuery("SELECT  BILL_NO FROM     PharmacyBilling  ORDER BY BILL_NO DESC")
                txtBillNo.Text = sqlDT.Rows(0)("BILL_NO")
                LoadCartItem()
            End If
        Else
            Dim msg As String
            msg = "Cart is empty! "
            msg = msg & Chr(10) & " "
            msg = msg & Chr(10) & "Are you sure you want to create a new bill?"
            If MsgBox(msg, MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Empty!") = MsgBoxResult.Yes Then
                ExecuteSQLQuery(" INSERT INTO PharmacyBilling (BILLING_DATE, WalkInCustomerName, Total, Paid_PAYMENT, DUE_PAYMENT, PAYMENT_METHOD, Patient_ID) VALUES " &
                                " ('" & Format(Now, "MM/dd/yyyy") & "', '', 0, 0, 0, '----', 0) ")
                txtPaid.Value = "0"
                ExecuteSQLQuery("SELECT  BILL_NO FROM     PharmacyBilling  ORDER BY BILL_NO DESC")
                txtBillNo.Text = sqlDT.Rows(0)("BILL_NO")
                LoadCartItem()
            End If
        End If

    End Sub

    Private Sub txtPaid_ValueChanged(sender As Object, e As EventArgs) Handles txtPaid.ValueChanged
        LoadCalculation()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MsgBox("Are you sure you want to save this bill?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
            ExecuteSQLQuery(" UPDATE PharmacyBilling SET Patient_ID=" & num_fltr(txtPatientID.Text) & ", WalkInCustomerName='" + str_repl(txtCustomerName.Text) + "', Total=" & num_fltr(txtTotalBill.Text) & ", Paid_PAYMENT=" & num_fltr(txtPaid.Value) & ",  " &
                            " DUE_PAYMENT=" & num_fltr(txtChangeDue.Text) & ", PAYMENT_METHOD='" + str_repl(cmbMethod.Text) + "'   WHERE        (BILL_NO =" & num_fltr(txtBillNo.Text) & ") ")
            MsgBox("Record has been updated successfully.", MsgBoxStyle.Information, "Information")
        End If
    End Sub

    Private Sub lnkInvoiceLists_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkInvoiceLists.LinkClicked
        Dim InvoList As New frmInvoiceLists
        If (InvoList.ShowDialog() = DialogResult.OK) Then
            txtBillNo.Text = InvoList.RTN_INV_NO
            LoadCartItem()
        End If
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        ExecuteSQLQuery("SELECT *  FROM     PharmacyBillingDetails   WHERE    (BILL_NO = " & num_fltr(txtBillNo.Text) & ")")
        If sqlDT.Rows.Count > 0 Then
            ExecuteSQLQuery(" UPDATE PharmacyBilling SET Patient_ID=" & num_fltr(txtPatientID.Text) & ", WalkInCustomerName='" + str_repl(txtCustomerName.Text) + "', Total=" & num_fltr(txtTotalBill.Text) & ", Paid_PAYMENT=" & num_fltr(txtPaid.Value) & ",  " &
                            " DUE_PAYMENT=" & num_fltr(txtChangeDue.Text) & ", PAYMENT_METHOD='" + str_repl(cmbMethod.Text) + "'   WHERE        (BILL_NO =" & num_fltr(txtBillNo.Text) & ") ")
            If chkPrintBill.Checked = True Then
                Pharmacy_Bill_View(" SELECT        PharmacyBilling.BILL_NO, PharmacyBilling.BILLING_DATE, PharmacyBilling.Patient_ID, PharmacyBilling.WalkInCustomerName, PharmacyBilling.Total, PharmacyBilling.Paid_PAYMENT, PharmacyBilling.DUE_PAYMENT, " &
                                   " PharmacyBilling.PAYMENT_METHOD, ProductInformation.ProductName, PharmacyBillingDetails.Qty, ProductInformation.UOM, PharmacyBillingDetails.TotalCost, PharmacyBillingDetails.TotalSales,  " &
                                   " PharmacyBillingDetails.UnitSales FROM            PharmacyBilling LEFT OUTER JOIN  PharmacyBillingDetails ON PharmacyBilling.BILL_NO = PharmacyBillingDetails.BILL_NO LEFT OUTER JOIN " &
                                   " ProductInformation ON PharmacyBillingDetails.PRODUCT_ID = ProductInformation.PRODUCT_ID WHERE        (PharmacyBilling.BILL_NO = " & num_fltr(txtBillNo.Text) & ") ")
            End If
            btnNewSale.PerformClick()
        Else
            MsgBox("No item found in this invoice.", MsgBoxStyle.Critical, "Critical")
        End If
    End Sub
End Class