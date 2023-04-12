Imports System.Net
Imports System.Net.Sockets
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Public Class frmMDIParent
    Private m_ChildFormNumber As Integer
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        Dim ChildForm As New System.Windows.Forms.Form
        ChildForm.MdiParent = Me
        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber
        ChildForm.Show()
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
    Private Sub frmMDIParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializingDatabaseConnection()
        tsslCapsLock.Enabled = My.Computer.Keyboard.CapsLock
        tsslNumLock.Enabled = My.Computer.Keyboard.NumLock
        tsslScrollLock.Enabled = My.Computer.Keyboard.ScrollLock
        Dim xEntry As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(Dns.GetHostName)
        Dim ipAddr As Net.IPAddress() = xEntry.AddressList
        tsslIP.Text = "IP :" + ipAddr(0).ToString()
        tsslVersion.Text = "Version Number: " & Me.GetType.Assembly.GetName.Version.ToString
        LoadUserInformation()
        User_Image.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub LoadUserInformation()
        ExecuteSQLQuery("SELECT   *  FROM     ApplicationUsers  WHERE   (UserID = " & xUser_ID & ")")
        If sqlDT.Rows.Count > 0 Then
            lblUserFullName.Text = sqlDT.Rows(0)("FullName")
            lblRegistrationDate.Text = sqlDT.Rows(0)("UserType")
            Try
                MakeRoundedImage(Image.FromFile(Application.StartupPath + "\Upload\Users\" + sqlDT.Rows(0)("Photo_File_Name")), User_Image)
            Catch ex As Exception
                User_Image.Image = DentalClinicManagementSystem.My.Resources.User_nulled
            End Try
        Else
            User_Image.Image = DentalClinicManagementSystem.My.Resources.User_nulled
        End If
    End Sub
    Private Sub frmMDIParent_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.CapsLock
                tsslCapsLock.Enabled = Not tsslCapsLock.Enabled
            Case Keys.NumLock
                tsslNumLock.Enabled = Not tsslNumLock.Enabled
            Case Keys.Scroll
                tsslScrollLock.Enabled = Not tsslScrollLock.Enabled
        End Select
    End Sub
    Private Sub MakeRoundedImage(ByVal Img As Image, ByVal PicBox As PictureBox)
        Using bm As New Bitmap(Img.Width, Img.Height)
            Using grx2 As Graphics = Graphics.FromImage(bm)
                grx2.SmoothingMode = SmoothingMode.AntiAlias
                Using tb As New TextureBrush(Img)
                    tb.TranslateTransform(0, 0)
                    Using gp As New GraphicsPath
                        gp.AddEllipse(0, 0, Img.Width, Img.Height)
                        grx2.FillPath(tb, gp)
                    End Using
                End Using
            End Using
            If PicBox.Image IsNot Nothing Then PicBox.Image.Dispose()
            PicBox.Image = New Bitmap(bm)
        End Using
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub btnPatient_Click(sender As Object, e As EventArgs) Handles btnPatient.Click
        cmsPatient.Show(btnPatient, New Point(218, 0))
    End Sub

    Private Sub AtientInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtientInformationToolStripMenuItem.Click
        frmPatientInformation.MdiParent = Me
        frmPatientInformation.Show()
    End Sub

    Private Sub ListOfPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfPatientToolStripMenuItem.Click
        frmListOfPatient.MdiParent = Me
        frmListOfPatient.Show()
    End Sub

    Private Sub btnAdministration_Click(sender As Object, e As EventArgs) Handles btnAdministration.Click
        cmsAdministration.Show(btnAdministration, New Point(218, 0))
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        frmClinicInformation.MdiParent = Me
        frmClinicInformation.Show()
    End Sub

    Private Sub UserInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserInformationToolStripMenuItem.Click
        frmUserInformation.MdiParent = Me
        frmUserInformation.Show()
    End Sub

    Private Sub ListOfUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfUsersToolStripMenuItem.Click
        frmListOfUsers.MdiParent = Me
        frmListOfUsers.Show()
    End Sub

    Private Sub PermissionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermissionToolStripMenuItem.Click
        frmPermission.MdiParent = Me
        frmPermission.Show()
    End Sub

    Private Sub frmMDIParent_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

    Private Sub btnMedicine_Click(sender As Object, e As EventArgs) Handles btnMedicine.Click
        cmbPharmacy.Show(btnMedicine, New Point(218, 0))
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        frmSalesReport.MdiParent = Me
        frmSalesReport.Show()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        frmSales.MdiParent = Me
        frmSales.Show()
    End Sub

    Private Sub ProductListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductListToolStripMenuItem.Click
        frmProductList.MdiParent = Me
        frmProductList.Show()
    End Sub

    Private Sub ProductInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductInformationToolStripMenuItem.Click
        frmProductInformation.MdiParent = Me
        frmProductInformation.Show()
    End Sub

    Private Sub btnDoctor_Click(sender As Object, e As EventArgs) Handles btnDoctor.Click
        csmDoctor.Show(btnDoctor, New Point(218, 0))
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        frmPhysiciansInformation.MdiParent = Me
        frmPhysiciansInformation.Show()
    End Sub

    Private Sub ListOfDoctorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfDoctorsToolStripMenuItem.Click
        frmListOfPhysician.MdiParent = Me
        frmListOfPhysician.Show()
    End Sub

    Private Sub btnPrescription_Click(sender As Object, e As EventArgs) Handles btnPrescription.Click
        cmsPrescription.Show(btnPrescription, New Point(218, 0))
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        frmPrescription.MdiParent = Me
        frmPrescription.Show()
    End Sub

    Private Sub btnIncomeExpenditure_Click(sender As Object, e As EventArgs) Handles btnIncomeExpenditure.Click
        cmsIncomeExpenditure.Show(btnIncomeExpenditure, New Point(218, 0))
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        frmVoucher.MdiParent = Me
        frmVoucher.Show()
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        frmListOfVoucher.MdiParent = Me
        frmListOfVoucher.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem1.Click
        frmVoucherReport.MdiParent = Me
        frmVoucherReport.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        frmChangePassword.MdiParent = Me
        frmChangePassword.Show()
    End Sub

    Private Sub btnTreatment_Click(sender As Object, e As EventArgs) Handles btnTreatment.Click
        cmsTreatment.Show(btnTreatment, New Point(218, 0))
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
        frmDentalScreen.MdiParent = Me
        frmDentalScreen.Show()
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click
        frmPatientVisitList.MdiParent = Me
        frmPatientVisitList.Show()
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        frmPrescriptionList.MdiParent = Me
        frmPrescriptionList.Show()
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        frmTreatmentReport.MdiParent = Me
        frmTreatmentReport.Show()
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOffToolStripMenuItem.Click
        frmAuthentication.Show()
        Me.Hide()
    End Sub
End Class
