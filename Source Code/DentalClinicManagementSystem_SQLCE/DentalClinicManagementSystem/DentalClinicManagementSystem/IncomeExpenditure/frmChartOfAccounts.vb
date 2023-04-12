Public Class frmChartOfAccounts
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtAcID.Text = ""
        txtAccountName.Text = ""
        cmbAccountType.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        btnSave.Text = "SAVE"
        LoadAccounts()
    End Sub
    Private Sub LoadAccounts()
        sqlSTR = " SELECT        CHART_OF_ACCOUNT_ID, AccountsName, AccountsType, AcStatus FROM            ChartOfAccounts "
        FillDataGrid(sqlSTR, DataGridView1)
    End Sub

    Private Sub frmChartOfAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
        LoadAccounts()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtAccountName.Text = "" Or cmbStatus.Text = "" Or cmbAccountType.Text = "" Then
            ErrorProvider1.SetError(txtAccountName, "Mandatory field.")
            ErrorProvider1.SetError(cmbStatus, "Mandatory field.")
            ErrorProvider1.SetError(cmbAccountType, "Mandatory field.")
        Else
            ErrorProvider1.Clear()
            If btnSave.Text = "SAVE" Then
                ExecuteSQLQuery("INSERT INTO ChartOfAccounts (AccountsName, AccountsType, AcStatus) VALUES ('" + str_repl(txtAccountName.Text) + "', '" + str_repl(cmbAccountType.Text) + "', '" + str_repl(cmbStatus.Text) + "') ")
            ElseIf btnSave.Text = "UPDATE" Then
                ExecuteSQLQuery(" UPDATE ChartOfAccounts SET AccountsName='" + str_repl(txtAccountName.Text) + "', AccountsType='" + str_repl(cmbAccountType.Text) + "', AcStatus= '" + str_repl(cmbStatus.Text) + "'  WHERE        (CHART_OF_ACCOUNT_ID = " & txtAcID.Text & ") ")
            End If
            btnReset.PerformClick()
            MsgBox("Record has been saved successfully.", MsgBoxStyle.Information, "Information")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 Then
            If MsgBox("Are you sure you want to edit this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                ExecuteSQLQuery(" SELECT * FROM ChartOfAccounts WHERE  CHART_OF_ACCOUNT_ID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                If sqlDT.Rows.Count > 0 Then
                    txtAcID.Text = sqlDT.Rows(0)("CHART_OF_ACCOUNT_ID")
                    txtAccountName.Text = sqlDT.Rows(0)("AccountsName")
                    cmbAccountType.Text = sqlDT.Rows(0)("AccountsType")
                    cmbStatus.Text = sqlDT.Rows(0)("AcStatus")
                    btnSave.Text = "UPDATE"
                End If
            End If
        ElseIf e.ColumnIndex = 1 Then
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                ExecuteSQLQuery("DELETE FROM ChartOfAccounts WHERE  CHART_OF_ACCOUNT_ID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                LoadAccounts()
                MsgBox("Record deleted successfully.", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub
End Class