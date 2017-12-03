Imports System
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO
Imports System.Security
Public Class frmCreateAccount

    Private Sub btnOKCreate_Click(sender As Object, e As EventArgs) Handles btnOKCreate.Click
        Dim fileName As String
        Dim firstName As String
        Dim lastName As String
        Dim byHashedData As Byte()
        Dim encoder As New UTF8Encoding()
        Dim md5Hasher As New MD5CryptoServiceProvider
        Dim strPW As String
        Dim username As String


        firstName = txtCAFirstName.Text.First
        firstName = firstName.ToLower
        lastName = txtCALastName.Text.ToLower
        username = txtCAUsername.Text
        fileName = username
        Dim path As String = "C:\Users\TJB\Documents\Visual Studio 2015\Projects\Americold\Employee Accounts"
        Dim fs As FileStream = File.Create(path & "\" & fileName)

        If txtCAPWCreate.Text = txtCAPWConfirm.Text Then
            strPW = txtCAPWCreate.Text
            byHashedData = md5Hasher.ComputeHash(encoder.GetBytes(strPW & fileName))
            fs.Write(byHashedData, 0, byHashedData.Length)
            fs.Close()
            MessageBox.Show("Your account name is " & username & " your password is " & strPW & ".")
            frmMain.Show()
            Me.Close()
        ElseIf 
        Else
            MessageBox.Show("The passwords you have entered do not match.")
            txtCAFirstName.Text = ""
            txtCALastName.Text = ""
            txtCAPWCreate.Text = ""
            txtCAPWConfirm.Text = ""
        End If

    End Sub

    Private Sub btnCancelCreate_Click(sender As Object, e As EventArgs) Handles btnCancelCreate.Click
        frmMain.Show()
        Me.Close()
    End Sub
End Class