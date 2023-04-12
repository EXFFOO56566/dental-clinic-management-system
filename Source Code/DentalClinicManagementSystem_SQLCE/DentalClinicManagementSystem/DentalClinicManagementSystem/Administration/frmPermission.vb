Imports System.Reflection
Public Class frmPermission
    Private Sub frmPermission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If

        FillComboBox("SELECT  UserID,  UserName  FROM   ApplicationUsers", "UserID", "UserName", cmbUsers)
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        If cmbUsers.SelectedValue Is Nothing Or cmbUsers.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cmbUsers, "Please select a username.")
            FillDataGrid("SELECT  FormCaption, FormName, Active  FROM    UserPermission   WHERE  (UserID = 0)", DataGridView1)
        Else
            ErrorProvider1.Clear()
            ExecuteSQLQuery(" SELECT  * FROM   UserPermission  WHERE   (UserID = '" & cmbUsers.SelectedValue & "') ")
            If sqlDT.Rows.Count > 0 Then
                LoadUserPermission(cmbUsers.SelectedValue)
            Else
                Try
                    Dim projectA = Assembly.Load("DentalClinicManagementSystem")
                    For Each t In projectA.GetTypes
                        If t.BaseType Is GetType(Form) Then
                            Dim emptyCtor = t.GetConstructor(Type.EmptyTypes)
                            If emptyCtor IsNot Nothing Then
                                Dim f = CType(emptyCtor.Invoke(New Object() {}), Form)
                                sqlSTR = "INSERT INTO UserPermission (FormCaption, FormName, UserID, Active) VALUES ('" & str_repl(f.Text) & "', '" + str_repl(f.Name) + "', " & cmbUsers.SelectedValue & ", 1)"
                                ExecuteSQLQuery(sqlSTR)
                            End If
                        End If
                    Next
                Catch ex As Exception
                    MessageBox.Show("Error : " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                LoadUserPermission(cmbUsers.SelectedValue)
            End If
        End If
    End Sub
    Private Sub LoadUserPermission(ByVal UserID As Double)
        ExecuteSQLQuery("DELETE UserPermission WHERE (FormName = 'frmReportViewer') ")
        ExecuteSQLQuery("DELETE UserPermission WHERE (FormName = 'frmSplashScreen') ")
        ExecuteSQLQuery("DELETE UserPermission WHERE (FormName = 'frmAbout') ")
        ExecuteSQLQuery("DELETE UserPermission WHERE (FormName = 'frmMDIParent') ")
        ExecuteSQLQuery("DELETE UserPermission WHERE (FormName = 'frmDatabaseConnectionSetting') ")
        FillDataGrid("SELECT  FormCaption, FormName, Active  FROM    UserPermission   WHERE  (UserID = " & UserID & ") ORDER BY FormCaption ", DataGridView1)
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If DataGridView1.RowCount > 0 Then
            For Each Row As DataGridViewRow In DataGridView1.Rows
                If Row.Cells("chk").Value IsNot Nothing Then
                    If CBool(Row.Cells("chk").Value) = True Then
                        Dim FormName As String = Row.Cells("Column2").Value.ToString
                        ExecuteSQLQuery("UPDATE UserPermission SET  Active = 1  WHERE  (UserID = '" & cmbUsers.SelectedValue & "') AND (FormName = '" & str_repl(FormName) & "')")
                    End If
                    If CBool(Row.Cells("chk").Value) = False Then
                        Dim FormName As String = Row.Cells("Column2").Value.ToString
                        ExecuteSQLQuery("UPDATE UserPermission SET  Active = 0  WHERE  (UserID = '" & cmbUsers.SelectedValue & "') AND (FormName = '" & str_repl(FormName) & "')")
                    End If
                End If
            Next
            MessageBox.Show("Permission has been updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Permission Empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class