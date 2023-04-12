Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient
Module modUtilities
    Public sqlDT As New DataTable
    Public CnString As String = My.Settings.DB_CN_NODE
    Public xUser_ID As Integer
    Public xUserName As String
    Public xUserPassword As String
    Public sqlSTR As String
    Private param_clinic_name As String
    Private param_clinic_phone As String
    Private param_clinic_address As String
    Private param_clinic_reportheader As String
    Private param_clinic_reportfooter As String
    Private param_clinic_logo As String
    Public Function InitializingDatabaseConnection() As Boolean
        Try
            Dim sqlCon As New SqlConnection
            sqlCon.ConnectionString = CnString
            sqlCon.Open()
            InitializingDatabaseConnection = True
            sqlCon.Close()
        Catch ex As Exception
            InitializingDatabaseConnection = False
            MessageBox.Show("Error : " & ex.Message, "Important Note...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Public Function CheckPermission(ByVal frmName As String) As Boolean
        Dim PermisReturnValue = False
        ExecuteSQLQuery("SELECT  *  FROM  UserPermission   WHERE   (FormName = '" & frmName & "') AND (UserID = '" & num_fltr(xUser_ID) & "') AND (Active = 1)")
        If sqlDT.Rows.Count > 0 Then
            PermisReturnValue = True
        Else
            PermisReturnValue = False
        End If
        Return PermisReturnValue
    End Function
    Public Function str_repl(ByVal str As String)
        Return Replace(Replace(Replace(str, "'", ""), ",", ","), "+", "")
    End Function
    Public Function num_fltr(ByVal value As String)
        If Not IsNumeric(value) Then
            Return 0
        Else
            Return value
        End If
    End Function
    Public Function ExecuteSQLQuery(ByVal SQLQuery As String) As DataTable
        Try
            Dim sqlCon As New SqlConnection(CnString)
            Dim sqlDA As New SqlDataAdapter(SQLQuery, sqlCon)
            Dim sqlCB As New SqlCommandBuilder(sqlDA)
            sqlDT.Reset()
            sqlDA.Fill(sqlDT)
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
        Return sqlDT
    End Function
    Public Sub FillDataGrid(ByVal sql As String, ByVal dgv As DataGridView)
        Dim conn As SqlConnection = New SqlConnection(CnString)
        Try
            conn.Open()
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)
            Dim adp As New SqlDataAdapter
            Dim dt As New DataTable
            adp.SelectCommand = cmd
            adp.Fill(dt)
            dgv.DataSource = dt
            adp.Dispose()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub FillComboBox(ByVal sql As String, ByVal Value_Member As String, ByVal Display_Member As String, ByVal combo As ComboBox)
        Dim dt As DataTable = New DataTable
        Using connection = New SqlConnection(CnString)
            Using cmd = New SqlCommand(sql, connection)
                connection.Open()
                Try
                    dt.Load(cmd.ExecuteReader)
                Catch e As SqlException
                    MessageBox.Show(" Error : " & e.ToString)
                End Try
            End Using
        End Using
        combo.DataSource = dt
        combo.ValueMember = Value_Member
        combo.DisplayMember = Display_Member
    End Sub

    'Microsoft Report Viewer 
    Public Sub LoadClinicInformation()
        ExecuteSQLQuery("SELECT  *  FROM  ClinicInformation")
        If sqlDT.Rows.Count > 0 Then
            param_clinic_name = sqlDT.Rows(0)("ClinicName")
            param_clinic_phone = sqlDT.Rows(0)("Phone")
            param_clinic_address = sqlDT.Rows(0)("Address")
            param_clinic_reportheader = sqlDT.Rows(0)("ReportHeader")
            param_clinic_reportfooter = sqlDT.Rows(0)("ReportFooter")
            param_clinic_logo = sqlDT.Rows(0)("Clinic_Logo")
        Else
            param_clinic_name = "Clinic Name"
            param_clinic_phone = "Phone"
            param_clinic_address = "Address"
            param_clinic_reportheader = "Report Header"
            param_clinic_reportfooter = "Report Footer"
            param_clinic_logo = "-"
        End If
    End Sub

    Public Sub Prescription_View(ByVal Sql As String)
        LoadClinicInformation()
        Dim frmReportViewer As New frmReportViewer
        Dim rptDataSource As New ReportDataSource
        Try
            With frmReportViewer.ReportViewer1.LocalReport
                .ReportPath = "Reports\Prescription.rdlc"
                .DataSources.Clear()
            End With
            Dim ds As New DentalClinicManagementSystem.dsDentalClinic
            Dim da As SqlDataAdapter = New SqlDataAdapter()
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Sql, New SqlConnection(CnString))
            da = New SqlDataAdapter(cmd)
            da.Fill(ds.Prescription)
            Dim rparam_clinic_name As ReportParameter = New ReportParameter("ClinicName", param_clinic_name)
            Dim rparam_clinic_address As ReportParameter = New ReportParameter("Address", param_clinic_address)
            Dim rparam_clinic_phone As ReportParameter = New ReportParameter("Phone", param_clinic_phone)
            Dim rparam_clinic_reportheader As ReportParameter = New ReportParameter("ReceiptHeader", param_clinic_reportheader)
            Dim rparam_clinic_reportfooter As ReportParameter = New ReportParameter("ReceiptFooter", param_clinic_reportfooter)
            Dim rparam_clinic_logo As ReportParameter = New ReportParameter("ClinicLogoFile", "file:///" + Application.StartupPath + "\Upload\Clinic\" + param_clinic_logo)
            frmReportViewer.ReportViewer1.LocalReport.EnableExternalImages = True
            frmReportViewer.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {rparam_clinic_name, rparam_clinic_address, rparam_clinic_phone, rparam_clinic_reportheader, rparam_clinic_reportfooter, rparam_clinic_logo})
            rptDataSource = New ReportDataSource("Prescription", ds.Tables("Prescription"))
            frmReportViewer.ReportViewer1.LocalReport.DataSources.Add(rptDataSource)
            frmReportViewer.Show()
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        End Try
    End Sub

    Public Sub Voucher_View(ByVal Sql As String)
        LoadClinicInformation()
        Dim frmReportViewer As New frmReportViewer
        Dim rptDataSource As New ReportDataSource
        Try
            With frmReportViewer.ReportViewer1.LocalReport
                .ReportPath = "Reports\Voucher.rdlc"
                .DataSources.Clear()
            End With
            Dim ds As New DentalClinicManagementSystem.dsDentalClinic
            Dim da As SqlDataAdapter = New SqlDataAdapter()
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Sql, New SqlConnection(CnString))
            da = New SqlDataAdapter(cmd)
            da.Fill(ds.Voucher)
            Dim rparam_clinic_name As ReportParameter = New ReportParameter("ClinicName", param_clinic_name)
            Dim rparam_clinic_address As ReportParameter = New ReportParameter("Address", param_clinic_address)
            Dim rparam_clinic_phone As ReportParameter = New ReportParameter("Phone", param_clinic_phone)
            Dim rparam_clinic_reportheader As ReportParameter = New ReportParameter("ReceiptHeader", param_clinic_reportheader)
            Dim rparam_clinic_reportfooter As ReportParameter = New ReportParameter("ReceiptFooter", param_clinic_reportfooter)
            Dim rparam_clinic_logo As ReportParameter = New ReportParameter("ClinicLogoFile", "file:///" + Application.StartupPath + "\Upload\Clinic\" + param_clinic_logo)
            frmReportViewer.ReportViewer1.LocalReport.EnableExternalImages = True
            frmReportViewer.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {rparam_clinic_name, rparam_clinic_address, rparam_clinic_phone, rparam_clinic_reportheader, rparam_clinic_reportfooter, rparam_clinic_logo})
            rptDataSource = New ReportDataSource("Voucher", ds.Tables("Voucher"))
            frmReportViewer.ReportViewer1.LocalReport.DataSources.Add(rptDataSource)
            frmReportViewer.Show()
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        End Try
    End Sub
    Public Sub Voucher_List_View(ByVal Sql As String, ByVal SharedParam As String)
        LoadClinicInformation()
        Dim frmReportViewer As New frmReportViewer
        Dim rptDataSource As New ReportDataSource
        Try
            With frmReportViewer.ReportViewer1.LocalReport
                .ReportPath = "Reports\VoucherList.rdlc"
                .DataSources.Clear()
            End With
            Dim ds As New DentalClinicManagementSystem.dsDentalClinic
            Dim da As SqlDataAdapter = New SqlDataAdapter()
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Sql, New SqlConnection(CnString))
            da = New SqlDataAdapter(cmd)
            da.Fill(ds.Voucher)
            Dim rparam_clinic_name As ReportParameter = New ReportParameter("ClinicName", param_clinic_name)
            Dim rparam_clinic_address As ReportParameter = New ReportParameter("Address", param_clinic_address)
            Dim rparam_clinic_phone As ReportParameter = New ReportParameter("Phone", param_clinic_phone)
            Dim rparam_clinic_reportheader As ReportParameter = New ReportParameter("ReceiptHeader", param_clinic_reportheader)
            Dim rparam_clinic_reportfooter As ReportParameter = New ReportParameter("ReceiptFooter", param_clinic_reportfooter)
            Dim rparam_clinic_logo As ReportParameter = New ReportParameter("ClinicLogoFile", "file:///" + Application.StartupPath + "\Upload\Clinic\" + param_clinic_logo)
            Dim rparam_shared As ReportParameter = New ReportParameter("SharedParameters", SharedParam)
            frmReportViewer.ReportViewer1.LocalReport.EnableExternalImages = True
            frmReportViewer.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {rparam_clinic_name, rparam_clinic_address, rparam_clinic_phone, rparam_clinic_reportheader, rparam_clinic_reportfooter, rparam_clinic_logo, rparam_shared})
            rptDataSource = New ReportDataSource("Voucher", ds.Tables("Voucher"))
            frmReportViewer.ReportViewer1.LocalReport.DataSources.Add(rptDataSource)
            frmReportViewer.Show()
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        End Try
    End Sub

    Public Sub Pharmacy_Bill_View(ByVal Sql As String)
        LoadClinicInformation()
        Dim frmReportViewer As New frmReportViewer
        Dim rptDataSource As New ReportDataSource
        Try
            With frmReportViewer.ReportViewer1.LocalReport
                .ReportPath = "Reports\Invoice.rdlc"
                .DataSources.Clear()
            End With
            Dim ds As New DentalClinicManagementSystem.dsDentalClinic
            Dim da As SqlDataAdapter = New SqlDataAdapter()
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Sql, New SqlConnection(CnString))
            da = New SqlDataAdapter(cmd)
            da.Fill(ds.PharmacyBilling)
            Dim rparam_clinic_name As ReportParameter = New ReportParameter("ClinicName", param_clinic_name)
            Dim rparam_clinic_address As ReportParameter = New ReportParameter("Address", param_clinic_address)
            Dim rparam_clinic_phone As ReportParameter = New ReportParameter("Phone", param_clinic_phone)
            Dim rparam_clinic_reportheader As ReportParameter = New ReportParameter("ReceiptHeader", param_clinic_reportheader)
            Dim rparam_clinic_reportfooter As ReportParameter = New ReportParameter("ReceiptFooter", param_clinic_reportfooter)
            Dim rparam_clinic_logo As ReportParameter = New ReportParameter("ClinicLogoFile", "file:///" + Application.StartupPath + "\Upload\Clinic\" + param_clinic_logo)
            frmReportViewer.ReportViewer1.LocalReport.EnableExternalImages = True
            frmReportViewer.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {rparam_clinic_name, rparam_clinic_address, rparam_clinic_phone, rparam_clinic_reportheader, rparam_clinic_reportfooter, rparam_clinic_logo})
            rptDataSource = New ReportDataSource("PharmacyBilling", ds.Tables("PharmacyBilling"))
            frmReportViewer.ReportViewer1.LocalReport.DataSources.Add(rptDataSource)
            frmReportViewer.Show()
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        End Try
    End Sub
    Public Sub Pharmacy_Sales_List(ByVal Sql As String, ByVal SharedParam As String)
        LoadClinicInformation()
        Dim frmReportViewer As New frmReportViewer
        Dim rptDataSource As New ReportDataSource
        Try
            With frmReportViewer.ReportViewer1.LocalReport
                .ReportPath = "Reports\SalesList.rdlc"
                .DataSources.Clear()
            End With
            Dim ds As New DentalClinicManagementSystem.dsDentalClinic
            Dim da As SqlDataAdapter = New SqlDataAdapter()
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Sql, New SqlConnection(CnString))
            da = New SqlDataAdapter(cmd)
            da.Fill(ds.PharmacyBilling)
            Dim rparam_clinic_name As ReportParameter = New ReportParameter("ClinicName", param_clinic_name)
            Dim rparam_clinic_address As ReportParameter = New ReportParameter("Address", param_clinic_address)
            Dim rparam_clinic_phone As ReportParameter = New ReportParameter("Phone", param_clinic_phone)
            Dim rparam_clinic_reportheader As ReportParameter = New ReportParameter("ReceiptHeader", param_clinic_reportheader)
            Dim rparam_clinic_reportfooter As ReportParameter = New ReportParameter("ReceiptFooter", param_clinic_reportfooter)
            Dim rparam_clinic_logo As ReportParameter = New ReportParameter("ClinicLogoFile", "file:///" + Application.StartupPath + "\Upload\Clinic\" + param_clinic_logo)
            Dim rparam_shared As ReportParameter = New ReportParameter("SharedParameters", SharedParam)
            frmReportViewer.ReportViewer1.LocalReport.EnableExternalImages = True
            frmReportViewer.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {rparam_clinic_name, rparam_clinic_address, rparam_clinic_phone, rparam_clinic_reportheader, rparam_clinic_reportfooter, rparam_clinic_logo, rparam_shared})
            rptDataSource = New ReportDataSource("PharmacyBilling", ds.Tables("PharmacyBilling"))
            frmReportViewer.ReportViewer1.LocalReport.DataSources.Add(rptDataSource)
            frmReportViewer.Show()
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        End Try
    End Sub

    Public Sub TreatmentBill_View(ByVal Sql As String)
        LoadClinicInformation()
        Dim frmReportViewer As New frmReportViewer
        Dim rptDataSource As New ReportDataSource
        Try
            With frmReportViewer.ReportViewer1.LocalReport
                .ReportPath = "Reports\TreatmentBill.rdlc"
                .DataSources.Clear()
            End With
            Dim ds As New DentalClinicManagementSystem.dsDentalClinic
            Dim da As SqlDataAdapter = New SqlDataAdapter()
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Sql, New SqlConnection(CnString))
            da = New SqlDataAdapter(cmd)
            da.Fill(ds.TreatmentProcedureBill)
            Dim rparam_clinic_name As ReportParameter = New ReportParameter("ClinicName", param_clinic_name)
            Dim rparam_clinic_address As ReportParameter = New ReportParameter("Address", param_clinic_address)
            Dim rparam_clinic_phone As ReportParameter = New ReportParameter("Phone", param_clinic_phone)
            Dim rparam_clinic_reportheader As ReportParameter = New ReportParameter("ReceiptHeader", param_clinic_reportheader)
            Dim rparam_clinic_reportfooter As ReportParameter = New ReportParameter("ReceiptFooter", param_clinic_reportfooter)
            Dim rparam_clinic_logo As ReportParameter = New ReportParameter("ClinicLogoFile", "file:///" + Application.StartupPath + "\Upload\Clinic\" + param_clinic_logo)
            frmReportViewer.ReportViewer1.LocalReport.EnableExternalImages = True
            frmReportViewer.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {rparam_clinic_name, rparam_clinic_address, rparam_clinic_phone, rparam_clinic_reportheader, rparam_clinic_reportfooter, rparam_clinic_logo})
            rptDataSource = New ReportDataSource("TreatmentProcedureBill", ds.Tables("TreatmentProcedureBill"))
            frmReportViewer.ReportViewer1.LocalReport.DataSources.Add(rptDataSource)
            frmReportViewer.Show()
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        End Try
    End Sub

    Public Sub PatientForm_View(ByVal Sql As String)
        LoadClinicInformation()
        Dim frmReportViewer As New frmReportViewer
        Dim rptDataSource As New ReportDataSource
        Try
            With frmReportViewer.ReportViewer1.LocalReport
                .ReportPath = "Reports\PatientForm.rdlc"
                .DataSources.Clear()
            End With
            Dim ds As New DentalClinicManagementSystem.dsDentalClinic
            Dim da As SqlDataAdapter = New SqlDataAdapter()
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Sql, New SqlConnection(CnString))
            da = New SqlDataAdapter(cmd)
            da.Fill(ds.PatientForm)
            Dim rparam_clinic_name As ReportParameter = New ReportParameter("ClinicName", param_clinic_name)
            Dim rparam_clinic_address As ReportParameter = New ReportParameter("Address", param_clinic_address)
            Dim rparam_clinic_phone As ReportParameter = New ReportParameter("Phone", param_clinic_phone)
            Dim rparam_clinic_reportheader As ReportParameter = New ReportParameter("ReceiptHeader", param_clinic_reportheader)
            Dim rparam_clinic_reportfooter As ReportParameter = New ReportParameter("ReceiptFooter", param_clinic_reportfooter)
            Dim rparam_clinic_logo As ReportParameter = New ReportParameter("ClinicLogoFile", "file:///" + Application.StartupPath + "\Upload\Clinic\" + param_clinic_logo)
            frmReportViewer.ReportViewer1.LocalReport.EnableExternalImages = True
            frmReportViewer.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {rparam_clinic_name, rparam_clinic_address, rparam_clinic_phone, rparam_clinic_reportheader, rparam_clinic_reportfooter, rparam_clinic_logo})
            rptDataSource = New ReportDataSource("PatientForm", ds.Tables("PatientForm"))
            frmReportViewer.ReportViewer1.LocalReport.DataSources.Add(rptDataSource)
            frmReportViewer.Show()
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        End Try
    End Sub

    Public Sub SickLeaveForm_View(ByVal Sql As String)
        LoadClinicInformation()
        Dim frmReportViewer As New frmReportViewer
        Dim rptDataSource As New ReportDataSource
        Try
            With frmReportViewer.ReportViewer1.LocalReport
                .ReportPath = "Reports\SickLeave.rdlc"
                .DataSources.Clear()
            End With
            Dim ds As New DentalClinicManagementSystem.dsDentalClinic
            Dim da As SqlDataAdapter = New SqlDataAdapter()
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Sql, New SqlConnection(CnString))
            da = New SqlDataAdapter(cmd)
            da.Fill(ds.TrtmntSickLeave)
            Dim rparam_clinic_name As ReportParameter = New ReportParameter("ClinicName", param_clinic_name)
            Dim rparam_clinic_address As ReportParameter = New ReportParameter("Address", param_clinic_address)
            Dim rparam_clinic_phone As ReportParameter = New ReportParameter("Phone", param_clinic_phone)
            Dim rparam_clinic_reportheader As ReportParameter = New ReportParameter("ReceiptHeader", param_clinic_reportheader)
            Dim rparam_clinic_reportfooter As ReportParameter = New ReportParameter("ReceiptFooter", param_clinic_reportfooter)
            Dim rparam_clinic_logo As ReportParameter = New ReportParameter("ClinicLogoFile", "file:///" + Application.StartupPath + "\Upload\Clinic\" + param_clinic_logo)
            frmReportViewer.ReportViewer1.LocalReport.EnableExternalImages = True
            frmReportViewer.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {rparam_clinic_name, rparam_clinic_address, rparam_clinic_phone, rparam_clinic_reportheader, rparam_clinic_reportfooter, rparam_clinic_logo})
            rptDataSource = New ReportDataSource("TrtmntSickLeave", ds.Tables("TrtmntSickLeave"))
            frmReportViewer.ReportViewer1.LocalReport.DataSources.Add(rptDataSource)
            frmReportViewer.Show()
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        End Try
    End Sub


    Public Sub TreatmentBillList_View(ByVal Sql As String, ByVal SharedParam As String)
        LoadClinicInformation()
        Dim frmReportViewer As New frmReportViewer
        Dim rptDataSource As New ReportDataSource
        Try
            With frmReportViewer.ReportViewer1.LocalReport
                .ReportPath = "Reports\TreatmentBillList.rdlc"
                .DataSources.Clear()
            End With
            Dim ds As New DentalClinicManagementSystem.dsDentalClinic
            Dim da As SqlDataAdapter = New SqlDataAdapter()
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Sql, New SqlConnection(CnString))
            da = New SqlDataAdapter(cmd)
            da.Fill(ds.Treatment)
            Dim rparam_clinic_name As ReportParameter = New ReportParameter("ClinicName", param_clinic_name)
            Dim rparam_clinic_address As ReportParameter = New ReportParameter("Address", param_clinic_address)
            Dim rparam_clinic_phone As ReportParameter = New ReportParameter("Phone", param_clinic_phone)
            Dim rparam_clinic_reportheader As ReportParameter = New ReportParameter("ReceiptHeader", param_clinic_reportheader)
            Dim rparam_clinic_reportfooter As ReportParameter = New ReportParameter("ReceiptFooter", param_clinic_reportfooter)
            Dim rparam_clinic_logo As ReportParameter = New ReportParameter("ClinicLogoFile", "file:///" + Application.StartupPath + "\Upload\Clinic\" + param_clinic_logo)
            Dim rparam_shared As ReportParameter = New ReportParameter("SharedParameters", SharedParam)
            frmReportViewer.ReportViewer1.LocalReport.EnableExternalImages = True
            frmReportViewer.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {rparam_clinic_name, rparam_clinic_address, rparam_clinic_phone, rparam_clinic_reportheader, rparam_clinic_reportfooter, rparam_clinic_logo, rparam_shared})
            rptDataSource = New ReportDataSource("Treatment", ds.Tables("Treatment"))
            frmReportViewer.ReportViewer1.LocalReport.DataSources.Add(rptDataSource)
            frmReportViewer.Show()
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        End Try
    End Sub


End Module
