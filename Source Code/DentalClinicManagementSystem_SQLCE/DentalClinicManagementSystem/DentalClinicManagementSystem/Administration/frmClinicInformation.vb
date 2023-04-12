Imports System.IO
Public Class frmClinicInformation
    Dim fileExtension As String = ".png"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmClinicInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If

        ExecuteSQLQuery("SELECT * FROM ClinicInformation")
        If sqlDT.Rows.Count > 0 Then
            txtClinicName.Text = sqlDT.Rows(0)("ClinicName")
            txtAddress.Text = sqlDT.Rows(0)("Address")
            txtPhone.Text = sqlDT.Rows(0)("Phone")
            txtReportHeader.Text = sqlDT.Rows(0)("ReportHeader")
            txtReportFooter.Text = sqlDT.Rows(0)("ReportFooter")
            Try
                ClinicLogo.ImageLocation = Application.StartupPath + "\Upload\Clinic\" + sqlDT.Rows(0)("Clinic_Logo")
            Catch ex As Exception
                ClinicLogo.Image = DentalClinicManagementSystem.My.Resources.no_images
            End Try
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtClinicName.Text = "" Or txtAddress.Text = "" Or txtPhone.Text = "" Then
            ErrorProvider1.SetError(txtClinicName, "Mandatory field.")
            ErrorProvider1.SetError(txtAddress, "Mandatory field.")
            ErrorProvider1.SetError(txtPhone, "Mandatory field.")
        Else
            ErrorProvider1.Clear()
            ExecuteSQLQuery("SELECT * FROM ClinicInformation")
            If sqlDT.Rows.Count > 0 Then
                ExecuteSQLQuery("UPDATE   ClinicInformation  SET ClinicName='" + str_repl(txtClinicName.Text) + "', Address='" + str_repl(txtAddress.Text) + "', Phone='" + str_repl(txtPhone.Text) + "', ReportHeader='" + str_repl(txtReportHeader.Text) + "', ReportFooter='" + str_repl(txtReportFooter.Text) + "' ")
                If Not OpenFileDialog1.FileName = "" Then
                    UploadClinicLogo()
                End If
                MsgBox("Record updated successful.", MsgBoxStyle.Information, "Information")
            Else
                ExecuteSQLQuery(" INSERT INTO ClinicInformation (ClinicName, Address, Phone, ReportHeader, ReportFooter) VALUES ('" + str_repl(txtClinicName.Text) + "', '" + str_repl(txtAddress.Text) + "', '" + str_repl(txtPhone.Text) + "', '" + str_repl(txtReportHeader.Text) + "', '" + str_repl(txtReportFooter.Text) + "')  ")
                If Not OpenFileDialog1.FileName = "" Then
                    UploadClinicLogo()
                End If
                MsgBox("New record has been added on database successfully.", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub
    Private Sub UploadClinicLogo()
        Dim DestPath As String = Application.StartupPath + "\Upload\Clinic\"
        If Not Directory.Exists(DestPath) Then
            Directory.CreateDirectory(DestPath)
        End If
        System.IO.File.Delete(DestPath + "\" + "company_logo" + fileExtension)
        Dim ImageFileName As String = DestPath + "\" + OpenFileDialog1.SafeFileName
        ClinicLogo.Image.Save(ImageFileName, System.Drawing.Imaging.ImageFormat.Png)
        System.IO.File.Move(DestPath + "\" + OpenFileDialog1.SafeFileName, DestPath + "\" + "company_logo" + fileExtension)
        ExecuteSQLQuery(" UPDATE ClinicInformation SET Clinic_Logo='" + ("company_logo" + fileExtension) + "' ")
    End Sub
    Private Sub lnkBrowse_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkBrowse.LinkClicked
        OpenFileDialog1.Title = "Browse image"
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.gif;*.bmp;*.png;"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ClinicLogo.ImageLocation = OpenFileDialog1.FileName
            fileExtension = Path.GetExtension(OpenFileDialog1.FileName)
        End If
    End Sub
End Class