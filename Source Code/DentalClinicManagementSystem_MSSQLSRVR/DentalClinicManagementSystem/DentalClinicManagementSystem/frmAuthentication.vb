Imports System.ComponentModel
Imports System.Reflection

Public Class frmAuthentication
    Dim xcountx As Integer
    Private Sub frmAuthentication_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrEmpty(txtUserName.Text) Then
            ErrorProvider2.Clear()
            ErrorProvider1.SetError(txtUserName, "Required")
        ElseIf String.IsNullOrEmpty(txtPassword.Text) Then
            ErrorProvider1.Clear()
            ErrorProvider2.SetError(txtPassword, "Required")
        Else
            sqlSTR = "SELECT * FROM ApplicationUsers WHERE UserName='" & str_repl(txtUserName.Text) & "' AND Password ='" & str_repl(txtPassword.Text) & "' "
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                xUserName = sqlDT.Rows(0)("UserName")
                xUserPassword = sqlDT.Rows(0)("Password")
                xUser_ID = sqlDT.Rows(0)("UserID")
                frmMDIParent.LogOffToolStripMenuItem.Text = "Log Off  ||  " & xUserName
                txtUserName.Text = ""
                txtPassword.Text = ""
                With frmMDIParent
                    .LogOffToolStripMenuItem.Text = "Log Off : " & xUserName
                    .Show()
                End With
                Me.Visible = False
            Else
                MsgBox("You have no permission to use this system, for further details please contact to your top managment system.", MsgBoxStyle.Information, "Warning.")
                xcountx = xcountx + 1
                If xcountx >= 3 Then
                    MsgBox("You have reach the maximum time of login !!", MsgBoxStyle.Critical, "Error.")
                    End
                End If
                Exit Sub
            End If
        End If
    End Sub

    Private Sub frmAuthentication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ExecuteSQLQuery("SELECT      *    FROM            ApplicationUsers")
            If Not sqlDT.Rows.Count > 0 Then

                sqlSTR = " INSERT INTO ApplicationUsers (FullName, UserName, Password, ContactNo, UserType, JoiningDate, RegistrationDate, LastLogonDateTime, Photo_File_Name, Designation) VALUES  " &
                         "( 'System Administrator', 'admin', '12345', '123-456-789', 'Administrator',  " &
                         " '" & Format(Now, "MM/dd/yyyy") & "', '" & Format(Now, "MM/dd/yyyy") & "', '" & Format(Now, "MM/dd/yyyy") & "', '', 'Administrator' ) "
                ExecuteSQLQuery(sqlSTR)
                ExecuteSQLQuery("SELECT  UserID FROM     ApplicationUsers  ORDER BY UserID DESC")
                Dim USER_ID As Double = sqlDT.Rows(0)("UserID")

                Try
                    Dim projectA = Assembly.Load("DentalClinicManagementSystem")
                    For Each t In projectA.GetTypes
                        If t.BaseType Is GetType(Form) Then
                            Dim emptyCtor = t.GetConstructor(Type.EmptyTypes)
                            If emptyCtor IsNot Nothing Then
                                Dim f = CType(emptyCtor.Invoke(New Object() {}), Form)
                                sqlSTR = "INSERT INTO UserPermission (FormCaption, FormName, UserID, Active) VALUES ('" & str_repl(f.Text) & "', '" + str_repl(f.Name) + "', " & num_fltr(USER_ID) & ", 1)"
                                ExecuteSQLQuery(sqlSTR)
                            End If
                        End If
                    Next
                Catch ex As Exception
                    MessageBox.Show("Error : " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        End Try
    End Sub
End Class
