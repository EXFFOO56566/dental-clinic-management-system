Public Class frmProductList
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub LoadData()
        sqlSTR = " SELECT        ProductInformation.PRODUCT_ID, ProductInformation.ProductName, ProductInformation.GenericName, ProductCategory.CATEGORY_NAME, ProductInformation.ManufactureDate, ProductInformation.ExpirationDate,  " &
                 " ProductInformation.Barcode, ProductInformation.UOM, ProductInformation.Quantity, ProductInformation.PurchasePrice, ProductInformation.SalesPrice " &
                 " FROM            ProductInformation LEFT OUTER JOIN  ProductCategory ON ProductInformation.CATEGORY_ID = ProductCategory.CATEGORY_ID "
        FillDataGrid(sqlSTR, DataGridView1)
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            lblCount.Text = sqlDT.Rows.Count.ToString & " Record Found."
        Else
            lblCount.Text = "No Record Found."
        End If
    End Sub

    Private Sub frmProductList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
        LoadData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData()
    End Sub

    Private Sub txtCriteria_TextChanged(sender As Object, e As EventArgs) Handles txtCriteria.TextChanged
        If cmbParameter.Text = "" Then
            ErrorProvider1.SetError(cmbParameter, "Mandatory field.")
            LoadData()
        ElseIf txtCriteria.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider2.SetError(txtCriteria, "Mandatory field.")
            LoadData()
        Else
            ErrorProvider1.Clear()
            ErrorProvider2.Clear()
            sqlSTR = " SELECT        ProductInformation.PRODUCT_ID, ProductInformation.ProductName, ProductInformation.GenericName, ProductCategory.CATEGORY_NAME, ProductInformation.ManufactureDate, ProductInformation.ExpirationDate,  " &
                     " ProductInformation.Barcode, ProductInformation.UOM, ProductInformation.Quantity, ProductInformation.PurchasePrice, ProductInformation.SalesPrice " &
                     " FROM            ProductInformation LEFT OUTER JOIN  ProductCategory ON ProductInformation.CATEGORY_ID = ProductCategory.CATEGORY_ID " &
                     " WHERE   (ProductInformation." + cmbParameter.Text + " LIKE '%" + str_repl(txtCriteria.Text) + "%') "
            FillDataGrid(sqlSTR, DataGridView1)
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                lblCount.Text = sqlDT.Rows.Count.ToString & " Record Found."
            Else
                lblCount.Text = "No Record Found."
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 Then
            If MsgBox("Are you sure you want to edit this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                With frmProductInformation
                    .MdiParent = frmMDIParent
                    .Show()
                    ExecuteSQLQuery(" SELECT * FROM ProductInformation WHERE  PRODUCT_ID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                    If sqlDT.Rows.Count > 0 Then
                        .txtBarcode.Text = sqlDT.Rows(0)("Barcode")
                        .txtGenericName.Text = sqlDT.Rows(0)("GenericName")
                        .txtProductID.Text = sqlDT.Rows(0)("PRODUCT_ID")
                        .txtProductName.Text = sqlDT.Rows(0)("ProductName")
                        .txtPurchasePrice.Text = sqlDT.Rows(0)("PurchasePrice")
                        .txtQuantity.Text = sqlDT.Rows(0)("Quantity")
                        .txtSalesPrice.Text = sqlDT.Rows(0)("SalesPrice")
                        .dtpExpirationDate.Value = sqlDT.Rows(0)("ExpirationDate")
                        .dtpManufactureDate.Text = sqlDT.Rows(0)("ManufactureDate")
                        .cmbCategory.SelectedValue = sqlDT.Rows(0)("CATEGORY_ID")
                        .txtUOM.Text = sqlDT.Rows(0)("UOM")
                        .btnSave.Text = "UPDATE"
                        Try
                            .ProductImage.ImageLocation = Application.StartupPath + "\Upload\Product\" + sqlDT.Rows(0)("Photo_File_Name")
                        Catch ex As Exception

                        End Try
                        .btnSave.Text = "UPDATE"
                    End If
                End With
            End If
        ElseIf e.ColumnIndex = 1 Then
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                ExecuteSQLQuery("DELETE FROM ProductInformation WHERE  PRODUCT_ID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                LoadData()
                MsgBox("Record deleted successfully.", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub
End Class