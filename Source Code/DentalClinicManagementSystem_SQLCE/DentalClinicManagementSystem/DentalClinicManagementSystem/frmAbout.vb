Public Class frmAbout
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("mailto:linkbirdtech@gmail.com")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://linkbirdtech.com/")
    End Sub
End Class