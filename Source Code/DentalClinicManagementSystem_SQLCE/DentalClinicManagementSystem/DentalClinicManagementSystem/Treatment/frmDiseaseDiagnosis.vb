Imports System.ComponentModel

Public Class frmDiseaseDiagnosis
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtID.Text = ""
        txtDiseaseName.Text = ""
        btnSave.Text = "SAVE"
        LoadData()
    End Sub
    Private Sub LoadData()
        FillDataGrid("SELECT        DISEASE_DIAGNOSIS_ID, Disease  FROM            DiseaseDiagnosis", DataGridView1)
    End Sub

    Private Sub frmDiseaseDiagnosis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
        LoadData()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtDiseaseName.Text = "" Then
            ErrorProvider1.SetError(txtDiseaseName, "Mandatory field.")
        Else
            ErrorProvider1.Clear()
            If btnSave.Text = "SAVE" Then
                ExecuteSQLQuery(" INSERT INTO  DiseaseDiagnosis (Disease) VALUES ('" + str_repl(txtDiseaseName.Text) + "')")
                LoadData()
            ElseIf btnSave.Text = "UPDATE" Then
                ExecuteSQLQuery(" UPDATE   DiseaseDiagnosis SET Disease= '" + str_repl(txtDiseaseName.Text) + "' WHERE DISEASE_DIAGNOSIS_ID=" & txtID.Text & " ")
                LoadData()
            End If
            btnSave.Text = "SAVE"
            btnReset.PerformClick()
            MsgBox("Record has been saved successfully.", MsgBoxStyle.Information, "Information")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 Then
            If MsgBox("Are you sure you want to edit this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                ExecuteSQLQuery(" SELECT * FROM DiseaseDiagnosis WHERE  DISEASE_DIAGNOSIS_ID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                If sqlDT.Rows.Count > 0 Then
                    txtID.Text = sqlDT.Rows(0)("DISEASE_DIAGNOSIS_ID")
                    txtDiseaseName.Text = sqlDT.Rows(0)("Disease")
                    btnSave.Text = "UPDATE"
                End If
            End If
        ElseIf e.ColumnIndex = 1 Then
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                ExecuteSQLQuery("DELETE FROM DiseaseDiagnosis WHERE  DISEASE_DIAGNOSIS_ID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                LoadData()
                MsgBox("Record deleted successfully.", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmDiseaseDiagnosis_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class