Public Class frmListOfUsers


    Private Sub LoadUsersData()
        sqlSTR = "SELECT  UserID, FullName, UserName, ContactNo, UserType, Designation ,JoiningDate, RegistrationDate, LastLogonDateTime  FROM      ApplicationUsers "
        FillDataGrid(sqlSTR, DataGridView1)
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            lblCount.Text = sqlDT.Rows.Count.ToString & " Record Found."
        Else
            lblCount.Text = "No Record Found."
        End If
    End Sub

    Private Sub frmListOfUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
        LoadUsersData()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadUsersData()
    End Sub

    Private Sub txtCriteria_TextChanged(sender As Object, e As EventArgs) Handles txtCriteria.TextChanged
        If cmbParameter.Text = "" Then
            ErrorProvider1.SetError(cmbParameter, "Mandatory field.")
            LoadUsersData()
        ElseIf txtCriteria.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider2.SetError(txtCriteria, "Mandatory field.")
            LoadUsersData()
        Else
            ErrorProvider1.Clear()
            ErrorProvider2.Clear()
            sqlSTR = " SELECT  UserID, FullName, UserName, ContactNo, UserType, Designation ,JoiningDate,  " &
                     " RegistrationDate, LastLogonDateTime  FROM      ApplicationUsers  " &
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 Then
            If MsgBox("Are you sure you want to edit this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                With frmUserInformation
                    .MdiParent = frmMDIParent
                    .Show()
                    ExecuteSQLQuery(" SELECT * FROM ApplicationUsers WHERE  UserID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                    If sqlDT.Rows.Count > 0 Then
                        .txtContactNo.Text = sqlDT.Rows(0)("ContactNo")
                        .txtDesignation.Text = sqlDT.Rows(0)("Designation")
                        .txtFullName.Text = sqlDT.Rows(0)("FullName")
                        .txtPassword.Text = sqlDT.Rows(0)("Password")
                        .txtRePassword.Text = sqlDT.Rows(0)("Password")
                        .txtUserID.Text = sqlDT.Rows(0)("UserID")
                        .txtUserName.Text = sqlDT.Rows(0)("UserName")
                        .txtUserName.Enabled = False
                        .dtpJoiningDate.Value = sqlDT.Rows(0)("JoiningDate")
                        .cmbUserType.Text = sqlDT.Rows(0)("UserType")
                        Try
                            .UserImage.ImageLocation = Application.StartupPath + "\Upload\Users\" + sqlDT.Rows(0)("Photo_File_Name")
                        Catch ex As Exception

                        End Try
                        .btnSave.Text = "UPDATE"
                    End If
                End With
            End If
        ElseIf e.ColumnIndex = 1 Then
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                ExecuteSQLQuery("DELETE FROM PatientInformation WHERE  Patient_ID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                LoadUsersData()
                MsgBox("Record deleted successfully.", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub
End Class