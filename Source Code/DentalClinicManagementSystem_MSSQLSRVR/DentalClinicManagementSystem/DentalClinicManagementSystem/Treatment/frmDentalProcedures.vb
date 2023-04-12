Public Class frmDentalProcedures
    Private Sub frmDentalProcedures_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub LoadData()
        FillDataGrid("SELECT   PROCEDURES_ID, DENTAL_PROCEDURES, PRICE  FROM    DentalProcedures", DataGridView1)
    End Sub

    Private Sub frmDentalProcedures_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
        LoadData()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtID.Text = ""
        txtProcedureName.Text = ""
        txtPrice.Value = "0"
        LoadData()
        btnSave.Text = "SAVE"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtProcedureName.Text = "" Then
            ErrorProvider1.SetError(txtProcedureName, "Mandatory field.")
        Else
            ErrorProvider1.Clear()
            If btnSave.Text = "SAVE" Then
                ExecuteSQLQuery(" INSERT INTO  DentalProcedures (DENTAL_PROCEDURES, PRICE) VALUES ('" + str_repl(txtProcedureName.Text) + "', " & txtPrice.Value & ")")
                LoadData()
            ElseIf btnSave.Text = "UPDATE" Then
                ExecuteSQLQuery(" UPDATE   DentalProcedures SET DENTAL_PROCEDURES= '" + str_repl(txtProcedureName.Text) + "', PRICE= " & txtPrice.Value & "  WHERE PROCEDURES_ID=" & txtID.Text & " ")
                LoadData()
            End If
            btnReset.PerformClick()
            MsgBox("Record has been saved successfully.", MsgBoxStyle.Information, "Information")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 Then
            If MsgBox("Are you sure you want to edit this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                ExecuteSQLQuery(" SELECT * FROM DentalProcedures WHERE  PROCEDURES_ID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                If sqlDT.Rows.Count > 0 Then
                    txtID.Text = sqlDT.Rows(0)("PROCEDURES_ID")
                    txtProcedureName.Text = sqlDT.Rows(0)("DENTAL_PROCEDURES")
                    txtPrice.Value = sqlDT.Rows(0)("PRICE")
                    btnSave.Text = "UPDATE"
                End If
            End If
        ElseIf e.ColumnIndex = 1 Then
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                ExecuteSQLQuery("DELETE FROM DentalProcedures WHERE  PROCEDURES_ID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                LoadData()
                MsgBox("Record deleted successfully.", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub
End Class