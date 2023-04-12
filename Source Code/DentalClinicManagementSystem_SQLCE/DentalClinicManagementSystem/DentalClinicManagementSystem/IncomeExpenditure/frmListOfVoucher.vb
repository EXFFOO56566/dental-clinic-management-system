Public Class frmListOfVoucher
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub LoadVoucher()
        sqlSTR = " SELECT        Voucher.VOUCHER_ID, Voucher.DateOfVoucher, Voucher.PaymentMethod, ChartOfAccounts.AccountsName, ChartOfAccounts.AccountsType,  " &
                 " Voucher.ReferenceNumber, Voucher.Remark, Voucher.Amount FROM            Voucher LEFT OUTER JOIN " &
                 " ChartOfAccounts ON Voucher.CHART_OF_ACCOUNT_ID = ChartOfAccounts.CHART_OF_ACCOUNT_ID "
        FillDataGrid(sqlSTR, DataGridView1)
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            lblCount.Text = sqlDT.Rows.Count.ToString & " Record Found."
        Else
            lblCount.Text = "No Record Found."
        End If
    End Sub

    Private Sub frmListOfVoucher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
        LoadVoucher()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadVoucher()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        sqlSTR = " SELECT        Voucher.VOUCHER_ID, Voucher.DateOfVoucher, Voucher.PaymentMethod, ChartOfAccounts.AccountsName, ChartOfAccounts.AccountsType,  " &
                 " Voucher.ReferenceNumber, Voucher.Remark, Voucher.Amount FROM            Voucher LEFT OUTER JOIN " &
                 " ChartOfAccounts ON Voucher.CHART_OF_ACCOUNT_ID = ChartOfAccounts.CHART_OF_ACCOUNT_ID " &
                 " WHERE        (Voucher.DateOfVoucher >= '" & Format(dtpDateFrom.Value, "MM/dd/yyyy") & "' AND Voucher.DateOfVoucher <= '" & Format(dtpDateTo.Value, "MM/dd/yyyy") & "') "
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
                With frmVoucher
                    .MdiParent = frmMDIParent
                    .Show()
                    sqlSTR = " SELECT * FROM Voucher WHERE  VOUCHER_ID =" & DataGridView1.CurrentRow.Cells(3).Value & " "
                    ExecuteSQLQuery(sqlSTR)
                    Dim CHART_OF_ACCOUNT_ID As Double = sqlDT.Rows(0)("CHART_OF_ACCOUNT_ID")
                    ExecuteSQLQuery("SELECT *  FROM   ChartOfAccounts  WHERE   (CHART_OF_ACCOUNT_ID = " & CHART_OF_ACCOUNT_ID & ")")
                    If sqlDT.Rows(0)("AccountsType") = "Revenue" Then
                        .rbRevenue.Checked = True
                    Else
                        .rbExpense.Checked = True
                    End If
                    ExecuteSQLQuery(sqlSTR)
                    If sqlDT.Rows.Count > 0 Then
                        .txtVoucherID.Text = sqlDT.Rows(0)("VOUCHER_ID")
                        .txtAmount.Text = sqlDT.Rows(0)("Amount")
                        .txtReferenceNumber.Text = sqlDT.Rows(0)("ReferenceNumber")
                        .txtRemark.Text = sqlDT.Rows(0)("Remark")
                        .dtpDateOfVoucher.Value = sqlDT.Rows(0)("DateOfVoucher")
                        .cmbPaymentMethod.Text = sqlDT.Rows(0)("PaymentMethod")
                        .cmbAccountName.SelectedValue = sqlDT.Rows(0)("CHART_OF_ACCOUNT_ID")
                        .btnSave.Text = "UPDATE"
                    End If
                End With
            End If
        ElseIf e.ColumnIndex = 1 Then
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                ExecuteSQLQuery("DELETE FROM Voucher WHERE  VOUCHER_ID =" & DataGridView1.CurrentRow.Cells(3).Value & " ")
                LoadVoucher()
                MsgBox("Record deleted successfully.", MsgBoxStyle.Information, "Information")
            End If
        ElseIf e.ColumnIndex = 2 Then
            If MsgBox("Are you sure you want to print view this voucher?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                Voucher_View(" SELECT        Voucher.VOUCHER_ID, Voucher.CHART_OF_ACCOUNT_ID, ChartOfAccounts.AccountsName, ChartOfAccounts.AccountsType, ChartOfAccounts.AcStatus, Voucher.DateOfVoucher, Voucher.ReferenceNumber, Voucher.Remark,  " &
                             " Voucher.Amount, Voucher.PaymentMethod FROM    Voucher LEFT OUTER JOIN  ChartOfAccounts ON Voucher.CHART_OF_ACCOUNT_ID = ChartOfAccounts.CHART_OF_ACCOUNT_ID WHERE        (Voucher.VOUCHER_ID = " & DataGridView1.CurrentRow.Cells(3).Value & ") ")
            End If
        End If
    End Sub
End Class