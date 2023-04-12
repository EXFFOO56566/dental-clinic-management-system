Imports System.IO
Public Class frmProductInformation
    Dim fileExtension As String = ".png"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmProductCategory.MdiParent = frmMDIParent
        frmProductCategory.Show()
    End Sub

    Private Sub frmProductInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
        FillComboBox("SELECT   CATEGORY_ID, CATEGORY_NAME  FROM      ProductCategory", "CATEGORY_ID", "CATEGORY_NAME", cmbCategory)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtBarcode.Text = ""
        txtGenericName.Text = ""
        txtProductID.Text = ""
        txtProductName.Text = ""
        txtPurchasePrice.Text = ""
        txtQuantity.Text = ""
        txtSalesPrice.Text = ""
        dtpExpirationDate.Value = Now
        dtpManufactureDate.Text = Now
        btnSave.Text = "SAVE"
        fileExtension = ".png"
        OpenFileDialog1.FileName = ""
        txtUOM.Text = ""
        ProductImage.Image = DentalClinicManagementSystem.My.Resources.no_images
    End Sub

    Private Sub lnkBrowse_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkBrowse.LinkClicked
        OpenFileDialog1.Title = "Browse Image"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Image Files |*.jpg;*.jpeg;*.gif;*.bmp;*.png;"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ProductImage.ImageLocation = OpenFileDialog1.FileName
            fileExtension = Path.GetExtension(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub UploadProductImages(ByVal PRODUCT_ID As Double)
        Dim DestPath As String = Application.StartupPath + "\Upload\Product\"
        If Not Directory.Exists(DestPath) Then
            Directory.CreateDirectory(DestPath)
        End If
        System.IO.File.Delete(DestPath + "\" + PRODUCT_ID.ToString + fileExtension)
        Dim ImageFileName As String = DestPath + "\" + OpenFileDialog1.SafeFileName
        ProductImage.Image.Save(ImageFileName, System.Drawing.Imaging.ImageFormat.Png)
        System.IO.File.Move(DestPath + "\" + OpenFileDialog1.SafeFileName, DestPath + "\" + PRODUCT_ID.ToString + fileExtension)
        ExecuteSQLQuery(" UPDATE ProductInformation SET Photo_File_Name='" + (PRODUCT_ID.ToString + fileExtension) + "'  WHERE PRODUCT_ID=" & PRODUCT_ID & " ")
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtProductName.Text = "" Or cmbCategory.SelectedValue Is Nothing Or cmbCategory.SelectedIndex = -1 Or txtUOM.Text = "" Or txtQuantity.Text = "" Or txtPurchasePrice.Text = "" Or txtSalesPrice.Text = "" Then
            ErrorProvider1.SetError(txtProductName, "Mandatory field.")
            ErrorProvider1.SetError(cmbCategory, "Mandatory field.")
            ErrorProvider1.SetError(txtUOM, "Mandatory field.")
            ErrorProvider1.SetError(txtQuantity, "Mandatory field.")
            ErrorProvider1.SetError(txtPurchasePrice, "Mandatory field.")
            ErrorProvider1.SetError(txtSalesPrice, "Mandatory field.")
        ElseIf Not IsNumeric(txtQuantity.Text) Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(txtQuantity, "Mandatory field.")
        ElseIf Not IsNumeric(txtPurchasePrice.Text) Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(txtPurchasePrice, "Mandatory field.")
        ElseIf Not IsNumeric(txtSalesPrice.Text) Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(txtSalesPrice, "Mandatory field.")
        Else
            ErrorProvider1.Clear()
            If btnSave.Text = "SAVE" Then
                ExecuteSQLQuery(" INSERT INTO ProductInformation (ProductName, GenericName, CATEGORY_ID, ManufactureDate, ExpirationDate, Barcode, UOM, Quantity, PurchasePrice, SalesPrice) VALUES  " &
                                " ( '" + str_repl(txtProductName.Text) + "', '" + str_repl(txtGenericName.Text) + "', " & cmbCategory.SelectedValue & ", '" & Format(dtpManufactureDate.Value, "MM/dd/yyyy") & "', " &
                                " '" & Format(dtpExpirationDate.Value, "MM/dd/yyyy") & "', '" + str_repl(txtBarcode.Text) + "', '" + str_repl(txtUOM.Text) + "', " & txtQuantity.Text & ", " & txtPurchasePrice.Text & ", " & txtSalesPrice.Text & " )")
                ExecuteSQLQuery("SELECT  PRODUCT_ID FROM     ProductInformation  ORDER BY PRODUCT_ID DESC")
                Dim PRODUCT_ID As Double = sqlDT.Rows(0)("PRODUCT_ID")
                If Not OpenFileDialog1.FileName = "" Then
                    UploadProductImages(PRODUCT_ID)
                End If
                btnReset.PerformClick()
                MsgBox("Record has been saved successfully.", MsgBoxStyle.Information, "Information")
            ElseIf btnSave.Text = "UPDATE" Then
                ErrorProvider1.Clear()
                ExecuteSQLQuery(" UPDATE ProductInformation SET  ProductName='" + str_repl(txtProductName.Text) + "', GenericName='" + str_repl(txtGenericName.Text) + "', ManufactureDate='" & Format(dtpManufactureDate.Value, "MM/dd/yyyy") & "', ExpirationDate='" & Format(dtpExpirationDate.Value, "MM/dd/yyyy") & "',  " &
                                " Barcode='" + str_repl(txtBarcode.Text) + "', UOM='" + str_repl(txtUOM.Text) + "', Quantity=" & txtQuantity.Text & ", PurchasePrice=" & txtPurchasePrice.Text & ", SalesPrice=" & txtSalesPrice.Text & ", CATEGORY_ID = " & cmbCategory.SelectedValue & " " &
                                " WHERE        (PRODUCT_ID = " & txtProductID.Text & ") ")
                If Not OpenFileDialog1.FileName = "" Then
                    UploadProductImages(txtProductID.Text)
                End If
                btnReset.PerformClick()
                MsgBox("Record has been saved successfully.", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub
End Class