Imports System.ComponentModel

Public Class frmDatabaseConnectionSetting
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ErrorProvider1.Clear()
        If txtConnectionString.Text = "" Then
            ErrorProvider1.SetError(txtConnectionString, "Connection String")
            txtConnectionString.Focus()
        Else
            Dim msg As String
            msg = "Confirm that the server connection string are correct."
            msg = msg & Chr(10) & " "
            msg = msg & Chr(10) & "Are you sure want to save?"
            If MsgBox(msg, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Server Properties") = MsgBoxResult.Yes Then
                My.Settings.DB_CN_NODE = txtConnectionString.Text
                My.Settings.Save()
                MsgBox("Congratulations!", MsgBoxStyle.Information, "Confirmation!")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmDatabaseConnectionSetting_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

    Private Sub frmDatabaseConnectionSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtConnectionString.Text = My.Settings.DB_CN_NODE
    End Sub
End Class