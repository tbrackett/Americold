Imports System
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO
Imports System.Security

Public Class frmLogin

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOK.Click
        Dim byHashedData As Byte()
        Dim encoder As New UTF8Encoding()
        Dim md5Hasher As New MD5CryptoServiceProvider
        Dim strPW As String = txtPassword.Text
        Dim accountName As String = cmbUserName.SelectedItem.ToString()
        Dim accountFilePath As String = "C:\Users\TJB\Google Drive\Work\Work-Program\Accounts"
        Dim accountFileString As String
        Dim enteredInfoString As String

        'Gets entered account info as hash
        byHashedData = md5Hasher.ComputeHash(encoder.GetBytes(strPW & accountName))
        enteredInfoString = GetHash(byHashedData)

        'Gets account info on file as hash
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(accountFilePath)
            accountFileString = GetFileHash(foundFile)


            If enteredInfoString = accountFileString Then
                MessageBox.Show("Login successful.")
                frmMain.Show()
                Me.Close()
            Else
                MessageBox.Show("Incorrect account name and/or password.")
                txtPassword.Text = ""
            End If
        Next

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub mnuCreateAccount_Click(sender As Object, e As EventArgs) Handles mnuCreateAccount.Click
        frmCreateAccount.Show()
        Me.Hide()
    End Sub

    Private Sub mnuChangePW_Click(sender As Object, e As EventArgs)
        frmChangePW.Show()
        Me.Hide()
    End Sub

    Private Sub mnuRecoverPW_Click(sender As Object, e As EventArgs)
        frmRecoverPW.Show()
        Me.Hide()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.Hide()

        Dim path As String = "C:\Users\TJB\Google Drive\Work\Work-Program\Accounts"
        Dim accountName As String

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(path)
            accountName = foundFile.Remove(0, path.Length).ToString
            cmbUserName.Items.Add(accountName)
        Next

    End Sub

    Public Function GetFileHash(ByVal filePath As String)
        Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
        Dim f As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)

        f = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        md5.ComputeHash(f)
        f.Close()

        Dim hash As Byte() = md5.Hash
        Dim buff As StringBuilder = New StringBuilder
        Dim hashByte As Byte

        For Each hashByte In hash
            buff.Append(String.Format("{0:X2}", hashByte))
        Next

        Dim md5string As String
        md5string = buff.ToString()

        Return md5string

    End Function

    Public Function GetHash(ByVal enteredInfo As Byte())
        Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider

        md5.ComputeHash(enteredInfo)

        Dim hash As Byte() = md5.Hash
        Dim buff As StringBuilder = New StringBuilder
        Dim hashByte As Byte

        For Each hashByte In hash
            buff.Append(String.Format("{0:X2}", hashByte))
        Next

        Dim md5string As String
        md5string = buff.ToString()

        Return md5string
    End Function
End Class
