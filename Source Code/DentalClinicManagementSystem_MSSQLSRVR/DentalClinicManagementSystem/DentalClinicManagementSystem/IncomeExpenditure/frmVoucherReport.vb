Public Class frmVoucherReport
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmVoucherReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
        FillComboBox("SELECT  CHART_OF_ACCOUNT_ID, AccountsName  FROM   ChartOfAccounts ", "CHART_OF_ACCOUNT_ID", "AccountsName", cmbAccountName)
    End Sub

    Private Sub btnPrintView_Click(sender As Object, e As EventArgs) Handles btnPrintView.Click
        Dim SharedParameters As String
        If RadioButton1.Checked = True Then
            SharedParameters = Format(dtpDateFrom.Value, "dd-MMM-yyyy") & " - " & Format(dtpDateTo.Value, "dd-MMM-yyyy")
            Voucher_List_View(" SELECT        Voucher.VOUCHER_ID, Voucher.CHART_OF_ACCOUNT_ID, ChartOfAccounts.AccountsName, ChartOfAccounts.AccountsType, ChartOfAccounts.AcStatus, Voucher.DateOfVoucher,  " &
                              " Voucher.ReferenceNumber, Voucher.Remark,  Voucher.Amount, Voucher.PaymentMethod FROM            Voucher LEFT OUTER JOIN " &
                              " ChartOfAccounts ON Voucher.CHART_OF_ACCOUNT_ID = ChartOfAccounts.CHART_OF_ACCOUNT_ID WHERE        (Voucher.DateOfVoucher >= '" & Format(dtpDateFrom.Value, "MM/dd/yyyy") & "' AND Voucher.DateOfVoucher <= '" & Format(dtpDateTo.Value, "MM/dd/yyyy") & "') ", SharedParameters)
        ElseIf RadioButton2.Checked = True Then
            If cmbAccountName.SelectedValue Is Nothing Or cmbAccountName.SelectedIndex = -1 Then
                ErrorProvider1.SetError(cmbAccountName, "Please select a Account Name.")
            Else
                ErrorProvider1.Clear()
                SharedParameters = cmbAccountName.Text & " - " & Format(dtpDateFrom.Value, "dd-MMM-yyyy") & " - " & Format(dtpDateTo.Value, "dd-MMM-yyyy")
                Voucher_List_View(" SELECT        Voucher.VOUCHER_ID, Voucher.CHART_OF_ACCOUNT_ID, ChartOfAccounts.AccountsName, ChartOfAccounts.AccountsType, ChartOfAccounts.AcStatus, Voucher.DateOfVoucher,  " &
                                  " Voucher.ReferenceNumber, Voucher.Remark,  Voucher.Amount, Voucher.PaymentMethod FROM            Voucher LEFT OUTER JOIN " &
                                  " ChartOfAccounts ON Voucher.CHART_OF_ACCOUNT_ID = ChartOfAccounts.CHART_OF_ACCOUNT_ID WHERE        (Voucher.DateOfVoucher >= '" & Format(dtpDateFrom.Value, "MM/dd/yyyy") & "' AND Voucher.DateOfVoucher <= '" & Format(dtpDateTo.Value, "MM/dd/yyyy") & "') " &
                                  " AND (Voucher.CHART_OF_ACCOUNT_ID = " & cmbAccountName.SelectedValue & ") ", SharedParameters)
            End If
        End If
    End Sub
End Class