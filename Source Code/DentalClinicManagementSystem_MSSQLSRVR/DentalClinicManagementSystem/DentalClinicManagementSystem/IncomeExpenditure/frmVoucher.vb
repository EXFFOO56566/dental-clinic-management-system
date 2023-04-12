Public Class frmVoucher
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmChartOfAccounts.MdiParent = frmMDIParent
        frmChartOfAccounts.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub LoadVoucherType()
        If rbRevenue.Checked Then
            FillComboBox("SELECT  CHART_OF_ACCOUNT_ID, AccountsName  FROM   ChartOfAccounts WHERE   (AccountsType = 'Revenue')", "CHART_OF_ACCOUNT_ID", "AccountsName", cmbAccountName)
        Else
            FillComboBox("SELECT  CHART_OF_ACCOUNT_ID, AccountsName  FROM   ChartOfAccounts WHERE   (AccountsType = 'Expense')", "CHART_OF_ACCOUNT_ID", "AccountsName", cmbAccountName)
        End If
    End Sub

    Private Sub rbRevenue_CheckedChanged(sender As Object, e As EventArgs) Handles rbRevenue.CheckedChanged
        LoadVoucherType()
    End Sub

    Private Sub rbExpense_CheckedChanged(sender As Object, e As EventArgs) Handles rbExpense.CheckedChanged
        LoadVoucherType()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        LoadVoucherType()
        txtVoucherID.Text = ""
        txtAmount.Text = ""
        txtReferenceNumber.Text = ""
        txtRemark.Text = ""
        dtpDateOfVoucher.Value = Now
        cmbPaymentMethod.SelectedIndex = -1
        btnSave.Text = "SAVE"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbAccountName.SelectedValue Is Nothing Or cmbAccountName.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cmbAccountName, "Please select a Account Name.")
        ElseIf cmbPaymentMethod.Text = "" Then
            ErrorProvider1.SetError(cmbPaymentMethod, "Please select a Account Name.")
        ElseIf Not IsNumeric(txtAmount.Text) Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(txtAmount, "Mandatory field.")
        Else
            ErrorProvider1.Clear()
            If btnSave.Text = "SAVE" Then
                ExecuteSQLQuery(" INSERT INTO  Voucher (CHART_OF_ACCOUNT_ID, DateOfVoucher, ReferenceNumber, Remark, Amount, PaymentMethod) VALUES " &
                                " (" & cmbAccountName.SelectedValue & ", '" & Format(dtpDateOfVoucher.Value, "MM/dd/yyyy") & "', '" + str_repl(txtReferenceNumber.Text) + "', '" + str_repl(txtRemark.Text) + "', " & txtAmount.Text & ", '" + str_repl(cmbPaymentMethod.Text) + "') ")
            ElseIf btnSave.Text = "UPDATE" Then
                ExecuteSQLQuery(" UPDATE  Voucher SET  DateOfVoucher='" & Format(dtpDateOfVoucher.Value, "MM/dd/yyyy") & "', PaymentMethod='" + str_repl(cmbPaymentMethod.Text) + "', ReferenceNumber='" + str_repl(txtReferenceNumber.Text) + "'," &
                                " Remark='" + str_repl(txtRemark.Text) + "', Amount=" & txtAmount.Text & ", CHART_OF_ACCOUNT_ID=" & cmbAccountName.SelectedValue & "   WHERE        (VOUCHER_ID = " & txtVoucherID.Text & ") ")
            End If
            btnReset.PerformClick()
            MsgBox("Record has been saved successfully.", MsgBoxStyle.Information, "Information")
        End If
    End Sub

    Private Sub frmVoucher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
    End Sub
End Class