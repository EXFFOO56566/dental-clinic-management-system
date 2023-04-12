Imports System.IO
Public Class frmUserInformation
    Dim fileExtension As String = ".png"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtContactNo.Text = ""
        txtDesignation.Text = ""
        txtFullName.Text = ""
        txtPassword.Text = ""
        txtRePassword.Text = ""
        txtUserID.Text = ""
        txtUserName.Text = ""
        txtUserName.Enabled = True
        dtpJoiningDate.Value = Now
        cmbUserType.Text = ""
        btnSave.Text = "SAVE"
        fileExtension = ".png"
        OpenFileDialog1.FileName = ""
        UserImage.Image = DentalClinicManagementSystem.My.Resources.no_images
    End Sub

    Private Sub lnkBrowse_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkBrowse.LinkClicked
        OpenFileDialog1.Title = "Browse Image"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Image Files |*.jpg;*.jpeg;*.gif;*.bmp;*.png;"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            UserImage.ImageLocation = OpenFileDialog1.FileName
            fileExtension = Path.GetExtension(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub UploadUserImages(ByVal USER_ID As Double)
        Dim DestPath As String = Application.StartupPath + "\Upload\Users\"
        If Not Directory.Exists(DestPath) Then
            Directory.CreateDirectory(DestPath)
        End If
        System.IO.File.Delete(DestPath + "\" + USER_ID.ToString + fileExtension)
        Dim ImageFileName As String = DestPath + "\" + OpenFileDialog1.SafeFileName
        UserImage.Image.Save(ImageFileName, System.Drawing.Imaging.ImageFormat.Png)
        System.IO.File.Move(DestPath + "\" + OpenFileDialog1.SafeFileName, DestPath + "\" + USER_ID.ToString + fileExtension)
        ExecuteSQLQuery(" UPDATE ApplicationUsers SET Photo_File_Name='" + (USER_ID.ToString + fileExtension) + "'  WHERE UserID=" & USER_ID & " ")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtFullName.Text = "" Or txtUserName.Text = "" Or txtPassword.Text = "" Or txtRePassword.Text = "" Or cmbUserType.Text = "" Or txtContactNo.Text = "" Then
            ErrorProvider1.SetError(txtFullName, "Mandatory")
            ErrorProvider1.SetError(txtUserName, "Mandatory")
            ErrorProvider1.SetError(txtPassword, "Mandatory")
            ErrorProvider1.SetError(cmbUserType, "Mandatory")
            ErrorProvider1.SetError(txtRePassword, "Mandatory")
            ErrorProvider1.SetError(txtContactNo, "Mandatory")
        ElseIf Not txtPassword.Text = txtRePassword.Text Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(txtPassword, "Password does not match.")
            ErrorProvider1.SetError(txtRePassword, "Password does not match.")
        Else
            If btnSave.Text = "SAVE" Then
                ErrorProvider1.Clear()
                ExecuteSQLQuery("SELECT *  FROM   ApplicationUsers  WHERE  (UserName = '" + str_repl(txtUserName.Text) + "')")
                If sqlDT.Rows.Count > 0 Then
                    ErrorProvider1.SetError(txtUserName, "The username already exists.")
                    MsgBox("The username already exists. Please use a different username.", MsgBoxStyle.Critical, "Critical")
                Else
                    ErrorProvider1.Clear()
                    ExecuteSQLQuery(" INSERT INTO ApplicationUsers (FullName, UserName, Password, Designation, ContactNo, UserType, JoiningDate, RegistrationDate, LastLogonDateTime) VALUES " &
                                    " ('" + str_repl(txtFullName.Text) + "', '" + str_repl(txtUserName.Text) + "', '" + str_repl(txtPassword.Text) + "', '" + str_repl(txtDesignation.Text) + "',  " &
                                    " '" + str_repl(txtContactNo.Text) + "', '" + str_repl(cmbUserType.Text) + "', '" & Format(dtpJoiningDate.Value, "MM/dd/yyyy") & "', '" & Format(Now, "MM/dd/yyyy") & "', '" & Format(Now, "MM/dd/yyyy h:mm:ss") & "') ")
                    ExecuteSQLQuery("SELECT  UserID FROM     ApplicationUsers  ORDER BY UserID DESC")
                    Dim USER_ID As Double = sqlDT.Rows(0)("UserID")
                    If Not OpenFileDialog1.FileName = "" Then
                        UploadUserImages(USER_ID)
                    End If
                    btnReset.PerformClick()
                    MsgBox("Record has been saved successfully.", MsgBoxStyle.Information, "Information")
                End If
            ElseIf btnSave.Text = "UPDATE" Then
                ErrorProvider1.Clear()
                ExecuteSQLQuery(" UPDATE  ApplicationUsers SET FullName='" + str_repl(txtFullName.Text) + "', Password='" + str_repl(txtPassword.Text) + "', Designation='" + str_repl(txtDesignation.Text) + "', " &
                                " ContactNo='" + str_repl(txtContactNo.Text) + "', UserType='" + str_repl(cmbUserType.Text) + "', JoiningDate = '" & Format(dtpJoiningDate.Value, "MM/dd/yyyy") & "'  WHERE   (UserID = " & txtUserID.Text & ") ")
                If Not OpenFileDialog1.FileName = "" Then
                    UploadUserImages(txtUserID.Text)
                End If
                btnReset.PerformClick()
                MsgBox("Record has been saved successfully.", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub

    Private Sub frmUserInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
    End Sub
End Class