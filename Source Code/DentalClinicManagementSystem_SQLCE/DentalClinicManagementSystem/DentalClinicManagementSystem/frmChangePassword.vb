Public Class frmChangePassword
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtCurrentPassword.Text = "" Then
            ErrorProvider1.SetError(txtCurrentPassword, "Mandatory field.")
        ElseIf txtNewPassword.Text = "" Then
            ErrorProvider2.SetError(txtNewPassword, "Mandatory field.")
            ErrorProvider1.Clear()
        ElseIf txtRePassword.Text = "" Then
            ErrorProvider2.Clear()
            ErrorProvider3.SetError(txtRePassword, "Mandatory field.")
        ElseIf Not (txtNewPassword.Text = txtRePassword.Text) Then
            ErrorProvider1.Clear()
            ErrorProvider2.SetError(txtNewPassword, "Mandatory field.")
            ErrorProvider3.SetError(txtRePassword, "Mandatory field.")
        Else
            ErrorProvider1.Clear()
            ErrorProvider2.Clear()
            ErrorProvider3.Clear()
            ExecuteSQLQuery("SELECT  *  FROM   ApplicationUsers  WHERE    (UserID = " & xUser_ID & ") AND (Password = '" & str_repl(txtCurrentPassword.Text) & "')")
            If sqlDT.Rows.Count > 0 Then
                Dim msg As String
                msg = "Would you like to change this password?"
                If MsgBox(msg, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Question...") = MsgBoxResult.Yes Then
                    ExecuteSQLQuery(" UPDATE  ApplicationUsers SET Password = '" & str_repl(txtRePassword.Text) & "' WHERE   UserID = " & xUser_ID & "")
                    MsgBox("Password updated successful.", MsgBoxStyle.Information, "Information")
                    Me.Close()
                End If
            Else
                MsgBox("Sorry! Current password does not match.", MsgBoxStyle.Critical, "Critical")
            End If
        End If
    End Sub

    Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
    End Sub
End Class