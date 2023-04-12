Public Class frmProductCategory
    Private Sub frmProductCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
        LoadData()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ErrorProvider1.Clear()
        txtCategoryID.Text = ""
        txtCategoryName.Text = ""
        btnSave.Text = "SAVE"
        LoadData()
    End Sub
    Private Sub LoadData()
        FillDataGrid("SELECT  CATEGORY_ID, CATEGORY_NAME  FROM   ProductCategory", DataGridView1)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtCategoryName.Text = "" Then
            ErrorProvider1.SetError(txtCategoryName, "Mandatory field.")
        Else
            ErrorProvider1.Clear()
            If btnSave.Text = "SAVE" Then
                ExecuteSQLQuery(" INSERT INTO  ProductCategory (CATEGORY_NAME) VALUES ('" + str_repl(txtCategoryName.Text) + "')")
                LoadData()
            ElseIf btnSave.Text = "UPDATE" Then
                ExecuteSQLQuery(" UPDATE   ProductCategory SET CATEGORY_NAME= '" + str_repl(txtCategoryName.Text) + "' WHERE CATEGORY_ID=" & txtCategoryID.Text & " ")
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
                ExecuteSQLQuery(" SELECT * FROM ProductCategory WHERE  CATEGORY_ID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                If sqlDT.Rows.Count > 0 Then
                    txtCategoryID.Text = sqlDT.Rows(0)("CATEGORY_ID")
                    txtCategoryName.Text = sqlDT.Rows(0)("CATEGORY_NAME")
                    btnSave.Text = "UPDATE"
                End If
            End If
        ElseIf e.ColumnIndex = 1 Then
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                ExecuteSQLQuery("DELETE FROM ProductCategory WHERE  CATEGORY_ID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                LoadData()
                MsgBox("Record deleted successfully.", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub
End Class