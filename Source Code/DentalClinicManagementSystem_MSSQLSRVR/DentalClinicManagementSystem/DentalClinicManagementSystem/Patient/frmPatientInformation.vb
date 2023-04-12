Imports System.IO
Public Class frmPatientInformation
    Dim fileExtension As String = ".png"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lnkBrowse_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkBrowse.LinkClicked
        OpenFileDialog1.Title = "Browse Image"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Image Files |*.jpg;*.jpeg;*.gif;*.bmp;*.png;"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PatientImage.ImageLocation = OpenFileDialog1.FileName
            fileExtension = Path.GetExtension(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub frmPatientInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtAddress.Text = ""
        txtAge.Text = ""
        txtContactNo.Text = ""
        txtOccupation.Text = ""
        txtParentNames.Text = ""
        txtPatientID.Text = ""
        txtPatientName.Text = ""
        txtReference.Text = ""
        dtpDateOfEnroll.Value = Now
        cmbGender.Text = ""
        btnSave.Text = "SAVE"
        fileExtension = ".png"
        OpenFileDialog1.FileName = ""
        PatientImage.Image = DentalClinicManagementSystem.My.Resources.no_images
    End Sub
    Private Sub UploadPatientImages(ByVal PATIENT_ID As Double)
        Dim DestPath As String = Application.StartupPath + "\Upload\Patient\"
        If Not Directory.Exists(DestPath) Then
            Directory.CreateDirectory(DestPath)
        End If
        System.IO.File.Delete(DestPath + "\" + PATIENT_ID.ToString + fileExtension)
        Dim ImageFileName As String = DestPath + "\" + OpenFileDialog1.SafeFileName
        PatientImage.Image.Save(ImageFileName, System.Drawing.Imaging.ImageFormat.Png)
        System.IO.File.Move(DestPath + "\" + OpenFileDialog1.SafeFileName, DestPath + "\" + PATIENT_ID.ToString + fileExtension)
        ExecuteSQLQuery(" UPDATE PatientInformation SET Photo_File_Name='" + (PATIENT_ID.ToString + fileExtension) + "'  WHERE Patient_ID=" & PATIENT_ID & " ")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtPatientName.Text = "" Or cmbGender.Text = "" Or txtContactNo.Text = "" Then
            ErrorProvider1.SetError(txtPatientName, "Mandatory field.")
            ErrorProvider1.SetError(cmbGender, "Mandatory field.")
            ErrorProvider1.SetError(txtContactNo, "Mandatory field.")
        Else
            ErrorProvider1.Clear()
            If btnSave.Text = "SAVE" Then
                ExecuteSQLQuery(" INSERT INTO  PatientInformation (PatientName, ParentNames, Gender, Age, Occupation, Address, ContactNo, Reference, DateOfEnroll) VALUES " &
                                " ('" + str_repl(txtPatientName.Text) + "', '" + str_repl(txtParentNames.Text) + "', '" + str_repl(cmbGender.Text) + "', '" + str_repl(txtAge.Text) + "',  " &
                                " '" + str_repl(txtOccupation.Text) + "', '" + str_repl(txtAddress.Text) + "', '" + str_repl(txtContactNo.Text) + "', '" + str_repl(txtReference.Text) + "', '" & Format(dtpDateOfEnroll.Value, "MM/dd/yyyy") & "')   ")
                ExecuteSQLQuery("SELECT  Patient_ID FROM     PatientInformation  ORDER BY Patient_ID DESC")
                Dim PATIENT_ID As Double = sqlDT.Rows(0)("Patient_ID")
                If Not OpenFileDialog1.FileName = "" Then
                    UploadPatientImages(PATIENT_ID)
                End If
            ElseIf btnSave.Text = "UPDATE" Then
                ExecuteSQLQuery(" UPDATE   PatientInformation SET PatientName='" + str_repl(txtPatientName.Text) + "', ParentNames='" + str_repl(txtParentNames.Text) + "', Gender='" + str_repl(cmbGender.Text) + "', Age='" + str_repl(txtAge.Text) + "',  " &
                                " Occupation='" + str_repl(txtOccupation.Text) + "', Address='" + str_repl(txtAddress.Text) + "', ContactNo='" + str_repl(txtContactNo.Text) + "', Reference='" + str_repl(txtReference.Text) + "', DateOfEnroll='" & Format(dtpDateOfEnroll.Value, "MM/dd/yyyy") & "' " &
                                " WHERE  Patient_ID=" & txtPatientID.Text & "  ")
                If Not OpenFileDialog1.FileName = "" Then
                    UploadPatientImages(txtPatientID.Text)
                End If
            End If
            btnSave.Text = "SAVE"
            btnReset.PerformClick()
            MsgBox("Record has been saved successfully.", MsgBoxStyle.Information, "Information")
        End If
    End Sub
End Class