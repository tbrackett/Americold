Imports System
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO
Imports System.Security

Public Class frmChangePW


    Public Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim accountName As String = txtPWChangeUserName.Text
        Dim strPw As String = txtOldPW.Text
        Dim byHashedData As Byte()
        Dim encoder As New UTF8Encoding()
        Dim md5Hasher As New MD5CryptoServiceProvider
        Dim enteredInfoString As String
        Dim accountFilePath As String = "C:\Users\TJ\Google Drive\Work\Americold VB Project\Accounts\"
        Dim accountFileString As String

        byHashedData = md5Hasher.ComputeHash(encoder.GetBytes(strPw & accountName))
        enteredInfoString = frmLogin.GetHash(byHashedData)

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(accountFilePath)
            accountFileString = frmLogin.GetFileHash(foundFile)
            'Find a way to close the file to allow for writing
            If enteredInfoString = accountFileString Then
                If txtNewPW.Text = txtNewPW2.Text Then
                    File.WriteAllText(foundFile, enteredInfoString)
                    MessageBox.Show("Your new password is " & strPw)
                    Me.Close()
                Else
                    MessageBox.Show("The passwords do not match.")
                End If

            Else
                MessageBox.Show("Incorrect account name and/or password.")
                txtPWChangeUserName.Text = ""
                txtOldPW.Text = ""
                txtNewPW.Text = ""
                txtNewPW2.Text = ""
            End If
        Next

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
